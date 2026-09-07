
partial class RwsMastershipControl
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
        tabMastership = new TabPage();
        flowMastership = new FlowLayoutPanel();
        pnlDomains = new Panel();
        btnGetDomains = new Button();
        sep1 = new Panel();
        gridGetDomains = new PropertyGrid();
        pnlAllDomains = new Panel();
        btnGetInfo = new Button();
        sep2 = new Panel();
        gridGetInfo = new PropertyGrid();
        sep3 = new Panel();
        btnRequest = new Button();
        sep4 = new Panel();
        btnRelease = new Button();
        pnlDomain = new Panel();
        cboDomain = new ComboBox();
        sep5 = new Panel();
        btnGetInfoDomain = new Button();
        sep6 = new Panel();
        gridGetInfoDomain = new PropertyGrid();
        sep7 = new Panel();
        btnRequestDomain = new Button();
        sep8 = new Panel();
        btnReleaseDomain = new Button();
        tabControl.SuspendLayout();
        tabMastership.SuspendLayout();
        flowMastership.SuspendLayout();
        pnlDomains.SuspendLayout();
        pnlAllDomains.SuspendLayout();
        pnlDomain.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabMastership);
        tabControl.Dock = DockStyle.Fill;
        tabControl.Location = new Point(0, 0);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(890, 491);
        tabControl.TabIndex = 0;
        // 
        // tabMastership
        // 
        tabMastership.Controls.Add(flowMastership);
        tabMastership.Location = new Point(4, 24);
        tabMastership.Name = "tabMastership";
        tabMastership.Padding = new Padding(3);
        tabMastership.Size = new Size(882, 463);
        tabMastership.TabIndex = 0;
        tabMastership.Text = "Mastership";
        tabMastership.UseVisualStyleBackColor = true;
        // 
        // flowMastership
        // 
        flowMastership.AutoScroll = true;
        flowMastership.Controls.Add(pnlDomains);
        flowMastership.Controls.Add(pnlAllDomains);
        flowMastership.Controls.Add(pnlDomain);
        flowMastership.Dock = DockStyle.Fill;
        flowMastership.FlowDirection = FlowDirection.TopDown;
        flowMastership.Location = new Point(3, 3);
        flowMastership.Name = "flowMastership";
        flowMastership.Size = new Size(876, 457);
        flowMastership.TabIndex = 0;
        // 
        // pnlDomains
        // 
        pnlDomains.BorderStyle = BorderStyle.FixedSingle;
        pnlDomains.Controls.Add(gridGetDomains);
        pnlDomains.Controls.Add(sep1);
        pnlDomains.Controls.Add(btnGetDomains);
        pnlDomains.Location = new Point(3, 3);
        pnlDomains.Name = "pnlDomains";
        pnlDomains.Padding = new Padding(5);
        pnlDomains.Size = new Size(250, 141);
        pnlDomains.TabIndex = 0;
        // 
        // btnGetDomains
        // 
        btnGetDomains.Dock = DockStyle.Top;
        btnGetDomains.Location = new Point(5, 5);
        btnGetDomains.Name = "btnGetDomains";
        btnGetDomains.Size = new Size(238, 23);
        btnGetDomains.TabIndex = 0;
        btnGetDomains.Text = "Get Domains";
        btnGetDomains.UseVisualStyleBackColor = true;
        btnGetDomains.Click += btnGetDomains_Click;
        // 
        // sep1
        // 
        sep1.Dock = DockStyle.Top;
        sep1.Location = new Point(5, 28);
        sep1.Name = "sep1";
        sep1.Size = new Size(238, 5);
        sep1.TabIndex = 1;
        // 
        // gridGetDomains
        // 
        gridGetDomains.Dock = DockStyle.Top;
        gridGetDomains.Location = new Point(5, 33);
        gridGetDomains.HelpVisible = false;
        gridGetDomains.Name = "gridGetDomains";
        gridGetDomains.PropertySort = PropertySort.NoSort;
        gridGetDomains.Size = new Size(238, 101);
        gridGetDomains.TabIndex = 2;
        gridGetDomains.ToolbarVisible = false;
        // 
        // pnlAllDomains
        // 
        pnlAllDomains.BorderStyle = BorderStyle.FixedSingle;
        pnlAllDomains.Controls.Add(btnRelease);
        pnlAllDomains.Controls.Add(sep4);
        pnlAllDomains.Controls.Add(btnRequest);
        pnlAllDomains.Controls.Add(sep3);
        pnlAllDomains.Controls.Add(gridGetInfo);
        pnlAllDomains.Controls.Add(sep2);
        pnlAllDomains.Controls.Add(btnGetInfo);
        pnlAllDomains.Location = new Point(3, 3);
        pnlAllDomains.Name = "pnlAllDomains";
        pnlAllDomains.Padding = new Padding(5);
        pnlAllDomains.Size = new Size(250, 444);
        pnlAllDomains.TabIndex = 1;
        // 
        // btnGetInfo
        // 
        btnGetInfo.Dock = DockStyle.Top;
        btnGetInfo.Location = new Point(5, 5);
        btnGetInfo.Name = "btnGetInfo";
        btnGetInfo.Size = new Size(238, 23);
        btnGetInfo.TabIndex = 0;
        btnGetInfo.Text = "Get Info of every domain";
        btnGetInfo.UseVisualStyleBackColor = true;
        btnGetInfo.Click += btnGetInfo_Click;
        // 
        // sep2
        // 
        sep2.Dock = DockStyle.Top;
        sep2.Location = new Point(5, 28);
        sep2.Name = "sep2";
        sep2.Size = new Size(238, 5);
        sep2.TabIndex = 1;
        // 
        // gridGetInfo
        // 
        gridGetInfo.Dock = DockStyle.Top;
        gridGetInfo.Location = new Point(5, 33);
        gridGetInfo.HelpVisible = false;
        gridGetInfo.Name = "gridGetInfo";
        gridGetInfo.PropertySort = PropertySort.NoSort;
        gridGetInfo.Size = new Size(238, 348);
        gridGetInfo.TabIndex = 2;
        gridGetInfo.ToolbarVisible = false;
        // 
        // sep3
        // 
        sep3.Dock = DockStyle.Top;
        sep3.Location = new Point(5, 381);
        sep3.Name = "sep3";
        sep3.Size = new Size(238, 5);
        sep3.TabIndex = 3;
        // 
        // btnRequest
        // 
        btnRequest.Dock = DockStyle.Top;
        btnRequest.Location = new Point(5, 386);
        btnRequest.Name = "btnRequest";
        btnRequest.Size = new Size(238, 23);
        btnRequest.TabIndex = 4;
        btnRequest.Text = "Request every domain";
        btnRequest.UseVisualStyleBackColor = true;
        btnRequest.Click += btnRequest_Click;
        // 
        // sep4
        // 
        sep4.Dock = DockStyle.Top;
        sep4.Location = new Point(5, 409);
        sep4.Name = "sep4";
        sep4.Size = new Size(238, 5);
        sep4.TabIndex = 5;
        // 
        // btnRelease
        // 
        btnRelease.Dock = DockStyle.Top;
        btnRelease.Location = new Point(5, 414);
        btnRelease.Name = "btnRelease";
        btnRelease.Size = new Size(238, 23);
        btnRelease.TabIndex = 6;
        btnRelease.Text = "Release every domain";
        btnRelease.UseVisualStyleBackColor = true;
        btnRelease.Click += btnRelease_Click;
        // 
        // pnlDomain
        // 
        pnlDomain.BorderStyle = BorderStyle.FixedSingle;
        pnlDomain.Controls.Add(btnReleaseDomain);
        pnlDomain.Controls.Add(sep8);
        pnlDomain.Controls.Add(btnRequestDomain);
        pnlDomain.Controls.Add(sep7);
        pnlDomain.Controls.Add(gridGetInfoDomain);
        pnlDomain.Controls.Add(sep6);
        pnlDomain.Controls.Add(btnGetInfoDomain);
        pnlDomain.Controls.Add(sep5);
        pnlDomain.Controls.Add(cboDomain);
        pnlDomain.Location = new Point(3, 3);
        pnlDomain.Name = "pnlDomain";
        pnlDomain.Padding = new Padding(5);
        pnlDomain.Size = new Size(250, 282);
        pnlDomain.TabIndex = 2;
        // 
        // cboDomain
        // 
        cboDomain.Dock = DockStyle.Top;
        cboDomain.Location = new Point(5, 5);
        cboDomain.DropDownStyle = ComboBoxStyle.DropDownList;
        cboDomain.FormattingEnabled = true;
        cboDomain.Name = "cboDomain";
        cboDomain.Size = new Size(238, 23);
        cboDomain.TabIndex = 0;
        // 
        // sep5
        // 
        sep5.Dock = DockStyle.Top;
        sep5.Location = new Point(5, 28);
        sep5.Name = "sep5";
        sep5.Size = new Size(238, 5);
        sep5.TabIndex = 1;
        // 
        // btnGetInfoDomain
        // 
        btnGetInfoDomain.Dock = DockStyle.Top;
        btnGetInfoDomain.Location = new Point(5, 33);
        btnGetInfoDomain.Name = "btnGetInfoDomain";
        btnGetInfoDomain.Size = new Size(238, 23);
        btnGetInfoDomain.TabIndex = 2;
        btnGetInfoDomain.Text = "Get Info of the domain";
        btnGetInfoDomain.UseVisualStyleBackColor = true;
        btnGetInfoDomain.Click += btnGetInfoDomain_Click;
        // 
        // sep6
        // 
        sep6.Dock = DockStyle.Top;
        sep6.Location = new Point(5, 56);
        sep6.Name = "sep6";
        sep6.Size = new Size(238, 5);
        sep6.TabIndex = 3;
        // 
        // gridGetInfoDomain
        // 
        gridGetInfoDomain.Dock = DockStyle.Top;
        gridGetInfoDomain.Location = new Point(5, 61);
        gridGetInfoDomain.HelpVisible = false;
        gridGetInfoDomain.Name = "gridGetInfoDomain";
        gridGetInfoDomain.PropertySort = PropertySort.NoSort;
        gridGetInfoDomain.Size = new Size(238, 158);
        gridGetInfoDomain.TabIndex = 4;
        gridGetInfoDomain.ToolbarVisible = false;
        // 
        // sep7
        // 
        sep7.Dock = DockStyle.Top;
        sep7.Location = new Point(5, 219);
        sep7.Name = "sep7";
        sep7.Size = new Size(238, 5);
        sep7.TabIndex = 5;
        // 
        // btnRequestDomain
        // 
        btnRequestDomain.Dock = DockStyle.Top;
        btnRequestDomain.Location = new Point(5, 224);
        btnRequestDomain.Name = "btnRequestDomain";
        btnRequestDomain.Size = new Size(238, 23);
        btnRequestDomain.TabIndex = 6;
        btnRequestDomain.Text = "Request the domain";
        btnRequestDomain.UseVisualStyleBackColor = true;
        btnRequestDomain.Click += btnRequestDomain_Click;
        // 
        // sep8
        // 
        sep8.Dock = DockStyle.Top;
        sep8.Location = new Point(5, 247);
        sep8.Name = "sep8";
        sep8.Size = new Size(238, 5);
        sep8.TabIndex = 7;
        // 
        // btnReleaseDomain
        // 
        btnReleaseDomain.Dock = DockStyle.Top;
        btnReleaseDomain.Location = new Point(5, 252);
        btnReleaseDomain.Name = "btnReleaseDomain";
        btnReleaseDomain.Size = new Size(238, 23);
        btnReleaseDomain.TabIndex = 8;
        btnReleaseDomain.Text = "Release the domain";
        btnReleaseDomain.UseVisualStyleBackColor = true;
        btnReleaseDomain.Click += btnReleaseDomain_Click;
        //
        // RwsMastershipControl
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tabControl);
        Margin = new Padding(4, 3, 4, 3);
        Name = "RwsMastershipControl";
        Size = new Size(890, 491);
        tabControl.ResumeLayout(false);
        tabMastership.ResumeLayout(false);
        flowMastership.ResumeLayout(false);
        pnlDomains.ResumeLayout(false);
        pnlAllDomains.ResumeLayout(false);
        pnlDomain.ResumeLayout(false);
        pnlDomain.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl;

    private TabPage tabMastership;
    private FlowLayoutPanel flowMastership;

    private Panel pnlDomains;
    private Button btnGetDomains;
    private Panel sep1;
    private PropertyGrid gridGetDomains;

    private Panel pnlAllDomains;
    private Button btnGetInfo;
    private Panel sep2;
    private PropertyGrid gridGetInfo;
    private Panel sep3;
    private Button btnRequest;
    private Panel sep4;
    private Button btnRelease;

    private Panel pnlDomain;
    private ComboBox cboDomain;
    private Panel sep5;
    private Button btnGetInfoDomain;
    private Panel sep6;
    private PropertyGrid gridGetInfoDomain;
    private Panel sep7;
    private Button btnRequestDomain;
    private Panel sep8;
    private Button btnReleaseDomain;
}
