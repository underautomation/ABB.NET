//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Threading;
using System.Threading.Tasks;
using System;
using UnderAutomation.ABB.Rws.Data;

namespace UnderAutomation.ABB.Rws.Services {
	/// <summary>
	/// 
	/// I/O System Service - Provides access to the I/O resources of the controller: networks, devices and signals.
	/// None of these resources is available while the controller runs in bootserver mode.
	/// 
	/// </summary>
	public class IoService : Object {

		/// <summary>
		/// 
		/// Gets the names of the I/O sub resources exposed by the controller (synchronous)
		/// 
		/// </summary>
		/// <returns>Names of the I/O sub resources (&quot;networks&quot;, &quot;devices&quot;, &quot;signals&quot;)</returns>
		public string[] GetResources()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the names of the I/O sub resources exposed by the controller (asynchronous)
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Names of the I/O sub resources (&quot;networks&quot;, &quot;devices&quot;, &quot;signals&quot;)</returns>
		public Task<string[]> GetResourcesAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets every I/O network defined in the controller (synchronous)
		/// 
		/// </summary>
		/// <returns>I/O networks, for example &quot;Local&quot; and &quot;Virtual&quot;</returns>
		public IoNetworkItem[] GetNetworks()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets every I/O network defined in the controller (asynchronous)
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>I/O networks, for example &quot;Local&quot; and &quot;Virtual&quot;</returns>
		public Task<IoNetworkItem[]> GetNetworksAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets a single I/O network (synchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network, for example &quot;Local&quot;</param>
		/// <returns>The I/O network</returns>
		public IoNetworkItem GetNetwork(string network)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets a single I/O network (asynchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network, for example &quot;Local&quot;</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The I/O network</returns>
		public Task<IoNetworkItem> GetNetworkAsync(string network, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Searches the I/O networks matching a name and/or a physical state (synchronous)
		/// 
		/// </summary>
		/// <param name="name">Name of the searched networks, for example &quot;Local&quot;. Optional when <code data-dev-comment-type="paramref" class="paramref">physicalState</code> is given.</param>
		/// <param name="physicalState">Physical state of the searched networks, for example <xref href="UnderAutomation.ABB.Rws.Data.IoNetworkPhysicalState.Running" data-throw-if-not-resolved="false"></xref>. Optional when <code data-dev-comment-type="paramref" class="paramref">name</code> is given.</param>
		/// <returns>I/O networks matching the criteria</returns>
		public IoNetworkItem[] SearchNetworks(string name = null, Nullable<IoNetworkPhysicalState> physicalState = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Searches the I/O networks matching a name and/or a physical state (asynchronous)
		/// 
		/// </summary>
		/// <param name="name">Name of the searched networks, for example &quot;Local&quot;. Optional when <code data-dev-comment-type="paramref" class="paramref">physicalState</code> is given.</param>
		/// <param name="physicalState">Physical state of the searched networks, for example <xref href="UnderAutomation.ABB.Rws.Data.IoNetworkPhysicalState.Running" data-throw-if-not-resolved="false"></xref>. Optional when <code data-dev-comment-type="paramref" class="paramref">name</code> is given.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>I/O networks matching the criteria</returns>
		public Task<IoNetworkItem[]> SearchNetworksAsync(string name = null, Nullable<IoNetworkPhysicalState> physicalState = null, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the runtime configuration properties of an I/O network (synchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network, for example &quot;Local&quot;</param>
		/// <returns>Runtime configuration of the network</returns>
		public IoNetworkConfiguration GetNetworkConfiguration(string network)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the runtime configuration properties of an I/O network (asynchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network, for example &quot;Local&quot;</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Runtime configuration of the network</returns>
		public Task<IoNetworkConfiguration> GetNetworkConfigurationAsync(string network, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Runs the auto configuration of an I/O network (synchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network, for example &quot;Local&quot;</param>
		/// <param name="configurationType">Part of the network to configure</param>
		/// <returns>Action the client is expected to take, <xref href="UnderAutomation.ABB.Rws.Data.IoClientAction.Unknown" data-throw-if-not-resolved="false"></xref> when the controller did not report one</returns>
		public IoClientAction SetNetworkConfigurationType(string network, IoNetworkConfigurationType configurationType)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Runs the auto configuration of an I/O network (asynchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network, for example &quot;Local&quot;</param>
		/// <param name="configurationType">Part of the network to configure</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Action the client is expected to take, <xref href="UnderAutomation.ABB.Rws.Data.IoClientAction.Unknown" data-throw-if-not-resolved="false"></xref> when the controller did not report one</returns>
		public Task<IoClientAction> SetNetworkConfigurationTypeAsync(string network, IoNetworkConfigurationType configurationType, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Starts or stops an I/O network (synchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network, for example &quot;Local&quot;</param>
		/// <param name="logicalState">New logical state of the network, <xref href="UnderAutomation.ABB.Rws.Data.IoNetworkLogicalState.Started" data-throw-if-not-resolved="false"></xref> or <xref href="UnderAutomation.ABB.Rws.Data.IoNetworkLogicalState.Stopped" data-throw-if-not-resolved="false"></xref></param>
		public void SetNetworkState(string network, IoNetworkLogicalState logicalState)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Starts or stops an I/O network (asynchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network, for example &quot;Local&quot;</param>
		/// <param name="logicalState">New logical state of the network, <xref href="UnderAutomation.ABB.Rws.Data.IoNetworkLogicalState.Started" data-throw-if-not-resolved="false"></xref> or <xref href="UnderAutomation.ABB.Rws.Data.IoNetworkLogicalState.Stopped" data-throw-if-not-resolved="false"></xref></param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetNetworkStateAsync(string network, IoNetworkLogicalState logicalState, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets every I/O device defined in the controller (synchronous)
		/// 
		/// </summary>
		/// <returns>I/O devices of every network</returns>
		public IoDeviceItem[] GetDevices()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets every I/O device defined in the controller (asynchronous)
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>I/O devices of every network</returns>
		public Task<IoDeviceItem[]> GetDevicesAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets a single I/O device, including its input and output data (synchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network the device is connected to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device, for example &quot;PANEL&quot;</param>
		/// <returns>The I/O device</returns>
		public IoDeviceItem GetDevice(string network, string device)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets a single I/O device, including its input and output data (asynchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network the device is connected to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device, for example &quot;PANEL&quot;</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The I/O device</returns>
		public Task<IoDeviceItem> GetDeviceAsync(string network, string device, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Searches the I/O devices matching a name and/or a logical state (synchronous)
		/// 
		/// </summary>
		/// <param name="name">Name of the searched devices, for example &quot;DRV_1&quot;. Optional when <code data-dev-comment-type="paramref" class="paramref">logicalState</code> is given.</param>
		/// <param name="logicalState">Logical state of the searched devices. Optional when <code data-dev-comment-type="paramref" class="paramref">name</code> is given.</param>
		/// <param name="network">Name of the network the searched devices are connected to, for example &quot;DeviceNet&quot;. Optional.</param>
		/// <returns>I/O devices matching the criteria</returns>
		public IoDeviceItem[] SearchDevices(string name = null, Nullable<IoDeviceLogicalState> logicalState = null, string network = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Searches the I/O devices matching a name and/or a logical state (asynchronous)
		/// 
		/// </summary>
		/// <param name="name">Name of the searched devices, for example &quot;DRV_1&quot;. Optional when <code data-dev-comment-type="paramref" class="paramref">logicalState</code> is given.</param>
		/// <param name="logicalState">Logical state of the searched devices. Optional when <code data-dev-comment-type="paramref" class="paramref">name</code> is given.</param>
		/// <param name="network">Name of the network the searched devices are connected to, for example &quot;DeviceNet&quot;. Optional.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>I/O devices matching the criteria</returns>
		public Task<IoDeviceItem[]> SearchDevicesAsync(string name = null, Nullable<IoDeviceLogicalState> logicalState = null, string network = null, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the runtime configuration properties of an I/O device (synchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network the device is connected to, for example &quot;DeviceNet&quot;</param>
		/// <param name="device">Name of the device, for example &quot;DN_Internal_Device&quot;</param>
		/// <returns>Runtime configuration of the device</returns>
		public IoDeviceConfiguration GetDeviceConfiguration(string network, string device)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the runtime configuration properties of an I/O device (asynchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network the device is connected to, for example &quot;DeviceNet&quot;</param>
		/// <param name="device">Name of the device, for example &quot;DN_Internal_Device&quot;</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Runtime configuration of the device</returns>
		public Task<IoDeviceConfiguration> GetDeviceConfigurationAsync(string network, string device, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the firmware upgrade status of an I/O device and of each of its modules (synchronous)
		/// <p>Only available on a real controller.</p>
		/// 
		/// </summary>
		/// <param name="network">Name of the network the device is connected to, for example &quot;EtherNetIP&quot;</param>
		/// <param name="device">Name of the device, for example &quot;EN_Internal_Device&quot;</param>
		/// <returns>Firmware upgrade status of the device</returns>
		public IoDeviceUpgradeInfo GetDeviceUpgradeInfo(string network, string device)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the firmware upgrade status of an I/O device and of each of its modules (asynchronous)
		/// <p>Only available on a real controller.</p>
		/// 
		/// </summary>
		/// <param name="network">Name of the network the device is connected to, for example &quot;EtherNetIP&quot;</param>
		/// <param name="device">Name of the device, for example &quot;EN_Internal_Device&quot;</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Firmware upgrade status of the device</returns>
		public Task<IoDeviceUpgradeInfo> GetDeviceUpgradeInfoAsync(string network, string device, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Enables or disables an I/O device (synchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network the device is connected to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device, for example &quot;DRV_1&quot;</param>
		/// <param name="logicalState">New logical state of the device, <xref href="UnderAutomation.ABB.Rws.Data.IoDeviceLogicalState.Enabled" data-throw-if-not-resolved="false"></xref> or <xref href="UnderAutomation.ABB.Rws.Data.IoDeviceLogicalState.Disabled" data-throw-if-not-resolved="false"></xref></param>
		public void SetDeviceState(string network, string device, IoDeviceLogicalState logicalState)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Enables or disables an I/O device (asynchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network the device is connected to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device, for example &quot;DRV_1&quot;</param>
		/// <param name="logicalState">New logical state of the device, <xref href="UnderAutomation.ABB.Rws.Data.IoDeviceLogicalState.Enabled" data-throw-if-not-resolved="false"></xref> or <xref href="UnderAutomation.ABB.Rws.Data.IoDeviceLogicalState.Disabled" data-throw-if-not-resolved="false"></xref></param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetDeviceStateAsync(string network, string device, IoDeviceLogicalState logicalState, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Writes one byte of the input data of an I/O device (synchronous)
		/// <p>Only supported on a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="network">Name of the network the device is connected to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device, for example &quot;DRV_1&quot;</param>
		/// <param name="startByte">Index of the written byte. For a 4 bytes long input data, it ranges from 0 to 3.</param>
		/// <param name="signalData">Written value, from 0 to 255. Only the first 8 bits are used.</param>
		/// <param name="dataMask">Mask of the written bits, from 0 to 255. A bit set to zero is left unchanged.</param>
		public void SetDeviceInputData(string network, string device, int startByte, int signalData, int dataMask)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Writes one byte of the input data of an I/O device (asynchronous)
		/// <p>Only supported on a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="network">Name of the network the device is connected to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device, for example &quot;DRV_1&quot;</param>
		/// <param name="startByte">Index of the written byte. For a 4 bytes long input data, it ranges from 0 to 3.</param>
		/// <param name="signalData">Written value, from 0 to 255. Only the first 8 bits are used.</param>
		/// <param name="dataMask">Mask of the written bits, from 0 to 255. A bit set to zero is left unchanged.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetDeviceInputDataAsync(string network, string device, int startByte, int signalData, int dataMask, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Writes one byte of the output data of an I/O device (synchronous)
		/// <p>Only supported on a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="network">Name of the network the device is connected to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device, for example &quot;DRV_1&quot;</param>
		/// <param name="startByte">Index of the written byte. For a 4 bytes long output data, it ranges from 0 to 3.</param>
		/// <param name="signalData">Written value, from 0 to 255. Only the first 8 bits are used.</param>
		/// <param name="dataMask">Mask of the written bits, from 0 to 255. A bit set to zero is left unchanged.</param>
		public void SetDeviceOutputData(string network, string device, int startByte, int signalData, int dataMask)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Writes one byte of the output data of an I/O device (asynchronous)
		/// <p>Only supported on a virtual controller.</p>
		/// 
		/// </summary>
		/// <param name="network">Name of the network the device is connected to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device, for example &quot;DRV_1&quot;</param>
		/// <param name="startByte">Index of the written byte. For a 4 bytes long output data, it ranges from 0 to 3.</param>
		/// <param name="signalData">Written value, from 0 to 255. Only the first 8 bits are used.</param>
		/// <param name="dataMask">Mask of the written bits, from 0 to 255. A bit set to zero is left unchanged.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetDeviceOutputDataAsync(string network, string device, int startByte, int signalData, int dataMask, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Sends a command to an I/O device (synchronous)
		/// <p>Only available on a real controller.</p>
		/// 
		/// </summary>
		/// <param name="network">Name of the network the device is connected to, for example &quot;EtherNetIP&quot;</param>
		/// <param name="device">Name of the device, for example &quot;Local_IO&quot;</param>
		/// <param name="commandName">Name of the device command, for example &quot;FIRMWARE_INFO&quot;</param>
		/// <param name="value">Value of the command, an empty string when the command takes none</param>
		/// <param name="valueLength">Number of bytes of <code data-dev-comment-type="paramref" class="paramref">value</code></param>
		/// <param name="timeout">Maximum time in milliseconds to wait for the answer of the device</param>
		public void SendDeviceCommand(string network, string device, string commandName, string value, int valueLength, int timeout)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Sends a command to an I/O device (asynchronous)
		/// <p>Only available on a real controller.</p>
		/// 
		/// </summary>
		/// <param name="network">Name of the network the device is connected to, for example &quot;EtherNetIP&quot;</param>
		/// <param name="device">Name of the device, for example &quot;Local_IO&quot;</param>
		/// <param name="commandName">Name of the device command, for example &quot;FIRMWARE_INFO&quot;</param>
		/// <param name="value">Value of the command, an empty string when the command takes none</param>
		/// <param name="valueLength">Number of bytes of <code data-dev-comment-type="paramref" class="paramref">value</code></param>
		/// <param name="timeout">Maximum time in milliseconds to wait for the answer of the device</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SendDeviceCommandAsync(string network, string device, string commandName, string value, int valueLength, int timeout, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets every I/O signal defined in the controller (synchronous)
		/// <p>A controller usually exposes several hundreds of signals. Use <xref href="UnderAutomation.ABB.Rws.Services.IoService.SearchSignals(UnderAutomation.ABB.Rws.Data.IoSignalSearchCriteria%2cUnderAutomation.ABB.Rws.Data.IoSignalSearchCriteria%2cSystem.Nullable%7bSystem.Int32%7d%2cSystem.Nullable%7bSystem.Int32%7d)" data-throw-if-not-resolved="false"></xref> to
		/// narrow the result down to a network, a device, a category or a signal type.</p>
		/// 
		/// </summary>
		/// <returns>I/O signals of every device</returns>
		public IoSignalItem[] GetSignals()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets every I/O signal defined in the controller (asynchronous)
		/// <p>A controller usually exposes several hundreds of signals. Use <xref href="UnderAutomation.ABB.Rws.Services.IoService.SearchSignalsAsync(UnderAutomation.ABB.Rws.Data.IoSignalSearchCriteria%2cUnderAutomation.ABB.Rws.Data.IoSignalSearchCriteria%2cSystem.Nullable%7bSystem.Int32%7d%2cSystem.Nullable%7bSystem.Int32%7d%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref> to
		/// narrow the result down to a network, a device, a category or a signal type.</p>
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>I/O signals of every device</returns>
		public Task<IoSignalItem[]> GetSignalsAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets a single I/O signal, including its physical value and time stamps (synchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network the signal belongs to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device the signal is connected to, for example &quot;DRV_1&quot;</param>
		/// <param name="signal">Name of the signal, for example &quot;DRV1K1&quot;</param>
		/// <returns>The I/O signal</returns>
		public IoSignalItem GetSignal(string network, string device, string signal)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets a single I/O signal, including its physical value and time stamps (asynchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network the signal belongs to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device the signal is connected to, for example &quot;DRV_1&quot;</param>
		/// <param name="signal">Name of the signal, for example &quot;DRV1K1&quot;</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The I/O signal</returns>
		public Task<IoSignalItem> GetSignalAsync(string network, string device, string signal, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the runtime configuration properties of an I/O signal (synchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network the signal belongs to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device the signal is connected to, for example &quot;DRV_1&quot;</param>
		/// <param name="signal">Name of the signal, for example &quot;DRV1K1&quot;</param>
		/// <returns>Runtime configuration of the signal</returns>
		public IoSignalConfiguration GetSignalConfiguration(string network, string device, string signal)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Gets the runtime configuration properties of an I/O signal (asynchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network the signal belongs to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device the signal is connected to, for example &quot;DRV_1&quot;</param>
		/// <param name="signal">Name of the signal, for example &quot;DRV1K1&quot;</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Runtime configuration of the signal</returns>
		public Task<IoSignalConfiguration> GetSignalConfigurationAsync(string network, string device, string signal, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Writes the value of an I/O signal (synchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network the signal belongs to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device the signal is connected to, for example &quot;DRV_1&quot;</param>
		/// <param name="signal">Name of the signal, for example &quot;DRV1K1&quot;</param>
		/// <param name="value">New logical value of the signal, 0 or 1 for a digital signal</param>
		/// <param name="logToEventLog">Whether the change is written to the event log of the controller</param>
		public void SetSignalValue(string network, string device, string signal, float value, bool logToEventLog = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Writes the value of an I/O signal (asynchronous)
		/// 
		/// </summary>
		/// <param name="network">Name of the network the signal belongs to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device the signal is connected to, for example &quot;DRV_1&quot;</param>
		/// <param name="signal">Name of the signal, for example &quot;DRV1K1&quot;</param>
		/// <param name="value">New logical value of the signal, 0 or 1 for a digital signal</param>
		/// <param name="logToEventLog">Whether the change is written to the event log of the controller</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetSignalValueAsync(string network, string device, string signal, float value, bool logToEventLog = false, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Writes the value of an I/O signal in &quot;queued delayed&quot; mode (synchronous)
		/// <p>The controller queues the write and applies it once the delay has elapsed.</p>
		/// 
		/// </summary>
		/// <param name="network">Name of the network the signal belongs to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device the signal is connected to, for example &quot;DRV_1&quot;</param>
		/// <param name="signal">Name of the signal, for example &quot;DRV1K1&quot;</param>
		/// <param name="value">New logical value of the signal, 0 or 1 for a digital signal</param>
		/// <param name="delay">Delay in milliseconds before the value is applied</param>
		/// <param name="logToEventLog">Whether the change is written to the event log of the controller</param>
		public void SetSignalValueDelayed(string network, string device, string signal, float value, int delay, bool logToEventLog = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Writes the value of an I/O signal in &quot;queued delayed&quot; mode (asynchronous)
		/// <p>The controller queues the write and applies it once the delay has elapsed.</p>
		/// 
		/// </summary>
		/// <param name="network">Name of the network the signal belongs to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device the signal is connected to, for example &quot;DRV_1&quot;</param>
		/// <param name="signal">Name of the signal, for example &quot;DRV1K1&quot;</param>
		/// <param name="value">New logical value of the signal, 0 or 1 for a digital signal</param>
		/// <param name="delay">Delay in milliseconds before the value is applied</param>
		/// <param name="logToEventLog">Whether the change is written to the event log of the controller</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetSignalValueDelayedAsync(string network, string device, string signal, float value, int delay, bool logToEventLog = false, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Inverts the value of an I/O signal (synchronous)
		/// <p>Only digital and group signals can be inverted.</p>
		/// 
		/// </summary>
		/// <param name="network">Name of the network the signal belongs to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device the signal is connected to, for example &quot;DRV_1&quot;</param>
		/// <param name="signal">Name of the signal, for example &quot;DRV1K1&quot;</param>
		/// <param name="value">Current logical value of the signal, which the controller requires even to invert it</param>
		/// <param name="logToEventLog">Whether the change is written to the event log of the controller</param>
		public void InvertSignal(string network, string device, string signal, float value, bool logToEventLog = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Inverts the value of an I/O signal (asynchronous)
		/// <p>Only digital and group signals can be inverted.</p>
		/// 
		/// </summary>
		/// <param name="network">Name of the network the signal belongs to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device the signal is connected to, for example &quot;DRV_1&quot;</param>
		/// <param name="signal">Name of the signal, for example &quot;DRV1K1&quot;</param>
		/// <param name="value">Current logical value of the signal, which the controller requires even to invert it</param>
		/// <param name="logToEventLog">Whether the change is written to the event log of the controller</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task InvertSignalAsync(string network, string device, string signal, float value, bool logToEventLog = false, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Pulses the value of an I/O signal (synchronous)
		/// <p>Only digital and group signals can be pulsed.</p>
		/// 
		/// </summary>
		/// <param name="network">Name of the network the signal belongs to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device the signal is connected to, for example &quot;DRV_1&quot;</param>
		/// <param name="signal">Name of the signal, for example &quot;DRV1K1&quot;</param>
		/// <param name="value">Logical value the signal is pulsed to, which the controller requires</param>
		/// <param name="pulses">Number of pulses</param>
		/// <param name="activePulseLength">Length in milliseconds of the active part of a pulse, null to use the controller default</param>
		/// <param name="passivePulseLength">Length in milliseconds of the passive part of a pulse, null to use the controller default</param>
		/// <param name="logToEventLog">Whether the change is written to the event log of the controller</param>
		public void PulseSignal(string network, string device, string signal, float value, int pulses, Nullable<int> activePulseLength = null, Nullable<int> passivePulseLength = null, bool logToEventLog = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Pulses the value of an I/O signal (asynchronous)
		/// <p>Only digital and group signals can be pulsed.</p>
		/// 
		/// </summary>
		/// <param name="network">Name of the network the signal belongs to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device the signal is connected to, for example &quot;DRV_1&quot;</param>
		/// <param name="signal">Name of the signal, for example &quot;DRV1K1&quot;</param>
		/// <param name="value">Logical value the signal is pulsed to, which the controller requires</param>
		/// <param name="pulses">Number of pulses</param>
		/// <param name="activePulseLength">Length in milliseconds of the active part of a pulse, null to use the controller default</param>
		/// <param name="passivePulseLength">Length in milliseconds of the passive part of a pulse, null to use the controller default</param>
		/// <param name="logToEventLog">Whether the change is written to the event log of the controller</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task PulseSignalAsync(string network, string device, string signal, float value, int pulses, Nullable<int> activePulseLength = null, Nullable<int> passivePulseLength = null, bool logToEventLog = false, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Pulses an I/O signal by toggling its current value (synchronous)
		/// <p>Only digital and group signals can be toggled.</p>
		/// 
		/// </summary>
		/// <param name="network">Name of the network the signal belongs to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device the signal is connected to, for example &quot;DRV_1&quot;</param>
		/// <param name="signal">Name of the signal, for example &quot;DRV1K1&quot;</param>
		/// <param name="value">Logical value the signal is pulsed to, which the controller requires</param>
		/// <param name="pulses">Number of pulses</param>
		/// <param name="activePulseLength">Length in milliseconds of the active part of a pulse, null to use the controller default</param>
		/// <param name="passivePulseLength">Length in milliseconds of the passive part of a pulse, null to use the controller default</param>
		/// <param name="logToEventLog">Whether the change is written to the event log of the controller</param>
		public void ToggleSignal(string network, string device, string signal, float value, int pulses, Nullable<int> activePulseLength = null, Nullable<int> passivePulseLength = null, bool logToEventLog = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Pulses an I/O signal by toggling its current value (asynchronous)
		/// <p>Only digital and group signals can be toggled.</p>
		/// 
		/// </summary>
		/// <param name="network">Name of the network the signal belongs to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device the signal is connected to, for example &quot;DRV_1&quot;</param>
		/// <param name="signal">Name of the signal, for example &quot;DRV1K1&quot;</param>
		/// <param name="value">Logical value the signal is pulsed to, which the controller requires</param>
		/// <param name="pulses">Number of pulses</param>
		/// <param name="activePulseLength">Length in milliseconds of the active part of a pulse, null to use the controller default</param>
		/// <param name="passivePulseLength">Length in milliseconds of the passive part of a pulse, null to use the controller default</param>
		/// <param name="logToEventLog">Whether the change is written to the event log of the controller</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task ToggleSignalAsync(string network, string device, string signal, float value, int pulses, Nullable<int> activePulseLength = null, Nullable<int> passivePulseLength = null, bool logToEventLog = false, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Simulates or stops simulating an I/O signal (synchronous)
		/// <p>A simulated signal keeps the logical value written by the client and no longer follows its physical value.</p>
		/// 
		/// </summary>
		/// <param name="network">Name of the network the signal belongs to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device the signal is connected to, for example &quot;DRV_1&quot;</param>
		/// <param name="signal">Name of the signal, for example &quot;DRV1K1&quot;</param>
		/// <param name="simulated">True to simulate the signal, false to stop simulating it</param>
		public void SetSignalState(string network, string device, string signal, bool simulated)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Simulates or stops simulating an I/O signal (asynchronous)
		/// <p>A simulated signal keeps the logical value written by the client and no longer follows its physical value.</p>
		/// 
		/// </summary>
		/// <param name="network">Name of the network the signal belongs to, for example &quot;Local&quot;</param>
		/// <param name="device">Name of the device the signal is connected to, for example &quot;DRV_1&quot;</param>
		/// <param name="signal">Name of the signal, for example &quot;DRV1K1&quot;</param>
		/// <param name="simulated">True to simulate the signal, false to stop simulating it</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetSignalStateAsync(string network, string device, string signal, bool simulated, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Searches the I/O signals matching the given criteria (synchronous)
		/// <p>The returned signals carry their name, type, category, logical value and logical state.
		/// Use <xref href="UnderAutomation.ABB.Rws.Services.IoService.SearchSignalsExtended(UnderAutomation.ABB.Rws.Data.IoSignalSearchCriteria%2cUnderAutomation.ABB.Rws.Data.IoSignalSearchCriteria%2cSystem.Nullable%7bSystem.Int32%7d%2cSystem.Nullable%7bSystem.Int32%7d)" data-throw-if-not-resolved="false"></xref> to also get their physical value, time stamps and write access level.</p>
		/// 
		/// </summary>
		/// <param name="criteria">Search criteria, null to match every signal</param>
		/// <param name="secondCriteria">Optional second criteria, a signal is returned only when it matches both</param>
		/// <param name="start">Index of the first returned signal, null to start at the first one</param>
		/// <param name="limit">Maximum number of returned signals, null to let the controller decide</param>
		/// <returns>I/O signals matching the criteria</returns>
		public IoSignalItem[] SearchSignals(IoSignalSearchCriteria criteria = null, IoSignalSearchCriteria secondCriteria = null, Nullable<int> start = null, Nullable<int> limit = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Searches the I/O signals matching the given criteria (asynchronous)
		/// <p>The returned signals carry their name, type, category, logical value and logical state.
		/// Use <xref href="UnderAutomation.ABB.Rws.Services.IoService.SearchSignalsExtendedAsync(UnderAutomation.ABB.Rws.Data.IoSignalSearchCriteria%2cUnderAutomation.ABB.Rws.Data.IoSignalSearchCriteria%2cSystem.Nullable%7bSystem.Int32%7d%2cSystem.Nullable%7bSystem.Int32%7d%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref> to also get their physical value, time stamps and write access level.</p>
		/// 
		/// </summary>
		/// <param name="criteria">Search criteria, null to match every signal</param>
		/// <param name="secondCriteria">Optional second criteria, a signal is returned only when it matches both</param>
		/// <param name="start">Index of the first returned signal, null to start at the first one</param>
		/// <param name="limit">Maximum number of returned signals, null to let the controller decide</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>I/O signals matching the criteria</returns>
		public Task<IoSignalItem[]> SearchSignalsAsync(IoSignalSearchCriteria criteria = null, IoSignalSearchCriteria secondCriteria = null, Nullable<int> start = null, Nullable<int> limit = null, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Searches the I/O signals matching the given criteria and returns their extended properties (synchronous)
		/// <p>In addition to <xref href="UnderAutomation.ABB.Rws.Services.IoService.SearchSignals(UnderAutomation.ABB.Rws.Data.IoSignalSearchCriteria%2cUnderAutomation.ABB.Rws.Data.IoSignalSearchCriteria%2cSystem.Nullable%7bSystem.Int32%7d%2cSystem.Nullable%7bSystem.Int32%7d)" data-throw-if-not-resolved="false"></xref>, the returned signals carry their physical value,
		/// quality, time stamps and write access level.</p>
		/// 
		/// </summary>
		/// <param name="criteria">Search criteria, null to match every signal</param>
		/// <param name="secondCriteria">Optional second criteria, a signal is returned only when it matches both</param>
		/// <param name="start">Index of the first returned signal, null to start at the first one</param>
		/// <param name="limit">Maximum number of returned signals, null to let the controller decide</param>
		/// <returns>I/O signals matching the criteria</returns>
		public IoSignalItem[] SearchSignalsExtended(IoSignalSearchCriteria criteria = null, IoSignalSearchCriteria secondCriteria = null, Nullable<int> start = null, Nullable<int> limit = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Searches the I/O signals matching the given criteria and returns their extended properties (asynchronous)
		/// <p>In addition to <xref href="UnderAutomation.ABB.Rws.Services.IoService.SearchSignalsAsync(UnderAutomation.ABB.Rws.Data.IoSignalSearchCriteria%2cUnderAutomation.ABB.Rws.Data.IoSignalSearchCriteria%2cSystem.Nullable%7bSystem.Int32%7d%2cSystem.Nullable%7bSystem.Int32%7d%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref>, the returned signals carry their physical value,
		/// quality, time stamps and write access level.</p>
		/// 
		/// </summary>
		/// <param name="criteria">Search criteria, null to match every signal</param>
		/// <param name="secondCriteria">Optional second criteria, a signal is returned only when it matches both</param>
		/// <param name="start">Index of the first returned signal, null to start at the first one</param>
		/// <param name="limit">Maximum number of returned signals, null to let the controller decide</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>I/O signals matching the criteria</returns>
		public Task<IoSignalItem[]> SearchSignalsExtendedAsync(IoSignalSearchCriteria criteria = null, IoSignalSearchCriteria secondCriteria = null, Nullable<int> start = null, Nullable<int> limit = null, CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Removes the simulation of every simulated I/O signal of the controller (synchronous)
		/// 
		/// </summary>
		public void UnblockSignals()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Removes the simulation of every simulated I/O signal of the controller (asynchronous)
		/// 
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task UnblockSignalsAsync(CancellationToken cancellationToken = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
