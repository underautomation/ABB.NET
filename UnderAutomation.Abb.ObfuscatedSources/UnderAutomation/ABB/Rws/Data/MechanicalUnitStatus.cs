//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Calibration and synchronization state of a mechanical unit or of one of its axes
	/// 
	/// </summary>
	public sealed class MechanicalUnitStatus : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a state this library does not know
		/// 
		/// </summary>
		public const MechanicalUnitStatus Unknown;

		/// <summary>
		/// 
		/// The unit is starting up
		/// 
		/// </summary>
		public const MechanicalUnitStatus Initiated;

		/// <summary>
		/// 
		/// One or several motors have not been commutated
		/// 
		/// </summary>
		public const MechanicalUnitStatus NotCommutated;

		/// <summary>
		/// 
		/// The unit has never been calibrated
		/// 
		/// </summary>
		public const MechanicalUnitStatus NotCalibrated;

		/// <summary>
		/// 
		/// One or several absolute measurement axes are not synchronized
		/// 
		/// </summary>
		public const MechanicalUnitStatus NotAbsoluteSynchronized;

		/// <summary>
		/// 
		/// One or several relative measurement axes are not synchronized
		/// 
		/// </summary>
		public const MechanicalUnitStatus NotRelativeSynchronized;

		/// <summary>
		/// 
		/// The unit is calibrated and synchronized, and can be moved
		/// 
		/// </summary>
		public const MechanicalUnitStatus Synchronized;

		/// <summary>
		/// 
		/// The unit is locked and refuses to move
		/// 
		/// </summary>
		public const MechanicalUnitStatus Locked;

		/// <summary>
		/// 
		/// The unit is locked, and the controller shows it as such
		/// 
		/// </summary>
		public const MechanicalUnitStatus LockedShow;

		/// <summary>
		/// 
		/// The controller knows the unit but does not report its state
		/// 
		/// </summary>
		public const MechanicalUnitStatus Undefined;
	}
}
