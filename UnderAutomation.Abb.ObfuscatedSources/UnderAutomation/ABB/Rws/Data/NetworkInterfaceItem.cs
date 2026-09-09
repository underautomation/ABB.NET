//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Network interface of the robot controller.
	/// <p>Returned by <code>ControllerService.GetNetworkInterfaces()</code>.</p>
	/// 
	/// </summary>
	public class NetworkInterfaceItem : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.NetworkInterfaceItem" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public NetworkInterfaceItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this network interface
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Physical port of the interface, for example &quot;X6&quot; or &quot;X23&quot;
		/// 
		/// </summary>
		public string Port { get; set; }

		/// <summary>
		/// 
		/// Logical name of the interface, for example &quot;WAN&quot;, &quot;LAN1&quot; or &quot;SERVICE&quot;
		/// 
		/// </summary>
		public string LogicalName { get; set; }

		/// <summary>
		/// 
		/// Network the interface belongs to (&quot;Public&quot;, &quot;Private&quot;, &quot;Ability&quot;, &quot;Drive&quot;).
		/// <p>Only available when connected with version 2.</p>
		/// 
		/// </summary>
		public string Network { get; set; }

		/// <summary>
		/// 
		/// IP address of the interface
		/// 
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// 
		/// Subnet mask of the interface
		/// 
		/// </summary>
		public string Mask { get; set; }

		/// <summary>
		/// 
		/// Primary DNS server of the interface.
		/// <p>Only available when connected with version 2.</p>
		/// 
		/// </summary>
		public string PrimaryDns { get; set; }

		/// <summary>
		/// 
		/// Secondary DNS server of the interface.
		/// <p>Only available when connected with version 2.</p>
		/// 
		/// </summary>
		public string SecondaryDns { get; set; }

		/// <summary>
		/// 
		/// DHCP status of the interface, if reported by the controller
		/// 
		/// </summary>
		public Nullable<bool> DhcpEnabled { get; set; }

		/// <summary>
		/// 
		/// Default gateway of the interface, if applicable
		/// 
		/// </summary>
		public string Gateway { get; set; }
	}
}
