//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// IP configuration method of a controller LAN adapter
	/// </summary>
	public enum NetworkConfigurationMethod {

		/// <summary>
		/// Fixed IP address, the address, mask and gateway have to be provided
		/// </summary>
		FixIp = 0,

		/// <summary>
		/// IP address obtained from a DHCP server
		/// </summary>
		Dhcp = 1,

		/// <summary>
		/// No IP address configured on the adapter
		/// </summary>
		NoIp = 2,
	}
}
