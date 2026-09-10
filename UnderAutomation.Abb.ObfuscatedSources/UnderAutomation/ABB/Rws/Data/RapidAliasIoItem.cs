//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// An I/O signal a running RAPID program has given an alias to with the AliasIO instruction.
	/// 
	/// <p>Returned by <code>RapidService.GetAliasIo()</code>. The controller only knows about an alias while the
	/// program that declares it is loaded, so this list is empty on a controller holding no such program.</p>
	/// </summary>
	public class RapidAliasIoItem {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidAliasIoItem" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidAliasIoItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this alias
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name the RAPID program refers to the signal by
		/// </summary>
		public string AliasName { get; set; }

		/// <summary>
		/// Name of the I/O signal the alias points at
		/// </summary>
		public string SignalName { get; set; }

		/// <summary>
		/// Type of the aliased signal
		/// </summary>
		public IoSignalType Type { get; set; }
	}
}
