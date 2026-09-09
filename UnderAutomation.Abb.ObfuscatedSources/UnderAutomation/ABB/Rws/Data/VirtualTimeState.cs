//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// State of the virtual time server of a virtual controller
	/// 
	/// </summary>
	public sealed class VirtualTimeState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The state could not be determined
		/// 
		/// </summary>
		public const VirtualTimeState Unknown;

		/// <summary>
		/// 
		/// Virtual time is stopped (VTSTOP)
		/// 
		/// </summary>
		public const VirtualTimeState Stop;

		/// <summary>
		/// 
		/// Virtual time runs freely (VTFREERUN)
		/// 
		/// </summary>
		public const VirtualTimeState FreeRun;

		/// <summary>
		/// 
		/// Virtual time runs one time slice at a time (VTRUNSLICE)
		/// 
		/// </summary>
		public const VirtualTimeState RunSlice;

		/// <summary>
		/// 
		/// Virtual time runs until the next event (VTNEXTEVENT)
		/// 
		/// </summary>
		public const VirtualTimeState NextEvent;
	}
}
