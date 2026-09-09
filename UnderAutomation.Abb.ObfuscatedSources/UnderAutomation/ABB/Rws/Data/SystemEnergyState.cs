//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// State of the energy measurement of the controller
	/// 
	/// </summary>
	public sealed class SystemEnergyState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The energy state could not be determined
		/// 
		/// </summary>
		public const SystemEnergyState Unknown;

		/// <summary>
		/// 
		/// Energy measurement is blocked and no new value is produced
		/// 
		/// </summary>
		public const SystemEnergyState Blocked;

		/// <summary>
		/// 
		/// Energy measurement is paused
		/// 
		/// </summary>
		public const SystemEnergyState Paused;

		/// <summary>
		/// 
		/// Energy measurement is running
		/// 
		/// </summary>
		public const SystemEnergyState NotPaused;

		/// <summary>
		/// 
		/// Energy measurement is being resumed
		/// 
		/// </summary>
		public const SystemEnergyState Resuming;

		/// <summary>
		/// 
		/// Energy measurement is being paused
		/// 
		/// </summary>
		public const SystemEnergyState Pausing;

		/// <summary>
		/// 
		/// The controller is entering its low energy consumption mode
		/// 
		/// </summary>
		public const SystemEnergyState GoingToSleep;

		/// <summary>
		/// 
		/// The controller is in its low energy consumption mode
		/// 
		/// </summary>
		public const SystemEnergyState Sleep;
	}
}
