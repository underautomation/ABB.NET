//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.ABB.Rws.Data;
using System.Threading;
using System.Threading.Tasks;
using System;
using UnderAutomation.ABB.Common;

namespace UnderAutomation.ABB.Rws.Services {
	/// <summary>
	/// RAPID Service - Everything about the program the robot runs: the tasks it is split into, the modules
	/// and the source they hold, the symbols the program declares and the values they carry, where the
	/// program pointer stands, and starting, stopping and stepping the execution.
	/// 
	/// <p>None of these resources is available while the controller runs in bootserver mode.</p>
	/// <p>Most of the writes need the RAPID mastership, which <code>RwsClient.Mastership</code> takes.</p>
	/// </summary>
	public class RapidService {

		/// <summary>
		/// Gets whether the controller is executing RAPID code, and how many cycles it is set to run
		/// (synchronous)
		/// </summary>
		/// <returns>Execution state of the controller</returns>
		public RapidExecutionInfo GetExecutionState()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets whether the controller is executing RAPID code, and how many cycles it is set to run
		/// (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Execution state of the controller</returns>
		public Task<RapidExecutionInfo> GetExecutionStateAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Starts executing the RAPID program from where the program pointer stands (synchronous)
		/// 
		/// <p>The controller has to be in automatic mode with the motors on, or in manual mode with the
		/// enabling device held. Reset the program pointer first with <xref href="UnderAutomation.ABB.Rws.Services.RapidService.ResetProgramPointer" data-throw-if-not-resolved="false"></xref> to
		/// start from the beginning.</p>
		/// </summary>
		/// <param name="regain">What the robot does about the distance between where it stands and where the
		///             path it resumes expects it to be</param>
		/// <param name="executionMode">How far the program advances before stopping again</param>
		/// <param name="cycle">How many times the program runs before stopping</param>
		/// <param name="condition">Condition the controller checks before it starts</param>
		/// <param name="stopAtBreakpoint">Whether execution stops when it reaches a breakpoint</param>
		/// <param name="allTasksBySelection">Whether every task the selection panel has enabled is started,
		///             rather than the normal tasks only</param>
		public void Start(RapidRegainMode regain = RapidRegainMode.Continue, RapidExecutionMode executionMode = RapidExecutionMode.Continue, RapidExecutionCycle cycle = RapidExecutionCycle.Forever, RapidStartCondition condition = RapidStartCondition.None, bool stopAtBreakpoint = false, bool allTasksBySelection = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Starts executing the RAPID program from where the program pointer stands (asynchronous)
		/// 
		/// <p>The controller has to be in automatic mode with the motors on, or in manual mode with the
		/// enabling device held. Reset the program pointer first with <xref href="UnderAutomation.ABB.Rws.Services.RapidService.ResetProgramPointerAsync(System.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref>
		/// to start from the beginning.</p>
		/// </summary>
		/// <param name="regain">What the robot does about the distance between where it stands and where the
		///             path it resumes expects it to be</param>
		/// <param name="executionMode">How far the program advances before stopping again</param>
		/// <param name="cycle">How many times the program runs before stopping</param>
		/// <param name="condition">Condition the controller checks before it starts</param>
		/// <param name="stopAtBreakpoint">Whether execution stops when it reaches a breakpoint</param>
		/// <param name="allTasksBySelection">Whether every task the selection panel has enabled is started,
		///             rather than the normal tasks only</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task StartAsync(RapidRegainMode regain = RapidRegainMode.Continue, RapidExecutionMode executionMode = RapidExecutionMode.Continue, RapidExecutionCycle cycle = RapidExecutionCycle.Forever, RapidStartCondition condition = RapidStartCondition.None, bool stopAtBreakpoint = false, bool allTasksBySelection = false, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Starts executing from the production entry point of the program rather than from where the program
		/// pointer stands (synchronous)
		/// </summary>
		public void StartFromProductionEntry()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Starts executing from the production entry point of the program rather than from where the program
		/// pointer stands (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task StartFromProductionEntryAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Stops the RAPID execution (synchronous)
		/// </summary>
		/// <param name="stopMode">How abruptly the execution is stopped</param>
		/// <param name="scope">Whether the command applies to the normal tasks only or to every task</param>
		public void Stop(RapidStopMode stopMode = RapidStopMode.Stop, RapidTaskScope scope = RapidTaskScope.Normal)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Stops the RAPID execution (asynchronous)
		/// </summary>
		/// <param name="stopMode">How abruptly the execution is stopped</param>
		/// <param name="scope">Whether the command applies to the normal tasks only or to every task</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task StopAsync(RapidStopMode stopMode = RapidStopMode.Stop, RapidTaskScope scope = RapidTaskScope.Normal, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Moves the program pointer of every task back to the entry point of its program (synchronous)
		/// </summary>
		public void ResetProgramPointer()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Moves the program pointer of every task back to the entry point of its program (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task ResetProgramPointerAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets how many times the program runs before stopping (synchronous)
		/// </summary>
		/// <param name="cycle">Number of cycles to run; only <xref href="UnderAutomation.ABB.Rws.Data.RapidExecutionCycle.Once" data-throw-if-not-resolved="false"></xref> and
		///             <xref href="UnderAutomation.ABB.Rws.Data.RapidExecutionCycle.Forever" data-throw-if-not-resolved="false"></xref> are accepted</param>
		public void SetExecutionCycle(RapidExecutionCycle cycle)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Sets how many times the program runs before stopping (asynchronous)
		/// </summary>
		/// <param name="cycle">Number of cycles to run; only <xref href="UnderAutomation.ABB.Rws.Data.RapidExecutionCycle.Once" data-throw-if-not-resolved="false"></xref> and
		///             <xref href="UnderAutomation.ABB.Rws.Data.RapidExecutionCycle.Forever" data-throw-if-not-resolved="false"></xref> are accepted</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetExecutionCycleAsync(RapidExecutionCycle cycle, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Drives the hold-to-run control that lets the program run in manual mode (synchronous)
		/// 
		/// <p>Send <xref href="UnderAutomation.ABB.Rws.Data.RapidHoldToRunState.Press" data-throw-if-not-resolved="false"></xref> to allow execution to start, then
		/// <xref href="UnderAutomation.ABB.Rws.Data.RapidHoldToRunState.Held" data-throw-if-not-resolved="false"></xref> about every two seconds to keep it running; the controller
		/// stops the program as soon as it stops hearing from the client. Send
		/// <xref href="UnderAutomation.ABB.Rws.Data.RapidHoldToRunState.Release" data-throw-if-not-resolved="false"></xref> to stop it at once.</p>
		/// </summary>
		/// <param name="state">State to put the control in</param>
		public void SetHoldToRun(RapidHoldToRunState state)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Drives the hold-to-run control that lets the program run in manual mode (asynchronous)
		/// 
		/// <p>Send <xref href="UnderAutomation.ABB.Rws.Data.RapidHoldToRunState.Press" data-throw-if-not-resolved="false"></xref> to allow execution to start, then
		/// <xref href="UnderAutomation.ABB.Rws.Data.RapidHoldToRunState.Held" data-throw-if-not-resolved="false"></xref> about every two seconds to keep it running; the controller
		/// stops the program as soon as it stops hearing from the client. Send
		/// <xref href="UnderAutomation.ABB.Rws.Data.RapidHoldToRunState.Release" data-throw-if-not-resolved="false"></xref> to stop it at once.</p>
		/// </summary>
		/// <param name="state">State to put the control in</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetHoldToRunAsync(RapidHoldToRunState state, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the task selection panel: which tasks are selected, and which of them an operator is allowed
		/// to change the selection of (synchronous)
		/// </summary>
		/// <returns>One entry per task the panel shows</returns>
		public RapidTaskSelectionItem[] GetTaskSelection()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the task selection panel: which tasks are selected, and which of them an operator is allowed
		/// to change the selection of (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>One entry per task the panel shows</returns>
		public Task<RapidTaskSelectionItem[]> GetTaskSelectionAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the I/O signals a running RAPID program has given an alias to (synchronous)
		/// </summary>
		/// <param name="start">Index of the first alias to return, null to start from the beginning</param>
		/// <param name="limit">Maximum number of aliases to return, null to let the controller decide</param>
		/// <returns>One entry per alias, empty when no loaded program declares any</returns>
		public RapidAliasIoItem[] GetAliasIo(int? start = null, int? limit = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the I/O signals a running RAPID program has given an alias to (asynchronous)
		/// </summary>
		/// <param name="start">Index of the first alias to return, null to start from the beginning</param>
		/// <param name="limit">Maximum number of aliases to return, null to let the controller decide</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>One entry per alias, empty when no loaded program declares any</returns>
		public Task<RapidAliasIoItem[]> GetAliasIoAsync(int? start = null, int? limit = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the modules loaded into a task (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <returns>One entry per module</returns>
		public RapidModuleItem[] GetModules(string task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the modules loaded into a task (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>One entry per module</returns>
		public Task<RapidModuleItem[]> GetModulesAsync(string task, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the file a module came from and the properties declared on it (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <returns>State of the module</returns>
		public RapidModuleInfo GetModule(string task, string module)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the file a module came from and the properties declared on it (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>State of the module</returns>
		public Task<RapidModuleInfo> GetModuleAsync(string task, string module, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the counter the controller increments whenever a module changes (synchronous)
		/// 
		/// <p>Comparing it with what a previous reading gave is cheaper than fetching the source again to
		/// find out that nothing changed.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <returns>Change counter of the module</returns>
		public int GetModuleChangeCount(string task, string module)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the counter the controller increments whenever a module changes (asynchronous)
		/// 
		/// <p>Comparing it with what a previous reading gave is cheaper than fetching the source again to
		/// find out that nothing changed.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Change counter of the module</returns>
		public Task<int> GetModuleChangeCountAsync(string task, string module, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets how many lines and columns the source of a module holds (synchronous)
		/// 
		/// <p>This is what it takes to ask for the whole of it with <xref href="UnderAutomation.ABB.Rws.Services.RapidService.GetModuleTextRange(System.String%2cSystem.String%2cSystem.Int32%2cSystem.Int32%2cSystem.Int32%2cSystem.Int32)" data-throw-if-not-resolved="false"></xref>.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <returns>Size of the module</returns>
		public RapidModuleExtension GetModuleExtension(string task, string module)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets how many lines and columns the source of a module holds (asynchronous)
		/// 
		/// <p>This is what it takes to ask for the whole of it with <xref href="UnderAutomation.ABB.Rws.Services.RapidService.GetModuleTextRangeAsync(System.String%2cSystem.String%2cSystem.Int32%2cSystem.Int32%2cSystem.Int32%2cSystem.Int32%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref>.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Size of the module</returns>
		public Task<RapidModuleExtension> GetModuleExtensionAsync(string task, string module, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the source of a module (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <returns>Source of the module and the counters that go with it</returns>
		public RapidModuleText GetModuleText(string task, string module)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the source of a module (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Source of the module and the counters that go with it</returns>
		public Task<RapidModuleText> GetModuleTextAsync(string task, string module, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Replaces the whole source of a module (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="text">New source of the module</param>
		public void SetModuleText(string task, string module, string text)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Replaces the whole source of a module (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="text">New source of the module</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetModuleTextAsync(string task, string module, string text, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets a range of the source of a module (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="startRow">Line the range starts at, counted from 1</param>
		/// <param name="startColumn">Column the range starts at, counted from 1</param>
		/// <param name="endRow">Line the range ends at</param>
		/// <param name="endColumn">Column the range ends at</param>
		/// <returns>The requested source</returns>
		public string GetModuleTextRange(string task, string module, int startRow, int startColumn, int endRow, int endColumn)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets a range of the source of a module (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="startRow">Line the range starts at, counted from 1</param>
		/// <param name="startColumn">Column the range starts at, counted from 1</param>
		/// <param name="endRow">Line the range ends at</param>
		/// <param name="endColumn">Column the range ends at</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The requested source</returns>
		public Task<string> GetModuleTextRangeAsync(string task, string module, int startRow, int startColumn, int endRow, int endColumn, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes text into a range of the source of a module (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="replaceMode">Whether the text replaces the range or is inserted around it</param>
		/// <param name="queryMode">How hard the controller tries when the change would invalidate the
		///             program pointer</param>
		/// <param name="startRow">Line the range starts at, counted from 1</param>
		/// <param name="startColumn">Column the range starts at, counted from 1</param>
		/// <param name="endRow">Line the range ends at</param>
		/// <param name="endColumn">Column the range ends at</param>
		/// <param name="text">Text to write</param>
		/// <returns>What the controller did with the change, including the name the module ended up with</returns>
		public RapidSetTextRangeResult SetModuleTextRange(string task, string module, RapidTextReplaceMode replaceMode, RapidTextQueryMode queryMode, int startRow, int startColumn, int endRow, int endColumn, string text)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes text into a range of the source of a module (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="replaceMode">Whether the text replaces the range or is inserted around it</param>
		/// <param name="queryMode">How hard the controller tries when the change would invalidate the
		///             program pointer</param>
		/// <param name="startRow">Line the range starts at, counted from 1</param>
		/// <param name="startColumn">Column the range starts at, counted from 1</param>
		/// <param name="endRow">Line the range ends at</param>
		/// <param name="endColumn">Column the range ends at</param>
		/// <param name="text">Text to write</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>What the controller did with the change, including the name the module ended up with</returns>
		public Task<RapidSetTextRangeResult> SetModuleTextRangeAsync(string task, string module, RapidTextReplaceMode replaceMode, RapidTextQueryMode queryMode, int startRow, int startColumn, int endRow, int endColumn, string text, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Finds where a piece of text sits in the source of a module (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="text">Text to look for</param>
		/// <param name="startRow">Line to start looking from, counted from 1</param>
		/// <param name="startColumn">Column to start looking from, counted from 1</param>
		/// <returns>Where the text was found; its <code>Found</code> property is false when it was not</returns>
		public RapidTextPosition SearchModuleText(string task, string module, string text, int startRow = 1, int startColumn = 1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Finds where a piece of text sits in the source of a module (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="text">Text to look for</param>
		/// <param name="startRow">Line to start looking from, counted from 1</param>
		/// <param name="startColumn">Column to start looking from, counted from 1</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Where the text was found; its <code>Found</code> property is false when it was not</returns>
		public Task<RapidTextPosition> SearchModuleTextAsync(string task, string module, string text, int startRow = 1, int startColumn = 1, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets whether the persistent variables of a module are kept synchronized with the other tasks
		/// declaring them (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <returns>True when the persistent variables are synchronized</returns>
		public bool GetSyncPersStatus(string task, string module)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets whether the persistent variables of a module are kept synchronized with the other tasks
		/// declaring them (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>True when the persistent variables are synchronized</returns>
		public Task<bool> GetSyncPersStatusAsync(string task, string module, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Synchronizes the persistent variables of a module with the other tasks declaring them (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		public void SyncPersistentVariables(string task, string module)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Synchronizes the persistent variables of a module with the other tasks declaring them (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SyncPersistentVariablesAsync(string task, string module, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Saves a module to the file system of the controller (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module to save</param>
		/// <param name="name">Name to save it under; the controller appends the module extension itself</param>
		/// <param name="path">Directory to save it into, which may use the environment variables of the
		///             controller such as its home or temporary directory</param>
		public void SaveModule(string task, string module, string name, string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Saves a module to the file system of the controller (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module to save</param>
		/// <param name="name">Name to save it under; the controller appends the module extension itself</param>
		/// <param name="path">Directory to save it into, which may use the environment variables of the
		///             controller such as its home or temporary directory</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SaveModuleAsync(string task, string module, string name, string path, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets which of the requested properties may be declared on a module (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="attributes">Properties to ask about</param>
		/// <returns>The properties of the request the module accepts</returns>
		public RapidModuleAttribute[] GetPossibleModuleAttributes(string task, string module, params RapidModuleAttribute[] attributes)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets which of the requested properties may be declared on a module (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="attributes">Properties to ask about</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The properties of the request the module accepts</returns>
		public Task<RapidModuleAttribute[]> GetPossibleModuleAttributesAsync(string task, string module, RapidModuleAttribute[] attributes, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the declaration the controller finds at a position of a module (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="row">Line to look at, counted from 1</param>
		/// <param name="column">Column to look at, counted from 1</param>
		/// <returns>The declaration, null when there is none at that position</returns>
		public RapidModuleSymbol GetModuleSymbol(string task, string module, int row, int column)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the declaration the controller finds at a position of a module (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="row">Line to look at, counted from 1</param>
		/// <param name="column">Column to look at, counted from 1</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The declaration, null when there is none at that position</returns>
		public Task<RapidModuleSymbol> GetModuleSymbolAsync(string task, string module, int row, int column, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the routine the controller finds called at a position of a module (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="row">Line to look at, counted from 1</param>
		/// <param name="column">Column to look at, counted from 1</param>
		/// <returns>The routine called at that position</returns>
		public RapidRoutineInfo GetRoutine(string task, string module, int row, int column)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the routine the controller finds called at a position of a module (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="row">Line to look at, counted from 1</param>
		/// <param name="column">Column to look at, counted from 1</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The routine called at that position</returns>
		public Task<RapidRoutineInfo> GetRoutineAsync(string task, string module, int row, int column, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the arguments of the routine call found at a position of a module (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="row">Line of the call, counted from 1</param>
		/// <param name="column">Column of the call, counted from 1</param>
		/// <param name="mark">Index of the first argument to return, null to start from the beginning</param>
		/// <param name="limit">Maximum number of arguments to return, null to let the controller decide</param>
		/// <returns>One entry per argument</returns>
		public RapidRoutineArgument[] GetRoutineArguments(string task, string module, int row, int column, int? mark = null, int? limit = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the arguments of the routine call found at a position of a module (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="row">Line of the call, counted from 1</param>
		/// <param name="column">Column of the call, counted from 1</param>
		/// <param name="mark">Index of the first argument to return, null to start from the beginning</param>
		/// <param name="limit">Maximum number of arguments to return, null to let the controller decide</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>One entry per argument</returns>
		public Task<RapidRoutineArgument[]> GetRoutineArgumentsAsync(string task, string module, int row, int column, int? mark = null, int? limit = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the template the controller suggests for an instruction or a data type: the arguments to
		/// write and the values to write them with (synchronous)
		/// 
		/// <p>This is what an editor uses to insert a complete, valid instruction rather than a bare
		/// keyword.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module the instruction would be inserted into</param>
		/// <param name="name">Name of the instruction or of the data type, for example "MoveJ"</param>
		/// <param name="isDataType">Whether the name is a data type rather than an instruction</param>
		/// <param name="row">Line the instruction would be inserted at, null to leave it to the controller</param>
		/// <param name="column">Column the instruction would be inserted at, null to leave it to the controller</param>
		/// <param name="parameterNumber">Parameter to override the suggestion of, null to take the default</param>
		/// <param name="alternativeNumber">Alternative of that parameter, null to take the default</param>
		/// <returns>The suggested template</returns>
		public RapidInstructionTemplate GetInstructionTemplate(string task, string module, string name, bool isDataType = false, int? row = null, int? column = null, int? parameterNumber = null, int? alternativeNumber = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the template the controller suggests for an instruction or a data type: the arguments to
		/// write and the values to write them with (asynchronous)
		/// 
		/// <p>This is what an editor uses to insert a complete, valid instruction rather than a bare
		/// keyword.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module the instruction would be inserted into</param>
		/// <param name="name">Name of the instruction or of the data type, for example "MoveJ"</param>
		/// <param name="isDataType">Whether the name is a data type rather than an instruction</param>
		/// <param name="row">Line the instruction would be inserted at, null to leave it to the controller</param>
		/// <param name="column">Column the instruction would be inserted at, null to leave it to the controller</param>
		/// <param name="parameterNumber">Parameter to override the suggestion of, null to take the default</param>
		/// <param name="alternativeNumber">Alternative of that parameter, null to take the default</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The suggested template</returns>
		public Task<RapidInstructionTemplate> GetInstructionTemplateAsync(string task, string module, string name, bool isDataType = false, int? row = null, int? column = null, int? parameterNumber = null, int? alternativeNumber = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the parts a RAPID object is made of and where each of them sits in the source (synchronous)
		/// 
		/// <p>Pass the whole span of the object to get its parts; an editor uses this to know where the
		/// name, the attributes and the declaration lists of a module begin and end.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="startLine">Line the object starts at, counted from 1</param>
		/// <param name="startColumn">Column the object starts at, counted from 1</param>
		/// <param name="endLine">Line the object ends at</param>
		/// <param name="endColumn">Column the object ends at</param>
		/// <returns>The parts of the object</returns>
		public RapidObjectChild GetObjectChildren(string task, string module, int startLine, int startColumn, int endLine, int endColumn)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the parts a RAPID object is made of and where each of them sits in the source (asynchronous)
		/// 
		/// <p>Pass the whole span of the object to get its parts; an editor uses this to know where the
		/// name, the attributes and the declaration lists of a module begin and end.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="startLine">Line the object starts at, counted from 1</param>
		/// <param name="startColumn">Column the object starts at, counted from 1</param>
		/// <param name="endLine">Line the object ends at</param>
		/// <param name="endColumn">Column the object ends at</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The parts of the object</returns>
		public Task<RapidObjectChild> GetObjectChildrenAsync(string task, string module, int startLine, int startColumn, int endLine, int endColumn, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets how many motion instructions of a range can have their position rewritten to where the robot
		/// currently stands (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="startRow">Line the range starts at, counted from 1</param>
		/// <param name="startColumn">Column the range starts at, counted from 1</param>
		/// <param name="endRow">Line the range ends at</param>
		/// <param name="endColumn">Column the range ends at</param>
		/// <returns>How many instructions can be rewritten, and which range they cover</returns>
		public RapidModifiablePositions GetModifiablePositions(string task, string module, int startRow, int startColumn, int endRow, int endColumn)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets how many motion instructions of a range can have their position rewritten to where the robot
		/// currently stands (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="startRow">Line the range starts at, counted from 1</param>
		/// <param name="startColumn">Column the range starts at, counted from 1</param>
		/// <param name="endRow">Line the range ends at</param>
		/// <param name="endColumn">Column the range ends at</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>How many instructions can be rewritten, and which range they cover</returns>
		public Task<RapidModifiablePositions> GetModifiablePositionsAsync(string task, string module, int startRow, int startColumn, int endRow, int endColumn, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets every motion instruction of the system whose position can be rewritten to where the robot
		/// currently stands, wherever in whichever task it sits (synchronous)
		/// </summary>
		/// <returns>One entry per instruction, empty when the controller found none</returns>
		public RapidModifiablePositionItem[] GetAllModifiablePositions()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets every motion instruction of the system whose position can be rewritten to where the robot
		/// currently stands, wherever in whichever task it sits (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>One entry per instruction, empty when the controller found none</returns>
		public Task<RapidModifiablePositionItem[]> GetAllModifiablePositionsAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Rewrites the positions of the motion instructions of a range to where the robot currently stands
		/// (synchronous)
		/// 
		/// <p>This is the teaching gesture: jog the robot where it should go, then write that position
		/// back into the program.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="startRow">Line the range starts at, counted from 1</param>
		/// <param name="startColumn">Column the range starts at, counted from 1</param>
		/// <param name="endRow">Line the range ends at</param>
		/// <param name="endColumn">Column the range ends at</param>
		/// <param name="checkLimits">Whether the controller refuses a position outside the working range</param>
		/// <param name="checkDeactivatedAxes">Whether the controller refuses to rewrite an axis that is deactivated</param>
		/// <param name="allowDeactivated">Whether a deactivated axis is rewritten anyway</param>
		public void ModifyPosition(string task, string module, int startRow, int startColumn, int endRow, int endColumn, bool checkLimits = true, bool checkDeactivatedAxes = true, bool allowDeactivated = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Rewrites the positions of the motion instructions of a range to where the robot currently stands
		/// (asynchronous)
		/// 
		/// <p>This is the teaching gesture: jog the robot where it should go, then write that position
		/// back into the program.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module, for example "MainModule"</param>
		/// <param name="startRow">Line the range starts at, counted from 1</param>
		/// <param name="startColumn">Column the range starts at, counted from 1</param>
		/// <param name="endRow">Line the range ends at</param>
		/// <param name="endColumn">Column the range ends at</param>
		/// <param name="checkLimits">Whether the controller refuses a position outside the working range</param>
		/// <param name="checkDeactivatedAxes">Whether the controller refuses to rewrite an axis that is deactivated</param>
		/// <param name="allowDeactivated">Whether a deactivated axis is rewritten anyway</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task ModifyPositionAsync(string task, string module, int startRow, int startColumn, int endRow, int endColumn, bool checkLimits = true, bool checkDeactivatedAxes = true, bool allowDeactivated = false, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Rewrites the positions of every motion instruction of the system that can be rewritten, to where
		/// the robot currently stands (synchronous)
		/// </summary>
		/// <param name="checkLimits">Whether the controller refuses a position outside the working range</param>
		/// <param name="checkDeactivatedAxes">Whether the controller refuses to rewrite an axis that is deactivated</param>
		public void ModifyAllPositions(bool checkLimits = true, bool checkDeactivatedAxes = true)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Rewrites the positions of every motion instruction of the system that can be rewritten, to where
		/// the robot currently stands (asynchronous)
		/// </summary>
		/// <param name="checkLimits">Whether the controller refuses a position outside the working range</param>
		/// <param name="checkDeactivatedAxes">Whether the controller refuses to rewrite an axis that is deactivated</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task ModifyAllPositionsAsync(bool checkLimits = true, bool checkDeactivatedAxes = true, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets where the tool of a task currently stands, as a position and an orientation (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="tool">Name of the tool to express the position in, null to use the one the task is
		///             currently using</param>
		/// <param name="workObject">Name of the work object to express the position in, null to use the one
		///             the task is currently using</param>
		/// <returns>Position, orientation, configuration and external axes of the tool</returns>
		public RobTarget GetRobTarget(string task, string tool = null, string workObject = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets where the tool of a task currently stands, as a position and an orientation (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="tool">Name of the tool to express the position in, null to use the one the task is
		///             currently using</param>
		/// <param name="workObject">Name of the work object to express the position in, null to use the one
		///             the task is currently using</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Position, orientation, configuration and external axes of the tool</returns>
		public Task<RobTarget> GetRobTargetAsync(string task, string tool = null, string workObject = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the joint values of the robot of a task (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <returns>Values of the six robot axes and of the external axes</returns>
		public JointTarget GetJointTarget(string task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the joint values of the robot of a task (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Values of the six robot axes and of the external axes</returns>
		public Task<JointTarget> GetJointTargetAsync(string task, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets what each of the six external joints of a task is doing (synchronous)
		/// 
		/// <p>This is what says how to read the corresponding value of
		/// <xref href="UnderAutomation.ABB.Rws.Services.RapidService.GetJointTarget(System.String)" data-throw-if-not-resolved="false"></xref>: a joint reported as not active carries no meaningful
		/// position.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <returns>State of each external joint</returns>
		public RapidExternalJointStates GetExternalJointStates(string task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets what each of the six external joints of a task is doing (asynchronous)
		/// 
		/// <p>This is what says how to read the corresponding value of
		/// <xref href="UnderAutomation.ABB.Rws.Services.RapidService.GetJointTargetAsync(System.String%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref>: a joint reported as not active carries no meaningful
		/// position.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>State of each external joint</returns>
		public Task<RapidExternalJointStates> GetExternalJointStatesAsync(string task, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the mechanical units the positions of a task are expressed in (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <returns>One entry per unit the task can move</returns>
		public RapidMechanicalUnitItem[] GetMechanicalUnits(string task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the mechanical units the positions of a task are expressed in (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>One entry per unit the task can move</returns>
		public Task<RapidMechanicalUnitItem[]> GetMechanicalUnitsAsync(string task, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the program loaded into a task (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <returns>The loaded program, null when the task holds none</returns>
		public RapidProgramInfo GetProgram(string task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the program loaded into a task (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The loaded program, null when the task holds none</returns>
		public Task<RapidProgramInfo> GetProgramAsync(string task, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Loads a program into a task (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="programPath">Path of the program on the controller, for example "$HOME/myprogram.pgf"</param>
		/// <param name="loadMode">What happens to the modules the task already holds</param>
		public void LoadProgram(string task, string programPath, RapidProgramLoadMode loadMode = RapidProgramLoadMode.Add)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Loads a program into a task (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="programPath">Path of the program on the controller, for example "$HOME/myprogram.pgf"</param>
		/// <param name="loadMode">What happens to the modules the task already holds</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task LoadProgramAsync(string task, string programPath, RapidProgramLoadMode loadMode = RapidProgramLoadMode.Add, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Unloads the program of a task (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		public void UnloadProgram(string task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Unloads the program of a task (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task UnloadProgramAsync(string task, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Saves the program of a task to the file system of the controller (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="path">Directory to save the program into, for example "$HOME/myprograms"</param>
		public void SaveProgram(string task, string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Saves the program of a task to the file system of the controller (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="path">Directory to save the program into, for example "$HOME/myprograms"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SaveProgramAsync(string task, string path, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Renames the program of a task (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="name">New name of the program</param>
		public void SetProgramName(string task, string name)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Renames the program of a task (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="name">New name of the program</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetProgramNameAsync(string task, string name, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets the routine the program pointer moves to when it is reset (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="routine">Name of the routine, for example "main"</param>
		public void SetEntryPoint(string task, string routine)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Sets the routine the program pointer moves to when it is reset (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="routine">Name of the routine, for example "main"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetEntryPointAsync(string task, string routine, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the breakpoints set in the program of a task (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="start">Index of the first breakpoint to return, null to start from the beginning</param>
		/// <param name="limit">Maximum number of breakpoints to return, null to let the controller decide</param>
		/// <returns>One entry per breakpoint, empty when the program carries none</returns>
		public RapidBreakpoint[] GetBreakpoints(string task, int? start = null, int? limit = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the breakpoints set in the program of a task (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="start">Index of the first breakpoint to return, null to start from the beginning</param>
		/// <param name="limit">Maximum number of breakpoints to return, null to let the controller decide</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>One entry per breakpoint, empty when the program carries none</returns>
		public Task<RapidBreakpoint[]> GetBreakpointsAsync(string task, int? start = null, int? limit = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets a breakpoint at a position of a module (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module to break in</param>
		/// <param name="row">Line to break at, counted from 1</param>
		/// <param name="column">Column to break at, counted from 1</param>
		/// <returns>The breakpoint as the controller placed it</returns>
		public RapidBreakpoint SetBreakpoint(string task, string module, int row, int column)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets a breakpoint at a position of a module (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module to break in</param>
		/// <param name="row">Line to break at, counted from 1</param>
		/// <param name="column">Column to break at, counted from 1</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The breakpoint as the controller placed it</returns>
		public Task<RapidBreakpoint> SetBreakpointAsync(string task, string module, int row, int column, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the errors the controller found while linking the program of a task (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="start">Index of the first error to return, null to start from the beginning</param>
		/// <param name="limit">Maximum number of errors to return, null to let the controller decide</param>
		/// <returns>One entry per error, empty when the program linked cleanly</returns>
		public RapidBuildError[] GetBuildErrors(string task, int? start = null, int? limit = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the errors the controller found while linking the program of a task (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="start">Index of the first error to return, null to start from the beginning</param>
		/// <param name="limit">Maximum number of errors to return, null to let the controller decide</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>One entry per error, empty when the program linked cleanly</returns>
		public Task<RapidBuildError[]> GetBuildErrorsAsync(string task, int? start = null, int? limit = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets which piece of source the program pointer of a task points at (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <returns>Position of the program pointer</returns>
		public RapidProgramCounterPosition GetProgramCounterPosition(string task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets which piece of source the program pointer of a task points at (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Position of the program pointer</returns>
		public Task<RapidProgramCounterPosition> GetProgramCounterPositionAsync(string task, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets where the program pointer and the motion pointer of a task stand (synchronous)
		/// 
		/// <p>The program pointer says which instruction runs next, the motion pointer which one the robot
		/// is actually executing; they drift apart because the controller plans the path ahead of the
		/// movement.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <returns>The two pointers of the task</returns>
		public RapidPointers GetPointers(string task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets where the program pointer and the motion pointer of a task stand (asynchronous)
		/// 
		/// <p>The program pointer says which instruction runs next, the motion pointer which one the robot
		/// is actually executing; they drift apart because the controller plans the path ahead of the
		/// movement.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The two pointers of the task</returns>
		public Task<RapidPointers> GetPointersAsync(string task, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Moves the program pointer of a task to a position of a module (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module to move the pointer into</param>
		/// <param name="routine">Name of the routine the position sits in</param>
		/// <param name="row">Line to move the pointer to, counted from 1</param>
		/// <param name="column">Column to move the pointer to, counted from 1</param>
		public void SetProgramPointerToCursor(string task, string module, string routine, int row, int column)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Moves the program pointer of a task to a position of a module (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module to move the pointer into</param>
		/// <param name="routine">Name of the routine the position sits in</param>
		/// <param name="row">Line to move the pointer to, counted from 1</param>
		/// <param name="column">Column to move the pointer to, counted from 1</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetProgramPointerToCursorAsync(string task, string module, string routine, int row, int column, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Moves the program pointer of a task to the beginning of a routine (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module holding the routine</param>
		/// <param name="routine">Name of the routine</param>
		/// <param name="userLevel">Whether the pointer is moved at user level, which is what a service
		///             routine has to be started with</param>
		public void SetProgramPointerToRoutine(string task, string module, string routine, bool userLevel = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Moves the program pointer of a task to the beginning of a routine (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module holding the routine</param>
		/// <param name="routine">Name of the routine</param>
		/// <param name="userLevel">Whether the pointer is moved at user level, which is what a service
		///             routine has to be started with</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetProgramPointerToRoutineAsync(string task, string module, string routine, bool userLevel = false, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Moves the program pointer of a task to a routine named by its path (synchronous)
		/// 
		/// <p>This is what the paths <code>GetServiceRoutines()</code> reports are for.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="routineUrl">Path of the routine, for example "RAPID/T_ROB1/BASEFUN/LoadIdentify"</param>
		/// <param name="userLevel">Whether the pointer is moved at user level, which is what a service
		///             routine has to be started with</param>
		public void SetProgramPointerToRoutineUrl(string task, string routineUrl, bool userLevel = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Moves the program pointer of a task to a routine named by its path (asynchronous)
		/// 
		/// <p>This is what the paths <code>GetServiceRoutinesAsync()</code> reports are for.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="routineUrl">Path of the routine, for example "RAPID/T_ROB1/BASEFUN/LoadIdentify"</param>
		/// <param name="userLevel">Whether the pointer is moved at user level, which is what a service
		///             routine has to be started with</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetProgramPointerToRoutineUrlAsync(string task, string routineUrl, bool userLevel = false, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Moves the program pointer of a task forward by one instruction (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		public void SetProgramPointerToNextInstruction(string task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Moves the program pointer of a task forward by one instruction (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetProgramPointerToNextInstructionAsync(string task, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Moves the program pointer of a task back by one instruction (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		public void SetProgramPointerToPreviousInstruction(string task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Moves the program pointer of a task back by one instruction (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetProgramPointerToPreviousInstructionAsync(string task, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets what a RAPID symbol is declared as (synchronous)
		/// </summary>
		/// <param name="symbolUrl">Path of the symbol, for example "RAPID/T_ROB1/user/reg1"</param>
		/// <returns>Declaration of the symbol</returns>
		public RapidSymbolProperties GetSymbolProperties(string symbolUrl)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets what a RAPID symbol is declared as (asynchronous)
		/// </summary>
		/// <param name="symbolUrl">Path of the symbol, for example "RAPID/T_ROB1/user/reg1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Declaration of the symbol</returns>
		public Task<RapidSymbolProperties> GetSymbolPropertiesAsync(string symbolUrl, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the value of a RAPID symbol and where it is declared (synchronous)
		/// </summary>
		/// <param name="symbolUrl">Path of the symbol, for example "RAPID/T_ROB1/user/reg1"</param>
		/// <returns>Value of the symbol, written the way RAPID writes it</returns>
		public RapidSymbolValue GetSymbolValue(string symbolUrl)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the value of a RAPID symbol and where it is declared (asynchronous)
		/// </summary>
		/// <param name="symbolUrl">Path of the symbol, for example "RAPID/T_ROB1/user/reg1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Value of the symbol, written the way RAPID writes it</returns>
		public Task<RapidSymbolValue> GetSymbolValueAsync(string symbolUrl, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets the value a RAPID symbol currently holds (synchronous)
		/// </summary>
		/// <param name="symbolUrl">Path of the symbol, for example "RAPID/T_ROB1/user/reg1"</param>
		/// <param name="value">New value, written the way RAPID writes it; a record needs the bracketed form,
		///             for example "[[515,0,712],[1,0,0,0],[0,0,0,0],[9E9,9E9,9E9,9E9,9E9,9E9]]"</param>
		public void SetSymbolValue(string symbolUrl, string value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Sets the value a RAPID symbol currently holds (asynchronous)
		/// </summary>
		/// <param name="symbolUrl">Path of the symbol, for example "RAPID/T_ROB1/user/reg1"</param>
		/// <param name="value">New value, written the way RAPID writes it; a record needs the bracketed form,
		///             for example "[[515,0,712],[1,0,0,0],[0,0,0,0],[9E9,9E9,9E9,9E9,9E9,9E9]]"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetSymbolValueAsync(string symbolUrl, string value, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets the value a RAPID symbol is declared with, which is the one it goes back to when the program
		/// is reset (synchronous)
		/// </summary>
		/// <param name="symbolUrl">Path of the symbol, for example "RAPID/T_ROB1/user/reg1"</param>
		/// <param name="value">New initial value, written the way RAPID writes it</param>
		public void SetSymbolInitialValue(string symbolUrl, string value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Sets the value a RAPID symbol is declared with, which is the one it goes back to when the program
		/// is reset (asynchronous)
		/// </summary>
		/// <param name="symbolUrl">Path of the symbol, for example "RAPID/T_ROB1/user/reg1"</param>
		/// <param name="value">New initial value, written the way RAPID writes it</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetSymbolInitialValueAsync(string symbolUrl, string value, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Finds the RAPID symbols matching a set of criteria (synchronous)
		/// </summary>
		/// <param name="criteria">What to look for; set at least its search path, because a search with no
		///             criterion walks the whole system</param>
		/// <returns>One entry per symbol found, empty when none matched</returns>
		public RapidSymbolProperties[] SearchSymbols(RapidSymbolSearchCriteria criteria)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Finds the RAPID symbols matching a set of criteria (asynchronous)
		/// </summary>
		/// <param name="criteria">What to look for; set at least its search path, because a search with no
		///             criterion walks the whole system</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>One entry per symbol found, empty when none matched</returns>
		public Task<RapidSymbolProperties[]> SearchSymbolsAsync(RapidSymbolSearchCriteria criteria, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Asks the controller whether a value would be accepted for a given RAPID type, without writing it
		/// anywhere (synchronous)
		/// 
		/// <p>This is what an editor uses to tell an operator that what they typed is wrong before the
		/// write is attempted.</p>
		/// </summary>
		/// <param name="task">Name of the task the type is looked up in, for example "T_ROB1"</param>
		/// <param name="dataType">Name of the type, for example "robtarget"</param>
		/// <param name="value">Value to check, written the way RAPID writes it</param>
		/// <returns>True when the controller accepts the value, false when it rejects it</returns>
		public bool ValidateSymbolValue(string task, string dataType, string value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Asks the controller whether a value would be accepted for a given RAPID type, without writing it
		/// anywhere (asynchronous)
		/// 
		/// <p>This is what an editor uses to tell an operator that what they typed is wrong before the
		/// write is attempted.</p>
		/// </summary>
		/// <param name="task">Name of the task the type is looked up in, for example "T_ROB1"</param>
		/// <param name="dataType">Name of the type, for example "robtarget"</param>
		/// <param name="value">Value to check, written the way RAPID writes it</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>True when the controller accepts the value, false when it rejects it</returns>
		public Task<bool> ValidateSymbolValueAsync(string task, string dataType, string value, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets where one of the lists a RAPID object holds sits in the source: the span of the whole list,
		/// and the spans of its first and last elements (synchronous)
		/// 
		/// <p>An editor uses this to jump to the beginning or the end of a list without reading the whole
		/// module.</p>
		/// </summary>
		/// <param name="symbolUrl">Path of the object, for example "RAPID/T_ROB1/MainModule"</param>
		/// <param name="type">Which of its lists is being asked about</param>
		/// <returns>Where the list and its ends sit</returns>
		public RapidObjectListExtension GetObjectListExtension(string symbolUrl, RapidObjectListType type = RapidObjectListType.Statements)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets where one of the lists a RAPID object holds sits in the source: the span of the whole list,
		/// and the spans of its first and last elements (asynchronous)
		/// 
		/// <p>An editor uses this to jump to the beginning or the end of a list without reading the whole
		/// module.</p>
		/// </summary>
		/// <param name="symbolUrl">Path of the object, for example "RAPID/T_ROB1/MainModule"</param>
		/// <param name="type">Which of its lists is being asked about</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Where the list and its ends sit</returns>
		public Task<RapidObjectListExtension> GetObjectListExtensionAsync(string symbolUrl, RapidObjectListType type = RapidObjectListType.Statements, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets every RAPID task of the controller and what each of them is doing (synchronous)
		/// </summary>
		/// <returns>One entry per task</returns>
		public RapidTaskItem[] GetTasks()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets every RAPID task of the controller and what each of them is doing (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>One entry per task</returns>
		public Task<RapidTaskItem[]> GetTasksAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets everything the controller reports about one task (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <returns>State of the task</returns>
		public RapidTaskInfo GetTask(string task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets everything the controller reports about one task (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>State of the task</returns>
		public Task<RapidTaskInfo> GetTaskAsync(string task, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Activates every task of the controller (synchronous)
		/// </summary>
		public void ActivateTasks()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Activates every task of the controller (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task ActivateTasksAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Deactivates every task of the controller (synchronous)
		/// </summary>
		public void DeactivateTasks()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Deactivates every task of the controller (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task DeactivateTasksAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Activates one task (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		public void ActivateTask(string task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Activates one task (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task ActivateTaskAsync(string task, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Deactivates one task (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		public void DeactivateTask(string task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Deactivates one task (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task DeactivateTaskAsync(string task, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Links the program of a task, which is what turns the modules it holds into something runnable
		/// (synchronous)
		/// 
		/// <p>Read <code>GetBuildErrors()</code> afterwards to find out what the controller refused.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		public void BuildTask(string task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Links the program of a task, which is what turns the modules it holds into something runnable
		/// (asynchronous)
		/// 
		/// <p>Read <code>GetBuildErrorsAsync()</code> afterwards to find out what the controller refused.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task BuildTaskAsync(string task, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Abandons the routine the task is currently running and returns to the level below it (synchronous)
		/// 
		/// <p>This is how a trap or a service routine started by hand is left without stopping the program
		/// underneath it.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		public void AbortExecutionLevel(string task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Abandons the routine the task is currently running and returns to the level below it (asynchronous)
		/// 
		/// <p>This is how a trap or a service routine started by hand is left without stopping the program
		/// underneath it.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task AbortExecutionLevelAsync(string task, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Loads a module file into a task (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="modulePath">Path of the module file on the controller, for example "$HOME/mymodule.mod"</param>
		/// <param name="replace">Whether a module of the same name already loaded is replaced</param>
		/// <returns>Name of the loaded module, null when the controller did not report it</returns>
		public string LoadModule(string task, string modulePath, bool replace = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Loads a module file into a task (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="modulePath">Path of the module file on the controller, for example "$HOME/mymodule.mod"</param>
		/// <param name="replace">Whether a module of the same name already loaded is replaced</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Name of the loaded module, null when the controller did not report it</returns>
		public Task<string> LoadModuleAsync(string task, string modulePath, bool replace = false, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Unloads a module from a task (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module to unload</param>
		public void UnloadModule(string task, string module)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Unloads a module from a task (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="module">Name of the module to unload</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task UnloadModuleAsync(string task, string module, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets whether the controller is recording the RAPID execution trace to a file (synchronous)
		/// </summary>
		/// <returns>Whether the trace is being written</returns>
		public RapidSpyStatus GetSpyStatus()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets whether the controller is recording the RAPID execution trace to a file (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Whether the trace is being written</returns>
		public Task<RapidSpyStatus> GetSpyStatusAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Starts recording the RAPID execution trace into a file (synchronous)
		/// 
		/// <p>The trace names every instruction the controller runs, which is what it takes to find out
		/// why a program took a branch it should not have.</p>
		/// </summary>
		/// <param name="logFile">Path of the file to write, which lands in the home directory when it carries
		///             no directory of its own</param>
		public void StartSpy(string logFile)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Starts recording the RAPID execution trace into a file (asynchronous)
		/// 
		/// <p>The trace names every instruction the controller runs, which is what it takes to find out
		/// why a program took a branch it should not have.</p>
		/// </summary>
		/// <param name="logFile">Path of the file to write, which lands in the home directory when it carries
		///             no directory of its own</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task StartSpyAsync(string logFile, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Stops recording the RAPID execution trace (synchronous)
		/// </summary>
		public void StopSpy()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Stops recording the RAPID execution trace (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task StopSpyAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets whether the program pointers of every task are synchronized with each other (synchronous)
		/// </summary>
		/// <returns>Whether the program pointers are synchronized</returns>
		public RapidPointerSyncState GetProgramPointerSyncState()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets whether the program pointers of every task are synchronized with each other (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Whether the program pointers are synchronized</returns>
		public Task<RapidPointerSyncState> GetProgramPointerSyncStateAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets whether the motion pointers of every task are synchronized with each other (synchronous)
		/// </summary>
		/// <returns>Whether the motion pointers are synchronized</returns>
		public RapidPointerSyncState GetMotionPointerSyncState()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets whether the motion pointers of every task are synchronized with each other (asynchronous)
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Whether the motion pointers are synchronized</returns>
		public Task<RapidPointerSyncState> GetMotionPointerSyncStateAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets whether the program pointer of one task is synchronized with the others (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <returns>Whether the program pointer of the task is synchronized</returns>
		public RapidPointerSyncState GetTaskProgramPointerSyncState(string task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets whether the program pointer of one task is synchronized with the others (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Whether the program pointer of the task is synchronized</returns>
		public Task<RapidPointerSyncState> GetTaskProgramPointerSyncStateAsync(string task, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets whether the motion pointer of one task is synchronized with the others (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <returns>Whether the motion pointer of the task is synchronized</returns>
		public RapidPointerSyncState GetTaskMotionPointerSyncState(string task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets whether the motion pointer of one task is synchronized with the others (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Whether the motion pointer of the task is synchronized</returns>
		public Task<RapidPointerSyncState> GetTaskMotionPointerSyncStateAsync(string task, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the two counters a task keeps of what has changed in it (synchronous)
		/// 
		/// <p>Comparing them with what a previous reading gave is cheaper than fetching the modules again
		/// to find out that nothing moved.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <returns>Change counters of the task</returns>
		public RapidStructuralChangeCount GetStructuralChangeCount(string task)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the two counters a task keeps of what has changed in it (asynchronous)
		/// 
		/// <p>Comparing them with what a previous reading gave is cheaper than fetching the modules again
		/// to find out that nothing moved.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Change counters of the task</returns>
		public Task<RapidStructuralChangeCount> GetStructuralChangeCountAsync(string task, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets one frame of the call stack of a task: which routine is running and where execution stands in
		/// it (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="stackFrame">Frame to read, 1 being the one holding the program pointer and the number
		///             growing towards the entry point of the program</param>
		/// <returns>The requested stack frame</returns>
		public RapidActivationRecord GetActivationRecord(string task, int stackFrame = 1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets one frame of the call stack of a task: which routine is running and where execution stands in
		/// it (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="stackFrame">Frame to read, 1 being the one holding the program pointer and the number
		///             growing towards the entry point of the program</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The requested stack frame</returns>
		public Task<RapidActivationRecord> GetActivationRecordAsync(string task, int stackFrame = 1, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the routines of a task the program pointer can be moved to (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="start">Index of the first routine to return, null to start from the beginning</param>
		/// <param name="limit">Maximum number of routines to return, null to let the controller decide</param>
		/// <returns>One entry per routine</returns>
		public RapidServiceRoutineItem[] GetServiceRoutines(string task, int? start = null, int? limit = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the routines of a task the program pointer can be moved to (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="start">Index of the first routine to return, null to start from the beginning</param>
		/// <param name="limit">Maximum number of routines to return, null to let the controller decide</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>One entry per routine</returns>
		public Task<RapidServiceRoutineItem[]> GetServiceRoutinesAsync(string task, int? start = null, int? limit = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the data types the controller suggests for one argument of an instruction (synchronous)
		/// 
		/// <p>An editor uses this to offer only the types that fit where the operator is typing.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="instruction">Name of the instruction, for example "AliasIO"</param>
		/// <param name="parameter">Name of the argument of that instruction, for example "FromSignal"</param>
		/// <returns>One entry per suggested type</returns>
		public RapidPreferredDataTypeItem[] GetPreferredDataTypes(string task, string instruction, string parameter)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the data types the controller suggests for one argument of an instruction (asynchronous)
		/// 
		/// <p>An editor uses this to offer only the types that fit where the operator is typing.</p>
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="instruction">Name of the instruction, for example "AliasIO"</param>
		/// <param name="parameter">Name of the argument of that instruction, for example "FromSignal"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>One entry per suggested type</returns>
		public Task<RapidPreferredDataTypeItem[]> GetPreferredDataTypesAsync(string task, string instruction, string parameter, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the categories of the instruction palette an editor offers (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="start">Index of the first category to return, null to start from the beginning</param>
		/// <param name="limit">Maximum number of categories to return, null to let the controller decide</param>
		/// <returns>One entry per category; the number of an entry is what <xref href="UnderAutomation.ABB.Rws.Services.RapidService.GetPallet(System.String%2cSystem.Int32%2cSystem.Nullable%7bSystem.Int32%7d%2cSystem.Nullable%7bSystem.Int32%7d)" data-throw-if-not-resolved="false"></xref> takes</returns>
		public RapidPalletHeadItem[] GetPalletHeads(string task, int? start = null, int? limit = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the categories of the instruction palette an editor offers (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="start">Index of the first category to return, null to start from the beginning</param>
		/// <param name="limit">Maximum number of categories to return, null to let the controller decide</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>One entry per category; the number of an entry is what <xref href="UnderAutomation.ABB.Rws.Services.RapidService.GetPalletAsync(System.String%2cSystem.Int32%2cSystem.Nullable%7bSystem.Int32%7d%2cSystem.Nullable%7bSystem.Int32%7d%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref> takes</returns>
		public Task<RapidPalletHeadItem[]> GetPalletHeadsAsync(string task, int? start = null, int? limit = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the entries of one category of the instruction palette (synchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="palletNumber">Number of the category, as <xref href="UnderAutomation.ABB.Rws.Services.RapidService.GetPalletHeads(System.String%2cSystem.Nullable%7bSystem.Int32%7d%2cSystem.Nullable%7bSystem.Int32%7d)" data-throw-if-not-resolved="false"></xref> reports it</param>
		/// <param name="start">Index of the first entry to return, null to start from the beginning</param>
		/// <param name="limit">Maximum number of entries to return, null to let the controller decide</param>
		/// <returns>One entry per instruction of the category</returns>
		public RapidPalletItem[] GetPallet(string task, int palletNumber, int? start = null, int? limit = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the entries of one category of the instruction palette (asynchronous)
		/// </summary>
		/// <param name="task">Name of the task, for example "T_ROB1"</param>
		/// <param name="palletNumber">Number of the category, as <xref href="UnderAutomation.ABB.Rws.Services.RapidService.GetPalletHeadsAsync(System.String%2cSystem.Nullable%7bSystem.Int32%7d%2cSystem.Nullable%7bSystem.Int32%7d%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref> reports it</param>
		/// <param name="start">Index of the first entry to return, null to start from the beginning</param>
		/// <param name="limit">Maximum number of entries to return, null to let the controller decide</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>One entry per instruction of the category</returns>
		public Task<RapidPalletItem[]> GetPalletAsync(string task, int palletNumber, int? start = null, int? limit = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the dialogue a running RAPID program is currently asking an operator for (synchronous)
		/// 
		/// <p>Answering it means writing its parameters with
		/// <xref href="UnderAutomation.ABB.Rws.Services.RapidService.SetUiInstructionParameter(System.String%2cSystem.String%2cSystem.String)" data-throw-if-not-resolved="false"></xref>, addressed by the path this returns.</p>
		/// </summary>
		/// <returns>The pending instruction, null when the program is not asking for anything</returns>
		public RapidUiInstruction GetActiveUiInstruction()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the dialogue a running RAPID program is currently asking an operator for (asynchronous)
		/// 
		/// <p>Answering it means writing its parameters with
		/// <xref href="UnderAutomation.ABB.Rws.Services.RapidService.SetUiInstructionParameterAsync(System.String%2cSystem.String%2cSystem.String%2cSystem.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref>, addressed by the path this returns.</p>
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The pending instruction, null when the program is not asking for anything</returns>
		public Task<RapidUiInstruction> GetActiveUiInstructionAsync(CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets every parameter of a pending UI instruction: what the program passed in, and what it is
		/// waiting for (synchronous)
		/// </summary>
		/// <param name="stackUrl">Path identifying the call, as
		///             <xref href="UnderAutomation.ABB.Rws.Services.RapidService.GetActiveUiInstruction" data-throw-if-not-resolved="false"></xref> reports it</param>
		/// <returns>One entry per parameter</returns>
		public RapidUiInstructionParameter[] GetUiInstructionParameters(string stackUrl)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets every parameter of a pending UI instruction: what the program passed in, and what it is
		/// waiting for (asynchronous)
		/// </summary>
		/// <param name="stackUrl">Path identifying the call, as
		///             <xref href="UnderAutomation.ABB.Rws.Services.RapidService.GetActiveUiInstructionAsync(System.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref> reports it</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>One entry per parameter</returns>
		public Task<RapidUiInstructionParameter[]> GetUiInstructionParametersAsync(string stackUrl, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the value of one parameter of a pending UI instruction (synchronous)
		/// </summary>
		/// <param name="stackUrl">Path identifying the call, as
		///             <xref href="UnderAutomation.ABB.Rws.Services.RapidService.GetActiveUiInstruction" data-throw-if-not-resolved="false"></xref> reports it</param>
		/// <param name="parameter">Name of the parameter, for example "TPCompleted"</param>
		/// <returns>Value of the parameter, written the way RAPID writes it</returns>
		public string GetUiInstructionParameter(string stackUrl, string parameter)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the value of one parameter of a pending UI instruction (asynchronous)
		/// </summary>
		/// <param name="stackUrl">Path identifying the call, as
		///             <xref href="UnderAutomation.ABB.Rws.Services.RapidService.GetActiveUiInstructionAsync(System.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref> reports it</param>
		/// <param name="parameter">Name of the parameter, for example "TPCompleted"</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Value of the parameter, written the way RAPID writes it</returns>
		public Task<string> GetUiInstructionParameterAsync(string stackUrl, string parameter, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Answers a pending UI instruction by writing one of its parameters (synchronous)
		/// 
		/// <p>An instruction is normally answered by writing the parameter carrying the answer and then
		/// the one marking it as completed.</p>
		/// </summary>
		/// <param name="stackUrl">Path identifying the call, as
		///             <xref href="UnderAutomation.ABB.Rws.Services.RapidService.GetActiveUiInstruction" data-throw-if-not-resolved="false"></xref> reports it</param>
		/// <param name="parameter">Name of the parameter to write, for example "TPCompleted"</param>
		/// <param name="value">Value to write, written the way RAPID writes it</param>
		public void SetUiInstructionParameter(string stackUrl, string parameter, string value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Answers a pending UI instruction by writing one of its parameters (asynchronous)
		/// 
		/// <p>An instruction is normally answered by writing the parameter carrying the answer and then
		/// the one marking it as completed.</p>
		/// </summary>
		/// <param name="stackUrl">Path identifying the call, as
		///             <xref href="UnderAutomation.ABB.Rws.Services.RapidService.GetActiveUiInstructionAsync(System.Threading.CancellationToken)" data-throw-if-not-resolved="false"></xref> reports it</param>
		/// <param name="parameter">Name of the parameter to write, for example "TPCompleted"</param>
		/// <param name="value">Value to write, written the way RAPID writes it</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task SetUiInstructionParameterAsync(string stackUrl, string parameter, string value, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
