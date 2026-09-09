//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Criteria used to search I/O signals with <code>IoService.SearchSignals()</code> and
	/// <code>IoService.SearchSignalsExtended()</code>.
	/// <p>Every property is optional: the properties left to null are not sent to the controller,
	/// and an empty criteria matches every signal.</p>
	/// <p>Two criteria can be combined by passing a second instance to the search methods, in which case
	/// a signal is returned only when it matches both. One of the two criteria should then have
	/// <xref href="UnderAutomation.ABB.Rws.Data.IoSignalSearchCriteria.Invert" data-throw-if-not-resolved="false"></xref> set to true, otherwise the result is the same as with a single criteria.</p>
	/// 
	/// </summary>
	public class IoSignalSearchCriteria : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.IoSignalSearchCriteria" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public IoSignalSearchCriteria()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this search criteria
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Name of the searched signals
		/// 
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 
		/// Name of the device the searched signals are connected to
		/// 
		/// </summary>
		public string DeviceName { get; set; }

		/// <summary>
		/// 
		/// Name of the network the searched signals belong to
		/// 
		/// </summary>
		public string NetworkName { get; set; }

		/// <summary>
		/// 
		/// Category of the searched signals, for example &quot;safety&quot;
		/// 
		/// </summary>
		public string Category { get; set; }

		/// <summary>
		/// 
		/// Category prefix of the searched signals
		/// 
		/// </summary>
		public string CategoryPrefix { get; set; }

		/// <summary>
		/// 
		/// Type of the searched signals, null to search every type
		/// 
		/// </summary>
		public Nullable<IoSignalType> Type { get; set; }

		/// <summary>
		/// 
		/// Whether the criteria is inverted: the signals matching it are excluded from the result
		/// 
		/// </summary>
		public Nullable<bool> Invert { get; set; }

		/// <summary>
		/// 
		/// Whether only the blocked (simulated) signals are searched
		/// 
		/// </summary>
		public Nullable<bool> Blocked { get; set; }
	}
}
