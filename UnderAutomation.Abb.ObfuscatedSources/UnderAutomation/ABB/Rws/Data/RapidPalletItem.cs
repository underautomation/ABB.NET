//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// One entry of an instruction palette category, which an editor offers as something the operator can
	/// insert at the cursor.
	/// 
	/// <p>Returned by <code>RapidService.GetPallet()</code>.</p>
	/// </summary>
	public class RapidPalletItem {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidPalletItem" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidPalletItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this entry
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name shown for the entry, for example "MoveJ"
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Instruction the entry inserts
		/// </summary>
		public string Instruction { get; set; }

		/// <summary>
		/// Parameter the entry preselects, null when the controller did not report it
		/// </summary>
		public int? Parameter { get; set; }

		/// <summary>
		/// Alternative of the parameter the entry preselects, null when the controller did not report it
		/// </summary>
		public int? Alternative { get; set; }

		/// <summary>
		/// Whether the entry is a language keyword rather than an instruction, null when the controller
		/// did not report it
		/// </summary>
		public int? Keyword { get; set; }
	}
}
