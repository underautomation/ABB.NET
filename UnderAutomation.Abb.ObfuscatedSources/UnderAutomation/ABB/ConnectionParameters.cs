//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.ABB.Rws;

namespace UnderAutomation.ABB {
	/// <summary>
	/// Connection parameters for an ABB robot controller
	/// </summary>
	public class ConnectionParameters {

		/// <summary>
		/// Instantiate new connection parameters with default values
		/// </summary>
		public ConnectionParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Instantiate new connection parameters with a specified address
		/// </summary>
		/// <param name="address">IP address or hostname of the robot controller</param>
		public ConnectionParameters(string address)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Address of the robot controller (IP or host name), default value is 127.0.0.1
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// Send a ping command before initializing any connections
		/// </summary>
		public bool PingBeforeConnect { get; set; }

		/// <summary>
		/// RWS2 (Robot Web Services 2) connection parameters
		/// </summary>
		public RwsConnectParameters Rws { get; set; }
	}
}
