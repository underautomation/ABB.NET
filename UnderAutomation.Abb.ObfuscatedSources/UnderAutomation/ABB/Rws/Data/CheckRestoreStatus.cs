//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Result status of a backup restore check
	/// 
	/// </summary>
	public sealed class CheckRestoreStatus : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The status could not be determined
		/// 
		/// </summary>
		public const CheckRestoreStatus Unknown;

		/// <summary>
		/// 
		/// The backup is accepted and can be restored
		/// 
		/// </summary>
		public const CheckRestoreStatus Accepted;

		/// <summary>
		/// 
		/// The backup was not created from the current system, there might be differences in active options and selected languages
		/// 
		/// </summary>
		public const CheckRestoreStatus RestoreMismatchSystemId;

		/// <summary>
		/// 
		/// The current system and the backed up system may be generated from different key ids, possibly with different robot types
		/// 
		/// </summary>
		public const CheckRestoreStatus RestoreMismatchTemplateId;

		/// <summary>
		/// 
		/// The backup directory is not complete
		/// 
		/// </summary>
		public const CheckRestoreStatus DirectoryNotComplete;

		/// <summary>
		/// 
		/// Error in the configuration data of the backup
		/// 
		/// </summary>
		public const CheckRestoreStatus ConfigurationDataIncorrect;
	}
}
