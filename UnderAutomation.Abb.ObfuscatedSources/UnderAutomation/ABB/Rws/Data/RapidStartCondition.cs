//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Condition the controller checks before it starts executing
	/// 
	/// </summary>
	public sealed class RapidStartCondition : Enum {


		public int value__;

		/// <summary>
		/// 
		/// Start without any additional check
		/// 
		/// </summary>
		public const RapidStartCondition None;

		/// <summary>
		/// 
		/// Start only when the call chain of the program pointer is still valid
		/// 
		/// </summary>
		public const RapidStartCondition CallChain;
	}
}
