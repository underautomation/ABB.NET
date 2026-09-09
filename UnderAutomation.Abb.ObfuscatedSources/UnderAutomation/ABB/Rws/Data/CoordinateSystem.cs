//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Reference frame a cartesian position is expressed in
	/// 
	/// </summary>
	public sealed class CoordinateSystem : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a frame this library does not know
		/// 
		/// </summary>
		public const CoordinateSystem Unknown;

		/// <summary>
		/// 
		/// The world frame, shared by every mechanical unit of the system
		/// 
		/// </summary>
		public const CoordinateSystem World;

		/// <summary>
		/// 
		/// The base frame of the mechanical unit
		/// 
		/// </summary>
		public const CoordinateSystem Base;

		/// <summary>
		/// 
		/// The frame of the active tool
		/// 
		/// </summary>
		public const CoordinateSystem Tool;

		/// <summary>
		/// 
		/// The frame of the active work object
		/// 
		/// </summary>
		public const CoordinateSystem WorkObject;
	}
}
