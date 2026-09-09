//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Whether the controller is recording the RAPID execution trace to a file
	/// 
	/// </summary>
	public sealed class RapidSpyStatus : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a status this library does not know
		/// 
		/// </summary>
		public const RapidSpyStatus Unknown;

		/// <summary>
		/// 
		/// The execution trace is being written
		/// 
		/// </summary>
		public const RapidSpyStatus Logging;

		/// <summary>
		/// 
		/// No execution trace is being written
		/// 
		/// </summary>
		public const RapidSpyStatus NotLogging;
	}
}
