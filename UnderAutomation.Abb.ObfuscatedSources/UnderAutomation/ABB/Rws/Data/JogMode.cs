//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// How the jogging commands sent to a mechanical unit are interpreted
	/// 
	/// </summary>
	public sealed class JogMode : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a mode this library does not know
		/// 
		/// </summary>
		public const JogMode Unknown;

		/// <summary>
		/// 
		/// Each command moves one axis of the first axis group
		/// 
		/// </summary>
		public const JogMode AxisGroup1;

		/// <summary>
		/// 
		/// Each command moves one axis of the second axis group
		/// 
		/// </summary>
		public const JogMode AxisGroup2;

		/// <summary>
		/// 
		/// The tool is moved along the axes of the active coordinate system
		/// 
		/// </summary>
		public const JogMode Cartesian;

		/// <summary>
		/// 
		/// The tool is aligned with the closest axis of the active coordinate system
		/// 
		/// </summary>
		public const JogMode Align;

		/// <summary>
		/// 
		/// The robot moves to a given position
		/// 
		/// </summary>
		public const JogMode GoToPosition;

		/// <summary>
		/// 
		/// The robot changes axis configuration without moving the tool center point
		/// 
		/// </summary>
		public const JogMode ConfigurationJog;
	}
}
