//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// The two counters a task keeps of what has changed in it, so that a client can tell whether it needs
	/// to read the task again instead of fetching everything periodically.
	/// 
	/// <p>Returned by <code>RapidService.GetStructuralChangeCount()</code>.</p>
	/// </summary>
	public class RapidStructuralChangeCount {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidStructuralChangeCount" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidStructuralChangeCount()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of these counters
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Counter the controller increments whenever anything relevant changes in the task
		/// </summary>
		public int? ChangeCount { get; set; }

		/// <summary>
		/// Counter the controller increments when a module is loaded, unloaded or renamed.
		/// 
		/// <p>A rename counts as an unload followed by a load.</p>
		/// </summary>
		public int? StructuralChangeCount { get; set; }
	}
}
