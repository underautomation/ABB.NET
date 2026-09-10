//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// One event log domain of the controller, for example the common, the operational or the safety log.
	/// 
	/// <p>Returned by <code>ElogService.GetDomains()</code> and <code>ElogService.GetDomain()</code>.</p>
	/// </summary>
	public class ElogDomain {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.ElogDomain" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public ElogDomain()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this domain
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Number identifying the domain, which is the value to pass to the methods reading its messages
		/// </summary>
		public int Number { get; set; }

		/// <summary>
		/// Name of the domain, for example "Operational" or "Safety".
		/// 
		/// <p>Only filled when a language was asked for, null otherwise.</p>
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Number of messages currently held by the domain, null when the controller did not report it
		/// </summary>
		public int? MessageCount { get; set; }

		/// <summary>
		/// Number of messages the domain can hold before the oldest ones are discarded,
		/// null when the controller did not report it
		/// </summary>
		public int? BufferSize { get; set; }
	}
}
