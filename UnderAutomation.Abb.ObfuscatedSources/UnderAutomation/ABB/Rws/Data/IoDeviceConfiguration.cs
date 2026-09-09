//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Runtime configuration properties of an I/O device.
	/// <p>Returned by <code>IoService.GetDeviceConfiguration()</code>.</p>
	/// 
	/// </summary>
	public class IoDeviceConfiguration : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.IoDeviceConfiguration" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public IoDeviceConfiguration()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this device configuration
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Name of the device, for example &quot;DN_Internal_Device&quot;
		/// 
		/// </summary>
		public string DeviceName { get; set; }

		/// <summary>
		/// 
		/// Name of the industrial network the device belongs to, for example &quot;DeviceNet&quot;
		/// 
		/// </summary>
		public string NetworkName { get; set; }

		/// <summary>
		/// 
		/// Number of input bits of the device, null when not reported
		/// 
		/// </summary>
		public Nullable<int> InputBits { get; set; }

		/// <summary>
		/// 
		/// Number of output bits of the device, null when not reported
		/// 
		/// </summary>
		public Nullable<int> OutputBits { get; set; }

		/// <summary>
		/// 
		/// Whether a RAPID client can access the device in both manual and auto mode
		/// 
		/// </summary>
		public Nullable<bool> Rapid { get; set; }

		/// <summary>
		/// 
		/// Whether a local client can access the device in manual mode
		/// 
		/// </summary>
		public Nullable<bool> LocalManual { get; set; }

		/// <summary>
		/// 
		/// Whether a local client can access the device in auto mode
		/// 
		/// </summary>
		public Nullable<bool> LocalAuto { get; set; }

		/// <summary>
		/// 
		/// Whether a remote client can access the device in manual mode
		/// 
		/// </summary>
		public Nullable<bool> RemoteManual { get; set; }

		/// <summary>
		/// 
		/// Whether a remote client can access the device in auto mode
		/// 
		/// </summary>
		public Nullable<bool> RemoteAuto { get; set; }

		/// <summary>
		/// 
		/// Address of the device on its network, &quot;-&quot; when the network has no addressing
		/// 
		/// </summary>
		public string DeviceAddress { get; set; }

		/// <summary>
		/// 
		/// Whether deactivating the device is denied
		/// 
		/// </summary>
		public Nullable<bool> DenyDeactivate { get; set; }
	}
}
