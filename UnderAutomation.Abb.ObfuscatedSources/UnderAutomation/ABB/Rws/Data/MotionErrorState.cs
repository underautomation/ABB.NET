//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Last error the motion system ran into, most of them raised by a jogging request it could not honour
	/// 
	/// </summary>
	public sealed class MotionErrorState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported an error this library does not know
		/// 
		/// </summary>
		public const MotionErrorState Unknown;

		/// <summary>
		/// 
		/// No error
		/// 
		/// </summary>
		public const MotionErrorState Ok;

		/// <summary>
		/// 
		/// A mechanical unit was jogged whose activation failed
		/// 
		/// </summary>
		public const MotionErrorState MechanicalUnitNotActive;

		/// <summary>
		/// 
		/// An uncalibrated robot was jogged in a mode that needs its calibration
		/// 
		/// </summary>
		public const MotionErrorState UncalibratedJogMotionType;

		/// <summary>
		/// 
		/// A quaternion that is not normalized reached the jogging task, from a tool, a load or a work object
		/// 
		/// </summary>
		public const MotionErrorState UnnormalizedQuaternion;

		/// <summary>
		/// 
		/// A load definition carries a negative mass
		/// 
		/// </summary>
		public const MotionErrorState ErroneousToolMass;

		/// <summary>
		/// 
		/// The tool and the work object disagree on which one the robot holds
		/// 
		/// </summary>
		public const MotionErrorState RobotHoldMismatch;

		/// <summary>
		/// 
		/// A mechanical unit used in coordinated jogging was not found
		/// 
		/// </summary>
		public const MotionErrorState WorkObjectMechanicalUnitNotFound;

		/// <summary>
		/// 
		/// The requested jogging mode is not valid
		/// 
		/// </summary>
		public const MotionErrorState InvalidJogMotionType;
	}
}
