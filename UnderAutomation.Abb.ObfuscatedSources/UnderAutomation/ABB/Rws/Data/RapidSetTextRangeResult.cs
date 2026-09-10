//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// What the controller did with a change written into the source of a module.
	/// 
	/// <p>Returned by <code>RapidService.SetModuleTextRange()</code>. Rewriting the MODULE line renames the
	/// module, which is why the controller reports the name it ended up with.</p>
	/// </summary>
	public class RapidSetTextRangeResult {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidSetTextRangeResult" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidSetTextRangeResult()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this result
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Whether the change renamed the module
		/// </summary>
		public bool ModuleRenamed { get; set; }

		/// <summary>
		/// Name the module now has, empty when the change did not rename it
		/// </summary>
		public string NewModuleName { get; set; }

		/// <summary>
		/// Counter the controller incremented for the change, null when it did not report it
		/// </summary>
		public int? ChangeCount { get; set; }
	}
}
