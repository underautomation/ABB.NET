//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Safety mode status of the controller.
	/// <p>Returned by <code>ControllerService.GetSafetyMode()</code>.</p>
	/// 
	/// </summary>
	public class SafetyModeStatus : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.SafetyModeStatus" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public SafetyModeStatus()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this safety mode status
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Current safety mode
		/// 
		/// </summary>
		public SafetyMode Mode { get; set; }

		/// <summary>
		/// 
		/// User data associated with the safety mode, if reported by the controller
		/// 
		/// </summary>
		public Nullable<int> UserData { get; set; }
	}
}
