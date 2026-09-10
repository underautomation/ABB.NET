//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Size of the step a jogging command moves the robot by
	/// </summary>
	public enum JogIncrementMode {

		/// <summary>
		/// The robot moves for as long as the command is repeated, with no fixed step
		/// </summary>
		None = 0,

		/// <summary>
		/// One step of the size configured in the system parameters
		/// </summary>
		User = 1,

		/// <summary>
		/// One small step
		/// </summary>
		Small = 2,

		/// <summary>
		/// One medium step
		/// </summary>
		Medium = 3,

		/// <summary>
		/// One large step
		/// </summary>
		Large = 4,
	}
}
