//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Physical state of an I/O signal
	/// </summary>
	public enum IoSignalPhysicalState {

		/// <summary>
		/// The physical state could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The physical value of the signal is valid
		/// </summary>
		Valid = 1,

		/// <summary>
		/// The physical value of the signal is not valid
		/// </summary>
		Invalid = 2,
	}
}
