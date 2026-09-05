using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using UnderAutomation.ABB;
using UnderAutomation.ABB.Rws.Data;

public partial class RwsControllerControl : UserControl, IUserControl
{
    private AbbController _robot;

    public RwsControllerControl(AbbController robot)
    {
        // Complex types shown in a PropertyGrid have to be expandable and not editable
        MakeExpandableAndReadOnly(typeof(ControllerInfo));
        MakeExpandableAndReadOnly(typeof(ControllerIdentity));
        MakeExpandableAndReadOnly(typeof(TimeServerInfo));
        MakeExpandableAndReadOnly(typeof(NetworkInterfaceItem));
        MakeExpandableAndReadOnly(typeof(NetworkInterfaceItem[]));
        MakeExpandableAndReadOnly(typeof(BackupSystemInfo));
        MakeExpandableAndReadOnly(typeof(CheckRestoreResult));
        MakeExpandableAndReadOnly(typeof(SafetyModeStatus));
        MakeExpandableAndReadOnly(typeof(SafetyConfiguration));
        MakeExpandableAndReadOnly(typeof(CyclicBrakeCheckStatus));
        MakeExpandableAndReadOnly(typeof(SafetyViolationInfo));
        MakeExpandableAndReadOnly(typeof(string[]));

        _robot = robot;
        InitializeComponent();

        // Enum arguments are selected in a combo box
        FillCombo(cboSetNetworkConfigurationMethod, Enum.GetValues(typeof(NetworkConfigurationMethod)));
        FillCombo(cboRestartMode, Enum.GetValues(typeof(ControllerRestartMode)));
        FillCombo(cboRestoreBackupIgnore, Enum.GetValues(typeof(BackupRestoreIgnore)));
        FillCombo(cboRestoreBackupInclude, Enum.GetValues(typeof(BackupRestoreInclude)));
        FillCombo(cboCheckRestoreIgnore, Enum.GetValues(typeof(BackupRestoreIgnore)));
        FillCombo(cboCheckRestoreInclude, Enum.GetValues(typeof(BackupRestoreInclude)));

        // Only these three safety modes can be set by a client
        FillCombo(cboSetSafetyModeMode, new object[] { SafetyMode.Active, SafetyMode.Commissioning, SafetyMode.Service });

        // Unknown is only returned by the controller, it cannot be set
        FillCombo(cboSetVirtualTimeStateState, new object[] { VirtualTimeState.Stop, VirtualTimeState.FreeRun, VirtualTimeState.RunSlice, VirtualTimeState.NextEvent });
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

    private static void FillCombo(ComboBox combo, System.Collections.IEnumerable values)
    {
        foreach (var value in values)
            combo.Items.Add(value);

        if (combo.Items.Count > 0)
            combo.SelectedIndex = 0;
    }

    // Show a complex result in a property grid, all nodes expanded
    private static void ShowInGrid(PropertyGrid grid, object value)
    {
        grid.SelectedObject = value;
        grid.ExpandAllGridItems();
    }

    #region IUserControl
    public string Title => "Controller info (RWS)";

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


    private void btnGetControllerInfo_Click(object sender, EventArgs e)
    {
        ControllerInfo controllerInfo = _robot.Rws.Controller.GetInfo();
        gridControllerInfo.SelectedObject = controllerInfo;
        gridControllerInfo.ExpandAllGridItems();
    }

    private void btnGetEnvironmentVariable_Click(object sender, EventArgs e)
    {
        txtEnvironmentVariableValue.Text = _robot.Rws.Controller.GetEnvironmentVariable(txtEnvironmentVariableName.Text);
    }

    private void btnGetClock_Click(object sender, EventArgs e)
    {
        dtpClock.Value = _robot.Rws.Controller.GetClock();
    }

    private void btnSetClock_Click(object sender, EventArgs e)
    {
        _robot.Rws.Controller.SetClock(dtpClock.Value);
    }

    private void btnGetTimeZone_Click(object sender, EventArgs e)
    {
        txtTimeZone.Text = _robot.Rws.Controller.GetTimeZone();
    }

    private void btnSetTimeZone_Click(object sender, EventArgs e)
    {
        _robot.Rws.Controller.SetTimeZone(txtTimeZone.Text);
    }

    private void btnGetTimeServer_Click(object sender, EventArgs e)
    {
        // The server ip is optional, and only supported by RWS v2
        string? serverIp = string.IsNullOrEmpty(txtGetTimeServerServerIp.Text) ? null : txtGetTimeServerServerIp.Text;

        TimeServerInfo timeServer = _robot.Rws.Controller.GetTimeServer(serverIp);
        ShowInGrid(gridTimeServer, timeServer);
    }

    private void btnSetTimeServer_Click(object sender, EventArgs e)
    {
        _robot.Rws.Controller.SetTimeServer(txtSetTimeServerTimeServer.Text);
    }

    private void btnGetIdentity_Click(object sender, EventArgs e)
    {
        ControllerIdentity identity = _robot.Rws.Controller.GetIdentity();
        ShowInGrid(gridIdentity, identity);

        txtSetIdentityName.Text = identity.Name;
        txtSetIdentityId.Text = identity.Id;
    }

    private void btnSetIdentity_Click(object sender, EventArgs e)
    {
        string? id = string.IsNullOrEmpty(txtSetIdentityId.Text) ? null : txtSetIdentityId.Text;

        _robot.Rws.Controller.SetIdentity(txtSetIdentityName.Text, id);
    }

    private void btnSetLanguage_Click(object sender, EventArgs e)
    {
        _robot.Rws.Controller.SetLanguage(txtSetLanguageLanguage.Text);
    }

    private void btnGetNetworkInterfaces_Click(object sender, EventArgs e)
    {
        NetworkInterfaceItem[] interfaces = _robot.Rws.Controller.GetNetworkInterfaces();
        ShowInGrid(gridNetworkInterfaces, interfaces);
    }

    private void btnSetNetworkConfiguration_Click(object sender, EventArgs e)
    {
        var method = SelectedValue<NetworkConfigurationMethod>(cboSetNetworkConfigurationMethod);

        _robot.Rws.Controller.SetNetworkConfiguration(method,
                                                      txtSetNetworkConfigurationAddress.Text,
                                                      txtSetNetworkConfigurationMask.Text,
                                                      txtSetNetworkConfigurationGateway.Text);
    }

    private void btnRestart_Click(object sender, EventArgs e)
    {
        var mode = SelectedValue<ControllerRestartMode>(cboRestartMode);

        _robot.Rws.Controller.Restart(mode, chkRestartUseImplicitMastership.Checked);
    }

    private void btnGetInstalledSystems_Click(object sender, EventArgs e)
    {
        string[] systems = _robot.Rws.Controller.GetInstalledSystems();
        ShowInGrid(gridInstalledSystems, systems);
    }

    private void btnHasOption_Click(object sender, EventArgs e)
    {
        chkHasOptionResult.Checked = _robot.Rws.Controller.HasOption(txtHasOptionOption.Text);
    }

    private void btnIsRobotWareVersionCompatible_Click(object sender, EventArgs e)
    {
        chkIsRobotWareVersionCompatibleResult.Checked = _robot.Rws.Controller.IsRobotWareVersionCompatible(txtIsRobotWareVersionCompatibleRobotWareVersion.Text);
    }

    private void btnGetBackupResources_Click(object sender, EventArgs e)
    {
        string[] resources = _robot.Rws.Controller.GetBackupResources();
        ShowInGrid(gridBackupResources, resources);
    }

    private void btnGetBackupInfo_Click(object sender, EventArgs e)
    {
        BackupSystemInfo backupInfo = _robot.Rws.Controller.GetBackupInfo(txtGetBackupInfoBackupPath.Text);
        ShowInGrid(gridBackupInfo, backupInfo);
    }

    private void btnGetBackupState_Click(object sender, EventArgs e)
    {
        BackupState state = _robot.Rws.Controller.GetBackupState();
        txtBackupState.Text = state.ToString();
    }

    private void btnCreateBackup_Click(object sender, EventArgs e)
    {
        // The controller creates the backup asynchronously, follow it with Get Backup state
        _robot.Rws.Controller.CreateBackup(txtCreateBackupBackupPath.Text, chkCreateBackupArchive.Checked);
    }

    private void btnRestoreBackup_Click(object sender, EventArgs e)
    {
        var ignore = SelectedValue<BackupRestoreIgnore>(cboRestoreBackupIgnore);
        var include = SelectedValue<BackupRestoreInclude>(cboRestoreBackupInclude);

        _robot.Rws.Controller.RestoreBackup(txtRestoreBackupBackupPath.Text,
                                            ignore,
                                            chkRestoreBackupDeleteDirectory.Checked,
                                            chkRestoreBackupIncludeControllerSettings.Checked,
                                            chkRestoreBackupIncludeSafetySettings.Checked,
                                            include);
    }

    private void btnCheckRestore_Click(object sender, EventArgs e)
    {
        var ignore = SelectedValue<BackupRestoreIgnore>(cboCheckRestoreIgnore);
        var include = SelectedValue<BackupRestoreInclude>(cboCheckRestoreInclude);

        CheckRestoreResult result = _robot.Rws.Controller.CheckRestore(txtCheckRestoreBackupPath.Text,
                                                                      ignore,
                                                                      chkCheckRestoreIncludeControllerSettings.Checked,
                                                                      chkCheckRestoreIncludeSafetySettings.Checked,
                                                                      include);
        ShowInGrid(gridCheckRestore, result);
    }

    private void btnGetSafetyResources_Click(object sender, EventArgs e)
    {
        string[] resources = _robot.Rws.Controller.GetSafetyResources();
        ShowInGrid(gridSafetyResources, resources);
    }

    private void btnGetSafetyMode_Click(object sender, EventArgs e)
    {
        SafetyModeStatus safetyMode = _robot.Rws.Controller.GetSafetyMode();
        ShowInGrid(gridSafetyMode, safetyMode);
    }

    private void btnSetSafetyMode_Click(object sender, EventArgs e)
    {
        var mode = SelectedValue<SafetyMode>(cboSetSafetyModeMode);

        _robot.Rws.Controller.SetSafetyMode(mode);
    }

    private void btnGetSafetyConfiguration_Click(object sender, EventArgs e)
    {
        SafetyConfiguration configuration = _robot.Rws.Controller.GetSafetyConfiguration();
        ShowInGrid(gridSafetyConfiguration, configuration);
    }

    private void btnLoadSafetyConfiguration_Click(object sender, EventArgs e)
    {
        _robot.Rws.Controller.LoadSafetyConfiguration(txtLoadSafetyConfigurationFilePath.Text);
    }

    private void btnInvalidateSafetyConfiguration_Click(object sender, EventArgs e)
    {
        _robot.Rws.Controller.InvalidateSafetyConfiguration();
    }

    private void btnGetSafetyLoadOperationStatus_Click(object sender, EventArgs e)
    {
        SafetyLoadOperationStatus status = _robot.Rws.Controller.GetSafetyLoadOperationStatus();
        txtSafetyLoadOperationStatus.Text = status.ToString();
    }

    private void btnGetCyclicBrakeCheckStatus_Click(object sender, EventArgs e)
    {
        int driveNumber = (int)numGetCyclicBrakeCheckStatusDriveNumber.Value;

        CyclicBrakeCheckStatus status = _robot.Rws.Controller.GetCyclicBrakeCheckStatus(driveNumber);
        ShowInGrid(gridCyclicBrakeCheckStatus, status);
    }

    private void btnGetSafetyViolationInfo_Click(object sender, EventArgs e)
    {
        SafetyViolationInfo violationInfo = _robot.Rws.Controller.GetSafetyViolationInfo();
        ShowInGrid(gridSafetyViolationInfo, violationInfo);
    }

    private void btnGetVirtualTimeResources_Click(object sender, EventArgs e)
    {
        string[] resources = _robot.Rws.Controller.GetVirtualTimeResources();
        ShowInGrid(gridVirtualTimeResources, resources);
    }

    private void btnGetVirtualTime_Click(object sender, EventArgs e)
    {
        long virtualTime = _robot.Rws.Controller.GetVirtualTime();
        txtVirtualTime.Text = virtualTime.ToString() + " ms";
    }

    private void btnGetVirtualTimeSpeed_Click(object sender, EventArgs e)
    {
        numSetVirtualTimeSpeedSpeed.Value = _robot.Rws.Controller.GetVirtualTimeSpeed();
    }

    private void btnSetVirtualTimeSpeed_Click(object sender, EventArgs e)
    {
        _robot.Rws.Controller.SetVirtualTimeSpeed((int)numSetVirtualTimeSpeedSpeed.Value);
    }

    private void btnGetVirtualTimeState_Click(object sender, EventArgs e)
    {
        VirtualTimeState state = _robot.Rws.Controller.GetVirtualTimeState();
        cboSetVirtualTimeStateState.SelectedItem = state;
    }

    private void btnSetVirtualTimeState_Click(object sender, EventArgs e)
    {
        var state = SelectedValue<VirtualTimeState>(cboSetVirtualTimeStateState);

        _robot.Rws.Controller.SetVirtualTimeState(state);
    }

    private void btnGetVirtualTimeSlice_Click(object sender, EventArgs e)
    {
        numSetVirtualTimeSliceMilliseconds.Value = _robot.Rws.Controller.GetVirtualTimeSlice();
    }

    private void btnSetVirtualTimeSlice_Click(object sender, EventArgs e)
    {
        _robot.Rws.Controller.SetVirtualTimeSlice((int)numSetVirtualTimeSliceMilliseconds.Value);
    }

    private void btnRunVirtualTime_Click(object sender, EventArgs e)
    {
        _robot.Rws.Controller.RunVirtualTime();
    }
}
