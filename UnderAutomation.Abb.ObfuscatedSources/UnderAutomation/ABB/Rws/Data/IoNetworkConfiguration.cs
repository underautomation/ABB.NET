//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Runtime configuration properties of an I/O network.
	/// 
	/// <p>Returned by <code>IoService.GetNetworkConfiguration()</code>.</p>
	/// </summary>
	public class IoNetworkConfiguration {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.IoNetworkConfiguration" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public IoNetworkConfiguration()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this network configuration
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the network, for example "Local"
		/// </summary>
		public string NetworkName { get; set; }

		/// <summary>
		/// Type of the network, for example "Local" or "LOC"
		/// </summary>
		public string NetworkType { get; set; }

		/// <summary>
		/// Industrial network address, "-" when the network has no addressing
		/// </summary>
		public string NetworkAddress { get; set; }
	}
}
