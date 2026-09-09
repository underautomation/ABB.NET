//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Common {
	/// <summary>
	/// 
	/// The six joint values of a robot arm.
	/// <p>Readings of the controller express them in degrees, while the kinematics calculations work
	/// in radians. The method that returns or takes them says which one it uses.</p>
	/// 
	/// </summary>
	public class RobotJoints : Object {

		/// <summary>
		/// 
		/// Initializes the six axes to zero
		/// 
		/// </summary>
		public RobotJoints()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Initializes the six axes
		/// 
		/// </summary>
		/// <param name="axis1">Value of axis 1</param>
		/// <param name="axis2">Value of axis 2</param>
		/// <param name="axis3">Value of axis 3</param>
		/// <param name="axis4">Value of axis 4</param>
		/// <param name="axis5">Value of axis 5</param>
		/// <param name="axis6">Value of axis 6</param>
		public RobotJoints(double axis1, double axis2, double axis3, double axis4, double axis5, double axis6)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of these joint values
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Value of axis 1
		/// 
		/// </summary>
		public double Axis1 { get; set; }

		/// <summary>
		/// 
		/// Value of axis 2
		/// 
		/// </summary>
		public double Axis2 { get; set; }

		/// <summary>
		/// 
		/// Value of axis 3
		/// 
		/// </summary>
		public double Axis3 { get; set; }

		/// <summary>
		/// 
		/// Value of axis 4
		/// 
		/// </summary>
		public double Axis4 { get; set; }

		/// <summary>
		/// 
		/// Value of axis 5
		/// 
		/// </summary>
		public double Axis5 { get; set; }

		/// <summary>
		/// 
		/// Value of axis 6
		/// 
		/// </summary>
		public double Axis6 { get; set; }
	}
}
