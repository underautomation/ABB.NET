//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// How far the controller has got in preparing the program of a task
	/// 
	/// </summary>
	public sealed class RapidTaskState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a state this library does not know
		/// 
		/// </summary>
		public const RapidTaskState Unknown;

		/// <summary>
		/// 
		/// The task holds no program
		/// 
		/// </summary>
		public const RapidTaskState Empty;

		/// <summary>
		/// 
		/// The task has been created but its program is not linked yet
		/// 
		/// </summary>
		public const RapidTaskState Initiated;

		/// <summary>
		/// 
		/// The program of the task is linked and ready to run
		/// 
		/// </summary>
		public const RapidTaskState Linked;

		/// <summary>
		/// 
		/// A program is loaded into the task but not linked yet
		/// 
		/// </summary>
		public const RapidTaskState Loaded;

		/// <summary>
		/// 
		/// The task is not initialized
		/// 
		/// </summary>
		public const RapidTaskState Uninitialized;
	}
}
