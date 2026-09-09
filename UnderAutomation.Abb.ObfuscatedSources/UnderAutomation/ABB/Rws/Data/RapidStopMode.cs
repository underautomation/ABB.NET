//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// How abruptly RAPID execution is stopped
	/// 
	/// </summary>
	public sealed class RapidStopMode : Enum {


		public int value__;

		/// <summary>
		/// 
		/// Stop when the current cycle ends
		/// 
		/// </summary>
		public const RapidStopMode Cycle;

		/// <summary>
		/// 
		/// Stop when the current instruction ends
		/// 
		/// </summary>
		public const RapidStopMode Instruction;

		/// <summary>
		/// 
		/// Stop as soon as the robot can decelerate along its path
		/// 
		/// </summary>
		public const RapidStopMode Stop;

		/// <summary>
		/// 
		/// Stop as fast as the robot can, leaving the path
		/// 
		/// </summary>
		public const RapidStopMode QuickStop;
	}
}
