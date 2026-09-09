//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Pending change that an operating mode acknowledgement confirms
	/// 
	/// </summary>
	public sealed class OperationModeAcknowledgement : Enum {


		public int value__;

		/// <summary>
		/// 
		/// Confirms the switch to the automatic mode
		/// 
		/// </summary>
		public const OperationModeAcknowledgement Automatic;

		/// <summary>
		/// 
		/// Confirms the switch to the manual full speed mode
		/// 
		/// </summary>
		public const OperationModeAcknowledgement ManualFullSpeed;

		/// <summary>
		/// 
		/// Confirms a collision detection
		/// 
		/// </summary>
		public const OperationModeAcknowledgement CollisionDetection;
	}
}
