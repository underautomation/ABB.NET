//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Time server used by the controller to synchronize its clock.
	/// 
	/// <p>Returned by <code>ControllerService.GetTimeServer()</code>.</p>
	/// </summary>
	public class TimeServerInfo {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.TimeServerInfo" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public TimeServerInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this time server
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Address of the time server
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// Time reported by the time server (UTC), if available.
		/// 
		/// <p>Only available when connected with version 2.</p>
		/// </summary>
		public DateTime? Time { get; set; }
	}
}
