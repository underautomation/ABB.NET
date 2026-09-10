//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Whether an operator can push the robot arm around by hand
	/// </summary>
	public enum LeadThroughStatus {

		/// <summary>
		/// The controller reported a state this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The arm gives way when pushed
		/// </summary>
		Active = 1,

		/// <summary>
		/// The arm holds its position
		/// </summary>
		Inactive = 2,
	}
}
