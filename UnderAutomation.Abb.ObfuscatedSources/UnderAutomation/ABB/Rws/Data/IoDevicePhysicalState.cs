//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Physical state of an I/O device
	/// </summary>
	public enum IoDevicePhysicalState {

		/// <summary>
		/// The physical state could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The device is deactivated
		/// </summary>
		Deactivated = 1,

		/// <summary>
		/// The device is running
		/// </summary>
		Running = 2,

		/// <summary>
		/// The device reports an error
		/// </summary>
		Error = 3,

		/// <summary>
		/// The device is not connected
		/// </summary>
		Unconnected = 4,

		/// <summary>
		/// The device is not configured
		/// </summary>
		Unconfigured = 5,

		/// <summary>
		/// The device is starting up
		/// </summary>
		Startup = 6,

		/// <summary>
		/// The device is initializing
		/// </summary>
		Init = 7,

		/// <summary>
		/// The device is halted
		/// </summary>
		Halted = 8,
	}
}
