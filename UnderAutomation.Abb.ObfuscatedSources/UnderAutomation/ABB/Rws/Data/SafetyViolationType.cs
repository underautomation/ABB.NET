//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Type of safety violation reported by the safety controller
	/// </summary>
	public enum SafetyViolationType {

		/// <summary>
		/// The violation type could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// No violation
		/// </summary>
		None = 1,

		/// <summary>
		/// Safe Tool Zone (stz)
		/// </summary>
		SafeToolZone = 2,

		/// <summary>
		/// Safe Axis Range (sar)
		/// </summary>
		SafeAxisRange = 3,

		/// <summary>
		/// Safe Tool Speed (sts)
		/// </summary>
		SafeToolSpeed = 4,

		/// <summary>
		/// Safe Axis Speed (sas)
		/// </summary>
		SafeAxisSpeed = 5,

		/// <summary>
		/// Tool Orientation Monitoring (tom)
		/// </summary>
		ToolOrientationMonitoring = 6,

		/// <summary>
		/// Operational Safety Range (osr)
		/// </summary>
		OperationalSafetyRange = 7,

		/// <summary>
		/// Safe Standstill (sst)
		/// </summary>
		SafeStandstill = 8,

		/// <summary>
		/// Reduced Tool Speed in manual mode (red_tool_speed)
		/// </summary>
		ReducedToolSpeed = 9,

		/// <summary>
		/// Reduced Axis Speed in manual mode (red_axis_speed)
		/// </summary>
		ReducedAxisSpeed = 10,

		/// <summary>
		/// Reduced Axis Speed due to unsynchronized robot (unsync_speed_lim)
		/// </summary>
		UnsynchronizedSpeedLimit = 11,

		/// <summary>
		/// Emergency stop triggered (empstop)
		/// </summary>
		EmergencyStop = 12,

		/// <summary>
		/// Internal error (other)
		/// </summary>
		Other = 13,

		/// <summary>
		/// The safety controller reports an invalid violation
		/// </summary>
		Invalid = 14,
	}
}
