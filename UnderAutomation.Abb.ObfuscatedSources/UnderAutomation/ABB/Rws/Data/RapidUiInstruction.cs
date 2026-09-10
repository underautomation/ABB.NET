//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// The dialogue a running RAPID program is currently asking an operator for.
	/// 
	/// <p>Returned by <code>RapidService.GetActiveUiInstruction()</code>, which returns null when no
	/// instruction is pending. Answering one means writing its parameters with
	/// <code>RapidService.SetUiInstructionParameter()</code>, using <xref href="UnderAutomation.ABB.Rws.Data.RapidUiInstruction.StackUrl" data-throw-if-not-resolved="false"></xref> to address them.</p>
	/// </summary>
	public class RapidUiInstruction {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidUiInstruction" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidUiInstruction()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this instruction
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the RAPID instruction that opened the dialogue, for example "TPReadNum"
		/// </summary>
		public string Instruction { get; set; }

		/// <summary>
		/// What the instruction is asking of the client
		/// </summary>
		public RapidUiInstructionEvent Event { get; set; }

		/// <summary>
		/// Path identifying the call, which the parameter methods take
		/// </summary>
		public string StackUrl { get; set; }

		/// <summary>
		/// Level at which the instruction is executing
		/// </summary>
		public RapidExecutionLevel ExecutionLevel { get; set; }

		/// <summary>
		/// Text the instruction displays
		/// </summary>
		public string Message { get; set; }
	}
}
