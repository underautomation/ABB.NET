//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Logical state of an I/O device
	/// </summary>
	public enum IoDeviceLogicalState {

		/// <summary>
		/// The logical state could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The device is enabled
		/// </summary>
		Enabled = 1,

		/// <summary>
		/// The device is disabled
		/// </summary>
		Disabled = 2,
	}
}
