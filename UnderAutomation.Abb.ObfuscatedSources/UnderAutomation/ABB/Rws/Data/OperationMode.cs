//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Operating mode selected on the robot controller
	/// </summary>
	public enum OperationMode {

		/// <summary>
		/// The operating mode could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The controller is initializing
		/// </summary>
		Init = 1,

		/// <summary>
		/// A change to the automatic mode has been requested and is waiting to be acknowledged
		/// </summary>
		AutomaticChangeRequest = 2,

		/// <summary>
		/// A change to the manual full speed mode has been requested and is waiting to be acknowledged
		/// </summary>
		ManualFullSpeedChangeRequest = 3,

		/// <summary>
		/// Manual mode at reduced speed
		/// </summary>
		ManualReducedSpeed = 4,

		/// <summary>
		/// Manual mode at full speed
		/// </summary>
		ManualFullSpeed = 5,

		/// <summary>
		/// Automatic mode
		/// </summary>
		Automatic = 6,

		/// <summary>
		/// The controller reports an undefined operating mode
		/// </summary>
		Undefined = 7,
	}
}
