//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Whether a single task is running, and whether it could be
	/// </summary>
	public enum RapidTaskExecutionState {

		/// <summary>
		/// The controller reported a state this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The task is ready to be started
		/// </summary>
		Ready = 1,

		/// <summary>
		/// The task was running and has been stopped
		/// </summary>
		Stopped = 2,

		/// <summary>
		/// The task is running
		/// </summary>
		Started = 3,

		/// <summary>
		/// The task is not initialized
		/// </summary>
		Uninitialized = 4,
	}
}
