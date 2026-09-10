//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Safety mode of the safety controller
	/// </summary>
	public enum SafetyMode {

		/// <summary>
		/// The safety mode could not be determined
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The safety configuration is active and supervised
		/// </summary>
		Active = 1,

		/// <summary>
		/// Commissioning mode, used while configuring the safety controller
		/// </summary>
		Commissioning = 2,

		/// <summary>
		/// Service mode
		/// </summary>
		Service = 3,

		/// <summary>
		/// The safety controller reports a mode error
		/// </summary>
		ModeError = 4,
	}
}
