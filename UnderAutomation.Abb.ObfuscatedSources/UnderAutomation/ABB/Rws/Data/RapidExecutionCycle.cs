//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// How many times the controller runs the program before stopping
	/// </summary>
	public enum RapidExecutionCycle {

		/// <summary>
		/// The controller reported a cycle this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The program runs again every time it reaches its end
		/// </summary>
		Forever = 1,

		/// <summary>
		/// The cycle currently configured is left untouched
		/// </summary>
		AsIs = 2,

		/// <summary>
		/// The program runs once and stops at its end
		/// </summary>
		Once = 3,

		/// <summary>
		/// The program was asked to run once and has finished doing so
		/// </summary>
		OnceDone = 4,
	}
}
