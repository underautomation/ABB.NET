//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws {
	/// <summary>
	/// 
	/// Exception thrown when an RWS API request fails.
	/// Compatible with RWS v1 and v2.
	/// 
	/// </summary>
	public class RwsException : Exception {

		/// <summary>
		/// 
		/// Creates a new RWS exception with a message
		/// 
		/// </summary>
		public RwsException(string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Creates a new RWS exception with a message and the raw response body
		/// 
		/// </summary>
		public RwsException(string message, string responseBody)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Creates a new RWS exception with a message, status code and response body
		/// 
		/// </summary>
		public RwsException(string message, int statusCode, string responseBody)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Creates a new RWS exception with a message and inner exception
		/// 
		/// </summary>
		public RwsException(string message, Exception innerException)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Creates a new RWS exception that explains the failure of another one, keeping its diagnostics
		/// 
		/// </summary>
		public RwsException(string message, RwsException innerException)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Raw response body from the server, if available
		/// 
		/// </summary>
		public string ResponseBody { get; }

		/// <summary>
		/// 
		/// HTTP status code returned by the server
		/// 
		/// </summary>
		public Nullable<int> StatusCode { get; }

		/// <summary>
		/// 
		/// HTTP reason phrase returned by the server (e.g. &quot;Forbidden&quot;, &quot;Method Not Allowed&quot;), if available
		/// 
		/// </summary>
		public string ReasonPhrase { get; }

		/// <summary>
		/// 
		/// ABB internal error code extracted from the RWS error payload (e.g. &quot;-1073445865&quot;), if present
		/// 
		/// </summary>
		public string RwsErrorCode { get; }

		/// <summary>
		/// 
		/// Human readable error text extracted from the RWS error payload, if present
		/// 
		/// </summary>
		public string RwsErrorMessage { get; }
	}
}
