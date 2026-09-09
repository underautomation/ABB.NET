//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Kind of RAPID task, which decides when the controller runs it
	/// 
	/// </summary>
	public sealed class RapidTaskType : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a type this library does not know
		/// 
		/// </summary>
		public const RapidTaskType Unknown;

		/// <summary>
		/// 
		/// A task started and stopped together with the program
		/// 
		/// </summary>
		public const RapidTaskType Normal;

		/// <summary>
		/// 
		/// A task that keeps its program pointer where it was when the controller was switched off
		/// 
		/// </summary>
		public const RapidTaskType Static;

		/// <summary>
		/// 
		/// A task restarted from its beginning every time the controller starts
		/// 
		/// </summary>
		public const RapidTaskType SemiStatic;
	}
}
