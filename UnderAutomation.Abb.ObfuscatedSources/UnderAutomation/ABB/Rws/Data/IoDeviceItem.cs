//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// I/O device (unit) connected to an I/O network of the robot controller.
	/// <p>Returned by <code>IoService.GetDevices()</code>, <code>IoService.GetDevice()</code> and <code>IoService.SearchDevices()</code>.</p>
	/// 
	/// </summary>
	public class IoDeviceItem : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.IoDeviceItem" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public IoDeviceItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this device
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Name of the device, for example &quot;DRV_1&quot; or &quot;PANEL&quot;
		/// 
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 
		/// Name of the network the device is connected to, for example &quot;Local&quot;
		/// 
		/// </summary>
		public string NetworkName { get; set; }

		/// <summary>
		/// 
		/// Full path of the device, &quot;{network}/{device}&quot; (for example &quot;Local/DRV_1&quot;)
		/// 
		/// </summary>
		public string Path { get; set; }

		/// <summary>
		/// 
		/// Type of the device, for example &quot;DRV_1_TYPE&quot;.
		/// <p>Not reported by every controller, null when absent. A virtual controller leaves it out.</p>
		/// 
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// 
		/// Physical state of the device
		/// 
		/// </summary>
		public IoDevicePhysicalState PhysicalState { get; set; }

		/// <summary>
		/// 
		/// Logical state of the device
		/// 
		/// </summary>
		public IoDeviceLogicalState LogicalState { get; set; }

		/// <summary>
		/// 
		/// Address of the device on its network, &quot;-&quot; when the network has no addressing
		/// 
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// 
		/// Input data of the device, as an hexadecimal string (for example &quot;1FFFE063&quot;).
		/// <p>Only reported when reading a single device with <code>IoService.GetDevice()</code>.</p>
		/// 
		/// </summary>
		public string InputData { get; set; }

		/// <summary>
		/// 
		/// Input mask of the device, as an hexadecimal string. A bit set to zero is an input bit that is not written.
		/// <p>Only reported when reading a single device with <code>IoService.GetDevice()</code>.</p>
		/// 
		/// </summary>
		public string InputMask { get; set; }

		/// <summary>
		/// 
		/// Output data of the device, as an hexadecimal string (for example &quot;0000000E&quot;).
		/// <p>Only reported when reading a single device with <code>IoService.GetDevice()</code>.</p>
		/// 
		/// </summary>
		public string OutputData { get; set; }

		/// <summary>
		/// 
		/// Output mask of the device, as an hexadecimal string. A bit set to zero is an output bit that is not written.
		/// <p>Only reported when reading a single device with <code>IoService.GetDevice()</code>.</p>
		/// 
		/// </summary>
		public string OutputMask { get; set; }
	}
}
