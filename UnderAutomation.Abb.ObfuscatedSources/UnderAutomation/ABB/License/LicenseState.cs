//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.License {
	/// <summary>
	/// 
	/// States that can take a license
	/// 
	/// </summary>
	public sealed class LicenseState : Enum {


		public int value__;

		/// <summary>
		/// 
		/// No license has been provided
		/// 
		/// </summary>
		public const LicenseState None;

		/// <summary>
		/// 
		/// The pair License Identifier and License Key are incompatible, you cannot use the library
		/// 
		/// </summary>
		public const LicenseState Invalid;

		/// <summary>
		/// 
		/// The library is in a trial period, you can use the library
		/// 
		/// </summary>
		public const LicenseState Trial;

		/// <summary>
		/// 
		/// The library is in an extra trial period, you can use the library
		/// 
		/// </summary>
		public const LicenseState ExtraTrial;

		/// <summary>
		/// 
		/// The trial period as expired, you no more can use the library
		/// 
		/// </summary>
		public const LicenseState Expired;

		/// <summary>
		/// 
		/// Your license does not allow you to use such a recent release. Please buy maintenance to use this version
		/// 
		/// </summary>
		public const LicenseState MaintenanceNeeded;

		/// <summary>
		/// 
		/// Congratulations, the library is licensed.
		/// 
		/// </summary>
		public const LicenseState Licensed;
	}
}
