//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Logical state of an I/O network
	/// 
	/// </summary>
	public sealed class IoNetworkLogicalState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The logical state could not be determined
		/// 
		/// </summary>
		public const IoNetworkLogicalState Unknown;

		/// <summary>
		/// 
		/// The network is started
		/// 
		/// </summary>
		public const IoNetworkLogicalState Started;

		/// <summary>
		/// 
		/// The network is stopped
		/// 
		/// </summary>
		public const IoNetworkLogicalState Stopped;
	}
}
