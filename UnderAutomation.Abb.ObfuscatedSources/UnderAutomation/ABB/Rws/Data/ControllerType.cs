//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Type of the robot controller (real or virtual)
	/// </summary>
	public enum ControllerType {

		/// <summary>
		/// The controller type could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Physical robot controller (RC)
		/// </summary>
		RealController = 1,

		/// <summary>
		/// Virtual controller (VC), for example running in RobotStudio
		/// </summary>
		VirtualController = 2,
	}
}
