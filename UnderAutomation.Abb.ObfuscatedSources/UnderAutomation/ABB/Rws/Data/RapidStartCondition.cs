//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Condition the controller checks before it starts executing
	/// </summary>
	public enum RapidStartCondition {

		/// <summary>
		/// Start without any additional check
		/// </summary>
		None = 0,

		/// <summary>
		/// Start only when the call chain of the program pointer is still valid
		/// </summary>
		CallChain = 1,
	}
}
