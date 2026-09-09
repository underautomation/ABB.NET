//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.ABB.Rws.Internal;

namespace UnderAutomation.ABB.Rws {
	/// <summary>
	/// 
	/// Connection parameters for ABB Robot Web Services (RWS).
	/// Supports both RWS v1 and v2.
	/// 
	/// </summary>
	public class RwsConnectParameters : RwsConnectParametersBase {

		/// <summary>
		/// 
		/// Default RWS port (80 for HTTP, 443 for HTTPS)
		/// 
		/// </summary>
		public const int DEFAULT_PORT = 80;

		/// <summary>
		/// 
		/// Default username for Digest Authentication
		/// 
		/// </summary>
		public const string DEFAULT_USERNAME = "Default User";

		/// <summary>
		/// 
		/// Default password for Digest Authentication
		/// 
		/// </summary>
		public const string DEFAULT_PASSWORD = "robotics";

		/// <summary>
		/// 
		/// Default timeout in milliseconds
		/// 
		/// </summary>
		public const int DEFAULT_TIMEOUT = 10000;


		public RwsConnectParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Enable or disable the RWS client connection
		/// 
		/// </summary>
		public bool Enable { get; set; }
	}
}
