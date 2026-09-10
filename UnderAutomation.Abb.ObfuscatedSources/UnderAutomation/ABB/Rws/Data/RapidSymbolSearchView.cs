//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Which part of the system a symbol search walks
	/// </summary>
	public enum RapidSymbolSearchView {

		/// <summary>
		/// Let the controller decide
		/// </summary>
		Undefined = 0,

		/// <summary>
		/// Search the block the search path names, and optionally what it contains
		/// </summary>
		Block = 1,

		/// <summary>
		/// Search what is visible from a position of the source, which the search path and the
		/// position both have to be given for
		/// </summary>
		Scope = 2,

		/// <summary>
		/// Search what is visible from a frame of the call stack, which needs the program pointer to be set
		/// </summary>
		Stack = 3,
	}
}
