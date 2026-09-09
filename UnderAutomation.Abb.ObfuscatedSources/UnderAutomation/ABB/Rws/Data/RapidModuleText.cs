//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// The source of a module and the counters that go with it.
	/// <p>Returned by <code>RapidService.GetModuleText()</code>.</p>
	/// 
	/// </summary>
	public class RapidModuleText : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidModuleText" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public RapidModuleText()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this module source
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Source of the module
		/// 
		/// </summary>
		public string Text { get; set; }

		/// <summary>
		/// 
		/// Counter the controller increments whenever the module changes, null when it did not report it
		/// 
		/// </summary>
		public Nullable<int> ChangeCount { get; set; }

		/// <summary>
		/// 
		/// Length the controller declares for the module, null when it did not report it.
		/// <p>This is the size the controller reserves for the module and not the length of
		/// <xref href="UnderAutomation.ABB.Rws.Data.RapidModuleText.Text" data-throw-if-not-resolved="false"></xref>, so the two normally differ.</p>
		/// 
		/// </summary>
		public Nullable<int> DeclaredLength { get; set; }
	}
}
