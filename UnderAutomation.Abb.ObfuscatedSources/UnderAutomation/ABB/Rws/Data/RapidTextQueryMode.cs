//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// How hard the controller tries to apply a change to the source of a running task
	/// 
	/// </summary>
	public sealed class RapidTextQueryMode : Enum {


		public int value__;

		/// <summary>
		/// 
		/// Apply the change even when it invalidates the program pointer
		/// 
		/// </summary>
		public const RapidTextQueryMode Force;

		/// <summary>
		/// 
		/// Apply the change only when the program pointer survives it
		/// 
		/// </summary>
		public const RapidTextQueryMode Try;
	}
}
