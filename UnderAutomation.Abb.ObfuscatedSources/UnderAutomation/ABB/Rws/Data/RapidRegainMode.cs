//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// What the robot does about the distance between where it stands and where the path it is
	/// about to resume expects it to be
	/// 
	/// </summary>
	public sealed class RapidRegainMode : Enum {


		public int value__;

		/// <summary>
		/// 
		/// Resume from the current position without moving back to the path
		/// 
		/// </summary>
		public const RapidRegainMode Continue;

		/// <summary>
		/// 
		/// Move back onto the path before resuming
		/// 
		/// </summary>
		public const RapidRegainMode Regain;

		/// <summary>
		/// 
		/// Drop the path and resume from the current position
		/// 
		/// </summary>
		public const RapidRegainMode Clear;

		/// <summary>
		/// 
		/// Resume by entering the consumption of the already generated path
		/// 
		/// </summary>
		public const RapidRegainMode EnterConsume;
	}
}
