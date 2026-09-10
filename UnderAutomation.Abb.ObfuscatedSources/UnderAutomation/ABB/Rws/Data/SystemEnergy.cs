//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// Energy the controller has consumed, for the current measurement interval and since the last reset.
	/// 
	/// <p>Returned by <code>SystemService.GetEnergy()</code>.</p>
	/// </summary>
	public class SystemEnergy {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.SystemEnergy" data-throw-if-not-resolved="false"></xref> class
		/// </summary>
		public SystemEnergy()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation of this measurement
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Whether the reported measurement is valid. When false, every energy value of this instance is
		/// meaningless and the measurement has to be read again later.
		/// </summary>
		public bool IsMeasurementValid { get; set; }

		/// <summary>
		/// State of the energy measurement
		/// </summary>
		public SystemEnergyState State { get; set; }

		/// <summary>
		/// Counter the controller increments every time a new measurement is available.
		/// 
		/// <p>Comparing it with the previous one tells whether the values changed without reading them all.</p>
		/// </summary>
		public int? ChangeCount { get; set; }

		/// <summary>
		/// Moment the measurement was taken, null when the controller did not report it
		/// </summary>
		public DateTime? TimeStamp { get; set; }

		/// <summary>
		/// Moment the accumulated energy was last reset, null when the controller did not report it
		/// </summary>
		public DateTime? ResetTime { get; set; }

		/// <summary>
		/// Length of the measurement interval in seconds, which the average power is computed from,
		/// null when the controller did not report it
		/// </summary>
		public int? IntervalLength { get; set; }

		/// <summary>
		/// Total energy consumed during the current measurement interval, in joules,
		/// null when the controller did not report it
		/// </summary>
		public double? IntervalEnergy { get; set; }

		/// <summary>
		/// Total energy consumed since the last reset, in joules, null when the controller did not report it
		/// </summary>
		public double? AccumulatedEnergy { get; set; }

		/// <summary>
		/// Energy consumed by each mechanical unit during the current measurement interval
		/// </summary>
		public SystemEnergyMechanicalUnit[] MechanicalUnits { get; set; }

		/// <summary>
		/// Average power consumed during the current measurement interval, in watts.
		/// 
		/// <p>Null when the interval energy or the interval length is missing, or when the interval is empty.</p>
		/// </summary>
		public double? AveragePower { get; }

		/// <summary>
		/// Number of mechanical units the controller reported
		/// </summary>
		public int MechanicalUnitCount { get; }
	}
}
