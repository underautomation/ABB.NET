//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// State of one axis of a mechanical unit.
	/// <p>Returned by <code>MotionSystemService.GetAxis()</code>.</p>
	/// 
	/// </summary>
	public class AxisInfo : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.AxisInfo" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public AxisInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this axis
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Number of the axis inside its mechanical unit, starting at 1
		/// 
		/// </summary>
		public int Number { get; set; }

		/// <summary>
		/// 
		/// Calibration and synchronization state of the axis
		/// 
		/// </summary>
		public MechanicalUnitStatus Status { get; set; }

		/// <summary>
		/// 
		/// Logical joint number of the axis, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> LogicalAxis { get; set; }
	}
}
