//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Logical state of an I/O network
	/// </summary>
	public enum IoNetworkLogicalState {

		/// <summary>
		/// The logical state could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The network is started
		/// </summary>
		Started = 1,

		/// <summary>
		/// The network is stopped
		/// </summary>
		Stopped = 2,
	}
}
