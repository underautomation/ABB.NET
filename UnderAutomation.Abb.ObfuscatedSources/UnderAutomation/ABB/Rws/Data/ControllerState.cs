//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// State of the robot controller, as reported by the control panel
	/// 
	/// </summary>
	public sealed class ControllerState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The state could not be determined
		/// 
		/// </summary>
		public const ControllerState Unknown;

		/// <summary>
		/// 
		/// The robot is starting up. It will shift to <xref href="UnderAutomation.ABB.Rws.Data.ControllerState.MotorsOff" data-throw-if-not-resolved="false"></xref> once it has started.
		/// 
		/// </summary>
		public const ControllerState Init;

		/// <summary>
		/// 
		/// The robot is in a standby state where there is no power to its motors.
		/// The state has to be shifted to <xref href="UnderAutomation.ABB.Rws.Data.ControllerState.MotorsOn" data-throw-if-not-resolved="false"></xref> before the robot can move.
		/// 
		/// </summary>
		public const ControllerState MotorsOff;

		/// <summary>
		/// 
		/// The robot is ready to move, either by jogging or by running programs
		/// 
		/// </summary>
		public const ControllerState MotorsOn;

		/// <summary>
		/// 
		/// The robot is stopped because the safety runchain is opened, for instance because a door of its cell is open
		/// 
		/// </summary>
		public const ControllerState GuardStop;

		/// <summary>
		/// 
		/// The robot is stopped because the emergency stop was activated
		/// 
		/// </summary>
		public const ControllerState EmergencyStop;

		/// <summary>
		/// 
		/// The robot is ready to leave the emergency stop state: the emergency stop is no longer activated,
		/// but the state transition is not confirmed yet.
		/// 
		/// </summary>
		public const ControllerState EmergencyStopReset;

		/// <summary>
		/// 
		/// The robot is in a system failure state and requires a restart
		/// 
		/// </summary>
		public const ControllerState SystemFailure;
	}
}
