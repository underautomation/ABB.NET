//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// How many times the controller runs the program before stopping
	/// 
	/// </summary>
	public sealed class RapidExecutionCycle : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a cycle this library does not know
		/// 
		/// </summary>
		public const RapidExecutionCycle Unknown;

		/// <summary>
		/// 
		/// The program runs again every time it reaches its end
		/// 
		/// </summary>
		public const RapidExecutionCycle Forever;

		/// <summary>
		/// 
		/// The cycle currently configured is left untouched
		/// 
		/// </summary>
		public const RapidExecutionCycle AsIs;

		/// <summary>
		/// 
		/// The program runs once and stops at its end
		/// 
		/// </summary>
		public const RapidExecutionCycle Once;

		/// <summary>
		/// 
		/// The program was asked to run once and has finished doing so
		/// 
		/// </summary>
		public const RapidExecutionCycle OnceDone;
	}
}
