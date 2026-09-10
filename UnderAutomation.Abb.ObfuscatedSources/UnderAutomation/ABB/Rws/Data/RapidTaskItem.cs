//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// A RAPID task of the controller, as listed by <code>RapidService.GetTasks()</code>.
	/// 
	/// <p><code>RapidService.GetTask()</code> returns a <xref href="UnderAutomation.ABB.Rws.Data.RapidTaskInfo" data-throw-if-not-resolved="false"></xref>, which adds everything the
	/// controller reports for a single task only.</p>
	/// </summary>
	public class RapidTaskItem {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidTaskItem" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidTaskItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this task
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the task, for example "T_ROB1"
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Kind of task, which decides when the controller runs it
		/// </summary>
		public RapidTaskType Type { get; set; }

		/// <summary>
		/// How far the controller has got in preparing the program of the task
		/// </summary>
		public RapidTaskState TaskState { get; set; }

		/// <summary>
		/// Whether the task is running, and whether it could be
		/// </summary>
		public RapidTaskExecutionState ExecutionState { get; set; }

		/// <summary>
		/// Whether the task is active, null when the controller did not report it
		/// </summary>
		public bool? Active { get; set; }

		/// <summary>
		/// Whether the task can move a mechanical unit, null when the controller did not report it
		/// </summary>
		public bool? MotionTask { get; set; }
	}
}
