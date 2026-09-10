//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Everything the controller reports about one module.
	/// 
	/// <p>Returned by <code>RapidService.GetModule()</code>; the module lists only carry the properties of the
	/// <xref href="UnderAutomation.ABB.Rws.Data.RapidModuleItem" data-throw-if-not-resolved="false"></xref> base class.</p>
	/// </summary>
	public class RapidModuleInfo : RapidModuleItem {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidModuleInfo" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidModuleInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Name of the file the module was loaded from, for example "MainModule.mod"
		/// </summary>
		public string FileName { get; set; }

		/// <summary>
		/// Properties declared on the module, empty when it declares none
		/// </summary>
		public RapidModuleAttribute[] Attributes { get; set; }

		/// <summary>
		/// Number of properties declared on the module
		/// </summary>
		public int AttributeCount { get; }
	}
}
