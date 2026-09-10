//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// One argument of the routine call found at a given position of a module, and where it sits in the source.
	/// 
	/// <p>Returned by <code>RapidService.GetRoutineArguments()</code>.</p>
	/// </summary>
	public class RapidRoutineArgument {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidRoutineArgument" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidRoutineArgument()
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
		/// Position of the argument in the call, counted from 0
		/// </summary>
		public int? ParameterNumber { get; set; }

		/// <summary>
		/// Which alternative of the parameter this argument fills, null when the controller did not report it
		/// </summary>
		public int? AlternateArgument { get; set; }

		/// <summary>
		/// Line the argument starts at, null when the controller did not report it
		/// </summary>
		public int? StartRow { get; set; }

		/// <summary>
		/// Column the argument starts at, null when the controller did not report it
		/// </summary>
		public int? StartColumn { get; set; }

		/// <summary>
		/// Line the argument ends at, null when the controller did not report it
		/// </summary>
		public int? EndRow { get; set; }

		/// <summary>
		/// Column the argument ends at, null when the controller did not report it
		/// </summary>
		public int? EndColumn { get; set; }

		/// <summary>
		/// What the argument is, for example a required argument or a name reference
		/// </summary>
		public string ObjectType { get; set; }

		/// <summary>
		/// Type of the argument, for example "num"
		/// </summary>
		public string DataType { get; set; }

		/// <summary>
		/// Position of the argument in the argument list, null when the controller did not report it
		/// </summary>
		public int? ListNumber { get; set; }

		/// <summary>
		/// Length of the argument list, null when the controller did not report it
		/// </summary>
		public int? ListLength { get; set; }
	}
}
