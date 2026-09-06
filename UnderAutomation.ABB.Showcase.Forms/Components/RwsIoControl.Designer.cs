
partial class RwsIoControl
{
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Code généré par le Concepteur de composants

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
        tabControl = new TabControl();
        tabNetworks = new TabPage();
        flowNetworks = new FlowLayoutPanel();
        pnlIoResources = new Panel();
        btnGetResources = new Button();
        sep1 = new Panel();
        gridResources = new PropertyGrid();
        pnlNetworks = new Panel();
        btnGetNetworks = new Button();
        sep2 = new Panel();
        gridNetworks = new PropertyGrid();
        pnlNetwork = new Panel();
        txtGetNetworkNetwork = new TextBox();
        sep3 = new Panel();
        btnGetNetwork = new Button();
        sep4 = new Panel();
        gridNetwork = new PropertyGrid();
        sep5 = new Panel();
        cboSetNetworkStateLogicalState = new ComboBox();
        sep6 = new Panel();
        btnSetNetworkState = new Button();
        pnlSearchNetworks = new Panel();
        txtSearchNetworksName = new TextBox();
        sep7 = new Panel();
        cboSearchNetworksPhysicalState = new ComboBox();
        sep8 = new Panel();
        btnSearchNetworks = new Button();
        sep9 = new Panel();
        gridSearchNetworks = new PropertyGrid();
        pnlNetworkConfiguration = new Panel();
        txtNetworkConfigurationNetwork = new TextBox();
        sep10 = new Panel();
        btnGetNetworkConfiguration = new Button();
        sep11 = new Panel();
        gridNetworkConfiguration = new PropertyGrid();
        sep12 = new Panel();
        cboSetNetworkConfigurationType = new ComboBox();
        sep13 = new Panel();
        btnSetNetworkConfigurationType = new Button();
        sep14 = new Panel();
        txtSetNetworkConfigurationTypeResult = new TextBox();
        tabDevices = new TabPage();
        flowDevices = new FlowLayoutPanel();
        pnlDevices = new Panel();
        btnGetDevices = new Button();
        sep15 = new Panel();
        gridDevices = new PropertyGrid();
        pnlDevice = new Panel();
        txtGetDeviceNetwork = new TextBox();
        sep16 = new Panel();
        txtGetDeviceDevice = new TextBox();
        sep17 = new Panel();
        btnGetDevice = new Button();
        sep18 = new Panel();
        gridDevice = new PropertyGrid();
        sep19 = new Panel();
        cboSetDeviceStateLogicalState = new ComboBox();
        sep20 = new Panel();
        btnSetDeviceState = new Button();
        pnlSearchDevices = new Panel();
        txtSearchDevicesName = new TextBox();
        sep21 = new Panel();
        cboSearchDevicesLogicalState = new ComboBox();
        sep22 = new Panel();
        txtSearchDevicesNetwork = new TextBox();
        sep23 = new Panel();
        btnSearchDevices = new Button();
        sep24 = new Panel();
        gridSearchDevices = new PropertyGrid();
        pnlDeviceConfiguration = new Panel();
        txtDeviceConfigurationNetwork = new TextBox();
        sep25 = new Panel();
        txtDeviceConfigurationDevice = new TextBox();
        sep26 = new Panel();
        btnGetDeviceConfiguration = new Button();
        sep27 = new Panel();
        gridDeviceConfiguration = new PropertyGrid();
        pnlDeviceUpgradeInfo = new Panel();
        txtDeviceUpgradeInfoNetwork = new TextBox();
        sep28 = new Panel();
        txtDeviceUpgradeInfoDevice = new TextBox();
        sep29 = new Panel();
        btnGetDeviceUpgradeInfo = new Button();
        sep30 = new Panel();
        gridDeviceUpgradeInfo = new PropertyGrid();
        tabDeviceData = new TabPage();
        flowDeviceData = new FlowLayoutPanel();
        pnlDeviceInputData = new Panel();
        txtSetDeviceInputDataNetwork = new TextBox();
        sep31 = new Panel();
        txtSetDeviceInputDataDevice = new TextBox();
        sep32 = new Panel();
        numSetDeviceInputDataStartByte = new NumericUpDown();
        sep33 = new Panel();
        numSetDeviceInputDataSignalData = new NumericUpDown();
        sep34 = new Panel();
        numSetDeviceInputDataDataMask = new NumericUpDown();
        sep35 = new Panel();
        btnSetDeviceInputData = new Button();
        pnlDeviceOutputData = new Panel();
        txtSetDeviceOutputDataNetwork = new TextBox();
        sep36 = new Panel();
        txtSetDeviceOutputDataDevice = new TextBox();
        sep37 = new Panel();
        numSetDeviceOutputDataStartByte = new NumericUpDown();
        sep38 = new Panel();
        numSetDeviceOutputDataSignalData = new NumericUpDown();
        sep39 = new Panel();
        numSetDeviceOutputDataDataMask = new NumericUpDown();
        sep40 = new Panel();
        btnSetDeviceOutputData = new Button();
        pnlDeviceCommand = new Panel();
        txtSendDeviceCommandNetwork = new TextBox();
        sep41 = new Panel();
        txtSendDeviceCommandDevice = new TextBox();
        sep42 = new Panel();
        txtSendDeviceCommandCommandName = new TextBox();
        sep43 = new Panel();
        txtSendDeviceCommandValue = new TextBox();
        sep44 = new Panel();
        numSendDeviceCommandValueLength = new NumericUpDown();
        sep45 = new Panel();
        numSendDeviceCommandTimeout = new NumericUpDown();
        sep46 = new Panel();
        btnSendDeviceCommand = new Button();
        tabSignals = new TabPage();
        flowSignals = new FlowLayoutPanel();
        pnlSignals = new Panel();
        btnGetSignals = new Button();
        sep47 = new Panel();
        gridSignals = new PropertyGrid();
        pnlSignal = new Panel();
        txtGetSignalNetwork = new TextBox();
        sep48 = new Panel();
        txtGetSignalDevice = new TextBox();
        sep49 = new Panel();
        txtGetSignalSignal = new TextBox();
        sep50 = new Panel();
        btnGetSignal = new Button();
        sep51 = new Panel();
        gridSignal = new PropertyGrid();
        pnlSignalConfiguration = new Panel();
        txtSignalConfigurationNetwork = new TextBox();
        sep52 = new Panel();
        txtSignalConfigurationDevice = new TextBox();
        sep53 = new Panel();
        txtSignalConfigurationSignal = new TextBox();
        sep54 = new Panel();
        btnGetSignalConfiguration = new Button();
        sep55 = new Panel();
        gridSignalConfiguration = new PropertyGrid();
        pnlUnblockSignals = new Panel();
        btnUnblockSignals = new Button();
        tabSignalWrite = new TabPage();
        flowSignalWrite = new FlowLayoutPanel();
        pnlSetSignalValue = new Panel();
        txtSetSignalValueNetwork = new TextBox();
        sep56 = new Panel();
        txtSetSignalValueDevice = new TextBox();
        sep57 = new Panel();
        txtSetSignalValueSignal = new TextBox();
        sep58 = new Panel();
        numSetSignalValueValue = new NumericUpDown();
        sep59 = new Panel();
        chkSetSignalValueLogToEventLog = new CheckBox();
        sep60 = new Panel();
        btnSetSignalValue = new Button();
        pnlSetSignalValueDelayed = new Panel();
        txtSetSignalValueDelayedNetwork = new TextBox();
        sep61 = new Panel();
        txtSetSignalValueDelayedDevice = new TextBox();
        sep62 = new Panel();
        txtSetSignalValueDelayedSignal = new TextBox();
        sep63 = new Panel();
        numSetSignalValueDelayedValue = new NumericUpDown();
        sep64 = new Panel();
        numSetSignalValueDelayedDelay = new NumericUpDown();
        sep65 = new Panel();
        chkSetSignalValueDelayedLogToEventLog = new CheckBox();
        sep66 = new Panel();
        btnSetSignalValueDelayed = new Button();
        pnlSetSignalState = new Panel();
        txtSetSignalStateNetwork = new TextBox();
        sep67 = new Panel();
        txtSetSignalStateDevice = new TextBox();
        sep68 = new Panel();
        txtSetSignalStateSignal = new TextBox();
        sep69 = new Panel();
        chkSetSignalStateSimulated = new CheckBox();
        sep70 = new Panel();
        btnSetSignalState = new Button();
        pnlInvertSignal = new Panel();
        txtInvertSignalNetwork = new TextBox();
        sep71 = new Panel();
        txtInvertSignalDevice = new TextBox();
        sep72 = new Panel();
        txtInvertSignalSignal = new TextBox();
        sep73 = new Panel();
        numInvertSignalValue = new NumericUpDown();
        sep74 = new Panel();
        chkInvertSignalLogToEventLog = new CheckBox();
        sep75 = new Panel();
        btnInvertSignal = new Button();
        pnlPulseSignal = new Panel();
        txtPulseSignalNetwork = new TextBox();
        sep76 = new Panel();
        txtPulseSignalDevice = new TextBox();
        sep77 = new Panel();
        txtPulseSignalSignal = new TextBox();
        sep78 = new Panel();
        numPulseSignalValue = new NumericUpDown();
        sep79 = new Panel();
        numPulseSignalPulses = new NumericUpDown();
        sep80 = new Panel();
        txtPulseSignalActivePulseLength = new TextBox();
        sep81 = new Panel();
        txtPulseSignalPassivePulseLength = new TextBox();
        sep82 = new Panel();
        chkPulseSignalLogToEventLog = new CheckBox();
        sep83 = new Panel();
        btnPulseSignal = new Button();
        pnlToggleSignal = new Panel();
        txtToggleSignalNetwork = new TextBox();
        sep84 = new Panel();
        txtToggleSignalDevice = new TextBox();
        sep85 = new Panel();
        txtToggleSignalSignal = new TextBox();
        sep86 = new Panel();
        numToggleSignalValue = new NumericUpDown();
        sep87 = new Panel();
        numToggleSignalPulses = new NumericUpDown();
        sep88 = new Panel();
        txtToggleSignalActivePulseLength = new TextBox();
        sep89 = new Panel();
        txtToggleSignalPassivePulseLength = new TextBox();
        sep90 = new Panel();
        chkToggleSignalLogToEventLog = new CheckBox();
        sep91 = new Panel();
        btnToggleSignal = new Button();
        tabSignalSearch = new TabPage();
        flowSignalSearch = new FlowLayoutPanel();
        pnlSearchSignals = new Panel();
        txtSearchSignalsName = new TextBox();
        sep92 = new Panel();
        txtSearchSignalsDevice = new TextBox();
        sep93 = new Panel();
        txtSearchSignalsNetwork = new TextBox();
        sep94 = new Panel();
        txtSearchSignalsCategory = new TextBox();
        sep95 = new Panel();
        txtSearchSignalsCategoryPrefix = new TextBox();
        sep96 = new Panel();
        cboSearchSignalsType = new ComboBox();
        sep97 = new Panel();
        cboSearchSignalsInvert = new ComboBox();
        sep98 = new Panel();
        cboSearchSignalsBlocked = new ComboBox();
        sep99 = new Panel();
        txtSearchSignalsStart = new TextBox();
        sep100 = new Panel();
        txtSearchSignalsLimit = new TextBox();
        sep101 = new Panel();
        btnSearchSignals = new Button();
        sep102 = new Panel();
        btnSearchSignalsExtended = new Button();
        pnlSearchSignalsResult = new Panel();
        gridSearchSignals = new PropertyGrid();
        tabControl.SuspendLayout();
        tabNetworks.SuspendLayout();
        flowNetworks.SuspendLayout();
        tabDevices.SuspendLayout();
        flowDevices.SuspendLayout();
        tabDeviceData.SuspendLayout();
        flowDeviceData.SuspendLayout();
        tabSignals.SuspendLayout();
        flowSignals.SuspendLayout();
        tabSignalWrite.SuspendLayout();
        flowSignalWrite.SuspendLayout();
        tabSignalSearch.SuspendLayout();
        flowSignalSearch.SuspendLayout();
        pnlIoResources.SuspendLayout();
        pnlNetworks.SuspendLayout();
        pnlNetwork.SuspendLayout();
        pnlSearchNetworks.SuspendLayout();
        pnlNetworkConfiguration.SuspendLayout();
        pnlDevices.SuspendLayout();
        pnlDevice.SuspendLayout();
        pnlSearchDevices.SuspendLayout();
        pnlDeviceConfiguration.SuspendLayout();
        pnlDeviceUpgradeInfo.SuspendLayout();
        pnlDeviceInputData.SuspendLayout();
        pnlDeviceOutputData.SuspendLayout();
        pnlDeviceCommand.SuspendLayout();
        pnlSignals.SuspendLayout();
        pnlSignal.SuspendLayout();
        pnlSignalConfiguration.SuspendLayout();
        pnlUnblockSignals.SuspendLayout();
        pnlSetSignalValue.SuspendLayout();
        pnlSetSignalValueDelayed.SuspendLayout();
        pnlSetSignalState.SuspendLayout();
        pnlInvertSignal.SuspendLayout();
        pnlPulseSignal.SuspendLayout();
        pnlToggleSignal.SuspendLayout();
        pnlSearchSignals.SuspendLayout();
        pnlSearchSignalsResult.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numSetDeviceInputDataStartByte).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numSetDeviceInputDataSignalData).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numSetDeviceInputDataDataMask).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numSetDeviceOutputDataStartByte).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numSetDeviceOutputDataSignalData).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numSetDeviceOutputDataDataMask).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numSendDeviceCommandValueLength).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numSendDeviceCommandTimeout).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numSetSignalValueValue).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numSetSignalValueDelayedValue).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numSetSignalValueDelayedDelay).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numInvertSignalValue).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numPulseSignalValue).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numPulseSignalPulses).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numToggleSignalValue).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numToggleSignalPulses).BeginInit();
        SuspendLayout();
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabNetworks);
        tabControl.Controls.Add(tabDevices);
        tabControl.Controls.Add(tabDeviceData);
        tabControl.Controls.Add(tabSignals);
        tabControl.Controls.Add(tabSignalWrite);
        tabControl.Controls.Add(tabSignalSearch);
        tabControl.Dock = DockStyle.Fill;
        tabControl.Location = new Point(0, 0);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(890, 491);
        tabControl.TabIndex = 0;
        // 
        // tabNetworks
        // 
        tabNetworks.Controls.Add(flowNetworks);
        tabNetworks.Location = new Point(4, 24);
        tabNetworks.Name = "tabNetworks";
        tabNetworks.Padding = new Padding(3);
        tabNetworks.Size = new Size(882, 463);
        tabNetworks.TabIndex = 0;
        tabNetworks.Text = "Networks";
        tabNetworks.UseVisualStyleBackColor = true;
        // 
        // flowNetworks
        // 
        flowNetworks.AutoScroll = true;
        flowNetworks.Controls.Add(pnlIoResources);
        flowNetworks.Controls.Add(pnlNetworks);
        flowNetworks.Controls.Add(pnlNetwork);
        flowNetworks.Controls.Add(pnlSearchNetworks);
        flowNetworks.Controls.Add(pnlNetworkConfiguration);
        flowNetworks.Dock = DockStyle.Fill;
        flowNetworks.FlowDirection = FlowDirection.TopDown;
        flowNetworks.Location = new Point(3, 3);
        flowNetworks.Name = "flowNetworks";
        flowNetworks.Size = new Size(876, 457);
        flowNetworks.TabIndex = 0;
        // 
        // pnlIoResources
        // 
        pnlIoResources.BorderStyle = BorderStyle.FixedSingle;
        pnlIoResources.Controls.Add(gridResources);
        pnlIoResources.Controls.Add(sep1);
        pnlIoResources.Controls.Add(btnGetResources);
        pnlIoResources.Location = new Point(3, 3);
        pnlIoResources.Name = "pnlIoResources";
        pnlIoResources.Padding = new Padding(5);
        pnlIoResources.Size = new Size(250, 122);
        pnlIoResources.TabIndex = 0;
        // 
        // btnGetResources
        // 
        btnGetResources.Dock = DockStyle.Top;
        btnGetResources.Location = new Point(5, 5);
        btnGetResources.Name = "btnGetResources";
        btnGetResources.Size = new Size(238, 23);
        btnGetResources.TabIndex = 0;
        btnGetResources.Text = "Get I/O resources";
        btnGetResources.UseVisualStyleBackColor = true;
        btnGetResources.Click += btnGetResources_Click;
        // 
        // sep1
        // 
        sep1.Dock = DockStyle.Top;
        sep1.Location = new Point(5, 28);
        sep1.Name = "sep1";
        sep1.Size = new Size(238, 5);
        sep1.TabIndex = 1;
        // 
        // gridResources
        // 
        gridResources.Dock = DockStyle.Top;
        gridResources.Location = new Point(5, 33);
        gridResources.HelpVisible = false;
        gridResources.Name = "gridResources";
        gridResources.PropertySort = PropertySort.NoSort;
        gridResources.Size = new Size(238, 82);
        gridResources.TabIndex = 2;
        gridResources.ToolbarVisible = false;
        // 
        // pnlNetworks
        // 
        pnlNetworks.BorderStyle = BorderStyle.FixedSingle;
        pnlNetworks.Controls.Add(gridNetworks);
        pnlNetworks.Controls.Add(sep2);
        pnlNetworks.Controls.Add(btnGetNetworks);
        pnlNetworks.Location = new Point(3, 3);
        pnlNetworks.Name = "pnlNetworks";
        pnlNetworks.Padding = new Padding(5);
        pnlNetworks.Size = new Size(250, 331);
        pnlNetworks.TabIndex = 1;
        // 
        // btnGetNetworks
        // 
        btnGetNetworks.Dock = DockStyle.Top;
        btnGetNetworks.Location = new Point(5, 5);
        btnGetNetworks.Name = "btnGetNetworks";
        btnGetNetworks.Size = new Size(238, 23);
        btnGetNetworks.TabIndex = 0;
        btnGetNetworks.Text = "Get Networks";
        btnGetNetworks.UseVisualStyleBackColor = true;
        btnGetNetworks.Click += btnGetNetworks_Click;
        // 
        // sep2
        // 
        sep2.Dock = DockStyle.Top;
        sep2.Location = new Point(5, 28);
        sep2.Name = "sep2";
        sep2.Size = new Size(238, 5);
        sep2.TabIndex = 1;
        // 
        // gridNetworks
        // 
        gridNetworks.Dock = DockStyle.Top;
        gridNetworks.Location = new Point(5, 33);
        gridNetworks.HelpVisible = false;
        gridNetworks.Name = "gridNetworks";
        gridNetworks.PropertySort = PropertySort.NoSort;
        gridNetworks.Size = new Size(238, 291);
        gridNetworks.TabIndex = 2;
        gridNetworks.ToolbarVisible = false;
        // 
        // pnlNetwork
        // 
        pnlNetwork.BorderStyle = BorderStyle.FixedSingle;
        pnlNetwork.Controls.Add(btnSetNetworkState);
        pnlNetwork.Controls.Add(sep6);
        pnlNetwork.Controls.Add(cboSetNetworkStateLogicalState);
        pnlNetwork.Controls.Add(sep5);
        pnlNetwork.Controls.Add(gridNetwork);
        pnlNetwork.Controls.Add(sep4);
        pnlNetwork.Controls.Add(btnGetNetwork);
        pnlNetwork.Controls.Add(sep3);
        pnlNetwork.Controls.Add(txtGetNetworkNetwork);
        pnlNetwork.Location = new Point(3, 3);
        pnlNetwork.Name = "pnlNetwork";
        pnlNetwork.Padding = new Padding(5);
        pnlNetwork.Size = new Size(250, 206);
        pnlNetwork.TabIndex = 2;
        // 
        // txtGetNetworkNetwork
        // 
        txtGetNetworkNetwork.Dock = DockStyle.Top;
        txtGetNetworkNetwork.Location = new Point(5, 5);
        txtGetNetworkNetwork.Name = "txtGetNetworkNetwork";
        txtGetNetworkNetwork.PlaceholderText = "network";
        txtGetNetworkNetwork.Size = new Size(238, 23);
        txtGetNetworkNetwork.TabIndex = 0;
        txtGetNetworkNetwork.Text = "Local";
        // 
        // sep3
        // 
        sep3.Dock = DockStyle.Top;
        sep3.Location = new Point(5, 28);
        sep3.Name = "sep3";
        sep3.Size = new Size(238, 5);
        sep3.TabIndex = 1;
        // 
        // btnGetNetwork
        // 
        btnGetNetwork.Dock = DockStyle.Top;
        btnGetNetwork.Location = new Point(5, 33);
        btnGetNetwork.Name = "btnGetNetwork";
        btnGetNetwork.Size = new Size(238, 23);
        btnGetNetwork.TabIndex = 2;
        btnGetNetwork.Text = "Get Network";
        btnGetNetwork.UseVisualStyleBackColor = true;
        btnGetNetwork.Click += btnGetNetwork_Click;
        // 
        // sep4
        // 
        sep4.Dock = DockStyle.Top;
        sep4.Location = new Point(5, 56);
        sep4.Name = "sep4";
        sep4.Size = new Size(238, 5);
        sep4.TabIndex = 3;
        // 
        // gridNetwork
        // 
        gridNetwork.Dock = DockStyle.Top;
        gridNetwork.Location = new Point(5, 61);
        gridNetwork.HelpVisible = false;
        gridNetwork.Name = "gridNetwork";
        gridNetwork.PropertySort = PropertySort.NoSort;
        gridNetwork.Size = new Size(238, 82);
        gridNetwork.TabIndex = 4;
        gridNetwork.ToolbarVisible = false;
        // 
        // sep5
        // 
        sep5.Dock = DockStyle.Top;
        sep5.Location = new Point(5, 143);
        sep5.Name = "sep5";
        sep5.Size = new Size(238, 5);
        sep5.TabIndex = 5;
        // 
        // cboSetNetworkStateLogicalState
        // 
        cboSetNetworkStateLogicalState.Dock = DockStyle.Top;
        cboSetNetworkStateLogicalState.Location = new Point(5, 148);
        cboSetNetworkStateLogicalState.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSetNetworkStateLogicalState.FormattingEnabled = true;
        cboSetNetworkStateLogicalState.Name = "cboSetNetworkStateLogicalState";
        cboSetNetworkStateLogicalState.Size = new Size(238, 23);
        cboSetNetworkStateLogicalState.TabIndex = 6;
        // 
        // sep6
        // 
        sep6.Dock = DockStyle.Top;
        sep6.Location = new Point(5, 171);
        sep6.Name = "sep6";
        sep6.Size = new Size(238, 5);
        sep6.TabIndex = 7;
        // 
        // btnSetNetworkState
        // 
        btnSetNetworkState.Dock = DockStyle.Top;
        btnSetNetworkState.Location = new Point(5, 176);
        btnSetNetworkState.Name = "btnSetNetworkState";
        btnSetNetworkState.Size = new Size(238, 23);
        btnSetNetworkState.TabIndex = 8;
        btnSetNetworkState.Text = "Set Network state";
        btnSetNetworkState.UseVisualStyleBackColor = true;
        btnSetNetworkState.Click += btnSetNetworkState_Click;
        // 
        // pnlSearchNetworks
        // 
        pnlSearchNetworks.BorderStyle = BorderStyle.FixedSingle;
        pnlSearchNetworks.Controls.Add(gridSearchNetworks);
        pnlSearchNetworks.Controls.Add(sep9);
        pnlSearchNetworks.Controls.Add(btnSearchNetworks);
        pnlSearchNetworks.Controls.Add(sep8);
        pnlSearchNetworks.Controls.Add(cboSearchNetworksPhysicalState);
        pnlSearchNetworks.Controls.Add(sep7);
        pnlSearchNetworks.Controls.Add(txtSearchNetworksName);
        pnlSearchNetworks.Location = new Point(3, 3);
        pnlSearchNetworks.Name = "pnlSearchNetworks";
        pnlSearchNetworks.Padding = new Padding(5);
        pnlSearchNetworks.Size = new Size(250, 387);
        pnlSearchNetworks.TabIndex = 3;
        // 
        // txtSearchNetworksName
        // 
        txtSearchNetworksName.Dock = DockStyle.Top;
        txtSearchNetworksName.Location = new Point(5, 5);
        txtSearchNetworksName.Name = "txtSearchNetworksName";
        txtSearchNetworksName.PlaceholderText = "name (optional)";
        txtSearchNetworksName.Size = new Size(238, 23);
        txtSearchNetworksName.TabIndex = 0;
        // 
        // sep7
        // 
        sep7.Dock = DockStyle.Top;
        sep7.Location = new Point(5, 28);
        sep7.Name = "sep7";
        sep7.Size = new Size(238, 5);
        sep7.TabIndex = 1;
        // 
        // cboSearchNetworksPhysicalState
        // 
        cboSearchNetworksPhysicalState.Dock = DockStyle.Top;
        cboSearchNetworksPhysicalState.Location = new Point(5, 33);
        cboSearchNetworksPhysicalState.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSearchNetworksPhysicalState.FormattingEnabled = true;
        cboSearchNetworksPhysicalState.Name = "cboSearchNetworksPhysicalState";
        cboSearchNetworksPhysicalState.Size = new Size(238, 23);
        cboSearchNetworksPhysicalState.TabIndex = 2;
        // 
        // sep8
        // 
        sep8.Dock = DockStyle.Top;
        sep8.Location = new Point(5, 56);
        sep8.Name = "sep8";
        sep8.Size = new Size(238, 5);
        sep8.TabIndex = 3;
        // 
        // btnSearchNetworks
        // 
        btnSearchNetworks.Dock = DockStyle.Top;
        btnSearchNetworks.Location = new Point(5, 61);
        btnSearchNetworks.Name = "btnSearchNetworks";
        btnSearchNetworks.Size = new Size(238, 23);
        btnSearchNetworks.TabIndex = 4;
        btnSearchNetworks.Text = "Search Networks";
        btnSearchNetworks.UseVisualStyleBackColor = true;
        btnSearchNetworks.Click += btnSearchNetworks_Click;
        // 
        // sep9
        // 
        sep9.Dock = DockStyle.Top;
        sep9.Location = new Point(5, 84);
        sep9.Name = "sep9";
        sep9.Size = new Size(238, 5);
        sep9.TabIndex = 5;
        // 
        // gridSearchNetworks
        // 
        gridSearchNetworks.Dock = DockStyle.Top;
        gridSearchNetworks.Location = new Point(5, 89);
        gridSearchNetworks.HelpVisible = false;
        gridSearchNetworks.Name = "gridSearchNetworks";
        gridSearchNetworks.PropertySort = PropertySort.NoSort;
        gridSearchNetworks.Size = new Size(238, 291);
        gridSearchNetworks.TabIndex = 6;
        gridSearchNetworks.ToolbarVisible = false;
        // 
        // pnlNetworkConfiguration
        // 
        pnlNetworkConfiguration.BorderStyle = BorderStyle.FixedSingle;
        pnlNetworkConfiguration.Controls.Add(txtSetNetworkConfigurationTypeResult);
        pnlNetworkConfiguration.Controls.Add(sep14);
        pnlNetworkConfiguration.Controls.Add(btnSetNetworkConfigurationType);
        pnlNetworkConfiguration.Controls.Add(sep13);
        pnlNetworkConfiguration.Controls.Add(cboSetNetworkConfigurationType);
        pnlNetworkConfiguration.Controls.Add(sep12);
        pnlNetworkConfiguration.Controls.Add(gridNetworkConfiguration);
        pnlNetworkConfiguration.Controls.Add(sep11);
        pnlNetworkConfiguration.Controls.Add(btnGetNetworkConfiguration);
        pnlNetworkConfiguration.Controls.Add(sep10);
        pnlNetworkConfiguration.Controls.Add(txtNetworkConfigurationNetwork);
        pnlNetworkConfiguration.Location = new Point(3, 3);
        pnlNetworkConfiguration.Name = "pnlNetworkConfiguration";
        pnlNetworkConfiguration.Padding = new Padding(5);
        pnlNetworkConfiguration.Size = new Size(250, 215);
        pnlNetworkConfiguration.TabIndex = 4;
        // 
        // txtNetworkConfigurationNetwork
        // 
        txtNetworkConfigurationNetwork.Dock = DockStyle.Top;
        txtNetworkConfigurationNetwork.Location = new Point(5, 5);
        txtNetworkConfigurationNetwork.Name = "txtNetworkConfigurationNetwork";
        txtNetworkConfigurationNetwork.PlaceholderText = "network";
        txtNetworkConfigurationNetwork.Size = new Size(238, 23);
        txtNetworkConfigurationNetwork.TabIndex = 0;
        txtNetworkConfigurationNetwork.Text = "Local";
        // 
        // sep10
        // 
        sep10.Dock = DockStyle.Top;
        sep10.Location = new Point(5, 28);
        sep10.Name = "sep10";
        sep10.Size = new Size(238, 5);
        sep10.TabIndex = 1;
        // 
        // btnGetNetworkConfiguration
        // 
        btnGetNetworkConfiguration.Dock = DockStyle.Top;
        btnGetNetworkConfiguration.Location = new Point(5, 33);
        btnGetNetworkConfiguration.Name = "btnGetNetworkConfiguration";
        btnGetNetworkConfiguration.Size = new Size(238, 23);
        btnGetNetworkConfiguration.TabIndex = 2;
        btnGetNetworkConfiguration.Text = "Get Network configuration";
        btnGetNetworkConfiguration.UseVisualStyleBackColor = true;
        btnGetNetworkConfiguration.Click += btnGetNetworkConfiguration_Click;
        // 
        // sep11
        // 
        sep11.Dock = DockStyle.Top;
        sep11.Location = new Point(5, 56);
        sep11.Name = "sep11";
        sep11.Size = new Size(238, 5);
        sep11.TabIndex = 3;
        // 
        // gridNetworkConfiguration
        // 
        gridNetworkConfiguration.Dock = DockStyle.Top;
        gridNetworkConfiguration.Location = new Point(5, 61);
        gridNetworkConfiguration.HelpVisible = false;
        gridNetworkConfiguration.Name = "gridNetworkConfiguration";
        gridNetworkConfiguration.PropertySort = PropertySort.NoSort;
        gridNetworkConfiguration.Size = new Size(238, 63);
        gridNetworkConfiguration.TabIndex = 4;
        gridNetworkConfiguration.ToolbarVisible = false;
        // 
        // sep12
        // 
        sep12.Dock = DockStyle.Top;
        sep12.Location = new Point(5, 124);
        sep12.Name = "sep12";
        sep12.Size = new Size(238, 5);
        sep12.TabIndex = 5;
        // 
        // cboSetNetworkConfigurationType
        // 
        cboSetNetworkConfigurationType.Dock = DockStyle.Top;
        cboSetNetworkConfigurationType.Location = new Point(5, 129);
        cboSetNetworkConfigurationType.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSetNetworkConfigurationType.FormattingEnabled = true;
        cboSetNetworkConfigurationType.Name = "cboSetNetworkConfigurationType";
        cboSetNetworkConfigurationType.Size = new Size(238, 23);
        cboSetNetworkConfigurationType.TabIndex = 6;
        // 
        // sep13
        // 
        sep13.Dock = DockStyle.Top;
        sep13.Location = new Point(5, 152);
        sep13.Name = "sep13";
        sep13.Size = new Size(238, 5);
        sep13.TabIndex = 7;
        // 
        // btnSetNetworkConfigurationType
        // 
        btnSetNetworkConfigurationType.Dock = DockStyle.Top;
        btnSetNetworkConfigurationType.Location = new Point(5, 157);
        btnSetNetworkConfigurationType.Name = "btnSetNetworkConfigurationType";
        btnSetNetworkConfigurationType.Size = new Size(238, 23);
        btnSetNetworkConfigurationType.TabIndex = 8;
        btnSetNetworkConfigurationType.Text = "Set Network configuration type";
        btnSetNetworkConfigurationType.UseVisualStyleBackColor = true;
        btnSetNetworkConfigurationType.Click += btnSetNetworkConfigurationType_Click;
        // 
        // sep14
        // 
        sep14.Dock = DockStyle.Top;
        sep14.Location = new Point(5, 180);
        sep14.Name = "sep14";
        sep14.Size = new Size(238, 5);
        sep14.TabIndex = 9;
        // 
        // txtSetNetworkConfigurationTypeResult
        // 
        txtSetNetworkConfigurationTypeResult.Dock = DockStyle.Top;
        txtSetNetworkConfigurationTypeResult.Location = new Point(5, 185);
        txtSetNetworkConfigurationTypeResult.Name = "txtSetNetworkConfigurationTypeResult";
        txtSetNetworkConfigurationTypeResult.PlaceholderText = "client action";
        txtSetNetworkConfigurationTypeResult.ReadOnly = true;
        txtSetNetworkConfigurationTypeResult.Size = new Size(238, 23);
        txtSetNetworkConfigurationTypeResult.TabIndex = 10;
        // 
        // tabDevices
        // 
        tabDevices.Controls.Add(flowDevices);
        tabDevices.Location = new Point(4, 24);
        tabDevices.Name = "tabDevices";
        tabDevices.Padding = new Padding(3);
        tabDevices.Size = new Size(882, 463);
        tabDevices.TabIndex = 1;
        tabDevices.Text = "Devices";
        tabDevices.UseVisualStyleBackColor = true;
        // 
        // flowDevices
        // 
        flowDevices.AutoScroll = true;
        flowDevices.Controls.Add(pnlDevices);
        flowDevices.Controls.Add(pnlDevice);
        flowDevices.Controls.Add(pnlSearchDevices);
        flowDevices.Controls.Add(pnlDeviceConfiguration);
        flowDevices.Controls.Add(pnlDeviceUpgradeInfo);
        flowDevices.Dock = DockStyle.Fill;
        flowDevices.FlowDirection = FlowDirection.TopDown;
        flowDevices.Location = new Point(3, 3);
        flowDevices.Name = "flowDevices";
        flowDevices.Size = new Size(876, 457);
        flowDevices.TabIndex = 0;
        // 
        // pnlDevices
        // 
        pnlDevices.BorderStyle = BorderStyle.FixedSingle;
        pnlDevices.Controls.Add(gridDevices);
        pnlDevices.Controls.Add(sep15);
        pnlDevices.Controls.Add(btnGetDevices);
        pnlDevices.Location = new Point(3, 3);
        pnlDevices.Name = "pnlDevices";
        pnlDevices.Padding = new Padding(5);
        pnlDevices.Size = new Size(250, 445);
        pnlDevices.TabIndex = 0;
        // 
        // btnGetDevices
        // 
        btnGetDevices.Dock = DockStyle.Top;
        btnGetDevices.Location = new Point(5, 5);
        btnGetDevices.Name = "btnGetDevices";
        btnGetDevices.Size = new Size(238, 23);
        btnGetDevices.TabIndex = 0;
        btnGetDevices.Text = "Get Devices";
        btnGetDevices.UseVisualStyleBackColor = true;
        btnGetDevices.Click += btnGetDevices_Click;
        // 
        // sep15
        // 
        sep15.Dock = DockStyle.Top;
        sep15.Location = new Point(5, 28);
        sep15.Name = "sep15";
        sep15.Size = new Size(238, 5);
        sep15.TabIndex = 1;
        // 
        // gridDevices
        // 
        gridDevices.Dock = DockStyle.Top;
        gridDevices.Location = new Point(5, 33);
        gridDevices.HelpVisible = false;
        gridDevices.Name = "gridDevices";
        gridDevices.PropertySort = PropertySort.NoSort;
        gridDevices.Size = new Size(238, 405);
        gridDevices.TabIndex = 2;
        gridDevices.ToolbarVisible = false;
        // 
        // pnlDevice
        // 
        pnlDevice.BorderStyle = BorderStyle.FixedSingle;
        pnlDevice.Controls.Add(btnSetDeviceState);
        pnlDevice.Controls.Add(sep20);
        pnlDevice.Controls.Add(cboSetDeviceStateLogicalState);
        pnlDevice.Controls.Add(sep19);
        pnlDevice.Controls.Add(gridDevice);
        pnlDevice.Controls.Add(sep18);
        pnlDevice.Controls.Add(btnGetDevice);
        pnlDevice.Controls.Add(sep17);
        pnlDevice.Controls.Add(txtGetDeviceDevice);
        pnlDevice.Controls.Add(sep16);
        pnlDevice.Controls.Add(txtGetDeviceNetwork);
        pnlDevice.Location = new Point(3, 3);
        pnlDevice.Name = "pnlDevice";
        pnlDevice.Padding = new Padding(5);
        pnlDevice.Size = new Size(250, 367);
        pnlDevice.TabIndex = 1;
        // 
        // txtGetDeviceNetwork
        // 
        txtGetDeviceNetwork.Dock = DockStyle.Top;
        txtGetDeviceNetwork.Location = new Point(5, 5);
        txtGetDeviceNetwork.Name = "txtGetDeviceNetwork";
        txtGetDeviceNetwork.PlaceholderText = "network";
        txtGetDeviceNetwork.Size = new Size(238, 23);
        txtGetDeviceNetwork.TabIndex = 0;
        txtGetDeviceNetwork.Text = "Local";
        // 
        // sep16
        // 
        sep16.Dock = DockStyle.Top;
        sep16.Location = new Point(5, 28);
        sep16.Name = "sep16";
        sep16.Size = new Size(238, 5);
        sep16.TabIndex = 1;
        // 
        // txtGetDeviceDevice
        // 
        txtGetDeviceDevice.Dock = DockStyle.Top;
        txtGetDeviceDevice.Location = new Point(5, 33);
        txtGetDeviceDevice.Name = "txtGetDeviceDevice";
        txtGetDeviceDevice.PlaceholderText = "device";
        txtGetDeviceDevice.Size = new Size(238, 23);
        txtGetDeviceDevice.TabIndex = 2;
        txtGetDeviceDevice.Text = "DRV_1";
        // 
        // sep17
        // 
        sep17.Dock = DockStyle.Top;
        sep17.Location = new Point(5, 56);
        sep17.Name = "sep17";
        sep17.Size = new Size(238, 5);
        sep17.TabIndex = 3;
        // 
        // btnGetDevice
        // 
        btnGetDevice.Dock = DockStyle.Top;
        btnGetDevice.Location = new Point(5, 61);
        btnGetDevice.Name = "btnGetDevice";
        btnGetDevice.Size = new Size(238, 23);
        btnGetDevice.TabIndex = 4;
        btnGetDevice.Text = "Get Device";
        btnGetDevice.UseVisualStyleBackColor = true;
        btnGetDevice.Click += btnGetDevice_Click;
        // 
        // sep18
        // 
        sep18.Dock = DockStyle.Top;
        sep18.Location = new Point(5, 84);
        sep18.Name = "sep18";
        sep18.Size = new Size(238, 5);
        sep18.TabIndex = 5;
        // 
        // gridDevice
        // 
        gridDevice.Dock = DockStyle.Top;
        gridDevice.Location = new Point(5, 89);
        gridDevice.HelpVisible = false;
        gridDevice.Name = "gridDevice";
        gridDevice.PropertySort = PropertySort.NoSort;
        gridDevice.Size = new Size(238, 215);
        gridDevice.TabIndex = 6;
        gridDevice.ToolbarVisible = false;
        // 
        // sep19
        // 
        sep19.Dock = DockStyle.Top;
        sep19.Location = new Point(5, 304);
        sep19.Name = "sep19";
        sep19.Size = new Size(238, 5);
        sep19.TabIndex = 7;
        // 
        // cboSetDeviceStateLogicalState
        // 
        cboSetDeviceStateLogicalState.Dock = DockStyle.Top;
        cboSetDeviceStateLogicalState.Location = new Point(5, 309);
        cboSetDeviceStateLogicalState.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSetDeviceStateLogicalState.FormattingEnabled = true;
        cboSetDeviceStateLogicalState.Name = "cboSetDeviceStateLogicalState";
        cboSetDeviceStateLogicalState.Size = new Size(238, 23);
        cboSetDeviceStateLogicalState.TabIndex = 8;
        // 
        // sep20
        // 
        sep20.Dock = DockStyle.Top;
        sep20.Location = new Point(5, 332);
        sep20.Name = "sep20";
        sep20.Size = new Size(238, 5);
        sep20.TabIndex = 9;
        // 
        // btnSetDeviceState
        // 
        btnSetDeviceState.Dock = DockStyle.Top;
        btnSetDeviceState.Location = new Point(5, 337);
        btnSetDeviceState.Name = "btnSetDeviceState";
        btnSetDeviceState.Size = new Size(238, 23);
        btnSetDeviceState.TabIndex = 10;
        btnSetDeviceState.Text = "Set Device state";
        btnSetDeviceState.UseVisualStyleBackColor = true;
        btnSetDeviceState.Click += btnSetDeviceState_Click;
        // 
        // pnlSearchDevices
        // 
        pnlSearchDevices.BorderStyle = BorderStyle.FixedSingle;
        pnlSearchDevices.Controls.Add(gridSearchDevices);
        pnlSearchDevices.Controls.Add(sep24);
        pnlSearchDevices.Controls.Add(btnSearchDevices);
        pnlSearchDevices.Controls.Add(sep23);
        pnlSearchDevices.Controls.Add(txtSearchDevicesNetwork);
        pnlSearchDevices.Controls.Add(sep22);
        pnlSearchDevices.Controls.Add(cboSearchDevicesLogicalState);
        pnlSearchDevices.Controls.Add(sep21);
        pnlSearchDevices.Controls.Add(txtSearchDevicesName);
        pnlSearchDevices.Location = new Point(3, 3);
        pnlSearchDevices.Name = "pnlSearchDevices";
        pnlSearchDevices.Padding = new Padding(5);
        pnlSearchDevices.Size = new Size(250, 415);
        pnlSearchDevices.TabIndex = 2;
        // 
        // txtSearchDevicesName
        // 
        txtSearchDevicesName.Dock = DockStyle.Top;
        txtSearchDevicesName.Location = new Point(5, 5);
        txtSearchDevicesName.Name = "txtSearchDevicesName";
        txtSearchDevicesName.PlaceholderText = "name (optional)";
        txtSearchDevicesName.Size = new Size(238, 23);
        txtSearchDevicesName.TabIndex = 0;
        // 
        // sep21
        // 
        sep21.Dock = DockStyle.Top;
        sep21.Location = new Point(5, 28);
        sep21.Name = "sep21";
        sep21.Size = new Size(238, 5);
        sep21.TabIndex = 1;
        // 
        // cboSearchDevicesLogicalState
        // 
        cboSearchDevicesLogicalState.Dock = DockStyle.Top;
        cboSearchDevicesLogicalState.Location = new Point(5, 33);
        cboSearchDevicesLogicalState.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSearchDevicesLogicalState.FormattingEnabled = true;
        cboSearchDevicesLogicalState.Name = "cboSearchDevicesLogicalState";
        cboSearchDevicesLogicalState.Size = new Size(238, 23);
        cboSearchDevicesLogicalState.TabIndex = 2;
        // 
        // sep22
        // 
        sep22.Dock = DockStyle.Top;
        sep22.Location = new Point(5, 56);
        sep22.Name = "sep22";
        sep22.Size = new Size(238, 5);
        sep22.TabIndex = 3;
        // 
        // txtSearchDevicesNetwork
        // 
        txtSearchDevicesNetwork.Dock = DockStyle.Top;
        txtSearchDevicesNetwork.Location = new Point(5, 61);
        txtSearchDevicesNetwork.Name = "txtSearchDevicesNetwork";
        txtSearchDevicesNetwork.PlaceholderText = "network (optional)";
        txtSearchDevicesNetwork.Size = new Size(238, 23);
        txtSearchDevicesNetwork.TabIndex = 4;
        // 
        // sep23
        // 
        sep23.Dock = DockStyle.Top;
        sep23.Location = new Point(5, 84);
        sep23.Name = "sep23";
        sep23.Size = new Size(238, 5);
        sep23.TabIndex = 5;
        // 
        // btnSearchDevices
        // 
        btnSearchDevices.Dock = DockStyle.Top;
        btnSearchDevices.Location = new Point(5, 89);
        btnSearchDevices.Name = "btnSearchDevices";
        btnSearchDevices.Size = new Size(238, 23);
        btnSearchDevices.TabIndex = 6;
        btnSearchDevices.Text = "Search Devices";
        btnSearchDevices.UseVisualStyleBackColor = true;
        btnSearchDevices.Click += btnSearchDevices_Click;
        // 
        // sep24
        // 
        sep24.Dock = DockStyle.Top;
        sep24.Location = new Point(5, 112);
        sep24.Name = "sep24";
        sep24.Size = new Size(238, 5);
        sep24.TabIndex = 7;
        // 
        // gridSearchDevices
        // 
        gridSearchDevices.Dock = DockStyle.Top;
        gridSearchDevices.Location = new Point(5, 117);
        gridSearchDevices.HelpVisible = false;
        gridSearchDevices.Name = "gridSearchDevices";
        gridSearchDevices.PropertySort = PropertySort.NoSort;
        gridSearchDevices.Size = new Size(238, 291);
        gridSearchDevices.TabIndex = 8;
        gridSearchDevices.ToolbarVisible = false;
        // 
        // pnlDeviceConfiguration
        // 
        pnlDeviceConfiguration.BorderStyle = BorderStyle.FixedSingle;
        pnlDeviceConfiguration.Controls.Add(gridDeviceConfiguration);
        pnlDeviceConfiguration.Controls.Add(sep27);
        pnlDeviceConfiguration.Controls.Add(btnGetDeviceConfiguration);
        pnlDeviceConfiguration.Controls.Add(sep26);
        pnlDeviceConfiguration.Controls.Add(txtDeviceConfigurationDevice);
        pnlDeviceConfiguration.Controls.Add(sep25);
        pnlDeviceConfiguration.Controls.Add(txtDeviceConfigurationNetwork);
        pnlDeviceConfiguration.Location = new Point(3, 3);
        pnlDeviceConfiguration.Name = "pnlDeviceConfiguration";
        pnlDeviceConfiguration.Padding = new Padding(5);
        pnlDeviceConfiguration.Size = new Size(250, 311);
        pnlDeviceConfiguration.TabIndex = 3;
        // 
        // txtDeviceConfigurationNetwork
        // 
        txtDeviceConfigurationNetwork.Dock = DockStyle.Top;
        txtDeviceConfigurationNetwork.Location = new Point(5, 5);
        txtDeviceConfigurationNetwork.Name = "txtDeviceConfigurationNetwork";
        txtDeviceConfigurationNetwork.PlaceholderText = "network";
        txtDeviceConfigurationNetwork.Size = new Size(238, 23);
        txtDeviceConfigurationNetwork.TabIndex = 0;
        txtDeviceConfigurationNetwork.Text = "Local";
        // 
        // sep25
        // 
        sep25.Dock = DockStyle.Top;
        sep25.Location = new Point(5, 28);
        sep25.Name = "sep25";
        sep25.Size = new Size(238, 5);
        sep25.TabIndex = 1;
        // 
        // txtDeviceConfigurationDevice
        // 
        txtDeviceConfigurationDevice.Dock = DockStyle.Top;
        txtDeviceConfigurationDevice.Location = new Point(5, 33);
        txtDeviceConfigurationDevice.Name = "txtDeviceConfigurationDevice";
        txtDeviceConfigurationDevice.PlaceholderText = "device";
        txtDeviceConfigurationDevice.Size = new Size(238, 23);
        txtDeviceConfigurationDevice.TabIndex = 2;
        txtDeviceConfigurationDevice.Text = "DRV_1";
        // 
        // sep26
        // 
        sep26.Dock = DockStyle.Top;
        sep26.Location = new Point(5, 56);
        sep26.Name = "sep26";
        sep26.Size = new Size(238, 5);
        sep26.TabIndex = 3;
        // 
        // btnGetDeviceConfiguration
        // 
        btnGetDeviceConfiguration.Dock = DockStyle.Top;
        btnGetDeviceConfiguration.Location = new Point(5, 61);
        btnGetDeviceConfiguration.Name = "btnGetDeviceConfiguration";
        btnGetDeviceConfiguration.Size = new Size(238, 23);
        btnGetDeviceConfiguration.TabIndex = 4;
        btnGetDeviceConfiguration.Text = "Get Device configuration";
        btnGetDeviceConfiguration.UseVisualStyleBackColor = true;
        btnGetDeviceConfiguration.Click += btnGetDeviceConfiguration_Click;
        // 
        // sep27
        // 
        sep27.Dock = DockStyle.Top;
        sep27.Location = new Point(5, 84);
        sep27.Name = "sep27";
        sep27.Size = new Size(238, 5);
        sep27.TabIndex = 5;
        // 
        // gridDeviceConfiguration
        // 
        gridDeviceConfiguration.Dock = DockStyle.Top;
        gridDeviceConfiguration.Location = new Point(5, 89);
        gridDeviceConfiguration.HelpVisible = false;
        gridDeviceConfiguration.Name = "gridDeviceConfiguration";
        gridDeviceConfiguration.PropertySort = PropertySort.NoSort;
        gridDeviceConfiguration.Size = new Size(238, 215);
        gridDeviceConfiguration.TabIndex = 6;
        gridDeviceConfiguration.ToolbarVisible = false;
        // 
        // pnlDeviceUpgradeInfo
        // 
        pnlDeviceUpgradeInfo.BorderStyle = BorderStyle.FixedSingle;
        pnlDeviceUpgradeInfo.Controls.Add(gridDeviceUpgradeInfo);
        pnlDeviceUpgradeInfo.Controls.Add(sep30);
        pnlDeviceUpgradeInfo.Controls.Add(btnGetDeviceUpgradeInfo);
        pnlDeviceUpgradeInfo.Controls.Add(sep29);
        pnlDeviceUpgradeInfo.Controls.Add(txtDeviceUpgradeInfoDevice);
        pnlDeviceUpgradeInfo.Controls.Add(sep28);
        pnlDeviceUpgradeInfo.Controls.Add(txtDeviceUpgradeInfoNetwork);
        pnlDeviceUpgradeInfo.Location = new Point(3, 3);
        pnlDeviceUpgradeInfo.Name = "pnlDeviceUpgradeInfo";
        pnlDeviceUpgradeInfo.Padding = new Padding(5);
        pnlDeviceUpgradeInfo.Size = new Size(250, 406);
        pnlDeviceUpgradeInfo.TabIndex = 4;
        // 
        // txtDeviceUpgradeInfoNetwork
        // 
        txtDeviceUpgradeInfoNetwork.Dock = DockStyle.Top;
        txtDeviceUpgradeInfoNetwork.Location = new Point(5, 5);
        txtDeviceUpgradeInfoNetwork.Name = "txtDeviceUpgradeInfoNetwork";
        txtDeviceUpgradeInfoNetwork.PlaceholderText = "network";
        txtDeviceUpgradeInfoNetwork.Size = new Size(238, 23);
        txtDeviceUpgradeInfoNetwork.TabIndex = 0;
        txtDeviceUpgradeInfoNetwork.Text = "Local";
        // 
        // sep28
        // 
        sep28.Dock = DockStyle.Top;
        sep28.Location = new Point(5, 28);
        sep28.Name = "sep28";
        sep28.Size = new Size(238, 5);
        sep28.TabIndex = 1;
        // 
        // txtDeviceUpgradeInfoDevice
        // 
        txtDeviceUpgradeInfoDevice.Dock = DockStyle.Top;
        txtDeviceUpgradeInfoDevice.Location = new Point(5, 33);
        txtDeviceUpgradeInfoDevice.Name = "txtDeviceUpgradeInfoDevice";
        txtDeviceUpgradeInfoDevice.PlaceholderText = "device";
        txtDeviceUpgradeInfoDevice.Size = new Size(238, 23);
        txtDeviceUpgradeInfoDevice.TabIndex = 2;
        txtDeviceUpgradeInfoDevice.Text = "DRV_1";
        // 
        // sep29
        // 
        sep29.Dock = DockStyle.Top;
        sep29.Location = new Point(5, 56);
        sep29.Name = "sep29";
        sep29.Size = new Size(238, 5);
        sep29.TabIndex = 3;
        // 
        // btnGetDeviceUpgradeInfo
        // 
        btnGetDeviceUpgradeInfo.Dock = DockStyle.Top;
        btnGetDeviceUpgradeInfo.Location = new Point(5, 61);
        btnGetDeviceUpgradeInfo.Name = "btnGetDeviceUpgradeInfo";
        btnGetDeviceUpgradeInfo.Size = new Size(238, 23);
        btnGetDeviceUpgradeInfo.TabIndex = 4;
        btnGetDeviceUpgradeInfo.Text = "Get Device upgrade info";
        btnGetDeviceUpgradeInfo.UseVisualStyleBackColor = true;
        btnGetDeviceUpgradeInfo.Click += btnGetDeviceUpgradeInfo_Click;
        // 
        // sep30
        // 
        sep30.Dock = DockStyle.Top;
        sep30.Location = new Point(5, 84);
        sep30.Name = "sep30";
        sep30.Size = new Size(238, 5);
        sep30.TabIndex = 5;
        // 
        // gridDeviceUpgradeInfo
        // 
        gridDeviceUpgradeInfo.Dock = DockStyle.Top;
        gridDeviceUpgradeInfo.Location = new Point(5, 89);
        gridDeviceUpgradeInfo.HelpVisible = false;
        gridDeviceUpgradeInfo.Name = "gridDeviceUpgradeInfo";
        gridDeviceUpgradeInfo.PropertySort = PropertySort.NoSort;
        gridDeviceUpgradeInfo.Size = new Size(238, 310);
        gridDeviceUpgradeInfo.TabIndex = 6;
        gridDeviceUpgradeInfo.ToolbarVisible = false;
        // 
        // tabDeviceData
        // 
        tabDeviceData.Controls.Add(flowDeviceData);
        tabDeviceData.Location = new Point(4, 24);
        tabDeviceData.Name = "tabDeviceData";
        tabDeviceData.Padding = new Padding(3);
        tabDeviceData.Size = new Size(882, 463);
        tabDeviceData.TabIndex = 2;
        tabDeviceData.Text = "Device data";
        tabDeviceData.UseVisualStyleBackColor = true;
        // 
        // flowDeviceData
        // 
        flowDeviceData.AutoScroll = true;
        flowDeviceData.Controls.Add(pnlDeviceInputData);
        flowDeviceData.Controls.Add(pnlDeviceOutputData);
        flowDeviceData.Controls.Add(pnlDeviceCommand);
        flowDeviceData.Dock = DockStyle.Fill;
        flowDeviceData.FlowDirection = FlowDirection.TopDown;
        flowDeviceData.Location = new Point(3, 3);
        flowDeviceData.Name = "flowDeviceData";
        flowDeviceData.Size = new Size(876, 457);
        flowDeviceData.TabIndex = 0;
        // 
        // pnlDeviceInputData
        // 
        pnlDeviceInputData.BorderStyle = BorderStyle.FixedSingle;
        pnlDeviceInputData.Controls.Add(btnSetDeviceInputData);
        pnlDeviceInputData.Controls.Add(sep35);
        pnlDeviceInputData.Controls.Add(numSetDeviceInputDataDataMask);
        pnlDeviceInputData.Controls.Add(sep34);
        pnlDeviceInputData.Controls.Add(numSetDeviceInputDataSignalData);
        pnlDeviceInputData.Controls.Add(sep33);
        pnlDeviceInputData.Controls.Add(numSetDeviceInputDataStartByte);
        pnlDeviceInputData.Controls.Add(sep32);
        pnlDeviceInputData.Controls.Add(txtSetDeviceInputDataDevice);
        pnlDeviceInputData.Controls.Add(sep31);
        pnlDeviceInputData.Controls.Add(txtSetDeviceInputDataNetwork);
        pnlDeviceInputData.Location = new Point(3, 3);
        pnlDeviceInputData.Name = "pnlDeviceInputData";
        pnlDeviceInputData.Padding = new Padding(5);
        pnlDeviceInputData.Size = new Size(250, 175);
        pnlDeviceInputData.TabIndex = 0;
        // 
        // txtSetDeviceInputDataNetwork
        // 
        txtSetDeviceInputDataNetwork.Dock = DockStyle.Top;
        txtSetDeviceInputDataNetwork.Location = new Point(5, 5);
        txtSetDeviceInputDataNetwork.Name = "txtSetDeviceInputDataNetwork";
        txtSetDeviceInputDataNetwork.PlaceholderText = "network";
        txtSetDeviceInputDataNetwork.Size = new Size(238, 23);
        txtSetDeviceInputDataNetwork.TabIndex = 0;
        txtSetDeviceInputDataNetwork.Text = "Local";
        // 
        // sep31
        // 
        sep31.Dock = DockStyle.Top;
        sep31.Location = new Point(5, 28);
        sep31.Name = "sep31";
        sep31.Size = new Size(238, 5);
        sep31.TabIndex = 1;
        // 
        // txtSetDeviceInputDataDevice
        // 
        txtSetDeviceInputDataDevice.Dock = DockStyle.Top;
        txtSetDeviceInputDataDevice.Location = new Point(5, 33);
        txtSetDeviceInputDataDevice.Name = "txtSetDeviceInputDataDevice";
        txtSetDeviceInputDataDevice.PlaceholderText = "device";
        txtSetDeviceInputDataDevice.Size = new Size(238, 23);
        txtSetDeviceInputDataDevice.TabIndex = 2;
        txtSetDeviceInputDataDevice.Text = "DRV_1";
        // 
        // sep32
        // 
        sep32.Dock = DockStyle.Top;
        sep32.Location = new Point(5, 56);
        sep32.Name = "sep32";
        sep32.Size = new Size(238, 5);
        sep32.TabIndex = 3;
        // 
        // numSetDeviceInputDataStartByte
        // 
        numSetDeviceInputDataStartByte.Dock = DockStyle.Top;
        numSetDeviceInputDataStartByte.Location = new Point(5, 61);
        numSetDeviceInputDataStartByte.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        numSetDeviceInputDataStartByte.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        numSetDeviceInputDataStartByte.Name = "numSetDeviceInputDataStartByte";
        numSetDeviceInputDataStartByte.Size = new Size(238, 23);
        numSetDeviceInputDataStartByte.TabIndex = 4;
        numSetDeviceInputDataStartByte.Value = new decimal(new int[] { 0, 0, 0, 0 });
        // 
        // sep33
        // 
        sep33.Dock = DockStyle.Top;
        sep33.Location = new Point(5, 84);
        sep33.Name = "sep33";
        sep33.Size = new Size(238, 5);
        sep33.TabIndex = 5;
        // 
        // numSetDeviceInputDataSignalData
        // 
        numSetDeviceInputDataSignalData.Dock = DockStyle.Top;
        numSetDeviceInputDataSignalData.Location = new Point(5, 89);
        numSetDeviceInputDataSignalData.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        numSetDeviceInputDataSignalData.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        numSetDeviceInputDataSignalData.Name = "numSetDeviceInputDataSignalData";
        numSetDeviceInputDataSignalData.Size = new Size(238, 23);
        numSetDeviceInputDataSignalData.TabIndex = 6;
        numSetDeviceInputDataSignalData.Value = new decimal(new int[] { 0, 0, 0, 0 });
        // 
        // sep34
        // 
        sep34.Dock = DockStyle.Top;
        sep34.Location = new Point(5, 112);
        sep34.Name = "sep34";
        sep34.Size = new Size(238, 5);
        sep34.TabIndex = 7;
        // 
        // numSetDeviceInputDataDataMask
        // 
        numSetDeviceInputDataDataMask.Dock = DockStyle.Top;
        numSetDeviceInputDataDataMask.Location = new Point(5, 117);
        numSetDeviceInputDataDataMask.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        numSetDeviceInputDataDataMask.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        numSetDeviceInputDataDataMask.Name = "numSetDeviceInputDataDataMask";
        numSetDeviceInputDataDataMask.Size = new Size(238, 23);
        numSetDeviceInputDataDataMask.TabIndex = 8;
        numSetDeviceInputDataDataMask.Value = new decimal(new int[] { 255, 0, 0, 0 });
        // 
        // sep35
        // 
        sep35.Dock = DockStyle.Top;
        sep35.Location = new Point(5, 140);
        sep35.Name = "sep35";
        sep35.Size = new Size(238, 5);
        sep35.TabIndex = 9;
        // 
        // btnSetDeviceInputData
        // 
        btnSetDeviceInputData.Dock = DockStyle.Top;
        btnSetDeviceInputData.Location = new Point(5, 145);
        btnSetDeviceInputData.Name = "btnSetDeviceInputData";
        btnSetDeviceInputData.Size = new Size(238, 23);
        btnSetDeviceInputData.TabIndex = 10;
        btnSetDeviceInputData.Text = "Set Device input data";
        btnSetDeviceInputData.UseVisualStyleBackColor = true;
        btnSetDeviceInputData.Click += btnSetDeviceInputData_Click;
        // 
        // pnlDeviceOutputData
        // 
        pnlDeviceOutputData.BorderStyle = BorderStyle.FixedSingle;
        pnlDeviceOutputData.Controls.Add(btnSetDeviceOutputData);
        pnlDeviceOutputData.Controls.Add(sep40);
        pnlDeviceOutputData.Controls.Add(numSetDeviceOutputDataDataMask);
        pnlDeviceOutputData.Controls.Add(sep39);
        pnlDeviceOutputData.Controls.Add(numSetDeviceOutputDataSignalData);
        pnlDeviceOutputData.Controls.Add(sep38);
        pnlDeviceOutputData.Controls.Add(numSetDeviceOutputDataStartByte);
        pnlDeviceOutputData.Controls.Add(sep37);
        pnlDeviceOutputData.Controls.Add(txtSetDeviceOutputDataDevice);
        pnlDeviceOutputData.Controls.Add(sep36);
        pnlDeviceOutputData.Controls.Add(txtSetDeviceOutputDataNetwork);
        pnlDeviceOutputData.Location = new Point(3, 3);
        pnlDeviceOutputData.Name = "pnlDeviceOutputData";
        pnlDeviceOutputData.Padding = new Padding(5);
        pnlDeviceOutputData.Size = new Size(250, 175);
        pnlDeviceOutputData.TabIndex = 1;
        // 
        // txtSetDeviceOutputDataNetwork
        // 
        txtSetDeviceOutputDataNetwork.Dock = DockStyle.Top;
        txtSetDeviceOutputDataNetwork.Location = new Point(5, 5);
        txtSetDeviceOutputDataNetwork.Name = "txtSetDeviceOutputDataNetwork";
        txtSetDeviceOutputDataNetwork.PlaceholderText = "network";
        txtSetDeviceOutputDataNetwork.Size = new Size(238, 23);
        txtSetDeviceOutputDataNetwork.TabIndex = 0;
        txtSetDeviceOutputDataNetwork.Text = "Local";
        // 
        // sep36
        // 
        sep36.Dock = DockStyle.Top;
        sep36.Location = new Point(5, 28);
        sep36.Name = "sep36";
        sep36.Size = new Size(238, 5);
        sep36.TabIndex = 1;
        // 
        // txtSetDeviceOutputDataDevice
        // 
        txtSetDeviceOutputDataDevice.Dock = DockStyle.Top;
        txtSetDeviceOutputDataDevice.Location = new Point(5, 33);
        txtSetDeviceOutputDataDevice.Name = "txtSetDeviceOutputDataDevice";
        txtSetDeviceOutputDataDevice.PlaceholderText = "device";
        txtSetDeviceOutputDataDevice.Size = new Size(238, 23);
        txtSetDeviceOutputDataDevice.TabIndex = 2;
        txtSetDeviceOutputDataDevice.Text = "DRV_1";
        // 
        // sep37
        // 
        sep37.Dock = DockStyle.Top;
        sep37.Location = new Point(5, 56);
        sep37.Name = "sep37";
        sep37.Size = new Size(238, 5);
        sep37.TabIndex = 3;
        // 
        // numSetDeviceOutputDataStartByte
        // 
        numSetDeviceOutputDataStartByte.Dock = DockStyle.Top;
        numSetDeviceOutputDataStartByte.Location = new Point(5, 61);
        numSetDeviceOutputDataStartByte.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        numSetDeviceOutputDataStartByte.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        numSetDeviceOutputDataStartByte.Name = "numSetDeviceOutputDataStartByte";
        numSetDeviceOutputDataStartByte.Size = new Size(238, 23);
        numSetDeviceOutputDataStartByte.TabIndex = 4;
        numSetDeviceOutputDataStartByte.Value = new decimal(new int[] { 0, 0, 0, 0 });
        // 
        // sep38
        // 
        sep38.Dock = DockStyle.Top;
        sep38.Location = new Point(5, 84);
        sep38.Name = "sep38";
        sep38.Size = new Size(238, 5);
        sep38.TabIndex = 5;
        // 
        // numSetDeviceOutputDataSignalData
        // 
        numSetDeviceOutputDataSignalData.Dock = DockStyle.Top;
        numSetDeviceOutputDataSignalData.Location = new Point(5, 89);
        numSetDeviceOutputDataSignalData.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        numSetDeviceOutputDataSignalData.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        numSetDeviceOutputDataSignalData.Name = "numSetDeviceOutputDataSignalData";
        numSetDeviceOutputDataSignalData.Size = new Size(238, 23);
        numSetDeviceOutputDataSignalData.TabIndex = 6;
        numSetDeviceOutputDataSignalData.Value = new decimal(new int[] { 0, 0, 0, 0 });
        // 
        // sep39
        // 
        sep39.Dock = DockStyle.Top;
        sep39.Location = new Point(5, 112);
        sep39.Name = "sep39";
        sep39.Size = new Size(238, 5);
        sep39.TabIndex = 7;
        // 
        // numSetDeviceOutputDataDataMask
        // 
        numSetDeviceOutputDataDataMask.Dock = DockStyle.Top;
        numSetDeviceOutputDataDataMask.Location = new Point(5, 117);
        numSetDeviceOutputDataDataMask.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        numSetDeviceOutputDataDataMask.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        numSetDeviceOutputDataDataMask.Name = "numSetDeviceOutputDataDataMask";
        numSetDeviceOutputDataDataMask.Size = new Size(238, 23);
        numSetDeviceOutputDataDataMask.TabIndex = 8;
        numSetDeviceOutputDataDataMask.Value = new decimal(new int[] { 255, 0, 0, 0 });
        // 
        // sep40
        // 
        sep40.Dock = DockStyle.Top;
        sep40.Location = new Point(5, 140);
        sep40.Name = "sep40";
        sep40.Size = new Size(238, 5);
        sep40.TabIndex = 9;
        // 
        // btnSetDeviceOutputData
        // 
        btnSetDeviceOutputData.Dock = DockStyle.Top;
        btnSetDeviceOutputData.Location = new Point(5, 145);
        btnSetDeviceOutputData.Name = "btnSetDeviceOutputData";
        btnSetDeviceOutputData.Size = new Size(238, 23);
        btnSetDeviceOutputData.TabIndex = 10;
        btnSetDeviceOutputData.Text = "Set Device output data";
        btnSetDeviceOutputData.UseVisualStyleBackColor = true;
        btnSetDeviceOutputData.Click += btnSetDeviceOutputData_Click;
        // 
        // pnlDeviceCommand
        // 
        pnlDeviceCommand.BorderStyle = BorderStyle.FixedSingle;
        pnlDeviceCommand.Controls.Add(btnSendDeviceCommand);
        pnlDeviceCommand.Controls.Add(sep46);
        pnlDeviceCommand.Controls.Add(numSendDeviceCommandTimeout);
        pnlDeviceCommand.Controls.Add(sep45);
        pnlDeviceCommand.Controls.Add(numSendDeviceCommandValueLength);
        pnlDeviceCommand.Controls.Add(sep44);
        pnlDeviceCommand.Controls.Add(txtSendDeviceCommandValue);
        pnlDeviceCommand.Controls.Add(sep43);
        pnlDeviceCommand.Controls.Add(txtSendDeviceCommandCommandName);
        pnlDeviceCommand.Controls.Add(sep42);
        pnlDeviceCommand.Controls.Add(txtSendDeviceCommandDevice);
        pnlDeviceCommand.Controls.Add(sep41);
        pnlDeviceCommand.Controls.Add(txtSendDeviceCommandNetwork);
        pnlDeviceCommand.Location = new Point(3, 3);
        pnlDeviceCommand.Name = "pnlDeviceCommand";
        pnlDeviceCommand.Padding = new Padding(5);
        pnlDeviceCommand.Size = new Size(250, 203);
        pnlDeviceCommand.TabIndex = 2;
        // 
        // txtSendDeviceCommandNetwork
        // 
        txtSendDeviceCommandNetwork.Dock = DockStyle.Top;
        txtSendDeviceCommandNetwork.Location = new Point(5, 5);
        txtSendDeviceCommandNetwork.Name = "txtSendDeviceCommandNetwork";
        txtSendDeviceCommandNetwork.PlaceholderText = "network";
        txtSendDeviceCommandNetwork.Size = new Size(238, 23);
        txtSendDeviceCommandNetwork.TabIndex = 0;
        txtSendDeviceCommandNetwork.Text = "EtherNetIP";
        // 
        // sep41
        // 
        sep41.Dock = DockStyle.Top;
        sep41.Location = new Point(5, 28);
        sep41.Name = "sep41";
        sep41.Size = new Size(238, 5);
        sep41.TabIndex = 1;
        // 
        // txtSendDeviceCommandDevice
        // 
        txtSendDeviceCommandDevice.Dock = DockStyle.Top;
        txtSendDeviceCommandDevice.Location = new Point(5, 33);
        txtSendDeviceCommandDevice.Name = "txtSendDeviceCommandDevice";
        txtSendDeviceCommandDevice.PlaceholderText = "device";
        txtSendDeviceCommandDevice.Size = new Size(238, 23);
        txtSendDeviceCommandDevice.TabIndex = 2;
        txtSendDeviceCommandDevice.Text = "Local_IO";
        // 
        // sep42
        // 
        sep42.Dock = DockStyle.Top;
        sep42.Location = new Point(5, 56);
        sep42.Name = "sep42";
        sep42.Size = new Size(238, 5);
        sep42.TabIndex = 3;
        // 
        // txtSendDeviceCommandCommandName
        // 
        txtSendDeviceCommandCommandName.Dock = DockStyle.Top;
        txtSendDeviceCommandCommandName.Location = new Point(5, 61);
        txtSendDeviceCommandCommandName.Name = "txtSendDeviceCommandCommandName";
        txtSendDeviceCommandCommandName.PlaceholderText = "commandName";
        txtSendDeviceCommandCommandName.Size = new Size(238, 23);
        txtSendDeviceCommandCommandName.TabIndex = 4;
        txtSendDeviceCommandCommandName.Text = "FIRMWARE_INFO";
        // 
        // sep43
        // 
        sep43.Dock = DockStyle.Top;
        sep43.Location = new Point(5, 84);
        sep43.Name = "sep43";
        sep43.Size = new Size(238, 5);
        sep43.TabIndex = 5;
        // 
        // txtSendDeviceCommandValue
        // 
        txtSendDeviceCommandValue.Dock = DockStyle.Top;
        txtSendDeviceCommandValue.Location = new Point(5, 89);
        txtSendDeviceCommandValue.Name = "txtSendDeviceCommandValue";
        txtSendDeviceCommandValue.PlaceholderText = "value";
        txtSendDeviceCommandValue.Size = new Size(238, 23);
        txtSendDeviceCommandValue.TabIndex = 6;
        // 
        // sep44
        // 
        sep44.Dock = DockStyle.Top;
        sep44.Location = new Point(5, 112);
        sep44.Name = "sep44";
        sep44.Size = new Size(238, 5);
        sep44.TabIndex = 7;
        // 
        // numSendDeviceCommandValueLength
        // 
        numSendDeviceCommandValueLength.Dock = DockStyle.Top;
        numSendDeviceCommandValueLength.Location = new Point(5, 117);
        numSendDeviceCommandValueLength.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numSendDeviceCommandValueLength.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        numSendDeviceCommandValueLength.Name = "numSendDeviceCommandValueLength";
        numSendDeviceCommandValueLength.Size = new Size(238, 23);
        numSendDeviceCommandValueLength.TabIndex = 8;
        numSendDeviceCommandValueLength.Value = new decimal(new int[] { 0, 0, 0, 0 });
        // 
        // sep45
        // 
        sep45.Dock = DockStyle.Top;
        sep45.Location = new Point(5, 140);
        sep45.Name = "sep45";
        sep45.Size = new Size(238, 5);
        sep45.TabIndex = 9;
        // 
        // numSendDeviceCommandTimeout
        // 
        numSendDeviceCommandTimeout.Dock = DockStyle.Top;
        numSendDeviceCommandTimeout.Location = new Point(5, 145);
        numSendDeviceCommandTimeout.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numSendDeviceCommandTimeout.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        numSendDeviceCommandTimeout.Name = "numSendDeviceCommandTimeout";
        numSendDeviceCommandTimeout.Size = new Size(238, 23);
        numSendDeviceCommandTimeout.TabIndex = 10;
        numSendDeviceCommandTimeout.Value = new decimal(new int[] { 0, 0, 0, 0 });
        // 
        // sep46
        // 
        sep46.Dock = DockStyle.Top;
        sep46.Location = new Point(5, 168);
        sep46.Name = "sep46";
        sep46.Size = new Size(238, 5);
        sep46.TabIndex = 11;
        // 
        // btnSendDeviceCommand
        // 
        btnSendDeviceCommand.Dock = DockStyle.Top;
        btnSendDeviceCommand.Location = new Point(5, 173);
        btnSendDeviceCommand.Name = "btnSendDeviceCommand";
        btnSendDeviceCommand.Size = new Size(238, 23);
        btnSendDeviceCommand.TabIndex = 12;
        btnSendDeviceCommand.Text = "Send Device command";
        btnSendDeviceCommand.UseVisualStyleBackColor = true;
        btnSendDeviceCommand.Click += btnSendDeviceCommand_Click;
        // 
        // tabSignals
        // 
        tabSignals.Controls.Add(flowSignals);
        tabSignals.Location = new Point(4, 24);
        tabSignals.Name = "tabSignals";
        tabSignals.Padding = new Padding(3);
        tabSignals.Size = new Size(882, 463);
        tabSignals.TabIndex = 3;
        tabSignals.Text = "Signals";
        tabSignals.UseVisualStyleBackColor = true;
        // 
        // flowSignals
        // 
        flowSignals.AutoScroll = true;
        flowSignals.Controls.Add(pnlSignals);
        flowSignals.Controls.Add(pnlSignal);
        flowSignals.Controls.Add(pnlSignalConfiguration);
        flowSignals.Controls.Add(pnlUnblockSignals);
        flowSignals.Dock = DockStyle.Fill;
        flowSignals.FlowDirection = FlowDirection.TopDown;
        flowSignals.Location = new Point(3, 3);
        flowSignals.Name = "flowSignals";
        flowSignals.Size = new Size(876, 457);
        flowSignals.TabIndex = 0;
        // 
        // pnlSignals
        // 
        pnlSignals.BorderStyle = BorderStyle.FixedSingle;
        pnlSignals.Controls.Add(gridSignals);
        pnlSignals.Controls.Add(sep47);
        pnlSignals.Controls.Add(btnGetSignals);
        pnlSignals.Location = new Point(3, 3);
        pnlSignals.Name = "pnlSignals";
        pnlSignals.Padding = new Padding(5);
        pnlSignals.Size = new Size(250, 445);
        pnlSignals.TabIndex = 0;
        // 
        // btnGetSignals
        // 
        btnGetSignals.Dock = DockStyle.Top;
        btnGetSignals.Location = new Point(5, 5);
        btnGetSignals.Name = "btnGetSignals";
        btnGetSignals.Size = new Size(238, 23);
        btnGetSignals.TabIndex = 0;
        btnGetSignals.Text = "Get Signals";
        btnGetSignals.UseVisualStyleBackColor = true;
        btnGetSignals.Click += btnGetSignals_Click;
        // 
        // sep47
        // 
        sep47.Dock = DockStyle.Top;
        sep47.Location = new Point(5, 28);
        sep47.Name = "sep47";
        sep47.Size = new Size(238, 5);
        sep47.TabIndex = 1;
        // 
        // gridSignals
        // 
        gridSignals.Dock = DockStyle.Top;
        gridSignals.Location = new Point(5, 33);
        gridSignals.HelpVisible = false;
        gridSignals.Name = "gridSignals";
        gridSignals.PropertySort = PropertySort.NoSort;
        gridSignals.Size = new Size(238, 405);
        gridSignals.TabIndex = 2;
        gridSignals.ToolbarVisible = false;
        // 
        // pnlSignal
        // 
        pnlSignal.BorderStyle = BorderStyle.FixedSingle;
        pnlSignal.Controls.Add(gridSignal);
        pnlSignal.Controls.Add(sep51);
        pnlSignal.Controls.Add(btnGetSignal);
        pnlSignal.Controls.Add(sep50);
        pnlSignal.Controls.Add(txtGetSignalSignal);
        pnlSignal.Controls.Add(sep49);
        pnlSignal.Controls.Add(txtGetSignalDevice);
        pnlSignal.Controls.Add(sep48);
        pnlSignal.Controls.Add(txtGetSignalNetwork);
        pnlSignal.Location = new Point(3, 3);
        pnlSignal.Name = "pnlSignal";
        pnlSignal.Padding = new Padding(5);
        pnlSignal.Size = new Size(250, 434);
        pnlSignal.TabIndex = 1;
        // 
        // txtGetSignalNetwork
        // 
        txtGetSignalNetwork.Dock = DockStyle.Top;
        txtGetSignalNetwork.Location = new Point(5, 5);
        txtGetSignalNetwork.Name = "txtGetSignalNetwork";
        txtGetSignalNetwork.PlaceholderText = "network";
        txtGetSignalNetwork.Size = new Size(238, 23);
        txtGetSignalNetwork.TabIndex = 0;
        txtGetSignalNetwork.Text = "Local";
        // 
        // sep48
        // 
        sep48.Dock = DockStyle.Top;
        sep48.Location = new Point(5, 28);
        sep48.Name = "sep48";
        sep48.Size = new Size(238, 5);
        sep48.TabIndex = 1;
        // 
        // txtGetSignalDevice
        // 
        txtGetSignalDevice.Dock = DockStyle.Top;
        txtGetSignalDevice.Location = new Point(5, 33);
        txtGetSignalDevice.Name = "txtGetSignalDevice";
        txtGetSignalDevice.PlaceholderText = "device";
        txtGetSignalDevice.Size = new Size(238, 23);
        txtGetSignalDevice.TabIndex = 2;
        txtGetSignalDevice.Text = "DRV_1";
        // 
        // sep49
        // 
        sep49.Dock = DockStyle.Top;
        sep49.Location = new Point(5, 56);
        sep49.Name = "sep49";
        sep49.Size = new Size(238, 5);
        sep49.TabIndex = 3;
        // 
        // txtGetSignalSignal
        // 
        txtGetSignalSignal.Dock = DockStyle.Top;
        txtGetSignalSignal.Location = new Point(5, 61);
        txtGetSignalSignal.Name = "txtGetSignalSignal";
        txtGetSignalSignal.PlaceholderText = "signal";
        txtGetSignalSignal.Size = new Size(238, 23);
        txtGetSignalSignal.TabIndex = 4;
        txtGetSignalSignal.Text = "DRV1K1";
        // 
        // sep50
        // 
        sep50.Dock = DockStyle.Top;
        sep50.Location = new Point(5, 84);
        sep50.Name = "sep50";
        sep50.Size = new Size(238, 5);
        sep50.TabIndex = 5;
        // 
        // btnGetSignal
        // 
        btnGetSignal.Dock = DockStyle.Top;
        btnGetSignal.Location = new Point(5, 89);
        btnGetSignal.Name = "btnGetSignal";
        btnGetSignal.Size = new Size(238, 23);
        btnGetSignal.TabIndex = 6;
        btnGetSignal.Text = "Get Signal";
        btnGetSignal.UseVisualStyleBackColor = true;
        btnGetSignal.Click += btnGetSignal_Click;
        // 
        // sep51
        // 
        sep51.Dock = DockStyle.Top;
        sep51.Location = new Point(5, 112);
        sep51.Name = "sep51";
        sep51.Size = new Size(238, 5);
        sep51.TabIndex = 7;
        // 
        // gridSignal
        // 
        gridSignal.Dock = DockStyle.Top;
        gridSignal.Location = new Point(5, 117);
        gridSignal.HelpVisible = false;
        gridSignal.Name = "gridSignal";
        gridSignal.PropertySort = PropertySort.NoSort;
        gridSignal.Size = new Size(238, 310);
        gridSignal.TabIndex = 8;
        gridSignal.ToolbarVisible = false;
        // 
        // pnlSignalConfiguration
        // 
        pnlSignalConfiguration.BorderStyle = BorderStyle.FixedSingle;
        pnlSignalConfiguration.Controls.Add(gridSignalConfiguration);
        pnlSignalConfiguration.Controls.Add(sep55);
        pnlSignalConfiguration.Controls.Add(btnGetSignalConfiguration);
        pnlSignalConfiguration.Controls.Add(sep54);
        pnlSignalConfiguration.Controls.Add(txtSignalConfigurationSignal);
        pnlSignalConfiguration.Controls.Add(sep53);
        pnlSignalConfiguration.Controls.Add(txtSignalConfigurationDevice);
        pnlSignalConfiguration.Controls.Add(sep52);
        pnlSignalConfiguration.Controls.Add(txtSignalConfigurationNetwork);
        pnlSignalConfiguration.Location = new Point(3, 3);
        pnlSignalConfiguration.Name = "pnlSignalConfiguration";
        pnlSignalConfiguration.Padding = new Padding(5);
        pnlSignalConfiguration.Size = new Size(250, 282);
        pnlSignalConfiguration.TabIndex = 2;
        // 
        // txtSignalConfigurationNetwork
        // 
        txtSignalConfigurationNetwork.Dock = DockStyle.Top;
        txtSignalConfigurationNetwork.Location = new Point(5, 5);
        txtSignalConfigurationNetwork.Name = "txtSignalConfigurationNetwork";
        txtSignalConfigurationNetwork.PlaceholderText = "network";
        txtSignalConfigurationNetwork.Size = new Size(238, 23);
        txtSignalConfigurationNetwork.TabIndex = 0;
        txtSignalConfigurationNetwork.Text = "Local";
        // 
        // sep52
        // 
        sep52.Dock = DockStyle.Top;
        sep52.Location = new Point(5, 28);
        sep52.Name = "sep52";
        sep52.Size = new Size(238, 5);
        sep52.TabIndex = 1;
        // 
        // txtSignalConfigurationDevice
        // 
        txtSignalConfigurationDevice.Dock = DockStyle.Top;
        txtSignalConfigurationDevice.Location = new Point(5, 33);
        txtSignalConfigurationDevice.Name = "txtSignalConfigurationDevice";
        txtSignalConfigurationDevice.PlaceholderText = "device";
        txtSignalConfigurationDevice.Size = new Size(238, 23);
        txtSignalConfigurationDevice.TabIndex = 2;
        txtSignalConfigurationDevice.Text = "DRV_1";
        // 
        // sep53
        // 
        sep53.Dock = DockStyle.Top;
        sep53.Location = new Point(5, 56);
        sep53.Name = "sep53";
        sep53.Size = new Size(238, 5);
        sep53.TabIndex = 3;
        // 
        // txtSignalConfigurationSignal
        // 
        txtSignalConfigurationSignal.Dock = DockStyle.Top;
        txtSignalConfigurationSignal.Location = new Point(5, 61);
        txtSignalConfigurationSignal.Name = "txtSignalConfigurationSignal";
        txtSignalConfigurationSignal.PlaceholderText = "signal";
        txtSignalConfigurationSignal.Size = new Size(238, 23);
        txtSignalConfigurationSignal.TabIndex = 4;
        txtSignalConfigurationSignal.Text = "DRV1K1";
        // 
        // sep54
        // 
        sep54.Dock = DockStyle.Top;
        sep54.Location = new Point(5, 84);
        sep54.Name = "sep54";
        sep54.Size = new Size(238, 5);
        sep54.TabIndex = 5;
        // 
        // btnGetSignalConfiguration
        // 
        btnGetSignalConfiguration.Dock = DockStyle.Top;
        btnGetSignalConfiguration.Location = new Point(5, 89);
        btnGetSignalConfiguration.Name = "btnGetSignalConfiguration";
        btnGetSignalConfiguration.Size = new Size(238, 23);
        btnGetSignalConfiguration.TabIndex = 6;
        btnGetSignalConfiguration.Text = "Get Signal configuration";
        btnGetSignalConfiguration.UseVisualStyleBackColor = true;
        btnGetSignalConfiguration.Click += btnGetSignalConfiguration_Click;
        // 
        // sep55
        // 
        sep55.Dock = DockStyle.Top;
        sep55.Location = new Point(5, 112);
        sep55.Name = "sep55";
        sep55.Size = new Size(238, 5);
        sep55.TabIndex = 7;
        // 
        // gridSignalConfiguration
        // 
        gridSignalConfiguration.Dock = DockStyle.Top;
        gridSignalConfiguration.Location = new Point(5, 117);
        gridSignalConfiguration.HelpVisible = false;
        gridSignalConfiguration.Name = "gridSignalConfiguration";
        gridSignalConfiguration.PropertySort = PropertySort.NoSort;
        gridSignalConfiguration.Size = new Size(238, 158);
        gridSignalConfiguration.TabIndex = 8;
        gridSignalConfiguration.ToolbarVisible = false;
        // 
        // pnlUnblockSignals
        // 
        pnlUnblockSignals.BorderStyle = BorderStyle.FixedSingle;
        pnlUnblockSignals.Controls.Add(btnUnblockSignals);
        pnlUnblockSignals.Location = new Point(3, 3);
        pnlUnblockSignals.Name = "pnlUnblockSignals";
        pnlUnblockSignals.Padding = new Padding(5);
        pnlUnblockSignals.Size = new Size(250, 35);
        pnlUnblockSignals.TabIndex = 3;
        // 
        // btnUnblockSignals
        // 
        btnUnblockSignals.Dock = DockStyle.Top;
        btnUnblockSignals.Location = new Point(5, 5);
        btnUnblockSignals.Name = "btnUnblockSignals";
        btnUnblockSignals.Size = new Size(238, 23);
        btnUnblockSignals.TabIndex = 0;
        btnUnblockSignals.Text = "Unblock Signals";
        btnUnblockSignals.UseVisualStyleBackColor = true;
        btnUnblockSignals.Click += btnUnblockSignals_Click;
        // 
        // tabSignalWrite
        // 
        tabSignalWrite.Controls.Add(flowSignalWrite);
        tabSignalWrite.Location = new Point(4, 24);
        tabSignalWrite.Name = "tabSignalWrite";
        tabSignalWrite.Padding = new Padding(3);
        tabSignalWrite.Size = new Size(882, 463);
        tabSignalWrite.TabIndex = 4;
        tabSignalWrite.Text = "Signal write";
        tabSignalWrite.UseVisualStyleBackColor = true;
        // 
        // flowSignalWrite
        // 
        flowSignalWrite.AutoScroll = true;
        flowSignalWrite.Controls.Add(pnlSetSignalValue);
        flowSignalWrite.Controls.Add(pnlSetSignalValueDelayed);
        flowSignalWrite.Controls.Add(pnlSetSignalState);
        flowSignalWrite.Controls.Add(pnlInvertSignal);
        flowSignalWrite.Controls.Add(pnlPulseSignal);
        flowSignalWrite.Controls.Add(pnlToggleSignal);
        flowSignalWrite.Dock = DockStyle.Fill;
        flowSignalWrite.FlowDirection = FlowDirection.TopDown;
        flowSignalWrite.Location = new Point(3, 3);
        flowSignalWrite.Name = "flowSignalWrite";
        flowSignalWrite.Size = new Size(876, 457);
        flowSignalWrite.TabIndex = 0;
        // 
        // pnlSetSignalValue
        // 
        pnlSetSignalValue.BorderStyle = BorderStyle.FixedSingle;
        pnlSetSignalValue.Controls.Add(btnSetSignalValue);
        pnlSetSignalValue.Controls.Add(sep60);
        pnlSetSignalValue.Controls.Add(chkSetSignalValueLogToEventLog);
        pnlSetSignalValue.Controls.Add(sep59);
        pnlSetSignalValue.Controls.Add(numSetSignalValueValue);
        pnlSetSignalValue.Controls.Add(sep58);
        pnlSetSignalValue.Controls.Add(txtSetSignalValueSignal);
        pnlSetSignalValue.Controls.Add(sep57);
        pnlSetSignalValue.Controls.Add(txtSetSignalValueDevice);
        pnlSetSignalValue.Controls.Add(sep56);
        pnlSetSignalValue.Controls.Add(txtSetSignalValueNetwork);
        pnlSetSignalValue.Location = new Point(3, 3);
        pnlSetSignalValue.Name = "pnlSetSignalValue";
        pnlSetSignalValue.Padding = new Padding(5);
        pnlSetSignalValue.Size = new Size(250, 175);
        pnlSetSignalValue.TabIndex = 0;
        // 
        // txtSetSignalValueNetwork
        // 
        txtSetSignalValueNetwork.Dock = DockStyle.Top;
        txtSetSignalValueNetwork.Location = new Point(5, 5);
        txtSetSignalValueNetwork.Name = "txtSetSignalValueNetwork";
        txtSetSignalValueNetwork.PlaceholderText = "network";
        txtSetSignalValueNetwork.Size = new Size(238, 23);
        txtSetSignalValueNetwork.TabIndex = 0;
        txtSetSignalValueNetwork.Text = "Local";
        // 
        // sep56
        // 
        sep56.Dock = DockStyle.Top;
        sep56.Location = new Point(5, 28);
        sep56.Name = "sep56";
        sep56.Size = new Size(238, 5);
        sep56.TabIndex = 1;
        // 
        // txtSetSignalValueDevice
        // 
        txtSetSignalValueDevice.Dock = DockStyle.Top;
        txtSetSignalValueDevice.Location = new Point(5, 33);
        txtSetSignalValueDevice.Name = "txtSetSignalValueDevice";
        txtSetSignalValueDevice.PlaceholderText = "device";
        txtSetSignalValueDevice.Size = new Size(238, 23);
        txtSetSignalValueDevice.TabIndex = 2;
        txtSetSignalValueDevice.Text = "DRV_1";
        // 
        // sep57
        // 
        sep57.Dock = DockStyle.Top;
        sep57.Location = new Point(5, 56);
        sep57.Name = "sep57";
        sep57.Size = new Size(238, 5);
        sep57.TabIndex = 3;
        // 
        // txtSetSignalValueSignal
        // 
        txtSetSignalValueSignal.Dock = DockStyle.Top;
        txtSetSignalValueSignal.Location = new Point(5, 61);
        txtSetSignalValueSignal.Name = "txtSetSignalValueSignal";
        txtSetSignalValueSignal.PlaceholderText = "signal";
        txtSetSignalValueSignal.Size = new Size(238, 23);
        txtSetSignalValueSignal.TabIndex = 4;
        txtSetSignalValueSignal.Text = "DRV1K1";
        // 
        // sep58
        // 
        sep58.Dock = DockStyle.Top;
        sep58.Location = new Point(5, 84);
        sep58.Name = "sep58";
        sep58.Size = new Size(238, 5);
        sep58.TabIndex = 5;
        // 
        // numSetSignalValueValue
        // 
        numSetSignalValueValue.Dock = DockStyle.Top;
        numSetSignalValueValue.Location = new Point(5, 89);
        numSetSignalValueValue.DecimalPlaces = 3;
        numSetSignalValueValue.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numSetSignalValueValue.Minimum = new decimal(new int[] { 99999999, 0, 0, -2147483648 });
        numSetSignalValueValue.Name = "numSetSignalValueValue";
        numSetSignalValueValue.Size = new Size(238, 23);
        numSetSignalValueValue.TabIndex = 6;
        numSetSignalValueValue.Value = new decimal(new int[] { 0, 0, 0, 0 });
        // 
        // sep59
        // 
        sep59.Dock = DockStyle.Top;
        sep59.Location = new Point(5, 112);
        sep59.Name = "sep59";
        sep59.Size = new Size(238, 5);
        sep59.TabIndex = 7;
        // 
        // chkSetSignalValueLogToEventLog
        // 
        chkSetSignalValueLogToEventLog.Dock = DockStyle.Top;
        chkSetSignalValueLogToEventLog.Location = new Point(5, 117);
        chkSetSignalValueLogToEventLog.Name = "chkSetSignalValueLogToEventLog";
        chkSetSignalValueLogToEventLog.Size = new Size(238, 23);
        chkSetSignalValueLogToEventLog.TabIndex = 8;
        chkSetSignalValueLogToEventLog.Text = "Log to event log";
        chkSetSignalValueLogToEventLog.UseVisualStyleBackColor = true;
        // 
        // sep60
        // 
        sep60.Dock = DockStyle.Top;
        sep60.Location = new Point(5, 140);
        sep60.Name = "sep60";
        sep60.Size = new Size(238, 5);
        sep60.TabIndex = 9;
        // 
        // btnSetSignalValue
        // 
        btnSetSignalValue.Dock = DockStyle.Top;
        btnSetSignalValue.Location = new Point(5, 145);
        btnSetSignalValue.Name = "btnSetSignalValue";
        btnSetSignalValue.Size = new Size(238, 23);
        btnSetSignalValue.TabIndex = 10;
        btnSetSignalValue.Text = "Set Signal value";
        btnSetSignalValue.UseVisualStyleBackColor = true;
        btnSetSignalValue.Click += btnSetSignalValue_Click;
        // 
        // pnlSetSignalValueDelayed
        // 
        pnlSetSignalValueDelayed.BorderStyle = BorderStyle.FixedSingle;
        pnlSetSignalValueDelayed.Controls.Add(btnSetSignalValueDelayed);
        pnlSetSignalValueDelayed.Controls.Add(sep66);
        pnlSetSignalValueDelayed.Controls.Add(chkSetSignalValueDelayedLogToEventLog);
        pnlSetSignalValueDelayed.Controls.Add(sep65);
        pnlSetSignalValueDelayed.Controls.Add(numSetSignalValueDelayedDelay);
        pnlSetSignalValueDelayed.Controls.Add(sep64);
        pnlSetSignalValueDelayed.Controls.Add(numSetSignalValueDelayedValue);
        pnlSetSignalValueDelayed.Controls.Add(sep63);
        pnlSetSignalValueDelayed.Controls.Add(txtSetSignalValueDelayedSignal);
        pnlSetSignalValueDelayed.Controls.Add(sep62);
        pnlSetSignalValueDelayed.Controls.Add(txtSetSignalValueDelayedDevice);
        pnlSetSignalValueDelayed.Controls.Add(sep61);
        pnlSetSignalValueDelayed.Controls.Add(txtSetSignalValueDelayedNetwork);
        pnlSetSignalValueDelayed.Location = new Point(3, 3);
        pnlSetSignalValueDelayed.Name = "pnlSetSignalValueDelayed";
        pnlSetSignalValueDelayed.Padding = new Padding(5);
        pnlSetSignalValueDelayed.Size = new Size(250, 203);
        pnlSetSignalValueDelayed.TabIndex = 1;
        // 
        // txtSetSignalValueDelayedNetwork
        // 
        txtSetSignalValueDelayedNetwork.Dock = DockStyle.Top;
        txtSetSignalValueDelayedNetwork.Location = new Point(5, 5);
        txtSetSignalValueDelayedNetwork.Name = "txtSetSignalValueDelayedNetwork";
        txtSetSignalValueDelayedNetwork.PlaceholderText = "network";
        txtSetSignalValueDelayedNetwork.Size = new Size(238, 23);
        txtSetSignalValueDelayedNetwork.TabIndex = 0;
        txtSetSignalValueDelayedNetwork.Text = "Local";
        // 
        // sep61
        // 
        sep61.Dock = DockStyle.Top;
        sep61.Location = new Point(5, 28);
        sep61.Name = "sep61";
        sep61.Size = new Size(238, 5);
        sep61.TabIndex = 1;
        // 
        // txtSetSignalValueDelayedDevice
        // 
        txtSetSignalValueDelayedDevice.Dock = DockStyle.Top;
        txtSetSignalValueDelayedDevice.Location = new Point(5, 33);
        txtSetSignalValueDelayedDevice.Name = "txtSetSignalValueDelayedDevice";
        txtSetSignalValueDelayedDevice.PlaceholderText = "device";
        txtSetSignalValueDelayedDevice.Size = new Size(238, 23);
        txtSetSignalValueDelayedDevice.TabIndex = 2;
        txtSetSignalValueDelayedDevice.Text = "DRV_1";
        // 
        // sep62
        // 
        sep62.Dock = DockStyle.Top;
        sep62.Location = new Point(5, 56);
        sep62.Name = "sep62";
        sep62.Size = new Size(238, 5);
        sep62.TabIndex = 3;
        // 
        // txtSetSignalValueDelayedSignal
        // 
        txtSetSignalValueDelayedSignal.Dock = DockStyle.Top;
        txtSetSignalValueDelayedSignal.Location = new Point(5, 61);
        txtSetSignalValueDelayedSignal.Name = "txtSetSignalValueDelayedSignal";
        txtSetSignalValueDelayedSignal.PlaceholderText = "signal";
        txtSetSignalValueDelayedSignal.Size = new Size(238, 23);
        txtSetSignalValueDelayedSignal.TabIndex = 4;
        txtSetSignalValueDelayedSignal.Text = "DRV1K1";
        // 
        // sep63
        // 
        sep63.Dock = DockStyle.Top;
        sep63.Location = new Point(5, 84);
        sep63.Name = "sep63";
        sep63.Size = new Size(238, 5);
        sep63.TabIndex = 5;
        // 
        // numSetSignalValueDelayedValue
        // 
        numSetSignalValueDelayedValue.Dock = DockStyle.Top;
        numSetSignalValueDelayedValue.Location = new Point(5, 89);
        numSetSignalValueDelayedValue.DecimalPlaces = 3;
        numSetSignalValueDelayedValue.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numSetSignalValueDelayedValue.Minimum = new decimal(new int[] { 99999999, 0, 0, -2147483648 });
        numSetSignalValueDelayedValue.Name = "numSetSignalValueDelayedValue";
        numSetSignalValueDelayedValue.Size = new Size(238, 23);
        numSetSignalValueDelayedValue.TabIndex = 6;
        numSetSignalValueDelayedValue.Value = new decimal(new int[] { 0, 0, 0, 0 });
        // 
        // sep64
        // 
        sep64.Dock = DockStyle.Top;
        sep64.Location = new Point(5, 112);
        sep64.Name = "sep64";
        sep64.Size = new Size(238, 5);
        sep64.TabIndex = 7;
        // 
        // numSetSignalValueDelayedDelay
        // 
        numSetSignalValueDelayedDelay.Dock = DockStyle.Top;
        numSetSignalValueDelayedDelay.Location = new Point(5, 117);
        numSetSignalValueDelayedDelay.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numSetSignalValueDelayedDelay.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        numSetSignalValueDelayedDelay.Name = "numSetSignalValueDelayedDelay";
        numSetSignalValueDelayedDelay.Size = new Size(238, 23);
        numSetSignalValueDelayedDelay.TabIndex = 8;
        numSetSignalValueDelayedDelay.Value = new decimal(new int[] { 1000, 0, 0, 0 });
        // 
        // sep65
        // 
        sep65.Dock = DockStyle.Top;
        sep65.Location = new Point(5, 140);
        sep65.Name = "sep65";
        sep65.Size = new Size(238, 5);
        sep65.TabIndex = 9;
        // 
        // chkSetSignalValueDelayedLogToEventLog
        // 
        chkSetSignalValueDelayedLogToEventLog.Dock = DockStyle.Top;
        chkSetSignalValueDelayedLogToEventLog.Location = new Point(5, 145);
        chkSetSignalValueDelayedLogToEventLog.Name = "chkSetSignalValueDelayedLogToEventLog";
        chkSetSignalValueDelayedLogToEventLog.Size = new Size(238, 23);
        chkSetSignalValueDelayedLogToEventLog.TabIndex = 10;
        chkSetSignalValueDelayedLogToEventLog.Text = "Log to event log";
        chkSetSignalValueDelayedLogToEventLog.UseVisualStyleBackColor = true;
        // 
        // sep66
        // 
        sep66.Dock = DockStyle.Top;
        sep66.Location = new Point(5, 168);
        sep66.Name = "sep66";
        sep66.Size = new Size(238, 5);
        sep66.TabIndex = 11;
        // 
        // btnSetSignalValueDelayed
        // 
        btnSetSignalValueDelayed.Dock = DockStyle.Top;
        btnSetSignalValueDelayed.Location = new Point(5, 173);
        btnSetSignalValueDelayed.Name = "btnSetSignalValueDelayed";
        btnSetSignalValueDelayed.Size = new Size(238, 23);
        btnSetSignalValueDelayed.TabIndex = 12;
        btnSetSignalValueDelayed.Text = "Set Signal value delayed";
        btnSetSignalValueDelayed.UseVisualStyleBackColor = true;
        btnSetSignalValueDelayed.Click += btnSetSignalValueDelayed_Click;
        // 
        // pnlSetSignalState
        // 
        pnlSetSignalState.BorderStyle = BorderStyle.FixedSingle;
        pnlSetSignalState.Controls.Add(btnSetSignalState);
        pnlSetSignalState.Controls.Add(sep70);
        pnlSetSignalState.Controls.Add(chkSetSignalStateSimulated);
        pnlSetSignalState.Controls.Add(sep69);
        pnlSetSignalState.Controls.Add(txtSetSignalStateSignal);
        pnlSetSignalState.Controls.Add(sep68);
        pnlSetSignalState.Controls.Add(txtSetSignalStateDevice);
        pnlSetSignalState.Controls.Add(sep67);
        pnlSetSignalState.Controls.Add(txtSetSignalStateNetwork);
        pnlSetSignalState.Location = new Point(3, 3);
        pnlSetSignalState.Name = "pnlSetSignalState";
        pnlSetSignalState.Padding = new Padding(5);
        pnlSetSignalState.Size = new Size(250, 147);
        pnlSetSignalState.TabIndex = 2;
        // 
        // txtSetSignalStateNetwork
        // 
        txtSetSignalStateNetwork.Dock = DockStyle.Top;
        txtSetSignalStateNetwork.Location = new Point(5, 5);
        txtSetSignalStateNetwork.Name = "txtSetSignalStateNetwork";
        txtSetSignalStateNetwork.PlaceholderText = "network";
        txtSetSignalStateNetwork.Size = new Size(238, 23);
        txtSetSignalStateNetwork.TabIndex = 0;
        txtSetSignalStateNetwork.Text = "Local";
        // 
        // sep67
        // 
        sep67.Dock = DockStyle.Top;
        sep67.Location = new Point(5, 28);
        sep67.Name = "sep67";
        sep67.Size = new Size(238, 5);
        sep67.TabIndex = 1;
        // 
        // txtSetSignalStateDevice
        // 
        txtSetSignalStateDevice.Dock = DockStyle.Top;
        txtSetSignalStateDevice.Location = new Point(5, 33);
        txtSetSignalStateDevice.Name = "txtSetSignalStateDevice";
        txtSetSignalStateDevice.PlaceholderText = "device";
        txtSetSignalStateDevice.Size = new Size(238, 23);
        txtSetSignalStateDevice.TabIndex = 2;
        txtSetSignalStateDevice.Text = "DRV_1";
        // 
        // sep68
        // 
        sep68.Dock = DockStyle.Top;
        sep68.Location = new Point(5, 56);
        sep68.Name = "sep68";
        sep68.Size = new Size(238, 5);
        sep68.TabIndex = 3;
        // 
        // txtSetSignalStateSignal
        // 
        txtSetSignalStateSignal.Dock = DockStyle.Top;
        txtSetSignalStateSignal.Location = new Point(5, 61);
        txtSetSignalStateSignal.Name = "txtSetSignalStateSignal";
        txtSetSignalStateSignal.PlaceholderText = "signal";
        txtSetSignalStateSignal.Size = new Size(238, 23);
        txtSetSignalStateSignal.TabIndex = 4;
        txtSetSignalStateSignal.Text = "DRV1K1";
        // 
        // sep69
        // 
        sep69.Dock = DockStyle.Top;
        sep69.Location = new Point(5, 84);
        sep69.Name = "sep69";
        sep69.Size = new Size(238, 5);
        sep69.TabIndex = 5;
        // 
        // chkSetSignalStateSimulated
        // 
        chkSetSignalStateSimulated.Dock = DockStyle.Top;
        chkSetSignalStateSimulated.Location = new Point(5, 89);
        chkSetSignalStateSimulated.Name = "chkSetSignalStateSimulated";
        chkSetSignalStateSimulated.Size = new Size(238, 23);
        chkSetSignalStateSimulated.TabIndex = 6;
        chkSetSignalStateSimulated.Text = "Simulated";
        chkSetSignalStateSimulated.UseVisualStyleBackColor = true;
        // 
        // sep70
        // 
        sep70.Dock = DockStyle.Top;
        sep70.Location = new Point(5, 112);
        sep70.Name = "sep70";
        sep70.Size = new Size(238, 5);
        sep70.TabIndex = 7;
        // 
        // btnSetSignalState
        // 
        btnSetSignalState.Dock = DockStyle.Top;
        btnSetSignalState.Location = new Point(5, 117);
        btnSetSignalState.Name = "btnSetSignalState";
        btnSetSignalState.Size = new Size(238, 23);
        btnSetSignalState.TabIndex = 8;
        btnSetSignalState.Text = "Set Signal state";
        btnSetSignalState.UseVisualStyleBackColor = true;
        btnSetSignalState.Click += btnSetSignalState_Click;
        // 
        // pnlInvertSignal
        // 
        pnlInvertSignal.BorderStyle = BorderStyle.FixedSingle;
        pnlInvertSignal.Controls.Add(btnInvertSignal);
        pnlInvertSignal.Controls.Add(sep75);
        pnlInvertSignal.Controls.Add(chkInvertSignalLogToEventLog);
        pnlInvertSignal.Controls.Add(sep74);
        pnlInvertSignal.Controls.Add(numInvertSignalValue);
        pnlInvertSignal.Controls.Add(sep73);
        pnlInvertSignal.Controls.Add(txtInvertSignalSignal);
        pnlInvertSignal.Controls.Add(sep72);
        pnlInvertSignal.Controls.Add(txtInvertSignalDevice);
        pnlInvertSignal.Controls.Add(sep71);
        pnlInvertSignal.Controls.Add(txtInvertSignalNetwork);
        pnlInvertSignal.Location = new Point(3, 3);
        pnlInvertSignal.Name = "pnlInvertSignal";
        pnlInvertSignal.Padding = new Padding(5);
        pnlInvertSignal.Size = new Size(250, 175);
        pnlInvertSignal.TabIndex = 3;
        // 
        // txtInvertSignalNetwork
        // 
        txtInvertSignalNetwork.Dock = DockStyle.Top;
        txtInvertSignalNetwork.Location = new Point(5, 5);
        txtInvertSignalNetwork.Name = "txtInvertSignalNetwork";
        txtInvertSignalNetwork.PlaceholderText = "network";
        txtInvertSignalNetwork.Size = new Size(238, 23);
        txtInvertSignalNetwork.TabIndex = 0;
        txtInvertSignalNetwork.Text = "Local";
        // 
        // sep71
        // 
        sep71.Dock = DockStyle.Top;
        sep71.Location = new Point(5, 28);
        sep71.Name = "sep71";
        sep71.Size = new Size(238, 5);
        sep71.TabIndex = 1;
        // 
        // txtInvertSignalDevice
        // 
        txtInvertSignalDevice.Dock = DockStyle.Top;
        txtInvertSignalDevice.Location = new Point(5, 33);
        txtInvertSignalDevice.Name = "txtInvertSignalDevice";
        txtInvertSignalDevice.PlaceholderText = "device";
        txtInvertSignalDevice.Size = new Size(238, 23);
        txtInvertSignalDevice.TabIndex = 2;
        txtInvertSignalDevice.Text = "DRV_1";
        // 
        // sep72
        // 
        sep72.Dock = DockStyle.Top;
        sep72.Location = new Point(5, 56);
        sep72.Name = "sep72";
        sep72.Size = new Size(238, 5);
        sep72.TabIndex = 3;
        // 
        // txtInvertSignalSignal
        // 
        txtInvertSignalSignal.Dock = DockStyle.Top;
        txtInvertSignalSignal.Location = new Point(5, 61);
        txtInvertSignalSignal.Name = "txtInvertSignalSignal";
        txtInvertSignalSignal.PlaceholderText = "signal";
        txtInvertSignalSignal.Size = new Size(238, 23);
        txtInvertSignalSignal.TabIndex = 4;
        txtInvertSignalSignal.Text = "DRV1K1";
        // 
        // sep73
        // 
        sep73.Dock = DockStyle.Top;
        sep73.Location = new Point(5, 84);
        sep73.Name = "sep73";
        sep73.Size = new Size(238, 5);
        sep73.TabIndex = 5;
        // 
        // numInvertSignalValue
        // 
        numInvertSignalValue.Dock = DockStyle.Top;
        numInvertSignalValue.Location = new Point(5, 89);
        numInvertSignalValue.DecimalPlaces = 3;
        numInvertSignalValue.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numInvertSignalValue.Minimum = new decimal(new int[] { 99999999, 0, 0, -2147483648 });
        numInvertSignalValue.Name = "numInvertSignalValue";
        numInvertSignalValue.Size = new Size(238, 23);
        numInvertSignalValue.TabIndex = 6;
        numInvertSignalValue.Value = new decimal(new int[] { 0, 0, 0, 0 });
        // 
        // sep74
        // 
        sep74.Dock = DockStyle.Top;
        sep74.Location = new Point(5, 112);
        sep74.Name = "sep74";
        sep74.Size = new Size(238, 5);
        sep74.TabIndex = 7;
        // 
        // chkInvertSignalLogToEventLog
        // 
        chkInvertSignalLogToEventLog.Dock = DockStyle.Top;
        chkInvertSignalLogToEventLog.Location = new Point(5, 117);
        chkInvertSignalLogToEventLog.Name = "chkInvertSignalLogToEventLog";
        chkInvertSignalLogToEventLog.Size = new Size(238, 23);
        chkInvertSignalLogToEventLog.TabIndex = 8;
        chkInvertSignalLogToEventLog.Text = "Log to event log";
        chkInvertSignalLogToEventLog.UseVisualStyleBackColor = true;
        // 
        // sep75
        // 
        sep75.Dock = DockStyle.Top;
        sep75.Location = new Point(5, 140);
        sep75.Name = "sep75";
        sep75.Size = new Size(238, 5);
        sep75.TabIndex = 9;
        // 
        // btnInvertSignal
        // 
        btnInvertSignal.Dock = DockStyle.Top;
        btnInvertSignal.Location = new Point(5, 145);
        btnInvertSignal.Name = "btnInvertSignal";
        btnInvertSignal.Size = new Size(238, 23);
        btnInvertSignal.TabIndex = 10;
        btnInvertSignal.Text = "Invert Signal";
        btnInvertSignal.UseVisualStyleBackColor = true;
        btnInvertSignal.Click += btnInvertSignal_Click;
        // 
        // pnlPulseSignal
        // 
        pnlPulseSignal.BorderStyle = BorderStyle.FixedSingle;
        pnlPulseSignal.Controls.Add(btnPulseSignal);
        pnlPulseSignal.Controls.Add(sep83);
        pnlPulseSignal.Controls.Add(chkPulseSignalLogToEventLog);
        pnlPulseSignal.Controls.Add(sep82);
        pnlPulseSignal.Controls.Add(txtPulseSignalPassivePulseLength);
        pnlPulseSignal.Controls.Add(sep81);
        pnlPulseSignal.Controls.Add(txtPulseSignalActivePulseLength);
        pnlPulseSignal.Controls.Add(sep80);
        pnlPulseSignal.Controls.Add(numPulseSignalPulses);
        pnlPulseSignal.Controls.Add(sep79);
        pnlPulseSignal.Controls.Add(numPulseSignalValue);
        pnlPulseSignal.Controls.Add(sep78);
        pnlPulseSignal.Controls.Add(txtPulseSignalSignal);
        pnlPulseSignal.Controls.Add(sep77);
        pnlPulseSignal.Controls.Add(txtPulseSignalDevice);
        pnlPulseSignal.Controls.Add(sep76);
        pnlPulseSignal.Controls.Add(txtPulseSignalNetwork);
        pnlPulseSignal.Location = new Point(3, 3);
        pnlPulseSignal.Name = "pnlPulseSignal";
        pnlPulseSignal.Padding = new Padding(5);
        pnlPulseSignal.Size = new Size(250, 259);
        pnlPulseSignal.TabIndex = 4;
        // 
        // txtPulseSignalNetwork
        // 
        txtPulseSignalNetwork.Dock = DockStyle.Top;
        txtPulseSignalNetwork.Location = new Point(5, 5);
        txtPulseSignalNetwork.Name = "txtPulseSignalNetwork";
        txtPulseSignalNetwork.PlaceholderText = "network";
        txtPulseSignalNetwork.Size = new Size(238, 23);
        txtPulseSignalNetwork.TabIndex = 0;
        txtPulseSignalNetwork.Text = "Local";
        // 
        // sep76
        // 
        sep76.Dock = DockStyle.Top;
        sep76.Location = new Point(5, 28);
        sep76.Name = "sep76";
        sep76.Size = new Size(238, 5);
        sep76.TabIndex = 1;
        // 
        // txtPulseSignalDevice
        // 
        txtPulseSignalDevice.Dock = DockStyle.Top;
        txtPulseSignalDevice.Location = new Point(5, 33);
        txtPulseSignalDevice.Name = "txtPulseSignalDevice";
        txtPulseSignalDevice.PlaceholderText = "device";
        txtPulseSignalDevice.Size = new Size(238, 23);
        txtPulseSignalDevice.TabIndex = 2;
        txtPulseSignalDevice.Text = "DRV_1";
        // 
        // sep77
        // 
        sep77.Dock = DockStyle.Top;
        sep77.Location = new Point(5, 56);
        sep77.Name = "sep77";
        sep77.Size = new Size(238, 5);
        sep77.TabIndex = 3;
        // 
        // txtPulseSignalSignal
        // 
        txtPulseSignalSignal.Dock = DockStyle.Top;
        txtPulseSignalSignal.Location = new Point(5, 61);
        txtPulseSignalSignal.Name = "txtPulseSignalSignal";
        txtPulseSignalSignal.PlaceholderText = "signal";
        txtPulseSignalSignal.Size = new Size(238, 23);
        txtPulseSignalSignal.TabIndex = 4;
        txtPulseSignalSignal.Text = "DRV1K1";
        // 
        // sep78
        // 
        sep78.Dock = DockStyle.Top;
        sep78.Location = new Point(5, 84);
        sep78.Name = "sep78";
        sep78.Size = new Size(238, 5);
        sep78.TabIndex = 5;
        // 
        // numPulseSignalValue
        // 
        numPulseSignalValue.Dock = DockStyle.Top;
        numPulseSignalValue.Location = new Point(5, 89);
        numPulseSignalValue.DecimalPlaces = 3;
        numPulseSignalValue.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numPulseSignalValue.Minimum = new decimal(new int[] { 99999999, 0, 0, -2147483648 });
        numPulseSignalValue.Name = "numPulseSignalValue";
        numPulseSignalValue.Size = new Size(238, 23);
        numPulseSignalValue.TabIndex = 6;
        numPulseSignalValue.Value = new decimal(new int[] { 0, 0, 0, 0 });
        // 
        // sep79
        // 
        sep79.Dock = DockStyle.Top;
        sep79.Location = new Point(5, 112);
        sep79.Name = "sep79";
        sep79.Size = new Size(238, 5);
        sep79.TabIndex = 7;
        // 
        // numPulseSignalPulses
        // 
        numPulseSignalPulses.Dock = DockStyle.Top;
        numPulseSignalPulses.Location = new Point(5, 117);
        numPulseSignalPulses.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numPulseSignalPulses.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numPulseSignalPulses.Name = "numPulseSignalPulses";
        numPulseSignalPulses.Size = new Size(238, 23);
        numPulseSignalPulses.TabIndex = 8;
        numPulseSignalPulses.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // sep80
        // 
        sep80.Dock = DockStyle.Top;
        sep80.Location = new Point(5, 140);
        sep80.Name = "sep80";
        sep80.Size = new Size(238, 5);
        sep80.TabIndex = 9;
        // 
        // txtPulseSignalActivePulseLength
        // 
        txtPulseSignalActivePulseLength.Dock = DockStyle.Top;
        txtPulseSignalActivePulseLength.Location = new Point(5, 145);
        txtPulseSignalActivePulseLength.Name = "txtPulseSignalActivePulseLength";
        txtPulseSignalActivePulseLength.PlaceholderText = "activePulseLength ms (optional)";
        txtPulseSignalActivePulseLength.Size = new Size(238, 23);
        txtPulseSignalActivePulseLength.TabIndex = 10;
        // 
        // sep81
        // 
        sep81.Dock = DockStyle.Top;
        sep81.Location = new Point(5, 168);
        sep81.Name = "sep81";
        sep81.Size = new Size(238, 5);
        sep81.TabIndex = 11;
        // 
        // txtPulseSignalPassivePulseLength
        // 
        txtPulseSignalPassivePulseLength.Dock = DockStyle.Top;
        txtPulseSignalPassivePulseLength.Location = new Point(5, 173);
        txtPulseSignalPassivePulseLength.Name = "txtPulseSignalPassivePulseLength";
        txtPulseSignalPassivePulseLength.PlaceholderText = "passivePulseLength ms (optional)";
        txtPulseSignalPassivePulseLength.Size = new Size(238, 23);
        txtPulseSignalPassivePulseLength.TabIndex = 12;
        // 
        // sep82
        // 
        sep82.Dock = DockStyle.Top;
        sep82.Location = new Point(5, 196);
        sep82.Name = "sep82";
        sep82.Size = new Size(238, 5);
        sep82.TabIndex = 13;
        // 
        // chkPulseSignalLogToEventLog
        // 
        chkPulseSignalLogToEventLog.Dock = DockStyle.Top;
        chkPulseSignalLogToEventLog.Location = new Point(5, 201);
        chkPulseSignalLogToEventLog.Name = "chkPulseSignalLogToEventLog";
        chkPulseSignalLogToEventLog.Size = new Size(238, 23);
        chkPulseSignalLogToEventLog.TabIndex = 14;
        chkPulseSignalLogToEventLog.Text = "Log to event log";
        chkPulseSignalLogToEventLog.UseVisualStyleBackColor = true;
        // 
        // sep83
        // 
        sep83.Dock = DockStyle.Top;
        sep83.Location = new Point(5, 224);
        sep83.Name = "sep83";
        sep83.Size = new Size(238, 5);
        sep83.TabIndex = 15;
        // 
        // btnPulseSignal
        // 
        btnPulseSignal.Dock = DockStyle.Top;
        btnPulseSignal.Location = new Point(5, 229);
        btnPulseSignal.Name = "btnPulseSignal";
        btnPulseSignal.Size = new Size(238, 23);
        btnPulseSignal.TabIndex = 16;
        btnPulseSignal.Text = "Pulse Signal";
        btnPulseSignal.UseVisualStyleBackColor = true;
        btnPulseSignal.Click += btnPulseSignal_Click;
        // 
        // pnlToggleSignal
        // 
        pnlToggleSignal.BorderStyle = BorderStyle.FixedSingle;
        pnlToggleSignal.Controls.Add(btnToggleSignal);
        pnlToggleSignal.Controls.Add(sep91);
        pnlToggleSignal.Controls.Add(chkToggleSignalLogToEventLog);
        pnlToggleSignal.Controls.Add(sep90);
        pnlToggleSignal.Controls.Add(txtToggleSignalPassivePulseLength);
        pnlToggleSignal.Controls.Add(sep89);
        pnlToggleSignal.Controls.Add(txtToggleSignalActivePulseLength);
        pnlToggleSignal.Controls.Add(sep88);
        pnlToggleSignal.Controls.Add(numToggleSignalPulses);
        pnlToggleSignal.Controls.Add(sep87);
        pnlToggleSignal.Controls.Add(numToggleSignalValue);
        pnlToggleSignal.Controls.Add(sep86);
        pnlToggleSignal.Controls.Add(txtToggleSignalSignal);
        pnlToggleSignal.Controls.Add(sep85);
        pnlToggleSignal.Controls.Add(txtToggleSignalDevice);
        pnlToggleSignal.Controls.Add(sep84);
        pnlToggleSignal.Controls.Add(txtToggleSignalNetwork);
        pnlToggleSignal.Location = new Point(3, 3);
        pnlToggleSignal.Name = "pnlToggleSignal";
        pnlToggleSignal.Padding = new Padding(5);
        pnlToggleSignal.Size = new Size(250, 259);
        pnlToggleSignal.TabIndex = 5;
        // 
        // txtToggleSignalNetwork
        // 
        txtToggleSignalNetwork.Dock = DockStyle.Top;
        txtToggleSignalNetwork.Location = new Point(5, 5);
        txtToggleSignalNetwork.Name = "txtToggleSignalNetwork";
        txtToggleSignalNetwork.PlaceholderText = "network";
        txtToggleSignalNetwork.Size = new Size(238, 23);
        txtToggleSignalNetwork.TabIndex = 0;
        txtToggleSignalNetwork.Text = "Local";
        // 
        // sep84
        // 
        sep84.Dock = DockStyle.Top;
        sep84.Location = new Point(5, 28);
        sep84.Name = "sep84";
        sep84.Size = new Size(238, 5);
        sep84.TabIndex = 1;
        // 
        // txtToggleSignalDevice
        // 
        txtToggleSignalDevice.Dock = DockStyle.Top;
        txtToggleSignalDevice.Location = new Point(5, 33);
        txtToggleSignalDevice.Name = "txtToggleSignalDevice";
        txtToggleSignalDevice.PlaceholderText = "device";
        txtToggleSignalDevice.Size = new Size(238, 23);
        txtToggleSignalDevice.TabIndex = 2;
        txtToggleSignalDevice.Text = "DRV_1";
        // 
        // sep85
        // 
        sep85.Dock = DockStyle.Top;
        sep85.Location = new Point(5, 56);
        sep85.Name = "sep85";
        sep85.Size = new Size(238, 5);
        sep85.TabIndex = 3;
        // 
        // txtToggleSignalSignal
        // 
        txtToggleSignalSignal.Dock = DockStyle.Top;
        txtToggleSignalSignal.Location = new Point(5, 61);
        txtToggleSignalSignal.Name = "txtToggleSignalSignal";
        txtToggleSignalSignal.PlaceholderText = "signal";
        txtToggleSignalSignal.Size = new Size(238, 23);
        txtToggleSignalSignal.TabIndex = 4;
        txtToggleSignalSignal.Text = "DRV1K1";
        // 
        // sep86
        // 
        sep86.Dock = DockStyle.Top;
        sep86.Location = new Point(5, 84);
        sep86.Name = "sep86";
        sep86.Size = new Size(238, 5);
        sep86.TabIndex = 5;
        // 
        // numToggleSignalValue
        // 
        numToggleSignalValue.Dock = DockStyle.Top;
        numToggleSignalValue.Location = new Point(5, 89);
        numToggleSignalValue.DecimalPlaces = 3;
        numToggleSignalValue.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numToggleSignalValue.Minimum = new decimal(new int[] { 99999999, 0, 0, -2147483648 });
        numToggleSignalValue.Name = "numToggleSignalValue";
        numToggleSignalValue.Size = new Size(238, 23);
        numToggleSignalValue.TabIndex = 6;
        numToggleSignalValue.Value = new decimal(new int[] { 0, 0, 0, 0 });
        // 
        // sep87
        // 
        sep87.Dock = DockStyle.Top;
        sep87.Location = new Point(5, 112);
        sep87.Name = "sep87";
        sep87.Size = new Size(238, 5);
        sep87.TabIndex = 7;
        // 
        // numToggleSignalPulses
        // 
        numToggleSignalPulses.Dock = DockStyle.Top;
        numToggleSignalPulses.Location = new Point(5, 117);
        numToggleSignalPulses.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numToggleSignalPulses.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numToggleSignalPulses.Name = "numToggleSignalPulses";
        numToggleSignalPulses.Size = new Size(238, 23);
        numToggleSignalPulses.TabIndex = 8;
        numToggleSignalPulses.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // sep88
        // 
        sep88.Dock = DockStyle.Top;
        sep88.Location = new Point(5, 140);
        sep88.Name = "sep88";
        sep88.Size = new Size(238, 5);
        sep88.TabIndex = 9;
        // 
        // txtToggleSignalActivePulseLength
        // 
        txtToggleSignalActivePulseLength.Dock = DockStyle.Top;
        txtToggleSignalActivePulseLength.Location = new Point(5, 145);
        txtToggleSignalActivePulseLength.Name = "txtToggleSignalActivePulseLength";
        txtToggleSignalActivePulseLength.PlaceholderText = "activePulseLength ms (optional)";
        txtToggleSignalActivePulseLength.Size = new Size(238, 23);
        txtToggleSignalActivePulseLength.TabIndex = 10;
        // 
        // sep89
        // 
        sep89.Dock = DockStyle.Top;
        sep89.Location = new Point(5, 168);
        sep89.Name = "sep89";
        sep89.Size = new Size(238, 5);
        sep89.TabIndex = 11;
        // 
        // txtToggleSignalPassivePulseLength
        // 
        txtToggleSignalPassivePulseLength.Dock = DockStyle.Top;
        txtToggleSignalPassivePulseLength.Location = new Point(5, 173);
        txtToggleSignalPassivePulseLength.Name = "txtToggleSignalPassivePulseLength";
        txtToggleSignalPassivePulseLength.PlaceholderText = "passivePulseLength ms (optional)";
        txtToggleSignalPassivePulseLength.Size = new Size(238, 23);
        txtToggleSignalPassivePulseLength.TabIndex = 12;
        // 
        // sep90
        // 
        sep90.Dock = DockStyle.Top;
        sep90.Location = new Point(5, 196);
        sep90.Name = "sep90";
        sep90.Size = new Size(238, 5);
        sep90.TabIndex = 13;
        // 
        // chkToggleSignalLogToEventLog
        // 
        chkToggleSignalLogToEventLog.Dock = DockStyle.Top;
        chkToggleSignalLogToEventLog.Location = new Point(5, 201);
        chkToggleSignalLogToEventLog.Name = "chkToggleSignalLogToEventLog";
        chkToggleSignalLogToEventLog.Size = new Size(238, 23);
        chkToggleSignalLogToEventLog.TabIndex = 14;
        chkToggleSignalLogToEventLog.Text = "Log to event log";
        chkToggleSignalLogToEventLog.UseVisualStyleBackColor = true;
        // 
        // sep91
        // 
        sep91.Dock = DockStyle.Top;
        sep91.Location = new Point(5, 224);
        sep91.Name = "sep91";
        sep91.Size = new Size(238, 5);
        sep91.TabIndex = 15;
        // 
        // btnToggleSignal
        // 
        btnToggleSignal.Dock = DockStyle.Top;
        btnToggleSignal.Location = new Point(5, 229);
        btnToggleSignal.Name = "btnToggleSignal";
        btnToggleSignal.Size = new Size(238, 23);
        btnToggleSignal.TabIndex = 16;
        btnToggleSignal.Text = "Toggle Signal";
        btnToggleSignal.UseVisualStyleBackColor = true;
        btnToggleSignal.Click += btnToggleSignal_Click;
        // 
        // tabSignalSearch
        // 
        tabSignalSearch.Controls.Add(flowSignalSearch);
        tabSignalSearch.Location = new Point(4, 24);
        tabSignalSearch.Name = "tabSignalSearch";
        tabSignalSearch.Padding = new Padding(3);
        tabSignalSearch.Size = new Size(882, 463);
        tabSignalSearch.TabIndex = 5;
        tabSignalSearch.Text = "Signal search";
        tabSignalSearch.UseVisualStyleBackColor = true;
        // 
        // flowSignalSearch
        // 
        flowSignalSearch.AutoScroll = true;
        flowSignalSearch.Controls.Add(pnlSearchSignals);
        flowSignalSearch.Controls.Add(pnlSearchSignalsResult);
        flowSignalSearch.Dock = DockStyle.Fill;
        flowSignalSearch.FlowDirection = FlowDirection.TopDown;
        flowSignalSearch.Location = new Point(3, 3);
        flowSignalSearch.Name = "flowSignalSearch";
        flowSignalSearch.Size = new Size(876, 457);
        flowSignalSearch.TabIndex = 0;
        // 
        // pnlSearchSignals
        // 
        pnlSearchSignals.BorderStyle = BorderStyle.FixedSingle;
        pnlSearchSignals.Controls.Add(btnSearchSignalsExtended);
        pnlSearchSignals.Controls.Add(sep102);
        pnlSearchSignals.Controls.Add(btnSearchSignals);
        pnlSearchSignals.Controls.Add(sep101);
        pnlSearchSignals.Controls.Add(txtSearchSignalsLimit);
        pnlSearchSignals.Controls.Add(sep100);
        pnlSearchSignals.Controls.Add(txtSearchSignalsStart);
        pnlSearchSignals.Controls.Add(sep99);
        pnlSearchSignals.Controls.Add(cboSearchSignalsBlocked);
        pnlSearchSignals.Controls.Add(sep98);
        pnlSearchSignals.Controls.Add(cboSearchSignalsInvert);
        pnlSearchSignals.Controls.Add(sep97);
        pnlSearchSignals.Controls.Add(cboSearchSignalsType);
        pnlSearchSignals.Controls.Add(sep96);
        pnlSearchSignals.Controls.Add(txtSearchSignalsCategoryPrefix);
        pnlSearchSignals.Controls.Add(sep95);
        pnlSearchSignals.Controls.Add(txtSearchSignalsCategory);
        pnlSearchSignals.Controls.Add(sep94);
        pnlSearchSignals.Controls.Add(txtSearchSignalsNetwork);
        pnlSearchSignals.Controls.Add(sep93);
        pnlSearchSignals.Controls.Add(txtSearchSignalsDevice);
        pnlSearchSignals.Controls.Add(sep92);
        pnlSearchSignals.Controls.Add(txtSearchSignalsName);
        pnlSearchSignals.Location = new Point(3, 3);
        pnlSearchSignals.Name = "pnlSearchSignals";
        pnlSearchSignals.Padding = new Padding(5);
        pnlSearchSignals.Size = new Size(250, 343);
        pnlSearchSignals.TabIndex = 0;
        // 
        // txtSearchSignalsName
        // 
        txtSearchSignalsName.Dock = DockStyle.Top;
        txtSearchSignalsName.Location = new Point(5, 5);
        txtSearchSignalsName.Name = "txtSearchSignalsName";
        txtSearchSignalsName.PlaceholderText = "name (optional)";
        txtSearchSignalsName.Size = new Size(238, 23);
        txtSearchSignalsName.TabIndex = 0;
        // 
        // sep92
        // 
        sep92.Dock = DockStyle.Top;
        sep92.Location = new Point(5, 28);
        sep92.Name = "sep92";
        sep92.Size = new Size(238, 5);
        sep92.TabIndex = 1;
        // 
        // txtSearchSignalsDevice
        // 
        txtSearchSignalsDevice.Dock = DockStyle.Top;
        txtSearchSignalsDevice.Location = new Point(5, 33);
        txtSearchSignalsDevice.Name = "txtSearchSignalsDevice";
        txtSearchSignalsDevice.PlaceholderText = "device (optional)";
        txtSearchSignalsDevice.Size = new Size(238, 23);
        txtSearchSignalsDevice.TabIndex = 2;
        // 
        // sep93
        // 
        sep93.Dock = DockStyle.Top;
        sep93.Location = new Point(5, 56);
        sep93.Name = "sep93";
        sep93.Size = new Size(238, 5);
        sep93.TabIndex = 3;
        // 
        // txtSearchSignalsNetwork
        // 
        txtSearchSignalsNetwork.Dock = DockStyle.Top;
        txtSearchSignalsNetwork.Location = new Point(5, 61);
        txtSearchSignalsNetwork.Name = "txtSearchSignalsNetwork";
        txtSearchSignalsNetwork.PlaceholderText = "network (optional)";
        txtSearchSignalsNetwork.Size = new Size(238, 23);
        txtSearchSignalsNetwork.TabIndex = 4;
        // 
        // sep94
        // 
        sep94.Dock = DockStyle.Top;
        sep94.Location = new Point(5, 84);
        sep94.Name = "sep94";
        sep94.Size = new Size(238, 5);
        sep94.TabIndex = 5;
        // 
        // txtSearchSignalsCategory
        // 
        txtSearchSignalsCategory.Dock = DockStyle.Top;
        txtSearchSignalsCategory.Location = new Point(5, 89);
        txtSearchSignalsCategory.Name = "txtSearchSignalsCategory";
        txtSearchSignalsCategory.PlaceholderText = "category (optional)";
        txtSearchSignalsCategory.Size = new Size(238, 23);
        txtSearchSignalsCategory.TabIndex = 6;
        // 
        // sep95
        // 
        sep95.Dock = DockStyle.Top;
        sep95.Location = new Point(5, 112);
        sep95.Name = "sep95";
        sep95.Size = new Size(238, 5);
        sep95.TabIndex = 7;
        // 
        // txtSearchSignalsCategoryPrefix
        // 
        txtSearchSignalsCategoryPrefix.Dock = DockStyle.Top;
        txtSearchSignalsCategoryPrefix.Location = new Point(5, 117);
        txtSearchSignalsCategoryPrefix.Name = "txtSearchSignalsCategoryPrefix";
        txtSearchSignalsCategoryPrefix.PlaceholderText = "categoryPrefix (optional)";
        txtSearchSignalsCategoryPrefix.Size = new Size(238, 23);
        txtSearchSignalsCategoryPrefix.TabIndex = 8;
        // 
        // sep96
        // 
        sep96.Dock = DockStyle.Top;
        sep96.Location = new Point(5, 140);
        sep96.Name = "sep96";
        sep96.Size = new Size(238, 5);
        sep96.TabIndex = 9;
        // 
        // cboSearchSignalsType
        // 
        cboSearchSignalsType.Dock = DockStyle.Top;
        cboSearchSignalsType.Location = new Point(5, 145);
        cboSearchSignalsType.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSearchSignalsType.FormattingEnabled = true;
        cboSearchSignalsType.Name = "cboSearchSignalsType";
        cboSearchSignalsType.Size = new Size(238, 23);
        cboSearchSignalsType.TabIndex = 10;
        // 
        // sep97
        // 
        sep97.Dock = DockStyle.Top;
        sep97.Location = new Point(5, 168);
        sep97.Name = "sep97";
        sep97.Size = new Size(238, 5);
        sep97.TabIndex = 11;
        // 
        // cboSearchSignalsInvert
        // 
        cboSearchSignalsInvert.Dock = DockStyle.Top;
        cboSearchSignalsInvert.Location = new Point(5, 173);
        cboSearchSignalsInvert.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSearchSignalsInvert.FormattingEnabled = true;
        cboSearchSignalsInvert.Name = "cboSearchSignalsInvert";
        cboSearchSignalsInvert.Size = new Size(238, 23);
        cboSearchSignalsInvert.TabIndex = 12;
        // 
        // sep98
        // 
        sep98.Dock = DockStyle.Top;
        sep98.Location = new Point(5, 196);
        sep98.Name = "sep98";
        sep98.Size = new Size(238, 5);
        sep98.TabIndex = 13;
        // 
        // cboSearchSignalsBlocked
        // 
        cboSearchSignalsBlocked.Dock = DockStyle.Top;
        cboSearchSignalsBlocked.Location = new Point(5, 201);
        cboSearchSignalsBlocked.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSearchSignalsBlocked.FormattingEnabled = true;
        cboSearchSignalsBlocked.Name = "cboSearchSignalsBlocked";
        cboSearchSignalsBlocked.Size = new Size(238, 23);
        cboSearchSignalsBlocked.TabIndex = 14;
        // 
        // sep99
        // 
        sep99.Dock = DockStyle.Top;
        sep99.Location = new Point(5, 224);
        sep99.Name = "sep99";
        sep99.Size = new Size(238, 5);
        sep99.TabIndex = 15;
        // 
        // txtSearchSignalsStart
        // 
        txtSearchSignalsStart.Dock = DockStyle.Top;
        txtSearchSignalsStart.Location = new Point(5, 229);
        txtSearchSignalsStart.Name = "txtSearchSignalsStart";
        txtSearchSignalsStart.PlaceholderText = "start (optional)";
        txtSearchSignalsStart.Size = new Size(238, 23);
        txtSearchSignalsStart.TabIndex = 16;
        // 
        // sep100
        // 
        sep100.Dock = DockStyle.Top;
        sep100.Location = new Point(5, 252);
        sep100.Name = "sep100";
        sep100.Size = new Size(238, 5);
        sep100.TabIndex = 17;
        // 
        // txtSearchSignalsLimit
        // 
        txtSearchSignalsLimit.Dock = DockStyle.Top;
        txtSearchSignalsLimit.Location = new Point(5, 257);
        txtSearchSignalsLimit.Name = "txtSearchSignalsLimit";
        txtSearchSignalsLimit.PlaceholderText = "limit (optional)";
        txtSearchSignalsLimit.Size = new Size(238, 23);
        txtSearchSignalsLimit.TabIndex = 18;
        // 
        // sep101
        // 
        sep101.Dock = DockStyle.Top;
        sep101.Location = new Point(5, 280);
        sep101.Name = "sep101";
        sep101.Size = new Size(238, 5);
        sep101.TabIndex = 19;
        // 
        // btnSearchSignals
        // 
        btnSearchSignals.Dock = DockStyle.Top;
        btnSearchSignals.Location = new Point(5, 285);
        btnSearchSignals.Name = "btnSearchSignals";
        btnSearchSignals.Size = new Size(238, 23);
        btnSearchSignals.TabIndex = 20;
        btnSearchSignals.Text = "Search Signals";
        btnSearchSignals.UseVisualStyleBackColor = true;
        btnSearchSignals.Click += btnSearchSignals_Click;
        // 
        // sep102
        // 
        sep102.Dock = DockStyle.Top;
        sep102.Location = new Point(5, 308);
        sep102.Name = "sep102";
        sep102.Size = new Size(238, 5);
        sep102.TabIndex = 21;
        // 
        // btnSearchSignalsExtended
        // 
        btnSearchSignalsExtended.Dock = DockStyle.Top;
        btnSearchSignalsExtended.Location = new Point(5, 313);
        btnSearchSignalsExtended.Name = "btnSearchSignalsExtended";
        btnSearchSignalsExtended.Size = new Size(238, 23);
        btnSearchSignalsExtended.TabIndex = 22;
        btnSearchSignalsExtended.Text = "Search Signals extended";
        btnSearchSignalsExtended.UseVisualStyleBackColor = true;
        btnSearchSignalsExtended.Click += btnSearchSignalsExtended_Click;
        // 
        // pnlSearchSignalsResult
        // 
        pnlSearchSignalsResult.BorderStyle = BorderStyle.FixedSingle;
        pnlSearchSignalsResult.Controls.Add(gridSearchSignals);
        pnlSearchSignalsResult.Location = new Point(3, 3);
        pnlSearchSignalsResult.Name = "pnlSearchSignalsResult";
        pnlSearchSignalsResult.Padding = new Padding(5);
        pnlSearchSignalsResult.Size = new Size(250, 417);
        pnlSearchSignalsResult.TabIndex = 1;
        // 
        // gridSearchSignals
        // 
        gridSearchSignals.Dock = DockStyle.Top;
        gridSearchSignals.Location = new Point(5, 5);
        gridSearchSignals.HelpVisible = false;
        gridSearchSignals.Name = "gridSearchSignals";
        gridSearchSignals.PropertySort = PropertySort.NoSort;
        gridSearchSignals.Size = new Size(238, 405);
        gridSearchSignals.TabIndex = 0;
        gridSearchSignals.ToolbarVisible = false;
        //
        // RwsIoControl
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tabControl);
        Margin = new Padding(4, 3, 4, 3);
        Name = "RwsIoControl";
        Size = new Size(890, 491);
        tabControl.ResumeLayout(false);
        tabNetworks.ResumeLayout(false);
        flowNetworks.ResumeLayout(false);
        tabDevices.ResumeLayout(false);
        flowDevices.ResumeLayout(false);
        tabDeviceData.ResumeLayout(false);
        flowDeviceData.ResumeLayout(false);
        tabSignals.ResumeLayout(false);
        flowSignals.ResumeLayout(false);
        tabSignalWrite.ResumeLayout(false);
        flowSignalWrite.ResumeLayout(false);
        tabSignalSearch.ResumeLayout(false);
        flowSignalSearch.ResumeLayout(false);
        pnlIoResources.ResumeLayout(false);
        pnlNetworks.ResumeLayout(false);
        pnlNetwork.ResumeLayout(false);
        pnlNetwork.PerformLayout();
        pnlSearchNetworks.ResumeLayout(false);
        pnlSearchNetworks.PerformLayout();
        pnlNetworkConfiguration.ResumeLayout(false);
        pnlNetworkConfiguration.PerformLayout();
        pnlDevices.ResumeLayout(false);
        pnlDevice.ResumeLayout(false);
        pnlDevice.PerformLayout();
        pnlSearchDevices.ResumeLayout(false);
        pnlSearchDevices.PerformLayout();
        pnlDeviceConfiguration.ResumeLayout(false);
        pnlDeviceConfiguration.PerformLayout();
        pnlDeviceUpgradeInfo.ResumeLayout(false);
        pnlDeviceUpgradeInfo.PerformLayout();
        pnlDeviceInputData.ResumeLayout(false);
        pnlDeviceInputData.PerformLayout();
        pnlDeviceOutputData.ResumeLayout(false);
        pnlDeviceOutputData.PerformLayout();
        pnlDeviceCommand.ResumeLayout(false);
        pnlDeviceCommand.PerformLayout();
        pnlSignals.ResumeLayout(false);
        pnlSignal.ResumeLayout(false);
        pnlSignal.PerformLayout();
        pnlSignalConfiguration.ResumeLayout(false);
        pnlSignalConfiguration.PerformLayout();
        pnlUnblockSignals.ResumeLayout(false);
        pnlSetSignalValue.ResumeLayout(false);
        pnlSetSignalValue.PerformLayout();
        pnlSetSignalValueDelayed.ResumeLayout(false);
        pnlSetSignalValueDelayed.PerformLayout();
        pnlSetSignalState.ResumeLayout(false);
        pnlSetSignalState.PerformLayout();
        pnlInvertSignal.ResumeLayout(false);
        pnlInvertSignal.PerformLayout();
        pnlPulseSignal.ResumeLayout(false);
        pnlPulseSignal.PerformLayout();
        pnlToggleSignal.ResumeLayout(false);
        pnlToggleSignal.PerformLayout();
        pnlSearchSignals.ResumeLayout(false);
        pnlSearchSignals.PerformLayout();
        pnlSearchSignalsResult.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numSetDeviceInputDataStartByte).EndInit();
        ((System.ComponentModel.ISupportInitialize)numSetDeviceInputDataSignalData).EndInit();
        ((System.ComponentModel.ISupportInitialize)numSetDeviceInputDataDataMask).EndInit();
        ((System.ComponentModel.ISupportInitialize)numSetDeviceOutputDataStartByte).EndInit();
        ((System.ComponentModel.ISupportInitialize)numSetDeviceOutputDataSignalData).EndInit();
        ((System.ComponentModel.ISupportInitialize)numSetDeviceOutputDataDataMask).EndInit();
        ((System.ComponentModel.ISupportInitialize)numSendDeviceCommandValueLength).EndInit();
        ((System.ComponentModel.ISupportInitialize)numSendDeviceCommandTimeout).EndInit();
        ((System.ComponentModel.ISupportInitialize)numSetSignalValueValue).EndInit();
        ((System.ComponentModel.ISupportInitialize)numSetSignalValueDelayedValue).EndInit();
        ((System.ComponentModel.ISupportInitialize)numSetSignalValueDelayedDelay).EndInit();
        ((System.ComponentModel.ISupportInitialize)numInvertSignalValue).EndInit();
        ((System.ComponentModel.ISupportInitialize)numPulseSignalValue).EndInit();
        ((System.ComponentModel.ISupportInitialize)numPulseSignalPulses).EndInit();
        ((System.ComponentModel.ISupportInitialize)numToggleSignalValue).EndInit();
        ((System.ComponentModel.ISupportInitialize)numToggleSignalPulses).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl;

    private TabPage tabNetworks;
    private FlowLayoutPanel flowNetworks;

    private Panel pnlIoResources;
    private Button btnGetResources;
    private Panel sep1;
    private PropertyGrid gridResources;

    private Panel pnlNetworks;
    private Button btnGetNetworks;
    private Panel sep2;
    private PropertyGrid gridNetworks;

    private Panel pnlNetwork;
    private TextBox txtGetNetworkNetwork;
    private Panel sep3;
    private Button btnGetNetwork;
    private Panel sep4;
    private PropertyGrid gridNetwork;
    private Panel sep5;
    private ComboBox cboSetNetworkStateLogicalState;
    private Panel sep6;
    private Button btnSetNetworkState;

    private Panel pnlSearchNetworks;
    private TextBox txtSearchNetworksName;
    private Panel sep7;
    private ComboBox cboSearchNetworksPhysicalState;
    private Panel sep8;
    private Button btnSearchNetworks;
    private Panel sep9;
    private PropertyGrid gridSearchNetworks;

    private Panel pnlNetworkConfiguration;
    private TextBox txtNetworkConfigurationNetwork;
    private Panel sep10;
    private Button btnGetNetworkConfiguration;
    private Panel sep11;
    private PropertyGrid gridNetworkConfiguration;
    private Panel sep12;
    private ComboBox cboSetNetworkConfigurationType;
    private Panel sep13;
    private Button btnSetNetworkConfigurationType;
    private Panel sep14;
    private TextBox txtSetNetworkConfigurationTypeResult;

    private TabPage tabDevices;
    private FlowLayoutPanel flowDevices;

    private Panel pnlDevices;
    private Button btnGetDevices;
    private Panel sep15;
    private PropertyGrid gridDevices;

    private Panel pnlDevice;
    private TextBox txtGetDeviceNetwork;
    private Panel sep16;
    private TextBox txtGetDeviceDevice;
    private Panel sep17;
    private Button btnGetDevice;
    private Panel sep18;
    private PropertyGrid gridDevice;
    private Panel sep19;
    private ComboBox cboSetDeviceStateLogicalState;
    private Panel sep20;
    private Button btnSetDeviceState;

    private Panel pnlSearchDevices;
    private TextBox txtSearchDevicesName;
    private Panel sep21;
    private ComboBox cboSearchDevicesLogicalState;
    private Panel sep22;
    private TextBox txtSearchDevicesNetwork;
    private Panel sep23;
    private Button btnSearchDevices;
    private Panel sep24;
    private PropertyGrid gridSearchDevices;

    private Panel pnlDeviceConfiguration;
    private TextBox txtDeviceConfigurationNetwork;
    private Panel sep25;
    private TextBox txtDeviceConfigurationDevice;
    private Panel sep26;
    private Button btnGetDeviceConfiguration;
    private Panel sep27;
    private PropertyGrid gridDeviceConfiguration;

    private Panel pnlDeviceUpgradeInfo;
    private TextBox txtDeviceUpgradeInfoNetwork;
    private Panel sep28;
    private TextBox txtDeviceUpgradeInfoDevice;
    private Panel sep29;
    private Button btnGetDeviceUpgradeInfo;
    private Panel sep30;
    private PropertyGrid gridDeviceUpgradeInfo;

    private TabPage tabDeviceData;
    private FlowLayoutPanel flowDeviceData;

    private Panel pnlDeviceInputData;
    private TextBox txtSetDeviceInputDataNetwork;
    private Panel sep31;
    private TextBox txtSetDeviceInputDataDevice;
    private Panel sep32;
    private NumericUpDown numSetDeviceInputDataStartByte;
    private Panel sep33;
    private NumericUpDown numSetDeviceInputDataSignalData;
    private Panel sep34;
    private NumericUpDown numSetDeviceInputDataDataMask;
    private Panel sep35;
    private Button btnSetDeviceInputData;

    private Panel pnlDeviceOutputData;
    private TextBox txtSetDeviceOutputDataNetwork;
    private Panel sep36;
    private TextBox txtSetDeviceOutputDataDevice;
    private Panel sep37;
    private NumericUpDown numSetDeviceOutputDataStartByte;
    private Panel sep38;
    private NumericUpDown numSetDeviceOutputDataSignalData;
    private Panel sep39;
    private NumericUpDown numSetDeviceOutputDataDataMask;
    private Panel sep40;
    private Button btnSetDeviceOutputData;

    private Panel pnlDeviceCommand;
    private TextBox txtSendDeviceCommandNetwork;
    private Panel sep41;
    private TextBox txtSendDeviceCommandDevice;
    private Panel sep42;
    private TextBox txtSendDeviceCommandCommandName;
    private Panel sep43;
    private TextBox txtSendDeviceCommandValue;
    private Panel sep44;
    private NumericUpDown numSendDeviceCommandValueLength;
    private Panel sep45;
    private NumericUpDown numSendDeviceCommandTimeout;
    private Panel sep46;
    private Button btnSendDeviceCommand;

    private TabPage tabSignals;
    private FlowLayoutPanel flowSignals;

    private Panel pnlSignals;
    private Button btnGetSignals;
    private Panel sep47;
    private PropertyGrid gridSignals;

    private Panel pnlSignal;
    private TextBox txtGetSignalNetwork;
    private Panel sep48;
    private TextBox txtGetSignalDevice;
    private Panel sep49;
    private TextBox txtGetSignalSignal;
    private Panel sep50;
    private Button btnGetSignal;
    private Panel sep51;
    private PropertyGrid gridSignal;

    private Panel pnlSignalConfiguration;
    private TextBox txtSignalConfigurationNetwork;
    private Panel sep52;
    private TextBox txtSignalConfigurationDevice;
    private Panel sep53;
    private TextBox txtSignalConfigurationSignal;
    private Panel sep54;
    private Button btnGetSignalConfiguration;
    private Panel sep55;
    private PropertyGrid gridSignalConfiguration;

    private Panel pnlUnblockSignals;
    private Button btnUnblockSignals;

    private TabPage tabSignalWrite;
    private FlowLayoutPanel flowSignalWrite;

    private Panel pnlSetSignalValue;
    private TextBox txtSetSignalValueNetwork;
    private Panel sep56;
    private TextBox txtSetSignalValueDevice;
    private Panel sep57;
    private TextBox txtSetSignalValueSignal;
    private Panel sep58;
    private NumericUpDown numSetSignalValueValue;
    private Panel sep59;
    private CheckBox chkSetSignalValueLogToEventLog;
    private Panel sep60;
    private Button btnSetSignalValue;

    private Panel pnlSetSignalValueDelayed;
    private TextBox txtSetSignalValueDelayedNetwork;
    private Panel sep61;
    private TextBox txtSetSignalValueDelayedDevice;
    private Panel sep62;
    private TextBox txtSetSignalValueDelayedSignal;
    private Panel sep63;
    private NumericUpDown numSetSignalValueDelayedValue;
    private Panel sep64;
    private NumericUpDown numSetSignalValueDelayedDelay;
    private Panel sep65;
    private CheckBox chkSetSignalValueDelayedLogToEventLog;
    private Panel sep66;
    private Button btnSetSignalValueDelayed;

    private Panel pnlSetSignalState;
    private TextBox txtSetSignalStateNetwork;
    private Panel sep67;
    private TextBox txtSetSignalStateDevice;
    private Panel sep68;
    private TextBox txtSetSignalStateSignal;
    private Panel sep69;
    private CheckBox chkSetSignalStateSimulated;
    private Panel sep70;
    private Button btnSetSignalState;

    private Panel pnlInvertSignal;
    private TextBox txtInvertSignalNetwork;
    private Panel sep71;
    private TextBox txtInvertSignalDevice;
    private Panel sep72;
    private TextBox txtInvertSignalSignal;
    private Panel sep73;
    private NumericUpDown numInvertSignalValue;
    private Panel sep74;
    private CheckBox chkInvertSignalLogToEventLog;
    private Panel sep75;
    private Button btnInvertSignal;

    private Panel pnlPulseSignal;
    private TextBox txtPulseSignalNetwork;
    private Panel sep76;
    private TextBox txtPulseSignalDevice;
    private Panel sep77;
    private TextBox txtPulseSignalSignal;
    private Panel sep78;
    private NumericUpDown numPulseSignalValue;
    private Panel sep79;
    private NumericUpDown numPulseSignalPulses;
    private Panel sep80;
    private TextBox txtPulseSignalActivePulseLength;
    private Panel sep81;
    private TextBox txtPulseSignalPassivePulseLength;
    private Panel sep82;
    private CheckBox chkPulseSignalLogToEventLog;
    private Panel sep83;
    private Button btnPulseSignal;

    private Panel pnlToggleSignal;
    private TextBox txtToggleSignalNetwork;
    private Panel sep84;
    private TextBox txtToggleSignalDevice;
    private Panel sep85;
    private TextBox txtToggleSignalSignal;
    private Panel sep86;
    private NumericUpDown numToggleSignalValue;
    private Panel sep87;
    private NumericUpDown numToggleSignalPulses;
    private Panel sep88;
    private TextBox txtToggleSignalActivePulseLength;
    private Panel sep89;
    private TextBox txtToggleSignalPassivePulseLength;
    private Panel sep90;
    private CheckBox chkToggleSignalLogToEventLog;
    private Panel sep91;
    private Button btnToggleSignal;

    private TabPage tabSignalSearch;
    private FlowLayoutPanel flowSignalSearch;

    private Panel pnlSearchSignals;
    private TextBox txtSearchSignalsName;
    private Panel sep92;
    private TextBox txtSearchSignalsDevice;
    private Panel sep93;
    private TextBox txtSearchSignalsNetwork;
    private Panel sep94;
    private TextBox txtSearchSignalsCategory;
    private Panel sep95;
    private TextBox txtSearchSignalsCategoryPrefix;
    private Panel sep96;
    private ComboBox cboSearchSignalsType;
    private Panel sep97;
    private ComboBox cboSearchSignalsInvert;
    private Panel sep98;
    private ComboBox cboSearchSignalsBlocked;
    private Panel sep99;
    private TextBox txtSearchSignalsStart;
    private Panel sep100;
    private TextBox txtSearchSignalsLimit;
    private Panel sep101;
    private Button btnSearchSignals;
    private Panel sep102;
    private Button btnSearchSignalsExtended;

    private Panel pnlSearchSignalsResult;
    private PropertyGrid gridSearchSignals;
}
