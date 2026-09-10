//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Which variables a symbol search keeps, by what may be done with them
	/// </summary>
	public enum RapidSymbolVariableType {

		/// <summary>
		/// Let the controller decide
		/// </summary>
		Undefined = 0,

		/// <summary>
		/// Only the variables that can be read and written
		/// </summary>
		ReadWrite = 1,

		/// <summary>
		/// Only the variables that can be read but not written
		/// </summary>
		ReadOnly = 2,

		/// <summary>
		/// Only the loop variables
		/// </summary>
		Loop = 3,

		/// <summary>
		/// Any of them
		/// </summary>
		Any = 4,
	}
}
