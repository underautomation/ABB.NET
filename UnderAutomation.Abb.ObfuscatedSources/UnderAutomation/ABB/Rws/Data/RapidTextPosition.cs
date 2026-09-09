//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// A position in the source of a module, counted from 1.
	/// <p>Returned by <code>RapidService.SearchModuleText()</code>, which reports row and column 0 when the
	/// text was not found rather than failing.</p>
	/// 
	/// </summary>
	public class RapidTextPosition : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidTextPosition" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public RapidTextPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this position
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Line of the position, 0 when the search found nothing
		/// 
		/// </summary>
		public int Row { get; set; }

		/// <summary>
		/// 
		/// Column of the position, 0 when the search found nothing
		/// 
		/// </summary>
		public int Column { get; set; }

		/// <summary>
		/// 
		/// Whether the position points at something, which it does not when a search found nothing
		/// 
		/// </summary>
		public bool Found { get; }
	}
}
