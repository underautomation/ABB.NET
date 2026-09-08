using System;
using System.ComponentModel;
using System.Windows.Forms;
using UnderAutomation.ABB;
using UnderAutomation.ABB.Common;
using UnderAutomation.ABB.Rws.Data;

public partial class RwsRapidControl : UserControl, IUserControl
{
    private AbbController _robot;

    public RwsRapidControl(AbbController robot)
    {
        _robot = robot;
        InitializeComponent();

        RegisterGridTypes();
        FillCombos();
    }

    #region IUserControl

    public string Title => "RAPID (RWS)";

    public bool FeatureEnabled => _robot?.Rws != null && _robot.Rws.Enabled;

    public void PeriodicUpdate()
    {
        this.Enabled = FeatureEnabled;
    }

    public void OnClose()
    {
    }

    public void OnOpen()
    {
    }

    #endregion

    #region Setup

    // The property grids show these types, and an array of them, as expandable read only rows
    private static void RegisterGridTypes()
    {
        MakeExpandableAndReadOnly(typeof(RapidExecutionInfo));
        MakeExpandableAndReadOnly(typeof(RapidTaskSelectionItem));
        MakeExpandableAndReadOnly(typeof(RapidAliasIoItem));

        MakeExpandableAndReadOnly(typeof(RapidTaskItem));
        MakeExpandableAndReadOnly(typeof(RapidTaskInfo));
        MakeExpandableAndReadOnly(typeof(RapidStructuralChangeCount));
        MakeExpandableAndReadOnly(typeof(RapidActivationRecord));
        MakeExpandableAndReadOnly(typeof(RapidServiceRoutineItem));
        MakeExpandableAndReadOnly(typeof(RapidPreferredDataTypeItem));
        MakeExpandableAndReadOnly(typeof(RapidPalletHeadItem));
        MakeExpandableAndReadOnly(typeof(RapidPalletItem));

        MakeExpandableAndReadOnly(typeof(RapidProgramInfo));
        MakeExpandableAndReadOnly(typeof(RapidBreakpoint));
        MakeExpandableAndReadOnly(typeof(RapidBuildError));
        MakeExpandableAndReadOnly(typeof(RapidProgramCounterPosition));
        MakeExpandableAndReadOnly(typeof(RapidPointers));
        MakeExpandableAndReadOnly(typeof(RapidPointerPosition));

        MakeExpandableAndReadOnly(typeof(RapidModuleItem));
        MakeExpandableAndReadOnly(typeof(RapidModuleInfo));
        MakeExpandableAndReadOnly(typeof(RapidModuleExtension));
        MakeExpandableAndReadOnly(typeof(RapidModuleText));
        MakeExpandableAndReadOnly(typeof(RapidSetTextRangeResult));
        MakeExpandableAndReadOnly(typeof(RapidTextPosition));
        MakeExpandableAndReadOnly(typeof(RapidTextRange));
        MakeExpandableAndReadOnly(typeof(RapidModuleSymbol));
        MakeExpandableAndReadOnly(typeof(RapidRoutineInfo));
        MakeExpandableAndReadOnly(typeof(RapidRoutineArgument));
        MakeExpandableAndReadOnly(typeof(RapidInstructionTemplate));
        MakeExpandableAndReadOnly(typeof(RapidInstructionTemplateArgument));
        MakeExpandableAndReadOnly(typeof(RapidObjectChild));
        MakeExpandableAndReadOnly(typeof(RapidObjectChildRange));
        MakeExpandableAndReadOnly(typeof(RapidModifiablePositions));
        MakeExpandableAndReadOnly(typeof(RapidModifiablePositionItem));

        MakeExpandableAndReadOnly(typeof(RapidSymbolProperties));
        MakeExpandableAndReadOnly(typeof(RapidSymbolValue));
        MakeExpandableAndReadOnly(typeof(RapidObjectListExtension));

        MakeExpandableAndReadOnly(typeof(RapidExternalJointStates));
        MakeExpandableAndReadOnly(typeof(RapidMechanicalUnitItem));

        MakeExpandableAndReadOnly(typeof(RapidUiInstruction));
        MakeExpandableAndReadOnly(typeof(RapidUiInstructionParameter));

        // the positions come back as the geometry types shared with the motion system
        MakeExpandableAndReadOnly(typeof(Position));
        MakeExpandableAndReadOnly(typeof(Pose));
        MakeExpandableAndReadOnly(typeof(RobTarget));
        MakeExpandableAndReadOnly(typeof(Quaternion));
        MakeExpandableAndReadOnly(typeof(RobotConfiguration));
        MakeExpandableAndReadOnly(typeof(RobotJoints));
        MakeExpandableAndReadOnly(typeof(ExternalJoints));
        MakeExpandableAndReadOnly(typeof(JointTarget));
    }

    private static void MakeExpandableAndReadOnly(Type type)
    {
        TypeDescriptor.AddAttributes(type, new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(type, new ReadOnlyAttribute(true));
    }

    // Only the values the controller accepts as a command go in the combos: the Unknown members are answers,
    // not commands
    private void FillCombos()
    {
        cboStartRegain.Items.AddRange(new object[]
        {
            RapidRegainMode.Continue,
            RapidRegainMode.Regain,
            RapidRegainMode.Clear,
            RapidRegainMode.EnterConsume,
        });
        cboStartRegain.SelectedIndex = 0;

        cboStartExecutionMode.Items.AddRange(new object[]
        {
            RapidExecutionMode.Continue,
            RapidExecutionMode.StepIn,
            RapidExecutionMode.StepOver,
            RapidExecutionMode.StepOut,
            RapidExecutionMode.StepBack,
            RapidExecutionMode.StepLast,
            RapidExecutionMode.StepMotion,
        });
        cboStartExecutionMode.SelectedIndex = 0;

        // AsIs leaves the configured cycle alone, OnceDone is an answer and not a command
        cboStartCycle.Items.AddRange(new object[]
        {
            RapidExecutionCycle.Forever,
            RapidExecutionCycle.Once,
            RapidExecutionCycle.AsIs,
        });
        cboStartCycle.SelectedIndex = 0;

        cboStartCondition.Items.AddRange(new object[]
        {
            RapidStartCondition.None,
            RapidStartCondition.CallChain,
        });
        cboStartCondition.SelectedIndex = 0;

        cboStopStopMode.Items.AddRange(new object[]
        {
            RapidStopMode.Stop,
            RapidStopMode.Cycle,
            RapidStopMode.Instruction,
            RapidStopMode.QuickStop,
        });
        cboStopStopMode.SelectedIndex = 0;

        cboStopScope.Items.AddRange(new object[]
        {
            RapidTaskScope.Normal,
            RapidTaskScope.AllTasks,
        });
        cboStopScope.SelectedIndex = 0;

        // the cycle resource only takes these two
        cboSetExecutionCycleCycle.Items.AddRange(new object[]
        {
            RapidExecutionCycle.Forever,
            RapidExecutionCycle.Once,
        });
        cboSetExecutionCycleCycle.SelectedIndex = 0;

        cboSetHoldToRunState.Items.AddRange(new object[]
        {
            RapidHoldToRunState.Press,
            RapidHoldToRunState.Held,
            RapidHoldToRunState.Release,
        });
        cboSetHoldToRunState.SelectedIndex = 0;

        cboLoadProgramLoadMode.Items.AddRange(new object[]
        {
            RapidProgramLoadMode.Add,
            RapidProgramLoadMode.Replace,
        });
        cboLoadProgramLoadMode.SelectedIndex = 0;

        cboSetModuleTextRangeReplaceMode.Items.AddRange(new object[]
        {
            RapidTextReplaceMode.After,
            RapidTextReplaceMode.Before,
            RapidTextReplaceMode.Replace,
        });
        cboSetModuleTextRangeReplaceMode.SelectedIndex = 0;

        cboSetModuleTextRangeQueryMode.Items.AddRange(new object[]
        {
            RapidTextQueryMode.Force,
            RapidTextQueryMode.Try,
        });
        cboSetModuleTextRangeQueryMode.SelectedIndex = 0;

        cboSearchSymbolsView.Items.AddRange(new object[]
        {
            RapidSymbolSearchView.Block,
            RapidSymbolSearchView.Scope,
            RapidSymbolSearchView.Stack,
            RapidSymbolSearchView.Undefined,
        });
        cboSearchSymbolsView.SelectedIndex = 0;

        cboSearchSymbolsSymbolType.Items.AddRange(new object[]
        {
            RapidSymbolType.Variable,
            RapidSymbolType.Persistent,
            RapidSymbolType.Constant,
            RapidSymbolType.Procedure,
            RapidSymbolType.Function,
            RapidSymbolType.Trap,
            RapidSymbolType.Module,
            RapidSymbolType.Parameter,
            RapidSymbolType.Record,
            RapidSymbolType.Alias,
            RapidSymbolType.Atomic,
            RapidSymbolType.Any,
        });
        cboSearchSymbolsSymbolType.SelectedIndex = 0;

        cboObjectListExtensionType.Items.AddRange(new object[]
        {
            RapidObjectListType.Statements,
            RapidObjectListType.BackwardStatements,
            RapidObjectListType.ErrorStatements,
            RapidObjectListType.UndoStatements,
            RapidObjectListType.TypeDeclarations,
            RapidObjectListType.DataDeclarations,
            RapidObjectListType.ParameterDeclarations,
            RapidObjectListType.RoutineDeclarations,
            RapidObjectListType.Attributes,
        });
        cboObjectListExtensionType.SelectedIndex = 0;
    }

    #endregion

    #region Helpers

    // Read the value of an enum combo without a nullable warning
    private static T SelectedValue<T>(ComboBox combo) where T : struct
    {
        return (T)(combo.SelectedItem ?? default(T));
    }

    // An empty box means "let the controller use what it already has"
    private static string? Optional(TextBox box)
    {
        return string.IsNullOrEmpty(box.Text) ? null : box.Text;
    }

    private static void Show(PropertyGrid grid, object? value)
    {
        grid.SelectedObject = value;

        if (value != null)
            grid.ExpandAllGridItems();
    }

    // The task and the module every panel works on, taken from the bar above the tabs rather than repeated
    // in each of them
    private string Task => txtTask.Text;

    private string Module => txtModule.Text;

    private static bool Confirm(string question, string title)
    {
        return MessageBox.Show(question, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK;
    }

    #endregion

    #region Mastership

    private void btnTakeMastership_Click(object sender, EventArgs e)
    {
        // The edit domain is what the RAPID writes need, and it means the same thing on both connection
        // versions even though the controller does not cut its domains the same way
        _robot.Rws.Mastership.Request(MastershipDomain.Edit);
        ReadMastershipState();
    }

    private void btnReleaseMastership_Click(object sender, EventArgs e)
    {
        // Giving everything back is accepted whatever is held, so this never fails for having nothing to give
        _robot.Rws.Mastership.Release();
        ReadMastershipState();
    }

    private void ReadMastershipState()
    {
        var held = _robot.Rws.Mastership.GetInfo(MastershipDomain.Edit).HeldByMe;

        lblMastershipStatus.Text = held
            ? "2. Edit mastership held"
            : "2. Most writes need it";
    }

    #endregion

    #region Execution

    private void btnGetExecutionState_Click(object sender, EventArgs e)
    {
        Show(gridExecutionState, _robot.Rws.Rapid.GetExecutionState());
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        if (!Confirm("Start the RAPID program? The robot moves.", "Start")) return;

        _robot.Rws.Rapid.Start(SelectedValue<RapidRegainMode>(cboStartRegain),
                               SelectedValue<RapidExecutionMode>(cboStartExecutionMode),
                               SelectedValue<RapidExecutionCycle>(cboStartCycle),
                               SelectedValue<RapidStartCondition>(cboStartCondition),
                               chkStartStopAtBreakpoint.Checked,
                               chkStartAllTasksBySelection.Checked);

        Show(gridExecutionState, _robot.Rws.Rapid.GetExecutionState());
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.Stop(SelectedValue<RapidStopMode>(cboStopStopMode),
                              SelectedValue<RapidTaskScope>(cboStopScope));

        Show(gridExecutionState, _robot.Rws.Rapid.GetExecutionState());
    }

    private void btnStartFromProductionEntry_Click(object sender, EventArgs e)
    {
        if (!Confirm("Start from the production entry point? The robot moves.", "Start")) return;

        _robot.Rws.Rapid.StartFromProductionEntry();
        Show(gridExecutionState, _robot.Rws.Rapid.GetExecutionState());
    }

    private void btnResetProgramPointer_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.ResetProgramPointer();
    }

    private void btnSetExecutionCycle_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.SetExecutionCycle(SelectedValue<RapidExecutionCycle>(cboSetExecutionCycleCycle));
        Show(gridExecutionState, _robot.Rws.Rapid.GetExecutionState());
    }

    private void btnSetHoldToRun_Click(object sender, EventArgs e)
    {
        // Only a virtual controller in manual mode honours this, and only for the local client
        _robot.Rws.Rapid.SetHoldToRun(SelectedValue<RapidHoldToRunState>(cboSetHoldToRunState));
    }

    private void btnGetTaskSelection_Click(object sender, EventArgs e)
    {
        Show(gridTaskSelection, _robot.Rws.Rapid.GetTaskSelection());
    }

    private void btnGetAliasIo_Click(object sender, EventArgs e)
    {
        Show(gridAliasIo, _robot.Rws.Rapid.GetAliasIo());
    }

    #endregion

    #region Tasks

    private void btnGetTasks_Click(object sender, EventArgs e)
    {
        Show(gridTasks, _robot.Rws.Rapid.GetTasks());
    }

    private void btnGetTask_Click(object sender, EventArgs e)
    {
        Show(gridTask, _robot.Rws.Rapid.GetTask(Task));
    }

    private void btnActivateTask_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.ActivateTask(Task);
        Show(gridTask, _robot.Rws.Rapid.GetTask(Task));
    }

    private void btnDeactivateTask_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.DeactivateTask(Task);
        Show(gridTask, _robot.Rws.Rapid.GetTask(Task));
    }

    private void btnActivateTasks_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.ActivateTasks();
        Show(gridTasks, _robot.Rws.Rapid.GetTasks());
    }

    private void btnDeactivateTasks_Click(object sender, EventArgs e)
    {
        if (!Confirm("Deactivate every task? None of them takes part in the execution afterwards.",
                     "Deactivate tasks")) return;

        _robot.Rws.Rapid.DeactivateTasks();
        Show(gridTasks, _robot.Rws.Rapid.GetTasks());
    }

    private void btnBuildTask_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.BuildTask(Task);
        Show(gridBuildErrors, _robot.Rws.Rapid.GetBuildErrors(Task));
    }

    private void btnAbortExecutionLevel_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.AbortExecutionLevel(Task);
    }

    private void btnLoadModule_Click(object sender, EventArgs e)
    {
        txtLoadModuleResult.Text = _robot.Rws.Rapid.LoadModule(Task, txtLoadModulePath.Text,
                                                               chkLoadModuleReplace.Checked) ?? string.Empty;

        Show(gridModules, _robot.Rws.Rapid.GetModules(Task));
    }

    private void btnUnloadModule_Click(object sender, EventArgs e)
    {
        if (!Confirm($"Unload {Module} from {Task}?", "Unload module")) return;

        _robot.Rws.Rapid.UnloadModule(Task, Module);
        Show(gridModules, _robot.Rws.Rapid.GetModules(Task));
    }

    private void btnGetSpyStatus_Click(object sender, EventArgs e)
    {
        txtSpyStatus.Text = _robot.Rws.Rapid.GetSpyStatus().ToString();
    }

    private void btnStartSpy_Click(object sender, EventArgs e)
    {
        // The controller writes the trace into the home directory, a path of its own is refused
        _robot.Rws.Rapid.StartSpy(txtStartSpyLogFile.Text);
        txtSpyStatus.Text = _robot.Rws.Rapid.GetSpyStatus().ToString();
    }

    private void btnStopSpy_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.StopSpy();
        txtSpyStatus.Text = _robot.Rws.Rapid.GetSpyStatus().ToString();
    }

    private void btnGetProgramPointerSyncState_Click(object sender, EventArgs e)
    {
        txtProgramPointerSyncState.Text = _robot.Rws.Rapid.GetProgramPointerSyncState().ToString();
    }

    private void btnGetMotionPointerSyncState_Click(object sender, EventArgs e)
    {
        txtMotionPointerSyncState.Text = _robot.Rws.Rapid.GetMotionPointerSyncState().ToString();
    }

    private void btnGetTaskProgramPointerSyncState_Click(object sender, EventArgs e)
    {
        txtTaskProgramPointerSyncState.Text = _robot.Rws.Rapid.GetTaskProgramPointerSyncState(Task).ToString();
    }

    private void btnGetTaskMotionPointerSyncState_Click(object sender, EventArgs e)
    {
        txtTaskMotionPointerSyncState.Text = _robot.Rws.Rapid.GetTaskMotionPointerSyncState(Task).ToString();
    }

    private void btnGetStructuralChangeCount_Click(object sender, EventArgs e)
    {
        Show(gridStructuralChangeCount, _robot.Rws.Rapid.GetStructuralChangeCount(Task));
    }

    private void btnGetActivationRecord_Click(object sender, EventArgs e)
    {
        // Refused when the task has no program pointer, which is the usual state of an idle controller
        Show(gridActivationRecord, _robot.Rws.Rapid.GetActivationRecord(Task, (int)numGetActivationRecordStackFrame.Value));
    }

    private void btnGetServiceRoutines_Click(object sender, EventArgs e)
    {
        Show(gridServiceRoutines, _robot.Rws.Rapid.GetServiceRoutines(Task, limit: (int)numGetServiceRoutinesLimit.Value));
    }

    private void btnGetPreferredDataTypes_Click(object sender, EventArgs e)
    {
        Show(gridPreferredDataTypes, _robot.Rws.Rapid.GetPreferredDataTypes(Task,
                                                                            txtGetPreferredDataTypesInstruction.Text,
                                                                            txtGetPreferredDataTypesParameter.Text));
    }

    private void btnGetPalletHeads_Click(object sender, EventArgs e)
    {
        Show(gridPalletHeads, _robot.Rws.Rapid.GetPalletHeads(Task));
    }

    private void btnGetPallet_Click(object sender, EventArgs e)
    {
        Show(gridPallet, _robot.Rws.Rapid.GetPallet(Task, (int)numGetPalletNumber.Value));
    }

    #endregion

    #region Program

    private void btnGetProgram_Click(object sender, EventArgs e)
    {
        // Null when the task holds no program, which the grid shows as an empty selection
        Show(gridProgram, _robot.Rws.Rapid.GetProgram(Task));
    }

    private void btnLoadProgram_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.LoadProgram(Task, txtLoadProgramPath.Text,
                                     SelectedValue<RapidProgramLoadMode>(cboLoadProgramLoadMode));
    }

    private void btnUnloadProgram_Click(object sender, EventArgs e)
    {
        if (!Confirm($"Unload the program of {Task}?", "Unload program")) return;

        _robot.Rws.Rapid.UnloadProgram(Task);
    }

    private void btnSaveProgram_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.SaveProgram(Task, txtSaveProgramPath.Text);
    }

    private void btnSetProgramName_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.SetProgramName(Task, txtSetProgramNameName.Text);
        Show(gridProgram, _robot.Rws.Rapid.GetProgram(Task));
    }

    private void btnSetEntryPoint_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.SetEntryPoint(Task, txtSetEntryPointRoutine.Text);
        Show(gridProgram, _robot.Rws.Rapid.GetProgram(Task));
    }

    private void btnGetBreakpoints_Click(object sender, EventArgs e)
    {
        Show(gridBreakpoints, _robot.Rws.Rapid.GetBreakpoints(Task));
    }

    private void btnSetBreakpoint_Click(object sender, EventArgs e)
    {
        // The controller snaps the breakpoint to the whole instruction containing that position
        _robot.Rws.Rapid.SetBreakpoint(Task, Module,
                                       (int)numSetBreakpointRow.Value,
                                       (int)numSetBreakpointColumn.Value);

        Show(gridBreakpoints, _robot.Rws.Rapid.GetBreakpoints(Task));
    }

    private void btnGetBuildErrors_Click(object sender, EventArgs e)
    {
        Show(gridBuildErrors, _robot.Rws.Rapid.GetBuildErrors(Task));
    }

    private void btnGetPointers_Click(object sender, EventArgs e)
    {
        Show(gridPointers, _robot.Rws.Rapid.GetPointers(Task));
    }

    private void btnGetProgramCounterPosition_Click(object sender, EventArgs e)
    {
        // Refused when the task has no program pointer set, rather than answered empty
        Show(gridProgramCounterPosition, _robot.Rws.Rapid.GetProgramCounterPosition(Task));
    }

    private void btnSetProgramPointerToCursor_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.SetProgramPointerToCursor(Task, Module, txtSetProgramPointerRoutine.Text,
                                                   (int)numSetProgramPointerRow.Value,
                                                   (int)numSetProgramPointerColumn.Value);

        Show(gridPointers, _robot.Rws.Rapid.GetPointers(Task));
    }

    private void btnSetProgramPointerToRoutine_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.SetProgramPointerToRoutine(Task, Module, txtSetProgramPointerRoutine.Text,
                                                    chkSetProgramPointerUserLevel.Checked);

        Show(gridPointers, _robot.Rws.Rapid.GetPointers(Task));
    }

    private void btnSetProgramPointerToNextInstruction_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.SetProgramPointerToNextInstruction(Task);
        Show(gridPointers, _robot.Rws.Rapid.GetPointers(Task));
    }

    private void btnSetProgramPointerToPreviousInstruction_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.SetProgramPointerToPreviousInstruction(Task);
        Show(gridPointers, _robot.Rws.Rapid.GetPointers(Task));
    }

    private void btnSetProgramPointerToRoutineUrl_Click(object sender, EventArgs e)
    {
        // The paths the service routine list reports are what this takes
        _robot.Rws.Rapid.SetProgramPointerToRoutineUrl(Task, txtSetProgramPointerToRoutineUrlRoutineUrl.Text,
                                                       chkSetProgramPointerUserLevel.Checked);

        Show(gridPointers, _robot.Rws.Rapid.GetPointers(Task));
    }

    #endregion

    #region Modules

    private void btnGetModules_Click(object sender, EventArgs e)
    {
        Show(gridModules, _robot.Rws.Rapid.GetModules(Task));
    }

    private void btnGetModule_Click(object sender, EventArgs e)
    {
        Show(gridModule, _robot.Rws.Rapid.GetModule(Task, Module));
    }

    private void btnGetModuleChangeCount_Click(object sender, EventArgs e)
    {
        txtModuleChangeCount.Text = _robot.Rws.Rapid.GetModuleChangeCount(Task, Module).ToString();
    }

    private void btnGetModuleExtension_Click(object sender, EventArgs e)
    {
        Show(gridModuleExtension, _robot.Rws.Rapid.GetModuleExtension(Task, Module));
    }

    private void btnGetModuleText_Click(object sender, EventArgs e)
    {
        var text = _robot.Rws.Rapid.GetModuleText(Task, Module);

        // the box keeps the line breaks of the controller, which are not the ones a multiline TextBox draws
        memoModuleText.Text = Normalize(text.Text);
    }

    private void btnSetModuleText_Click(object sender, EventArgs e)
    {
        if (!Confirm($"Replace the whole source of {Module}? What it holds now is overwritten.",
                     "Set module text")) return;

        _robot.Rws.Rapid.SetModuleText(Task, Module, memoModuleText.Text);
    }

    private void btnGetModuleTextRange_Click(object sender, EventArgs e)
    {
        memoModuleTextRange.Text = Normalize(_robot.Rws.Rapid.GetModuleTextRange(
            Task, Module,
            (int)numModuleTextRangeStartRow.Value, (int)numModuleTextRangeStartColumn.Value,
            (int)numModuleTextRangeEndRow.Value, (int)numModuleTextRangeEndColumn.Value));
    }

    private void btnSetModuleTextRange_Click(object sender, EventArgs e)
    {
        if (!Confirm($"Write that text into {Module}?", "Set module text range")) return;

        Show(gridSetModuleTextRangeResult, _robot.Rws.Rapid.SetModuleTextRange(
            Task, Module,
            SelectedValue<RapidTextReplaceMode>(cboSetModuleTextRangeReplaceMode),
            SelectedValue<RapidTextQueryMode>(cboSetModuleTextRangeQueryMode),
            (int)numModuleTextRangeStartRow.Value, (int)numModuleTextRangeStartColumn.Value,
            (int)numModuleTextRangeEndRow.Value, (int)numModuleTextRangeEndColumn.Value,
            memoModuleTextRange.Text));
    }

    private void btnSearchModuleText_Click(object sender, EventArgs e)
    {
        // Row and column 0 mean the text was not found, which is an answer and not a failure
        Show(gridSearchModuleText, _robot.Rws.Rapid.SearchModuleText(Task, Module, txtSearchModuleTextText.Text,
                                                                     (int)numSearchModuleTextStartRow.Value,
                                                                     (int)numSearchModuleTextStartColumn.Value));
    }

    private void btnGetSyncPersStatus_Click(object sender, EventArgs e)
    {
        chkSyncPersStatus.Checked = _robot.Rws.Rapid.GetSyncPersStatus(Task, Module);
    }

    private void btnSyncPersistentVariables_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.SyncPersistentVariables(Task, Module);
        chkSyncPersStatus.Checked = _robot.Rws.Rapid.GetSyncPersStatus(Task, Module);
    }

    private void btnGetPossibleModuleAttributes_Click(object sender, EventArgs e)
    {
        Show(gridPossibleModuleAttributes, _robot.Rws.Rapid.GetPossibleModuleAttributes(
            Task, Module,
            RapidModuleAttribute.SystemModule,
            RapidModuleAttribute.NoStepIn,
            RapidModuleAttribute.ViewOnly,
            RapidModuleAttribute.ReadOnly));
    }

    private void btnSaveModule_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.SaveModule(Task, Module, txtSaveModuleName.Text, txtSaveModulePath.Text);
    }

    private void btnGetModuleSymbol_Click(object sender, EventArgs e)
    {
        // Null where nothing is declared, which the grid shows as an empty selection
        Show(gridModuleSymbol, _robot.Rws.Rapid.GetModuleSymbol(Task, Module,
                                                                (int)numGetModuleSymbolRow.Value,
                                                                (int)numGetModuleSymbolColumn.Value));
    }

    private void btnGetRoutine_Click(object sender, EventArgs e)
    {
        // Refused when the position does not sit on a routine call
        Show(gridRoutine, _robot.Rws.Rapid.GetRoutine(Task, Module,
                                                      (int)numGetRoutineRow.Value,
                                                      (int)numGetRoutineColumn.Value));
    }

    private void btnGetRoutineArguments_Click(object sender, EventArgs e)
    {
        Show(gridRoutineArguments, _robot.Rws.Rapid.GetRoutineArguments(Task, Module,
                                                                        (int)numGetRoutineRow.Value,
                                                                        (int)numGetRoutineColumn.Value));
    }

    private void btnGetInstructionTemplate_Click(object sender, EventArgs e)
    {
        Show(gridInstructionTemplate, _robot.Rws.Rapid.GetInstructionTemplate(
            Task, Module, txtGetInstructionTemplateName.Text,
            chkGetInstructionTemplateIsDataType.Checked));
    }

    private void btnGetObjectChildren_Click(object sender, EventArgs e)
    {
        // The span has to cover a whole object, the module itself being the usual one to ask about
        Show(gridObjectChildren, _robot.Rws.Rapid.GetObjectChildren(
            Task, Module,
            (int)numObjectChildStartLine.Value, (int)numObjectChildStartColumn.Value,
            (int)numObjectChildEndLine.Value, (int)numObjectChildEndColumn.Value));
    }

    private void btnGetModifiablePositions_Click(object sender, EventArgs e)
    {
        Show(gridModifiablePositions, _robot.Rws.Rapid.GetModifiablePositions(
            Task, Module,
            (int)numModifiablePositionsStartRow.Value, 1,
            (int)numModifiablePositionsEndRow.Value, 1));
    }

    private void btnModifyPosition_Click(object sender, EventArgs e)
    {
        if (!Confirm("Rewrite the taught positions of that range to where the robot stands? " +
                     "The positions they hold now are lost.", "Modify position")) return;

        _robot.Rws.Rapid.ModifyPosition(Task, Module,
                                        (int)numModifiablePositionsStartRow.Value, 1,
                                        (int)numModifiablePositionsEndRow.Value, 1);
    }

    private void btnGetAllModifiablePositions_Click(object sender, EventArgs e)
    {
        Show(gridAllModifiablePositions, _robot.Rws.Rapid.GetAllModifiablePositions());
    }

    private void btnModifyAllPositions_Click(object sender, EventArgs e)
    {
        if (!Confirm("Rewrite every modifiable position of the system to where the robot stands? " +
                     "The positions they hold now are lost.", "Modify all positions")) return;

        _robot.Rws.Rapid.ModifyAllPositions();
    }

    // The controller writes its line breaks the way RAPID stores them, which a multiline TextBox does not draw
    private static string Normalize(string? text)
    {
        if (string.IsNullOrEmpty(text))
            return string.Empty;

        return text.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", Environment.NewLine);
    }

    #endregion

    #region Symbols

    private void btnGetSymbolProperties_Click(object sender, EventArgs e)
    {
        Show(gridSymbolProperties, _robot.Rws.Rapid.GetSymbolProperties(txtSymbolUrl.Text));
    }

    private void btnGetSymbolValue_Click(object sender, EventArgs e)
    {
        var value = _robot.Rws.Rapid.GetSymbolValue(txtSymbolUrl.Text);
        Show(gridSymbolValue, value);

        // so that the write below starts from what the symbol holds rather than from an empty box
        txtSetSymbolValueValue.Text = value.Value ?? string.Empty;
    }

    private void btnSetSymbolValue_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.SetSymbolValue(txtSymbolUrl.Text, txtSetSymbolValueValue.Text);
        Show(gridSymbolValue, _robot.Rws.Rapid.GetSymbolValue(txtSymbolUrl.Text));
    }

    private void btnSetSymbolInitialValue_Click(object sender, EventArgs e)
    {
        if (!Confirm("Rewrite the declaration of that symbol? This changes the source of its module.",
                     "Set initial value")) return;

        _robot.Rws.Rapid.SetSymbolInitialValue(txtSymbolUrl.Text, txtSetSymbolValueValue.Text);
        Show(gridSymbolValue, _robot.Rws.Rapid.GetSymbolValue(txtSymbolUrl.Text));
    }

    private void btnSearchSymbols_Click(object sender, EventArgs e)
    {
        var criteria = new RapidSymbolSearchCriteria
        {
            View = SelectedValue<RapidSymbolSearchView>(cboSearchSymbolsView),
            BlockUrl = txtSearchSymbolsBlockUrl.Text,
            Recursive = chkSearchSymbolsRecursive.Checked,
            OnlyUsed = false,
            SkipShared = false,
            NamePattern = Optional(txtSearchSymbolsNamePattern),
            DataType = Optional(txtSearchSymbolsDataType),
            SymbolTypes = new[] { SelectedValue<RapidSymbolType>(cboSearchSymbolsSymbolType) },
        };

        Show(gridSearchSymbols, _robot.Rws.Rapid.SearchSymbols(criteria));
    }

    private void btnValidateSymbolValue_Click(object sender, EventArgs e)
    {
        // A bare word is accepted for any type, because RAPID reads it as the name of another symbol
        chkValidateResult.Checked = _robot.Rws.Rapid.ValidateSymbolValue(Task, txtValidateDataType.Text,
                                                                         txtValidateValue.Text);
    }

    private void btnGetObjectListExtension_Click(object sender, EventArgs e)
    {
        Show(gridObjectListExtension, _robot.Rws.Rapid.GetObjectListExtension(
            txtObjectListExtensionSymbolUrl.Text,
            SelectedValue<RapidObjectListType>(cboObjectListExtensionType)));
    }

    #endregion

    #region Motion

    private void btnGetRobTarget_Click(object sender, EventArgs e)
    {
        // Millimetres and degrees here, unlike the kinematics of the motion system service
        Show(gridRobTarget, _robot.Rws.Rapid.GetRobTarget(Task,
                                                          Optional(txtGetRobTargetTool),
                                                          Optional(txtGetRobTargetWorkObject)));
    }

    private void btnGetJointTarget_Click(object sender, EventArgs e)
    {
        Show(gridJointTarget, _robot.Rws.Rapid.GetJointTarget(Task));
    }

    private void btnGetExternalJointStates_Click(object sender, EventArgs e)
    {
        Show(gridExternalJointStates, _robot.Rws.Rapid.GetExternalJointStates(Task));
    }

    private void btnGetRapidMechanicalUnits_Click(object sender, EventArgs e)
    {
        Show(gridRapidMechanicalUnits, _robot.Rws.Rapid.GetMechanicalUnits(Task));
    }

    #endregion

    #region UI instructions

    private void btnGetActiveUiInstruction_Click(object sender, EventArgs e)
    {
        var instruction = _robot.Rws.Rapid.GetActiveUiInstruction();
        Show(gridActiveUiInstruction, instruction);

        // the path of the pending call is what the two panels below need, so it is filled in from here
        if (instruction != null)
            txtUiStackUrl.Text = instruction.StackUrl ?? string.Empty;
    }

    private void btnGetUiInstructionParameters_Click(object sender, EventArgs e)
    {
        Show(gridUiInstructionParameters, _robot.Rws.Rapid.GetUiInstructionParameters(txtUiStackUrl.Text));
    }

    private void btnGetUiInstructionParameter_Click(object sender, EventArgs e)
    {
        txtUiParameterValue.Text = _robot.Rws.Rapid.GetUiInstructionParameter(txtUiStackUrl.Text,
                                                                              txtUiParameterName.Text) ?? string.Empty;
    }

    private void btnSetUiInstructionParameter_Click(object sender, EventArgs e)
    {
        _robot.Rws.Rapid.SetUiInstructionParameter(txtUiStackUrl.Text, txtUiParameterName.Text,
                                                   txtSetUiInstructionParameterValue.Text);
    }

    #endregion
}
