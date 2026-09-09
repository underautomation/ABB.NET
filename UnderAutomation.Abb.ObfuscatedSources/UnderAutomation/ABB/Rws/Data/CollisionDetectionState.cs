//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// State of the collision detection of the robot controller
	/// 
	/// </summary>
	public sealed class CollisionDetectionState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The collision detection state could not be determined
		/// 
		/// </summary>
		public const CollisionDetectionState Unknown;

		/// <summary>
		/// 
		/// No collision has been detected since the controller started
		/// 
		/// </summary>
		public const CollisionDetectionState Init;

		/// <summary>
		/// 
		/// A collision has been detected and is waiting to be confirmed
		/// 
		/// </summary>
		public const CollisionDetectionState Triggered;

		/// <summary>
		/// 
		/// A detected collision has been confirmed
		/// 
		/// </summary>
		public const CollisionDetectionState Confirmed;

		/// <summary>
		/// 
		/// A detected collision has been acknowledged by an operator
		/// 
		/// </summary>
		public const CollisionDetectionState TriggeredAcknowledged;
	}
}
