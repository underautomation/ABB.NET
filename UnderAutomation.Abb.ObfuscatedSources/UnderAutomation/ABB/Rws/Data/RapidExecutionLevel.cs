//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Level at which the code of a task is currently executing
	/// </summary>
	public enum RapidExecutionLevel {

		/// <summary>
		/// The controller reported a level this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Nothing is executing
		/// </summary>
		None = 1,

		/// <summary>
		/// The normal user code is executing
		/// </summary>
		Normal = 2,

		/// <summary>
		/// A trap routine is executing
		/// </summary>
		Trap = 3,

		/// <summary>
		/// A user routine is executing
		/// </summary>
		User = 4,
	}
}
