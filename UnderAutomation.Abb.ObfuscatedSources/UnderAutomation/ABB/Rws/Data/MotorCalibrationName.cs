//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Names one joint of a mechanical unit carries: the joint itself and the calibration data attached to it.
	/// <p>Returned by <code>MotionSystemService.GetMotorCalibrationNames()</code>.</p>
	/// 
	/// </summary>
	public class MotorCalibrationName : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.MotorCalibrationName" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public MotorCalibrationName()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of these names
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Number of the joint inside its mechanical unit, starting at 1
		/// 
		/// </summary>
		public int Number { get; set; }

		/// <summary>
		/// 
		/// Name of the joint, for example &quot;rob1_1&quot;
		/// 
		/// </summary>
		public string JointName { get; set; }

		/// <summary>
		/// 
		/// Name of the calibration data of the joint, usually the same as <xref href="UnderAutomation.ABB.Rws.Data.MotorCalibrationName.JointName" data-throw-if-not-resolved="false"></xref>
		/// 
		/// </summary>
		public string CalibrationName { get; set; }
	}
}
