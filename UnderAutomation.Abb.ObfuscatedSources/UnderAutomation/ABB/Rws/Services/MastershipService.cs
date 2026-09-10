//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.ABB.Rws.Data;
using System.Threading;
using System.Threading.Tasks;

namespace UnderAutomation.ABB.Rws.Services {
	/// <summary>
	/// Mastership Service - Takes and gives back the exclusive right to change a domain of the controller.
	/// 
	/// <p>Most write operations are refused unless the client holds the mastership of the domain they belong
	/// to: moving a mechanical unit needs <xref href="UnderAutomation.ABB.Rws.Data.MastershipDomain.Motion" data-throw-if-not-resolved="false"></xref>, changing the system parameters
	/// or the RAPID programs needs <xref href="UnderAutomation.ABB.Rws.Data.MastershipDomain.Edit" data-throw-if-not-resolved="false"></xref>.</p>
	/// <p>Only one client holds a domain at a time, and it keeps it until <xref href="UnderAutomation.ABB.Rws.Services.MastershipService.Release" data-throw-if-not-resolved="false"></xref> is called or
	/// the connection ends. Take it as late and give it back as early as possible: while it is held, the operator
	/// of the robot cannot change the same domain from the teach pendant.</p>
	/// <p>Mastership belongs to the connection that took it, so every call made through the same client is the
	/// holder. None of these resources is available while the controller runs in bootserver mode.</p>
	/// </summary>
	public class MastershipService {

		/// <summary>
		/// Gets the domains the connected controller can give the mastership of (synchronous)
		/// </summary>
		/// <returns>Domains the controller exposes, which are not the same on a connection established with
		///             version 1 and on one established with version 2. <xref href="UnderAutomation.ABB.Rws.Data.MastershipDomain.Edit" data-throw-if-not-resolved="false"></xref> can be asked for
		///             on either, even when it is not listed here: it then stands for the domains covering the same
		///             ground.</returns>
		public MastershipDomain[] GetDomains()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the domains the connected controller can give the mastership of (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Domains the controller exposes, which are not the same on a connection established with
		///             version 1 and on one established with version 2. <xref href="UnderAutomation.ABB.Rws.Data.MastershipDomain.Edit" data-throw-if-not-resolved="false"></xref> can be asked for
		///             on either, even when it is not listed here: it then stands for the domains covering the same
		///             ground.</returns>
		public Task<MastershipDomain[]> GetDomainsAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets who holds the mastership of every domain of the controller (synchronous)
		/// </summary>
		/// <returns>One state per domain the controller exposes, in the order it lists them</returns>
		public MastershipInfo[] GetInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets who holds the mastership of one domain (synchronous)
		/// </summary>
		/// <param name="domain">Domain to read the state of</param>
		/// <returns>State of the domain, with <xref href="UnderAutomation.ABB.Rws.Data.MastershipInfo.HeldByMe" data-throw-if-not-resolved="false"></xref> telling whether this
		///             connection is allowed to write in it</returns>
		public MastershipInfo GetInfo(MastershipDomain domain)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets who holds the mastership of every domain of the controller (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>One state per domain the controller exposes, in the order it lists them</returns>
		public Task<MastershipInfo[]> GetInfoAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets who holds the mastership of one domain (asynchronous)
		/// </summary>
		/// <param name="domain">Domain to read the state of</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>State of the domain, with <xref href="UnderAutomation.ABB.Rws.Data.MastershipInfo.HeldByMe" data-throw-if-not-resolved="false"></xref> telling whether this
		///             connection is allowed to write in it</returns>
		public Task<MastershipInfo> GetInfoAsync(MastershipDomain domain, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Takes the mastership of every domain of the controller (synchronous)
		/// </summary>
		public void Request()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Takes the mastership of one domain (synchronous)
		/// </summary>
		/// <param name="domain">Domain to take</param>
		public void Request(MastershipDomain domain)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Takes the mastership of every domain of the controller (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task RequestAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Takes the mastership of one domain (asynchronous)
		/// </summary>
		/// <param name="domain">Domain to take</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task RequestAsync(MastershipDomain domain, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gives back the mastership of every domain of the controller (synchronous)
		/// </summary>
		public void Release()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gives back the mastership of one domain (synchronous)
		/// </summary>
		/// <param name="domain">Domain to give back</param>
		public void Release(MastershipDomain domain)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gives back the mastership of every domain of the controller (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task ReleaseAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gives back the mastership of one domain (asynchronous)
		/// </summary>
		/// <param name="domain">Domain to give back</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task ReleaseAsync(MastershipDomain domain, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
