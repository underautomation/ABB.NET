using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using UnderAutomation.ABB;
using UnderAutomation.ABB.Rws.Data;

public partial class RwsRapidControl : UserControl, IUserControl
{
    private AbbController _robot;

    public RwsRapidControl(AbbController robot)
    {
        _robot = robot;
        InitializeComponent();
    }

    #region IUserControl
    public string Title => "RAPID (RWS)";

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


}
