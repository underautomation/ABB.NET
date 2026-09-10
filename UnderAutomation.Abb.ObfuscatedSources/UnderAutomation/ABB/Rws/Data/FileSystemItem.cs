//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Abstract base class for all file system items returned by the File Service.
	/// 
	/// <p>Derived classes: <xref href="UnderAutomation.ABB.Rws.Data.FileItem" data-throw-if-not-resolved="false"></xref>, <xref href="UnderAutomation.ABB.Rws.Data.DirectoryItem" data-throw-if-not-resolved="false"></xref>, <xref href="UnderAutomation.ABB.Rws.Data.DeviceItem" data-throw-if-not-resolved="false"></xref></p>
	/// </summary>
	public abstract class FileSystemItem {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.FileSystemItem" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		protected FileSystemItem()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns the name of the item
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the item (file name, directory name, or device name such as "C:")
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Creation date of the resource, if available
		/// </summary>
		public DateTime? CreationDate { get; set; }

		/// <summary>
		/// Last modification date of the resource, if available
		/// </summary>
		public DateTime? ModificationDate { get; set; }
	}
}
