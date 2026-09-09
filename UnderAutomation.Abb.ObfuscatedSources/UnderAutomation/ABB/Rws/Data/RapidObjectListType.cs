//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Which of the lists a RAPID object holds is being asked about
	/// 
	/// </summary>
	public sealed class RapidObjectListType : Enum {


		public int value__;

		/// <summary>
		/// 
		/// The statements of the object
		/// 
		/// </summary>
		public const RapidObjectListType Statements;

		/// <summary>
		/// 
		/// The statements of its BACKWARD handler
		/// 
		/// </summary>
		public const RapidObjectListType BackwardStatements;

		/// <summary>
		/// 
		/// The statements of its ERROR handler
		/// 
		/// </summary>
		public const RapidObjectListType ErrorStatements;

		/// <summary>
		/// 
		/// The statements of its UNDO handler
		/// 
		/// </summary>
		public const RapidObjectListType UndoStatements;

		/// <summary>
		/// 
		/// The type declarations it holds
		/// 
		/// </summary>
		public const RapidObjectListType TypeDeclarations;

		/// <summary>
		/// 
		/// The data declarations it holds
		/// 
		/// </summary>
		public const RapidObjectListType DataDeclarations;

		/// <summary>
		/// 
		/// The parameter declarations it holds
		/// 
		/// </summary>
		public const RapidObjectListType ParameterDeclarations;

		/// <summary>
		/// 
		/// The routine declarations it holds
		/// 
		/// </summary>
		public const RapidObjectListType RoutineDeclarations;

		/// <summary>
		/// 
		/// The attributes it declares
		/// 
		/// </summary>
		public const RapidObjectListType Attributes;
	}
}
