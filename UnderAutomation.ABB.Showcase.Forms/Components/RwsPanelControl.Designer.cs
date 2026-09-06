
partial class RwsPanelControl
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
        tabState = new TabPage();
        flowState = new FlowLayoutPanel();
        pnlControllerState = new Panel();
        btnGetControllerState = new Button();
        sep1 = new Panel();
        txtControllerState = new TextBox();
        sep2 = new Panel();
        cboSetControllerStateState = new ComboBox();
        sep3 = new Panel();
        btnSetControllerState = new Button();
        pnlSpeedRatio = new Panel();
        btnGetSpeedRatio = new Button();
        sep4 = new Panel();
        numSpeedRatio = new NumericUpDown();
        sep5 = new Panel();
        chkSetSpeedRatioUseImplicitMastership = new CheckBox();
        sep6 = new Panel();
        btnSetSpeedRatio = new Button();
        pnlCollisionDetectionState = new Panel();
        btnGetCollisionDetectionState = new Button();
        sep7 = new Panel();
        txtCollisionDetectionState = new TextBox();
        tabOpMode = new TabPage();
        flowOpMode = new FlowLayoutPanel();
        pnlOperationMode = new Panel();
        btnGetOperationMode = new Button();
        sep8 = new Panel();
        txtOperationMode = new TextBox();
        pnlAcknowledgeOperationMode = new Panel();
        cboAcknowledgeOperationModeAcknowledgement = new ComboBox();
        sep9 = new Panel();
        btnAcknowledgeOperationMode = new Button();
        pnlOperationModeLockState = new Panel();
        btnGetOperationModeLockState = new Button();
        sep10 = new Panel();
        txtOperationModeLockState = new TextBox();
        pnlOperationModeLock = new Panel();
        txtOperationModePin = new TextBox();
        sep11 = new Panel();
        chkLockOperationModePermanent = new CheckBox();
        sep12 = new Panel();
        btnLockOperationMode = new Button();
        sep13 = new Panel();
        btnUnlockOperationMode = new Button();
        tabController = new TabPage();
        flowController = new FlowLayoutPanel();
        pnlLanguage = new Panel();
        txtSetLanguageLanguageCode = new TextBox();
        sep14 = new Panel();
        btnSetLanguage = new Button();
        pnlRestart = new Panel();
        cboRestartMode = new ComboBox();
        sep15 = new Panel();
        chkRestartUseImplicitMastership = new CheckBox();
        sep16 = new Panel();
        btnRestart = new Button();
        tabControl.SuspendLayout();
        tabState.SuspendLayout();
        flowState.SuspendLayout();
        tabOpMode.SuspendLayout();
        flowOpMode.SuspendLayout();
        tabController.SuspendLayout();
        flowController.SuspendLayout();
        pnlControllerState.SuspendLayout();
        pnlSpeedRatio.SuspendLayout();
        pnlCollisionDetectionState.SuspendLayout();
        pnlOperationMode.SuspendLayout();
        pnlAcknowledgeOperationMode.SuspendLayout();
        pnlOperationModeLockState.SuspendLayout();
        pnlOperationModeLock.SuspendLayout();
        pnlLanguage.SuspendLayout();
        pnlRestart.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numSpeedRatio).BeginInit();
        SuspendLayout();
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabState);
        tabControl.Controls.Add(tabOpMode);
        tabControl.Controls.Add(tabController);
        tabControl.Dock = DockStyle.Fill;
        tabControl.Location = new Point(0, 0);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(890, 491);
        tabControl.TabIndex = 0;
        // 
        // tabState
        // 
        tabState.Controls.Add(flowState);
        tabState.Location = new Point(4, 24);
        tabState.Name = "tabState";
        tabState.Padding = new Padding(3);
        tabState.Size = new Size(882, 463);
        tabState.TabIndex = 0;
        tabState.Text = "Controller state";
        tabState.UseVisualStyleBackColor = true;
        // 
        // flowState
        // 
        flowState.AutoScroll = true;
        flowState.Controls.Add(pnlControllerState);
        flowState.Controls.Add(pnlSpeedRatio);
        flowState.Controls.Add(pnlCollisionDetectionState);
        flowState.Dock = DockStyle.Fill;
        flowState.FlowDirection = FlowDirection.TopDown;
        flowState.Location = new Point(3, 3);
        flowState.Name = "flowState";
        flowState.Size = new Size(876, 457);
        flowState.TabIndex = 0;
        // 
        // pnlControllerState
        // 
        pnlControllerState.BorderStyle = BorderStyle.FixedSingle;
        pnlControllerState.Controls.Add(btnSetControllerState);
        pnlControllerState.Controls.Add(sep3);
        pnlControllerState.Controls.Add(cboSetControllerStateState);
        pnlControllerState.Controls.Add(sep2);
        pnlControllerState.Controls.Add(txtControllerState);
        pnlControllerState.Controls.Add(sep1);
        pnlControllerState.Controls.Add(btnGetControllerState);
        pnlControllerState.Location = new Point(3, 3);
        pnlControllerState.Name = "pnlControllerState";
        pnlControllerState.Padding = new Padding(5);
        pnlControllerState.Size = new Size(250, 119);
        pnlControllerState.TabIndex = 0;
        // 
        // btnGetControllerState
        // 
        btnGetControllerState.Dock = DockStyle.Top;
        btnGetControllerState.Location = new Point(5, 5);
        btnGetControllerState.Name = "btnGetControllerState";
        btnGetControllerState.Size = new Size(238, 23);
        btnGetControllerState.TabIndex = 0;
        btnGetControllerState.Text = "Get Controller state";
        btnGetControllerState.UseVisualStyleBackColor = true;
        btnGetControllerState.Click += btnGetControllerState_Click;
        // 
        // sep1
        // 
        sep1.Dock = DockStyle.Top;
        sep1.Location = new Point(5, 28);
        sep1.Name = "sep1";
        sep1.Size = new Size(238, 5);
        sep1.TabIndex = 1;
        // 
        // txtControllerState
        // 
        txtControllerState.Dock = DockStyle.Top;
        txtControllerState.Location = new Point(5, 33);
        txtControllerState.Name = "txtControllerState";
        txtControllerState.PlaceholderText = "controller state";
        txtControllerState.ReadOnly = true;
        txtControllerState.Size = new Size(238, 23);
        txtControllerState.TabIndex = 2;
        // 
        // sep2
        // 
        sep2.Dock = DockStyle.Top;
        sep2.Location = new Point(5, 56);
        sep2.Name = "sep2";
        sep2.Size = new Size(238, 5);
        sep2.TabIndex = 3;
        // 
        // cboSetControllerStateState
        // 
        cboSetControllerStateState.Dock = DockStyle.Top;
        cboSetControllerStateState.Location = new Point(5, 61);
        cboSetControllerStateState.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSetControllerStateState.FormattingEnabled = true;
        cboSetControllerStateState.Name = "cboSetControllerStateState";
        cboSetControllerStateState.Size = new Size(238, 23);
        cboSetControllerStateState.TabIndex = 4;
        // 
        // sep3
        // 
        sep3.Dock = DockStyle.Top;
        sep3.Location = new Point(5, 84);
        sep3.Name = "sep3";
        sep3.Size = new Size(238, 5);
        sep3.TabIndex = 5;
        // 
        // btnSetControllerState
        // 
        btnSetControllerState.Dock = DockStyle.Top;
        btnSetControllerState.Location = new Point(5, 89);
        btnSetControllerState.Name = "btnSetControllerState";
        btnSetControllerState.Size = new Size(238, 23);
        btnSetControllerState.TabIndex = 6;
        btnSetControllerState.Text = "Set Controller state";
        btnSetControllerState.UseVisualStyleBackColor = true;
        btnSetControllerState.Click += btnSetControllerState_Click;
        // 
        // pnlSpeedRatio
        // 
        pnlSpeedRatio.BorderStyle = BorderStyle.FixedSingle;
        pnlSpeedRatio.Controls.Add(btnSetSpeedRatio);
        pnlSpeedRatio.Controls.Add(sep6);
        pnlSpeedRatio.Controls.Add(chkSetSpeedRatioUseImplicitMastership);
        pnlSpeedRatio.Controls.Add(sep5);
        pnlSpeedRatio.Controls.Add(numSpeedRatio);
        pnlSpeedRatio.Controls.Add(sep4);
        pnlSpeedRatio.Controls.Add(btnGetSpeedRatio);
        pnlSpeedRatio.Location = new Point(3, 3);
        pnlSpeedRatio.Name = "pnlSpeedRatio";
        pnlSpeedRatio.Padding = new Padding(5);
        pnlSpeedRatio.Size = new Size(250, 119);
        pnlSpeedRatio.TabIndex = 1;
        // 
        // btnGetSpeedRatio
        // 
        btnGetSpeedRatio.Dock = DockStyle.Top;
        btnGetSpeedRatio.Location = new Point(5, 5);
        btnGetSpeedRatio.Name = "btnGetSpeedRatio";
        btnGetSpeedRatio.Size = new Size(238, 23);
        btnGetSpeedRatio.TabIndex = 0;
        btnGetSpeedRatio.Text = "Get Speed ratio";
        btnGetSpeedRatio.UseVisualStyleBackColor = true;
        btnGetSpeedRatio.Click += btnGetSpeedRatio_Click;
        // 
        // sep4
        // 
        sep4.Dock = DockStyle.Top;
        sep4.Location = new Point(5, 28);
        sep4.Name = "sep4";
        sep4.Size = new Size(238, 5);
        sep4.TabIndex = 1;
        // 
        // numSpeedRatio
        // 
        numSpeedRatio.Dock = DockStyle.Top;
        numSpeedRatio.Location = new Point(5, 33);
        numSpeedRatio.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
        numSpeedRatio.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        numSpeedRatio.Name = "numSpeedRatio";
        numSpeedRatio.Size = new Size(238, 23);
        numSpeedRatio.TabIndex = 2;
        numSpeedRatio.Value = new decimal(new int[] { 100, 0, 0, 0 });
        // 
        // sep5
        // 
        sep5.Dock = DockStyle.Top;
        sep5.Location = new Point(5, 56);
        sep5.Name = "sep5";
        sep5.Size = new Size(238, 5);
        sep5.TabIndex = 3;
        // 
        // chkSetSpeedRatioUseImplicitMastership
        // 
        chkSetSpeedRatioUseImplicitMastership.Dock = DockStyle.Top;
        chkSetSpeedRatioUseImplicitMastership.Location = new Point(5, 61);
        chkSetSpeedRatioUseImplicitMastership.Checked = true;
        chkSetSpeedRatioUseImplicitMastership.CheckState = CheckState.Checked;
        chkSetSpeedRatioUseImplicitMastership.Name = "chkSetSpeedRatioUseImplicitMastership";
        chkSetSpeedRatioUseImplicitMastership.Size = new Size(238, 23);
        chkSetSpeedRatioUseImplicitMastership.TabIndex = 4;
        chkSetSpeedRatioUseImplicitMastership.Text = "Use implicit mastership";
        chkSetSpeedRatioUseImplicitMastership.UseVisualStyleBackColor = true;
        // 
        // sep6
        // 
        sep6.Dock = DockStyle.Top;
        sep6.Location = new Point(5, 84);
        sep6.Name = "sep6";
        sep6.Size = new Size(238, 5);
        sep6.TabIndex = 5;
        // 
        // btnSetSpeedRatio
        // 
        btnSetSpeedRatio.Dock = DockStyle.Top;
        btnSetSpeedRatio.Location = new Point(5, 89);
        btnSetSpeedRatio.Name = "btnSetSpeedRatio";
        btnSetSpeedRatio.Size = new Size(238, 23);
        btnSetSpeedRatio.TabIndex = 6;
        btnSetSpeedRatio.Text = "Set Speed ratio";
        btnSetSpeedRatio.UseVisualStyleBackColor = true;
        btnSetSpeedRatio.Click += btnSetSpeedRatio_Click;
        // 
        // pnlCollisionDetectionState
        // 
        pnlCollisionDetectionState.BorderStyle = BorderStyle.FixedSingle;
        pnlCollisionDetectionState.Controls.Add(txtCollisionDetectionState);
        pnlCollisionDetectionState.Controls.Add(sep7);
        pnlCollisionDetectionState.Controls.Add(btnGetCollisionDetectionState);
        pnlCollisionDetectionState.Location = new Point(3, 3);
        pnlCollisionDetectionState.Name = "pnlCollisionDetectionState";
        pnlCollisionDetectionState.Padding = new Padding(5);
        pnlCollisionDetectionState.Size = new Size(250, 63);
        pnlCollisionDetectionState.TabIndex = 2;
        // 
        // btnGetCollisionDetectionState
        // 
        btnGetCollisionDetectionState.Dock = DockStyle.Top;
        btnGetCollisionDetectionState.Location = new Point(5, 5);
        btnGetCollisionDetectionState.Name = "btnGetCollisionDetectionState";
        btnGetCollisionDetectionState.Size = new Size(238, 23);
        btnGetCollisionDetectionState.TabIndex = 0;
        btnGetCollisionDetectionState.Text = "Get Collision detection state";
        btnGetCollisionDetectionState.UseVisualStyleBackColor = true;
        btnGetCollisionDetectionState.Click += btnGetCollisionDetectionState_Click;
        // 
        // sep7
        // 
        sep7.Dock = DockStyle.Top;
        sep7.Location = new Point(5, 28);
        sep7.Name = "sep7";
        sep7.Size = new Size(238, 5);
        sep7.TabIndex = 1;
        // 
        // txtCollisionDetectionState
        // 
        txtCollisionDetectionState.Dock = DockStyle.Top;
        txtCollisionDetectionState.Location = new Point(5, 33);
        txtCollisionDetectionState.Name = "txtCollisionDetectionState";
        txtCollisionDetectionState.PlaceholderText = "collision detection state";
        txtCollisionDetectionState.ReadOnly = true;
        txtCollisionDetectionState.Size = new Size(238, 23);
        txtCollisionDetectionState.TabIndex = 2;
        // 
        // tabOpMode
        // 
        tabOpMode.Controls.Add(flowOpMode);
        tabOpMode.Location = new Point(4, 24);
        tabOpMode.Name = "tabOpMode";
        tabOpMode.Padding = new Padding(3);
        tabOpMode.Size = new Size(882, 463);
        tabOpMode.TabIndex = 1;
        tabOpMode.Text = "Operating mode";
        tabOpMode.UseVisualStyleBackColor = true;
        // 
        // flowOpMode
        // 
        flowOpMode.AutoScroll = true;
        flowOpMode.Controls.Add(pnlOperationMode);
        flowOpMode.Controls.Add(pnlAcknowledgeOperationMode);
        flowOpMode.Controls.Add(pnlOperationModeLockState);
        flowOpMode.Controls.Add(pnlOperationModeLock);
        flowOpMode.Dock = DockStyle.Fill;
        flowOpMode.FlowDirection = FlowDirection.TopDown;
        flowOpMode.Location = new Point(3, 3);
        flowOpMode.Name = "flowOpMode";
        flowOpMode.Size = new Size(876, 457);
        flowOpMode.TabIndex = 0;
        // 
        // pnlOperationMode
        // 
        pnlOperationMode.BorderStyle = BorderStyle.FixedSingle;
        pnlOperationMode.Controls.Add(txtOperationMode);
        pnlOperationMode.Controls.Add(sep8);
        pnlOperationMode.Controls.Add(btnGetOperationMode);
        pnlOperationMode.Location = new Point(3, 3);
        pnlOperationMode.Name = "pnlOperationMode";
        pnlOperationMode.Padding = new Padding(5);
        pnlOperationMode.Size = new Size(250, 63);
        pnlOperationMode.TabIndex = 0;
        // 
        // btnGetOperationMode
        // 
        btnGetOperationMode.Dock = DockStyle.Top;
        btnGetOperationMode.Location = new Point(5, 5);
        btnGetOperationMode.Name = "btnGetOperationMode";
        btnGetOperationMode.Size = new Size(238, 23);
        btnGetOperationMode.TabIndex = 0;
        btnGetOperationMode.Text = "Get Operating mode";
        btnGetOperationMode.UseVisualStyleBackColor = true;
        btnGetOperationMode.Click += btnGetOperationMode_Click;
        // 
        // sep8
        // 
        sep8.Dock = DockStyle.Top;
        sep8.Location = new Point(5, 28);
        sep8.Name = "sep8";
        sep8.Size = new Size(238, 5);
        sep8.TabIndex = 1;
        // 
        // txtOperationMode
        // 
        txtOperationMode.Dock = DockStyle.Top;
        txtOperationMode.Location = new Point(5, 33);
        txtOperationMode.Name = "txtOperationMode";
        txtOperationMode.PlaceholderText = "operating mode";
        txtOperationMode.ReadOnly = true;
        txtOperationMode.Size = new Size(238, 23);
        txtOperationMode.TabIndex = 2;
        // 
        // pnlAcknowledgeOperationMode
        // 
        pnlAcknowledgeOperationMode.BorderStyle = BorderStyle.FixedSingle;
        pnlAcknowledgeOperationMode.Controls.Add(btnAcknowledgeOperationMode);
        pnlAcknowledgeOperationMode.Controls.Add(sep9);
        pnlAcknowledgeOperationMode.Controls.Add(cboAcknowledgeOperationModeAcknowledgement);
        pnlAcknowledgeOperationMode.Location = new Point(3, 3);
        pnlAcknowledgeOperationMode.Name = "pnlAcknowledgeOperationMode";
        pnlAcknowledgeOperationMode.Padding = new Padding(5);
        pnlAcknowledgeOperationMode.Size = new Size(250, 63);
        pnlAcknowledgeOperationMode.TabIndex = 1;
        // 
        // cboAcknowledgeOperationModeAcknowledgement
        // 
        cboAcknowledgeOperationModeAcknowledgement.Dock = DockStyle.Top;
        cboAcknowledgeOperationModeAcknowledgement.Location = new Point(5, 5);
        cboAcknowledgeOperationModeAcknowledgement.DropDownStyle = ComboBoxStyle.DropDownList;
        cboAcknowledgeOperationModeAcknowledgement.FormattingEnabled = true;
        cboAcknowledgeOperationModeAcknowledgement.Name = "cboAcknowledgeOperationModeAcknowledgement";
        cboAcknowledgeOperationModeAcknowledgement.Size = new Size(238, 23);
        cboAcknowledgeOperationModeAcknowledgement.TabIndex = 0;
        // 
        // sep9
        // 
        sep9.Dock = DockStyle.Top;
        sep9.Location = new Point(5, 28);
        sep9.Name = "sep9";
        sep9.Size = new Size(238, 5);
        sep9.TabIndex = 1;
        // 
        // btnAcknowledgeOperationMode
        // 
        btnAcknowledgeOperationMode.Dock = DockStyle.Top;
        btnAcknowledgeOperationMode.Location = new Point(5, 33);
        btnAcknowledgeOperationMode.Name = "btnAcknowledgeOperationMode";
        btnAcknowledgeOperationMode.Size = new Size(238, 23);
        btnAcknowledgeOperationMode.TabIndex = 2;
        btnAcknowledgeOperationMode.Text = "Acknowledge Operating mode";
        btnAcknowledgeOperationMode.UseVisualStyleBackColor = true;
        btnAcknowledgeOperationMode.Click += btnAcknowledgeOperationMode_Click;
        // 
        // pnlOperationModeLockState
        // 
        pnlOperationModeLockState.BorderStyle = BorderStyle.FixedSingle;
        pnlOperationModeLockState.Controls.Add(txtOperationModeLockState);
        pnlOperationModeLockState.Controls.Add(sep10);
        pnlOperationModeLockState.Controls.Add(btnGetOperationModeLockState);
        pnlOperationModeLockState.Location = new Point(3, 3);
        pnlOperationModeLockState.Name = "pnlOperationModeLockState";
        pnlOperationModeLockState.Padding = new Padding(5);
        pnlOperationModeLockState.Size = new Size(250, 63);
        pnlOperationModeLockState.TabIndex = 2;
        // 
        // btnGetOperationModeLockState
        // 
        btnGetOperationModeLockState.Dock = DockStyle.Top;
        btnGetOperationModeLockState.Location = new Point(5, 5);
        btnGetOperationModeLockState.Name = "btnGetOperationModeLockState";
        btnGetOperationModeLockState.Size = new Size(238, 23);
        btnGetOperationModeLockState.TabIndex = 0;
        btnGetOperationModeLockState.Text = "Get Operating mode lock state";
        btnGetOperationModeLockState.UseVisualStyleBackColor = true;
        btnGetOperationModeLockState.Click += btnGetOperationModeLockState_Click;
        // 
        // sep10
        // 
        sep10.Dock = DockStyle.Top;
        sep10.Location = new Point(5, 28);
        sep10.Name = "sep10";
        sep10.Size = new Size(238, 5);
        sep10.TabIndex = 1;
        // 
        // txtOperationModeLockState
        // 
        txtOperationModeLockState.Dock = DockStyle.Top;
        txtOperationModeLockState.Location = new Point(5, 33);
        txtOperationModeLockState.Name = "txtOperationModeLockState";
        txtOperationModeLockState.PlaceholderText = "lock state";
        txtOperationModeLockState.ReadOnly = true;
        txtOperationModeLockState.Size = new Size(238, 23);
        txtOperationModeLockState.TabIndex = 2;
        // 
        // pnlOperationModeLock
        // 
        pnlOperationModeLock.BorderStyle = BorderStyle.FixedSingle;
        pnlOperationModeLock.Controls.Add(btnUnlockOperationMode);
        pnlOperationModeLock.Controls.Add(sep13);
        pnlOperationModeLock.Controls.Add(btnLockOperationMode);
        pnlOperationModeLock.Controls.Add(sep12);
        pnlOperationModeLock.Controls.Add(chkLockOperationModePermanent);
        pnlOperationModeLock.Controls.Add(sep11);
        pnlOperationModeLock.Controls.Add(txtOperationModePin);
        pnlOperationModeLock.Location = new Point(3, 3);
        pnlOperationModeLock.Name = "pnlOperationModeLock";
        pnlOperationModeLock.Padding = new Padding(5);
        pnlOperationModeLock.Size = new Size(250, 119);
        pnlOperationModeLock.TabIndex = 3;
        // 
        // txtOperationModePin
        // 
        txtOperationModePin.Dock = DockStyle.Top;
        txtOperationModePin.Location = new Point(5, 5);
        txtOperationModePin.Name = "txtOperationModePin";
        txtOperationModePin.PlaceholderText = "pin (4 digits)";
        txtOperationModePin.Size = new Size(238, 23);
        txtOperationModePin.TabIndex = 0;
        txtOperationModePin.Text = "1234";
        // 
        // sep11
        // 
        sep11.Dock = DockStyle.Top;
        sep11.Location = new Point(5, 28);
        sep11.Name = "sep11";
        sep11.Size = new Size(238, 5);
        sep11.TabIndex = 1;
        // 
        // chkLockOperationModePermanent
        // 
        chkLockOperationModePermanent.Dock = DockStyle.Top;
        chkLockOperationModePermanent.Location = new Point(5, 33);
        chkLockOperationModePermanent.Name = "chkLockOperationModePermanent";
        chkLockOperationModePermanent.Size = new Size(238, 23);
        chkLockOperationModePermanent.TabIndex = 2;
        chkLockOperationModePermanent.Text = "Permanent";
        chkLockOperationModePermanent.UseVisualStyleBackColor = true;
        // 
        // sep12
        // 
        sep12.Dock = DockStyle.Top;
        sep12.Location = new Point(5, 56);
        sep12.Name = "sep12";
        sep12.Size = new Size(238, 5);
        sep12.TabIndex = 3;
        // 
        // btnLockOperationMode
        // 
        btnLockOperationMode.Dock = DockStyle.Top;
        btnLockOperationMode.Location = new Point(5, 61);
        btnLockOperationMode.Name = "btnLockOperationMode";
        btnLockOperationMode.Size = new Size(238, 23);
        btnLockOperationMode.TabIndex = 4;
        btnLockOperationMode.Text = "Lock Operating mode";
        btnLockOperationMode.UseVisualStyleBackColor = true;
        btnLockOperationMode.Click += btnLockOperationMode_Click;
        // 
        // sep13
        // 
        sep13.Dock = DockStyle.Top;
        sep13.Location = new Point(5, 84);
        sep13.Name = "sep13";
        sep13.Size = new Size(238, 5);
        sep13.TabIndex = 5;
        // 
        // btnUnlockOperationMode
        // 
        btnUnlockOperationMode.Dock = DockStyle.Top;
        btnUnlockOperationMode.Location = new Point(5, 89);
        btnUnlockOperationMode.Name = "btnUnlockOperationMode";
        btnUnlockOperationMode.Size = new Size(238, 23);
        btnUnlockOperationMode.TabIndex = 6;
        btnUnlockOperationMode.Text = "Unlock Operating mode";
        btnUnlockOperationMode.UseVisualStyleBackColor = true;
        btnUnlockOperationMode.Click += btnUnlockOperationMode_Click;
        // 
        // tabController
        // 
        tabController.Controls.Add(flowController);
        tabController.Location = new Point(4, 24);
        tabController.Name = "tabController";
        tabController.Padding = new Padding(3);
        tabController.Size = new Size(882, 463);
        tabController.TabIndex = 2;
        tabController.Text = "Controller";
        tabController.UseVisualStyleBackColor = true;
        // 
        // flowController
        // 
        flowController.AutoScroll = true;
        flowController.Controls.Add(pnlLanguage);
        flowController.Controls.Add(pnlRestart);
        flowController.Dock = DockStyle.Fill;
        flowController.FlowDirection = FlowDirection.TopDown;
        flowController.Location = new Point(3, 3);
        flowController.Name = "flowController";
        flowController.Size = new Size(876, 457);
        flowController.TabIndex = 0;
        // 
        // pnlLanguage
        // 
        pnlLanguage.BorderStyle = BorderStyle.FixedSingle;
        pnlLanguage.Controls.Add(btnSetLanguage);
        pnlLanguage.Controls.Add(sep14);
        pnlLanguage.Controls.Add(txtSetLanguageLanguageCode);
        pnlLanguage.Location = new Point(3, 3);
        pnlLanguage.Name = "pnlLanguage";
        pnlLanguage.Padding = new Padding(5);
        pnlLanguage.Size = new Size(250, 63);
        pnlLanguage.TabIndex = 0;
        // 
        // txtSetLanguageLanguageCode
        // 
        txtSetLanguageLanguageCode.Dock = DockStyle.Top;
        txtSetLanguageLanguageCode.Location = new Point(5, 5);
        txtSetLanguageLanguageCode.Name = "txtSetLanguageLanguageCode";
        txtSetLanguageLanguageCode.PlaceholderText = "languageCode";
        txtSetLanguageLanguageCode.Size = new Size(238, 23);
        txtSetLanguageLanguageCode.TabIndex = 0;
        txtSetLanguageLanguageCode.Text = "en";
        // 
        // sep14
        // 
        sep14.Dock = DockStyle.Top;
        sep14.Location = new Point(5, 28);
        sep14.Name = "sep14";
        sep14.Size = new Size(238, 5);
        sep14.TabIndex = 1;
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
        // pnlRestart
        // 
        pnlRestart.BorderStyle = BorderStyle.FixedSingle;
        pnlRestart.Controls.Add(btnRestart);
        pnlRestart.Controls.Add(sep16);
        pnlRestart.Controls.Add(chkRestartUseImplicitMastership);
        pnlRestart.Controls.Add(sep15);
        pnlRestart.Controls.Add(cboRestartMode);
        pnlRestart.Location = new Point(3, 3);
        pnlRestart.Name = "pnlRestart";
        pnlRestart.Padding = new Padding(5);
        pnlRestart.Size = new Size(250, 91);
        pnlRestart.TabIndex = 1;
        // 
        // cboRestartMode
        // 
        cboRestartMode.Dock = DockStyle.Top;
        cboRestartMode.Location = new Point(5, 5);
        cboRestartMode.DropDownStyle = ComboBoxStyle.DropDownList;
        cboRestartMode.FormattingEnabled = true;
        cboRestartMode.Name = "cboRestartMode";
        cboRestartMode.Size = new Size(238, 23);
        cboRestartMode.TabIndex = 0;
        // 
        // sep15
        // 
        sep15.Dock = DockStyle.Top;
        sep15.Location = new Point(5, 28);
        sep15.Name = "sep15";
        sep15.Size = new Size(238, 5);
        sep15.TabIndex = 1;
        // 
        // chkRestartUseImplicitMastership
        // 
        chkRestartUseImplicitMastership.Dock = DockStyle.Top;
        chkRestartUseImplicitMastership.Location = new Point(5, 33);
        chkRestartUseImplicitMastership.Checked = true;
        chkRestartUseImplicitMastership.CheckState = CheckState.Checked;
        chkRestartUseImplicitMastership.Name = "chkRestartUseImplicitMastership";
        chkRestartUseImplicitMastership.Size = new Size(238, 23);
        chkRestartUseImplicitMastership.TabIndex = 2;
        chkRestartUseImplicitMastership.Text = "Use implicit mastership";
        chkRestartUseImplicitMastership.UseVisualStyleBackColor = true;
        // 
        // sep16
        // 
        sep16.Dock = DockStyle.Top;
        sep16.Location = new Point(5, 56);
        sep16.Name = "sep16";
        sep16.Size = new Size(238, 5);
        sep16.TabIndex = 3;
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
        // RwsPanelControl
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tabControl);
        Margin = new Padding(4, 3, 4, 3);
        Name = "RwsPanelControl";
        Size = new Size(890, 491);
        tabControl.ResumeLayout(false);
        tabState.ResumeLayout(false);
        flowState.ResumeLayout(false);
        tabOpMode.ResumeLayout(false);
        flowOpMode.ResumeLayout(false);
        tabController.ResumeLayout(false);
        flowController.ResumeLayout(false);
        pnlControllerState.ResumeLayout(false);
        pnlControllerState.PerformLayout();
        pnlSpeedRatio.ResumeLayout(false);
        pnlSpeedRatio.PerformLayout();
        pnlCollisionDetectionState.ResumeLayout(false);
        pnlCollisionDetectionState.PerformLayout();
        pnlOperationMode.ResumeLayout(false);
        pnlOperationMode.PerformLayout();
        pnlAcknowledgeOperationMode.ResumeLayout(false);
        pnlAcknowledgeOperationMode.PerformLayout();
        pnlOperationModeLockState.ResumeLayout(false);
        pnlOperationModeLockState.PerformLayout();
        pnlOperationModeLock.ResumeLayout(false);
        pnlOperationModeLock.PerformLayout();
        pnlLanguage.ResumeLayout(false);
        pnlLanguage.PerformLayout();
        pnlRestart.ResumeLayout(false);
        pnlRestart.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numSpeedRatio).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl;

    private TabPage tabState;
    private FlowLayoutPanel flowState;

    private Panel pnlControllerState;
    private Button btnGetControllerState;
    private Panel sep1;
    private TextBox txtControllerState;
    private Panel sep2;
    private ComboBox cboSetControllerStateState;
    private Panel sep3;
    private Button btnSetControllerState;

    private Panel pnlSpeedRatio;
    private Button btnGetSpeedRatio;
    private Panel sep4;
    private NumericUpDown numSpeedRatio;
    private Panel sep5;
    private CheckBox chkSetSpeedRatioUseImplicitMastership;
    private Panel sep6;
    private Button btnSetSpeedRatio;

    private Panel pnlCollisionDetectionState;
    private Button btnGetCollisionDetectionState;
    private Panel sep7;
    private TextBox txtCollisionDetectionState;

    private TabPage tabOpMode;
    private FlowLayoutPanel flowOpMode;

    private Panel pnlOperationMode;
    private Button btnGetOperationMode;
    private Panel sep8;
    private TextBox txtOperationMode;

    private Panel pnlAcknowledgeOperationMode;
    private ComboBox cboAcknowledgeOperationModeAcknowledgement;
    private Panel sep9;
    private Button btnAcknowledgeOperationMode;

    private Panel pnlOperationModeLockState;
    private Button btnGetOperationModeLockState;
    private Panel sep10;
    private TextBox txtOperationModeLockState;

    private Panel pnlOperationModeLock;
    private TextBox txtOperationModePin;
    private Panel sep11;
    private CheckBox chkLockOperationModePermanent;
    private Panel sep12;
    private Button btnLockOperationMode;
    private Panel sep13;
    private Button btnUnlockOperationMode;

    private TabPage tabController;
    private FlowLayoutPanel flowController;

    private Panel pnlLanguage;
    private TextBox txtSetLanguageLanguageCode;
    private Panel sep14;
    private Button btnSetLanguage;

    private Panel pnlRestart;
    private ComboBox cboRestartMode;
    private Panel sep15;
    private CheckBox chkRestartUseImplicitMastership;
    private Panel sep16;
    private Button btnRestart;
}
