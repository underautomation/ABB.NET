//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Result of a backup restore check.
	/// <p>Returned by <code>ControllerService.CheckRestore(...)</code>.</p>
	/// 
	/// </summary>
	public class CheckRestoreResult : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.CheckRestoreResult" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public CheckRestoreResult()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this check result
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Status of the check
		/// 
		/// </summary>
		public CheckRestoreStatus Status { get; set; }

		/// <summary>
		/// 
		/// Indicates whether the backup can be restored
		/// 
		/// </summary>
		public bool IsAccepted { get; }

		/// <summary>
		/// 
		/// File missing or corrupted in the backup, if reported by the controller
		/// 
		/// </summary>
		public string Path { get; set; }
	}
}
