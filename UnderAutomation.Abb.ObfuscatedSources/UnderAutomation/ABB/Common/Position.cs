//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Common {
	/// <summary>
	/// 
	/// A point in space, expressed in the coordinate system of whoever produced it.
	/// <p>Most readings of the controller express a position in millimetres, while the kinematics
	/// calculations work in metres. The method that returns or takes a position says which one it uses.</p>
	/// 
	/// </summary>
	public class Position : Object {

		/// <summary>
		/// 
		/// Initializes a new position at the origin
		/// 
		/// </summary>
		public Position()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Initializes a new position
		/// 
		/// </summary>
		/// <param name="x">Coordinate along the X axis</param>
		/// <param name="y">Coordinate along the Y axis</param>
		/// <param name="z">Coordinate along the Z axis</param>
		public Position(double x, double y, double z)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this position
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Coordinate along the X axis
		/// 
		/// </summary>
		public double X { get; set; }

		/// <summary>
		/// 
		/// Coordinate along the Y axis
		/// 
		/// </summary>
		public double Y { get; set; }

		/// <summary>
		/// 
		/// Coordinate along the Z axis
		/// 
		/// </summary>
		public double Z { get; set; }
	}
}
