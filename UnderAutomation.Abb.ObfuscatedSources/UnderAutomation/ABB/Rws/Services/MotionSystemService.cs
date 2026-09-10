//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.ABB.Rws.Data;
using System.Threading;
using System.Threading.Tasks;
using System;
using UnderAutomation.ABB.Common;

namespace UnderAutomation.ABB.Rws.Services {
	/// <summary>
	/// Motion System Service - Everything about how the robot stands and how it moves: the mechanical units of
	/// the system and their axes, where the tool currently is, the calibration and the revolution counters,
	/// jogging, the collision supervision, and the kinematics calculations that convert a pose into joint values
	/// and back.
	/// 
	/// <p>None of these resources is available while the controller runs in bootserver mode.</p>
	/// </summary>
	public class MotionSystemService {

		/// <summary>
		/// Gets how each joint of a mechanical unit was calibrated (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <returns>Calibration of the unit, with one entry per joint slot</returns>
		public CalibrationInfo GetCalibrationInfo(string mechanicalUnit)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets how each joint of a mechanical unit was calibrated (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Calibration of the unit, with one entry per joint slot</returns>
		public Task<CalibrationInfo> GetCalibrationInfoAsync(string mechanicalUnit, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the name each joint of a mechanical unit carries, and the name of its calibration data (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <returns>One entry per joint of the unit</returns>
		public MotorCalibrationName[] GetMotorCalibrationNames(string mechanicalUnit)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the name each joint of a mechanical unit carries, and the name of its calibration data (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>One entry per joint of the unit</returns>
		public Task<MotorCalibrationName[]> GetMotorCalibrationNamesAsync(string mechanicalUnit, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the serial measurement board data of a mechanical unit, as held by the controller cabinet and by
		/// the robot itself (synchronous)
		/// 
		/// <p>The two copies are meant to agree. When they do not, one of them is written over the other with
		/// <xref href="UnderAutomation.ABB.Rws.Services.MotionSystemService.SetSmbData(System.String%2cUnderAutomation.ABB.Rws.Data.SmbDataTransfer)" data-throw-if-not-resolved="false"></xref>.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <returns>Both copies of the measurement board data</returns>
		public SmbData GetSmbData(string mechanicalUnit)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the serial measurement board data of a mechanical unit, as held by the controller cabinet and by
		/// the robot itself (asynchronous)
		/// 
		/// <p>The two copies are meant to agree. When they do not, one of them is written over the other with
		/// <xref href="UnderAutomation.ABB.Rws.Services.MotionSystemService.SetSmbDataAsync(System.String%2cUnderAutomation.ABB.Rws.Data.SmbDataTransfer%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref>.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Both copies of the measurement board data</returns>
		public Task<SmbData> GetSmbDataAsync(string mechanicalUnit, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Copies one of the two serial measurement board data stores over the other (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="direction">Which copy overwrites which</param>
		public void SetSmbData(string mechanicalUnit, SmbDataTransfer direction)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Copies one of the two serial measurement board data stores over the other (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="direction">Which copy overwrites which</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetSmbDataAsync(string mechanicalUnit, SmbDataTransfer direction, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Erases one of the two serial measurement board data stores (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="memory">Which of the two copies to erase</param>
		public void ClearSmbData(string mechanicalUnit, SmbDataMemory memory)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Erases one of the two serial measurement board data stores (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="memory">Which of the two copies to erase</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task ClearSmbDataAsync(string mechanicalUnit, SmbDataMemory memory, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets an overview of the motion system: the mechanical unit jogging applies to, the change counter
		/// and the payload and accuracy settings (synchronous)
		/// </summary>
		/// <returns>Overview of the motion system</returns>
		public MotionSystemInfo GetInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets an overview of the motion system: the mechanical unit jogging applies to, the change counter
		/// and the payload and accuracy settings (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Overview of the motion system</returns>
		public Task<MotionSystemInfo> GetInfoAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Tells whether the motion system changed since it reported the given change count (synchronous)
		/// 
		/// <p>Reading <xref href="UnderAutomation.ABB.Rws.Data.MotionSystemInfo.ChangeCount" data-throw-if-not-resolved="false"></xref> once and asking this afterwards is cheaper
		/// than fetching the whole state again to find out that nothing moved.</p>
		/// </summary>
		/// <param name="changeCount">Change count a previous reading reported</param>
		/// <returns>True when the motion system changed since then, false when it did not</returns>
		public bool HasChanged(int changeCount)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Tells whether the motion system changed since it reported the given change count (asynchronous)
		/// 
		/// <p>Reading <xref href="UnderAutomation.ABB.Rws.Data.MotionSystemInfo.ChangeCount" data-throw-if-not-resolved="false"></xref> once and asking this afterwards is cheaper
		/// than fetching the whole state again to find out that nothing moved.</p>
		/// </summary>
		/// <param name="changeCount">Change count a previous reading reported</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>True when the motion system changed since then, false when it did not</returns>
		public Task<bool> HasChangedAsync(int changeCount, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the last error the motion system ran into, and how many errors it has counted (synchronous)
		/// 
		/// <p>Most of these errors are raised by a jogging request the controller could not honour, and stay
		/// reported until a new one replaces them.</p>
		/// </summary>
		/// <returns>Error state of the motion system</returns>
		public MotionSystemErrorState GetErrorState()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the last error the motion system ran into, and how many errors it has counted (asynchronous)
		/// 
		/// <p>Most of these errors are raised by a jogging request the controller could not honour, and stay
		/// reported until a new one replaces them.</p>
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Error state of the motion system</returns>
		public Task<MotionSystemErrorState> GetErrorStateAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Tells whether the controller runs RAPID programs without moving the robot (synchronous)
		/// 
		/// <p>In that mode the program executes normally but every motion instruction is skipped, which is
		/// how a program is tested without the robot leaving its position.</p>
		/// </summary>
		/// <returns>True when the motion instructions are skipped, false when the robot really moves</returns>
		public bool GetNonMotionExecutionMode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Tells whether the controller runs RAPID programs without moving the robot (asynchronous)
		/// 
		/// <p>In that mode the program executes normally but every motion instruction is skipped, which is
		/// how a program is tested without the robot leaving its position.</p>
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>True when the motion instructions are skipped, false when the robot really moves</returns>
		public Task<bool> GetNonMotionExecutionModeAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Chooses whether the controller runs RAPID programs without moving the robot (synchronous)
		/// </summary>
		/// <param name="enabled">True to skip every motion instruction, false to let the robot move</param>
		public void SetNonMotionExecutionMode(bool enabled)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Chooses whether the controller runs RAPID programs without moving the robot (asynchronous)
		/// </summary>
		/// <param name="enabled">True to skip every motion instruction, false to let the robot move</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetNonMotionExecutionModeAsync(bool enabled, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Tells whether the controller predicts collisions before they happen (synchronous)
		/// 
		/// <p>Collision prediction stops the robot before it hits something it knows about, where the motion
		/// supervision only reacts once the arm meets an unexpected resistance.</p>
		/// </summary>
		/// <returns>True when collision prediction is switched on</returns>
		public bool GetCollisionPredictionMode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Tells whether the controller predicts collisions before they happen (asynchronous)
		/// 
		/// <p>Collision prediction stops the robot before it hits something it knows about, where the motion
		/// supervision only reacts once the arm meets an unexpected resistance.</p>
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>True when collision prediction is switched on</returns>
		public Task<bool> GetCollisionPredictionModeAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Switches collision prediction on or off (synchronous)
		/// </summary>
		/// <param name="enabled">True to predict collisions, false to switch the prediction off</param>
		public void SetCollisionPredictionMode(bool enabled)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Switches collision prediction on or off (asynchronous)
		/// </summary>
		/// <param name="enabled">True to predict collisions, false to switch the prediction off</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetCollisionPredictionModeAsync(bool enabled, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Moves the mechanical unit currently selected for jogging (synchronous)
		/// 
		/// <p>The unit is the one <xref href="UnderAutomation.ABB.Rws.Services.MotionSystemService.SetJoggingMechanicalUnit(System.String)" data-throw-if-not-resolved="false"></xref> chose, and how the six values are
		/// interpreted depends on its jog mode: axis by axis, along the axes of a coordinate system, and so on.</p>
		/// </summary>
		/// <param name="axes">Value requested for each of the six axes</param>
		/// <param name="changeCount">Change count of the last reading of the motion system, which the controller
		///             uses to reject a command based on a state that has moved on since</param>
		/// <param name="incrementMode">Size of the step to move by, <xref href="UnderAutomation.ABB.Rws.Data.JogIncrementMode.None" data-throw-if-not-resolved="false"></xref> to move
		///             continuously for as long as the command is repeated</param>
		public void Jog(RobotJoints axes, int changeCount, JogIncrementMode incrementMode = JogIncrementMode.None)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Moves the mechanical unit currently selected for jogging (asynchronous)
		/// 
		/// <p>The unit is the one <xref href="UnderAutomation.ABB.Rws.Services.MotionSystemService.SetJoggingMechanicalUnitAsync(System.String%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref> chose, and how the six values are
		/// interpreted depends on its jog mode: axis by axis, along the axes of a coordinate system, and so on.</p>
		/// </summary>
		/// <param name="axes">Value requested for each of the six axes</param>
		/// <param name="changeCount">Change count of the last reading of the motion system, which the controller
		///             uses to reject a command based on a state that has moved on since</param>
		/// <param name="incrementMode">Size of the step to move by, <xref href="UnderAutomation.ABB.Rws.Data.JogIncrementMode.None" data-throw-if-not-resolved="false"></xref> to move
		///             continuously for as long as the command is repeated</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task JogAsync(RobotJoints axes, int changeCount, JogIncrementMode incrementMode = JogIncrementMode.None, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Chooses which mechanical unit the jogging commands apply to (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		public void SetJoggingMechanicalUnit(string mechanicalUnit)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Chooses which mechanical unit the jogging commands apply to (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetJoggingMechanicalUnitAsync(string mechanicalUnit, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sends the robot to a cartesian target (synchronous)
		/// 
		/// <p>The position is expressed in millimetres, in the coordinate system currently active for the
		/// mechanical unit selected for jogging.</p>
		/// </summary>
		/// <param name="target">Target to move to, with the axis configuration to reach it in and the external
		///             axis values that travel with it</param>
		public void SetPositionTarget(RobTarget target)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Sends the robot to a cartesian target (asynchronous)
		/// 
		/// <p>The position is expressed in millimetres, in the coordinate system currently active for the
		/// mechanical unit selected for jogging.</p>
		/// </summary>
		/// <param name="target">Target to move to, with the axis configuration to reach it in and the external
		///             axis values that travel with it</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetPositionTargetAsync(RobTarget target, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Asks the controller where the tool would be if the robot stood at the given joint values, without
		/// moving it there (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="toolFrame">Position and orientation of the tool relative to the mounting flange</param>
		/// <param name="joints">Joint values to compute the pose of</param>
		/// <param name="robotHoldsWorkObject">True when the robot carries the work object and the tool is fixed
		///             in the cell, false in the usual case where the robot carries the tool</param>
		/// <param name="logErrors">True to have the controller write an event log message when the calculation fails</param>
		/// <returns>Pose the tool would be at, with the axis configuration and the external axis values</returns>
		public RobTarget GetPoseFromJoints(string mechanicalUnit, Pose toolFrame, JointTarget joints, bool robotHoldsWorkObject = false, bool logErrors = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Asks the controller where the tool would be if the robot stood at the given joint values, without
		/// moving it there (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="toolFrame">Position and orientation of the tool relative to the mounting flange</param>
		/// <param name="joints">Joint values to compute the pose of</param>
		/// <param name="robotHoldsWorkObject">True when the robot carries the work object and the tool is fixed
		///             in the cell, false in the usual case where the robot carries the tool</param>
		/// <param name="logErrors">True to have the controller write an event log message when the calculation fails</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Pose the tool would be at, with the axis configuration and the external axis values</returns>
		public Task<RobTarget> GetPoseFromJointsAsync(string mechanicalUnit, Pose toolFrame, JointTarget joints, bool robotHoldsWorkObject = false, bool logErrors = false, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Asks the controller which joint values put the tool at the given pose, staying close to the joint
		/// values the robot is already in (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="pose">Pose to reach, in metres</param>
		/// <param name="externalAxes">External axis values that go with that pose</param>
		/// <param name="toolFrame">Position and orientation of the tool relative to the mounting flange</param>
		/// <param name="previousJoints">Joint values the robot is currently in, which decide between the
		///             solutions the pose admits</param>
		/// <param name="configuration">Axis configuration to reach the pose in</param>
		/// <param name="robotHoldsWorkObject">True when the robot carries the work object and the tool is fixed
		///             in the cell, false in the usual case where the robot carries the tool</param>
		/// <param name="logErrors">True to have the controller write an event log message when the calculation fails</param>
		/// <returns>Joint values that reach the pose, in radians</returns>
		public JointTarget GetJointsFromCartesian(string mechanicalUnit, Pose pose, ExternalJoints externalAxes, Pose toolFrame, JointTarget previousJoints, RobotConfiguration configuration, bool robotHoldsWorkObject = false, bool logErrors = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Asks the controller which joint values put the tool at the given pose, staying close to the joint
		/// values the robot is already in (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="pose">Pose to reach, in metres</param>
		/// <param name="externalAxes">External axis values that go with that pose</param>
		/// <param name="toolFrame">Position and orientation of the tool relative to the mounting flange</param>
		/// <param name="previousJoints">Joint values the robot is currently in, which decide between the
		///             solutions the pose admits</param>
		/// <param name="configuration">Axis configuration to reach the pose in</param>
		/// <param name="robotHoldsWorkObject">True when the robot carries the work object and the tool is fixed
		///             in the cell, false in the usual case where the robot carries the tool</param>
		/// <param name="logErrors">True to have the controller write an event log message when the calculation fails</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Joint values that reach the pose, in radians</returns>
		public Task<JointTarget> GetJointsFromCartesianAsync(string mechanicalUnit, Pose pose, ExternalJoints externalAxes, Pose toolFrame, JointTarget previousJoints, RobotConfiguration configuration, bool robotHoldsWorkObject = false, bool logErrors = false, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Asks the controller which joint values put the tool at the given pose (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="pose">Pose to reach, in metres</param>
		/// <param name="externalAxes">External axis values that go with that pose</param>
		/// <param name="toolFrame">Position and orientation of the tool relative to the mounting flange</param>
		/// <param name="previousJoints">Joint values the robot is currently in, which decide between the
		///             solutions the pose admits</param>
		/// <param name="configuration">Axis configuration to reach the pose in</param>
		/// <param name="robotHoldsWorkObject">True when the robot carries the work object and the tool is fixed
		///             in the cell, false in the usual case where the robot carries the tool</param>
		/// <param name="logErrors">True to have the controller write an event log message when the calculation fails</param>
		/// <returns>Joint values that reach the pose, in radians</returns>
		public JointTarget GetJointsFromPose(string mechanicalUnit, Pose pose, ExternalJoints externalAxes, Pose toolFrame, JointTarget previousJoints, RobotConfiguration configuration, bool robotHoldsWorkObject = false, bool logErrors = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Asks the controller which joint values put the tool at the given pose (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="pose">Pose to reach, in metres</param>
		/// <param name="externalAxes">External axis values that go with that pose</param>
		/// <param name="toolFrame">Position and orientation of the tool relative to the mounting flange</param>
		/// <param name="previousJoints">Joint values the robot is currently in, which decide between the
		///             solutions the pose admits</param>
		/// <param name="configuration">Axis configuration to reach the pose in</param>
		/// <param name="robotHoldsWorkObject">True when the robot carries the work object and the tool is fixed
		///             in the cell, false in the usual case where the robot carries the tool</param>
		/// <param name="logErrors">True to have the controller write an event log message when the calculation fails</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Joint values that reach the pose, in radians</returns>
		public Task<JointTarget> GetJointsFromPoseAsync(string mechanicalUnit, Pose pose, ExternalJoints externalAxes, Pose toolFrame, JointTarget previousJoints, RobotConfiguration configuration, bool robotHoldsWorkObject = false, bool logErrors = false, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Asks the controller for every joint combination that puts the tool at the given pose (synchronous)
		/// 
		/// <p>A six axis robot usually reaches the same pose in eight different ways, each one in a different
		/// axis configuration.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="pose">Pose to reach, in metres</param>
		/// <param name="externalAxes">External axis values that go with that pose</param>
		/// <param name="toolFrame">Position and orientation of the tool relative to the mounting flange</param>
		/// <param name="configuration">Axis configuration the pose is given in</param>
		/// <param name="robotHoldsWorkObject">True when the robot carries the work object and the tool is fixed
		///             in the cell, false in the usual case where the robot carries the tool</param>
		/// <returns>One entry per solution, each with the joint values in radians and the axis configuration it
		///             corresponds to</returns>
		public JointSolution[] GetAllJointSolutions(string mechanicalUnit, Pose pose, ExternalJoints externalAxes, Pose toolFrame, RobotConfiguration configuration, bool robotHoldsWorkObject = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Asks the controller for every joint combination that puts the tool at the given pose (asynchronous)
		/// 
		/// <p>A six axis robot usually reaches the same pose in eight different ways, each one in a different
		/// axis configuration.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="pose">Pose to reach, in metres</param>
		/// <param name="externalAxes">External axis values that go with that pose</param>
		/// <param name="toolFrame">Position and orientation of the tool relative to the mounting flange</param>
		/// <param name="configuration">Axis configuration the pose is given in</param>
		/// <param name="robotHoldsWorkObject">True when the robot carries the work object and the tool is fixed
		///             in the cell, false in the usual case where the robot carries the tool</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>One entry per solution, each with the joint values in radians and the axis configuration it
		///             corresponds to</returns>
		public Task<JointSolution[]> GetAllJointSolutionsAsync(string mechanicalUnit, Pose pose, ExternalJoints externalAxes, Pose toolFrame, RobotConfiguration configuration, bool robotHoldsWorkObject = false, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Lists the mechanical units of the motion system (synchronous)
		/// </summary>
		/// <returns>Mechanical units, with their activation state. Empty when the system declares none.</returns>
		public MechanicalUnitItem[] GetMechanicalUnits()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Lists the mechanical units of the motion system (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Mechanical units, with their activation state. Empty when the system declares none.</returns>
		public Task<MechanicalUnitItem[]> GetMechanicalUnitsAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets everything the controller knows about one mechanical unit (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <returns>Properties of the mechanical unit</returns>
		public MechanicalUnitInfo GetMechanicalUnit(string mechanicalUnit)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets everything the controller knows about one mechanical unit (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Properties of the mechanical unit</returns>
		public Task<MechanicalUnitInfo> GetMechanicalUnitAsync(string mechanicalUnit, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Changes one or several properties of a mechanical unit (synchronous)
		/// 
		/// <p>Every argument but the unit name is optional; leave the ones you do not want to touch null.
		/// At least one of them has to be given.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="tool">Name of the tool to activate</param>
		/// <param name="workObject">Name of the work object to activate</param>
		/// <param name="payload">Name of the payload to activate</param>
		/// <param name="totalPayload">Name of the total payload to activate</param>
		/// <param name="mode">Whether to activate or deactivate the unit</param>
		/// <param name="jogMode">How the jogging commands sent to the unit are to be interpreted</param>
		/// <param name="coordinateSystem">Reference frame the cartesian positions of the unit are expressed in</param>
		public void SetMechanicalUnit(string mechanicalUnit, string tool = null, string workObject = null, string payload = null, string totalPayload = null, MechanicalUnitMode? mode = null, JogMode? jogMode = null, CoordinateSystem? coordinateSystem = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Changes one or several properties of a mechanical unit (asynchronous)
		/// 
		/// <p>Every argument but the unit name is optional; leave the ones you do not want to touch null.
		/// At least one of them has to be given.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="tool">Name of the tool to activate</param>
		/// <param name="workObject">Name of the work object to activate</param>
		/// <param name="payload">Name of the payload to activate</param>
		/// <param name="totalPayload">Name of the total payload to activate</param>
		/// <param name="mode">Whether to activate or deactivate the unit</param>
		/// <param name="jogMode">How the jogging commands sent to the unit are to be interpreted</param>
		/// <param name="coordinateSystem">Reference frame the cartesian positions of the unit are expressed in</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetMechanicalUnitAsync(string mechanicalUnit, string tool = null, string workObject = null, string payload = null, string totalPayload = null, MechanicalUnitMode? mode = null, JogMode? jogMode = null, CoordinateSystem? coordinateSystem = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets how many axes a mechanical unit has (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <returns>Number of axes, which are numbered from 1 to that value</returns>
		public int GetAxisCount(string mechanicalUnit)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets how many axes a mechanical unit has (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Number of axes, which are numbered from 1 to that value</returns>
		public Task<int> GetAxisCountAsync(string mechanicalUnit, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the state of one axis of a mechanical unit (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="axis">Number of the axis, starting at 1</param>
		/// <returns>State of the axis</returns>
		public AxisInfo GetAxis(string mechanicalUnit, int axis)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the state of one axis of a mechanical unit (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="axis">Number of the axis, starting at 1</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>State of the axis</returns>
		public Task<AxisInfo> GetAxisAsync(string mechanicalUnit, int axis, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets where one axis of a mechanical unit sits (synchronous)
		/// 
		/// <p>The position is expressed in millimetres.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="axis">Number of the axis, starting at 1</param>
		/// <returns>Position and orientation of the axis</returns>
		public Pose GetAxisPose(string mechanicalUnit, int axis)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets where one axis of a mechanical unit sits (asynchronous)
		/// 
		/// <p>The position is expressed in millimetres.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="axis">Number of the axis, starting at 1</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Position and orientation of the axis</returns>
		public Task<Pose> GetAxisPoseAsync(string mechanicalUnit, int axis, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Declares where one axis of a mechanical unit sits (synchronous)
		/// 
		/// <p>The position is expressed in millimetres.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="axis">Number of the axis, starting at 1</param>
		/// <param name="pose">Position and orientation to declare for the axis</param>
		public void SetAxisPose(string mechanicalUnit, int axis, Pose pose)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Declares where one axis of a mechanical unit sits (asynchronous)
		/// 
		/// <p>The position is expressed in millimetres.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="axis">Number of the axis, starting at 1</param>
		/// <param name="pose">Position and orientation to declare for the axis</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetAxisPoseAsync(string mechanicalUnit, int axis, Pose pose, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Commutates the motor of one axis, which teaches the controller how the rotor of that motor is
		/// oriented (synchronous)
		/// 
		/// <p>Needed once after a motor has been replaced, before the axis can be calibrated.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="axis">Number of the axis, starting at 1</param>
		public void Commutate(string mechanicalUnit, int axis)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Commutates the motor of one axis, which teaches the controller how the rotor of that motor is
		/// oriented (asynchronous)
		/// 
		/// <p>Needed once after a motor has been replaced, before the axis can be calibrated.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="axis">Number of the axis, starting at 1</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task CommutateAsync(string mechanicalUnit, int axis, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Synchronizes the revolution counter of one axis, telling the controller that the axis stands at its
		/// synchronization mark (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="axis">Number of the axis, starting at 1</param>
		public void SynchronizeAxisRevolutionCounter(string mechanicalUnit, int axis)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Synchronizes the revolution counter of one axis, telling the controller that the axis stands at its
		/// synchronization mark (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="axis">Number of the axis, starting at 1</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SynchronizeAxisRevolutionCounterAsync(string mechanicalUnit, int axis, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Updates the revolution counter of one axis of a mechanical unit (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="axis">Number of the axis, starting at 1</param>
		public void UpdateRevolutionCounter(string mechanicalUnit, int axis)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Updates the revolution counter of one axis of a mechanical unit (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="axis">Number of the axis, starting at 1</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task UpdateRevolutionCounterAsync(string mechanicalUnit, int axis, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Fine calibrates one axis of a mechanical unit (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="axis">Number of the axis, starting at 1</param>
		public void FineCalibrate(string mechanicalUnit, int axis)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Fine calibrates one axis of a mechanical unit (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="axis">Number of the axis, starting at 1</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task FineCalibrateAsync(string mechanicalUnit, int axis, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets where the base of a mechanical unit sits (synchronous)
		/// 
		/// <p>The position is expressed in millimetres.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <returns>Base frame of the mechanical unit, with the kind of base it is</returns>
		public BaseFrame GetBaseFrame(string mechanicalUnit)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets where the base of a mechanical unit sits (asynchronous)
		/// 
		/// <p>The position is expressed in millimetres.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Base frame of the mechanical unit, with the kind of base it is</returns>
		public Task<BaseFrame> GetBaseFrameAsync(string mechanicalUnit, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Declares where the base of a mechanical unit sits (synchronous)
		/// 
		/// <p>The position is expressed in millimetres.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="baseFrame">Position and orientation of the base of the unit</param>
		public void SetBaseFrame(string mechanicalUnit, Pose baseFrame)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Declares where the base of a mechanical unit sits (asynchronous)
		/// 
		/// <p>The position is expressed in millimetres.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="baseFrame">Position and orientation of the base of the unit</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetBaseFrameAsync(string mechanicalUnit, Pose baseFrame, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets where the tool of a mechanical unit currently is (synchronous)
		/// 
		/// <p>The position is expressed in millimetres.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="coordinateSystem">Reference frame to express the position in</param>
		/// <param name="tool">Name of the tool to measure from, null to use the tool active on the unit</param>
		/// <param name="workObject">Name of the work object to measure against, null to use the one active on the unit</param>
		/// <returns>Position, orientation, axis configuration and external axis values of the tool</returns>
		public RobTarget GetRobTarget(string mechanicalUnit, CoordinateSystem coordinateSystem = CoordinateSystem.Base, string tool = null, string workObject = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets where the tool of a mechanical unit currently is (asynchronous)
		/// 
		/// <p>The position is expressed in millimetres.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="coordinateSystem">Reference frame to express the position in</param>
		/// <param name="tool">Name of the tool to measure from, null to use the tool active on the unit</param>
		/// <param name="workObject">Name of the work object to measure against, null to use the one active on the unit</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Position, orientation, axis configuration and external axis values of the tool</returns>
		public Task<RobTarget> GetRobTargetAsync(string mechanicalUnit, CoordinateSystem coordinateSystem = CoordinateSystem.Base, string tool = null, string workObject = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets where the tool of a mechanical unit currently is, without the external axes (synchronous)
		/// 
		/// <p>The position is expressed in millimetres.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="coordinateSystem">Reference frame to express the position in</param>
		/// <param name="tool">Name of the tool to measure from, null to use the tool active on the unit</param>
		/// <param name="workObject">Name of the work object to measure against, null to use the one active on the unit</param>
		/// <param name="logErrors">True to have the controller write an event log message when the reading fails</param>
		/// <returns>Position, orientation and axis configuration of the tool. <xref href="UnderAutomation.ABB.Common.RobTarget.ExternalAxes" data-throw-if-not-resolved="false"></xref>
		///             is null: this reading does not report them, use <xref href="UnderAutomation.ABB.Rws.Services.MotionSystemService.GetRobTarget(System.String%2cUnderAutomation.ABB.Rws.Data.CoordinateSystem%2cSystem.String%2cSystem.String)" data-throw-if-not-resolved="false"></xref> when they are needed.</returns>
		public RobTarget GetCartesianPosition(string mechanicalUnit, CoordinateSystem coordinateSystem = CoordinateSystem.Base, string tool = null, string workObject = null, bool logErrors = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets where the tool of a mechanical unit currently is, without the external axes (asynchronous)
		/// 
		/// <p>The position is expressed in millimetres.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="coordinateSystem">Reference frame to express the position in</param>
		/// <param name="tool">Name of the tool to measure from, null to use the tool active on the unit</param>
		/// <param name="workObject">Name of the work object to measure against, null to use the one active on the unit</param>
		/// <param name="logErrors">True to have the controller write an event log message when the reading fails</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Position, orientation and axis configuration of the tool. <xref href="UnderAutomation.ABB.Common.RobTarget.ExternalAxes" data-throw-if-not-resolved="false"></xref>
		///             is null: this reading does not report them, use <xref href="UnderAutomation.ABB.Rws.Services.MotionSystemService.GetRobTargetAsync(System.String%2cUnderAutomation.ABB.Rws.Data.CoordinateSystem%2cSystem.String%2cSystem.String%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref> when they are needed.</returns>
		public Task<RobTarget> GetCartesianPositionAsync(string mechanicalUnit, CoordinateSystem coordinateSystem = CoordinateSystem.Base, string tool = null, string workObject = null, bool logErrors = false, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the joint values a mechanical unit currently stands at (synchronous)
		/// 
		/// <p>The robot axes are expressed in degrees.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="alwaysRead">True to have the controller measure the position again instead of answering
		///             with the value it already holds</param>
		/// <returns>Joint values of the six robot axes and of the six external axes</returns>
		public JointTarget GetJointTarget(string mechanicalUnit, bool alwaysRead = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the joint values a mechanical unit currently stands at (asynchronous)
		/// 
		/// <p>The robot axes are expressed in degrees.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="alwaysRead">True to have the controller measure the position again instead of answering
		///             with the value it already holds</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Joint values of the six robot axes and of the six external axes</returns>
		public Task<JointTarget> GetJointTargetAsync(string mechanicalUnit, bool alwaysRead = false, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the physical joint values of a mechanical unit, as its measurement system reads them (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <returns>Physical value of the six axes</returns>
		public RobotJoints GetPhysicalJoints(string mechanicalUnit)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the physical joint values of a mechanical unit, as its measurement system reads them (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Physical value of the six axes</returns>
		public Task<RobotJoints> GetPhysicalJointsAsync(string mechanicalUnit, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Places a mechanical unit at the given joint values without moving it there (synchronous)
		/// 
		/// <p>Only a virtual controller accepts this: it teleports the simulated robot, which a real one
		/// cannot do.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="position">Joint values to place the unit at, robot axes in degrees</param>
		public void SetMechanicalUnitPosition(string mechanicalUnit, JointTarget position)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Places a mechanical unit at the given joint values without moving it there (asynchronous)
		/// 
		/// <p>Only a virtual controller accepts this: it teleports the simulated robot, which a real one
		/// cannot do.</p>
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="position">Joint values to place the unit at, robot axes in degrees</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetMechanicalUnitPositionAsync(string mechanicalUnit, JointTarget position, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Tells whether an operator can push the arm of a mechanical unit around by hand (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <returns>Whether the arm gives way when pushed</returns>
		public LeadThroughStatus GetLeadThrough(string mechanicalUnit)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Tells whether an operator can push the arm of a mechanical unit around by hand (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Whether the arm gives way when pushed</returns>
		public Task<LeadThroughStatus> GetLeadThroughAsync(string mechanicalUnit, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Lets an operator push the arm of a mechanical unit around by hand, or stops letting them (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="active">True to let the arm give way when pushed, false to have it hold its position</param>
		public void SetLeadThrough(string mechanicalUnit, bool active)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Lets an operator push the arm of a mechanical unit around by hand, or stops letting them (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="active">True to let the arm give way when pushed, false to have it hold its position</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetLeadThroughAsync(string mechanicalUnit, bool active, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the collision detection settings that apply while a mechanical unit is jogged (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <returns>Whether the supervision is switched on, and how sensitive it is</returns>
		public MotionSupervision GetMotionSupervision(string mechanicalUnit)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the collision detection settings that apply while a mechanical unit is jogged (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Whether the supervision is switched on, and how sensitive it is</returns>
		public Task<MotionSupervision> GetMotionSupervisionAsync(string mechanicalUnit, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Switches the jogging collision detection of a mechanical unit on or off (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="enabled">True to watch for collisions while the unit is jogged, false to stop watching</param>
		public void SetMotionSupervisionMode(string mechanicalUnit, bool enabled)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Switches the jogging collision detection of a mechanical unit on or off (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="enabled">True to watch for collisions while the unit is jogged, false to stop watching</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetMotionSupervisionModeAsync(string mechanicalUnit, bool enabled, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets how sensitive the jogging collision detection of a mechanical unit is (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="sensitivity">Sensitivity as a percentage: the lower the value, the sooner a collision
		///             is reported</param>
		public void SetMotionSupervisionLevel(string mechanicalUnit, int sensitivity)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Sets how sensitive the jogging collision detection of a mechanical unit is (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="sensitivity">Sensitivity as a percentage: the lower the value, the sooner a collision
		///             is reported</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetMotionSupervisionLevelAsync(string mechanicalUnit, int sensitivity, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the collision detection settings that apply while a mechanical unit follows a programmed
		/// path (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <returns>Whether the supervision is switched on, and how sensitive it is</returns>
		public PathSupervision GetPathSupervision(string mechanicalUnit)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the collision detection settings that apply while a mechanical unit follows a programmed
		/// path (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Whether the supervision is switched on, and how sensitive it is</returns>
		public Task<PathSupervision> GetPathSupervisionAsync(string mechanicalUnit, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Switches the path collision detection of a mechanical unit on or off (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="enabled">True to watch for collisions along the programmed path, false to stop watching</param>
		public void SetPathSupervisionMode(string mechanicalUnit, bool enabled)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Switches the path collision detection of a mechanical unit on or off (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="enabled">True to watch for collisions along the programmed path, false to stop watching</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetPathSupervisionModeAsync(string mechanicalUnit, bool enabled, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets how sensitive the path collision detection of a mechanical unit is (synchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="level">Sensitivity as a percentage: the lower the value, the sooner a collision
		///             is reported</param>
		public void SetPathSupervisionLevel(string mechanicalUnit, int level)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Sets how sensitive the path collision detection of a mechanical unit is (asynchronous)
		/// </summary>
		/// <param name="mechanicalUnit">Name of the mechanical unit, for example "ROB_1"</param>
		/// <param name="level">Sensitivity as a percentage: the lower the value, the sooner a collision
		///             is reported</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetPathSupervisionLevelAsync(string mechanicalUnit, int level, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
