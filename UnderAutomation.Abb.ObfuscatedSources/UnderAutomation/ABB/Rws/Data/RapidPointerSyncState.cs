//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Whether the pointers of every task are synchronized with each other
	/// </summary>
	public enum RapidPointerSyncState {

		/// <summary>
		/// The controller reported a state this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The pointers are synchronized
		/// </summary>
		On = 1,

		/// <summary>
		/// The pointers are not synchronized
		/// </summary>
		Off = 2,
	}
}
