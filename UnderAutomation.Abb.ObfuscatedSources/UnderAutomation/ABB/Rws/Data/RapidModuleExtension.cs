//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// How big the source of a module is, which is what it takes to ask for the whole of it as a range.
	/// <p>Returned by <code>RapidService.GetModuleExtension()</code>.</p>
	/// 
	/// </summary>
	public class RapidModuleExtension : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidModuleExtension" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public RapidModuleExtension()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this extension
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Number of lines the module holds, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> LineCount { get; set; }

		/// <summary>
		/// 
		/// Length of the longest line of the module, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> MaxColumnCount { get; set; }

		/// <summary>
		/// 
		/// Counter the controller increments whenever the module changes, null when it did not report it
		/// 
		/// </summary>
		public Nullable<int> ChangeCount { get; set; }
	}
}
