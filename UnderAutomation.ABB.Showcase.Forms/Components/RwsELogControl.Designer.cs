
partial class RwsELogControl
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
        tabDomains = new TabPage();
        flowDomains = new FlowLayoutPanel();
        pnlDomains = new Panel();
        txtGetDomainsLanguage = new TextBox();
        sep1 = new Panel();
        btnGetDomains = new Button();
        sep2 = new Panel();
        gridDomains = new PropertyGrid();
        pnlDomain = new Panel();
        numGetDomainDomain = new NumericUpDown();
        sep3 = new Panel();
        btnGetDomain = new Button();
        sep4 = new Panel();
        gridDomain = new PropertyGrid();
        tabMessages = new TabPage();
        flowMessages = new FlowLayoutPanel();
        pnlMessages = new Panel();
        numGetMessagesDomain = new NumericUpDown();
        sep5 = new Panel();
        cboGetMessagesOrder = new ComboBox();
        sep6 = new Panel();
        txtGetMessagesLanguage = new TextBox();
        sep7 = new Panel();
        numGetMessagesMaxCount = new NumericUpDown();
        sep8 = new Panel();
        btnGetMessages = new Button();
        sep9 = new Panel();
        gridMessages = new PropertyGrid();
        pnlMessageTitles = new Panel();
        numGetMessageTitlesDomain = new NumericUpDown();
        sep10 = new Panel();
        txtGetMessageTitlesLanguage = new TextBox();
        sep11 = new Panel();
        cboGetMessageTitlesOrder = new ComboBox();
        sep12 = new Panel();
        numGetMessageTitlesMaxCount = new NumericUpDown();
        sep13 = new Panel();
        btnGetMessageTitles = new Button();
        sep14 = new Panel();
        gridMessageTitles = new PropertyGrid();
        tabSingleMessage = new TabPage();
        flowSingleMessage = new FlowLayoutPanel();
        pnlMessage = new Panel();
        numGetMessageDomain = new NumericUpDown();
        sep15 = new Panel();
        numGetMessageSequenceNumber = new NumericUpDown();
        sep16 = new Panel();
        txtGetMessageLanguage = new TextBox();
        sep17 = new Panel();
        btnGetMessage = new Button();
        sep18 = new Panel();
        gridMessage = new PropertyGrid();
        pnlMessageBySequenceNumber = new Panel();
        numGetMessageBySequenceNumberSequenceNumber = new NumericUpDown();
        sep19 = new Panel();
        txtGetMessageBySequenceNumberLanguage = new TextBox();
        sep20 = new Panel();
        btnGetMessageBySequenceNumber = new Button();
        sep21 = new Panel();
        gridMessageBySequenceNumber = new PropertyGrid();
        tabMaintenance = new TabPage();
        flowMaintenance = new FlowLayoutPanel();
        pnlSaveDump = new Panel();
        txtSaveInSystemDumpFormatPath = new TextBox();
        sep22 = new Panel();
        btnSaveInSystemDumpFormat = new Button();
        sep23 = new Panel();
        txtSaveInSystemDumpFormatResult = new TextBox();
        pnlClearMessages = new Panel();
        numClearMessagesDomain = new NumericUpDown();
        sep24 = new Panel();
        btnClearMessages = new Button();
        pnlClearAllMessages = new Panel();
        btnClearAllMessages = new Button();
        tabControl.SuspendLayout();
        tabDomains.SuspendLayout();
        flowDomains.SuspendLayout();
        tabMessages.SuspendLayout();
        flowMessages.SuspendLayout();
        tabSingleMessage.SuspendLayout();
        flowSingleMessage.SuspendLayout();
        tabMaintenance.SuspendLayout();
        flowMaintenance.SuspendLayout();
        pnlDomains.SuspendLayout();
        pnlDomain.SuspendLayout();
        pnlMessages.SuspendLayout();
        pnlMessageTitles.SuspendLayout();
        pnlMessage.SuspendLayout();
        pnlMessageBySequenceNumber.SuspendLayout();
        pnlSaveDump.SuspendLayout();
        pnlClearMessages.SuspendLayout();
        pnlClearAllMessages.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numGetDomainDomain).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numGetMessagesDomain).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numGetMessagesMaxCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numGetMessageTitlesDomain).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numGetMessageTitlesMaxCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numGetMessageDomain).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numGetMessageSequenceNumber).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numGetMessageBySequenceNumberSequenceNumber).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numClearMessagesDomain).BeginInit();
        SuspendLayout();
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabDomains);
        tabControl.Controls.Add(tabMessages);
        tabControl.Controls.Add(tabSingleMessage);
        tabControl.Controls.Add(tabMaintenance);
        tabControl.Dock = DockStyle.Fill;
        tabControl.Location = new Point(0, 0);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(890, 491);
        tabControl.TabIndex = 0;
        // 
        // tabDomains
        // 
        tabDomains.Controls.Add(flowDomains);
        tabDomains.Location = new Point(4, 24);
        tabDomains.Name = "tabDomains";
        tabDomains.Padding = new Padding(3);
        tabDomains.Size = new Size(882, 463);
        tabDomains.TabIndex = 0;
        tabDomains.Text = "Domains";
        tabDomains.UseVisualStyleBackColor = true;
        // 
        // flowDomains
        // 
        flowDomains.AutoScroll = true;
        flowDomains.Controls.Add(pnlDomains);
        flowDomains.Controls.Add(pnlDomain);
        flowDomains.Dock = DockStyle.Fill;
        flowDomains.FlowDirection = FlowDirection.TopDown;
        flowDomains.Location = new Point(3, 3);
        flowDomains.Name = "flowDomains";
        flowDomains.Size = new Size(876, 457);
        flowDomains.TabIndex = 0;
        // 
        // pnlDomains
        // 
        pnlDomains.BorderStyle = BorderStyle.FixedSingle;
        pnlDomains.Controls.Add(gridDomains);
        pnlDomains.Controls.Add(sep2);
        pnlDomains.Controls.Add(btnGetDomains);
        pnlDomains.Controls.Add(sep1);
        pnlDomains.Controls.Add(txtGetDomainsLanguage);
        pnlDomains.Location = new Point(3, 3);
        pnlDomains.Name = "pnlDomains";
        pnlDomains.Padding = new Padding(5);
        pnlDomains.Size = new Size(250, 416);
        pnlDomains.TabIndex = 0;
        // 
        // txtGetDomainsLanguage
        // 
        txtGetDomainsLanguage.Dock = DockStyle.Top;
        txtGetDomainsLanguage.Location = new Point(5, 5);
        txtGetDomainsLanguage.Name = "txtGetDomainsLanguage";
        txtGetDomainsLanguage.PlaceholderText = "language (optional)";
        txtGetDomainsLanguage.Size = new Size(238, 23);
        txtGetDomainsLanguage.TabIndex = 0;
        txtGetDomainsLanguage.Text = "en";
        // 
        // sep1
        // 
        sep1.Dock = DockStyle.Top;
        sep1.Location = new Point(5, 28);
        sep1.Name = "sep1";
        sep1.Size = new Size(238, 5);
        sep1.TabIndex = 1;
        // 
        // btnGetDomains
        // 
        btnGetDomains.Dock = DockStyle.Top;
        btnGetDomains.Location = new Point(5, 33);
        btnGetDomains.Name = "btnGetDomains";
        btnGetDomains.Size = new Size(238, 23);
        btnGetDomains.TabIndex = 2;
        btnGetDomains.Text = "Get Domains";
        btnGetDomains.UseVisualStyleBackColor = true;
        btnGetDomains.Click += btnGetDomains_Click;
        // 
        // sep2
        // 
        sep2.Dock = DockStyle.Top;
        sep2.Location = new Point(5, 56);
        sep2.Name = "sep2";
        sep2.Size = new Size(238, 5);
        sep2.TabIndex = 3;
        // 
        // gridDomains
        // 
        gridDomains.Dock = DockStyle.Top;
        gridDomains.Location = new Point(5, 61);
        gridDomains.HelpVisible = false;
        gridDomains.Name = "gridDomains";
        gridDomains.PropertySort = PropertySort.NoSort;
        gridDomains.Size = new Size(238, 348);
        gridDomains.TabIndex = 4;
        gridDomains.ToolbarVisible = false;
        // 
        // pnlDomain
        // 
        pnlDomain.BorderStyle = BorderStyle.FixedSingle;
        pnlDomain.Controls.Add(gridDomain);
        pnlDomain.Controls.Add(sep4);
        pnlDomain.Controls.Add(btnGetDomain);
        pnlDomain.Controls.Add(sep3);
        pnlDomain.Controls.Add(numGetDomainDomain);
        pnlDomain.Location = new Point(3, 3);
        pnlDomain.Name = "pnlDomain";
        pnlDomain.Padding = new Padding(5);
        pnlDomain.Size = new Size(250, 150);
        pnlDomain.TabIndex = 1;
        // 
        // numGetDomainDomain
        // 
        numGetDomainDomain.Dock = DockStyle.Top;
        numGetDomainDomain.Location = new Point(5, 5);
        numGetDomainDomain.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numGetDomainDomain.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        numGetDomainDomain.Name = "numGetDomainDomain";
        numGetDomainDomain.Size = new Size(238, 23);
        numGetDomainDomain.TabIndex = 0;
        numGetDomainDomain.Value = new decimal(new int[] { 0, 0, 0, 0 });
        // 
        // sep3
        // 
        sep3.Dock = DockStyle.Top;
        sep3.Location = new Point(5, 28);
        sep3.Name = "sep3";
        sep3.Size = new Size(238, 5);
        sep3.TabIndex = 1;
        // 
        // btnGetDomain
        // 
        btnGetDomain.Dock = DockStyle.Top;
        btnGetDomain.Location = new Point(5, 33);
        btnGetDomain.Name = "btnGetDomain";
        btnGetDomain.Size = new Size(238, 23);
        btnGetDomain.TabIndex = 2;
        btnGetDomain.Text = "Get Domain";
        btnGetDomain.UseVisualStyleBackColor = true;
        btnGetDomain.Click += btnGetDomain_Click;
        // 
        // sep4
        // 
        sep4.Dock = DockStyle.Top;
        sep4.Location = new Point(5, 56);
        sep4.Name = "sep4";
        sep4.Size = new Size(238, 5);
        sep4.TabIndex = 3;
        // 
        // gridDomain
        // 
        gridDomain.Dock = DockStyle.Top;
        gridDomain.Location = new Point(5, 61);
        gridDomain.HelpVisible = false;
        gridDomain.Name = "gridDomain";
        gridDomain.PropertySort = PropertySort.NoSort;
        gridDomain.Size = new Size(238, 82);
        gridDomain.TabIndex = 4;
        gridDomain.ToolbarVisible = false;
        // 
        // tabMessages
        // 
        tabMessages.Controls.Add(flowMessages);
        tabMessages.Location = new Point(4, 24);
        tabMessages.Name = "tabMessages";
        tabMessages.Padding = new Padding(3);
        tabMessages.Size = new Size(882, 463);
        tabMessages.TabIndex = 1;
        tabMessages.Text = "Messages";
        tabMessages.UseVisualStyleBackColor = true;
        // 
        // flowMessages
        // 
        flowMessages.AutoScroll = true;
        flowMessages.Controls.Add(pnlMessages);
        flowMessages.Controls.Add(pnlMessageTitles);
        flowMessages.Dock = DockStyle.Fill;
        flowMessages.FlowDirection = FlowDirection.TopDown;
        flowMessages.Location = new Point(3, 3);
        flowMessages.Name = "flowMessages";
        flowMessages.Size = new Size(876, 457);
        flowMessages.TabIndex = 0;
        // 
        // pnlMessages
        // 
        pnlMessages.BorderStyle = BorderStyle.FixedSingle;
        pnlMessages.Controls.Add(gridMessages);
        pnlMessages.Controls.Add(sep9);
        pnlMessages.Controls.Add(btnGetMessages);
        pnlMessages.Controls.Add(sep8);
        pnlMessages.Controls.Add(numGetMessagesMaxCount);
        pnlMessages.Controls.Add(sep7);
        pnlMessages.Controls.Add(txtGetMessagesLanguage);
        pnlMessages.Controls.Add(sep6);
        pnlMessages.Controls.Add(cboGetMessagesOrder);
        pnlMessages.Controls.Add(sep5);
        pnlMessages.Controls.Add(numGetMessagesDomain);
        pnlMessages.Location = new Point(3, 3);
        pnlMessages.Name = "pnlMessages";
        pnlMessages.Padding = new Padding(5);
        pnlMessages.Size = new Size(250, 443);
        pnlMessages.TabIndex = 0;
        // 
        // numGetMessagesDomain
        // 
        numGetMessagesDomain.Dock = DockStyle.Top;
        numGetMessagesDomain.Location = new Point(5, 5);
        numGetMessagesDomain.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numGetMessagesDomain.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        numGetMessagesDomain.Name = "numGetMessagesDomain";
        numGetMessagesDomain.Size = new Size(238, 23);
        numGetMessagesDomain.TabIndex = 0;
        numGetMessagesDomain.Value = new decimal(new int[] { 0, 0, 0, 0 });
        // 
        // sep5
        // 
        sep5.Dock = DockStyle.Top;
        sep5.Location = new Point(5, 28);
        sep5.Name = "sep5";
        sep5.Size = new Size(238, 5);
        sep5.TabIndex = 1;
        // 
        // cboGetMessagesOrder
        // 
        cboGetMessagesOrder.Dock = DockStyle.Top;
        cboGetMessagesOrder.Location = new Point(5, 33);
        cboGetMessagesOrder.DropDownStyle = ComboBoxStyle.DropDownList;
        cboGetMessagesOrder.FormattingEnabled = true;
        cboGetMessagesOrder.Name = "cboGetMessagesOrder";
        cboGetMessagesOrder.Size = new Size(238, 23);
        cboGetMessagesOrder.TabIndex = 2;
        // 
        // sep6
        // 
        sep6.Dock = DockStyle.Top;
        sep6.Location = new Point(5, 56);
        sep6.Name = "sep6";
        sep6.Size = new Size(238, 5);
        sep6.TabIndex = 3;
        // 
        // txtGetMessagesLanguage
        // 
        txtGetMessagesLanguage.Dock = DockStyle.Top;
        txtGetMessagesLanguage.Location = new Point(5, 61);
        txtGetMessagesLanguage.Name = "txtGetMessagesLanguage";
        txtGetMessagesLanguage.PlaceholderText = "language (optional)";
        txtGetMessagesLanguage.Size = new Size(238, 23);
        txtGetMessagesLanguage.TabIndex = 4;
        txtGetMessagesLanguage.Text = "en";
        // 
        // sep7
        // 
        sep7.Dock = DockStyle.Top;
        sep7.Location = new Point(5, 84);
        sep7.Name = "sep7";
        sep7.Size = new Size(238, 5);
        sep7.TabIndex = 5;
        // 
        // numGetMessagesMaxCount
        // 
        numGetMessagesMaxCount.Dock = DockStyle.Top;
        numGetMessagesMaxCount.Location = new Point(5, 89);
        numGetMessagesMaxCount.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numGetMessagesMaxCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numGetMessagesMaxCount.Name = "numGetMessagesMaxCount";
        numGetMessagesMaxCount.Size = new Size(238, 23);
        numGetMessagesMaxCount.TabIndex = 6;
        numGetMessagesMaxCount.Value = new decimal(new int[] { 20, 0, 0, 0 });
        // 
        // sep8
        // 
        sep8.Dock = DockStyle.Top;
        sep8.Location = new Point(5, 112);
        sep8.Name = "sep8";
        sep8.Size = new Size(238, 5);
        sep8.TabIndex = 7;
        // 
        // btnGetMessages
        // 
        btnGetMessages.Dock = DockStyle.Top;
        btnGetMessages.Location = new Point(5, 117);
        btnGetMessages.Name = "btnGetMessages";
        btnGetMessages.Size = new Size(238, 23);
        btnGetMessages.TabIndex = 8;
        btnGetMessages.Text = "Get Messages";
        btnGetMessages.UseVisualStyleBackColor = true;
        btnGetMessages.Click += btnGetMessages_Click;
        // 
        // sep9
        // 
        sep9.Dock = DockStyle.Top;
        sep9.Location = new Point(5, 140);
        sep9.Name = "sep9";
        sep9.Size = new Size(238, 5);
        sep9.TabIndex = 9;
        // 
        // gridMessages
        // 
        gridMessages.Dock = DockStyle.Top;
        gridMessages.Location = new Point(5, 145);
        gridMessages.HelpVisible = false;
        gridMessages.Name = "gridMessages";
        gridMessages.PropertySort = PropertySort.NoSort;
        gridMessages.Size = new Size(238, 291);
        gridMessages.TabIndex = 10;
        gridMessages.ToolbarVisible = false;
        // 
        // pnlMessageTitles
        // 
        pnlMessageTitles.BorderStyle = BorderStyle.FixedSingle;
        pnlMessageTitles.Controls.Add(gridMessageTitles);
        pnlMessageTitles.Controls.Add(sep14);
        pnlMessageTitles.Controls.Add(btnGetMessageTitles);
        pnlMessageTitles.Controls.Add(sep13);
        pnlMessageTitles.Controls.Add(numGetMessageTitlesMaxCount);
        pnlMessageTitles.Controls.Add(sep12);
        pnlMessageTitles.Controls.Add(cboGetMessageTitlesOrder);
        pnlMessageTitles.Controls.Add(sep11);
        pnlMessageTitles.Controls.Add(txtGetMessageTitlesLanguage);
        pnlMessageTitles.Controls.Add(sep10);
        pnlMessageTitles.Controls.Add(numGetMessageTitlesDomain);
        pnlMessageTitles.Location = new Point(3, 3);
        pnlMessageTitles.Name = "pnlMessageTitles";
        pnlMessageTitles.Padding = new Padding(5);
        pnlMessageTitles.Size = new Size(250, 443);
        pnlMessageTitles.TabIndex = 1;
        // 
        // numGetMessageTitlesDomain
        // 
        numGetMessageTitlesDomain.Dock = DockStyle.Top;
        numGetMessageTitlesDomain.Location = new Point(5, 5);
        numGetMessageTitlesDomain.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numGetMessageTitlesDomain.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        numGetMessageTitlesDomain.Name = "numGetMessageTitlesDomain";
        numGetMessageTitlesDomain.Size = new Size(238, 23);
        numGetMessageTitlesDomain.TabIndex = 0;
        numGetMessageTitlesDomain.Value = new decimal(new int[] { 0, 0, 0, 0 });
        // 
        // sep10
        // 
        sep10.Dock = DockStyle.Top;
        sep10.Location = new Point(5, 28);
        sep10.Name = "sep10";
        sep10.Size = new Size(238, 5);
        sep10.TabIndex = 1;
        // 
        // txtGetMessageTitlesLanguage
        // 
        txtGetMessageTitlesLanguage.Dock = DockStyle.Top;
        txtGetMessageTitlesLanguage.Location = new Point(5, 33);
        txtGetMessageTitlesLanguage.Name = "txtGetMessageTitlesLanguage";
        txtGetMessageTitlesLanguage.PlaceholderText = "language";
        txtGetMessageTitlesLanguage.Size = new Size(238, 23);
        txtGetMessageTitlesLanguage.TabIndex = 2;
        txtGetMessageTitlesLanguage.Text = "en";
        // 
        // sep11
        // 
        sep11.Dock = DockStyle.Top;
        sep11.Location = new Point(5, 56);
        sep11.Name = "sep11";
        sep11.Size = new Size(238, 5);
        sep11.TabIndex = 3;
        // 
        // cboGetMessageTitlesOrder
        // 
        cboGetMessageTitlesOrder.Dock = DockStyle.Top;
        cboGetMessageTitlesOrder.Location = new Point(5, 61);
        cboGetMessageTitlesOrder.DropDownStyle = ComboBoxStyle.DropDownList;
        cboGetMessageTitlesOrder.FormattingEnabled = true;
        cboGetMessageTitlesOrder.Name = "cboGetMessageTitlesOrder";
        cboGetMessageTitlesOrder.Size = new Size(238, 23);
        cboGetMessageTitlesOrder.TabIndex = 4;
        // 
        // sep12
        // 
        sep12.Dock = DockStyle.Top;
        sep12.Location = new Point(5, 84);
        sep12.Name = "sep12";
        sep12.Size = new Size(238, 5);
        sep12.TabIndex = 5;
        // 
        // numGetMessageTitlesMaxCount
        // 
        numGetMessageTitlesMaxCount.Dock = DockStyle.Top;
        numGetMessageTitlesMaxCount.Location = new Point(5, 89);
        numGetMessageTitlesMaxCount.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numGetMessageTitlesMaxCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numGetMessageTitlesMaxCount.Name = "numGetMessageTitlesMaxCount";
        numGetMessageTitlesMaxCount.Size = new Size(238, 23);
        numGetMessageTitlesMaxCount.TabIndex = 6;
        numGetMessageTitlesMaxCount.Value = new decimal(new int[] { 20, 0, 0, 0 });
        // 
        // sep13
        // 
        sep13.Dock = DockStyle.Top;
        sep13.Location = new Point(5, 112);
        sep13.Name = "sep13";
        sep13.Size = new Size(238, 5);
        sep13.TabIndex = 7;
        // 
        // btnGetMessageTitles
        // 
        btnGetMessageTitles.Dock = DockStyle.Top;
        btnGetMessageTitles.Location = new Point(5, 117);
        btnGetMessageTitles.Name = "btnGetMessageTitles";
        btnGetMessageTitles.Size = new Size(238, 23);
        btnGetMessageTitles.TabIndex = 8;
        btnGetMessageTitles.Text = "Get Message titles";
        btnGetMessageTitles.UseVisualStyleBackColor = true;
        btnGetMessageTitles.Click += btnGetMessageTitles_Click;
        // 
        // sep14
        // 
        sep14.Dock = DockStyle.Top;
        sep14.Location = new Point(5, 140);
        sep14.Name = "sep14";
        sep14.Size = new Size(238, 5);
        sep14.TabIndex = 9;
        // 
        // gridMessageTitles
        // 
        gridMessageTitles.Dock = DockStyle.Top;
        gridMessageTitles.Location = new Point(5, 145);
        gridMessageTitles.HelpVisible = false;
        gridMessageTitles.Name = "gridMessageTitles";
        gridMessageTitles.PropertySort = PropertySort.NoSort;
        gridMessageTitles.Size = new Size(238, 291);
        gridMessageTitles.TabIndex = 10;
        gridMessageTitles.ToolbarVisible = false;
        // 
        // tabSingleMessage
        // 
        tabSingleMessage.Controls.Add(flowSingleMessage);
        tabSingleMessage.Location = new Point(4, 24);
        tabSingleMessage.Name = "tabSingleMessage";
        tabSingleMessage.Padding = new Padding(3);
        tabSingleMessage.Size = new Size(882, 463);
        tabSingleMessage.TabIndex = 2;
        tabSingleMessage.Text = "One message";
        tabSingleMessage.UseVisualStyleBackColor = true;
        // 
        // flowSingleMessage
        // 
        flowSingleMessage.AutoScroll = true;
        flowSingleMessage.Controls.Add(pnlMessage);
        flowSingleMessage.Controls.Add(pnlMessageBySequenceNumber);
        flowSingleMessage.Dock = DockStyle.Fill;
        flowSingleMessage.FlowDirection = FlowDirection.TopDown;
        flowSingleMessage.Location = new Point(3, 3);
        flowSingleMessage.Name = "flowSingleMessage";
        flowSingleMessage.Size = new Size(876, 457);
        flowSingleMessage.TabIndex = 0;
        // 
        // pnlMessage
        // 
        pnlMessage.BorderStyle = BorderStyle.FixedSingle;
        pnlMessage.Controls.Add(gridMessage);
        pnlMessage.Controls.Add(sep18);
        pnlMessage.Controls.Add(btnGetMessage);
        pnlMessage.Controls.Add(sep17);
        pnlMessage.Controls.Add(txtGetMessageLanguage);
        pnlMessage.Controls.Add(sep16);
        pnlMessage.Controls.Add(numGetMessageSequenceNumber);
        pnlMessage.Controls.Add(sep15);
        pnlMessage.Controls.Add(numGetMessageDomain);
        pnlMessage.Location = new Point(3, 3);
        pnlMessage.Name = "pnlMessage";
        pnlMessage.Padding = new Padding(5);
        pnlMessage.Size = new Size(250, 377);
        pnlMessage.TabIndex = 0;
        // 
        // numGetMessageDomain
        // 
        numGetMessageDomain.Dock = DockStyle.Top;
        numGetMessageDomain.Location = new Point(5, 5);
        numGetMessageDomain.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numGetMessageDomain.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        numGetMessageDomain.Name = "numGetMessageDomain";
        numGetMessageDomain.Size = new Size(238, 23);
        numGetMessageDomain.TabIndex = 0;
        numGetMessageDomain.Value = new decimal(new int[] { 0, 0, 0, 0 });
        // 
        // sep15
        // 
        sep15.Dock = DockStyle.Top;
        sep15.Location = new Point(5, 28);
        sep15.Name = "sep15";
        sep15.Size = new Size(238, 5);
        sep15.TabIndex = 1;
        // 
        // numGetMessageSequenceNumber
        // 
        numGetMessageSequenceNumber.Dock = DockStyle.Top;
        numGetMessageSequenceNumber.Location = new Point(5, 33);
        numGetMessageSequenceNumber.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numGetMessageSequenceNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numGetMessageSequenceNumber.Name = "numGetMessageSequenceNumber";
        numGetMessageSequenceNumber.Size = new Size(238, 23);
        numGetMessageSequenceNumber.TabIndex = 2;
        numGetMessageSequenceNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // sep16
        // 
        sep16.Dock = DockStyle.Top;
        sep16.Location = new Point(5, 56);
        sep16.Name = "sep16";
        sep16.Size = new Size(238, 5);
        sep16.TabIndex = 3;
        // 
        // txtGetMessageLanguage
        // 
        txtGetMessageLanguage.Dock = DockStyle.Top;
        txtGetMessageLanguage.Location = new Point(5, 61);
        txtGetMessageLanguage.Name = "txtGetMessageLanguage";
        txtGetMessageLanguage.PlaceholderText = "language (optional)";
        txtGetMessageLanguage.Size = new Size(238, 23);
        txtGetMessageLanguage.TabIndex = 4;
        txtGetMessageLanguage.Text = "en";
        // 
        // sep17
        // 
        sep17.Dock = DockStyle.Top;
        sep17.Location = new Point(5, 84);
        sep17.Name = "sep17";
        sep17.Size = new Size(238, 5);
        sep17.TabIndex = 5;
        // 
        // btnGetMessage
        // 
        btnGetMessage.Dock = DockStyle.Top;
        btnGetMessage.Location = new Point(5, 89);
        btnGetMessage.Name = "btnGetMessage";
        btnGetMessage.Size = new Size(238, 23);
        btnGetMessage.TabIndex = 6;
        btnGetMessage.Text = "Get Message";
        btnGetMessage.UseVisualStyleBackColor = true;
        btnGetMessage.Click += btnGetMessage_Click;
        // 
        // sep18
        // 
        sep18.Dock = DockStyle.Top;
        sep18.Location = new Point(5, 112);
        sep18.Name = "sep18";
        sep18.Size = new Size(238, 5);
        sep18.TabIndex = 7;
        // 
        // gridMessage
        // 
        gridMessage.Dock = DockStyle.Top;
        gridMessage.Location = new Point(5, 117);
        gridMessage.HelpVisible = false;
        gridMessage.Name = "gridMessage";
        gridMessage.PropertySort = PropertySort.NoSort;
        gridMessage.Size = new Size(238, 253);
        gridMessage.TabIndex = 8;
        gridMessage.ToolbarVisible = false;
        // 
        // pnlMessageBySequenceNumber
        // 
        pnlMessageBySequenceNumber.BorderStyle = BorderStyle.FixedSingle;
        pnlMessageBySequenceNumber.Controls.Add(gridMessageBySequenceNumber);
        pnlMessageBySequenceNumber.Controls.Add(sep21);
        pnlMessageBySequenceNumber.Controls.Add(btnGetMessageBySequenceNumber);
        pnlMessageBySequenceNumber.Controls.Add(sep20);
        pnlMessageBySequenceNumber.Controls.Add(txtGetMessageBySequenceNumberLanguage);
        pnlMessageBySequenceNumber.Controls.Add(sep19);
        pnlMessageBySequenceNumber.Controls.Add(numGetMessageBySequenceNumberSequenceNumber);
        pnlMessageBySequenceNumber.Location = new Point(3, 3);
        pnlMessageBySequenceNumber.Name = "pnlMessageBySequenceNumber";
        pnlMessageBySequenceNumber.Padding = new Padding(5);
        pnlMessageBySequenceNumber.Size = new Size(250, 349);
        pnlMessageBySequenceNumber.TabIndex = 1;
        // 
        // numGetMessageBySequenceNumberSequenceNumber
        // 
        numGetMessageBySequenceNumberSequenceNumber.Dock = DockStyle.Top;
        numGetMessageBySequenceNumberSequenceNumber.Location = new Point(5, 5);
        numGetMessageBySequenceNumberSequenceNumber.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numGetMessageBySequenceNumberSequenceNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numGetMessageBySequenceNumberSequenceNumber.Name = "numGetMessageBySequenceNumberSequenceNumber";
        numGetMessageBySequenceNumberSequenceNumber.Size = new Size(238, 23);
        numGetMessageBySequenceNumberSequenceNumber.TabIndex = 0;
        numGetMessageBySequenceNumberSequenceNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // sep19
        // 
        sep19.Dock = DockStyle.Top;
        sep19.Location = new Point(5, 28);
        sep19.Name = "sep19";
        sep19.Size = new Size(238, 5);
        sep19.TabIndex = 1;
        // 
        // txtGetMessageBySequenceNumberLanguage
        // 
        txtGetMessageBySequenceNumberLanguage.Dock = DockStyle.Top;
        txtGetMessageBySequenceNumberLanguage.Location = new Point(5, 33);
        txtGetMessageBySequenceNumberLanguage.Name = "txtGetMessageBySequenceNumberLanguage";
        txtGetMessageBySequenceNumberLanguage.PlaceholderText = "language (optional)";
        txtGetMessageBySequenceNumberLanguage.Size = new Size(238, 23);
        txtGetMessageBySequenceNumberLanguage.TabIndex = 2;
        txtGetMessageBySequenceNumberLanguage.Text = "en";
        // 
        // sep20
        // 
        sep20.Dock = DockStyle.Top;
        sep20.Location = new Point(5, 56);
        sep20.Name = "sep20";
        sep20.Size = new Size(238, 5);
        sep20.TabIndex = 3;
        // 
        // btnGetMessageBySequenceNumber
        // 
        btnGetMessageBySequenceNumber.Dock = DockStyle.Top;
        btnGetMessageBySequenceNumber.Location = new Point(5, 61);
        btnGetMessageBySequenceNumber.Name = "btnGetMessageBySequenceNumber";
        btnGetMessageBySequenceNumber.Size = new Size(238, 23);
        btnGetMessageBySequenceNumber.TabIndex = 4;
        btnGetMessageBySequenceNumber.Text = "Get Message by sequence number";
        btnGetMessageBySequenceNumber.UseVisualStyleBackColor = true;
        btnGetMessageBySequenceNumber.Click += btnGetMessageBySequenceNumber_Click;
        // 
        // sep21
        // 
        sep21.Dock = DockStyle.Top;
        sep21.Location = new Point(5, 84);
        sep21.Name = "sep21";
        sep21.Size = new Size(238, 5);
        sep21.TabIndex = 5;
        // 
        // gridMessageBySequenceNumber
        // 
        gridMessageBySequenceNumber.Dock = DockStyle.Top;
        gridMessageBySequenceNumber.Location = new Point(5, 89);
        gridMessageBySequenceNumber.HelpVisible = false;
        gridMessageBySequenceNumber.Name = "gridMessageBySequenceNumber";
        gridMessageBySequenceNumber.PropertySort = PropertySort.NoSort;
        gridMessageBySequenceNumber.Size = new Size(238, 253);
        gridMessageBySequenceNumber.TabIndex = 6;
        gridMessageBySequenceNumber.ToolbarVisible = false;
        // 
        // tabMaintenance
        // 
        tabMaintenance.Controls.Add(flowMaintenance);
        tabMaintenance.Location = new Point(4, 24);
        tabMaintenance.Name = "tabMaintenance";
        tabMaintenance.Padding = new Padding(3);
        tabMaintenance.Size = new Size(882, 463);
        tabMaintenance.TabIndex = 3;
        tabMaintenance.Text = "Maintenance";
        tabMaintenance.UseVisualStyleBackColor = true;
        // 
        // flowMaintenance
        // 
        flowMaintenance.AutoScroll = true;
        flowMaintenance.Controls.Add(pnlSaveDump);
        flowMaintenance.Controls.Add(pnlClearMessages);
        flowMaintenance.Controls.Add(pnlClearAllMessages);
        flowMaintenance.Dock = DockStyle.Fill;
        flowMaintenance.FlowDirection = FlowDirection.TopDown;
        flowMaintenance.Location = new Point(3, 3);
        flowMaintenance.Name = "flowMaintenance";
        flowMaintenance.Size = new Size(876, 457);
        flowMaintenance.TabIndex = 0;
        // 
        // pnlSaveDump
        // 
        pnlSaveDump.BorderStyle = BorderStyle.FixedSingle;
        pnlSaveDump.Controls.Add(txtSaveInSystemDumpFormatResult);
        pnlSaveDump.Controls.Add(sep23);
        pnlSaveDump.Controls.Add(btnSaveInSystemDumpFormat);
        pnlSaveDump.Controls.Add(sep22);
        pnlSaveDump.Controls.Add(txtSaveInSystemDumpFormatPath);
        pnlSaveDump.Location = new Point(3, 3);
        pnlSaveDump.Name = "pnlSaveDump";
        pnlSaveDump.Padding = new Padding(5);
        pnlSaveDump.Size = new Size(250, 91);
        pnlSaveDump.TabIndex = 0;
        // 
        // txtSaveInSystemDumpFormatPath
        // 
        txtSaveInSystemDumpFormatPath.Dock = DockStyle.Top;
        txtSaveInSystemDumpFormatPath.Location = new Point(5, 5);
        txtSaveInSystemDumpFormatPath.Name = "txtSaveInSystemDumpFormatPath";
        txtSaveInSystemDumpFormatPath.PlaceholderText = "path";
        txtSaveInSystemDumpFormatPath.Size = new Size(238, 23);
        txtSaveInSystemDumpFormatPath.TabIndex = 0;
        txtSaveInSystemDumpFormatPath.Text = "$temp/elog.txt";
        // 
        // sep22
        // 
        sep22.Dock = DockStyle.Top;
        sep22.Location = new Point(5, 28);
        sep22.Name = "sep22";
        sep22.Size = new Size(238, 5);
        sep22.TabIndex = 1;
        // 
        // btnSaveInSystemDumpFormat
        // 
        btnSaveInSystemDumpFormat.Dock = DockStyle.Top;
        btnSaveInSystemDumpFormat.Location = new Point(5, 33);
        btnSaveInSystemDumpFormat.Name = "btnSaveInSystemDumpFormat";
        btnSaveInSystemDumpFormat.Size = new Size(238, 23);
        btnSaveInSystemDumpFormat.TabIndex = 2;
        btnSaveInSystemDumpFormat.Text = "Save in system dump format";
        btnSaveInSystemDumpFormat.UseVisualStyleBackColor = true;
        btnSaveInSystemDumpFormat.Click += btnSaveInSystemDumpFormat_Click;
        // 
        // sep23
        // 
        sep23.Dock = DockStyle.Top;
        sep23.Location = new Point(5, 56);
        sep23.Name = "sep23";
        sep23.Size = new Size(238, 5);
        sep23.TabIndex = 3;
        // 
        // txtSaveInSystemDumpFormatResult
        // 
        txtSaveInSystemDumpFormatResult.Dock = DockStyle.Top;
        txtSaveInSystemDumpFormatResult.Location = new Point(5, 61);
        txtSaveInSystemDumpFormatResult.Name = "txtSaveInSystemDumpFormatResult";
        txtSaveInSystemDumpFormatResult.PlaceholderText = "result";
        txtSaveInSystemDumpFormatResult.ReadOnly = true;
        txtSaveInSystemDumpFormatResult.Size = new Size(238, 23);
        txtSaveInSystemDumpFormatResult.TabIndex = 4;
        // 
        // pnlClearMessages
        // 
        pnlClearMessages.BorderStyle = BorderStyle.FixedSingle;
        pnlClearMessages.Controls.Add(btnClearMessages);
        pnlClearMessages.Controls.Add(sep24);
        pnlClearMessages.Controls.Add(numClearMessagesDomain);
        pnlClearMessages.Location = new Point(3, 3);
        pnlClearMessages.Name = "pnlClearMessages";
        pnlClearMessages.Padding = new Padding(5);
        pnlClearMessages.Size = new Size(250, 63);
        pnlClearMessages.TabIndex = 1;
        // 
        // numClearMessagesDomain
        // 
        numClearMessagesDomain.Dock = DockStyle.Top;
        numClearMessagesDomain.Location = new Point(5, 5);
        numClearMessagesDomain.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numClearMessagesDomain.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        numClearMessagesDomain.Name = "numClearMessagesDomain";
        numClearMessagesDomain.Size = new Size(238, 23);
        numClearMessagesDomain.TabIndex = 0;
        numClearMessagesDomain.Value = new decimal(new int[] { 0, 0, 0, 0 });
        // 
        // sep24
        // 
        sep24.Dock = DockStyle.Top;
        sep24.Location = new Point(5, 28);
        sep24.Name = "sep24";
        sep24.Size = new Size(238, 5);
        sep24.TabIndex = 1;
        // 
        // btnClearMessages
        // 
        btnClearMessages.Dock = DockStyle.Top;
        btnClearMessages.Location = new Point(5, 33);
        btnClearMessages.Name = "btnClearMessages";
        btnClearMessages.Size = new Size(238, 23);
        btnClearMessages.TabIndex = 2;
        btnClearMessages.Text = "Clear Domain messages";
        btnClearMessages.UseVisualStyleBackColor = true;
        btnClearMessages.Click += btnClearMessages_Click;
        // 
        // pnlClearAllMessages
        // 
        pnlClearAllMessages.BorderStyle = BorderStyle.FixedSingle;
        pnlClearAllMessages.Controls.Add(btnClearAllMessages);
        pnlClearAllMessages.Location = new Point(3, 3);
        pnlClearAllMessages.Name = "pnlClearAllMessages";
        pnlClearAllMessages.Padding = new Padding(5);
        pnlClearAllMessages.Size = new Size(250, 35);
        pnlClearAllMessages.TabIndex = 2;
        // 
        // btnClearAllMessages
        // 
        btnClearAllMessages.Dock = DockStyle.Top;
        btnClearAllMessages.Location = new Point(5, 5);
        btnClearAllMessages.Name = "btnClearAllMessages";
        btnClearAllMessages.Size = new Size(238, 23);
        btnClearAllMessages.TabIndex = 0;
        btnClearAllMessages.Text = "Clear All messages";
        btnClearAllMessages.UseVisualStyleBackColor = true;
        btnClearAllMessages.Click += btnClearAllMessages_Click;
        //
        // RwsELogControl
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tabControl);
        Margin = new Padding(4, 3, 4, 3);
        Name = "RwsELogControl";
        Size = new Size(890, 491);
        tabControl.ResumeLayout(false);
        tabDomains.ResumeLayout(false);
        flowDomains.ResumeLayout(false);
        tabMessages.ResumeLayout(false);
        flowMessages.ResumeLayout(false);
        tabSingleMessage.ResumeLayout(false);
        flowSingleMessage.ResumeLayout(false);
        tabMaintenance.ResumeLayout(false);
        flowMaintenance.ResumeLayout(false);
        pnlDomains.ResumeLayout(false);
        pnlDomains.PerformLayout();
        pnlDomain.ResumeLayout(false);
        pnlDomain.PerformLayout();
        pnlMessages.ResumeLayout(false);
        pnlMessages.PerformLayout();
        pnlMessageTitles.ResumeLayout(false);
        pnlMessageTitles.PerformLayout();
        pnlMessage.ResumeLayout(false);
        pnlMessage.PerformLayout();
        pnlMessageBySequenceNumber.ResumeLayout(false);
        pnlMessageBySequenceNumber.PerformLayout();
        pnlSaveDump.ResumeLayout(false);
        pnlSaveDump.PerformLayout();
        pnlClearMessages.ResumeLayout(false);
        pnlClearMessages.PerformLayout();
        pnlClearAllMessages.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numGetDomainDomain).EndInit();
        ((System.ComponentModel.ISupportInitialize)numGetMessagesDomain).EndInit();
        ((System.ComponentModel.ISupportInitialize)numGetMessagesMaxCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)numGetMessageTitlesDomain).EndInit();
        ((System.ComponentModel.ISupportInitialize)numGetMessageTitlesMaxCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)numGetMessageDomain).EndInit();
        ((System.ComponentModel.ISupportInitialize)numGetMessageSequenceNumber).EndInit();
        ((System.ComponentModel.ISupportInitialize)numGetMessageBySequenceNumberSequenceNumber).EndInit();
        ((System.ComponentModel.ISupportInitialize)numClearMessagesDomain).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl;

    private TabPage tabDomains;
    private FlowLayoutPanel flowDomains;

    private Panel pnlDomains;
    private TextBox txtGetDomainsLanguage;
    private Panel sep1;
    private Button btnGetDomains;
    private Panel sep2;
    private PropertyGrid gridDomains;

    private Panel pnlDomain;
    private NumericUpDown numGetDomainDomain;
    private Panel sep3;
    private Button btnGetDomain;
    private Panel sep4;
    private PropertyGrid gridDomain;

    private TabPage tabMessages;
    private FlowLayoutPanel flowMessages;

    private Panel pnlMessages;
    private NumericUpDown numGetMessagesDomain;
    private Panel sep5;
    private ComboBox cboGetMessagesOrder;
    private Panel sep6;
    private TextBox txtGetMessagesLanguage;
    private Panel sep7;
    private NumericUpDown numGetMessagesMaxCount;
    private Panel sep8;
    private Button btnGetMessages;
    private Panel sep9;
    private PropertyGrid gridMessages;

    private Panel pnlMessageTitles;
    private NumericUpDown numGetMessageTitlesDomain;
    private Panel sep10;
    private TextBox txtGetMessageTitlesLanguage;
    private Panel sep11;
    private ComboBox cboGetMessageTitlesOrder;
    private Panel sep12;
    private NumericUpDown numGetMessageTitlesMaxCount;
    private Panel sep13;
    private Button btnGetMessageTitles;
    private Panel sep14;
    private PropertyGrid gridMessageTitles;

    private TabPage tabSingleMessage;
    private FlowLayoutPanel flowSingleMessage;

    private Panel pnlMessage;
    private NumericUpDown numGetMessageDomain;
    private Panel sep15;
    private NumericUpDown numGetMessageSequenceNumber;
    private Panel sep16;
    private TextBox txtGetMessageLanguage;
    private Panel sep17;
    private Button btnGetMessage;
    private Panel sep18;
    private PropertyGrid gridMessage;

    private Panel pnlMessageBySequenceNumber;
    private NumericUpDown numGetMessageBySequenceNumberSequenceNumber;
    private Panel sep19;
    private TextBox txtGetMessageBySequenceNumberLanguage;
    private Panel sep20;
    private Button btnGetMessageBySequenceNumber;
    private Panel sep21;
    private PropertyGrid gridMessageBySequenceNumber;

    private TabPage tabMaintenance;
    private FlowLayoutPanel flowMaintenance;

    private Panel pnlSaveDump;
    private TextBox txtSaveInSystemDumpFormatPath;
    private Panel sep22;
    private Button btnSaveInSystemDumpFormat;
    private Panel sep23;
    private TextBox txtSaveInSystemDumpFormatResult;

    private Panel pnlClearMessages;
    private NumericUpDown numClearMessagesDomain;
    private Panel sep24;
    private Button btnClearMessages;

    private Panel pnlClearAllMessages;
    private Button btnClearAllMessages;
}
