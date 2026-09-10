//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// One argument of the template the controller suggests for an instruction or a data type.
	/// 
	/// <p>Carried by <xref href="UnderAutomation.ABB.Rws.Data.RapidInstructionTemplate" data-throw-if-not-resolved="false"></xref>.</p>
	/// </summary>
	public class RapidInstructionTemplateArgument {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidInstructionTemplateArgument" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidInstructionTemplateArgument()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this argument
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Position of the argument, null when the controller did not report it
		/// </summary>
		public int? ArgumentNumber { get; set; }

		/// <summary>
		/// Whether the argument has to be given, null when the controller did not report it
		/// </summary>
		public bool? Required { get; set; }

		/// <summary>
		/// Name of the argument, for example "ToPoint"
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Whether inserting the instruction also needs a declaration to be created for this argument,
		/// null when the controller did not report it
		/// </summary>
		public bool? DeclarationNeeded { get; set; }

		/// <summary>
		/// Name of the symbol the argument refers to, empty when the argument is written as a literal
		/// </summary>
		public string Symbol { get; set; }

		/// <summary>
		/// Value the argument is suggested with, written the way RAPID writes it
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// Type of the argument, for example "robtarget"
		/// </summary>
		public string DataType { get; set; }

		/// <summary>
		/// How the suggested symbol is declared, for example "CONST" or "TASK PERS"
		/// </summary>
		public string ObjectType { get; set; }

		/// <summary>
		/// Whether the suggested symbol is local to its module, null when the controller did not report it
		/// </summary>
		public bool? Local { get; set; }

		/// <summary>
		/// Number of array dimensions of the argument, null when the controller did not report it
		/// </summary>
		public int? Dimensions { get; set; }
	}
}
