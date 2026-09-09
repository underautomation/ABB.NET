//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// One category of the instruction palette the FlexPendant editor offers, for example &quot;Prog.Flow&quot;.
	/// <p>Returned by <code>RapidService.GetPalletHeads()</code>; its <xref href="UnderAutomation.ABB.Rws.Data.RapidPalletHeadItem.Number" data-throw-if-not-resolved="false"></xref> is what
	/// <code>RapidService.GetPallet()</code> takes.</p>
	/// 
	/// </summary>
	public class RapidPalletHeadItem : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidPalletHeadItem" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public RapidPalletHeadItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this category
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Name of the category, for example &quot;Motion&amp;Proc.&quot;
		/// 
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 
		/// Number identifying the category, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> Number { get; set; }
	}
}
