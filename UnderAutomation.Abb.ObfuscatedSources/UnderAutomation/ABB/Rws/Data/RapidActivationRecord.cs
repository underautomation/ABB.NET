//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// One frame of the call stack of a task: which routine is running and where the execution stands in it.
	/// <p>Returned by <code>RapidService.GetActivationRecord()</code>. Frame 1 is the routine holding the program
	/// pointer, and the number grows towards the entry point of the program.</p>
	/// 
	/// </summary>
	public class RapidActivationRecord : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidActivationRecord" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public RapidActivationRecord()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this stack frame
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Level at which this frame is executing
		/// 
		/// </summary>
		public RapidExecutionLevel ExecutionLevel { get; set; }

		/// <summary>
		/// 
		/// Line the executing statement starts at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> BeginRow { get; set; }

		/// <summary>
		/// 
		/// Column the executing statement starts at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> BeginColumn { get; set; }

		/// <summary>
		/// 
		/// Line the executing statement ends at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> EndRow { get; set; }

		/// <summary>
		/// 
		/// Column the executing statement ends at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> EndColumn { get; set; }

		/// <summary>
		/// 
		/// Path identifying this stack frame, which the UI instruction resources also take
		/// 
		/// </summary>
		public string StackUrl { get; set; }

		/// <summary>
		/// 
		/// Path of the routine this frame is executing
		/// 
		/// </summary>
		public string RoutineUrl { get; set; }
	}
}
