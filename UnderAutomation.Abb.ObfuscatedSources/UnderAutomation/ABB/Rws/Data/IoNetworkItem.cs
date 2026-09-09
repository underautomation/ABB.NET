//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// I/O network defined in the robot controller.
	/// <p>Returned by <code>IoService.GetNetworks()</code>, <code>IoService.GetNetwork()</code> and <code>IoService.SearchNetworks()</code>.</p>
	/// 
	/// </summary>
	public class IoNetworkItem : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.IoNetworkItem" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public IoNetworkItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this network
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Name of the network, for example &quot;Local&quot;, &quot;Virtual&quot; or &quot;EtherNetIP&quot;
		/// 
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 
		/// Full path of the network, which is its name for a network (for example &quot;Local&quot;)
		/// 
		/// </summary>
		public string Path { get; set; }

		/// <summary>
		/// 
		/// Physical state of the network
		/// 
		/// </summary>
		public IoNetworkPhysicalState PhysicalState { get; set; }

		/// <summary>
		/// 
		/// Logical state of the network
		/// 
		/// </summary>
		public IoNetworkLogicalState LogicalState { get; set; }
	}
}
