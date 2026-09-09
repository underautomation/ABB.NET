//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Whether an operator can push the robot arm around by hand
	/// 
	/// </summary>
	public sealed class LeadThroughStatus : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a state this library does not know
		/// 
		/// </summary>
		public const LeadThroughStatus Unknown;

		/// <summary>
		/// 
		/// The arm gives way when pushed
		/// 
		/// </summary>
		public const LeadThroughStatus Active;

		/// <summary>
		/// 
		/// The arm holds its position
		/// 
		/// </summary>
		public const LeadThroughStatus Inactive;
	}
}
