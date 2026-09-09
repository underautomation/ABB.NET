//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// A module loaded into a task, as listed by <code>RapidService.GetModules()</code>.
	/// <p><code>RapidService.GetModule()</code> returns a <xref href="UnderAutomation.ABB.Rws.Data.RapidModuleInfo" data-throw-if-not-resolved="false"></xref>, which adds the file the
	/// module came from and the attributes declared on it.</p>
	/// 
	/// </summary>
	public class RapidModuleItem : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidModuleItem" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public RapidModuleItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this module
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Name of the module, for example &quot;MainModule&quot;
		/// 
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 
		/// Whether the module belongs to the program or to the system
		/// 
		/// </summary>
		public RapidModuleType Type { get; set; }
	}
}
