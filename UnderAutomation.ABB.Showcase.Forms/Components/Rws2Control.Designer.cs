
partial class Rws2Control
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
        tabController = new TabPage();
        pnlControllerTop = new Panel();
        btnGetIdentity = new Button();
        btnGetDateTime = new Button();
        lblSetDateTime = new Label();
        txtSetDateTime = new TextBox();
        btnSetDateTime = new Button();
        btnGetTimezone = new Button();
        lblTimezone = new Label();
        txtTimezone = new TextBox();
        btnSetTimezone = new Button();
        btnGetTimeserver = new Button();
        lblTimeserver = new Label();
        txtTimeserver = new TextBox();
        btnSetTimeserver = new Button();
        lblEnvName = new Label();
        txtEnvName = new TextBox();
        btnGetEnvVar = new Button();
        lblLangCode = new Label();
        txtLangCode = new TextBox();
        btnSetLanguage = new Button();
        lblBackupPath = new Label();
        txtBackupPath = new TextBox();
        btnGetBackupInfo = new Button();
        btnGetBackupState = new Button();
        btnCreateBackup = new Button();
        btnRestoreBackup = new Button();
        btnCheckRestore = new Button();
        btnCompress = new Button();
        btnDecompress = new Button();
        btnGetCertStores = new Button();
        lblCertStoreGroup = new Label();
        txtCertStoreGroup = new TextBox();
        lblCertStoreName = new Label();
        txtCertStoreName = new TextBox();
        btnGetCertificate = new Button();
        btnClearCertStore = new Button();
        lblRestartMode = new Label();
        cbRestartMode = new ComboBox();
        btnRestart = new Button();
        tabPanel = new TabPage();
        pnlPanelTop = new Panel();
        btnGetOpMode = new Button();
        btnGetCtrlState = new Button();
        btnGetSpeedRatio = new Button();
        lblSpeed = new Label();
        nudSpeedRatio = new NumericUpDown();
        btnSetSpeedRatio = new Button();
        btnKeylessMotorOn = new Button();
        btnGetEnablingDevRequired = new Button();
        tabIO = new TabPage();
        pnlIOTop = new Panel();
        btnGetNetworks = new Button();
        btnGetAllSignals = new Button();
        lblIONetwork = new Label();
        txtIONetwork = new TextBox();
        lblIODevice = new Label();
        txtIODevice = new TextBox();
        lblIOSignal = new Label();
        txtIOSignal = new TextBox();
        btnGetSignal = new Button();
        lblIOValue = new Label();
        txtIOValue = new TextBox();
        btnSetSignalVal = new Button();
        tabRapid = new TabPage();
        pnlRapidTop = new Panel();
        btnGetExecState = new Button();
        btnStartExec = new Button();
        btnStopExec = new Button();
        btnResetPP = new Button();
        btnGetTasks = new Button();
        lblTask = new Label();
        txtTask = new TextBox();
        btnGetModules = new Button();
        lblSymbol = new Label();
        txtSymbolUrl = new TextBox();
        btnGetSymbol = new Button();
        txtSymbolVal = new TextBox();
        btnSetSymbol = new Button();
        tabFile = new TabPage();
        pnlFileTop = new Panel();
        btnGetFsDevices = new Button();
        lblDirPath = new Label();
        txtDirPath = new TextBox();
        btnListDir = new Button();
        lblFilePath = new Label();
        txtFilePath = new TextBox();
        btnGetFileContent = new Button();
        lblUploadPath = new Label();
        txtUploadPath = new TextBox();
        lblCreatePath = new Label();
        txtCreatePath = new TextBox();
        btnCreateFolder = new Button();
        btnDeleteFolder = new Button();
        btnMoveFile = new Button();
        btnUploadBackup = new Button();
        btnDownloadBackup = new Button();
        btnGetFileInfo = new Button();
        btnGetFileProperty = new Button();
        btnSetFileProperty = new Button();
        tabSubscription = new TabPage();
        pnlSubTop = new Panel();
        lblSubResource = new Label();
        txtSubResource = new TextBox();
        lblSubPriority = new Label();
        cbSubPriority = new ComboBox();
        btnSubscribe = new Button();
        lblSubGroupId = new Label();
        txtSubGroupId = new TextBox();
        btnUnsubscribe = new Button();
        lblUpdateResource = new Label();
        txtUpdateResource = new TextBox();
        tabSystem = new TabPage();
        pnlSystemTop = new Panel();
        btnGetSysInfo = new Button();
        btnGetSysOptions = new Button();
        btnGetRobotType = new Button();
        btnGetLicense = new Button();
        btnGetEnergy = new Button();
        btnResetEnergy = new Button();
        tabMastership = new TabPage();
        pnlMasterTop = new Panel();
        btnGetEditDomain = new Button();
        btnGetMotionDomain = new Button();
        btnRequestAllMaster = new Button();
        btnReleaseAllMaster = new Button();
        lblMasterDomain = new Label();
        txtMasterDomain = new TextBox();
        btnRequestMaster = new Button();
        btnReleaseMaster = new Button();
        tabElog = new TabPage();
        pnlElogTop = new Panel();
        btnGetElogDomains = new Button();
        lblElogDomain = new Label();
        txtElogDomain = new TextBox();
        btnGetElogMessages = new Button();
        btnClearAllElog = new Button();
        btnClearElogDomain = new Button();
        btnSaveRawElog = new Button();
        tabCfg = new TabPage();
        pnlCfgTop = new Panel();
        btnGetCfgDomains = new Button();
        lblCfgDomain = new Label();
        txtCfgDomain = new TextBox();
        btnGetCfgTypes = new Button();
        lblCfgType = new Label();
        txtCfgType = new TextBox();
        btnGetCfgInstances = new Button();
        btnGetCfgAttributes = new Button();
        lblCfgAttribute = new Label();
        txtCfgAttribute = new TextBox();
        btnGetAttribute = new Button();
        lblCfgValue = new Label();
        txtCfgValue = new TextBox();
        btnSetAttribute = new Button();
        btnDeleteInstance = new Button();
        btnCreateDefault = new Button();
        btnLoadCfg = new Button();
        btnSaveCfg = new Button();
        btnValidateCfg = new Button();
        btnResetCfg = new Button();
        btnCfgSystemAction = new Button();
        tabMotion = new TabPage();
        pnlMotionTop = new Panel();
        btnGetMechUnits = new Button();
        lblMechUnit = new Label();
        txtMechUnit = new TextBox();
        btnGetMechUnit = new Button();
        btnGetCartesian = new Button();
        btnGetRobTarget = new Button();
        btnGetJointTarget = new Button();
        lblMechUnitState = new Label();
        cbMechUnitState = new ComboBox();
        btnSetMechUnitState = new Button();
        lblPayload = new Label();
        txtPayload = new TextBox();
        btnSetPayload = new Button();
        btnGetPayload = new Button();
        lblSupervision = new Label();
        cbSupervision = new CheckBox();
        btnSetSupervision = new Button();
        btnGetSupervision = new Button();
        btnResetPpMoved = new Button();
        lblCalAxis = new Label();
        txtCalAxis = new TextBox();
        btnLoadIdentity = new Button();
        btnClearCalibPath = new Button();
        lblCalibOffset = new Label();
        txtCalibOffset = new TextBox();
        btnSetCalibOffset = new Button();
        btnGetCalibOffset = new Button();
        lblJogSpeed = new Label();
        txtJogSpeed = new TextBox();
        lblJogIncrement = new Label();
        txtJogIncrement = new TextBox();
        lblJogMode = new Label();
        cbJogMode = new ComboBox();
        btnStartJogF = new Button();
        btnStartJogB = new Button();
        btnStartJogR = new Button();
        btnStartJogL = new Button();
        btnStartJogU = new Button();
        btnStartJogD = new Button();
        btnStopJog = new Button();
        btnSetJogMode = new Button();
        lblSpeedRatio = new Label();
        txtSpeedRatio = new NumericUpDown();
        btnEnableLeadThrough = new Button();
        btnDisableLeadThrough = new Button();
        btnGetMechUnitMode = new Button();
        tabDIPC = new TabPage();
        pnlDIPCTop = new Panel();
        btnGetDIPCQueues = new Button();
        lblDIPCQueue = new Label();
        txtDIPCQueue = new TextBox();
        btnGetDIPCQueueInfo = new Button();
        lblDIPCSize = new Label();
        txtDIPCSize = new TextBox();
        lblDIPCMsgSize = new Label();
        txtDIPCMsgSize = new TextBox();
        btnCreateDIPCQueue = new Button();
        btnDeleteDIPCQueue = new Button();
        lblDipcMsgType = new Label();
        txtDipcMsgType = new TextBox();
        lblDipcCmd = new Label();
        txtDipcCmd = new TextBox();
        btnSendDipcMsg = new Button();
        lblDipcUserDef = new Label();
        txtDipcUserDef = new TextBox();
        btnSetDipcUserDef = new Button();
        btnGetDipcQueue = new Button();
        tabUas = new TabPage();
        pnlUasTop = new Panel();
        btnGetUasUsers = new Button();
        btnGetUasRoles = new Button();
        btnGetUasGrants = new Button();
        lblUasUser = new Label();
        txtUasUser = new TextBox();
        btnGetUserRoles = new Button();
        btnGetUserGrants = new Button();
        lblUasUsername = new Label();
        txtUasUsername = new TextBox();
        lblUasPassword = new Label();
        txtUasPassword = new TextBox();
        btnCreateUser = new Button();
        btnDeleteUser = new Button();
        btnModifyUser = new Button();
        btnGetUserInfo = new Button();
        lblUasRole = new Label();
        txtUasRole = new TextBox();
        btnGetRoleInfo = new Button();
        btnCreateRole = new Button();
        btnDeleteRole = new Button();
        lblUasCapabilities = new Label();
        txtUasCapabilities = new TextBox();
        btnSetCapabilities = new Button();
        lblGrantUser = new Label();
        txtGrantUser = new TextBox();
        lblGrantRole = new Label();
        txtGrantRole = new TextBox();
        btnGrantRole = new Button();
        btnRevokeRole = new Button();
        tabRetcode = new TabPage();
        pnlRetcodeTop = new Panel();
        lblRetcode = new Label();
        txtRetcode = new TextBox();
        btnGetRetcodes = new Button();
        pgAnswer = new PropertyGrid();
        tabControl.SuspendLayout();
        tabController.SuspendLayout();
        pnlControllerTop.SuspendLayout();
        tabPanel.SuspendLayout();
        pnlPanelTop.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudSpeedRatio).BeginInit();
        tabIO.SuspendLayout();
        pnlIOTop.SuspendLayout();
        tabRapid.SuspendLayout();
        pnlRapidTop.SuspendLayout();
        tabFile.SuspendLayout();
        pnlFileTop.SuspendLayout();
        tabSubscription.SuspendLayout();
        pnlSubTop.SuspendLayout();
        tabSystem.SuspendLayout();
        pnlSystemTop.SuspendLayout();
        tabMastership.SuspendLayout();
        pnlMasterTop.SuspendLayout();
        tabElog.SuspendLayout();
        pnlElogTop.SuspendLayout();
        tabCfg.SuspendLayout();
        pnlCfgTop.SuspendLayout();
        tabMotion.SuspendLayout();
        pnlMotionTop.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)txtSpeedRatio).BeginInit();
        tabDIPC.SuspendLayout();
        pnlDIPCTop.SuspendLayout();
        tabUas.SuspendLayout();
        pnlUasTop.SuspendLayout();
        tabRetcode.SuspendLayout();
        pnlRetcodeTop.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabController);
        tabControl.Controls.Add(tabPanel);
        tabControl.Controls.Add(tabIO);
        tabControl.Controls.Add(tabRapid);
        tabControl.Controls.Add(tabFile);
        tabControl.Controls.Add(tabSubscription);
        tabControl.Controls.Add(tabSystem);
        tabControl.Controls.Add(tabMastership);
        tabControl.Controls.Add(tabElog);
        tabControl.Controls.Add(tabCfg);
        tabControl.Controls.Add(tabMotion);
        tabControl.Controls.Add(tabDIPC);
        tabControl.Controls.Add(tabUas);
        tabControl.Controls.Add(tabRetcode);
        tabControl.Dock = DockStyle.Top;
        tabControl.Location = new Point(0, 0);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(900, 351);
        tabControl.TabIndex = 0;
        // 
        // tabController
        // 
        tabController.Controls.Add(pnlControllerTop);
        tabController.Location = new Point(4, 24);
        tabController.Name = "tabController";
        tabController.Padding = new Padding(3);
        tabController.Size = new Size(892, 121);
        tabController.TabIndex = 0;
        tabController.Text = "Controller";
        tabController.UseVisualStyleBackColor = true;
        // 
        // pnlControllerTop
        // 
        pnlControllerTop.AutoScroll = true;
        pnlControllerTop.Controls.Add(btnGetIdentity);
        pnlControllerTop.Controls.Add(btnGetDateTime);
        pnlControllerTop.Controls.Add(lblSetDateTime);
        pnlControllerTop.Controls.Add(txtSetDateTime);
        pnlControllerTop.Controls.Add(btnSetDateTime);
        pnlControllerTop.Controls.Add(btnGetTimezone);
        pnlControllerTop.Controls.Add(lblTimezone);
        pnlControllerTop.Controls.Add(txtTimezone);
        pnlControllerTop.Controls.Add(btnSetTimezone);
        pnlControllerTop.Controls.Add(btnGetTimeserver);
        pnlControllerTop.Controls.Add(lblTimeserver);
        pnlControllerTop.Controls.Add(txtTimeserver);
        pnlControllerTop.Controls.Add(btnSetTimeserver);
        pnlControllerTop.Controls.Add(lblEnvName);
        pnlControllerTop.Controls.Add(txtEnvName);
        pnlControllerTop.Controls.Add(btnGetEnvVar);
        pnlControllerTop.Controls.Add(lblLangCode);
        pnlControllerTop.Controls.Add(txtLangCode);
        pnlControllerTop.Controls.Add(btnSetLanguage);
        pnlControllerTop.Controls.Add(lblBackupPath);
        pnlControllerTop.Controls.Add(txtBackupPath);
        pnlControllerTop.Controls.Add(btnGetBackupInfo);
        pnlControllerTop.Controls.Add(btnGetBackupState);
        pnlControllerTop.Controls.Add(btnCreateBackup);
        pnlControllerTop.Controls.Add(btnRestoreBackup);
        pnlControllerTop.Controls.Add(btnCheckRestore);
        pnlControllerTop.Controls.Add(btnCompress);
        pnlControllerTop.Controls.Add(btnDecompress);
        pnlControllerTop.Controls.Add(btnGetCertStores);
        pnlControllerTop.Controls.Add(lblCertStoreGroup);
        pnlControllerTop.Controls.Add(txtCertStoreGroup);
        pnlControllerTop.Controls.Add(lblCertStoreName);
        pnlControllerTop.Controls.Add(txtCertStoreName);
        pnlControllerTop.Controls.Add(btnGetCertificate);
        pnlControllerTop.Controls.Add(btnClearCertStore);
        pnlControllerTop.Controls.Add(lblRestartMode);
        pnlControllerTop.Controls.Add(cbRestartMode);
        pnlControllerTop.Controls.Add(btnRestart);
        pnlControllerTop.Dock = DockStyle.Fill;
        pnlControllerTop.Location = new Point(3, 3);
        pnlControllerTop.Name = "pnlControllerTop";
        pnlControllerTop.Size = new Size(886, 115);
        pnlControllerTop.TabIndex = 0;
        // 
        // btnGetIdentity
        // 
        btnGetIdentity.Location = new Point(10, 10);
        btnGetIdentity.Name = "btnGetIdentity";
        btnGetIdentity.Size = new Size(100, 25);
        btnGetIdentity.TabIndex = 0;
        btnGetIdentity.Text = "Get Identity";
        btnGetIdentity.UseVisualStyleBackColor = true;
        btnGetIdentity.Click += btnGetIdentity_Click;
        // 
        // btnGetDateTime
        // 
        btnGetDateTime.Location = new Point(120, 10);
        btnGetDateTime.Name = "btnGetDateTime";
        btnGetDateTime.Size = new Size(100, 25);
        btnGetDateTime.TabIndex = 1;
        btnGetDateTime.Text = "Get DateTime";
        btnGetDateTime.UseVisualStyleBackColor = true;
        btnGetDateTime.Click += btnGetDateTime_Click;
        // 
        // lblSetDateTime
        // 
        lblSetDateTime.AutoSize = true;
        lblSetDateTime.Location = new Point(230, 15);
        lblSetDateTime.Name = "lblSetDateTime";
        lblSetDateTime.Size = new Size(43, 15);
        lblSetDateTime.TabIndex = 2;
        lblSetDateTime.Text = "Set DT:";
        // 
        // txtSetDateTime
        // 
        txtSetDateTime.Location = new Point(285, 11);
        txtSetDateTime.Name = "txtSetDateTime";
        txtSetDateTime.Size = new Size(140, 23);
        txtSetDateTime.TabIndex = 3;
        txtSetDateTime.Text = "2026-02-20T12:00:00";
        // 
        // btnSetDateTime
        // 
        btnSetDateTime.Location = new Point(435, 10);
        btnSetDateTime.Name = "btnSetDateTime";
        btnSetDateTime.Size = new Size(70, 25);
        btnSetDateTime.TabIndex = 4;
        btnSetDateTime.Text = "Set DT";
        btnSetDateTime.UseVisualStyleBackColor = true;
        btnSetDateTime.Click += btnSetDateTime_Click;
        // 
        // btnGetTimezone
        // 
        btnGetTimezone.Location = new Point(10, 45);
        btnGetTimezone.Name = "btnGetTimezone";
        btnGetTimezone.Size = new Size(100, 25);
        btnGetTimezone.TabIndex = 5;
        btnGetTimezone.Text = "Get Timezone";
        btnGetTimezone.UseVisualStyleBackColor = true;
        btnGetTimezone.Click += btnGetTimezone_Click;
        // 
        // lblTimezone
        // 
        lblTimezone.AutoSize = true;
        lblTimezone.Location = new Point(120, 50);
        lblTimezone.Name = "lblTimezone";
        lblTimezone.Size = new Size(62, 15);
        lblTimezone.TabIndex = 6;
        lblTimezone.Text = "Timezone:";
        // 
        // txtTimezone
        // 
        txtTimezone.Location = new Point(180, 46);
        txtTimezone.Name = "txtTimezone";
        txtTimezone.Size = new Size(120, 23);
        txtTimezone.TabIndex = 7;
        txtTimezone.Text = "Europe/Paris";
        // 
        // btnSetTimezone
        // 
        btnSetTimezone.Location = new Point(310, 45);
        btnSetTimezone.Name = "btnSetTimezone";
        btnSetTimezone.Size = new Size(80, 25);
        btnSetTimezone.TabIndex = 8;
        btnSetTimezone.Text = "Set TZ";
        btnSetTimezone.UseVisualStyleBackColor = true;
        btnSetTimezone.Click += btnSetTimezone_Click;
        // 
        // btnGetTimeserver
        // 
        btnGetTimeserver.Location = new Point(10, 80);
        btnGetTimeserver.Name = "btnGetTimeserver";
        btnGetTimeserver.Size = new Size(110, 25);
        btnGetTimeserver.TabIndex = 9;
        btnGetTimeserver.Text = "Get Timeserver";
        btnGetTimeserver.UseVisualStyleBackColor = true;
        btnGetTimeserver.Click += btnGetTimeserver_Click;
        // 
        // lblTimeserver
        // 
        lblTimeserver.AutoSize = true;
        lblTimeserver.Location = new Point(130, 85);
        lblTimeserver.Name = "lblTimeserver";
        lblTimeserver.Size = new Size(68, 15);
        lblTimeserver.TabIndex = 10;
        lblTimeserver.Text = "NTP Server:";
        // 
        // txtTimeserver
        // 
        txtTimeserver.Location = new Point(200, 81);
        txtTimeserver.Name = "txtTimeserver";
        txtTimeserver.Size = new Size(150, 23);
        txtTimeserver.TabIndex = 11;
        txtTimeserver.Text = "pool.ntp.org";
        // 
        // btnSetTimeserver
        // 
        btnSetTimeserver.Location = new Point(360, 80);
        btnSetTimeserver.Name = "btnSetTimeserver";
        btnSetTimeserver.Size = new Size(90, 25);
        btnSetTimeserver.TabIndex = 12;
        btnSetTimeserver.Text = "Set Server";
        btnSetTimeserver.UseVisualStyleBackColor = true;
        btnSetTimeserver.Click += btnSetTimeserver_Click;
        // 
        // lblEnvName
        // 
        lblEnvName.AutoSize = true;
        lblEnvName.Location = new Point(10, 120);
        lblEnvName.Name = "lblEnvName";
        lblEnvName.Size = new Size(62, 15);
        lblEnvName.TabIndex = 13;
        lblEnvName.Text = "Env name:";
        // 
        // txtEnvName
        // 
        txtEnvName.Location = new Point(85, 116);
        txtEnvName.Name = "txtEnvName";
        txtEnvName.Size = new Size(150, 23);
        txtEnvName.TabIndex = 14;
        txtEnvName.Text = "LANG";
        // 
        // btnGetEnvVar
        // 
        btnGetEnvVar.Location = new Point(245, 115);
        btnGetEnvVar.Name = "btnGetEnvVar";
        btnGetEnvVar.Size = new Size(90, 25);
        btnGetEnvVar.TabIndex = 15;
        btnGetEnvVar.Text = "Get Env Var";
        btnGetEnvVar.UseVisualStyleBackColor = true;
        btnGetEnvVar.Click += btnGetEnvVar_Click;
        // 
        // lblLangCode
        // 
        lblLangCode.AutoSize = true;
        lblLangCode.Location = new Point(350, 120);
        lblLangCode.Name = "lblLangCode";
        lblLangCode.Size = new Size(62, 15);
        lblLangCode.TabIndex = 16;
        lblLangCode.Text = "Language:";
        // 
        // txtLangCode
        // 
        txtLangCode.Location = new Point(420, 116);
        txtLangCode.Name = "txtLangCode";
        txtLangCode.Size = new Size(80, 23);
        txtLangCode.TabIndex = 17;
        txtLangCode.Text = "en";
        // 
        // btnSetLanguage
        // 
        btnSetLanguage.Location = new Point(510, 115);
        btnSetLanguage.Name = "btnSetLanguage";
        btnSetLanguage.Size = new Size(100, 25);
        btnSetLanguage.TabIndex = 18;
        btnSetLanguage.Text = "Set Language";
        btnSetLanguage.UseVisualStyleBackColor = true;
        btnSetLanguage.Click += btnSetLanguage_Click;
        // 
        // lblBackupPath
        // 
        lblBackupPath.AutoSize = true;
        lblBackupPath.Location = new Point(10, 160);
        lblBackupPath.Name = "lblBackupPath";
        lblBackupPath.Size = new Size(76, 15);
        lblBackupPath.TabIndex = 19;
        lblBackupPath.Text = "Backup Path:";
        // 
        // txtBackupPath
        // 
        txtBackupPath.Location = new Point(90, 156);
        txtBackupPath.Name = "txtBackupPath";
        txtBackupPath.Size = new Size(250, 23);
        txtBackupPath.TabIndex = 20;
        txtBackupPath.Text = "$home/backup.zip";
        // 
        // btnGetBackupInfo
        // 
        btnGetBackupInfo.Location = new Point(350, 155);
        btnGetBackupInfo.Name = "btnGetBackupInfo";
        btnGetBackupInfo.Size = new Size(90, 25);
        btnGetBackupInfo.TabIndex = 21;
        btnGetBackupInfo.Text = "Backup Info";
        btnGetBackupInfo.UseVisualStyleBackColor = true;
        btnGetBackupInfo.Click += btnGetBackupInfo_Click;
        // 
        // btnGetBackupState
        // 
        btnGetBackupState.Location = new Point(450, 155);
        btnGetBackupState.Name = "btnGetBackupState";
        btnGetBackupState.Size = new Size(95, 25);
        btnGetBackupState.TabIndex = 22;
        btnGetBackupState.Text = "Backup State";
        btnGetBackupState.UseVisualStyleBackColor = true;
        btnGetBackupState.Click += btnGetBackupState_Click;
        // 
        // btnCreateBackup
        // 
        btnCreateBackup.Location = new Point(10, 190);
        btnCreateBackup.Name = "btnCreateBackup";
        btnCreateBackup.Size = new Size(100, 25);
        btnCreateBackup.TabIndex = 23;
        btnCreateBackup.Text = "Create Backup";
        btnCreateBackup.UseVisualStyleBackColor = true;
        btnCreateBackup.Click += btnCreateBackup_Click;
        // 
        // btnRestoreBackup
        // 
        btnRestoreBackup.Location = new Point(120, 190);
        btnRestoreBackup.Name = "btnRestoreBackup";
        btnRestoreBackup.Size = new Size(110, 25);
        btnRestoreBackup.TabIndex = 24;
        btnRestoreBackup.Text = "Restore Backup";
        btnRestoreBackup.UseVisualStyleBackColor = true;
        btnRestoreBackup.Click += btnRestoreBackup_Click;
        // 
        // btnCheckRestore
        // 
        btnCheckRestore.Location = new Point(240, 190);
        btnCheckRestore.Name = "btnCheckRestore";
        btnCheckRestore.Size = new Size(100, 25);
        btnCheckRestore.TabIndex = 25;
        btnCheckRestore.Text = "Check Restore";
        btnCheckRestore.UseVisualStyleBackColor = true;
        btnCheckRestore.Click += btnCheckRestore_Click;
        // 
        // btnCompress
        // 
        btnCompress.Location = new Point(350, 190);
        btnCompress.Name = "btnCompress";
        btnCompress.Size = new Size(80, 25);
        btnCompress.TabIndex = 26;
        btnCompress.Text = "Compress";
        btnCompress.UseVisualStyleBackColor = true;
        btnCompress.Click += btnCompress_Click;
        // 
        // btnDecompress
        // 
        btnDecompress.Location = new Point(440, 190);
        btnDecompress.Name = "btnDecompress";
        btnDecompress.Size = new Size(95, 25);
        btnDecompress.TabIndex = 27;
        btnDecompress.Text = "Decompress";
        btnDecompress.UseVisualStyleBackColor = true;
        btnDecompress.Click += btnDecompress_Click;
        // 
        // btnGetCertStores
        // 
        btnGetCertStores.Location = new Point(10, 230);
        btnGetCertStores.Name = "btnGetCertStores";
        btnGetCertStores.Size = new Size(110, 25);
        btnGetCertStores.TabIndex = 28;
        btnGetCertStores.Text = "Get Cert Stores";
        btnGetCertStores.UseVisualStyleBackColor = true;
        btnGetCertStores.Click += btnGetCertStores_Click;
        // 
        // lblCertStoreGroup
        // 
        lblCertStoreGroup.AutoSize = true;
        lblCertStoreGroup.Location = new Point(130, 235);
        lblCertStoreGroup.Name = "lblCertStoreGroup";
        lblCertStoreGroup.Size = new Size(43, 15);
        lblCertStoreGroup.TabIndex = 29;
        lblCertStoreGroup.Text = "Group:";
        // 
        // txtCertStoreGroup
        // 
        txtCertStoreGroup.Location = new Point(180, 231);
        txtCertStoreGroup.Name = "txtCertStoreGroup";
        txtCertStoreGroup.Size = new Size(100, 23);
        txtCertStoreGroup.TabIndex = 30;
        txtCertStoreGroup.Text = "https-client";
        // 
        // lblCertStoreName
        // 
        lblCertStoreName.AutoSize = true;
        lblCertStoreName.Location = new Point(290, 235);
        lblCertStoreName.Name = "lblCertStoreName";
        lblCertStoreName.Size = new Size(42, 15);
        lblCertStoreName.TabIndex = 31;
        lblCertStoreName.Text = "Name:";
        // 
        // txtCertStoreName
        // 
        txtCertStoreName.Location = new Point(340, 231);
        txtCertStoreName.Name = "txtCertStoreName";
        txtCertStoreName.Size = new Size(100, 23);
        txtCertStoreName.TabIndex = 32;
        txtCertStoreName.Text = "root-ca";
        // 
        // btnGetCertificate
        // 
        btnGetCertificate.Location = new Point(450, 230);
        btnGetCertificate.Name = "btnGetCertificate";
        btnGetCertificate.Size = new Size(80, 25);
        btnGetCertificate.TabIndex = 33;
        btnGetCertificate.Text = "Get Cert";
        btnGetCertificate.UseVisualStyleBackColor = true;
        btnGetCertificate.Click += btnGetCertificate_Click;
        // 
        // btnClearCertStore
        // 
        btnClearCertStore.Location = new Point(540, 230);
        btnClearCertStore.Name = "btnClearCertStore";
        btnClearCertStore.Size = new Size(100, 25);
        btnClearCertStore.TabIndex = 34;
        btnClearCertStore.Text = "Clear Store";
        btnClearCertStore.UseVisualStyleBackColor = true;
        btnClearCertStore.Click += btnClearCertStore_Click;
        // 
        // lblRestartMode
        // 
        lblRestartMode.AutoSize = true;
        lblRestartMode.Location = new Point(10, 275);
        lblRestartMode.Name = "lblRestartMode";
        lblRestartMode.Size = new Size(80, 15);
        lblRestartMode.TabIndex = 35;
        lblRestartMode.Text = "Restart Mode:";
        // 
        // cbRestartMode
        // 
        cbRestartMode.DropDownStyle = ComboBoxStyle.DropDownList;
        cbRestartMode.FormattingEnabled = true;
        cbRestartMode.Items.AddRange(new object[] { "Restart (0)", "Shutdown (1)", "Boot application (2)", "Shutdown application (3)" });
        cbRestartMode.Location = new Point(100, 271);
        cbRestartMode.Name = "cbRestartMode";
        cbRestartMode.Size = new Size(160, 23);
        cbRestartMode.TabIndex = 36;
        // 
        // btnRestart
        // 
        btnRestart.Location = new Point(270, 270);
        btnRestart.Name = "btnRestart";
        btnRestart.Size = new Size(80, 25);
        btnRestart.TabIndex = 37;
        btnRestart.Text = "Restart";
        btnRestart.UseVisualStyleBackColor = true;
        btnRestart.Click += btnRestart_Click;
        // 
        // tabPanel
        // 
        tabPanel.Controls.Add(pnlPanelTop);
        tabPanel.Location = new Point(4, 24);
        tabPanel.Name = "tabPanel";
        tabPanel.Padding = new Padding(3);
        tabPanel.Size = new Size(892, 121);
        tabPanel.TabIndex = 1;
        tabPanel.Text = "Panel";
        tabPanel.UseVisualStyleBackColor = true;
        // 
        // pnlPanelTop
        // 
        pnlPanelTop.AutoScroll = true;
        pnlPanelTop.Controls.Add(btnGetOpMode);
        pnlPanelTop.Controls.Add(btnGetCtrlState);
        pnlPanelTop.Controls.Add(lblSpeed);
        pnlPanelTop.Controls.Add(nudSpeedRatio);
        pnlPanelTop.Controls.Add(btnKeylessMotorOn);
        pnlPanelTop.Controls.Add(btnGetEnablingDevRequired);
        pnlPanelTop.Dock = DockStyle.Fill;
        pnlPanelTop.Location = new Point(3, 3);
        pnlPanelTop.Name = "pnlPanelTop";
        pnlPanelTop.Size = new Size(886, 115);
        pnlPanelTop.TabIndex = 0;
        // 
        // btnGetOpMode
        // 
        btnGetOpMode.Location = new Point(10, 8);
        btnGetOpMode.Name = "btnGetOpMode";
        btnGetOpMode.Size = new Size(110, 25);
        btnGetOpMode.TabIndex = 0;
        btnGetOpMode.Text = "Get Op Mode";
        btnGetOpMode.UseVisualStyleBackColor = true;
        btnGetOpMode.Click += btnGetOpMode_Click;
        // 
        // btnGetCtrlState
        // 
        btnGetCtrlState.Location = new Point(130, 8);
        btnGetCtrlState.Name = "btnGetCtrlState";
        btnGetCtrlState.Size = new Size(110, 25);
        btnGetCtrlState.TabIndex = 1;
        btnGetCtrlState.Text = "Get Ctrl State";
        btnGetCtrlState.UseVisualStyleBackColor = true;
        btnGetCtrlState.Click += btnGetCtrlState_Click;
        // 
        // btnGetSpeedRatio
        // 
        btnGetSpeedRatio.Location = new Point(290, 245);
        btnGetSpeedRatio.Name = "btnGetSpeedRatio";
        btnGetSpeedRatio.Size = new Size(110, 25);
        btnGetSpeedRatio.TabIndex = 44;
        btnGetSpeedRatio.Text = "Get Speed Ratio";
        btnGetSpeedRatio.UseVisualStyleBackColor = true;
        btnGetSpeedRatio.Click += btnGetSpeedRatio_Click;
        // 
        // lblSpeed
        // 
        lblSpeed.AutoSize = true;
        lblSpeed.Location = new Point(10, 44);
        lblSpeed.Name = "lblSpeed";
        lblSpeed.Size = new Size(55, 15);
        lblSpeed.TabIndex = 3;
        lblSpeed.Text = "Speed %:";
        // 
        // nudSpeedRatio
        // 
        nudSpeedRatio.Location = new Point(80, 40);
        nudSpeedRatio.Name = "nudSpeedRatio";
        nudSpeedRatio.Size = new Size(60, 23);
        nudSpeedRatio.TabIndex = 4;
        nudSpeedRatio.Value = new decimal(new int[] { 50, 0, 0, 0 });
        // 
        // btnSetSpeedRatio
        // 
        btnSetSpeedRatio.Location = new Point(170, 245);
        btnSetSpeedRatio.Name = "btnSetSpeedRatio";
        btnSetSpeedRatio.Size = new Size(110, 25);
        btnSetSpeedRatio.TabIndex = 43;
        btnSetSpeedRatio.Text = "Set Speed Ratio";
        btnSetSpeedRatio.UseVisualStyleBackColor = true;
        btnSetSpeedRatio.Click += btnSetSpeedRatio_Click;
        // 
        // btnKeylessMotorOn
        // 
        btnKeylessMotorOn.Location = new Point(10, 75);
        btnKeylessMotorOn.Name = "btnKeylessMotorOn";
        btnKeylessMotorOn.Size = new Size(130, 25);
        btnKeylessMotorOn.TabIndex = 6;
        btnKeylessMotorOn.Text = "Keyless Motor On";
        btnKeylessMotorOn.UseVisualStyleBackColor = true;
        btnKeylessMotorOn.Click += btnKeylessMotorOn_Click;
        // 
        // btnGetEnablingDevRequired
        // 
        btnGetEnablingDevRequired.Location = new Point(150, 75);
        btnGetEnablingDevRequired.Name = "btnGetEnablingDevRequired";
        btnGetEnablingDevRequired.Size = new Size(160, 25);
        btnGetEnablingDevRequired.TabIndex = 7;
        btnGetEnablingDevRequired.Text = "Get Enabling Dev Req";
        btnGetEnablingDevRequired.UseVisualStyleBackColor = true;
        btnGetEnablingDevRequired.Click += btnGetEnablingDevRequired_Click;
        // 
        // tabIO
        // 
        tabIO.Controls.Add(pnlIOTop);
        tabIO.Location = new Point(4, 24);
        tabIO.Name = "tabIO";
        tabIO.Padding = new Padding(3);
        tabIO.Size = new Size(892, 121);
        tabIO.TabIndex = 2;
        tabIO.Text = "IO";
        tabIO.UseVisualStyleBackColor = true;
        // 
        // pnlIOTop
        // 
        pnlIOTop.Controls.Add(btnGetNetworks);
        pnlIOTop.Controls.Add(btnGetAllSignals);
        pnlIOTop.Controls.Add(lblIONetwork);
        pnlIOTop.Controls.Add(txtIONetwork);
        pnlIOTop.Controls.Add(lblIODevice);
        pnlIOTop.Controls.Add(txtIODevice);
        pnlIOTop.Controls.Add(lblIOSignal);
        pnlIOTop.Controls.Add(txtIOSignal);
        pnlIOTop.Controls.Add(btnGetSignal);
        pnlIOTop.Controls.Add(lblIOValue);
        pnlIOTop.Controls.Add(txtIOValue);
        pnlIOTop.Controls.Add(btnSetSignalVal);
        pnlIOTop.Dock = DockStyle.Fill;
        pnlIOTop.Location = new Point(3, 3);
        pnlIOTop.Name = "pnlIOTop";
        pnlIOTop.Size = new Size(886, 115);
        pnlIOTop.TabIndex = 0;
        // 
        // btnGetNetworks
        // 
        btnGetNetworks.Location = new Point(10, 8);
        btnGetNetworks.Name = "btnGetNetworks";
        btnGetNetworks.Size = new Size(110, 25);
        btnGetNetworks.TabIndex = 0;
        btnGetNetworks.Text = "Get Networks";
        btnGetNetworks.UseVisualStyleBackColor = true;
        btnGetNetworks.Click += btnGetNetworks_Click;
        // 
        // btnGetAllSignals
        // 
        btnGetAllSignals.Location = new Point(130, 8);
        btnGetAllSignals.Name = "btnGetAllSignals";
        btnGetAllSignals.Size = new Size(110, 25);
        btnGetAllSignals.TabIndex = 1;
        btnGetAllSignals.Text = "Get All Signals";
        btnGetAllSignals.UseVisualStyleBackColor = true;
        btnGetAllSignals.Click += btnGetAllSignals_Click;
        // 
        // lblIONetwork
        // 
        lblIONetwork.AutoSize = true;
        lblIONetwork.Location = new Point(10, 42);
        lblIONetwork.Name = "lblIONetwork";
        lblIONetwork.Size = new Size(55, 15);
        lblIONetwork.TabIndex = 5;
        lblIONetwork.Text = "Network:";
        // 
        // txtIONetwork
        // 
        txtIONetwork.Location = new Point(75, 38);
        txtIONetwork.Name = "txtIONetwork";
        txtIONetwork.Size = new Size(90, 23);
        txtIONetwork.TabIndex = 6;
        // 
        // lblIODevice
        // 
        lblIODevice.AutoSize = true;
        lblIODevice.Location = new Point(175, 42);
        lblIODevice.Name = "lblIODevice";
        lblIODevice.Size = new Size(45, 15);
        lblIODevice.TabIndex = 7;
        lblIODevice.Text = "Device:";
        // 
        // txtIODevice
        // 
        txtIODevice.Location = new Point(228, 38);
        txtIODevice.Name = "txtIODevice";
        txtIODevice.Size = new Size(90, 23);
        txtIODevice.TabIndex = 8;
        // 
        // lblIOSignal
        // 
        lblIOSignal.AutoSize = true;
        lblIOSignal.Location = new Point(328, 42);
        lblIOSignal.Name = "lblIOSignal";
        lblIOSignal.Size = new Size(42, 15);
        lblIOSignal.TabIndex = 9;
        lblIOSignal.Text = "Signal:";
        // 
        // txtIOSignal
        // 
        txtIOSignal.Location = new Point(378, 38);
        txtIOSignal.Name = "txtIOSignal";
        txtIOSignal.Size = new Size(90, 23);
        txtIOSignal.TabIndex = 10;
        // 
        // btnGetSignal
        // 
        btnGetSignal.Location = new Point(10, 68);
        btnGetSignal.Name = "btnGetSignal";
        btnGetSignal.Size = new Size(90, 25);
        btnGetSignal.TabIndex = 11;
        btnGetSignal.Text = "Get Signal";
        btnGetSignal.UseVisualStyleBackColor = true;
        btnGetSignal.Click += btnGetSignal_Click;
        // 
        // lblIOValue
        // 
        lblIOValue.AutoSize = true;
        lblIOValue.Location = new Point(110, 72);
        lblIOValue.Name = "lblIOValue";
        lblIOValue.Size = new Size(38, 15);
        lblIOValue.TabIndex = 12;
        lblIOValue.Text = "Value:";
        // 
        // txtIOValue
        // 
        txtIOValue.Location = new Point(155, 68);
        txtIOValue.Name = "txtIOValue";
        txtIOValue.Size = new Size(60, 23);
        txtIOValue.TabIndex = 13;
        // 
        // btnSetSignalVal
        // 
        btnSetSignalVal.Location = new Point(225, 68);
        btnSetSignalVal.Name = "btnSetSignalVal";
        btnSetSignalVal.Size = new Size(80, 25);
        btnSetSignalVal.TabIndex = 14;
        btnSetSignalVal.Text = "Set Value";
        btnSetSignalVal.UseVisualStyleBackColor = true;
        btnSetSignalVal.Click += btnSetSignalVal_Click;
        // 
        // tabRapid
        // 
        tabRapid.Controls.Add(pnlRapidTop);
        tabRapid.Location = new Point(4, 24);
        tabRapid.Name = "tabRapid";
        tabRapid.Padding = new Padding(3);
        tabRapid.Size = new Size(892, 272);
        tabRapid.TabIndex = 3;
        tabRapid.Text = "RAPID";
        tabRapid.UseVisualStyleBackColor = true;
        // 
        // pnlRapidTop
        // 
        pnlRapidTop.AutoScroll = true;
        pnlRapidTop.Controls.Add(btnGetExecState);
        pnlRapidTop.Controls.Add(btnStartExec);
        pnlRapidTop.Controls.Add(btnStopExec);
        pnlRapidTop.Controls.Add(btnResetPP);
        pnlRapidTop.Controls.Add(btnGetTasks);
        pnlRapidTop.Controls.Add(lblTask);
        pnlRapidTop.Controls.Add(txtTask);
        pnlRapidTop.Controls.Add(btnGetModules);
        pnlRapidTop.Controls.Add(lblSymbol);
        pnlRapidTop.Controls.Add(txtSymbolUrl);
        pnlRapidTop.Controls.Add(btnGetSymbol);
        pnlRapidTop.Controls.Add(txtSymbolVal);
        pnlRapidTop.Controls.Add(btnSetSymbol);
        pnlRapidTop.Dock = DockStyle.Fill;
        pnlRapidTop.Location = new Point(3, 3);
        pnlRapidTop.Name = "pnlRapidTop";
        pnlRapidTop.Size = new Size(886, 266);
        pnlRapidTop.TabIndex = 0;
        // 
        // btnGetExecState
        // 
        btnGetExecState.Location = new Point(10, 8);
        btnGetExecState.Name = "btnGetExecState";
        btnGetExecState.Size = new Size(90, 25);
        btnGetExecState.TabIndex = 0;
        btnGetExecState.Text = "Exec State";
        btnGetExecState.UseVisualStyleBackColor = true;
        btnGetExecState.Click += btnGetExecState_Click;
        // 
        // btnStartExec
        // 
        btnStartExec.Location = new Point(110, 8);
        btnStartExec.Name = "btnStartExec";
        btnStartExec.Size = new Size(60, 25);
        btnStartExec.TabIndex = 1;
        btnStartExec.Text = "Start";
        btnStartExec.UseVisualStyleBackColor = true;
        btnStartExec.Click += btnStartExec_Click;
        // 
        // btnStopExec
        // 
        btnStopExec.Location = new Point(180, 8);
        btnStopExec.Name = "btnStopExec";
        btnStopExec.Size = new Size(60, 25);
        btnStopExec.TabIndex = 2;
        btnStopExec.Text = "Stop";
        btnStopExec.UseVisualStyleBackColor = true;
        btnStopExec.Click += btnStopExec_Click;
        // 
        // btnResetPP
        // 
        btnResetPP.Location = new Point(250, 8);
        btnResetPP.Name = "btnResetPP";
        btnResetPP.Size = new Size(75, 25);
        btnResetPP.TabIndex = 3;
        btnResetPP.Text = "Reset PP";
        btnResetPP.UseVisualStyleBackColor = true;
        btnResetPP.Click += btnResetPP_Click;
        // 
        // btnGetTasks
        // 
        btnGetTasks.Location = new Point(10, 38);
        btnGetTasks.Name = "btnGetTasks";
        btnGetTasks.Size = new Size(80, 25);
        btnGetTasks.TabIndex = 4;
        btnGetTasks.Text = "Get Tasks";
        btnGetTasks.UseVisualStyleBackColor = true;
        btnGetTasks.Click += btnGetTasks_Click;
        // 
        // lblTask
        // 
        lblTask.AutoSize = true;
        lblTask.Location = new Point(10, 72);
        lblTask.Name = "lblTask";
        lblTask.Size = new Size(33, 15);
        lblTask.TabIndex = 5;
        lblTask.Text = "Task:";
        // 
        // txtTask
        // 
        txtTask.Location = new Point(50, 68);
        txtTask.Name = "txtTask";
        txtTask.Size = new Size(100, 23);
        txtTask.TabIndex = 6;
        txtTask.Text = "T_ROB1";
        // 
        // btnGetModules
        // 
        btnGetModules.Location = new Point(160, 68);
        btnGetModules.Name = "btnGetModules";
        btnGetModules.Size = new Size(100, 25);
        btnGetModules.TabIndex = 7;
        btnGetModules.Text = "Get Modules";
        btnGetModules.UseVisualStyleBackColor = true;
        btnGetModules.Click += btnGetModules_Click;
        // 
        // lblSymbol
        // 
        lblSymbol.AutoSize = true;
        lblSymbol.Location = new Point(10, 102);
        lblSymbol.Name = "lblSymbol";
        lblSymbol.Size = new Size(50, 15);
        lblSymbol.TabIndex = 8;
        lblSymbol.Text = "Symbol:";
        // 
        // txtSymbolUrl
        // 
        txtSymbolUrl.Location = new Point(65, 98);
        txtSymbolUrl.Name = "txtSymbolUrl";
        txtSymbolUrl.Size = new Size(180, 23);
        txtSymbolUrl.TabIndex = 9;
        txtSymbolUrl.Text = "T_ROB1/Module1/myVar";
        // 
        // btnGetSymbol
        // 
        btnGetSymbol.Location = new Point(255, 98);
        btnGetSymbol.Name = "btnGetSymbol";
        btnGetSymbol.Size = new Size(50, 25);
        btnGetSymbol.TabIndex = 10;
        btnGetSymbol.Text = "Get";
        btnGetSymbol.UseVisualStyleBackColor = true;
        btnGetSymbol.Click += btnGetSymbol_Click;
        // 
        // txtSymbolVal
        // 
        txtSymbolVal.Location = new Point(315, 98);
        txtSymbolVal.Name = "txtSymbolVal";
        txtSymbolVal.Size = new Size(100, 23);
        txtSymbolVal.TabIndex = 11;
        // 
        // btnSetSymbol
        // 
        btnSetSymbol.Location = new Point(425, 98);
        btnSetSymbol.Name = "btnSetSymbol";
        btnSetSymbol.Size = new Size(50, 25);
        btnSetSymbol.TabIndex = 12;
        btnSetSymbol.Text = "Set";
        btnSetSymbol.UseVisualStyleBackColor = true;
        btnSetSymbol.Click += btnSetSymbol_Click;
        // 
        // tabFile
        // 
        tabFile.Controls.Add(pnlFileTop);
        tabFile.Location = new Point(4, 24);
        tabFile.Name = "tabFile";
        tabFile.Padding = new Padding(3);
        tabFile.Size = new Size(892, 121);
        tabFile.TabIndex = 4;
        tabFile.Text = "File";
        tabFile.UseVisualStyleBackColor = true;
        // 
        // pnlFileTop
        // 
        pnlFileTop.AutoScroll = true;
        pnlFileTop.Controls.Add(btnGetFsDevices);
        pnlFileTop.Controls.Add(lblDirPath);
        pnlFileTop.Controls.Add(txtDirPath);
        pnlFileTop.Controls.Add(btnListDir);
        pnlFileTop.Controls.Add(lblFilePath);
        pnlFileTop.Controls.Add(txtFilePath);
        pnlFileTop.Controls.Add(btnGetFileContent);
        pnlFileTop.Controls.Add(lblUploadPath);
        pnlFileTop.Controls.Add(txtUploadPath);
        pnlFileTop.Controls.Add(lblCreatePath);
        pnlFileTop.Controls.Add(txtCreatePath);
        pnlFileTop.Controls.Add(btnCreateFolder);
        pnlFileTop.Controls.Add(btnDeleteFolder);
        pnlFileTop.Controls.Add(btnMoveFile);
        pnlFileTop.Controls.Add(btnUploadBackup);
        pnlFileTop.Controls.Add(btnDownloadBackup);
        pnlFileTop.Controls.Add(btnGetFileInfo);
        pnlFileTop.Controls.Add(btnGetFileProperty);
        pnlFileTop.Controls.Add(btnSetFileProperty);
        pnlFileTop.Dock = DockStyle.Fill;
        pnlFileTop.Location = new Point(3, 3);
        pnlFileTop.Name = "pnlFileTop";
        pnlFileTop.Size = new Size(886, 115);
        pnlFileTop.TabIndex = 0;
        // 
        // btnGetFsDevices
        // 
        btnGetFsDevices.Location = new Point(10, 8);
        btnGetFsDevices.Name = "btnGetFsDevices";
        btnGetFsDevices.Size = new Size(100, 25);
        btnGetFsDevices.TabIndex = 0;
        btnGetFsDevices.Text = "Get Devices";
        btnGetFsDevices.UseVisualStyleBackColor = true;
        btnGetFsDevices.Click += btnGetFsDevices_Click;
        // 
        // lblDirPath
        // 
        lblDirPath.AutoSize = true;
        lblDirPath.Location = new Point(10, 42);
        lblDirPath.Name = "lblDirPath";
        lblDirPath.Size = new Size(34, 15);
        lblDirPath.TabIndex = 1;
        lblDirPath.Text = "Path:";
        // 
        // txtDirPath
        // 
        txtDirPath.Location = new Point(50, 38);
        txtDirPath.Name = "txtDirPath";
        txtDirPath.Size = new Size(250, 23);
        txtDirPath.TabIndex = 2;
        txtDirPath.Text = "$home";
        // 
        // btnListDir
        // 
        btnListDir.Location = new Point(310, 38);
        btnListDir.Name = "btnListDir";
        btnListDir.Size = new Size(80, 25);
        btnListDir.TabIndex = 3;
        btnListDir.Text = "List Dir";
        btnListDir.UseVisualStyleBackColor = true;
        btnListDir.Click += btnListDir_Click;
        // 
        // lblFilePath
        // 
        lblFilePath.AutoSize = true;
        lblFilePath.Location = new Point(10, 72);
        lblFilePath.Name = "lblFilePath";
        lblFilePath.Size = new Size(28, 15);
        lblFilePath.TabIndex = 4;
        lblFilePath.Text = "File:";
        // 
        // txtFilePath
        // 
        txtFilePath.Location = new Point(50, 68);
        txtFilePath.Name = "txtFilePath";
        txtFilePath.Size = new Size(250, 23);
        txtFilePath.TabIndex = 5;
        // 
        // btnGetFileContent
        // 
        btnGetFileContent.Location = new Point(310, 68);
        btnGetFileContent.Name = "btnGetFileContent";
        btnGetFileContent.Size = new Size(90, 25);
        btnGetFileContent.TabIndex = 6;
        btnGetFileContent.Text = "Get Content";
        btnGetFileContent.UseVisualStyleBackColor = true;
        btnGetFileContent.Click += btnGetFileContent_Click;
        // 
        // lblUploadPath
        // 
        lblUploadPath.AutoSize = true;
        lblUploadPath.Location = new Point(10, 48);
        lblUploadPath.Name = "lblUploadPath";
        lblUploadPath.Size = new Size(75, 15);
        lblUploadPath.TabIndex = 7;
        lblUploadPath.Text = "Upload Path:";
        // 
        // txtUploadPath
        // 
        txtUploadPath.Location = new Point(90, 43);
        txtUploadPath.Name = "txtUploadPath";
        txtUploadPath.Size = new Size(250, 23);
        txtUploadPath.TabIndex = 8;
        // 
        // lblCreatePath
        // 
        lblCreatePath.AutoSize = true;
        lblCreatePath.Location = new Point(10, 83);
        lblCreatePath.Name = "lblCreatePath";
        lblCreatePath.Size = new Size(71, 15);
        lblCreatePath.TabIndex = 11;
        lblCreatePath.Text = "Create Path:";
        // 
        // txtCreatePath
        // 
        txtCreatePath.Location = new Point(90, 78);
        txtCreatePath.Name = "txtCreatePath";
        txtCreatePath.Size = new Size(250, 23);
        txtCreatePath.TabIndex = 12;
        // 
        // btnCreateFolder
        // 
        btnCreateFolder.Location = new Point(350, 78);
        btnCreateFolder.Name = "btnCreateFolder";
        btnCreateFolder.Size = new Size(95, 25);
        btnCreateFolder.TabIndex = 13;
        btnCreateFolder.Text = "Create Folder";
        btnCreateFolder.UseVisualStyleBackColor = true;
        btnCreateFolder.Click += btnCreateFolder_Click;
        // 
        // btnDeleteFolder
        // 
        btnDeleteFolder.Location = new Point(455, 78);
        btnDeleteFolder.Name = "btnDeleteFolder";
        btnDeleteFolder.Size = new Size(95, 25);
        btnDeleteFolder.TabIndex = 14;
        btnDeleteFolder.Text = "Delete Folder";
        btnDeleteFolder.UseVisualStyleBackColor = true;
        btnDeleteFolder.Click += btnDeleteFolder_Click;
        // 
        // btnMoveFile
        // 
        btnMoveFile.Location = new Point(740, 78);
        btnMoveFile.Name = "btnMoveFile";
        btnMoveFile.Size = new Size(75, 25);
        btnMoveFile.TabIndex = 17;
        btnMoveFile.Text = "Move File";
        btnMoveFile.UseVisualStyleBackColor = true;
        btnMoveFile.Click += btnMoveFile_Click;
        // 
        // btnUploadBackup
        // 
        btnUploadBackup.Location = new Point(10, 113);
        btnUploadBackup.Name = "btnUploadBackup";
        btnUploadBackup.Size = new Size(105, 25);
        btnUploadBackup.TabIndex = 18;
        btnUploadBackup.Text = "Upload Backup";
        btnUploadBackup.UseVisualStyleBackColor = true;
        btnUploadBackup.Click += btnUploadBackup_Click;
        // 
        // btnDownloadBackup
        // 
        btnDownloadBackup.Location = new Point(125, 113);
        btnDownloadBackup.Name = "btnDownloadBackup";
        btnDownloadBackup.Size = new Size(115, 25);
        btnDownloadBackup.TabIndex = 19;
        btnDownloadBackup.Text = "Download Backup";
        btnDownloadBackup.UseVisualStyleBackColor = true;
        btnDownloadBackup.Click += btnDownloadBackup_Click;
        // 
        // btnGetFileInfo
        // 
        btnGetFileInfo.Location = new Point(250, 113);
        btnGetFileInfo.Name = "btnGetFileInfo";
        btnGetFileInfo.Size = new Size(90, 25);
        btnGetFileInfo.TabIndex = 20;
        btnGetFileInfo.Text = "Get File Info";
        btnGetFileInfo.UseVisualStyleBackColor = true;
        btnGetFileInfo.Click += btnGetFileInfo_Click;
        // 
        // btnGetFileProperty
        // 
        btnGetFileProperty.Location = new Point(350, 113);
        btnGetFileProperty.Name = "btnGetFileProperty";
        btnGetFileProperty.Size = new Size(110, 25);
        btnGetFileProperty.TabIndex = 21;
        btnGetFileProperty.Text = "Get File Property";
        btnGetFileProperty.UseVisualStyleBackColor = true;
        btnGetFileProperty.Click += btnGetFileProperty_Click;
        // 
        // btnSetFileProperty
        // 
        btnSetFileProperty.Location = new Point(470, 113);
        btnSetFileProperty.Name = "btnSetFileProperty";
        btnSetFileProperty.Size = new Size(110, 25);
        btnSetFileProperty.TabIndex = 22;
        btnSetFileProperty.Text = "Set File Property";
        btnSetFileProperty.UseVisualStyleBackColor = true;
        btnSetFileProperty.Click += btnSetFileProperty_Click;
        // 
        // tabSubscription
        // 
        tabSubscription.Controls.Add(pnlSubTop);
        tabSubscription.Location = new Point(4, 24);
        tabSubscription.Name = "tabSubscription";
        tabSubscription.Padding = new Padding(3);
        tabSubscription.Size = new Size(892, 121);
        tabSubscription.TabIndex = 5;
        tabSubscription.Text = "Subscription";
        tabSubscription.UseVisualStyleBackColor = true;
        // 
        // pnlSubTop
        // 
        pnlSubTop.AutoScroll = true;
        pnlSubTop.Controls.Add(lblSubResource);
        pnlSubTop.Controls.Add(txtSubResource);
        pnlSubTop.Controls.Add(lblSubPriority);
        pnlSubTop.Controls.Add(cbSubPriority);
        pnlSubTop.Controls.Add(btnSubscribe);
        pnlSubTop.Controls.Add(lblSubGroupId);
        pnlSubTop.Controls.Add(txtSubGroupId);
        pnlSubTop.Controls.Add(btnUnsubscribe);
        pnlSubTop.Controls.Add(lblUpdateResource);
        pnlSubTop.Controls.Add(txtUpdateResource);
        pnlSubTop.Dock = DockStyle.Fill;
        pnlSubTop.Location = new Point(3, 3);
        pnlSubTop.Name = "pnlSubTop";
        pnlSubTop.Size = new Size(886, 115);
        pnlSubTop.TabIndex = 0;
        // 
        // lblSubResource
        // 
        lblSubResource.AutoSize = true;
        lblSubResource.Location = new Point(10, 12);
        lblSubResource.Name = "lblSubResource";
        lblSubResource.Size = new Size(58, 15);
        lblSubResource.TabIndex = 0;
        lblSubResource.Text = "Resource:";
        // 
        // txtSubResource
        // 
        txtSubResource.Location = new Point(75, 8);
        txtSubResource.Name = "txtSubResource";
        txtSubResource.Size = new Size(250, 23);
        txtSubResource.TabIndex = 1;
        txtSubResource.Text = "/rw/panel/speedratio";
        // 
        // lblSubPriority
        // 
        lblSubPriority.AutoSize = true;
        lblSubPriority.Location = new Point(335, 12);
        lblSubPriority.Name = "lblSubPriority";
        lblSubPriority.Size = new Size(48, 15);
        lblSubPriority.TabIndex = 2;
        lblSubPriority.Text = "Priority:";
        // 
        // cbSubPriority
        // 
        cbSubPriority.DropDownStyle = ComboBoxStyle.DropDownList;
        cbSubPriority.FormattingEnabled = true;
        cbSubPriority.Items.AddRange(new object[] { "Low (0)", "Medium (1)", "High (2)" });
        cbSubPriority.Location = new Point(395, 8);
        cbSubPriority.Name = "cbSubPriority";
        cbSubPriority.Size = new Size(90, 23);
        cbSubPriority.TabIndex = 3;
        // 
        // btnSubscribe
        // 
        btnSubscribe.Location = new Point(495, 8);
        btnSubscribe.Name = "btnSubscribe";
        btnSubscribe.Size = new Size(80, 25);
        btnSubscribe.TabIndex = 4;
        btnSubscribe.Text = "Subscribe";
        btnSubscribe.UseVisualStyleBackColor = true;
        btnSubscribe.Click += btnSubscribe_Click;
        // 
        // lblSubGroupId
        // 
        lblSubGroupId.AutoSize = true;
        lblSubGroupId.Location = new Point(10, 44);
        lblSubGroupId.Name = "lblSubGroupId";
        lblSubGroupId.Size = new Size(57, 15);
        lblSubGroupId.TabIndex = 5;
        lblSubGroupId.Text = "Group ID:";
        // 
        // txtSubGroupId
        // 
        txtSubGroupId.Location = new Point(75, 40);
        txtSubGroupId.Name = "txtSubGroupId";
        txtSubGroupId.Size = new Size(80, 23);
        txtSubGroupId.TabIndex = 6;
        // 
        // btnUnsubscribe
        // 
        btnUnsubscribe.Location = new Point(165, 38);
        btnUnsubscribe.Name = "btnUnsubscribe";
        btnUnsubscribe.Size = new Size(90, 25);
        btnUnsubscribe.TabIndex = 7;
        btnUnsubscribe.Text = "Unsubscribe";
        btnUnsubscribe.UseVisualStyleBackColor = true;
        btnUnsubscribe.Click += btnUnsubscribe_Click;
        // 
        // lblUpdateResource
        // 
        lblUpdateResource.AutoSize = true;
        lblUpdateResource.Location = new Point(10, 75);
        lblUpdateResource.Name = "lblUpdateResource";
        lblUpdateResource.Size = new Size(73, 15);
        lblUpdateResource.TabIndex = 8;
        lblUpdateResource.Text = "Update Rsrc:";
        // 
        // txtUpdateResource
        // 
        txtUpdateResource.Location = new Point(95, 70);
        txtUpdateResource.Name = "txtUpdateResource";
        txtUpdateResource.Size = new Size(180, 23);
        txtUpdateResource.TabIndex = 9;
        // 
        // tabSystem
        // 
        tabSystem.Controls.Add(pnlSystemTop);
        tabSystem.Location = new Point(4, 24);
        tabSystem.Name = "tabSystem";
        tabSystem.Padding = new Padding(3);
        tabSystem.Size = new Size(892, 121);
        tabSystem.TabIndex = 6;
        tabSystem.Text = "System";
        tabSystem.UseVisualStyleBackColor = true;
        // 
        // pnlSystemTop
        // 
        pnlSystemTop.Controls.Add(btnGetSysInfo);
        pnlSystemTop.Controls.Add(btnGetSysOptions);
        pnlSystemTop.Controls.Add(btnGetRobotType);
        pnlSystemTop.Controls.Add(btnGetLicense);
        pnlSystemTop.Controls.Add(btnGetEnergy);
        pnlSystemTop.Controls.Add(btnResetEnergy);
        pnlSystemTop.Dock = DockStyle.Top;
        pnlSystemTop.Location = new Point(3, 3);
        pnlSystemTop.Name = "pnlSystemTop";
        pnlSystemTop.Size = new Size(886, 50);
        pnlSystemTop.TabIndex = 0;
        // 
        // btnGetSysInfo
        // 
        btnGetSysInfo.Location = new Point(10, 8);
        btnGetSysInfo.Name = "btnGetSysInfo";
        btnGetSysInfo.Size = new Size(90, 25);
        btnGetSysInfo.TabIndex = 0;
        btnGetSysInfo.Text = "System Info";
        btnGetSysInfo.UseVisualStyleBackColor = true;
        btnGetSysInfo.Click += btnGetSysInfo_Click;
        // 
        // btnGetSysOptions
        // 
        btnGetSysOptions.Location = new Point(110, 8);
        btnGetSysOptions.Name = "btnGetSysOptions";
        btnGetSysOptions.Size = new Size(75, 25);
        btnGetSysOptions.TabIndex = 1;
        btnGetSysOptions.Text = "Options";
        btnGetSysOptions.UseVisualStyleBackColor = true;
        btnGetSysOptions.Click += btnGetSysOptions_Click;
        // 
        // btnGetRobotType
        // 
        btnGetRobotType.Location = new Point(195, 8);
        btnGetRobotType.Name = "btnGetRobotType";
        btnGetRobotType.Size = new Size(85, 25);
        btnGetRobotType.TabIndex = 2;
        btnGetRobotType.Text = "Robot Type";
        btnGetRobotType.UseVisualStyleBackColor = true;
        btnGetRobotType.Click += btnGetRobotType_Click;
        // 
        // btnGetLicense
        // 
        btnGetLicense.Location = new Point(290, 8);
        btnGetLicense.Name = "btnGetLicense";
        btnGetLicense.Size = new Size(70, 25);
        btnGetLicense.TabIndex = 3;
        btnGetLicense.Text = "License";
        btnGetLicense.UseVisualStyleBackColor = true;
        btnGetLicense.Click += btnGetLicense_Click;
        // 
        // btnGetEnergy
        // 
        btnGetEnergy.Location = new Point(370, 8);
        btnGetEnergy.Name = "btnGetEnergy";
        btnGetEnergy.Size = new Size(70, 25);
        btnGetEnergy.TabIndex = 4;
        btnGetEnergy.Text = "Energy";
        btnGetEnergy.UseVisualStyleBackColor = true;
        btnGetEnergy.Click += btnGetEnergy_Click;
        // 
        // btnResetEnergy
        // 
        btnResetEnergy.Location = new Point(450, 8);
        btnResetEnergy.Name = "btnResetEnergy";
        btnResetEnergy.Size = new Size(90, 25);
        btnResetEnergy.TabIndex = 5;
        btnResetEnergy.Text = "Reset Energy";
        btnResetEnergy.UseVisualStyleBackColor = true;
        btnResetEnergy.Click += btnResetEnergy_Click;
        // 
        // tabMastership
        // 
        tabMastership.Controls.Add(pnlMasterTop);
        tabMastership.Location = new Point(4, 24);
        tabMastership.Name = "tabMastership";
        tabMastership.Padding = new Padding(3);
        tabMastership.Size = new Size(892, 272);
        tabMastership.TabIndex = 7;
        tabMastership.Text = "Mastership";
        tabMastership.UseVisualStyleBackColor = true;
        // 
        // pnlMasterTop
        // 
        pnlMasterTop.Controls.Add(btnGetEditDomain);
        pnlMasterTop.Controls.Add(btnGetMotionDomain);
        pnlMasterTop.Controls.Add(btnRequestAllMaster);
        pnlMasterTop.Controls.Add(btnReleaseAllMaster);
        pnlMasterTop.Controls.Add(lblMasterDomain);
        pnlMasterTop.Controls.Add(txtMasterDomain);
        pnlMasterTop.Controls.Add(btnRequestMaster);
        pnlMasterTop.Controls.Add(btnReleaseMaster);
        pnlMasterTop.Dock = DockStyle.Top;
        pnlMasterTop.Location = new Point(3, 3);
        pnlMasterTop.Name = "pnlMasterTop";
        pnlMasterTop.Size = new Size(886, 80);
        pnlMasterTop.TabIndex = 0;
        // 
        // btnGetEditDomain
        // 
        btnGetEditDomain.Location = new Point(10, 8);
        btnGetEditDomain.Name = "btnGetEditDomain";
        btnGetEditDomain.Size = new Size(100, 25);
        btnGetEditDomain.TabIndex = 0;
        btnGetEditDomain.Text = "Edit Domain";
        btnGetEditDomain.UseVisualStyleBackColor = true;
        btnGetEditDomain.Click += btnGetEditDomain_Click;
        // 
        // btnGetMotionDomain
        // 
        btnGetMotionDomain.Location = new Point(120, 8);
        btnGetMotionDomain.Name = "btnGetMotionDomain";
        btnGetMotionDomain.Size = new Size(110, 25);
        btnGetMotionDomain.TabIndex = 1;
        btnGetMotionDomain.Text = "Motion Domain";
        btnGetMotionDomain.UseVisualStyleBackColor = true;
        btnGetMotionDomain.Click += btnGetMotionDomain_Click;
        // 
        // btnRequestAllMaster
        // 
        btnRequestAllMaster.Location = new Point(240, 8);
        btnRequestAllMaster.Name = "btnRequestAllMaster";
        btnRequestAllMaster.Size = new Size(90, 25);
        btnRequestAllMaster.TabIndex = 2;
        btnRequestAllMaster.Text = "Request All";
        btnRequestAllMaster.UseVisualStyleBackColor = true;
        btnRequestAllMaster.Click += btnRequestAllMaster_Click;
        // 
        // btnReleaseAllMaster
        // 
        btnReleaseAllMaster.Location = new Point(340, 8);
        btnReleaseAllMaster.Name = "btnReleaseAllMaster";
        btnReleaseAllMaster.Size = new Size(90, 25);
        btnReleaseAllMaster.TabIndex = 3;
        btnReleaseAllMaster.Text = "Release All";
        btnReleaseAllMaster.UseVisualStyleBackColor = true;
        btnReleaseAllMaster.Click += btnReleaseAllMaster_Click;
        // 
        // lblMasterDomain
        // 
        lblMasterDomain.AutoSize = true;
        lblMasterDomain.Location = new Point(10, 44);
        lblMasterDomain.Name = "lblMasterDomain";
        lblMasterDomain.Size = new Size(52, 15);
        lblMasterDomain.TabIndex = 4;
        lblMasterDomain.Text = "Domain:";
        // 
        // txtMasterDomain
        // 
        txtMasterDomain.Location = new Point(70, 40);
        txtMasterDomain.Name = "txtMasterDomain";
        txtMasterDomain.Size = new Size(100, 23);
        txtMasterDomain.TabIndex = 5;
        txtMasterDomain.Text = "edit";
        // 
        // btnRequestMaster
        // 
        btnRequestMaster.Location = new Point(180, 38);
        btnRequestMaster.Name = "btnRequestMaster";
        btnRequestMaster.Size = new Size(80, 25);
        btnRequestMaster.TabIndex = 6;
        btnRequestMaster.Text = "Request";
        btnRequestMaster.UseVisualStyleBackColor = true;
        btnRequestMaster.Click += btnRequestMaster_Click;
        // 
        // btnReleaseMaster
        // 
        btnReleaseMaster.Location = new Point(270, 38);
        btnReleaseMaster.Name = "btnReleaseMaster";
        btnReleaseMaster.Size = new Size(80, 25);
        btnReleaseMaster.TabIndex = 7;
        btnReleaseMaster.Text = "Release";
        btnReleaseMaster.UseVisualStyleBackColor = true;
        btnReleaseMaster.Click += btnReleaseMaster_Click;
        // 
        // tabElog
        // 
        tabElog.Controls.Add(pnlElogTop);
        tabElog.Location = new Point(4, 24);
        tabElog.Name = "tabElog";
        tabElog.Padding = new Padding(3);
        tabElog.Size = new Size(892, 272);
        tabElog.TabIndex = 8;
        tabElog.Text = "Event Log";
        tabElog.UseVisualStyleBackColor = true;
        // 
        // pnlElogTop
        // 
        pnlElogTop.AutoScroll = true;
        pnlElogTop.Controls.Add(btnGetElogDomains);
        pnlElogTop.Controls.Add(lblElogDomain);
        pnlElogTop.Controls.Add(txtElogDomain);
        pnlElogTop.Controls.Add(btnGetElogMessages);
        pnlElogTop.Controls.Add(btnClearAllElog);
        pnlElogTop.Controls.Add(btnClearElogDomain);
        pnlElogTop.Controls.Add(btnSaveRawElog);
        pnlElogTop.Dock = DockStyle.Fill;
        pnlElogTop.Location = new Point(3, 3);
        pnlElogTop.Name = "pnlElogTop";
        pnlElogTop.Size = new Size(886, 266);
        pnlElogTop.TabIndex = 0;
        // 
        // btnGetElogDomains
        // 
        btnGetElogDomains.Location = new Point(10, 8);
        btnGetElogDomains.Name = "btnGetElogDomains";
        btnGetElogDomains.Size = new Size(100, 25);
        btnGetElogDomains.TabIndex = 0;
        btnGetElogDomains.Text = "Get Domains";
        btnGetElogDomains.UseVisualStyleBackColor = true;
        btnGetElogDomains.Click += btnGetElogDomains_Click;
        // 
        // lblElogDomain
        // 
        lblElogDomain.AutoSize = true;
        lblElogDomain.Location = new Point(10, 44);
        lblElogDomain.Name = "lblElogDomain";
        lblElogDomain.Size = new Size(62, 15);
        lblElogDomain.TabIndex = 1;
        lblElogDomain.Text = "Domain #:";
        // 
        // txtElogDomain
        // 
        txtElogDomain.Location = new Point(80, 40);
        txtElogDomain.Name = "txtElogDomain";
        txtElogDomain.Size = new Size(50, 23);
        txtElogDomain.TabIndex = 2;
        txtElogDomain.Text = "0";
        // 
        // btnGetElogMessages
        // 
        btnGetElogMessages.Location = new Point(140, 38);
        btnGetElogMessages.Name = "btnGetElogMessages";
        btnGetElogMessages.Size = new Size(100, 25);
        btnGetElogMessages.TabIndex = 3;
        btnGetElogMessages.Text = "Get Messages";
        btnGetElogMessages.UseVisualStyleBackColor = true;
        btnGetElogMessages.Click += btnGetElogMessages_Click;
        // 
        // btnClearAllElog
        // 
        btnClearAllElog.Location = new Point(120, 8);
        btnClearAllElog.Name = "btnClearAllElog";
        btnClearAllElog.Size = new Size(80, 25);
        btnClearAllElog.TabIndex = 4;
        btnClearAllElog.Text = "Clear All";
        btnClearAllElog.UseVisualStyleBackColor = true;
        btnClearAllElog.Click += btnClearAllElog_Click;
        // 
        // btnClearElogDomain
        // 
        btnClearElogDomain.Location = new Point(250, 38);
        btnClearElogDomain.Name = "btnClearElogDomain";
        btnClearElogDomain.Size = new Size(100, 25);
        btnClearElogDomain.TabIndex = 5;
        btnClearElogDomain.Text = "Clear Domain";
        btnClearElogDomain.UseVisualStyleBackColor = true;
        btnClearElogDomain.Click += btnClearElogDomain_Click;
        // 
        // btnSaveRawElog
        // 
        btnSaveRawElog.Location = new Point(345, 70);
        btnSaveRawElog.Name = "btnSaveRawElog";
        btnSaveRawElog.Size = new Size(85, 25);
        btnSaveRawElog.TabIndex = 8;
        btnSaveRawElog.Text = "Save Raw";
        btnSaveRawElog.UseVisualStyleBackColor = true;
        btnSaveRawElog.Click += btnSaveRawElog_Click;
        // 
        // tabCfg
        // 
        tabCfg.Controls.Add(pnlCfgTop);
        tabCfg.Location = new Point(4, 24);
        tabCfg.Name = "tabCfg";
        tabCfg.Padding = new Padding(3);
        tabCfg.Size = new Size(892, 185);
        tabCfg.TabIndex = 9;
        tabCfg.Text = "Configuration";
        tabCfg.UseVisualStyleBackColor = true;
        // 
        // pnlCfgTop
        // 
        pnlCfgTop.AutoScroll = true;
        pnlCfgTop.Controls.Add(btnGetCfgDomains);
        pnlCfgTop.Controls.Add(lblCfgDomain);
        pnlCfgTop.Controls.Add(txtCfgDomain);
        pnlCfgTop.Controls.Add(btnGetCfgTypes);
        pnlCfgTop.Controls.Add(lblCfgType);
        pnlCfgTop.Controls.Add(txtCfgType);
        pnlCfgTop.Controls.Add(btnGetCfgInstances);
        pnlCfgTop.Controls.Add(btnGetCfgAttributes);
        pnlCfgTop.Controls.Add(lblCfgAttribute);
        pnlCfgTop.Controls.Add(txtCfgAttribute);
        pnlCfgTop.Controls.Add(btnGetAttribute);
        pnlCfgTop.Controls.Add(lblCfgValue);
        pnlCfgTop.Controls.Add(txtCfgValue);
        pnlCfgTop.Controls.Add(btnSetAttribute);
        pnlCfgTop.Controls.Add(btnDeleteInstance);
        pnlCfgTop.Controls.Add(btnCreateDefault);
        pnlCfgTop.Controls.Add(btnLoadCfg);
        pnlCfgTop.Controls.Add(btnSaveCfg);
        pnlCfgTop.Controls.Add(btnValidateCfg);
        pnlCfgTop.Controls.Add(btnResetCfg);
        pnlCfgTop.Controls.Add(btnCfgSystemAction);
        pnlCfgTop.Dock = DockStyle.Fill;
        pnlCfgTop.Location = new Point(3, 3);
        pnlCfgTop.Name = "pnlCfgTop";
        pnlCfgTop.Size = new Size(886, 179);
        pnlCfgTop.TabIndex = 0;
        // 
        // btnGetCfgDomains
        // 
        btnGetCfgDomains.Location = new Point(10, 8);
        btnGetCfgDomains.Name = "btnGetCfgDomains";
        btnGetCfgDomains.Size = new Size(100, 25);
        btnGetCfgDomains.TabIndex = 0;
        btnGetCfgDomains.Text = "Get Domains";
        btnGetCfgDomains.UseVisualStyleBackColor = true;
        btnGetCfgDomains.Click += btnGetCfgDomains_Click;
        // 
        // lblCfgDomain
        // 
        lblCfgDomain.AutoSize = true;
        lblCfgDomain.Location = new Point(10, 42);
        lblCfgDomain.Name = "lblCfgDomain";
        lblCfgDomain.Size = new Size(52, 15);
        lblCfgDomain.TabIndex = 1;
        lblCfgDomain.Text = "Domain:";
        // 
        // txtCfgDomain
        // 
        txtCfgDomain.Location = new Point(70, 38);
        txtCfgDomain.Name = "txtCfgDomain";
        txtCfgDomain.Size = new Size(100, 23);
        txtCfgDomain.TabIndex = 2;
        txtCfgDomain.Text = "MOC";
        // 
        // btnGetCfgTypes
        // 
        btnGetCfgTypes.Location = new Point(180, 38);
        btnGetCfgTypes.Name = "btnGetCfgTypes";
        btnGetCfgTypes.Size = new Size(80, 25);
        btnGetCfgTypes.TabIndex = 3;
        btnGetCfgTypes.Text = "Get Types";
        btnGetCfgTypes.UseVisualStyleBackColor = true;
        btnGetCfgTypes.Click += btnGetCfgTypes_Click;
        // 
        // lblCfgType
        // 
        lblCfgType.AutoSize = true;
        lblCfgType.Location = new Point(10, 72);
        lblCfgType.Name = "lblCfgType";
        lblCfgType.Size = new Size(35, 15);
        lblCfgType.TabIndex = 4;
        lblCfgType.Text = "Type:";
        // 
        // txtCfgType
        // 
        txtCfgType.Location = new Point(55, 68);
        txtCfgType.Name = "txtCfgType";
        txtCfgType.Size = new Size(130, 23);
        txtCfgType.TabIndex = 5;
        // 
        // btnGetCfgInstances
        // 
        btnGetCfgInstances.Location = new Point(195, 68);
        btnGetCfgInstances.Name = "btnGetCfgInstances";
        btnGetCfgInstances.Size = new Size(100, 25);
        btnGetCfgInstances.TabIndex = 6;
        btnGetCfgInstances.Text = "Get Instances";
        btnGetCfgInstances.UseVisualStyleBackColor = true;
        btnGetCfgInstances.Click += btnGetCfgInstances_Click;
        // 
        // btnGetCfgAttributes
        // 
        btnGetCfgAttributes.Location = new Point(305, 68);
        btnGetCfgAttributes.Name = "btnGetCfgAttributes";
        btnGetCfgAttributes.Size = new Size(100, 25);
        btnGetCfgAttributes.TabIndex = 7;
        btnGetCfgAttributes.Text = "Get Attributes";
        btnGetCfgAttributes.UseVisualStyleBackColor = true;
        btnGetCfgAttributes.Click += btnGetCfgAttributes_Click;
        // 
        // lblCfgAttribute
        // 
        lblCfgAttribute.AutoSize = true;
        lblCfgAttribute.Location = new Point(10, 108);
        lblCfgAttribute.Name = "lblCfgAttribute";
        lblCfgAttribute.Size = new Size(57, 15);
        lblCfgAttribute.TabIndex = 8;
        lblCfgAttribute.Text = "Attribute:";
        // 
        // txtCfgAttribute
        // 
        txtCfgAttribute.Location = new Point(80, 103);
        txtCfgAttribute.Name = "txtCfgAttribute";
        txtCfgAttribute.Size = new Size(120, 23);
        txtCfgAttribute.TabIndex = 9;
        // 
        // btnGetAttribute
        // 
        btnGetAttribute.Location = new Point(210, 103);
        btnGetAttribute.Name = "btnGetAttribute";
        btnGetAttribute.Size = new Size(95, 25);
        btnGetAttribute.TabIndex = 10;
        btnGetAttribute.Text = "Get Attribute";
        btnGetAttribute.UseVisualStyleBackColor = true;
        btnGetAttribute.Click += btnGetAttribute_Click;
        // 
        // lblCfgValue
        // 
        lblCfgValue.AutoSize = true;
        lblCfgValue.Location = new Point(315, 108);
        lblCfgValue.Name = "lblCfgValue";
        lblCfgValue.Size = new Size(38, 15);
        lblCfgValue.TabIndex = 11;
        lblCfgValue.Text = "Value:";
        // 
        // txtCfgValue
        // 
        txtCfgValue.Location = new Point(360, 103);
        txtCfgValue.Name = "txtCfgValue";
        txtCfgValue.Size = new Size(120, 23);
        txtCfgValue.TabIndex = 12;
        // 
        // btnSetAttribute
        // 
        btnSetAttribute.Location = new Point(490, 103);
        btnSetAttribute.Name = "btnSetAttribute";
        btnSetAttribute.Size = new Size(90, 25);
        btnSetAttribute.TabIndex = 13;
        btnSetAttribute.Text = "Set Attribute";
        btnSetAttribute.UseVisualStyleBackColor = true;
        btnSetAttribute.Click += btnSetAttribute_Click;
        // 
        // btnDeleteInstance
        // 
        btnDeleteInstance.Location = new Point(590, 103);
        btnDeleteInstance.Name = "btnDeleteInstance";
        btnDeleteInstance.Size = new Size(100, 25);
        btnDeleteInstance.TabIndex = 14;
        btnDeleteInstance.Text = "Delete Instance";
        btnDeleteInstance.UseVisualStyleBackColor = true;
        btnDeleteInstance.Click += btnDeleteInstance_Click;
        // 
        // btnCreateDefault
        // 
        btnCreateDefault.Location = new Point(700, 103);
        btnCreateDefault.Name = "btnCreateDefault";
        btnCreateDefault.Size = new Size(100, 25);
        btnCreateDefault.TabIndex = 15;
        btnCreateDefault.Text = "Create Default";
        btnCreateDefault.UseVisualStyleBackColor = true;
        btnCreateDefault.Click += btnCreateDefault_Click;
        // 
        // btnLoadCfg
        // 
        btnLoadCfg.Location = new Point(285, 138);
        btnLoadCfg.Name = "btnLoadCfg";
        btnLoadCfg.Size = new Size(85, 25);
        btnLoadCfg.TabIndex = 18;
        btnLoadCfg.Text = "Load Config";
        btnLoadCfg.UseVisualStyleBackColor = true;
        btnLoadCfg.Click += btnLoadCfg_Click;
        // 
        // btnSaveCfg
        // 
        btnSaveCfg.Location = new Point(380, 138);
        btnSaveCfg.Name = "btnSaveCfg";
        btnSaveCfg.Size = new Size(85, 25);
        btnSaveCfg.TabIndex = 19;
        btnSaveCfg.Text = "Save Config";
        btnSaveCfg.UseVisualStyleBackColor = true;
        btnSaveCfg.Click += btnSaveCfg_Click;
        // 
        // btnValidateCfg
        // 
        btnValidateCfg.Location = new Point(475, 138);
        btnValidateCfg.Name = "btnValidateCfg";
        btnValidateCfg.Size = new Size(95, 25);
        btnValidateCfg.TabIndex = 20;
        btnValidateCfg.Text = "Validate Config";
        btnValidateCfg.UseVisualStyleBackColor = true;
        btnValidateCfg.Click += btnValidateCfg_Click;
        // 
        // btnResetCfg
        // 
        btnResetCfg.Location = new Point(580, 138);
        btnResetCfg.Name = "btnResetCfg";
        btnResetCfg.Size = new Size(85, 25);
        btnResetCfg.TabIndex = 21;
        btnResetCfg.Text = "Reset Config";
        btnResetCfg.UseVisualStyleBackColor = true;
        btnResetCfg.Click += btnResetCfg_Click;
        // 
        // btnCfgSystemAction
        // 
        btnCfgSystemAction.Location = new Point(675, 138);
        btnCfgSystemAction.Name = "btnCfgSystemAction";
        btnCfgSystemAction.Size = new Size(115, 25);
        btnCfgSystemAction.TabIndex = 22;
        btnCfgSystemAction.Text = "System Action";
        btnCfgSystemAction.UseVisualStyleBackColor = true;
        btnCfgSystemAction.Click += btnCfgSystemAction_Click;
        // 
        // tabMotion
        // 
        tabMotion.Controls.Add(pnlMotionTop);
        tabMotion.Location = new Point(4, 24);
        tabMotion.Name = "tabMotion";
        tabMotion.Padding = new Padding(3);
        tabMotion.Size = new Size(892, 323);
        tabMotion.TabIndex = 10;
        tabMotion.Text = "Motion";
        tabMotion.UseVisualStyleBackColor = true;
        // 
        // pnlMotionTop
        // 
        pnlMotionTop.AutoScroll = true;
        pnlMotionTop.Controls.Add(btnGetMechUnits);
        pnlMotionTop.Controls.Add(lblMechUnit);
        pnlMotionTop.Controls.Add(txtMechUnit);
        pnlMotionTop.Controls.Add(btnGetMechUnit);
        pnlMotionTop.Controls.Add(btnGetCartesian);
        pnlMotionTop.Controls.Add(btnGetRobTarget);
        pnlMotionTop.Controls.Add(btnGetJointTarget);
        pnlMotionTop.Controls.Add(lblMechUnitState);
        pnlMotionTop.Controls.Add(cbMechUnitState);
        pnlMotionTop.Controls.Add(btnSetMechUnitState);
        pnlMotionTop.Controls.Add(lblPayload);
        pnlMotionTop.Controls.Add(txtPayload);
        pnlMotionTop.Controls.Add(btnSetPayload);
        pnlMotionTop.Controls.Add(btnGetPayload);
        pnlMotionTop.Controls.Add(lblSupervision);
        pnlMotionTop.Controls.Add(cbSupervision);
        pnlMotionTop.Controls.Add(btnSetSupervision);
        pnlMotionTop.Controls.Add(btnGetSupervision);
        pnlMotionTop.Controls.Add(btnResetPpMoved);
        pnlMotionTop.Controls.Add(lblCalAxis);
        pnlMotionTop.Controls.Add(txtCalAxis);
        pnlMotionTop.Controls.Add(btnLoadIdentity);
        pnlMotionTop.Controls.Add(btnClearCalibPath);
        pnlMotionTop.Controls.Add(lblCalibOffset);
        pnlMotionTop.Controls.Add(txtCalibOffset);
        pnlMotionTop.Controls.Add(btnSetCalibOffset);
        pnlMotionTop.Controls.Add(btnGetCalibOffset);
        pnlMotionTop.Controls.Add(lblJogSpeed);
        pnlMotionTop.Controls.Add(txtJogSpeed);
        pnlMotionTop.Controls.Add(lblJogIncrement);
        pnlMotionTop.Controls.Add(txtJogIncrement);
        pnlMotionTop.Controls.Add(lblJogMode);
        pnlMotionTop.Controls.Add(cbJogMode);
        pnlMotionTop.Controls.Add(btnStartJogF);
        pnlMotionTop.Controls.Add(btnStartJogB);
        pnlMotionTop.Controls.Add(btnStartJogR);
        pnlMotionTop.Controls.Add(btnStartJogL);
        pnlMotionTop.Controls.Add(btnStartJogU);
        pnlMotionTop.Controls.Add(btnStartJogD);
        pnlMotionTop.Controls.Add(btnStopJog);
        pnlMotionTop.Controls.Add(btnSetJogMode);
        pnlMotionTop.Controls.Add(lblSpeedRatio);
        pnlMotionTop.Controls.Add(txtSpeedRatio);
        pnlMotionTop.Controls.Add(btnSetSpeedRatio);
        pnlMotionTop.Controls.Add(btnGetSpeedRatio);
        pnlMotionTop.Controls.Add(btnEnableLeadThrough);
        pnlMotionTop.Controls.Add(btnDisableLeadThrough);
        pnlMotionTop.Controls.Add(btnGetMechUnitMode);
        pnlMotionTop.Dock = DockStyle.Fill;
        pnlMotionTop.Location = new Point(3, 3);
        pnlMotionTop.Name = "pnlMotionTop";
        pnlMotionTop.Size = new Size(886, 317);
        pnlMotionTop.TabIndex = 0;
        // 
        // btnGetMechUnits
        // 
        btnGetMechUnits.Location = new Point(10, 8);
        btnGetMechUnits.Name = "btnGetMechUnits";
        btnGetMechUnits.Size = new Size(100, 25);
        btnGetMechUnits.TabIndex = 0;
        btnGetMechUnits.Text = "Get All Units";
        btnGetMechUnits.UseVisualStyleBackColor = true;
        btnGetMechUnits.Click += btnGetMechUnits_Click;
        // 
        // lblMechUnit
        // 
        lblMechUnit.AutoSize = true;
        lblMechUnit.Location = new Point(10, 44);
        lblMechUnit.Name = "lblMechUnit";
        lblMechUnit.Size = new Size(65, 15);
        lblMechUnit.TabIndex = 1;
        lblMechUnit.Text = "Mech Unit:";
        // 
        // txtMechUnit
        // 
        txtMechUnit.Location = new Point(85, 40);
        txtMechUnit.Name = "txtMechUnit";
        txtMechUnit.Size = new Size(80, 23);
        txtMechUnit.TabIndex = 2;
        txtMechUnit.Text = "ROB_1";
        // 
        // btnGetMechUnit
        // 
        btnGetMechUnit.Location = new Point(175, 38);
        btnGetMechUnit.Name = "btnGetMechUnit";
        btnGetMechUnit.Size = new Size(70, 25);
        btnGetMechUnit.TabIndex = 3;
        btnGetMechUnit.Text = "Details";
        btnGetMechUnit.UseVisualStyleBackColor = true;
        btnGetMechUnit.Click += btnGetMechUnit_Click;
        // 
        // btnGetCartesian
        // 
        btnGetCartesian.Location = new Point(255, 38);
        btnGetCartesian.Name = "btnGetCartesian";
        btnGetCartesian.Size = new Size(80, 25);
        btnGetCartesian.TabIndex = 4;
        btnGetCartesian.Text = "Cartesian";
        btnGetCartesian.UseVisualStyleBackColor = true;
        btnGetCartesian.Click += btnGetCartesian_Click;
        // 
        // btnGetRobTarget
        // 
        btnGetRobTarget.Location = new Point(345, 38);
        btnGetRobTarget.Name = "btnGetRobTarget";
        btnGetRobTarget.Size = new Size(80, 25);
        btnGetRobTarget.TabIndex = 5;
        btnGetRobTarget.Text = "RobTarget";
        btnGetRobTarget.UseVisualStyleBackColor = true;
        btnGetRobTarget.Click += btnGetRobTarget_Click;
        // 
        // btnGetJointTarget
        // 
        btnGetJointTarget.Location = new Point(435, 38);
        btnGetJointTarget.Name = "btnGetJointTarget";
        btnGetJointTarget.Size = new Size(85, 25);
        btnGetJointTarget.TabIndex = 6;
        btnGetJointTarget.Text = "JointTarget";
        btnGetJointTarget.UseVisualStyleBackColor = true;
        btnGetJointTarget.Click += btnGetJointTarget_Click;
        // 
        // lblMechUnitState
        // 
        lblMechUnitState.AutoSize = true;
        lblMechUnitState.Location = new Point(10, 75);
        lblMechUnitState.Name = "lblMechUnitState";
        lblMechUnitState.Size = new Size(36, 15);
        lblMechUnitState.TabIndex = 7;
        lblMechUnitState.Text = "State:";
        // 
        // cbMechUnitState
        // 
        cbMechUnitState.DropDownStyle = ComboBoxStyle.DropDownList;
        cbMechUnitState.FormattingEnabled = true;
        cbMechUnitState.Items.AddRange(new object[] { "Activated (0)", "Deactivated (1)" });
        cbMechUnitState.Location = new Point(55, 70);
        cbMechUnitState.Name = "cbMechUnitState";
        cbMechUnitState.Size = new Size(130, 23);
        cbMechUnitState.TabIndex = 8;
        // 
        // btnSetMechUnitState
        // 
        btnSetMechUnitState.Location = new Point(195, 70);
        btnSetMechUnitState.Name = "btnSetMechUnitState";
        btnSetMechUnitState.Size = new Size(100, 25);
        btnSetMechUnitState.TabIndex = 9;
        btnSetMechUnitState.Text = "Set MU State";
        btnSetMechUnitState.UseVisualStyleBackColor = true;
        btnSetMechUnitState.Click += btnSetMechUnitState_Click;
        // 
        // lblPayload
        // 
        lblPayload.AutoSize = true;
        lblPayload.Location = new Point(305, 75);
        lblPayload.Name = "lblPayload";
        lblPayload.Size = new Size(52, 15);
        lblPayload.TabIndex = 10;
        lblPayload.Text = "Payload:";
        // 
        // txtPayload
        // 
        txtPayload.Location = new Point(365, 70);
        txtPayload.Name = "txtPayload";
        txtPayload.Size = new Size(80, 23);
        txtPayload.TabIndex = 11;
        // 
        // btnSetPayload
        // 
        btnSetPayload.Location = new Point(455, 70);
        btnSetPayload.Name = "btnSetPayload";
        btnSetPayload.Size = new Size(90, 25);
        btnSetPayload.TabIndex = 12;
        btnSetPayload.Text = "Set Payload";
        btnSetPayload.UseVisualStyleBackColor = true;
        btnSetPayload.Click += btnSetPayload_Click;
        // 
        // btnGetPayload
        // 
        btnGetPayload.Location = new Point(555, 70);
        btnGetPayload.Name = "btnGetPayload";
        btnGetPayload.Size = new Size(90, 25);
        btnGetPayload.TabIndex = 13;
        btnGetPayload.Text = "Get Payload";
        btnGetPayload.UseVisualStyleBackColor = true;
        btnGetPayload.Click += btnGetPayload_Click;
        // 
        // lblSupervision
        // 
        lblSupervision.AutoSize = true;
        lblSupervision.Location = new Point(10, 110);
        lblSupervision.Name = "lblSupervision";
        lblSupervision.Size = new Size(71, 15);
        lblSupervision.TabIndex = 14;
        lblSupervision.Text = "Supervision:";
        // 
        // cbSupervision
        // 
        cbSupervision.AutoSize = true;
        cbSupervision.Location = new Point(90, 109);
        cbSupervision.Name = "cbSupervision";
        cbSupervision.Size = new Size(15, 14);
        cbSupervision.TabIndex = 15;
        cbSupervision.UseVisualStyleBackColor = true;
        // 
        // btnSetSupervision
        // 
        btnSetSupervision.Location = new Point(115, 105);
        btnSetSupervision.Name = "btnSetSupervision";
        btnSetSupervision.Size = new Size(110, 25);
        btnSetSupervision.TabIndex = 16;
        btnSetSupervision.Text = "Set Supervision";
        btnSetSupervision.UseVisualStyleBackColor = true;
        btnSetSupervision.Click += btnSetSupervision_Click;
        // 
        // btnGetSupervision
        // 
        btnGetSupervision.Location = new Point(235, 105);
        btnGetSupervision.Name = "btnGetSupervision";
        btnGetSupervision.Size = new Size(110, 25);
        btnGetSupervision.TabIndex = 17;
        btnGetSupervision.Text = "Get Supervision";
        btnGetSupervision.UseVisualStyleBackColor = true;
        btnGetSupervision.Click += btnGetSupervision_Click;
        // 
        // btnResetPpMoved
        // 
        btnResetPpMoved.Location = new Point(355, 105);
        btnResetPpMoved.Name = "btnResetPpMoved";
        btnResetPpMoved.Size = new Size(110, 25);
        btnResetPpMoved.TabIndex = 18;
        btnResetPpMoved.Text = "Reset PP Moved";
        btnResetPpMoved.UseVisualStyleBackColor = true;
        btnResetPpMoved.Click += btnResetPpMoved_Click;
        // 
        // lblCalAxis
        // 
        lblCalAxis.AutoSize = true;
        lblCalAxis.Location = new Point(10, 145);
        lblCalAxis.Name = "lblCalAxis";
        lblCalAxis.Size = new Size(51, 15);
        lblCalAxis.TabIndex = 19;
        lblCalAxis.Text = "Cal Axis:";
        // 
        // txtCalAxis
        // 
        txtCalAxis.Location = new Point(70, 140);
        txtCalAxis.Name = "txtCalAxis";
        txtCalAxis.Size = new Size(60, 23);
        txtCalAxis.TabIndex = 20;
        // 
        // btnLoadIdentity
        // 
        btnLoadIdentity.Location = new Point(140, 140);
        btnLoadIdentity.Name = "btnLoadIdentity";
        btnLoadIdentity.Size = new Size(105, 25);
        btnLoadIdentity.TabIndex = 21;
        btnLoadIdentity.Text = "Load Identity";
        btnLoadIdentity.UseVisualStyleBackColor = true;
        btnLoadIdentity.Click += btnLoadIdentity_Click;
        // 
        // btnClearCalibPath
        // 
        btnClearCalibPath.Location = new Point(255, 140);
        btnClearCalibPath.Name = "btnClearCalibPath";
        btnClearCalibPath.Size = new Size(110, 25);
        btnClearCalibPath.TabIndex = 22;
        btnClearCalibPath.Text = "Clear Calib Path";
        btnClearCalibPath.UseVisualStyleBackColor = true;
        btnClearCalibPath.Click += btnClearCalibPath_Click;
        // 
        // lblCalibOffset
        // 
        lblCalibOffset.AutoSize = true;
        lblCalibOffset.Location = new Point(375, 145);
        lblCalibOffset.Name = "lblCalibOffset";
        lblCalibOffset.Size = new Size(42, 15);
        lblCalibOffset.TabIndex = 23;
        lblCalibOffset.Text = "Offset:";
        // 
        // txtCalibOffset
        // 
        txtCalibOffset.Location = new Point(430, 140);
        txtCalibOffset.Name = "txtCalibOffset";
        txtCalibOffset.Size = new Size(80, 23);
        txtCalibOffset.TabIndex = 24;
        // 
        // btnSetCalibOffset
        // 
        btnSetCalibOffset.Location = new Point(520, 140);
        btnSetCalibOffset.Name = "btnSetCalibOffset";
        btnSetCalibOffset.Size = new Size(100, 25);
        btnSetCalibOffset.TabIndex = 25;
        btnSetCalibOffset.Text = "Set Cal Offset";
        btnSetCalibOffset.UseVisualStyleBackColor = true;
        btnSetCalibOffset.Click += btnSetCalibOffset_Click;
        // 
        // btnGetCalibOffset
        // 
        btnGetCalibOffset.Location = new Point(630, 140);
        btnGetCalibOffset.Name = "btnGetCalibOffset";
        btnGetCalibOffset.Size = new Size(105, 25);
        btnGetCalibOffset.TabIndex = 26;
        btnGetCalibOffset.Text = "Get Cal Offset";
        btnGetCalibOffset.UseVisualStyleBackColor = true;
        btnGetCalibOffset.Click += btnGetCalibOffset_Click;
        // 
        // lblJogSpeed
        // 
        lblJogSpeed.AutoSize = true;
        lblJogSpeed.Location = new Point(10, 180);
        lblJogSpeed.Name = "lblJogSpeed";
        lblJogSpeed.Size = new Size(63, 15);
        lblJogSpeed.TabIndex = 27;
        lblJogSpeed.Text = "Jog Speed:";
        // 
        // txtJogSpeed
        // 
        txtJogSpeed.Location = new Point(80, 175);
        txtJogSpeed.Name = "txtJogSpeed";
        txtJogSpeed.Size = new Size(60, 23);
        txtJogSpeed.TabIndex = 28;
        // 
        // lblJogIncrement
        // 
        lblJogIncrement.AutoSize = true;
        lblJogIncrement.Location = new Point(150, 180);
        lblJogIncrement.Name = "lblJogIncrement";
        lblJogIncrement.Size = new Size(64, 15);
        lblJogIncrement.TabIndex = 29;
        lblJogIncrement.Text = "Increment:";
        // 
        // txtJogIncrement
        // 
        txtJogIncrement.Location = new Point(220, 175);
        txtJogIncrement.Name = "txtJogIncrement";
        txtJogIncrement.Size = new Size(60, 23);
        txtJogIncrement.TabIndex = 30;
        // 
        // lblJogMode
        // 
        lblJogMode.AutoSize = true;
        lblJogMode.Location = new Point(290, 180);
        lblJogMode.Name = "lblJogMode";
        lblJogMode.Size = new Size(41, 15);
        lblJogMode.TabIndex = 31;
        lblJogMode.Text = "Mode:";
        // 
        // cbJogMode
        // 
        cbJogMode.DropDownStyle = ComboBoxStyle.DropDownList;
        cbJogMode.FormattingEnabled = true;
        cbJogMode.Items.AddRange(new object[] { "Normal (0)", "Rapid (1)" });
        cbJogMode.Location = new Point(335, 175);
        cbJogMode.Name = "cbJogMode";
        cbJogMode.Size = new Size(100, 23);
        cbJogMode.TabIndex = 32;
        // 
        // btnStartJogF
        // 
        btnStartJogF.Location = new Point(10, 210);
        btnStartJogF.Name = "btnStartJogF";
        btnStartJogF.Size = new Size(60, 25);
        btnStartJogF.TabIndex = 33;
        btnStartJogF.Text = "Jog +X";
        btnStartJogF.UseVisualStyleBackColor = true;
        btnStartJogF.Click += btnStartJogF_Click;
        // 
        // btnStartJogB
        // 
        btnStartJogB.Location = new Point(80, 210);
        btnStartJogB.Name = "btnStartJogB";
        btnStartJogB.Size = new Size(60, 25);
        btnStartJogB.TabIndex = 34;
        btnStartJogB.Text = "Jog -X";
        btnStartJogB.UseVisualStyleBackColor = true;
        btnStartJogB.Click += btnStartJogB_Click;
        // 
        // btnStartJogR
        // 
        btnStartJogR.Location = new Point(150, 210);
        btnStartJogR.Name = "btnStartJogR";
        btnStartJogR.Size = new Size(60, 25);
        btnStartJogR.TabIndex = 35;
        btnStartJogR.Text = "Jog +Y";
        btnStartJogR.UseVisualStyleBackColor = true;
        btnStartJogR.Click += btnStartJogR_Click;
        // 
        // btnStartJogL
        // 
        btnStartJogL.Location = new Point(220, 210);
        btnStartJogL.Name = "btnStartJogL";
        btnStartJogL.Size = new Size(60, 25);
        btnStartJogL.TabIndex = 36;
        btnStartJogL.Text = "Jog -Y";
        btnStartJogL.UseVisualStyleBackColor = true;
        btnStartJogL.Click += btnStartJogL_Click;
        // 
        // btnStartJogU
        // 
        btnStartJogU.Location = new Point(290, 210);
        btnStartJogU.Name = "btnStartJogU";
        btnStartJogU.Size = new Size(60, 25);
        btnStartJogU.TabIndex = 37;
        btnStartJogU.Text = "Jog +Z";
        btnStartJogU.UseVisualStyleBackColor = true;
        btnStartJogU.Click += btnStartJogU_Click;
        // 
        // btnStartJogD
        // 
        btnStartJogD.Location = new Point(360, 210);
        btnStartJogD.Name = "btnStartJogD";
        btnStartJogD.Size = new Size(60, 25);
        btnStartJogD.TabIndex = 38;
        btnStartJogD.Text = "Jog -Z";
        btnStartJogD.UseVisualStyleBackColor = true;
        btnStartJogD.Click += btnStartJogD_Click;
        // 
        // btnStopJog
        // 
        btnStopJog.Location = new Point(430, 210);
        btnStopJog.Name = "btnStopJog";
        btnStopJog.Size = new Size(75, 25);
        btnStopJog.TabIndex = 39;
        btnStopJog.Text = "Stop Jog";
        btnStopJog.UseVisualStyleBackColor = true;
        btnStopJog.Click += btnStopJog_Click;
        // 
        // btnSetJogMode
        // 
        btnSetJogMode.Location = new Point(515, 210);
        btnSetJogMode.Name = "btnSetJogMode";
        btnSetJogMode.Size = new Size(100, 25);
        btnSetJogMode.TabIndex = 40;
        btnSetJogMode.Text = "Set Jog Mode";
        btnSetJogMode.UseVisualStyleBackColor = true;
        btnSetJogMode.Click += btnSetJogMode_Click;
        // 
        // lblSpeedRatio
        // 
        lblSpeedRatio.AutoSize = true;
        lblSpeedRatio.Location = new Point(10, 250);
        lblSpeedRatio.Name = "lblSpeedRatio";
        lblSpeedRatio.Size = new Size(72, 15);
        lblSpeedRatio.TabIndex = 41;
        lblSpeedRatio.Text = "Speed Ratio:";
        // 
        // txtSpeedRatio
        // 
        txtSpeedRatio.Location = new Point(90, 245);
        txtSpeedRatio.Name = "txtSpeedRatio";
        txtSpeedRatio.Size = new Size(70, 23);
        txtSpeedRatio.TabIndex = 42;
        txtSpeedRatio.Value = new decimal(new int[] { 100, 0, 0, 0 });
        // 
        // btnEnableLeadThrough
        // 
        btnEnableLeadThrough.Location = new Point(130, 285);
        btnEnableLeadThrough.Name = "btnEnableLeadThrough";
        btnEnableLeadThrough.Size = new Size(125, 25);
        btnEnableLeadThrough.TabIndex = 46;
        btnEnableLeadThrough.Text = "Enable LeadThrough";
        btnEnableLeadThrough.UseVisualStyleBackColor = true;
        btnEnableLeadThrough.Click += btnEnableLeadThrough_Click;
        // 
        // btnDisableLeadThrough
        // 
        btnDisableLeadThrough.Location = new Point(265, 285);
        btnDisableLeadThrough.Name = "btnDisableLeadThrough";
        btnDisableLeadThrough.Size = new Size(130, 25);
        btnDisableLeadThrough.TabIndex = 47;
        btnDisableLeadThrough.Text = "Disable LeadThrough";
        btnDisableLeadThrough.UseVisualStyleBackColor = true;
        btnDisableLeadThrough.Click += btnDisableLeadThrough_Click;
        // 
        // btnGetMechUnitMode
        // 
        btnGetMechUnitMode.Location = new Point(405, 285);
        btnGetMechUnitMode.Name = "btnGetMechUnitMode";
        btnGetMechUnitMode.Size = new Size(125, 25);
        btnGetMechUnitMode.TabIndex = 48;
        btnGetMechUnitMode.Text = "Get MU Mode";
        btnGetMechUnitMode.UseVisualStyleBackColor = true;
        btnGetMechUnitMode.Click += btnGetMechUnitMode_Click;
        // 
        // tabDIPC
        // 
        tabDIPC.Controls.Add(pnlDIPCTop);
        tabDIPC.Location = new Point(4, 24);
        tabDIPC.Name = "tabDIPC";
        tabDIPC.Padding = new Padding(3);
        tabDIPC.Size = new Size(892, 185);
        tabDIPC.TabIndex = 11;
        tabDIPC.Text = "DIPC";
        tabDIPC.UseVisualStyleBackColor = true;
        // 
        // pnlDIPCTop
        // 
        pnlDIPCTop.AutoScroll = true;
        pnlDIPCTop.Controls.Add(btnGetDIPCQueues);
        pnlDIPCTop.Controls.Add(lblDIPCQueue);
        pnlDIPCTop.Controls.Add(txtDIPCQueue);
        pnlDIPCTop.Controls.Add(btnGetDIPCQueueInfo);
        pnlDIPCTop.Controls.Add(lblDIPCSize);
        pnlDIPCTop.Controls.Add(txtDIPCSize);
        pnlDIPCTop.Controls.Add(lblDIPCMsgSize);
        pnlDIPCTop.Controls.Add(txtDIPCMsgSize);
        pnlDIPCTop.Controls.Add(btnCreateDIPCQueue);
        pnlDIPCTop.Controls.Add(btnDeleteDIPCQueue);
        pnlDIPCTop.Controls.Add(lblDipcMsgType);
        pnlDIPCTop.Controls.Add(txtDipcMsgType);
        pnlDIPCTop.Controls.Add(lblDipcCmd);
        pnlDIPCTop.Controls.Add(txtDipcCmd);
        pnlDIPCTop.Controls.Add(btnSendDipcMsg);
        pnlDIPCTop.Controls.Add(lblDipcUserDef);
        pnlDIPCTop.Controls.Add(txtDipcUserDef);
        pnlDIPCTop.Controls.Add(btnSetDipcUserDef);
        pnlDIPCTop.Controls.Add(btnGetDipcQueue);
        pnlDIPCTop.Dock = DockStyle.Fill;
        pnlDIPCTop.Location = new Point(3, 3);
        pnlDIPCTop.Name = "pnlDIPCTop";
        pnlDIPCTop.Size = new Size(886, 179);
        pnlDIPCTop.TabIndex = 0;
        // 
        // btnGetDIPCQueues
        // 
        btnGetDIPCQueues.Location = new Point(10, 8);
        btnGetDIPCQueues.Name = "btnGetDIPCQueues";
        btnGetDIPCQueues.Size = new Size(90, 25);
        btnGetDIPCQueues.TabIndex = 0;
        btnGetDIPCQueues.Text = "Get Queues";
        btnGetDIPCQueues.UseVisualStyleBackColor = true;
        btnGetDIPCQueues.Click += btnGetDIPCQueues_Click;
        // 
        // lblDIPCQueue
        // 
        lblDIPCQueue.AutoSize = true;
        lblDIPCQueue.Location = new Point(10, 44);
        lblDIPCQueue.Name = "lblDIPCQueue";
        lblDIPCQueue.Size = new Size(45, 15);
        lblDIPCQueue.TabIndex = 1;
        lblDIPCQueue.Text = "Queue:";
        // 
        // txtDIPCQueue
        // 
        txtDIPCQueue.Location = new Point(60, 40);
        txtDIPCQueue.Name = "txtDIPCQueue";
        txtDIPCQueue.Size = new Size(100, 23);
        txtDIPCQueue.TabIndex = 2;
        // 
        // btnGetDIPCQueueInfo
        // 
        btnGetDIPCQueueInfo.Location = new Point(170, 38);
        btnGetDIPCQueueInfo.Name = "btnGetDIPCQueueInfo";
        btnGetDIPCQueueInfo.Size = new Size(50, 25);
        btnGetDIPCQueueInfo.TabIndex = 3;
        btnGetDIPCQueueInfo.Text = "Info";
        btnGetDIPCQueueInfo.UseVisualStyleBackColor = true;
        btnGetDIPCQueueInfo.Click += btnGetDIPCQueueInfo_Click;
        // 
        // lblDIPCSize
        // 
        lblDIPCSize.AutoSize = true;
        lblDIPCSize.Location = new Point(110, 12);
        lblDIPCSize.Name = "lblDIPCSize";
        lblDIPCSize.Size = new Size(30, 15);
        lblDIPCSize.TabIndex = 4;
        lblDIPCSize.Text = "Size:";
        // 
        // txtDIPCSize
        // 
        txtDIPCSize.Location = new Point(148, 8);
        txtDIPCSize.Name = "txtDIPCSize";
        txtDIPCSize.Size = new Size(40, 23);
        txtDIPCSize.TabIndex = 5;
        txtDIPCSize.Text = "10";
        // 
        // lblDIPCMsgSize
        // 
        lblDIPCMsgSize.AutoSize = true;
        lblDIPCMsgSize.Location = new Point(196, 12);
        lblDIPCMsgSize.Name = "lblDIPCMsgSize";
        lblDIPCMsgSize.Size = new Size(53, 15);
        lblDIPCMsgSize.TabIndex = 6;
        lblDIPCMsgSize.Text = "MsgSize:";
        // 
        // txtDIPCMsgSize
        // 
        txtDIPCMsgSize.Location = new Point(258, 8);
        txtDIPCMsgSize.Name = "txtDIPCMsgSize";
        txtDIPCMsgSize.Size = new Size(50, 23);
        txtDIPCMsgSize.TabIndex = 7;
        txtDIPCMsgSize.Text = "444";
        // 
        // btnCreateDIPCQueue
        // 
        btnCreateDIPCQueue.Location = new Point(320, 8);
        btnCreateDIPCQueue.Name = "btnCreateDIPCQueue";
        btnCreateDIPCQueue.Size = new Size(65, 25);
        btnCreateDIPCQueue.TabIndex = 8;
        btnCreateDIPCQueue.Text = "Create";
        btnCreateDIPCQueue.UseVisualStyleBackColor = true;
        btnCreateDIPCQueue.Click += btnCreateDIPCQueue_Click;
        // 
        // btnDeleteDIPCQueue
        // 
        btnDeleteDIPCQueue.Location = new Point(230, 38);
        btnDeleteDIPCQueue.Name = "btnDeleteDIPCQueue";
        btnDeleteDIPCQueue.Size = new Size(65, 25);
        btnDeleteDIPCQueue.TabIndex = 9;
        btnDeleteDIPCQueue.Text = "Delete";
        btnDeleteDIPCQueue.UseVisualStyleBackColor = true;
        btnDeleteDIPCQueue.Click += btnDeleteDIPCQueue_Click;
        // 
        // lblDipcMsgType
        // 
        lblDipcMsgType.AutoSize = true;
        lblDipcMsgType.Location = new Point(10, 75);
        lblDipcMsgType.Name = "lblDipcMsgType";
        lblDipcMsgType.Size = new Size(61, 15);
        lblDipcMsgType.TabIndex = 10;
        lblDipcMsgType.Text = "Msg Type:";
        // 
        // txtDipcMsgType
        // 
        txtDipcMsgType.Location = new Point(80, 70);
        txtDipcMsgType.Name = "txtDipcMsgType";
        txtDipcMsgType.Size = new Size(80, 23);
        txtDipcMsgType.TabIndex = 11;
        // 
        // lblDipcCmd
        // 
        lblDipcCmd.AutoSize = true;
        lblDipcCmd.Location = new Point(170, 75);
        lblDipcCmd.Name = "lblDipcCmd";
        lblDipcCmd.Size = new Size(67, 15);
        lblDipcCmd.TabIndex = 12;
        lblDipcCmd.Text = "Command:";
        // 
        // txtDipcCmd
        // 
        txtDipcCmd.Location = new Point(240, 70);
        txtDipcCmd.Name = "txtDipcCmd";
        txtDipcCmd.Size = new Size(150, 23);
        txtDipcCmd.TabIndex = 13;
        // 
        // btnSendDipcMsg
        // 
        btnSendDipcMsg.Location = new Point(400, 70);
        btnSendDipcMsg.Name = "btnSendDipcMsg";
        btnSendDipcMsg.Size = new Size(100, 25);
        btnSendDipcMsg.TabIndex = 14;
        btnSendDipcMsg.Text = "Send Message";
        btnSendDipcMsg.UseVisualStyleBackColor = true;
        btnSendDipcMsg.Click += btnSendDipcMsg_Click;
        // 
        // lblDipcUserDef
        // 
        lblDipcUserDef.AutoSize = true;
        lblDipcUserDef.Location = new Point(10, 110);
        lblDipcUserDef.Name = "lblDipcUserDef";
        lblDipcUserDef.Size = new Size(51, 15);
        lblDipcUserDef.TabIndex = 15;
        lblDipcUserDef.Text = "UserDef:";
        // 
        // txtDipcUserDef
        // 
        txtDipcUserDef.Location = new Point(80, 105);
        txtDipcUserDef.Name = "txtDipcUserDef";
        txtDipcUserDef.Size = new Size(200, 23);
        txtDipcUserDef.TabIndex = 16;
        // 
        // btnSetDipcUserDef
        // 
        btnSetDipcUserDef.Location = new Point(290, 105);
        btnSetDipcUserDef.Name = "btnSetDipcUserDef";
        btnSetDipcUserDef.Size = new Size(110, 25);
        btnSetDipcUserDef.TabIndex = 17;
        btnSetDipcUserDef.Text = "Set UserDef";
        btnSetDipcUserDef.UseVisualStyleBackColor = true;
        btnSetDipcUserDef.Click += btnSetDipcUserDef_Click;
        // 
        // btnGetDipcQueue
        // 
        btnGetDipcQueue.Location = new Point(410, 105);
        btnGetDipcQueue.Name = "btnGetDipcQueue";
        btnGetDipcQueue.Size = new Size(100, 25);
        btnGetDipcQueue.TabIndex = 18;
        btnGetDipcQueue.Text = "Get Queue";
        btnGetDipcQueue.UseVisualStyleBackColor = true;
        btnGetDipcQueue.Click += btnGetDipcQueue_Click;
        // 
        // tabUas
        // 
        tabUas.Controls.Add(pnlUasTop);
        tabUas.Location = new Point(4, 24);
        tabUas.Name = "tabUas";
        tabUas.Padding = new Padding(3);
        tabUas.Size = new Size(892, 121);
        tabUas.TabIndex = 12;
        tabUas.Text = "UAS";
        tabUas.UseVisualStyleBackColor = true;
        // 
        // pnlUasTop
        // 
        pnlUasTop.AutoScroll = true;
        pnlUasTop.Controls.Add(btnGetUasUsers);
        pnlUasTop.Controls.Add(btnGetUasRoles);
        pnlUasTop.Controls.Add(btnGetUasGrants);
        pnlUasTop.Controls.Add(lblUasUser);
        pnlUasTop.Controls.Add(txtUasUser);
        pnlUasTop.Controls.Add(btnGetUserRoles);
        pnlUasTop.Controls.Add(btnGetUserGrants);
        pnlUasTop.Controls.Add(lblUasUsername);
        pnlUasTop.Controls.Add(txtUasUsername);
        pnlUasTop.Controls.Add(lblUasPassword);
        pnlUasTop.Controls.Add(txtUasPassword);
        pnlUasTop.Controls.Add(btnCreateUser);
        pnlUasTop.Controls.Add(btnDeleteUser);
        pnlUasTop.Controls.Add(btnModifyUser);
        pnlUasTop.Controls.Add(btnGetUserInfo);
        pnlUasTop.Controls.Add(lblUasRole);
        pnlUasTop.Controls.Add(txtUasRole);
        pnlUasTop.Controls.Add(btnGetRoleInfo);
        pnlUasTop.Controls.Add(btnCreateRole);
        pnlUasTop.Controls.Add(btnDeleteRole);
        pnlUasTop.Controls.Add(lblUasCapabilities);
        pnlUasTop.Controls.Add(txtUasCapabilities);
        pnlUasTop.Controls.Add(btnSetCapabilities);
        pnlUasTop.Controls.Add(lblGrantUser);
        pnlUasTop.Controls.Add(txtGrantUser);
        pnlUasTop.Controls.Add(lblGrantRole);
        pnlUasTop.Controls.Add(txtGrantRole);
        pnlUasTop.Controls.Add(btnGrantRole);
        pnlUasTop.Controls.Add(btnRevokeRole);
        pnlUasTop.Dock = DockStyle.Fill;
        pnlUasTop.Location = new Point(3, 3);
        pnlUasTop.Name = "pnlUasTop";
        pnlUasTop.Size = new Size(886, 115);
        pnlUasTop.TabIndex = 0;
        // 
        // btnGetUasUsers
        // 
        btnGetUasUsers.Location = new Point(10, 8);
        btnGetUasUsers.Name = "btnGetUasUsers";
        btnGetUasUsers.Size = new Size(80, 25);
        btnGetUasUsers.TabIndex = 0;
        btnGetUasUsers.Text = "Get Users";
        btnGetUasUsers.UseVisualStyleBackColor = true;
        btnGetUasUsers.Click += btnGetUasUsers_Click;
        // 
        // btnGetUasRoles
        // 
        btnGetUasRoles.Location = new Point(100, 8);
        btnGetUasRoles.Name = "btnGetUasRoles";
        btnGetUasRoles.Size = new Size(80, 25);
        btnGetUasRoles.TabIndex = 1;
        btnGetUasRoles.Text = "Get Roles";
        btnGetUasRoles.UseVisualStyleBackColor = true;
        btnGetUasRoles.Click += btnGetUasRoles_Click;
        // 
        // btnGetUasGrants
        // 
        btnGetUasGrants.Location = new Point(190, 8);
        btnGetUasGrants.Name = "btnGetUasGrants";
        btnGetUasGrants.Size = new Size(80, 25);
        btnGetUasGrants.TabIndex = 2;
        btnGetUasGrants.Text = "Get Grants";
        btnGetUasGrants.UseVisualStyleBackColor = true;
        btnGetUasGrants.Click += btnGetUasGrants_Click;
        // 
        // lblUasUser
        // 
        lblUasUser.AutoSize = true;
        lblUasUser.Location = new Point(10, 44);
        lblUasUser.Name = "lblUasUser";
        lblUasUser.Size = new Size(33, 15);
        lblUasUser.TabIndex = 3;
        lblUasUser.Text = "User:";
        // 
        // txtUasUser
        // 
        txtUasUser.Location = new Point(50, 40);
        txtUasUser.Name = "txtUasUser";
        txtUasUser.Size = new Size(120, 23);
        txtUasUser.TabIndex = 4;
        txtUasUser.Text = "Default User";
        // 
        // btnGetUserRoles
        // 
        btnGetUserRoles.Location = new Point(180, 38);
        btnGetUserRoles.Name = "btnGetUserRoles";
        btnGetUserRoles.Size = new Size(85, 25);
        btnGetUserRoles.TabIndex = 5;
        btnGetUserRoles.Text = "User Roles";
        btnGetUserRoles.UseVisualStyleBackColor = true;
        btnGetUserRoles.Click += btnGetUserRoles_Click;
        // 
        // btnGetUserGrants
        // 
        btnGetUserGrants.Location = new Point(275, 38);
        btnGetUserGrants.Name = "btnGetUserGrants";
        btnGetUserGrants.Size = new Size(90, 25);
        btnGetUserGrants.TabIndex = 6;
        btnGetUserGrants.Text = "User Grants";
        btnGetUserGrants.UseVisualStyleBackColor = true;
        btnGetUserGrants.Click += btnGetUserGrants_Click;
        // 
        // lblUasUsername
        // 
        lblUasUsername.AutoSize = true;
        lblUasUsername.Location = new Point(10, 75);
        lblUasUsername.Name = "lblUasUsername";
        lblUasUsername.Size = new Size(63, 15);
        lblUasUsername.TabIndex = 7;
        lblUasUsername.Text = "Username:";
        // 
        // txtUasUsername
        // 
        txtUasUsername.Location = new Point(80, 70);
        txtUasUsername.Name = "txtUasUsername";
        txtUasUsername.Size = new Size(120, 23);
        txtUasUsername.TabIndex = 8;
        // 
        // lblUasPassword
        // 
        lblUasPassword.AutoSize = true;
        lblUasPassword.Location = new Point(210, 75);
        lblUasPassword.Name = "lblUasPassword";
        lblUasPassword.Size = new Size(60, 15);
        lblUasPassword.TabIndex = 9;
        lblUasPassword.Text = "Password:";
        // 
        // txtUasPassword
        // 
        txtUasPassword.Location = new Point(280, 70);
        txtUasPassword.Name = "txtUasPassword";
        txtUasPassword.PasswordChar = '*';
        txtUasPassword.Size = new Size(120, 23);
        txtUasPassword.TabIndex = 10;
        // 
        // btnCreateUser
        // 
        btnCreateUser.Location = new Point(410, 70);
        btnCreateUser.Name = "btnCreateUser";
        btnCreateUser.Size = new Size(90, 25);
        btnCreateUser.TabIndex = 11;
        btnCreateUser.Text = "Create User";
        btnCreateUser.UseVisualStyleBackColor = true;
        btnCreateUser.Click += btnCreateUser_Click;
        // 
        // btnDeleteUser
        // 
        btnDeleteUser.Location = new Point(510, 70);
        btnDeleteUser.Name = "btnDeleteUser";
        btnDeleteUser.Size = new Size(90, 25);
        btnDeleteUser.TabIndex = 12;
        btnDeleteUser.Text = "Delete User";
        btnDeleteUser.UseVisualStyleBackColor = true;
        btnDeleteUser.Click += btnDeleteUser_Click;
        // 
        // btnModifyUser
        // 
        btnModifyUser.Location = new Point(610, 70);
        btnModifyUser.Name = "btnModifyUser";
        btnModifyUser.Size = new Size(90, 25);
        btnModifyUser.TabIndex = 13;
        btnModifyUser.Text = "Modify User";
        btnModifyUser.UseVisualStyleBackColor = true;
        btnModifyUser.Click += btnModifyUser_Click;
        // 
        // btnGetUserInfo
        // 
        btnGetUserInfo.Location = new Point(710, 70);
        btnGetUserInfo.Name = "btnGetUserInfo";
        btnGetUserInfo.Size = new Size(90, 25);
        btnGetUserInfo.TabIndex = 14;
        btnGetUserInfo.Text = "User Info";
        btnGetUserInfo.UseVisualStyleBackColor = true;
        btnGetUserInfo.Click += btnGetUserInfo_Click;
        // 
        // lblUasRole
        // 
        lblUasRole.AutoSize = true;
        lblUasRole.Location = new Point(10, 110);
        lblUasRole.Name = "lblUasRole";
        lblUasRole.Size = new Size(33, 15);
        lblUasRole.TabIndex = 15;
        lblUasRole.Text = "Role:";
        // 
        // txtUasRole
        // 
        txtUasRole.Location = new Point(50, 105);
        txtUasRole.Name = "txtUasRole";
        txtUasRole.Size = new Size(150, 23);
        txtUasRole.TabIndex = 16;
        // 
        // btnGetRoleInfo
        // 
        btnGetRoleInfo.Location = new Point(210, 105);
        btnGetRoleInfo.Name = "btnGetRoleInfo";
        btnGetRoleInfo.Size = new Size(80, 25);
        btnGetRoleInfo.TabIndex = 17;
        btnGetRoleInfo.Text = "Role Info";
        btnGetRoleInfo.UseVisualStyleBackColor = true;
        btnGetRoleInfo.Click += btnGetRoleInfo_Click;
        // 
        // btnCreateRole
        // 
        btnCreateRole.Location = new Point(300, 105);
        btnCreateRole.Name = "btnCreateRole";
        btnCreateRole.Size = new Size(85, 25);
        btnCreateRole.TabIndex = 18;
        btnCreateRole.Text = "Create Role";
        btnCreateRole.UseVisualStyleBackColor = true;
        btnCreateRole.Click += btnCreateRole_Click;
        // 
        // btnDeleteRole
        // 
        btnDeleteRole.Location = new Point(395, 105);
        btnDeleteRole.Name = "btnDeleteRole";
        btnDeleteRole.Size = new Size(85, 25);
        btnDeleteRole.TabIndex = 19;
        btnDeleteRole.Text = "Delete Role";
        btnDeleteRole.UseVisualStyleBackColor = true;
        btnDeleteRole.Click += btnDeleteRole_Click;
        // 
        // lblUasCapabilities
        // 
        lblUasCapabilities.AutoSize = true;
        lblUasCapabilities.Location = new Point(490, 110);
        lblUasCapabilities.Name = "lblUasCapabilities";
        lblUasCapabilities.Size = new Size(71, 15);
        lblUasCapabilities.TabIndex = 20;
        lblUasCapabilities.Text = "Capabilities:";
        // 
        // txtUasCapabilities
        // 
        txtUasCapabilities.Location = new Point(570, 105);
        txtUasCapabilities.Name = "txtUasCapabilities";
        txtUasCapabilities.Size = new Size(180, 23);
        txtUasCapabilities.TabIndex = 21;
        // 
        // btnSetCapabilities
        // 
        btnSetCapabilities.Location = new Point(760, 105);
        btnSetCapabilities.Name = "btnSetCapabilities";
        btnSetCapabilities.Size = new Size(105, 25);
        btnSetCapabilities.TabIndex = 22;
        btnSetCapabilities.Text = "Set Capabilities";
        btnSetCapabilities.UseVisualStyleBackColor = true;
        btnSetCapabilities.Click += btnSetCapabilities_Click;
        // 
        // lblGrantUser
        // 
        lblGrantUser.AutoSize = true;
        lblGrantUser.Location = new Point(10, 145);
        lblGrantUser.Name = "lblGrantUser";
        lblGrantUser.Size = new Size(65, 15);
        lblGrantUser.TabIndex = 23;
        lblGrantUser.Text = "Grant User:";
        // 
        // txtGrantUser
        // 
        txtGrantUser.Location = new Point(85, 140);
        txtGrantUser.Name = "txtGrantUser";
        txtGrantUser.Size = new Size(120, 23);
        txtGrantUser.TabIndex = 24;
        // 
        // lblGrantRole
        // 
        lblGrantRole.AutoSize = true;
        lblGrantRole.Location = new Point(215, 145);
        lblGrantRole.Name = "lblGrantRole";
        lblGrantRole.Size = new Size(33, 15);
        lblGrantRole.TabIndex = 25;
        lblGrantRole.Text = "Role:";
        // 
        // txtGrantRole
        // 
        txtGrantRole.Location = new Point(260, 140);
        txtGrantRole.Name = "txtGrantRole";
        txtGrantRole.Size = new Size(120, 23);
        txtGrantRole.TabIndex = 26;
        // 
        // btnGrantRole
        // 
        btnGrantRole.Location = new Point(390, 140);
        btnGrantRole.Name = "btnGrantRole";
        btnGrantRole.Size = new Size(85, 25);
        btnGrantRole.TabIndex = 27;
        btnGrantRole.Text = "Grant Role";
        btnGrantRole.UseVisualStyleBackColor = true;
        btnGrantRole.Click += btnGrantRole_Click;
        // 
        // btnRevokeRole
        // 
        btnRevokeRole.Location = new Point(485, 140);
        btnRevokeRole.Name = "btnRevokeRole";
        btnRevokeRole.Size = new Size(90, 25);
        btnRevokeRole.TabIndex = 28;
        btnRevokeRole.Text = "Revoke Role";
        btnRevokeRole.UseVisualStyleBackColor = true;
        btnRevokeRole.Click += btnRevokeRole_Click;
        // 
        // tabRetcode
        // 
        tabRetcode.Controls.Add(pnlRetcodeTop);
        tabRetcode.Location = new Point(4, 24);
        tabRetcode.Name = "tabRetcode";
        tabRetcode.Padding = new Padding(3);
        tabRetcode.Size = new Size(892, 272);
        tabRetcode.TabIndex = 13;
        tabRetcode.Text = "Return Codes";
        tabRetcode.UseVisualStyleBackColor = true;
        // 
        // pnlRetcodeTop
        // 
        pnlRetcodeTop.Controls.Add(lblRetcode);
        pnlRetcodeTop.Controls.Add(txtRetcode);
        pnlRetcodeTop.Controls.Add(btnGetRetcodes);
        pnlRetcodeTop.Dock = DockStyle.Top;
        pnlRetcodeTop.Location = new Point(3, 3);
        pnlRetcodeTop.Name = "pnlRetcodeTop";
        pnlRetcodeTop.Size = new Size(886, 50);
        pnlRetcodeTop.TabIndex = 0;
        // 
        // lblRetcode
        // 
        lblRetcode.AutoSize = true;
        lblRetcode.Location = new Point(10, 12);
        lblRetcode.Name = "lblRetcode";
        lblRetcode.Size = new Size(38, 15);
        lblRetcode.TabIndex = 0;
        lblRetcode.Text = "Code:";
        // 
        // txtRetcode
        // 
        txtRetcode.Location = new Point(50, 8);
        txtRetcode.Name = "txtRetcode";
        txtRetcode.Size = new Size(100, 23);
        txtRetcode.TabIndex = 1;
        // 
        // btnGetRetcodes
        // 
        btnGetRetcodes.Location = new Point(160, 8);
        btnGetRetcodes.Name = "btnGetRetcodes";
        btnGetRetcodes.Size = new Size(110, 25);
        btnGetRetcodes.TabIndex = 2;
        btnGetRetcodes.Text = "Get Return Codes";
        btnGetRetcodes.UseVisualStyleBackColor = true;
        btnGetRetcodes.Click += btnGetRetcodes_Click;
        // 
        // pgAnswer
        // 
        pgAnswer.Dock = DockStyle.Fill;
        pgAnswer.HelpVisible = false;
        pgAnswer.Location = new Point(0, 351);
        pgAnswer.Name = "pgAnswer";
        pgAnswer.PropertySort = PropertySort.NoSort;
        pgAnswer.Size = new Size(900, 249);
        pgAnswer.TabIndex = 2;
        pgAnswer.ToolbarVisible = false;
        // 
        // Rws2Control
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(pgAnswer);
        Controls.Add(tabControl);
        Name = "Rws2Control";
        Size = new Size(900, 600);
        tabControl.ResumeLayout(false);
        tabController.ResumeLayout(false);
        pnlControllerTop.ResumeLayout(false);
        pnlControllerTop.PerformLayout();
        tabPanel.ResumeLayout(false);
        pnlPanelTop.ResumeLayout(false);
        pnlPanelTop.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudSpeedRatio).EndInit();
        tabIO.ResumeLayout(false);
        pnlIOTop.ResumeLayout(false);
        pnlIOTop.PerformLayout();
        tabRapid.ResumeLayout(false);
        pnlRapidTop.ResumeLayout(false);
        pnlRapidTop.PerformLayout();
        tabFile.ResumeLayout(false);
        pnlFileTop.ResumeLayout(false);
        pnlFileTop.PerformLayout();
        tabSubscription.ResumeLayout(false);
        pnlSubTop.ResumeLayout(false);
        pnlSubTop.PerformLayout();
        tabSystem.ResumeLayout(false);
        pnlSystemTop.ResumeLayout(false);
        tabMastership.ResumeLayout(false);
        pnlMasterTop.ResumeLayout(false);
        pnlMasterTop.PerformLayout();
        tabElog.ResumeLayout(false);
        pnlElogTop.ResumeLayout(false);
        pnlElogTop.PerformLayout();
        tabCfg.ResumeLayout(false);
        pnlCfgTop.ResumeLayout(false);
        pnlCfgTop.PerformLayout();
        tabMotion.ResumeLayout(false);
        pnlMotionTop.ResumeLayout(false);
        pnlMotionTop.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)txtSpeedRatio).EndInit();
        tabDIPC.ResumeLayout(false);
        pnlDIPCTop.ResumeLayout(false);
        pnlDIPCTop.PerformLayout();
        tabUas.ResumeLayout(false);
        pnlUasTop.ResumeLayout(false);
        pnlUasTop.PerformLayout();
        tabRetcode.ResumeLayout(false);
        pnlRetcodeTop.ResumeLayout(false);
        pnlRetcodeTop.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl;
    private TabPage tabController;
    private TabPage tabPanel;
    private TabPage tabIO;
    private TabPage tabRapid;
    private TabPage tabFile;
    private TabPage tabSubscription;
    // Controller
    private Panel pnlControllerTop;
    private Button btnGetIdentity;
    private Button btnGetDateTime;
    private Label lblEnvName;
    private TextBox txtEnvName;
    private Button btnGetEnvVar;
    private Label lblLangCode;
    private TextBox txtLangCode;
    private Button btnSetLanguage;
    // Panel
    private Panel pnlPanelTop;
    private Button btnGetOpMode;
    private Button btnGetCtrlState;
    private Button btnGetSpeedRatio;
    private Label lblSpeed;
    private NumericUpDown nudSpeedRatio;
    private Button btnSetSpeedRatio;
    // IO
    private Panel pnlIOTop;
    private Button btnGetNetworks;
    private Button btnGetAllSignals;
    private Label lblIONetwork;
    private TextBox txtIONetwork;
    private Label lblIODevice;
    private TextBox txtIODevice;
    private Label lblIOSignal;
    private TextBox txtIOSignal;
    private Button btnGetSignal;
    private Label lblIOValue;
    private TextBox txtIOValue;
    private Button btnSetSignalVal;
    // RAPID
    private Panel pnlRapidTop;
    private Button btnGetExecState;
    private Button btnStartExec;
    private Button btnStopExec;
    private Button btnResetPP;
    private Button btnGetTasks;
    private Label lblTask;
    private TextBox txtTask;
    private Button btnGetModules;
    private Label lblSymbol;
    private TextBox txtSymbolUrl;
    private Button btnGetSymbol;
    private TextBox txtSymbolVal;
    private Button btnSetSymbol;
    // File
    private Panel pnlFileTop;
    private Button btnGetFsDevices;
    private Label lblDirPath;
    private TextBox txtDirPath;
    private Button btnListDir;
    private Label lblFilePath;
    private TextBox txtFilePath;
    private Button btnGetFileContent;
    private Label lblUploadPath;
    private TextBox txtUploadPath;
    private Label lblCreatePath;
    private TextBox txtCreatePath;
    private Button btnCreateFolder;
    private Button btnDeleteFolder;
    private Button btnMoveFile;
    private Button btnUploadBackup;
    private Button btnDownloadBackup;
    private Button btnGetFileInfo;
    private Button btnGetFileProperty;
    private Button btnSetFileProperty;
    // Subscription
    private Panel pnlSubTop;
    private Label lblSubResource;
    private TextBox txtSubResource;
    private Label lblSubPriority;
    private ComboBox cbSubPriority;
    private Button btnSubscribe;
    private Label lblSubGroupId;
    private TextBox txtSubGroupId;
    private Button btnUnsubscribe;
    private Label lblUpdateResource;
    private TextBox txtUpdateResource;
    // System
    private TabPage tabSystem;
    private Panel pnlSystemTop;
    private Button btnGetSysInfo;
    private Button btnGetSysOptions;
    private Button btnGetRobotType;
    private Button btnGetLicense;
    private Button btnGetEnergy;
    private Button btnResetEnergy;
    // Mastership
    private TabPage tabMastership;
    private Panel pnlMasterTop;
    private Button btnGetEditDomain;
    private Button btnGetMotionDomain;
    private Button btnRequestAllMaster;
    private Button btnReleaseAllMaster;
    private Label lblMasterDomain;
    private TextBox txtMasterDomain;
    private Button btnRequestMaster;
    private Button btnReleaseMaster;
    // Elog
    private TabPage tabElog;
    private Panel pnlElogTop;
    private Button btnGetElogDomains;
    private Label lblElogDomain;
    private TextBox txtElogDomain;
    private Button btnGetElogMessages;
    private Button btnClearAllElog;
    private Button btnClearElogDomain;
    private Button btnSaveRawElog;
    // CFG
    private TabPage tabCfg;
    private Panel pnlCfgTop;
    private Button btnGetCfgDomains;
    private Label lblCfgDomain;
    private TextBox txtCfgDomain;
    private Button btnGetCfgTypes;
    private Label lblCfgType;
    private TextBox txtCfgType;
    private Button btnGetCfgInstances;
    private Button btnGetCfgAttributes;
    private Label lblCfgAttribute;
    private TextBox txtCfgAttribute;
    private Button btnGetAttribute;
    private Label lblCfgValue;
    private TextBox txtCfgValue;
    private Button btnSetAttribute;
    private Button btnDeleteInstance;
    private Button btnCreateDefault;
    private Button btnLoadCfg;
    private Button btnSaveCfg;
    private Button btnValidateCfg;
    private Button btnResetCfg;
    private Button btnCfgSystemAction;
    // Motion
    private TabPage tabMotion;
    private Panel pnlMotionTop;
    private Button btnGetMechUnits;
    private Label lblMechUnit;
    private TextBox txtMechUnit;
    private Button btnGetMechUnit;
    private Button btnGetCartesian;
    private Button btnGetRobTarget;
    private Button btnGetJointTarget;
    private Label lblMechUnitState;
    private ComboBox cbMechUnitState;
    private Button btnSetMechUnitState;
    private Label lblPayload;
    private TextBox txtPayload;
    private Button btnSetPayload;
    private Button btnGetPayload;
    private Label lblSupervision;
    private CheckBox cbSupervision;
    private Button btnSetSupervision;
    private Button btnGetSupervision;
    private Button btnResetPpMoved;
    private Label lblCalAxis;
    private TextBox txtCalAxis;
    private Button btnLoadIdentity;
    private Button btnClearCalibPath;
    private Label lblCalibOffset;
    private TextBox txtCalibOffset;
    private Button btnSetCalibOffset;
    private Button btnGetCalibOffset;
    private Label lblJogSpeed;
    private TextBox txtJogSpeed;
    private Label lblJogIncrement;
    private TextBox txtJogIncrement;
    private Label lblJogMode;
    private ComboBox cbJogMode;
    private Button btnStartJogF;
    private Button btnStartJogB;
    private Button btnStartJogR;
    private Button btnStartJogL;
    private Button btnStartJogU;
    private Button btnStartJogD;
    private Button btnStopJog;
    private Button btnSetJogMode;
    private Label lblSpeedRatio;
    private NumericUpDown txtSpeedRatio;
    private Button btnEnableLeadThrough;
    private Button btnDisableLeadThrough;
    private Button btnGetMechUnitMode;
    // DIPC
    private TabPage tabDIPC;
    private Panel pnlDIPCTop;
    private Button btnGetDIPCQueues;
    private Label lblDIPCQueue;
    private TextBox txtDIPCQueue;
    private Button btnGetDIPCQueueInfo;
    private Label lblDIPCSize;
    private TextBox txtDIPCSize;
    private Label lblDIPCMsgSize;
    private TextBox txtDIPCMsgSize;
    private Button btnCreateDIPCQueue;
    private Button btnDeleteDIPCQueue;
    private Label lblDipcMsgType;
    private TextBox txtDipcMsgType;
    private Label lblDipcCmd;
    private TextBox txtDipcCmd;
    private Button btnSendDipcMsg;
    private Label lblDipcUserDef;
    private TextBox txtDipcUserDef;
    private Button btnSetDipcUserDef;
    private Button btnGetDipcQueue;
    // UAS
    private TabPage tabUas;
    private Panel pnlUasTop;
    private Button btnGetUasUsers;
    private Button btnGetUasRoles;
    private Button btnGetUasGrants;
    private Label lblUasUser;
    private TextBox txtUasUser;
    private Button btnGetUserRoles;
    private Button btnGetUserGrants;
    private Label lblUasUsername;
    private TextBox txtUasUsername;
    private Label lblUasPassword;
    private TextBox txtUasPassword;
    private Button btnCreateUser;
    private Button btnDeleteUser;
    private Button btnModifyUser;
    private Button btnGetUserInfo;
    private Label lblUasRole;
    private TextBox txtUasRole;
    private Button btnGetRoleInfo;
    private Button btnCreateRole;
    private Button btnDeleteRole;
    private Label lblUasCapabilities;
    private TextBox txtUasCapabilities;
    private Button btnSetCapabilities;
    private Label lblGrantUser;
    private TextBox txtGrantUser;
    private Label lblGrantRole;
    private TextBox txtGrantRole;
    private Button btnGrantRole;
    private Button btnRevokeRole;
    // Retcode
    private TabPage tabRetcode;
    private Panel pnlRetcodeTop;
    private Label lblRetcode;
    private TextBox txtRetcode;
    private Button btnGetRetcodes;
    private PropertyGrid pgAnswer;

    // Controller Tab - Additional controls
    private Label lblSetDateTime;
    private TextBox txtSetDateTime;
    private Button btnSetDateTime;
    private Label lblTimezone;
    private TextBox txtTimezone;
    private Button btnGetTimezone;
    private Button btnSetTimezone;
    private Label lblTimeserver;
    private TextBox txtTimeserver;
    private Button btnGetTimeserver;
    private Button btnSetTimeserver;
    private Button btnGetBackupInfo;
    private Button btnGetBackupState;
    private Label lblBackupPath;
    private TextBox txtBackupPath;
    private Button btnCreateBackup;
    private Button btnRestoreBackup;
    private Button btnCheckRestore;
    private Button btnCompress;
    private Button btnDecompress;
    private Button btnGetCertStores;
    private Label lblCertStoreGroup;
    private TextBox txtCertStoreGroup;
    private Label lblCertStoreName;
    private TextBox txtCertStoreName;
    private Button btnGetCertificate;
    private Button btnClearCertStore;
    private Label lblRestartMode;
    private ComboBox cbRestartMode;
    private Button btnRestart;

    // Panel Tab - Additional controls
    private Button btnKeylessMotorOn;
    private Button btnGetEnablingDevRequired;
    private Button btnGetCollisionDetectionState;
    private Button btnGetOpModeLockState;
    private Label lblAckOpMode;
    private TextBox txtAckOpMode;
    private Button btnAckOpMode;
    private Label lblLockPin;
    private TextBox txtLockPin;
    private Label lblLockPermanent;
    private CheckBox cbLockPermanent;
    private Button btnLockOpMode;
    private Label lblUnlockPin;
    private TextBox txtUnlockPin;
    private Button btnUnlockOpMode;
    private Label lblPanelCtrlState;
    private ComboBox cbPanelCtrlState;
    private Button btnSetCtrlState;
    private Label lblEnableSwitch;
    private CheckBox cbEnableSwitch;
    private Button btnSetEnableSwitch;
    private Label lblEmergencyStop;
    private CheckBox cbEmergencyStop;
    private Button btnSetEmergencyStop;
    private Label lblPanelRestartMode;
    private ComboBox cbPanelRestartMode;
    private Button btnPanelRestart;
    private Label lblPanelLangCode;
    private TextBox txtPanelLangCode;
    private Button btnSetPanelLanguage;

    // IO Tab - Additional controls
    private Label lblNetworkForDevices;
    private TextBox txtNetworkForDevices;
    private Button btnGetNetworkDevices;
    private Label lblIOState;
    private TextBox txtIOState;
    private Button btnSetLogicalState;

    // RAPID Tab - Additional controls
    private Label lblStopMode;
    private ComboBox cbStopMode;
    private Label lblExecCycle;
    private ComboBox cbExecCycle;
    private Button btnSetExecCycle;
    private Label lblActivateTasks;
    private TextBox txtActivateTasks;
    private Button btnActivateTasks;
    private Button btnDeactivateTasks;
    private Label lblModule;
    private TextBox txtModule;
    private Button btnGetModuleText;
    private Label lblModuleText;
    private TextBox txtModuleText;
    private Button btnSetModuleText;
    private Label lblModPath;
    private TextBox txtModPath;
    private Label lblReplaceModule;
    private CheckBox cbReplaceModule;
    private Button btnLoadModule;
    private Button btnUnloadModule;
    private Label lblProgPath;
    private TextBox txtProgPath;
    private Button btnLoadProgram;
    private Button btnSaveProgram;
    private Button btnUnloadProgram;

    // File Tab - Additional controls
    private Label lblUploadContent;
    private TextBox txtUploadContent;
    private Button btnUploadFile;
    private Button btnDeleteFile;
    private Button btnDeleteDirectory;
    private Label lblNewDirParent;
    private TextBox txtNewDirParent;
    private Label lblNewDirName;
    private TextBox txtNewDirName;
    private Button btnCreateDirectory;
    private Label lblRenameNewName;
    private TextBox txtRenameNewName;
    private Button btnRenameFile;
    private Button btnRenameDirectory;
    private Label lblCopyDest;
    private TextBox txtCopyDest;
    private Label lblCopyOverwrite;
    private CheckBox cbCopyOverwrite;
    private Button btnCopyFile;
    private Button btnCopyDirectory;

    // Subscription Tab - Additional controls
    private Label lblUpdateSubResources;
    private TextBox txtUpdateSubResources;
    private Button btnUpdateSubscription;
    private Label lblUnsubResource;
    private TextBox txtUnsubResource;
    private Button btnUnsubscribeResource;

    // Mastership Tab - Additional controls
    private Button btnGetMasterDomain;

    // Elog Tab - Additional controls
    private Label lblElogSavePath;
    private TextBox txtElogSavePath;
    private Button btnSaveRaw;

    // Cfg Tab - Additional controls
    private Label lblCfgInstance;
    private TextBox txtCfgInstance;
    private Button btnGetCfgInstance;
    private Button btnDeleteCfgInstance;
    private Button btnCreateDefaultInstance;
    private Button btnResetCfgDomain;
    private Button btnResetCfgInstances;
    private Label lblCfgAttribs;
    private TextBox txtCfgAttribs;
    private Button btnUpdateCfgInstance;
    private Label lblCfgFilePath;
    private TextBox txtCfgFilePath;
    private Button btnCfgSaveAs;
    private Label lblCfgActionType;
    private TextBox txtCfgActionType;
    private Button btnCfgLoad;
    private Button btnCfgValidate;

    // Motion Tab - Additional controls
    private Button btnGetBaseFrame;
    private Button btnGetPhysicalJoints;
    private Label lblMechUnitProps;
    private TextBox txtMechUnitProps;
    private Button btnSetMechUnit;
    private Button btnGetMotionSupMode;
    private Button btnGetMotionSupLevel;
    private Label lblMotionSupEnabled;
    private CheckBox cbMotionSupEnabled;
    private Button btnSetMotionSupMode;
    private Label lblMotionSupLevel;
    private TextBox txtMotionSupLevel;
    private Button btnSetMotionSupLevel;
    private Button btnGetPathSupMode;
    private Label lblPathSupMode;
    private TextBox txtPathSupMode;
    private Button btnSetPathSupMode;
    private Label lblPathSupLevel;
    private TextBox txtPathSupLevel;
    private Button btnSetPathSupLevel;
    private Button btnGetCollisionPredMode;
    private Label lblCollisionPredEnabled;
    private CheckBox cbCollisionPredEnabled;
    private Button btnSetCollisionPredMode;
    private Button btnGetMotionErrorState;
    private Button btnGetNonMotionExecMode;
    private Label lblNonMotionMode;
    private TextBox txtNonMotionMode;
    private Button btnSetNonMotionExecMode;
    private Button btnGetLeadThrough;
    private Label lblLeadThroughStatus;
    private TextBox txtLeadThroughStatus;
    private Button btnSetLeadThrough;
    private Button btnGetSmbData;
    private Label lblSmbData;
    private TextBox txtSmbData;
    private Button btnSetSmbData;
    private Label lblRobJoint;
    private TextBox txtRobJoint;
    private Label lblExtJoint;
    private TextBox txtExtJoint;
    private Button btnSetPosition;
    private Label lblCalibAxis;
    private TextBox txtCalibAxis;
    private Button btnFineCalibrate;
    private Button btnUpdateRevCounter;
    private Label lblJogAxis1;
    private TextBox txtJogAxis1;
    private Label lblJogAxis2;
    private TextBox txtJogAxis2;
    private Label lblJogAxis3;
    private TextBox txtJogAxis3;
    private Label lblJogAxis4;
    private TextBox txtJogAxis4;
    private Label lblJogAxis5;
    private TextBox txtJogAxis5;
    private Label lblJogAxis6;
    private TextBox txtJogAxis6;
    private Label lblJogCcount;
    private TextBox txtJogCcount;
    private Label lblJogIncMode;
    private TextBox txtJogIncMode;
    private Button btnJog;

    // DIPC Tab - Additional controls
    private Label lblDIPCTimeout;
    private TextBox txtDIPCTimeout;
    private Button btnReadDIPCMessage;
    private Label lblDIPCSrcQueue;
    private TextBox txtDIPCSrcQueue;
    private Label lblDIPCCmd;
    private TextBox txtDIPCCmd;
    private Label lblDIPCUserDef;
    private TextBox txtDIPCUserDef;
    private Label lblDIPCMsgType;
    private TextBox txtDIPCMsgType;
    private Label lblDIPCData;
    private TextBox txtDIPCData;
    private Button btnSendDIPCMessage;
}
