//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Physical state of an I/O device
	/// 
	/// </summary>
	public sealed class IoDevicePhysicalState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The physical state could not be determined
		/// 
		/// </summary>
		public const IoDevicePhysicalState Unknown;

		/// <summary>
		/// 
		/// The device is deactivated
		/// 
		/// </summary>
		public const IoDevicePhysicalState Deactivated;

		/// <summary>
		/// 
		/// The device is running
		/// 
		/// </summary>
		public const IoDevicePhysicalState Running;

		/// <summary>
		/// 
		/// The device reports an error
		/// 
		/// </summary>
		public const IoDevicePhysicalState Error;

		/// <summary>
		/// 
		/// The device is not connected
		/// 
		/// </summary>
		public const IoDevicePhysicalState Unconnected;

		/// <summary>
		/// 
		/// The device is not configured
		/// 
		/// </summary>
		public const IoDevicePhysicalState Unconfigured;

		/// <summary>
		/// 
		/// The device is starting up
		/// 
		/// </summary>
		public const IoDevicePhysicalState Startup;

		/// <summary>
		/// 
		/// The device is initializing
		/// 
		/// </summary>
		public const IoDevicePhysicalState Init;

		/// <summary>
		/// 
		/// The device is halted
		/// 
		/// </summary>
		public const IoDevicePhysicalState Halted;
	}
}
