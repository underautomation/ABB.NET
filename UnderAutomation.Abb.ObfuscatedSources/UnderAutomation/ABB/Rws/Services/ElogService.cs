//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.ABB.Rws.Data;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace UnderAutomation.ABB.Rws.Services {
	/// <summary>
	/// 
	/// Event Log Service - Provides access to the messages the controller logs: the list of the log domains,
	/// the messages they hold, and the operations that clear them or dump them to a file.
	/// None of these resources is available while the controller runs in bootserver mode.
	/// 
	/// </summary>
	public class ElogService : Object {

		/// <summary>
		/// 
		/// Gets every event log domain of the controller, with the number of messages each one holds (synchronous)
		/// 
		/// </summary>
		/// <param name="language">Two letter code of the language the domain names are wanted in, for example &quot;en&quot;
		/// or &quot;de&quot;. Leave null to skip the names and only read the numbers and the counts.</param>
		/// <returns>Event log domains, ordered as the controller reports them</returns>
		public ElogDomain[] GetDomains(string language = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets every event log domain of the controller, with the number of messages each one holds (asynchronous)
		/// 
		/// </summary>
		/// <param name="language">Two letter code of the language the domain names are wanted in, for example &quot;en&quot;
		/// or &quot;de&quot;. Leave null to skip the names and only read the numbers and the counts.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Event log domains, ordered as the controller reports them</returns>
		public Task<ElogDomain[]> GetDomainsAsync(string language = null, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the number of messages one event log domain holds and the number it can hold (synchronous)
		/// 
		/// </summary>
		/// <param name="domain">Number of the domain, as reported by <xref href="UnderAutomation.ABB.Rws.Services.ElogService.GetDomains(System.String)" data-throw-if-not-resolved="false"></xref></param>
		/// <returns>The domain, without its name</returns>
		public ElogDomain GetDomain(int domain)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the number of messages one event log domain holds and the number it can hold (asynchronous)
		/// 
		/// </summary>
		/// <param name="domain">Number of the domain, as reported by <xref href="UnderAutomation.ABB.Rws.Services.ElogService.GetDomainsAsync(System.String%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref></param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The domain, without its name</returns>
		public Task<ElogDomain> GetDomainAsync(int domain, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the messages held by one event log domain (synchronous)
		/// 
		/// </summary>
		/// <param name="domain">Number of the domain, as reported by <xref href="UnderAutomation.ABB.Rws.Services.ElogService.GetDomains(System.String)" data-throw-if-not-resolved="false"></xref></param>
		/// <param name="order">Order the messages are returned in, most recent first by default</param>
		/// <param name="language">Two letter code of the language the message texts are wanted in, for example &quot;en&quot;
		/// or &quot;de&quot;. Leave null to read only the code, the severity and the timestamp of each message.</param>
		/// <param name="maxCount">Largest number of messages to return, null to return every message of the domain</param>
		/// <returns>Messages of the domain, empty when the domain holds none</returns>
		public ElogMessage[] GetMessages(int domain, ElogMessageOrder order, string language = null, Nullable<int> maxCount = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the messages held by one event log domain (asynchronous)
		/// 
		/// </summary>
		/// <param name="domain">Number of the domain, as reported by <xref href="UnderAutomation.ABB.Rws.Services.ElogService.GetDomainsAsync(System.String%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref></param>
		/// <param name="order">Order the messages are returned in, most recent first by default</param>
		/// <param name="language">Two letter code of the language the message texts are wanted in, for example &quot;en&quot;
		/// or &quot;de&quot;. Leave null to read only the code, the severity and the timestamp of each message.</param>
		/// <param name="maxCount">Largest number of messages to return, null to return every message of the domain</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Messages of the domain, empty when the domain holds none</returns>
		public Task<ElogMessage[]> GetMessagesAsync(int domain, ElogMessageOrder order, string language = null, Nullable<int> maxCount = null, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the messages held by one event log domain, with their short text only (synchronous)
		/// 
		/// </summary>
		/// <param name="domain">Number of the domain, as reported by <xref href="UnderAutomation.ABB.Rws.Services.ElogService.GetDomains(System.String)" data-throw-if-not-resolved="false"></xref></param>
		/// <param name="language">Two letter code of the language the titles are wanted in, for example &quot;en&quot; or &quot;de&quot;. Required.</param>
		/// <param name="order">Order the messages are returned in, most recent first by default</param>
		/// <param name="maxCount">Largest number of messages to return, null to return every message of the domain</param>
		/// <returns>Messages of the domain, carrying their severity, code, timestamp and title only</returns>
		public ElogMessage[] GetMessageTitles(int domain, string language, ElogMessageOrder order, Nullable<int> maxCount = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the messages held by one event log domain, with their short text only (asynchronous)
		/// 
		/// </summary>
		/// <param name="domain">Number of the domain, as reported by <xref href="UnderAutomation.ABB.Rws.Services.ElogService.GetDomainsAsync(System.String%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref></param>
		/// <param name="language">Two letter code of the language the titles are wanted in, for example &quot;en&quot; or &quot;de&quot;. Required.</param>
		/// <param name="order">Order the messages are returned in, most recent first by default</param>
		/// <param name="maxCount">Largest number of messages to return, null to return every message of the domain</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Messages of the domain, carrying their severity, code, timestamp and title only</returns>
		public Task<ElogMessage[]> GetMessageTitlesAsync(int domain, string language, ElogMessageOrder order, Nullable<int> maxCount = null, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets one message of an event log domain (synchronous)
		/// 
		/// </summary>
		/// <param name="domain">Number of the domain, as reported by <xref href="UnderAutomation.ABB.Rws.Services.ElogService.GetDomains(System.String)" data-throw-if-not-resolved="false"></xref></param>
		/// <param name="sequenceNumber">Number identifying the message inside its domain</param>
		/// <param name="language">Two letter code of the language the message texts are wanted in, for example &quot;en&quot;
		/// or &quot;de&quot;. Leave null to read only the code, the severity and the timestamp.</param>
		/// <returns>The message</returns>
		public ElogMessage GetMessage(int domain, int sequenceNumber, string language = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets one message of an event log domain (asynchronous)
		/// 
		/// </summary>
		/// <param name="domain">Number of the domain, as reported by <xref href="UnderAutomation.ABB.Rws.Services.ElogService.GetDomainsAsync(System.String%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref></param>
		/// <param name="sequenceNumber">Number identifying the message inside its domain</param>
		/// <param name="language">Two letter code of the language the message texts are wanted in, for example &quot;en&quot;
		/// or &quot;de&quot;. Leave null to read only the code, the severity and the timestamp.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The message</returns>
		public Task<ElogMessage> GetMessageAsync(int domain, int sequenceNumber, string language = null, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets one message from its sequence number alone, without naming the domain it belongs to (synchronous)
		/// 
		/// </summary>
		/// <param name="sequenceNumber">Number identifying the message</param>
		/// <param name="language">Two letter code of the language the message texts are wanted in, for example &quot;en&quot;
		/// or &quot;de&quot;. Leave null to read only the code, the severity and the timestamp.</param>
		/// <returns>The message</returns>
		public ElogMessage GetMessageBySequenceNumber(int sequenceNumber, string language = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets one message from its sequence number alone, without naming the domain it belongs to (asynchronous)
		/// 
		/// </summary>
		/// <param name="sequenceNumber">Number identifying the message</param>
		/// <param name="language">Two letter code of the language the message texts are wanted in, for example &quot;en&quot;
		/// or &quot;de&quot;. Leave null to read only the code, the severity and the timestamp.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The message</returns>
		public Task<ElogMessage> GetMessageBySequenceNumberAsync(int sequenceNumber, string language = null, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Deletes every message of one event log domain (synchronous)
		/// 
		/// </summary>
		/// <param name="domain">Number of the domain, as reported by <xref href="UnderAutomation.ABB.Rws.Services.ElogService.GetDomains(System.String)" data-throw-if-not-resolved="false"></xref></param>
		public void ClearMessages(int domain)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Deletes every message of one event log domain (asynchronous)
		/// 
		/// </summary>
		/// <param name="domain">Number of the domain, as reported by <xref href="UnderAutomation.ABB.Rws.Services.ElogService.GetDomainsAsync(System.String%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref></param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task ClearMessagesAsync(int domain, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Deletes every message of every event log domain (synchronous)
		/// 
		/// </summary>
		public void ClearAllMessages()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Deletes every message of every event log domain (asynchronous)
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task ClearAllMessagesAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Asks the controller to write the whole event log to one file on its own file system (synchronous)
		/// 
		/// </summary>
		/// <param name="path">Destination file on the controller, for example &quot;$temp/elog.txt&quot; or
		/// &quot;/fileservice/$home/elog.txt&quot;. Both spellings of an environment variable are accepted.</param>
		public void SaveInSystemDumpFormat(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Asks the controller to write the whole event log to one file on its own file system (asynchronous)
		/// 
		/// </summary>
		/// <param name="path">Destination file on the controller, for example &quot;$temp/elog.txt&quot; or
		/// &quot;/fileservice/$home/elog.txt&quot;. Both spellings of an environment variable are accepted.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SaveInSystemDumpFormatAsync(string path, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
