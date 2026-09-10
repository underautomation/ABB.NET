//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Result of the last cyclic brake check test
	/// </summary>
	public enum CyclicBrakeCheckTestStatus {

		/// <summary>
		/// The test status could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The last brake check succeeded (CBC_TEST_OK)
		/// </summary>
		Ok = 1,

		/// <summary>
		/// The last brake check ended with a warning (CBC_TEST_WARNING)
		/// </summary>
		Warning = 2,

		/// <summary>
		/// The last brake check failed (CBC_TEST_ERROR)
		/// </summary>
		Error = 3,

		/// <summary>
		/// No brake check has been performed yet (CBC_TEST_UNDEFINED)
		/// </summary>
		Undefined = 4,
	}
}
