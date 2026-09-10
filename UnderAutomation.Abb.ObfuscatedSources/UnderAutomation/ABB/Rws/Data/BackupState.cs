//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// State of the backup operation of the controller
	/// </summary>
	public enum BackupState {

		/// <summary>
		/// The backup state could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// No backup operation
		/// </summary>
		None = 1,

		/// <summary>
		/// A backup operation has been initialized
		/// </summary>
		InitState = 2,

		/// <summary>
		/// A backup operation is running
		/// </summary>
		BackupInProgress = 3,

		/// <summary>
		/// The backup operation finished successfully
		/// </summary>
		BackupReady = 4,

		/// <summary>
		/// The backup operation failed
		/// </summary>
		ErrorDuringBackup = 5,

		/// <summary>
		/// The backup state is invalid
		/// </summary>
		Invalid = 6,
	}
}
