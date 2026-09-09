//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Overview of the motion system of the controller.
	/// <p>Returned by <code>MotionSystemService.GetInfo()</code>.</p>
	/// 
	/// </summary>
	public class MotionSystemInfo : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.MotionSystemInfo" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public MotionSystemInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this motion system
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Counter the controller increments on every change of the motion system.
		/// <p>Pass it to <code>MotionSystemService.HasChanged()</code> to find out whether anything moved
		/// since a previous reading, without fetching the whole state again.</p>
		/// 
		/// </summary>
		public Nullable<int> ChangeCount { get; set; }

		/// <summary>
		/// 
		/// Name of the mechanical unit the jogging commands currently apply to
		/// 
		/// </summary>
		public string MechanicalUnitName { get; set; }

		/// <summary>
		/// 
		/// Rate at which the controller refreshes the motion system state, null when it did not report it
		/// 
		/// </summary>
		public Nullable<int> PollRate { get; set; }

		/// <summary>
		/// 
		/// Whether the payload of the robot is set by the running program rather than by the mechanical unit,
		/// null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<bool> ModalPayloadMode { get; set; }

		/// <summary>
		/// 
		/// Whether absolute accuracy is switched on, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<bool> AbsoluteAccuracyActive { get; set; }
	}
}
