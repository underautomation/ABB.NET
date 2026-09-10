//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// The program loaded into a task.
	/// 
	/// <p>Returned by <code>RapidService.GetProgram()</code>, which returns null when the task holds no
	/// program at all.</p>
	/// </summary>
	public class RapidProgramInfo {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidProgramInfo" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidProgramInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this program
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the program, null when the controller did not report it
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Routine the program pointer moves to when it is reset, null when the controller did not report it
		/// </summary>
		public string EntryPoint { get; set; }
	}
}
