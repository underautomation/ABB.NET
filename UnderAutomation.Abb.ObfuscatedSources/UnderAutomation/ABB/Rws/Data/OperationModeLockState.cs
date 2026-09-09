//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Lock state of the operating mode selector
	/// 
	/// </summary>
	public sealed class OperationModeLockState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The lock state could not be determined
		/// 
		/// </summary>
		public const OperationModeLockState Unknown;

		/// <summary>
		/// 
		/// The controller reports an error on the mode selector lock
		/// 
		/// </summary>
		public const OperationModeLockState Error;

		/// <summary>
		/// 
		/// The operating mode can be changed freely
		/// 
		/// </summary>
		public const OperationModeLockState Unlocked;

		/// <summary>
		/// 
		/// The operating mode is locked and can be unlocked again with the pin code it was locked with
		/// 
		/// </summary>
		public const OperationModeLockState Locked;

		/// <summary>
		/// 
		/// The operating mode is permanently locked
		/// 
		/// </summary>
		public const OperationModeLockState PermanentlyLocked;

		/// <summary>
		/// 
		/// A permanent lock has been requested and is not effective yet
		/// 
		/// </summary>
		public const OperationModeLockState PendingPermanentLock;
	}
}
