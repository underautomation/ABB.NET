//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// State of the collision detection of the robot controller
	/// </summary>
	public enum CollisionDetectionState {

		/// <summary>
		/// The collision detection state could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// No collision has been detected since the controller started
		/// </summary>
		Init = 1,

		/// <summary>
		/// A collision has been detected and is waiting to be confirmed
		/// </summary>
		Triggered = 2,

		/// <summary>
		/// A detected collision has been confirmed
		/// </summary>
		Confirmed = 3,

		/// <summary>
		/// A detected collision has been acknowledged by an operator
		/// </summary>
		TriggeredAcknowledged = 4,
	}
}
