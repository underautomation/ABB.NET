//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// State of the energy measurement of the controller
	/// </summary>
	public enum SystemEnergyState {

		/// <summary>
		/// The energy state could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Energy measurement is blocked and no new value is produced
		/// </summary>
		Blocked = 1,

		/// <summary>
		/// Energy measurement is paused
		/// </summary>
		Paused = 2,

		/// <summary>
		/// Energy measurement is running
		/// </summary>
		NotPaused = 3,

		/// <summary>
		/// Energy measurement is being resumed
		/// </summary>
		Resuming = 4,

		/// <summary>
		/// Energy measurement is being paused
		/// </summary>
		Pausing = 5,

		/// <summary>
		/// The controller is entering its low energy consumption mode
		/// </summary>
		GoingToSleep = 6,

		/// <summary>
		/// The controller is in its low energy consumption mode
		/// </summary>
		Sleep = 7,
	}
}
