//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// IP configuration method of a controller LAN adapter
	/// 
	/// </summary>
	public sealed class NetworkConfigurationMethod : Enum {


		public int value__;

		/// <summary>
		/// 
		/// Fixed IP address, the address, mask and gateway have to be provided
		/// 
		/// </summary>
		public const NetworkConfigurationMethod FixIp;

		/// <summary>
		/// 
		/// IP address obtained from a DHCP server
		/// 
		/// </summary>
		public const NetworkConfigurationMethod Dhcp;

		/// <summary>
		/// 
		/// No IP address configured on the adapter
		/// 
		/// </summary>
		public const NetworkConfigurationMethod NoIp;
	}
}
