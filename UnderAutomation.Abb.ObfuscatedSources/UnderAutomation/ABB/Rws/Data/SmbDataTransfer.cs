//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Which of the two copies of the serial measurement board data overwrites the other
	/// </summary>
	public enum SmbDataTransfer {

		/// <summary>
		/// The copy held by the robot is written into the controller cabinet
		/// </summary>
		RobotToController = 0,

		/// <summary>
		/// The copy held by the controller cabinet is written into the robot
		/// </summary>
		ControllerToRobot = 1,
	}
}
