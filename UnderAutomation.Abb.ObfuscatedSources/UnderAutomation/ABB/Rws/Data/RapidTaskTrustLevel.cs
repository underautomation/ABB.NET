//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// What the controller does to the system when a task that is not a normal one stops unexpectedly
	/// </summary>
	public enum RapidTaskTrustLevel {

		/// <summary>
		/// The controller reported a level this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The system carries on
		/// </summary>
		None = 1,

		/// <summary>
		/// The whole system fails
		/// </summary>
		SystemFailure = 2,

		/// <summary>
		/// The system halts
		/// </summary>
		SystemHalt = 3,

		/// <summary>
		/// The system stops
		/// </summary>
		SystemStop = 4,
	}
}
