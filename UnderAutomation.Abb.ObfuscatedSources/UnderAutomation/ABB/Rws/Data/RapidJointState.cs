//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// What an external joint of a task is doing
	/// 
	/// </summary>
	public sealed class RapidJointState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a state this library does not know
		/// 
		/// </summary>
		public const RapidJointState Unknown;

		/// <summary>
		/// 
		/// The joint moves along a line
		/// 
		/// </summary>
		public const RapidJointState Linear;

		/// <summary>
		/// 
		/// The joint turns
		/// 
		/// </summary>
		public const RapidJointState Rotating;

		/// <summary>
		/// 
		/// The joint is not active
		/// 
		/// </summary>
		public const RapidJointState NotActive;

		/// <summary>
		/// 
		/// The joint is active but has no position
		/// 
		/// </summary>
		public const RapidJointState NoPosition;
	}
}
