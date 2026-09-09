//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Physical state of an I/O network
	/// 
	/// </summary>
	public sealed class IoNetworkPhysicalState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The physical state could not be determined
		/// 
		/// </summary>
		public const IoNetworkPhysicalState Unknown;

		/// <summary>
		/// 
		/// The network is halted
		/// 
		/// </summary>
		public const IoNetworkPhysicalState Halted;

		/// <summary>
		/// 
		/// The network is running
		/// 
		/// </summary>
		public const IoNetworkPhysicalState Running;

		/// <summary>
		/// 
		/// The network reports an error
		/// 
		/// </summary>
		public const IoNetworkPhysicalState Error;

		/// <summary>
		/// 
		/// The network is starting up
		/// 
		/// </summary>
		public const IoNetworkPhysicalState Startup;

		/// <summary>
		/// 
		/// The network is initializing
		/// 
		/// </summary>
		public const IoNetworkPhysicalState Init;
	}
}
