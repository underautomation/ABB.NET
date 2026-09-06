using System;
using System.ComponentModel;
using System.Windows.Forms;
using UnderAutomation.ABB;
using UnderAutomation.ABB.Rws.Data;

public partial class RwsELogControl : UserControl, IUserControl
{
    private AbbController _robot;

    public RwsELogControl(AbbController robot)
    {
        // Complex types shown in a PropertyGrid have to be expandable and not editable
        MakeExpandableAndReadOnly(typeof(ElogDomain));
        MakeExpandableAndReadOnly(typeof(ElogDomain[]));
        MakeExpandableAndReadOnly(typeof(ElogMessage));
        MakeExpandableAndReadOnly(typeof(ElogMessage[]));
        MakeExpandableAndReadOnly(typeof(ElogMessageArgument));
        MakeExpandableAndReadOnly(typeof(ElogMessageArgument[]));

        _robot = robot;
        InitializeComponent();

        // Enum arguments are selected in a combo box. Both orders are commands the controller accepts.
        FillCombo(cboGetMessagesOrder, Enum.GetValues(typeof(ElogMessageOrder)));
        FillCombo(cboGetMessageTitlesOrder, Enum.GetValues(typeof(ElogMessageOrder)));
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

    // An empty text box stands for an omitted optional argument
    private static string? Optional(TextBox textBox)
    {
        return string.IsNullOrEmpty(textBox.Text) ? null : textBox.Text;
    }

    // Show a complex result in a property grid, all nodes expanded
    private static void ShowInGrid(PropertyGrid grid, object value)
    {
        grid.SelectedObject = value;
        grid.ExpandAllGridItems();
    }

    #region IUserControl
    public string Title => "Logs (RWS)";

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


    #region Domains

    private void btnGetDomains_Click(object sender, EventArgs e)
    {
        ElogDomain[] domains = _robot.Rws.Elog.GetDomains(Optional(txtGetDomainsLanguage));
        ShowInGrid(gridDomains, domains);
    }

    private void btnGetDomain_Click(object sender, EventArgs e)
    {
        ElogDomain domain = _robot.Rws.Elog.GetDomain((int)numGetDomainDomain.Value);
        ShowInGrid(gridDomain, domain);
    }

    #endregion

    #region Messages

    private void btnGetMessages_Click(object sender, EventArgs e)
    {
        // Without a count the whole domain is read, which costs one request per page
        ElogMessage[] messages = _robot.Rws.Elog.GetMessages((int)numGetMessagesDomain.Value,
                                                             SelectedValue<ElogMessageOrder>(cboGetMessagesOrder),
                                                             Optional(txtGetMessagesLanguage),
                                                             (int)numGetMessagesMaxCount.Value);
        ShowInGrid(gridMessages, messages);
    }

    private void btnGetMessageTitles_Click(object sender, EventArgs e)
    {
        ElogMessage[] messages = _robot.Rws.Elog.GetMessageTitles((int)numGetMessageTitlesDomain.Value,
                                                                  txtGetMessageTitlesLanguage.Text,
                                                                  SelectedValue<ElogMessageOrder>(cboGetMessageTitlesOrder),
                                                                  (int)numGetMessageTitlesMaxCount.Value);
        ShowInGrid(gridMessageTitles, messages);
    }

    private void btnGetMessage_Click(object sender, EventArgs e)
    {
        ElogMessage message = _robot.Rws.Elog.GetMessage((int)numGetMessageDomain.Value,
                                                         (int)numGetMessageSequenceNumber.Value,
                                                         Optional(txtGetMessageLanguage));
        ShowInGrid(gridMessage, message);
    }

    private void btnGetMessageBySequenceNumber_Click(object sender, EventArgs e)
    {
        // Only a connection established with version 2 exposes this, version 1 explains the refusal
        ElogMessage message = _robot.Rws.Elog.GetMessageBySequenceNumber((int)numGetMessageBySequenceNumberSequenceNumber.Value,
                                                                        Optional(txtGetMessageBySequenceNumberLanguage));
        ShowInGrid(gridMessageBySequenceNumber, message);
    }

    #endregion

    #region Maintenance

    private void btnSaveInSystemDumpFormat_Click(object sender, EventArgs e)
    {
        // The controller accepts the request and writes the file afterwards, so there is nothing to show yet
        _robot.Rws.Elog.SaveInSystemDumpFormat(txtSaveInSystemDumpFormatPath.Text);
        txtSaveInSystemDumpFormatResult.Text = "Requested, the controller writes the file in the background";
    }

    private void btnClearMessages_Click(object sender, EventArgs e)
    {
        var domain = (int)numClearMessagesDomain.Value;

        if (MessageBox.Show($"Delete every message of domain {domain}? They cannot be recovered.",
                            "Clear domain messages", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            return;

        _robot.Rws.Elog.ClearMessages(domain);
    }

    private void btnClearAllMessages_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Delete every message of every domain? They cannot be recovered.",
                            "Clear all messages", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            return;

        _robot.Rws.Elog.ClearAllMessages();
    }

    #endregion
}
