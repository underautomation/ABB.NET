//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Who holds the mastership of a domain
	/// </summary>
	public enum MastershipHolder {

		/// <summary>
		/// The controller reported a holder this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Nobody holds the mastership, it is free to be taken
		/// </summary>
		None = 1,

		/// <summary>
		/// A client connected over the network holds it, possibly this one
		/// </summary>
		Remote = 2,

		/// <summary>
		/// A device attached to the controller holds it, the teach pendant for instance
		/// </summary>
		Local = 3,

		/// <summary>
		/// The controller itself holds it, while it runs an operation that must not be interrupted
		/// </summary>
		Internal = 4,
	}
}
