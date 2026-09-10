//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// How far the controller has got in preparing the program of a task
	/// </summary>
	public enum RapidTaskState {

		/// <summary>
		/// The controller reported a state this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The task holds no program
		/// </summary>
		Empty = 1,

		/// <summary>
		/// The task has been created but its program is not linked yet
		/// </summary>
		Initiated = 2,

		/// <summary>
		/// The program of the task is linked and ready to run
		/// </summary>
		Linked = 3,

		/// <summary>
		/// A program is loaded into the task but not linked yet
		/// </summary>
		Loaded = 4,

		/// <summary>
		/// The task is not initialized
		/// </summary>
		Uninitialized = 5,
	}
}
