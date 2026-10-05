//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Represents a directory listing containing files, subdirectories, and devices.
	/// 
	/// <p>Returned by <code>FileService.ListDirectory(path)</code>.</p>
	/// <p>When listing the root path ("/"), the <see cref="UnderAutomation.ABB.Rws.Data.DirectoryListing.Devices"/> array contains available storage devices (C:, hd0a, etc.).</p>
	/// <p>When listing a subdirectory, only <see cref="UnderAutomation.ABB.Rws.Data.DirectoryListing.Files"/> and <see cref="UnderAutomation.ABB.Rws.Data.DirectoryListing.Directories"/> are typically populated.</p>
	/// </summary>
	public class DirectoryListing {

		/// <summary>
		/// Initializes a new instance of the <see cref="UnderAutomation.ABB.Rws.Data.DirectoryListing"/> class
		/// </summary>
		public DirectoryListing(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this directory listing
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Files contained in this directory
		/// </summary>
		public FileItem[] Files { get; set; }

		/// <summary>
		/// Subdirectories contained in this directory
		/// </summary>
		public DirectoryItem[] Directories { get; set; }

		/// <summary>
		/// Devices available in this listing (typically only present at root "/")
		/// </summary>
		public DeviceItem[] Devices { get; set; }

		/// <summary>
		/// Path that was listed
		/// </summary>
		public string Path { get; }

		/// <summary>
		/// Number of files in this listing
		/// </summary>
		public int FileCount { get; }

		/// <summary>
		/// Number of subdirectories in this listing
		/// </summary>
		public int DirectoryCount { get; }

		/// <summary>
		/// Number of devices in this listing
		/// </summary>
		public int DeviceCount { get; }

		/// <summary>
		/// Total number of items (files + directories + devices)
		/// </summary>
		public int TotalCount { get; }
	}
}
