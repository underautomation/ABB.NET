//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// One parameter of the pending UI instruction: what the program passed in, or what it is waiting for.
	/// 
	/// <p>Returned by <code>RapidService.GetUiInstructionParameters()</code>. The parameters carrying the answer
	/// are the ones to write, typically named after a function key or after the completion flag of the
	/// instruction.</p>
	/// </summary>
	public class RapidUiInstructionParameter {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidUiInstructionParameter" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidUiInstructionParameter()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this parameter
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the parameter, for example "TPCompleted"
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Value of the parameter, written the way RAPID writes it
		/// </summary>
		public string Value { get; set; }
	}
}
