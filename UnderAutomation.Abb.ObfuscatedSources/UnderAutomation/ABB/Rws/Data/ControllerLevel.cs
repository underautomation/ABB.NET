//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Level the controller is currently running at
	/// 
	/// </summary>
	public sealed class ControllerLevel : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller level could not be determined
		/// 
		/// </summary>
		public const ControllerLevel Unknown;

		/// <summary>
		/// 
		/// A system is loaded and running (system level)
		/// 
		/// </summary>
		public const ControllerLevel SystemLevel;

		/// <summary>
		/// 
		/// The controller runs the boot application (bootserver mode)
		/// 
		/// </summary>
		public const ControllerLevel BootLevel;
	}
}
