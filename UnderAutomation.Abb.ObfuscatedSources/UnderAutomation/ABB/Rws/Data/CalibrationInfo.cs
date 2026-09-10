//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// How a mechanical unit was calibrated, joint by joint.
	/// 
	/// <p>Returned by <code>MotionSystemService.GetCalibrationInfo()</code>.</p>
	/// </summary>
	public class CalibrationInfo {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.CalibrationInfo" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public CalibrationInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this calibration
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Kind of calibration window the controller offers for this unit,
		/// null when the controller did not report it
		/// </summary>
		public int? CalibrationWindowType { get; set; }

		/// <summary>
		/// Number of joints of the unit that are in use, null when the controller did not report it
		/// </summary>
		public int? ActiveJointCount { get; set; }

		/// <summary>
		/// Number of entries in <xref href="UnderAutomation.ABB.Rws.Data.CalibrationInfo.Joints" data-throw-if-not-resolved="false"></xref>, which is fixed and larger than
		/// <xref href="UnderAutomation.ABB.Rws.Data.CalibrationInfo.ActiveJointCount" data-throw-if-not-resolved="false"></xref>. Null when the controller did not report it.
		/// </summary>
		public int? JointCount { get; set; }

		/// <summary>
		/// Name of the calibration method the unit was last calibrated with, for example "AxisCalibration"
		/// </summary>
		public string CalibrationMethodUsed { get; set; }

		/// <summary>
		/// One entry per joint slot of the unit, the unused ones marked as such. Never null.
		/// </summary>
		public CalibrationJointInfo[] Joints { get; set; }

		/// <summary>
		/// Number of joints that exist on the unit, counted from <xref href="UnderAutomation.ABB.Rws.Data.CalibrationInfo.Joints" data-throw-if-not-resolved="false"></xref>
		/// </summary>
		public int ExistingJointCount { get; }
	}
}
