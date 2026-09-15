//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.ABB;
using UnderAutomation.ABB.Rws;

namespace UnderAutomation.ABB.Discovery {
	/// <summary>
	/// An ABB robot controller found on the local network.
	/// 
	/// <p>Returned by <xref href="UnderAutomation.ABB.AbbController.Discover(System.Int32)" data-throw-if-not-resolved="false"></xref>.</p>
	/// </summary>
	public class DiscoveredController {

		/// <summary>
		/// Build connection parameters pointing at this controller, ready for <xref href="UnderAutomation.ABB.AbbController.Connect(UnderAutomation.ABB.ConnectionParameters)" data-throw-if-not-resolved="false"></xref>.
		/// 
		/// <p>The address, the port, the scheme and the RWS version come from the discovery. The user name
		/// and the password keep their default values, change them if the controller needs other ones.</p>
		/// </summary>
		/// <returns>Connection parameters for this controller</returns>
		public ConnectionParameters ToConnectionParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns a string representation of this controller
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the robot system, as configured on the controller.
		/// 
		/// <p>Null when the controller was found by testing the ports of this machine rather than by
		/// hearing it announce itself, because a port tells nothing about the name.</p>
		/// </summary>
		public string SystemName { get; }

		/// <summary>
		/// Full name the controller publishes on the network. It contains <xref href="UnderAutomation.ABB.Discovery.DiscoveredController.SystemName" data-throw-if-not-resolved="false"></xref>.
		/// 
		/// <p>Null when the controller did not announce itself.</p>
		/// </summary>
		public string InstanceName { get; }

		/// <summary>
		/// IPv4 address of the controller
		/// </summary>
		public string Address { get; }

		/// <summary>
		/// Port the Robot Web Services interface listens on.
		/// 
		/// <p>A virtual controller gets a new port from RobotStudio at every start, so this value is
		/// the reason to discover the controller instead of writing the port down.</p>
		/// </summary>
		public int Port { get; }

		/// <summary>
		/// RobotWare version of the controller, for example "7.21.0".
		/// 
		/// <p>Null when the controller does not publish it. Only OmniCore controllers do.</p>
		/// </summary>
		public string RobotWareVersion { get; }

		/// <summary>
		/// Unique identifier of the robot system.
		/// 
		/// <p>Null when the controller does not publish it. Only OmniCore controllers do.</p>
		/// </summary>
		public string SystemId { get; }

		/// <summary>
		/// Port of the PC SDK interface of the controller, or 0 when the controller does not publish it.
		/// 
		/// <p>This SDK does not use that interface, the value is given for information.</p>
		/// </summary>
		public int PcSdkPort { get; }

		/// <summary>
		/// RWS version this controller most probably speaks.
		/// 
		/// <p>This is deduced from what the controller publishes, not from a request sent to it.
		/// Check <xref href="UnderAutomation.ABB.Discovery.DiscoveredController.IsVersionDetected" data-throw-if-not-resolved="false"></xref> before relying on it.</p>
		/// </summary>
		public RwsVersion ProbableVersion { get; }

		/// <summary>
		/// True when <xref href="UnderAutomation.ABB.Discovery.DiscoveredController.ProbableVersion" data-throw-if-not-resolved="false"></xref> is more than a guess.
		/// 
		/// <p>It is always true for a controller found by testing the ports of this machine, because the
		/// controller was asked. For a controller heard announcing itself, it is false when the announcement
		/// did not carry what the version is deduced from, and <xref href="UnderAutomation.ABB.Discovery.DiscoveredController.ProbableVersion" data-throw-if-not-resolved="false"></xref> then holds the
		/// most common value rather than a deduction.</p>
		/// </summary>
		public bool IsVersionDetected { get; }

		/// <summary>
		/// True when the controller serves Robot Web Services over HTTPS.
		/// 
		/// <p>OmniCore controllers use HTTPS, IRC5 controllers use HTTP.</p>
		/// </summary>
		public bool UseHttps { get; }
	}
}
