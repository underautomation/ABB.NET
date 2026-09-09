//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Common {
	/// <summary>
	/// 
	/// A complete robot target: a <xref href="UnderAutomation.ABB.Common.Pose" data-throw-if-not-resolved="false"></xref> extended with the axis configuration used to reach it
	/// and the external axis values that travel with it.
	/// 
	/// </summary>
	public class RobTarget : Pose {

		/// <summary>
		/// 
		/// Initializes a new target at the origin, with no rotation
		/// 
		/// </summary>
		public RobTarget()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Initializes a new target
		/// 
		/// </summary>
		/// <param name="x">Coordinate along the X axis</param>
		/// <param name="y">Coordinate along the Y axis</param>
		/// <param name="z">Coordinate along the Z axis</param>
		/// <param name="orientation">Orientation held at that position, the identity rotation when null</param>
		/// <param name="configuration">Axis configuration used to reach the pose, all zero when null</param>
		/// <param name="externalAxes">Values of the six external axes</param>
		public RobTarget(double x, double y, double z, Quaternion orientation, RobotConfiguration configuration, ExternalJoints externalAxes)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this target
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Axis configuration used to reach the pose. Never null.
		/// 
		/// </summary>
		public RobotConfiguration Configuration { get; set; }

		/// <summary>
		/// 
		/// Values of the six external axes, null when the reading does not report them
		/// 
		/// </summary>
		public ExternalJoints ExternalAxes { get; set; }
	}
}
