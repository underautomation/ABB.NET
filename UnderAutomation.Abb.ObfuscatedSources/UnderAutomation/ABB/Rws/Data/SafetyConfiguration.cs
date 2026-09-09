//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Safety supervision configuration of the controller.
	/// <p>Returned by <code>ControllerService.GetSafetyConfiguration()</code>.</p>
	/// 
	/// </summary>
	public class SafetyConfiguration : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.SafetyConfiguration" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public SafetyConfiguration()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this safety configuration
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Status of the configuration, for example &quot;SCORCH_CONFIG_LOADED&quot;.
		/// <p>Only available when connected with version 2.</p>
		/// 
		/// </summary>
		public string ConfigurationStatus { get; set; }

		/// <summary>
		/// 
		/// Safety software major version
		/// 
		/// </summary>
		public Nullable<int> SoftwareMajorVersion { get; set; }

		/// <summary>
		/// 
		/// Safety software minor version
		/// 
		/// </summary>
		public Nullable<int> SoftwareMinorVersion { get; set; }

		/// <summary>
		/// 
		/// Safety software revision
		/// 
		/// </summary>
		public Nullable<int> SoftwareRevision { get; set; }

		/// <summary>
		/// 
		/// Configuration file major version
		/// 
		/// </summary>
		public Nullable<int> FileMajorVersion { get; set; }

		/// <summary>
		/// 
		/// Configuration file minor version
		/// 
		/// </summary>
		public Nullable<int> FileMinorVersion { get; set; }

		/// <summary>
		/// 
		/// Configuration file revision
		/// 
		/// </summary>
		public Nullable<int> FileRevision { get; set; }

		/// <summary>
		/// 
		/// Creation date of the configuration, if available
		/// 
		/// </summary>
		public Nullable<DateTime> CreationDate { get; set; }

		/// <summary>
		/// 
		/// Author of the configuration
		/// 
		/// </summary>
		public string CreatedBy { get; set; }

		/// <summary>
		/// 
		/// Name of the configuration
		/// 
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 
		/// Checksum of the configuration, as base64 encoded data
		/// 
		/// </summary>
		public string Checksum { get; set; }
	}
}
