//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Which variables a symbol search keeps, by what may be done with them
	/// 
	/// </summary>
	public sealed class RapidSymbolVariableType : Enum {


		public int value__;

		/// <summary>
		/// 
		/// Let the controller decide
		/// 
		/// </summary>
		public const RapidSymbolVariableType Undefined;

		/// <summary>
		/// 
		/// Only the variables that can be read and written
		/// 
		/// </summary>
		public const RapidSymbolVariableType ReadWrite;

		/// <summary>
		/// 
		/// Only the variables that can be read but not written
		/// 
		/// </summary>
		public const RapidSymbolVariableType ReadOnly;

		/// <summary>
		/// 
		/// Only the loop variables
		/// 
		/// </summary>
		public const RapidSymbolVariableType Loop;

		/// <summary>
		/// 
		/// Any of them
		/// 
		/// </summary>
		public const RapidSymbolVariableType Any;
	}
}
