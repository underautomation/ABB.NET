//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// How the jogging commands sent to a mechanical unit are interpreted
	/// </summary>
	public enum JogMode {

		/// <summary>
		/// The controller reported a mode this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Each command moves one axis of the first axis group
		/// </summary>
		AxisGroup1 = 1,

		/// <summary>
		/// Each command moves one axis of the second axis group
		/// </summary>
		AxisGroup2 = 2,

		/// <summary>
		/// The tool is moved along the axes of the active coordinate system
		/// </summary>
		Cartesian = 3,

		/// <summary>
		/// The tool is aligned with the closest axis of the active coordinate system
		/// </summary>
		Align = 4,

		/// <summary>
		/// The robot moves to a given position
		/// </summary>
		GoToPosition = 5,

		/// <summary>
		/// The robot changes axis configuration without moving the tool center point
		/// </summary>
		ConfigurationJog = 6,
	}
}
