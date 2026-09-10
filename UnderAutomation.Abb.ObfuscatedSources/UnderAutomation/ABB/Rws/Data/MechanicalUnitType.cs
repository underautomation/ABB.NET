//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Kind of mechanical unit the controller drives
	/// </summary>
	public enum MechanicalUnitType {

		/// <summary>
		/// The controller reported a type this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// No mechanical unit
		/// </summary>
		None = 1,

		/// <summary>
		/// A robot arm holding a tool center point, which can be moved in cartesian coordinates
		/// </summary>
		TcpRobot = 2,

		/// <summary>
		/// A robot arm without a tool center point, which can only be moved axis by axis
		/// </summary>
		Robot = 3,

		/// <summary>
		/// A single external axis, such as a track or a positioner
		/// </summary>
		Single = 4,

		/// <summary>
		/// The controller knows the unit but does not report what it is
		/// </summary>
		Undefined = 5,
	}
}
