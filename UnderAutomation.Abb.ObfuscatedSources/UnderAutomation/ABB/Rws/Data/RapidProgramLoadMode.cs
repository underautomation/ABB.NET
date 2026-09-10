//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// What happens to the modules already in a task when a program is loaded into it
	/// </summary>
	public enum RapidProgramLoadMode {

		/// <summary>
		/// Keep the modules already loaded and add the ones of the program
		/// </summary>
		Add = 0,

		/// <summary>
		/// Replace everything the task holds with the program
		/// </summary>
		Replace = 1,
	}
}
