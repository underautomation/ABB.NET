//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Severity of an event log message
	/// </summary>
	public enum ElogMessageType {

		/// <summary>
		/// The message type could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// State change, or informational event
		/// </summary>
		Information = 1,

		/// <summary>
		/// Warning event
		/// </summary>
		Warning = 2,

		/// <summary>
		/// Error event
		/// </summary>
		Error = 3,
	}
}
