//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Kind of RAPID task, which decides when the controller runs it
	/// </summary>
	public enum RapidTaskType {

		/// <summary>
		/// The controller reported a type this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// A task started and stopped together with the program
		/// </summary>
		Normal = 1,

		/// <summary>
		/// A task that keeps its program pointer where it was when the controller was switched off
		/// </summary>
		Static = 2,

		/// <summary>
		/// A task restarted from its beginning every time the controller starts
		/// </summary>
		SemiStatic = 3,
	}
}
