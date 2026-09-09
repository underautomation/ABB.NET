//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// What kind of code a task is currently running
	/// 
	/// </summary>
	public sealed class RapidExecutionType : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a type this library does not know
		/// 
		/// </summary>
		public const RapidExecutionType Unknown;

		/// <summary>
		/// 
		/// Nothing is running
		/// 
		/// </summary>
		public const RapidExecutionType None;

		/// <summary>
		/// 
		/// The normal program is running
		/// 
		/// </summary>
		public const RapidExecutionType Normal;

		/// <summary>
		/// 
		/// An interrupt is running
		/// 
		/// </summary>
		public const RapidExecutionType Interrupt;

		/// <summary>
		/// 
		/// An external interrupt is running
		/// 
		/// </summary>
		public const RapidExecutionType ExternalInterrupt;

		/// <summary>
		/// 
		/// A user routine is running
		/// 
		/// </summary>
		public const RapidExecutionType UserRoutine;

		/// <summary>
		/// 
		/// An event routine is running
		/// 
		/// </summary>
		public const RapidExecutionType EventRoutine;
	}
}
