//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.ABB.Rws;

namespace UnderAutomation.ABB.Rws.Internal {
	/// <summary>
	/// 
	/// Base class for connection parameters.
	/// Contains core properties needed for RWS connection.
	/// 
	/// </summary>
	public abstract class RwsConnectParametersBase : Object {


		protected RwsConnectParametersBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// IP address or hostname of the robot controller
		/// 
		/// </summary>
		public string Ip { get; set; }

		/// <summary>
		/// 
		/// RWS service port (if set to 0, the SDK will use 80 for HTTP, 443 for HTTPS)
		/// 
		/// </summary>
		public int Port { get; set; }

		/// <summary>
		/// 
		/// Username for Digest Authentication (Default is &quot;Default User&quot;)
		/// 
		/// </summary>
		public string Username { get; set; }

		/// <summary>
		/// 
		/// Password for Digest Authentication (Default is &quot;robotics&quot;)
		/// 
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// 
		/// HTTP request timeout in milliseconds (default: 1000ms)
		/// 
		/// </summary>
		public int Timeout { get; set; }

		/// <summary>
		/// 
		/// Whether to use HTTPS instead of HTTP (default: false)
		/// 
		/// </summary>
		public bool UseHttps { get; set; }

		/// <summary>
		/// 
		/// RWS protocol version to use. If not specified, <xref href="UnderAutomation.ABB.Rws.RwsVersion.OmniCore_V2_0" data-throw-if-not-resolved="false"></xref> (RWS 2.0) is used.
		/// <p>RWS 2.0 is available in RobotWare >= 7, which ships the new OmniCore controller generation.
		/// For older RobotWare versions running on IRC5 controllers, use <xref href="UnderAutomation.ABB.Rws.RwsVersion.Irc5_V1_0" data-throw-if-not-resolved="false"></xref> (RWS 1.0).</p>
		/// 
		/// </summary>
		public RwsVersion Version { get; set; }
	}
}
