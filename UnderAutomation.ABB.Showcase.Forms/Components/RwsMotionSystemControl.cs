using System;
using System.ComponentModel;
using System.Windows.Forms;
using UnderAutomation.ABB;
using UnderAutomation.ABB.Common;
using UnderAutomation.ABB.Rws.Data;

public partial class RwsMotionSystemControl : UserControl, IUserControl
{
    private AbbController _robot;

    // The external axes of the two writes that take a full position. Neither panel exposes twelve more boxes
    // for them, so they are kept from the reading the Load button did and sent back unchanged.
    private ExternalJoints _positionTargetExternalAxes = new ExternalJoints();
    private ExternalJoints _mechanicalUnitPositionExternalAxes = new ExternalJoints();

    public RwsMotionSystemControl(AbbController robot)
    {
        _robot = robot;
        InitializeComponent();

        RegisterGridTypes();
        FillCombos();
    }

    // The property grids show these types, and an array of them, as expandable read only rows
    private static void RegisterGridTypes()
    {
        MakeExpandableAndReadOnly(typeof(MotionSystemInfo));
        MakeExpandableAndReadOnly(typeof(MotionSystemErrorState));
        MakeExpandableAndReadOnly(typeof(MechanicalUnitItem));
        MakeExpandableAndReadOnly(typeof(MechanicalUnitItem[]));
        MakeExpandableAndReadOnly(typeof(MechanicalUnitInfo));
        MakeExpandableAndReadOnly(typeof(AxisInfo));
        MakeExpandableAndReadOnly(typeof(BaseFrame));
        MakeExpandableAndReadOnly(typeof(MotionSupervision));
        MakeExpandableAndReadOnly(typeof(PathSupervision));
        MakeExpandableAndReadOnly(typeof(SmbData));
        MakeExpandableAndReadOnly(typeof(CalibrationInfo));
        MakeExpandableAndReadOnly(typeof(CalibrationJointInfo));
        MakeExpandableAndReadOnly(typeof(CalibrationJointInfo[]));
        MakeExpandableAndReadOnly(typeof(MotorCalibrationName));
        MakeExpandableAndReadOnly(typeof(MotorCalibrationName[]));
        MakeExpandableAndReadOnly(typeof(JointSolution));
        MakeExpandableAndReadOnly(typeof(JointSolution[]));

        MakeExpandableAndReadOnly(typeof(Position));
        MakeExpandableAndReadOnly(typeof(Pose));
        MakeExpandableAndReadOnly(typeof(RobTarget));
        MakeExpandableAndReadOnly(typeof(Quaternion));
        MakeExpandableAndReadOnly(typeof(RobotConfiguration));
        MakeExpandableAndReadOnly(typeof(RobotJoints));
        MakeExpandableAndReadOnly(typeof(ExternalJoints));
        MakeExpandableAndReadOnly(typeof(JointTarget));
    }

    private static void MakeExpandableAndReadOnly(Type type)
    {
        TypeDescriptor.AddAttributes(type, new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(type, new ReadOnlyAttribute(true));
    }

    // Only the values the controller accepts as a command go in the combos: the Unknown members are answers,
    // not commands
    private void FillCombos()
    {
        cboJogIncrementMode.Items.AddRange(new object[]
        {
            JogIncrementMode.None,
            JogIncrementMode.User,
            JogIncrementMode.Small,
            JogIncrementMode.Medium,
            JogIncrementMode.Large,
        });
        cboJogIncrementMode.SelectedIndex = 0;

        cboSetMechanicalUnitMode.Items.AddRange(new object[]
        {
            MechanicalUnitMode.Activated,
            MechanicalUnitMode.Deactivated,
        });
        cboSetMechanicalUnitMode.SelectedIndex = 0;

        cboSetMechanicalUnitJogMode.Items.AddRange(new object[]
        {
            JogMode.AxisGroup1,
            JogMode.AxisGroup2,
            JogMode.Cartesian,
            JogMode.Align,
            JogMode.GoToPosition,
            JogMode.ConfigurationJog,
        });
        cboSetMechanicalUnitJogMode.SelectedIndex = 0;

        FillCoordinateSystems(cboSetMechanicalUnitCoordinateSystem);
        FillCoordinateSystems(cboGetRobTargetCoordinateSystem);
        FillCoordinateSystems(cboGetCartesianPositionCoordinateSystem);

        cboSetSmbDataDirection.Items.AddRange(new object[]
        {
            SmbDataTransfer.RobotToController,
            SmbDataTransfer.ControllerToRobot,
        });
        cboSetSmbDataDirection.SelectedIndex = 0;

        cboClearSmbDataMemory.Items.AddRange(new object[]
        {
            SmbDataMemory.Robot,
            SmbDataMemory.Controller,
        });
        cboClearSmbDataMemory.SelectedIndex = 0;
    }

    private static void FillCoordinateSystems(ComboBox combo)
    {
        combo.Items.AddRange(new object[]
        {
            CoordinateSystem.Base,
            CoordinateSystem.World,
            CoordinateSystem.Tool,
            CoordinateSystem.WorkObject,
        });
        combo.SelectedIndex = 0;
    }

    #region IUserControl
    public string Title => "Motion System (RWS)";

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

    #region Helpers

    // Read the value of an enum combo without a nullable warning
    private static T SelectedValue<T>(ComboBox combo) where T : struct
    {
        return (T)(combo.SelectedItem ?? default(T));
    }

    // An empty box means "let the controller use what the mechanical unit already has"
    private static string? Optional(TextBox box)
    {
        return string.IsNullOrEmpty(box.Text) ? null : box.Text;
    }

    private static void Show(PropertyGrid grid, object value)
    {
        grid.SelectedObject = value;
        grid.ExpandAllGridItems();
    }

    private static Pose ReadPose(NumericUpDown x, NumericUpDown y, NumericUpDown z,
                                 NumericUpDown q1, NumericUpDown q2, NumericUpDown q3, NumericUpDown q4)
    {
        return new Pose((double)x.Value, (double)y.Value, (double)z.Value,
                        (double)q1.Value, (double)q2.Value, (double)q3.Value, (double)q4.Value);
    }

    private static void WritePose(Pose pose, NumericUpDown x, NumericUpDown y, NumericUpDown z,
                                  NumericUpDown q1, NumericUpDown q2, NumericUpDown q3, NumericUpDown q4)
    {
        x.Value = Clamp(x, pose.X);
        y.Value = Clamp(y, pose.Y);
        z.Value = Clamp(z, pose.Z);
        q1.Value = Clamp(q1, pose.Orientation.Q1);
        q2.Value = Clamp(q2, pose.Orientation.Q2);
        q3.Value = Clamp(q3, pose.Orientation.Q3);
        q4.Value = Clamp(q4, pose.Orientation.Q4);
    }

    private static RobotJoints ReadJoints(NumericUpDown a1, NumericUpDown a2, NumericUpDown a3,
                                          NumericUpDown a4, NumericUpDown a5, NumericUpDown a6)
    {
        return new RobotJoints((double)a1.Value, (double)a2.Value, (double)a3.Value,
                               (double)a4.Value, (double)a5.Value, (double)a6.Value);
    }

    private static void WriteJoints(RobotJoints joints, NumericUpDown a1, NumericUpDown a2, NumericUpDown a3,
                                    NumericUpDown a4, NumericUpDown a5, NumericUpDown a6)
    {
        a1.Value = Clamp(a1, joints.Axis1);
        a2.Value = Clamp(a2, joints.Axis2);
        a3.Value = Clamp(a3, joints.Axis3);
        a4.Value = Clamp(a4, joints.Axis4);
        a5.Value = Clamp(a5, joints.Axis5);
        a6.Value = Clamp(a6, joints.Axis6);
    }

    // An unused external axis comes back as 9E9, which is past what the box accepts
    private static decimal Clamp(NumericUpDown box, double value)
    {
        var rounded = Math.Round(value, box.DecimalPlaces);

        if (rounded < (double)box.Minimum) return box.Minimum;
        if (rounded > (double)box.Maximum) return box.Maximum;

        return (decimal)rounded;
    }

    #endregion

    #region Motion system

    private void btnGetInfo_Click(object sender, EventArgs e)
    {
        var info = _robot.Rws.MotionSystem.GetInfo();
        Show(gridInfo, info);

        // the change count of the jogging commands and of the change check comes from here
        numJogChangeCount.Value = info.ChangeCount ?? 0;
        numHasChangedChangeCount.Value = info.ChangeCount ?? 0;
    }

    private void btnHasChanged_Click(object sender, EventArgs e)
    {
        chkHasChangedResult.Checked = _robot.Rws.MotionSystem.HasChanged((int)numHasChangedChangeCount.Value);
    }

    private void btnGetErrorState_Click(object sender, EventArgs e)
    {
        Show(gridErrorState, _robot.Rws.MotionSystem.GetErrorState());
    }

    private void btnGetNonMotionExecutionMode_Click(object sender, EventArgs e)
    {
        chkNonMotionExecutionMode.Checked = _robot.Rws.MotionSystem.GetNonMotionExecutionMode();
    }

    private void btnSetNonMotionExecutionMode_Click(object sender, EventArgs e)
    {
        // Needs mastership of the motion domain
        _robot.Rws.MotionSystem.SetNonMotionExecutionMode(chkNonMotionExecutionMode.Checked);
        chkNonMotionExecutionMode.Checked = _robot.Rws.MotionSystem.GetNonMotionExecutionMode();
    }

    private void btnGetCollisionPredictionMode_Click(object sender, EventArgs e)
    {
        chkCollisionPredictionMode.Checked = _robot.Rws.MotionSystem.GetCollisionPredictionMode();
    }

    private void btnSetCollisionPredictionMode_Click(object sender, EventArgs e)
    {
        // Refused with an explicit message on a system built without the collision prediction option
        _robot.Rws.MotionSystem.SetCollisionPredictionMode(chkCollisionPredictionMode.Checked);
        chkCollisionPredictionMode.Checked = _robot.Rws.MotionSystem.GetCollisionPredictionMode();
    }

    private void btnSetJoggingMechanicalUnit_Click(object sender, EventArgs e)
    {
        _robot.Rws.MotionSystem.SetJoggingMechanicalUnit(txtSetJoggingMechanicalUnitMechanicalUnit.Text);
        Show(gridInfo, _robot.Rws.MotionSystem.GetInfo());
    }

    private void btnJog_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Jog the selected mechanical unit? The robot moves.",
                            "Jog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            return;

        var axes = ReadJoints(numJogAxis1, numJogAxis2, numJogAxis3, numJogAxis4, numJogAxis5, numJogAxis6);

        _robot.Rws.MotionSystem.Jog(axes, (int)numJogChangeCount.Value,
                                    SelectedValue<JogIncrementMode>(cboJogIncrementMode));
    }

    private void btnLoadPositionTarget_Click(object sender, EventArgs e)
    {
        var target = _robot.Rws.MotionSystem.GetRobTarget(txtPositionTargetMechanicalUnit.Text);

        WritePose(target, numPositionTargetX, numPositionTargetY, numPositionTargetZ,
                  numPositionTargetQ1, numPositionTargetQ2, numPositionTargetQ3, numPositionTargetQ4);

        numPositionTargetQuarter1.Value = target.Configuration.Quarter1;
        numPositionTargetQuarter4.Value = target.Configuration.Quarter4;
        numPositionTargetQuarter6.Value = target.Configuration.Quarter6;
        numPositionTargetQuarterX.Value = target.Configuration.QuarterX;

        _positionTargetExternalAxes = target.ExternalAxes ?? new ExternalJoints();
    }

    private void btnSetPositionTarget_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Send the robot to that target? The robot moves.",
                            "Set position target", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            return;

        var pose = ReadPose(numPositionTargetX, numPositionTargetY, numPositionTargetZ,
                            numPositionTargetQ1, numPositionTargetQ2, numPositionTargetQ3, numPositionTargetQ4);

        var configuration = new RobotConfiguration((int)numPositionTargetQuarter1.Value,
                                                   (int)numPositionTargetQuarter4.Value,
                                                   (int)numPositionTargetQuarter6.Value,
                                                   (int)numPositionTargetQuarterX.Value);

        _robot.Rws.MotionSystem.SetPositionTarget(
            new RobTarget(pose.X, pose.Y, pose.Z, pose.Orientation, configuration, _positionTargetExternalAxes));
    }

    #endregion

    #region Mechanical units

    private void btnGetMechanicalUnits_Click(object sender, EventArgs e)
    {
        Show(gridMechanicalUnits, _robot.Rws.MotionSystem.GetMechanicalUnits());
    }

    private void btnGetMechanicalUnit_Click(object sender, EventArgs e)
    {
        Show(gridMechanicalUnit, _robot.Rws.MotionSystem.GetMechanicalUnit(txtGetMechanicalUnitMechanicalUnit.Text));
    }

    private void btnSetMechanicalUnit_Click(object sender, EventArgs e)
    {
        // Needs mastership of the motion domain. Only the boxes that are filled in are sent.
        _robot.Rws.MotionSystem.SetMechanicalUnit(
            txtSetMechanicalUnitMechanicalUnit.Text,
            Optional(txtSetMechanicalUnitTool),
            Optional(txtSetMechanicalUnitWorkObject),
            Optional(txtSetMechanicalUnitPayload),
            Optional(txtSetMechanicalUnitTotalPayload),
            SelectedValue<MechanicalUnitMode>(cboSetMechanicalUnitMode),
            SelectedValue<JogMode>(cboSetMechanicalUnitJogMode),
            SelectedValue<CoordinateSystem>(cboSetMechanicalUnitCoordinateSystem));

        Show(gridMechanicalUnit, _robot.Rws.MotionSystem.GetMechanicalUnit(txtSetMechanicalUnitMechanicalUnit.Text));
    }

    private void btnGetAxisCount_Click(object sender, EventArgs e)
    {
        txtAxisCount.Text = _robot.Rws.MotionSystem.GetAxisCount(txtGetAxisCountMechanicalUnit.Text).ToString();
    }

    private void btnGetAxis_Click(object sender, EventArgs e)
    {
        Show(gridAxis, _robot.Rws.MotionSystem.GetAxis(txtGetAxisMechanicalUnit.Text, (int)numGetAxisAxis.Value));
    }

    private void btnGetAxisPose_Click(object sender, EventArgs e)
    {
        var pose = _robot.Rws.MotionSystem.GetAxisPose(txtAxisPoseMechanicalUnit.Text, (int)numAxisPoseAxis.Value);

        WritePose(pose, numAxisPoseX, numAxisPoseY, numAxisPoseZ,
                  numAxisPoseQ1, numAxisPoseQ2, numAxisPoseQ3, numAxisPoseQ4);
    }

    private void btnSetAxisPose_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Declare that pose for the axis? This changes the calibration of the robot.",
                            "Set axis pose", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            return;

        var pose = ReadPose(numAxisPoseX, numAxisPoseY, numAxisPoseZ,
                            numAxisPoseQ1, numAxisPoseQ2, numAxisPoseQ3, numAxisPoseQ4);

        _robot.Rws.MotionSystem.SetAxisPose(txtAxisPoseMechanicalUnit.Text, (int)numAxisPoseAxis.Value, pose);
    }

    private void btnGetBaseFrame_Click(object sender, EventArgs e)
    {
        var frame = _robot.Rws.MotionSystem.GetBaseFrame(txtBaseFrameMechanicalUnit.Text);

        txtBaseFrameType.Text = frame.Type;
        WritePose(frame, numBaseFrameX, numBaseFrameY, numBaseFrameZ,
                  numBaseFrameQ1, numBaseFrameQ2, numBaseFrameQ3, numBaseFrameQ4);
    }

    private void btnSetBaseFrame_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Declare that base frame? This changes the calibration of the robot.",
                            "Set base frame", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            return;

        var frame = ReadPose(numBaseFrameX, numBaseFrameY, numBaseFrameZ,
                             numBaseFrameQ1, numBaseFrameQ2, numBaseFrameQ3, numBaseFrameQ4);

        _robot.Rws.MotionSystem.SetBaseFrame(txtBaseFrameMechanicalUnit.Text, frame);
    }

    private void btnGetLeadThrough_Click(object sender, EventArgs e)
    {
        var status = _robot.Rws.MotionSystem.GetLeadThrough(txtLeadThroughMechanicalUnit.Text);

        txtLeadThroughStatus.Text = status.ToString();
        chkSetLeadThroughActive.Checked = status == LeadThroughStatus.Active;
    }

    private void btnSetLeadThrough_Click(object sender, EventArgs e)
    {
        // Switching it on needs the motors on and the option installed
        _robot.Rws.MotionSystem.SetLeadThrough(txtLeadThroughMechanicalUnit.Text, chkSetLeadThroughActive.Checked);
        txtLeadThroughStatus.Text = _robot.Rws.MotionSystem.GetLeadThrough(txtLeadThroughMechanicalUnit.Text).ToString();
    }

    #endregion

    #region Positions

    private void btnGetRobTarget_Click(object sender, EventArgs e)
    {
        Show(gridRobTarget, _robot.Rws.MotionSystem.GetRobTarget(
            txtGetRobTargetMechanicalUnit.Text,
            SelectedValue<CoordinateSystem>(cboGetRobTargetCoordinateSystem),
            Optional(txtGetRobTargetTool),
            Optional(txtGetRobTargetWorkObject)));
    }

    private void btnGetCartesianPosition_Click(object sender, EventArgs e)
    {
        // this reading leaves the external axes out, which is why it has a panel of its own
        Show(gridCartesian, _robot.Rws.MotionSystem.GetCartesianPosition(
            txtGetCartesianPositionMechanicalUnit.Text,
            SelectedValue<CoordinateSystem>(cboGetCartesianPositionCoordinateSystem),
            Optional(txtGetCartesianPositionTool),
            Optional(txtGetCartesianPositionWorkObject),
            chkGetCartesianPositionLogErrors.Checked));
    }

    private void btnGetJointTarget_Click(object sender, EventArgs e)
    {
        Show(gridJointTarget, _robot.Rws.MotionSystem.GetJointTarget(
            txtGetJointTargetMechanicalUnit.Text, chkGetJointTargetAlwaysRead.Checked));
    }

    private void btnGetPhysicalJoints_Click(object sender, EventArgs e)
    {
        Show(gridPhysicalJoints, _robot.Rws.MotionSystem.GetPhysicalJoints(txtGetPhysicalJointsMechanicalUnit.Text));
    }

    private void btnLoadMechanicalUnitPosition_Click(object sender, EventArgs e)
    {
        var joints = _robot.Rws.MotionSystem.GetJointTarget(txtSetMechanicalUnitPositionMechanicalUnit.Text);

        WriteJoints(joints.RobotAxes,
                    numMechanicalUnitPositionAxis1, numMechanicalUnitPositionAxis2, numMechanicalUnitPositionAxis3,
                    numMechanicalUnitPositionAxis4, numMechanicalUnitPositionAxis5, numMechanicalUnitPositionAxis6);

        _mechanicalUnitPositionExternalAxes = joints.ExternalAxes ?? new ExternalJoints();
    }

    private void btnSetMechanicalUnitPosition_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Place the mechanical unit at those joint values? Only a virtual controller accepts this.",
                            "Set mechanical unit position", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            return;

        var axes = ReadJoints(numMechanicalUnitPositionAxis1, numMechanicalUnitPositionAxis2, numMechanicalUnitPositionAxis3,
                              numMechanicalUnitPositionAxis4, numMechanicalUnitPositionAxis5, numMechanicalUnitPositionAxis6);

        _robot.Rws.MotionSystem.SetMechanicalUnitPosition(
            txtSetMechanicalUnitPositionMechanicalUnit.Text,
            new JointTarget(axes, _mechanicalUnitPositionExternalAxes));
    }

    #endregion

    #region Supervision

    private void btnGetMotionSupervision_Click(object sender, EventArgs e)
    {
        var supervision = _robot.Rws.MotionSystem.GetMotionSupervision(txtMotionSupervisionMechanicalUnit.Text);

        chkMotionSupervisionEnabled.Checked = supervision.Enabled == true;
        if (supervision.Level.HasValue)
            numMotionSupervisionLevel.Value = supervision.Level.Value;
    }

    private void btnSetMotionSupervisionMode_Click(object sender, EventArgs e)
    {
        // Needs mastership of the motion domain
        _robot.Rws.MotionSystem.SetMotionSupervisionMode(txtMotionSupervisionMechanicalUnit.Text,
                                                         chkMotionSupervisionEnabled.Checked);
    }

    private void btnSetMotionSupervisionLevel_Click(object sender, EventArgs e)
    {
        _robot.Rws.MotionSystem.SetMotionSupervisionLevel(txtMotionSupervisionMechanicalUnit.Text,
                                                          (int)numMotionSupervisionLevel.Value);
    }

    private void btnGetPathSupervision_Click(object sender, EventArgs e)
    {
        var supervision = _robot.Rws.MotionSystem.GetPathSupervision(txtPathSupervisionMechanicalUnit.Text);

        chkPathSupervisionEnabled.Checked = supervision.Enabled == true;
        if (supervision.Level.HasValue)
            numPathSupervisionLevel.Value = supervision.Level.Value;
    }

    private void btnSetPathSupervisionMode_Click(object sender, EventArgs e)
    {
        _robot.Rws.MotionSystem.SetPathSupervisionMode(txtPathSupervisionMechanicalUnit.Text,
                                                       chkPathSupervisionEnabled.Checked);
    }

    private void btnSetPathSupervisionLevel_Click(object sender, EventArgs e)
    {
        _robot.Rws.MotionSystem.SetPathSupervisionLevel(txtPathSupervisionMechanicalUnit.Text,
                                                        (int)numPathSupervisionLevel.Value);
    }

    #endregion

    #region Calibration

    private void btnGetCalibrationInfo_Click(object sender, EventArgs e)
    {
        Show(gridCalibrationInfo, _robot.Rws.MotionSystem.GetCalibrationInfo(txtGetCalibrationInfoMechanicalUnit.Text));
    }

    private void btnGetMotorCalibrationNames_Click(object sender, EventArgs e)
    {
        Show(gridMotorCalibration, _robot.Rws.MotionSystem.GetMotorCalibrationNames(txtGetMotorCalibrationNamesMechanicalUnit.Text));
    }

    private void btnGetSmbData_Click(object sender, EventArgs e)
    {
        Show(gridSmbData, _robot.Rws.MotionSystem.GetSmbData(txtSmbDataMechanicalUnit.Text));
    }

    private void btnSetSmbData_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Copy one measurement board store over the other? The overwritten copy is gone.",
                            "Set SMB data", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            return;

        _robot.Rws.MotionSystem.SetSmbData(txtSmbDataMechanicalUnit.Text,
                                           SelectedValue<SmbDataTransfer>(cboSetSmbDataDirection));

        Show(gridSmbData, _robot.Rws.MotionSystem.GetSmbData(txtSmbDataMechanicalUnit.Text));
    }

    private void btnClearSmbData_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Erase that measurement board store? It holds the calibration of the robot and cannot be recovered.",
                            "Clear SMB data", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            return;

        _robot.Rws.MotionSystem.ClearSmbData(txtSmbDataMechanicalUnit.Text,
                                             SelectedValue<SmbDataMemory>(cboClearSmbDataMemory));

        Show(gridSmbData, _robot.Rws.MotionSystem.GetSmbData(txtSmbDataMechanicalUnit.Text));
    }

    private void btnFineCalibrate_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Calibrate the axis where it currently stands? This replaces its calibration.",
                            "Fine calibrate", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            return;

        _robot.Rws.MotionSystem.FineCalibrate(txtFineCalibrateMechanicalUnit.Text, (int)numFineCalibrateAxis.Value);
    }

    private void btnUpdateRevolutionCounter_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Update the revolution counter? The axis has to be standing at its synchronization mark.",
                            "Update revolution counter", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            return;

        _robot.Rws.MotionSystem.UpdateRevolutionCounter(txtRevolutionCounterMechanicalUnit.Text,
                                                        (int)numRevolutionCounterAxis.Value);
    }

    private void btnSynchronizeAxisRevolutionCounter_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Synchronize the revolution counter? The axis has to be standing at its synchronization mark.",
                            "Synchronize revolution counter", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            return;

        _robot.Rws.MotionSystem.SynchronizeAxisRevolutionCounter(txtRevolutionCounterMechanicalUnit.Text,
                                                                 (int)numRevolutionCounterAxis.Value);
    }

    private void btnCommutate_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Commutate the motor of that axis? This is only needed after the motor was replaced.",
                            "Commutate", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            return;

        _robot.Rws.MotionSystem.Commutate(txtCommutateMechanicalUnit.Text, (int)numCommutateAxis.Value);
    }

    #endregion

    #region Kinematics

    // The three calculations below work in metres and radians, unlike every reading of the other tabs,
    // which the controller answers in millimetres and degrees.

    private void btnGetPoseFromJoints_Click(object sender, EventArgs e)
    {
        var axes = ReadJoints(numGetPoseFromJointsAxis1, numGetPoseFromJointsAxis2, numGetPoseFromJointsAxis3,
                              numGetPoseFromJointsAxis4, numGetPoseFromJointsAxis5, numGetPoseFromJointsAxis6);

        var pose = _robot.Rws.MotionSystem.GetPoseFromJoints(
            txtGetPoseFromJointsMechanicalUnit.Text,
            IdentityToolFrame(),
            new JointTarget(axes, new ExternalJoints()),
            chkGetPoseFromJointsRobotHoldsWorkObject.Checked);

        Show(gridPoseFromJoints, pose);

        // the answer of this calculation is the input of the two other ones
        WritePose(pose, numGetJointsFromPoseX, numGetJointsFromPoseY, numGetJointsFromPoseZ,
                  numGetJointsFromPoseQ1, numGetJointsFromPoseQ2, numGetJointsFromPoseQ3, numGetJointsFromPoseQ4);
        WritePose(pose, numGetAllJointSolutionsX, numGetAllJointSolutionsY, numGetAllJointSolutionsZ,
                  numGetAllJointSolutionsQ1, numGetAllJointSolutionsQ2, numGetAllJointSolutionsQ3, numGetAllJointSolutionsQ4);
    }

    private void btnGetJointsFromPose_Click(object sender, EventArgs e)
    {
        Show(gridJointsFromPose, _robot.Rws.MotionSystem.GetJointsFromPose(
            txtGetJointsFromPoseMechanicalUnit.Text,
            JointsFromPoseTarget(),
            new ExternalJoints(),
            IdentityToolFrame(),
            new JointTarget(),
            new RobotConfiguration()));
    }

    private void btnGetJointsFromCartesian_Click(object sender, EventArgs e)
    {
        // the controller computes this one differently and does not always return the same solution
        Show(gridJointsFromPose, _robot.Rws.MotionSystem.GetJointsFromCartesian(
            txtGetJointsFromPoseMechanicalUnit.Text,
            JointsFromPoseTarget(),
            new ExternalJoints(),
            IdentityToolFrame(),
            new JointTarget(),
            new RobotConfiguration()));
    }

    private void btnGetAllJointSolutions_Click(object sender, EventArgs e)
    {
        var pose = ReadPose(numGetAllJointSolutionsX, numGetAllJointSolutionsY, numGetAllJointSolutionsZ,
                            numGetAllJointSolutionsQ1, numGetAllJointSolutionsQ2,
                            numGetAllJointSolutionsQ3, numGetAllJointSolutionsQ4);

        Show(gridAllJointSolutions, _robot.Rws.MotionSystem.GetAllJointSolutions(
            txtGetAllJointSolutionsMechanicalUnit.Text,
            pose,
            new ExternalJoints(),
            IdentityToolFrame(),
            new RobotConfiguration()));
    }

    private Pose JointsFromPoseTarget()
    {
        return ReadPose(numGetJointsFromPoseX, numGetJointsFromPoseY, numGetJointsFromPoseZ,
                        numGetJointsFromPoseQ1, numGetJointsFromPoseQ2, numGetJointsFromPoseQ3, numGetJointsFromPoseQ4);
    }

    // No offset and no rotation, so the answers are about the mounting flange itself
    private static Pose IdentityToolFrame()
    {
        return new Pose(0, 0, 0, 1, 0, 0, 0);
    }

    #endregion
}
