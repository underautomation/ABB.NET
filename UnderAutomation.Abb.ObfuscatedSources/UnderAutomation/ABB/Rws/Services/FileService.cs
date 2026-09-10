//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.ABB.Rws.Data;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System;

namespace UnderAutomation.ABB.Rws.Services {
	/// <summary>
	/// File Service - Provides access to the robot controller file system
	/// 
	/// <p>Compatibility:</p>
	/// <ul><li>Version 1: directory operations with basic functionality</li><li>Version 2: extended file operations</li></ul>
	/// </summary>
	public class FileService {

		/// <summary>
		/// Lists contents of a directory resource (synchronous)
		/// 
		/// <p>Environment variables (e.g. $home, $temp) and devices are treated as directories.</p>
		/// <p>When listing the root path ("/", null, or "\\"), the response includes available devices in <xref href="UnderAutomation.ABB.Rws.Data.DirectoryListing.Devices" data-throw-if-not-resolved="false"></xref>.</p>
		/// <p>The complete content is always returned, however many entries the directory holds.</p>
		/// </summary>
		/// <param name="path">Path to the directory (e.g. "$home", "$home/mydir", "hd0a:/data"), or null/"/"/"\\" for root</param>
		/// <returns>Directory listing containing files, subdirectories, and devices</returns>
		public DirectoryListing ListDirectory(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Lists contents of a directory resource (asynchronous)
		/// 
		/// <p>Environment variables (e.g. $home, $temp) and devices are treated as directories.</p>
		/// <p>When listing the root path ("/", null, or "\\"), the response includes available devices in <xref href="UnderAutomation.ABB.Rws.Data.DirectoryListing.Devices" data-throw-if-not-resolved="false"></xref>.</p>
		/// <p>The complete content is always returned, however many entries the directory holds.</p>
		/// </summary>
		/// <param name="path">Path to the directory (e.g. "$home", "$home/mydir", "hd0a:/data"), or null/"/"/"\\" for root</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Directory listing containing files, subdirectories, and devices</returns>
		public Task<DirectoryListing> ListDirectoryAsync(string path, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Deletes a directory and all its subdirectories and files (synchronous)
		/// </summary>
		/// <param name="path">Path to the directory to delete (e.g. "$home/testdir")</param>
		public void DeleteDirectory(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Deletes a directory and all its subdirectories and files (asynchronous)
		/// </summary>
		/// <param name="path">Path to the directory to delete (e.g. "$home/testdir")</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task DeleteDirectoryAsync(string path, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates a new directory (synchronous)
		/// 
		/// <p>The newName parameter can contain nested directory structure (e.g. "parentdir/subdir")</p>
		/// <p>which will create both directories if they don't exist.</p>
		/// </summary>
		/// <param name="path">Parent directory path (e.g. "$home", "$home/existing")</param>
		/// <param name="newName">Name of the new directory (can be nested: "dir1/dir2")</param>
		public void CreateDirectory(string path, string newName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a new directory (asynchronous)
		/// 
		/// <p>The newName parameter can contain nested directory structure (e.g. "parentdir/subdir")</p>
		/// <p>which will create both directories if they don't exist.</p>
		/// </summary>
		/// <param name="path">Parent directory path (e.g. "$home", "$home/existing")</param>
		/// <param name="newName">Name of the new directory (can be nested: "dir1/dir2")</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task CreateDirectoryAsync(string path, string newName, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Renames a directory (synchronous)
		/// </summary>
		/// <param name="path">Path to the directory to rename (e.g. "$home/dir1")</param>
		/// <param name="newName">New directory name (relative or absolute depending on controller behavior)</param>
		public void RenameDirectory(string path, string newName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Renames a directory (asynchronous)
		/// </summary>
		/// <param name="path">Path to the directory to rename (e.g. "$home/dir1")</param>
		/// <param name="newName">New directory name (relative or absolute depending on controller behavior)</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task RenameDirectoryAsync(string path, string newName, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Copies a directory (synchronous)
		/// </summary>
		/// <param name="path">Path to the directory to copy (e.g. "$home/dir1")</param>
		/// <param name="newName">New directory name (relative or absolute)</param>
		/// <param name="overwrite">Whether to overwrite if target exists</param>
		public void CopyDirectory(string path, string newName, bool overwrite)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Copies a directory (asynchronous)
		/// </summary>
		/// <param name="path">Path to the directory to copy (e.g. "$home/dir1")</param>
		/// <param name="newName">New directory name (relative or absolute)</param>
		/// <param name="overwrite">Whether to overwrite if target exists</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task CopyDirectoryAsync(string path, string newName, bool overwrite, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Deletes a file (synchronous)
		/// </summary>
		/// <param name="path">Path to the file to delete (e.g. "$home/file.txt")</param>
		public void DeleteFile(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Deletes a file (asynchronous)
		/// </summary>
		/// <param name="path">Path to the file to delete (e.g. "$home/file.txt")</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task DeleteFileAsync(string path, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Renames a file (synchronous)
		/// </summary>
		/// <param name="path">Path to the file to rename (e.g. "$home/file.txt")</param>
		/// <param name="newName">New file name</param>
		public void RenameFile(string path, string newName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Renames a file (asynchronous)
		/// </summary>
		/// <param name="path">Path to the file to rename (e.g. "$home/file.txt")</param>
		/// <param name="newName">New file name</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task RenameFileAsync(string path, string newName, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Copies a file (synchronous)
		/// </summary>
		/// <param name="path">Path to the file to copy (e.g. "$home/file.txt")</param>
		/// <param name="newName">New file name (relative or absolute)</param>
		/// <param name="overwrite">Whether to overwrite if target exists</param>
		public void CopyFile(string path, string newName, bool overwrite)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Copies a file (asynchronous)
		/// </summary>
		/// <param name="path">Path to the file to copy (e.g. "$home/file.txt")</param>
		/// <param name="newName">New file name (relative or absolute)</param>
		/// <param name="overwrite">Whether to overwrite if target exists</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task CopyFileAsync(string path, string newName, bool overwrite, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets file content as raw bytes (synchronous)
		/// </summary>
		/// <param name="path">Path to the file (e.g. "$home/file.txt")</param>
		/// <returns>File content as byte array</returns>
		public byte[] GetFileAsBytes(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets file content as a read-only stream (synchronous)
		/// 
		/// <p>For sync: Returns a read-only MemoryStream (buffered for .NET 3.5/4.0 compatibility)</p>
		/// <p>For true HTTP streaming with large files, use GetFileAsReadonlyStreamAsync() instead</p>
		/// </summary>
		/// <param name="path">Path to the file (e.g. "$home/file.txt")</param>
		/// <returns>File content as a readable stream</returns>
		public Stream GetFileAsReadonlyStream(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets file content as text (synchronous)
		/// </summary>
		/// <param name="path">Path to the file (e.g. "$home/file.txt")</param>
		/// <param name="encoding">Text encoding (UTF-8 if null)</param>
		/// <returns>File content as string</returns>
		public string GetFileAsText(string path, Encoding encoding = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads a file to a local path (synchronous)
		/// </summary>
		/// <param name="path">Path to the file (e.g. "$home/file.txt")</param>
		/// <param name="localPath">Local file path to write</param>
		public void GetFileToDestination(string path, string localPath)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets file content as raw bytes (asynchronous)
		/// </summary>
		/// <param name="path">Path to the file (e.g. "$home/file.txt")</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>File content as byte array</returns>
		public Task<byte[]> GetFileAsBytesAsync(string path, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets file content as a read-only stream (asynchronous)
		/// 
		/// <p>Returns true HTTP stream without buffering - ideal for large files</p>
		/// </summary>
		/// <param name="path">Path to the file (e.g. "$home/file.txt")</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>File content as a readable stream</returns>
		public Task<Stream> GetFileAsReadonlyStreamAsync(string path, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets file content as text (asynchronous)
		/// </summary>
		/// <param name="path">Path to the file (e.g. "$home/file.txt")</param>
		/// <param name="encoding">Text encoding (UTF-8 if null)</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>File content as string</returns>
		public Task<string> GetFileAsTextAsync(string path, Encoding encoding = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads a file to a local path (asynchronous)
		/// </summary>
		/// <param name="path">Path to the file (e.g. "$home/file.txt")</param>
		/// <param name="localPath">Local file path to write</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task GetFileToDestinationAsync(string path, string localPath, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads a file from raw bytes (synchronous)
		/// </summary>
		/// <param name="path">Path to the file (e.g. "$home/file.txt")</param>
		/// <param name="content">Raw file content</param>
		/// <param name="contentType">Content type (default: application/octet-stream)</param>
		public void UploadFileFromBytes(string path, byte[] content, string contentType = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Uploads a file from a stream (synchronous)
		/// </summary>
		/// <param name="path">Path to the file (e.g. "$home/file.txt")</param>
		/// <param name="contentStream">Stream containing the file content</param>
		/// <param name="contentType">Content type (default: application/octet-stream)</param>
		public void UploadFileFromStream(string path, Stream contentStream, string contentType = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Uploads a file from text (synchronous)
		/// </summary>
		/// <param name="path">Path to the file (e.g. "$home/file.txt")</param>
		/// <param name="content">Text content</param>
		/// <param name="encoding">Text encoding (UTF-8 if null)</param>
		public void UploadFileFromText(string path, string content, Encoding encoding = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Uploads a local file to the controller (synchronous)
		/// </summary>
		/// <param name="path">Target file path on controller (e.g. "$home/file.txt")</param>
		/// <param name="localPath">Local file path to upload</param>
		/// <param name="contentType">Content type (default: application/octet-stream)</param>
		public void UploadFileFromPath(string path, string localPath, string contentType = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Uploads a file from raw bytes (asynchronous)
		/// </summary>
		/// <param name="path">Path to the file (e.g. "$home/file.txt")</param>
		/// <param name="content">Raw file content</param>
		/// <param name="contentType">Content type (default: application/octet-stream)</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task UploadFileFromBytesAsync(string path, byte[] content, string contentType = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads a file from a stream (asynchronous)
		/// </summary>
		/// <param name="path">Path to the file (e.g. "$home/file.txt")</param>
		/// <param name="contentStream">Stream containing the file content</param>
		/// <param name="contentType">Content type (default: application/octet-stream)</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task UploadFileFromStreamAsync(string path, Stream contentStream, string contentType = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads a file from text (asynchronous)
		/// </summary>
		/// <param name="path">Path to the file (e.g. "$home/file.txt")</param>
		/// <param name="content">Text content</param>
		/// <param name="encoding">Text encoding (UTF-8 if null)</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task UploadFileFromTextAsync(string path, string content, Encoding encoding = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads a local file to the controller (asynchronous)
		/// </summary>
		/// <param name="path">Target file path on controller (e.g. "$home/file.txt")</param>
		/// <param name="localPath">Local file path to upload</param>
		/// <param name="contentType">Content type (default: application/octet-stream)</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task UploadFileFromPathAsync(string path, string localPath, string contentType = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
