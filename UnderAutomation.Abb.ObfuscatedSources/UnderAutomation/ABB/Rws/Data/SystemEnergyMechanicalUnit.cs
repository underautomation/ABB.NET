//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Energy consumed by one mechanical unit, broken down per axis.
	/// 
	/// <p>Held by <xref href="UnderAutomation.ABB.Rws.Data.SystemEnergy" data-throw-if-not-resolved="false"></xref>.</p>
	/// </summary>
	public class SystemEnergyMechanicalUnit {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.SystemEnergyMechanicalUnit" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public SystemEnergyMechanicalUnit()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this mechanical unit
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the mechanical unit, for example "ROB_1"
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Energy consumed by each axis of the mechanical unit during the current measurement interval
		/// </summary>
		public SystemEnergyAxis[] Axes { get; set; }

		/// <summary>
		/// Number of axes the controller reported for this mechanical unit
		/// </summary>
		public int AxisCount { get; }
	}
}
