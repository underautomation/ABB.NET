//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Level the controller is currently running at
	/// </summary>
	public enum ControllerLevel {

		/// <summary>
		/// The controller level could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// A system is loaded and running (system level)
		/// </summary>
		SystemLevel = 1,

		/// <summary>
		/// The controller runs the boot application (bootserver mode)
		/// </summary>
		BootLevel = 2,
	}
}
