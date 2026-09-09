//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Where the program pointer of a task stands, expressed as the piece of source it points at.
	/// <p>Returned by <code>RapidService.GetProgramCounterPosition()</code>. The controller refuses the request
	/// when the task has no program pointer set, so reset it or start the program first.</p>
	/// 
	/// </summary>
	public class RapidProgramCounterPosition : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidProgramCounterPosition" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public RapidProgramCounterPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this position
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Name of the module the pointer stands in
		/// 
		/// </summary>
		public string Module { get; set; }

		/// <summary>
		/// 
		/// Name of the routine the pointer stands in
		/// 
		/// </summary>
		public string Routine { get; set; }

		/// <summary>
		/// 
		/// Line the pointed instruction starts at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> StartLine { get; set; }

		/// <summary>
		/// 
		/// Column the pointed instruction starts at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> StartColumn { get; set; }

		/// <summary>
		/// 
		/// Line the pointed instruction ends at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> EndLine { get; set; }

		/// <summary>
		/// 
		/// Column the pointed instruction ends at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> EndColumn { get; set; }
	}
}
