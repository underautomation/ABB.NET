//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// One motion instruction of the system whose position can be rewritten to where the robot currently
	/// stands, wherever in whichever task it sits.
	/// 
	/// <p>Returned by <code>RapidService.GetAllModifiablePositions()</code>.</p>
	/// </summary>
	public class RapidModifiablePositionItem {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidModifiablePositionItem" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidModifiablePositionItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this instruction
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the module holding the instruction
		/// </summary>
		public string ModuleName { get; set; }

		/// <summary>
		/// Name of the task holding the module
		/// </summary>
		public string TaskName { get; set; }

		/// <summary>
		/// Line the instruction starts at, null when the controller did not report it
		/// </summary>
		public int? StartRow { get; set; }

		/// <summary>
		/// Column the instruction starts at, null when the controller did not report it
		/// </summary>
		public int? StartColumn { get; set; }

		/// <summary>
		/// Line the instruction ends at, null when the controller did not report it
		/// </summary>
		public int? EndRow { get; set; }

		/// <summary>
		/// Column the instruction ends at, null when the controller did not report it
		/// </summary>
		public int? EndColumn { get; set; }
	}
}
