//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// One software product installed on the controller.
	/// 
	/// <p>Returned by <code>SystemService.GetProducts()</code>.</p>
	/// </summary>
	public class SystemProduct {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.SystemProduct" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public SystemProduct()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this product
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the product, for example "RobotWare" or "RobotControl"
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Full version of the product, build information included.
		/// 
		/// <p>Null when the controller only reports the version name.</p>
		/// </summary>
		public string Version { get; set; }

		/// <summary>
		/// Human readable version of the product
		/// </summary>
		public string VersionName { get; set; }
	}
}
