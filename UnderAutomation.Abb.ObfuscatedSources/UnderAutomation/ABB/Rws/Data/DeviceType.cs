//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Represents the type of storage device
	/// </summary>
	public enum DeviceType {

		/// <summary>
		/// Fixed storage device (hard drive)
		/// </summary>
		Fixed = 0,

		/// <summary>
		/// Removable storage device (USB, SD card, etc.)
		/// </summary>
		Removable = 1,

		/// <summary>
		/// RAM disk
		/// </summary>
		RamDisk = 2,

		/// <summary>
		/// Remote or network storage
		/// </summary>
		Remote = 3,

		/// <summary>
		/// Unknown device type
		/// </summary>
		Unknown = 4,
	}
}
