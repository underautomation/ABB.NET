//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// State of one block of serial measurement board data, on the controller side or on the robot side
	/// 
	/// </summary>
	public sealed class SmbDataStatus : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a state this library does not know
		/// 
		/// </summary>
		public const SmbDataStatus Unknown;

		/// <summary>
		/// 
		/// The data is present and the two copies agree
		/// 
		/// </summary>
		public const SmbDataStatus Valid;

		/// <summary>
		/// 
		/// The data is present on both sides, but the two copies differ
		/// 
		/// </summary>
		public const SmbDataStatus ValidNotEqual;

		/// <summary>
		/// 
		/// The data is missing or unusable
		/// 
		/// </summary>
		public const SmbDataStatus NotValid;

		/// <summary>
		/// 
		/// The robot system does not use this block of data
		/// 
		/// </summary>
		public const SmbDataStatus NotUsed;
	}
}
