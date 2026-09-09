//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Logical state of an I/O signal
	/// 
	/// </summary>
	public sealed class IoSignalLogicalState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The logical state could not be determined
		/// 
		/// </summary>
		public const IoSignalLogicalState Unknown;

		/// <summary>
		/// 
		/// The signal is simulated: its logical value is forced and no longer follows the physical value
		/// 
		/// </summary>
		public const IoSignalLogicalState Simulated;

		/// <summary>
		/// 
		/// The signal is not simulated
		/// 
		/// </summary>
		public const IoSignalLogicalState NotSimulated;
	}
}
