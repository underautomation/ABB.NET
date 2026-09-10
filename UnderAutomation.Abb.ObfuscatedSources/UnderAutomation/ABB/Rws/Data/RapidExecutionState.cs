//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Whether the controller is currently executing RAPID code
	/// </summary>
	public enum RapidExecutionState {

		/// <summary>
		/// The controller reported a state this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// RAPID execution is running
		/// </summary>
		Running = 1,

		/// <summary>
		/// RAPID execution is stopped
		/// </summary>
		Stopped = 2,
	}
}
