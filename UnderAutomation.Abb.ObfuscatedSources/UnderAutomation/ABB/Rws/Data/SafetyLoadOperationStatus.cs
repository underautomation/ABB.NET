//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Indicates whether a new safety configuration is allowed to be loaded
	/// </summary>
	public enum SafetyLoadOperationStatus {

		/// <summary>
		/// The status could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Loading a new safety configuration is allowed
		/// </summary>
		Ok = 1,

		/// <summary>
		/// The safety option is not present on the controller (SCORCH_ERR_OPTION_NOT_PRESENT)
		/// </summary>
		OptionNotPresent = 2,

		/// <summary>
		/// The controller is not in manual mode (SCORCH_ERR_NOT_IN_MANUAL_MODE)
		/// </summary>
		NotInManualMode = 3,

		/// <summary>
		/// The motors are not switched off (SCORCH_ERR_NOT_IN_MOTORS_OFF)
		/// </summary>
		NotInMotorsOff = 4,

		/// <summary>
		/// The current safety configuration is locked (SCORCH_ERR_CURRENT_CONFIG_LOCKED)
		/// </summary>
		CurrentConfigurationLocked = 5,

		/// <summary>
		/// The user does not have the required grant (SCORCH_ERR_USER_GRANT_IS_MISSING)
		/// </summary>
		UserGrantMissing = 6,
	}
}
