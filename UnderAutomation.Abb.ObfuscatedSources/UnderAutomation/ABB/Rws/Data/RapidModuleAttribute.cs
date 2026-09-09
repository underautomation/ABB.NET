//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// A property declared on a module, which restricts what may be done with it
	/// 
	/// </summary>
	public sealed class RapidModuleAttribute : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported an attribute this library does not know
		/// 
		/// </summary>
		public const RapidModuleAttribute Unknown;

		/// <summary>
		/// 
		/// The module belongs to the system rather than to the program
		/// 
		/// </summary>
		public const RapidModuleAttribute SystemModule;

		/// <summary>
		/// 
		/// The source of the module is encoded and cannot be read back
		/// 
		/// </summary>
		public const RapidModuleAttribute Encoded;

		/// <summary>
		/// 
		/// The source of the module may not be displayed
		/// 
		/// </summary>
		public const RapidModuleAttribute NoView;

		/// <summary>
		/// 
		/// Execution may not step into the routines of the module
		/// 
		/// </summary>
		public const RapidModuleAttribute NoStepIn;

		/// <summary>
		/// 
		/// The source may be displayed but not changed
		/// 
		/// </summary>
		public const RapidModuleAttribute ViewOnly;

		/// <summary>
		/// 
		/// The module may not be changed
		/// 
		/// </summary>
		public const RapidModuleAttribute ReadOnly;
	}
}
