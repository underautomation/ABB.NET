//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// I/O signal defined in the robot controller.
	/// 
	/// <p>Returned by <code>IoService.GetSignals()</code>, <code>IoService.GetSignal()</code>, <code>IoService.SearchSignals()</code> and
	/// <code>IoService.SearchSignalsExtended()</code>.</p>
	/// <p>Depending on the method used, only a subset of the properties is filled in: the signal lists carry
	/// the name, type, category, logical value and logical state only.</p>
	/// </summary>
	public class IoSignalItem {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.IoSignalItem" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public IoSignalItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this signal
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the signal, for example "DRV1BRAKE"
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Name of the network the signal belongs to, for example "Local"
		/// </summary>
		public string NetworkName { get; set; }

		/// <summary>
		/// Name of the device the signal is connected to, for example "DRV_1"
		/// </summary>
		public string DeviceName { get; set; }

		/// <summary>
		/// Full path of the signal, "{network}/{device}/{signal}" (for example "Local/DRV_1/DRV1BRAKE")
		/// </summary>
		public string Path { get; set; }

		/// <summary>
		/// Type of the signal
		/// </summary>
		public IoSignalType Type { get; set; }

		/// <summary>
		/// Category the signal belongs to, for example "safety"
		/// </summary>
		public string Category { get; set; }

		/// <summary>
		/// Logical value of the signal, null when the controller did not report it
		/// </summary>
		public float? LogicalValue { get; set; }

		/// <summary>
		/// Logical state of the signal (simulated or not)
		/// </summary>
		public IoSignalLogicalState LogicalState { get; set; }

		/// <summary>
		/// Physical state of the signal.
		/// 
		/// <p>Only reported when reading a single signal with <code>IoService.GetSignal()</code>.</p>
		/// </summary>
		public IoSignalPhysicalState PhysicalState { get; set; }

		/// <summary>
		/// Physical value of the signal, null when the controller did not report it.
		/// 
		/// <p>Only reported by <code>IoService.GetSignal()</code> and <code>IoService.SearchSignalsExtended()</code>.</p>
		/// </summary>
		public float? PhysicalValue { get; set; }

		/// <summary>
		/// Seconds part of the global time at which the logical value was updated, null when not reported
		/// </summary>
		public long? LogicalTimeSeconds { get; set; }

		/// <summary>
		/// Microseconds part of the global time at which the logical value was updated, null when not reported
		/// </summary>
		public long? LogicalTimeMicroseconds { get; set; }

		/// <summary>
		/// Seconds part of the global time at which the physical value was updated, null when not reported
		/// </summary>
		public long? PhysicalTimeSeconds { get; set; }

		/// <summary>
		/// Microseconds part of the global time at which the physical value was updated, null when not reported
		/// </summary>
		public long? PhysicalTimeMicroseconds { get; set; }

		/// <summary>
		/// Quality of the signal, reported as a numeric code by <code>IoService.GetSignal()</code> and as a
		/// textual value (for example "good") by <code>IoService.SearchSignalsExtended()</code>
		/// </summary>
		public string Quality { get; set; }

		/// <summary>
		/// Access level required to write the signal, for example "None".
		/// 
		/// <p>Only reported by <code>IoService.SearchSignalsExtended()</code>.</p>
		/// </summary>
		public string WriteAccessLevel { get; set; }
	}
}
