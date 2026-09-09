//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Result of the last cyclic brake check test
	/// 
	/// </summary>
	public sealed class CyclicBrakeCheckTestStatus : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The test status could not be determined
		/// 
		/// </summary>
		public const CyclicBrakeCheckTestStatus Unknown;

		/// <summary>
		/// 
		/// The last brake check succeeded (CBC_TEST_OK)
		/// 
		/// </summary>
		public const CyclicBrakeCheckTestStatus Ok;

		/// <summary>
		/// 
		/// The last brake check ended with a warning (CBC_TEST_WARNING)
		/// 
		/// </summary>
		public const CyclicBrakeCheckTestStatus Warning;

		/// <summary>
		/// 
		/// The last brake check failed (CBC_TEST_ERROR)
		/// 
		/// </summary>
		public const CyclicBrakeCheckTestStatus Error;

		/// <summary>
		/// 
		/// No brake check has been performed yet (CBC_TEST_UNDEFINED)
		/// 
		/// </summary>
		public const CyclicBrakeCheckTestStatus Undefined;
	}
}
