//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.ABB.Common;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// One of the joint combinations that reach a given pose: a <xref href="UnderAutomation.ABB.Common.JointTarget" data-throw-if-not-resolved="false"></xref> extended with the
	/// axis configuration it corresponds to.
	/// 
	/// <p>Returned by <code>MotionSystemService.GetAllJointSolutions()</code>. The joint values are expressed
	/// in radians.</p>
	/// </summary>
	public class JointSolution : JointTarget {

		/// <summary>
		/// Initializes a new solution with every axis at zero
		/// </summary>
		public JointSolution()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this solution
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Axis configuration this solution corresponds to. Never null.
		/// </summary>
		public RobotConfiguration Configuration { get; set; }
	}
}
