//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Type of the robot controller (real or virtual)
	/// 
	/// </summary>
	public sealed class ControllerType : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller type could not be determined
		/// 
		/// </summary>
		public const ControllerType Unknown;

		/// <summary>
		/// 
		/// Physical robot controller (RC)
		/// 
		/// </summary>
		public const ControllerType RealController;

		/// <summary>
		/// 
		/// Virtual controller (VC), for example running in RobotStudio
		/// 
		/// </summary>
		public const ControllerType VirtualController;
	}
}
