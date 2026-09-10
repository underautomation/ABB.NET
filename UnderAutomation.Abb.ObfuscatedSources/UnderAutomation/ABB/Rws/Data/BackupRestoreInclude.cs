//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Content included when restoring a backup
	/// </summary>
	public enum BackupRestoreInclude {

		/// <summary>
		/// Restore configuration files and RAPID modules
		/// </summary>
		All = 0,

		/// <summary>
		/// Restore configuration files only
		/// </summary>
		Cfg = 1,

		/// <summary>
		/// Restore RAPID modules only
		/// </summary>
		Modules = 2,
	}
}
