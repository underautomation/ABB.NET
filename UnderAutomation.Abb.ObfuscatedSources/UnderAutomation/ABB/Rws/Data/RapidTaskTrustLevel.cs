//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// What the controller does to the system when a task that is not a normal one stops unexpectedly
	/// 
	/// </summary>
	public sealed class RapidTaskTrustLevel : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a level this library does not know
		/// 
		/// </summary>
		public const RapidTaskTrustLevel Unknown;

		/// <summary>
		/// 
		/// The system carries on
		/// 
		/// </summary>
		public const RapidTaskTrustLevel None;

		/// <summary>
		/// 
		/// The whole system fails
		/// 
		/// </summary>
		public const RapidTaskTrustLevel SystemFailure;

		/// <summary>
		/// 
		/// The system halts
		/// 
		/// </summary>
		public const RapidTaskTrustLevel SystemHalt;

		/// <summary>
		/// 
		/// The system stops
		/// 
		/// </summary>
		public const RapidTaskTrustLevel SystemStop;
	}
}
