//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Whether a module belongs to the program or to the system
	/// 
	/// </summary>
	public sealed class RapidModuleType : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a type this library does not know
		/// 
		/// </summary>
		public const RapidModuleType Unknown;

		/// <summary>
		/// 
		/// A module of the program, saved and loaded with it
		/// 
		/// </summary>
		public const RapidModuleType ProgramModule;

		/// <summary>
		/// 
		/// A module of the system, which survives loading another program
		/// 
		/// </summary>
		public const RapidModuleType SystemModule;
	}
}
