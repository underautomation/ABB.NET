using System.Diagnostics;
using UnderAutomation.ABB;

public partial class MainForm : Form
{
    // ABB instance that handles connection to the robot
    private readonly AbbController _robot = new AbbController();

    internal static MainForm Instance;

    #region Initialisation
    public MainForm()
    {
        Instance = this;

        // Catch all unhandled exceptions
        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        Application.ThreadException += Application_ThreadException;

        Control.CheckForIllegalCrossThreadCalls = false;

        // Load configuration file
        Config.Load();

        InitializeComponent();

        // Add nodes in left menu and instanciate associated control 
        AddNode(new ConnectControl(_robot));
        AddNode(new ContactControl());
        AddNode(new LicenseControl());

        // Select first node at startup
        SelectNode(leftTreeView.Nodes[0]);
    }


    private void AddNode(IUserControl control)
    {
        var node = leftTreeView.Nodes.Add(control.Title);
        node.Tag = control;
    }
    #endregion

    #region Unhandled exception
    private void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
    {
        CatchApplicationException(e.Exception);
    }

    private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        CatchApplicationException(e.ExceptionObject as Exception);
    }

    private void CatchApplicationException(Exception e)
    {
        try
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => CatchApplicationException(e)));
                return;
            }

            Logger.Log("ApplicationException", e.ToString());

            if (MessageBox.Show($"{e?.Message}\r\n\r\nWould you like to report this error?", "An error occurred", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                SelectNode<ContactControl>()?.SetMessage($@"Hi,

I have this exception that prevents me from using the full capabilities of the SDK. Could you take a look at it and help me out?

{e}");
            }
        }
        catch { }
    }
    #endregion

    private void leftTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
        SelectNode(e.Node);
    }

    internal T SelectNode<T>() where T : class, IUserControl
    {
        var node = Instance.leftTreeView.Nodes.OfType<TreeNode>().FirstOrDefault(n => n.Tag is T);
        var control = node?.Tag as T;
        SelectNode(node);
        return control;
    }

    // Open right control associated to a node
    internal void SelectNode(TreeNode node)
    {
        if (leftTreeView.SelectedNode != node) leftTreeView.SelectedNode = node;

        if (node is null) return;

        mainPanel.SuspendLayout();

        mainPanel.Controls.OfType<IUserControl>().FirstOrDefault()?.OnClose();

        mainPanel.Controls.Clear();

        var control = node.Tag as Control;

        if (control is null)
        {
            panelTitle.Text = "";
            return;
        }

        lnkSource.Text = $"View C# page source\n{control.GetType().Name}.cs";

        panelTitle.Text = (node.Tag as IUserControl)?.Title;

        mainPanel.Controls.Add(control);

        control.Dock = DockStyle.Fill;

        mainPanel.ResumeLayout();

        try
        {
            Cursor = Cursors.WaitCursor;
            mainPanel.Controls.OfType<IUserControl>().FirstOrDefault()?.OnOpen();
            mainPanel.Controls.OfType<IUserControl>().FirstOrDefault()?.PeriodicUpdate();
        }
        finally
        {
            Cursor = Cursors.Default;
        }
    }

    // Open browser to documentation page
    private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var url = (sender as Label)?.Text;
        if (url is null) return;
        OpenUrl(url);
    }

    // Timer callback to refresh the control on the right and the left menu
    private void tmrPeriodicUpdate_Tick(object sender, EventArgs e)
    {
        try
        {
            // refresh control on the right
            mainPanel.Controls.OfType<IUserControl>().FirstOrDefault()?.PeriodicUpdate();
        }
        catch { }

        try
        {
            // Refresh left menu icons and colors
            foreach (TreeNode node in leftTreeView.Nodes)
            {
                try
                {
                    var ctrl = node?.Tag as IUserControl;
                    if (ctrl == null) continue;

                    var enabled = ctrl.FeatureEnabled;

                    var key = enabled ? "ON" : "OFF";

                    if (key != node.ImageKey)
                    {
                        node.ImageKey = key;
                        node.SelectedImageKey = key;
                        node.ForeColor = enabled ? Color.Green : Color.DarkGray;
                    }
                }
                catch { }
            }
        }
        catch { }
    }



    private void titlePictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        ScreenshotsGenerator.Generate(this);
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            _robot.Disconnect();
        }
        catch { }
    }

    internal void OpenUrl(string url)
    {
        try
        {
            var ps = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
        catch { }
    }

    private void lnkSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var name = mainPanel.Controls.OfType<IUserControl>().FirstOrDefault().GetType().Name;
        OpenUrl($"https://github.com/underautomation/ABB.NET/blob/main/UnderAutomation.ABB.Showcase.Forms/Components/{name}.cs");
    }
}