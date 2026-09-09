//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Which of the two copies of the serial measurement board data is erased
	/// 
	/// </summary>
	public sealed class SmbDataMemory : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The copy held by the robot itself
		/// 
		/// </summary>
		public const SmbDataMemory Robot;

		/// <summary>
		/// 
		/// The copy held by the controller cabinet
		/// 
		/// </summary>
		public const SmbDataMemory Controller;
	}
}
