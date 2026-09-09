//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Where one of the two pointers of a task stands.
	/// <p>Carried by <xref href="UnderAutomation.ABB.Rws.Data.RapidPointers" data-throw-if-not-resolved="false"></xref>. <xref href="UnderAutomation.ABB.Rws.Data.RapidPointerPosition.Available" data-throw-if-not-resolved="false"></xref> tells apart a pointer that is
	/// really placed somewhere from one the controller could not report, which happens for the motion
	/// pointer whenever the task has not moved yet.</p>
	/// 
	/// </summary>
	public class RapidPointerPosition : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidPointerPosition" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public RapidPointerPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this pointer position
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Whether the controller reported a position for this pointer at all
		/// 
		/// </summary>
		public bool Available { get; set; }

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
		/// Line the pointer begins at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> BeginRow { get; set; }

		/// <summary>
		/// 
		/// Column the pointer begins at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> BeginColumn { get; set; }

		/// <summary>
		/// 
		/// Line the pointer ends at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> EndRow { get; set; }

		/// <summary>
		/// 
		/// Column the pointer ends at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> EndColumn { get; set; }

		/// <summary>
		/// 
		/// How many times the pointer has been moved, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> ChangeCount { get; set; }

		/// <summary>
		/// 
		/// What kind of code the pointer is standing in
		/// 
		/// </summary>
		public RapidExecutionType ExecutionType { get; set; }
	}
}
