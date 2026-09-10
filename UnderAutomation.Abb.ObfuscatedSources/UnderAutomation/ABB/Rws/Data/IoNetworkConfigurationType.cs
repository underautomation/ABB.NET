//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Configuration type applied to an I/O network by <code>IoService.SetNetworkConfigurationType()</code>
	/// </summary>
	public enum IoNetworkConfigurationType {

		/// <summary>
		/// Configure the signals of the network
		/// </summary>
		Bits = 0,

		/// <summary>
		/// Configure the signal groups of the network
		/// </summary>
		Groups = 1,

		/// <summary>
		/// Configure both the signals and the signal groups
		/// </summary>
		Both = 2,

		/// <summary>
		/// Scan the network for connected devices
		/// </summary>
		Scan = 3,

		/// <summary>
		/// Configure the devices of the network
		/// </summary>
		Units = 4,
	}
}
