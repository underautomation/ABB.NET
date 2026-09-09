//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Which part of the system a symbol search walks
	/// 
	/// </summary>
	public sealed class RapidSymbolSearchView : Enum {


		public int value__;

		/// <summary>
		/// 
		/// Let the controller decide
		/// 
		/// </summary>
		public const RapidSymbolSearchView Undefined;

		/// <summary>
		/// 
		/// Search the block the search path names, and optionally what it contains
		/// 
		/// </summary>
		public const RapidSymbolSearchView Block;

		/// <summary>
		/// 
		/// Search what is visible from a position of the source, which the search path and the
		/// position both have to be given for
		/// 
		/// </summary>
		public const RapidSymbolSearchView Scope;

		/// <summary>
		/// 
		/// Search what is visible from a frame of the call stack, which needs the program pointer to be set
		/// 
		/// </summary>
		public const RapidSymbolSearchView Stack;
	}
}
