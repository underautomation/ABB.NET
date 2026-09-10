//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// The parts a RAPID object is made of, and where each of them sits in the source.
	/// 
	/// <p>Returned by <code>RapidService.GetObjectChildren()</code>. Which parts the controller reports depends
	/// entirely on what the object is: a module answers with its name, its attributes and its declaration
	/// lists, a routine with something else. They are therefore returned as a list of named spans rather
	/// than as fixed properties.</p>
	/// </summary>
	public class RapidObjectChild {

		/// <summary>
		/// Returns the span of one part by its name, null when the controller did not report it
		/// </summary>
		/// <param name="name">Name of the part, for example "data-decl"</param>
		/// <returns>Span of the part, null when there is no such part</returns>
		public RapidTextRange GetRange(string name)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidObjectChild" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidObjectChild()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this object
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// What the object is, for example "module"
		/// </summary>
		public string ObjectType { get; set; }

		/// <summary>
		/// The parts of the object, including the ones it does not hold, whose span is then empty
		/// </summary>
		public RapidObjectChildRange[] Ranges { get; set; }

		/// <summary>
		/// Number of parts the controller reported
		/// </summary>
		public int RangeCount { get; }
	}
}
