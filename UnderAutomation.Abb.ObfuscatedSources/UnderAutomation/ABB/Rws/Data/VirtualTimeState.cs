//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// State of the virtual time server of a virtual controller
	/// </summary>
	public enum VirtualTimeState {

		/// <summary>
		/// The state could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Virtual time is stopped (VTSTOP)
		/// </summary>
		Stop = 1,

		/// <summary>
		/// Virtual time runs freely (VTFREERUN)
		/// </summary>
		FreeRun = 2,

		/// <summary>
		/// Virtual time runs one time slice at a time (VTRUNSLICE)
		/// </summary>
		RunSlice = 3,

		/// <summary>
		/// Virtual time runs until the next event (VTNEXTEVENT)
		/// </summary>
		NextEvent = 4,
	}
}
