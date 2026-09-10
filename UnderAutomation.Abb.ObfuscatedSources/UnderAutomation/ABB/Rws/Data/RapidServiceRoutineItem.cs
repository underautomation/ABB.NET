//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// A routine of a task the program pointer can be moved to.
	/// 
	/// <p>Returned by <code>RapidService.GetServiceRoutines()</code>.</p>
	/// </summary>
	public class RapidServiceRoutineItem {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidServiceRoutineItem" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidServiceRoutineItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this routine
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the routine, for example "LoadIdentify"
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Path of the routine, which <code>RapidService.SetProgramPointerToRoutineUrl()</code> takes
		/// </summary>
		public string Url { get; set; }

		/// <summary>
		/// Whether this is a service routine rather than an ordinary one, null when the controller
		/// did not report it
		/// </summary>
		public bool? IsServiceRoutine { get; set; }
	}
}
