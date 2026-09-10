//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// What a RAPID symbol is: a value, a routine, a type or one of the structural elements of the language
	/// </summary>
	public enum RapidSymbolType {

		/// <summary>
		/// The controller reported a type this library does not know
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The type is not defined
		/// </summary>
		Undefined = 1,

		/// <summary>
		/// A built-in type such as num or string
		/// </summary>
		Atomic = 2,

		/// <summary>
		/// A record type
		/// </summary>
		Record = 3,

		/// <summary>
		/// An alias of another type
		/// </summary>
		Alias = 4,

		/// <summary>
		/// One component of a record
		/// </summary>
		RecordComponent = 5,

		/// <summary>
		/// A constant
		/// </summary>
		Constant = 6,

		/// <summary>
		/// A variable
		/// </summary>
		Variable = 7,

		/// <summary>
		/// A persistent variable, whose value survives a restart
		/// </summary>
		Persistent = 8,

		/// <summary>
		/// A parameter of a routine
		/// </summary>
		Parameter = 9,

		/// <summary>
		/// A label
		/// </summary>
		Label = 10,

		/// <summary>
		/// The loop variable of a FOR statement
		/// </summary>
		ForVariable = 11,

		/// <summary>
		/// A function
		/// </summary>
		Function = 12,

		/// <summary>
		/// A procedure
		/// </summary>
		Procedure = 13,

		/// <summary>
		/// A trap routine
		/// </summary>
		Trap = 14,

		/// <summary>
		/// A module
		/// </summary>
		Module = 15,

		/// <summary>
		/// A task
		/// </summary>
		Task = 16,

		/// <summary>
		/// Any of the other types, which a search uses to mean that it does not filter on the type
		/// </summary>
		Any = 17,
	}
}
