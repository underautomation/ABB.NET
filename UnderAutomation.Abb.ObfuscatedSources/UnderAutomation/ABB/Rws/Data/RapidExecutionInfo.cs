//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Overall RAPID execution state of the controller.
	/// <p>Returned by <code>RapidService.GetExecutionState()</code>.</p>
	/// 
	/// </summary>
	public class RapidExecutionInfo : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidExecutionInfo" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public RapidExecutionInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this execution state
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Whether RAPID code is currently running
		/// 
		/// </summary>
		public RapidExecutionState State { get; set; }

		/// <summary>
		/// 
		/// Number of cycles the program is set to run
		/// 
		/// </summary>
		public RapidExecutionCycle Cycle { get; set; }
	}
}
