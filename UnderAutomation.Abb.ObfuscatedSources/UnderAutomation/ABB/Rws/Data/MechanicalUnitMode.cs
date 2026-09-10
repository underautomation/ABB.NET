//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Whether a mechanical unit is activated and can be moved
	/// </summary>
	public enum MechanicalUnitMode {

		/// <summary>
		/// The controller reported a mode this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The mechanical unit is activated and takes part in the motion
		/// </summary>
		Activated = 1,

		/// <summary>
		/// The mechanical unit is deactivated and stays where it is
		/// </summary>
		Deactivated = 2,
	}
}
