//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Type of an I/O signal
	/// </summary>
	public enum IoSignalType {

		/// <summary>
		/// The signal type could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Digital output
		/// </summary>
		DigitalOutput = 1,

		/// <summary>
		/// Digital input
		/// </summary>
		DigitalInput = 2,

		/// <summary>
		/// Analog output
		/// </summary>
		AnalogOutput = 3,

		/// <summary>
		/// Analog input
		/// </summary>
		AnalogInput = 4,

		/// <summary>
		/// Group input
		/// </summary>
		GroupInput = 5,

		/// <summary>
		/// Group output
		/// </summary>
		GroupOutput = 6,
	}
}
