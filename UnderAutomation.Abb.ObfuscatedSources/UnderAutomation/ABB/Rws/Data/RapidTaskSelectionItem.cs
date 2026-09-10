//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// One line of the task selection panel, telling whether a task is selected and whether an
	/// operator is allowed to change that.
	/// 
	/// <p>Returned by <code>RapidService.GetTaskSelection()</code>.</p>
	/// </summary>
	public class RapidTaskSelectionItem {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidTaskSelectionItem" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidTaskSelectionItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this task selection
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
		/// Whether the task is selected, null when the controller did not report it
		/// </summary>
		public bool? Selected { get; set; }

		/// <summary>
		/// Whether the task can move a mechanical unit, null when the controller did not report it
		/// </summary>
		public bool? MotionTask { get; set; }

		/// <summary>
		/// Whether an operator is allowed to change the selection of this task, null when the
		/// controller did not report it
		/// </summary>
		public bool? UserModify { get; set; }
	}
}
