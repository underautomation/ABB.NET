//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// What each of the six external joints of a task is doing, which says how to read the corresponding
	/// value of an external axis.
	/// 
	/// <p>Returned by <code>RapidService.GetExternalJointStates()</code>. A joint reported as
	/// <xref href="UnderAutomation.ABB.Rws.Data.RapidJointState.NotActive" data-throw-if-not-resolved="false"></xref> carries no meaningful position.</p>
	/// </summary>
	public class RapidExternalJointStates {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.RapidExternalJointStates" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public RapidExternalJointStates()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of these joint states
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// State of the first external joint
		/// </summary>
		public RapidJointState Joint1 { get; set; }

		/// <summary>
		/// State of the second external joint
		/// </summary>
		public RapidJointState Joint2 { get; set; }

		/// <summary>
		/// State of the third external joint
		/// </summary>
		public RapidJointState Joint3 { get; set; }

		/// <summary>
		/// State of the fourth external joint
		/// </summary>
		public RapidJointState Joint4 { get; set; }

		/// <summary>
		/// State of the fifth external joint
		/// </summary>
		public RapidJointState Joint5 { get; set; }

		/// <summary>
		/// State of the sixth external joint
		/// </summary>
		public RapidJointState Joint6 { get; set; }
	}
}
