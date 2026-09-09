//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Severity of an event log message
	/// 
	/// </summary>
	public sealed class ElogMessageType : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The message type could not be determined
		/// 
		/// </summary>
		public const ElogMessageType Unknown;

		/// <summary>
		/// 
		/// State change, or informational event
		/// 
		/// </summary>
		public const ElogMessageType Information;

		/// <summary>
		/// 
		/// Warning event
		/// 
		/// </summary>
		public const ElogMessageType Warning;

		/// <summary>
		/// 
		/// Error event
		/// 
		/// </summary>
		public const ElogMessageType Error;
	}
}
