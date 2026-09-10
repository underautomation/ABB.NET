//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.ABB.Common;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Where the base of a mechanical unit sits, and what kind of base it is: a <xref href="UnderAutomation.ABB.Common.Pose" data-throw-if-not-resolved="false"></xref>
	/// extended with the type of the frame.
	/// 
	/// <p>Returned by <code>MotionSystemService.GetBaseFrame()</code>. The position is expressed in millimetres.</p>
	/// </summary>
	public class BaseFrame : Pose {

		/// <summary>
		/// Initializes a new base frame at the origin, with no rotation
		/// </summary>
		public BaseFrame()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this base frame
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Kind of base frame the controller reports, for example "IRBRobot"
		/// </summary>
		public string Type { get; set; }
	}
}
