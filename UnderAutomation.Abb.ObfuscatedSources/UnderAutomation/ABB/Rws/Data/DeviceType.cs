//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Represents the type of storage device
	/// 
	/// </summary>
	public sealed class DeviceType : Enum {


		public int value__;

		/// <summary>
		/// 
		/// Fixed storage device (hard drive)
		/// 
		/// </summary>
		public const DeviceType Fixed;

		/// <summary>
		/// 
		/// Removable storage device (USB, SD card, etc.)
		/// 
		/// </summary>
		public const DeviceType Removable;

		/// <summary>
		/// 
		/// RAM disk
		/// 
		/// </summary>
		public const DeviceType RamDisk;

		/// <summary>
		/// 
		/// Remote or network storage
		/// 
		/// </summary>
		public const DeviceType Remote;

		/// <summary>
		/// 
		/// Unknown device type
		/// 
		/// </summary>
		public const DeviceType Unknown;
	}
}
