//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Mismatches between a backup and the current system that are ignored when restoring
	/// 
	/// </summary>
	public sealed class BackupRestoreIgnore : Enum {


		public int value__;

		/// <summary>
		/// 
		/// No mismatch is ignored
		/// 
		/// </summary>
		public const BackupRestoreIgnore None;

		/// <summary>
		/// 
		/// All mismatches are ignored
		/// 
		/// </summary>
		public const BackupRestoreIgnore All;

		/// <summary>
		/// 
		/// A mismatch between the system id of the backup and the system id of the current system is ignored
		/// 
		/// </summary>
		public const BackupRestoreIgnore SystemId;

		/// <summary>
		/// 
		/// A mismatch between the template id of the backup and the template id of the current system is ignored
		/// 
		/// </summary>
		public const BackupRestoreIgnore TemplateId;
	}
}
