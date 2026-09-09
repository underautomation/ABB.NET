//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.ABB.License;
using UnderAutomation.ABB.Rws.Internal;

namespace UnderAutomation.ABB {
	/// <summary>
	/// 
	/// Main class of the SDK that represents a connection to an ABB robot controller
	/// 
	/// </summary>
	public class AbbController : Object {

		/// <summary>
		/// 
		/// Instantiate a new ABB robot controller connection
		/// 
		/// </summary>
		public AbbController()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Connect to robot by IP with default connection parameters
		/// 
		/// </summary>
		/// <param name="ip">IP address or hostname of the robot controller</param>
		public void Connect(string ip)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Initialize a connection to the robot with specified parameters
		/// 
		/// </summary>
		/// <param name="parameters">Connection parameters</param>
		public void Connect(ConnectionParameters parameters)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Disconnect from the robot controller
		/// 
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// If you have a license and a key, please call this static method to register the product and exit the trial period.
		/// You can register a product even if the trial period has ended.
		/// 
		/// </summary>
		/// <param name="licensee">Your organization name</param>
		/// <param name="key">The associated key supplied by UnderAutomation</param>
		/// <returns>Information about the supplied license</returns>
		public static LicenseInfo RegisterLicense(string licensee, string key)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// IP or robot name
		/// 
		/// </summary>
		public string Address { get; }

		/// <summary>
		/// 
		/// Check if the robot controller is connected
		/// 
		/// </summary>
		public bool Enabled { get; }

		/// <summary>
		/// 
		/// RWS client providing access to Robot Web Services API (controller, panel, IO, RAPID, file system, subscriptions)
		/// 
		/// </summary>
		public RwsClientInternal Rws { get; }

		/// <summary>
		/// 
		/// Return information about your license
		/// 
		/// </summary>
		public static LicenseInfo LicenseInfo { get; }
	}
}
