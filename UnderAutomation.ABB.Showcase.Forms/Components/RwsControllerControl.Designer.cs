
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RwsControllerControl));
        lstFolderImageList = new ImageList(components);
        dlgOpen = new OpenFileDialog();
        dlgSave = new SaveFileDialog();
        flowLayoutPanel1 = new FlowLayoutPanel();
        pnlControllerInfo = new Panel();
        btnGetControllerInfo = new Button();
        sep1 = new Panel();
        gridControllerInfo = new PropertyGrid();
        pnlEnvironmentVariable = new Panel();
        txtEnvironmentVariableName = new TextBox();
        sep2 = new Panel();
        btnGetEnvironmentVariable = new Button();
        sep3 = new Panel();
        txtEnvironmentVariableValue = new TextBox();
        pnlClock = new Panel();
        btnGetClock = new Button();
        sep4 = new Panel();
        dtpClock = new DateTimePicker();
        sep5 = new Panel();
        btnSetClock = new Button();
        pnlTimeZone = new Panel();
        btnGetTimeZone = new Button();
        sep6 = new Panel();
        txtTimeZone = new TextBox();
        sep7 = new Panel();
        btnSetTimeZone = new Button();
        pnlTimeServer = new Panel();
        txtGetTimeServerServerIp = new TextBox();
        sep8 = new Panel();
        btnGetTimeServer = new Button();
        sep9 = new Panel();
        gridTimeServer = new PropertyGrid();
        sep10 = new Panel();
        txtSetTimeServerTimeServer = new TextBox();
        sep11 = new Panel();
        btnSetTimeServer = new Button();
        pnlIdentity = new Panel();
        btnGetIdentity = new Button();
        sep12 = new Panel();
        gridIdentity = new PropertyGrid();
        sep13 = new Panel();
        txtSetIdentityName = new TextBox();
        sep14 = new Panel();
        txtSetIdentityId = new TextBox();
        sep15 = new Panel();
        btnSetIdentity = new Button();
        pnlLanguage = new Panel();
        txtSetLanguageLanguage = new TextBox();
        sep16 = new Panel();
        btnSetLanguage = new Button();
        pnlNetwork = new Panel();
        btnGetNetworkInterfaces = new Button();
        sep17 = new Panel();
        gridNetworkInterfaces = new PropertyGrid();
        sep18 = new Panel();
        cboSetNetworkConfigurationMethod = new ComboBox();
        sep19 = new Panel();
        txtSetNetworkConfigurationAddress = new TextBox();
        sep20 = new Panel();
        txtSetNetworkConfigurationMask = new TextBox();
        sep21 = new Panel();
        txtSetNetworkConfigurationGateway = new TextBox();
        sep22 = new Panel();
        btnSetNetworkConfiguration = new Button();
        pnlRestart = new Panel();
        cboRestartMode = new ComboBox();
        sep23 = new Panel();
        chkRestartUseImplicitMastership = new CheckBox();
        sep24 = new Panel();
        btnRestart = new Button();
        pnlInstalledSystems = new Panel();
        btnGetInstalledSystems = new Button();
        sep25 = new Panel();
        gridInstalledSystems = new PropertyGrid();
        pnlOption = new Panel();
        txtHasOptionOption = new TextBox();
        sep26 = new Panel();
        btnHasOption = new Button();
        sep27 = new Panel();
        chkHasOptionResult = new CheckBox();
        pnlCompatibility = new Panel();
        txtIsRobotWareVersionCompatibleRobotWareVersion = new TextBox();
        sep28 = new Panel();
        btnIsRobotWareVersionCompatible = new Button();
        sep29 = new Panel();
        chkIsRobotWareVersionCompatibleResult = new CheckBox();
        pnlBackupResources = new Panel();
        btnGetBackupResources = new Button();
        sep30 = new Panel();
        gridBackupResources = new PropertyGrid();
        pnlBackupInfo = new Panel();
        txtGetBackupInfoBackupPath = new TextBox();
        sep31 = new Panel();
        btnGetBackupInfo = new Button();
        sep32 = new Panel();
        gridBackupInfo = new PropertyGrid();
        pnlBackupState = new Panel();
        btnGetBackupState = new Button();
        sep33 = new Panel();
        txtBackupState = new TextBox();
        pnlCreateBackup = new Panel();
        txtCreateBackupBackupPath = new TextBox();
        sep34 = new Panel();
        chkCreateBackupArchive = new CheckBox();
        sep35 = new Panel();
        btnCreateBackup = new Button();
        pnlRestoreBackup = new Panel();
        txtRestoreBackupBackupPath = new TextBox();
        sep36 = new Panel();
        cboRestoreBackupIgnore = new ComboBox();
        sep37 = new Panel();
        cboRestoreBackupInclude = new ComboBox();
        sep38 = new Panel();
        chkRestoreBackupDeleteDirectory = new CheckBox();
        sep39 = new Panel();
        chkRestoreBackupIncludeControllerSettings = new CheckBox();
        sep40 = new Panel();
        chkRestoreBackupIncludeSafetySettings = new CheckBox();
        sep41 = new Panel();
        btnRestoreBackup = new Button();
        pnlCheckRestore = new Panel();
        txtCheckRestoreBackupPath = new TextBox();
        sep42 = new Panel();
        cboCheckRestoreIgnore = new ComboBox();
        sep43 = new Panel();
        cboCheckRestoreInclude = new ComboBox();
        sep44 = new Panel();
        chkCheckRestoreIncludeControllerSettings = new CheckBox();
        sep45 = new Panel();
        chkCheckRestoreIncludeSafetySettings = new CheckBox();
        sep46 = new Panel();
        btnCheckRestore = new Button();
        sep47 = new Panel();
        gridCheckRestore = new PropertyGrid();
        pnlSafetyResources = new Panel();
        btnGetSafetyResources = new Button();
        sep48 = new Panel();
        gridSafetyResources = new PropertyGrid();
        pnlSafetyMode = new Panel();
        btnGetSafetyMode = new Button();
        sep49 = new Panel();
        gridSafetyMode = new PropertyGrid();
        sep50 = new Panel();
        cboSetSafetyModeMode = new ComboBox();
        sep51 = new Panel();
        btnSetSafetyMode = new Button();
        pnlSafetyConfiguration = new Panel();
        btnGetSafetyConfiguration = new Button();
        sep52 = new Panel();
        gridSafetyConfiguration = new PropertyGrid();
        sep53 = new Panel();
        txtLoadSafetyConfigurationFilePath = new TextBox();
        sep54 = new Panel();
        btnLoadSafetyConfiguration = new Button();
        pnlInvalidateSafetyConfiguration = new Panel();
        btnInvalidateSafetyConfiguration = new Button();
        pnlSafetyLoadOperationStatus = new Panel();
        btnGetSafetyLoadOperationStatus = new Button();
        sep55 = new Panel();
        txtSafetyLoadOperationStatus = new TextBox();
        pnlCyclicBrakeCheckStatus = new Panel();
        numGetCyclicBrakeCheckStatusDriveNumber = new NumericUpDown();
        sep56 = new Panel();
        btnGetCyclicBrakeCheckStatus = new Button();
        sep57 = new Panel();
        gridCyclicBrakeCheckStatus = new PropertyGrid();
        pnlSafetyViolationInfo = new Panel();
        btnGetSafetyViolationInfo = new Button();
        sep58 = new Panel();
        gridSafetyViolationInfo = new PropertyGrid();
        pnlVirtualTimeResources = new Panel();
        btnGetVirtualTimeResources = new Button();
        sep59 = new Panel();
        gridVirtualTimeResources = new PropertyGrid();
        pnlVirtualTime = new Panel();
        btnGetVirtualTime = new Button();
        sep60 = new Panel();
        txtVirtualTime = new TextBox();
        pnlVirtualTimeSpeed = new Panel();
        btnGetVirtualTimeSpeed = new Button();
        sep61 = new Panel();
        numSetVirtualTimeSpeedSpeed = new NumericUpDown();
        sep62 = new Panel();
        btnSetVirtualTimeSpeed = new Button();
        pnlVirtualTimeState = new Panel();
        btnGetVirtualTimeState = new Button();
        sep63 = new Panel();
        cboSetVirtualTimeStateState = new ComboBox();
        sep64 = new Panel();
        btnSetVirtualTimeState = new Button();
        pnlVirtualTimeSlice = new Panel();
        btnGetVirtualTimeSlice = new Button();
        sep65 = new Panel();
        numSetVirtualTimeSliceMilliseconds = new NumericUpDown();
        sep66 = new Panel();
        btnSetVirtualTimeSlice = new Button();
        pnlRunVirtualTime = new Panel();
        btnRunVirtualTime = new Button();
        flowLayoutPanel1.SuspendLayout();
        pnlControllerInfo.SuspendLayout();
        pnlEnvironmentVariable.SuspendLayout();
        pnlClock.SuspendLayout();
        pnlTimeZone.SuspendLayout();
        pnlTimeServer.SuspendLayout();
        pnlIdentity.SuspendLayout();
        pnlLanguage.SuspendLayout();
        pnlNetwork.SuspendLayout();
        pnlRestart.SuspendLayout();
        pnlInstalledSystems.SuspendLayout();
        pnlOption.SuspendLayout();
        pnlCompatibility.SuspendLayout();
        pnlBackupResources.SuspendLayout();
        pnlBackupInfo.SuspendLayout();
        pnlBackupState.SuspendLayout();
        pnlCreateBackup.SuspendLayout();
        pnlRestoreBackup.SuspendLayout();
        pnlCheckRestore.SuspendLayout();
        pnlSafetyResources.SuspendLayout();
        pnlSafetyMode.SuspendLayout();
        pnlSafetyConfiguration.SuspendLayout();
        pnlInvalidateSafetyConfiguration.SuspendLayout();
        pnlSafetyLoadOperationStatus.SuspendLayout();
        pnlCyclicBrakeCheckStatus.SuspendLayout();
        pnlSafetyViolationInfo.SuspendLayout();
        pnlVirtualTimeResources.SuspendLayout();
        pnlVirtualTime.SuspendLayout();
        pnlVirtualTimeSpeed.SuspendLayout();
        pnlVirtualTimeState.SuspendLayout();
        pnlVirtualTimeSlice.SuspendLayout();
        pnlRunVirtualTime.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numGetCyclicBrakeCheckStatusDriveNumber).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numSetVirtualTimeSpeedSpeed).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numSetVirtualTimeSliceMilliseconds).BeginInit();
        SuspendLayout();
        //
        // lstFolderImageList
        //
        lstFolderImageList.ColorDepth = ColorDepth.Depth8Bit;
        lstFolderImageList.ImageStream = (ImageListStreamer)resources.GetObject("lstFolderImageList.ImageStream");
        lstFolderImageList.TransparentColor = Color.Transparent;
        lstFolderImageList.Images.SetKeyName(0, "folder");
        lstFolderImageList.Images.SetKeyName(1, "file");
        lstFolderImageList.Images.SetKeyName(2, "symbolicLink");
        //
        // dlgOpen
        //
        dlgOpen.Filter = "All files|*.*";
        dlgOpen.Title = "Select file to upload";
        //
        // dlgSave
        //
        dlgSave.Filter = "All files|*.*";
        dlgSave.RestoreDirectory = true;
        dlgSave.Title = "Download file";
        //
        // flowLayoutPanel1
        //
        flowLayoutPanel1.Controls.Add(pnlControllerInfo);
        flowLayoutPanel1.Controls.Add(pnlEnvironmentVariable);
        flowLayoutPanel1.Controls.Add(pnlClock);
        flowLayoutPanel1.Controls.Add(pnlTimeZone);
        flowLayoutPanel1.Controls.Add(pnlTimeServer);
        flowLayoutPanel1.Controls.Add(pnlIdentity);
        flowLayoutPanel1.Controls.Add(pnlLanguage);
        flowLayoutPanel1.Controls.Add(pnlNetwork);
        flowLayoutPanel1.Controls.Add(pnlRestart);
        flowLayoutPanel1.Controls.Add(pnlInstalledSystems);
        flowLayoutPanel1.Controls.Add(pnlOption);
        flowLayoutPanel1.Controls.Add(pnlCompatibility);
        flowLayoutPanel1.Controls.Add(pnlBackupResources);
        flowLayoutPanel1.Controls.Add(pnlBackupInfo);
        flowLayoutPanel1.Controls.Add(pnlBackupState);
        flowLayoutPanel1.Controls.Add(pnlCreateBackup);
        flowLayoutPanel1.Controls.Add(pnlRestoreBackup);
        flowLayoutPanel1.Controls.Add(pnlCheckRestore);
        flowLayoutPanel1.Controls.Add(pnlSafetyResources);
        flowLayoutPanel1.Controls.Add(pnlSafetyMode);
        flowLayoutPanel1.Controls.Add(pnlSafetyConfiguration);
        flowLayoutPanel1.Controls.Add(pnlInvalidateSafetyConfiguration);
        flowLayoutPanel1.Controls.Add(pnlSafetyLoadOperationStatus);
        flowLayoutPanel1.Controls.Add(pnlCyclicBrakeCheckStatus);
        flowLayoutPanel1.Controls.Add(pnlSafetyViolationInfo);
        flowLayoutPanel1.Controls.Add(pnlVirtualTimeResources);
        flowLayoutPanel1.Controls.Add(pnlVirtualTime);
        flowLayoutPanel1.Controls.Add(pnlVirtualTimeSpeed);
        flowLayoutPanel1.Controls.Add(pnlVirtualTimeState);
        flowLayoutPanel1.Controls.Add(pnlVirtualTimeSlice);
        flowLayoutPanel1.Controls.Add(pnlRunVirtualTime);
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.Dock = DockStyle.Fill;
        flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        flowLayoutPanel1.Location = new Point(0, 0);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(890, 491);
        flowLayoutPanel1.TabIndex = 0;
        // 
        // pnlControllerInfo
        // 
        pnlControllerInfo.BorderStyle = BorderStyle.FixedSingle;
        pnlControllerInfo.Controls.Add(gridControllerInfo);
        pnlControllerInfo.Controls.Add(sep1);
        pnlControllerInfo.Controls.Add(btnGetControllerInfo);
        pnlControllerInfo.Name = "pnlControllerInfo";
        pnlControllerInfo.Padding = new Padding(5);
        pnlControllerInfo.Size = new Size(250, 350);
        pnlControllerInfo.TabIndex = 0;
        // 
        // btnGetControllerInfo
        // 
        btnGetControllerInfo.Dock = DockStyle.Top;
        btnGetControllerInfo.Name = "btnGetControllerInfo";
        btnGetControllerInfo.Size = new Size(238, 23);
        btnGetControllerInfo.TabIndex = 0;
        btnGetControllerInfo.Text = "Get Controller Info";
        btnGetControllerInfo.UseVisualStyleBackColor = true;
        btnGetControllerInfo.Click += btnGetControllerInfo_Click;
        // 
        // sep1
        // 
        sep1.Dock = DockStyle.Top;
        sep1.Name = "sep1";
        sep1.Size = new Size(238, 5);
        sep1.TabIndex = 1;
        // 
        // gridControllerInfo
        // 
        gridControllerInfo.Dock = DockStyle.Fill;
        gridControllerInfo.HelpVisible = false;
        gridControllerInfo.Name = "gridControllerInfo";
        gridControllerInfo.PropertySort = PropertySort.NoSort;
        gridControllerInfo.Size = new Size(238, 120);
        gridControllerInfo.TabIndex = 2;
        gridControllerInfo.ToolbarVisible = false;
        // 
        // pnlEnvironmentVariable
        // 
        pnlEnvironmentVariable.BorderStyle = BorderStyle.FixedSingle;
        pnlEnvironmentVariable.Controls.Add(txtEnvironmentVariableValue);
        pnlEnvironmentVariable.Controls.Add(sep3);
        pnlEnvironmentVariable.Controls.Add(btnGetEnvironmentVariable);
        pnlEnvironmentVariable.Controls.Add(sep2);
        pnlEnvironmentVariable.Controls.Add(txtEnvironmentVariableName);
        pnlEnvironmentVariable.Name = "pnlEnvironmentVariable";
        pnlEnvironmentVariable.Padding = new Padding(5);
        pnlEnvironmentVariable.Size = new Size(250, 94);
        pnlEnvironmentVariable.TabIndex = 0;
        // 
        // txtEnvironmentVariableName
        // 
        txtEnvironmentVariableName.Dock = DockStyle.Top;
        txtEnvironmentVariableName.Name = "txtEnvironmentVariableName";
        txtEnvironmentVariableName.Size = new Size(238, 23);
        txtEnvironmentVariableName.TabIndex = 0;
        txtEnvironmentVariableName.PlaceholderText = "name";
        txtEnvironmentVariableName.Text = "$temp";
        // 
        // sep2
        // 
        sep2.Dock = DockStyle.Top;
        sep2.Name = "sep2";
        sep2.Size = new Size(238, 5);
        sep2.TabIndex = 1;
        // 
        // btnGetEnvironmentVariable
        // 
        btnGetEnvironmentVariable.Dock = DockStyle.Top;
        btnGetEnvironmentVariable.Name = "btnGetEnvironmentVariable";
        btnGetEnvironmentVariable.Size = new Size(238, 23);
        btnGetEnvironmentVariable.TabIndex = 2;
        btnGetEnvironmentVariable.Text = "Get Environment variable";
        btnGetEnvironmentVariable.UseVisualStyleBackColor = true;
        btnGetEnvironmentVariable.Click += btnGetEnvironmentVariable_Click;
        // 
        // sep3
        // 
        sep3.Dock = DockStyle.Top;
        sep3.Name = "sep3";
        sep3.Size = new Size(238, 5);
        sep3.TabIndex = 3;
        // 
        // txtEnvironmentVariableValue
        // 
        txtEnvironmentVariableValue.Dock = DockStyle.Top;
        txtEnvironmentVariableValue.Name = "txtEnvironmentVariableValue";
        txtEnvironmentVariableValue.ReadOnly = true;
        txtEnvironmentVariableValue.Size = new Size(238, 23);
        txtEnvironmentVariableValue.TabIndex = 4;
        txtEnvironmentVariableValue.PlaceholderText = "value";
        // 
        // pnlClock
        // 
        pnlClock.BorderStyle = BorderStyle.FixedSingle;
        pnlClock.Controls.Add(btnSetClock);
        pnlClock.Controls.Add(sep5);
        pnlClock.Controls.Add(dtpClock);
        pnlClock.Controls.Add(sep4);
        pnlClock.Controls.Add(btnGetClock);
        pnlClock.Name = "pnlClock";
        pnlClock.Padding = new Padding(5);
        pnlClock.Size = new Size(250, 91);
        pnlClock.TabIndex = 0;
        // 
        // btnGetClock
        // 
        btnGetClock.Dock = DockStyle.Top;
        btnGetClock.Name = "btnGetClock";
        btnGetClock.Size = new Size(238, 23);
        btnGetClock.TabIndex = 0;
        btnGetClock.Text = "Get Clock";
        btnGetClock.UseVisualStyleBackColor = true;
        btnGetClock.Click += btnGetClock_Click;
        // 
        // sep4
        // 
        sep4.Dock = DockStyle.Top;
        sep4.Name = "sep4";
        sep4.Size = new Size(238, 5);
        sep4.TabIndex = 1;
        // 
        // dtpClock
        // 
        dtpClock.Dock = DockStyle.Top;
        dtpClock.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        dtpClock.Format = DateTimePickerFormat.Custom;
        dtpClock.Name = "dtpClock";
        dtpClock.Size = new Size(238, 23);
        dtpClock.TabIndex = 2;
        // 
        // sep5
        // 
        sep5.Dock = DockStyle.Top;
        sep5.Name = "sep5";
        sep5.Size = new Size(238, 5);
        sep5.TabIndex = 3;
        // 
        // btnSetClock
        // 
        btnSetClock.Dock = DockStyle.Top;
        btnSetClock.Name = "btnSetClock";
        btnSetClock.Size = new Size(238, 23);
        btnSetClock.TabIndex = 4;
        btnSetClock.Text = "Set Clock";
        btnSetClock.UseVisualStyleBackColor = true;
        btnSetClock.Click += btnSetClock_Click;
        // 
        // pnlTimeZone
        // 
        pnlTimeZone.BorderStyle = BorderStyle.FixedSingle;
        pnlTimeZone.Controls.Add(btnSetTimeZone);
        pnlTimeZone.Controls.Add(sep7);
        pnlTimeZone.Controls.Add(txtTimeZone);
        pnlTimeZone.Controls.Add(sep6);
        pnlTimeZone.Controls.Add(btnGetTimeZone);
        pnlTimeZone.Name = "pnlTimeZone";
        pnlTimeZone.Padding = new Padding(5);
        pnlTimeZone.Size = new Size(250, 91);
        pnlTimeZone.TabIndex = 0;
        // 
        // btnGetTimeZone
        // 
        btnGetTimeZone.Dock = DockStyle.Top;
        btnGetTimeZone.Name = "btnGetTimeZone";
        btnGetTimeZone.Size = new Size(238, 23);
        btnGetTimeZone.TabIndex = 0;
        btnGetTimeZone.Text = "Get Time zone";
        btnGetTimeZone.UseVisualStyleBackColor = true;
        btnGetTimeZone.Click += btnGetTimeZone_Click;
        // 
        // sep6
        // 
        sep6.Dock = DockStyle.Top;
        sep6.Name = "sep6";
        sep6.Size = new Size(238, 5);
        sep6.TabIndex = 1;
        // 
        // txtTimeZone
        // 
        txtTimeZone.Dock = DockStyle.Top;
        txtTimeZone.Name = "txtTimeZone";
        txtTimeZone.Size = new Size(238, 23);
        txtTimeZone.TabIndex = 2;
        txtTimeZone.PlaceholderText = "timeZone";
        txtTimeZone.Text = "Europe/Stockholm";
        // 
        // sep7
        // 
        sep7.Dock = DockStyle.Top;
        sep7.Name = "sep7";
        sep7.Size = new Size(238, 5);
        sep7.TabIndex = 3;
        // 
        // btnSetTimeZone
        // 
        btnSetTimeZone.Dock = DockStyle.Top;
        btnSetTimeZone.Name = "btnSetTimeZone";
        btnSetTimeZone.Size = new Size(238, 23);
        btnSetTimeZone.TabIndex = 4;
        btnSetTimeZone.Text = "Set Time zone";
        btnSetTimeZone.UseVisualStyleBackColor = true;
        btnSetTimeZone.Click += btnSetTimeZone_Click;
        // 
        // pnlTimeServer
        // 
        pnlTimeServer.BorderStyle = BorderStyle.FixedSingle;
        pnlTimeServer.Controls.Add(btnSetTimeServer);
        pnlTimeServer.Controls.Add(sep11);
        pnlTimeServer.Controls.Add(txtSetTimeServerTimeServer);
        pnlTimeServer.Controls.Add(sep10);
        pnlTimeServer.Controls.Add(gridTimeServer);
        pnlTimeServer.Controls.Add(sep9);
        pnlTimeServer.Controls.Add(btnGetTimeServer);
        pnlTimeServer.Controls.Add(sep8);
        pnlTimeServer.Controls.Add(txtGetTimeServerServerIp);
        pnlTimeServer.Name = "pnlTimeServer";
        pnlTimeServer.Padding = new Padding(5);
        pnlTimeServer.Size = new Size(250, 244);
        pnlTimeServer.TabIndex = 0;
        // 
        // txtGetTimeServerServerIp
        // 
        txtGetTimeServerServerIp.Dock = DockStyle.Top;
        txtGetTimeServerServerIp.Name = "txtGetTimeServerServerIp";
        txtGetTimeServerServerIp.Size = new Size(238, 23);
        txtGetTimeServerServerIp.TabIndex = 0;
        txtGetTimeServerServerIp.PlaceholderText = "serverIp (optional, v2 only)";
        // 
        // sep8
        // 
        sep8.Dock = DockStyle.Top;
        sep8.Name = "sep8";
        sep8.Size = new Size(238, 5);
        sep8.TabIndex = 1;
        // 
        // btnGetTimeServer
        // 
        btnGetTimeServer.Dock = DockStyle.Top;
        btnGetTimeServer.Name = "btnGetTimeServer";
        btnGetTimeServer.Size = new Size(238, 23);
        btnGetTimeServer.TabIndex = 2;
        btnGetTimeServer.Text = "Get Time server";
        btnGetTimeServer.UseVisualStyleBackColor = true;
        btnGetTimeServer.Click += btnGetTimeServer_Click;
        // 
        // sep9
        // 
        sep9.Dock = DockStyle.Top;
        sep9.Name = "sep9";
        sep9.Size = new Size(238, 5);
        sep9.TabIndex = 3;
        // 
        // gridTimeServer
        // 
        gridTimeServer.Dock = DockStyle.Top;
        gridTimeServer.HelpVisible = false;
        gridTimeServer.Name = "gridTimeServer";
        gridTimeServer.PropertySort = PropertySort.NoSort;
        gridTimeServer.Size = new Size(238, 120);
        gridTimeServer.TabIndex = 4;
        gridTimeServer.ToolbarVisible = false;
        // 
        // sep10
        // 
        sep10.Dock = DockStyle.Top;
        sep10.Name = "sep10";
        sep10.Size = new Size(238, 5);
        sep10.TabIndex = 5;
        // 
        // txtSetTimeServerTimeServer
        // 
        txtSetTimeServerTimeServer.Dock = DockStyle.Top;
        txtSetTimeServerTimeServer.Name = "txtSetTimeServerTimeServer";
        txtSetTimeServerTimeServer.Size = new Size(238, 23);
        txtSetTimeServerTimeServer.TabIndex = 6;
        txtSetTimeServerTimeServer.PlaceholderText = "timeServer";
        txtSetTimeServerTimeServer.Text = "132.163.4.101";
        // 
        // sep11
        // 
        sep11.Dock = DockStyle.Top;
        sep11.Name = "sep11";
        sep11.Size = new Size(238, 5);
        sep11.TabIndex = 7;
        // 
        // btnSetTimeServer
        // 
        btnSetTimeServer.Dock = DockStyle.Top;
        btnSetTimeServer.Name = "btnSetTimeServer";
        btnSetTimeServer.Size = new Size(238, 23);
        btnSetTimeServer.TabIndex = 8;
        btnSetTimeServer.Text = "Set Time server";
        btnSetTimeServer.UseVisualStyleBackColor = true;
        btnSetTimeServer.Click += btnSetTimeServer_Click;
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
        pnlIdentity.Name = "pnlIdentity";
        pnlIdentity.Padding = new Padding(5);
        pnlIdentity.Size = new Size(250, 244);
        pnlIdentity.TabIndex = 0;
        // 
        // btnGetIdentity
        // 
        btnGetIdentity.Dock = DockStyle.Top;
        btnGetIdentity.Name = "btnGetIdentity";
        btnGetIdentity.Size = new Size(238, 23);
        btnGetIdentity.TabIndex = 0;
        btnGetIdentity.Text = "Get Identity";
        btnGetIdentity.UseVisualStyleBackColor = true;
        btnGetIdentity.Click += btnGetIdentity_Click;
        // 
        // sep12
        // 
        sep12.Dock = DockStyle.Top;
        sep12.Name = "sep12";
        sep12.Size = new Size(238, 5);
        sep12.TabIndex = 1;
        // 
        // gridIdentity
        // 
        gridIdentity.Dock = DockStyle.Top;
        gridIdentity.HelpVisible = false;
        gridIdentity.Name = "gridIdentity";
        gridIdentity.PropertySort = PropertySort.NoSort;
        gridIdentity.Size = new Size(238, 120);
        gridIdentity.TabIndex = 2;
        gridIdentity.ToolbarVisible = false;
        // 
        // sep13
        // 
        sep13.Dock = DockStyle.Top;
        sep13.Name = "sep13";
        sep13.Size = new Size(238, 5);
        sep13.TabIndex = 3;
        // 
        // txtSetIdentityName
        // 
        txtSetIdentityName.Dock = DockStyle.Top;
        txtSetIdentityName.Name = "txtSetIdentityName";
        txtSetIdentityName.Size = new Size(238, 23);
        txtSetIdentityName.TabIndex = 4;
        txtSetIdentityName.PlaceholderText = "name";
        // 
        // sep14
        // 
        sep14.Dock = DockStyle.Top;
        sep14.Name = "sep14";
        sep14.Size = new Size(238, 5);
        sep14.TabIndex = 5;
        // 
        // txtSetIdentityId
        // 
        txtSetIdentityId.Dock = DockStyle.Top;
        txtSetIdentityId.Name = "txtSetIdentityId";
        txtSetIdentityId.Size = new Size(238, 23);
        txtSetIdentityId.TabIndex = 6;
        txtSetIdentityId.PlaceholderText = "id (optional)";
        // 
        // sep15
        // 
        sep15.Dock = DockStyle.Top;
        sep15.Name = "sep15";
        sep15.Size = new Size(238, 5);
        sep15.TabIndex = 7;
        // 
        // btnSetIdentity
        // 
        btnSetIdentity.Dock = DockStyle.Top;
        btnSetIdentity.Name = "btnSetIdentity";
        btnSetIdentity.Size = new Size(238, 23);
        btnSetIdentity.TabIndex = 8;
        btnSetIdentity.Text = "Set Identity";
        btnSetIdentity.UseVisualStyleBackColor = true;
        btnSetIdentity.Click += btnSetIdentity_Click;
        // 
        // pnlLanguage
        // 
        pnlLanguage.BorderStyle = BorderStyle.FixedSingle;
        pnlLanguage.Controls.Add(btnSetLanguage);
        pnlLanguage.Controls.Add(sep16);
        pnlLanguage.Controls.Add(txtSetLanguageLanguage);
        pnlLanguage.Name = "pnlLanguage";
        pnlLanguage.Padding = new Padding(5);
        pnlLanguage.Size = new Size(250, 63);
        pnlLanguage.TabIndex = 0;
        // 
        // txtSetLanguageLanguage
        // 
        txtSetLanguageLanguage.Dock = DockStyle.Top;
        txtSetLanguageLanguage.Name = "txtSetLanguageLanguage";
        txtSetLanguageLanguage.Size = new Size(238, 23);
        txtSetLanguageLanguage.TabIndex = 0;
        txtSetLanguageLanguage.PlaceholderText = "language";
        txtSetLanguageLanguage.Text = "en";
        // 
        // sep16
        // 
        sep16.Dock = DockStyle.Top;
        sep16.Name = "sep16";
        sep16.Size = new Size(238, 5);
        sep16.TabIndex = 1;
        // 
        // btnSetLanguage
        // 
        btnSetLanguage.Dock = DockStyle.Top;
        btnSetLanguage.Name = "btnSetLanguage";
        btnSetLanguage.Size = new Size(238, 23);
        btnSetLanguage.TabIndex = 2;
        btnSetLanguage.Text = "Set Language";
        btnSetLanguage.UseVisualStyleBackColor = true;
        btnSetLanguage.Click += btnSetLanguage_Click;
        // 
        // pnlNetwork
        // 
        pnlNetwork.BorderStyle = BorderStyle.FixedSingle;
        pnlNetwork.Controls.Add(btnSetNetworkConfiguration);
        pnlNetwork.Controls.Add(sep22);
        pnlNetwork.Controls.Add(txtSetNetworkConfigurationGateway);
        pnlNetwork.Controls.Add(sep21);
        pnlNetwork.Controls.Add(txtSetNetworkConfigurationMask);
        pnlNetwork.Controls.Add(sep20);
        pnlNetwork.Controls.Add(txtSetNetworkConfigurationAddress);
        pnlNetwork.Controls.Add(sep19);
        pnlNetwork.Controls.Add(cboSetNetworkConfigurationMethod);
        pnlNetwork.Controls.Add(sep18);
        pnlNetwork.Controls.Add(gridNetworkInterfaces);
        pnlNetwork.Controls.Add(sep17);
        pnlNetwork.Controls.Add(btnGetNetworkInterfaces);
        pnlNetwork.Name = "pnlNetwork";
        pnlNetwork.Padding = new Padding(5);
        pnlNetwork.Size = new Size(250, 300);
        pnlNetwork.TabIndex = 0;
        // 
        // btnGetNetworkInterfaces
        // 
        btnGetNetworkInterfaces.Dock = DockStyle.Top;
        btnGetNetworkInterfaces.Name = "btnGetNetworkInterfaces";
        btnGetNetworkInterfaces.Size = new Size(238, 23);
        btnGetNetworkInterfaces.TabIndex = 0;
        btnGetNetworkInterfaces.Text = "Get Network interfaces";
        btnGetNetworkInterfaces.UseVisualStyleBackColor = true;
        btnGetNetworkInterfaces.Click += btnGetNetworkInterfaces_Click;
        // 
        // sep17
        // 
        sep17.Dock = DockStyle.Top;
        sep17.Name = "sep17";
        sep17.Size = new Size(238, 5);
        sep17.TabIndex = 1;
        // 
        // gridNetworkInterfaces
        // 
        gridNetworkInterfaces.Dock = DockStyle.Top;
        gridNetworkInterfaces.HelpVisible = false;
        gridNetworkInterfaces.Name = "gridNetworkInterfaces";
        gridNetworkInterfaces.PropertySort = PropertySort.NoSort;
        gridNetworkInterfaces.Size = new Size(238, 120);
        gridNetworkInterfaces.TabIndex = 2;
        gridNetworkInterfaces.ToolbarVisible = false;
        // 
        // sep18
        // 
        sep18.Dock = DockStyle.Top;
        sep18.Name = "sep18";
        sep18.Size = new Size(238, 5);
        sep18.TabIndex = 3;
        // 
        // cboSetNetworkConfigurationMethod
        // 
        cboSetNetworkConfigurationMethod.Dock = DockStyle.Top;
        cboSetNetworkConfigurationMethod.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSetNetworkConfigurationMethod.FormattingEnabled = true;
        cboSetNetworkConfigurationMethod.Name = "cboSetNetworkConfigurationMethod";
        cboSetNetworkConfigurationMethod.Size = new Size(238, 23);
        cboSetNetworkConfigurationMethod.TabIndex = 4;
        // 
        // sep19
        // 
        sep19.Dock = DockStyle.Top;
        sep19.Name = "sep19";
        sep19.Size = new Size(238, 5);
        sep19.TabIndex = 5;
        // 
        // txtSetNetworkConfigurationAddress
        // 
        txtSetNetworkConfigurationAddress.Dock = DockStyle.Top;
        txtSetNetworkConfigurationAddress.Name = "txtSetNetworkConfigurationAddress";
        txtSetNetworkConfigurationAddress.Size = new Size(238, 23);
        txtSetNetworkConfigurationAddress.TabIndex = 6;
        txtSetNetworkConfigurationAddress.PlaceholderText = "address";
        // 
        // sep20
        // 
        sep20.Dock = DockStyle.Top;
        sep20.Name = "sep20";
        sep20.Size = new Size(238, 5);
        sep20.TabIndex = 7;
        // 
        // txtSetNetworkConfigurationMask
        // 
        txtSetNetworkConfigurationMask.Dock = DockStyle.Top;
        txtSetNetworkConfigurationMask.Name = "txtSetNetworkConfigurationMask";
        txtSetNetworkConfigurationMask.Size = new Size(238, 23);
        txtSetNetworkConfigurationMask.TabIndex = 8;
        txtSetNetworkConfigurationMask.PlaceholderText = "mask";
        // 
        // sep21
        // 
        sep21.Dock = DockStyle.Top;
        sep21.Name = "sep21";
        sep21.Size = new Size(238, 5);
        sep21.TabIndex = 9;
        // 
        // txtSetNetworkConfigurationGateway
        // 
        txtSetNetworkConfigurationGateway.Dock = DockStyle.Top;
        txtSetNetworkConfigurationGateway.Name = "txtSetNetworkConfigurationGateway";
        txtSetNetworkConfigurationGateway.Size = new Size(238, 23);
        txtSetNetworkConfigurationGateway.TabIndex = 10;
        txtSetNetworkConfigurationGateway.PlaceholderText = "gateway";
        // 
        // sep22
        // 
        sep22.Dock = DockStyle.Top;
        sep22.Name = "sep22";
        sep22.Size = new Size(238, 5);
        sep22.TabIndex = 11;
        // 
        // btnSetNetworkConfiguration
        // 
        btnSetNetworkConfiguration.Dock = DockStyle.Top;
        btnSetNetworkConfiguration.Name = "btnSetNetworkConfiguration";
        btnSetNetworkConfiguration.Size = new Size(238, 23);
        btnSetNetworkConfiguration.TabIndex = 12;
        btnSetNetworkConfiguration.Text = "Set Network configuration";
        btnSetNetworkConfiguration.UseVisualStyleBackColor = true;
        btnSetNetworkConfiguration.Click += btnSetNetworkConfiguration_Click;
        // 
        // pnlRestart
        // 
        pnlRestart.BorderStyle = BorderStyle.FixedSingle;
        pnlRestart.Controls.Add(btnRestart);
        pnlRestart.Controls.Add(sep24);
        pnlRestart.Controls.Add(chkRestartUseImplicitMastership);
        pnlRestart.Controls.Add(sep23);
        pnlRestart.Controls.Add(cboRestartMode);
        pnlRestart.Name = "pnlRestart";
        pnlRestart.Padding = new Padding(5);
        pnlRestart.Size = new Size(250, 91);
        pnlRestart.TabIndex = 0;
        // 
        // cboRestartMode
        // 
        cboRestartMode.Dock = DockStyle.Top;
        cboRestartMode.DropDownStyle = ComboBoxStyle.DropDownList;
        cboRestartMode.FormattingEnabled = true;
        cboRestartMode.Name = "cboRestartMode";
        cboRestartMode.Size = new Size(238, 23);
        cboRestartMode.TabIndex = 0;
        // 
        // sep23
        // 
        sep23.Dock = DockStyle.Top;
        sep23.Name = "sep23";
        sep23.Size = new Size(238, 5);
        sep23.TabIndex = 1;
        // 
        // chkRestartUseImplicitMastership
        // 
        chkRestartUseImplicitMastership.Dock = DockStyle.Top;
        chkRestartUseImplicitMastership.Checked = true;
        chkRestartUseImplicitMastership.CheckState = CheckState.Checked;
        chkRestartUseImplicitMastership.Name = "chkRestartUseImplicitMastership";
        chkRestartUseImplicitMastership.Size = new Size(238, 23);
        chkRestartUseImplicitMastership.TabIndex = 2;
        chkRestartUseImplicitMastership.Text = "Use implicit mastership";
        chkRestartUseImplicitMastership.UseVisualStyleBackColor = true;
        // 
        // sep24
        // 
        sep24.Dock = DockStyle.Top;
        sep24.Name = "sep24";
        sep24.Size = new Size(238, 5);
        sep24.TabIndex = 3;
        // 
        // btnRestart
        // 
        btnRestart.Dock = DockStyle.Top;
        btnRestart.Name = "btnRestart";
        btnRestart.Size = new Size(238, 23);
        btnRestart.TabIndex = 4;
        btnRestart.Text = "Restart";
        btnRestart.UseVisualStyleBackColor = true;
        btnRestart.Click += btnRestart_Click;
        // 
        // pnlInstalledSystems
        // 
        pnlInstalledSystems.BorderStyle = BorderStyle.FixedSingle;
        pnlInstalledSystems.Controls.Add(gridInstalledSystems);
        pnlInstalledSystems.Controls.Add(sep25);
        pnlInstalledSystems.Controls.Add(btnGetInstalledSystems);
        pnlInstalledSystems.Name = "pnlInstalledSystems";
        pnlInstalledSystems.Padding = new Padding(5);
        pnlInstalledSystems.Size = new Size(250, 200);
        pnlInstalledSystems.TabIndex = 0;
        // 
        // btnGetInstalledSystems
        // 
        btnGetInstalledSystems.Dock = DockStyle.Top;
        btnGetInstalledSystems.Name = "btnGetInstalledSystems";
        btnGetInstalledSystems.Size = new Size(238, 23);
        btnGetInstalledSystems.TabIndex = 0;
        btnGetInstalledSystems.Text = "Get Installed systems";
        btnGetInstalledSystems.UseVisualStyleBackColor = true;
        btnGetInstalledSystems.Click += btnGetInstalledSystems_Click;
        // 
        // sep25
        // 
        sep25.Dock = DockStyle.Top;
        sep25.Name = "sep25";
        sep25.Size = new Size(238, 5);
        sep25.TabIndex = 1;
        // 
        // gridInstalledSystems
        // 
        gridInstalledSystems.Dock = DockStyle.Fill;
        gridInstalledSystems.HelpVisible = false;
        gridInstalledSystems.Name = "gridInstalledSystems";
        gridInstalledSystems.PropertySort = PropertySort.NoSort;
        gridInstalledSystems.Size = new Size(238, 120);
        gridInstalledSystems.TabIndex = 2;
        gridInstalledSystems.ToolbarVisible = false;
        // 
        // pnlOption
        // 
        pnlOption.BorderStyle = BorderStyle.FixedSingle;
        pnlOption.Controls.Add(chkHasOptionResult);
        pnlOption.Controls.Add(sep27);
        pnlOption.Controls.Add(btnHasOption);
        pnlOption.Controls.Add(sep26);
        pnlOption.Controls.Add(txtHasOptionOption);
        pnlOption.Name = "pnlOption";
        pnlOption.Padding = new Padding(5);
        pnlOption.Size = new Size(250, 91);
        pnlOption.TabIndex = 0;
        // 
        // txtHasOptionOption
        // 
        txtHasOptionOption.Dock = DockStyle.Top;
        txtHasOptionOption.Name = "txtHasOptionOption";
        txtHasOptionOption.Size = new Size(238, 23);
        txtHasOptionOption.TabIndex = 0;
        txtHasOptionOption.PlaceholderText = "option";
        txtHasOptionOption.Text = "SAFEMOVEPRO";
        // 
        // sep26
        // 
        sep26.Dock = DockStyle.Top;
        sep26.Name = "sep26";
        sep26.Size = new Size(238, 5);
        sep26.TabIndex = 1;
        // 
        // btnHasOption
        // 
        btnHasOption.Dock = DockStyle.Top;
        btnHasOption.Name = "btnHasOption";
        btnHasOption.Size = new Size(238, 23);
        btnHasOption.TabIndex = 2;
        btnHasOption.Text = "Has Option";
        btnHasOption.UseVisualStyleBackColor = true;
        btnHasOption.Click += btnHasOption_Click;
        // 
        // sep27
        // 
        sep27.Dock = DockStyle.Top;
        sep27.Name = "sep27";
        sep27.Size = new Size(238, 5);
        sep27.TabIndex = 3;
        // 
        // chkHasOptionResult
        // 
        chkHasOptionResult.Dock = DockStyle.Top;
        chkHasOptionResult.AutoCheck = false;
        chkHasOptionResult.Name = "chkHasOptionResult";
        chkHasOptionResult.Size = new Size(238, 23);
        chkHasOptionResult.TabIndex = 4;
        chkHasOptionResult.Text = "Option installed";
        chkHasOptionResult.UseVisualStyleBackColor = true;
        // 
        // pnlCompatibility
        // 
        pnlCompatibility.BorderStyle = BorderStyle.FixedSingle;
        pnlCompatibility.Controls.Add(chkIsRobotWareVersionCompatibleResult);
        pnlCompatibility.Controls.Add(sep29);
        pnlCompatibility.Controls.Add(btnIsRobotWareVersionCompatible);
        pnlCompatibility.Controls.Add(sep28);
        pnlCompatibility.Controls.Add(txtIsRobotWareVersionCompatibleRobotWareVersion);
        pnlCompatibility.Name = "pnlCompatibility";
        pnlCompatibility.Padding = new Padding(5);
        pnlCompatibility.Size = new Size(250, 91);
        pnlCompatibility.TabIndex = 0;
        // 
        // txtIsRobotWareVersionCompatibleRobotWareVersion
        // 
        txtIsRobotWareVersionCompatibleRobotWareVersion.Dock = DockStyle.Top;
        txtIsRobotWareVersionCompatibleRobotWareVersion.Name = "txtIsRobotWareVersionCompatibleRobotWareVersion";
        txtIsRobotWareVersionCompatibleRobotWareVersion.Size = new Size(238, 23);
        txtIsRobotWareVersionCompatibleRobotWareVersion.TabIndex = 0;
        txtIsRobotWareVersionCompatibleRobotWareVersion.PlaceholderText = "robotWareVersion";
        txtIsRobotWareVersionCompatibleRobotWareVersion.Text = "6.03.0101";
        // 
        // sep28
        // 
        sep28.Dock = DockStyle.Top;
        sep28.Name = "sep28";
        sep28.Size = new Size(238, 5);
        sep28.TabIndex = 1;
        // 
        // btnIsRobotWareVersionCompatible
        // 
        btnIsRobotWareVersionCompatible.Dock = DockStyle.Top;
        btnIsRobotWareVersionCompatible.Name = "btnIsRobotWareVersionCompatible";
        btnIsRobotWareVersionCompatible.Size = new Size(238, 23);
        btnIsRobotWareVersionCompatible.TabIndex = 2;
        btnIsRobotWareVersionCompatible.Text = "Is RobotWare version compatible";
        btnIsRobotWareVersionCompatible.UseVisualStyleBackColor = true;
        btnIsRobotWareVersionCompatible.Click += btnIsRobotWareVersionCompatible_Click;
        // 
        // sep29
        // 
        sep29.Dock = DockStyle.Top;
        sep29.Name = "sep29";
        sep29.Size = new Size(238, 5);
        sep29.TabIndex = 3;
        // 
        // chkIsRobotWareVersionCompatibleResult
        // 
        chkIsRobotWareVersionCompatibleResult.Dock = DockStyle.Top;
        chkIsRobotWareVersionCompatibleResult.AutoCheck = false;
        chkIsRobotWareVersionCompatibleResult.Name = "chkIsRobotWareVersionCompatibleResult";
        chkIsRobotWareVersionCompatibleResult.Size = new Size(238, 23);
        chkIsRobotWareVersionCompatibleResult.TabIndex = 4;
        chkIsRobotWareVersionCompatibleResult.Text = "Compatible";
        chkIsRobotWareVersionCompatibleResult.UseVisualStyleBackColor = true;
        // 
        // pnlBackupResources
        // 
        pnlBackupResources.BorderStyle = BorderStyle.FixedSingle;
        pnlBackupResources.Controls.Add(gridBackupResources);
        pnlBackupResources.Controls.Add(sep30);
        pnlBackupResources.Controls.Add(btnGetBackupResources);
        pnlBackupResources.Name = "pnlBackupResources";
        pnlBackupResources.Padding = new Padding(5);
        pnlBackupResources.Size = new Size(250, 200);
        pnlBackupResources.TabIndex = 0;
        // 
        // btnGetBackupResources
        // 
        btnGetBackupResources.Dock = DockStyle.Top;
        btnGetBackupResources.Name = "btnGetBackupResources";
        btnGetBackupResources.Size = new Size(238, 23);
        btnGetBackupResources.TabIndex = 0;
        btnGetBackupResources.Text = "Get Backup resources";
        btnGetBackupResources.UseVisualStyleBackColor = true;
        btnGetBackupResources.Click += btnGetBackupResources_Click;
        // 
        // sep30
        // 
        sep30.Dock = DockStyle.Top;
        sep30.Name = "sep30";
        sep30.Size = new Size(238, 5);
        sep30.TabIndex = 1;
        // 
        // gridBackupResources
        // 
        gridBackupResources.Dock = DockStyle.Fill;
        gridBackupResources.HelpVisible = false;
        gridBackupResources.Name = "gridBackupResources";
        gridBackupResources.PropertySort = PropertySort.NoSort;
        gridBackupResources.Size = new Size(238, 120);
        gridBackupResources.TabIndex = 2;
        gridBackupResources.ToolbarVisible = false;
        // 
        // pnlBackupInfo
        // 
        pnlBackupInfo.BorderStyle = BorderStyle.FixedSingle;
        pnlBackupInfo.Controls.Add(gridBackupInfo);
        pnlBackupInfo.Controls.Add(sep32);
        pnlBackupInfo.Controls.Add(btnGetBackupInfo);
        pnlBackupInfo.Controls.Add(sep31);
        pnlBackupInfo.Controls.Add(txtGetBackupInfoBackupPath);
        pnlBackupInfo.Name = "pnlBackupInfo";
        pnlBackupInfo.Padding = new Padding(5);
        pnlBackupInfo.Size = new Size(250, 250);
        pnlBackupInfo.TabIndex = 0;
        // 
        // txtGetBackupInfoBackupPath
        // 
        txtGetBackupInfoBackupPath.Dock = DockStyle.Top;
        txtGetBackupInfoBackupPath.Name = "txtGetBackupInfoBackupPath";
        txtGetBackupInfoBackupPath.Size = new Size(238, 23);
        txtGetBackupInfoBackupPath.TabIndex = 0;
        txtGetBackupInfoBackupPath.PlaceholderText = "backupPath";
        txtGetBackupInfoBackupPath.Text = "$temp/mybackup";
        // 
        // sep31
        // 
        sep31.Dock = DockStyle.Top;
        sep31.Name = "sep31";
        sep31.Size = new Size(238, 5);
        sep31.TabIndex = 1;
        // 
        // btnGetBackupInfo
        // 
        btnGetBackupInfo.Dock = DockStyle.Top;
        btnGetBackupInfo.Name = "btnGetBackupInfo";
        btnGetBackupInfo.Size = new Size(238, 23);
        btnGetBackupInfo.TabIndex = 2;
        btnGetBackupInfo.Text = "Get Backup info";
        btnGetBackupInfo.UseVisualStyleBackColor = true;
        btnGetBackupInfo.Click += btnGetBackupInfo_Click;
        // 
        // sep32
        // 
        sep32.Dock = DockStyle.Top;
        sep32.Name = "sep32";
        sep32.Size = new Size(238, 5);
        sep32.TabIndex = 3;
        // 
        // gridBackupInfo
        // 
        gridBackupInfo.Dock = DockStyle.Fill;
        gridBackupInfo.HelpVisible = false;
        gridBackupInfo.Name = "gridBackupInfo";
        gridBackupInfo.PropertySort = PropertySort.NoSort;
        gridBackupInfo.Size = new Size(238, 120);
        gridBackupInfo.TabIndex = 4;
        gridBackupInfo.ToolbarVisible = false;
        // 
        // pnlBackupState
        // 
        pnlBackupState.BorderStyle = BorderStyle.FixedSingle;
        pnlBackupState.Controls.Add(txtBackupState);
        pnlBackupState.Controls.Add(sep33);
        pnlBackupState.Controls.Add(btnGetBackupState);
        pnlBackupState.Name = "pnlBackupState";
        pnlBackupState.Padding = new Padding(5);
        pnlBackupState.Size = new Size(250, 63);
        pnlBackupState.TabIndex = 0;
        // 
        // btnGetBackupState
        // 
        btnGetBackupState.Dock = DockStyle.Top;
        btnGetBackupState.Name = "btnGetBackupState";
        btnGetBackupState.Size = new Size(238, 23);
        btnGetBackupState.TabIndex = 0;
        btnGetBackupState.Text = "Get Backup state";
        btnGetBackupState.UseVisualStyleBackColor = true;
        btnGetBackupState.Click += btnGetBackupState_Click;
        // 
        // sep33
        // 
        sep33.Dock = DockStyle.Top;
        sep33.Name = "sep33";
        sep33.Size = new Size(238, 5);
        sep33.TabIndex = 1;
        // 
        // txtBackupState
        // 
        txtBackupState.Dock = DockStyle.Top;
        txtBackupState.Name = "txtBackupState";
        txtBackupState.ReadOnly = true;
        txtBackupState.Size = new Size(238, 23);
        txtBackupState.TabIndex = 2;
        txtBackupState.PlaceholderText = "backup state";
        // 
        // pnlCreateBackup
        // 
        pnlCreateBackup.BorderStyle = BorderStyle.FixedSingle;
        pnlCreateBackup.Controls.Add(btnCreateBackup);
        pnlCreateBackup.Controls.Add(sep35);
        pnlCreateBackup.Controls.Add(chkCreateBackupArchive);
        pnlCreateBackup.Controls.Add(sep34);
        pnlCreateBackup.Controls.Add(txtCreateBackupBackupPath);
        pnlCreateBackup.Name = "pnlCreateBackup";
        pnlCreateBackup.Padding = new Padding(5);
        pnlCreateBackup.Size = new Size(250, 91);
        pnlCreateBackup.TabIndex = 0;
        // 
        // txtCreateBackupBackupPath
        // 
        txtCreateBackupBackupPath.Dock = DockStyle.Top;
        txtCreateBackupBackupPath.Name = "txtCreateBackupBackupPath";
        txtCreateBackupBackupPath.Size = new Size(238, 23);
        txtCreateBackupBackupPath.TabIndex = 0;
        txtCreateBackupBackupPath.PlaceholderText = "backupPath";
        txtCreateBackupBackupPath.Text = "$temp/mybackup";
        // 
        // sep34
        // 
        sep34.Dock = DockStyle.Top;
        sep34.Name = "sep34";
        sep34.Size = new Size(238, 5);
        sep34.TabIndex = 1;
        // 
        // chkCreateBackupArchive
        // 
        chkCreateBackupArchive.Dock = DockStyle.Top;
        chkCreateBackupArchive.Name = "chkCreateBackupArchive";
        chkCreateBackupArchive.Size = new Size(238, 23);
        chkCreateBackupArchive.TabIndex = 2;
        chkCreateBackupArchive.Text = "Archive";
        chkCreateBackupArchive.UseVisualStyleBackColor = true;
        // 
        // sep35
        // 
        sep35.Dock = DockStyle.Top;
        sep35.Name = "sep35";
        sep35.Size = new Size(238, 5);
        sep35.TabIndex = 3;
        // 
        // btnCreateBackup
        // 
        btnCreateBackup.Dock = DockStyle.Top;
        btnCreateBackup.Name = "btnCreateBackup";
        btnCreateBackup.Size = new Size(238, 23);
        btnCreateBackup.TabIndex = 4;
        btnCreateBackup.Text = "Create Backup";
        btnCreateBackup.UseVisualStyleBackColor = true;
        btnCreateBackup.Click += btnCreateBackup_Click;
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
        pnlRestoreBackup.Name = "pnlRestoreBackup";
        pnlRestoreBackup.Padding = new Padding(5);
        pnlRestoreBackup.Size = new Size(250, 203);
        pnlRestoreBackup.TabIndex = 0;
        // 
        // txtRestoreBackupBackupPath
        // 
        txtRestoreBackupBackupPath.Dock = DockStyle.Top;
        txtRestoreBackupBackupPath.Name = "txtRestoreBackupBackupPath";
        txtRestoreBackupBackupPath.Size = new Size(238, 23);
        txtRestoreBackupBackupPath.TabIndex = 0;
        txtRestoreBackupBackupPath.PlaceholderText = "backupPath";
        txtRestoreBackupBackupPath.Text = "$temp/mybackup";
        // 
        // sep36
        // 
        sep36.Dock = DockStyle.Top;
        sep36.Name = "sep36";
        sep36.Size = new Size(238, 5);
        sep36.TabIndex = 1;
        // 
        // cboRestoreBackupIgnore
        // 
        cboRestoreBackupIgnore.Dock = DockStyle.Top;
        cboRestoreBackupIgnore.DropDownStyle = ComboBoxStyle.DropDownList;
        cboRestoreBackupIgnore.FormattingEnabled = true;
        cboRestoreBackupIgnore.Name = "cboRestoreBackupIgnore";
        cboRestoreBackupIgnore.Size = new Size(238, 23);
        cboRestoreBackupIgnore.TabIndex = 2;
        // 
        // sep37
        // 
        sep37.Dock = DockStyle.Top;
        sep37.Name = "sep37";
        sep37.Size = new Size(238, 5);
        sep37.TabIndex = 3;
        // 
        // cboRestoreBackupInclude
        // 
        cboRestoreBackupInclude.Dock = DockStyle.Top;
        cboRestoreBackupInclude.DropDownStyle = ComboBoxStyle.DropDownList;
        cboRestoreBackupInclude.FormattingEnabled = true;
        cboRestoreBackupInclude.Name = "cboRestoreBackupInclude";
        cboRestoreBackupInclude.Size = new Size(238, 23);
        cboRestoreBackupInclude.TabIndex = 4;
        // 
        // sep38
        // 
        sep38.Dock = DockStyle.Top;
        sep38.Name = "sep38";
        sep38.Size = new Size(238, 5);
        sep38.TabIndex = 5;
        // 
        // chkRestoreBackupDeleteDirectory
        // 
        chkRestoreBackupDeleteDirectory.Dock = DockStyle.Top;
        chkRestoreBackupDeleteDirectory.Checked = true;
        chkRestoreBackupDeleteDirectory.CheckState = CheckState.Checked;
        chkRestoreBackupDeleteDirectory.Name = "chkRestoreBackupDeleteDirectory";
        chkRestoreBackupDeleteDirectory.Size = new Size(238, 23);
        chkRestoreBackupDeleteDirectory.TabIndex = 6;
        chkRestoreBackupDeleteDirectory.Text = "Delete directory";
        chkRestoreBackupDeleteDirectory.UseVisualStyleBackColor = true;
        // 
        // sep39
        // 
        sep39.Dock = DockStyle.Top;
        sep39.Name = "sep39";
        sep39.Size = new Size(238, 5);
        sep39.TabIndex = 7;
        // 
        // chkRestoreBackupIncludeControllerSettings
        // 
        chkRestoreBackupIncludeControllerSettings.Dock = DockStyle.Top;
        chkRestoreBackupIncludeControllerSettings.Checked = true;
        chkRestoreBackupIncludeControllerSettings.CheckState = CheckState.Checked;
        chkRestoreBackupIncludeControllerSettings.Name = "chkRestoreBackupIncludeControllerSettings";
        chkRestoreBackupIncludeControllerSettings.Size = new Size(238, 23);
        chkRestoreBackupIncludeControllerSettings.TabIndex = 8;
        chkRestoreBackupIncludeControllerSettings.Text = "Include controller settings";
        chkRestoreBackupIncludeControllerSettings.UseVisualStyleBackColor = true;
        // 
        // sep40
        // 
        sep40.Dock = DockStyle.Top;
        sep40.Name = "sep40";
        sep40.Size = new Size(238, 5);
        sep40.TabIndex = 9;
        // 
        // chkRestoreBackupIncludeSafetySettings
        // 
        chkRestoreBackupIncludeSafetySettings.Dock = DockStyle.Top;
        chkRestoreBackupIncludeSafetySettings.Checked = true;
        chkRestoreBackupIncludeSafetySettings.CheckState = CheckState.Checked;
        chkRestoreBackupIncludeSafetySettings.Name = "chkRestoreBackupIncludeSafetySettings";
        chkRestoreBackupIncludeSafetySettings.Size = new Size(238, 23);
        chkRestoreBackupIncludeSafetySettings.TabIndex = 10;
        chkRestoreBackupIncludeSafetySettings.Text = "Include safety settings";
        chkRestoreBackupIncludeSafetySettings.UseVisualStyleBackColor = true;
        // 
        // sep41
        // 
        sep41.Dock = DockStyle.Top;
        sep41.Name = "sep41";
        sep41.Size = new Size(238, 5);
        sep41.TabIndex = 11;
        // 
        // btnRestoreBackup
        // 
        btnRestoreBackup.Dock = DockStyle.Top;
        btnRestoreBackup.Name = "btnRestoreBackup";
        btnRestoreBackup.Size = new Size(238, 23);
        btnRestoreBackup.TabIndex = 12;
        btnRestoreBackup.Text = "Restore Backup";
        btnRestoreBackup.UseVisualStyleBackColor = true;
        btnRestoreBackup.Click += btnRestoreBackup_Click;
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
        pnlCheckRestore.Name = "pnlCheckRestore";
        pnlCheckRestore.Padding = new Padding(5);
        pnlCheckRestore.Size = new Size(250, 300);
        pnlCheckRestore.TabIndex = 0;
        // 
        // txtCheckRestoreBackupPath
        // 
        txtCheckRestoreBackupPath.Dock = DockStyle.Top;
        txtCheckRestoreBackupPath.Name = "txtCheckRestoreBackupPath";
        txtCheckRestoreBackupPath.Size = new Size(238, 23);
        txtCheckRestoreBackupPath.TabIndex = 0;
        txtCheckRestoreBackupPath.PlaceholderText = "backupPath";
        txtCheckRestoreBackupPath.Text = "$temp/mybackup";
        // 
        // sep42
        // 
        sep42.Dock = DockStyle.Top;
        sep42.Name = "sep42";
        sep42.Size = new Size(238, 5);
        sep42.TabIndex = 1;
        // 
        // cboCheckRestoreIgnore
        // 
        cboCheckRestoreIgnore.Dock = DockStyle.Top;
        cboCheckRestoreIgnore.DropDownStyle = ComboBoxStyle.DropDownList;
        cboCheckRestoreIgnore.FormattingEnabled = true;
        cboCheckRestoreIgnore.Name = "cboCheckRestoreIgnore";
        cboCheckRestoreIgnore.Size = new Size(238, 23);
        cboCheckRestoreIgnore.TabIndex = 2;
        // 
        // sep43
        // 
        sep43.Dock = DockStyle.Top;
        sep43.Name = "sep43";
        sep43.Size = new Size(238, 5);
        sep43.TabIndex = 3;
        // 
        // cboCheckRestoreInclude
        // 
        cboCheckRestoreInclude.Dock = DockStyle.Top;
        cboCheckRestoreInclude.DropDownStyle = ComboBoxStyle.DropDownList;
        cboCheckRestoreInclude.FormattingEnabled = true;
        cboCheckRestoreInclude.Name = "cboCheckRestoreInclude";
        cboCheckRestoreInclude.Size = new Size(238, 23);
        cboCheckRestoreInclude.TabIndex = 4;
        // 
        // sep44
        // 
        sep44.Dock = DockStyle.Top;
        sep44.Name = "sep44";
        sep44.Size = new Size(238, 5);
        sep44.TabIndex = 5;
        // 
        // chkCheckRestoreIncludeControllerSettings
        // 
        chkCheckRestoreIncludeControllerSettings.Dock = DockStyle.Top;
        chkCheckRestoreIncludeControllerSettings.Checked = true;
        chkCheckRestoreIncludeControllerSettings.CheckState = CheckState.Checked;
        chkCheckRestoreIncludeControllerSettings.Name = "chkCheckRestoreIncludeControllerSettings";
        chkCheckRestoreIncludeControllerSettings.Size = new Size(238, 23);
        chkCheckRestoreIncludeControllerSettings.TabIndex = 6;
        chkCheckRestoreIncludeControllerSettings.Text = "Include controller settings";
        chkCheckRestoreIncludeControllerSettings.UseVisualStyleBackColor = true;
        // 
        // sep45
        // 
        sep45.Dock = DockStyle.Top;
        sep45.Name = "sep45";
        sep45.Size = new Size(238, 5);
        sep45.TabIndex = 7;
        // 
        // chkCheckRestoreIncludeSafetySettings
        // 
        chkCheckRestoreIncludeSafetySettings.Dock = DockStyle.Top;
        chkCheckRestoreIncludeSafetySettings.Checked = true;
        chkCheckRestoreIncludeSafetySettings.CheckState = CheckState.Checked;
        chkCheckRestoreIncludeSafetySettings.Name = "chkCheckRestoreIncludeSafetySettings";
        chkCheckRestoreIncludeSafetySettings.Size = new Size(238, 23);
        chkCheckRestoreIncludeSafetySettings.TabIndex = 8;
        chkCheckRestoreIncludeSafetySettings.Text = "Include safety settings";
        chkCheckRestoreIncludeSafetySettings.UseVisualStyleBackColor = true;
        // 
        // sep46
        // 
        sep46.Dock = DockStyle.Top;
        sep46.Name = "sep46";
        sep46.Size = new Size(238, 5);
        sep46.TabIndex = 9;
        // 
        // btnCheckRestore
        // 
        btnCheckRestore.Dock = DockStyle.Top;
        btnCheckRestore.Name = "btnCheckRestore";
        btnCheckRestore.Size = new Size(238, 23);
        btnCheckRestore.TabIndex = 10;
        btnCheckRestore.Text = "Check Restore";
        btnCheckRestore.UseVisualStyleBackColor = true;
        btnCheckRestore.Click += btnCheckRestore_Click;
        // 
        // sep47
        // 
        sep47.Dock = DockStyle.Top;
        sep47.Name = "sep47";
        sep47.Size = new Size(238, 5);
        sep47.TabIndex = 11;
        // 
        // gridCheckRestore
        // 
        gridCheckRestore.Dock = DockStyle.Fill;
        gridCheckRestore.HelpVisible = false;
        gridCheckRestore.Name = "gridCheckRestore";
        gridCheckRestore.PropertySort = PropertySort.NoSort;
        gridCheckRestore.Size = new Size(238, 120);
        gridCheckRestore.TabIndex = 12;
        gridCheckRestore.ToolbarVisible = false;
        // 
        // pnlSafetyResources
        // 
        pnlSafetyResources.BorderStyle = BorderStyle.FixedSingle;
        pnlSafetyResources.Controls.Add(gridSafetyResources);
        pnlSafetyResources.Controls.Add(sep48);
        pnlSafetyResources.Controls.Add(btnGetSafetyResources);
        pnlSafetyResources.Name = "pnlSafetyResources";
        pnlSafetyResources.Padding = new Padding(5);
        pnlSafetyResources.Size = new Size(250, 200);
        pnlSafetyResources.TabIndex = 0;
        // 
        // btnGetSafetyResources
        // 
        btnGetSafetyResources.Dock = DockStyle.Top;
        btnGetSafetyResources.Name = "btnGetSafetyResources";
        btnGetSafetyResources.Size = new Size(238, 23);
        btnGetSafetyResources.TabIndex = 0;
        btnGetSafetyResources.Text = "Get Safety resources";
        btnGetSafetyResources.UseVisualStyleBackColor = true;
        btnGetSafetyResources.Click += btnGetSafetyResources_Click;
        // 
        // sep48
        // 
        sep48.Dock = DockStyle.Top;
        sep48.Name = "sep48";
        sep48.Size = new Size(238, 5);
        sep48.TabIndex = 1;
        // 
        // gridSafetyResources
        // 
        gridSafetyResources.Dock = DockStyle.Fill;
        gridSafetyResources.HelpVisible = false;
        gridSafetyResources.Name = "gridSafetyResources";
        gridSafetyResources.PropertySort = PropertySort.NoSort;
        gridSafetyResources.Size = new Size(238, 120);
        gridSafetyResources.TabIndex = 2;
        gridSafetyResources.ToolbarVisible = false;
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
        pnlSafetyMode.Name = "pnlSafetyMode";
        pnlSafetyMode.Padding = new Padding(5);
        pnlSafetyMode.Size = new Size(250, 216);
        pnlSafetyMode.TabIndex = 0;
        // 
        // btnGetSafetyMode
        // 
        btnGetSafetyMode.Dock = DockStyle.Top;
        btnGetSafetyMode.Name = "btnGetSafetyMode";
        btnGetSafetyMode.Size = new Size(238, 23);
        btnGetSafetyMode.TabIndex = 0;
        btnGetSafetyMode.Text = "Get Safety mode";
        btnGetSafetyMode.UseVisualStyleBackColor = true;
        btnGetSafetyMode.Click += btnGetSafetyMode_Click;
        // 
        // sep49
        // 
        sep49.Dock = DockStyle.Top;
        sep49.Name = "sep49";
        sep49.Size = new Size(238, 5);
        sep49.TabIndex = 1;
        // 
        // gridSafetyMode
        // 
        gridSafetyMode.Dock = DockStyle.Top;
        gridSafetyMode.HelpVisible = false;
        gridSafetyMode.Name = "gridSafetyMode";
        gridSafetyMode.PropertySort = PropertySort.NoSort;
        gridSafetyMode.Size = new Size(238, 120);
        gridSafetyMode.TabIndex = 2;
        gridSafetyMode.ToolbarVisible = false;
        // 
        // sep50
        // 
        sep50.Dock = DockStyle.Top;
        sep50.Name = "sep50";
        sep50.Size = new Size(238, 5);
        sep50.TabIndex = 3;
        // 
        // cboSetSafetyModeMode
        // 
        cboSetSafetyModeMode.Dock = DockStyle.Top;
        cboSetSafetyModeMode.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSetSafetyModeMode.FormattingEnabled = true;
        cboSetSafetyModeMode.Name = "cboSetSafetyModeMode";
        cboSetSafetyModeMode.Size = new Size(238, 23);
        cboSetSafetyModeMode.TabIndex = 4;
        // 
        // sep51
        // 
        sep51.Dock = DockStyle.Top;
        sep51.Name = "sep51";
        sep51.Size = new Size(238, 5);
        sep51.TabIndex = 5;
        // 
        // btnSetSafetyMode
        // 
        btnSetSafetyMode.Dock = DockStyle.Top;
        btnSetSafetyMode.Name = "btnSetSafetyMode";
        btnSetSafetyMode.Size = new Size(238, 23);
        btnSetSafetyMode.TabIndex = 6;
        btnSetSafetyMode.Text = "Set Safety mode";
        btnSetSafetyMode.UseVisualStyleBackColor = true;
        btnSetSafetyMode.Click += btnSetSafetyMode_Click;
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
        pnlSafetyConfiguration.Name = "pnlSafetyConfiguration";
        pnlSafetyConfiguration.Padding = new Padding(5);
        pnlSafetyConfiguration.Size = new Size(250, 276);
        pnlSafetyConfiguration.TabIndex = 0;
        // 
        // btnGetSafetyConfiguration
        // 
        btnGetSafetyConfiguration.Dock = DockStyle.Top;
        btnGetSafetyConfiguration.Name = "btnGetSafetyConfiguration";
        btnGetSafetyConfiguration.Size = new Size(238, 23);
        btnGetSafetyConfiguration.TabIndex = 0;
        btnGetSafetyConfiguration.Text = "Get Safety configuration";
        btnGetSafetyConfiguration.UseVisualStyleBackColor = true;
        btnGetSafetyConfiguration.Click += btnGetSafetyConfiguration_Click;
        // 
        // sep52
        // 
        sep52.Dock = DockStyle.Top;
        sep52.Name = "sep52";
        sep52.Size = new Size(238, 5);
        sep52.TabIndex = 1;
        // 
        // gridSafetyConfiguration
        // 
        gridSafetyConfiguration.Dock = DockStyle.Top;
        gridSafetyConfiguration.HelpVisible = false;
        gridSafetyConfiguration.Name = "gridSafetyConfiguration";
        gridSafetyConfiguration.PropertySort = PropertySort.NoSort;
        gridSafetyConfiguration.Size = new Size(238, 150);
        gridSafetyConfiguration.TabIndex = 2;
        gridSafetyConfiguration.ToolbarVisible = false;
        // 
        // sep53
        // 
        sep53.Dock = DockStyle.Top;
        sep53.Name = "sep53";
        sep53.Size = new Size(238, 5);
        sep53.TabIndex = 3;
        // 
        // txtLoadSafetyConfigurationFilePath
        // 
        txtLoadSafetyConfigurationFilePath.Dock = DockStyle.Top;
        txtLoadSafetyConfigurationFilePath.Name = "txtLoadSafetyConfigurationFilePath";
        txtLoadSafetyConfigurationFilePath.Size = new Size(238, 23);
        txtLoadSafetyConfigurationFilePath.TabIndex = 4;
        txtLoadSafetyConfigurationFilePath.PlaceholderText = "filePath";
        txtLoadSafetyConfigurationFilePath.Text = "$home/safety.xml";
        // 
        // sep54
        // 
        sep54.Dock = DockStyle.Top;
        sep54.Name = "sep54";
        sep54.Size = new Size(238, 5);
        sep54.TabIndex = 5;
        // 
        // btnLoadSafetyConfiguration
        // 
        btnLoadSafetyConfiguration.Dock = DockStyle.Top;
        btnLoadSafetyConfiguration.Name = "btnLoadSafetyConfiguration";
        btnLoadSafetyConfiguration.Size = new Size(238, 23);
        btnLoadSafetyConfiguration.TabIndex = 6;
        btnLoadSafetyConfiguration.Text = "Load Safety configuration";
        btnLoadSafetyConfiguration.UseVisualStyleBackColor = true;
        btnLoadSafetyConfiguration.Click += btnLoadSafetyConfiguration_Click;
        // 
        // pnlInvalidateSafetyConfiguration
        // 
        pnlInvalidateSafetyConfiguration.BorderStyle = BorderStyle.FixedSingle;
        pnlInvalidateSafetyConfiguration.Controls.Add(btnInvalidateSafetyConfiguration);
        pnlInvalidateSafetyConfiguration.Name = "pnlInvalidateSafetyConfiguration";
        pnlInvalidateSafetyConfiguration.Padding = new Padding(5);
        pnlInvalidateSafetyConfiguration.Size = new Size(250, 35);
        pnlInvalidateSafetyConfiguration.TabIndex = 0;
        // 
        // btnInvalidateSafetyConfiguration
        // 
        btnInvalidateSafetyConfiguration.Dock = DockStyle.Top;
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
        pnlSafetyLoadOperationStatus.Name = "pnlSafetyLoadOperationStatus";
        pnlSafetyLoadOperationStatus.Padding = new Padding(5);
        pnlSafetyLoadOperationStatus.Size = new Size(250, 63);
        pnlSafetyLoadOperationStatus.TabIndex = 0;
        // 
        // btnGetSafetyLoadOperationStatus
        // 
        btnGetSafetyLoadOperationStatus.Dock = DockStyle.Top;
        btnGetSafetyLoadOperationStatus.Name = "btnGetSafetyLoadOperationStatus";
        btnGetSafetyLoadOperationStatus.Size = new Size(238, 23);
        btnGetSafetyLoadOperationStatus.TabIndex = 0;
        btnGetSafetyLoadOperationStatus.Text = "Get Safety load operation status";
        btnGetSafetyLoadOperationStatus.UseVisualStyleBackColor = true;
        btnGetSafetyLoadOperationStatus.Click += btnGetSafetyLoadOperationStatus_Click;
        // 
        // sep55
        // 
        sep55.Dock = DockStyle.Top;
        sep55.Name = "sep55";
        sep55.Size = new Size(238, 5);
        sep55.TabIndex = 1;
        // 
        // txtSafetyLoadOperationStatus
        // 
        txtSafetyLoadOperationStatus.Dock = DockStyle.Top;
        txtSafetyLoadOperationStatus.Name = "txtSafetyLoadOperationStatus";
        txtSafetyLoadOperationStatus.ReadOnly = true;
        txtSafetyLoadOperationStatus.Size = new Size(238, 23);
        txtSafetyLoadOperationStatus.TabIndex = 2;
        txtSafetyLoadOperationStatus.PlaceholderText = "status";
        // 
        // pnlCyclicBrakeCheckStatus
        // 
        pnlCyclicBrakeCheckStatus.BorderStyle = BorderStyle.FixedSingle;
        pnlCyclicBrakeCheckStatus.Controls.Add(gridCyclicBrakeCheckStatus);
        pnlCyclicBrakeCheckStatus.Controls.Add(sep57);
        pnlCyclicBrakeCheckStatus.Controls.Add(btnGetCyclicBrakeCheckStatus);
        pnlCyclicBrakeCheckStatus.Controls.Add(sep56);
        pnlCyclicBrakeCheckStatus.Controls.Add(numGetCyclicBrakeCheckStatusDriveNumber);
        pnlCyclicBrakeCheckStatus.Name = "pnlCyclicBrakeCheckStatus";
        pnlCyclicBrakeCheckStatus.Padding = new Padding(5);
        pnlCyclicBrakeCheckStatus.Size = new Size(250, 250);
        pnlCyclicBrakeCheckStatus.TabIndex = 0;
        // 
        // numGetCyclicBrakeCheckStatusDriveNumber
        // 
        numGetCyclicBrakeCheckStatusDriveNumber.Dock = DockStyle.Top;
        numGetCyclicBrakeCheckStatusDriveNumber.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
        numGetCyclicBrakeCheckStatusDriveNumber.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        numGetCyclicBrakeCheckStatusDriveNumber.Name = "numGetCyclicBrakeCheckStatusDriveNumber";
        numGetCyclicBrakeCheckStatusDriveNumber.Size = new Size(238, 23);
        numGetCyclicBrakeCheckStatusDriveNumber.TabIndex = 0;
        numGetCyclicBrakeCheckStatusDriveNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // sep56
        // 
        sep56.Dock = DockStyle.Top;
        sep56.Name = "sep56";
        sep56.Size = new Size(238, 5);
        sep56.TabIndex = 1;
        // 
        // btnGetCyclicBrakeCheckStatus
        // 
        btnGetCyclicBrakeCheckStatus.Dock = DockStyle.Top;
        btnGetCyclicBrakeCheckStatus.Name = "btnGetCyclicBrakeCheckStatus";
        btnGetCyclicBrakeCheckStatus.Size = new Size(238, 23);
        btnGetCyclicBrakeCheckStatus.TabIndex = 2;
        btnGetCyclicBrakeCheckStatus.Text = "Get Cyclic brake check status";
        btnGetCyclicBrakeCheckStatus.UseVisualStyleBackColor = true;
        btnGetCyclicBrakeCheckStatus.Click += btnGetCyclicBrakeCheckStatus_Click;
        // 
        // sep57
        // 
        sep57.Dock = DockStyle.Top;
        sep57.Name = "sep57";
        sep57.Size = new Size(238, 5);
        sep57.TabIndex = 3;
        // 
        // gridCyclicBrakeCheckStatus
        // 
        gridCyclicBrakeCheckStatus.Dock = DockStyle.Fill;
        gridCyclicBrakeCheckStatus.HelpVisible = false;
        gridCyclicBrakeCheckStatus.Name = "gridCyclicBrakeCheckStatus";
        gridCyclicBrakeCheckStatus.PropertySort = PropertySort.NoSort;
        gridCyclicBrakeCheckStatus.Size = new Size(238, 120);
        gridCyclicBrakeCheckStatus.TabIndex = 4;
        gridCyclicBrakeCheckStatus.ToolbarVisible = false;
        // 
        // pnlSafetyViolationInfo
        // 
        pnlSafetyViolationInfo.BorderStyle = BorderStyle.FixedSingle;
        pnlSafetyViolationInfo.Controls.Add(gridSafetyViolationInfo);
        pnlSafetyViolationInfo.Controls.Add(sep58);
        pnlSafetyViolationInfo.Controls.Add(btnGetSafetyViolationInfo);
        pnlSafetyViolationInfo.Name = "pnlSafetyViolationInfo";
        pnlSafetyViolationInfo.Padding = new Padding(5);
        pnlSafetyViolationInfo.Size = new Size(250, 300);
        pnlSafetyViolationInfo.TabIndex = 0;
        // 
        // btnGetSafetyViolationInfo
        // 
        btnGetSafetyViolationInfo.Dock = DockStyle.Top;
        btnGetSafetyViolationInfo.Name = "btnGetSafetyViolationInfo";
        btnGetSafetyViolationInfo.Size = new Size(238, 23);
        btnGetSafetyViolationInfo.TabIndex = 0;
        btnGetSafetyViolationInfo.Text = "Get Safety violation info";
        btnGetSafetyViolationInfo.UseVisualStyleBackColor = true;
        btnGetSafetyViolationInfo.Click += btnGetSafetyViolationInfo_Click;
        // 
        // sep58
        // 
        sep58.Dock = DockStyle.Top;
        sep58.Name = "sep58";
        sep58.Size = new Size(238, 5);
        sep58.TabIndex = 1;
        // 
        // gridSafetyViolationInfo
        // 
        gridSafetyViolationInfo.Dock = DockStyle.Fill;
        gridSafetyViolationInfo.HelpVisible = false;
        gridSafetyViolationInfo.Name = "gridSafetyViolationInfo";
        gridSafetyViolationInfo.PropertySort = PropertySort.NoSort;
        gridSafetyViolationInfo.Size = new Size(238, 120);
        gridSafetyViolationInfo.TabIndex = 2;
        gridSafetyViolationInfo.ToolbarVisible = false;
        // 
        // pnlVirtualTimeResources
        // 
        pnlVirtualTimeResources.BorderStyle = BorderStyle.FixedSingle;
        pnlVirtualTimeResources.Controls.Add(gridVirtualTimeResources);
        pnlVirtualTimeResources.Controls.Add(sep59);
        pnlVirtualTimeResources.Controls.Add(btnGetVirtualTimeResources);
        pnlVirtualTimeResources.Name = "pnlVirtualTimeResources";
        pnlVirtualTimeResources.Padding = new Padding(5);
        pnlVirtualTimeResources.Size = new Size(250, 200);
        pnlVirtualTimeResources.TabIndex = 0;
        // 
        // btnGetVirtualTimeResources
        // 
        btnGetVirtualTimeResources.Dock = DockStyle.Top;
        btnGetVirtualTimeResources.Name = "btnGetVirtualTimeResources";
        btnGetVirtualTimeResources.Size = new Size(238, 23);
        btnGetVirtualTimeResources.TabIndex = 0;
        btnGetVirtualTimeResources.Text = "Get Virtual time resources";
        btnGetVirtualTimeResources.UseVisualStyleBackColor = true;
        btnGetVirtualTimeResources.Click += btnGetVirtualTimeResources_Click;
        // 
        // sep59
        // 
        sep59.Dock = DockStyle.Top;
        sep59.Name = "sep59";
        sep59.Size = new Size(238, 5);
        sep59.TabIndex = 1;
        // 
        // gridVirtualTimeResources
        // 
        gridVirtualTimeResources.Dock = DockStyle.Fill;
        gridVirtualTimeResources.HelpVisible = false;
        gridVirtualTimeResources.Name = "gridVirtualTimeResources";
        gridVirtualTimeResources.PropertySort = PropertySort.NoSort;
        gridVirtualTimeResources.Size = new Size(238, 120);
        gridVirtualTimeResources.TabIndex = 2;
        gridVirtualTimeResources.ToolbarVisible = false;
        // 
        // pnlVirtualTime
        // 
        pnlVirtualTime.BorderStyle = BorderStyle.FixedSingle;
        pnlVirtualTime.Controls.Add(txtVirtualTime);
        pnlVirtualTime.Controls.Add(sep60);
        pnlVirtualTime.Controls.Add(btnGetVirtualTime);
        pnlVirtualTime.Name = "pnlVirtualTime";
        pnlVirtualTime.Padding = new Padding(5);
        pnlVirtualTime.Size = new Size(250, 63);
        pnlVirtualTime.TabIndex = 0;
        // 
        // btnGetVirtualTime
        // 
        btnGetVirtualTime.Dock = DockStyle.Top;
        btnGetVirtualTime.Name = "btnGetVirtualTime";
        btnGetVirtualTime.Size = new Size(238, 23);
        btnGetVirtualTime.TabIndex = 0;
        btnGetVirtualTime.Text = "Get Virtual time";
        btnGetVirtualTime.UseVisualStyleBackColor = true;
        btnGetVirtualTime.Click += btnGetVirtualTime_Click;
        // 
        // sep60
        // 
        sep60.Dock = DockStyle.Top;
        sep60.Name = "sep60";
        sep60.Size = new Size(238, 5);
        sep60.TabIndex = 1;
        // 
        // txtVirtualTime
        // 
        txtVirtualTime.Dock = DockStyle.Top;
        txtVirtualTime.Name = "txtVirtualTime";
        txtVirtualTime.ReadOnly = true;
        txtVirtualTime.Size = new Size(238, 23);
        txtVirtualTime.TabIndex = 2;
        txtVirtualTime.PlaceholderText = "virtual time";
        // 
        // pnlVirtualTimeSpeed
        // 
        pnlVirtualTimeSpeed.BorderStyle = BorderStyle.FixedSingle;
        pnlVirtualTimeSpeed.Controls.Add(btnSetVirtualTimeSpeed);
        pnlVirtualTimeSpeed.Controls.Add(sep62);
        pnlVirtualTimeSpeed.Controls.Add(numSetVirtualTimeSpeedSpeed);
        pnlVirtualTimeSpeed.Controls.Add(sep61);
        pnlVirtualTimeSpeed.Controls.Add(btnGetVirtualTimeSpeed);
        pnlVirtualTimeSpeed.Name = "pnlVirtualTimeSpeed";
        pnlVirtualTimeSpeed.Padding = new Padding(5);
        pnlVirtualTimeSpeed.Size = new Size(250, 91);
        pnlVirtualTimeSpeed.TabIndex = 0;
        // 
        // btnGetVirtualTimeSpeed
        // 
        btnGetVirtualTimeSpeed.Dock = DockStyle.Top;
        btnGetVirtualTimeSpeed.Name = "btnGetVirtualTimeSpeed";
        btnGetVirtualTimeSpeed.Size = new Size(238, 23);
        btnGetVirtualTimeSpeed.TabIndex = 0;
        btnGetVirtualTimeSpeed.Text = "Get Virtual time speed";
        btnGetVirtualTimeSpeed.UseVisualStyleBackColor = true;
        btnGetVirtualTimeSpeed.Click += btnGetVirtualTimeSpeed_Click;
        // 
        // sep61
        // 
        sep61.Dock = DockStyle.Top;
        sep61.Name = "sep61";
        sep61.Size = new Size(238, 5);
        sep61.TabIndex = 1;
        // 
        // numSetVirtualTimeSpeedSpeed
        // 
        numSetVirtualTimeSpeedSpeed.Dock = DockStyle.Top;
        numSetVirtualTimeSpeedSpeed.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        numSetVirtualTimeSpeedSpeed.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
        numSetVirtualTimeSpeedSpeed.Name = "numSetVirtualTimeSpeedSpeed";
        numSetVirtualTimeSpeedSpeed.Size = new Size(238, 23);
        numSetVirtualTimeSpeedSpeed.TabIndex = 2;
        numSetVirtualTimeSpeedSpeed.Value = new decimal(new int[] { 100, 0, 0, 0 });
        // 
        // sep62
        // 
        sep62.Dock = DockStyle.Top;
        sep62.Name = "sep62";
        sep62.Size = new Size(238, 5);
        sep62.TabIndex = 3;
        // 
        // btnSetVirtualTimeSpeed
        // 
        btnSetVirtualTimeSpeed.Dock = DockStyle.Top;
        btnSetVirtualTimeSpeed.Name = "btnSetVirtualTimeSpeed";
        btnSetVirtualTimeSpeed.Size = new Size(238, 23);
        btnSetVirtualTimeSpeed.TabIndex = 4;
        btnSetVirtualTimeSpeed.Text = "Set Virtual time speed";
        btnSetVirtualTimeSpeed.UseVisualStyleBackColor = true;
        btnSetVirtualTimeSpeed.Click += btnSetVirtualTimeSpeed_Click;
        // 
        // pnlVirtualTimeState
        // 
        pnlVirtualTimeState.BorderStyle = BorderStyle.FixedSingle;
        pnlVirtualTimeState.Controls.Add(btnSetVirtualTimeState);
        pnlVirtualTimeState.Controls.Add(sep64);
        pnlVirtualTimeState.Controls.Add(cboSetVirtualTimeStateState);
        pnlVirtualTimeState.Controls.Add(sep63);
        pnlVirtualTimeState.Controls.Add(btnGetVirtualTimeState);
        pnlVirtualTimeState.Name = "pnlVirtualTimeState";
        pnlVirtualTimeState.Padding = new Padding(5);
        pnlVirtualTimeState.Size = new Size(250, 91);
        pnlVirtualTimeState.TabIndex = 0;
        // 
        // btnGetVirtualTimeState
        // 
        btnGetVirtualTimeState.Dock = DockStyle.Top;
        btnGetVirtualTimeState.Name = "btnGetVirtualTimeState";
        btnGetVirtualTimeState.Size = new Size(238, 23);
        btnGetVirtualTimeState.TabIndex = 0;
        btnGetVirtualTimeState.Text = "Get Virtual time state";
        btnGetVirtualTimeState.UseVisualStyleBackColor = true;
        btnGetVirtualTimeState.Click += btnGetVirtualTimeState_Click;
        // 
        // sep63
        // 
        sep63.Dock = DockStyle.Top;
        sep63.Name = "sep63";
        sep63.Size = new Size(238, 5);
        sep63.TabIndex = 1;
        // 
        // cboSetVirtualTimeStateState
        // 
        cboSetVirtualTimeStateState.Dock = DockStyle.Top;
        cboSetVirtualTimeStateState.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSetVirtualTimeStateState.FormattingEnabled = true;
        cboSetVirtualTimeStateState.Name = "cboSetVirtualTimeStateState";
        cboSetVirtualTimeStateState.Size = new Size(238, 23);
        cboSetVirtualTimeStateState.TabIndex = 2;
        // 
        // sep64
        // 
        sep64.Dock = DockStyle.Top;
        sep64.Name = "sep64";
        sep64.Size = new Size(238, 5);
        sep64.TabIndex = 3;
        // 
        // btnSetVirtualTimeState
        // 
        btnSetVirtualTimeState.Dock = DockStyle.Top;
        btnSetVirtualTimeState.Name = "btnSetVirtualTimeState";
        btnSetVirtualTimeState.Size = new Size(238, 23);
        btnSetVirtualTimeState.TabIndex = 4;
        btnSetVirtualTimeState.Text = "Set Virtual time state";
        btnSetVirtualTimeState.UseVisualStyleBackColor = true;
        btnSetVirtualTimeState.Click += btnSetVirtualTimeState_Click;
        // 
        // pnlVirtualTimeSlice
        // 
        pnlVirtualTimeSlice.BorderStyle = BorderStyle.FixedSingle;
        pnlVirtualTimeSlice.Controls.Add(btnSetVirtualTimeSlice);
        pnlVirtualTimeSlice.Controls.Add(sep66);
        pnlVirtualTimeSlice.Controls.Add(numSetVirtualTimeSliceMilliseconds);
        pnlVirtualTimeSlice.Controls.Add(sep65);
        pnlVirtualTimeSlice.Controls.Add(btnGetVirtualTimeSlice);
        pnlVirtualTimeSlice.Name = "pnlVirtualTimeSlice";
        pnlVirtualTimeSlice.Padding = new Padding(5);
        pnlVirtualTimeSlice.Size = new Size(250, 91);
        pnlVirtualTimeSlice.TabIndex = 0;
        // 
        // btnGetVirtualTimeSlice
        // 
        btnGetVirtualTimeSlice.Dock = DockStyle.Top;
        btnGetVirtualTimeSlice.Name = "btnGetVirtualTimeSlice";
        btnGetVirtualTimeSlice.Size = new Size(238, 23);
        btnGetVirtualTimeSlice.TabIndex = 0;
        btnGetVirtualTimeSlice.Text = "Get Virtual time slice";
        btnGetVirtualTimeSlice.UseVisualStyleBackColor = true;
        btnGetVirtualTimeSlice.Click += btnGetVirtualTimeSlice_Click;
        // 
        // sep65
        // 
        sep65.Dock = DockStyle.Top;
        sep65.Name = "sep65";
        sep65.Size = new Size(238, 5);
        sep65.TabIndex = 1;
        // 
        // numSetVirtualTimeSliceMilliseconds
        // 
        numSetVirtualTimeSliceMilliseconds.Dock = DockStyle.Top;
        numSetVirtualTimeSliceMilliseconds.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        numSetVirtualTimeSliceMilliseconds.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
        numSetVirtualTimeSliceMilliseconds.Name = "numSetVirtualTimeSliceMilliseconds";
        numSetVirtualTimeSliceMilliseconds.Size = new Size(238, 23);
        numSetVirtualTimeSliceMilliseconds.TabIndex = 2;
        numSetVirtualTimeSliceMilliseconds.Value = new decimal(new int[] { 20, 0, 0, 0 });
        // 
        // sep66
        // 
        sep66.Dock = DockStyle.Top;
        sep66.Name = "sep66";
        sep66.Size = new Size(238, 5);
        sep66.TabIndex = 3;
        // 
        // btnSetVirtualTimeSlice
        // 
        btnSetVirtualTimeSlice.Dock = DockStyle.Top;
        btnSetVirtualTimeSlice.Name = "btnSetVirtualTimeSlice";
        btnSetVirtualTimeSlice.Size = new Size(238, 23);
        btnSetVirtualTimeSlice.TabIndex = 4;
        btnSetVirtualTimeSlice.Text = "Set Virtual time slice";
        btnSetVirtualTimeSlice.UseVisualStyleBackColor = true;
        btnSetVirtualTimeSlice.Click += btnSetVirtualTimeSlice_Click;
        // 
        // pnlRunVirtualTime
        // 
        pnlRunVirtualTime.BorderStyle = BorderStyle.FixedSingle;
        pnlRunVirtualTime.Controls.Add(btnRunVirtualTime);
        pnlRunVirtualTime.Name = "pnlRunVirtualTime";
        pnlRunVirtualTime.Padding = new Padding(5);
        pnlRunVirtualTime.Size = new Size(250, 35);
        pnlRunVirtualTime.TabIndex = 0;
        // 
        // btnRunVirtualTime
        // 
        btnRunVirtualTime.Dock = DockStyle.Top;
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
        Controls.Add(flowLayoutPanel1);
        Margin = new Padding(4, 3, 4, 3);
        Name = "RwsControllerControl";
        Size = new Size(890, 491);
        flowLayoutPanel1.ResumeLayout(false);
        pnlControllerInfo.ResumeLayout(false);
        pnlEnvironmentVariable.ResumeLayout(false);
        pnlEnvironmentVariable.PerformLayout();
        pnlClock.ResumeLayout(false);
        pnlTimeZone.ResumeLayout(false);
        pnlTimeZone.PerformLayout();
        pnlTimeServer.ResumeLayout(false);
        pnlTimeServer.PerformLayout();
        pnlIdentity.ResumeLayout(false);
        pnlIdentity.PerformLayout();
        pnlLanguage.ResumeLayout(false);
        pnlLanguage.PerformLayout();
        pnlNetwork.ResumeLayout(false);
        pnlNetwork.PerformLayout();
        pnlRestart.ResumeLayout(false);
        pnlRestart.PerformLayout();
        pnlInstalledSystems.ResumeLayout(false);
        pnlOption.ResumeLayout(false);
        pnlOption.PerformLayout();
        pnlCompatibility.ResumeLayout(false);
        pnlCompatibility.PerformLayout();
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
        pnlSafetyResources.ResumeLayout(false);
        pnlSafetyMode.ResumeLayout(false);
        pnlSafetyMode.PerformLayout();
        pnlSafetyConfiguration.ResumeLayout(false);
        pnlSafetyConfiguration.PerformLayout();
        pnlInvalidateSafetyConfiguration.ResumeLayout(false);
        pnlSafetyLoadOperationStatus.ResumeLayout(false);
        pnlSafetyLoadOperationStatus.PerformLayout();
        pnlCyclicBrakeCheckStatus.ResumeLayout(false);
        pnlCyclicBrakeCheckStatus.PerformLayout();
        pnlSafetyViolationInfo.ResumeLayout(false);
        pnlVirtualTimeResources.ResumeLayout(false);
        pnlVirtualTime.ResumeLayout(false);
        pnlVirtualTime.PerformLayout();
        pnlVirtualTimeSpeed.ResumeLayout(false);
        pnlVirtualTimeSpeed.PerformLayout();
        pnlVirtualTimeState.ResumeLayout(false);
        pnlVirtualTimeState.PerformLayout();
        pnlVirtualTimeSlice.ResumeLayout(false);
        pnlVirtualTimeSlice.PerformLayout();
        pnlRunVirtualTime.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numGetCyclicBrakeCheckStatusDriveNumber).EndInit();
        ((System.ComponentModel.ISupportInitialize)numSetVirtualTimeSpeedSpeed).EndInit();
        ((System.ComponentModel.ISupportInitialize)numSetVirtualTimeSliceMilliseconds).EndInit();
        ResumeLayout(false);
    }

    #endregion

    internal System.Windows.Forms.OpenFileDialog dlgOpen;
    internal System.Windows.Forms.SaveFileDialog dlgSave;
    internal System.Windows.Forms.ImageList lstFolderImageList;
    private FlowLayoutPanel flowLayoutPanel1;

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

    private Panel pnlClock;
    private Button btnGetClock;
    private Panel sep4;
    private DateTimePicker dtpClock;
    private Panel sep5;
    private Button btnSetClock;

    private Panel pnlTimeZone;
    private Button btnGetTimeZone;
    private Panel sep6;
    private TextBox txtTimeZone;
    private Panel sep7;
    private Button btnSetTimeZone;

    private Panel pnlTimeServer;
    private TextBox txtGetTimeServerServerIp;
    private Panel sep8;
    private Button btnGetTimeServer;
    private Panel sep9;
    private PropertyGrid gridTimeServer;
    private Panel sep10;
    private TextBox txtSetTimeServerTimeServer;
    private Panel sep11;
    private Button btnSetTimeServer;

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

    private Panel pnlLanguage;
    private TextBox txtSetLanguageLanguage;
    private Panel sep16;
    private Button btnSetLanguage;

    private Panel pnlNetwork;
    private Button btnGetNetworkInterfaces;
    private Panel sep17;
    private PropertyGrid gridNetworkInterfaces;
    private Panel sep18;
    private ComboBox cboSetNetworkConfigurationMethod;
    private Panel sep19;
    private TextBox txtSetNetworkConfigurationAddress;
    private Panel sep20;
    private TextBox txtSetNetworkConfigurationMask;
    private Panel sep21;
    private TextBox txtSetNetworkConfigurationGateway;
    private Panel sep22;
    private Button btnSetNetworkConfiguration;

    private Panel pnlRestart;
    private ComboBox cboRestartMode;
    private Panel sep23;
    private CheckBox chkRestartUseImplicitMastership;
    private Panel sep24;
    private Button btnRestart;

    private Panel pnlInstalledSystems;
    private Button btnGetInstalledSystems;
    private Panel sep25;
    private PropertyGrid gridInstalledSystems;

    private Panel pnlOption;
    private TextBox txtHasOptionOption;
    private Panel sep26;
    private Button btnHasOption;
    private Panel sep27;
    private CheckBox chkHasOptionResult;

    private Panel pnlCompatibility;
    private TextBox txtIsRobotWareVersionCompatibleRobotWareVersion;
    private Panel sep28;
    private Button btnIsRobotWareVersionCompatible;
    private Panel sep29;
    private CheckBox chkIsRobotWareVersionCompatibleResult;

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
