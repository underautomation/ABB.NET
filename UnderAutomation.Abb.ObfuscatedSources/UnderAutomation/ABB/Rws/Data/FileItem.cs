//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Represents a file entry in the robot controller file system.
	/// </summary>
	public class FileItem : FileSystemItem {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.FileItem" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public FileItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this file entry
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// File size in bytes
		/// </summary>
		public long Size { get; set; }

		/// <summary>
		/// Indicates if the file is read-only
		/// </summary>
		public bool IsReadOnly { get; set; }
	}
}
