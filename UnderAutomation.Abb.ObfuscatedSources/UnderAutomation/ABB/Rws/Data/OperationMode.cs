//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Operating mode selected on the robot controller
	/// 
	/// </summary>
	public sealed class OperationMode : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The operating mode could not be determined
		/// 
		/// </summary>
		public const OperationMode Unknown;

		/// <summary>
		/// 
		/// The controller is initializing
		/// 
		/// </summary>
		public const OperationMode Init;

		/// <summary>
		/// 
		/// A change to the automatic mode has been requested and is waiting to be acknowledged
		/// 
		/// </summary>
		public const OperationMode AutomaticChangeRequest;

		/// <summary>
		/// 
		/// A change to the manual full speed mode has been requested and is waiting to be acknowledged
		/// 
		/// </summary>
		public const OperationMode ManualFullSpeedChangeRequest;

		/// <summary>
		/// 
		/// Manual mode at reduced speed
		/// 
		/// </summary>
		public const OperationMode ManualReducedSpeed;

		/// <summary>
		/// 
		/// Manual mode at full speed
		/// 
		/// </summary>
		public const OperationMode ManualFullSpeed;

		/// <summary>
		/// 
		/// Automatic mode
		/// 
		/// </summary>
		public const OperationMode Automatic;

		/// <summary>
		/// 
		/// The controller reports an undefined operating mode
		/// 
		/// </summary>
		public const OperationMode Undefined;
	}
}
