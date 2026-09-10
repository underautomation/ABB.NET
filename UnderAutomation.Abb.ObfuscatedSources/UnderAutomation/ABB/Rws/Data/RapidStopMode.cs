//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// How abruptly RAPID execution is stopped
	/// </summary>
	public enum RapidStopMode {

		/// <summary>
		/// Stop when the current cycle ends
		/// </summary>
		Cycle = 0,

		/// <summary>
		/// Stop when the current instruction ends
		/// </summary>
		Instruction = 1,

		/// <summary>
		/// Stop as soon as the robot can decelerate along its path
		/// </summary>
		Stop = 2,

		/// <summary>
		/// Stop as fast as the robot can, leaving the path
		/// </summary>
		QuickStop = 3,
	}
}
