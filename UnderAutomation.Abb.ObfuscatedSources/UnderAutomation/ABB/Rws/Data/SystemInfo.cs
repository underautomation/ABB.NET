//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Identity and software version of the system running on the controller.
	/// 
	/// <p>Returned by <code>SystemService.GetInfo()</code>.</p>
	/// </summary>
	public class SystemInfo {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.SystemInfo" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public SystemInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this system
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the system installed on the controller
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Version of the robot software the system runs
		/// </summary>
		public string Version { get; set; }

		/// <summary>
		/// Human readable version of the robot software the system runs
		/// </summary>
		public string VersionName { get; set; }

		/// <summary>
		/// Version of the software distribution the system was installed from.
		/// 
		/// <p>Null when the controller does not report it.</p>
		/// </summary>
		public string DistributionVersion { get; set; }

		/// <summary>
		/// Unique identifier of the system
		/// </summary>
		public string SystemId { get; set; }

		/// <summary>
		/// Moment the system was last started, null when the controller did not report it
		/// </summary>
		public DateTime? StartTime { get; set; }

		/// <summary>
		/// Major number of the version, null when the controller did not report it
		/// </summary>
		public int? Major { get; set; }

		/// <summary>
		/// Minor number of the version, null when the controller did not report it
		/// </summary>
		public int? Minor { get; set; }

		/// <summary>
		/// Build number of the version, null when the controller did not report it
		/// </summary>
		public int? Build { get; set; }

		/// <summary>
		/// Revision number of the version, null when the controller did not report it
		/// </summary>
		public int? Revision { get; set; }

		/// <summary>
		/// Sub revision number of the version, null when the controller did not report it
		/// </summary>
		public int? SubRevision { get; set; }

		/// <summary>
		/// Free text describing the build the system was produced by, null when the controller did not report it
		/// </summary>
		public string BuildTag { get; set; }

		/// <summary>
		/// Revision of the programming interface the system is compatible with,
		/// null when the controller did not report it
		/// </summary>
		public int? ApiCompatibilityRevision { get; set; }

		/// <summary>
		/// Title of the system, null when the controller did not report it
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Type of the system, null when the controller did not report it
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// Description of the system, null when the controller did not report it
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Date the system was produced, null when the controller did not report it
		/// </summary>
		public DateTime? Date { get; set; }

		/// <summary>
		/// Timestamp of the configuration the system was built with, as the controller spells it.
		/// 
		/// <p>Null when the controller did not report it, which is the usual case on a virtual controller.</p>
		/// </summary>
		public string ConfigurationTimestamp { get; set; }

		/// <summary>
		/// Options installed on the system, in the order the controller reports them
		/// </summary>
		public string[] Options { get; set; }

		/// <summary>
		/// Number of options installed on the system
		/// </summary>
		public int OptionCount { get; }
	}
}
