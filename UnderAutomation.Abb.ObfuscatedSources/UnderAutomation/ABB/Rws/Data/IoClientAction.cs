//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Action the client is expected to take after an I/O network auto configuration,
	/// returned by <code>IoService.SetNetworkConfigurationType()</code>.
	/// <p>Only available when connected with version 2.</p>
	/// 
	/// </summary>
	public sealed class IoClientAction : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller did not report any client action.
		/// <p>Always returned when connected with version 1, which does not report this information.</p>
		/// 
		/// </summary>
		public const IoClientAction Unknown;

		/// <summary>
		/// 
		/// Nothing to do
		/// 
		/// </summary>
		public const IoClientAction None;

		/// <summary>
		/// 
		/// The user should be informed of the configuration result
		/// 
		/// </summary>
		public const IoClientAction Info;

		/// <summary>
		/// 
		/// The controller has to be restarted for the configuration to take effect
		/// 
		/// </summary>
		public const IoClientAction Restart;
	}
}
