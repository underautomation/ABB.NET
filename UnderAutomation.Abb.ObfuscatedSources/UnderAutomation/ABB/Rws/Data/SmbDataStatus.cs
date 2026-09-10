//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// State of one block of serial measurement board data, on the controller side or on the robot side
	/// </summary>
	public enum SmbDataStatus {

		/// <summary>
		/// The controller reported a state this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The data is present and the two copies agree
		/// </summary>
		Valid = 1,

		/// <summary>
		/// The data is present on both sides, but the two copies differ
		/// </summary>
		ValidNotEqual = 2,

		/// <summary>
		/// The data is missing or unusable
		/// </summary>
		NotValid = 3,

		/// <summary>
		/// The robot system does not use this block of data
		/// </summary>
		NotUsed = 4,
	}
}
