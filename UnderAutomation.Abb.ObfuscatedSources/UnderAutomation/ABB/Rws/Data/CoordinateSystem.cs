//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Reference frame a cartesian position is expressed in
	/// </summary>
	public enum CoordinateSystem {

		/// <summary>
		/// The controller reported a frame this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The world frame, shared by every mechanical unit of the system
		/// </summary>
		World = 1,

		/// <summary>
		/// The base frame of the mechanical unit
		/// </summary>
		Base = 2,

		/// <summary>
		/// The frame of the active tool
		/// </summary>
		Tool = 3,

		/// <summary>
		/// The frame of the active work object
		/// </summary>
		WorkObject = 4,
	}
}
