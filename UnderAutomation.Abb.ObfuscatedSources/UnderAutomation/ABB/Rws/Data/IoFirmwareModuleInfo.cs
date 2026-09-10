//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Firmware upgrade status of one module of an I/O device.
	/// 
	/// <p>Returned by <code>IoService.GetDeviceUpgradeInfo()</code>.</p>
	/// </summary>
	public class IoFirmwareModuleInfo {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.IoFirmwareModuleInfo" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public IoFirmwareModuleInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this module
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Index of the module inside the device ("0", "1", ...)
		/// </summary>
		public string Index { get; set; }

		/// <summary>
		/// Progress of the firmware upgrade of this module
		/// </summary>
		public IoFirmwareUpgradeState State { get; set; }

		/// <summary>
		/// Result of the firmware upgrade of this module
		/// </summary>
		public IoFirmwareUpgradeStatus Status { get; set; }

		/// <summary>
		/// Name of the program installed on the module, for example "A_HYPIOM_B_3_8"
		/// </summary>
		public string ProgramName { get; set; }

		/// <summary>
		/// Serial number of the module
		/// </summary>
		public string SerialNumber { get; set; }

		/// <summary>
		/// Hardware revision of the module, for example "C.1"
		/// </summary>
		public string HardwareRevision { get; set; }

		/// <summary>
		/// Name of the latest program available for the module
		/// </summary>
		public string LatestProgramNameAvailable { get; set; }
	}
}
