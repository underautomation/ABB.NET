//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Overview of the controller resources.
	/// 
	/// <p>Returned by <code>ControllerService.GetInfo()</code>.</p>
	/// </summary>
	public class ControllerInfo {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.ControllerInfo" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public ControllerInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this controller information
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Current system time of the controller (UTC), if available
		/// </summary>
		public DateTime? SystemTime { get; set; }

		/// <summary>
		/// Name of the controller
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Indicates whether the controller is a real or a virtual controller
		/// </summary>
		public ControllerType Type { get; set; }

		/// <summary>
		/// Indicates whether the controller runs at system level or in bootserver mode
		/// </summary>
		public ControllerLevel Level { get; set; }

		/// <summary>
		/// Names of the sub resources exposed by the controller ("clock", "identity", "network", ...)
		/// </summary>
		public string[] Resources { get; set; }
	}
}
