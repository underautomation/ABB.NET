//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Firmware upgrade status of an I/O device and of each of its modules.
	/// 
	/// <p>Returned by <code>IoService.GetDeviceUpgradeInfo()</code>.</p>
	/// <p>Only applicable to a real controller.</p>
	/// </summary>
	public class IoDeviceUpgradeInfo {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.IoDeviceUpgradeInfo" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public IoDeviceUpgradeInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this upgrade information
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Overall progress of the firmware upgrade of the device
		/// </summary>
		public IoFirmwareUpgradeState State { get; set; }

		/// <summary>
		/// Overall result of the firmware upgrade of the device
		/// </summary>
		public IoFirmwareUpgradeStatus Status { get; set; }

		/// <summary>
		/// Firmware status of each module of the device, empty when the controller reported none
		/// </summary>
		public IoFirmwareModuleInfo[] Modules { get; set; }

		/// <summary>
		/// Number of modules reported by the controller
		/// </summary>
		public int ModuleCount { get; }
	}
}
