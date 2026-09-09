//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// The program pointer and the motion pointer of a task, read in one request.
	/// <p>Returned by <code>RapidService.GetPointers()</code>. The program pointer says which instruction runs
	/// next, the motion pointer which one the robot is actually executing; they drift apart because the
	/// controller plans the path ahead of the movement.</p>
	/// 
	/// </summary>
	public class RapidPointers : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidPointers" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public RapidPointers()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of the two pointers
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Instruction the task will execute next
		/// 
		/// </summary>
		public RapidPointerPosition ProgramPointer { get; set; }

		/// <summary>
		/// 
		/// Instruction the robot is currently moving for
		/// 
		/// </summary>
		public RapidPointerPosition MotionPointer { get; set; }
	}
}
