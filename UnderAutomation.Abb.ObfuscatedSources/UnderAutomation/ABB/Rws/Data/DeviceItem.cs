//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Represents a device entry in the robot controller file system (e.g. C:, hd0a).
	/// <p>Devices are returned alongside files and directories when listing the root path (&quot;/&quot;)
	/// or any directory that contains mounted devices.</p>
	/// 
	/// </summary>
	public class DeviceItem : FileSystemItem {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.DeviceItem" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public DeviceItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this device entry
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Type of device (Fixed, Removable, RamDisk, Remote)
		/// 
		/// </summary>
		public DeviceType DeviceType { get; set; }

		/// <summary>
		/// 
		/// Total storage space in bytes
		/// 
		/// </summary>
		public long TotalSpace { get; set; }

		/// <summary>
		/// 
		/// Free storage space in bytes
		/// 
		/// </summary>
		public long FreeSpace { get; set; }

		/// <summary>
		/// 
		/// Indicates if the device is enabled
		/// 
		/// </summary>
		public bool IsEnabled { get; set; }

		/// <summary>
		/// 
		/// Indicates if the device is read-only
		/// 
		/// </summary>
		public bool IsReadOnly { get; set; }
	}
}
