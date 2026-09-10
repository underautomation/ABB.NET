//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Result of a firmware upgrade of an I/O device
	/// </summary>
	public enum IoFirmwareUpgradeStatus {

		/// <summary>
		/// The controller did not report a status, or it could not be parsed
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The upgrade failed
		/// </summary>
		Error = 1,

		/// <summary>
		/// The upgrade finished, the firmware was already up to date
		/// </summary>
		Ok = 2,

		/// <summary>
		/// The upgrade finished, the firmware was updated
		/// </summary>
		Upgraded = 3,

		/// <summary>
		/// The upgrade is pending
		/// </summary>
		Pending = 4,
	}
}
