//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Common {
	/// <summary>
	/// 
	/// A position and the orientation the robot holds there: a <xref href="UnderAutomation.ABB.Common.Position" data-throw-if-not-resolved="false"></xref> extended with a
	/// <xref href="UnderAutomation.ABB.Common.Quaternion" data-throw-if-not-resolved="false"></xref>.
	/// 
	/// </summary>
	public class Pose : Position {

		/// <summary>
		/// 
		/// Initializes a new pose at the origin, with no rotation
		/// 
		/// </summary>
		public Pose()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Initializes a new pose
		/// 
		/// </summary>
		/// <param name="x">Coordinate along the X axis</param>
		/// <param name="y">Coordinate along the Y axis</param>
		/// <param name="z">Coordinate along the Z axis</param>
		/// <param name="orientation">Orientation held at that position, the identity rotation when null</param>
		public Pose(double x, double y, double z, Quaternion orientation)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Initializes a new pose
		/// 
		/// </summary>
		/// <param name="x">Coordinate along the X axis</param>
		/// <param name="y">Coordinate along the Y axis</param>
		/// <param name="z">Coordinate along the Z axis</param>
		/// <param name="q1">Real component of the orientation</param>
		/// <param name="q2">First imaginary component of the orientation</param>
		/// <param name="q3">Second imaginary component of the orientation</param>
		/// <param name="q4">Third imaginary component of the orientation</param>
		public Pose(double x, double y, double z, double q1, double q2, double q3, double q4)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this pose
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Orientation held at this position. Never null: a pose built without one carries the identity rotation.
		/// 
		/// </summary>
		public Quaternion Orientation { get; set; }
	}
}
