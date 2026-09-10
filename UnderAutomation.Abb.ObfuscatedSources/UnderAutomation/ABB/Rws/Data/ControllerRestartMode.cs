//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Restart mode of the robot controller
	/// </summary>
	public enum ControllerRestartMode {

		/// <summary>
		/// The controller will be restarted. The state is saved and any changed system parameter settings will be activated after the restart.
		/// </summary>
		Restart = 0,

		/// <summary>
		/// The main computer will be shut down. Should be used if the controller UPS is broken.
		/// </summary>
		Shutdown = 1,

		/// <summary>
		/// The controller will be restarted and the Boot Application will be started. The current system is saved and deactivated
		/// (the controller is non-functional, for advanced maintenance only).
		/// </summary>
		XStart = 2,

		/// <summary>
		/// The controller will be restarted. The current system parameter settings and RAPID programs will be discarded,
		/// and the original system installation settings will be used.
		/// </summary>
		IStart = 3,

		/// <summary>
		/// The controller will be restarted. The current RAPID programs and data will be discarded, but not the system parameter settings.
		/// </summary>
		PStart = 4,

		/// <summary>
		/// The controller will be restarted. The last automatically saved system state will be loaded.
		/// Should be used to recover from a system crash.
		/// </summary>
		BStart = 5,
	}
}
