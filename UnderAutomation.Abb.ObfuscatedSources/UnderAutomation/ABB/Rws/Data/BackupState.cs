//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// State of the backup operation of the controller
	/// 
	/// </summary>
	public sealed class BackupState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The backup state could not be determined
		/// 
		/// </summary>
		public const BackupState Unknown;

		/// <summary>
		/// 
		/// No backup operation
		/// 
		/// </summary>
		public const BackupState None;

		/// <summary>
		/// 
		/// A backup operation has been initialized
		/// 
		/// </summary>
		public const BackupState InitState;

		/// <summary>
		/// 
		/// A backup operation is running
		/// 
		/// </summary>
		public const BackupState BackupInProgress;

		/// <summary>
		/// 
		/// The backup operation finished successfully
		/// 
		/// </summary>
		public const BackupState BackupReady;

		/// <summary>
		/// 
		/// The backup operation failed
		/// 
		/// </summary>
		public const BackupState ErrorDuringBackup;

		/// <summary>
		/// 
		/// The backup state is invalid
		/// 
		/// </summary>
		public const BackupState Invalid;
	}
}
