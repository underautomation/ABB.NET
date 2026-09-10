//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// State of the robot controller, as reported by the control panel
	/// </summary>
	public enum ControllerState {

		/// <summary>
		/// The state could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The robot is starting up. It will shift to <xref href="UnderAutomation.ABB.Rws.Data.ControllerState.MotorsOff" data-throw-if-not-resolved="false"></xref> once it has started.
		/// </summary>
		Init = 1,

		/// <summary>
		/// The robot is in a standby state where there is no power to its motors.
		/// The state has to be shifted to <xref href="UnderAutomation.ABB.Rws.Data.ControllerState.MotorsOn" data-throw-if-not-resolved="false"></xref> before the robot can move.
		/// </summary>
		MotorsOff = 2,

		/// <summary>
		/// The robot is ready to move, either by jogging or by running programs
		/// </summary>
		MotorsOn = 3,

		/// <summary>
		/// The robot is stopped because the safety runchain is opened, for instance because a door of its cell is open
		/// </summary>
		GuardStop = 4,

		/// <summary>
		/// The robot is stopped because the emergency stop was activated
		/// </summary>
		EmergencyStop = 5,

		/// <summary>
		/// The robot is ready to leave the emergency stop state: the emergency stop is no longer activated,
		/// but the state transition is not confirmed yet.
		/// </summary>
		EmergencyStopReset = 6,

		/// <summary>
		/// The robot is in a system failure state and requires a restart
		/// </summary>
		SystemFailure = 7,
	}
}
