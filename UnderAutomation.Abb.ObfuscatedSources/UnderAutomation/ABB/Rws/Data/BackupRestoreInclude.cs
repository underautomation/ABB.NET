//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Content included when restoring a backup
	/// 
	/// </summary>
	public sealed class BackupRestoreInclude : Enum {


		public int value__;

		/// <summary>
		/// 
		/// Restore configuration files and RAPID modules
		/// 
		/// </summary>
		public const BackupRestoreInclude All;

		/// <summary>
		/// 
		/// Restore configuration files only
		/// 
		/// </summary>
		public const BackupRestoreInclude Cfg;

		/// <summary>
		/// 
		/// Restore RAPID modules only
		/// 
		/// </summary>
		public const BackupRestoreInclude Modules;
	}
}
