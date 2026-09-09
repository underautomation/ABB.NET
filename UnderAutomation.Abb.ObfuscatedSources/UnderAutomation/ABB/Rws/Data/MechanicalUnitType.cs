//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Kind of mechanical unit the controller drives
	/// 
	/// </summary>
	public sealed class MechanicalUnitType : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a type this library does not know
		/// 
		/// </summary>
		public const MechanicalUnitType Unknown;

		/// <summary>
		/// 
		/// No mechanical unit
		/// 
		/// </summary>
		public const MechanicalUnitType None;

		/// <summary>
		/// 
		/// A robot arm holding a tool center point, which can be moved in cartesian coordinates
		/// 
		/// </summary>
		public const MechanicalUnitType TcpRobot;

		/// <summary>
		/// 
		/// A robot arm without a tool center point, which can only be moved axis by axis
		/// 
		/// </summary>
		public const MechanicalUnitType Robot;

		/// <summary>
		/// 
		/// A single external axis, such as a track or a positioner
		/// 
		/// </summary>
		public const MechanicalUnitType Single;

		/// <summary>
		/// 
		/// The controller knows the unit but does not report what it is
		/// 
		/// </summary>
		public const MechanicalUnitType Undefined;
	}
}
