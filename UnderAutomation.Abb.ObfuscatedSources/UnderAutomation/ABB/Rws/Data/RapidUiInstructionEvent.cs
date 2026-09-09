//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// What a UI instruction is asking of the client
	/// 
	/// </summary>
	public sealed class RapidUiInstructionEvent : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported an event this library does not know
		/// 
		/// </summary>
		public const RapidUiInstructionEvent Unknown;

		/// <summary>
		/// 
		/// The instruction is waiting for an answer
		/// 
		/// </summary>
		public const RapidUiInstructionEvent Send;

		/// <summary>
		/// 
		/// The instruction only displays something and expects no answer
		/// 
		/// </summary>
		public const RapidUiInstructionEvent Post;

		/// <summary>
		/// 
		/// The instruction has been abandoned and no answer is expected any more
		/// 
		/// </summary>
		public const RapidUiInstructionEvent Abort;
	}
}
