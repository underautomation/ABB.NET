//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// The template the controller suggests for an instruction or a data type: the arguments to write and
	/// the values to write them with.
	/// 
	/// <p>Returned by <code>RapidService.GetInstructionTemplate()</code>. An editor uses it to insert a
	/// complete, valid instruction rather than a bare keyword.</p>
	/// </summary>
	public class RapidInstructionTemplate {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidInstructionTemplate" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidInstructionTemplate()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this template
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Number of arguments the controller reported, null when it did not report it
		/// </summary>
		public int? ArgumentCount { get; set; }

		/// <summary>
		/// Index the controller started reporting from, null when it did not report it
		/// </summary>
		public int? Mark { get; set; }

		/// <summary>
		/// Whether every argument has been reported, null when the controller did not report it
		/// </summary>
		public bool? Complete { get; set; }

		/// <summary>
		/// Version the controller stamps on the template
		/// </summary>
		public string Version { get; set; }

		/// <summary>
		/// Argument the controller suggests selecting first, null when it did not report it
		/// </summary>
		public int? SelectedParameter { get; set; }

		/// <summary>
		/// The suggested arguments
		/// </summary>
		public RapidInstructionTemplateArgument[] Arguments { get; set; }
	}
}
