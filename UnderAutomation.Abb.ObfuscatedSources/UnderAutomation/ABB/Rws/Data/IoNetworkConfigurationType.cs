//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Configuration type applied to an I/O network by <code>IoService.SetNetworkConfigurationType()</code>
	/// 
	/// </summary>
	public sealed class IoNetworkConfigurationType : Enum {


		public int value__;

		/// <summary>
		/// 
		/// Configure the signals of the network
		/// 
		/// </summary>
		public const IoNetworkConfigurationType Bits;

		/// <summary>
		/// 
		/// Configure the signal groups of the network
		/// 
		/// </summary>
		public const IoNetworkConfigurationType Groups;

		/// <summary>
		/// 
		/// Configure both the signals and the signal groups
		/// 
		/// </summary>
		public const IoNetworkConfigurationType Both;

		/// <summary>
		/// 
		/// Scan the network for connected devices
		/// 
		/// </summary>
		public const IoNetworkConfigurationType Scan;

		/// <summary>
		/// 
		/// Configure the devices of the network
		/// 
		/// </summary>
		public const IoNetworkConfigurationType Units;
	}
}
