//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// The routine the controller finds called at a given position of a module.
	/// <p>Returned by <code>RapidService.GetRoutine()</code>. The controller refuses the request when the
	/// position does not sit on a routine call.</p>
	/// 
	/// </summary>
	public class RapidRoutineInfo : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidRoutineInfo" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public RapidRoutineInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this routine
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Path of the routine, which the program pointer resources take
		/// 
		/// </summary>
		public string SymbolUrl { get; set; }

		/// <summary>
		/// 
		/// Name of the routine
		/// 
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 
		/// Whether the routine is a procedure, a function or a trap
		/// 
		/// </summary>
		public RapidSymbolType SymbolType { get; set; }

		/// <summary>
		/// 
		/// Whether the routine is named, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<bool> Named { get; set; }

		/// <summary>
		/// 
		/// Whether the routine is local to its module, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<bool> Local { get; set; }

		/// <summary>
		/// 
		/// Number of parameters the routine takes, null when the controller did not report it.
		/// <p>The controller reports -1 when the parameter list is not linked yet.</p>
		/// 
		/// </summary>
		public Nullable<int> ParameterCount { get; set; }
	}
}
