//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Where new text is put relative to the range it is written against
	/// </summary>
	public enum RapidTextReplaceMode {

		/// <summary>
		/// Insert the new text after the range, leaving it in place
		/// </summary>
		After = 0,

		/// <summary>
		/// Insert the new text before the range, leaving it in place
		/// </summary>
		Before = 1,

		/// <summary>
		/// Replace the range with the new text
		/// </summary>
		Replace = 2,
	}
}
