//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.ABB.Rws.Internal;

namespace UnderAutomation.ABB.Rws {
	/// <summary>
	/// Standalone public RWS client for ABB robot controllers.
	/// Supports both RWS v1 and v2.
	/// Use this class when you want to connect to a robot without using the <xref href="UnderAutomation.ABB.AbbController" data-throw-if-not-resolved="false"></xref> class.
	/// </summary>
	public class RwsClient : RwsClientBase {

		/// <summary>
		/// Create a new RWS client instance
		/// </summary>
		public RwsClient()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connect to the robot controller RWS service
		/// </summary>
		/// <param name="ip">IP address or hostname of the robot controller</param>
		/// <param name="username">Username for Digest Authentication (default: "Default User")</param>
		/// <param name="password">Password for Digest Authentication (default: "robotics")</param>
		/// <param name="port">RWS service port. If set to 0, the default port will be used (80 for HTTP, 443 for HTTPS).</param>
		/// <param name="timeout">HTTP request timeout in milliseconds (default: 10000)</param>
		/// <param name="useHttps">Whether to use HTTPS (default: false)</param>
		/// <param name="version">RWS protocol version (default: <xref href="UnderAutomation.ABB.Rws.RwsVersion.OmniCore_V2_0" data-throw-if-not-resolved="false"></xref>)</param>
		public void Connect(string ip, string username = "Default User", string password = "robotics", int port = 0, int timeout = 10000, bool useHttps = false, RwsVersion version = RwsVersion.OmniCore_V2_0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
