//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Whether an execution command applies to the normal tasks only or to every task
	/// 
	/// </summary>
	public sealed class RapidTaskScope : Enum {


		public int value__;

		/// <summary>
		/// 
		/// Apply to the tasks the task selection panel has enabled
		/// 
		/// </summary>
		public const RapidTaskScope Normal;

		/// <summary>
		/// 
		/// Apply to every task of the system
		/// 
		/// </summary>
		public const RapidTaskScope AllTasks;
	}
}
