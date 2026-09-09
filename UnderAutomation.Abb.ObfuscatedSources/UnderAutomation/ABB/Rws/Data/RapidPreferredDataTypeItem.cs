//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// A data type the controller suggests for one argument of an instruction, so that an editor can offer
	/// the operator the types that fit where the cursor stands.
	/// <p>Returned by <code>RapidService.GetPreferredDataTypes()</code>.</p>
	/// 
	/// </summary>
	public class RapidPreferredDataTypeItem : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidPreferredDataTypeItem" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public RapidPreferredDataTypeItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this suggestion
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Name of the suggestion, for example &quot;signaldi&quot;
		/// 
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 
		/// Data type of the suggestion
		/// 
		/// </summary>
		public string DataType { get; set; }
	}
}
