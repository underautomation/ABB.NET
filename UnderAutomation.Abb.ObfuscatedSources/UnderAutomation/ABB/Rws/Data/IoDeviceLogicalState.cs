//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Logical state of an I/O device
	/// 
	/// </summary>
	public sealed class IoDeviceLogicalState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The logical state could not be determined
		/// 
		/// </summary>
		public const IoDeviceLogicalState Unknown;

		/// <summary>
		/// 
		/// The device is enabled
		/// 
		/// </summary>
		public const IoDeviceLogicalState Enabled;

		/// <summary>
		/// 
		/// The device is disabled
		/// 
		/// </summary>
		public const IoDeviceLogicalState Disabled;
	}
}
