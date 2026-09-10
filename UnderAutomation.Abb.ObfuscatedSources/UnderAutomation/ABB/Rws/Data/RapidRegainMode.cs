//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// What the robot does about the distance between where it stands and where the path it is
	/// about to resume expects it to be
	/// </summary>
	public enum RapidRegainMode {

		/// <summary>
		/// Resume from the current position without moving back to the path
		/// </summary>
		Continue = 0,

		/// <summary>
		/// Move back onto the path before resuming
		/// </summary>
		Regain = 1,

		/// <summary>
		/// Drop the path and resume from the current position
		/// </summary>
		Clear = 2,

		/// <summary>
		/// Resume by entering the consumption of the already generated path
		/// </summary>
		EnterConsume = 3,
	}
}
