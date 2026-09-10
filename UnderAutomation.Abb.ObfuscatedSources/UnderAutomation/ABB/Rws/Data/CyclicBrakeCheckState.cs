//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Cyclic brake check state of a mechanical unit
	/// </summary>
	public enum CyclicBrakeCheckState {

		/// <summary>
		/// The state could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// No brake check is needed (CBC_STATUS_OK)
		/// </summary>
		Ok = 1,

		/// <summary>
		/// A brake check will soon be required (CBC_STATUS_PREWARNING)
		/// </summary>
		PreWarning = 2,

		/// <summary>
		/// A brake check is required (CBC_STATUS_REQUIRE_CBC)
		/// </summary>
		Required = 3,
	}
}
