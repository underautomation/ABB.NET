//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Order in which the event log messages of a domain are returned
	/// 
	/// </summary>
	public sealed class ElogMessageOrder : Enum {


		public int value__;

		/// <summary>
		/// 
		/// Most recent message first
		/// 
		/// </summary>
		public const ElogMessageOrder NewestFirst;

		/// <summary>
		/// 
		/// Oldest message first
		/// 
		/// </summary>
		public const ElogMessageOrder OldestFirst;
	}
}
