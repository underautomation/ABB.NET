//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Last error the motion system ran into, most of them raised by a jogging request it could not honour
	/// </summary>
	public enum MotionErrorState {

		/// <summary>
		/// The controller reported an error this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// No error
		/// </summary>
		Ok = 1,

		/// <summary>
		/// A mechanical unit was jogged whose activation failed
		/// </summary>
		MechanicalUnitNotActive = 2,

		/// <summary>
		/// An uncalibrated robot was jogged in a mode that needs its calibration
		/// </summary>
		UncalibratedJogMotionType = 3,

		/// <summary>
		/// A quaternion that is not normalized reached the jogging task, from a tool, a load or a work object
		/// </summary>
		UnnormalizedQuaternion = 4,

		/// <summary>
		/// A load definition carries a negative mass
		/// </summary>
		ErroneousToolMass = 5,

		/// <summary>
		/// The tool and the work object disagree on which one the robot holds
		/// </summary>
		RobotHoldMismatch = 6,

		/// <summary>
		/// A mechanical unit used in coordinated jogging was not found
		/// </summary>
		WorkObjectMechanicalUnitNotFound = 7,

		/// <summary>
		/// The requested jogging mode is not valid
		/// </summary>
		InvalidJogMotionType = 8,
	}
}
