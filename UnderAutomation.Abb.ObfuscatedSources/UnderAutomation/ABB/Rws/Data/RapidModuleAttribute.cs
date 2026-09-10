//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// A property declared on a module, which restricts what may be done with it
	/// </summary>
	public enum RapidModuleAttribute {

		/// <summary>
		/// The controller reported an attribute this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The module belongs to the system rather than to the program
		/// </summary>
		SystemModule = 1,

		/// <summary>
		/// The source of the module is encoded and cannot be read back
		/// </summary>
		Encoded = 2,

		/// <summary>
		/// The source of the module may not be displayed
		/// </summary>
		NoView = 3,

		/// <summary>
		/// Execution may not step into the routines of the module
		/// </summary>
		NoStepIn = 4,

		/// <summary>
		/// The source may be displayed but not changed
		/// </summary>
		ViewOnly = 5,

		/// <summary>
		/// The module may not be changed
		/// </summary>
		ReadOnly = 6,
	}
}
