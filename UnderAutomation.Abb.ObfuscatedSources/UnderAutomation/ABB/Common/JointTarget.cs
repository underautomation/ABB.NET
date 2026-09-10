//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Common {
	/// <summary>
	/// A robot position expressed joint by joint: the six axes of the arm and the six external axes.
	/// </summary>
	public class JointTarget {

		/// <summary>
		/// Initializes a new joint target with every axis at zero
		/// </summary>
		public JointTarget()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new joint target
		/// </summary>
		/// <param name="robotAxes">Values of the six axes of the robot arm, zero when null</param>
		/// <param name="externalAxes">Values of the six external axes, zero when null</param>
		public JointTarget(RobotJoints robotAxes, ExternalJoints externalAxes)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this joint target
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Values of the six axes of the robot arm. Never null.
		/// </summary>
		public RobotJoints RobotAxes { get; set; }

		/// <summary>
		/// Values of the six external axes. Never null.
		/// </summary>
		public ExternalJoints ExternalAxes { get; set; }
	}
}
