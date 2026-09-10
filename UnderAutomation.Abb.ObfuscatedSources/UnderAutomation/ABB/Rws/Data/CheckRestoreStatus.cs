//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Result status of a backup restore check
	/// </summary>
	public enum CheckRestoreStatus {

		/// <summary>
		/// The status could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The backup is accepted and can be restored
		/// </summary>
		Accepted = 1,

		/// <summary>
		/// The backup was not created from the current system, there might be differences in active options and selected languages
		/// </summary>
		RestoreMismatchSystemId = 2,

		/// <summary>
		/// The current system and the backed up system may be generated from different key ids, possibly with different robot types
		/// </summary>
		RestoreMismatchTemplateId = 3,

		/// <summary>
		/// The backup directory is not complete
		/// </summary>
		DirectoryNotComplete = 4,

		/// <summary>
		/// Error in the configuration data of the backup
		/// </summary>
		ConfigurationDataIncorrect = 5,
	}
}
