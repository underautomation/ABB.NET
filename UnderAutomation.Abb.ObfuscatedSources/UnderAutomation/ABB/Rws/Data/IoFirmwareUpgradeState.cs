//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Progress of a firmware upgrade of an I/O device
	/// 
	/// </summary>
	public sealed class IoFirmwareUpgradeState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The state is unknown, or could not be parsed
		/// 
		/// </summary>
		public const IoFirmwareUpgradeState Unknown;

		/// <summary>
		/// 
		/// The upgrade is performed automatically
		/// 
		/// </summary>
		public const IoFirmwareUpgradeState Automatic;

		/// <summary>
		/// 
		/// The upgrade has to be started manually
		/// 
		/// </summary>
		public const IoFirmwareUpgradeState Manual;

		/// <summary>
		/// 
		/// The firmware information is being collected
		/// 
		/// </summary>
		public const IoFirmwareUpgradeState Info;

		/// <summary>
		/// 
		/// The upgrade resources are being allocated
		/// 
		/// </summary>
		public const IoFirmwareUpgradeState Allocate;

		/// <summary>
		/// 
		/// The upgrade is starting
		/// 
		/// </summary>
		public const IoFirmwareUpgradeState Start;

		/// <summary>
		/// 
		/// The upgrade is running
		/// 
		/// </summary>
		public const IoFirmwareUpgradeState Running;

		/// <summary>
		/// 
		/// The device acknowledged the start of the upgrade
		/// 
		/// </summary>
		public const IoFirmwareUpgradeState RunningStartReceived;

		/// <summary>
		/// 
		/// The firmware is being checked
		/// 
		/// </summary>
		public const IoFirmwareUpgradeState RunningCheckInProgress;

		/// <summary>
		/// 
		/// The device memory is being erased
		/// 
		/// </summary>
		public const IoFirmwareUpgradeState RunningEraseInProgress;

		/// <summary>
		/// 
		/// The firmware is being written to the device
		/// 
		/// </summary>
		public const IoFirmwareUpgradeState RunningBurnInProgress;

		/// <summary>
		/// 
		/// The device acknowledged the end of the upgrade
		/// 
		/// </summary>
		public const IoFirmwareUpgradeState RunningEndReceived;

		/// <summary>
		/// 
		/// The upgraded firmware is being verified
		/// 
		/// </summary>
		public const IoFirmwareUpgradeState Check;

		/// <summary>
		/// 
		/// The upgrade resources are being released
		/// 
		/// </summary>
		public const IoFirmwareUpgradeState Deallocate;

		/// <summary>
		/// 
		/// The upgrade is finished
		/// 
		/// </summary>
		public const IoFirmwareUpgradeState Finished;
	}
}
