//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// A breakpoint set in the program of a task.
	/// <p>Returned by <code>RapidService.GetBreakpoints()</code> and <code>RapidService.SetBreakpoint()</code>.
	/// The controller answers a write with the range it actually snapped the breakpoint to, which is the
	/// whole instruction containing the requested position rather than the position itself.</p>
	/// 
	/// </summary>
	public class RapidBreakpoint : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidBreakpoint" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public RapidBreakpoint()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this breakpoint
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Name of the module the breakpoint sits in, null when the controller did not report it
		/// 
		/// </summary>
		public string ModuleName { get; set; }

		/// <summary>
		/// 
		/// Line the breakpoint starts at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> StartRow { get; set; }

		/// <summary>
		/// 
		/// Column the breakpoint starts at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> StartColumn { get; set; }

		/// <summary>
		/// 
		/// Line the breakpoint ends at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> EndRow { get; set; }

		/// <summary>
		/// 
		/// Column the breakpoint ends at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> EndColumn { get; set; }
	}
}
