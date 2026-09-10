//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Runtime configuration properties of an I/O signal.
	/// 
	/// <p>Returned by <code>IoService.GetSignalConfiguration()</code>.</p>
	/// </summary>
	public class IoSignalConfiguration {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.IoSignalConfiguration" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public IoSignalConfiguration()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this signal configuration
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the signal, for example "DRV1CHAIN2"
		/// </summary>
		public string SignalName { get; set; }

		/// <summary>
		/// Number of bits of the signal, null when not reported
		/// </summary>
		public int? SignalBits { get; set; }

		/// <summary>
		/// Whether a RAPID client can write the signal in both manual and auto mode
		/// </summary>
		public bool? Rapid { get; set; }

		/// <summary>
		/// Whether a local client can write the signal in manual mode
		/// </summary>
		public bool? LocalManual { get; set; }

		/// <summary>
		/// Whether a local client can write the signal in auto mode
		/// </summary>
		public bool? LocalAuto { get; set; }

		/// <summary>
		/// Whether a remote client can write the signal in manual mode
		/// </summary>
		public bool? RemoteManual { get; set; }

		/// <summary>
		/// Whether a remote client can write the signal in auto mode
		/// </summary>
		public bool? RemoteAuto { get; set; }

		/// <summary>
		/// Whether the bits of this signal are set by a device transfer operation.
		/// 
		/// <p>Not reported by every controller, null when absent from the response.</p>
		/// </summary>
		public bool? SetByDeviceTransfer { get; set; }
	}
}
