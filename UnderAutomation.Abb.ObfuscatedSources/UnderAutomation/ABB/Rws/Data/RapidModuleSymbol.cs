//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// The declaration the controller finds at a given position of a module.
	/// 
	/// <p>Returned by <code>RapidService.GetModuleSymbol()</code>, which returns null when there is no
	/// declaration at that position.</p>
	/// </summary>
	public class RapidModuleSymbol {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidModuleSymbol" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidModuleSymbol()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this declaration
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Version the controller stamps on the declaration
		/// </summary>
		public string Version { get; set; }

		/// <summary>
		/// Name of the declared symbol
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Path of the symbol, which the symbol resources take
		/// </summary>
		public string SymbolUrl { get; set; }

		/// <summary>
		/// What kind of symbol was declared
		/// </summary>
		public RapidSymbolType SymbolType { get; set; }

		/// <summary>
		/// Whether the declaration is complete, null when the controller did not report it
		/// </summary>
		public bool? Linked { get; set; }

		/// <summary>
		/// Whether the symbol is local to its module, null when the controller did not report it
		/// </summary>
		public bool? Local { get; set; }

		/// <summary>
		/// Path of the type of the symbol
		/// </summary>
		public string TypeUrl { get; set; }

		/// <summary>
		/// Name of the type of the symbol, for example "robtarget"
		/// </summary>
		public string DataType { get; set; }

		/// <summary>
		/// Number of array dimensions of the symbol, null when the controller did not report it
		/// </summary>
		public int? Dimensions { get; set; }

		/// <summary>
		/// How the controller stores the symbol, null when it did not report it
		/// </summary>
		public int? Storage { get; set; }

		/// <summary>
		/// Whether the symbol is allocated on the heap, null when the controller did not report it
		/// </summary>
		public bool? Heap { get; set; }

		/// <summary>
		/// How many times the symbol is referred to, null when the controller did not report it
		/// </summary>
		public int? ReferenceCount { get; set; }
	}
}
