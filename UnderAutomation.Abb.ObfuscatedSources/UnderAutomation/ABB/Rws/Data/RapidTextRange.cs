//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// A span of source between two positions, counted from 1.
	/// 
	/// <p>Used wherever the controller reports where something is declared or where a statement sits.</p>
	/// </summary>
	public class RapidTextRange {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidTextRange" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidTextRange()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this range
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Line the range begins at, null when the controller did not report it
		/// </summary>
		public int? BeginRow { get; set; }

		/// <summary>
		/// Column the range begins at, null when the controller did not report it
		/// </summary>
		public int? BeginColumn { get; set; }

		/// <summary>
		/// Line the range ends at, null when the controller did not report it
		/// </summary>
		public int? EndRow { get; set; }

		/// <summary>
		/// Column the range ends at, null when the controller did not report it
		/// </summary>
		public int? EndColumn { get; set; }
	}
}
