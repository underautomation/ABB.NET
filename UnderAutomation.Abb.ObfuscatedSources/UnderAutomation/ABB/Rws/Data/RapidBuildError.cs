//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// An error the controller found while linking the program of a task.
	/// 
	/// <p>Returned by <code>RapidService.GetBuildErrors()</code>.</p>
	/// </summary>
	public class RapidBuildError {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidBuildError" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidBuildError()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this build error
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the module the error was found in
		/// </summary>
		public string ModuleName { get; set; }

		/// <summary>
		/// Line the error was found at, null when the controller did not report it
		/// </summary>
		public int? Row { get; set; }

		/// <summary>
		/// Column the error was found at, null when the controller did not report it
		/// </summary>
		public int? Column { get; set; }

		/// <summary>
		/// Numeric identifier of the error, null when the controller did not report it
		/// </summary>
		public int? ErrorNumber { get; set; }

		/// <summary>
		/// Description of the error as the controller worded it
		/// </summary>
		public string Error { get; set; }
	}
}
