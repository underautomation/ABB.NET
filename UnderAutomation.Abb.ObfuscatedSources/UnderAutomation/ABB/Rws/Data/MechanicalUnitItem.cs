//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// One mechanical unit of the motion system, as listed by <code>MotionSystemService.GetMechanicalUnits()</code>.
	/// 
	/// <p>Only the few properties the list carries are filled in. Read the unit itself with
	/// <code>MotionSystemService.GetMechanicalUnit()</code> to get a <xref href="UnderAutomation.ABB.Rws.Data.MechanicalUnitInfo" data-throw-if-not-resolved="false"></xref>.</p>
	/// </summary>
	public class MechanicalUnitItem {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.MechanicalUnitItem" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public MechanicalUnitItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this mechanical unit
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the mechanical unit, for example "ROB_1"
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Whether the unit is activated
		/// </summary>
		public MechanicalUnitMode Mode { get; set; }

		/// <summary>
		/// Whether the unit can be activated, null when the controller did not report it
		/// </summary>
		public bool? ActivationAllowed { get; set; }

		/// <summary>
		/// Number of the drive module the unit is connected to, null when the controller did not report it
		/// </summary>
		public int? DriveModule { get; set; }
	}
}
