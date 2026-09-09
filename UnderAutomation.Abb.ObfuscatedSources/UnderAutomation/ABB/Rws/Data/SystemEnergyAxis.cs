//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Energy consumed by one axis of a mechanical unit during the current measurement interval.
	/// <p>Held by <xref href="UnderAutomation.ABB.Rws.Data.SystemEnergyMechanicalUnit" data-throw-if-not-resolved="false"></xref>.</p>
	/// 
	/// </summary>
	public class SystemEnergyAxis : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.SystemEnergyAxis" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public SystemEnergyAxis()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this axis
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Number of the axis inside its mechanical unit, starting at 1
		/// 
		/// </summary>
		public int Number { get; set; }

		/// <summary>
		/// 
		/// Energy the axis consumed during the current measurement interval, in joules,
		/// null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<double> IntervalEnergy { get; set; }
	}
}
