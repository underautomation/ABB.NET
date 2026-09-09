//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Physical state of an I/O signal
	/// 
	/// </summary>
	public sealed class IoSignalPhysicalState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The physical state could not be determined
		/// 
		/// </summary>
		public const IoSignalPhysicalState Unknown;

		/// <summary>
		/// 
		/// The physical value of the signal is valid
		/// 
		/// </summary>
		public const IoSignalPhysicalState Valid;

		/// <summary>
		/// 
		/// The physical value of the signal is not valid
		/// 
		/// </summary>
		public const IoSignalPhysicalState Invalid;
	}
}
