//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Indicates whether a new safety configuration is allowed to be loaded
	/// 
	/// </summary>
	public sealed class SafetyLoadOperationStatus : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The status could not be determined
		/// 
		/// </summary>
		public const SafetyLoadOperationStatus Unknown;

		/// <summary>
		/// 
		/// Loading a new safety configuration is allowed
		/// 
		/// </summary>
		public const SafetyLoadOperationStatus Ok;

		/// <summary>
		/// 
		/// The safety option is not present on the controller (SCORCH_ERR_OPTION_NOT_PRESENT)
		/// 
		/// </summary>
		public const SafetyLoadOperationStatus OptionNotPresent;

		/// <summary>
		/// 
		/// The controller is not in manual mode (SCORCH_ERR_NOT_IN_MANUAL_MODE)
		/// 
		/// </summary>
		public const SafetyLoadOperationStatus NotInManualMode;

		/// <summary>
		/// 
		/// The motors are not switched off (SCORCH_ERR_NOT_IN_MOTORS_OFF)
		/// 
		/// </summary>
		public const SafetyLoadOperationStatus NotInMotorsOff;

		/// <summary>
		/// 
		/// The current safety configuration is locked (SCORCH_ERR_CURRENT_CONFIG_LOCKED)
		/// 
		/// </summary>
		public const SafetyLoadOperationStatus CurrentConfigurationLocked;

		/// <summary>
		/// 
		/// The user does not have the required grant (SCORCH_ERR_USER_GRANT_IS_MISSING)
		/// 
		/// </summary>
		public const SafetyLoadOperationStatus UserGrantMissing;
	}
}
