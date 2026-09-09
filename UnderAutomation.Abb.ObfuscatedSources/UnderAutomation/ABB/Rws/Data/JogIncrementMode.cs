//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Size of the step a jogging command moves the robot by
	/// 
	/// </summary>
	public sealed class JogIncrementMode : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The robot moves for as long as the command is repeated, with no fixed step
		/// 
		/// </summary>
		public const JogIncrementMode None;

		/// <summary>
		/// 
		/// One step of the size configured in the system parameters
		/// 
		/// </summary>
		public const JogIncrementMode User;

		/// <summary>
		/// 
		/// One small step
		/// 
		/// </summary>
		public const JogIncrementMode Small;

		/// <summary>
		/// 
		/// One medium step
		/// 
		/// </summary>
		public const JogIncrementMode Medium;

		/// <summary>
		/// 
		/// One large step
		/// 
		/// </summary>
		public const JogIncrementMode Large;
	}
}
