//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Calibration and synchronization state of a mechanical unit or of one of its axes
	/// </summary>
	public enum MechanicalUnitStatus {

		/// <summary>
		/// The controller reported a state this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The unit is starting up
		/// </summary>
		Initiated = 1,

		/// <summary>
		/// One or several motors have not been commutated
		/// </summary>
		NotCommutated = 2,

		/// <summary>
		/// The unit has never been calibrated
		/// </summary>
		NotCalibrated = 3,

		/// <summary>
		/// One or several absolute measurement axes are not synchronized
		/// </summary>
		NotAbsoluteSynchronized = 4,

		/// <summary>
		/// One or several relative measurement axes are not synchronized
		/// </summary>
		NotRelativeSynchronized = 5,

		/// <summary>
		/// The unit is calibrated and synchronized, and can be moved
		/// </summary>
		Synchronized = 6,

		/// <summary>
		/// The unit is locked and refuses to move
		/// </summary>
		Locked = 7,

		/// <summary>
		/// The unit is locked, and the controller shows it as such
		/// </summary>
		LockedShow = 8,

		/// <summary>
		/// The controller knows the unit but does not report its state
		/// </summary>
		Undefined = 9,
	}
}
