//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Order in which the event log messages of a domain are returned
	/// </summary>
	public enum ElogMessageOrder {

		/// <summary>
		/// Most recent message first
		/// </summary>
		NewestFirst = 0,

		/// <summary>
		/// Oldest message first
		/// </summary>
		OldestFirst = 1,
	}
}
