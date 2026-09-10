//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Physical state of an I/O network
	/// </summary>
	public enum IoNetworkPhysicalState {

		/// <summary>
		/// The physical state could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The network is halted
		/// </summary>
		Halted = 1,

		/// <summary>
		/// The network is running
		/// </summary>
		Running = 2,

		/// <summary>
		/// The network reports an error
		/// </summary>
		Error = 3,

		/// <summary>
		/// The network is starting up
		/// </summary>
		Startup = 4,

		/// <summary>
		/// The network is initializing
		/// </summary>
		Init = 5,
	}
}
