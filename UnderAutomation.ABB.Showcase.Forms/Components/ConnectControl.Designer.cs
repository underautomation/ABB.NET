
partial class ConnectControl
{
    /// <summary> 
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
        tableLayoutPanel1 = new TableLayoutPanel();
        txtRws2User = new TextBox();
        chkRws2 = new CheckBox();
        txtRws2Password = new TextBox();
        lblRws2Password = new Label();
        udRws2Port = new NumericUpDown();
        lblRws2Port = new Label();
        chkRws2Https = new CheckBox();
        lblConnected = new Label();
        label1 = new Label();
        txtIP = new TextBox();
        panel1 = new Panel();
        btnConnect = new Button();
        btnDisconnect = new Button();
        lblLicense = new Label();
        lblRws2User = new Label();
        addressTooltip = new ToolTip(components);
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udRws2Port).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 205F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel1.Controls.Add(txtRws2User, 1, 3);
        tableLayoutPanel1.Controls.Add(chkRws2, 1, 2);
        tableLayoutPanel1.Controls.Add(txtRws2Password, 1, 4);
        tableLayoutPanel1.Controls.Add(lblRws2Password, 0, 4);
        tableLayoutPanel1.Controls.Add(udRws2Port, 1, 5);
        tableLayoutPanel1.Controls.Add(lblRws2Port, 0, 5);
        tableLayoutPanel1.Controls.Add(chkRws2Https, 1, 6);
        tableLayoutPanel1.Controls.Add(lblConnected, 1, 10);
        tableLayoutPanel1.Controls.Add(label1, 0, 0);
        tableLayoutPanel1.Controls.Add(txtIP, 1, 0);
        tableLayoutPanel1.Controls.Add(panel1, 1, 9);
        tableLayoutPanel1.Controls.Add(lblLicense, 2, 9);
        tableLayoutPanel1.Controls.Add(lblRws2User, 0, 3);
        tableLayoutPanel1.Location = new Point(21, 32);
        tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 12;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new Size(628, 585);
        tableLayoutPanel1.TabIndex = 10;
        // 
        // txtRws2User
        // 
        txtRws2User.Anchor = AnchorStyles.Left;
        txtRws2User.Location = new Point(208, 118);
        txtRws2User.Name = "txtRws2User";
        txtRws2User.Size = new Size(140, 23);
        txtRws2User.TabIndex = 2;
        txtRws2User.Text = "Default User";
        // 
        // chkRws2
        // 
        chkRws2.Anchor = AnchorStyles.Left;
        chkRws2.AutoSize = true;
        chkRws2.Checked = true;
        chkRws2.CheckState = CheckState.Checked;
        chkRws2.Location = new Point(208, 91);
        chkRws2.Name = "chkRws2";
        chkRws2.Size = new Size(94, 19);
        chkRws2.TabIndex = 0;
        chkRws2.Text = "Enable RWS2";
        chkRws2.UseVisualStyleBackColor = true;
        // 
        // txtRws2Password
        // 
        txtRws2Password.Anchor = AnchorStyles.Left;
        txtRws2Password.Location = new Point(208, 147);
        txtRws2Password.Name = "txtRws2Password";
        txtRws2Password.Size = new Size(140, 23);
        txtRws2Password.TabIndex = 4;
        txtRws2Password.Text = "robotics";
        txtRws2Password.UseSystemPasswordChar = true;
        // 
        // lblRws2Password
        // 
        lblRws2Password.Anchor = AnchorStyles.Right;
        lblRws2Password.AutoSize = true;
        lblRws2Password.Location = new Point(142, 151);
        lblRws2Password.Name = "lblRws2Password";
        lblRws2Password.Size = new Size(60, 15);
        lblRws2Password.TabIndex = 3;
        lblRws2Password.Text = "Password:";
        // 
        // udRws2Port
        // 
        udRws2Port.Anchor = AnchorStyles.Left;
        udRws2Port.Location = new Point(208, 176);
        udRws2Port.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        udRws2Port.Name = "udRws2Port";
        udRws2Port.Size = new Size(80, 23);
        udRws2Port.TabIndex = 6;
        udRws2Port.Value = new decimal(new int[] { 443, 0, 0, 0 });
        // 
        // lblRws2Port
        // 
        lblRws2Port.Anchor = AnchorStyles.Right;
        lblRws2Port.AutoSize = true;
        lblRws2Port.Location = new Point(170, 180);
        lblRws2Port.Name = "lblRws2Port";
        lblRws2Port.Size = new Size(32, 15);
        lblRws2Port.TabIndex = 5;
        lblRws2Port.Text = "Port:";
        // 
        // chkRws2Https
        // 
        chkRws2Https.Anchor = AnchorStyles.Left;
        chkRws2Https.AutoSize = true;
        chkRws2Https.Checked = true;
        chkRws2Https.CheckState = CheckState.Checked;
        chkRws2Https.Location = new Point(208, 207);
        chkRws2Https.Name = "chkRws2Https";
        chkRws2Https.Size = new Size(84, 19);
        chkRws2Https.TabIndex = 7;
        chkRws2Https.Text = "Use HTTPS";
        chkRws2Https.UseVisualStyleBackColor = true;
        // 
        // lblConnected
        // 
        lblConnected.Dock = DockStyle.Fill;
        lblConnected.Location = new Point(209, 317);
        lblConnected.Margin = new Padding(4, 0, 4, 0);
        lblConnected.Name = "lblConnected";
        lblConnected.Size = new Size(242, 29);
        lblConnected.TabIndex = 19;
        lblConnected.Text = "______";
        lblConnected.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Cursor = Cursors.Help;
        label1.Location = new Point(16, 12);
        label1.Margin = new Padding(0);
        label1.Name = "label1";
        label1.Size = new Size(189, 45);
        label1.TabIndex = 0;
        label1.Text = "IP address\r\nor\r\nPath to RoboGuide robot directory";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        addressTooltip.SetToolTip(label1, "192.168.0.1\r\nC:\\ABB\\MyCell\\Myrobot\r\n\\\\my-dev-machine\\MyCell\\MyRobot");
        // 
        // txtIP
        // 
        txtIP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        tableLayoutPanel1.SetColumnSpan(txtIP, 2);
        txtIP.Cursor = Cursors.Help;
        txtIP.Location = new Point(209, 23);
        txtIP.Margin = new Padding(4, 3, 4, 3);
        txtIP.Name = "txtIP";
        txtIP.Size = new Size(415, 23);
        txtIP.TabIndex = 1;
        txtIP.Text = "192.168.0.1";
        addressTooltip.SetToolTip(txtIP, "192.168.0.1\r\nC:\\ABB\\MyCell\\MyRobot\r\n\\\\my-dev-machine\\MyCell\\MyRobot\r\n");
        // 
        // panel1
        // 
        panel1.Controls.Add(btnConnect);
        panel1.Controls.Add(btnDisconnect);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(209, 280);
        panel1.Margin = new Padding(4, 3, 4, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(242, 34);
        panel1.TabIndex = 12;
        // 
        // btnConnect
        // 
        btnConnect.Dock = DockStyle.Left;
        btnConnect.Location = new Point(0, 0);
        btnConnect.Margin = new Padding(4, 3, 4, 3);
        btnConnect.Name = "btnConnect";
        btnConnect.Size = new Size(112, 34);
        btnConnect.TabIndex = 17;
        btnConnect.Text = "Connect";
        btnConnect.UseVisualStyleBackColor = true;
        btnConnect.Click += btnConnect_Click;
        // 
        // btnDisconnect
        // 
        btnDisconnect.Dock = DockStyle.Right;
        btnDisconnect.Location = new Point(135, 0);
        btnDisconnect.Margin = new Padding(4, 3, 4, 3);
        btnDisconnect.Name = "btnDisconnect";
        btnDisconnect.Size = new Size(107, 34);
        btnDisconnect.TabIndex = 18;
        btnDisconnect.Text = "Disconnect";
        btnDisconnect.UseVisualStyleBackColor = true;
        btnDisconnect.Click += btnDisconnect_Click;
        // 
        // lblLicense
        // 
        lblLicense.Anchor = AnchorStyles.Left;
        lblLicense.AutoSize = true;
        lblLicense.Location = new Point(455, 289);
        lblLicense.Margin = new Padding(0);
        lblLicense.Name = "lblLicense";
        lblLicense.Size = new Size(13, 15);
        lblLicense.TabIndex = 25;
        lblLicense.Text = "..";
        // 
        // lblRws2User
        // 
        lblRws2User.Anchor = AnchorStyles.Right;
        lblRws2User.AutoSize = true;
        lblRws2User.Location = new Point(139, 122);
        lblRws2User.Name = "lblRws2User";
        lblRws2User.Size = new Size(63, 15);
        lblRws2User.TabIndex = 1;
        lblRws2User.Text = "Username:";
        // 
        // addressTooltip
        // 
        addressTooltip.AutomaticDelay = 0;
        addressTooltip.ToolTipIcon = ToolTipIcon.Info;
        addressTooltip.ToolTipTitle = "Examples :";
        addressTooltip.UseAnimation = false;
        addressTooltip.UseFading = false;
        // 
        // ConnectControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tableLayoutPanel1);
        Margin = new Padding(4, 3, 4, 3);
        Name = "ConnectControl";
        Size = new Size(1091, 831);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)udRws2Port).EndInit();
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label lblConnected;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtIP;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ToolTip addressTooltip;
    private Label lblLicense;
    private CheckBox chkRws2;
    private Label lblRws2User;
    private TextBox txtRws2User;
    private Label lblRws2Password;
    private TextBox txtRws2Password;
    private Label lblRws2Port;
    private NumericUpDown udRws2Port;
    private CheckBox chkRws2Https;
    private Button btnConnect;
    private Button btnDisconnect;
}
