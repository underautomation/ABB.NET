//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Result of a firmware upgrade of an I/O device
	/// 
	/// </summary>
	public sealed class IoFirmwareUpgradeStatus : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller did not report a status, or it could not be parsed
		/// 
		/// </summary>
		public const IoFirmwareUpgradeStatus Unknown;

		/// <summary>
		/// 
		/// The upgrade failed
		/// 
		/// </summary>
		public const IoFirmwareUpgradeStatus Error;

		/// <summary>
		/// 
		/// The upgrade finished, the firmware was already up to date
		/// 
		/// </summary>
		public const IoFirmwareUpgradeStatus Ok;

		/// <summary>
		/// 
		/// The upgrade finished, the firmware was updated
		/// 
		/// </summary>
		public const IoFirmwareUpgradeStatus Upgraded;

		/// <summary>
		/// 
		/// The upgrade is pending
		/// 
		/// </summary>
		public const IoFirmwareUpgradeStatus Pending;
	}
}
