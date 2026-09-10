//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Which of the lists a RAPID object holds is being asked about
	/// </summary>
	public enum RapidObjectListType {

		/// <summary>
		/// The statements of the object
		/// </summary>
		Statements = 0,

		/// <summary>
		/// The statements of its BACKWARD handler
		/// </summary>
		BackwardStatements = 1,

		/// <summary>
		/// The statements of its ERROR handler
		/// </summary>
		ErrorStatements = 2,

		/// <summary>
		/// The statements of its UNDO handler
		/// </summary>
		UndoStatements = 3,

		/// <summary>
		/// The type declarations it holds
		/// </summary>
		TypeDeclarations = 4,

		/// <summary>
		/// The data declarations it holds
		/// </summary>
		DataDeclarations = 5,

		/// <summary>
		/// The parameter declarations it holds
		/// </summary>
		ParameterDeclarations = 6,

		/// <summary>
		/// The routine declarations it holds
		/// </summary>
		RoutineDeclarations = 7,

		/// <summary>
		/// The attributes it declares
		/// </summary>
		Attributes = 8,
	}
}
