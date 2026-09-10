//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Which of the two copies of the serial measurement board data is erased
	/// </summary>
	public enum SmbDataMemory {

		/// <summary>
		/// The copy held by the robot itself
		/// </summary>
		Robot = 0,

		/// <summary>
		/// The copy held by the controller cabinet
		/// </summary>
		Controller = 1,
	}
}
