//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// One message of the controller event log.
	/// 
	/// <p>Returned by <code>ElogService.GetMessages()</code>, <code>ElogService.GetMessageTitles()</code>,
	/// <code>ElogService.GetMessage()</code> and <code>ElogService.GetMessageBySequenceNumber()</code>.</p>
	/// <p>The texts (<xref href="UnderAutomation.ABB.Rws.Data.ElogMessage.Title" data-throw-if-not-resolved="false"></xref>, <xref href="UnderAutomation.ABB.Rws.Data.ElogMessage.Description" data-throw-if-not-resolved="false"></xref>, <xref href="UnderAutomation.ABB.Rws.Data.ElogMessage.Consequences" data-throw-if-not-resolved="false"></xref>,
	/// <xref href="UnderAutomation.ABB.Rws.Data.ElogMessage.Causes" data-throw-if-not-resolved="false"></xref> and <xref href="UnderAutomation.ABB.Rws.Data.ElogMessage.Actions" data-throw-if-not-resolved="false"></xref>) are only filled when a language was asked for.</p>
	/// </summary>
	public class ElogMessage {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.ElogMessage" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public ElogMessage()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this message
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Number of the domain the message belongs to, null when the controller did not report it
		/// </summary>
		public int? DomainNumber { get; set; }

		/// <summary>
		/// Number identifying the message inside its domain. Messages are numbered in the order
		/// they were logged, so a higher number is a more recent message.
		/// </summary>
		public int? SequenceNumber { get; set; }

		/// <summary>
		/// Severity of the message
		/// </summary>
		public ElogMessageType Type { get; set; }

		/// <summary>
		/// Number identifying the kind of event, the one printed on the teach pendant
		/// </summary>
		public int? Code { get; set; }

		/// <summary>
		/// Part of the controller that logged the message, for example "MC0"
		/// </summary>
		public string SourceName { get; set; }

		/// <summary>
		/// Moment the event was logged, null when the controller did not report it
		/// </summary>
		public DateTime? Timestamp { get; set; }

		/// <summary>
		/// Short text of the message. Only filled when a language was asked for.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Long text describing what happened. Only filled when a language was asked for.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Text describing what the event implies for the robot. Only filled when a language was asked for.
		/// </summary>
		public string Consequences { get; set; }

		/// <summary>
		/// Text describing the probable causes of the event. Only filled when a language was asked for.
		/// </summary>
		public string Causes { get; set; }

		/// <summary>
		/// Text describing the recommended actions. Only filled when a language was asked for.
		/// </summary>
		public string Actions { get; set; }

		/// <summary>
		/// Values the controller substitutes into the text of the message
		/// </summary>
		public ElogMessageArgument[] Arguments { get; set; }

		/// <summary>
		/// Number of arguments of the message
		/// </summary>
		public int ArgumentCount { get; }
	}
}
