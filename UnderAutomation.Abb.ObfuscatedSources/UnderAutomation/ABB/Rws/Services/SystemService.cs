//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.ABB.Rws.Data;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace UnderAutomation.ABB.Rws.Services {
	/// <summary>
	/// System Service - Describes the system installed on the controller: its name and software version, the
	/// options and the products it was built with, the type of robot it drives, its license, and the energy it
	/// consumes. None of these resources is available while the controller runs in bootserver mode.
	/// </summary>
	public class SystemService {

		/// <summary>
		/// Gets the name, the software version and the installed options of the system (synchronous)
		/// </summary>
		/// <returns>Description of the system running on the controller</returns>
		public SystemInfo GetInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the name, the software version and the installed options of the system (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Description of the system running on the controller</returns>
		public Task<SystemInfo> GetInfoAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the options installed on the system (synchronous)
		/// </summary>
		/// <returns>Names of the options, in the order the controller reports them, empty when there is none</returns>
		public string[] GetOptions()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the options installed on the system (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Names of the options, in the order the controller reports them, empty when there is none</returns>
		public Task<string[]> GetOptionsAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the license the robot software runs under (synchronous)
		/// </summary>
		/// <returns>Name of the license, for example "VIRTUAL_USE" on a simulated controller</returns>
		public string GetLicense()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the license the robot software runs under (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Name of the license, for example "VIRTUAL_USE" on a simulated controller</returns>
		public Task<string> GetLicenseAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the type of every robot the controller drives (synchronous)
		/// </summary>
		/// <returns>Robot types, for example "IRB 120-3/0.6", empty when the controller drives no standard robot</returns>
		public string[] GetRobotTypes()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the type of every robot the controller drives (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Robot types, for example "IRB 120-3/0.6", empty when the controller drives no standard robot</returns>
		public Task<string[]> GetRobotTypesAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the software products installed on the controller, with their versions (synchronous)
		/// </summary>
		/// <param name="name">Name of a single product to report, null to report every installed product</param>
		/// <returns>Installed products, empty when the controller reports none</returns>
		public SystemProduct[] GetProducts(string name = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the software products installed on the controller, with their versions (asynchronous)
		/// </summary>
		/// <param name="name">Name of a single product to report, null to report every installed product</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Installed products, empty when the controller reports none</returns>
		public Task<SystemProduct[]> GetProductsAsync(string name = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the energy the controller consumed, for the current interval and since the last reset (synchronous)
		/// </summary>
		/// <returns>Energy measurement, broken down per mechanical unit and per axis</returns>
		public SystemEnergy GetEnergy()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the energy the controller consumed, for the current interval and since the last reset (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Energy measurement, broken down per mechanical unit and per axis</returns>
		public Task<SystemEnergy> GetEnergyAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the counter the controller increments each time a new energy measurement is available (synchronous)
		/// </summary>
		/// <returns>Current value of the counter, null when the controller did not report it</returns>
		public int? GetEnergyChangeCount()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the counter the controller increments each time a new energy measurement is available (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Current value of the counter, null when the controller did not report it</returns>
		public Task<int?> GetEnergyChangeCountAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets the accumulated energy counter of the controller back to zero (synchronous)
		/// </summary>
		public void ResetAccumulatedEnergy()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Sets the accumulated energy counter of the controller back to zero (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task ResetAccumulatedEnergyAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
