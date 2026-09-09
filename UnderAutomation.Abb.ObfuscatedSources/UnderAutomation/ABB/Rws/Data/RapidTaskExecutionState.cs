//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Whether a single task is running, and whether it could be
	/// 
	/// </summary>
	public sealed class RapidTaskExecutionState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a state this library does not know
		/// 
		/// </summary>
		public const RapidTaskExecutionState Unknown;

		/// <summary>
		/// 
		/// The task is ready to be started
		/// 
		/// </summary>
		public const RapidTaskExecutionState Ready;

		/// <summary>
		/// 
		/// The task was running and has been stopped
		/// 
		/// </summary>
		public const RapidTaskExecutionState Stopped;

		/// <summary>
		/// 
		/// The task is running
		/// 
		/// </summary>
		public const RapidTaskExecutionState Started;

		/// <summary>
		/// 
		/// The task is not initialized
		/// 
		/// </summary>
		public const RapidTaskExecutionState Uninitialized;
	}
}
