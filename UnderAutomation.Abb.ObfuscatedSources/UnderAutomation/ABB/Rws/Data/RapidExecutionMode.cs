//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// How far the program advances when execution is started
	/// 
	/// </summary>
	public sealed class RapidExecutionMode : Enum {


		public int value__;

		/// <summary>
		/// 
		/// Run until something stops it
		/// 
		/// </summary>
		public const RapidExecutionMode Continue;

		/// <summary>
		/// 
		/// Step into the routine called by the current instruction
		/// 
		/// </summary>
		public const RapidExecutionMode StepIn;

		/// <summary>
		/// 
		/// Run the current instruction whole, without entering the routine it calls
		/// 
		/// </summary>
		public const RapidExecutionMode StepOver;

		/// <summary>
		/// 
		/// Run until the current routine returns
		/// 
		/// </summary>
		public const RapidExecutionMode StepOut;

		/// <summary>
		/// 
		/// Step one instruction backwards
		/// 
		/// </summary>
		public const RapidExecutionMode StepBack;

		/// <summary>
		/// 
		/// Step to the last instruction
		/// 
		/// </summary>
		public const RapidExecutionMode StepLast;

		/// <summary>
		/// 
		/// Step to the next motion instruction
		/// 
		/// </summary>
		public const RapidExecutionMode StepMotion;
	}
}
