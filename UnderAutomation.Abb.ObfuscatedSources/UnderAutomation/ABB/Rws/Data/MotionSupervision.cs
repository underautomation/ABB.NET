//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Collision detection settings of one mechanical unit while it is jogged.
	/// 
	/// <p>Returned by <code>MotionSystemService.GetMotionSupervision()</code>.</p>
	/// </summary>
	public class MotionSupervision {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.MotionSupervision" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public MotionSupervision()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of these settings
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Whether the supervision is switched on, null when the controller did not report it
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// Sensitivity of the supervision, as a percentage: the lower the value, the sooner a collision is
		/// reported. Null when the controller did not report it.
		/// </summary>
		public int? Level { get; set; }
	}
}
