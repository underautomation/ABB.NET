using UnderAutomation.ABB;
using UnderAutomation.ABB.License;

public partial class ConnectControl : UserControl, IUserControl
{
    AbbController _robot;

    private static ConnectControl Instance;


    public ConnectControl(AbbController ABB)
    {
        Instance = this;

        _robot = ABB;
        InitializeComponent();

        var parameters = Config.Current.ConnectParameters ?? new ConnectionParameters();

        // Use stored information or set to default
        txtIP.Text = parameters.Address ?? "192.168.0.1";

    }


    #region IUserControl
    public bool FeatureEnabled => _robot.Enabled;

    public string Title => "Connection";

    public void OnClose() { }

    public void OnOpen() { ValidateLicense(); }

    public void PeriodicUpdate()
    {
        var connected = FeatureEnabled;
        btnDisconnect.Enabled = connected;
        btnConnect.Text = connected ? "Reconnect" : "Connect";
        lblConnected.Text = connected ? "Connected" : "Disconnected";
        lblConnected.ForeColor = connected ? Color.Green : Color.Red;

    }
    #endregion

    public void ValidateLicense()
    {
        var licenseInfo = AbbController.LicenseInfo;
        var isActiveLicense = licenseInfo.State == LicenseState.Licensed || licenseInfo.State == LicenseState.Trial || licenseInfo.State == LicenseState.ExtraTrial;

        lblLicense.Text = "License state : " + AbbController.LicenseInfo.State;
        lblLicense.ForeColor = isActiveLicense ? Color.Green : Color.Black;
    }

    private void btnConnect_Click(object sender, EventArgs e)
    {
        if (e is KeyEventArgs && ((KeyEventArgs)e).KeyCode != Keys.Enter) return;
        var parameters = new ConnectionParameters();
        parameters.Address = txtIP.Text;

        // Store information
        Config.Current.ConnectParameters = parameters;
        Config.Save();

        if (parameters.Address == "127.0.0.1" || string.Equals(parameters.Address, "localhost", StringComparison.InvariantCultureIgnoreCase) || string.Equals(parameters.Address, "loopback", StringComparison.InvariantCultureIgnoreCase))
        {
            if (MessageBox.Show("Please enter the path to your ROBOGUIDE folder instead of the localhost IP so that the SDK can read the services.txt and connect to the correct TCP ports. Go on anyway?", "Make sure you use localhost ?", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
        }

        try
        {
            // Connect to the robot
            _robot.Connect(parameters);
        }
        catch (InvalidLicenseException)
        {
            MessageBox.Show("Your licence is invalid. Please obtain a Trial Licence or enter the licence key you receive after purchasing the SDK", "License error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MainForm.Instance.SelectNode<LicenseControl>();
        }
    }

    private void btnDisconnect_Click(object sender, EventArgs e)
    {
        // Disconnect all services
        _robot.Disconnect();
    }
}
