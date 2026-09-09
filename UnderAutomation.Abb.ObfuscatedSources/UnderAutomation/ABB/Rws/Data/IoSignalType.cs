//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Type of an I/O signal
	/// 
	/// </summary>
	public sealed class IoSignalType : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The signal type could not be determined
		/// 
		/// </summary>
		public const IoSignalType Unknown;

		/// <summary>
		/// 
		/// Digital output
		/// 
		/// </summary>
		public const IoSignalType DigitalOutput;

		/// <summary>
		/// 
		/// Digital input
		/// 
		/// </summary>
		public const IoSignalType DigitalInput;

		/// <summary>
		/// 
		/// Analog output
		/// 
		/// </summary>
		public const IoSignalType AnalogOutput;

		/// <summary>
		/// 
		/// Analog input
		/// 
		/// </summary>
		public const IoSignalType AnalogInput;

		/// <summary>
		/// 
		/// Group input
		/// 
		/// </summary>
		public const IoSignalType GroupInput;

		/// <summary>
		/// 
		/// Group output
		/// 
		/// </summary>
		public const IoSignalType GroupOutput;
	}
}
