//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Pending change that an operating mode acknowledgement confirms
	/// </summary>
	public enum OperationModeAcknowledgement {

		/// <summary>
		/// Confirms the switch to the automatic mode
		/// </summary>
		Automatic = 0,

		/// <summary>
		/// Confirms the switch to the manual full speed mode
		/// </summary>
		ManualFullSpeed = 1,

		/// <summary>
		/// Confirms a collision detection
		/// </summary>
		CollisionDetection = 2,
	}
}
