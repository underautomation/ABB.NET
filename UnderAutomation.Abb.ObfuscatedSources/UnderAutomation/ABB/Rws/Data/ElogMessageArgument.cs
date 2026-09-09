//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// One argument of an event log message. The arguments are the values the controller substitutes
	/// into the text of the message, for example the name of the task that was started.
	/// <p>Held by <xref href="UnderAutomation.ABB.Rws.Data.ElogMessage.Arguments" data-throw-if-not-resolved="false"></xref>.</p>
	/// 
	/// </summary>
	public class ElogMessageArgument : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.ElogMessageArgument" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public ElogMessageArgument()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this argument
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Position of the argument in the message, starting at 1
		/// 
		/// </summary>
		public int Index { get; set; }

		/// <summary>
		/// 
		/// Type of the argument reported by the controller, for example &quot;string&quot;, &quot;long&quot; or &quot;float&quot;
		/// 
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// 
		/// Value of the argument, always as text
		/// 
		/// </summary>
		public string Value { get; set; }
	}
}
