//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Where one of the lists of a RAPID object sits in the source: the span of the whole list, and the
	/// spans of its first and last elements.
	/// 
	/// <p>Returned by <code>RapidService.GetObjectListExtension()</code>. An editor uses it to jump to the
	/// beginning or the end of a list without reading the module.</p>
	/// <p>The controller reports an empty span when the object holds no such list.</p>
	/// </summary>
	public class RapidObjectListExtension {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidObjectListExtension" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidObjectListExtension()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this extension
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Span of the whole list
		/// </summary>
		public RapidTextRange List { get; set; }

		/// <summary>
		/// Span of the first element of the list
		/// </summary>
		public RapidTextRange First { get; set; }

		/// <summary>
		/// Span of the last element of the list
		/// </summary>
		public RapidTextRange Last { get; set; }
	}
}
