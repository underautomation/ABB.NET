//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// State of the hold-to-run control that gates RAPID execution in manual mode
	/// </summary>
	public enum RapidHoldToRunState {

		/// <summary>
		/// Ask for execution to be allowed to start
		/// </summary>
		Press = 0,

		/// <summary>
		/// Confirm that execution may keep running, which has to be repeated about every two seconds
		/// </summary>
		Held = 1,

		/// <summary>
		/// Stop execution immediately
		/// </summary>
		Release = 2,
	}
}
