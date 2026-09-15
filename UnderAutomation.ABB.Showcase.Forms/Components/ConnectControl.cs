using UnderAutomation.ABB;
using UnderAutomation.ABB.Discovery;
using UnderAutomation.ABB.License;
using UnderAutomation.ABB.Rws;
using System.Linq;

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
        cbDiscovered.Text = parameters.Address ?? "192.168.0.1";

        cbVersion.Items.AddRange(Enum.GetValues(typeof(RwsVersion)).OfType<object>().ToArray());

        // RWS parameters
        var rws = parameters.Rws ?? new RwsConnectParameters();
        chkRws.Checked = rws.Enable;
        txtRws2User.Text = rws.Username;
        txtRws2Password.Text = rws.Password;
        udRws2Port.Value = rws.Port;
        chkRws2Https.Checked = rws.UseHttps;
        cbVersion.SelectedItem = rws.Version;
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
        parameters.Address = cbDiscovered.Text;

        // RWS2 parameters
        parameters.Rws = new RwsConnectParameters
        {
            Enable = chkRws.Checked,
            Username = txtRws2User.Text,
            Password = txtRws2Password.Text,
            Port = (int)udRws2Port.Value,
            UseHttps = chkRws2Https.Checked,
            Version = (RwsVersion)cbVersion.SelectedItem
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

    #region Scan

    private bool _scanning;

    private async void btnScan_Click(object sender, EventArgs e)
    {
        if (_scanning) return;

        _scanning = true;
        btnScan.Enabled = false;
        btnScan.Text = "Scanning...";
        lblScanResult.Text = "Looking for robots...";
        lblScanResult.ForeColor = SystemColors.ControlText;
        cbDiscovered.Items.Clear();

        try
        {
            // Finds the robots of the local network and the virtual controllers of this machine.
            // No connection is opened and no license is needed.
            var found = await AbbController.DiscoverAsync();

            cbDiscovered.Items.AddRange(found.Cast<object>().ToArray());

            if (found.Length == 0)
            {
                lblScanResult.Text = "No robot answered. Enter the address below.";
            }
            else
            {
                lblScanResult.Text = found.Length == 1 ? "1 robot found" : found.Length + " robots found";
            }

            cbDiscovered.DroppedDown = true;
        }
        catch (Exception ex)
        {
            lblScanResult.Text = "The scan failed : " + ex.Message;
            lblScanResult.ForeColor = Color.Red;
        }
        finally
        {
            btnScan.Text = "Scan for robots";
            btnScan.Enabled = true;
            _scanning = false;
        }
    }

    private void cbDiscovered_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbDiscovered.SelectedItem is not DiscoveredController controller) return;

        // Everything the scan knows goes to the connection fields. The user name and the password are
        // not discovered, so they are left as they are.
        udRws2Port.Value = controller.Port;
        chkRws2Https.Checked = controller.UseHttps;
        cbVersion.SelectedItem = controller.ProbableVersion;
        chkRws.Checked = true;

        lblScanResult.Text = Describe(controller);
        lblScanResult.ForeColor = controller.IsVersionDetected ? SystemColors.ControlText : Color.DarkOrange;
    }

    private static string Describe(DiscoveredController controller)
    {
        var text = controller.UseHttps ? "HTTPS" : "HTTP";
        text += controller.ProbableVersion == RwsVersion.OmniCore_V2_0 ? ", RWS 2.0" : ", RWS 1.0";

        if (!controller.IsVersionDetected) text += " (guessed)";
        if (!string.IsNullOrEmpty(controller.RobotWareVersion)) text += ", RobotWare " + controller.RobotWareVersion;
        if (!string.IsNullOrEmpty(controller.SystemId)) text += ", " + controller.SystemId;

        return text;
    }

    #endregion
}
