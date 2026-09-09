//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// What a RAPID symbol is: a value, a routine, a type or one of the structural elements of the language
	/// 
	/// </summary>
	public sealed class RapidSymbolType : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The controller reported a type this library does not know
		/// 
		/// </summary>
		public const RapidSymbolType Unknown;

		/// <summary>
		/// 
		/// The type is not defined
		/// 
		/// </summary>
		public const RapidSymbolType Undefined;

		/// <summary>
		/// 
		/// A built-in type such as num or string
		/// 
		/// </summary>
		public const RapidSymbolType Atomic;

		/// <summary>
		/// 
		/// A record type
		/// 
		/// </summary>
		public const RapidSymbolType Record;

		/// <summary>
		/// 
		/// An alias of another type
		/// 
		/// </summary>
		public const RapidSymbolType Alias;

		/// <summary>
		/// 
		/// One component of a record
		/// 
		/// </summary>
		public const RapidSymbolType RecordComponent;

		/// <summary>
		/// 
		/// A constant
		/// 
		/// </summary>
		public const RapidSymbolType Constant;

		/// <summary>
		/// 
		/// A variable
		/// 
		/// </summary>
		public const RapidSymbolType Variable;

		/// <summary>
		/// 
		/// A persistent variable, whose value survives a restart
		/// 
		/// </summary>
		public const RapidSymbolType Persistent;

		/// <summary>
		/// 
		/// A parameter of a routine
		/// 
		/// </summary>
		public const RapidSymbolType Parameter;

		/// <summary>
		/// 
		/// A label
		/// 
		/// </summary>
		public const RapidSymbolType Label;

		/// <summary>
		/// 
		/// The loop variable of a FOR statement
		/// 
		/// </summary>
		public const RapidSymbolType ForVariable;

		/// <summary>
		/// 
		/// A function
		/// 
		/// </summary>
		public const RapidSymbolType Function;

		/// <summary>
		/// 
		/// A procedure
		/// 
		/// </summary>
		public const RapidSymbolType Procedure;

		/// <summary>
		/// 
		/// A trap routine
		/// 
		/// </summary>
		public const RapidSymbolType Trap;

		/// <summary>
		/// 
		/// A module
		/// 
		/// </summary>
		public const RapidSymbolType Module;

		/// <summary>
		/// 
		/// A task
		/// 
		/// </summary>
		public const RapidSymbolType Task;

		/// <summary>
		/// 
		/// Any of the other types, which a search uses to mean that it does not filter on the type
		/// 
		/// </summary>
		public const RapidSymbolType Any;
	}
}
