//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Cyclic brake check state of a mechanical unit
	/// 
	/// </summary>
	public sealed class CyclicBrakeCheckState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The state could not be determined
		/// 
		/// </summary>
		public const CyclicBrakeCheckState Unknown;

		/// <summary>
		/// 
		/// No brake check is needed (CBC_STATUS_OK)
		/// 
		/// </summary>
		public const CyclicBrakeCheckState Ok;

		/// <summary>
		/// 
		/// A brake check will soon be required (CBC_STATUS_PREWARNING)
		/// 
		/// </summary>
		public const CyclicBrakeCheckState PreWarning;

		/// <summary>
		/// 
		/// A brake check is required (CBC_STATUS_REQUIRE_CBC)
		/// 
		/// </summary>
		public const CyclicBrakeCheckState Required;
	}
}
