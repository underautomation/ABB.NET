//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// How hard the controller tries to apply a change to the source of a running task
	/// </summary>
	public enum RapidTextQueryMode {

		/// <summary>
		/// Apply the change even when it invalidates the program pointer
		/// </summary>
		Force = 0,

		/// <summary>
		/// Apply the change only when the program pointer survives it
		/// </summary>
		Try = 1,
	}
}
