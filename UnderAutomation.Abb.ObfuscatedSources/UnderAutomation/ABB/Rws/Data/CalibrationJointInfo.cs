//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// How one joint of a mechanical unit was calibrated.
	/// <p>Held by <xref href="UnderAutomation.ABB.Rws.Data.CalibrationInfo" data-throw-if-not-resolved="false"></xref>.</p>
	/// 
	/// </summary>
	public class CalibrationJointInfo : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.CalibrationJointInfo" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public CalibrationJointInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this joint
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Whether the joint exists on this mechanical unit. The controller always answers with a fixed
		/// number of entries and marks the unused ones, which carry no name at all.
		/// 
		/// </summary>
		public bool Exists { get; set; }

		/// <summary>
		/// 
		/// Name of the joint, for example &quot;rob1_1&quot;, empty for an entry that does not exist
		/// 
		/// </summary>
		public string JointName { get; set; }

		/// <summary>
		/// 
		/// Method the joint was calibrated with in the factory
		/// 
		/// </summary>
		public string FactoryCalibrationMethod { get; set; }

		/// <summary>
		/// 
		/// Method the joint is currently calibrated with
		/// 
		/// </summary>
		public string CurrentCalibrationMethod { get; set; }
	}
}
