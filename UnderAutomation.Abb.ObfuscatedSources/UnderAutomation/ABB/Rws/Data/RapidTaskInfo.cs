//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Everything the controller reports about one RAPID task.
	/// 
	/// <p>Returned by <code>RapidService.GetTask()</code>; the task lists only carry the properties of the
	/// <xref href="UnderAutomation.ABB.Rws.Data.RapidTaskItem" data-throw-if-not-resolved="false"></xref> base class.</p>
	/// </summary>
	public class RapidTaskInfo : RapidTaskItem {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidTaskInfo" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidTaskInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// What the controller does to the system when this task stops unexpectedly
		/// </summary>
		public RapidTaskTrustLevel Trust { get; set; }

		/// <summary>
		/// Identifier of the task, null when the controller did not report it
		/// </summary>
		public int? TaskId { get; set; }

		/// <summary>
		/// Level at which the code of the task is currently executing
		/// </summary>
		public RapidExecutionLevel ExecutionLevel { get; set; }

		/// <summary>
		/// Stepping mode the task was last started with
		/// </summary>
		public RapidTaskExecutionMode ExecutionMode { get; set; }

		/// <summary>
		/// What kind of code the task is currently running
		/// </summary>
		public RapidExecutionType ExecutionType { get; set; }

		/// <summary>
		/// Number of cycles the task is set to run.
		/// 
		/// <p>Only reported over a connection established with version 2, and left to
		/// <xref href="UnderAutomation.ABB.Rws.Data.RapidExecutionCycle.Unknown" data-throw-if-not-resolved="false"></xref> otherwise.</p>
		/// </summary>
		public RapidExecutionCycle ExecutionCycle { get; set; }

		/// <summary>
		/// Routine the program pointer moves to when it is reset, for example "main"
		/// </summary>
		public string ProductionEntryPoint { get; set; }

		/// <summary>
		/// Whether the task is bound to a configured task number, null when the controller did not report it
		/// </summary>
		public bool? BindReference { get; set; }

		/// <summary>
		/// Name of the task running in the foreground, empty when there is none
		/// </summary>
		public string TaskInForeground { get; set; }
	}
}
