//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Whether the controller is currently executing RAPID code
	/// 
	/// </summary>
	public sealed class RapidExecutionState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a state this library does not know
		/// 
		/// </summary>
		public const RapidExecutionState Unknown;

		/// <summary>
		/// 
		/// RAPID execution is running
		/// 
		/// </summary>
		public const RapidExecutionState Running;

		/// <summary>
		/// 
		/// RAPID execution is stopped
		/// 
		/// </summary>
		public const RapidExecutionState Stopped;
	}
}
