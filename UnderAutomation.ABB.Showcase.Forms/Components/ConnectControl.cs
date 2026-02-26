using UnderAutomation.ABB;
using UnderAutomation.ABB.License;
using UnderAutomation.ABB.Rws;

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

        // RWS parameters
        var rws = parameters.Rws ?? new RwsConnectParameters();
        chkRws.Checked = rws.Enable;
        txtRws2User.Text = rws.Username;
        txtRws2Password.Text = rws.Password;
        udRws2Port.Value = rws.Port;
        chkRws2Https.Checked = rws.UseHttps;
        cbVersion.SelectedItem = rws.Version.ToString();
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

        // RWS2 parameters
        parameters.Rws = new RwsConnectParameters
        {
            Enable = chkRws.Checked,
            Username = txtRws2User.Text,
            Password = txtRws2Password.Text,
            Port = (int)udRws2Port.Value,
            UseHttps = chkRws2Https.Checked,
            Version = (int)cbVersion.SelectedItem
        };

        // Store information
        Config.Current.ConnectParameters = parameters;
        Config.Save();

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
