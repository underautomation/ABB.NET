//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Common {
	/// <summary>
	/// The axis configuration the robot uses to reach a pose.
	/// 
	/// <p>Several joint combinations reach the same tool position and orientation. The configuration
	/// names the one to use, as the quarter revolution each of the deciding axes sits in.</p>
	/// </summary>
	public class RobotConfiguration {

		/// <summary>
		/// Initializes a new configuration with every quarter revolution set to zero
		/// </summary>
		public RobotConfiguration()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new configuration
		/// </summary>
		/// <param name="quarter1">Quarter revolution axis 1 sits in</param>
		/// <param name="quarter4">Quarter revolution axis 4 sits in</param>
		/// <param name="quarter6">Quarter revolution axis 6 sits in</param>
		/// <param name="quarterX">Index of the arm configuration</param>
		public RobotConfiguration(int quarter1, int quarter4, int quarter6, int quarterX)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this configuration
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Quarter revolution axis 1 sits in
		/// </summary>
		public int Quarter1 { get; set; }

		/// <summary>
		/// Quarter revolution axis 4 sits in
		/// </summary>
		public int Quarter4 { get; set; }

		/// <summary>
		/// Quarter revolution axis 6 sits in
		/// </summary>
		public int Quarter6 { get; set; }

		/// <summary>
		/// Index of the arm configuration, which tells the remaining joint combinations apart
		/// </summary>
		public int QuarterX { get; set; }
	}
}
