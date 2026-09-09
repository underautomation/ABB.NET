//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// What a symbol search looks for.
	/// <p>Passed to <code>RapidService.SearchSymbols()</code>. Every property is optional; leaving one alone
	/// means the search does not filter on it. A search with no criterion at all walks the whole system,
	/// which is slow, so at least set <xref href="UnderAutomation.ABB.Rws.Data.RapidSymbolSearchCriteria.BlockUrl" data-throw-if-not-resolved="false"></xref>.</p>
	/// 
	/// </summary>
	public class RapidSymbolSearchCriteria : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidSymbolSearchCriteria" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public RapidSymbolSearchCriteria()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Which part of the system the search walks
		/// 
		/// </summary>
		public RapidSymbolSearchView View { get; set; }

		/// <summary>
		/// 
		/// Which variables the search keeps, by what may be done with them
		/// 
		/// </summary>
		public RapidSymbolVariableType VariableType { get; set; }

		/// <summary>
		/// 
		/// Path the search starts from, for example &quot;RAPID/T_ROB1&quot;
		/// 
		/// </summary>
		public string BlockUrl { get; set; }

		/// <summary>
		/// 
		/// Whether the search also walks what the starting point contains, null to leave it to the controller
		/// 
		/// </summary>
		public Nullable<bool> Recursive { get; set; }

		/// <summary>
		/// 
		/// Line the search starts from, used together with <xref href="UnderAutomation.ABB.Rws.Data.RapidSymbolSearchView.Scope" data-throw-if-not-resolved="false"></xref>
		/// 
		/// </summary>
		public Nullable<int> PositionRow { get; set; }

		/// <summary>
		/// 
		/// Column the search starts from, used together with <xref href="UnderAutomation.ABB.Rws.Data.RapidSymbolSearchView.Scope" data-throw-if-not-resolved="false"></xref>
		/// 
		/// </summary>
		public Nullable<int> PositionColumn { get; set; }

		/// <summary>
		/// 
		/// Frame of the call stack the search starts from, used together with
		/// <xref href="UnderAutomation.ABB.Rws.Data.RapidSymbolSearchView.Stack" data-throw-if-not-resolved="false"></xref>
		/// 
		/// </summary>
		public Nullable<int> StackFrame { get; set; }

		/// <summary>
		/// 
		/// Whether only the symbols the program actually refers to are kept, null to leave it to the controller
		/// 
		/// </summary>
		public Nullable<bool> OnlyUsed { get; set; }

		/// <summary>
		/// 
		/// Whether the symbols shared between tasks are skipped, null to leave it to the controller
		/// 
		/// </summary>
		public Nullable<bool> SkipShared { get; set; }

		/// <summary>
		/// 
		/// Regular expression the name of a symbol has to match to be kept
		/// 
		/// </summary>
		public string NamePattern { get; set; }

		/// <summary>
		/// 
		/// Kinds of symbol the search keeps, empty to keep every kind
		/// 
		/// </summary>
		public RapidSymbolType[] SymbolTypes { get; set; }

		/// <summary>
		/// 
		/// Name of the type a symbol has to have to be kept, for example &quot;robtarget&quot;
		/// 
		/// </summary>
		public string DataType { get; set; }
	}
}
