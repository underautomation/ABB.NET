//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// One named part of a RAPID object, and where it sits in the source.
	/// 
	/// <p>Carried by <xref href="UnderAutomation.ABB.Rws.Data.RapidObjectChild" data-throw-if-not-resolved="false"></xref>.</p>
	/// </summary>
	public class RapidObjectChildRange {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidObjectChildRange" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidObjectChildRange()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this part
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the part as the controller worded it, for example "data-decl" or "endmod"
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Where the part sits in the source
		/// </summary>
		public RapidTextRange Range { get; set; }

		/// <summary>
		/// Whether the controller reported a real span for the part, which it does not when the object
		/// does not hold it
		/// </summary>
		public bool IsPresent { get; }
	}
}
