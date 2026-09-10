//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Whether a module belongs to the program or to the system
	/// </summary>
	public enum RapidModuleType {

		/// <summary>
		/// The controller reported a type this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// A module of the program, saved and loaded with it
		/// </summary>
		ProgramModule = 1,

		/// <summary>
		/// A module of the system, which survives loading another program
		/// </summary>
		SystemModule = 2,
	}
}
