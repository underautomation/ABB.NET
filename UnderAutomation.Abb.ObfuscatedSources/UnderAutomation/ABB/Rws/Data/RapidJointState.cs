//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// What an external joint of a task is doing
	/// </summary>
	public enum RapidJointState {

		/// <summary>
		/// The controller reported a state this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The joint moves along a line
		/// </summary>
		Linear = 1,

		/// <summary>
		/// The joint turns
		/// </summary>
		Rotating = 2,

		/// <summary>
		/// The joint is not active
		/// </summary>
		NotActive = 3,

		/// <summary>
		/// The joint is active but has no position
		/// </summary>
		NoPosition = 4,
	}
}
