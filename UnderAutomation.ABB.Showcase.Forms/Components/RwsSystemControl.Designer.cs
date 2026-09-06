
partial class RwsSystemControl
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
        tabSystem = new TabPage();
        flowSystem = new FlowLayoutPanel();
        pnlInfo = new Panel();
        btnGetInfo = new Button();
        sep1 = new Panel();
        gridInfo = new PropertyGrid();
        pnlOptions = new Panel();
        btnGetOptions = new Button();
        sep2 = new Panel();
        gridOptions = new PropertyGrid();
        pnlRobotTypes = new Panel();
        btnGetRobotTypes = new Button();
        sep3 = new Panel();
        gridRobotTypes = new PropertyGrid();
        pnlLicense = new Panel();
        btnGetLicense = new Button();
        sep4 = new Panel();
        txtGetLicenseResult = new TextBox();
        tabProducts = new TabPage();
        flowProducts = new FlowLayoutPanel();
        pnlProducts = new Panel();
        txtGetProductsName = new TextBox();
        sep5 = new Panel();
        btnGetProducts = new Button();
        sep6 = new Panel();
        gridProducts = new PropertyGrid();
        tabEnergy = new TabPage();
        flowEnergy = new FlowLayoutPanel();
        pnlEnergy = new Panel();
        btnGetEnergy = new Button();
        sep7 = new Panel();
        gridEnergy = new PropertyGrid();
        pnlEnergyChangeCount = new Panel();
        btnGetEnergyChangeCount = new Button();
        sep8 = new Panel();
        txtGetEnergyChangeCountResult = new TextBox();
        pnlResetAccumulatedEnergy = new Panel();
        btnResetAccumulatedEnergy = new Button();
        sep9 = new Panel();
        txtResetAccumulatedEnergyResult = new TextBox();
        tabControl.SuspendLayout();
        tabSystem.SuspendLayout();
        flowSystem.SuspendLayout();
        tabProducts.SuspendLayout();
        flowProducts.SuspendLayout();
        tabEnergy.SuspendLayout();
        flowEnergy.SuspendLayout();
        pnlInfo.SuspendLayout();
        pnlOptions.SuspendLayout();
        pnlRobotTypes.SuspendLayout();
        pnlLicense.SuspendLayout();
        pnlProducts.SuspendLayout();
        pnlEnergy.SuspendLayout();
        pnlEnergyChangeCount.SuspendLayout();
        pnlResetAccumulatedEnergy.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabSystem);
        tabControl.Controls.Add(tabProducts);
        tabControl.Controls.Add(tabEnergy);
        tabControl.Dock = DockStyle.Fill;
        tabControl.Location = new Point(0, 0);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(890, 491);
        tabControl.TabIndex = 0;
        // 
        // tabSystem
        // 
        tabSystem.Controls.Add(flowSystem);
        tabSystem.Location = new Point(4, 24);
        tabSystem.Name = "tabSystem";
        tabSystem.Padding = new Padding(3);
        tabSystem.Size = new Size(882, 463);
        tabSystem.TabIndex = 0;
        tabSystem.Text = "System";
        tabSystem.UseVisualStyleBackColor = true;
        // 
        // flowSystem
        // 
        flowSystem.AutoScroll = true;
        flowSystem.Controls.Add(pnlInfo);
        flowSystem.Controls.Add(pnlOptions);
        flowSystem.Controls.Add(pnlRobotTypes);
        flowSystem.Controls.Add(pnlLicense);
        flowSystem.Dock = DockStyle.Fill;
        flowSystem.FlowDirection = FlowDirection.TopDown;
        flowSystem.Location = new Point(3, 3);
        flowSystem.Name = "flowSystem";
        flowSystem.Size = new Size(876, 457);
        flowSystem.TabIndex = 0;
        // 
        // pnlInfo
        // 
        pnlInfo.BorderStyle = BorderStyle.FixedSingle;
        pnlInfo.Controls.Add(gridInfo);
        pnlInfo.Controls.Add(sep1);
        pnlInfo.Controls.Add(btnGetInfo);
        pnlInfo.Location = new Point(3, 3);
        pnlInfo.Name = "pnlInfo";
        pnlInfo.Padding = new Padding(5);
        pnlInfo.Size = new Size(250, 445);
        pnlInfo.TabIndex = 0;
        // 
        // btnGetInfo
        // 
        btnGetInfo.Dock = DockStyle.Top;
        btnGetInfo.Location = new Point(5, 5);
        btnGetInfo.Name = "btnGetInfo";
        btnGetInfo.Size = new Size(238, 23);
        btnGetInfo.TabIndex = 0;
        btnGetInfo.Text = "Get System info";
        btnGetInfo.UseVisualStyleBackColor = true;
        btnGetInfo.Click += btnGetInfo_Click;
        // 
        // sep1
        // 
        sep1.Dock = DockStyle.Top;
        sep1.Location = new Point(5, 28);
        sep1.Name = "sep1";
        sep1.Size = new Size(238, 5);
        sep1.TabIndex = 1;
        // 
        // gridInfo
        // 
        gridInfo.Dock = DockStyle.Top;
        gridInfo.Location = new Point(5, 33);
        gridInfo.HelpVisible = false;
        gridInfo.Name = "gridInfo";
        gridInfo.PropertySort = PropertySort.NoSort;
        gridInfo.Size = new Size(238, 405);
        gridInfo.TabIndex = 2;
        gridInfo.ToolbarVisible = false;
        // 
        // pnlOptions
        // 
        pnlOptions.BorderStyle = BorderStyle.FixedSingle;
        pnlOptions.Controls.Add(gridOptions);
        pnlOptions.Controls.Add(sep2);
        pnlOptions.Controls.Add(btnGetOptions);
        pnlOptions.Location = new Point(3, 3);
        pnlOptions.Name = "pnlOptions";
        pnlOptions.Padding = new Padding(5);
        pnlOptions.Size = new Size(250, 445);
        pnlOptions.TabIndex = 1;
        // 
        // btnGetOptions
        // 
        btnGetOptions.Dock = DockStyle.Top;
        btnGetOptions.Location = new Point(5, 5);
        btnGetOptions.Name = "btnGetOptions";
        btnGetOptions.Size = new Size(238, 23);
        btnGetOptions.TabIndex = 0;
        btnGetOptions.Text = "Get Options";
        btnGetOptions.UseVisualStyleBackColor = true;
        btnGetOptions.Click += btnGetOptions_Click;
        // 
        // sep2
        // 
        sep2.Dock = DockStyle.Top;
        sep2.Location = new Point(5, 28);
        sep2.Name = "sep2";
        sep2.Size = new Size(238, 5);
        sep2.TabIndex = 1;
        // 
        // gridOptions
        // 
        gridOptions.Dock = DockStyle.Top;
        gridOptions.Location = new Point(5, 33);
        gridOptions.HelpVisible = false;
        gridOptions.Name = "gridOptions";
        gridOptions.PropertySort = PropertySort.NoSort;
        gridOptions.Size = new Size(238, 405);
        gridOptions.TabIndex = 2;
        gridOptions.ToolbarVisible = false;
        // 
        // pnlRobotTypes
        // 
        pnlRobotTypes.BorderStyle = BorderStyle.FixedSingle;
        pnlRobotTypes.Controls.Add(gridRobotTypes);
        pnlRobotTypes.Controls.Add(sep3);
        pnlRobotTypes.Controls.Add(btnGetRobotTypes);
        pnlRobotTypes.Location = new Point(3, 3);
        pnlRobotTypes.Name = "pnlRobotTypes";
        pnlRobotTypes.Padding = new Padding(5);
        pnlRobotTypes.Size = new Size(250, 122);
        pnlRobotTypes.TabIndex = 2;
        // 
        // btnGetRobotTypes
        // 
        btnGetRobotTypes.Dock = DockStyle.Top;
        btnGetRobotTypes.Location = new Point(5, 5);
        btnGetRobotTypes.Name = "btnGetRobotTypes";
        btnGetRobotTypes.Size = new Size(238, 23);
        btnGetRobotTypes.TabIndex = 0;
        btnGetRobotTypes.Text = "Get Robot types";
        btnGetRobotTypes.UseVisualStyleBackColor = true;
        btnGetRobotTypes.Click += btnGetRobotTypes_Click;
        // 
        // sep3
        // 
        sep3.Dock = DockStyle.Top;
        sep3.Location = new Point(5, 28);
        sep3.Name = "sep3";
        sep3.Size = new Size(238, 5);
        sep3.TabIndex = 1;
        // 
        // gridRobotTypes
        // 
        gridRobotTypes.Dock = DockStyle.Top;
        gridRobotTypes.Location = new Point(5, 33);
        gridRobotTypes.HelpVisible = false;
        gridRobotTypes.Name = "gridRobotTypes";
        gridRobotTypes.PropertySort = PropertySort.NoSort;
        gridRobotTypes.Size = new Size(238, 82);
        gridRobotTypes.TabIndex = 2;
        gridRobotTypes.ToolbarVisible = false;
        // 
        // pnlLicense
        // 
        pnlLicense.BorderStyle = BorderStyle.FixedSingle;
        pnlLicense.Controls.Add(txtGetLicenseResult);
        pnlLicense.Controls.Add(sep4);
        pnlLicense.Controls.Add(btnGetLicense);
        pnlLicense.Location = new Point(3, 3);
        pnlLicense.Name = "pnlLicense";
        pnlLicense.Padding = new Padding(5);
        pnlLicense.Size = new Size(250, 63);
        pnlLicense.TabIndex = 3;
        // 
        // btnGetLicense
        // 
        btnGetLicense.Dock = DockStyle.Top;
        btnGetLicense.Location = new Point(5, 5);
        btnGetLicense.Name = "btnGetLicense";
        btnGetLicense.Size = new Size(238, 23);
        btnGetLicense.TabIndex = 0;
        btnGetLicense.Text = "Get License";
        btnGetLicense.UseVisualStyleBackColor = true;
        btnGetLicense.Click += btnGetLicense_Click;
        // 
        // sep4
        // 
        sep4.Dock = DockStyle.Top;
        sep4.Location = new Point(5, 28);
        sep4.Name = "sep4";
        sep4.Size = new Size(238, 5);
        sep4.TabIndex = 1;
        // 
        // txtGetLicenseResult
        // 
        txtGetLicenseResult.Dock = DockStyle.Top;
        txtGetLicenseResult.Location = new Point(5, 33);
        txtGetLicenseResult.Name = "txtGetLicenseResult";
        txtGetLicenseResult.PlaceholderText = "license";
        txtGetLicenseResult.ReadOnly = true;
        txtGetLicenseResult.Size = new Size(238, 23);
        txtGetLicenseResult.TabIndex = 2;
        // 
        // tabProducts
        // 
        tabProducts.Controls.Add(flowProducts);
        tabProducts.Location = new Point(4, 24);
        tabProducts.Name = "tabProducts";
        tabProducts.Padding = new Padding(3);
        tabProducts.Size = new Size(882, 463);
        tabProducts.TabIndex = 1;
        tabProducts.Text = "Products";
        tabProducts.UseVisualStyleBackColor = true;
        // 
        // flowProducts
        // 
        flowProducts.AutoScroll = true;
        flowProducts.Controls.Add(pnlProducts);
        flowProducts.Dock = DockStyle.Fill;
        flowProducts.FlowDirection = FlowDirection.TopDown;
        flowProducts.Location = new Point(3, 3);
        flowProducts.Name = "flowProducts";
        flowProducts.Size = new Size(876, 457);
        flowProducts.TabIndex = 0;
        // 
        // pnlProducts
        // 
        pnlProducts.BorderStyle = BorderStyle.FixedSingle;
        pnlProducts.Controls.Add(gridProducts);
        pnlProducts.Controls.Add(sep6);
        pnlProducts.Controls.Add(btnGetProducts);
        pnlProducts.Controls.Add(sep5);
        pnlProducts.Controls.Add(txtGetProductsName);
        pnlProducts.Location = new Point(3, 3);
        pnlProducts.Name = "pnlProducts";
        pnlProducts.Padding = new Padding(5);
        pnlProducts.Size = new Size(250, 435);
        pnlProducts.TabIndex = 0;
        // 
        // txtGetProductsName
        // 
        txtGetProductsName.Dock = DockStyle.Top;
        txtGetProductsName.Location = new Point(5, 5);
        txtGetProductsName.Name = "txtGetProductsName";
        txtGetProductsName.PlaceholderText = "product name (optional)";
        txtGetProductsName.Size = new Size(238, 23);
        txtGetProductsName.TabIndex = 0;
        // 
        // sep5
        // 
        sep5.Dock = DockStyle.Top;
        sep5.Location = new Point(5, 28);
        sep5.Name = "sep5";
        sep5.Size = new Size(238, 5);
        sep5.TabIndex = 1;
        // 
        // btnGetProducts
        // 
        btnGetProducts.Dock = DockStyle.Top;
        btnGetProducts.Location = new Point(5, 33);
        btnGetProducts.Name = "btnGetProducts";
        btnGetProducts.Size = new Size(238, 23);
        btnGetProducts.TabIndex = 2;
        btnGetProducts.Text = "Get Products";
        btnGetProducts.UseVisualStyleBackColor = true;
        btnGetProducts.Click += btnGetProducts_Click;
        // 
        // sep6
        // 
        sep6.Dock = DockStyle.Top;
        sep6.Location = new Point(5, 56);
        sep6.Name = "sep6";
        sep6.Size = new Size(238, 5);
        sep6.TabIndex = 3;
        // 
        // gridProducts
        // 
        gridProducts.Dock = DockStyle.Top;
        gridProducts.Location = new Point(5, 61);
        gridProducts.HelpVisible = false;
        gridProducts.Name = "gridProducts";
        gridProducts.PropertySort = PropertySort.NoSort;
        gridProducts.Size = new Size(238, 367);
        gridProducts.TabIndex = 4;
        gridProducts.ToolbarVisible = false;
        // 
        // tabEnergy
        // 
        tabEnergy.Controls.Add(flowEnergy);
        tabEnergy.Location = new Point(4, 24);
        tabEnergy.Name = "tabEnergy";
        tabEnergy.Padding = new Padding(3);
        tabEnergy.Size = new Size(882, 463);
        tabEnergy.TabIndex = 2;
        tabEnergy.Text = "Energy";
        tabEnergy.UseVisualStyleBackColor = true;
        // 
        // flowEnergy
        // 
        flowEnergy.AutoScroll = true;
        flowEnergy.Controls.Add(pnlEnergy);
        flowEnergy.Controls.Add(pnlEnergyChangeCount);
        flowEnergy.Controls.Add(pnlResetAccumulatedEnergy);
        flowEnergy.Dock = DockStyle.Fill;
        flowEnergy.FlowDirection = FlowDirection.TopDown;
        flowEnergy.Location = new Point(3, 3);
        flowEnergy.Name = "flowEnergy";
        flowEnergy.Size = new Size(876, 457);
        flowEnergy.TabIndex = 0;
        // 
        // pnlEnergy
        // 
        pnlEnergy.BorderStyle = BorderStyle.FixedSingle;
        pnlEnergy.Controls.Add(gridEnergy);
        pnlEnergy.Controls.Add(sep7);
        pnlEnergy.Controls.Add(btnGetEnergy);
        pnlEnergy.Location = new Point(3, 3);
        pnlEnergy.Name = "pnlEnergy";
        pnlEnergy.Padding = new Padding(5);
        pnlEnergy.Size = new Size(250, 445);
        pnlEnergy.TabIndex = 0;
        // 
        // btnGetEnergy
        // 
        btnGetEnergy.Dock = DockStyle.Top;
        btnGetEnergy.Location = new Point(5, 5);
        btnGetEnergy.Name = "btnGetEnergy";
        btnGetEnergy.Size = new Size(238, 23);
        btnGetEnergy.TabIndex = 0;
        btnGetEnergy.Text = "Get Energy";
        btnGetEnergy.UseVisualStyleBackColor = true;
        btnGetEnergy.Click += btnGetEnergy_Click;
        // 
        // sep7
        // 
        sep7.Dock = DockStyle.Top;
        sep7.Location = new Point(5, 28);
        sep7.Name = "sep7";
        sep7.Size = new Size(238, 5);
        sep7.TabIndex = 1;
        // 
        // gridEnergy
        // 
        gridEnergy.Dock = DockStyle.Top;
        gridEnergy.Location = new Point(5, 33);
        gridEnergy.HelpVisible = false;
        gridEnergy.Name = "gridEnergy";
        gridEnergy.PropertySort = PropertySort.NoSort;
        gridEnergy.Size = new Size(238, 405);
        gridEnergy.TabIndex = 2;
        gridEnergy.ToolbarVisible = false;
        // 
        // pnlEnergyChangeCount
        // 
        pnlEnergyChangeCount.BorderStyle = BorderStyle.FixedSingle;
        pnlEnergyChangeCount.Controls.Add(txtGetEnergyChangeCountResult);
        pnlEnergyChangeCount.Controls.Add(sep8);
        pnlEnergyChangeCount.Controls.Add(btnGetEnergyChangeCount);
        pnlEnergyChangeCount.Location = new Point(3, 3);
        pnlEnergyChangeCount.Name = "pnlEnergyChangeCount";
        pnlEnergyChangeCount.Padding = new Padding(5);
        pnlEnergyChangeCount.Size = new Size(250, 63);
        pnlEnergyChangeCount.TabIndex = 1;
        // 
        // btnGetEnergyChangeCount
        // 
        btnGetEnergyChangeCount.Dock = DockStyle.Top;
        btnGetEnergyChangeCount.Location = new Point(5, 5);
        btnGetEnergyChangeCount.Name = "btnGetEnergyChangeCount";
        btnGetEnergyChangeCount.Size = new Size(238, 23);
        btnGetEnergyChangeCount.TabIndex = 0;
        btnGetEnergyChangeCount.Text = "Get Energy change count";
        btnGetEnergyChangeCount.UseVisualStyleBackColor = true;
        btnGetEnergyChangeCount.Click += btnGetEnergyChangeCount_Click;
        // 
        // sep8
        // 
        sep8.Dock = DockStyle.Top;
        sep8.Location = new Point(5, 28);
        sep8.Name = "sep8";
        sep8.Size = new Size(238, 5);
        sep8.TabIndex = 1;
        // 
        // txtGetEnergyChangeCountResult
        // 
        txtGetEnergyChangeCountResult.Dock = DockStyle.Top;
        txtGetEnergyChangeCountResult.Location = new Point(5, 33);
        txtGetEnergyChangeCountResult.Name = "txtGetEnergyChangeCountResult";
        txtGetEnergyChangeCountResult.PlaceholderText = "change count";
        txtGetEnergyChangeCountResult.ReadOnly = true;
        txtGetEnergyChangeCountResult.Size = new Size(238, 23);
        txtGetEnergyChangeCountResult.TabIndex = 2;
        // 
        // pnlResetAccumulatedEnergy
        // 
        pnlResetAccumulatedEnergy.BorderStyle = BorderStyle.FixedSingle;
        pnlResetAccumulatedEnergy.Controls.Add(txtResetAccumulatedEnergyResult);
        pnlResetAccumulatedEnergy.Controls.Add(sep9);
        pnlResetAccumulatedEnergy.Controls.Add(btnResetAccumulatedEnergy);
        pnlResetAccumulatedEnergy.Location = new Point(3, 3);
        pnlResetAccumulatedEnergy.Name = "pnlResetAccumulatedEnergy";
        pnlResetAccumulatedEnergy.Padding = new Padding(5);
        pnlResetAccumulatedEnergy.Size = new Size(250, 63);
        pnlResetAccumulatedEnergy.TabIndex = 2;
        // 
        // btnResetAccumulatedEnergy
        // 
        btnResetAccumulatedEnergy.Dock = DockStyle.Top;
        btnResetAccumulatedEnergy.Location = new Point(5, 5);
        btnResetAccumulatedEnergy.Name = "btnResetAccumulatedEnergy";
        btnResetAccumulatedEnergy.Size = new Size(238, 23);
        btnResetAccumulatedEnergy.TabIndex = 0;
        btnResetAccumulatedEnergy.Text = "Reset Accumulated energy";
        btnResetAccumulatedEnergy.UseVisualStyleBackColor = true;
        btnResetAccumulatedEnergy.Click += btnResetAccumulatedEnergy_Click;
        // 
        // sep9
        // 
        sep9.Dock = DockStyle.Top;
        sep9.Location = new Point(5, 28);
        sep9.Name = "sep9";
        sep9.Size = new Size(238, 5);
        sep9.TabIndex = 1;
        // 
        // txtResetAccumulatedEnergyResult
        // 
        txtResetAccumulatedEnergyResult.Dock = DockStyle.Top;
        txtResetAccumulatedEnergyResult.Location = new Point(5, 33);
        txtResetAccumulatedEnergyResult.Name = "txtResetAccumulatedEnergyResult";
        txtResetAccumulatedEnergyResult.PlaceholderText = "result";
        txtResetAccumulatedEnergyResult.ReadOnly = true;
        txtResetAccumulatedEnergyResult.Size = new Size(238, 23);
        txtResetAccumulatedEnergyResult.TabIndex = 2;
        //
        // RwsSystemControl
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tabControl);
        Margin = new Padding(4, 3, 4, 3);
        Name = "RwsSystemControl";
        Size = new Size(890, 491);
        tabControl.ResumeLayout(false);
        tabSystem.ResumeLayout(false);
        flowSystem.ResumeLayout(false);
        tabProducts.ResumeLayout(false);
        flowProducts.ResumeLayout(false);
        tabEnergy.ResumeLayout(false);
        flowEnergy.ResumeLayout(false);
        pnlInfo.ResumeLayout(false);
        pnlOptions.ResumeLayout(false);
        pnlRobotTypes.ResumeLayout(false);
        pnlLicense.ResumeLayout(false);
        pnlLicense.PerformLayout();
        pnlProducts.ResumeLayout(false);
        pnlProducts.PerformLayout();
        pnlEnergy.ResumeLayout(false);
        pnlEnergyChangeCount.ResumeLayout(false);
        pnlEnergyChangeCount.PerformLayout();
        pnlResetAccumulatedEnergy.ResumeLayout(false);
        pnlResetAccumulatedEnergy.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl;

    private TabPage tabSystem;
    private FlowLayoutPanel flowSystem;

    private Panel pnlInfo;
    private Button btnGetInfo;
    private Panel sep1;
    private PropertyGrid gridInfo;

    private Panel pnlOptions;
    private Button btnGetOptions;
    private Panel sep2;
    private PropertyGrid gridOptions;

    private Panel pnlRobotTypes;
    private Button btnGetRobotTypes;
    private Panel sep3;
    private PropertyGrid gridRobotTypes;

    private Panel pnlLicense;
    private Button btnGetLicense;
    private Panel sep4;
    private TextBox txtGetLicenseResult;

    private TabPage tabProducts;
    private FlowLayoutPanel flowProducts;

    private Panel pnlProducts;
    private TextBox txtGetProductsName;
    private Panel sep5;
    private Button btnGetProducts;
    private Panel sep6;
    private PropertyGrid gridProducts;

    private TabPage tabEnergy;
    private FlowLayoutPanel flowEnergy;

    private Panel pnlEnergy;
    private Button btnGetEnergy;
    private Panel sep7;
    private PropertyGrid gridEnergy;

    private Panel pnlEnergyChangeCount;
    private Button btnGetEnergyChangeCount;
    private Panel sep8;
    private TextBox txtGetEnergyChangeCountResult;

    private Panel pnlResetAccumulatedEnergy;
    private Button btnResetAccumulatedEnergy;
    private Panel sep9;
    private TextBox txtResetAccumulatedEnergyResult;
}
