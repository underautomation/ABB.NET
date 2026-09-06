using System;
using System.ComponentModel;
using System.Windows.Forms;
using UnderAutomation.ABB;
using UnderAutomation.ABB.Rws.Data;

public partial class RwsSystemControl : UserControl, IUserControl
{
    private AbbController _robot;

    public RwsSystemControl(AbbController robot)
    {
        // Complex types shown in a PropertyGrid have to be expandable and not editable
        MakeExpandableAndReadOnly(typeof(SystemInfo));
        MakeExpandableAndReadOnly(typeof(SystemProduct));
        MakeExpandableAndReadOnly(typeof(SystemProduct[]));
        MakeExpandableAndReadOnly(typeof(SystemEnergy));
        MakeExpandableAndReadOnly(typeof(SystemEnergyMechanicalUnit));
        MakeExpandableAndReadOnly(typeof(SystemEnergyMechanicalUnit[]));
        MakeExpandableAndReadOnly(typeof(SystemEnergyAxis));
        MakeExpandableAndReadOnly(typeof(SystemEnergyAxis[]));

        // the options and the robot types come back as string arrays, shown in a grid as well
        MakeExpandableAndReadOnly(typeof(string[]));

        _robot = robot;
        InitializeComponent();
    }

    // Make a type expandable in a PropertyGrid, and not editable
    private static void MakeExpandableAndReadOnly(Type type)
    {
        TypeDescriptor.AddAttributes(type, new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(type, new ReadOnlyAttribute(true));
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
    public string Title => "System (RWS)";

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


    #region System

    private void btnGetInfo_Click(object sender, EventArgs e)
    {
        // A virtual controller leaves most of the detailed version fields empty
        SystemInfo info = _robot.Rws.System.GetInfo();
        ShowInGrid(gridInfo, info);
    }

    private void btnGetOptions_Click(object sender, EventArgs e)
    {
        // The same list already comes with GetInfo, this reads it without the rest
        string[] options = _robot.Rws.System.GetOptions();
        ShowInGrid(gridOptions, options);
    }

    private void btnGetRobotTypes_Click(object sender, EventArgs e)
    {
        // Only standard ABB robots are reported, so this can legitimately come back empty
        string[] types = _robot.Rws.System.GetRobotTypes();
        ShowInGrid(gridRobotTypes, types);
    }

    private void btnGetLicense_Click(object sender, EventArgs e)
    {
        txtGetLicenseResult.Text = _robot.Rws.System.GetLicense();
    }

    #endregion

    #region Products

    private void btnGetProducts_Click(object sender, EventArgs e)
    {
        // An unknown name is rejected by the controller instead of returning an empty list
        SystemProduct[] products = _robot.Rws.System.GetProducts(Optional(txtGetProductsName));
        ShowInGrid(gridProducts, products);
    }

    #endregion

    #region Energy

    private void btnGetEnergy_Click(object sender, EventArgs e)
    {
        SystemEnergy energy = _robot.Rws.System.GetEnergy();
        ShowInGrid(gridEnergy, energy);
    }

    private void btnGetEnergyChangeCount_Click(object sender, EventArgs e)
    {
        // The counter moves when a new measurement is available, which is the cheap way to poll it
        int? changeCount = _robot.Rws.System.GetEnergyChangeCount();
        txtGetEnergyChangeCountResult.Text = changeCount.HasValue ? changeCount.Value.ToString() : string.Empty;
    }

    private void btnResetAccumulatedEnergy_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Reset the accumulated energy of the controller? The total counted so far cannot be recovered.",
                            "Reset accumulated energy", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            return;

        _robot.Rws.System.ResetAccumulatedEnergy();
        txtResetAccumulatedEnergyResult.Text = "Reset, the accumulated total starts again from now";
    }

    #endregion
}
