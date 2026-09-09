//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.ABB.Rws.Data;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace UnderAutomation.ABB.Rws.Services {
	/// <summary>
	/// 
	/// Controller Service - Provides access to the controller resources: clock, identity, network, installed systems,
	/// options, backups, safety controller and virtual time.
	/// 
	/// </summary>
	public class ControllerService : Object {

		/// <summary>
		/// 
		/// Gets an overview of the controller resources (synchronous)
		/// <p>Contains the current system time, the controller identity and the list of available sub resources.</p>
		/// 
		/// </summary>
		/// <returns>Controller information</returns>
		public ControllerInfo GetInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets an overview of the controller resources (asynchronous)
		/// <p>Contains the current system time, the controller identity and the list of available sub resources.</p>
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Controller information</returns>
		public Task<ControllerInfo> GetInfoAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the value of a controller environment variable (synchronous)
		/// 
		/// </summary>
		/// <param name="name">Name of the environment variable, with or without the leading dollar sign (e.g. &quot;$TEMP&quot; or &quot;TEMP&quot;)</param>
		/// <returns>Value of the environment variable (e.g. &quot;/hd0a/TEMP&quot;)</returns>
		public string GetEnvironmentVariable(string name)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the value of a controller environment variable (asynchronous)
		/// 
		/// </summary>
		/// <param name="name">Name of the environment variable, with or without the leading dollar sign (e.g. &quot;$TEMP&quot; or &quot;TEMP&quot;)</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Value of the environment variable (e.g. &quot;/hd0a/TEMP&quot;)</returns>
		public Task<string> GetEnvironmentVariableAsync(string name, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the current system time of the controller (synchronous)
		/// <p>The time returned by the controller is always UTC.</p>
		/// 
		/// </summary>
		/// <returns>Current controller time (UTC)</returns>
		public DateTime GetClock()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the current system time of the controller (asynchronous)
		/// <p>The time returned by the controller is always UTC.</p>
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Current controller time (UTC)</returns>
		public Task<DateTime> GetClockAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Sets the system time of the controller (synchronous)
		/// <p>The controller clock is always UTC, pass a UTC date and time.</p>
		/// <p>Instead of setting the time explicitly, a time server can be configured with <xref href="UnderAutomation.ABB.Rws.Services.ControllerService.SetTimeServer(System.String)" data-throw-if-not-resolved="false"></xref>.</p>
		/// 
		/// </summary>
		/// <param name="dateTime">New controller date and time (UTC)</param>
		public void SetClock(DateTime dateTime)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Sets the system time of the controller (asynchronous)
		/// <p>The controller clock is always UTC, pass a UTC date and time.</p>
		/// <p>Instead of setting the time explicitly, a time server can be configured with <xref href="UnderAutomation.ABB.Rws.Services.ControllerService.SetTimeServerAsync(System.String%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref>.</p>
		/// 
		/// </summary>
		/// <param name="dateTime">New controller date and time (UTC)</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetClockAsync(DateTime dateTime, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the time zone used by the controller (synchronous)
		/// 
		/// </summary>
		/// <returns>Time zone as defined by the tz database, for example &quot;Europe/Stockholm&quot;</returns>
		public string GetTimeZone()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the time zone used by the controller (asynchronous)
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Time zone as defined by the tz database, for example &quot;Europe/Stockholm&quot;</returns>
		public Task<string> GetTimeZoneAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Sets the time zone used by the controller (synchronous)
		/// <p>Available only on a real controller.</p>
		/// 
		/// </summary>
		/// <param name="timeZone">Time zone as defined by the tz database, for example &quot;Europe/Stockholm&quot;</param>
		public void SetTimeZone(string timeZone)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Sets the time zone used by the controller (asynchronous)
		/// <p>Available only on a real controller.</p>
		/// 
		/// </summary>
		/// <param name="timeZone">Time zone as defined by the tz database, for example &quot;Europe/Stockholm&quot;</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetTimeZoneAsync(string timeZone, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the time server used by the controller to synchronize its clock (synchronous)
		/// <p>Available only on a real controller.</p>
		/// 
		/// </summary>
		/// <param name="serverIp">Optional IP of a specific time server to query. Requires a connection established with version 2, leave null to get the default time server.</param>
		/// <returns>Time server information, or null when no time server is configured</returns>
		public TimeServerInfo GetTimeServer(string serverIp = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the time server used by the controller to synchronize its clock (asynchronous)
		/// <p>Available only on a real controller.</p>
		/// 
		/// </summary>
		/// <param name="serverIp">Optional IP of a specific time server to query. Requires a connection established with version 2, leave null to get the default time server.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Time server information, or null when no time server is configured</returns>
		public Task<TimeServerInfo> GetTimeServerAsync(string serverIp = null, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Sets the time server used by the controller to synchronize its clock (synchronous)
		/// <p>Available only on a real controller.</p>
		/// 
		/// </summary>
		/// <param name="timeServer">Address of the time server, for example &quot;132.163.4.101&quot;</param>
		public void SetTimeServer(string timeServer)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Sets the time server used by the controller to synchronize its clock (asynchronous)
		/// <p>Available only on a real controller.</p>
		/// 
		/// </summary>
		/// <param name="timeServer">Address of the time server, for example &quot;132.163.4.101&quot;</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetTimeServerAsync(string timeServer, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the identity of the controller: name, id, type, MAC address and level (synchronous)
		/// 
		/// </summary>
		/// <returns>Controller identity</returns>
		public ControllerIdentity GetIdentity()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the identity of the controller: name, id, type, MAC address and level (asynchronous)
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Controller identity</returns>
		public Task<ControllerIdentity> GetIdentityAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Sets the identity of the controller (synchronous)
		/// <p>Available only on a real controller.</p>
		/// 
		/// </summary>
		/// <param name="name">New name of the controller, null to leave it unchanged</param>
		/// <param name="id">New controller id, null to leave it unchanged</param>
		public void SetIdentity(string name, string id = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Sets the identity of the controller (asynchronous)
		/// <p>Available only on a real controller.</p>
		/// 
		/// </summary>
		/// <param name="name">New name of the controller, null to leave it unchanged</param>
		/// <param name="id">New controller id, null to leave it unchanged</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetIdentityAsync(string name, string id = null, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Sets the language of the controller (synchronous)
		/// 
		/// </summary>
		/// <param name="language">Language as per RFC 3066, for example &quot;en&quot; or &quot;de&quot;. A not supported language results in a bad request.</param>
		public void SetLanguage(string language)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Sets the language of the controller (asynchronous)
		/// 
		/// </summary>
		/// <param name="language">Language as per RFC 3066, for example &quot;en&quot; or &quot;de&quot;. A not supported language results in a bad request.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetLanguageAsync(string language, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the IP configuration of all network interfaces of the controller (synchronous)
		/// <p>Not applicable to a virtual controller.</p>
		/// 
		/// </summary>
		/// <returns>Network interfaces of the controller</returns>
		public NetworkInterfaceItem[] GetNetworkInterfaces()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the IP configuration of all network interfaces of the controller (asynchronous)
		/// <p>Not applicable to a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Network interfaces of the controller</returns>
		public Task<NetworkInterfaceItem[]> GetNetworkInterfacesAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Sets the IP configuration of the LAN adapter of the controller (synchronous)
		/// <p>The controller must be restarted for the change to take effect. Requires the UAS grant UAS_CONTROLLER_PROPERTIES_WRITE.</p>
		/// <p>Not supported by a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="method">IP configuration method</param>
		/// <param name="address">IP address, required when <code data-dev-comment-type="paramref" class="paramref">method</code> is <xref href="UnderAutomation.ABB.Rws.Data.NetworkConfigurationMethod.FixIp" data-throw-if-not-resolved="false"></xref></param>
		/// <param name="mask">Subnet mask, required when <code data-dev-comment-type="paramref" class="paramref">method</code> is <xref href="UnderAutomation.ABB.Rws.Data.NetworkConfigurationMethod.FixIp" data-throw-if-not-resolved="false"></xref></param>
		/// <param name="gateway">Default gateway, applicable when <code data-dev-comment-type="paramref" class="paramref">method</code> is <xref href="UnderAutomation.ABB.Rws.Data.NetworkConfigurationMethod.FixIp" data-throw-if-not-resolved="false"></xref></param>
		public void SetNetworkConfiguration(NetworkConfigurationMethod method, string address = null, string mask = null, string gateway = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Sets the IP configuration of the LAN adapter of the controller (asynchronous)
		/// <p>The controller must be restarted for the change to take effect. Requires the UAS grant UAS_CONTROLLER_PROPERTIES_WRITE.</p>
		/// <p>Not supported by a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="method">IP configuration method</param>
		/// <param name="address">IP address, required when <code data-dev-comment-type="paramref" class="paramref">method</code> is <xref href="UnderAutomation.ABB.Rws.Data.NetworkConfigurationMethod.FixIp" data-throw-if-not-resolved="false"></xref></param>
		/// <param name="mask">Subnet mask, required when <code data-dev-comment-type="paramref" class="paramref">method</code> is <xref href="UnderAutomation.ABB.Rws.Data.NetworkConfigurationMethod.FixIp" data-throw-if-not-resolved="false"></xref></param>
		/// <param name="gateway">Default gateway, applicable when <code data-dev-comment-type="paramref" class="paramref">method</code> is <xref href="UnderAutomation.ABB.Rws.Data.NetworkConfigurationMethod.FixIp" data-throw-if-not-resolved="false"></xref></param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetNetworkConfigurationAsync(NetworkConfigurationMethod method, string address = null, string mask = null, string gateway = null, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Restarts or shuts down the controller (synchronous)
		/// 
		/// </summary>
		/// <param name="mode">Restart mode</param>
		/// <param name="useImplicitMastership">
		/// A connection established with version 2 requires mastership on all domains to restart the controller. When true
		/// (default), mastership is taken implicitly for this request. Ignored on a version 1 connection, which needs none.
		/// </param>
		public void Restart(ControllerRestartMode mode, bool useImplicitMastership = true)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Restarts or shuts down the controller (asynchronous)
		/// 
		/// </summary>
		/// <param name="mode">Restart mode</param>
		/// <param name="useImplicitMastership">
		/// A connection established with version 2 requires mastership on all domains to restart the controller. When true
		/// (default), mastership is taken implicitly for this request. Ignored on a version 1 connection, which needs none.
		/// </param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task RestartAsync(ControllerRestartMode mode, bool useImplicitMastership = true, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the names of the systems installed on the controller (synchronous)
		/// 
		/// </summary>
		/// <returns>Names of the installed systems</returns>
		public string[] GetInstalledSystems()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the names of the systems installed on the controller (asynchronous)
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Names of the installed systems</returns>
		public Task<string[]> GetInstalledSystemsAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Verifies whether an option is present on the controller (synchronous)
		/// <p>The option name is case sensitive, for example &quot;SAFEMOVEPRO&quot;.</p>
		/// 
		/// </summary>
		/// <param name="option">Option to verify</param>
		/// <returns>True when the option is installed on the controller, false otherwise</returns>
		public bool HasOption(string option)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Verifies whether an option is present on the controller (asynchronous)
		/// <p>The option name is case sensitive, for example &quot;SAFEMOVEPRO&quot;.</p>
		/// 
		/// </summary>
		/// <param name="option">Option to verify</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>True when the option is installed on the controller, false otherwise</returns>
		public Task<bool> HasOptionAsync(string option, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Checks whether a RobotWare version is compatible with the controller hardware (synchronous)
		/// <p>Supported only on a real controller.</p>
		/// 
		/// </summary>
		/// <param name="robotWareVersion">RobotWare version to check, for example &quot;6.03.0101&quot;</param>
		/// <returns>True when the RobotWare version is compatible with the controller hardware</returns>
		public bool IsRobotWareVersionCompatible(string robotWareVersion)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Checks whether a RobotWare version is compatible with the controller hardware (asynchronous)
		/// <p>Supported only on a real controller.</p>
		/// 
		/// </summary>
		/// <param name="robotWareVersion">RobotWare version to check, for example &quot;6.03.0101&quot;</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>True when the RobotWare version is compatible with the controller hardware</returns>
		public Task<bool> IsRobotWareVersionCompatibleAsync(string robotWareVersion, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the names of the backup sub resources exposed by the controller (synchronous)
		/// 
		/// </summary>
		/// <returns>Names of the backup sub resources (&quot;backup-info&quot;, &quot;backup-state&quot;, &quot;check-restore&quot;)</returns>
		public string[] GetBackupResources()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the names of the backup sub resources exposed by the controller (asynchronous)
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Names of the backup sub resources (&quot;backup-info&quot;, &quot;backup-state&quot;, &quot;check-restore&quot;)</returns>
		public Task<string[]> GetBackupResourcesAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets information about a backup stored on the controller file system (synchronous)
		/// 
		/// </summary>
		/// <param name="backupPath">Path of the backup folder on the controller file system. Environment variables are allowed, written either &quot;$temp/mybackup&quot; or &quot;~temp/mybackup&quot;, with or without the &quot;/fileservice&quot; prefix.</param>
		/// <returns>Name, versions and options of the backed up system</returns>
		public BackupSystemInfo GetBackupInfo(string backupPath)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets information about a backup stored on the controller file system (asynchronous)
		/// 
		/// </summary>
		/// <param name="backupPath">Path of the backup folder on the controller file system. Environment variables are allowed, written either &quot;$temp/mybackup&quot; or &quot;~temp/mybackup&quot;, with or without the &quot;/fileservice&quot; prefix.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Name, versions and options of the backed up system</returns>
		public Task<BackupSystemInfo> GetBackupInfoAsync(string backupPath, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the state of the backup operation of the controller (synchronous)
		/// <p>Used to follow a backup started with <xref href="UnderAutomation.ABB.Rws.Services.ControllerService.CreateBackup(System.String%2cSystem.Boolean)" data-throw-if-not-resolved="false"></xref>.</p>
		/// 
		/// </summary>
		/// <returns>Current backup state</returns>
		public BackupState GetBackupState()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the state of the backup operation of the controller (asynchronous)
		/// <p>Used to follow a backup started with <xref href="UnderAutomation.ABB.Rws.Services.ControllerService.CreateBackupAsync(System.String%2cSystem.Boolean%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref>.</p>
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Current backup state</returns>
		public Task<BackupState> GetBackupStateAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Creates a backup of the current system on the controller file system (synchronous)
		/// <p>The backup is created asynchronously by the controller: this method returns as soon as the request is accepted.
		/// Poll <xref href="UnderAutomation.ABB.Rws.Services.ControllerService.GetBackupState" data-throw-if-not-resolved="false"></xref> to know when the backup is finished.</p>
		/// <p>Requires the UAS grant UAS_BACKUP. Creating a backup may affect RAPID execution and can cause system stops.</p>
		/// 
		/// </summary>
		/// <param name="backupPath">
		/// Destination path of the backup, it must be part of the controller file system. Environment variables such as $TEMP or $SYSTEM
		/// are allowed, written either &quot;$temp/mybackup&quot; or &quot;~temp/mybackup&quot;, with or without the &quot;/fileservice&quot; prefix. The backup cannot
		/// be created under the $HOME directory, nor use the name of an environment variable directory.
		/// </param>
		/// <param name="archive">When true, the backup is stored as an archive</param>
		public void CreateBackup(string backupPath, bool archive = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Creates a backup of the current system on the controller file system (asynchronous)
		/// <p>The backup is created asynchronously by the controller: this method returns as soon as the request is accepted.
		/// Poll <xref href="UnderAutomation.ABB.Rws.Services.ControllerService.GetBackupStateAsync(System.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref> to know when the backup is finished.</p>
		/// <p>Requires the UAS grant UAS_BACKUP. Creating a backup may affect RAPID execution and can cause system stops.</p>
		/// 
		/// </summary>
		/// <param name="backupPath">
		/// Destination path of the backup, it must be part of the controller file system. Environment variables such as $TEMP or $SYSTEM
		/// are allowed, written either &quot;$temp/mybackup&quot; or &quot;~temp/mybackup&quot;, with or without the &quot;/fileservice&quot; prefix. The backup cannot
		/// be created under the $HOME directory, nor use the name of an environment variable directory.
		/// </param>
		/// <param name="archive">When true, the backup is stored as an archive</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task CreateBackupAsync(string backupPath, bool archive = false, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Restores a backup stored on the controller file system (synchronous)
		/// <p>When the backup can be restored, the controller restarts.</p>
		/// <p>Requires the UAS grant to restore a backup. Use <xref href="UnderAutomation.ABB.Rws.Services.ControllerService.CheckRestore(System.String%2cUnderAutomation.ABB.Rws.Data.BackupRestoreIgnore%2cSystem.Boolean%2cSystem.Boolean%2cUnderAutomation.ABB.Rws.Data.BackupRestoreInclude)" data-throw-if-not-resolved="false"></xref> first to detect mismatches.</p>
		/// 
		/// </summary>
		/// <param name="backupPath">Path of the backup folder on the controller file system. Environment variables are allowed, written either &quot;$temp/mybackup&quot; or &quot;~temp/mybackup&quot;, with or without the &quot;/fileservice&quot; prefix.</param>
		/// <param name="ignore">Mismatches between the backup and the current system that are ignored</param>
		/// <param name="deleteDirectory">When true, the backup directory is deleted once the restore is finished</param>
		/// <param name="includeControllerSettings">Include the controller settings in the restore. RobotWare 7 does not support restoring controller settings and ignores this flag.</param>
		/// <param name="includeSafetySettings">Include the safety settings in the restore</param>
		/// <param name="include">Content to restore</param>
		public void RestoreBackup(string backupPath, BackupRestoreIgnore ignore, bool deleteDirectory = true, bool includeControllerSettings = true, bool includeSafetySettings = true, BackupRestoreInclude include)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Restores a backup stored on the controller file system (asynchronous)
		/// <p>When the backup can be restored, the controller restarts.</p>
		/// <p>Requires the UAS grant to restore a backup. Use <xref href="UnderAutomation.ABB.Rws.Services.ControllerService.CheckRestoreAsync(System.String%2cUnderAutomation.ABB.Rws.Data.BackupRestoreIgnore%2cSystem.Boolean%2cSystem.Boolean%2cUnderAutomation.ABB.Rws.Data.BackupRestoreInclude%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref> first to detect mismatches.</p>
		/// 
		/// </summary>
		/// <param name="backupPath">Path of the backup folder on the controller file system. Environment variables are allowed, written either &quot;$temp/mybackup&quot; or &quot;~temp/mybackup&quot;, with or without the &quot;/fileservice&quot; prefix.</param>
		/// <param name="ignore">Mismatches between the backup and the current system that are ignored</param>
		/// <param name="deleteDirectory">When true, the backup directory is deleted once the restore is finished</param>
		/// <param name="includeControllerSettings">Include the controller settings in the restore. RobotWare 7 does not support restoring controller settings and ignores this flag.</param>
		/// <param name="includeSafetySettings">Include the safety settings in the restore</param>
		/// <param name="include">Content to restore</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task RestoreBackupAsync(string backupPath, BackupRestoreIgnore ignore, bool deleteDirectory = true, bool includeControllerSettings = true, bool includeSafetySettings = true, BackupRestoreInclude include, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Checks a backup for mismatches and other problems before restoring it (synchronous)
		/// 
		/// </summary>
		/// <param name="backupPath">Path of the backup folder on the controller file system. Environment variables are allowed, written either &quot;$temp/mybackup&quot; or &quot;~temp/mybackup&quot;, with or without the &quot;/fileservice&quot; prefix.</param>
		/// <param name="ignore">Mismatches between the backup and the current system that are ignored</param>
		/// <param name="includeControllerSettings">Include the controller settings in the restore</param>
		/// <param name="includeSafetySettings">Include the safety settings in the restore</param>
		/// <param name="include">Content to restore</param>
		/// <returns>Result of the check, including the missing or corrupted file when the controller reports one</returns>
		public CheckRestoreResult CheckRestore(string backupPath, BackupRestoreIgnore ignore, bool includeControllerSettings = true, bool includeSafetySettings = true, BackupRestoreInclude include)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Checks a backup for mismatches and other problems before restoring it (asynchronous)
		/// 
		/// </summary>
		/// <param name="backupPath">Path of the backup folder on the controller file system. Environment variables are allowed, written either &quot;$temp/mybackup&quot; or &quot;~temp/mybackup&quot;, with or without the &quot;/fileservice&quot; prefix.</param>
		/// <param name="ignore">Mismatches between the backup and the current system that are ignored</param>
		/// <param name="includeControllerSettings">Include the controller settings in the restore</param>
		/// <param name="includeSafetySettings">Include the safety settings in the restore</param>
		/// <param name="include">Content to restore</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Result of the check, including the missing or corrupted file when the controller reports one</returns>
		public Task<CheckRestoreResult> CheckRestoreAsync(string backupPath, BackupRestoreIgnore ignore, bool includeControllerSettings = true, bool includeSafetySettings = true, BackupRestoreInclude include, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the names of the safety sub resources exposed by the controller (synchronous)
		/// 
		/// </summary>
		/// <returns>Names of the safety sub resources (&quot;safety-mode&quot;, &quot;safety-configuration&quot;, &quot;violation-info&quot;, ...)</returns>
		public string[] GetSafetyResources()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the names of the safety sub resources exposed by the controller (asynchronous)
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Names of the safety sub resources (&quot;safety-mode&quot;, &quot;safety-configuration&quot;, &quot;violation-info&quot;, ...)</returns>
		public Task<string[]> GetSafetyResourcesAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the safety mode of the controller (synchronous)
		/// 
		/// </summary>
		/// <returns>Current safety mode and its user data</returns>
		public SafetyModeStatus GetSafetyMode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the safety mode of the controller (asynchronous)
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Current safety mode and its user data</returns>
		public Task<SafetyModeStatus> GetSafetyModeAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Sets the safety mode of the controller (synchronous)
		/// <p>The controller must be in manual mode.</p>
		/// 
		/// </summary>
		/// <param name="mode">New safety mode, one of <xref href="UnderAutomation.ABB.Rws.Data.SafetyMode.Active" data-throw-if-not-resolved="false"></xref>, <xref href="UnderAutomation.ABB.Rws.Data.SafetyMode.Commissioning" data-throw-if-not-resolved="false"></xref> or <xref href="UnderAutomation.ABB.Rws.Data.SafetyMode.Service" data-throw-if-not-resolved="false"></xref></param>
		public void SetSafetyMode(SafetyMode mode)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Sets the safety mode of the controller (asynchronous)
		/// <p>The controller must be in manual mode.</p>
		/// 
		/// </summary>
		/// <param name="mode">New safety mode, one of <xref href="UnderAutomation.ABB.Rws.Data.SafetyMode.Active" data-throw-if-not-resolved="false"></xref>, <xref href="UnderAutomation.ABB.Rws.Data.SafetyMode.Commissioning" data-throw-if-not-resolved="false"></xref> or <xref href="UnderAutomation.ABB.Rws.Data.SafetyMode.Service" data-throw-if-not-resolved="false"></xref></param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetSafetyModeAsync(SafetyMode mode, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the safety supervision configuration of the controller (synchronous)
		/// 
		/// </summary>
		/// <returns>Versions, creation date and checksum of the safety configuration</returns>
		public SafetyConfiguration GetSafetyConfiguration()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the safety supervision configuration of the controller (asynchronous)
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Versions, creation date and checksum of the safety configuration</returns>
		public Task<SafetyConfiguration> GetSafetyConfigurationAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Loads a safety configuration file into the controller (synchronous)
		/// <p>The configuration file must already exist on the controller file system.</p>
		/// <p>Use <xref href="UnderAutomation.ABB.Rws.Services.ControllerService.GetSafetyLoadOperationStatus" data-throw-if-not-resolved="false"></xref> to check whether loading is currently allowed.</p>
		/// 
		/// </summary>
		/// <param name="filePath">Path of the safety configuration file on the controller (e.g. &quot;$home/file.xml&quot;)</param>
		public void LoadSafetyConfiguration(string filePath)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Loads a safety configuration file into the controller (asynchronous)
		/// <p>The configuration file must already exist on the controller file system.</p>
		/// <p>Use <xref href="UnderAutomation.ABB.Rws.Services.ControllerService.GetSafetyLoadOperationStatusAsync(System.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref> to check whether loading is currently allowed.</p>
		/// 
		/// </summary>
		/// <param name="filePath">Path of the safety configuration file on the controller (e.g. &quot;$home/file.xml&quot;)</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task LoadSafetyConfigurationAsync(string filePath, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Removes the validation information from the safety configuration file (synchronous)
		/// <p>Requires the UAS grant UAS_SAFETY_SERVICES.</p>
		/// 
		/// </summary>
		public void InvalidateSafetyConfiguration()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Removes the validation information from the safety configuration file (asynchronous)
		/// <p>Requires the UAS grant UAS_SAFETY_SERVICES.</p>
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task InvalidateSafetyConfigurationAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Checks whether a new safety configuration is allowed to be loaded (synchronous)
		/// <p>The user must have the safety services privileges.</p>
		/// 
		/// </summary>
		/// <returns><xref href="UnderAutomation.ABB.Rws.Data.SafetyLoadOperationStatus.Ok" data-throw-if-not-resolved="false"></xref> when a configuration can be loaded, the blocking reason otherwise</returns>
		public SafetyLoadOperationStatus GetSafetyLoadOperationStatus()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Checks whether a new safety configuration is allowed to be loaded (asynchronous)
		/// <p>The user must have the safety services privileges.</p>
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns><xref href="UnderAutomation.ABB.Rws.Data.SafetyLoadOperationStatus.Ok" data-throw-if-not-resolved="false"></xref> when a configuration can be loaded, the blocking reason otherwise</returns>
		public Task<SafetyLoadOperationStatus> GetSafetyLoadOperationStatusAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the cyclic brake check status of a mechanical unit (synchronous)
		/// 
		/// </summary>
		/// <param name="driveNumber">Drive number of the mechanical unit</param>
		/// <returns>Cyclic brake check status of the mechanical unit</returns>
		public CyclicBrakeCheckStatus GetCyclicBrakeCheckStatus(int driveNumber)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the cyclic brake check status of a mechanical unit (asynchronous)
		/// 
		/// </summary>
		/// <param name="driveNumber">Drive number of the mechanical unit</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Cyclic brake check status of the mechanical unit</returns>
		public Task<CyclicBrakeCheckStatus> GetCyclicBrakeCheckStatusAsync(int driveNumber, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the safety violation details reported by the safety controller (synchronous)
		/// <p>The user must have the safety services privileges.</p>
		/// 
		/// </summary>
		/// <returns>Safety violation details</returns>
		public SafetyViolationInfo GetSafetyViolationInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the safety violation details reported by the safety controller (asynchronous)
		/// <p>The user must have the safety services privileges.</p>
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Safety violation details</returns>
		public Task<SafetyViolationInfo> GetSafetyViolationInfoAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the names of the virtual time sub resources exposed by the controller (synchronous)
		/// <p>Supported only on a virtual controller.</p>
		/// 
		/// </summary>
		/// <returns>Names of the virtual time sub resources (&quot;vttime&quot;, &quot;vtspeed&quot;, &quot;vtstate&quot;, &quot;vttimeslice&quot;)</returns>
		public string[] GetVirtualTimeResources()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the names of the virtual time sub resources exposed by the controller (asynchronous)
		/// <p>Supported only on a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Names of the virtual time sub resources (&quot;vttime&quot;, &quot;vtspeed&quot;, &quot;vtstate&quot;, &quot;vttimeslice&quot;)</returns>
		public Task<string[]> GetVirtualTimeResourcesAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the current value of the virtual time, in milliseconds (synchronous)
		/// <p>The virtual time is zeroed when the virtual controller starts. Supported only on a virtual controller.</p>
		/// 
		/// </summary>
		/// <returns>Virtual time in milliseconds</returns>
		public long GetVirtualTime()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the current value of the virtual time, in milliseconds (asynchronous)
		/// <p>The virtual time is zeroed when the virtual controller starts. Supported only on a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Virtual time in milliseconds</returns>
		public Task<long> GetVirtualTimeAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the speed of the virtual time, in percent relative to real time (synchronous)
		/// <p>-1 means full speed. Supported only on a virtual controller.</p>
		/// 
		/// </summary>
		/// <returns>Speed of the virtual time in percent</returns>
		public int GetVirtualTimeSpeed()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the speed of the virtual time, in percent relative to real time (asynchronous)
		/// <p>-1 means full speed. Supported only on a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Speed of the virtual time in percent</returns>
		public Task<int> GetVirtualTimeSpeedAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Sets the speed of the virtual time, in percent relative to real time (synchronous)
		/// <p>100 makes the virtual time run approximately at real time speed, -1 runs it as fast as possible.</p>
		/// <p>Supported only on a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="speed">Speed in percent, or -1 for full speed</param>
		public void SetVirtualTimeSpeed(int speed)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Sets the speed of the virtual time, in percent relative to real time (asynchronous)
		/// <p>100 makes the virtual time run approximately at real time speed, -1 runs it as fast as possible.</p>
		/// <p>Supported only on a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="speed">Speed in percent, or -1 for full speed</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetVirtualTimeSpeedAsync(int speed, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the state of the virtual time server (synchronous)
		/// <p>Supported only on a virtual controller.</p>
		/// 
		/// </summary>
		/// <returns>State of the virtual time server</returns>
		public VirtualTimeState GetVirtualTimeState()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the state of the virtual time server (asynchronous)
		/// <p>Supported only on a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>State of the virtual time server</returns>
		public Task<VirtualTimeState> GetVirtualTimeStateAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Sets the state of the virtual time server (synchronous)
		/// <p>Supported only on a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="state">New state of the virtual time server</param>
		public void SetVirtualTimeState(VirtualTimeState state)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Sets the state of the virtual time server (asynchronous)
		/// <p>Supported only on a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="state">New state of the virtual time server</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetVirtualTimeStateAsync(VirtualTimeState state, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the time slice of the virtual controller, in milliseconds (synchronous)
		/// <p>Supported only on a virtual controller.</p>
		/// 
		/// </summary>
		/// <returns>Time slice in milliseconds</returns>
		public int GetVirtualTimeSlice()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the time slice of the virtual controller, in milliseconds (asynchronous)
		/// <p>Supported only on a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Time slice in milliseconds</returns>
		public Task<int> GetVirtualTimeSliceAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Sets the time slice of the virtual controller, in milliseconds (synchronous)
		/// <p>The minimum value is 10 ms, lower values are replaced by the controller with the default value of 10 ms.</p>
		/// <p>Supported only on a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="milliseconds">Time slice in milliseconds</param>
		public void SetVirtualTimeSlice(int milliseconds)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Sets the time slice of the virtual controller, in milliseconds (asynchronous)
		/// <p>The minimum value is 10 ms, lower values are replaced by the controller with the default value of 10 ms.</p>
		/// <p>Supported only on a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="milliseconds">Time slice in milliseconds</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetVirtualTimeSliceAsync(int milliseconds, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Executes the virtual time according to the current state of the virtual time server (synchronous)
		/// <p>Supported only on a virtual controller.</p>
		/// 
		/// </summary>
		public void RunVirtualTime()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Executes the virtual time according to the current state of the virtual time server (asynchronous)
		/// <p>Supported only on a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task RunVirtualTimeAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
