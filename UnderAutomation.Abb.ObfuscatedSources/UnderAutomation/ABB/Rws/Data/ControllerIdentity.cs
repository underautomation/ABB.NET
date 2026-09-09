//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Identity of the robot controller.
	/// <p>Returned by <code>ControllerService.GetIdentity()</code>.</p>
	/// 
	/// </summary>
	public class ControllerIdentity : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.ControllerIdentity" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public ControllerIdentity()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this controller identity
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Name of the controller
		/// 
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 
		/// Controller id, available only for a real controller
		/// 
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// 
		/// Indicates whether the controller is a real or a virtual controller
		/// 
		/// </summary>
		public ControllerType Type { get; set; }

		/// <summary>
		/// 
		/// MAC address of the controller, available only for a real controller
		/// 
		/// </summary>
		public string MacAddress { get; set; }

		/// <summary>
		/// 
		/// Indicates whether the controller runs at system level or in bootserver mode
		/// 
		/// </summary>
		public ControllerLevel Level { get; set; }
	}
}
