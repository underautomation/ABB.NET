//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// How many motion instructions of a range can have their position rewritten to where the robot
	/// currently stands, and which range they cover.
	/// <p>Returned by <code>RapidService.GetModifiablePositions()</code>. The controller leaves the range empty
	/// when it found nothing modifiable.</p>
	/// 
	/// </summary>
	public class RapidModifiablePositions : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidModifiablePositions" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public RapidModifiablePositions()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this result
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Number of motion instructions of the range whose position can be rewritten
		/// 
		/// </summary>
		public int ModifiableLineCount { get; set; }

		/// <summary>
		/// 
		/// Line the modifiable range starts at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> StartRow { get; set; }

		/// <summary>
		/// 
		/// Column the modifiable range starts at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> StartColumn { get; set; }

		/// <summary>
		/// 
		/// Line the modifiable range ends at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> EndRow { get; set; }

		/// <summary>
		/// 
		/// Column the modifiable range ends at, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> EndColumn { get; set; }
	}
}
