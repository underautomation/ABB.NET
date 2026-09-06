using System;
using System.Windows.Forms;
using UnderAutomation.ABB;
using UnderAutomation.ABB.Rws.Data;

public partial class RwsPanelControl : UserControl, IUserControl
{
    private AbbController _robot;

    public RwsPanelControl(AbbController robot)
    {
        _robot = robot;
        InitializeComponent();

        // Only the values the controller accepts as a command go in the combos: every other state is
        // one the controller reaches on its own and answers with
        cboSetControllerStateState.Items.AddRange(new object[]
        {
            ControllerState.MotorsOn,
            ControllerState.MotorsOff,
        });
        cboSetControllerStateState.SelectedIndex = 0;

        cboAcknowledgeOperationModeAcknowledgement.Items.AddRange(new object[]
        {
            OperationModeAcknowledgement.Automatic,
            OperationModeAcknowledgement.ManualFullSpeed,
            OperationModeAcknowledgement.CollisionDetection,
        });
        cboAcknowledgeOperationModeAcknowledgement.SelectedIndex = 0;

        // The control panel accepts these four restart modes, the two others belong to the controller service
        cboRestartMode.Items.AddRange(new object[]
        {
            ControllerRestartMode.Restart,
            ControllerRestartMode.IStart,
            ControllerRestartMode.PStart,
            ControllerRestartMode.BStart,
        });
        cboRestartMode.SelectedIndex = 0;
    }

    // Read the value of an enum combo without a nullable warning
    private static T SelectedValue<T>(ComboBox combo) where T : struct
    {
        return (T)(combo.SelectedItem ?? default(T));
    }

    #region IUserControl
    public string Title => "Panel (RWS)";

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


    #region Controller state

    private void btnGetControllerState_Click(object sender, EventArgs e)
    {
        ControllerState state = _robot.Rws.Panel.GetControllerState();
        txtControllerState.Text = state.ToString();
    }

    private void btnSetControllerState_Click(object sender, EventArgs e)
    {
        // The documentation asks for a local client on a controller in manual mode, a virtual controller
        // accepts the change in automatic mode as well
        _robot.Rws.Panel.SetControllerState(SelectedValue<ControllerState>(cboSetControllerStateState));

        // the controller answers before the state has settled, so this is the requested one, not the reached one
        txtControllerState.Text = _robot.Rws.Panel.GetControllerState().ToString();
    }

    private void btnGetSpeedRatio_Click(object sender, EventArgs e)
    {
        numSpeedRatio.Value = _robot.Rws.Panel.GetSpeedRatio();
    }

    private void btnSetSpeedRatio_Click(object sender, EventArgs e)
    {
        // Only accepted while the controller runs in automatic mode
        _robot.Rws.Panel.SetSpeedRatio((int)numSpeedRatio.Value, chkSetSpeedRatioUseImplicitMastership.Checked);
    }

    private void btnGetCollisionDetectionState_Click(object sender, EventArgs e)
    {
        CollisionDetectionState state = _robot.Rws.Panel.GetCollisionDetectionState();
        txtCollisionDetectionState.Text = state.ToString();
    }

    #endregion

    #region Operating mode

    private void btnGetOperationMode_Click(object sender, EventArgs e)
    {
        OperationMode mode = _robot.Rws.Panel.GetOperationMode();
        txtOperationMode.Text = mode.ToString();
    }

    private void btnAcknowledgeOperationMode_Click(object sender, EventArgs e)
    {
        // Refused when no mode change is waiting to be confirmed, which is the case on a controller
        // that has no physical mode selector
        _robot.Rws.Panel.AcknowledgeOperationMode(SelectedValue<OperationModeAcknowledgement>(cboAcknowledgeOperationModeAcknowledgement));
        txtOperationMode.Text = _robot.Rws.Panel.GetOperationMode().ToString();
    }

    private void btnGetOperationModeLockState_Click(object sender, EventArgs e)
    {
        // A controller whose mode selector cannot be locked refuses this instead of answering unlocked
        OperationModeLockState lockState = _robot.Rws.Panel.GetOperationModeLockState();
        txtOperationModeLockState.Text = lockState.ToString();
    }

    private void btnLockOperationMode_Click(object sender, EventArgs e)
    {
        if (chkLockOperationModePermanent.Checked &&
            MessageBox.Show("Lock the operating mode selector permanently? A permanent lock cannot be released through this interface.",
                            "Lock operating mode", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            return;

        _robot.Rws.Panel.LockOperationMode(txtOperationModePin.Text, chkLockOperationModePermanent.Checked);
        txtOperationModeLockState.Text = _robot.Rws.Panel.GetOperationModeLockState().ToString();
    }

    private void btnUnlockOperationMode_Click(object sender, EventArgs e)
    {
        // The pin has to be the one the selector was locked with
        _robot.Rws.Panel.UnlockOperationMode(txtOperationModePin.Text);
        txtOperationModeLockState.Text = _robot.Rws.Panel.GetOperationModeLockState().ToString();
    }

    #endregion

    #region Controller

    private void btnSetLanguage_Click(object sender, EventArgs e)
    {
        // The panel exposes no way to read the language back
        _robot.Rws.Panel.SetLanguage(txtSetLanguageLanguageCode.Text);
    }

    private void btnRestart_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Restart the controller? The connection is lost until it has started again.",
                            "Restart controller", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            return;

        _robot.Rws.Panel.Restart(SelectedValue<ControllerRestartMode>(cboRestartMode), chkRestartUseImplicitMastership.Checked);
    }

    #endregion
}
