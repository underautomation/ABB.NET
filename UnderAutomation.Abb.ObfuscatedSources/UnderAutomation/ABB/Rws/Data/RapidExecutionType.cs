//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// What kind of code a task is currently running
	/// </summary>
	public enum RapidExecutionType {

		/// <summary>
		/// The controller reported a type this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Nothing is running
		/// </summary>
		None = 1,

		/// <summary>
		/// The normal program is running
		/// </summary>
		Normal = 2,

		/// <summary>
		/// An interrupt is running
		/// </summary>
		Interrupt = 3,

		/// <summary>
		/// An external interrupt is running
		/// </summary>
		ExternalInterrupt = 4,

		/// <summary>
		/// A user routine is running
		/// </summary>
		UserRoutine = 5,

		/// <summary>
		/// An event routine is running
		/// </summary>
		EventRoutine = 6,
	}
}
