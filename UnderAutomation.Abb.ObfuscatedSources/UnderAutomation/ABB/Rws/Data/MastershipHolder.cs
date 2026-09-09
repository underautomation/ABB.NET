//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Who holds the mastership of a domain
	/// 
	/// </summary>
	public sealed class MastershipHolder : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a holder this library does not know
		/// 
		/// </summary>
		public const MastershipHolder Unknown;

		/// <summary>
		/// 
		/// Nobody holds the mastership, it is free to be taken
		/// 
		/// </summary>
		public const MastershipHolder None;

		/// <summary>
		/// 
		/// A client connected over the network holds it, possibly this one
		/// 
		/// </summary>
		public const MastershipHolder Remote;

		/// <summary>
		/// 
		/// A device attached to the controller holds it, the teach pendant for instance
		/// 
		/// </summary>
		public const MastershipHolder Local;

		/// <summary>
		/// 
		/// The controller itself holds it, while it runs an operation that must not be interrupted
		/// 
		/// </summary>
		public const MastershipHolder Internal;
	}
}
