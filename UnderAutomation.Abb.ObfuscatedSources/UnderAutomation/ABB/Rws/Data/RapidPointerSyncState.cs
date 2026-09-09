//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Whether the pointers of every task are synchronized with each other
	/// 
	/// </summary>
	public sealed class RapidPointerSyncState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a state this library does not know
		/// 
		/// </summary>
		public const RapidPointerSyncState Unknown;

		/// <summary>
		/// 
		/// The pointers are synchronized
		/// 
		/// </summary>
		public const RapidPointerSyncState On;

		/// <summary>
		/// 
		/// The pointers are not synchronized
		/// 
		/// </summary>
		public const RapidPointerSyncState Off;
	}
}
