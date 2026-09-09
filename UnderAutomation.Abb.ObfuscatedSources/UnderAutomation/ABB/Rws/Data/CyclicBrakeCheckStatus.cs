//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Cyclic brake check status of a mechanical unit.
	/// <p>Returned by <code>ControllerService.GetCyclicBrakeCheckStatus(driveNumber)</code>.</p>
	/// 
	/// </summary>
	public class CyclicBrakeCheckStatus : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.CyclicBrakeCheckStatus" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public CyclicBrakeCheckStatus()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this cyclic brake check status
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Drive number of the mechanical unit this status belongs to
		/// 
		/// </summary>
		public int DriveNumber { get; set; }

		/// <summary>
		/// 
		/// Remaining time before the next brake check is required, if reported by the controller
		/// 
		/// </summary>
		public Nullable<long> NextBrakeCheckTime { get; set; }

		/// <summary>
		/// 
		/// Result of the last brake check
		/// 
		/// </summary>
		public CyclicBrakeCheckTestStatus LastBrakeCheckStatus { get; set; }

		/// <summary>
		/// 
		/// Current cyclic brake check state
		/// 
		/// </summary>
		public CyclicBrakeCheckState Status { get; set; }
	}
}
