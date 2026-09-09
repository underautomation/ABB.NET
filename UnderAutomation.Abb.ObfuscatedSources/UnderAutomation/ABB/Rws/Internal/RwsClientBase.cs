//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.ABB.Rws;
using UnderAutomation.ABB.Rws.Services;

namespace UnderAutomation.ABB.Rws.Internal {
	/// <summary>
	/// 
	/// Base class providing HTTP communication with ABB RWS REST API.
	/// Handles Digest Authentication, request building and XML response parsing.
	/// Supports both RWS v1 and v2.
	/// 
	/// </summary>
	public abstract class RwsClientBase : Object {

		/// <summary>
		/// 
		/// Disconnect from the robot controller
		/// 
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		protected RwsClientBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// IP address or hostname of the robot controller
		/// 
		/// </summary>
		public string Ip { get; }

		/// <summary>
		/// 
		/// Port of the RWS service
		/// 
		/// </summary>
		public int Port { get; }

		/// <summary>
		/// 
		/// Whether the connection uses HTTPS
		/// 
		/// </summary>
		public bool UseHttps { get; }

		/// <summary>
		/// 
		/// HTTP request timeout in milliseconds
		/// 
		/// </summary>
		public int Timeout { get; }

		/// <summary>
		/// 
		/// Whether the client is connected and ready
		/// 
		/// </summary>
		public bool Enabled { get; }

		/// <summary>
		/// 
		/// RWS protocol version this client talks to
		/// 
		/// </summary>
		public RwsVersion Version { get; }

		/// <summary>
		/// 
		/// File Service
		/// 
		/// </summary>
		public FileService File { get; }

		/// <summary>
		/// 
		/// Controller Service
		/// 
		/// </summary>
		public ControllerService Controller { get; }

		/// <summary>
		/// 
		/// I/O System Service
		/// 
		/// </summary>
		public IoService Io { get; }

		/// <summary>
		/// 
		/// Event Log Service
		/// 
		/// </summary>
		public ElogService Elog { get; }

		/// <summary>
		/// 
		/// System Service
		/// 
		/// </summary>
		public SystemService System { get; }

		/// <summary>
		/// 
		/// Control Panel Service
		/// 
		/// </summary>
		public PanelService Panel { get; }

		/// <summary>
		/// 
		/// Motion System Service
		/// 
		/// </summary>
		public MotionSystemService MotionSystem { get; }

		/// <summary>
		/// 
		/// Mastership Service
		/// 
		/// </summary>
		public MastershipService Mastership { get; }

		/// <summary>
		/// 
		/// RAPID Service
		/// 
		/// </summary>
		public RapidService Rapid { get; }
	}
}
