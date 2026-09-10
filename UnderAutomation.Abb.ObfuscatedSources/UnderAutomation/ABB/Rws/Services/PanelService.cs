//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.ABB.Rws.Data;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace UnderAutomation.ABB.Rws.Services {
	/// <summary>
	/// Panel Service - Exposes what an operator reads and acts on from the control panel of the controller:
	/// the controller state, the operating mode and its selector lock, the speed ratio, the collision detection
	/// state, the language of the controller and its restart.
	/// None of these resources is available while the controller runs in bootserver mode.
	/// </summary>
	public class PanelService {

		/// <summary>
		/// Gets the state of the controller (synchronous)
		/// </summary>
		/// <returns>State of the controller, <xref href="UnderAutomation.ABB.Rws.Data.ControllerState.Unknown" data-throw-if-not-resolved="false"></xref> when it reports a state this library does not know</returns>
		public ControllerState GetControllerState()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the state of the controller (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>State of the controller, <xref href="UnderAutomation.ABB.Rws.Data.ControllerState.Unknown" data-throw-if-not-resolved="false"></xref> when it reports a state this library does not know</returns>
		public Task<ControllerState> GetControllerStateAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Turns the motors of the robot on or off (synchronous)
		/// </summary>
		/// <param name="state">State to switch to, which can only be <xref href="UnderAutomation.ABB.Rws.Data.ControllerState.MotorsOn" data-throw-if-not-resolved="false"></xref> or <xref href="UnderAutomation.ABB.Rws.Data.ControllerState.MotorsOff" data-throw-if-not-resolved="false"></xref>.
		/// Every other state is reached by the controller on its own and cannot be requested.</param>
		public void SetControllerState(ControllerState state)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Turns the motors of the robot on or off (asynchronous)
		/// </summary>
		/// <param name="state">State to switch to, which can only be <xref href="UnderAutomation.ABB.Rws.Data.ControllerState.MotorsOn" data-throw-if-not-resolved="false"></xref> or <xref href="UnderAutomation.ABB.Rws.Data.ControllerState.MotorsOff" data-throw-if-not-resolved="false"></xref>.
		/// Every other state is reached by the controller on its own and cannot be requested.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetControllerStateAsync(ControllerState state, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the operating mode the controller runs in (synchronous)
		/// </summary>
		/// <returns>Operating mode, <xref href="UnderAutomation.ABB.Rws.Data.OperationMode.Unknown" data-throw-if-not-resolved="false"></xref> when the controller reports a mode this library does not know</returns>
		public OperationMode GetOperationMode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the operating mode the controller runs in (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Operating mode, <xref href="UnderAutomation.ABB.Rws.Data.OperationMode.Unknown" data-throw-if-not-resolved="false"></xref> when the controller reports a mode this library does not know</returns>
		public Task<OperationMode> GetOperationModeAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Confirms a pending operating mode change (synchronous)
		/// 
		/// <p>The controller waits for this confirmation whenever the mode selector is turned, unless it is
		/// configured to acknowledge the change on its own.</p>
		/// </summary>
		/// <param name="acknowledgement">Change to confirm</param>
		public void AcknowledgeOperationMode(OperationModeAcknowledgement acknowledgement)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Confirms a pending operating mode change (asynchronous)
		/// 
		/// <p>The controller waits for this confirmation whenever the mode selector is turned, unless it is
		/// configured to acknowledge the change on its own.</p>
		/// </summary>
		/// <param name="acknowledgement">Change to confirm</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task AcknowledgeOperationModeAsync(OperationModeAcknowledgement acknowledgement, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the lock state of the operating mode selector (synchronous)
		/// </summary>
		/// <returns>Lock state, <xref href="UnderAutomation.ABB.Rws.Data.OperationModeLockState.Unknown" data-throw-if-not-resolved="false"></xref> when the controller reports a state this library does not know</returns>
		public OperationModeLockState GetOperationModeLockState()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the lock state of the operating mode selector (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Lock state, <xref href="UnderAutomation.ABB.Rws.Data.OperationModeLockState.Unknown" data-throw-if-not-resolved="false"></xref> when the controller reports a state this library does not know</returns>
		public Task<OperationModeLockState> GetOperationModeLockStateAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Locks the operating mode selector with a pin code (synchronous)
		/// </summary>
		/// <param name="pin">Four digit pin code, which will be needed again to unlock the selector</param>
		/// <param name="permanent">When true, the selector is locked permanently, which requires the key-less mode selector grant.
		/// When false (default), the lock can be released with <xref href="UnderAutomation.ABB.Rws.Services.PanelService.UnlockOperationMode(System.String)" data-throw-if-not-resolved="false"></xref>.</param>
		public void LockOperationMode(string pin, bool permanent = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Locks the operating mode selector with a pin code (asynchronous)
		/// </summary>
		/// <param name="pin">Four digit pin code, which will be needed again to unlock the selector</param>
		/// <param name="permanent">When true, the selector is locked permanently, which requires the key-less mode selector grant.
		/// When false (default), the lock can be released with <xref href="UnderAutomation.ABB.Rws.Services.PanelService.UnlockOperationModeAsync(System.String%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref>.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task LockOperationModeAsync(string pin, bool permanent = false, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Releases the lock of the operating mode selector (synchronous)
		/// </summary>
		/// <param name="pin">Four digit pin code the selector was locked with</param>
		public void UnlockOperationMode(string pin)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Releases the lock of the operating mode selector (asynchronous)
		/// </summary>
		/// <param name="pin">Four digit pin code the selector was locked with</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task UnlockOperationModeAsync(string pin, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the speed ratio the controller runs the programs at (synchronous)
		/// </summary>
		/// <returns>Speed ratio, as a percentage between 0 and 100</returns>
		public int GetSpeedRatio()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the speed ratio the controller runs the programs at (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Speed ratio, as a percentage between 0 and 100</returns>
		public Task<int> GetSpeedRatioAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets the speed ratio the controller runs the programs at (synchronous)
		/// 
		/// <p>Only accepted while the controller runs in automatic mode.</p>
		/// </summary>
		/// <param name="speedRatio">Speed ratio, as a percentage between 0 and 100</param>
		/// <param name="useImplicitMastership">A connection established with version 2 requires mastership to change the speed ratio. When true (default),
		/// mastership is taken implicitly for this request. Ignored on a version 1 connection, which needs none.</param>
		public void SetSpeedRatio(int speedRatio, bool useImplicitMastership = true)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Sets the speed ratio the controller runs the programs at (asynchronous)
		/// 
		/// <p>Only accepted while the controller runs in automatic mode.</p>
		/// </summary>
		/// <param name="speedRatio">Speed ratio, as a percentage between 0 and 100</param>
		/// <param name="useImplicitMastership">A connection established with version 2 requires mastership to change the speed ratio. When true (default),
		/// mastership is taken implicitly for this request. Ignored on a version 1 connection, which needs none.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetSpeedRatioAsync(int speedRatio, bool useImplicitMastership = true, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the collision detection state of the controller (synchronous)
		/// </summary>
		/// <returns>Collision detection state, <xref href="UnderAutomation.ABB.Rws.Data.CollisionDetectionState.Unknown" data-throw-if-not-resolved="false"></xref> when the controller reports
		///             a state this library does not know</returns>
		public CollisionDetectionState GetCollisionDetectionState()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the collision detection state of the controller (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Collision detection state, <xref href="UnderAutomation.ABB.Rws.Data.CollisionDetectionState.Unknown" data-throw-if-not-resolved="false"></xref> when the controller reports
		///             a state this library does not know</returns>
		public Task<CollisionDetectionState> GetCollisionDetectionStateAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets the language the controller reports its messages in (synchronous)
		/// </summary>
		/// <param name="languageCode">Two letter language code, for example "en", "sv" or "de"</param>
		public void SetLanguage(string languageCode)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Sets the language the controller reports its messages in (asynchronous)
		/// </summary>
		/// <param name="languageCode">Two letter language code, for example "en", "sv" or "de"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetLanguageAsync(string languageCode, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Restarts the controller (synchronous)
		/// </summary>
		/// <param name="mode">How the controller restarts. The control panel accepts <xref href="UnderAutomation.ABB.Rws.Data.ControllerRestartMode.Restart" data-throw-if-not-resolved="false"></xref>,
		/// <xref href="UnderAutomation.ABB.Rws.Data.ControllerRestartMode.IStart" data-throw-if-not-resolved="false"></xref>, <xref href="UnderAutomation.ABB.Rws.Data.ControllerRestartMode.PStart" data-throw-if-not-resolved="false"></xref> and
		/// <xref href="UnderAutomation.ABB.Rws.Data.ControllerRestartMode.BStart" data-throw-if-not-resolved="false"></xref>; use <xref href="UnderAutomation.ABB.Rws.Services.ControllerService.Restart(UnderAutomation.ABB.Rws.Data.ControllerRestartMode%2cSystem.Boolean)" data-throw-if-not-resolved="false"></xref> for the others.</param>
		/// <param name="useImplicitMastership">A connection established with version 2 requires mastership on all domains to restart the controller. When true
		/// (default), mastership is taken implicitly for this request. Ignored on a version 1 connection, which needs none.</param>
		public void Restart(ControllerRestartMode mode, bool useImplicitMastership = true)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Restarts the controller (asynchronous)
		/// </summary>
		/// <param name="mode">How the controller restarts. The control panel accepts <xref href="UnderAutomation.ABB.Rws.Data.ControllerRestartMode.Restart" data-throw-if-not-resolved="false"></xref>,
		/// <xref href="UnderAutomation.ABB.Rws.Data.ControllerRestartMode.IStart" data-throw-if-not-resolved="false"></xref>, <xref href="UnderAutomation.ABB.Rws.Data.ControllerRestartMode.PStart" data-throw-if-not-resolved="false"></xref> and
		/// <xref href="UnderAutomation.ABB.Rws.Data.ControllerRestartMode.BStart" data-throw-if-not-resolved="false"></xref>; use <xref href="UnderAutomation.ABB.Rws.Services.ControllerService.RestartAsync(UnderAutomation.ABB.Rws.Data.ControllerRestartMode%2cSystem.Boolean%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref> for the others.</param>
		/// <param name="useImplicitMastership">A connection established with version 2 requires mastership on all domains to restart the controller. When true
		/// (default), mastership is taken implicitly for this request. Ignored on a version 1 connection, which needs none.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task RestartAsync(ControllerRestartMode mode, bool useImplicitMastership = true, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
