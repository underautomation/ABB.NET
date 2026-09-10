//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Information about a backup stored on the controller file system.
	/// 
	/// <p>Returned by <code>ControllerService.GetBackupInfo(backupPath)</code>.</p>
	/// </summary>
	public class BackupSystemInfo {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.BackupSystemInfo" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public BackupSystemInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this backup information
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the backed up system
		/// </summary>
		public string SystemName { get; set; }

		/// <summary>
		/// RobotWare version of the backed up system.
		/// 
		/// <p>Only available when connected with version 1.</p>
		/// </summary>
		public string RobotWareVersion { get; set; }

		/// <summary>
		/// RobotControl version of the backed up system.
		/// 
		/// <p>Only available when connected with version 2.</p>
		/// </summary>
		public string RobotControlVersion { get; set; }

		/// <summary>
		/// RobotOS version of the backed up system.
		/// 
		/// <p>Only available when connected with version 2.</p>
		/// </summary>
		public string RobotOsVersion { get; set; }

		/// <summary>
		/// Options installed on the backed up system
		/// </summary>
		public string[] Options { get; set; }

		/// <summary>
		/// Number of options installed on the backed up system
		/// </summary>
		public int OptionCount { get; }
	}
}
