//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Safety violation details reported by the safety controller.
	/// <p>Returned by <code>ControllerService.GetSafetyViolationInfo()</code>.</p>
	/// 
	/// </summary>
	public class SafetyViolationInfo : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.SafetyViolationInfo" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public SafetyViolationInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this safety violation information
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Number of violations
		/// 
		/// </summary>
		public Nullable<int> ViolationNumber { get; set; }

		/// <summary>
		/// 
		/// Type of the current violation
		/// 
		/// </summary>
		public SafetyViolationType ViolationType { get; set; }

		/// <summary>
		/// 
		/// Instance id of the last violation
		/// 
		/// </summary>
		public Nullable<int> LastViolationInstanceId { get; set; }

		/// <summary>
		/// 
		/// Indicates whether the robot is unsynchronized
		/// 
		/// </summary>
		public Nullable<int> Unsynchronized { get; set; }

		/// <summary>
		/// 
		/// Id of the tool involved in the violation
		/// 
		/// </summary>
		public Nullable<int> ToolId { get; set; }

		/// <summary>
		/// 
		/// Index of the drive module involved in the violation
		/// 
		/// </summary>
		public Nullable<int> DriveModuleIndex { get; set; }

		/// <summary>
		/// 
		/// Violating safety supervision value
		/// 
		/// </summary>
		public Nullable<int> ViolatingSsv { get; set; }

		/// <summary>
		/// 
		/// Tool position violation status
		/// 
		/// </summary>
		public Nullable<int> ToolPositionViolationStatus { get; set; }

		/// <summary>
		/// 
		/// Tool position supervision active status
		/// 
		/// </summary>
		public Nullable<int> ToolPositionActiveStatus { get; set; }

		/// <summary>
		/// 
		/// Upper arm violation status
		/// 
		/// </summary>
		public Nullable<int> UpperArmViolationStatus { get; set; }

		/// <summary>
		/// 
		/// Tool speed violation status
		/// 
		/// </summary>
		public Nullable<int> ToolSpeedViolationStatus { get; set; }

		/// <summary>
		/// 
		/// Tool speed supervision active status
		/// 
		/// </summary>
		public Nullable<int> ToolSpeedActiveStatus { get; set; }

		/// <summary>
		/// 
		/// Axis range violation status
		/// 
		/// </summary>
		public Nullable<int> AxisRangeViolationStatus { get; set; }

		/// <summary>
		/// 
		/// Axis range supervision active status
		/// 
		/// </summary>
		public Nullable<int> AxisRangeActiveStatus { get; set; }
	}
}
