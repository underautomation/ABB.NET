//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Stepping mode a task was last started with
	/// </summary>
	public enum RapidTaskExecutionMode {

		/// <summary>
		/// The controller reported a mode this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The task runs without stepping
		/// </summary>
		Continuous = 1,

		/// <summary>
		/// The task steps over the routine calls
		/// </summary>
		StepOver = 2,

		/// <summary>
		/// The task steps into the routine calls
		/// </summary>
		StepIn = 3,

		/// <summary>
		/// The task steps out of the current routine
		/// </summary>
		StepOutOf = 4,

		/// <summary>
		/// The task steps backwards
		/// </summary>
		StepBack = 5,

		/// <summary>
		/// The task steps to the last instruction
		/// </summary>
		StepLast = 6,

		/// <summary>
		/// The task advances one instruction at a time
		/// </summary>
		StepWise = 7,
	}
}
