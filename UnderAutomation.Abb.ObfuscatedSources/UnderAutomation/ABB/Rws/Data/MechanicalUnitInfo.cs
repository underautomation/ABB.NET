//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Everything the controller knows about one mechanical unit.
	/// <p>Returned by <code>MotionSystemService.GetMechanicalUnit()</code>.</p>
	/// 
	/// </summary>
	public class MechanicalUnitInfo : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.MechanicalUnitInfo" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public MechanicalUnitInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this mechanical unit
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Name of the mechanical unit, for example &quot;ROB_1&quot;
		/// 
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 
		/// Name of the active tool
		/// 
		/// </summary>
		public string ToolName { get; set; }

		/// <summary>
		/// 
		/// Name of the active work object
		/// 
		/// </summary>
		public string WorkObjectName { get; set; }

		/// <summary>
		/// 
		/// Name of the active payload
		/// 
		/// </summary>
		public string PayloadName { get; set; }

		/// <summary>
		/// 
		/// Name of the active total payload, which is the payload plus the load of the tool
		/// 
		/// </summary>
		public string TotalPayloadName { get; set; }

		/// <summary>
		/// 
		/// Calibration and synchronization state of the unit
		/// 
		/// </summary>
		public MechanicalUnitStatus Status { get; set; }

		/// <summary>
		/// 
		/// Whether the unit is activated
		/// 
		/// </summary>
		public MechanicalUnitMode Mode { get; set; }

		/// <summary>
		/// 
		/// How the jogging commands sent to the unit are interpreted
		/// 
		/// </summary>
		public JogMode JogMode { get; set; }

		/// <summary>
		/// 
		/// Kind of mechanical unit
		/// 
		/// </summary>
		public MechanicalUnitType Type { get; set; }

		/// <summary>
		/// 
		/// Name of the RAPID task that drives the unit
		/// 
		/// </summary>
		public string TaskName { get; set; }

		/// <summary>
		/// 
		/// Reference frame the cartesian positions of the unit are expressed in
		/// 
		/// </summary>
		public CoordinateSystem CoordinateSystem { get; set; }

		/// <summary>
		/// 
		/// Number of axes of the unit, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> Axes { get; set; }

		/// <summary>
		/// 
		/// Number of axes of the unit and of the units integrated with it,
		/// null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> TotalAxes { get; set; }

		/// <summary>
		/// 
		/// Name of the mechanical unit this one is integrated into. A unit that is integrated into no other
		/// one is reported with a placeholder name rather than an empty value.
		/// 
		/// </summary>
		public string IsIntegratedUnit { get; set; }

		/// <summary>
		/// 
		/// Name of the mechanical unit integrated into this one. A unit that integrates no other one is
		/// reported with a placeholder name rather than an empty value.
		/// 
		/// </summary>
		public string HasIntegratedUnit { get; set; }
	}
}
