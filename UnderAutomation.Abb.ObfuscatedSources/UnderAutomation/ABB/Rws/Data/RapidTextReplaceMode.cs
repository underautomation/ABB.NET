//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Where new text is put relative to the range it is written against
	/// 
	/// </summary>
	public sealed class RapidTextReplaceMode : Enum {


		public int value__;

		/// <summary>
		/// 
		/// Insert the new text after the range, leaving it in place
		/// 
		/// </summary>
		public const RapidTextReplaceMode After;

		/// <summary>
		/// 
		/// Insert the new text before the range, leaving it in place
		/// 
		/// </summary>
		public const RapidTextReplaceMode Before;

		/// <summary>
		/// 
		/// Replace the range with the new text
		/// 
		/// </summary>
		public const RapidTextReplaceMode Replace;
	}
}
