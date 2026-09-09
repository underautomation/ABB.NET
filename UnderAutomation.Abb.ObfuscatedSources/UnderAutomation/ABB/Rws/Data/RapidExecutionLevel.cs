//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Level at which the code of a task is currently executing
	/// 
	/// </summary>
	public sealed class RapidExecutionLevel : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a level this library does not know
		/// 
		/// </summary>
		public const RapidExecutionLevel Unknown;

		/// <summary>
		/// 
		/// Nothing is executing
		/// 
		/// </summary>
		public const RapidExecutionLevel None;

		/// <summary>
		/// 
		/// The normal user code is executing
		/// 
		/// </summary>
		public const RapidExecutionLevel Normal;

		/// <summary>
		/// 
		/// A trap routine is executing
		/// 
		/// </summary>
		public const RapidExecutionLevel Trap;

		/// <summary>
		/// 
		/// A user routine is executing
		/// 
		/// </summary>
		public const RapidExecutionLevel User;
	}
}
