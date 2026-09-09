//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// A mechanical unit the positions of a task are expressed in.
	/// <p>Returned by <code>RapidService.GetMechanicalUnits()</code>. This is the view the RAPID task has of the
	/// unit; <code>MotionSystemService.GetMechanicalUnits()</code> answers with everything the motion system knows
	/// about the same units.</p>
	/// 
	/// </summary>
	public class RapidMechanicalUnitItem : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidMechanicalUnitItem" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public RapidMechanicalUnitItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this unit
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Name of the unit, for example &quot;ROB_1&quot;
		/// 
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 
		/// Whether the unit is activated
		/// 
		/// </summary>
		public MechanicalUnitMode Mode { get; set; }

		/// <summary>
		/// 
		/// Kind of unit
		/// 
		/// </summary>
		public MechanicalUnitType Type { get; set; }
	}
}
