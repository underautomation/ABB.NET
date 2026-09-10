//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// How far the program advances when execution is started
	/// </summary>
	public enum RapidExecutionMode {

		/// <summary>
		/// Run until something stops it
		/// </summary>
		Continue = 0,

		/// <summary>
		/// Step into the routine called by the current instruction
		/// </summary>
		StepIn = 1,

		/// <summary>
		/// Run the current instruction whole, without entering the routine it calls
		/// </summary>
		StepOver = 2,

		/// <summary>
		/// Run until the current routine returns
		/// </summary>
		StepOut = 3,

		/// <summary>
		/// Step one instruction backwards
		/// </summary>
		StepBack = 4,

		/// <summary>
		/// Step to the last instruction
		/// </summary>
		StepLast = 5,

		/// <summary>
		/// Step to the next motion instruction
		/// </summary>
		StepMotion = 6,
	}
}
