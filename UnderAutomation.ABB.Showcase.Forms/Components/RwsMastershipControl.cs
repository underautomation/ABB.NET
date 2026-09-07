using System;
using System.ComponentModel;
using System.Windows.Forms;
using UnderAutomation.ABB;
using UnderAutomation.ABB.Rws.Data;

public partial class RwsMastershipControl : UserControl, IUserControl
{
    private AbbController _robot;

    public RwsMastershipControl(AbbController robot)
    {
        // Complex types shown in a PropertyGrid have to be expandable and not editable
        MakeExpandableAndReadOnly(typeof(MastershipInfo));
        MakeExpandableAndReadOnly(typeof(MastershipInfo[]));
        MakeExpandableAndReadOnly(typeof(MastershipDomain[]));

        _robot = robot;
        InitializeComponent();

        // The four domains are all accepted whatever the connection version: the ones the controller does
        // not expose land on the domain covering the same ground
        cboDomain.Items.AddRange(new object[]
        {
            MastershipDomain.Edit,
            MastershipDomain.Motion,
            MastershipDomain.Configuration,
            MastershipDomain.Rapid,
        });
        cboDomain.SelectedIndex = 0;
    }

    // Make a type expandable in a PropertyGrid, and not editable
    private static void MakeExpandableAndReadOnly(Type type)
    {
        TypeDescriptor.AddAttributes(type, new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(type, new ReadOnlyAttribute(true));
    }

    // Read the value of an enum combo without a nullable warning
    private static T SelectedValue<T>(ComboBox combo) where T : struct
    {
        return (T)(combo.SelectedItem ?? default(T));
    }

    // Show a complex result in a property grid, all nodes expanded
    private static void ShowInGrid(PropertyGrid grid, object value)
    {
        grid.SelectedObject = value;
        grid.ExpandAllGridItems();
    }

    #region IUserControl
    public string Title => "Mastership (RWS)";

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
        MastershipDomain[] domains = _robot.Rws.Mastership.GetDomains();
        ShowInGrid(gridGetDomains, domains);
    }

    #endregion

    #region Every domain

    private void btnGetInfo_Click(object sender, EventArgs e)
    {
        MastershipInfo[] states = _robot.Rws.Mastership.GetInfo();
        ShowInGrid(gridGetInfo, states);
    }

    private void btnRequest_Click(object sender, EventArgs e)
    {
        // Refused while somebody else holds one of the domains, and in manual mode until the operator has
        // given this client the right to act on their behalf
        _robot.Rws.Mastership.Request();
        ShowInGrid(gridGetInfo, _robot.Rws.Mastership.GetInfo());
    }

    private void btnRelease_Click(object sender, EventArgs e)
    {
        // Accepted even when this connection holds nothing
        _robot.Rws.Mastership.Release();
        ShowInGrid(gridGetInfo, _robot.Rws.Mastership.GetInfo());
    }

    #endregion

    #region One domain

    private void btnGetInfoDomain_Click(object sender, EventArgs e)
    {
        MastershipInfo state = _robot.Rws.Mastership.GetInfo(SelectedValue<MastershipDomain>(cboDomain));
        ShowInGrid(gridGetInfoDomain, state);
    }

    private void btnRequestDomain_Click(object sender, EventArgs e)
    {
        MastershipDomain domain = SelectedValue<MastershipDomain>(cboDomain);

        _robot.Rws.Mastership.Request(domain);
        ShowInGrid(gridGetInfoDomain, _robot.Rws.Mastership.GetInfo(domain));
    }

    private void btnReleaseDomain_Click(object sender, EventArgs e)
    {
        MastershipDomain domain = SelectedValue<MastershipDomain>(cboDomain);

        // A domain nobody holds is refused on a connection established with version 1, and accepted on one
        // established with version 2
        _robot.Rws.Mastership.Release(domain);
        ShowInGrid(gridGetInfoDomain, _robot.Rws.Mastership.GetInfo(domain));
    }

    #endregion
}
