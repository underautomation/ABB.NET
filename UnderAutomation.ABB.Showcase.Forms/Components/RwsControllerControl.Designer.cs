
partial class RwsControllerControl
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
        tabGeneral = new TabPage();
        flowGeneral = new FlowLayoutPanel();
        pnlControllerInfo = new Panel();
        gridControllerInfo = new PropertyGrid();
        sep1 = new Panel();
        btnGetControllerInfo = new Button();
        pnlEnvironmentVariable = new Panel();
        txtEnvironmentVariableValue = new TextBox();
        sep3 = new Panel();
        btnGetEnvironmentVariable = new Button();
        sep2 = new Panel();
        txtEnvironmentVariableName = new TextBox();
        pnlInstalledSystems = new Panel();
        gridInstalledSystems = new PropertyGrid();
        sep4 = new Panel();
        btnGetInstalledSystems = new Button();
        pnlOption = new Panel();
        chkHasOptionResult = new CheckBox();
        sep6 = new Panel();
        btnHasOption = new Button();
        sep5 = new Panel();
        txtHasOptionOption = new TextBox();
        pnlCompatibility = new Panel();
        chkIsRobotWareVersionCompatibleResult = new CheckBox();
        sep8 = new Panel();
        btnIsRobotWareVersionCompatible = new Button();
        sep7 = new Panel();
        txtIsRobotWareVersionCompatibleRobotWareVersion = new TextBox();
        pnlLanguage = new Panel();
        btnSetLanguage = new Button();
        sep9 = new Panel();
        txtSetLanguageLanguage = new TextBox();
        pnlRestart = new Panel();
        btnRestart = new Button();
        sep11 = new Panel();
        chkRestartUseImplicitMastership = new CheckBox();
        sep10 = new Panel();
        cboRestartMode = new ComboBox();
        tabIdentity = new TabPage();
        flowIdentity = new FlowLayoutPanel();
        pnlIdentity = new Panel();
        btnSetIdentity = new Button();
        sep15 = new Panel();
        txtSetIdentityId = new TextBox();
        sep14 = new Panel();
        txtSetIdentityName = new TextBox();
        sep13 = new Panel();
        gridIdentity = new PropertyGrid();
        sep12 = new Panel();
        btnGetIdentity = new Button();
        pnlNetwork = new Panel();
        btnSetNetworkConfiguration = new Button();
        sep21 = new Panel();
        txtSetNetworkConfigurationGateway = new TextBox();
        sep20 = new Panel();
        txtSetNetworkConfigurationMask = new TextBox();
        sep19 = new Panel();
        txtSetNetworkConfigurationAddress = new TextBox();
        sep18 = new Panel();
        cboSetNetworkConfigurationMethod = new ComboBox();
        sep17 = new Panel();
        gridNetworkInterfaces = new PropertyGrid();
        sep16 = new Panel();
        btnGetNetworkInterfaces = new Button();
        tabClock = new TabPage();
        flowClock = new FlowLayoutPanel();
        pnlClock = new Panel();
        btnSetClock = new Button();
        sep23 = new Panel();
        dtpClock = new DateTimePicker();
        sep22 = new Panel();
        btnGetClock = new Button();
        pnlTimeZone = new Panel();
        btnSetTimeZone = new Button();
        sep25 = new Panel();
        txtTimeZone = new TextBox();
        sep24 = new Panel();
        btnGetTimeZone = new Button();
        pnlTimeServer = new Panel();
        btnSetTimeServer = new Button();
        sep29 = new Panel();
        txtSetTimeServerTimeServer = new TextBox();
        sep28 = new Panel();
        gridTimeServer = new PropertyGrid();
        sep27 = new Panel();
        btnGetTimeServer = new Button();
        sep26 = new Panel();
        txtGetTimeServerServerIp = new TextBox();
        tabBackup = new TabPage();
        flowBackup = new FlowLayoutPanel();
        pnlBackupResources = new Panel();
        gridBackupResources = new PropertyGrid();
        sep30 = new Panel();
        btnGetBackupResources = new Button();
        pnlBackupInfo = new Panel();
        gridBackupInfo = new PropertyGrid();
        sep32 = new Panel();
        btnGetBackupInfo = new Button();
        sep31 = new Panel();
        txtGetBackupInfoBackupPath = new TextBox();
        pnlBackupState = new Panel();
        txtBackupState = new TextBox();
        sep33 = new Panel();
        btnGetBackupState = new Button();
        pnlCreateBackup = new Panel();
        btnCreateBackup = new Button();
        sep35 = new Panel();
        chkCreateBackupArchive = new CheckBox();
        sep34 = new Panel();
        txtCreateBackupBackupPath = new TextBox();
        pnlRestoreBackup = new Panel();
        btnRestoreBackup = new Button();
        sep41 = new Panel();
        chkRestoreBackupIncludeSafetySettings = new CheckBox();
        sep40 = new Panel();
        chkRestoreBackupIncludeControllerSettings = new CheckBox();
        sep39 = new Panel();
        chkRestoreBackupDeleteDirectory = new CheckBox();
        sep38 = new Panel();
        cboRestoreBackupInclude = new ComboBox();
        sep37 = new Panel();
        cboRestoreBackupIgnore = new ComboBox();
        sep36 = new Panel();
        txtRestoreBackupBackupPath = new TextBox();
        pnlCheckRestore = new Panel();
        gridCheckRestore = new PropertyGrid();
        sep47 = new Panel();
        btnCheckRestore = new Button();
        sep46 = new Panel();
        chkCheckRestoreIncludeSafetySettings = new CheckBox();
        sep45 = new Panel();
        chkCheckRestoreIncludeControllerSettings = new CheckBox();
        sep44 = new Panel();
        cboCheckRestoreInclude = new ComboBox();
        sep43 = new Panel();
        cboCheckRestoreIgnore = new ComboBox();
        sep42 = new Panel();
        txtCheckRestoreBackupPath = new TextBox();
        tabSafety = new TabPage();
        flowSafety = new FlowLayoutPanel();
        pnlSafetyResources = new Panel();
        gridSafetyResources = new PropertyGrid();
        sep48 = new Panel();
        btnGetSafetyResources = new Button();
        pnlSafetyMode = new Panel();
        btnSetSafetyMode = new Button();
        sep51 = new Panel();
        cboSetSafetyModeMode = new ComboBox();
        sep50 = new Panel();
        gridSafetyMode = new PropertyGrid();
        sep49 = new Panel();
        btnGetSafetyMode = new Button();
        pnlSafetyConfiguration = new Panel();
        btnLoadSafetyConfiguration = new Button();
        sep54 = new Panel();
        txtLoadSafetyConfigurationFilePath = new TextBox();
        sep53 = new Panel();
        gridSafetyConfiguration = new PropertyGrid();
        sep52 = new Panel();
        btnGetSafetyConfiguration = new Button();
        pnlInvalidateSafetyConfiguration = new Panel();
        btnInvalidateSafetyConfiguration = new Button();
        pnlSafetyLoadOperationStatus = new Panel();
        txtSafetyLoadOperationStatus = new TextBox();
        sep55 = new Panel();
        btnGetSafetyLoadOperationStatus = new Button();
        pnlCyclicBrakeCheckStatus = new Panel();
        gridCyclicBrakeCheckStatus = new PropertyGrid();
        sep57 = new Panel();
        btnGetCyclicBrakeCheckStatus = new Button();
        sep56 = new Panel();
        numGetCyclicBrakeCheckStatusDriveNumber = new NumericUpDown();
        pnlSafetyViolationInfo = new Panel();
        gridSafetyViolationInfo = new PropertyGrid();
        sep58 = new Panel();
        btnGetSafetyViolationInfo = new Button();
        tabVirtualTime = new TabPage();
        flowVirtualTime = new FlowLayoutPanel();
        pnlVirtualTimeResources = new Panel();
        gridVirtualTimeResources = new PropertyGrid();
        sep59 = new Panel();
        btnGetVirtualTimeResources = new Button();
        pnlVirtualTime = new Panel();
        txtVirtualTime = new TextBox();
        sep60 = new Panel();
        btnGetVirtualTime = new Button();
        pnlVirtualTimeSpeed = new Panel();
        btnSetVirtualTimeSpeed = new Button();
        sep62 = new Panel();
        numSetVirtualTimeSpeedSpeed = new NumericUpDown();
        sep61 = new Panel();
        btnGetVirtualTimeSpeed = new Button();
        pnlVirtualTimeState = new Panel();
        btnSetVirtualTimeState = new Button();
        sep64 = new Panel();
        cboSetVirtualTimeStateState = new ComboBox();
        sep63 = new Panel();
        btnGetVirtualTimeState = new Button();
        pnlVirtualTimeSlice = new Panel();
        btnSetVirtualTimeSlice = new Button();
        sep66 = new Panel();
        numSetVirtualTimeSliceMilliseconds = new NumericUpDown();
        sep65 = new Panel();
        btnGetVirtualTimeSlice = new Button();
        pnlRunVirtualTime = new Panel();
        btnRunVirtualTime = new Button();
        tabControl.SuspendLayout();
        tabGeneral.SuspendLayout();
        flowGeneral.SuspendLayout();
        pnlControllerInfo.SuspendLayout();
        pnlEnvironmentVariable.SuspendLayout();
        pnlInstalledSystems.SuspendLayout();
        pnlOption.SuspendLayout();
        pnlCompatibility.SuspendLayout();
        pnlLanguage.SuspendLayout();
        pnlRestart.SuspendLayout();
        tabIdentity.SuspendLayout();
        flowIdentity.SuspendLayout();
        pnlIdentity.SuspendLayout();
        pnlNetwork.SuspendLayout();
        tabClock.SuspendLayout();
        flowClock.SuspendLayout();
        pnlClock.SuspendLayout();
        pnlTimeZone.SuspendLayout();
        pnlTimeServer.SuspendLayout();
        tabBackup.SuspendLayout();
        flowBackup.SuspendLayout();
        pnlBackupResources.SuspendLayout();
        pnlBackupInfo.SuspendLayout();
        pnlBackupState.SuspendLayout();
        pnlCreateBackup.SuspendLayout();
        pnlRestoreBackup.SuspendLayout();
        pnlCheckRestore.SuspendLayout();
        tabSafety.SuspendLayout();
        flowSafety.SuspendLayout();
        pnlSafetyResources.SuspendLayout();
        pnlSafetyMode.SuspendLayout();
        pnlSafetyConfiguration.SuspendLayout();
        pnlInvalidateSafetyConfiguration.SuspendLayout();
        pnlSafetyLoadOperationStatus.SuspendLayout();
        pnlCyclicBrakeCheckStatus.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numGetCyclicBrakeCheckStatusDriveNumber).BeginInit();
        pnlSafetyViolationInfo.SuspendLayout();
        tabVirtualTime.SuspendLayout();
        flowVirtualTime.SuspendLayout();
        pnlVirtualTimeResources.SuspendLayout();
        pnlVirtualTime.SuspendLayout();
        pnlVirtualTimeSpeed.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numSetVirtualTimeSpeedSpeed).BeginInit();
        pnlVirtualTimeState.SuspendLayout();
        pnlVirtualTimeSlice.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numSetVirtualTimeSliceMilliseconds).BeginInit();
        pnlRunVirtualTime.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabGeneral);
        tabControl.Controls.Add(tabIdentity);
        tabControl.Controls.Add(tabClock);
        tabControl.Controls.Add(tabBackup);
        tabControl.Controls.Add(tabSafety);
        tabControl.Controls.Add(tabVirtualTime);
        tabControl.Dock = DockStyle.Fill;
        tabControl.Location = new Point(0, 0);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(890, 491);
        tabControl.TabIndex = 0;
        // 
        // tabGeneral
        // 
        tabGeneral.Controls.Add(flowGeneral);
        tabGeneral.Location = new Point(4, 24);
        tabGeneral.Name = "tabGeneral";
        tabGeneral.Padding = new Padding(3);
        tabGeneral.Size = new Size(882, 463);
        tabGeneral.TabIndex = 0;
        tabGeneral.Text = "General";
        tabGeneral.UseVisualStyleBackColor = true;
        // 
        // flowGeneral
        // 
        flowGeneral.AutoScroll = true;
        flowGeneral.Controls.Add(pnlControllerInfo);
        flowGeneral.Controls.Add(pnlEnvironmentVariable);
        flowGeneral.Controls.Add(pnlInstalledSystems);
        flowGeneral.Controls.Add(pnlOption);
        flowGeneral.Controls.Add(pnlCompatibility);
        flowGeneral.Controls.Add(pnlLanguage);
        flowGeneral.Controls.Add(pnlRestart);
        flowGeneral.Dock = DockStyle.Fill;
        flowGeneral.FlowDirection = FlowDirection.TopDown;
        flowGeneral.Location = new Point(3, 3);
        flowGeneral.Name = "flowGeneral";
        flowGeneral.Size = new Size(876, 457);
        flowGeneral.TabIndex = 0;
        // 
        // pnlControllerInfo
        // 
        pnlControllerInfo.BorderStyle = BorderStyle.FixedSingle;
        pnlControllerInfo.Controls.Add(gridControllerInfo);
        pnlControllerInfo.Controls.Add(sep1);
        pnlControllerInfo.Controls.Add(btnGetControllerInfo);
        pnlControllerInfo.Location = new Point(3, 3);
        pnlControllerInfo.Name = "pnlControllerInfo";
        pnlControllerInfo.Padding = new Padding(5);
        pnlControllerInfo.Size = new Size(250, 255);
        pnlControllerInfo.TabIndex = 0;
        // 
        // gridControllerInfo
        // 
        gridControllerInfo.Dock = DockStyle.Top;
        gridControllerInfo.HelpVisible = false;
        gridControllerInfo.Location = new Point(5, 33);
        gridControllerInfo.Name = "gridControllerInfo";
        gridControllerInfo.PropertySort = PropertySort.NoSort;
        gridControllerInfo.Size = new Size(238, 215);
        gridControllerInfo.TabIndex = 2;
        gridControllerInfo.ToolbarVisible = false;
        // 
        // sep1
        // 
        sep1.Dock = DockStyle.Top;
        sep1.Location = new Point(5, 28);
        sep1.Name = "sep1";
        sep1.Size = new Size(238, 5);
        sep1.TabIndex = 1;
        // 
        // btnGetControllerInfo
        // 
        btnGetControllerInfo.Dock = DockStyle.Top;
        btnGetControllerInfo.Location = new Point(5, 5);
        btnGetControllerInfo.Name = "btnGetControllerInfo";
        btnGetControllerInfo.Size = new Size(238, 23);
        btnGetControllerInfo.TabIndex = 0;
        btnGetControllerInfo.Text = "Get Controller Info";
        btnGetControllerInfo.UseVisualStyleBackColor = true;
        btnGetControllerInfo.Click += btnGetControllerInfo_Click;
        // 
        // pnlEnvironmentVariable
        // 
        pnlEnvironmentVariable.BorderStyle = BorderStyle.FixedSingle;
        pnlEnvironmentVariable.Controls.Add(txtEnvironmentVariableValue);
        pnlEnvironmentVariable.Controls.Add(sep3);
        pnlEnvironmentVariable.Controls.Add(btnGetEnvironmentVariable);
        pnlEnvironmentVariable.Controls.Add(sep2);
        pnlEnvironmentVariable.Controls.Add(txtEnvironmentVariableName);
        pnlEnvironmentVariable.Location = new Point(3, 264);
        pnlEnvironmentVariable.Name = "pnlEnvironmentVariable";
        pnlEnvironmentVariable.Padding = new Padding(5);
        pnlEnvironmentVariable.Size = new Size(250, 91);
        pnlEnvironmentVariable.TabIndex = 1;
        // 
        // txtEnvironmentVariableValue
        // 
        txtEnvironmentVariableValue.Dock = DockStyle.Top;
        txtEnvironmentVariableValue.Location = new Point(5, 61);
        txtEnvironmentVariableValue.Name = "txtEnvironmentVariableValue";
        txtEnvironmentVariableValue.PlaceholderText = "value";
        txtEnvironmentVariableValue.ReadOnly = true;
        txtEnvironmentVariableValue.Size = new Size(238, 23);
        txtEnvironmentVariableValue.TabIndex = 4;
        // 
        // sep3
        // 
        sep3.Dock = DockStyle.Top;
        sep3.Location = new Point(5, 56);
        sep3.Name = "sep3";
        sep3.Size = new Size(238, 5);
        sep3.TabIndex = 3;
        // 
        // btnGetEnvironmentVariable
        // 
        btnGetEnvironmentVariable.Dock = DockStyle.Top;
        btnGetEnvironmentVariable.Location = new Point(5, 33);
        btnGetEnvironmentVariable.Name = "btnGetEnvironmentVariable";
        btnGetEnvironmentVariable.Size = new Size(238, 23);
        btnGetEnvironmentVariable.TabIndex = 2;
        btnGetEnvironmentVariable.Text = "Get Environment variable";
        btnGetEnvironmentVariable.UseVisualStyleBackColor = true;
        btnGetEnvironmentVariable.Click += btnGetEnvironmentVariable_Click;
        // 
        // sep2
        // 
        sep2.Dock = DockStyle.Top;
        sep2.Location = new Point(5, 28);
        sep2.Name = "sep2";
        sep2.Size = new Size(238, 5);
        sep2.TabIndex = 1;
        // 
        // txtEnvironmentVariableName
        // 
        txtEnvironmentVariableName.Dock = DockStyle.Top;
        txtEnvironmentVariableName.Location = new Point(5, 5);
        txtEnvironmentVariableName.Name = "txtEnvironmentVariableName";
        txtEnvironmentVariableName.PlaceholderText = "name";
        txtEnvironmentVariableName.Size = new Size(238, 23);
        txtEnvironmentVariableName.TabIndex = 0;
        txtEnvironmentVariableName.Text = "$temp";
        // 
        // pnlInstalledSystems
        // 
        pnlInstalledSystems.BorderStyle = BorderStyle.FixedSingle;
        pnlInstalledSystems.Controls.Add(gridInstalledSystems);
        pnlInstalledSystems.Controls.Add(sep4);
        pnlInstalledSystems.Controls.Add(btnGetInstalledSystems);
        pnlInstalledSystems.Location = new Point(259, 3);
        pnlInstalledSystems.Name = "pnlInstalledSystems";
        pnlInstalledSystems.Padding = new Padding(5);
        pnlInstalledSystems.Size = new Size(250, 141);
        pnlInstalledSystems.TabIndex = 2;
        // 
        // gridInstalledSystems
        // 
        gridInstalledSystems.Dock = DockStyle.Top;
        gridInstalledSystems.HelpVisible = false;
        gridInstalledSystems.Location = new Point(5, 33);
        gridInstalledSystems.Name = "gridInstalledSystems";
        gridInstalledSystems.PropertySort = PropertySort.NoSort;
        gridInstalledSystems.Size = new Size(238, 101);
        gridInstalledSystems.TabIndex = 2;
        gridInstalledSystems.ToolbarVisible = false;
        // 
        // sep4
        // 
        sep4.Dock = DockStyle.Top;
        sep4.Location = new Point(5, 28);
        sep4.Name = "sep4";
        sep4.Size = new Size(238, 5);
        sep4.TabIndex = 1;
        // 
        // btnGetInstalledSystems
        // 
        btnGetInstalledSystems.Dock = DockStyle.Top;
        btnGetInstalledSystems.Location = new Point(5, 5);
        btnGetInstalledSystems.Name = "btnGetInstalledSystems";
        btnGetInstalledSystems.Size = new Size(238, 23);
        btnGetInstalledSystems.TabIndex = 0;
        btnGetInstalledSystems.Text = "Get Installed systems";
        btnGetInstalledSystems.UseVisualStyleBackColor = true;
        btnGetInstalledSystems.Click += btnGetInstalledSystems_Click;
        // 
        // pnlOption
        // 
        pnlOption.BorderStyle = BorderStyle.FixedSingle;
        pnlOption.Controls.Add(chkHasOptionResult);
        pnlOption.Controls.Add(sep6);
        pnlOption.Controls.Add(btnHasOption);
        pnlOption.Controls.Add(sep5);
        pnlOption.Controls.Add(txtHasOptionOption);
        pnlOption.Location = new Point(259, 150);
        pnlOption.Name = "pnlOption";
        pnlOption.Padding = new Padding(5);
        pnlOption.Size = new Size(250, 91);
        pnlOption.TabIndex = 3;
        // 
        // chkHasOptionResult
        // 
        chkHasOptionResult.AutoCheck = false;
        chkHasOptionResult.Dock = DockStyle.Top;
        chkHasOptionResult.Location = new Point(5, 61);
        chkHasOptionResult.Name = "chkHasOptionResult";
        chkHasOptionResult.Size = new Size(238, 23);
        chkHasOptionResult.TabIndex = 4;
        chkHasOptionResult.Text = "Option installed";
        chkHasOptionResult.UseVisualStyleBackColor = true;
        // 
        // sep6
        // 
        sep6.Dock = DockStyle.Top;
        sep6.Location = new Point(5, 56);
        sep6.Name = "sep6";
        sep6.Size = new Size(238, 5);
        sep6.TabIndex = 3;
        // 
        // btnHasOption
        // 
        btnHasOption.Dock = DockStyle.Top;
        btnHasOption.Location = new Point(5, 33);
        btnHasOption.Name = "btnHasOption";
        btnHasOption.Size = new Size(238, 23);
        btnHasOption.TabIndex = 2;
        btnHasOption.Text = "Has Option";
        btnHasOption.UseVisualStyleBackColor = true;
        btnHasOption.Click += btnHasOption_Click;
        // 
        // sep5
        // 
        sep5.Dock = DockStyle.Top;
        sep5.Location = new Point(5, 28);
        sep5.Name = "sep5";
        sep5.Size = new Size(238, 5);
        sep5.TabIndex = 1;
        // 
        // txtHasOptionOption
        // 
        txtHasOptionOption.Dock = DockStyle.Top;
        txtHasOptionOption.Location = new Point(5, 5);
        txtHasOptionOption.Name = "txtHasOptionOption";
        txtHasOptionOption.PlaceholderText = "option";
        txtHasOptionOption.Size = new Size(238, 23);
        txtHasOptionOption.TabIndex = 0;
        txtHasOptionOption.Text = "SAFEMOVEPRO";
        // 
        // pnlCompatibility
        // 
        pnlCompatibility.BorderStyle = BorderStyle.FixedSingle;
        pnlCompatibility.Controls.Add(chkIsRobotWareVersionCompatibleResult);
        pnlCompatibility.Controls.Add(sep8);
        pnlCompatibility.Controls.Add(btnIsRobotWareVersionCompatible);
        pnlCompatibility.Controls.Add(sep7);
        pnlCompatibility.Controls.Add(txtIsRobotWareVersionCompatibleRobotWareVersion);
        pnlCompatibility.Location = new Point(259, 247);
        pnlCompatibility.Name = "pnlCompatibility";
        pnlCompatibility.Padding = new Padding(5);
        pnlCompatibility.Size = new Size(250, 91);
        pnlCompatibility.TabIndex = 4;
        // 
        // chkIsRobotWareVersionCompatibleResult
        // 
        chkIsRobotWareVersionCompatibleResult.AutoCheck = false;
        chkIsRobotWareVersionCompatibleResult.Dock = DockStyle.Top;
        chkIsRobotWareVersionCompatibleResult.Location = new Point(5, 61);
        chkIsRobotWareVersionCompatibleResult.Name = "chkIsRobotWareVersionCompatibleResult";
        chkIsRobotWareVersionCompatibleResult.Size = new Size(238, 23);
        chkIsRobotWareVersionCompatibleResult.TabIndex = 4;
        chkIsRobotWareVersionCompatibleResult.Text = "Compatible";
        chkIsRobotWareVersionCompatibleResult.UseVisualStyleBackColor = true;
        // 
        // sep8
        // 
        sep8.Dock = DockStyle.Top;
        sep8.Location = new Point(5, 56);
        sep8.Name = "sep8";
        sep8.Size = new Size(238, 5);
        sep8.TabIndex = 3;
        // 
        // btnIsRobotWareVersionCompatible
        // 
        btnIsRobotWareVersionCompatible.Dock = DockStyle.Top;
        btnIsRobotWareVersionCompatible.Location = new Point(5, 33);
        btnIsRobotWareVersionCompatible.Name = "btnIsRobotWareVersionCompatible";
        btnIsRobotWareVersionCompatible.Size = new Size(238, 23);
        btnIsRobotWareVersionCompatible.TabIndex = 2;
        btnIsRobotWareVersionCompatible.Text = "Is RobotWare version compatible";
        btnIsRobotWareVersionCompatible.UseVisualStyleBackColor = true;
        btnIsRobotWareVersionCompatible.Click += btnIsRobotWareVersionCompatible_Click;
        // 
        // sep7
        // 
        sep7.Dock = DockStyle.Top;
        sep7.Location = new Point(5, 28);
        sep7.Name = "sep7";
        sep7.Size = new Size(238, 5);
        sep7.TabIndex = 1;
        // 
        // txtIsRobotWareVersionCompatibleRobotWareVersion
        // 
        txtIsRobotWareVersionCompatibleRobotWareVersion.Dock = DockStyle.Top;
        txtIsRobotWareVersionCompatibleRobotWareVersion.Location = new Point(5, 5);
        txtIsRobotWareVersionCompatibleRobotWareVersion.Name = "txtIsRobotWareVersionCompatibleRobotWareVersion";
        txtIsRobotWareVersionCompatibleRobotWareVersion.PlaceholderText = "robotWareVersion";
        txtIsRobotWareVersionCompatibleRobotWareVersion.Size = new Size(238, 23);
        txtIsRobotWareVersionCompatibleRobotWareVersion.TabIndex = 0;
        txtIsRobotWareVersionCompatibleRobotWareVersion.Text = "6.03.0101";
        // 
        // pnlLanguage
        // 
        pnlLanguage.BorderStyle = BorderStyle.FixedSingle;
        pnlLanguage.Controls.Add(btnSetLanguage);
        pnlLanguage.Controls.Add(sep9);
        pnlLanguage.Controls.Add(txtSetLanguageLanguage);
        pnlLanguage.Location = new Point(259, 344);
        pnlLanguage.Name = "pnlLanguage";
        pnlLanguage.Padding = new Padding(5);
        pnlLanguage.Size = new Size(250, 63);
        pnlLanguage.TabIndex = 5;
        // 
        // btnSetLanguage
        // 
        btnSetLanguage.Dock = DockStyle.Top;
        btnSetLanguage.Location = new Point(5, 33);
        btnSetLanguage.Name = "btnSetLanguage";
        btnSetLanguage.Size = new Size(238, 23);
        btnSetLanguage.TabIndex = 2;
        btnSetLanguage.Text = "Set Language";
        btnSetLanguage.UseVisualStyleBackColor = true;
        btnSetLanguage.Click += btnSetLanguage_Click;
        // 
        // sep9
        // 
        sep9.Dock = DockStyle.Top;
        sep9.Location = new Point(5, 28);
        sep9.Name = "sep9";
        sep9.Size = new Size(238, 5);
        sep9.TabIndex = 1;
        // 
        // txtSetLanguageLanguage
        // 
        txtSetLanguageLanguage.Dock = DockStyle.Top;
        txtSetLanguageLanguage.Location = new Point(5, 5);
        txtSetLanguageLanguage.Name = "txtSetLanguageLanguage";
        txtSetLanguageLanguage.PlaceholderText = "language";
        txtSetLanguageLanguage.Size = new Size(238, 23);
        txtSetLanguageLanguage.TabIndex = 0;
        txtSetLanguageLanguage.Text = "en";
        // 
        // pnlRestart
        // 
        pnlRestart.BorderStyle = BorderStyle.FixedSingle;
        pnlRestart.Controls.Add(btnRestart);
        pnlRestart.Controls.Add(sep11);
        pnlRestart.Controls.Add(chkRestartUseImplicitMastership);
        pnlRestart.Controls.Add(sep10);
        pnlRestart.Controls.Add(cboRestartMode);
        pnlRestart.Location = new Point(515, 3);
        pnlRestart.Name = "pnlRestart";
        pnlRestart.Padding = new Padding(5);
        pnlRestart.Size = new Size(250, 91);
        pnlRestart.TabIndex = 6;
        // 
        // btnRestart
        // 
        btnRestart.Dock = DockStyle.Top;
        btnRestart.Location = new Point(5, 61);
        btnRestart.Name = "btnRestart";
        btnRestart.Size = new Size(238, 23);
        btnRestart.TabIndex = 4;
        btnRestart.Text = "Restart";
        btnRestart.UseVisualStyleBackColor = true;
        btnRestart.Click += btnRestart_Click;
        // 
        // sep11
        // 
        sep11.Dock = DockStyle.Top;
        sep11.Location = new Point(5, 56);
        sep11.Name = "sep11";
        sep11.Size = new Size(238, 5);
        sep11.TabIndex = 3;
        // 
        // chkRestartUseImplicitMastership
        // 
        chkRestartUseImplicitMastership.Checked = true;
        chkRestartUseImplicitMastership.CheckState = CheckState.Checked;
        chkRestartUseImplicitMastership.Dock = DockStyle.Top;
        chkRestartUseImplicitMastership.Location = new Point(5, 33);
        chkRestartUseImplicitMastership.Name = "chkRestartUseImplicitMastership";
        chkRestartUseImplicitMastership.Size = new Size(238, 23);
        chkRestartUseImplicitMastership.TabIndex = 2;
        chkRestartUseImplicitMastership.Text = "Use implicit mastership";
        chkRestartUseImplicitMastership.UseVisualStyleBackColor = true;
        // 
        // sep10
        // 
        sep10.Dock = DockStyle.Top;
        sep10.Location = new Point(5, 28);
        sep10.Name = "sep10";
        sep10.Size = new Size(238, 5);
        sep10.TabIndex = 1;
        // 
        // cboRestartMode
        // 
        cboRestartMode.Dock = DockStyle.Top;
        cboRestartMode.DropDownStyle = ComboBoxStyle.DropDownList;
        cboRestartMode.FormattingEnabled = true;
        cboRestartMode.Location = new Point(5, 5);
        cboRestartMode.Name = "cboRestartMode";
        cboRestartMode.Size = new Size(238, 23);
        cboRestartMode.TabIndex = 0;
        // 
        // tabIdentity
        // 
        tabIdentity.Controls.Add(flowIdentity);
        tabIdentity.Location = new Point(4, 24);
        tabIdentity.Name = "tabIdentity";
        tabIdentity.Padding = new Padding(3);
        tabIdentity.Size = new Size(882, 463);
        tabIdentity.TabIndex = 1;
        tabIdentity.Text = "Identity && network";
        tabIdentity.UseVisualStyleBackColor = true;
        // 
        // flowIdentity
        // 
        flowIdentity.AutoScroll = true;
        flowIdentity.Controls.Add(pnlIdentity);
        flowIdentity.Controls.Add(pnlNetwork);
        flowIdentity.Dock = DockStyle.Fill;
        flowIdentity.FlowDirection = FlowDirection.TopDown;
        flowIdentity.Location = new Point(3, 3);
        flowIdentity.Name = "flowIdentity";
        flowIdentity.Size = new Size(876, 457);
        flowIdentity.TabIndex = 0;
        // 
        // pnlIdentity
        // 
        pnlIdentity.BorderStyle = BorderStyle.FixedSingle;
        pnlIdentity.Controls.Add(btnSetIdentity);
        pnlIdentity.Controls.Add(sep15);
        pnlIdentity.Controls.Add(txtSetIdentityId);
        pnlIdentity.Controls.Add(sep14);
        pnlIdentity.Controls.Add(txtSetIdentityName);
        pnlIdentity.Controls.Add(sep13);
        pnlIdentity.Controls.Add(gridIdentity);
        pnlIdentity.Controls.Add(sep12);
        pnlIdentity.Controls.Add(btnGetIdentity);
        pnlIdentity.Location = new Point(3, 3);
        pnlIdentity.Name = "pnlIdentity";
        pnlIdentity.Padding = new Padding(5);
        pnlIdentity.Size = new Size(250, 225);
        pnlIdentity.TabIndex = 0;
        // 
        // btnSetIdentity
        // 
        btnSetIdentity.Dock = DockStyle.Top;
        btnSetIdentity.Location = new Point(5, 195);
        btnSetIdentity.Name = "btnSetIdentity";
        btnSetIdentity.Size = new Size(238, 23);
        btnSetIdentity.TabIndex = 8;
        btnSetIdentity.Text = "Set Identity";
        btnSetIdentity.UseVisualStyleBackColor = true;
        btnSetIdentity.Click += btnSetIdentity_Click;
        // 
        // sep15
        // 
        sep15.Dock = DockStyle.Top;
        sep15.Location = new Point(5, 190);
        sep15.Name = "sep15";
        sep15.Size = new Size(238, 5);
        sep15.TabIndex = 7;
        // 
        // txtSetIdentityId
        // 
        txtSetIdentityId.Dock = DockStyle.Top;
        txtSetIdentityId.Location = new Point(5, 167);
        txtSetIdentityId.Name = "txtSetIdentityId";
        txtSetIdentityId.PlaceholderText = "id (optional)";
        txtSetIdentityId.Size = new Size(238, 23);
        txtSetIdentityId.TabIndex = 6;
        // 
        // sep14
        // 
        sep14.Dock = DockStyle.Top;
        sep14.Location = new Point(5, 162);
        sep14.Name = "sep14";
        sep14.Size = new Size(238, 5);
        sep14.TabIndex = 5;
        // 
        // txtSetIdentityName
        // 
        txtSetIdentityName.Dock = DockStyle.Top;
        txtSetIdentityName.Location = new Point(5, 139);
        txtSetIdentityName.Name = "txtSetIdentityName";
        txtSetIdentityName.PlaceholderText = "name";
        txtSetIdentityName.Size = new Size(238, 23);
        txtSetIdentityName.TabIndex = 4;
        // 
        // sep13
        // 
        sep13.Dock = DockStyle.Top;
        sep13.Location = new Point(5, 134);
        sep13.Name = "sep13";
        sep13.Size = new Size(238, 5);
        sep13.TabIndex = 3;
        // 
        // gridIdentity
        // 
        gridIdentity.Dock = DockStyle.Top;
        gridIdentity.HelpVisible = false;
        gridIdentity.Location = new Point(5, 33);
        gridIdentity.Name = "gridIdentity";
        gridIdentity.PropertySort = PropertySort.NoSort;
        gridIdentity.Size = new Size(238, 101);
        gridIdentity.TabIndex = 2;
        gridIdentity.ToolbarVisible = false;
        // 
        // sep12
        // 
        sep12.Dock = DockStyle.Top;
        sep12.Location = new Point(5, 28);
        sep12.Name = "sep12";
        sep12.Size = new Size(238, 5);
        sep12.TabIndex = 1;
        // 
        // btnGetIdentity
        // 
        btnGetIdentity.Dock = DockStyle.Top;
        btnGetIdentity.Location = new Point(5, 5);
        btnGetIdentity.Name = "btnGetIdentity";
        btnGetIdentity.Size = new Size(238, 23);
        btnGetIdentity.TabIndex = 0;
        btnGetIdentity.Text = "Get Identity";
        btnGetIdentity.UseVisualStyleBackColor = true;
        btnGetIdentity.Click += btnGetIdentity_Click;
        // 
        // pnlNetwork
        // 
        pnlNetwork.BorderStyle = BorderStyle.FixedSingle;
        pnlNetwork.Controls.Add(btnSetNetworkConfiguration);
        pnlNetwork.Controls.Add(sep21);
        pnlNetwork.Controls.Add(txtSetNetworkConfigurationGateway);
        pnlNetwork.Controls.Add(sep20);
        pnlNetwork.Controls.Add(txtSetNetworkConfigurationMask);
        pnlNetwork.Controls.Add(sep19);
        pnlNetwork.Controls.Add(txtSetNetworkConfigurationAddress);
        pnlNetwork.Controls.Add(sep18);
        pnlNetwork.Controls.Add(cboSetNetworkConfigurationMethod);
        pnlNetwork.Controls.Add(sep17);
        pnlNetwork.Controls.Add(gridNetworkInterfaces);
        pnlNetwork.Controls.Add(sep16);
        pnlNetwork.Controls.Add(btnGetNetworkInterfaces);
        pnlNetwork.Location = new Point(259, 3);
        pnlNetwork.Name = "pnlNetwork";
        pnlNetwork.Padding = new Padding(5);
        pnlNetwork.Size = new Size(250, 566);
        pnlNetwork.TabIndex = 1;
        // 
        // btnSetNetworkConfiguration
        // 
        btnSetNetworkConfiguration.Dock = DockStyle.Top;
        btnSetNetworkConfiguration.Location = new Point(5, 536);
        btnSetNetworkConfiguration.Name = "btnSetNetworkConfiguration";
        btnSetNetworkConfiguration.Size = new Size(238, 23);
        btnSetNetworkConfiguration.TabIndex = 12;
        btnSetNetworkConfiguration.Text = "Set Network configuration";
        btnSetNetworkConfiguration.UseVisualStyleBackColor = true;
        btnSetNetworkConfiguration.Click += btnSetNetworkConfiguration_Click;
        // 
        // sep21
        // 
        sep21.Dock = DockStyle.Top;
        sep21.Location = new Point(5, 531);
        sep21.Name = "sep21";
        sep21.Size = new Size(238, 5);
        sep21.TabIndex = 11;
        // 
        // txtSetNetworkConfigurationGateway
        // 
        txtSetNetworkConfigurationGateway.Dock = DockStyle.Top;
        txtSetNetworkConfigurationGateway.Location = new Point(5, 508);
        txtSetNetworkConfigurationGateway.Name = "txtSetNetworkConfigurationGateway";
        txtSetNetworkConfigurationGateway.PlaceholderText = "gateway";
        txtSetNetworkConfigurationGateway.Size = new Size(238, 23);
        txtSetNetworkConfigurationGateway.TabIndex = 10;
        // 
        // sep20
        // 
        sep20.Dock = DockStyle.Top;
        sep20.Location = new Point(5, 503);
        sep20.Name = "sep20";
        sep20.Size = new Size(238, 5);
        sep20.TabIndex = 9;
        // 
        // txtSetNetworkConfigurationMask
        // 
        txtSetNetworkConfigurationMask.Dock = DockStyle.Top;
        txtSetNetworkConfigurationMask.Location = new Point(5, 480);
        txtSetNetworkConfigurationMask.Name = "txtSetNetworkConfigurationMask";
        txtSetNetworkConfigurationMask.PlaceholderText = "mask";
        txtSetNetworkConfigurationMask.Size = new Size(238, 23);
        txtSetNetworkConfigurationMask.TabIndex = 8;
        // 
        // sep19
        // 
        sep19.Dock = DockStyle.Top;
        sep19.Location = new Point(5, 475);
        sep19.Name = "sep19";
        sep19.Size = new Size(238, 5);
        sep19.TabIndex = 7;
        // 
        // txtSetNetworkConfigurationAddress
        // 
        txtSetNetworkConfigurationAddress.Dock = DockStyle.Top;
        txtSetNetworkConfigurationAddress.Location = new Point(5, 452);
        txtSetNetworkConfigurationAddress.Name = "txtSetNetworkConfigurationAddress";
        txtSetNetworkConfigurationAddress.PlaceholderText = "address";
        txtSetNetworkConfigurationAddress.Size = new Size(238, 23);
        txtSetNetworkConfigurationAddress.TabIndex = 6;
        // 
        // sep18
        // 
        sep18.Dock = DockStyle.Top;
        sep18.Location = new Point(5, 447);
        sep18.Name = "sep18";
        sep18.Size = new Size(238, 5);
        sep18.TabIndex = 5;
        // 
        // cboSetNetworkConfigurationMethod
        // 
        cboSetNetworkConfigurationMethod.Dock = DockStyle.Top;
        cboSetNetworkConfigurationMethod.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSetNetworkConfigurationMethod.FormattingEnabled = true;
        cboSetNetworkConfigurationMethod.Location = new Point(5, 424);
        cboSetNetworkConfigurationMethod.Name = "cboSetNetworkConfigurationMethod";
        cboSetNetworkConfigurationMethod.Size = new Size(238, 23);
        cboSetNetworkConfigurationMethod.TabIndex = 4;
        // 
        // sep17
        // 
        sep17.Dock = DockStyle.Top;
        sep17.Location = new Point(5, 419);
        sep17.Name = "sep17";
        sep17.Size = new Size(238, 5);
        sep17.TabIndex = 3;
        // 
        // gridNetworkInterfaces
        // 
        gridNetworkInterfaces.Dock = DockStyle.Top;
        gridNetworkInterfaces.HelpVisible = false;
        gridNetworkInterfaces.Location = new Point(5, 33);
        gridNetworkInterfaces.Name = "gridNetworkInterfaces";
        gridNetworkInterfaces.PropertySort = PropertySort.NoSort;
        gridNetworkInterfaces.Size = new Size(238, 386);
        gridNetworkInterfaces.TabIndex = 2;
        gridNetworkInterfaces.ToolbarVisible = false;
        // 
        // sep16
        // 
        sep16.Dock = DockStyle.Top;
        sep16.Location = new Point(5, 28);
        sep16.Name = "sep16";
        sep16.Size = new Size(238, 5);
        sep16.TabIndex = 1;
        // 
        // btnGetNetworkInterfaces
        // 
        btnGetNetworkInterfaces.Dock = DockStyle.Top;
        btnGetNetworkInterfaces.Location = new Point(5, 5);
        btnGetNetworkInterfaces.Name = "btnGetNetworkInterfaces";
        btnGetNetworkInterfaces.Size = new Size(238, 23);
        btnGetNetworkInterfaces.TabIndex = 0;
        btnGetNetworkInterfaces.Text = "Get Network interfaces";
        btnGetNetworkInterfaces.UseVisualStyleBackColor = true;
        btnGetNetworkInterfaces.Click += btnGetNetworkInterfaces_Click;
        // 
        // tabClock
        // 
        tabClock.Controls.Add(flowClock);
        tabClock.Location = new Point(4, 24);
        tabClock.Name = "tabClock";
        tabClock.Padding = new Padding(3);
        tabClock.Size = new Size(882, 463);
        tabClock.TabIndex = 2;
        tabClock.Text = "Clock";
        tabClock.UseVisualStyleBackColor = true;
        // 
        // flowClock
        // 
        flowClock.AutoScroll = true;
        flowClock.Controls.Add(pnlClock);
        flowClock.Controls.Add(pnlTimeZone);
        flowClock.Controls.Add(pnlTimeServer);
        flowClock.Dock = DockStyle.Fill;
        flowClock.FlowDirection = FlowDirection.TopDown;
        flowClock.Location = new Point(3, 3);
        flowClock.Name = "flowClock";
        flowClock.Size = new Size(876, 457);
        flowClock.TabIndex = 0;
        // 
        // pnlClock
        // 
        pnlClock.BorderStyle = BorderStyle.FixedSingle;
        pnlClock.Controls.Add(btnSetClock);
        pnlClock.Controls.Add(sep23);
        pnlClock.Controls.Add(dtpClock);
        pnlClock.Controls.Add(sep22);
        pnlClock.Controls.Add(btnGetClock);
        pnlClock.Location = new Point(3, 3);
        pnlClock.Name = "pnlClock";
        pnlClock.Padding = new Padding(5);
        pnlClock.Size = new Size(250, 91);
        pnlClock.TabIndex = 0;
        // 
        // btnSetClock
        // 
        btnSetClock.Dock = DockStyle.Top;
        btnSetClock.Location = new Point(5, 61);
        btnSetClock.Name = "btnSetClock";
        btnSetClock.Size = new Size(238, 23);
        btnSetClock.TabIndex = 4;
        btnSetClock.Text = "Set Clock";
        btnSetClock.UseVisualStyleBackColor = true;
        btnSetClock.Click += btnSetClock_Click;
        // 
        // sep23
        // 
        sep23.Dock = DockStyle.Top;
        sep23.Location = new Point(5, 56);
        sep23.Name = "sep23";
        sep23.Size = new Size(238, 5);
        sep23.TabIndex = 3;
        // 
        // dtpClock
        // 
        dtpClock.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        dtpClock.Dock = DockStyle.Top;
        dtpClock.Format = DateTimePickerFormat.Custom;
        dtpClock.Location = new Point(5, 33);
        dtpClock.Name = "dtpClock";
        dtpClock.Size = new Size(238, 23);
        dtpClock.TabIndex = 2;
        // 
        // sep22
        // 
        sep22.Dock = DockStyle.Top;
        sep22.Location = new Point(5, 28);
        sep22.Name = "sep22";
        sep22.Size = new Size(238, 5);
        sep22.TabIndex = 1;
        // 
        // btnGetClock
        // 
        btnGetClock.Dock = DockStyle.Top;
        btnGetClock.Location = new Point(5, 5);
        btnGetClock.Name = "btnGetClock";
        btnGetClock.Size = new Size(238, 23);
        btnGetClock.TabIndex = 0;
        btnGetClock.Text = "Get Clock";
        btnGetClock.UseVisualStyleBackColor = true;
        btnGetClock.Click += btnGetClock_Click;
        // 
        // pnlTimeZone
        // 
        pnlTimeZone.BorderStyle = BorderStyle.FixedSingle;
        pnlTimeZone.Controls.Add(btnSetTimeZone);
        pnlTimeZone.Controls.Add(sep25);
        pnlTimeZone.Controls.Add(txtTimeZone);
        pnlTimeZone.Controls.Add(sep24);
        pnlTimeZone.Controls.Add(btnGetTimeZone);
        pnlTimeZone.Location = new Point(3, 100);
        pnlTimeZone.Name = "pnlTimeZone";
        pnlTimeZone.Padding = new Padding(5);
        pnlTimeZone.Size = new Size(250, 91);
        pnlTimeZone.TabIndex = 1;
        // 
        // btnSetTimeZone
        // 
        btnSetTimeZone.Dock = DockStyle.Top;
        btnSetTimeZone.Location = new Point(5, 61);
        btnSetTimeZone.Name = "btnSetTimeZone";
        btnSetTimeZone.Size = new Size(238, 23);
        btnSetTimeZone.TabIndex = 4;
        btnSetTimeZone.Text = "Set Time zone";
        btnSetTimeZone.UseVisualStyleBackColor = true;
        btnSetTimeZone.Click += btnSetTimeZone_Click;
        // 
        // sep25
        // 
        sep25.Dock = DockStyle.Top;
        sep25.Location = new Point(5, 56);
        sep25.Name = "sep25";
        sep25.Size = new Size(238, 5);
        sep25.TabIndex = 3;
        // 
        // txtTimeZone
        // 
        txtTimeZone.Dock = DockStyle.Top;
        txtTimeZone.Location = new Point(5, 33);
        txtTimeZone.Name = "txtTimeZone";
        txtTimeZone.PlaceholderText = "timeZone";
        txtTimeZone.Size = new Size(238, 23);
        txtTimeZone.TabIndex = 2;
        txtTimeZone.Text = "Europe/Stockholm";
        // 
        // sep24
        // 
        sep24.Dock = DockStyle.Top;
        sep24.Location = new Point(5, 28);
        sep24.Name = "sep24";
        sep24.Size = new Size(238, 5);
        sep24.TabIndex = 1;
        // 
        // btnGetTimeZone
        // 
        btnGetTimeZone.Dock = DockStyle.Top;
        btnGetTimeZone.Location = new Point(5, 5);
        btnGetTimeZone.Name = "btnGetTimeZone";
        btnGetTimeZone.Size = new Size(238, 23);
        btnGetTimeZone.TabIndex = 0;
        btnGetTimeZone.Text = "Get Time zone";
        btnGetTimeZone.UseVisualStyleBackColor = true;
        btnGetTimeZone.Click += btnGetTimeZone_Click;
        // 
        // pnlTimeServer
        // 
        pnlTimeServer.BorderStyle = BorderStyle.FixedSingle;
        pnlTimeServer.Controls.Add(btnSetTimeServer);
        pnlTimeServer.Controls.Add(sep29);
        pnlTimeServer.Controls.Add(txtSetTimeServerTimeServer);
        pnlTimeServer.Controls.Add(sep28);
        pnlTimeServer.Controls.Add(gridTimeServer);
        pnlTimeServer.Controls.Add(sep27);
        pnlTimeServer.Controls.Add(btnGetTimeServer);
        pnlTimeServer.Controls.Add(sep26);
        pnlTimeServer.Controls.Add(txtGetTimeServerServerIp);
        pnlTimeServer.Location = new Point(3, 197);
        pnlTimeServer.Name = "pnlTimeServer";
        pnlTimeServer.Padding = new Padding(5);
        pnlTimeServer.Size = new Size(250, 184);
        pnlTimeServer.TabIndex = 2;
        // 
        // btnSetTimeServer
        // 
        btnSetTimeServer.Dock = DockStyle.Top;
        btnSetTimeServer.Location = new Point(5, 154);
        btnSetTimeServer.Name = "btnSetTimeServer";
        btnSetTimeServer.Size = new Size(238, 23);
        btnSetTimeServer.TabIndex = 8;
        btnSetTimeServer.Text = "Set Time server";
        btnSetTimeServer.UseVisualStyleBackColor = true;
        btnSetTimeServer.Click += btnSetTimeServer_Click;
        // 
        // sep29
        // 
        sep29.Dock = DockStyle.Top;
        sep29.Location = new Point(5, 149);
        sep29.Name = "sep29";
        sep29.Size = new Size(238, 5);
        sep29.TabIndex = 7;
        // 
        // txtSetTimeServerTimeServer
        // 
        txtSetTimeServerTimeServer.Dock = DockStyle.Top;
        txtSetTimeServerTimeServer.Location = new Point(5, 126);
        txtSetTimeServerTimeServer.Name = "txtSetTimeServerTimeServer";
        txtSetTimeServerTimeServer.PlaceholderText = "timeServer";
        txtSetTimeServerTimeServer.Size = new Size(238, 23);
        txtSetTimeServerTimeServer.TabIndex = 6;
        txtSetTimeServerTimeServer.Text = "132.163.4.101";
        // 
        // sep28
        // 
        sep28.Dock = DockStyle.Top;
        sep28.Location = new Point(5, 121);
        sep28.Name = "sep28";
        sep28.Size = new Size(238, 5);
        sep28.TabIndex = 5;
        // 
        // gridTimeServer
        // 
        gridTimeServer.Dock = DockStyle.Top;
        gridTimeServer.HelpVisible = false;
        gridTimeServer.Location = new Point(5, 61);
        gridTimeServer.Name = "gridTimeServer";
        gridTimeServer.PropertySort = PropertySort.NoSort;
        gridTimeServer.Size = new Size(238, 60);
        gridTimeServer.TabIndex = 4;
        gridTimeServer.ToolbarVisible = false;
        // 
        // sep27
        // 
        sep27.Dock = DockStyle.Top;
        sep27.Location = new Point(5, 56);
        sep27.Name = "sep27";
        sep27.Size = new Size(238, 5);
        sep27.TabIndex = 3;
        // 
        // btnGetTimeServer
        // 
        btnGetTimeServer.Dock = DockStyle.Top;
        btnGetTimeServer.Location = new Point(5, 33);
        btnGetTimeServer.Name = "btnGetTimeServer";
        btnGetTimeServer.Size = new Size(238, 23);
        btnGetTimeServer.TabIndex = 2;
        btnGetTimeServer.Text = "Get Time server";
        btnGetTimeServer.UseVisualStyleBackColor = true;
        btnGetTimeServer.Click += btnGetTimeServer_Click;
        // 
        // sep26
        // 
        sep26.Dock = DockStyle.Top;
        sep26.Location = new Point(5, 28);
        sep26.Name = "sep26";
        sep26.Size = new Size(238, 5);
        sep26.TabIndex = 1;
        // 
        // txtGetTimeServerServerIp
        // 
        txtGetTimeServerServerIp.Dock = DockStyle.Top;
        txtGetTimeServerServerIp.Location = new Point(5, 5);
        txtGetTimeServerServerIp.Name = "txtGetTimeServerServerIp";
        txtGetTimeServerServerIp.PlaceholderText = "serverIp (optional, v2 only)";
        txtGetTimeServerServerIp.Size = new Size(238, 23);
        txtGetTimeServerServerIp.TabIndex = 0;
        // 
        // tabBackup
        // 
        tabBackup.Controls.Add(flowBackup);
        tabBackup.Location = new Point(4, 24);
        tabBackup.Name = "tabBackup";
        tabBackup.Padding = new Padding(3);
        tabBackup.Size = new Size(882, 463);
        tabBackup.TabIndex = 3;
        tabBackup.Text = "Backup";
        tabBackup.UseVisualStyleBackColor = true;
        // 
        // flowBackup
        // 
        flowBackup.AutoScroll = true;
        flowBackup.Controls.Add(pnlBackupResources);
        flowBackup.Controls.Add(pnlBackupInfo);
        flowBackup.Controls.Add(pnlBackupState);
        flowBackup.Controls.Add(pnlCreateBackup);
        flowBackup.Controls.Add(pnlRestoreBackup);
        flowBackup.Controls.Add(pnlCheckRestore);
        flowBackup.Dock = DockStyle.Fill;
        flowBackup.FlowDirection = FlowDirection.TopDown;
        flowBackup.Location = new Point(3, 3);
        flowBackup.Name = "flowBackup";
        flowBackup.Size = new Size(876, 457);
        flowBackup.TabIndex = 0;
        // 
        // pnlBackupResources
        // 
        pnlBackupResources.BorderStyle = BorderStyle.FixedSingle;
        pnlBackupResources.Controls.Add(gridBackupResources);
        pnlBackupResources.Controls.Add(sep30);
        pnlBackupResources.Controls.Add(btnGetBackupResources);
        pnlBackupResources.Location = new Point(3, 3);
        pnlBackupResources.Name = "pnlBackupResources";
        pnlBackupResources.Padding = new Padding(5);
        pnlBackupResources.Size = new Size(250, 103);
        pnlBackupResources.TabIndex = 0;
        // 
        // gridBackupResources
        // 
        gridBackupResources.Dock = DockStyle.Top;
        gridBackupResources.HelpVisible = false;
        gridBackupResources.Location = new Point(5, 33);
        gridBackupResources.Name = "gridBackupResources";
        gridBackupResources.PropertySort = PropertySort.NoSort;
        gridBackupResources.Size = new Size(238, 63);
        gridBackupResources.TabIndex = 2;
        gridBackupResources.ToolbarVisible = false;
        // 
        // sep30
        // 
        sep30.Dock = DockStyle.Top;
        sep30.Location = new Point(5, 28);
        sep30.Name = "sep30";
        sep30.Size = new Size(238, 5);
        sep30.TabIndex = 1;
        // 
        // btnGetBackupResources
        // 
        btnGetBackupResources.Dock = DockStyle.Top;
        btnGetBackupResources.Location = new Point(5, 5);
        btnGetBackupResources.Name = "btnGetBackupResources";
        btnGetBackupResources.Size = new Size(238, 23);
        btnGetBackupResources.TabIndex = 0;
        btnGetBackupResources.Text = "Get Backup resources";
        btnGetBackupResources.UseVisualStyleBackColor = true;
        btnGetBackupResources.Click += btnGetBackupResources_Click;
        // 
        // pnlBackupInfo
        // 
        pnlBackupInfo.BorderStyle = BorderStyle.FixedSingle;
        pnlBackupInfo.Controls.Add(gridBackupInfo);
        pnlBackupInfo.Controls.Add(sep32);
        pnlBackupInfo.Controls.Add(btnGetBackupInfo);
        pnlBackupInfo.Controls.Add(sep31);
        pnlBackupInfo.Controls.Add(txtGetBackupInfoBackupPath);
        pnlBackupInfo.Location = new Point(3, 112);
        pnlBackupInfo.Name = "pnlBackupInfo";
        pnlBackupInfo.Padding = new Padding(5);
        pnlBackupInfo.Size = new Size(250, 340);
        pnlBackupInfo.TabIndex = 1;
        // 
        // gridBackupInfo
        // 
        gridBackupInfo.Dock = DockStyle.Top;
        gridBackupInfo.HelpVisible = false;
        gridBackupInfo.Location = new Point(5, 61);
        gridBackupInfo.Name = "gridBackupInfo";
        gridBackupInfo.PropertySort = PropertySort.NoSort;
        gridBackupInfo.Size = new Size(238, 272);
        gridBackupInfo.TabIndex = 4;
        gridBackupInfo.ToolbarVisible = false;
        // 
        // sep32
        // 
        sep32.Dock = DockStyle.Top;
        sep32.Location = new Point(5, 56);
        sep32.Name = "sep32";
        sep32.Size = new Size(238, 5);
        sep32.TabIndex = 3;
        // 
        // btnGetBackupInfo
        // 
        btnGetBackupInfo.Dock = DockStyle.Top;
        btnGetBackupInfo.Location = new Point(5, 33);
        btnGetBackupInfo.Name = "btnGetBackupInfo";
        btnGetBackupInfo.Size = new Size(238, 23);
        btnGetBackupInfo.TabIndex = 2;
        btnGetBackupInfo.Text = "Get Backup info";
        btnGetBackupInfo.UseVisualStyleBackColor = true;
        btnGetBackupInfo.Click += btnGetBackupInfo_Click;
        // 
        // sep31
        // 
        sep31.Dock = DockStyle.Top;
        sep31.Location = new Point(5, 28);
        sep31.Name = "sep31";
        sep31.Size = new Size(238, 5);
        sep31.TabIndex = 1;
        // 
        // txtGetBackupInfoBackupPath
        // 
        txtGetBackupInfoBackupPath.Dock = DockStyle.Top;
        txtGetBackupInfoBackupPath.Location = new Point(5, 5);
        txtGetBackupInfoBackupPath.Name = "txtGetBackupInfoBackupPath";
        txtGetBackupInfoBackupPath.PlaceholderText = "backupPath";
        txtGetBackupInfoBackupPath.Size = new Size(238, 23);
        txtGetBackupInfoBackupPath.TabIndex = 0;
        txtGetBackupInfoBackupPath.Text = "$temp/mybackup";
        // 
        // pnlBackupState
        // 
        pnlBackupState.BorderStyle = BorderStyle.FixedSingle;
        pnlBackupState.Controls.Add(txtBackupState);
        pnlBackupState.Controls.Add(sep33);
        pnlBackupState.Controls.Add(btnGetBackupState);
        pnlBackupState.Location = new Point(259, 3);
        pnlBackupState.Name = "pnlBackupState";
        pnlBackupState.Padding = new Padding(5);
        pnlBackupState.Size = new Size(250, 63);
        pnlBackupState.TabIndex = 2;
        // 
        // txtBackupState
        // 
        txtBackupState.Dock = DockStyle.Top;
        txtBackupState.Location = new Point(5, 33);
        txtBackupState.Name = "txtBackupState";
        txtBackupState.PlaceholderText = "backup state";
        txtBackupState.ReadOnly = true;
        txtBackupState.Size = new Size(238, 23);
        txtBackupState.TabIndex = 2;
        // 
        // sep33
        // 
        sep33.Dock = DockStyle.Top;
        sep33.Location = new Point(5, 28);
        sep33.Name = "sep33";
        sep33.Size = new Size(238, 5);
        sep33.TabIndex = 1;
        // 
        // btnGetBackupState
        // 
        btnGetBackupState.Dock = DockStyle.Top;
        btnGetBackupState.Location = new Point(5, 5);
        btnGetBackupState.Name = "btnGetBackupState";
        btnGetBackupState.Size = new Size(238, 23);
        btnGetBackupState.TabIndex = 0;
        btnGetBackupState.Text = "Get Backup state";
        btnGetBackupState.UseVisualStyleBackColor = true;
        btnGetBackupState.Click += btnGetBackupState_Click;
        // 
        // pnlCreateBackup
        // 
        pnlCreateBackup.BorderStyle = BorderStyle.FixedSingle;
        pnlCreateBackup.Controls.Add(btnCreateBackup);
        pnlCreateBackup.Controls.Add(sep35);
        pnlCreateBackup.Controls.Add(chkCreateBackupArchive);
        pnlCreateBackup.Controls.Add(sep34);
        pnlCreateBackup.Controls.Add(txtCreateBackupBackupPath);
        pnlCreateBackup.Location = new Point(259, 72);
        pnlCreateBackup.Name = "pnlCreateBackup";
        pnlCreateBackup.Padding = new Padding(5);
        pnlCreateBackup.Size = new Size(250, 91);
        pnlCreateBackup.TabIndex = 3;
        // 
        // btnCreateBackup
        // 
        btnCreateBackup.Dock = DockStyle.Top;
        btnCreateBackup.Location = new Point(5, 61);
        btnCreateBackup.Name = "btnCreateBackup";
        btnCreateBackup.Size = new Size(238, 23);
        btnCreateBackup.TabIndex = 4;
        btnCreateBackup.Text = "Create Backup";
        btnCreateBackup.UseVisualStyleBackColor = true;
        btnCreateBackup.Click += btnCreateBackup_Click;
        // 
        // sep35
        // 
        sep35.Dock = DockStyle.Top;
        sep35.Location = new Point(5, 56);
        sep35.Name = "sep35";
        sep35.Size = new Size(238, 5);
        sep35.TabIndex = 3;
        // 
        // chkCreateBackupArchive
        // 
        chkCreateBackupArchive.Dock = DockStyle.Top;
        chkCreateBackupArchive.Location = new Point(5, 33);
        chkCreateBackupArchive.Name = "chkCreateBackupArchive";
        chkCreateBackupArchive.Size = new Size(238, 23);
        chkCreateBackupArchive.TabIndex = 2;
        chkCreateBackupArchive.Text = "Archive";
        chkCreateBackupArchive.UseVisualStyleBackColor = true;
        // 
        // sep34
        // 
        sep34.Dock = DockStyle.Top;
        sep34.Location = new Point(5, 28);
        sep34.Name = "sep34";
        sep34.Size = new Size(238, 5);
        sep34.TabIndex = 1;
        // 
        // txtCreateBackupBackupPath
        // 
        txtCreateBackupBackupPath.Dock = DockStyle.Top;
        txtCreateBackupBackupPath.Location = new Point(5, 5);
        txtCreateBackupBackupPath.Name = "txtCreateBackupBackupPath";
        txtCreateBackupBackupPath.PlaceholderText = "backupPath";
        txtCreateBackupBackupPath.Size = new Size(238, 23);
        txtCreateBackupBackupPath.TabIndex = 0;
        txtCreateBackupBackupPath.Text = "$temp/mybackup";
        // 
        // pnlRestoreBackup
        // 
        pnlRestoreBackup.BorderStyle = BorderStyle.FixedSingle;
        pnlRestoreBackup.Controls.Add(btnRestoreBackup);
        pnlRestoreBackup.Controls.Add(sep41);
        pnlRestoreBackup.Controls.Add(chkRestoreBackupIncludeSafetySettings);
        pnlRestoreBackup.Controls.Add(sep40);
        pnlRestoreBackup.Controls.Add(chkRestoreBackupIncludeControllerSettings);
        pnlRestoreBackup.Controls.Add(sep39);
        pnlRestoreBackup.Controls.Add(chkRestoreBackupDeleteDirectory);
        pnlRestoreBackup.Controls.Add(sep38);
        pnlRestoreBackup.Controls.Add(cboRestoreBackupInclude);
        pnlRestoreBackup.Controls.Add(sep37);
        pnlRestoreBackup.Controls.Add(cboRestoreBackupIgnore);
        pnlRestoreBackup.Controls.Add(sep36);
        pnlRestoreBackup.Controls.Add(txtRestoreBackupBackupPath);
        pnlRestoreBackup.Location = new Point(259, 169);
        pnlRestoreBackup.Name = "pnlRestoreBackup";
        pnlRestoreBackup.Padding = new Padding(5);
        pnlRestoreBackup.Size = new Size(250, 203);
        pnlRestoreBackup.TabIndex = 4;
        // 
        // btnRestoreBackup
        // 
        btnRestoreBackup.Dock = DockStyle.Top;
        btnRestoreBackup.Location = new Point(5, 173);
        btnRestoreBackup.Name = "btnRestoreBackup";
        btnRestoreBackup.Size = new Size(238, 23);
        btnRestoreBackup.TabIndex = 12;
        btnRestoreBackup.Text = "Restore Backup";
        btnRestoreBackup.UseVisualStyleBackColor = true;
        btnRestoreBackup.Click += btnRestoreBackup_Click;
        // 
        // sep41
        // 
        sep41.Dock = DockStyle.Top;
        sep41.Location = new Point(5, 168);
        sep41.Name = "sep41";
        sep41.Size = new Size(238, 5);
        sep41.TabIndex = 11;
        // 
        // chkRestoreBackupIncludeSafetySettings
        // 
        chkRestoreBackupIncludeSafetySettings.Checked = true;
        chkRestoreBackupIncludeSafetySettings.CheckState = CheckState.Checked;
        chkRestoreBackupIncludeSafetySettings.Dock = DockStyle.Top;
        chkRestoreBackupIncludeSafetySettings.Location = new Point(5, 145);
        chkRestoreBackupIncludeSafetySettings.Name = "chkRestoreBackupIncludeSafetySettings";
        chkRestoreBackupIncludeSafetySettings.Size = new Size(238, 23);
        chkRestoreBackupIncludeSafetySettings.TabIndex = 10;
        chkRestoreBackupIncludeSafetySettings.Text = "Include safety settings";
        chkRestoreBackupIncludeSafetySettings.UseVisualStyleBackColor = true;
        // 
        // sep40
        // 
        sep40.Dock = DockStyle.Top;
        sep40.Location = new Point(5, 140);
        sep40.Name = "sep40";
        sep40.Size = new Size(238, 5);
        sep40.TabIndex = 9;
        // 
        // chkRestoreBackupIncludeControllerSettings
        // 
        chkRestoreBackupIncludeControllerSettings.Checked = true;
        chkRestoreBackupIncludeControllerSettings.CheckState = CheckState.Checked;
        chkRestoreBackupIncludeControllerSettings.Dock = DockStyle.Top;
        chkRestoreBackupIncludeControllerSettings.Location = new Point(5, 117);
        chkRestoreBackupIncludeControllerSettings.Name = "chkRestoreBackupIncludeControllerSettings";
        chkRestoreBackupIncludeControllerSettings.Size = new Size(238, 23);
        chkRestoreBackupIncludeControllerSettings.TabIndex = 8;
        chkRestoreBackupIncludeControllerSettings.Text = "Include controller settings";
        chkRestoreBackupIncludeControllerSettings.UseVisualStyleBackColor = true;
        // 
        // sep39
        // 
        sep39.Dock = DockStyle.Top;
        sep39.Location = new Point(5, 112);
        sep39.Name = "sep39";
        sep39.Size = new Size(238, 5);
        sep39.TabIndex = 7;
        // 
        // chkRestoreBackupDeleteDirectory
        // 
        chkRestoreBackupDeleteDirectory.Checked = true;
        chkRestoreBackupDeleteDirectory.CheckState = CheckState.Checked;
        chkRestoreBackupDeleteDirectory.Dock = DockStyle.Top;
        chkRestoreBackupDeleteDirectory.Location = new Point(5, 89);
        chkRestoreBackupDeleteDirectory.Name = "chkRestoreBackupDeleteDirectory";
        chkRestoreBackupDeleteDirectory.Size = new Size(238, 23);
        chkRestoreBackupDeleteDirectory.TabIndex = 6;
        chkRestoreBackupDeleteDirectory.Text = "Delete directory";
        chkRestoreBackupDeleteDirectory.UseVisualStyleBackColor = true;
        // 
        // sep38
        // 
        sep38.Dock = DockStyle.Top;
        sep38.Location = new Point(5, 84);
        sep38.Name = "sep38";
        sep38.Size = new Size(238, 5);
        sep38.TabIndex = 5;
        // 
        // cboRestoreBackupInclude
        // 
        cboRestoreBackupInclude.Dock = DockStyle.Top;
        cboRestoreBackupInclude.DropDownStyle = ComboBoxStyle.DropDownList;
        cboRestoreBackupInclude.FormattingEnabled = true;
        cboRestoreBackupInclude.Location = new Point(5, 61);
        cboRestoreBackupInclude.Name = "cboRestoreBackupInclude";
        cboRestoreBackupInclude.Size = new Size(238, 23);
        cboRestoreBackupInclude.TabIndex = 4;
        // 
        // sep37
        // 
        sep37.Dock = DockStyle.Top;
        sep37.Location = new Point(5, 56);
        sep37.Name = "sep37";
        sep37.Size = new Size(238, 5);
        sep37.TabIndex = 3;
        // 
        // cboRestoreBackupIgnore
        // 
        cboRestoreBackupIgnore.Dock = DockStyle.Top;
        cboRestoreBackupIgnore.DropDownStyle = ComboBoxStyle.DropDownList;
        cboRestoreBackupIgnore.FormattingEnabled = true;
        cboRestoreBackupIgnore.Location = new Point(5, 33);
        cboRestoreBackupIgnore.Name = "cboRestoreBackupIgnore";
        cboRestoreBackupIgnore.Size = new Size(238, 23);
        cboRestoreBackupIgnore.TabIndex = 2;
        // 
        // sep36
        // 
        sep36.Dock = DockStyle.Top;
        sep36.Location = new Point(5, 28);
        sep36.Name = "sep36";
        sep36.Size = new Size(238, 5);
        sep36.TabIndex = 1;
        // 
        // txtRestoreBackupBackupPath
        // 
        txtRestoreBackupBackupPath.Dock = DockStyle.Top;
        txtRestoreBackupBackupPath.Location = new Point(5, 5);
        txtRestoreBackupBackupPath.Name = "txtRestoreBackupBackupPath";
        txtRestoreBackupBackupPath.PlaceholderText = "backupPath";
        txtRestoreBackupBackupPath.Size = new Size(238, 23);
        txtRestoreBackupBackupPath.TabIndex = 0;
        txtRestoreBackupBackupPath.Text = "$temp/mybackup";
        // 
        // pnlCheckRestore
        // 
        pnlCheckRestore.BorderStyle = BorderStyle.FixedSingle;
        pnlCheckRestore.Controls.Add(gridCheckRestore);
        pnlCheckRestore.Controls.Add(sep47);
        pnlCheckRestore.Controls.Add(btnCheckRestore);
        pnlCheckRestore.Controls.Add(sep46);
        pnlCheckRestore.Controls.Add(chkCheckRestoreIncludeSafetySettings);
        pnlCheckRestore.Controls.Add(sep45);
        pnlCheckRestore.Controls.Add(chkCheckRestoreIncludeControllerSettings);
        pnlCheckRestore.Controls.Add(sep44);
        pnlCheckRestore.Controls.Add(cboCheckRestoreInclude);
        pnlCheckRestore.Controls.Add(sep43);
        pnlCheckRestore.Controls.Add(cboCheckRestoreIgnore);
        pnlCheckRestore.Controls.Add(sep42);
        pnlCheckRestore.Controls.Add(txtCheckRestoreBackupPath);
        pnlCheckRestore.Location = new Point(515, 3);
        pnlCheckRestore.Name = "pnlCheckRestore";
        pnlCheckRestore.Padding = new Padding(5);
        pnlCheckRestore.Size = new Size(250, 243);
        pnlCheckRestore.TabIndex = 5;
        // 
        // gridCheckRestore
        // 
        gridCheckRestore.Dock = DockStyle.Top;
        gridCheckRestore.HelpVisible = false;
        gridCheckRestore.Location = new Point(5, 173);
        gridCheckRestore.Name = "gridCheckRestore";
        gridCheckRestore.PropertySort = PropertySort.NoSort;
        gridCheckRestore.Size = new Size(238, 63);
        gridCheckRestore.TabIndex = 12;
        gridCheckRestore.ToolbarVisible = false;
        // 
        // sep47
        // 
        sep47.Dock = DockStyle.Top;
        sep47.Location = new Point(5, 168);
        sep47.Name = "sep47";
        sep47.Size = new Size(238, 5);
        sep47.TabIndex = 11;
        // 
        // btnCheckRestore
        // 
        btnCheckRestore.Dock = DockStyle.Top;
        btnCheckRestore.Location = new Point(5, 145);
        btnCheckRestore.Name = "btnCheckRestore";
        btnCheckRestore.Size = new Size(238, 23);
        btnCheckRestore.TabIndex = 10;
        btnCheckRestore.Text = "Check Restore";
        btnCheckRestore.UseVisualStyleBackColor = true;
        btnCheckRestore.Click += btnCheckRestore_Click;
        // 
        // sep46
        // 
        sep46.Dock = DockStyle.Top;
        sep46.Location = new Point(5, 140);
        sep46.Name = "sep46";
        sep46.Size = new Size(238, 5);
        sep46.TabIndex = 9;
        // 
        // chkCheckRestoreIncludeSafetySettings
        // 
        chkCheckRestoreIncludeSafetySettings.Checked = true;
        chkCheckRestoreIncludeSafetySettings.CheckState = CheckState.Checked;
        chkCheckRestoreIncludeSafetySettings.Dock = DockStyle.Top;
        chkCheckRestoreIncludeSafetySettings.Location = new Point(5, 117);
        chkCheckRestoreIncludeSafetySettings.Name = "chkCheckRestoreIncludeSafetySettings";
        chkCheckRestoreIncludeSafetySettings.Size = new Size(238, 23);
        chkCheckRestoreIncludeSafetySettings.TabIndex = 8;
        chkCheckRestoreIncludeSafetySettings.Text = "Include safety settings";
        chkCheckRestoreIncludeSafetySettings.UseVisualStyleBackColor = true;
        // 
        // sep45
        // 
        sep45.Dock = DockStyle.Top;
        sep45.Location = new Point(5, 112);
        sep45.Name = "sep45";
        sep45.Size = new Size(238, 5);
        sep45.TabIndex = 7;
        // 
        // chkCheckRestoreIncludeControllerSettings
        // 
        chkCheckRestoreIncludeControllerSettings.Checked = true;
        chkCheckRestoreIncludeControllerSettings.CheckState = CheckState.Checked;
        chkCheckRestoreIncludeControllerSettings.Dock = DockStyle.Top;
        chkCheckRestoreIncludeControllerSettings.Location = new Point(5, 89);
        chkCheckRestoreIncludeControllerSettings.Name = "chkCheckRestoreIncludeControllerSettings";
        chkCheckRestoreIncludeControllerSettings.Size = new Size(238, 23);
        chkCheckRestoreIncludeControllerSettings.TabIndex = 6;
        chkCheckRestoreIncludeControllerSettings.Text = "Include controller settings";
        chkCheckRestoreIncludeControllerSettings.UseVisualStyleBackColor = true;
        // 
        // sep44
        // 
        sep44.Dock = DockStyle.Top;
        sep44.Location = new Point(5, 84);
        sep44.Name = "sep44";
        sep44.Size = new Size(238, 5);
        sep44.TabIndex = 5;
        // 
        // cboCheckRestoreInclude
        // 
        cboCheckRestoreInclude.Dock = DockStyle.Top;
        cboCheckRestoreInclude.DropDownStyle = ComboBoxStyle.DropDownList;
        cboCheckRestoreInclude.FormattingEnabled = true;
        cboCheckRestoreInclude.Location = new Point(5, 61);
        cboCheckRestoreInclude.Name = "cboCheckRestoreInclude";
        cboCheckRestoreInclude.Size = new Size(238, 23);
        cboCheckRestoreInclude.TabIndex = 4;
        // 
        // sep43
        // 
        sep43.Dock = DockStyle.Top;
        sep43.Location = new Point(5, 56);
        sep43.Name = "sep43";
        sep43.Size = new Size(238, 5);
        sep43.TabIndex = 3;
        // 
        // cboCheckRestoreIgnore
        // 
        cboCheckRestoreIgnore.Dock = DockStyle.Top;
        cboCheckRestoreIgnore.DropDownStyle = ComboBoxStyle.DropDownList;
        cboCheckRestoreIgnore.FormattingEnabled = true;
        cboCheckRestoreIgnore.Location = new Point(5, 33);
        cboCheckRestoreIgnore.Name = "cboCheckRestoreIgnore";
        cboCheckRestoreIgnore.Size = new Size(238, 23);
        cboCheckRestoreIgnore.TabIndex = 2;
        // 
        // sep42
        // 
        sep42.Dock = DockStyle.Top;
        sep42.Location = new Point(5, 28);
        sep42.Name = "sep42";
        sep42.Size = new Size(238, 5);
        sep42.TabIndex = 1;
        // 
        // txtCheckRestoreBackupPath
        // 
        txtCheckRestoreBackupPath.Dock = DockStyle.Top;
        txtCheckRestoreBackupPath.Location = new Point(5, 5);
        txtCheckRestoreBackupPath.Name = "txtCheckRestoreBackupPath";
        txtCheckRestoreBackupPath.PlaceholderText = "backupPath";
        txtCheckRestoreBackupPath.Size = new Size(238, 23);
        txtCheckRestoreBackupPath.TabIndex = 0;
        txtCheckRestoreBackupPath.Text = "$temp/mybackup";
        // 
        // tabSafety
        // 
        tabSafety.Controls.Add(flowSafety);
        tabSafety.Location = new Point(4, 24);
        tabSafety.Name = "tabSafety";
        tabSafety.Padding = new Padding(3);
        tabSafety.Size = new Size(882, 463);
        tabSafety.TabIndex = 4;
        tabSafety.Text = "Safety";
        tabSafety.UseVisualStyleBackColor = true;
        // 
        // flowSafety
        // 
        flowSafety.AutoScroll = true;
        flowSafety.Controls.Add(pnlSafetyResources);
        flowSafety.Controls.Add(pnlSafetyMode);
        flowSafety.Controls.Add(pnlSafetyConfiguration);
        flowSafety.Controls.Add(pnlInvalidateSafetyConfiguration);
        flowSafety.Controls.Add(pnlSafetyLoadOperationStatus);
        flowSafety.Controls.Add(pnlCyclicBrakeCheckStatus);
        flowSafety.Controls.Add(pnlSafetyViolationInfo);
        flowSafety.Dock = DockStyle.Fill;
        flowSafety.FlowDirection = FlowDirection.TopDown;
        flowSafety.Location = new Point(3, 3);
        flowSafety.Name = "flowSafety";
        flowSafety.Size = new Size(876, 457);
        flowSafety.TabIndex = 0;
        // 
        // pnlSafetyResources
        // 
        pnlSafetyResources.BorderStyle = BorderStyle.FixedSingle;
        pnlSafetyResources.Controls.Add(gridSafetyResources);
        pnlSafetyResources.Controls.Add(sep48);
        pnlSafetyResources.Controls.Add(btnGetSafetyResources);
        pnlSafetyResources.Location = new Point(3, 3);
        pnlSafetyResources.Name = "pnlSafetyResources";
        pnlSafetyResources.Padding = new Padding(5);
        pnlSafetyResources.Size = new Size(250, 179);
        pnlSafetyResources.TabIndex = 0;
        // 
        // gridSafetyResources
        // 
        gridSafetyResources.Dock = DockStyle.Top;
        gridSafetyResources.HelpVisible = false;
        gridSafetyResources.Location = new Point(5, 33);
        gridSafetyResources.Name = "gridSafetyResources";
        gridSafetyResources.PropertySort = PropertySort.NoSort;
        gridSafetyResources.Size = new Size(238, 139);
        gridSafetyResources.TabIndex = 2;
        gridSafetyResources.ToolbarVisible = false;
        // 
        // sep48
        // 
        sep48.Dock = DockStyle.Top;
        sep48.Location = new Point(5, 28);
        sep48.Name = "sep48";
        sep48.Size = new Size(238, 5);
        sep48.TabIndex = 1;
        // 
        // btnGetSafetyResources
        // 
        btnGetSafetyResources.Dock = DockStyle.Top;
        btnGetSafetyResources.Location = new Point(5, 5);
        btnGetSafetyResources.Name = "btnGetSafetyResources";
        btnGetSafetyResources.Size = new Size(238, 23);
        btnGetSafetyResources.TabIndex = 0;
        btnGetSafetyResources.Text = "Get Safety resources";
        btnGetSafetyResources.UseVisualStyleBackColor = true;
        btnGetSafetyResources.Click += btnGetSafetyResources_Click;
        // 
        // pnlSafetyMode
        // 
        pnlSafetyMode.BorderStyle = BorderStyle.FixedSingle;
        pnlSafetyMode.Controls.Add(btnSetSafetyMode);
        pnlSafetyMode.Controls.Add(sep51);
        pnlSafetyMode.Controls.Add(cboSetSafetyModeMode);
        pnlSafetyMode.Controls.Add(sep50);
        pnlSafetyMode.Controls.Add(gridSafetyMode);
        pnlSafetyMode.Controls.Add(sep49);
        pnlSafetyMode.Controls.Add(btnGetSafetyMode);
        pnlSafetyMode.Location = new Point(3, 188);
        pnlSafetyMode.Name = "pnlSafetyMode";
        pnlSafetyMode.Padding = new Padding(5);
        pnlSafetyMode.Size = new Size(250, 156);
        pnlSafetyMode.TabIndex = 1;
        // 
        // btnSetSafetyMode
        // 
        btnSetSafetyMode.Dock = DockStyle.Top;
        btnSetSafetyMode.Location = new Point(5, 126);
        btnSetSafetyMode.Name = "btnSetSafetyMode";
        btnSetSafetyMode.Size = new Size(238, 23);
        btnSetSafetyMode.TabIndex = 6;
        btnSetSafetyMode.Text = "Set Safety mode";
        btnSetSafetyMode.UseVisualStyleBackColor = true;
        btnSetSafetyMode.Click += btnSetSafetyMode_Click;
        // 
        // sep51
        // 
        sep51.Dock = DockStyle.Top;
        sep51.Location = new Point(5, 121);
        sep51.Name = "sep51";
        sep51.Size = new Size(238, 5);
        sep51.TabIndex = 5;
        // 
        // cboSetSafetyModeMode
        // 
        cboSetSafetyModeMode.Dock = DockStyle.Top;
        cboSetSafetyModeMode.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSetSafetyModeMode.FormattingEnabled = true;
        cboSetSafetyModeMode.Location = new Point(5, 98);
        cboSetSafetyModeMode.Name = "cboSetSafetyModeMode";
        cboSetSafetyModeMode.Size = new Size(238, 23);
        cboSetSafetyModeMode.TabIndex = 4;
        // 
        // sep50
        // 
        sep50.Dock = DockStyle.Top;
        sep50.Location = new Point(5, 93);
        sep50.Name = "sep50";
        sep50.Size = new Size(238, 5);
        sep50.TabIndex = 3;
        // 
        // gridSafetyMode
        // 
        gridSafetyMode.Dock = DockStyle.Top;
        gridSafetyMode.HelpVisible = false;
        gridSafetyMode.Location = new Point(5, 33);
        gridSafetyMode.Name = "gridSafetyMode";
        gridSafetyMode.PropertySort = PropertySort.NoSort;
        gridSafetyMode.Size = new Size(238, 60);
        gridSafetyMode.TabIndex = 2;
        gridSafetyMode.ToolbarVisible = false;
        // 
        // sep49
        // 
        sep49.Dock = DockStyle.Top;
        sep49.Location = new Point(5, 28);
        sep49.Name = "sep49";
        sep49.Size = new Size(238, 5);
        sep49.TabIndex = 1;
        // 
        // btnGetSafetyMode
        // 
        btnGetSafetyMode.Dock = DockStyle.Top;
        btnGetSafetyMode.Location = new Point(5, 5);
        btnGetSafetyMode.Name = "btnGetSafetyMode";
        btnGetSafetyMode.Size = new Size(238, 23);
        btnGetSafetyMode.TabIndex = 0;
        btnGetSafetyMode.Text = "Get Safety mode";
        btnGetSafetyMode.UseVisualStyleBackColor = true;
        btnGetSafetyMode.Click += btnGetSafetyMode_Click;
        // 
        // pnlSafetyConfiguration
        // 
        pnlSafetyConfiguration.BorderStyle = BorderStyle.FixedSingle;
        pnlSafetyConfiguration.Controls.Add(btnLoadSafetyConfiguration);
        pnlSafetyConfiguration.Controls.Add(sep54);
        pnlSafetyConfiguration.Controls.Add(txtLoadSafetyConfigurationFilePath);
        pnlSafetyConfiguration.Controls.Add(sep53);
        pnlSafetyConfiguration.Controls.Add(gridSafetyConfiguration);
        pnlSafetyConfiguration.Controls.Add(sep52);
        pnlSafetyConfiguration.Controls.Add(btnGetSafetyConfiguration);
        pnlSafetyConfiguration.Location = new Point(259, 3);
        pnlSafetyConfiguration.Name = "pnlSafetyConfiguration";
        pnlSafetyConfiguration.Padding = new Padding(5);
        pnlSafetyConfiguration.Size = new Size(250, 311);
        pnlSafetyConfiguration.TabIndex = 2;
        // 
        // btnLoadSafetyConfiguration
        // 
        btnLoadSafetyConfiguration.Dock = DockStyle.Top;
        btnLoadSafetyConfiguration.Location = new Point(5, 281);
        btnLoadSafetyConfiguration.Name = "btnLoadSafetyConfiguration";
        btnLoadSafetyConfiguration.Size = new Size(238, 23);
        btnLoadSafetyConfiguration.TabIndex = 6;
        btnLoadSafetyConfiguration.Text = "Load Safety configuration";
        btnLoadSafetyConfiguration.UseVisualStyleBackColor = true;
        btnLoadSafetyConfiguration.Click += btnLoadSafetyConfiguration_Click;
        // 
        // sep54
        // 
        sep54.Dock = DockStyle.Top;
        sep54.Location = new Point(5, 276);
        sep54.Name = "sep54";
        sep54.Size = new Size(238, 5);
        sep54.TabIndex = 5;
        // 
        // txtLoadSafetyConfigurationFilePath
        // 
        txtLoadSafetyConfigurationFilePath.Dock = DockStyle.Top;
        txtLoadSafetyConfigurationFilePath.Location = new Point(5, 253);
        txtLoadSafetyConfigurationFilePath.Name = "txtLoadSafetyConfigurationFilePath";
        txtLoadSafetyConfigurationFilePath.PlaceholderText = "filePath";
        txtLoadSafetyConfigurationFilePath.Size = new Size(238, 23);
        txtLoadSafetyConfigurationFilePath.TabIndex = 4;
        txtLoadSafetyConfigurationFilePath.Text = "$home/safety.xml";
        // 
        // sep53
        // 
        sep53.Dock = DockStyle.Top;
        sep53.Location = new Point(5, 248);
        sep53.Name = "sep53";
        sep53.Size = new Size(238, 5);
        sep53.TabIndex = 3;
        // 
        // gridSafetyConfiguration
        // 
        gridSafetyConfiguration.Dock = DockStyle.Top;
        gridSafetyConfiguration.HelpVisible = false;
        gridSafetyConfiguration.Location = new Point(5, 33);
        gridSafetyConfiguration.Name = "gridSafetyConfiguration";
        gridSafetyConfiguration.PropertySort = PropertySort.NoSort;
        gridSafetyConfiguration.Size = new Size(238, 215);
        gridSafetyConfiguration.TabIndex = 2;
        gridSafetyConfiguration.ToolbarVisible = false;
        // 
        // sep52
        // 
        sep52.Dock = DockStyle.Top;
        sep52.Location = new Point(5, 28);
        sep52.Name = "sep52";
        sep52.Size = new Size(238, 5);
        sep52.TabIndex = 1;
        // 
        // btnGetSafetyConfiguration
        // 
        btnGetSafetyConfiguration.Dock = DockStyle.Top;
        btnGetSafetyConfiguration.Location = new Point(5, 5);
        btnGetSafetyConfiguration.Name = "btnGetSafetyConfiguration";
        btnGetSafetyConfiguration.Size = new Size(238, 23);
        btnGetSafetyConfiguration.TabIndex = 0;
        btnGetSafetyConfiguration.Text = "Get Safety configuration";
        btnGetSafetyConfiguration.UseVisualStyleBackColor = true;
        btnGetSafetyConfiguration.Click += btnGetSafetyConfiguration_Click;
        // 
        // pnlInvalidateSafetyConfiguration
        // 
        pnlInvalidateSafetyConfiguration.BorderStyle = BorderStyle.FixedSingle;
        pnlInvalidateSafetyConfiguration.Controls.Add(btnInvalidateSafetyConfiguration);
        pnlInvalidateSafetyConfiguration.Location = new Point(259, 320);
        pnlInvalidateSafetyConfiguration.Name = "pnlInvalidateSafetyConfiguration";
        pnlInvalidateSafetyConfiguration.Padding = new Padding(5);
        pnlInvalidateSafetyConfiguration.Size = new Size(250, 35);
        pnlInvalidateSafetyConfiguration.TabIndex = 3;
        // 
        // btnInvalidateSafetyConfiguration
        // 
        btnInvalidateSafetyConfiguration.Dock = DockStyle.Top;
        btnInvalidateSafetyConfiguration.Location = new Point(5, 5);
        btnInvalidateSafetyConfiguration.Name = "btnInvalidateSafetyConfiguration";
        btnInvalidateSafetyConfiguration.Size = new Size(238, 23);
        btnInvalidateSafetyConfiguration.TabIndex = 0;
        btnInvalidateSafetyConfiguration.Text = "Invalidate Safety configuration";
        btnInvalidateSafetyConfiguration.UseVisualStyleBackColor = true;
        btnInvalidateSafetyConfiguration.Click += btnInvalidateSafetyConfiguration_Click;
        // 
        // pnlSafetyLoadOperationStatus
        // 
        pnlSafetyLoadOperationStatus.BorderStyle = BorderStyle.FixedSingle;
        pnlSafetyLoadOperationStatus.Controls.Add(txtSafetyLoadOperationStatus);
        pnlSafetyLoadOperationStatus.Controls.Add(sep55);
        pnlSafetyLoadOperationStatus.Controls.Add(btnGetSafetyLoadOperationStatus);
        pnlSafetyLoadOperationStatus.Location = new Point(259, 361);
        pnlSafetyLoadOperationStatus.Name = "pnlSafetyLoadOperationStatus";
        pnlSafetyLoadOperationStatus.Padding = new Padding(5);
        pnlSafetyLoadOperationStatus.Size = new Size(250, 63);
        pnlSafetyLoadOperationStatus.TabIndex = 4;
        // 
        // txtSafetyLoadOperationStatus
        // 
        txtSafetyLoadOperationStatus.Dock = DockStyle.Top;
        txtSafetyLoadOperationStatus.Location = new Point(5, 33);
        txtSafetyLoadOperationStatus.Name = "txtSafetyLoadOperationStatus";
        txtSafetyLoadOperationStatus.PlaceholderText = "status";
        txtSafetyLoadOperationStatus.ReadOnly = true;
        txtSafetyLoadOperationStatus.Size = new Size(238, 23);
        txtSafetyLoadOperationStatus.TabIndex = 2;
        // 
        // sep55
        // 
        sep55.Dock = DockStyle.Top;
        sep55.Location = new Point(5, 28);
        sep55.Name = "sep55";
        sep55.Size = new Size(238, 5);
        sep55.TabIndex = 1;
        // 
        // btnGetSafetyLoadOperationStatus
        // 
        btnGetSafetyLoadOperationStatus.Dock = DockStyle.Top;
        btnGetSafetyLoadOperationStatus.Location = new Point(5, 5);
        btnGetSafetyLoadOperationStatus.Name = "btnGetSafetyLoadOperationStatus";
        btnGetSafetyLoadOperationStatus.Size = new Size(238, 23);
        btnGetSafetyLoadOperationStatus.TabIndex = 0;
        btnGetSafetyLoadOperationStatus.Text = "Get Safety load operation status";
        btnGetSafetyLoadOperationStatus.UseVisualStyleBackColor = true;
        btnGetSafetyLoadOperationStatus.Click += btnGetSafetyLoadOperationStatus_Click;
        // 
        // pnlCyclicBrakeCheckStatus
        // 
        pnlCyclicBrakeCheckStatus.BorderStyle = BorderStyle.FixedSingle;
        pnlCyclicBrakeCheckStatus.Controls.Add(gridCyclicBrakeCheckStatus);
        pnlCyclicBrakeCheckStatus.Controls.Add(sep57);
        pnlCyclicBrakeCheckStatus.Controls.Add(btnGetCyclicBrakeCheckStatus);
        pnlCyclicBrakeCheckStatus.Controls.Add(sep56);
        pnlCyclicBrakeCheckStatus.Controls.Add(numGetCyclicBrakeCheckStatusDriveNumber);
        pnlCyclicBrakeCheckStatus.Location = new Point(515, 3);
        pnlCyclicBrakeCheckStatus.Name = "pnlCyclicBrakeCheckStatus";
        pnlCyclicBrakeCheckStatus.Padding = new Padding(5);
        pnlCyclicBrakeCheckStatus.Size = new Size(250, 150);
        pnlCyclicBrakeCheckStatus.TabIndex = 5;
        // 
        // gridCyclicBrakeCheckStatus
        // 
        gridCyclicBrakeCheckStatus.Dock = DockStyle.Top;
        gridCyclicBrakeCheckStatus.HelpVisible = false;
        gridCyclicBrakeCheckStatus.Location = new Point(5, 61);
        gridCyclicBrakeCheckStatus.Name = "gridCyclicBrakeCheckStatus";
        gridCyclicBrakeCheckStatus.PropertySort = PropertySort.NoSort;
        gridCyclicBrakeCheckStatus.Size = new Size(238, 82);
        gridCyclicBrakeCheckStatus.TabIndex = 4;
        gridCyclicBrakeCheckStatus.ToolbarVisible = false;
        // 
        // sep57
        // 
        sep57.Dock = DockStyle.Top;
        sep57.Location = new Point(5, 56);
        sep57.Name = "sep57";
        sep57.Size = new Size(238, 5);
        sep57.TabIndex = 3;
        // 
        // btnGetCyclicBrakeCheckStatus
        // 
        btnGetCyclicBrakeCheckStatus.Dock = DockStyle.Top;
        btnGetCyclicBrakeCheckStatus.Location = new Point(5, 33);
        btnGetCyclicBrakeCheckStatus.Name = "btnGetCyclicBrakeCheckStatus";
        btnGetCyclicBrakeCheckStatus.Size = new Size(238, 23);
        btnGetCyclicBrakeCheckStatus.TabIndex = 2;
        btnGetCyclicBrakeCheckStatus.Text = "Get Cyclic brake check status";
        btnGetCyclicBrakeCheckStatus.UseVisualStyleBackColor = true;
        btnGetCyclicBrakeCheckStatus.Click += btnGetCyclicBrakeCheckStatus_Click;
        // 
        // sep56
        // 
        sep56.Dock = DockStyle.Top;
        sep56.Location = new Point(5, 28);
        sep56.Name = "sep56";
        sep56.Size = new Size(238, 5);
        sep56.TabIndex = 1;
        // 
        // numGetCyclicBrakeCheckStatusDriveNumber
        // 
        numGetCyclicBrakeCheckStatusDriveNumber.Dock = DockStyle.Top;
        numGetCyclicBrakeCheckStatusDriveNumber.Location = new Point(5, 5);
        numGetCyclicBrakeCheckStatusDriveNumber.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numGetCyclicBrakeCheckStatusDriveNumber.Minimum = new decimal(new int[] { 99999999, 0, 0, int.MinValue });
        numGetCyclicBrakeCheckStatusDriveNumber.Name = "numGetCyclicBrakeCheckStatusDriveNumber";
        numGetCyclicBrakeCheckStatusDriveNumber.Size = new Size(238, 23);
        numGetCyclicBrakeCheckStatusDriveNumber.TabIndex = 0;
        numGetCyclicBrakeCheckStatusDriveNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // pnlSafetyViolationInfo
        // 
        pnlSafetyViolationInfo.BorderStyle = BorderStyle.FixedSingle;
        pnlSafetyViolationInfo.Controls.Add(gridSafetyViolationInfo);
        pnlSafetyViolationInfo.Controls.Add(sep58);
        pnlSafetyViolationInfo.Controls.Add(btnGetSafetyViolationInfo);
        pnlSafetyViolationInfo.Location = new Point(771, 3);
        pnlSafetyViolationInfo.Name = "pnlSafetyViolationInfo";
        pnlSafetyViolationInfo.Padding = new Padding(5);
        pnlSafetyViolationInfo.Size = new Size(250, 312);
        pnlSafetyViolationInfo.TabIndex = 6;
        // 
        // gridSafetyViolationInfo
        // 
        gridSafetyViolationInfo.Dock = DockStyle.Top;
        gridSafetyViolationInfo.HelpVisible = false;
        gridSafetyViolationInfo.Location = new Point(5, 33);
        gridSafetyViolationInfo.Name = "gridSafetyViolationInfo";
        gridSafetyViolationInfo.PropertySort = PropertySort.NoSort;
        gridSafetyViolationInfo.Size = new Size(238, 272);
        gridSafetyViolationInfo.TabIndex = 2;
        gridSafetyViolationInfo.ToolbarVisible = false;
        // 
        // sep58
        // 
        sep58.Dock = DockStyle.Top;
        sep58.Location = new Point(5, 28);
        sep58.Name = "sep58";
        sep58.Size = new Size(238, 5);
        sep58.TabIndex = 1;
        // 
        // btnGetSafetyViolationInfo
        // 
        btnGetSafetyViolationInfo.Dock = DockStyle.Top;
        btnGetSafetyViolationInfo.Location = new Point(5, 5);
        btnGetSafetyViolationInfo.Name = "btnGetSafetyViolationInfo";
        btnGetSafetyViolationInfo.Size = new Size(238, 23);
        btnGetSafetyViolationInfo.TabIndex = 0;
        btnGetSafetyViolationInfo.Text = "Get Safety violation info";
        btnGetSafetyViolationInfo.UseVisualStyleBackColor = true;
        btnGetSafetyViolationInfo.Click += btnGetSafetyViolationInfo_Click;
        // 
        // tabVirtualTime
        // 
        tabVirtualTime.Controls.Add(flowVirtualTime);
        tabVirtualTime.Location = new Point(4, 24);
        tabVirtualTime.Name = "tabVirtualTime";
        tabVirtualTime.Padding = new Padding(3);
        tabVirtualTime.Size = new Size(882, 463);
        tabVirtualTime.TabIndex = 5;
        tabVirtualTime.Text = "Virtual time";
        tabVirtualTime.UseVisualStyleBackColor = true;
        // 
        // flowVirtualTime
        // 
        flowVirtualTime.AutoScroll = true;
        flowVirtualTime.Controls.Add(pnlVirtualTimeResources);
        flowVirtualTime.Controls.Add(pnlVirtualTime);
        flowVirtualTime.Controls.Add(pnlVirtualTimeSpeed);
        flowVirtualTime.Controls.Add(pnlVirtualTimeState);
        flowVirtualTime.Controls.Add(pnlVirtualTimeSlice);
        flowVirtualTime.Controls.Add(pnlRunVirtualTime);
        flowVirtualTime.Dock = DockStyle.Fill;
        flowVirtualTime.FlowDirection = FlowDirection.TopDown;
        flowVirtualTime.Location = new Point(3, 3);
        flowVirtualTime.Name = "flowVirtualTime";
        flowVirtualTime.Size = new Size(876, 457);
        flowVirtualTime.TabIndex = 0;
        // 
        // pnlVirtualTimeResources
        // 
        pnlVirtualTimeResources.BorderStyle = BorderStyle.FixedSingle;
        pnlVirtualTimeResources.Controls.Add(gridVirtualTimeResources);
        pnlVirtualTimeResources.Controls.Add(sep59);
        pnlVirtualTimeResources.Controls.Add(btnGetVirtualTimeResources);
        pnlVirtualTimeResources.Location = new Point(3, 3);
        pnlVirtualTimeResources.Name = "pnlVirtualTimeResources";
        pnlVirtualTimeResources.Padding = new Padding(5);
        pnlVirtualTimeResources.Size = new Size(250, 122);
        pnlVirtualTimeResources.TabIndex = 0;
        // 
        // gridVirtualTimeResources
        // 
        gridVirtualTimeResources.Dock = DockStyle.Top;
        gridVirtualTimeResources.HelpVisible = false;
        gridVirtualTimeResources.Location = new Point(5, 33);
        gridVirtualTimeResources.Name = "gridVirtualTimeResources";
        gridVirtualTimeResources.PropertySort = PropertySort.NoSort;
        gridVirtualTimeResources.Size = new Size(238, 82);
        gridVirtualTimeResources.TabIndex = 2;
        gridVirtualTimeResources.ToolbarVisible = false;
        // 
        // sep59
        // 
        sep59.Dock = DockStyle.Top;
        sep59.Location = new Point(5, 28);
        sep59.Name = "sep59";
        sep59.Size = new Size(238, 5);
        sep59.TabIndex = 1;
        // 
        // btnGetVirtualTimeResources
        // 
        btnGetVirtualTimeResources.Dock = DockStyle.Top;
        btnGetVirtualTimeResources.Location = new Point(5, 5);
        btnGetVirtualTimeResources.Name = "btnGetVirtualTimeResources";
        btnGetVirtualTimeResources.Size = new Size(238, 23);
        btnGetVirtualTimeResources.TabIndex = 0;
        btnGetVirtualTimeResources.Text = "Get Virtual time resources";
        btnGetVirtualTimeResources.UseVisualStyleBackColor = true;
        btnGetVirtualTimeResources.Click += btnGetVirtualTimeResources_Click;
        // 
        // pnlVirtualTime
        // 
        pnlVirtualTime.BorderStyle = BorderStyle.FixedSingle;
        pnlVirtualTime.Controls.Add(txtVirtualTime);
        pnlVirtualTime.Controls.Add(sep60);
        pnlVirtualTime.Controls.Add(btnGetVirtualTime);
        pnlVirtualTime.Location = new Point(3, 131);
        pnlVirtualTime.Name = "pnlVirtualTime";
        pnlVirtualTime.Padding = new Padding(5);
        pnlVirtualTime.Size = new Size(250, 63);
        pnlVirtualTime.TabIndex = 1;
        // 
        // txtVirtualTime
        // 
        txtVirtualTime.Dock = DockStyle.Top;
        txtVirtualTime.Location = new Point(5, 33);
        txtVirtualTime.Name = "txtVirtualTime";
        txtVirtualTime.PlaceholderText = "virtual time";
        txtVirtualTime.ReadOnly = true;
        txtVirtualTime.Size = new Size(238, 23);
        txtVirtualTime.TabIndex = 2;
        // 
        // sep60
        // 
        sep60.Dock = DockStyle.Top;
        sep60.Location = new Point(5, 28);
        sep60.Name = "sep60";
        sep60.Size = new Size(238, 5);
        sep60.TabIndex = 1;
        // 
        // btnGetVirtualTime
        // 
        btnGetVirtualTime.Dock = DockStyle.Top;
        btnGetVirtualTime.Location = new Point(5, 5);
        btnGetVirtualTime.Name = "btnGetVirtualTime";
        btnGetVirtualTime.Size = new Size(238, 23);
        btnGetVirtualTime.TabIndex = 0;
        btnGetVirtualTime.Text = "Get Virtual time";
        btnGetVirtualTime.UseVisualStyleBackColor = true;
        btnGetVirtualTime.Click += btnGetVirtualTime_Click;
        // 
        // pnlVirtualTimeSpeed
        // 
        pnlVirtualTimeSpeed.BorderStyle = BorderStyle.FixedSingle;
        pnlVirtualTimeSpeed.Controls.Add(btnSetVirtualTimeSpeed);
        pnlVirtualTimeSpeed.Controls.Add(sep62);
        pnlVirtualTimeSpeed.Controls.Add(numSetVirtualTimeSpeedSpeed);
        pnlVirtualTimeSpeed.Controls.Add(sep61);
        pnlVirtualTimeSpeed.Controls.Add(btnGetVirtualTimeSpeed);
        pnlVirtualTimeSpeed.Location = new Point(3, 200);
        pnlVirtualTimeSpeed.Name = "pnlVirtualTimeSpeed";
        pnlVirtualTimeSpeed.Padding = new Padding(5);
        pnlVirtualTimeSpeed.Size = new Size(250, 91);
        pnlVirtualTimeSpeed.TabIndex = 2;
        // 
        // btnSetVirtualTimeSpeed
        // 
        btnSetVirtualTimeSpeed.Dock = DockStyle.Top;
        btnSetVirtualTimeSpeed.Location = new Point(5, 61);
        btnSetVirtualTimeSpeed.Name = "btnSetVirtualTimeSpeed";
        btnSetVirtualTimeSpeed.Size = new Size(238, 23);
        btnSetVirtualTimeSpeed.TabIndex = 4;
        btnSetVirtualTimeSpeed.Text = "Set Virtual time speed";
        btnSetVirtualTimeSpeed.UseVisualStyleBackColor = true;
        btnSetVirtualTimeSpeed.Click += btnSetVirtualTimeSpeed_Click;
        // 
        // sep62
        // 
        sep62.Dock = DockStyle.Top;
        sep62.Location = new Point(5, 56);
        sep62.Name = "sep62";
        sep62.Size = new Size(238, 5);
        sep62.TabIndex = 3;
        // 
        // numSetVirtualTimeSpeedSpeed
        // 
        numSetVirtualTimeSpeedSpeed.Dock = DockStyle.Top;
        numSetVirtualTimeSpeedSpeed.Location = new Point(5, 33);
        numSetVirtualTimeSpeedSpeed.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numSetVirtualTimeSpeedSpeed.Minimum = new decimal(new int[] { 99999999, 0, 0, int.MinValue });
        numSetVirtualTimeSpeedSpeed.Name = "numSetVirtualTimeSpeedSpeed";
        numSetVirtualTimeSpeedSpeed.Size = new Size(238, 23);
        numSetVirtualTimeSpeedSpeed.TabIndex = 2;
        numSetVirtualTimeSpeedSpeed.Value = new decimal(new int[] { 100, 0, 0, 0 });
        // 
        // sep61
        // 
        sep61.Dock = DockStyle.Top;
        sep61.Location = new Point(5, 28);
        sep61.Name = "sep61";
        sep61.Size = new Size(238, 5);
        sep61.TabIndex = 1;
        // 
        // btnGetVirtualTimeSpeed
        // 
        btnGetVirtualTimeSpeed.Dock = DockStyle.Top;
        btnGetVirtualTimeSpeed.Location = new Point(5, 5);
        btnGetVirtualTimeSpeed.Name = "btnGetVirtualTimeSpeed";
        btnGetVirtualTimeSpeed.Size = new Size(238, 23);
        btnGetVirtualTimeSpeed.TabIndex = 0;
        btnGetVirtualTimeSpeed.Text = "Get Virtual time speed";
        btnGetVirtualTimeSpeed.UseVisualStyleBackColor = true;
        btnGetVirtualTimeSpeed.Click += btnGetVirtualTimeSpeed_Click;
        // 
        // pnlVirtualTimeState
        // 
        pnlVirtualTimeState.BorderStyle = BorderStyle.FixedSingle;
        pnlVirtualTimeState.Controls.Add(btnSetVirtualTimeState);
        pnlVirtualTimeState.Controls.Add(sep64);
        pnlVirtualTimeState.Controls.Add(cboSetVirtualTimeStateState);
        pnlVirtualTimeState.Controls.Add(sep63);
        pnlVirtualTimeState.Controls.Add(btnGetVirtualTimeState);
        pnlVirtualTimeState.Location = new Point(3, 297);
        pnlVirtualTimeState.Name = "pnlVirtualTimeState";
        pnlVirtualTimeState.Padding = new Padding(5);
        pnlVirtualTimeState.Size = new Size(250, 91);
        pnlVirtualTimeState.TabIndex = 3;
        // 
        // btnSetVirtualTimeState
        // 
        btnSetVirtualTimeState.Dock = DockStyle.Top;
        btnSetVirtualTimeState.Location = new Point(5, 61);
        btnSetVirtualTimeState.Name = "btnSetVirtualTimeState";
        btnSetVirtualTimeState.Size = new Size(238, 23);
        btnSetVirtualTimeState.TabIndex = 4;
        btnSetVirtualTimeState.Text = "Set Virtual time state";
        btnSetVirtualTimeState.UseVisualStyleBackColor = true;
        btnSetVirtualTimeState.Click += btnSetVirtualTimeState_Click;
        // 
        // sep64
        // 
        sep64.Dock = DockStyle.Top;
        sep64.Location = new Point(5, 56);
        sep64.Name = "sep64";
        sep64.Size = new Size(238, 5);
        sep64.TabIndex = 3;
        // 
        // cboSetVirtualTimeStateState
        // 
        cboSetVirtualTimeStateState.Dock = DockStyle.Top;
        cboSetVirtualTimeStateState.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSetVirtualTimeStateState.FormattingEnabled = true;
        cboSetVirtualTimeStateState.Location = new Point(5, 33);
        cboSetVirtualTimeStateState.Name = "cboSetVirtualTimeStateState";
        cboSetVirtualTimeStateState.Size = new Size(238, 23);
        cboSetVirtualTimeStateState.TabIndex = 2;
        // 
        // sep63
        // 
        sep63.Dock = DockStyle.Top;
        sep63.Location = new Point(5, 28);
        sep63.Name = "sep63";
        sep63.Size = new Size(238, 5);
        sep63.TabIndex = 1;
        // 
        // btnGetVirtualTimeState
        // 
        btnGetVirtualTimeState.Dock = DockStyle.Top;
        btnGetVirtualTimeState.Location = new Point(5, 5);
        btnGetVirtualTimeState.Name = "btnGetVirtualTimeState";
        btnGetVirtualTimeState.Size = new Size(238, 23);
        btnGetVirtualTimeState.TabIndex = 0;
        btnGetVirtualTimeState.Text = "Get Virtual time state";
        btnGetVirtualTimeState.UseVisualStyleBackColor = true;
        btnGetVirtualTimeState.Click += btnGetVirtualTimeState_Click;
        // 
        // pnlVirtualTimeSlice
        // 
        pnlVirtualTimeSlice.BorderStyle = BorderStyle.FixedSingle;
        pnlVirtualTimeSlice.Controls.Add(btnSetVirtualTimeSlice);
        pnlVirtualTimeSlice.Controls.Add(sep66);
        pnlVirtualTimeSlice.Controls.Add(numSetVirtualTimeSliceMilliseconds);
        pnlVirtualTimeSlice.Controls.Add(sep65);
        pnlVirtualTimeSlice.Controls.Add(btnGetVirtualTimeSlice);
        pnlVirtualTimeSlice.Location = new Point(259, 3);
        pnlVirtualTimeSlice.Name = "pnlVirtualTimeSlice";
        pnlVirtualTimeSlice.Padding = new Padding(5);
        pnlVirtualTimeSlice.Size = new Size(250, 91);
        pnlVirtualTimeSlice.TabIndex = 4;
        // 
        // btnSetVirtualTimeSlice
        // 
        btnSetVirtualTimeSlice.Dock = DockStyle.Top;
        btnSetVirtualTimeSlice.Location = new Point(5, 61);
        btnSetVirtualTimeSlice.Name = "btnSetVirtualTimeSlice";
        btnSetVirtualTimeSlice.Size = new Size(238, 23);
        btnSetVirtualTimeSlice.TabIndex = 4;
        btnSetVirtualTimeSlice.Text = "Set Virtual time slice";
        btnSetVirtualTimeSlice.UseVisualStyleBackColor = true;
        btnSetVirtualTimeSlice.Click += btnSetVirtualTimeSlice_Click;
        // 
        // sep66
        // 
        sep66.Dock = DockStyle.Top;
        sep66.Location = new Point(5, 56);
        sep66.Name = "sep66";
        sep66.Size = new Size(238, 5);
        sep66.TabIndex = 3;
        // 
        // numSetVirtualTimeSliceMilliseconds
        // 
        numSetVirtualTimeSliceMilliseconds.Dock = DockStyle.Top;
        numSetVirtualTimeSliceMilliseconds.Location = new Point(5, 33);
        numSetVirtualTimeSliceMilliseconds.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numSetVirtualTimeSliceMilliseconds.Minimum = new decimal(new int[] { 99999999, 0, 0, int.MinValue });
        numSetVirtualTimeSliceMilliseconds.Name = "numSetVirtualTimeSliceMilliseconds";
        numSetVirtualTimeSliceMilliseconds.Size = new Size(238, 23);
        numSetVirtualTimeSliceMilliseconds.TabIndex = 2;
        numSetVirtualTimeSliceMilliseconds.Value = new decimal(new int[] { 20, 0, 0, 0 });
        // 
        // sep65
        // 
        sep65.Dock = DockStyle.Top;
        sep65.Location = new Point(5, 28);
        sep65.Name = "sep65";
        sep65.Size = new Size(238, 5);
        sep65.TabIndex = 1;
        // 
        // btnGetVirtualTimeSlice
        // 
        btnGetVirtualTimeSlice.Dock = DockStyle.Top;
        btnGetVirtualTimeSlice.Location = new Point(5, 5);
        btnGetVirtualTimeSlice.Name = "btnGetVirtualTimeSlice";
        btnGetVirtualTimeSlice.Size = new Size(238, 23);
        btnGetVirtualTimeSlice.TabIndex = 0;
        btnGetVirtualTimeSlice.Text = "Get Virtual time slice";
        btnGetVirtualTimeSlice.UseVisualStyleBackColor = true;
        btnGetVirtualTimeSlice.Click += btnGetVirtualTimeSlice_Click;
        // 
        // pnlRunVirtualTime
        // 
        pnlRunVirtualTime.BorderStyle = BorderStyle.FixedSingle;
        pnlRunVirtualTime.Controls.Add(btnRunVirtualTime);
        pnlRunVirtualTime.Location = new Point(259, 100);
        pnlRunVirtualTime.Name = "pnlRunVirtualTime";
        pnlRunVirtualTime.Padding = new Padding(5);
        pnlRunVirtualTime.Size = new Size(250, 35);
        pnlRunVirtualTime.TabIndex = 5;
        // 
        // btnRunVirtualTime
        // 
        btnRunVirtualTime.Dock = DockStyle.Top;
        btnRunVirtualTime.Location = new Point(5, 5);
        btnRunVirtualTime.Name = "btnRunVirtualTime";
        btnRunVirtualTime.Size = new Size(238, 23);
        btnRunVirtualTime.TabIndex = 0;
        btnRunVirtualTime.Text = "Run Virtual time";
        btnRunVirtualTime.UseVisualStyleBackColor = true;
        btnRunVirtualTime.Click += btnRunVirtualTime_Click;
        // 
        // RwsControllerControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tabControl);
        Margin = new Padding(4, 3, 4, 3);
        Name = "RwsControllerControl";
        Size = new Size(890, 491);
        tabControl.ResumeLayout(false);
        tabGeneral.ResumeLayout(false);
        flowGeneral.ResumeLayout(false);
        pnlControllerInfo.ResumeLayout(false);
        pnlEnvironmentVariable.ResumeLayout(false);
        pnlEnvironmentVariable.PerformLayout();
        pnlInstalledSystems.ResumeLayout(false);
        pnlOption.ResumeLayout(false);
        pnlOption.PerformLayout();
        pnlCompatibility.ResumeLayout(false);
        pnlCompatibility.PerformLayout();
        pnlLanguage.ResumeLayout(false);
        pnlLanguage.PerformLayout();
        pnlRestart.ResumeLayout(false);
        tabIdentity.ResumeLayout(false);
        flowIdentity.ResumeLayout(false);
        pnlIdentity.ResumeLayout(false);
        pnlIdentity.PerformLayout();
        pnlNetwork.ResumeLayout(false);
        pnlNetwork.PerformLayout();
        tabClock.ResumeLayout(false);
        flowClock.ResumeLayout(false);
        pnlClock.ResumeLayout(false);
        pnlTimeZone.ResumeLayout(false);
        pnlTimeZone.PerformLayout();
        pnlTimeServer.ResumeLayout(false);
        pnlTimeServer.PerformLayout();
        tabBackup.ResumeLayout(false);
        flowBackup.ResumeLayout(false);
        pnlBackupResources.ResumeLayout(false);
        pnlBackupInfo.ResumeLayout(false);
        pnlBackupInfo.PerformLayout();
        pnlBackupState.ResumeLayout(false);
        pnlBackupState.PerformLayout();
        pnlCreateBackup.ResumeLayout(false);
        pnlCreateBackup.PerformLayout();
        pnlRestoreBackup.ResumeLayout(false);
        pnlRestoreBackup.PerformLayout();
        pnlCheckRestore.ResumeLayout(false);
        pnlCheckRestore.PerformLayout();
        tabSafety.ResumeLayout(false);
        flowSafety.ResumeLayout(false);
        pnlSafetyResources.ResumeLayout(false);
        pnlSafetyMode.ResumeLayout(false);
        pnlSafetyConfiguration.ResumeLayout(false);
        pnlSafetyConfiguration.PerformLayout();
        pnlInvalidateSafetyConfiguration.ResumeLayout(false);
        pnlSafetyLoadOperationStatus.ResumeLayout(false);
        pnlSafetyLoadOperationStatus.PerformLayout();
        pnlCyclicBrakeCheckStatus.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numGetCyclicBrakeCheckStatusDriveNumber).EndInit();
        pnlSafetyViolationInfo.ResumeLayout(false);
        tabVirtualTime.ResumeLayout(false);
        flowVirtualTime.ResumeLayout(false);
        pnlVirtualTimeResources.ResumeLayout(false);
        pnlVirtualTime.ResumeLayout(false);
        pnlVirtualTime.PerformLayout();
        pnlVirtualTimeSpeed.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numSetVirtualTimeSpeedSpeed).EndInit();
        pnlVirtualTimeState.ResumeLayout(false);
        pnlVirtualTimeSlice.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numSetVirtualTimeSliceMilliseconds).EndInit();
        pnlRunVirtualTime.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private TabControl tabControl;

    private TabPage tabGeneral;
    private FlowLayoutPanel flowGeneral;

    private Panel pnlControllerInfo;
    private Button btnGetControllerInfo;
    private Panel sep1;
    private PropertyGrid gridControllerInfo;

    private Panel pnlEnvironmentVariable;
    private TextBox txtEnvironmentVariableName;
    private Panel sep2;
    private Button btnGetEnvironmentVariable;
    private Panel sep3;
    private TextBox txtEnvironmentVariableValue;

    private Panel pnlInstalledSystems;
    private Button btnGetInstalledSystems;
    private Panel sep4;
    private PropertyGrid gridInstalledSystems;

    private Panel pnlOption;
    private TextBox txtHasOptionOption;
    private Panel sep5;
    private Button btnHasOption;
    private Panel sep6;
    private CheckBox chkHasOptionResult;

    private Panel pnlCompatibility;
    private TextBox txtIsRobotWareVersionCompatibleRobotWareVersion;
    private Panel sep7;
    private Button btnIsRobotWareVersionCompatible;
    private Panel sep8;
    private CheckBox chkIsRobotWareVersionCompatibleResult;

    private Panel pnlLanguage;
    private TextBox txtSetLanguageLanguage;
    private Panel sep9;
    private Button btnSetLanguage;

    private Panel pnlRestart;
    private ComboBox cboRestartMode;
    private Panel sep10;
    private CheckBox chkRestartUseImplicitMastership;
    private Panel sep11;
    private Button btnRestart;

    private TabPage tabIdentity;
    private FlowLayoutPanel flowIdentity;

    private Panel pnlIdentity;
    private Button btnGetIdentity;
    private Panel sep12;
    private PropertyGrid gridIdentity;
    private Panel sep13;
    private TextBox txtSetIdentityName;
    private Panel sep14;
    private TextBox txtSetIdentityId;
    private Panel sep15;
    private Button btnSetIdentity;

    private Panel pnlNetwork;
    private Button btnGetNetworkInterfaces;
    private Panel sep16;
    private PropertyGrid gridNetworkInterfaces;
    private Panel sep17;
    private ComboBox cboSetNetworkConfigurationMethod;
    private Panel sep18;
    private TextBox txtSetNetworkConfigurationAddress;
    private Panel sep19;
    private TextBox txtSetNetworkConfigurationMask;
    private Panel sep20;
    private TextBox txtSetNetworkConfigurationGateway;
    private Panel sep21;
    private Button btnSetNetworkConfiguration;

    private TabPage tabClock;
    private FlowLayoutPanel flowClock;

    private Panel pnlClock;
    private Button btnGetClock;
    private Panel sep22;
    private DateTimePicker dtpClock;
    private Panel sep23;
    private Button btnSetClock;

    private Panel pnlTimeZone;
    private Button btnGetTimeZone;
    private Panel sep24;
    private TextBox txtTimeZone;
    private Panel sep25;
    private Button btnSetTimeZone;

    private Panel pnlTimeServer;
    private TextBox txtGetTimeServerServerIp;
    private Panel sep26;
    private Button btnGetTimeServer;
    private Panel sep27;
    private PropertyGrid gridTimeServer;
    private Panel sep28;
    private TextBox txtSetTimeServerTimeServer;
    private Panel sep29;
    private Button btnSetTimeServer;

    private TabPage tabBackup;
    private FlowLayoutPanel flowBackup;

    private Panel pnlBackupResources;
    private Button btnGetBackupResources;
    private Panel sep30;
    private PropertyGrid gridBackupResources;

    private Panel pnlBackupInfo;
    private TextBox txtGetBackupInfoBackupPath;
    private Panel sep31;
    private Button btnGetBackupInfo;
    private Panel sep32;
    private PropertyGrid gridBackupInfo;

    private Panel pnlBackupState;
    private Button btnGetBackupState;
    private Panel sep33;
    private TextBox txtBackupState;

    private Panel pnlCreateBackup;
    private TextBox txtCreateBackupBackupPath;
    private Panel sep34;
    private CheckBox chkCreateBackupArchive;
    private Panel sep35;
    private Button btnCreateBackup;

    private Panel pnlRestoreBackup;
    private TextBox txtRestoreBackupBackupPath;
    private Panel sep36;
    private ComboBox cboRestoreBackupIgnore;
    private Panel sep37;
    private ComboBox cboRestoreBackupInclude;
    private Panel sep38;
    private CheckBox chkRestoreBackupDeleteDirectory;
    private Panel sep39;
    private CheckBox chkRestoreBackupIncludeControllerSettings;
    private Panel sep40;
    private CheckBox chkRestoreBackupIncludeSafetySettings;
    private Panel sep41;
    private Button btnRestoreBackup;

    private Panel pnlCheckRestore;
    private TextBox txtCheckRestoreBackupPath;
    private Panel sep42;
    private ComboBox cboCheckRestoreIgnore;
    private Panel sep43;
    private ComboBox cboCheckRestoreInclude;
    private Panel sep44;
    private CheckBox chkCheckRestoreIncludeControllerSettings;
    private Panel sep45;
    private CheckBox chkCheckRestoreIncludeSafetySettings;
    private Panel sep46;
    private Button btnCheckRestore;
    private Panel sep47;
    private PropertyGrid gridCheckRestore;

    private TabPage tabSafety;
    private FlowLayoutPanel flowSafety;

    private Panel pnlSafetyResources;
    private Button btnGetSafetyResources;
    private Panel sep48;
    private PropertyGrid gridSafetyResources;

    private Panel pnlSafetyMode;
    private Button btnGetSafetyMode;
    private Panel sep49;
    private PropertyGrid gridSafetyMode;
    private Panel sep50;
    private ComboBox cboSetSafetyModeMode;
    private Panel sep51;
    private Button btnSetSafetyMode;

    private Panel pnlSafetyConfiguration;
    private Button btnGetSafetyConfiguration;
    private Panel sep52;
    private PropertyGrid gridSafetyConfiguration;
    private Panel sep53;
    private TextBox txtLoadSafetyConfigurationFilePath;
    private Panel sep54;
    private Button btnLoadSafetyConfiguration;

    private Panel pnlInvalidateSafetyConfiguration;
    private Button btnInvalidateSafetyConfiguration;

    private Panel pnlSafetyLoadOperationStatus;
    private Button btnGetSafetyLoadOperationStatus;
    private Panel sep55;
    private TextBox txtSafetyLoadOperationStatus;

    private Panel pnlCyclicBrakeCheckStatus;
    private NumericUpDown numGetCyclicBrakeCheckStatusDriveNumber;
    private Panel sep56;
    private Button btnGetCyclicBrakeCheckStatus;
    private Panel sep57;
    private PropertyGrid gridCyclicBrakeCheckStatus;

    private Panel pnlSafetyViolationInfo;
    private Button btnGetSafetyViolationInfo;
    private Panel sep58;
    private PropertyGrid gridSafetyViolationInfo;

    private TabPage tabVirtualTime;
    private FlowLayoutPanel flowVirtualTime;

    private Panel pnlVirtualTimeResources;
    private Button btnGetVirtualTimeResources;
    private Panel sep59;
    private PropertyGrid gridVirtualTimeResources;

    private Panel pnlVirtualTime;
    private Button btnGetVirtualTime;
    private Panel sep60;
    private TextBox txtVirtualTime;

    private Panel pnlVirtualTimeSpeed;
    private Button btnGetVirtualTimeSpeed;
    private Panel sep61;
    private NumericUpDown numSetVirtualTimeSpeedSpeed;
    private Panel sep62;
    private Button btnSetVirtualTimeSpeed;

    private Panel pnlVirtualTimeState;
    private Button btnGetVirtualTimeState;
    private Panel sep63;
    private ComboBox cboSetVirtualTimeStateState;
    private Panel sep64;
    private Button btnSetVirtualTimeState;

    private Panel pnlVirtualTimeSlice;
    private Button btnGetVirtualTimeSlice;
    private Panel sep65;
    private NumericUpDown numSetVirtualTimeSliceMilliseconds;
    private Panel sep66;
    private Button btnSetVirtualTimeSlice;

    private Panel pnlRunVirtualTime;
    private Button btnRunVirtualTime;
}
