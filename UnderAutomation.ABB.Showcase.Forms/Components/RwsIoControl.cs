using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using UnderAutomation.ABB;
using UnderAutomation.ABB.Rws.Data;

public partial class RwsIoControl : UserControl, IUserControl
{
    // Entry added to an optional filter combo box to mean "do not filter on this criteria"
    private const string Any = "(any)";

    private AbbController _robot;

    public RwsIoControl(AbbController robot)
    {
        // Complex types shown in a PropertyGrid have to be expandable and not editable
        MakeExpandableAndReadOnly(typeof(IoNetworkItem));
        MakeExpandableAndReadOnly(typeof(IoNetworkItem[]));
        MakeExpandableAndReadOnly(typeof(IoDeviceItem));
        MakeExpandableAndReadOnly(typeof(IoDeviceItem[]));
        MakeExpandableAndReadOnly(typeof(IoSignalItem));
        MakeExpandableAndReadOnly(typeof(IoSignalItem[]));
        MakeExpandableAndReadOnly(typeof(IoNetworkConfiguration));
        MakeExpandableAndReadOnly(typeof(IoDeviceConfiguration));
        MakeExpandableAndReadOnly(typeof(IoSignalConfiguration));
        MakeExpandableAndReadOnly(typeof(IoDeviceUpgradeInfo));
        MakeExpandableAndReadOnly(typeof(IoFirmwareModuleInfo));
        MakeExpandableAndReadOnly(typeof(IoFirmwareModuleInfo[]));
        MakeExpandableAndReadOnly(typeof(string[]));

        _robot = robot;
        InitializeComponent();

        // Enum arguments are selected in a combo box. Unknown is only ever an answer of the
        // controller, it cannot be sent back to it, so it is left out of every combo.
        FillCombo(cboSetNetworkStateLogicalState, new object[] { IoNetworkLogicalState.Started, IoNetworkLogicalState.Stopped });
        FillCombo(cboSetDeviceStateLogicalState, new object[] { IoDeviceLogicalState.Enabled, IoDeviceLogicalState.Disabled });
        FillCombo(cboSetNetworkConfigurationType, Enum.GetValues(typeof(IoNetworkConfigurationType)));

        // Optional search criteria: the first entry stands for the null value
        FillCombo(cboSearchNetworksPhysicalState, new object[] { Any, IoNetworkPhysicalState.Halted, IoNetworkPhysicalState.Running, IoNetworkPhysicalState.Error, IoNetworkPhysicalState.Startup, IoNetworkPhysicalState.Init });
        FillCombo(cboSearchDevicesLogicalState, new object[] { Any, IoDeviceLogicalState.Enabled, IoDeviceLogicalState.Disabled });
        FillCombo(cboSearchSignalsType, new object[] { Any, IoSignalType.DigitalOutput, IoSignalType.DigitalInput, IoSignalType.AnalogOutput, IoSignalType.AnalogInput, IoSignalType.GroupInput, IoSignalType.GroupOutput });
        FillCombo(cboSearchSignalsInvert, new object[] { Any, true, false });
        FillCombo(cboSearchSignalsBlocked, new object[] { Any, true, false });
    }

    // Make a type expandable in a PropertyGrid, and not editable
    private static void MakeExpandableAndReadOnly(Type type)
    {
        TypeDescriptor.AddAttributes(type, new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(type, new ReadOnlyAttribute(true));
    }

    // Value currently selected in an enum combo box
    private static T SelectedValue<T>(ComboBox combo) where T : struct
    {
        return (T)(combo.SelectedItem ?? default(T));
    }

    // Value currently selected in an optional filter combo box, null when "(any)" is selected
    private static T? OptionalValue<T>(ComboBox combo) where T : struct
    {
        return combo.SelectedItem is T value ? value : (T?)null;
    }

    private static void FillCombo(ComboBox combo, System.Collections.IEnumerable values)
    {
        foreach (var value in values)
            combo.Items.Add(value);

        if (combo.Items.Count > 0)
            combo.SelectedIndex = 0;
    }

    // Preselect the value a Get just returned, ignoring the states the combo does not offer
    private static void SelectIfPresent(ComboBox combo, object value)
    {
        if (combo.Items.Contains(value))
            combo.SelectedItem = value;
    }

    // An empty text box stands for an omitted optional argument
    private static string? Optional(TextBox textBox)
    {
        return string.IsNullOrEmpty(textBox.Text) ? null : textBox.Text;
    }

    private static int? OptionalInt(TextBox textBox)
    {
        return int.TryParse(textBox.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out int value) ? value : (int?)null;
    }

    // Show a complex result in a property grid, all nodes expanded
    private static void ShowInGrid(PropertyGrid grid, object value)
    {
        grid.SelectedObject = value;
        grid.ExpandAllGridItems();
    }

    // Every criteria field is optional, an empty one is simply not sent to the controller
    private IoSignalSearchCriteria BuildSignalSearchCriteria()
    {
        return new IoSignalSearchCriteria
        {
            Name = Optional(txtSearchSignalsName),
            DeviceName = Optional(txtSearchSignalsDevice),
            NetworkName = Optional(txtSearchSignalsNetwork),
            Category = Optional(txtSearchSignalsCategory),
            CategoryPrefix = Optional(txtSearchSignalsCategoryPrefix),
            Type = OptionalValue<IoSignalType>(cboSearchSignalsType),
            Invert = OptionalValue<bool>(cboSearchSignalsInvert),
            Blocked = OptionalValue<bool>(cboSearchSignalsBlocked),
        };
    }

    #region IUserControl
    public string Title => "IO (RWS)";

    public bool FeatureEnabled => _robot?.Rws != null && _robot.Rws.Enabled;

    public void PeriodicUpdate()
    {
        this.Enabled = FeatureEnabled;
    }


    public void OnClose()
    {
    }

    public void OnOpen()
    {
    }
    #endregion


    #region Networks

    private void btnGetResources_Click(object sender, EventArgs e)
    {
        string[] resources = _robot.Rws.Io.GetResources();
        ShowInGrid(gridResources, resources);
    }

    private void btnGetNetworks_Click(object sender, EventArgs e)
    {
        IoNetworkItem[] networks = _robot.Rws.Io.GetNetworks();
        ShowInGrid(gridNetworks, networks);
    }

    private void btnGetNetwork_Click(object sender, EventArgs e)
    {
        IoNetworkItem network = _robot.Rws.Io.GetNetwork(txtGetNetworkNetwork.Text);
        ShowInGrid(gridNetwork, network);

        SelectIfPresent(cboSetNetworkStateLogicalState, network.LogicalState);
    }

    private void btnSetNetworkState_Click(object sender, EventArgs e)
    {
        var logicalState = SelectedValue<IoNetworkLogicalState>(cboSetNetworkStateLogicalState);

        _robot.Rws.Io.SetNetworkState(txtGetNetworkNetwork.Text, logicalState);
    }

    private void btnSearchNetworks_Click(object sender, EventArgs e)
    {
        // The controller needs at least one of the two criteria
        IoNetworkItem[] networks = _robot.Rws.Io.SearchNetworks(Optional(txtSearchNetworksName),
                                                                OptionalValue<IoNetworkPhysicalState>(cboSearchNetworksPhysicalState));
        ShowInGrid(gridSearchNetworks, networks);
    }

    private void btnGetNetworkConfiguration_Click(object sender, EventArgs e)
    {
        IoNetworkConfiguration configuration = _robot.Rws.Io.GetNetworkConfiguration(txtNetworkConfigurationNetwork.Text);
        ShowInGrid(gridNetworkConfiguration, configuration);
    }

    private void btnSetNetworkConfigurationType_Click(object sender, EventArgs e)
    {
        var configurationType = SelectedValue<IoNetworkConfigurationType>(cboSetNetworkConfigurationType);

        IoClientAction clientAction = _robot.Rws.Io.SetNetworkConfigurationType(txtNetworkConfigurationNetwork.Text, configurationType);
        txtSetNetworkConfigurationTypeResult.Text = clientAction.ToString();
    }

    #endregion

    #region Devices

    private void btnGetDevices_Click(object sender, EventArgs e)
    {
        IoDeviceItem[] devices = _robot.Rws.Io.GetDevices();
        ShowInGrid(gridDevices, devices);
    }

    private void btnGetDevice_Click(object sender, EventArgs e)
    {
        IoDeviceItem device = _robot.Rws.Io.GetDevice(txtGetDeviceNetwork.Text, txtGetDeviceDevice.Text);
        ShowInGrid(gridDevice, device);

        SelectIfPresent(cboSetDeviceStateLogicalState, device.LogicalState);
    }

    private void btnSetDeviceState_Click(object sender, EventArgs e)
    {
        var logicalState = SelectedValue<IoDeviceLogicalState>(cboSetDeviceStateLogicalState);

        _robot.Rws.Io.SetDeviceState(txtGetDeviceNetwork.Text, txtGetDeviceDevice.Text, logicalState);
    }

    private void btnSearchDevices_Click(object sender, EventArgs e)
    {
        // The controller needs at least a name or a logical state
        IoDeviceItem[] devices = _robot.Rws.Io.SearchDevices(Optional(txtSearchDevicesName),
                                                             OptionalValue<IoDeviceLogicalState>(cboSearchDevicesLogicalState),
                                                             Optional(txtSearchDevicesNetwork));
        ShowInGrid(gridSearchDevices, devices);
    }

    private void btnGetDeviceConfiguration_Click(object sender, EventArgs e)
    {
        IoDeviceConfiguration configuration = _robot.Rws.Io.GetDeviceConfiguration(txtDeviceConfigurationNetwork.Text, txtDeviceConfigurationDevice.Text);
        ShowInGrid(gridDeviceConfiguration, configuration);
    }

    private void btnGetDeviceUpgradeInfo_Click(object sender, EventArgs e)
    {
        // Only a real controller reports a firmware upgrade status
        IoDeviceUpgradeInfo upgradeInfo = _robot.Rws.Io.GetDeviceUpgradeInfo(txtDeviceUpgradeInfoNetwork.Text, txtDeviceUpgradeInfoDevice.Text);
        ShowInGrid(gridDeviceUpgradeInfo, upgradeInfo);
    }

    #endregion

    #region Device data

    private void btnSetDeviceInputData_Click(object sender, EventArgs e)
    {
        // Writing device data is only supported by a virtual controller
        _robot.Rws.Io.SetDeviceInputData(txtSetDeviceInputDataNetwork.Text,
                                         txtSetDeviceInputDataDevice.Text,
                                         (int)numSetDeviceInputDataStartByte.Value,
                                         (int)numSetDeviceInputDataSignalData.Value,
                                         (int)numSetDeviceInputDataDataMask.Value);
    }

    private void btnSetDeviceOutputData_Click(object sender, EventArgs e)
    {
        _robot.Rws.Io.SetDeviceOutputData(txtSetDeviceOutputDataNetwork.Text,
                                          txtSetDeviceOutputDataDevice.Text,
                                          (int)numSetDeviceOutputDataStartByte.Value,
                                          (int)numSetDeviceOutputDataSignalData.Value,
                                          (int)numSetDeviceOutputDataDataMask.Value);
    }

    private void btnSendDeviceCommand_Click(object sender, EventArgs e)
    {
        // Only a real controller accepts device commands
        _robot.Rws.Io.SendDeviceCommand(txtSendDeviceCommandNetwork.Text,
                                        txtSendDeviceCommandDevice.Text,
                                        txtSendDeviceCommandCommandName.Text,
                                        txtSendDeviceCommandValue.Text,
                                        (int)numSendDeviceCommandValueLength.Value,
                                        (int)numSendDeviceCommandTimeout.Value);
    }

    #endregion

    #region Signals

    private void btnGetSignals_Click(object sender, EventArgs e)
    {
        // A controller declares several hundreds of signals, the search panel narrows it down
        IoSignalItem[] signals = _robot.Rws.Io.GetSignals();
        ShowInGrid(gridSignals, signals);
    }

    private void btnGetSignal_Click(object sender, EventArgs e)
    {
        IoSignalItem signal = _robot.Rws.Io.GetSignal(txtGetSignalNetwork.Text, txtGetSignalDevice.Text, txtGetSignalSignal.Text);
        ShowInGrid(gridSignal, signal);
    }

    private void btnGetSignalConfiguration_Click(object sender, EventArgs e)
    {
        IoSignalConfiguration configuration = _robot.Rws.Io.GetSignalConfiguration(txtSignalConfigurationNetwork.Text,
                                                                                  txtSignalConfigurationDevice.Text,
                                                                                  txtSignalConfigurationSignal.Text);
        ShowInGrid(gridSignalConfiguration, configuration);
    }

    private void btnUnblockSignals_Click(object sender, EventArgs e)
    {
        _robot.Rws.Io.UnblockSignals();
    }

    #endregion

    #region Signal write

    private void btnSetSignalValue_Click(object sender, EventArgs e)
    {
        _robot.Rws.Io.SetSignalValue(txtSetSignalValueNetwork.Text,
                                     txtSetSignalValueDevice.Text,
                                     txtSetSignalValueSignal.Text,
                                     (float)numSetSignalValueValue.Value,
                                     chkSetSignalValueLogToEventLog.Checked);
    }

    private void btnSetSignalValueDelayed_Click(object sender, EventArgs e)
    {
        _robot.Rws.Io.SetSignalValueDelayed(txtSetSignalValueDelayedNetwork.Text,
                                            txtSetSignalValueDelayedDevice.Text,
                                            txtSetSignalValueDelayedSignal.Text,
                                            (float)numSetSignalValueDelayedValue.Value,
                                            (int)numSetSignalValueDelayedDelay.Value,
                                            chkSetSignalValueDelayedLogToEventLog.Checked);
    }

    private void btnSetSignalState_Click(object sender, EventArgs e)
    {
        // A simulated signal keeps the value written by the client instead of following its physical value
        _robot.Rws.Io.SetSignalState(txtSetSignalStateNetwork.Text,
                                     txtSetSignalStateDevice.Text,
                                     txtSetSignalStateSignal.Text,
                                     chkSetSignalStateSimulated.Checked);
    }

    private void btnInvertSignal_Click(object sender, EventArgs e)
    {
        // the controller rejects a write carrying no value, whatever the mode
        _robot.Rws.Io.InvertSignal(txtInvertSignalNetwork.Text,
                                   txtInvertSignalDevice.Text,
                                   txtInvertSignalSignal.Text,
                                   (float)numInvertSignalValue.Value,
                                   chkInvertSignalLogToEventLog.Checked);
    }

    private void btnPulseSignal_Click(object sender, EventArgs e)
    {
        // Both pulse lengths are optional, left empty the controller uses its own defaults
        _robot.Rws.Io.PulseSignal(txtPulseSignalNetwork.Text,
                                  txtPulseSignalDevice.Text,
                                  txtPulseSignalSignal.Text,
                                  (float)numPulseSignalValue.Value,
                                  (int)numPulseSignalPulses.Value,
                                  OptionalInt(txtPulseSignalActivePulseLength),
                                  OptionalInt(txtPulseSignalPassivePulseLength),
                                  chkPulseSignalLogToEventLog.Checked);
    }

    private void btnToggleSignal_Click(object sender, EventArgs e)
    {
        _robot.Rws.Io.ToggleSignal(txtToggleSignalNetwork.Text,
                                   txtToggleSignalDevice.Text,
                                   txtToggleSignalSignal.Text,
                                   (float)numToggleSignalValue.Value,
                                   (int)numToggleSignalPulses.Value,
                                   OptionalInt(txtToggleSignalActivePulseLength),
                                   OptionalInt(txtToggleSignalPassivePulseLength),
                                   chkToggleSignalLogToEventLog.Checked);
    }

    #endregion

    #region Signal search

    private void btnSearchSignals_Click(object sender, EventArgs e)
    {
        IoSignalItem[] signals = _robot.Rws.Io.SearchSignals(BuildSignalSearchCriteria(),
                                                             null,
                                                             OptionalInt(txtSearchSignalsStart),
                                                             OptionalInt(txtSearchSignalsLimit));
        ShowInGrid(gridSearchSignals, signals);
    }

    private void btnSearchSignalsExtended_Click(object sender, EventArgs e)
    {
        // Same criteria, but the controller also reports the physical value, quality and access level
        IoSignalItem[] signals = _robot.Rws.Io.SearchSignalsExtended(BuildSignalSearchCriteria(),
                                                                     null,
                                                                     OptionalInt(txtSearchSignalsStart),
                                                                     OptionalInt(txtSearchSignalsLimit));
        ShowInGrid(gridSearchSignals, signals);
    }

    #endregion
}
