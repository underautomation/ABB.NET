//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// What a UI instruction is asking of the client
	/// </summary>
	public enum RapidUiInstructionEvent {

		/// <summary>
		/// The controller reported an event this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The instruction is waiting for an answer
		/// </summary>
		Send = 1,

		/// <summary>
		/// The instruction only displays something and expects no answer
		/// </summary>
		Post = 2,

		/// <summary>
		/// The instruction has been abandoned and no answer is expected any more
		/// </summary>
		Abort = 3,
	}
}
