//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Error state of the motion system, and how many errors it has counted.
	/// <p>Returned by <code>MotionSystemService.GetErrorState()</code>.</p>
	/// 
	/// </summary>
	public class MotionSystemErrorState : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.MotionSystemErrorState" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public MotionSystemErrorState()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this error state
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Last error the motion system ran into
		/// 
		/// </summary>
		public MotionErrorState State { get; set; }

		/// <summary>
		/// 
		/// Error state exactly as the controller reported it, useful when <xref href="UnderAutomation.ABB.Rws.Data.MotionSystemErrorState.State" data-throw-if-not-resolved="false"></xref> is
		/// <xref href="UnderAutomation.ABB.Rws.Data.MotionErrorState.Unknown" data-throw-if-not-resolved="false"></xref>
		/// 
		/// </summary>
		public string RawState { get; set; }

		/// <summary>
		/// 
		/// Number of errors counted since the controller started, incremented on every new error,
		/// null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> Count { get; set; }
	}
}
