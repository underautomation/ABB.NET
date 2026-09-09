//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Safety mode of the safety controller
	/// 
	/// </summary>
	public sealed class SafetyMode : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The safety mode could not be determined
		/// 
		/// </summary>
		public const SafetyMode Unknown;

		/// <summary>
		/// 
		/// The safety configuration is active and supervised
		/// 
		/// </summary>
		public const SafetyMode Active;

		/// <summary>
		/// 
		/// Commissioning mode, used while configuring the safety controller
		/// 
		/// </summary>
		public const SafetyMode Commissioning;

		/// <summary>
		/// 
		/// Service mode
		/// 
		/// </summary>
		public const SafetyMode Service;

		/// <summary>
		/// 
		/// The safety controller reports a mode error
		/// 
		/// </summary>
		public const SafetyMode ModeError;
	}
}
