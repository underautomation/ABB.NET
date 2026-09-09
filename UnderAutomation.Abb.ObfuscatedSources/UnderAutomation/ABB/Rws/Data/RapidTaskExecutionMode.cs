//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Stepping mode a task was last started with
	/// 
	/// </summary>
	public sealed class RapidTaskExecutionMode : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a mode this library does not know
		/// 
		/// </summary>
		public const RapidTaskExecutionMode Unknown;

		/// <summary>
		/// 
		/// The task runs without stepping
		/// 
		/// </summary>
		public const RapidTaskExecutionMode Continuous;

		/// <summary>
		/// 
		/// The task steps over the routine calls
		/// 
		/// </summary>
		public const RapidTaskExecutionMode StepOver;

		/// <summary>
		/// 
		/// The task steps into the routine calls
		/// 
		/// </summary>
		public const RapidTaskExecutionMode StepIn;

		/// <summary>
		/// 
		/// The task steps out of the current routine
		/// 
		/// </summary>
		public const RapidTaskExecutionMode StepOutOf;

		/// <summary>
		/// 
		/// The task steps backwards
		/// 
		/// </summary>
		public const RapidTaskExecutionMode StepBack;

		/// <summary>
		/// 
		/// The task steps to the last instruction
		/// 
		/// </summary>
		public const RapidTaskExecutionMode StepLast;

		/// <summary>
		/// 
		/// The task advances one instruction at a time
		/// 
		/// </summary>
		public const RapidTaskExecutionMode StepWise;
	}
}
