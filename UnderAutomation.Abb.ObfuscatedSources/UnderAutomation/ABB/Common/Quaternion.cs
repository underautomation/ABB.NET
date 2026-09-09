//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Common {
	/// <summary>
	/// 
	/// An orientation in space, expressed as a unit quaternion.
	/// <p>The controller rejects a quaternion that is not normalized, so keep
	/// <xref href="UnderAutomation.ABB.Common.Quaternion.Q1" data-throw-if-not-resolved="false"></xref>² + <xref href="UnderAutomation.ABB.Common.Quaternion.Q2" data-throw-if-not-resolved="false"></xref>² + <xref href="UnderAutomation.ABB.Common.Quaternion.Q3" data-throw-if-not-resolved="false"></xref>² + <xref href="UnderAutomation.ABB.Common.Quaternion.Q4" data-throw-if-not-resolved="false"></xref>² equal to 1.</p>
	/// 
	/// </summary>
	public class Quaternion : Object {

		/// <summary>
		/// 
		/// Initializes a new quaternion with no rotation at all (1, 0, 0, 0)
		/// 
		/// </summary>
		public Quaternion()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Initializes a new quaternion
		/// 
		/// </summary>
		/// <param name="q1">Real component</param>
		/// <param name="q2">First imaginary component</param>
		/// <param name="q3">Second imaginary component</param>
		/// <param name="q4">Third imaginary component</param>
		public Quaternion(double q1, double q2, double q3, double q4)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this orientation
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Real component of the quaternion
		/// 
		/// </summary>
		public double Q1 { get; set; }

		/// <summary>
		/// 
		/// First imaginary component of the quaternion
		/// 
		/// </summary>
		public double Q2 { get; set; }

		/// <summary>
		/// 
		/// Second imaginary component of the quaternion
		/// 
		/// </summary>
		public double Q3 { get; set; }

		/// <summary>
		/// 
		/// Third imaginary component of the quaternion
		/// 
		/// </summary>
		public double Q4 { get; set; }
	}
}
