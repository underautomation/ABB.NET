//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Lock state of the operating mode selector
	/// </summary>
	public enum OperationModeLockState {

		/// <summary>
		/// The lock state could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The controller reports an error on the mode selector lock
		/// </summary>
		Error = 1,

		/// <summary>
		/// The operating mode can be changed freely
		/// </summary>
		Unlocked = 2,

		/// <summary>
		/// The operating mode is locked and can be unlocked again with the pin code it was locked with
		/// </summary>
		Locked = 3,

		/// <summary>
		/// The operating mode is permanently locked
		/// </summary>
		PermanentlyLocked = 4,

		/// <summary>
		/// A permanent lock has been requested and is not effective yet
		/// </summary>
		PendingPermanentLock = 5,
	}
}
