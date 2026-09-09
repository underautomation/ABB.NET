//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Type of safety violation reported by the safety controller
	/// 
	/// </summary>
	public sealed class SafetyViolationType : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The violation type could not be determined
		/// 
		/// </summary>
		public const SafetyViolationType Unknown;

		/// <summary>
		/// 
		/// No violation
		/// 
		/// </summary>
		public const SafetyViolationType None;

		/// <summary>
		/// 
		/// Safe Tool Zone (stz)
		/// 
		/// </summary>
		public const SafetyViolationType SafeToolZone;

		/// <summary>
		/// 
		/// Safe Axis Range (sar)
		/// 
		/// </summary>
		public const SafetyViolationType SafeAxisRange;

		/// <summary>
		/// 
		/// Safe Tool Speed (sts)
		/// 
		/// </summary>
		public const SafetyViolationType SafeToolSpeed;

		/// <summary>
		/// 
		/// Safe Axis Speed (sas)
		/// 
		/// </summary>
		public const SafetyViolationType SafeAxisSpeed;

		/// <summary>
		/// 
		/// Tool Orientation Monitoring (tom)
		/// 
		/// </summary>
		public const SafetyViolationType ToolOrientationMonitoring;

		/// <summary>
		/// 
		/// Operational Safety Range (osr)
		/// 
		/// </summary>
		public const SafetyViolationType OperationalSafetyRange;

		/// <summary>
		/// 
		/// Safe Standstill (sst)
		/// 
		/// </summary>
		public const SafetyViolationType SafeStandstill;

		/// <summary>
		/// 
		/// Reduced Tool Speed in manual mode (red_tool_speed)
		/// 
		/// </summary>
		public const SafetyViolationType ReducedToolSpeed;

		/// <summary>
		/// 
		/// Reduced Axis Speed in manual mode (red_axis_speed)
		/// 
		/// </summary>
		public const SafetyViolationType ReducedAxisSpeed;

		/// <summary>
		/// 
		/// Reduced Axis Speed due to unsynchronized robot (unsync_speed_lim)
		/// 
		/// </summary>
		public const SafetyViolationType UnsynchronizedSpeedLimit;

		/// <summary>
		/// 
		/// Emergency stop triggered (empstop)
		/// 
		/// </summary>
		public const SafetyViolationType EmergencyStop;

		/// <summary>
		/// 
		/// Internal error (other)
		/// 
		/// </summary>
		public const SafetyViolationType Other;

		/// <summary>
		/// 
		/// The safety controller reports an invalid violation
		/// 
		/// </summary>
		public const SafetyViolationType Invalid;
	}
}
