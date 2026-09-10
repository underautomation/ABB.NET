//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// What a RAPID symbol is declared as.
	/// 
	/// <p>Returned by <code>RapidService.GetSymbolProperties()</code> and <code>RapidService.SearchSymbols()</code>.
	/// A search fills in <xref href="UnderAutomation.ABB.Rws.Data.RapidSymbolProperties.Name" data-throw-if-not-resolved="false"></xref> and leaves <xref href="UnderAutomation.ABB.Rws.Data.RapidSymbolProperties.Storage" data-throw-if-not-resolved="false"></xref> alone, a direct read does the
	/// opposite on some controllers, so treat both as optional.</p>
	/// </summary>
	public class RapidSymbolProperties {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidSymbolProperties" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidSymbolProperties()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this symbol
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Path of the symbol, which the other symbol methods take
		/// </summary>
		public string SymbolUrl { get; set; }

		/// <summary>
		/// Name of the symbol, for example "reg1"
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// What kind of symbol this is
		/// </summary>
		public RapidSymbolType SymbolType { get; set; }

		/// <summary>
		/// Whether the symbol is named, null when the controller did not report it
		/// </summary>
		public bool? Named { get; set; }

		/// <summary>
		/// Name of the type of the symbol, for example "num"
		/// </summary>
		public string DataType { get; set; }

		/// <summary>
		/// Number of array dimensions of the symbol, null when the controller did not report it
		/// </summary>
		public int? Dimensions { get; set; }

		/// <summary>
		/// Size of each array dimension as the controller worded it, empty when the symbol is not an array
		/// </summary>
		public string Dimension { get; set; }

		/// <summary>
		/// Whether the symbol is allocated on the heap, null when the controller did not report it
		/// </summary>
		public bool? Heap { get; set; }

		/// <summary>
		/// Whether the declaration is complete, null when the controller did not report it
		/// </summary>
		public bool? Linked { get; set; }

		/// <summary>
		/// Whether the symbol is local to its module, null when the controller did not report it
		/// </summary>
		public bool? Local { get; set; }

		/// <summary>
		/// Whether the symbol may not be written, null when the controller did not report it
		/// </summary>
		public bool? ReadOnly { get; set; }

		/// <summary>
		/// Whether the symbol is global within its task, null when the controller did not report it
		/// </summary>
		public bool? TaskVariable { get; set; }

		/// <summary>
		/// How the controller stores the symbol, for example "loaded"
		/// </summary>
		public string Storage { get; set; }

		/// <summary>
		/// Path of the type of the symbol, for example "RAPID/num"
		/// </summary>
		public string TypeUrl { get; set; }
	}
}
