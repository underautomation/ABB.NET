//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Common {
	/// <summary>
	/// 
	/// The six external axis values that travel with a robot position.
	/// <p>An axis the robot system does not define comes back as 9E9, which is how the controller says
	/// &quot;not in use&quot; rather than an actual position.</p>
	/// 
	/// </summary>
	public class ExternalJoints : Object {

		/// <summary>
		/// 
		/// Value the controller reports for an external axis that is not in use
		/// 
		/// </summary>
		public const double NotInUse = 9000000000;

		/// <summary>
		/// 
		/// Initializes the six external axes to zero
		/// 
		/// </summary>
		public ExternalJoints()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Initializes the six external axes
		/// 
		/// </summary>
		/// <param name="axisA">Value of external axis A</param>
		/// <param name="axisB">Value of external axis B</param>
		/// <param name="axisC">Value of external axis C</param>
		/// <param name="axisD">Value of external axis D</param>
		/// <param name="axisE">Value of external axis E</param>
		/// <param name="axisF">Value of external axis F</param>
		public ExternalJoints(double axisA, double axisB, double axisC, double axisD, double axisE, double axisF)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of these external axis values
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Value of external axis A
		/// 
		/// </summary>
		public double AxisA { get; set; }

		/// <summary>
		/// 
		/// Value of external axis B
		/// 
		/// </summary>
		public double AxisB { get; set; }

		/// <summary>
		/// 
		/// Value of external axis C
		/// 
		/// </summary>
		public double AxisC { get; set; }

		/// <summary>
		/// 
		/// Value of external axis D
		/// 
		/// </summary>
		public double AxisD { get; set; }

		/// <summary>
		/// 
		/// Value of external axis E
		/// 
		/// </summary>
		public double AxisE { get; set; }

		/// <summary>
		/// 
		/// Value of external axis F
		/// 
		/// </summary>
		public double AxisF { get; set; }
	}
}
