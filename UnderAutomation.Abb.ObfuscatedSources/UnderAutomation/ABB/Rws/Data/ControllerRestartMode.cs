//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Restart mode of the robot controller
	/// 
	/// </summary>
	public sealed class ControllerRestartMode : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller will be restarted. The state is saved and any changed system parameter settings will be activated after the restart.
		/// 
		/// </summary>
		public const ControllerRestartMode Restart;

		/// <summary>
		/// 
		/// The main computer will be shut down. Should be used if the controller UPS is broken.
		/// 
		/// </summary>
		public const ControllerRestartMode Shutdown;

		/// <summary>
		/// 
		/// The controller will be restarted and the Boot Application will be started. The current system is saved and deactivated
		/// (the controller is non-functional, for advanced maintenance only).
		/// 
		/// </summary>
		public const ControllerRestartMode XStart;

		/// <summary>
		/// 
		/// The controller will be restarted. The current system parameter settings and RAPID programs will be discarded,
		/// and the original system installation settings will be used.
		/// 
		/// </summary>
		public const ControllerRestartMode IStart;

		/// <summary>
		/// 
		/// The controller will be restarted. The current RAPID programs and data will be discarded, but not the system parameter settings.
		/// 
		/// </summary>
		public const ControllerRestartMode PStart;

		/// <summary>
		/// 
		/// The controller will be restarted. The last automatically saved system state will be loaded.
		/// Should be used to recover from a system crash.
		/// 
		/// </summary>
		public const ControllerRestartMode BStart;
	}
}
