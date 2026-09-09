//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws {
	/// <summary>
	/// 
	/// Version of the ABB Robot Web Services (RWS) protocol exposed by the robot controller.
	/// <p>The two versions differ in URL shapes, parameter placement and media types, so the client
	/// has to know which one it talks to. Pick the value that matches the controller generation.</p>
	/// 
	/// </summary>
	public sealed class RwsVersion : Enum {


		public int value__;

		/// <summary>
		/// 
		/// RWS 1.0, exposed by IRC5 controllers running RobotWare 6 and earlier.
		/// 
		/// </summary>
		public const RwsVersion Irc5_V1_0;

		/// <summary>
		/// 
		/// RWS 2.0, exposed by OmniCore controllers running RobotWare 7 and later.
		/// This is the default when no version is specified.
		/// 
		/// </summary>
		public const RwsVersion OmniCore_V2_0;
	}
}
