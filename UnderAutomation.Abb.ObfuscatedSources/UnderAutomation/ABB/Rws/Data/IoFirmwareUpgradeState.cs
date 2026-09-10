//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Progress of a firmware upgrade of an I/O device
	/// </summary>
	public enum IoFirmwareUpgradeState {

		/// <summary>
		/// The state is unknown, or could not be parsed
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The upgrade is performed automatically
		/// </summary>
		Automatic = 1,

		/// <summary>
		/// The upgrade has to be started manually
		/// </summary>
		Manual = 2,

		/// <summary>
		/// The firmware information is being collected
		/// </summary>
		Info = 3,

		/// <summary>
		/// The upgrade resources are being allocated
		/// </summary>
		Allocate = 4,

		/// <summary>
		/// The upgrade is starting
		/// </summary>
		Start = 5,

		/// <summary>
		/// The upgrade is running
		/// </summary>
		Running = 6,

		/// <summary>
		/// The device acknowledged the start of the upgrade
		/// </summary>
		RunningStartReceived = 7,

		/// <summary>
		/// The firmware is being checked
		/// </summary>
		RunningCheckInProgress = 8,

		/// <summary>
		/// The device memory is being erased
		/// </summary>
		RunningEraseInProgress = 9,

		/// <summary>
		/// The firmware is being written to the device
		/// </summary>
		RunningBurnInProgress = 10,

		/// <summary>
		/// The device acknowledged the end of the upgrade
		/// </summary>
		RunningEndReceived = 11,

		/// <summary>
		/// The upgraded firmware is being verified
		/// </summary>
		Check = 12,

		/// <summary>
		/// The upgrade resources are being released
		/// </summary>
		Deallocate = 13,

		/// <summary>
		/// The upgrade is finished
		/// </summary>
		Finished = 14,
	}
}
