//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// The value of a RAPID symbol and where it is declared.
	/// <p>Returned by <code>RapidService.GetSymbolValue()</code>. The value is the text the controller wrote it
	/// as, which for a record is the bracketed form RAPID itself uses, for example
	/// <code>[[515,0,712],[0.707107,0,0.707107,0],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]]</code>.</p>
	/// 
	/// </summary>
	public class RapidSymbolValue : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidSymbolValue" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public RapidSymbolValue()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this value
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Value of the symbol, written the way RAPID writes it
		/// 
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// 
		/// Where the symbol is declared, null when the controller did not report it
		/// 
		/// </summary>
		public RapidTextRange DeclarationPosition { get; set; }

		/// <summary>
		/// 
		/// Where the initial value of the symbol is written, null when the controller did not report it.
		/// <p>The controller reports zeros when the declaration carries no initial value.</p>
		/// 
		/// </summary>
		public RapidTextRange InitialValuePosition { get; set; }
	}
}
