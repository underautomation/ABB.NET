//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Whether the controller is recording the RAPID execution trace to a file
	/// </summary>
	public enum RapidSpyStatus {

		/// <summary>
		/// The controller reported a status this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The execution trace is being written
		/// </summary>
		Logging = 1,

		/// <summary>
		/// No execution trace is being written
		/// </summary>
		NotLogging = 2,
	}
}
