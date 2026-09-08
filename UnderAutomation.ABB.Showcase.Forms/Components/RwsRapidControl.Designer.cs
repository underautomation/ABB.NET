partial class RwsRapidControl
{
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Code généré par le Concepteur de composants

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
        pnlHeader = new Panel();
        lblMastershipStatus = new Label();
        btnTakeMastership = new Button();
        btnReleaseMastership = new Button();
        txtModule = new TextBox();
        lblModule = new Label();
        txtTask = new TextBox();
        lblTask = new Label();
        tabControl = new TabControl();
        tabExecution = new TabPage();
        flowExecution = new FlowLayoutPanel();
        pnlExecutionState = new Panel();
        gridExecutionState = new PropertyGrid();
        sep1 = new Panel();
        btnGetExecutionState = new Button();
        pnlStart = new Panel();
        btnStart = new Button();
        sep8 = new Panel();
        chkStartAllTasksBySelection = new CheckBox();
        sep7 = new Panel();
        chkStartStopAtBreakpoint = new CheckBox();
        sep6 = new Panel();
        cboStartCondition = new ComboBox();
        sep5 = new Panel();
        cboStartCycle = new ComboBox();
        sep4 = new Panel();
        cboStartExecutionMode = new ComboBox();
        sep3 = new Panel();
        cboStartRegain = new ComboBox();
        sep2 = new Panel();
        lblStart = new Label();
        pnlStop = new Panel();
        btnStop = new Button();
        sep11 = new Panel();
        cboStopScope = new ComboBox();
        sep10 = new Panel();
        cboStopStopMode = new ComboBox();
        sep9 = new Panel();
        lblStop = new Label();
        pnlProductionEntry = new Panel();
        btnResetProgramPointer = new Button();
        sep12 = new Panel();
        btnStartFromProductionEntry = new Button();
        pnlExecutionCycle = new Panel();
        btnSetExecutionCycle = new Button();
        sep13 = new Panel();
        cboSetExecutionCycleCycle = new ComboBox();
        pnlHoldToRun = new Panel();
        btnSetHoldToRun = new Button();
        sep14 = new Panel();
        cboSetHoldToRunState = new ComboBox();
        pnlTaskSelection = new Panel();
        gridTaskSelection = new PropertyGrid();
        sep15 = new Panel();
        btnGetTaskSelection = new Button();
        pnlAliasIo = new Panel();
        gridAliasIo = new PropertyGrid();
        sep16 = new Panel();
        btnGetAliasIo = new Button();
        tabTasks = new TabPage();
        flowTasks = new FlowLayoutPanel();
        pnlTasks = new Panel();
        gridTasks = new PropertyGrid();
        sep17 = new Panel();
        btnGetTasks = new Button();
        pnlTask = new Panel();
        gridTask = new PropertyGrid();
        sep18 = new Panel();
        btnGetTask = new Button();
        pnlTaskActivation = new Panel();
        btnDeactivateTasks = new Button();
        sep21 = new Panel();
        btnActivateTasks = new Button();
        sep20 = new Panel();
        btnDeactivateTask = new Button();
        sep19 = new Panel();
        btnActivateTask = new Button();
        pnlBuildTask = new Panel();
        btnAbortExecutionLevel = new Button();
        sep22 = new Panel();
        btnBuildTask = new Button();
        pnlLoadModule = new Panel();
        btnUnloadModule = new Button();
        sep26 = new Panel();
        txtLoadModuleResult = new TextBox();
        sep25 = new Panel();
        btnLoadModule = new Button();
        sep24 = new Panel();
        chkLoadModuleReplace = new CheckBox();
        sep23 = new Panel();
        txtLoadModulePath = new TextBox();
        pnlSpy = new Panel();
        btnStopSpy = new Button();
        sep30 = new Panel();
        btnStartSpy = new Button();
        sep29 = new Panel();
        txtStartSpyLogFile = new TextBox();
        sep28 = new Panel();
        txtSpyStatus = new TextBox();
        sep27 = new Panel();
        btnGetSpyStatus = new Button();
        pnlSyncState = new Panel();
        txtTaskMotionPointerSyncState = new TextBox();
        sep37 = new Panel();
        btnGetTaskMotionPointerSyncState = new Button();
        sep36 = new Panel();
        txtTaskProgramPointerSyncState = new TextBox();
        sep35 = new Panel();
        btnGetTaskProgramPointerSyncState = new Button();
        sep34 = new Panel();
        txtMotionPointerSyncState = new TextBox();
        sep33 = new Panel();
        btnGetMotionPointerSyncState = new Button();
        sep32 = new Panel();
        txtProgramPointerSyncState = new TextBox();
        sep31 = new Panel();
        btnGetProgramPointerSyncState = new Button();
        pnlStructuralChangeCount = new Panel();
        gridStructuralChangeCount = new PropertyGrid();
        sep38 = new Panel();
        btnGetStructuralChangeCount = new Button();
        pnlActivationRecord = new Panel();
        gridActivationRecord = new PropertyGrid();
        sep40 = new Panel();
        btnGetActivationRecord = new Button();
        sep39 = new Panel();
        numGetActivationRecordStackFrame = new NumericUpDown();
        pnlServiceRoutines = new Panel();
        gridServiceRoutines = new PropertyGrid();
        sep42 = new Panel();
        btnGetServiceRoutines = new Button();
        sep41 = new Panel();
        numGetServiceRoutinesLimit = new NumericUpDown();
        pnlPreferredDataTypes = new Panel();
        gridPreferredDataTypes = new PropertyGrid();
        sep45 = new Panel();
        btnGetPreferredDataTypes = new Button();
        sep44 = new Panel();
        txtGetPreferredDataTypesParameter = new TextBox();
        sep43 = new Panel();
        txtGetPreferredDataTypesInstruction = new TextBox();
        pnlPalletHeads = new Panel();
        gridPalletHeads = new PropertyGrid();
        sep46 = new Panel();
        btnGetPalletHeads = new Button();
        pnlPallet = new Panel();
        gridPallet = new PropertyGrid();
        sep48 = new Panel();
        btnGetPallet = new Button();
        sep47 = new Panel();
        numGetPalletNumber = new NumericUpDown();
        tabProgram = new TabPage();
        flowProgram = new FlowLayoutPanel();
        pnlProgram = new Panel();
        gridProgram = new PropertyGrid();
        sep49 = new Panel();
        btnGetProgram = new Button();
        pnlLoadProgram = new Panel();
        btnUnloadProgram = new Button();
        sep52 = new Panel();
        btnLoadProgram = new Button();
        sep51 = new Panel();
        cboLoadProgramLoadMode = new ComboBox();
        sep50 = new Panel();
        txtLoadProgramPath = new TextBox();
        pnlSaveProgram = new Panel();
        btnSaveProgram = new Button();
        sep53 = new Panel();
        txtSaveProgramPath = new TextBox();
        pnlProgramName = new Panel();
        btnSetEntryPoint = new Button();
        sep56 = new Panel();
        txtSetEntryPointRoutine = new TextBox();
        sep55 = new Panel();
        btnSetProgramName = new Button();
        sep54 = new Panel();
        txtSetProgramNameName = new TextBox();
        pnlBreakpoints = new Panel();
        btnSetBreakpoint = new Button();
        sep60 = new Panel();
        numSetBreakpointColumn = new NumericUpDown();
        sep59 = new Panel();
        numSetBreakpointRow = new NumericUpDown();
        sep58 = new Panel();
        gridBreakpoints = new PropertyGrid();
        sep57 = new Panel();
        btnGetBreakpoints = new Button();
        pnlBuildErrors = new Panel();
        gridBuildErrors = new PropertyGrid();
        sep61 = new Panel();
        btnGetBuildErrors = new Button();
        pnlPointers = new Panel();
        gridPointers = new PropertyGrid();
        sep62 = new Panel();
        btnGetPointers = new Button();
        pnlProgramCounterPosition = new Panel();
        gridProgramCounterPosition = new PropertyGrid();
        sep63 = new Panel();
        btnGetProgramCounterPosition = new Button();
        pnlProgramPointerMoves = new Panel();
        btnSetProgramPointerToPreviousInstruction = new Button();
        sep71 = new Panel();
        btnSetProgramPointerToNextInstruction = new Button();
        sep70 = new Panel();
        btnSetProgramPointerToRoutine = new Button();
        sep69 = new Panel();
        btnSetProgramPointerToCursor = new Button();
        sep68 = new Panel();
        chkSetProgramPointerUserLevel = new CheckBox();
        sep67 = new Panel();
        numSetProgramPointerColumn = new NumericUpDown();
        sep66 = new Panel();
        numSetProgramPointerRow = new NumericUpDown();
        sep65 = new Panel();
        txtSetProgramPointerRoutine = new TextBox();
        sep64 = new Panel();
        lblProgramPointer = new Label();
        pnlProgramPointerUrl = new Panel();
        btnSetProgramPointerToRoutineUrl = new Button();
        sep72 = new Panel();
        txtSetProgramPointerToRoutineUrlRoutineUrl = new TextBox();
        tabModules = new TabPage();
        flowModules = new FlowLayoutPanel();
        pnlModules = new Panel();
        gridModules = new PropertyGrid();
        sep73 = new Panel();
        btnGetModules = new Button();
        pnlModule = new Panel();
        gridModule = new PropertyGrid();
        sep74 = new Panel();
        btnGetModule = new Button();
        pnlModuleCounters = new Panel();
        gridModuleExtension = new PropertyGrid();
        sep77 = new Panel();
        btnGetModuleExtension = new Button();
        sep76 = new Panel();
        txtModuleChangeCount = new TextBox();
        sep75 = new Panel();
        btnGetModuleChangeCount = new Button();
        pnlModuleText = new Panel();
        btnSetModuleText = new Button();
        sep79 = new Panel();
        memoModuleText = new TextBox();
        sep78 = new Panel();
        btnGetModuleText = new Button();
        pnlModuleTextRange = new Panel();
        gridSetModuleTextRangeResult = new PropertyGrid();
        sep89 = new Panel();
        btnSetModuleTextRange = new Button();
        sep88 = new Panel();
        cboSetModuleTextRangeQueryMode = new ComboBox();
        sep87 = new Panel();
        cboSetModuleTextRangeReplaceMode = new ComboBox();
        sep86 = new Panel();
        memoModuleTextRange = new TextBox();
        sep85 = new Panel();
        btnGetModuleTextRange = new Button();
        sep84 = new Panel();
        numModuleTextRangeEndColumn = new NumericUpDown();
        sep83 = new Panel();
        numModuleTextRangeEndRow = new NumericUpDown();
        sep82 = new Panel();
        numModuleTextRangeStartColumn = new NumericUpDown();
        sep81 = new Panel();
        numModuleTextRangeStartRow = new NumericUpDown();
        sep80 = new Panel();
        lblModuleTextRange = new Label();
        pnlSearchModuleText = new Panel();
        gridSearchModuleText = new PropertyGrid();
        sep93 = new Panel();
        btnSearchModuleText = new Button();
        sep92 = new Panel();
        numSearchModuleTextStartColumn = new NumericUpDown();
        sep91 = new Panel();
        numSearchModuleTextStartRow = new NumericUpDown();
        sep90 = new Panel();
        txtSearchModuleTextText = new TextBox();
        pnlSyncPers = new Panel();
        btnSyncPersistentVariables = new Button();
        sep95 = new Panel();
        chkSyncPersStatus = new CheckBox();
        sep94 = new Panel();
        btnGetSyncPersStatus = new Button();
        pnlModuleAttributes = new Panel();
        gridPossibleModuleAttributes = new PropertyGrid();
        sep96 = new Panel();
        btnGetPossibleModuleAttributes = new Button();
        pnlSaveModule = new Panel();
        btnSaveModule = new Button();
        sep98 = new Panel();
        txtSaveModulePath = new TextBox();
        sep97 = new Panel();
        txtSaveModuleName = new TextBox();
        pnlModuleSymbol = new Panel();
        gridModuleSymbol = new PropertyGrid();
        sep101 = new Panel();
        btnGetModuleSymbol = new Button();
        sep100 = new Panel();
        numGetModuleSymbolColumn = new NumericUpDown();
        sep99 = new Panel();
        numGetModuleSymbolRow = new NumericUpDown();
        pnlRoutine = new Panel();
        gridRoutine = new PropertyGrid();
        sep104 = new Panel();
        btnGetRoutine = new Button();
        sep103 = new Panel();
        numGetRoutineColumn = new NumericUpDown();
        sep102 = new Panel();
        numGetRoutineRow = new NumericUpDown();
        pnlRoutineArguments = new Panel();
        gridRoutineArguments = new PropertyGrid();
        sep105 = new Panel();
        btnGetRoutineArguments = new Button();
        pnlInstructionTemplate = new Panel();
        gridInstructionTemplate = new PropertyGrid();
        sep108 = new Panel();
        btnGetInstructionTemplate = new Button();
        sep107 = new Panel();
        chkGetInstructionTemplateIsDataType = new CheckBox();
        sep106 = new Panel();
        txtGetInstructionTemplateName = new TextBox();
        pnlObjectChildren = new Panel();
        gridObjectChildren = new PropertyGrid();
        sep114 = new Panel();
        btnGetObjectChildren = new Button();
        sep113 = new Panel();
        numObjectChildEndColumn = new NumericUpDown();
        sep112 = new Panel();
        numObjectChildEndLine = new NumericUpDown();
        sep111 = new Panel();
        numObjectChildStartColumn = new NumericUpDown();
        sep110 = new Panel();
        numObjectChildStartLine = new NumericUpDown();
        sep109 = new Panel();
        lblObjectChildren = new Label();
        pnlModifiablePositions = new Panel();
        btnModifyPosition = new Button();
        sep119 = new Panel();
        gridModifiablePositions = new PropertyGrid();
        sep118 = new Panel();
        btnGetModifiablePositions = new Button();
        sep117 = new Panel();
        numModifiablePositionsEndRow = new NumericUpDown();
        sep116 = new Panel();
        numModifiablePositionsStartRow = new NumericUpDown();
        sep115 = new Panel();
        lblModifiablePositions = new Label();
        pnlAllModifiablePositions = new Panel();
        btnModifyAllPositions = new Button();
        sep121 = new Panel();
        gridAllModifiablePositions = new PropertyGrid();
        sep120 = new Panel();
        btnGetAllModifiablePositions = new Button();
        tabSymbols = new TabPage();
        flowSymbols = new FlowLayoutPanel();
        pnlSymbolProperties = new Panel();
        gridSymbolProperties = new PropertyGrid();
        sep123 = new Panel();
        btnGetSymbolProperties = new Button();
        sep122 = new Panel();
        txtSymbolUrl = new TextBox();
        pnlSymbolValue = new Panel();
        btnSetSymbolInitialValue = new Button();
        sep127 = new Panel();
        btnSetSymbolValue = new Button();
        sep126 = new Panel();
        txtSetSymbolValueValue = new TextBox();
        sep125 = new Panel();
        gridSymbolValue = new PropertyGrid();
        sep124 = new Panel();
        btnGetSymbolValue = new Button();
        pnlSearchSymbols = new Panel();
        gridSearchSymbols = new PropertyGrid();
        sep135 = new Panel();
        btnSearchSymbols = new Button();
        sep134 = new Panel();
        chkSearchSymbolsRecursive = new CheckBox();
        sep133 = new Panel();
        txtSearchSymbolsDataType = new TextBox();
        sep132 = new Panel();
        txtSearchSymbolsNamePattern = new TextBox();
        sep131 = new Panel();
        cboSearchSymbolsSymbolType = new ComboBox();
        sep130 = new Panel();
        cboSearchSymbolsView = new ComboBox();
        sep129 = new Panel();
        txtSearchSymbolsBlockUrl = new TextBox();
        sep128 = new Panel();
        lblSearchSymbols = new Label();
        pnlValidate = new Panel();
        chkValidateResult = new CheckBox();
        sep138 = new Panel();
        btnValidateSymbolValue = new Button();
        sep137 = new Panel();
        txtValidateValue = new TextBox();
        sep136 = new Panel();
        txtValidateDataType = new TextBox();
        pnlObjectListExtension = new Panel();
        gridObjectListExtension = new PropertyGrid();
        sep141 = new Panel();
        btnGetObjectListExtension = new Button();
        sep140 = new Panel();
        cboObjectListExtensionType = new ComboBox();
        sep139 = new Panel();
        txtObjectListExtensionSymbolUrl = new TextBox();
        tabMotion = new TabPage();
        flowMotion = new FlowLayoutPanel();
        pnlRobTarget = new Panel();
        gridRobTarget = new PropertyGrid();
        sep144 = new Panel();
        btnGetRobTarget = new Button();
        sep143 = new Panel();
        txtGetRobTargetWorkObject = new TextBox();
        sep142 = new Panel();
        txtGetRobTargetTool = new TextBox();
        pnlJointTarget = new Panel();
        gridJointTarget = new PropertyGrid();
        sep145 = new Panel();
        btnGetJointTarget = new Button();
        pnlExternalJointStates = new Panel();
        gridExternalJointStates = new PropertyGrid();
        sep146 = new Panel();
        btnGetExternalJointStates = new Button();
        pnlRapidMechanicalUnits = new Panel();
        gridRapidMechanicalUnits = new PropertyGrid();
        sep147 = new Panel();
        btnGetRapidMechanicalUnits = new Button();
        tabUiInstructions = new TabPage();
        flowUiInstructions = new FlowLayoutPanel();
        pnlActiveUiInstruction = new Panel();
        gridActiveUiInstruction = new PropertyGrid();
        sep148 = new Panel();
        btnGetActiveUiInstruction = new Button();
        pnlUiParameters = new Panel();
        gridUiInstructionParameters = new PropertyGrid();
        sep150 = new Panel();
        btnGetUiInstructionParameters = new Button();
        sep149 = new Panel();
        txtUiStackUrl = new TextBox();
        pnlUiParameter = new Panel();
        btnSetUiInstructionParameter = new Button();
        sep154 = new Panel();
        txtSetUiInstructionParameterValue = new TextBox();
        sep153 = new Panel();
        txtUiParameterValue = new TextBox();
        sep152 = new Panel();
        btnGetUiInstructionParameter = new Button();
        sep151 = new Panel();
        txtUiParameterName = new TextBox();
        pnlHeader.SuspendLayout();
        tabControl.SuspendLayout();
        tabExecution.SuspendLayout();
        flowExecution.SuspendLayout();
        pnlExecutionState.SuspendLayout();
        pnlStart.SuspendLayout();
        pnlStop.SuspendLayout();
        pnlProductionEntry.SuspendLayout();
        pnlExecutionCycle.SuspendLayout();
        pnlHoldToRun.SuspendLayout();
        pnlTaskSelection.SuspendLayout();
        pnlAliasIo.SuspendLayout();
        tabTasks.SuspendLayout();
        flowTasks.SuspendLayout();
        pnlTasks.SuspendLayout();
        pnlTask.SuspendLayout();
        pnlTaskActivation.SuspendLayout();
        pnlBuildTask.SuspendLayout();
        pnlLoadModule.SuspendLayout();
        pnlSpy.SuspendLayout();
        pnlSyncState.SuspendLayout();
        pnlStructuralChangeCount.SuspendLayout();
        pnlActivationRecord.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numGetActivationRecordStackFrame).BeginInit();
        pnlServiceRoutines.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numGetServiceRoutinesLimit).BeginInit();
        pnlPreferredDataTypes.SuspendLayout();
        pnlPalletHeads.SuspendLayout();
        pnlPallet.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numGetPalletNumber).BeginInit();
        tabProgram.SuspendLayout();
        flowProgram.SuspendLayout();
        pnlProgram.SuspendLayout();
        pnlLoadProgram.SuspendLayout();
        pnlSaveProgram.SuspendLayout();
        pnlProgramName.SuspendLayout();
        pnlBreakpoints.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numSetBreakpointColumn).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numSetBreakpointRow).BeginInit();
        pnlBuildErrors.SuspendLayout();
        pnlPointers.SuspendLayout();
        pnlProgramCounterPosition.SuspendLayout();
        pnlProgramPointerMoves.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numSetProgramPointerColumn).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numSetProgramPointerRow).BeginInit();
        pnlProgramPointerUrl.SuspendLayout();
        tabModules.SuspendLayout();
        flowModules.SuspendLayout();
        pnlModules.SuspendLayout();
        pnlModule.SuspendLayout();
        pnlModuleCounters.SuspendLayout();
        pnlModuleText.SuspendLayout();
        pnlModuleTextRange.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numModuleTextRangeEndColumn).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numModuleTextRangeEndRow).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numModuleTextRangeStartColumn).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numModuleTextRangeStartRow).BeginInit();
        pnlSearchModuleText.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numSearchModuleTextStartColumn).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numSearchModuleTextStartRow).BeginInit();
        pnlSyncPers.SuspendLayout();
        pnlModuleAttributes.SuspendLayout();
        pnlSaveModule.SuspendLayout();
        pnlModuleSymbol.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numGetModuleSymbolColumn).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numGetModuleSymbolRow).BeginInit();
        pnlRoutine.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numGetRoutineColumn).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numGetRoutineRow).BeginInit();
        pnlRoutineArguments.SuspendLayout();
        pnlInstructionTemplate.SuspendLayout();
        pnlObjectChildren.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numObjectChildEndColumn).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numObjectChildEndLine).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numObjectChildStartColumn).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numObjectChildStartLine).BeginInit();
        pnlModifiablePositions.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numModifiablePositionsEndRow).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numModifiablePositionsStartRow).BeginInit();
        pnlAllModifiablePositions.SuspendLayout();
        tabSymbols.SuspendLayout();
        flowSymbols.SuspendLayout();
        pnlSymbolProperties.SuspendLayout();
        pnlSymbolValue.SuspendLayout();
        pnlSearchSymbols.SuspendLayout();
        pnlValidate.SuspendLayout();
        pnlObjectListExtension.SuspendLayout();
        tabMotion.SuspendLayout();
        flowMotion.SuspendLayout();
        pnlRobTarget.SuspendLayout();
        pnlJointTarget.SuspendLayout();
        pnlExternalJointStates.SuspendLayout();
        pnlRapidMechanicalUnits.SuspendLayout();
        tabUiInstructions.SuspendLayout();
        flowUiInstructions.SuspendLayout();
        pnlActiveUiInstruction.SuspendLayout();
        pnlUiParameters.SuspendLayout();
        pnlUiParameter.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.FromArgb(255, 236, 179);
        pnlHeader.Controls.Add(lblMastershipStatus);
        pnlHeader.Controls.Add(btnTakeMastership);
        pnlHeader.Controls.Add(btnReleaseMastership);
        pnlHeader.Controls.Add(txtModule);
        pnlHeader.Controls.Add(lblModule);
        pnlHeader.Controls.Add(txtTask);
        pnlHeader.Controls.Add(lblTask);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new Padding(8, 6, 8, 6);
        pnlHeader.Size = new Size(890, 42);
        pnlHeader.TabIndex = 0;
        // 
        // lblMastershipStatus
        // 
        lblMastershipStatus.Dock = DockStyle.Fill;
        lblMastershipStatus.Location = new Point(351, 6);
        lblMastershipStatus.Name = "lblMastershipStatus";
        lblMastershipStatus.Size = new Size(199, 30);
        lblMastershipStatus.TabIndex = 6;
        lblMastershipStatus.Text = "2. Most writes need it";
        lblMastershipStatus.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnTakeMastership
        // 
        btnTakeMastership.Dock = DockStyle.Right;
        btnTakeMastership.Location = new Point(550, 6);
        btnTakeMastership.Name = "btnTakeMastership";
        btnTakeMastership.Size = new Size(162, 30);
        btnTakeMastership.TabIndex = 4;
        btnTakeMastership.Text = "1. Take mastership";
        btnTakeMastership.UseVisualStyleBackColor = true;
        btnTakeMastership.Click += btnTakeMastership_Click;
        // 
        // btnReleaseMastership
        // 
        btnReleaseMastership.Dock = DockStyle.Right;
        btnReleaseMastership.Location = new Point(712, 6);
        btnReleaseMastership.Name = "btnReleaseMastership";
        btnReleaseMastership.Size = new Size(170, 30);
        btnReleaseMastership.TabIndex = 5;
        btnReleaseMastership.Text = "3. Release mastership";
        btnReleaseMastership.UseVisualStyleBackColor = true;
        btnReleaseMastership.Click += btnReleaseMastership_Click;
        // 
        // txtModule
        // 
        txtModule.Dock = DockStyle.Left;
        txtModule.Location = new Point(211, 6);
        txtModule.Name = "txtModule";
        txtModule.Size = new Size(140, 23);
        txtModule.TabIndex = 3;
        txtModule.Text = "MainModule";
        // 
        // lblModule
        // 
        lblModule.Dock = DockStyle.Left;
        lblModule.Location = new Point(156, 6);
        lblModule.Name = "lblModule";
        lblModule.Size = new Size(55, 30);
        lblModule.TabIndex = 2;
        lblModule.Text = "Module";
        lblModule.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtTask
        // 
        txtTask.Dock = DockStyle.Left;
        txtTask.Location = new Point(46, 6);
        txtTask.Name = "txtTask";
        txtTask.Size = new Size(110, 23);
        txtTask.TabIndex = 1;
        txtTask.Text = "T_ROB1";
        // 
        // lblTask
        // 
        lblTask.Dock = DockStyle.Left;
        lblTask.Location = new Point(8, 6);
        lblTask.Name = "lblTask";
        lblTask.Size = new Size(38, 30);
        lblTask.TabIndex = 0;
        lblTask.Text = "Task";
        lblTask.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabExecution);
        tabControl.Controls.Add(tabTasks);
        tabControl.Controls.Add(tabProgram);
        tabControl.Controls.Add(tabModules);
        tabControl.Controls.Add(tabSymbols);
        tabControl.Controls.Add(tabMotion);
        tabControl.Controls.Add(tabUiInstructions);
        tabControl.Dock = DockStyle.Fill;
        tabControl.Location = new Point(0, 42);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(890, 449);
        tabControl.TabIndex = 1;
        // 
        // tabExecution
        // 
        tabExecution.Controls.Add(flowExecution);
        tabExecution.Location = new Point(4, 24);
        tabExecution.Name = "tabExecution";
        tabExecution.Padding = new Padding(3);
        tabExecution.Size = new Size(882, 421);
        tabExecution.TabIndex = 0;
        tabExecution.Text = "Execution";
        tabExecution.UseVisualStyleBackColor = true;
        // 
        // flowExecution
        // 
        flowExecution.AutoScroll = true;
        flowExecution.Controls.Add(pnlExecutionState);
        flowExecution.Controls.Add(pnlStart);
        flowExecution.Controls.Add(pnlStop);
        flowExecution.Controls.Add(pnlProductionEntry);
        flowExecution.Controls.Add(pnlExecutionCycle);
        flowExecution.Controls.Add(pnlHoldToRun);
        flowExecution.Controls.Add(pnlTaskSelection);
        flowExecution.Controls.Add(pnlAliasIo);
        flowExecution.Dock = DockStyle.Fill;
        flowExecution.FlowDirection = FlowDirection.TopDown;
        flowExecution.Location = new Point(3, 3);
        flowExecution.Name = "flowExecution";
        flowExecution.Size = new Size(876, 415);
        flowExecution.TabIndex = 0;
        // 
        // pnlExecutionState
        // 
        pnlExecutionState.BorderStyle = BorderStyle.FixedSingle;
        pnlExecutionState.Controls.Add(gridExecutionState);
        pnlExecutionState.Controls.Add(sep1);
        pnlExecutionState.Controls.Add(btnGetExecutionState);
        pnlExecutionState.Location = new Point(3, 3);
        pnlExecutionState.Name = "pnlExecutionState";
        pnlExecutionState.Padding = new Padding(5);
        pnlExecutionState.Size = new Size(250, 100);
        pnlExecutionState.TabIndex = 0;
        // 
        // gridExecutionState
        // 
        gridExecutionState.Dock = DockStyle.Top;
        gridExecutionState.HelpVisible = false;
        gridExecutionState.Location = new Point(5, 33);
        gridExecutionState.Name = "gridExecutionState";
        gridExecutionState.PropertySort = PropertySort.NoSort;
        gridExecutionState.Size = new Size(238, 60);
        gridExecutionState.TabIndex = 2;
        gridExecutionState.ToolbarVisible = false;
        // 
        // sep1
        // 
        sep1.Dock = DockStyle.Top;
        sep1.Location = new Point(5, 28);
        sep1.Name = "sep1";
        sep1.Size = new Size(238, 5);
        sep1.TabIndex = 1;
        // 
        // btnGetExecutionState
        // 
        btnGetExecutionState.Dock = DockStyle.Top;
        btnGetExecutionState.Location = new Point(5, 5);
        btnGetExecutionState.Name = "btnGetExecutionState";
        btnGetExecutionState.Size = new Size(238, 23);
        btnGetExecutionState.TabIndex = 0;
        btnGetExecutionState.Text = "Get Execution state";
        btnGetExecutionState.UseVisualStyleBackColor = true;
        btnGetExecutionState.Click += btnGetExecutionState_Click;
        // 
        // pnlStart
        // 
        pnlStart.BorderStyle = BorderStyle.FixedSingle;
        pnlStart.Controls.Add(btnStart);
        pnlStart.Controls.Add(sep8);
        pnlStart.Controls.Add(chkStartAllTasksBySelection);
        pnlStart.Controls.Add(sep7);
        pnlStart.Controls.Add(chkStartStopAtBreakpoint);
        pnlStart.Controls.Add(sep6);
        pnlStart.Controls.Add(cboStartCondition);
        pnlStart.Controls.Add(sep5);
        pnlStart.Controls.Add(cboStartCycle);
        pnlStart.Controls.Add(sep4);
        pnlStart.Controls.Add(cboStartExecutionMode);
        pnlStart.Controls.Add(sep3);
        pnlStart.Controls.Add(cboStartRegain);
        pnlStart.Controls.Add(sep2);
        pnlStart.Controls.Add(lblStart);
        pnlStart.Location = new Point(3, 109);
        pnlStart.Name = "pnlStart";
        pnlStart.Padding = new Padding(5);
        pnlStart.Size = new Size(250, 231);
        pnlStart.TabIndex = 1;
        // 
        // btnStart
        // 
        btnStart.Dock = DockStyle.Top;
        btnStart.Location = new Point(5, 201);
        btnStart.Name = "btnStart";
        btnStart.Size = new Size(238, 23);
        btnStart.TabIndex = 14;
        btnStart.Text = "Start";
        btnStart.UseVisualStyleBackColor = true;
        btnStart.Click += btnStart_Click;
        // 
        // sep8
        // 
        sep8.Dock = DockStyle.Top;
        sep8.Location = new Point(5, 196);
        sep8.Name = "sep8";
        sep8.Size = new Size(238, 5);
        sep8.TabIndex = 13;
        // 
        // chkStartAllTasksBySelection
        // 
        chkStartAllTasksBySelection.Dock = DockStyle.Top;
        chkStartAllTasksBySelection.Location = new Point(5, 173);
        chkStartAllTasksBySelection.Name = "chkStartAllTasksBySelection";
        chkStartAllTasksBySelection.Size = new Size(238, 23);
        chkStartAllTasksBySelection.TabIndex = 12;
        chkStartAllTasksBySelection.Text = "All tasks by selection";
        chkStartAllTasksBySelection.UseVisualStyleBackColor = true;
        // 
        // sep7
        // 
        sep7.Dock = DockStyle.Top;
        sep7.Location = new Point(5, 168);
        sep7.Name = "sep7";
        sep7.Size = new Size(238, 5);
        sep7.TabIndex = 11;
        // 
        // chkStartStopAtBreakpoint
        // 
        chkStartStopAtBreakpoint.Dock = DockStyle.Top;
        chkStartStopAtBreakpoint.Location = new Point(5, 145);
        chkStartStopAtBreakpoint.Name = "chkStartStopAtBreakpoint";
        chkStartStopAtBreakpoint.Size = new Size(238, 23);
        chkStartStopAtBreakpoint.TabIndex = 10;
        chkStartStopAtBreakpoint.Text = "Stop at breakpoint";
        chkStartStopAtBreakpoint.UseVisualStyleBackColor = true;
        // 
        // sep6
        // 
        sep6.Dock = DockStyle.Top;
        sep6.Location = new Point(5, 140);
        sep6.Name = "sep6";
        sep6.Size = new Size(238, 5);
        sep6.TabIndex = 9;
        // 
        // cboStartCondition
        // 
        cboStartCondition.Dock = DockStyle.Top;
        cboStartCondition.DropDownStyle = ComboBoxStyle.DropDownList;
        cboStartCondition.FormattingEnabled = true;
        cboStartCondition.Location = new Point(5, 117);
        cboStartCondition.Name = "cboStartCondition";
        cboStartCondition.Size = new Size(238, 23);
        cboStartCondition.TabIndex = 8;
        // 
        // sep5
        // 
        sep5.Dock = DockStyle.Top;
        sep5.Location = new Point(5, 112);
        sep5.Name = "sep5";
        sep5.Size = new Size(238, 5);
        sep5.TabIndex = 7;
        // 
        // cboStartCycle
        // 
        cboStartCycle.Dock = DockStyle.Top;
        cboStartCycle.DropDownStyle = ComboBoxStyle.DropDownList;
        cboStartCycle.FormattingEnabled = true;
        cboStartCycle.Location = new Point(5, 89);
        cboStartCycle.Name = "cboStartCycle";
        cboStartCycle.Size = new Size(238, 23);
        cboStartCycle.TabIndex = 6;
        // 
        // sep4
        // 
        sep4.Dock = DockStyle.Top;
        sep4.Location = new Point(5, 84);
        sep4.Name = "sep4";
        sep4.Size = new Size(238, 5);
        sep4.TabIndex = 5;
        // 
        // cboStartExecutionMode
        // 
        cboStartExecutionMode.Dock = DockStyle.Top;
        cboStartExecutionMode.DropDownStyle = ComboBoxStyle.DropDownList;
        cboStartExecutionMode.FormattingEnabled = true;
        cboStartExecutionMode.Location = new Point(5, 61);
        cboStartExecutionMode.Name = "cboStartExecutionMode";
        cboStartExecutionMode.Size = new Size(238, 23);
        cboStartExecutionMode.TabIndex = 4;
        // 
        // sep3
        // 
        sep3.Dock = DockStyle.Top;
        sep3.Location = new Point(5, 56);
        sep3.Name = "sep3";
        sep3.Size = new Size(238, 5);
        sep3.TabIndex = 3;
        // 
        // cboStartRegain
        // 
        cboStartRegain.Dock = DockStyle.Top;
        cboStartRegain.DropDownStyle = ComboBoxStyle.DropDownList;
        cboStartRegain.FormattingEnabled = true;
        cboStartRegain.Location = new Point(5, 33);
        cboStartRegain.Name = "cboStartRegain";
        cboStartRegain.Size = new Size(238, 23);
        cboStartRegain.TabIndex = 2;
        // 
        // sep2
        // 
        sep2.Dock = DockStyle.Top;
        sep2.Location = new Point(5, 28);
        sep2.Name = "sep2";
        sep2.Size = new Size(238, 5);
        sep2.TabIndex = 1;
        // 
        // lblStart
        // 
        lblStart.Dock = DockStyle.Top;
        lblStart.Location = new Point(5, 5);
        lblStart.Name = "lblStart";
        lblStart.Size = new Size(238, 23);
        lblStart.TabIndex = 0;
        lblStart.Text = "Start execution";
        lblStart.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlStop
        // 
        pnlStop.BorderStyle = BorderStyle.FixedSingle;
        pnlStop.Controls.Add(btnStop);
        pnlStop.Controls.Add(sep11);
        pnlStop.Controls.Add(cboStopScope);
        pnlStop.Controls.Add(sep10);
        pnlStop.Controls.Add(cboStopStopMode);
        pnlStop.Controls.Add(sep9);
        pnlStop.Controls.Add(lblStop);
        pnlStop.Location = new Point(259, 3);
        pnlStop.Name = "pnlStop";
        pnlStop.Padding = new Padding(5);
        pnlStop.Size = new Size(250, 119);
        pnlStop.TabIndex = 2;
        // 
        // btnStop
        // 
        btnStop.Dock = DockStyle.Top;
        btnStop.Location = new Point(5, 89);
        btnStop.Name = "btnStop";
        btnStop.Size = new Size(238, 23);
        btnStop.TabIndex = 6;
        btnStop.Text = "Stop";
        btnStop.UseVisualStyleBackColor = true;
        btnStop.Click += btnStop_Click;
        // 
        // sep11
        // 
        sep11.Dock = DockStyle.Top;
        sep11.Location = new Point(5, 84);
        sep11.Name = "sep11";
        sep11.Size = new Size(238, 5);
        sep11.TabIndex = 5;
        // 
        // cboStopScope
        // 
        cboStopScope.Dock = DockStyle.Top;
        cboStopScope.DropDownStyle = ComboBoxStyle.DropDownList;
        cboStopScope.FormattingEnabled = true;
        cboStopScope.Location = new Point(5, 61);
        cboStopScope.Name = "cboStopScope";
        cboStopScope.Size = new Size(238, 23);
        cboStopScope.TabIndex = 4;
        // 
        // sep10
        // 
        sep10.Dock = DockStyle.Top;
        sep10.Location = new Point(5, 56);
        sep10.Name = "sep10";
        sep10.Size = new Size(238, 5);
        sep10.TabIndex = 3;
        // 
        // cboStopStopMode
        // 
        cboStopStopMode.Dock = DockStyle.Top;
        cboStopStopMode.DropDownStyle = ComboBoxStyle.DropDownList;
        cboStopStopMode.FormattingEnabled = true;
        cboStopStopMode.Location = new Point(5, 33);
        cboStopStopMode.Name = "cboStopStopMode";
        cboStopStopMode.Size = new Size(238, 23);
        cboStopStopMode.TabIndex = 2;
        // 
        // sep9
        // 
        sep9.Dock = DockStyle.Top;
        sep9.Location = new Point(5, 28);
        sep9.Name = "sep9";
        sep9.Size = new Size(238, 5);
        sep9.TabIndex = 1;
        // 
        // lblStop
        // 
        lblStop.Dock = DockStyle.Top;
        lblStop.Location = new Point(5, 5);
        lblStop.Name = "lblStop";
        lblStop.Size = new Size(238, 23);
        lblStop.TabIndex = 0;
        lblStop.Text = "Stop execution";
        lblStop.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlProductionEntry
        // 
        pnlProductionEntry.BorderStyle = BorderStyle.FixedSingle;
        pnlProductionEntry.Controls.Add(btnResetProgramPointer);
        pnlProductionEntry.Controls.Add(sep12);
        pnlProductionEntry.Controls.Add(btnStartFromProductionEntry);
        pnlProductionEntry.Location = new Point(259, 128);
        pnlProductionEntry.Name = "pnlProductionEntry";
        pnlProductionEntry.Padding = new Padding(5);
        pnlProductionEntry.Size = new Size(250, 63);
        pnlProductionEntry.TabIndex = 3;
        // 
        // btnResetProgramPointer
        // 
        btnResetProgramPointer.Dock = DockStyle.Top;
        btnResetProgramPointer.Location = new Point(5, 33);
        btnResetProgramPointer.Name = "btnResetProgramPointer";
        btnResetProgramPointer.Size = new Size(238, 23);
        btnResetProgramPointer.TabIndex = 2;
        btnResetProgramPointer.Text = "Reset program pointer";
        btnResetProgramPointer.UseVisualStyleBackColor = true;
        btnResetProgramPointer.Click += btnResetProgramPointer_Click;
        // 
        // sep12
        // 
        sep12.Dock = DockStyle.Top;
        sep12.Location = new Point(5, 28);
        sep12.Name = "sep12";
        sep12.Size = new Size(238, 5);
        sep12.TabIndex = 1;
        // 
        // btnStartFromProductionEntry
        // 
        btnStartFromProductionEntry.Dock = DockStyle.Top;
        btnStartFromProductionEntry.Location = new Point(5, 5);
        btnStartFromProductionEntry.Name = "btnStartFromProductionEntry";
        btnStartFromProductionEntry.Size = new Size(238, 23);
        btnStartFromProductionEntry.TabIndex = 0;
        btnStartFromProductionEntry.Text = "Start from production entry";
        btnStartFromProductionEntry.UseVisualStyleBackColor = true;
        btnStartFromProductionEntry.Click += btnStartFromProductionEntry_Click;
        // 
        // pnlExecutionCycle
        // 
        pnlExecutionCycle.BorderStyle = BorderStyle.FixedSingle;
        pnlExecutionCycle.Controls.Add(btnSetExecutionCycle);
        pnlExecutionCycle.Controls.Add(sep13);
        pnlExecutionCycle.Controls.Add(cboSetExecutionCycleCycle);
        pnlExecutionCycle.Location = new Point(259, 197);
        pnlExecutionCycle.Name = "pnlExecutionCycle";
        pnlExecutionCycle.Padding = new Padding(5);
        pnlExecutionCycle.Size = new Size(250, 63);
        pnlExecutionCycle.TabIndex = 4;
        // 
        // btnSetExecutionCycle
        // 
        btnSetExecutionCycle.Dock = DockStyle.Top;
        btnSetExecutionCycle.Location = new Point(5, 33);
        btnSetExecutionCycle.Name = "btnSetExecutionCycle";
        btnSetExecutionCycle.Size = new Size(238, 23);
        btnSetExecutionCycle.TabIndex = 2;
        btnSetExecutionCycle.Text = "Set Execution cycle";
        btnSetExecutionCycle.UseVisualStyleBackColor = true;
        btnSetExecutionCycle.Click += btnSetExecutionCycle_Click;
        // 
        // sep13
        // 
        sep13.Dock = DockStyle.Top;
        sep13.Location = new Point(5, 28);
        sep13.Name = "sep13";
        sep13.Size = new Size(238, 5);
        sep13.TabIndex = 1;
        // 
        // cboSetExecutionCycleCycle
        // 
        cboSetExecutionCycleCycle.Dock = DockStyle.Top;
        cboSetExecutionCycleCycle.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSetExecutionCycleCycle.FormattingEnabled = true;
        cboSetExecutionCycleCycle.Location = new Point(5, 5);
        cboSetExecutionCycleCycle.Name = "cboSetExecutionCycleCycle";
        cboSetExecutionCycleCycle.Size = new Size(238, 23);
        cboSetExecutionCycleCycle.TabIndex = 0;
        // 
        // pnlHoldToRun
        // 
        pnlHoldToRun.BorderStyle = BorderStyle.FixedSingle;
        pnlHoldToRun.Controls.Add(btnSetHoldToRun);
        pnlHoldToRun.Controls.Add(sep14);
        pnlHoldToRun.Controls.Add(cboSetHoldToRunState);
        pnlHoldToRun.Location = new Point(259, 266);
        pnlHoldToRun.Name = "pnlHoldToRun";
        pnlHoldToRun.Padding = new Padding(5);
        pnlHoldToRun.Size = new Size(250, 63);
        pnlHoldToRun.TabIndex = 5;
        // 
        // btnSetHoldToRun
        // 
        btnSetHoldToRun.Dock = DockStyle.Top;
        btnSetHoldToRun.Location = new Point(5, 33);
        btnSetHoldToRun.Name = "btnSetHoldToRun";
        btnSetHoldToRun.Size = new Size(238, 23);
        btnSetHoldToRun.TabIndex = 2;
        btnSetHoldToRun.Text = "Set Hold to run";
        btnSetHoldToRun.UseVisualStyleBackColor = true;
        btnSetHoldToRun.Click += btnSetHoldToRun_Click;
        // 
        // sep14
        // 
        sep14.Dock = DockStyle.Top;
        sep14.Location = new Point(5, 28);
        sep14.Name = "sep14";
        sep14.Size = new Size(238, 5);
        sep14.TabIndex = 1;
        // 
        // cboSetHoldToRunState
        // 
        cboSetHoldToRunState.Dock = DockStyle.Top;
        cboSetHoldToRunState.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSetHoldToRunState.FormattingEnabled = true;
        cboSetHoldToRunState.Location = new Point(5, 5);
        cboSetHoldToRunState.Name = "cboSetHoldToRunState";
        cboSetHoldToRunState.Size = new Size(238, 23);
        cboSetHoldToRunState.TabIndex = 0;
        // 
        // pnlTaskSelection
        // 
        pnlTaskSelection.BorderStyle = BorderStyle.FixedSingle;
        pnlTaskSelection.Controls.Add(gridTaskSelection);
        pnlTaskSelection.Controls.Add(sep15);
        pnlTaskSelection.Controls.Add(btnGetTaskSelection);
        pnlTaskSelection.Location = new Point(515, 3);
        pnlTaskSelection.Name = "pnlTaskSelection";
        pnlTaskSelection.Padding = new Padding(5);
        pnlTaskSelection.Size = new Size(250, 160);
        pnlTaskSelection.TabIndex = 6;
        // 
        // gridTaskSelection
        // 
        gridTaskSelection.Dock = DockStyle.Top;
        gridTaskSelection.HelpVisible = false;
        gridTaskSelection.Location = new Point(5, 33);
        gridTaskSelection.Name = "gridTaskSelection";
        gridTaskSelection.PropertySort = PropertySort.NoSort;
        gridTaskSelection.Size = new Size(238, 120);
        gridTaskSelection.TabIndex = 2;
        gridTaskSelection.ToolbarVisible = false;
        // 
        // sep15
        // 
        sep15.Dock = DockStyle.Top;
        sep15.Location = new Point(5, 28);
        sep15.Name = "sep15";
        sep15.Size = new Size(238, 5);
        sep15.TabIndex = 1;
        // 
        // btnGetTaskSelection
        // 
        btnGetTaskSelection.Dock = DockStyle.Top;
        btnGetTaskSelection.Location = new Point(5, 5);
        btnGetTaskSelection.Name = "btnGetTaskSelection";
        btnGetTaskSelection.Size = new Size(238, 23);
        btnGetTaskSelection.TabIndex = 0;
        btnGetTaskSelection.Text = "Get Task selection";
        btnGetTaskSelection.UseVisualStyleBackColor = true;
        btnGetTaskSelection.Click += btnGetTaskSelection_Click;
        // 
        // pnlAliasIo
        // 
        pnlAliasIo.BorderStyle = BorderStyle.FixedSingle;
        pnlAliasIo.Controls.Add(gridAliasIo);
        pnlAliasIo.Controls.Add(sep16);
        pnlAliasIo.Controls.Add(btnGetAliasIo);
        pnlAliasIo.Location = new Point(515, 169);
        pnlAliasIo.Name = "pnlAliasIo";
        pnlAliasIo.Padding = new Padding(5);
        pnlAliasIo.Size = new Size(250, 141);
        pnlAliasIo.TabIndex = 7;
        // 
        // gridAliasIo
        // 
        gridAliasIo.Dock = DockStyle.Top;
        gridAliasIo.HelpVisible = false;
        gridAliasIo.Location = new Point(5, 33);
        gridAliasIo.Name = "gridAliasIo";
        gridAliasIo.PropertySort = PropertySort.NoSort;
        gridAliasIo.Size = new Size(238, 101);
        gridAliasIo.TabIndex = 2;
        gridAliasIo.ToolbarVisible = false;
        // 
        // sep16
        // 
        sep16.Dock = DockStyle.Top;
        sep16.Location = new Point(5, 28);
        sep16.Name = "sep16";
        sep16.Size = new Size(238, 5);
        sep16.TabIndex = 1;
        // 
        // btnGetAliasIo
        // 
        btnGetAliasIo.Dock = DockStyle.Top;
        btnGetAliasIo.Location = new Point(5, 5);
        btnGetAliasIo.Name = "btnGetAliasIo";
        btnGetAliasIo.Size = new Size(238, 23);
        btnGetAliasIo.TabIndex = 0;
        btnGetAliasIo.Text = "Get Alias I/O";
        btnGetAliasIo.UseVisualStyleBackColor = true;
        btnGetAliasIo.Click += btnGetAliasIo_Click;
        // 
        // tabTasks
        // 
        tabTasks.Controls.Add(flowTasks);
        tabTasks.Location = new Point(4, 24);
        tabTasks.Name = "tabTasks";
        tabTasks.Padding = new Padding(3);
        tabTasks.Size = new Size(882, 421);
        tabTasks.TabIndex = 1;
        tabTasks.Text = "Tasks";
        tabTasks.UseVisualStyleBackColor = true;
        // 
        // flowTasks
        // 
        flowTasks.AutoScroll = true;
        flowTasks.Controls.Add(pnlTasks);
        flowTasks.Controls.Add(pnlTask);
        flowTasks.Controls.Add(pnlTaskActivation);
        flowTasks.Controls.Add(pnlBuildTask);
        flowTasks.Controls.Add(pnlLoadModule);
        flowTasks.Controls.Add(pnlSpy);
        flowTasks.Controls.Add(pnlSyncState);
        flowTasks.Controls.Add(pnlStructuralChangeCount);
        flowTasks.Controls.Add(pnlActivationRecord);
        flowTasks.Controls.Add(pnlServiceRoutines);
        flowTasks.Controls.Add(pnlPreferredDataTypes);
        flowTasks.Controls.Add(pnlPalletHeads);
        flowTasks.Controls.Add(pnlPallet);
        flowTasks.Dock = DockStyle.Fill;
        flowTasks.FlowDirection = FlowDirection.TopDown;
        flowTasks.Location = new Point(3, 3);
        flowTasks.Name = "flowTasks";
        flowTasks.Size = new Size(876, 415);
        flowTasks.TabIndex = 0;
        // 
        // pnlTasks
        // 
        pnlTasks.BorderStyle = BorderStyle.FixedSingle;
        pnlTasks.Controls.Add(gridTasks);
        pnlTasks.Controls.Add(sep17);
        pnlTasks.Controls.Add(btnGetTasks);
        pnlTasks.Location = new Point(3, 3);
        pnlTasks.Name = "pnlTasks";
        pnlTasks.Padding = new Padding(5);
        pnlTasks.Size = new Size(250, 236);
        pnlTasks.TabIndex = 0;
        // 
        // gridTasks
        // 
        gridTasks.Dock = DockStyle.Top;
        gridTasks.HelpVisible = false;
        gridTasks.Location = new Point(5, 33);
        gridTasks.Name = "gridTasks";
        gridTasks.PropertySort = PropertySort.NoSort;
        gridTasks.Size = new Size(238, 196);
        gridTasks.TabIndex = 2;
        gridTasks.ToolbarVisible = false;
        // 
        // sep17
        // 
        sep17.Dock = DockStyle.Top;
        sep17.Location = new Point(5, 28);
        sep17.Name = "sep17";
        sep17.Size = new Size(238, 5);
        sep17.TabIndex = 1;
        // 
        // btnGetTasks
        // 
        btnGetTasks.Dock = DockStyle.Top;
        btnGetTasks.Location = new Point(5, 5);
        btnGetTasks.Name = "btnGetTasks";
        btnGetTasks.Size = new Size(238, 23);
        btnGetTasks.TabIndex = 0;
        btnGetTasks.Text = "Get Tasks";
        btnGetTasks.UseVisualStyleBackColor = true;
        btnGetTasks.Click += btnGetTasks_Click;
        // 
        // pnlTask
        // 
        pnlTask.BorderStyle = BorderStyle.FixedSingle;
        pnlTask.Controls.Add(gridTask);
        pnlTask.Controls.Add(sep18);
        pnlTask.Controls.Add(btnGetTask);
        pnlTask.Location = new Point(259, 3);
        pnlTask.Name = "pnlTask";
        pnlTask.Padding = new Padding(5);
        pnlTask.Size = new Size(250, 312);
        pnlTask.TabIndex = 1;
        // 
        // gridTask
        // 
        gridTask.Dock = DockStyle.Top;
        gridTask.HelpVisible = false;
        gridTask.Location = new Point(5, 33);
        gridTask.Name = "gridTask";
        gridTask.PropertySort = PropertySort.NoSort;
        gridTask.Size = new Size(238, 272);
        gridTask.TabIndex = 2;
        gridTask.ToolbarVisible = false;
        // 
        // sep18
        // 
        sep18.Dock = DockStyle.Top;
        sep18.Location = new Point(5, 28);
        sep18.Name = "sep18";
        sep18.Size = new Size(238, 5);
        sep18.TabIndex = 1;
        // 
        // btnGetTask
        // 
        btnGetTask.Dock = DockStyle.Top;
        btnGetTask.Location = new Point(5, 5);
        btnGetTask.Name = "btnGetTask";
        btnGetTask.Size = new Size(238, 23);
        btnGetTask.TabIndex = 0;
        btnGetTask.Text = "Get Task";
        btnGetTask.UseVisualStyleBackColor = true;
        btnGetTask.Click += btnGetTask_Click;
        // 
        // pnlTaskActivation
        // 
        pnlTaskActivation.BorderStyle = BorderStyle.FixedSingle;
        pnlTaskActivation.Controls.Add(btnDeactivateTasks);
        pnlTaskActivation.Controls.Add(sep21);
        pnlTaskActivation.Controls.Add(btnActivateTasks);
        pnlTaskActivation.Controls.Add(sep20);
        pnlTaskActivation.Controls.Add(btnDeactivateTask);
        pnlTaskActivation.Controls.Add(sep19);
        pnlTaskActivation.Controls.Add(btnActivateTask);
        pnlTaskActivation.Location = new Point(515, 3);
        pnlTaskActivation.Name = "pnlTaskActivation";
        pnlTaskActivation.Padding = new Padding(5);
        pnlTaskActivation.Size = new Size(250, 119);
        pnlTaskActivation.TabIndex = 2;
        // 
        // btnDeactivateTasks
        // 
        btnDeactivateTasks.Dock = DockStyle.Top;
        btnDeactivateTasks.Location = new Point(5, 89);
        btnDeactivateTasks.Name = "btnDeactivateTasks";
        btnDeactivateTasks.Size = new Size(238, 23);
        btnDeactivateTasks.TabIndex = 6;
        btnDeactivateTasks.Text = "Deactivate all tasks";
        btnDeactivateTasks.UseVisualStyleBackColor = true;
        btnDeactivateTasks.Click += btnDeactivateTasks_Click;
        // 
        // sep21
        // 
        sep21.Dock = DockStyle.Top;
        sep21.Location = new Point(5, 84);
        sep21.Name = "sep21";
        sep21.Size = new Size(238, 5);
        sep21.TabIndex = 5;
        // 
        // btnActivateTasks
        // 
        btnActivateTasks.Dock = DockStyle.Top;
        btnActivateTasks.Location = new Point(5, 61);
        btnActivateTasks.Name = "btnActivateTasks";
        btnActivateTasks.Size = new Size(238, 23);
        btnActivateTasks.TabIndex = 4;
        btnActivateTasks.Text = "Activate all tasks";
        btnActivateTasks.UseVisualStyleBackColor = true;
        btnActivateTasks.Click += btnActivateTasks_Click;
        // 
        // sep20
        // 
        sep20.Dock = DockStyle.Top;
        sep20.Location = new Point(5, 56);
        sep20.Name = "sep20";
        sep20.Size = new Size(238, 5);
        sep20.TabIndex = 3;
        // 
        // btnDeactivateTask
        // 
        btnDeactivateTask.Dock = DockStyle.Top;
        btnDeactivateTask.Location = new Point(5, 33);
        btnDeactivateTask.Name = "btnDeactivateTask";
        btnDeactivateTask.Size = new Size(238, 23);
        btnDeactivateTask.TabIndex = 2;
        btnDeactivateTask.Text = "Deactivate Task";
        btnDeactivateTask.UseVisualStyleBackColor = true;
        btnDeactivateTask.Click += btnDeactivateTask_Click;
        // 
        // sep19
        // 
        sep19.Dock = DockStyle.Top;
        sep19.Location = new Point(5, 28);
        sep19.Name = "sep19";
        sep19.Size = new Size(238, 5);
        sep19.TabIndex = 1;
        // 
        // btnActivateTask
        // 
        btnActivateTask.Dock = DockStyle.Top;
        btnActivateTask.Location = new Point(5, 5);
        btnActivateTask.Name = "btnActivateTask";
        btnActivateTask.Size = new Size(238, 23);
        btnActivateTask.TabIndex = 0;
        btnActivateTask.Text = "Activate Task";
        btnActivateTask.UseVisualStyleBackColor = true;
        btnActivateTask.Click += btnActivateTask_Click;
        // 
        // pnlBuildTask
        // 
        pnlBuildTask.BorderStyle = BorderStyle.FixedSingle;
        pnlBuildTask.Controls.Add(btnAbortExecutionLevel);
        pnlBuildTask.Controls.Add(sep22);
        pnlBuildTask.Controls.Add(btnBuildTask);
        pnlBuildTask.Location = new Point(515, 128);
        pnlBuildTask.Name = "pnlBuildTask";
        pnlBuildTask.Padding = new Padding(5);
        pnlBuildTask.Size = new Size(250, 63);
        pnlBuildTask.TabIndex = 3;
        // 
        // btnAbortExecutionLevel
        // 
        btnAbortExecutionLevel.Dock = DockStyle.Top;
        btnAbortExecutionLevel.Location = new Point(5, 33);
        btnAbortExecutionLevel.Name = "btnAbortExecutionLevel";
        btnAbortExecutionLevel.Size = new Size(238, 23);
        btnAbortExecutionLevel.TabIndex = 2;
        btnAbortExecutionLevel.Text = "Abort execution level";
        btnAbortExecutionLevel.UseVisualStyleBackColor = true;
        btnAbortExecutionLevel.Click += btnAbortExecutionLevel_Click;
        // 
        // sep22
        // 
        sep22.Dock = DockStyle.Top;
        sep22.Location = new Point(5, 28);
        sep22.Name = "sep22";
        sep22.Size = new Size(238, 5);
        sep22.TabIndex = 1;
        // 
        // btnBuildTask
        // 
        btnBuildTask.Dock = DockStyle.Top;
        btnBuildTask.Location = new Point(5, 5);
        btnBuildTask.Name = "btnBuildTask";
        btnBuildTask.Size = new Size(238, 23);
        btnBuildTask.TabIndex = 0;
        btnBuildTask.Text = "Build Task";
        btnBuildTask.UseVisualStyleBackColor = true;
        btnBuildTask.Click += btnBuildTask_Click;
        // 
        // pnlLoadModule
        // 
        pnlLoadModule.BorderStyle = BorderStyle.FixedSingle;
        pnlLoadModule.Controls.Add(btnUnloadModule);
        pnlLoadModule.Controls.Add(sep26);
        pnlLoadModule.Controls.Add(txtLoadModuleResult);
        pnlLoadModule.Controls.Add(sep25);
        pnlLoadModule.Controls.Add(btnLoadModule);
        pnlLoadModule.Controls.Add(sep24);
        pnlLoadModule.Controls.Add(chkLoadModuleReplace);
        pnlLoadModule.Controls.Add(sep23);
        pnlLoadModule.Controls.Add(txtLoadModulePath);
        pnlLoadModule.Location = new Point(515, 197);
        pnlLoadModule.Name = "pnlLoadModule";
        pnlLoadModule.Padding = new Padding(5);
        pnlLoadModule.Size = new Size(250, 147);
        pnlLoadModule.TabIndex = 4;
        // 
        // btnUnloadModule
        // 
        btnUnloadModule.Dock = DockStyle.Top;
        btnUnloadModule.Location = new Point(5, 117);
        btnUnloadModule.Name = "btnUnloadModule";
        btnUnloadModule.Size = new Size(238, 23);
        btnUnloadModule.TabIndex = 8;
        btnUnloadModule.Text = "Unload Module";
        btnUnloadModule.UseVisualStyleBackColor = true;
        btnUnloadModule.Click += btnUnloadModule_Click;
        // 
        // sep26
        // 
        sep26.Dock = DockStyle.Top;
        sep26.Location = new Point(5, 112);
        sep26.Name = "sep26";
        sep26.Size = new Size(238, 5);
        sep26.TabIndex = 7;
        // 
        // txtLoadModuleResult
        // 
        txtLoadModuleResult.Dock = DockStyle.Top;
        txtLoadModuleResult.Location = new Point(5, 89);
        txtLoadModuleResult.Name = "txtLoadModuleResult";
        txtLoadModuleResult.PlaceholderText = "loaded module";
        txtLoadModuleResult.ReadOnly = true;
        txtLoadModuleResult.Size = new Size(238, 23);
        txtLoadModuleResult.TabIndex = 6;
        // 
        // sep25
        // 
        sep25.Dock = DockStyle.Top;
        sep25.Location = new Point(5, 84);
        sep25.Name = "sep25";
        sep25.Size = new Size(238, 5);
        sep25.TabIndex = 5;
        // 
        // btnLoadModule
        // 
        btnLoadModule.Dock = DockStyle.Top;
        btnLoadModule.Location = new Point(5, 61);
        btnLoadModule.Name = "btnLoadModule";
        btnLoadModule.Size = new Size(238, 23);
        btnLoadModule.TabIndex = 4;
        btnLoadModule.Text = "Load Module";
        btnLoadModule.UseVisualStyleBackColor = true;
        btnLoadModule.Click += btnLoadModule_Click;
        // 
        // sep24
        // 
        sep24.Dock = DockStyle.Top;
        sep24.Location = new Point(5, 56);
        sep24.Name = "sep24";
        sep24.Size = new Size(238, 5);
        sep24.TabIndex = 3;
        // 
        // chkLoadModuleReplace
        // 
        chkLoadModuleReplace.Dock = DockStyle.Top;
        chkLoadModuleReplace.Location = new Point(5, 33);
        chkLoadModuleReplace.Name = "chkLoadModuleReplace";
        chkLoadModuleReplace.Size = new Size(238, 23);
        chkLoadModuleReplace.TabIndex = 2;
        chkLoadModuleReplace.Text = "Replace existing module";
        chkLoadModuleReplace.UseVisualStyleBackColor = true;
        // 
        // sep23
        // 
        sep23.Dock = DockStyle.Top;
        sep23.Location = new Point(5, 28);
        sep23.Name = "sep23";
        sep23.Size = new Size(238, 5);
        sep23.TabIndex = 1;
        // 
        // txtLoadModulePath
        // 
        txtLoadModulePath.Dock = DockStyle.Top;
        txtLoadModulePath.Location = new Point(5, 5);
        txtLoadModulePath.Name = "txtLoadModulePath";
        txtLoadModulePath.PlaceholderText = "modulePath";
        txtLoadModulePath.Size = new Size(238, 23);
        txtLoadModulePath.TabIndex = 0;
        txtLoadModulePath.Text = "$HOME/mymodule.mod";
        // 
        // pnlSpy
        // 
        pnlSpy.BorderStyle = BorderStyle.FixedSingle;
        pnlSpy.Controls.Add(btnStopSpy);
        pnlSpy.Controls.Add(sep30);
        pnlSpy.Controls.Add(btnStartSpy);
        pnlSpy.Controls.Add(sep29);
        pnlSpy.Controls.Add(txtStartSpyLogFile);
        pnlSpy.Controls.Add(sep28);
        pnlSpy.Controls.Add(txtSpyStatus);
        pnlSpy.Controls.Add(sep27);
        pnlSpy.Controls.Add(btnGetSpyStatus);
        pnlSpy.Location = new Point(771, 3);
        pnlSpy.Name = "pnlSpy";
        pnlSpy.Padding = new Padding(5);
        pnlSpy.Size = new Size(250, 147);
        pnlSpy.TabIndex = 5;
        // 
        // btnStopSpy
        // 
        btnStopSpy.Dock = DockStyle.Top;
        btnStopSpy.Location = new Point(5, 117);
        btnStopSpy.Name = "btnStopSpy";
        btnStopSpy.Size = new Size(238, 23);
        btnStopSpy.TabIndex = 8;
        btnStopSpy.Text = "Stop Spy";
        btnStopSpy.UseVisualStyleBackColor = true;
        btnStopSpy.Click += btnStopSpy_Click;
        // 
        // sep30
        // 
        sep30.Dock = DockStyle.Top;
        sep30.Location = new Point(5, 112);
        sep30.Name = "sep30";
        sep30.Size = new Size(238, 5);
        sep30.TabIndex = 7;
        // 
        // btnStartSpy
        // 
        btnStartSpy.Dock = DockStyle.Top;
        btnStartSpy.Location = new Point(5, 89);
        btnStartSpy.Name = "btnStartSpy";
        btnStartSpy.Size = new Size(238, 23);
        btnStartSpy.TabIndex = 6;
        btnStartSpy.Text = "Start Spy";
        btnStartSpy.UseVisualStyleBackColor = true;
        btnStartSpy.Click += btnStartSpy_Click;
        // 
        // sep29
        // 
        sep29.Dock = DockStyle.Top;
        sep29.Location = new Point(5, 84);
        sep29.Name = "sep29";
        sep29.Size = new Size(238, 5);
        sep29.TabIndex = 5;
        // 
        // txtStartSpyLogFile
        // 
        txtStartSpyLogFile.Dock = DockStyle.Top;
        txtStartSpyLogFile.Location = new Point(5, 61);
        txtStartSpyLogFile.Name = "txtStartSpyLogFile";
        txtStartSpyLogFile.PlaceholderText = "logFile";
        txtStartSpyLogFile.Size = new Size(238, 23);
        txtStartSpyLogFile.TabIndex = 4;
        txtStartSpyLogFile.Text = "rapidspy.log";
        // 
        // sep28
        // 
        sep28.Dock = DockStyle.Top;
        sep28.Location = new Point(5, 56);
        sep28.Name = "sep28";
        sep28.Size = new Size(238, 5);
        sep28.TabIndex = 3;
        // 
        // txtSpyStatus
        // 
        txtSpyStatus.Dock = DockStyle.Top;
        txtSpyStatus.Location = new Point(5, 33);
        txtSpyStatus.Name = "txtSpyStatus";
        txtSpyStatus.PlaceholderText = "status";
        txtSpyStatus.ReadOnly = true;
        txtSpyStatus.Size = new Size(238, 23);
        txtSpyStatus.TabIndex = 2;
        // 
        // sep27
        // 
        sep27.Dock = DockStyle.Top;
        sep27.Location = new Point(5, 28);
        sep27.Name = "sep27";
        sep27.Size = new Size(238, 5);
        sep27.TabIndex = 1;
        // 
        // btnGetSpyStatus
        // 
        btnGetSpyStatus.Dock = DockStyle.Top;
        btnGetSpyStatus.Location = new Point(5, 5);
        btnGetSpyStatus.Name = "btnGetSpyStatus";
        btnGetSpyStatus.Size = new Size(238, 23);
        btnGetSpyStatus.TabIndex = 0;
        btnGetSpyStatus.Text = "Get Spy status";
        btnGetSpyStatus.UseVisualStyleBackColor = true;
        btnGetSpyStatus.Click += btnGetSpyStatus_Click;
        // 
        // pnlSyncState
        // 
        pnlSyncState.BorderStyle = BorderStyle.FixedSingle;
        pnlSyncState.Controls.Add(txtTaskMotionPointerSyncState);
        pnlSyncState.Controls.Add(sep37);
        pnlSyncState.Controls.Add(btnGetTaskMotionPointerSyncState);
        pnlSyncState.Controls.Add(sep36);
        pnlSyncState.Controls.Add(txtTaskProgramPointerSyncState);
        pnlSyncState.Controls.Add(sep35);
        pnlSyncState.Controls.Add(btnGetTaskProgramPointerSyncState);
        pnlSyncState.Controls.Add(sep34);
        pnlSyncState.Controls.Add(txtMotionPointerSyncState);
        pnlSyncState.Controls.Add(sep33);
        pnlSyncState.Controls.Add(btnGetMotionPointerSyncState);
        pnlSyncState.Controls.Add(sep32);
        pnlSyncState.Controls.Add(txtProgramPointerSyncState);
        pnlSyncState.Controls.Add(sep31);
        pnlSyncState.Controls.Add(btnGetProgramPointerSyncState);
        pnlSyncState.Location = new Point(771, 156);
        pnlSyncState.Name = "pnlSyncState";
        pnlSyncState.Padding = new Padding(5);
        pnlSyncState.Size = new Size(250, 231);
        pnlSyncState.TabIndex = 6;
        // 
        // txtTaskMotionPointerSyncState
        // 
        txtTaskMotionPointerSyncState.Dock = DockStyle.Top;
        txtTaskMotionPointerSyncState.Location = new Point(5, 201);
        txtTaskMotionPointerSyncState.Name = "txtTaskMotionPointerSyncState";
        txtTaskMotionPointerSyncState.PlaceholderText = "motion pointer";
        txtTaskMotionPointerSyncState.ReadOnly = true;
        txtTaskMotionPointerSyncState.Size = new Size(238, 23);
        txtTaskMotionPointerSyncState.TabIndex = 14;
        // 
        // sep37
        // 
        sep37.Dock = DockStyle.Top;
        sep37.Location = new Point(5, 196);
        sep37.Name = "sep37";
        sep37.Size = new Size(238, 5);
        sep37.TabIndex = 13;
        // 
        // btnGetTaskMotionPointerSyncState
        // 
        btnGetTaskMotionPointerSyncState.Dock = DockStyle.Top;
        btnGetTaskMotionPointerSyncState.Location = new Point(5, 173);
        btnGetTaskMotionPointerSyncState.Name = "btnGetTaskMotionPointerSyncState";
        btnGetTaskMotionPointerSyncState.Size = new Size(238, 23);
        btnGetTaskMotionPointerSyncState.TabIndex = 12;
        btnGetTaskMotionPointerSyncState.Text = "Get Motion pointer sync (task)";
        btnGetTaskMotionPointerSyncState.UseVisualStyleBackColor = true;
        btnGetTaskMotionPointerSyncState.Click += btnGetTaskMotionPointerSyncState_Click;
        // 
        // sep36
        // 
        sep36.Dock = DockStyle.Top;
        sep36.Location = new Point(5, 168);
        sep36.Name = "sep36";
        sep36.Size = new Size(238, 5);
        sep36.TabIndex = 11;
        // 
        // txtTaskProgramPointerSyncState
        // 
        txtTaskProgramPointerSyncState.Dock = DockStyle.Top;
        txtTaskProgramPointerSyncState.Location = new Point(5, 145);
        txtTaskProgramPointerSyncState.Name = "txtTaskProgramPointerSyncState";
        txtTaskProgramPointerSyncState.PlaceholderText = "program pointer";
        txtTaskProgramPointerSyncState.ReadOnly = true;
        txtTaskProgramPointerSyncState.Size = new Size(238, 23);
        txtTaskProgramPointerSyncState.TabIndex = 10;
        // 
        // sep35
        // 
        sep35.Dock = DockStyle.Top;
        sep35.Location = new Point(5, 140);
        sep35.Name = "sep35";
        sep35.Size = new Size(238, 5);
        sep35.TabIndex = 9;
        // 
        // btnGetTaskProgramPointerSyncState
        // 
        btnGetTaskProgramPointerSyncState.Dock = DockStyle.Top;
        btnGetTaskProgramPointerSyncState.Location = new Point(5, 117);
        btnGetTaskProgramPointerSyncState.Name = "btnGetTaskProgramPointerSyncState";
        btnGetTaskProgramPointerSyncState.Size = new Size(238, 23);
        btnGetTaskProgramPointerSyncState.TabIndex = 8;
        btnGetTaskProgramPointerSyncState.Text = "Get Program pointer sync (task)";
        btnGetTaskProgramPointerSyncState.UseVisualStyleBackColor = true;
        btnGetTaskProgramPointerSyncState.Click += btnGetTaskProgramPointerSyncState_Click;
        // 
        // sep34
        // 
        sep34.Dock = DockStyle.Top;
        sep34.Location = new Point(5, 112);
        sep34.Name = "sep34";
        sep34.Size = new Size(238, 5);
        sep34.TabIndex = 7;
        // 
        // txtMotionPointerSyncState
        // 
        txtMotionPointerSyncState.Dock = DockStyle.Top;
        txtMotionPointerSyncState.Location = new Point(5, 89);
        txtMotionPointerSyncState.Name = "txtMotionPointerSyncState";
        txtMotionPointerSyncState.PlaceholderText = "motion pointer";
        txtMotionPointerSyncState.ReadOnly = true;
        txtMotionPointerSyncState.Size = new Size(238, 23);
        txtMotionPointerSyncState.TabIndex = 6;
        // 
        // sep33
        // 
        sep33.Dock = DockStyle.Top;
        sep33.Location = new Point(5, 84);
        sep33.Name = "sep33";
        sep33.Size = new Size(238, 5);
        sep33.TabIndex = 5;
        // 
        // btnGetMotionPointerSyncState
        // 
        btnGetMotionPointerSyncState.Dock = DockStyle.Top;
        btnGetMotionPointerSyncState.Location = new Point(5, 61);
        btnGetMotionPointerSyncState.Name = "btnGetMotionPointerSyncState";
        btnGetMotionPointerSyncState.Size = new Size(238, 23);
        btnGetMotionPointerSyncState.TabIndex = 4;
        btnGetMotionPointerSyncState.Text = "Get Motion pointer sync (all)";
        btnGetMotionPointerSyncState.UseVisualStyleBackColor = true;
        btnGetMotionPointerSyncState.Click += btnGetMotionPointerSyncState_Click;
        // 
        // sep32
        // 
        sep32.Dock = DockStyle.Top;
        sep32.Location = new Point(5, 56);
        sep32.Name = "sep32";
        sep32.Size = new Size(238, 5);
        sep32.TabIndex = 3;
        // 
        // txtProgramPointerSyncState
        // 
        txtProgramPointerSyncState.Dock = DockStyle.Top;
        txtProgramPointerSyncState.Location = new Point(5, 33);
        txtProgramPointerSyncState.Name = "txtProgramPointerSyncState";
        txtProgramPointerSyncState.PlaceholderText = "program pointer";
        txtProgramPointerSyncState.ReadOnly = true;
        txtProgramPointerSyncState.Size = new Size(238, 23);
        txtProgramPointerSyncState.TabIndex = 2;
        // 
        // sep31
        // 
        sep31.Dock = DockStyle.Top;
        sep31.Location = new Point(5, 28);
        sep31.Name = "sep31";
        sep31.Size = new Size(238, 5);
        sep31.TabIndex = 1;
        // 
        // btnGetProgramPointerSyncState
        // 
        btnGetProgramPointerSyncState.Dock = DockStyle.Top;
        btnGetProgramPointerSyncState.Location = new Point(5, 5);
        btnGetProgramPointerSyncState.Name = "btnGetProgramPointerSyncState";
        btnGetProgramPointerSyncState.Size = new Size(238, 23);
        btnGetProgramPointerSyncState.TabIndex = 0;
        btnGetProgramPointerSyncState.Text = "Get Program pointer sync (all)";
        btnGetProgramPointerSyncState.UseVisualStyleBackColor = true;
        btnGetProgramPointerSyncState.Click += btnGetProgramPointerSyncState_Click;
        // 
        // pnlStructuralChangeCount
        // 
        pnlStructuralChangeCount.BorderStyle = BorderStyle.FixedSingle;
        pnlStructuralChangeCount.Controls.Add(gridStructuralChangeCount);
        pnlStructuralChangeCount.Controls.Add(sep38);
        pnlStructuralChangeCount.Controls.Add(btnGetStructuralChangeCount);
        pnlStructuralChangeCount.Location = new Point(1027, 3);
        pnlStructuralChangeCount.Name = "pnlStructuralChangeCount";
        pnlStructuralChangeCount.Padding = new Padding(5);
        pnlStructuralChangeCount.Size = new Size(250, 100);
        pnlStructuralChangeCount.TabIndex = 7;
        // 
        // gridStructuralChangeCount
        // 
        gridStructuralChangeCount.Dock = DockStyle.Top;
        gridStructuralChangeCount.HelpVisible = false;
        gridStructuralChangeCount.Location = new Point(5, 33);
        gridStructuralChangeCount.Name = "gridStructuralChangeCount";
        gridStructuralChangeCount.PropertySort = PropertySort.NoSort;
        gridStructuralChangeCount.Size = new Size(238, 60);
        gridStructuralChangeCount.TabIndex = 2;
        gridStructuralChangeCount.ToolbarVisible = false;
        // 
        // sep38
        // 
        sep38.Dock = DockStyle.Top;
        sep38.Location = new Point(5, 28);
        sep38.Name = "sep38";
        sep38.Size = new Size(238, 5);
        sep38.TabIndex = 1;
        // 
        // btnGetStructuralChangeCount
        // 
        btnGetStructuralChangeCount.Dock = DockStyle.Top;
        btnGetStructuralChangeCount.Location = new Point(5, 5);
        btnGetStructuralChangeCount.Name = "btnGetStructuralChangeCount";
        btnGetStructuralChangeCount.Size = new Size(238, 23);
        btnGetStructuralChangeCount.TabIndex = 0;
        btnGetStructuralChangeCount.Text = "Get Structural change count";
        btnGetStructuralChangeCount.UseVisualStyleBackColor = true;
        btnGetStructuralChangeCount.Click += btnGetStructuralChangeCount_Click;
        // 
        // pnlActivationRecord
        // 
        pnlActivationRecord.BorderStyle = BorderStyle.FixedSingle;
        pnlActivationRecord.Controls.Add(gridActivationRecord);
        pnlActivationRecord.Controls.Add(sep40);
        pnlActivationRecord.Controls.Add(btnGetActivationRecord);
        pnlActivationRecord.Controls.Add(sep39);
        pnlActivationRecord.Controls.Add(numGetActivationRecordStackFrame);
        pnlActivationRecord.Location = new Point(1027, 109);
        pnlActivationRecord.Name = "pnlActivationRecord";
        pnlActivationRecord.Padding = new Padding(5);
        pnlActivationRecord.Size = new Size(250, 207);
        pnlActivationRecord.TabIndex = 8;
        // 
        // gridActivationRecord
        // 
        gridActivationRecord.Dock = DockStyle.Top;
        gridActivationRecord.HelpVisible = false;
        gridActivationRecord.Location = new Point(5, 61);
        gridActivationRecord.Name = "gridActivationRecord";
        gridActivationRecord.PropertySort = PropertySort.NoSort;
        gridActivationRecord.Size = new Size(238, 139);
        gridActivationRecord.TabIndex = 4;
        gridActivationRecord.ToolbarVisible = false;
        // 
        // sep40
        // 
        sep40.Dock = DockStyle.Top;
        sep40.Location = new Point(5, 56);
        sep40.Name = "sep40";
        sep40.Size = new Size(238, 5);
        sep40.TabIndex = 3;
        // 
        // btnGetActivationRecord
        // 
        btnGetActivationRecord.Dock = DockStyle.Top;
        btnGetActivationRecord.Location = new Point(5, 33);
        btnGetActivationRecord.Name = "btnGetActivationRecord";
        btnGetActivationRecord.Size = new Size(238, 23);
        btnGetActivationRecord.TabIndex = 2;
        btnGetActivationRecord.Text = "Get Activation record";
        btnGetActivationRecord.UseVisualStyleBackColor = true;
        btnGetActivationRecord.Click += btnGetActivationRecord_Click;
        // 
        // sep39
        // 
        sep39.Dock = DockStyle.Top;
        sep39.Location = new Point(5, 28);
        sep39.Name = "sep39";
        sep39.Size = new Size(238, 5);
        sep39.TabIndex = 1;
        // 
        // numGetActivationRecordStackFrame
        // 
        numGetActivationRecordStackFrame.Dock = DockStyle.Top;
        numGetActivationRecordStackFrame.Location = new Point(5, 5);
        numGetActivationRecordStackFrame.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numGetActivationRecordStackFrame.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numGetActivationRecordStackFrame.Name = "numGetActivationRecordStackFrame";
        numGetActivationRecordStackFrame.Size = new Size(238, 23);
        numGetActivationRecordStackFrame.TabIndex = 0;
        numGetActivationRecordStackFrame.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // pnlServiceRoutines
        // 
        pnlServiceRoutines.BorderStyle = BorderStyle.FixedSingle;
        pnlServiceRoutines.Controls.Add(gridServiceRoutines);
        pnlServiceRoutines.Controls.Add(sep42);
        pnlServiceRoutines.Controls.Add(btnGetServiceRoutines);
        pnlServiceRoutines.Controls.Add(sep41);
        pnlServiceRoutines.Controls.Add(numGetServiceRoutinesLimit);
        pnlServiceRoutines.Location = new Point(1283, 3);
        pnlServiceRoutines.Name = "pnlServiceRoutines";
        pnlServiceRoutines.Padding = new Padding(5);
        pnlServiceRoutines.Size = new Size(250, 302);
        pnlServiceRoutines.TabIndex = 9;
        // 
        // gridServiceRoutines
        // 
        gridServiceRoutines.Dock = DockStyle.Top;
        gridServiceRoutines.HelpVisible = false;
        gridServiceRoutines.Location = new Point(5, 61);
        gridServiceRoutines.Name = "gridServiceRoutines";
        gridServiceRoutines.PropertySort = PropertySort.NoSort;
        gridServiceRoutines.Size = new Size(238, 234);
        gridServiceRoutines.TabIndex = 4;
        gridServiceRoutines.ToolbarVisible = false;
        // 
        // sep42
        // 
        sep42.Dock = DockStyle.Top;
        sep42.Location = new Point(5, 56);
        sep42.Name = "sep42";
        sep42.Size = new Size(238, 5);
        sep42.TabIndex = 3;
        // 
        // btnGetServiceRoutines
        // 
        btnGetServiceRoutines.Dock = DockStyle.Top;
        btnGetServiceRoutines.Location = new Point(5, 33);
        btnGetServiceRoutines.Name = "btnGetServiceRoutines";
        btnGetServiceRoutines.Size = new Size(238, 23);
        btnGetServiceRoutines.TabIndex = 2;
        btnGetServiceRoutines.Text = "Get Service routines";
        btnGetServiceRoutines.UseVisualStyleBackColor = true;
        btnGetServiceRoutines.Click += btnGetServiceRoutines_Click;
        // 
        // sep41
        // 
        sep41.Dock = DockStyle.Top;
        sep41.Location = new Point(5, 28);
        sep41.Name = "sep41";
        sep41.Size = new Size(238, 5);
        sep41.TabIndex = 1;
        // 
        // numGetServiceRoutinesLimit
        // 
        numGetServiceRoutinesLimit.Dock = DockStyle.Top;
        numGetServiceRoutinesLimit.Location = new Point(5, 5);
        numGetServiceRoutinesLimit.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numGetServiceRoutinesLimit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numGetServiceRoutinesLimit.Name = "numGetServiceRoutinesLimit";
        numGetServiceRoutinesLimit.Size = new Size(238, 23);
        numGetServiceRoutinesLimit.TabIndex = 0;
        numGetServiceRoutinesLimit.Value = new decimal(new int[] { 10, 0, 0, 0 });
        // 
        // pnlPreferredDataTypes
        // 
        pnlPreferredDataTypes.BorderStyle = BorderStyle.FixedSingle;
        pnlPreferredDataTypes.Controls.Add(gridPreferredDataTypes);
        pnlPreferredDataTypes.Controls.Add(sep45);
        pnlPreferredDataTypes.Controls.Add(btnGetPreferredDataTypes);
        pnlPreferredDataTypes.Controls.Add(sep44);
        pnlPreferredDataTypes.Controls.Add(txtGetPreferredDataTypesParameter);
        pnlPreferredDataTypes.Controls.Add(sep43);
        pnlPreferredDataTypes.Controls.Add(txtGetPreferredDataTypesInstruction);
        pnlPreferredDataTypes.Location = new Point(1539, 3);
        pnlPreferredDataTypes.Name = "pnlPreferredDataTypes";
        pnlPreferredDataTypes.Padding = new Padding(5);
        pnlPreferredDataTypes.Size = new Size(250, 254);
        pnlPreferredDataTypes.TabIndex = 10;
        // 
        // gridPreferredDataTypes
        // 
        gridPreferredDataTypes.Dock = DockStyle.Top;
        gridPreferredDataTypes.HelpVisible = false;
        gridPreferredDataTypes.Location = new Point(5, 89);
        gridPreferredDataTypes.Name = "gridPreferredDataTypes";
        gridPreferredDataTypes.PropertySort = PropertySort.NoSort;
        gridPreferredDataTypes.Size = new Size(238, 158);
        gridPreferredDataTypes.TabIndex = 6;
        gridPreferredDataTypes.ToolbarVisible = false;
        // 
        // sep45
        // 
        sep45.Dock = DockStyle.Top;
        sep45.Location = new Point(5, 84);
        sep45.Name = "sep45";
        sep45.Size = new Size(238, 5);
        sep45.TabIndex = 5;
        // 
        // btnGetPreferredDataTypes
        // 
        btnGetPreferredDataTypes.Dock = DockStyle.Top;
        btnGetPreferredDataTypes.Location = new Point(5, 61);
        btnGetPreferredDataTypes.Name = "btnGetPreferredDataTypes";
        btnGetPreferredDataTypes.Size = new Size(238, 23);
        btnGetPreferredDataTypes.TabIndex = 4;
        btnGetPreferredDataTypes.Text = "Get Preferred data types";
        btnGetPreferredDataTypes.UseVisualStyleBackColor = true;
        btnGetPreferredDataTypes.Click += btnGetPreferredDataTypes_Click;
        // 
        // sep44
        // 
        sep44.Dock = DockStyle.Top;
        sep44.Location = new Point(5, 56);
        sep44.Name = "sep44";
        sep44.Size = new Size(238, 5);
        sep44.TabIndex = 3;
        // 
        // txtGetPreferredDataTypesParameter
        // 
        txtGetPreferredDataTypesParameter.Dock = DockStyle.Top;
        txtGetPreferredDataTypesParameter.Location = new Point(5, 33);
        txtGetPreferredDataTypesParameter.Name = "txtGetPreferredDataTypesParameter";
        txtGetPreferredDataTypesParameter.PlaceholderText = "parameter";
        txtGetPreferredDataTypesParameter.Size = new Size(238, 23);
        txtGetPreferredDataTypesParameter.TabIndex = 2;
        txtGetPreferredDataTypesParameter.Text = "FromSignal";
        // 
        // sep43
        // 
        sep43.Dock = DockStyle.Top;
        sep43.Location = new Point(5, 28);
        sep43.Name = "sep43";
        sep43.Size = new Size(238, 5);
        sep43.TabIndex = 1;
        // 
        // txtGetPreferredDataTypesInstruction
        // 
        txtGetPreferredDataTypesInstruction.Dock = DockStyle.Top;
        txtGetPreferredDataTypesInstruction.Location = new Point(5, 5);
        txtGetPreferredDataTypesInstruction.Name = "txtGetPreferredDataTypesInstruction";
        txtGetPreferredDataTypesInstruction.PlaceholderText = "instruction";
        txtGetPreferredDataTypesInstruction.Size = new Size(238, 23);
        txtGetPreferredDataTypesInstruction.TabIndex = 0;
        txtGetPreferredDataTypesInstruction.Text = "AliasIO";
        // 
        // pnlPalletHeads
        // 
        pnlPalletHeads.BorderStyle = BorderStyle.FixedSingle;
        pnlPalletHeads.Controls.Add(gridPalletHeads);
        pnlPalletHeads.Controls.Add(sep46);
        pnlPalletHeads.Controls.Add(btnGetPalletHeads);
        pnlPalletHeads.Location = new Point(1795, 3);
        pnlPalletHeads.Name = "pnlPalletHeads";
        pnlPalletHeads.Padding = new Padding(5);
        pnlPalletHeads.Size = new Size(250, 198);
        pnlPalletHeads.TabIndex = 11;
        // 
        // gridPalletHeads
        // 
        gridPalletHeads.Dock = DockStyle.Top;
        gridPalletHeads.HelpVisible = false;
        gridPalletHeads.Location = new Point(5, 33);
        gridPalletHeads.Name = "gridPalletHeads";
        gridPalletHeads.PropertySort = PropertySort.NoSort;
        gridPalletHeads.Size = new Size(238, 158);
        gridPalletHeads.TabIndex = 2;
        gridPalletHeads.ToolbarVisible = false;
        // 
        // sep46
        // 
        sep46.Dock = DockStyle.Top;
        sep46.Location = new Point(5, 28);
        sep46.Name = "sep46";
        sep46.Size = new Size(238, 5);
        sep46.TabIndex = 1;
        // 
        // btnGetPalletHeads
        // 
        btnGetPalletHeads.Dock = DockStyle.Top;
        btnGetPalletHeads.Location = new Point(5, 5);
        btnGetPalletHeads.Name = "btnGetPalletHeads";
        btnGetPalletHeads.Size = new Size(238, 23);
        btnGetPalletHeads.TabIndex = 0;
        btnGetPalletHeads.Text = "Get Pallet heads";
        btnGetPalletHeads.UseVisualStyleBackColor = true;
        btnGetPalletHeads.Click += btnGetPalletHeads_Click;
        // 
        // pnlPallet
        // 
        pnlPallet.BorderStyle = BorderStyle.FixedSingle;
        pnlPallet.Controls.Add(gridPallet);
        pnlPallet.Controls.Add(sep48);
        pnlPallet.Controls.Add(btnGetPallet);
        pnlPallet.Controls.Add(sep47);
        pnlPallet.Controls.Add(numGetPalletNumber);
        pnlPallet.Location = new Point(2051, 3);
        pnlPallet.Name = "pnlPallet";
        pnlPallet.Padding = new Padding(5);
        pnlPallet.Size = new Size(250, 226);
        pnlPallet.TabIndex = 12;
        // 
        // gridPallet
        // 
        gridPallet.Dock = DockStyle.Top;
        gridPallet.HelpVisible = false;
        gridPallet.Location = new Point(5, 61);
        gridPallet.Name = "gridPallet";
        gridPallet.PropertySort = PropertySort.NoSort;
        gridPallet.Size = new Size(238, 158);
        gridPallet.TabIndex = 4;
        gridPallet.ToolbarVisible = false;
        // 
        // sep48
        // 
        sep48.Dock = DockStyle.Top;
        sep48.Location = new Point(5, 56);
        sep48.Name = "sep48";
        sep48.Size = new Size(238, 5);
        sep48.TabIndex = 3;
        // 
        // btnGetPallet
        // 
        btnGetPallet.Dock = DockStyle.Top;
        btnGetPallet.Location = new Point(5, 33);
        btnGetPallet.Name = "btnGetPallet";
        btnGetPallet.Size = new Size(238, 23);
        btnGetPallet.TabIndex = 2;
        btnGetPallet.Text = "Get Pallet";
        btnGetPallet.UseVisualStyleBackColor = true;
        btnGetPallet.Click += btnGetPallet_Click;
        // 
        // sep47
        // 
        sep47.Dock = DockStyle.Top;
        sep47.Location = new Point(5, 28);
        sep47.Name = "sep47";
        sep47.Size = new Size(238, 5);
        sep47.TabIndex = 1;
        // 
        // numGetPalletNumber
        // 
        numGetPalletNumber.Dock = DockStyle.Top;
        numGetPalletNumber.Location = new Point(5, 5);
        numGetPalletNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numGetPalletNumber.Name = "numGetPalletNumber";
        numGetPalletNumber.Size = new Size(238, 23);
        numGetPalletNumber.TabIndex = 0;
        numGetPalletNumber.Value = new decimal(new int[] { 9, 0, 0, 0 });
        // 
        // tabProgram
        // 
        tabProgram.Controls.Add(flowProgram);
        tabProgram.Location = new Point(4, 24);
        tabProgram.Name = "tabProgram";
        tabProgram.Padding = new Padding(3);
        tabProgram.Size = new Size(882, 421);
        tabProgram.TabIndex = 2;
        tabProgram.Text = "Program";
        tabProgram.UseVisualStyleBackColor = true;
        // 
        // flowProgram
        // 
        flowProgram.AutoScroll = true;
        flowProgram.Controls.Add(pnlProgram);
        flowProgram.Controls.Add(pnlLoadProgram);
        flowProgram.Controls.Add(pnlSaveProgram);
        flowProgram.Controls.Add(pnlProgramName);
        flowProgram.Controls.Add(pnlBreakpoints);
        flowProgram.Controls.Add(pnlBuildErrors);
        flowProgram.Controls.Add(pnlPointers);
        flowProgram.Controls.Add(pnlProgramCounterPosition);
        flowProgram.Controls.Add(pnlProgramPointerMoves);
        flowProgram.Controls.Add(pnlProgramPointerUrl);
        flowProgram.Dock = DockStyle.Fill;
        flowProgram.FlowDirection = FlowDirection.TopDown;
        flowProgram.Location = new Point(3, 3);
        flowProgram.Name = "flowProgram";
        flowProgram.Size = new Size(876, 415);
        flowProgram.TabIndex = 0;
        // 
        // pnlProgram
        // 
        pnlProgram.BorderStyle = BorderStyle.FixedSingle;
        pnlProgram.Controls.Add(gridProgram);
        pnlProgram.Controls.Add(sep49);
        pnlProgram.Controls.Add(btnGetProgram);
        pnlProgram.Location = new Point(3, 3);
        pnlProgram.Name = "pnlProgram";
        pnlProgram.Padding = new Padding(5);
        pnlProgram.Size = new Size(250, 100);
        pnlProgram.TabIndex = 0;
        // 
        // gridProgram
        // 
        gridProgram.Dock = DockStyle.Top;
        gridProgram.HelpVisible = false;
        gridProgram.Location = new Point(5, 33);
        gridProgram.Name = "gridProgram";
        gridProgram.PropertySort = PropertySort.NoSort;
        gridProgram.Size = new Size(238, 60);
        gridProgram.TabIndex = 2;
        gridProgram.ToolbarVisible = false;
        // 
        // sep49
        // 
        sep49.Dock = DockStyle.Top;
        sep49.Location = new Point(5, 28);
        sep49.Name = "sep49";
        sep49.Size = new Size(238, 5);
        sep49.TabIndex = 1;
        // 
        // btnGetProgram
        // 
        btnGetProgram.Dock = DockStyle.Top;
        btnGetProgram.Location = new Point(5, 5);
        btnGetProgram.Name = "btnGetProgram";
        btnGetProgram.Size = new Size(238, 23);
        btnGetProgram.TabIndex = 0;
        btnGetProgram.Text = "Get Program";
        btnGetProgram.UseVisualStyleBackColor = true;
        btnGetProgram.Click += btnGetProgram_Click;
        // 
        // pnlLoadProgram
        // 
        pnlLoadProgram.BorderStyle = BorderStyle.FixedSingle;
        pnlLoadProgram.Controls.Add(btnUnloadProgram);
        pnlLoadProgram.Controls.Add(sep52);
        pnlLoadProgram.Controls.Add(btnLoadProgram);
        pnlLoadProgram.Controls.Add(sep51);
        pnlLoadProgram.Controls.Add(cboLoadProgramLoadMode);
        pnlLoadProgram.Controls.Add(sep50);
        pnlLoadProgram.Controls.Add(txtLoadProgramPath);
        pnlLoadProgram.Location = new Point(3, 109);
        pnlLoadProgram.Name = "pnlLoadProgram";
        pnlLoadProgram.Padding = new Padding(5);
        pnlLoadProgram.Size = new Size(250, 119);
        pnlLoadProgram.TabIndex = 1;
        // 
        // btnUnloadProgram
        // 
        btnUnloadProgram.Dock = DockStyle.Top;
        btnUnloadProgram.Location = new Point(5, 89);
        btnUnloadProgram.Name = "btnUnloadProgram";
        btnUnloadProgram.Size = new Size(238, 23);
        btnUnloadProgram.TabIndex = 6;
        btnUnloadProgram.Text = "Unload Program";
        btnUnloadProgram.UseVisualStyleBackColor = true;
        btnUnloadProgram.Click += btnUnloadProgram_Click;
        // 
        // sep52
        // 
        sep52.Dock = DockStyle.Top;
        sep52.Location = new Point(5, 84);
        sep52.Name = "sep52";
        sep52.Size = new Size(238, 5);
        sep52.TabIndex = 5;
        // 
        // btnLoadProgram
        // 
        btnLoadProgram.Dock = DockStyle.Top;
        btnLoadProgram.Location = new Point(5, 61);
        btnLoadProgram.Name = "btnLoadProgram";
        btnLoadProgram.Size = new Size(238, 23);
        btnLoadProgram.TabIndex = 4;
        btnLoadProgram.Text = "Load Program";
        btnLoadProgram.UseVisualStyleBackColor = true;
        btnLoadProgram.Click += btnLoadProgram_Click;
        // 
        // sep51
        // 
        sep51.Dock = DockStyle.Top;
        sep51.Location = new Point(5, 56);
        sep51.Name = "sep51";
        sep51.Size = new Size(238, 5);
        sep51.TabIndex = 3;
        // 
        // cboLoadProgramLoadMode
        // 
        cboLoadProgramLoadMode.Dock = DockStyle.Top;
        cboLoadProgramLoadMode.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLoadProgramLoadMode.FormattingEnabled = true;
        cboLoadProgramLoadMode.Location = new Point(5, 33);
        cboLoadProgramLoadMode.Name = "cboLoadProgramLoadMode";
        cboLoadProgramLoadMode.Size = new Size(238, 23);
        cboLoadProgramLoadMode.TabIndex = 2;
        // 
        // sep50
        // 
        sep50.Dock = DockStyle.Top;
        sep50.Location = new Point(5, 28);
        sep50.Name = "sep50";
        sep50.Size = new Size(238, 5);
        sep50.TabIndex = 1;
        // 
        // txtLoadProgramPath
        // 
        txtLoadProgramPath.Dock = DockStyle.Top;
        txtLoadProgramPath.Location = new Point(5, 5);
        txtLoadProgramPath.Name = "txtLoadProgramPath";
        txtLoadProgramPath.PlaceholderText = "programPath";
        txtLoadProgramPath.Size = new Size(238, 23);
        txtLoadProgramPath.TabIndex = 0;
        txtLoadProgramPath.Text = "$HOME/myprogram.pgf";
        // 
        // pnlSaveProgram
        // 
        pnlSaveProgram.BorderStyle = BorderStyle.FixedSingle;
        pnlSaveProgram.Controls.Add(btnSaveProgram);
        pnlSaveProgram.Controls.Add(sep53);
        pnlSaveProgram.Controls.Add(txtSaveProgramPath);
        pnlSaveProgram.Location = new Point(3, 234);
        pnlSaveProgram.Name = "pnlSaveProgram";
        pnlSaveProgram.Padding = new Padding(5);
        pnlSaveProgram.Size = new Size(250, 63);
        pnlSaveProgram.TabIndex = 2;
        // 
        // btnSaveProgram
        // 
        btnSaveProgram.Dock = DockStyle.Top;
        btnSaveProgram.Location = new Point(5, 33);
        btnSaveProgram.Name = "btnSaveProgram";
        btnSaveProgram.Size = new Size(238, 23);
        btnSaveProgram.TabIndex = 2;
        btnSaveProgram.Text = "Save Program";
        btnSaveProgram.UseVisualStyleBackColor = true;
        btnSaveProgram.Click += btnSaveProgram_Click;
        // 
        // sep53
        // 
        sep53.Dock = DockStyle.Top;
        sep53.Location = new Point(5, 28);
        sep53.Name = "sep53";
        sep53.Size = new Size(238, 5);
        sep53.TabIndex = 1;
        // 
        // txtSaveProgramPath
        // 
        txtSaveProgramPath.Dock = DockStyle.Top;
        txtSaveProgramPath.Location = new Point(5, 5);
        txtSaveProgramPath.Name = "txtSaveProgramPath";
        txtSaveProgramPath.PlaceholderText = "path";
        txtSaveProgramPath.Size = new Size(238, 23);
        txtSaveProgramPath.TabIndex = 0;
        txtSaveProgramPath.Text = "$temp/myprogram";
        // 
        // pnlProgramName
        // 
        pnlProgramName.BorderStyle = BorderStyle.FixedSingle;
        pnlProgramName.Controls.Add(btnSetEntryPoint);
        pnlProgramName.Controls.Add(sep56);
        pnlProgramName.Controls.Add(txtSetEntryPointRoutine);
        pnlProgramName.Controls.Add(sep55);
        pnlProgramName.Controls.Add(btnSetProgramName);
        pnlProgramName.Controls.Add(sep54);
        pnlProgramName.Controls.Add(txtSetProgramNameName);
        pnlProgramName.Location = new Point(259, 3);
        pnlProgramName.Name = "pnlProgramName";
        pnlProgramName.Padding = new Padding(5);
        pnlProgramName.Size = new Size(250, 119);
        pnlProgramName.TabIndex = 3;
        // 
        // btnSetEntryPoint
        // 
        btnSetEntryPoint.Dock = DockStyle.Top;
        btnSetEntryPoint.Location = new Point(5, 89);
        btnSetEntryPoint.Name = "btnSetEntryPoint";
        btnSetEntryPoint.Size = new Size(238, 23);
        btnSetEntryPoint.TabIndex = 6;
        btnSetEntryPoint.Text = "Set Entry point";
        btnSetEntryPoint.UseVisualStyleBackColor = true;
        btnSetEntryPoint.Click += btnSetEntryPoint_Click;
        // 
        // sep56
        // 
        sep56.Dock = DockStyle.Top;
        sep56.Location = new Point(5, 84);
        sep56.Name = "sep56";
        sep56.Size = new Size(238, 5);
        sep56.TabIndex = 5;
        // 
        // txtSetEntryPointRoutine
        // 
        txtSetEntryPointRoutine.Dock = DockStyle.Top;
        txtSetEntryPointRoutine.Location = new Point(5, 61);
        txtSetEntryPointRoutine.Name = "txtSetEntryPointRoutine";
        txtSetEntryPointRoutine.PlaceholderText = "routine";
        txtSetEntryPointRoutine.Size = new Size(238, 23);
        txtSetEntryPointRoutine.TabIndex = 4;
        txtSetEntryPointRoutine.Text = "main";
        // 
        // sep55
        // 
        sep55.Dock = DockStyle.Top;
        sep55.Location = new Point(5, 56);
        sep55.Name = "sep55";
        sep55.Size = new Size(238, 5);
        sep55.TabIndex = 3;
        // 
        // btnSetProgramName
        // 
        btnSetProgramName.Dock = DockStyle.Top;
        btnSetProgramName.Location = new Point(5, 33);
        btnSetProgramName.Name = "btnSetProgramName";
        btnSetProgramName.Size = new Size(238, 23);
        btnSetProgramName.TabIndex = 2;
        btnSetProgramName.Text = "Set Program name";
        btnSetProgramName.UseVisualStyleBackColor = true;
        btnSetProgramName.Click += btnSetProgramName_Click;
        // 
        // sep54
        // 
        sep54.Dock = DockStyle.Top;
        sep54.Location = new Point(5, 28);
        sep54.Name = "sep54";
        sep54.Size = new Size(238, 5);
        sep54.TabIndex = 1;
        // 
        // txtSetProgramNameName
        // 
        txtSetProgramNameName.Dock = DockStyle.Top;
        txtSetProgramNameName.Location = new Point(5, 5);
        txtSetProgramNameName.Name = "txtSetProgramNameName";
        txtSetProgramNameName.PlaceholderText = "name";
        txtSetProgramNameName.Size = new Size(238, 23);
        txtSetProgramNameName.TabIndex = 0;
        // 
        // pnlBreakpoints
        // 
        pnlBreakpoints.BorderStyle = BorderStyle.FixedSingle;
        pnlBreakpoints.Controls.Add(btnSetBreakpoint);
        pnlBreakpoints.Controls.Add(sep60);
        pnlBreakpoints.Controls.Add(numSetBreakpointColumn);
        pnlBreakpoints.Controls.Add(sep59);
        pnlBreakpoints.Controls.Add(numSetBreakpointRow);
        pnlBreakpoints.Controls.Add(sep58);
        pnlBreakpoints.Controls.Add(gridBreakpoints);
        pnlBreakpoints.Controls.Add(sep57);
        pnlBreakpoints.Controls.Add(btnGetBreakpoints);
        pnlBreakpoints.Location = new Point(259, 128);
        pnlBreakpoints.Name = "pnlBreakpoints";
        pnlBreakpoints.Padding = new Padding(5);
        pnlBreakpoints.Size = new Size(250, 244);
        pnlBreakpoints.TabIndex = 4;
        // 
        // btnSetBreakpoint
        // 
        btnSetBreakpoint.Dock = DockStyle.Top;
        btnSetBreakpoint.Location = new Point(5, 214);
        btnSetBreakpoint.Name = "btnSetBreakpoint";
        btnSetBreakpoint.Size = new Size(238, 23);
        btnSetBreakpoint.TabIndex = 8;
        btnSetBreakpoint.Text = "Set Breakpoint";
        btnSetBreakpoint.UseVisualStyleBackColor = true;
        btnSetBreakpoint.Click += btnSetBreakpoint_Click;
        // 
        // sep60
        // 
        sep60.Dock = DockStyle.Top;
        sep60.Location = new Point(5, 209);
        sep60.Name = "sep60";
        sep60.Size = new Size(238, 5);
        sep60.TabIndex = 7;
        // 
        // numSetBreakpointColumn
        // 
        numSetBreakpointColumn.Dock = DockStyle.Top;
        numSetBreakpointColumn.Location = new Point(5, 186);
        numSetBreakpointColumn.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numSetBreakpointColumn.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numSetBreakpointColumn.Name = "numSetBreakpointColumn";
        numSetBreakpointColumn.Size = new Size(238, 23);
        numSetBreakpointColumn.TabIndex = 6;
        numSetBreakpointColumn.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // sep59
        // 
        sep59.Dock = DockStyle.Top;
        sep59.Location = new Point(5, 181);
        sep59.Name = "sep59";
        sep59.Size = new Size(238, 5);
        sep59.TabIndex = 5;
        // 
        // numSetBreakpointRow
        // 
        numSetBreakpointRow.Dock = DockStyle.Top;
        numSetBreakpointRow.Location = new Point(5, 158);
        numSetBreakpointRow.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numSetBreakpointRow.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numSetBreakpointRow.Name = "numSetBreakpointRow";
        numSetBreakpointRow.Size = new Size(238, 23);
        numSetBreakpointRow.TabIndex = 4;
        numSetBreakpointRow.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // sep58
        // 
        sep58.Dock = DockStyle.Top;
        sep58.Location = new Point(5, 153);
        sep58.Name = "sep58";
        sep58.Size = new Size(238, 5);
        sep58.TabIndex = 3;
        // 
        // gridBreakpoints
        // 
        gridBreakpoints.Dock = DockStyle.Top;
        gridBreakpoints.HelpVisible = false;
        gridBreakpoints.Location = new Point(5, 33);
        gridBreakpoints.Name = "gridBreakpoints";
        gridBreakpoints.PropertySort = PropertySort.NoSort;
        gridBreakpoints.Size = new Size(238, 120);
        gridBreakpoints.TabIndex = 2;
        gridBreakpoints.ToolbarVisible = false;
        // 
        // sep57
        // 
        sep57.Dock = DockStyle.Top;
        sep57.Location = new Point(5, 28);
        sep57.Name = "sep57";
        sep57.Size = new Size(238, 5);
        sep57.TabIndex = 1;
        // 
        // btnGetBreakpoints
        // 
        btnGetBreakpoints.Dock = DockStyle.Top;
        btnGetBreakpoints.Location = new Point(5, 5);
        btnGetBreakpoints.Name = "btnGetBreakpoints";
        btnGetBreakpoints.Size = new Size(238, 23);
        btnGetBreakpoints.TabIndex = 0;
        btnGetBreakpoints.Text = "Get Breakpoints";
        btnGetBreakpoints.UseVisualStyleBackColor = true;
        btnGetBreakpoints.Click += btnGetBreakpoints_Click;
        // 
        // pnlBuildErrors
        // 
        pnlBuildErrors.BorderStyle = BorderStyle.FixedSingle;
        pnlBuildErrors.Controls.Add(gridBuildErrors);
        pnlBuildErrors.Controls.Add(sep61);
        pnlBuildErrors.Controls.Add(btnGetBuildErrors);
        pnlBuildErrors.Location = new Point(515, 3);
        pnlBuildErrors.Name = "pnlBuildErrors";
        pnlBuildErrors.Padding = new Padding(5);
        pnlBuildErrors.Size = new Size(250, 198);
        pnlBuildErrors.TabIndex = 5;
        // 
        // gridBuildErrors
        // 
        gridBuildErrors.Dock = DockStyle.Top;
        gridBuildErrors.HelpVisible = false;
        gridBuildErrors.Location = new Point(5, 33);
        gridBuildErrors.Name = "gridBuildErrors";
        gridBuildErrors.PropertySort = PropertySort.NoSort;
        gridBuildErrors.Size = new Size(238, 158);
        gridBuildErrors.TabIndex = 2;
        gridBuildErrors.ToolbarVisible = false;
        // 
        // sep61
        // 
        sep61.Dock = DockStyle.Top;
        sep61.Location = new Point(5, 28);
        sep61.Name = "sep61";
        sep61.Size = new Size(238, 5);
        sep61.TabIndex = 1;
        // 
        // btnGetBuildErrors
        // 
        btnGetBuildErrors.Dock = DockStyle.Top;
        btnGetBuildErrors.Location = new Point(5, 5);
        btnGetBuildErrors.Name = "btnGetBuildErrors";
        btnGetBuildErrors.Size = new Size(238, 23);
        btnGetBuildErrors.TabIndex = 0;
        btnGetBuildErrors.Text = "Get Build errors";
        btnGetBuildErrors.UseVisualStyleBackColor = true;
        btnGetBuildErrors.Click += btnGetBuildErrors_Click;
        // 
        // pnlPointers
        // 
        pnlPointers.BorderStyle = BorderStyle.FixedSingle;
        pnlPointers.Controls.Add(gridPointers);
        pnlPointers.Controls.Add(sep62);
        pnlPointers.Controls.Add(btnGetPointers);
        pnlPointers.Location = new Point(771, 3);
        pnlPointers.Name = "pnlPointers";
        pnlPointers.Padding = new Padding(5);
        pnlPointers.Size = new Size(250, 369);
        pnlPointers.TabIndex = 6;
        // 
        // gridPointers
        // 
        gridPointers.Dock = DockStyle.Top;
        gridPointers.HelpVisible = false;
        gridPointers.Location = new Point(5, 33);
        gridPointers.Name = "gridPointers";
        gridPointers.PropertySort = PropertySort.NoSort;
        gridPointers.Size = new Size(238, 329);
        gridPointers.TabIndex = 2;
        gridPointers.ToolbarVisible = false;
        // 
        // sep62
        // 
        sep62.Dock = DockStyle.Top;
        sep62.Location = new Point(5, 28);
        sep62.Name = "sep62";
        sep62.Size = new Size(238, 5);
        sep62.TabIndex = 1;
        // 
        // btnGetPointers
        // 
        btnGetPointers.Dock = DockStyle.Top;
        btnGetPointers.Location = new Point(5, 5);
        btnGetPointers.Name = "btnGetPointers";
        btnGetPointers.Size = new Size(238, 23);
        btnGetPointers.TabIndex = 0;
        btnGetPointers.Text = "Get Pointers";
        btnGetPointers.UseVisualStyleBackColor = true;
        btnGetPointers.Click += btnGetPointers_Click;
        // 
        // pnlProgramCounterPosition
        // 
        pnlProgramCounterPosition.BorderStyle = BorderStyle.FixedSingle;
        pnlProgramCounterPosition.Controls.Add(gridProgramCounterPosition);
        pnlProgramCounterPosition.Controls.Add(sep63);
        pnlProgramCounterPosition.Controls.Add(btnGetProgramCounterPosition);
        pnlProgramCounterPosition.Location = new Point(1027, 3);
        pnlProgramCounterPosition.Name = "pnlProgramCounterPosition";
        pnlProgramCounterPosition.Padding = new Padding(5);
        pnlProgramCounterPosition.Size = new Size(250, 160);
        pnlProgramCounterPosition.TabIndex = 7;
        // 
        // gridProgramCounterPosition
        // 
        gridProgramCounterPosition.Dock = DockStyle.Top;
        gridProgramCounterPosition.HelpVisible = false;
        gridProgramCounterPosition.Location = new Point(5, 33);
        gridProgramCounterPosition.Name = "gridProgramCounterPosition";
        gridProgramCounterPosition.PropertySort = PropertySort.NoSort;
        gridProgramCounterPosition.Size = new Size(238, 120);
        gridProgramCounterPosition.TabIndex = 2;
        gridProgramCounterPosition.ToolbarVisible = false;
        // 
        // sep63
        // 
        sep63.Dock = DockStyle.Top;
        sep63.Location = new Point(5, 28);
        sep63.Name = "sep63";
        sep63.Size = new Size(238, 5);
        sep63.TabIndex = 1;
        // 
        // btnGetProgramCounterPosition
        // 
        btnGetProgramCounterPosition.Dock = DockStyle.Top;
        btnGetProgramCounterPosition.Location = new Point(5, 5);
        btnGetProgramCounterPosition.Name = "btnGetProgramCounterPosition";
        btnGetProgramCounterPosition.Size = new Size(238, 23);
        btnGetProgramCounterPosition.TabIndex = 0;
        btnGetProgramCounterPosition.Text = "Get Program counter position";
        btnGetProgramCounterPosition.UseVisualStyleBackColor = true;
        btnGetProgramCounterPosition.Click += btnGetProgramCounterPosition_Click;
        // 
        // pnlProgramPointerMoves
        // 
        pnlProgramPointerMoves.BorderStyle = BorderStyle.FixedSingle;
        pnlProgramPointerMoves.Controls.Add(btnSetProgramPointerToPreviousInstruction);
        pnlProgramPointerMoves.Controls.Add(sep71);
        pnlProgramPointerMoves.Controls.Add(btnSetProgramPointerToNextInstruction);
        pnlProgramPointerMoves.Controls.Add(sep70);
        pnlProgramPointerMoves.Controls.Add(btnSetProgramPointerToRoutine);
        pnlProgramPointerMoves.Controls.Add(sep69);
        pnlProgramPointerMoves.Controls.Add(btnSetProgramPointerToCursor);
        pnlProgramPointerMoves.Controls.Add(sep68);
        pnlProgramPointerMoves.Controls.Add(chkSetProgramPointerUserLevel);
        pnlProgramPointerMoves.Controls.Add(sep67);
        pnlProgramPointerMoves.Controls.Add(numSetProgramPointerColumn);
        pnlProgramPointerMoves.Controls.Add(sep66);
        pnlProgramPointerMoves.Controls.Add(numSetProgramPointerRow);
        pnlProgramPointerMoves.Controls.Add(sep65);
        pnlProgramPointerMoves.Controls.Add(txtSetProgramPointerRoutine);
        pnlProgramPointerMoves.Controls.Add(sep64);
        pnlProgramPointerMoves.Controls.Add(lblProgramPointer);
        pnlProgramPointerMoves.Location = new Point(1283, 3);
        pnlProgramPointerMoves.Name = "pnlProgramPointerMoves";
        pnlProgramPointerMoves.Padding = new Padding(5);
        pnlProgramPointerMoves.Size = new Size(250, 259);
        pnlProgramPointerMoves.TabIndex = 8;
        // 
        // btnSetProgramPointerToPreviousInstruction
        // 
        btnSetProgramPointerToPreviousInstruction.Dock = DockStyle.Top;
        btnSetProgramPointerToPreviousInstruction.Location = new Point(5, 229);
        btnSetProgramPointerToPreviousInstruction.Name = "btnSetProgramPointerToPreviousInstruction";
        btnSetProgramPointerToPreviousInstruction.Size = new Size(238, 23);
        btnSetProgramPointerToPreviousInstruction.TabIndex = 16;
        btnSetProgramPointerToPreviousInstruction.Text = "To previous instruction";
        btnSetProgramPointerToPreviousInstruction.UseVisualStyleBackColor = true;
        btnSetProgramPointerToPreviousInstruction.Click += btnSetProgramPointerToPreviousInstruction_Click;
        // 
        // sep71
        // 
        sep71.Dock = DockStyle.Top;
        sep71.Location = new Point(5, 224);
        sep71.Name = "sep71";
        sep71.Size = new Size(238, 5);
        sep71.TabIndex = 15;
        // 
        // btnSetProgramPointerToNextInstruction
        // 
        btnSetProgramPointerToNextInstruction.Dock = DockStyle.Top;
        btnSetProgramPointerToNextInstruction.Location = new Point(5, 201);
        btnSetProgramPointerToNextInstruction.Name = "btnSetProgramPointerToNextInstruction";
        btnSetProgramPointerToNextInstruction.Size = new Size(238, 23);
        btnSetProgramPointerToNextInstruction.TabIndex = 14;
        btnSetProgramPointerToNextInstruction.Text = "To next instruction";
        btnSetProgramPointerToNextInstruction.UseVisualStyleBackColor = true;
        btnSetProgramPointerToNextInstruction.Click += btnSetProgramPointerToNextInstruction_Click;
        // 
        // sep70
        // 
        sep70.Dock = DockStyle.Top;
        sep70.Location = new Point(5, 196);
        sep70.Name = "sep70";
        sep70.Size = new Size(238, 5);
        sep70.TabIndex = 13;
        // 
        // btnSetProgramPointerToRoutine
        // 
        btnSetProgramPointerToRoutine.Dock = DockStyle.Top;
        btnSetProgramPointerToRoutine.Location = new Point(5, 173);
        btnSetProgramPointerToRoutine.Name = "btnSetProgramPointerToRoutine";
        btnSetProgramPointerToRoutine.Size = new Size(238, 23);
        btnSetProgramPointerToRoutine.TabIndex = 12;
        btnSetProgramPointerToRoutine.Text = "To routine";
        btnSetProgramPointerToRoutine.UseVisualStyleBackColor = true;
        btnSetProgramPointerToRoutine.Click += btnSetProgramPointerToRoutine_Click;
        // 
        // sep69
        // 
        sep69.Dock = DockStyle.Top;
        sep69.Location = new Point(5, 168);
        sep69.Name = "sep69";
        sep69.Size = new Size(238, 5);
        sep69.TabIndex = 11;
        // 
        // btnSetProgramPointerToCursor
        // 
        btnSetProgramPointerToCursor.Dock = DockStyle.Top;
        btnSetProgramPointerToCursor.Location = new Point(5, 145);
        btnSetProgramPointerToCursor.Name = "btnSetProgramPointerToCursor";
        btnSetProgramPointerToCursor.Size = new Size(238, 23);
        btnSetProgramPointerToCursor.TabIndex = 10;
        btnSetProgramPointerToCursor.Text = "To cursor";
        btnSetProgramPointerToCursor.UseVisualStyleBackColor = true;
        btnSetProgramPointerToCursor.Click += btnSetProgramPointerToCursor_Click;
        // 
        // sep68
        // 
        sep68.Dock = DockStyle.Top;
        sep68.Location = new Point(5, 140);
        sep68.Name = "sep68";
        sep68.Size = new Size(238, 5);
        sep68.TabIndex = 9;
        // 
        // chkSetProgramPointerUserLevel
        // 
        chkSetProgramPointerUserLevel.Dock = DockStyle.Top;
        chkSetProgramPointerUserLevel.Location = new Point(5, 117);
        chkSetProgramPointerUserLevel.Name = "chkSetProgramPointerUserLevel";
        chkSetProgramPointerUserLevel.Size = new Size(238, 23);
        chkSetProgramPointerUserLevel.TabIndex = 8;
        chkSetProgramPointerUserLevel.Text = "User level";
        chkSetProgramPointerUserLevel.UseVisualStyleBackColor = true;
        // 
        // sep67
        // 
        sep67.Dock = DockStyle.Top;
        sep67.Location = new Point(5, 112);
        sep67.Name = "sep67";
        sep67.Size = new Size(238, 5);
        sep67.TabIndex = 7;
        // 
        // numSetProgramPointerColumn
        // 
        numSetProgramPointerColumn.Dock = DockStyle.Top;
        numSetProgramPointerColumn.Location = new Point(5, 89);
        numSetProgramPointerColumn.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numSetProgramPointerColumn.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numSetProgramPointerColumn.Name = "numSetProgramPointerColumn";
        numSetProgramPointerColumn.Size = new Size(238, 23);
        numSetProgramPointerColumn.TabIndex = 6;
        numSetProgramPointerColumn.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // sep66
        // 
        sep66.Dock = DockStyle.Top;
        sep66.Location = new Point(5, 84);
        sep66.Name = "sep66";
        sep66.Size = new Size(238, 5);
        sep66.TabIndex = 5;
        // 
        // numSetProgramPointerRow
        // 
        numSetProgramPointerRow.Dock = DockStyle.Top;
        numSetProgramPointerRow.Location = new Point(5, 61);
        numSetProgramPointerRow.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numSetProgramPointerRow.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numSetProgramPointerRow.Name = "numSetProgramPointerRow";
        numSetProgramPointerRow.Size = new Size(238, 23);
        numSetProgramPointerRow.TabIndex = 4;
        numSetProgramPointerRow.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // sep65
        // 
        sep65.Dock = DockStyle.Top;
        sep65.Location = new Point(5, 56);
        sep65.Name = "sep65";
        sep65.Size = new Size(238, 5);
        sep65.TabIndex = 3;
        // 
        // txtSetProgramPointerRoutine
        // 
        txtSetProgramPointerRoutine.Dock = DockStyle.Top;
        txtSetProgramPointerRoutine.Location = new Point(5, 33);
        txtSetProgramPointerRoutine.Name = "txtSetProgramPointerRoutine";
        txtSetProgramPointerRoutine.PlaceholderText = "routine";
        txtSetProgramPointerRoutine.Size = new Size(238, 23);
        txtSetProgramPointerRoutine.TabIndex = 2;
        txtSetProgramPointerRoutine.Text = "main";
        // 
        // sep64
        // 
        sep64.Dock = DockStyle.Top;
        sep64.Location = new Point(5, 28);
        sep64.Name = "sep64";
        sep64.Size = new Size(238, 5);
        sep64.TabIndex = 1;
        // 
        // lblProgramPointer
        // 
        lblProgramPointer.Dock = DockStyle.Top;
        lblProgramPointer.Location = new Point(5, 5);
        lblProgramPointer.Name = "lblProgramPointer";
        lblProgramPointer.Size = new Size(238, 23);
        lblProgramPointer.TabIndex = 0;
        lblProgramPointer.Text = "Move the program pointer";
        lblProgramPointer.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlProgramPointerUrl
        // 
        pnlProgramPointerUrl.BorderStyle = BorderStyle.FixedSingle;
        pnlProgramPointerUrl.Controls.Add(btnSetProgramPointerToRoutineUrl);
        pnlProgramPointerUrl.Controls.Add(sep72);
        pnlProgramPointerUrl.Controls.Add(txtSetProgramPointerToRoutineUrlRoutineUrl);
        pnlProgramPointerUrl.Location = new Point(1283, 268);
        pnlProgramPointerUrl.Name = "pnlProgramPointerUrl";
        pnlProgramPointerUrl.Padding = new Padding(5);
        pnlProgramPointerUrl.Size = new Size(250, 63);
        pnlProgramPointerUrl.TabIndex = 9;
        // 
        // btnSetProgramPointerToRoutineUrl
        // 
        btnSetProgramPointerToRoutineUrl.Dock = DockStyle.Top;
        btnSetProgramPointerToRoutineUrl.Location = new Point(5, 33);
        btnSetProgramPointerToRoutineUrl.Name = "btnSetProgramPointerToRoutineUrl";
        btnSetProgramPointerToRoutineUrl.Size = new Size(238, 23);
        btnSetProgramPointerToRoutineUrl.TabIndex = 2;
        btnSetProgramPointerToRoutineUrl.Text = "To routine by path";
        btnSetProgramPointerToRoutineUrl.UseVisualStyleBackColor = true;
        btnSetProgramPointerToRoutineUrl.Click += btnSetProgramPointerToRoutineUrl_Click;
        // 
        // sep72
        // 
        sep72.Dock = DockStyle.Top;
        sep72.Location = new Point(5, 28);
        sep72.Name = "sep72";
        sep72.Size = new Size(238, 5);
        sep72.TabIndex = 1;
        // 
        // txtSetProgramPointerToRoutineUrlRoutineUrl
        // 
        txtSetProgramPointerToRoutineUrlRoutineUrl.Dock = DockStyle.Top;
        txtSetProgramPointerToRoutineUrlRoutineUrl.Location = new Point(5, 5);
        txtSetProgramPointerToRoutineUrlRoutineUrl.Name = "txtSetProgramPointerToRoutineUrlRoutineUrl";
        txtSetProgramPointerToRoutineUrlRoutineUrl.PlaceholderText = "routineUrl";
        txtSetProgramPointerToRoutineUrlRoutineUrl.Size = new Size(238, 23);
        txtSetProgramPointerToRoutineUrlRoutineUrl.TabIndex = 0;
        // 
        // tabModules
        // 
        tabModules.Controls.Add(flowModules);
        tabModules.Location = new Point(4, 24);
        tabModules.Name = "tabModules";
        tabModules.Padding = new Padding(3);
        tabModules.Size = new Size(882, 421);
        tabModules.TabIndex = 3;
        tabModules.Text = "Modules";
        tabModules.UseVisualStyleBackColor = true;
        // 
        // flowModules
        // 
        flowModules.AutoScroll = true;
        flowModules.Controls.Add(pnlModules);
        flowModules.Controls.Add(pnlModule);
        flowModules.Controls.Add(pnlModuleCounters);
        flowModules.Controls.Add(pnlModuleText);
        flowModules.Controls.Add(pnlModuleTextRange);
        flowModules.Controls.Add(pnlSearchModuleText);
        flowModules.Controls.Add(pnlSyncPers);
        flowModules.Controls.Add(pnlModuleAttributes);
        flowModules.Controls.Add(pnlSaveModule);
        flowModules.Controls.Add(pnlModuleSymbol);
        flowModules.Controls.Add(pnlRoutine);
        flowModules.Controls.Add(pnlRoutineArguments);
        flowModules.Controls.Add(pnlInstructionTemplate);
        flowModules.Controls.Add(pnlObjectChildren);
        flowModules.Controls.Add(pnlModifiablePositions);
        flowModules.Controls.Add(pnlAllModifiablePositions);
        flowModules.Dock = DockStyle.Fill;
        flowModules.FlowDirection = FlowDirection.TopDown;
        flowModules.Location = new Point(3, 3);
        flowModules.Name = "flowModules";
        flowModules.Size = new Size(876, 415);
        flowModules.TabIndex = 0;
        // 
        // pnlModules
        // 
        pnlModules.BorderStyle = BorderStyle.FixedSingle;
        pnlModules.Controls.Add(gridModules);
        pnlModules.Controls.Add(sep73);
        pnlModules.Controls.Add(btnGetModules);
        pnlModules.Location = new Point(3, 3);
        pnlModules.Name = "pnlModules";
        pnlModules.Padding = new Padding(5);
        pnlModules.Size = new Size(250, 236);
        pnlModules.TabIndex = 0;
        // 
        // gridModules
        // 
        gridModules.Dock = DockStyle.Top;
        gridModules.HelpVisible = false;
        gridModules.Location = new Point(5, 33);
        gridModules.Name = "gridModules";
        gridModules.PropertySort = PropertySort.NoSort;
        gridModules.Size = new Size(238, 196);
        gridModules.TabIndex = 2;
        gridModules.ToolbarVisible = false;
        // 
        // sep73
        // 
        sep73.Dock = DockStyle.Top;
        sep73.Location = new Point(5, 28);
        sep73.Name = "sep73";
        sep73.Size = new Size(238, 5);
        sep73.TabIndex = 1;
        // 
        // btnGetModules
        // 
        btnGetModules.Dock = DockStyle.Top;
        btnGetModules.Location = new Point(5, 5);
        btnGetModules.Name = "btnGetModules";
        btnGetModules.Size = new Size(238, 23);
        btnGetModules.TabIndex = 0;
        btnGetModules.Text = "Get Modules";
        btnGetModules.UseVisualStyleBackColor = true;
        btnGetModules.Click += btnGetModules_Click;
        // 
        // pnlModule
        // 
        pnlModule.BorderStyle = BorderStyle.FixedSingle;
        pnlModule.Controls.Add(gridModule);
        pnlModule.Controls.Add(sep74);
        pnlModule.Controls.Add(btnGetModule);
        pnlModule.Location = new Point(3, 245);
        pnlModule.Name = "pnlModule";
        pnlModule.Padding = new Padding(5);
        pnlModule.Size = new Size(250, 160);
        pnlModule.TabIndex = 1;
        // 
        // gridModule
        // 
        gridModule.Dock = DockStyle.Top;
        gridModule.HelpVisible = false;
        gridModule.Location = new Point(5, 33);
        gridModule.Name = "gridModule";
        gridModule.PropertySort = PropertySort.NoSort;
        gridModule.Size = new Size(238, 120);
        gridModule.TabIndex = 2;
        gridModule.ToolbarVisible = false;
        // 
        // sep74
        // 
        sep74.Dock = DockStyle.Top;
        sep74.Location = new Point(5, 28);
        sep74.Name = "sep74";
        sep74.Size = new Size(238, 5);
        sep74.TabIndex = 1;
        // 
        // btnGetModule
        // 
        btnGetModule.Dock = DockStyle.Top;
        btnGetModule.Location = new Point(5, 5);
        btnGetModule.Name = "btnGetModule";
        btnGetModule.Size = new Size(238, 23);
        btnGetModule.TabIndex = 0;
        btnGetModule.Text = "Get Module";
        btnGetModule.UseVisualStyleBackColor = true;
        btnGetModule.Click += btnGetModule_Click;
        // 
        // pnlModuleCounters
        // 
        pnlModuleCounters.BorderStyle = BorderStyle.FixedSingle;
        pnlModuleCounters.Controls.Add(gridModuleExtension);
        pnlModuleCounters.Controls.Add(sep77);
        pnlModuleCounters.Controls.Add(btnGetModuleExtension);
        pnlModuleCounters.Controls.Add(sep76);
        pnlModuleCounters.Controls.Add(txtModuleChangeCount);
        pnlModuleCounters.Controls.Add(sep75);
        pnlModuleCounters.Controls.Add(btnGetModuleChangeCount);
        pnlModuleCounters.Location = new Point(259, 3);
        pnlModuleCounters.Name = "pnlModuleCounters";
        pnlModuleCounters.Padding = new Padding(5);
        pnlModuleCounters.Size = new Size(250, 159);
        pnlModuleCounters.TabIndex = 2;
        // 
        // gridModuleExtension
        // 
        gridModuleExtension.Dock = DockStyle.Top;
        gridModuleExtension.HelpVisible = false;
        gridModuleExtension.Location = new Point(5, 89);
        gridModuleExtension.Name = "gridModuleExtension";
        gridModuleExtension.PropertySort = PropertySort.NoSort;
        gridModuleExtension.Size = new Size(238, 63);
        gridModuleExtension.TabIndex = 6;
        gridModuleExtension.ToolbarVisible = false;
        // 
        // sep77
        // 
        sep77.Dock = DockStyle.Top;
        sep77.Location = new Point(5, 84);
        sep77.Name = "sep77";
        sep77.Size = new Size(238, 5);
        sep77.TabIndex = 5;
        // 
        // btnGetModuleExtension
        // 
        btnGetModuleExtension.Dock = DockStyle.Top;
        btnGetModuleExtension.Location = new Point(5, 61);
        btnGetModuleExtension.Name = "btnGetModuleExtension";
        btnGetModuleExtension.Size = new Size(238, 23);
        btnGetModuleExtension.TabIndex = 4;
        btnGetModuleExtension.Text = "Get Module extension";
        btnGetModuleExtension.UseVisualStyleBackColor = true;
        btnGetModuleExtension.Click += btnGetModuleExtension_Click;
        // 
        // sep76
        // 
        sep76.Dock = DockStyle.Top;
        sep76.Location = new Point(5, 56);
        sep76.Name = "sep76";
        sep76.Size = new Size(238, 5);
        sep76.TabIndex = 3;
        // 
        // txtModuleChangeCount
        // 
        txtModuleChangeCount.Dock = DockStyle.Top;
        txtModuleChangeCount.Location = new Point(5, 33);
        txtModuleChangeCount.Name = "txtModuleChangeCount";
        txtModuleChangeCount.PlaceholderText = "change count";
        txtModuleChangeCount.ReadOnly = true;
        txtModuleChangeCount.Size = new Size(238, 23);
        txtModuleChangeCount.TabIndex = 2;
        // 
        // sep75
        // 
        sep75.Dock = DockStyle.Top;
        sep75.Location = new Point(5, 28);
        sep75.Name = "sep75";
        sep75.Size = new Size(238, 5);
        sep75.TabIndex = 1;
        // 
        // btnGetModuleChangeCount
        // 
        btnGetModuleChangeCount.Dock = DockStyle.Top;
        btnGetModuleChangeCount.Location = new Point(5, 5);
        btnGetModuleChangeCount.Name = "btnGetModuleChangeCount";
        btnGetModuleChangeCount.Size = new Size(238, 23);
        btnGetModuleChangeCount.TabIndex = 0;
        btnGetModuleChangeCount.Text = "Get Module change count";
        btnGetModuleChangeCount.UseVisualStyleBackColor = true;
        btnGetModuleChangeCount.Click += btnGetModuleChangeCount_Click;
        // 
        // pnlModuleText
        // 
        pnlModuleText.BorderStyle = BorderStyle.FixedSingle;
        pnlModuleText.Controls.Add(btnSetModuleText);
        pnlModuleText.Controls.Add(sep79);
        pnlModuleText.Controls.Add(memoModuleText);
        pnlModuleText.Controls.Add(sep78);
        pnlModuleText.Controls.Add(btnGetModuleText);
        pnlModuleText.Location = new Point(259, 168);
        pnlModuleText.Name = "pnlModuleText";
        pnlModuleText.Padding = new Padding(5);
        pnlModuleText.Size = new Size(250, 218);
        pnlModuleText.TabIndex = 3;
        // 
        // btnSetModuleText
        // 
        btnSetModuleText.Dock = DockStyle.Top;
        btnSetModuleText.Location = new Point(5, 188);
        btnSetModuleText.Name = "btnSetModuleText";
        btnSetModuleText.Size = new Size(238, 23);
        btnSetModuleText.TabIndex = 4;
        btnSetModuleText.Text = "Set Module text";
        btnSetModuleText.UseVisualStyleBackColor = true;
        btnSetModuleText.Click += btnSetModuleText_Click;
        // 
        // sep79
        // 
        sep79.Dock = DockStyle.Top;
        sep79.Location = new Point(5, 183);
        sep79.Name = "sep79";
        sep79.Size = new Size(238, 5);
        sep79.TabIndex = 3;
        // 
        // memoModuleText
        // 
        memoModuleText.Dock = DockStyle.Top;
        memoModuleText.Location = new Point(5, 33);
        memoModuleText.Multiline = true;
        memoModuleText.Name = "memoModuleText";
        memoModuleText.PlaceholderText = "module source";
        memoModuleText.ScrollBars = ScrollBars.Both;
        memoModuleText.Size = new Size(238, 150);
        memoModuleText.TabIndex = 2;
        memoModuleText.WordWrap = false;
        // 
        // sep78
        // 
        sep78.Dock = DockStyle.Top;
        sep78.Location = new Point(5, 28);
        sep78.Name = "sep78";
        sep78.Size = new Size(238, 5);
        sep78.TabIndex = 1;
        // 
        // btnGetModuleText
        // 
        btnGetModuleText.Dock = DockStyle.Top;
        btnGetModuleText.Location = new Point(5, 5);
        btnGetModuleText.Name = "btnGetModuleText";
        btnGetModuleText.Size = new Size(238, 23);
        btnGetModuleText.TabIndex = 0;
        btnGetModuleText.Text = "Get Module text";
        btnGetModuleText.UseVisualStyleBackColor = true;
        btnGetModuleText.Click += btnGetModuleText_Click;
        // 
        // pnlModuleTextRange
        // 
        pnlModuleTextRange.BorderStyle = BorderStyle.FixedSingle;
        pnlModuleTextRange.Controls.Add(gridSetModuleTextRangeResult);
        pnlModuleTextRange.Controls.Add(sep89);
        pnlModuleTextRange.Controls.Add(btnSetModuleTextRange);
        pnlModuleTextRange.Controls.Add(sep88);
        pnlModuleTextRange.Controls.Add(cboSetModuleTextRangeQueryMode);
        pnlModuleTextRange.Controls.Add(sep87);
        pnlModuleTextRange.Controls.Add(cboSetModuleTextRangeReplaceMode);
        pnlModuleTextRange.Controls.Add(sep86);
        pnlModuleTextRange.Controls.Add(memoModuleTextRange);
        pnlModuleTextRange.Controls.Add(sep85);
        pnlModuleTextRange.Controls.Add(btnGetModuleTextRange);
        pnlModuleTextRange.Controls.Add(sep84);
        pnlModuleTextRange.Controls.Add(numModuleTextRangeEndColumn);
        pnlModuleTextRange.Controls.Add(sep83);
        pnlModuleTextRange.Controls.Add(numModuleTextRangeEndRow);
        pnlModuleTextRange.Controls.Add(sep82);
        pnlModuleTextRange.Controls.Add(numModuleTextRangeStartColumn);
        pnlModuleTextRange.Controls.Add(sep81);
        pnlModuleTextRange.Controls.Add(numModuleTextRangeStartRow);
        pnlModuleTextRange.Controls.Add(sep80);
        pnlModuleTextRange.Controls.Add(lblModuleTextRange);
        pnlModuleTextRange.Location = new Point(515, 3);
        pnlModuleTextRange.Name = "pnlModuleTextRange";
        pnlModuleTextRange.Padding = new Padding(5);
        pnlModuleTextRange.Size = new Size(250, 392);
        pnlModuleTextRange.TabIndex = 4;
        // 
        // gridSetModuleTextRangeResult
        // 
        gridSetModuleTextRangeResult.Dock = DockStyle.Top;
        gridSetModuleTextRangeResult.HelpVisible = false;
        gridSetModuleTextRangeResult.Location = new Point(5, 322);
        gridSetModuleTextRangeResult.Name = "gridSetModuleTextRangeResult";
        gridSetModuleTextRangeResult.PropertySort = PropertySort.NoSort;
        gridSetModuleTextRangeResult.Size = new Size(238, 63);
        gridSetModuleTextRangeResult.TabIndex = 20;
        gridSetModuleTextRangeResult.ToolbarVisible = false;
        // 
        // sep89
        // 
        sep89.Dock = DockStyle.Top;
        sep89.Location = new Point(5, 317);
        sep89.Name = "sep89";
        sep89.Size = new Size(238, 5);
        sep89.TabIndex = 19;
        // 
        // btnSetModuleTextRange
        // 
        btnSetModuleTextRange.Dock = DockStyle.Top;
        btnSetModuleTextRange.Location = new Point(5, 294);
        btnSetModuleTextRange.Name = "btnSetModuleTextRange";
        btnSetModuleTextRange.Size = new Size(238, 23);
        btnSetModuleTextRange.TabIndex = 18;
        btnSetModuleTextRange.Text = "Set Module text range";
        btnSetModuleTextRange.UseVisualStyleBackColor = true;
        btnSetModuleTextRange.Click += btnSetModuleTextRange_Click;
        // 
        // sep88
        // 
        sep88.Dock = DockStyle.Top;
        sep88.Location = new Point(5, 289);
        sep88.Name = "sep88";
        sep88.Size = new Size(238, 5);
        sep88.TabIndex = 17;
        // 
        // cboSetModuleTextRangeQueryMode
        // 
        cboSetModuleTextRangeQueryMode.Dock = DockStyle.Top;
        cboSetModuleTextRangeQueryMode.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSetModuleTextRangeQueryMode.FormattingEnabled = true;
        cboSetModuleTextRangeQueryMode.Location = new Point(5, 266);
        cboSetModuleTextRangeQueryMode.Name = "cboSetModuleTextRangeQueryMode";
        cboSetModuleTextRangeQueryMode.Size = new Size(238, 23);
        cboSetModuleTextRangeQueryMode.TabIndex = 16;
        // 
        // sep87
        // 
        sep87.Dock = DockStyle.Top;
        sep87.Location = new Point(5, 261);
        sep87.Name = "sep87";
        sep87.Size = new Size(238, 5);
        sep87.TabIndex = 15;
        // 
        // cboSetModuleTextRangeReplaceMode
        // 
        cboSetModuleTextRangeReplaceMode.Dock = DockStyle.Top;
        cboSetModuleTextRangeReplaceMode.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSetModuleTextRangeReplaceMode.FormattingEnabled = true;
        cboSetModuleTextRangeReplaceMode.Location = new Point(5, 238);
        cboSetModuleTextRangeReplaceMode.Name = "cboSetModuleTextRangeReplaceMode";
        cboSetModuleTextRangeReplaceMode.Size = new Size(238, 23);
        cboSetModuleTextRangeReplaceMode.TabIndex = 14;
        // 
        // sep86
        // 
        sep86.Dock = DockStyle.Top;
        sep86.Location = new Point(5, 233);
        sep86.Name = "sep86";
        sep86.Size = new Size(238, 5);
        sep86.TabIndex = 13;
        // 
        // memoModuleTextRange
        // 
        memoModuleTextRange.Dock = DockStyle.Top;
        memoModuleTextRange.Location = new Point(5, 173);
        memoModuleTextRange.Multiline = true;
        memoModuleTextRange.Name = "memoModuleTextRange";
        memoModuleTextRange.PlaceholderText = "range source";
        memoModuleTextRange.ScrollBars = ScrollBars.Both;
        memoModuleTextRange.Size = new Size(238, 60);
        memoModuleTextRange.TabIndex = 12;
        memoModuleTextRange.WordWrap = false;
        // 
        // sep85
        // 
        sep85.Dock = DockStyle.Top;
        sep85.Location = new Point(5, 168);
        sep85.Name = "sep85";
        sep85.Size = new Size(238, 5);
        sep85.TabIndex = 11;
        // 
        // btnGetModuleTextRange
        // 
        btnGetModuleTextRange.Dock = DockStyle.Top;
        btnGetModuleTextRange.Location = new Point(5, 145);
        btnGetModuleTextRange.Name = "btnGetModuleTextRange";
        btnGetModuleTextRange.Size = new Size(238, 23);
        btnGetModuleTextRange.TabIndex = 10;
        btnGetModuleTextRange.Text = "Get Module text range";
        btnGetModuleTextRange.UseVisualStyleBackColor = true;
        btnGetModuleTextRange.Click += btnGetModuleTextRange_Click;
        // 
        // sep84
        // 
        sep84.Dock = DockStyle.Top;
        sep84.Location = new Point(5, 140);
        sep84.Name = "sep84";
        sep84.Size = new Size(238, 5);
        sep84.TabIndex = 9;
        // 
        // numModuleTextRangeEndColumn
        // 
        numModuleTextRangeEndColumn.Dock = DockStyle.Top;
        numModuleTextRangeEndColumn.Location = new Point(5, 117);
        numModuleTextRangeEndColumn.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numModuleTextRangeEndColumn.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numModuleTextRangeEndColumn.Name = "numModuleTextRangeEndColumn";
        numModuleTextRangeEndColumn.Size = new Size(238, 23);
        numModuleTextRangeEndColumn.TabIndex = 8;
        numModuleTextRangeEndColumn.Value = new decimal(new int[] { 200, 0, 0, 0 });
        // 
        // sep83
        // 
        sep83.Dock = DockStyle.Top;
        sep83.Location = new Point(5, 112);
        sep83.Name = "sep83";
        sep83.Size = new Size(238, 5);
        sep83.TabIndex = 7;
        // 
        // numModuleTextRangeEndRow
        // 
        numModuleTextRangeEndRow.Dock = DockStyle.Top;
        numModuleTextRangeEndRow.Location = new Point(5, 89);
        numModuleTextRangeEndRow.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numModuleTextRangeEndRow.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numModuleTextRangeEndRow.Name = "numModuleTextRangeEndRow";
        numModuleTextRangeEndRow.Size = new Size(238, 23);
        numModuleTextRangeEndRow.TabIndex = 6;
        numModuleTextRangeEndRow.Value = new decimal(new int[] { 10, 0, 0, 0 });
        // 
        // sep82
        // 
        sep82.Dock = DockStyle.Top;
        sep82.Location = new Point(5, 84);
        sep82.Name = "sep82";
        sep82.Size = new Size(238, 5);
        sep82.TabIndex = 5;
        // 
        // numModuleTextRangeStartColumn
        // 
        numModuleTextRangeStartColumn.Dock = DockStyle.Top;
        numModuleTextRangeStartColumn.Location = new Point(5, 61);
        numModuleTextRangeStartColumn.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numModuleTextRangeStartColumn.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numModuleTextRangeStartColumn.Name = "numModuleTextRangeStartColumn";
        numModuleTextRangeStartColumn.Size = new Size(238, 23);
        numModuleTextRangeStartColumn.TabIndex = 4;
        numModuleTextRangeStartColumn.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // sep81
        // 
        sep81.Dock = DockStyle.Top;
        sep81.Location = new Point(5, 56);
        sep81.Name = "sep81";
        sep81.Size = new Size(238, 5);
        sep81.TabIndex = 3;
        // 
        // numModuleTextRangeStartRow
        // 
        numModuleTextRangeStartRow.Dock = DockStyle.Top;
        numModuleTextRangeStartRow.Location = new Point(5, 33);
        numModuleTextRangeStartRow.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numModuleTextRangeStartRow.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numModuleTextRangeStartRow.Name = "numModuleTextRangeStartRow";
        numModuleTextRangeStartRow.Size = new Size(238, 23);
        numModuleTextRangeStartRow.TabIndex = 2;
        numModuleTextRangeStartRow.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // sep80
        // 
        sep80.Dock = DockStyle.Top;
        sep80.Location = new Point(5, 28);
        sep80.Name = "sep80";
        sep80.Size = new Size(238, 5);
        sep80.TabIndex = 1;
        // 
        // lblModuleTextRange
        // 
        lblModuleTextRange.Dock = DockStyle.Top;
        lblModuleTextRange.Location = new Point(5, 5);
        lblModuleTextRange.Name = "lblModuleTextRange";
        lblModuleTextRange.Size = new Size(238, 23);
        lblModuleTextRange.TabIndex = 0;
        lblModuleTextRange.Text = "Module text range";
        lblModuleTextRange.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlSearchModuleText
        // 
        pnlSearchModuleText.BorderStyle = BorderStyle.FixedSingle;
        pnlSearchModuleText.Controls.Add(gridSearchModuleText);
        pnlSearchModuleText.Controls.Add(sep93);
        pnlSearchModuleText.Controls.Add(btnSearchModuleText);
        pnlSearchModuleText.Controls.Add(sep92);
        pnlSearchModuleText.Controls.Add(numSearchModuleTextStartColumn);
        pnlSearchModuleText.Controls.Add(sep91);
        pnlSearchModuleText.Controls.Add(numSearchModuleTextStartRow);
        pnlSearchModuleText.Controls.Add(sep90);
        pnlSearchModuleText.Controls.Add(txtSearchModuleTextText);
        pnlSearchModuleText.Location = new Point(771, 3);
        pnlSearchModuleText.Name = "pnlSearchModuleText";
        pnlSearchModuleText.Padding = new Padding(5);
        pnlSearchModuleText.Size = new Size(250, 187);
        pnlSearchModuleText.TabIndex = 5;
        // 
        // gridSearchModuleText
        // 
        gridSearchModuleText.Dock = DockStyle.Top;
        gridSearchModuleText.HelpVisible = false;
        gridSearchModuleText.Location = new Point(5, 117);
        gridSearchModuleText.Name = "gridSearchModuleText";
        gridSearchModuleText.PropertySort = PropertySort.NoSort;
        gridSearchModuleText.Size = new Size(238, 63);
        gridSearchModuleText.TabIndex = 8;
        gridSearchModuleText.ToolbarVisible = false;
        // 
        // sep93
        // 
        sep93.Dock = DockStyle.Top;
        sep93.Location = new Point(5, 112);
        sep93.Name = "sep93";
        sep93.Size = new Size(238, 5);
        sep93.TabIndex = 7;
        // 
        // btnSearchModuleText
        // 
        btnSearchModuleText.Dock = DockStyle.Top;
        btnSearchModuleText.Location = new Point(5, 89);
        btnSearchModuleText.Name = "btnSearchModuleText";
        btnSearchModuleText.Size = new Size(238, 23);
        btnSearchModuleText.TabIndex = 6;
        btnSearchModuleText.Text = "Search Module text";
        btnSearchModuleText.UseVisualStyleBackColor = true;
        btnSearchModuleText.Click += btnSearchModuleText_Click;
        // 
        // sep92
        // 
        sep92.Dock = DockStyle.Top;
        sep92.Location = new Point(5, 84);
        sep92.Name = "sep92";
        sep92.Size = new Size(238, 5);
        sep92.TabIndex = 5;
        // 
        // numSearchModuleTextStartColumn
        // 
        numSearchModuleTextStartColumn.Dock = DockStyle.Top;
        numSearchModuleTextStartColumn.Location = new Point(5, 61);
        numSearchModuleTextStartColumn.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numSearchModuleTextStartColumn.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numSearchModuleTextStartColumn.Name = "numSearchModuleTextStartColumn";
        numSearchModuleTextStartColumn.Size = new Size(238, 23);
        numSearchModuleTextStartColumn.TabIndex = 4;
        numSearchModuleTextStartColumn.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // sep91
        // 
        sep91.Dock = DockStyle.Top;
        sep91.Location = new Point(5, 56);
        sep91.Name = "sep91";
        sep91.Size = new Size(238, 5);
        sep91.TabIndex = 3;
        // 
        // numSearchModuleTextStartRow
        // 
        numSearchModuleTextStartRow.Dock = DockStyle.Top;
        numSearchModuleTextStartRow.Location = new Point(5, 33);
        numSearchModuleTextStartRow.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numSearchModuleTextStartRow.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numSearchModuleTextStartRow.Name = "numSearchModuleTextStartRow";
        numSearchModuleTextStartRow.Size = new Size(238, 23);
        numSearchModuleTextStartRow.TabIndex = 2;
        numSearchModuleTextStartRow.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // sep90
        // 
        sep90.Dock = DockStyle.Top;
        sep90.Location = new Point(5, 28);
        sep90.Name = "sep90";
        sep90.Size = new Size(238, 5);
        sep90.TabIndex = 1;
        // 
        // txtSearchModuleTextText
        // 
        txtSearchModuleTextText.Dock = DockStyle.Top;
        txtSearchModuleTextText.Location = new Point(5, 5);
        txtSearchModuleTextText.Name = "txtSearchModuleTextText";
        txtSearchModuleTextText.PlaceholderText = "text";
        txtSearchModuleTextText.Size = new Size(238, 23);
        txtSearchModuleTextText.TabIndex = 0;
        txtSearchModuleTextText.Text = "MODULE";
        // 
        // pnlSyncPers
        // 
        pnlSyncPers.BorderStyle = BorderStyle.FixedSingle;
        pnlSyncPers.Controls.Add(btnSyncPersistentVariables);
        pnlSyncPers.Controls.Add(sep95);
        pnlSyncPers.Controls.Add(chkSyncPersStatus);
        pnlSyncPers.Controls.Add(sep94);
        pnlSyncPers.Controls.Add(btnGetSyncPersStatus);
        pnlSyncPers.Location = new Point(771, 196);
        pnlSyncPers.Name = "pnlSyncPers";
        pnlSyncPers.Padding = new Padding(5);
        pnlSyncPers.Size = new Size(250, 91);
        pnlSyncPers.TabIndex = 6;
        // 
        // btnSyncPersistentVariables
        // 
        btnSyncPersistentVariables.Dock = DockStyle.Top;
        btnSyncPersistentVariables.Location = new Point(5, 61);
        btnSyncPersistentVariables.Name = "btnSyncPersistentVariables";
        btnSyncPersistentVariables.Size = new Size(238, 23);
        btnSyncPersistentVariables.TabIndex = 4;
        btnSyncPersistentVariables.Text = "Sync persistent variables";
        btnSyncPersistentVariables.UseVisualStyleBackColor = true;
        btnSyncPersistentVariables.Click += btnSyncPersistentVariables_Click;
        // 
        // sep95
        // 
        sep95.Dock = DockStyle.Top;
        sep95.Location = new Point(5, 56);
        sep95.Name = "sep95";
        sep95.Size = new Size(238, 5);
        sep95.TabIndex = 3;
        // 
        // chkSyncPersStatus
        // 
        chkSyncPersStatus.AutoCheck = false;
        chkSyncPersStatus.Dock = DockStyle.Top;
        chkSyncPersStatus.Location = new Point(5, 33);
        chkSyncPersStatus.Name = "chkSyncPersStatus";
        chkSyncPersStatus.Size = new Size(238, 23);
        chkSyncPersStatus.TabIndex = 2;
        chkSyncPersStatus.Text = "Persistents synchronized";
        chkSyncPersStatus.UseVisualStyleBackColor = true;
        // 
        // sep94
        // 
        sep94.Dock = DockStyle.Top;
        sep94.Location = new Point(5, 28);
        sep94.Name = "sep94";
        sep94.Size = new Size(238, 5);
        sep94.TabIndex = 1;
        // 
        // btnGetSyncPersStatus
        // 
        btnGetSyncPersStatus.Dock = DockStyle.Top;
        btnGetSyncPersStatus.Location = new Point(5, 5);
        btnGetSyncPersStatus.Name = "btnGetSyncPersStatus";
        btnGetSyncPersStatus.Size = new Size(238, 23);
        btnGetSyncPersStatus.TabIndex = 0;
        btnGetSyncPersStatus.Text = "Get SyncPers status";
        btnGetSyncPersStatus.UseVisualStyleBackColor = true;
        btnGetSyncPersStatus.Click += btnGetSyncPersStatus_Click;
        // 
        // pnlModuleAttributes
        // 
        pnlModuleAttributes.BorderStyle = BorderStyle.FixedSingle;
        pnlModuleAttributes.Controls.Add(gridPossibleModuleAttributes);
        pnlModuleAttributes.Controls.Add(sep96);
        pnlModuleAttributes.Controls.Add(btnGetPossibleModuleAttributes);
        pnlModuleAttributes.Location = new Point(771, 293);
        pnlModuleAttributes.Name = "pnlModuleAttributes";
        pnlModuleAttributes.Padding = new Padding(5);
        pnlModuleAttributes.Size = new Size(250, 122);
        pnlModuleAttributes.TabIndex = 7;
        // 
        // gridPossibleModuleAttributes
        // 
        gridPossibleModuleAttributes.Dock = DockStyle.Top;
        gridPossibleModuleAttributes.HelpVisible = false;
        gridPossibleModuleAttributes.Location = new Point(5, 33);
        gridPossibleModuleAttributes.Name = "gridPossibleModuleAttributes";
        gridPossibleModuleAttributes.PropertySort = PropertySort.NoSort;
        gridPossibleModuleAttributes.Size = new Size(238, 82);
        gridPossibleModuleAttributes.TabIndex = 2;
        gridPossibleModuleAttributes.ToolbarVisible = false;
        // 
        // sep96
        // 
        sep96.Dock = DockStyle.Top;
        sep96.Location = new Point(5, 28);
        sep96.Name = "sep96";
        sep96.Size = new Size(238, 5);
        sep96.TabIndex = 1;
        // 
        // btnGetPossibleModuleAttributes
        // 
        btnGetPossibleModuleAttributes.Dock = DockStyle.Top;
        btnGetPossibleModuleAttributes.Location = new Point(5, 5);
        btnGetPossibleModuleAttributes.Name = "btnGetPossibleModuleAttributes";
        btnGetPossibleModuleAttributes.Size = new Size(238, 23);
        btnGetPossibleModuleAttributes.TabIndex = 0;
        btnGetPossibleModuleAttributes.Text = "Get Possible attributes";
        btnGetPossibleModuleAttributes.UseVisualStyleBackColor = true;
        btnGetPossibleModuleAttributes.Click += btnGetPossibleModuleAttributes_Click;
        // 
        // pnlSaveModule
        // 
        pnlSaveModule.BorderStyle = BorderStyle.FixedSingle;
        pnlSaveModule.Controls.Add(btnSaveModule);
        pnlSaveModule.Controls.Add(sep98);
        pnlSaveModule.Controls.Add(txtSaveModulePath);
        pnlSaveModule.Controls.Add(sep97);
        pnlSaveModule.Controls.Add(txtSaveModuleName);
        pnlSaveModule.Location = new Point(1027, 3);
        pnlSaveModule.Name = "pnlSaveModule";
        pnlSaveModule.Padding = new Padding(5);
        pnlSaveModule.Size = new Size(250, 91);
        pnlSaveModule.TabIndex = 8;
        // 
        // btnSaveModule
        // 
        btnSaveModule.Dock = DockStyle.Top;
        btnSaveModule.Location = new Point(5, 61);
        btnSaveModule.Name = "btnSaveModule";
        btnSaveModule.Size = new Size(238, 23);
        btnSaveModule.TabIndex = 4;
        btnSaveModule.Text = "Save Module";
        btnSaveModule.UseVisualStyleBackColor = true;
        btnSaveModule.Click += btnSaveModule_Click;
        // 
        // sep98
        // 
        sep98.Dock = DockStyle.Top;
        sep98.Location = new Point(5, 56);
        sep98.Name = "sep98";
        sep98.Size = new Size(238, 5);
        sep98.TabIndex = 3;
        // 
        // txtSaveModulePath
        // 
        txtSaveModulePath.Dock = DockStyle.Top;
        txtSaveModulePath.Location = new Point(5, 33);
        txtSaveModulePath.Name = "txtSaveModulePath";
        txtSaveModulePath.PlaceholderText = "path";
        txtSaveModulePath.Size = new Size(238, 23);
        txtSaveModulePath.TabIndex = 2;
        txtSaveModulePath.Text = "$temp";
        // 
        // sep97
        // 
        sep97.Dock = DockStyle.Top;
        sep97.Location = new Point(5, 28);
        sep97.Name = "sep97";
        sep97.Size = new Size(238, 5);
        sep97.TabIndex = 1;
        // 
        // txtSaveModuleName
        // 
        txtSaveModuleName.Dock = DockStyle.Top;
        txtSaveModuleName.Location = new Point(5, 5);
        txtSaveModuleName.Name = "txtSaveModuleName";
        txtSaveModuleName.PlaceholderText = "name";
        txtSaveModuleName.Size = new Size(238, 23);
        txtSaveModuleName.TabIndex = 0;
        txtSaveModuleName.Text = "mymodule";
        // 
        // pnlModuleSymbol
        // 
        pnlModuleSymbol.BorderStyle = BorderStyle.FixedSingle;
        pnlModuleSymbol.Controls.Add(gridModuleSymbol);
        pnlModuleSymbol.Controls.Add(sep101);
        pnlModuleSymbol.Controls.Add(btnGetModuleSymbol);
        pnlModuleSymbol.Controls.Add(sep100);
        pnlModuleSymbol.Controls.Add(numGetModuleSymbolColumn);
        pnlModuleSymbol.Controls.Add(sep99);
        pnlModuleSymbol.Controls.Add(numGetModuleSymbolRow);
        pnlModuleSymbol.Location = new Point(1283, 3);
        pnlModuleSymbol.Name = "pnlModuleSymbol";
        pnlModuleSymbol.Padding = new Padding(5);
        pnlModuleSymbol.Size = new Size(250, 330);
        pnlModuleSymbol.TabIndex = 9;
        // 
        // gridModuleSymbol
        // 
        gridModuleSymbol.Dock = DockStyle.Top;
        gridModuleSymbol.HelpVisible = false;
        gridModuleSymbol.Location = new Point(5, 89);
        gridModuleSymbol.Name = "gridModuleSymbol";
        gridModuleSymbol.PropertySort = PropertySort.NoSort;
        gridModuleSymbol.Size = new Size(238, 234);
        gridModuleSymbol.TabIndex = 6;
        gridModuleSymbol.ToolbarVisible = false;
        // 
        // sep101
        // 
        sep101.Dock = DockStyle.Top;
        sep101.Location = new Point(5, 84);
        sep101.Name = "sep101";
        sep101.Size = new Size(238, 5);
        sep101.TabIndex = 5;
        // 
        // btnGetModuleSymbol
        // 
        btnGetModuleSymbol.Dock = DockStyle.Top;
        btnGetModuleSymbol.Location = new Point(5, 61);
        btnGetModuleSymbol.Name = "btnGetModuleSymbol";
        btnGetModuleSymbol.Size = new Size(238, 23);
        btnGetModuleSymbol.TabIndex = 4;
        btnGetModuleSymbol.Text = "Get Module symbol";
        btnGetModuleSymbol.UseVisualStyleBackColor = true;
        btnGetModuleSymbol.Click += btnGetModuleSymbol_Click;
        // 
        // sep100
        // 
        sep100.Dock = DockStyle.Top;
        sep100.Location = new Point(5, 56);
        sep100.Name = "sep100";
        sep100.Size = new Size(238, 5);
        sep100.TabIndex = 3;
        // 
        // numGetModuleSymbolColumn
        // 
        numGetModuleSymbolColumn.Dock = DockStyle.Top;
        numGetModuleSymbolColumn.Location = new Point(5, 33);
        numGetModuleSymbolColumn.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numGetModuleSymbolColumn.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numGetModuleSymbolColumn.Name = "numGetModuleSymbolColumn";
        numGetModuleSymbolColumn.Size = new Size(238, 23);
        numGetModuleSymbolColumn.TabIndex = 2;
        numGetModuleSymbolColumn.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // sep99
        // 
        sep99.Dock = DockStyle.Top;
        sep99.Location = new Point(5, 28);
        sep99.Name = "sep99";
        sep99.Size = new Size(238, 5);
        sep99.TabIndex = 1;
        // 
        // numGetModuleSymbolRow
        // 
        numGetModuleSymbolRow.Dock = DockStyle.Top;
        numGetModuleSymbolRow.Location = new Point(5, 5);
        numGetModuleSymbolRow.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numGetModuleSymbolRow.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numGetModuleSymbolRow.Name = "numGetModuleSymbolRow";
        numGetModuleSymbolRow.Size = new Size(238, 23);
        numGetModuleSymbolRow.TabIndex = 0;
        numGetModuleSymbolRow.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // pnlRoutine
        // 
        pnlRoutine.BorderStyle = BorderStyle.FixedSingle;
        pnlRoutine.Controls.Add(gridRoutine);
        pnlRoutine.Controls.Add(sep104);
        pnlRoutine.Controls.Add(btnGetRoutine);
        pnlRoutine.Controls.Add(sep103);
        pnlRoutine.Controls.Add(numGetRoutineColumn);
        pnlRoutine.Controls.Add(sep102);
        pnlRoutine.Controls.Add(numGetRoutineRow);
        pnlRoutine.Location = new Point(1539, 3);
        pnlRoutine.Name = "pnlRoutine";
        pnlRoutine.Padding = new Padding(5);
        pnlRoutine.Size = new Size(250, 216);
        pnlRoutine.TabIndex = 10;
        // 
        // gridRoutine
        // 
        gridRoutine.Dock = DockStyle.Top;
        gridRoutine.HelpVisible = false;
        gridRoutine.Location = new Point(5, 89);
        gridRoutine.Name = "gridRoutine";
        gridRoutine.PropertySort = PropertySort.NoSort;
        gridRoutine.Size = new Size(238, 120);
        gridRoutine.TabIndex = 6;
        gridRoutine.ToolbarVisible = false;
        // 
        // sep104
        // 
        sep104.Dock = DockStyle.Top;
        sep104.Location = new Point(5, 84);
        sep104.Name = "sep104";
        sep104.Size = new Size(238, 5);
        sep104.TabIndex = 5;
        // 
        // btnGetRoutine
        // 
        btnGetRoutine.Dock = DockStyle.Top;
        btnGetRoutine.Location = new Point(5, 61);
        btnGetRoutine.Name = "btnGetRoutine";
        btnGetRoutine.Size = new Size(238, 23);
        btnGetRoutine.TabIndex = 4;
        btnGetRoutine.Text = "Get Routine";
        btnGetRoutine.UseVisualStyleBackColor = true;
        btnGetRoutine.Click += btnGetRoutine_Click;
        // 
        // sep103
        // 
        sep103.Dock = DockStyle.Top;
        sep103.Location = new Point(5, 56);
        sep103.Name = "sep103";
        sep103.Size = new Size(238, 5);
        sep103.TabIndex = 3;
        // 
        // numGetRoutineColumn
        // 
        numGetRoutineColumn.Dock = DockStyle.Top;
        numGetRoutineColumn.Location = new Point(5, 33);
        numGetRoutineColumn.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numGetRoutineColumn.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numGetRoutineColumn.Name = "numGetRoutineColumn";
        numGetRoutineColumn.Size = new Size(238, 23);
        numGetRoutineColumn.TabIndex = 2;
        numGetRoutineColumn.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // sep102
        // 
        sep102.Dock = DockStyle.Top;
        sep102.Location = new Point(5, 28);
        sep102.Name = "sep102";
        sep102.Size = new Size(238, 5);
        sep102.TabIndex = 1;
        // 
        // numGetRoutineRow
        // 
        numGetRoutineRow.Dock = DockStyle.Top;
        numGetRoutineRow.Location = new Point(5, 5);
        numGetRoutineRow.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numGetRoutineRow.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numGetRoutineRow.Name = "numGetRoutineRow";
        numGetRoutineRow.Size = new Size(238, 23);
        numGetRoutineRow.TabIndex = 0;
        numGetRoutineRow.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // pnlRoutineArguments
        // 
        pnlRoutineArguments.BorderStyle = BorderStyle.FixedSingle;
        pnlRoutineArguments.Controls.Add(gridRoutineArguments);
        pnlRoutineArguments.Controls.Add(sep105);
        pnlRoutineArguments.Controls.Add(btnGetRoutineArguments);
        pnlRoutineArguments.Location = new Point(1795, 3);
        pnlRoutineArguments.Name = "pnlRoutineArguments";
        pnlRoutineArguments.Padding = new Padding(5);
        pnlRoutineArguments.Size = new Size(250, 198);
        pnlRoutineArguments.TabIndex = 11;
        // 
        // gridRoutineArguments
        // 
        gridRoutineArguments.Dock = DockStyle.Top;
        gridRoutineArguments.HelpVisible = false;
        gridRoutineArguments.Location = new Point(5, 33);
        gridRoutineArguments.Name = "gridRoutineArguments";
        gridRoutineArguments.PropertySort = PropertySort.NoSort;
        gridRoutineArguments.Size = new Size(238, 158);
        gridRoutineArguments.TabIndex = 2;
        gridRoutineArguments.ToolbarVisible = false;
        // 
        // sep105
        // 
        sep105.Dock = DockStyle.Top;
        sep105.Location = new Point(5, 28);
        sep105.Name = "sep105";
        sep105.Size = new Size(238, 5);
        sep105.TabIndex = 1;
        // 
        // btnGetRoutineArguments
        // 
        btnGetRoutineArguments.Dock = DockStyle.Top;
        btnGetRoutineArguments.Location = new Point(5, 5);
        btnGetRoutineArguments.Name = "btnGetRoutineArguments";
        btnGetRoutineArguments.Size = new Size(238, 23);
        btnGetRoutineArguments.TabIndex = 0;
        btnGetRoutineArguments.Text = "Get Routine arguments";
        btnGetRoutineArguments.UseVisualStyleBackColor = true;
        btnGetRoutineArguments.Click += btnGetRoutineArguments_Click;
        // 
        // pnlInstructionTemplate
        // 
        pnlInstructionTemplate.BorderStyle = BorderStyle.FixedSingle;
        pnlInstructionTemplate.Controls.Add(gridInstructionTemplate);
        pnlInstructionTemplate.Controls.Add(sep108);
        pnlInstructionTemplate.Controls.Add(btnGetInstructionTemplate);
        pnlInstructionTemplate.Controls.Add(sep107);
        pnlInstructionTemplate.Controls.Add(chkGetInstructionTemplateIsDataType);
        pnlInstructionTemplate.Controls.Add(sep106);
        pnlInstructionTemplate.Controls.Add(txtGetInstructionTemplateName);
        pnlInstructionTemplate.Location = new Point(2051, 3);
        pnlInstructionTemplate.Name = "pnlInstructionTemplate";
        pnlInstructionTemplate.Padding = new Padding(5);
        pnlInstructionTemplate.Size = new Size(250, 368);
        pnlInstructionTemplate.TabIndex = 12;
        // 
        // gridInstructionTemplate
        // 
        gridInstructionTemplate.Dock = DockStyle.Top;
        gridInstructionTemplate.HelpVisible = false;
        gridInstructionTemplate.Location = new Point(5, 89);
        gridInstructionTemplate.Name = "gridInstructionTemplate";
        gridInstructionTemplate.PropertySort = PropertySort.NoSort;
        gridInstructionTemplate.Size = new Size(238, 272);
        gridInstructionTemplate.TabIndex = 6;
        gridInstructionTemplate.ToolbarVisible = false;
        // 
        // sep108
        // 
        sep108.Dock = DockStyle.Top;
        sep108.Location = new Point(5, 84);
        sep108.Name = "sep108";
        sep108.Size = new Size(238, 5);
        sep108.TabIndex = 5;
        // 
        // btnGetInstructionTemplate
        // 
        btnGetInstructionTemplate.Dock = DockStyle.Top;
        btnGetInstructionTemplate.Location = new Point(5, 61);
        btnGetInstructionTemplate.Name = "btnGetInstructionTemplate";
        btnGetInstructionTemplate.Size = new Size(238, 23);
        btnGetInstructionTemplate.TabIndex = 4;
        btnGetInstructionTemplate.Text = "Get Instruction template";
        btnGetInstructionTemplate.UseVisualStyleBackColor = true;
        btnGetInstructionTemplate.Click += btnGetInstructionTemplate_Click;
        // 
        // sep107
        // 
        sep107.Dock = DockStyle.Top;
        sep107.Location = new Point(5, 56);
        sep107.Name = "sep107";
        sep107.Size = new Size(238, 5);
        sep107.TabIndex = 3;
        // 
        // chkGetInstructionTemplateIsDataType
        // 
        chkGetInstructionTemplateIsDataType.Dock = DockStyle.Top;
        chkGetInstructionTemplateIsDataType.Location = new Point(5, 33);
        chkGetInstructionTemplateIsDataType.Name = "chkGetInstructionTemplateIsDataType";
        chkGetInstructionTemplateIsDataType.Size = new Size(238, 23);
        chkGetInstructionTemplateIsDataType.TabIndex = 2;
        chkGetInstructionTemplateIsDataType.Text = "The name is a data type";
        chkGetInstructionTemplateIsDataType.UseVisualStyleBackColor = true;
        // 
        // sep106
        // 
        sep106.Dock = DockStyle.Top;
        sep106.Location = new Point(5, 28);
        sep106.Name = "sep106";
        sep106.Size = new Size(238, 5);
        sep106.TabIndex = 1;
        // 
        // txtGetInstructionTemplateName
        // 
        txtGetInstructionTemplateName.Dock = DockStyle.Top;
        txtGetInstructionTemplateName.Location = new Point(5, 5);
        txtGetInstructionTemplateName.Name = "txtGetInstructionTemplateName";
        txtGetInstructionTemplateName.PlaceholderText = "instruction or data type";
        txtGetInstructionTemplateName.Size = new Size(238, 23);
        txtGetInstructionTemplateName.TabIndex = 0;
        txtGetInstructionTemplateName.Text = "MoveJ";
        // 
        // pnlObjectChildren
        // 
        pnlObjectChildren.BorderStyle = BorderStyle.FixedSingle;
        pnlObjectChildren.Controls.Add(gridObjectChildren);
        pnlObjectChildren.Controls.Add(sep114);
        pnlObjectChildren.Controls.Add(btnGetObjectChildren);
        pnlObjectChildren.Controls.Add(sep113);
        pnlObjectChildren.Controls.Add(numObjectChildEndColumn);
        pnlObjectChildren.Controls.Add(sep112);
        pnlObjectChildren.Controls.Add(numObjectChildEndLine);
        pnlObjectChildren.Controls.Add(sep111);
        pnlObjectChildren.Controls.Add(numObjectChildStartColumn);
        pnlObjectChildren.Controls.Add(sep110);
        pnlObjectChildren.Controls.Add(numObjectChildStartLine);
        pnlObjectChildren.Controls.Add(sep109);
        pnlObjectChildren.Controls.Add(lblObjectChildren);
        pnlObjectChildren.Location = new Point(2307, 3);
        pnlObjectChildren.Name = "pnlObjectChildren";
        pnlObjectChildren.Padding = new Padding(5);
        pnlObjectChildren.Size = new Size(250, 414);
        pnlObjectChildren.TabIndex = 13;
        // 
        // gridObjectChildren
        // 
        gridObjectChildren.Dock = DockStyle.Top;
        gridObjectChildren.HelpVisible = false;
        gridObjectChildren.Location = new Point(5, 173);
        gridObjectChildren.Name = "gridObjectChildren";
        gridObjectChildren.PropertySort = PropertySort.NoSort;
        gridObjectChildren.Size = new Size(238, 234);
        gridObjectChildren.TabIndex = 12;
        gridObjectChildren.ToolbarVisible = false;
        // 
        // sep114
        // 
        sep114.Dock = DockStyle.Top;
        sep114.Location = new Point(5, 168);
        sep114.Name = "sep114";
        sep114.Size = new Size(238, 5);
        sep114.TabIndex = 11;
        // 
        // btnGetObjectChildren
        // 
        btnGetObjectChildren.Dock = DockStyle.Top;
        btnGetObjectChildren.Location = new Point(5, 145);
        btnGetObjectChildren.Name = "btnGetObjectChildren";
        btnGetObjectChildren.Size = new Size(238, 23);
        btnGetObjectChildren.TabIndex = 10;
        btnGetObjectChildren.Text = "Get Object children";
        btnGetObjectChildren.UseVisualStyleBackColor = true;
        btnGetObjectChildren.Click += btnGetObjectChildren_Click;
        // 
        // sep113
        // 
        sep113.Dock = DockStyle.Top;
        sep113.Location = new Point(5, 140);
        sep113.Name = "sep113";
        sep113.Size = new Size(238, 5);
        sep113.TabIndex = 9;
        // 
        // numObjectChildEndColumn
        // 
        numObjectChildEndColumn.Dock = DockStyle.Top;
        numObjectChildEndColumn.Location = new Point(5, 117);
        numObjectChildEndColumn.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numObjectChildEndColumn.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numObjectChildEndColumn.Name = "numObjectChildEndColumn";
        numObjectChildEndColumn.Size = new Size(238, 23);
        numObjectChildEndColumn.TabIndex = 8;
        numObjectChildEndColumn.Value = new decimal(new int[] { 9, 0, 0, 0 });
        // 
        // sep112
        // 
        sep112.Dock = DockStyle.Top;
        sep112.Location = new Point(5, 112);
        sep112.Name = "sep112";
        sep112.Size = new Size(238, 5);
        sep112.TabIndex = 7;
        // 
        // numObjectChildEndLine
        // 
        numObjectChildEndLine.Dock = DockStyle.Top;
        numObjectChildEndLine.Location = new Point(5, 89);
        numObjectChildEndLine.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numObjectChildEndLine.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numObjectChildEndLine.Name = "numObjectChildEndLine";
        numObjectChildEndLine.Size = new Size(238, 23);
        numObjectChildEndLine.TabIndex = 6;
        numObjectChildEndLine.Value = new decimal(new int[] { 20, 0, 0, 0 });
        // 
        // sep111
        // 
        sep111.Dock = DockStyle.Top;
        sep111.Location = new Point(5, 84);
        sep111.Name = "sep111";
        sep111.Size = new Size(238, 5);
        sep111.TabIndex = 5;
        // 
        // numObjectChildStartColumn
        // 
        numObjectChildStartColumn.Dock = DockStyle.Top;
        numObjectChildStartColumn.Location = new Point(5, 61);
        numObjectChildStartColumn.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numObjectChildStartColumn.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numObjectChildStartColumn.Name = "numObjectChildStartColumn";
        numObjectChildStartColumn.Size = new Size(238, 23);
        numObjectChildStartColumn.TabIndex = 4;
        numObjectChildStartColumn.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // sep110
        // 
        sep110.Dock = DockStyle.Top;
        sep110.Location = new Point(5, 56);
        sep110.Name = "sep110";
        sep110.Size = new Size(238, 5);
        sep110.TabIndex = 3;
        // 
        // numObjectChildStartLine
        // 
        numObjectChildStartLine.Dock = DockStyle.Top;
        numObjectChildStartLine.Location = new Point(5, 33);
        numObjectChildStartLine.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numObjectChildStartLine.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numObjectChildStartLine.Name = "numObjectChildStartLine";
        numObjectChildStartLine.Size = new Size(238, 23);
        numObjectChildStartLine.TabIndex = 2;
        numObjectChildStartLine.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // sep109
        // 
        sep109.Dock = DockStyle.Top;
        sep109.Location = new Point(5, 28);
        sep109.Name = "sep109";
        sep109.Size = new Size(238, 5);
        sep109.TabIndex = 1;
        // 
        // lblObjectChildren
        // 
        lblObjectChildren.Dock = DockStyle.Top;
        lblObjectChildren.Location = new Point(5, 5);
        lblObjectChildren.Name = "lblObjectChildren";
        lblObjectChildren.Size = new Size(238, 23);
        lblObjectChildren.TabIndex = 0;
        lblObjectChildren.Text = "Object children";
        lblObjectChildren.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlModifiablePositions
        // 
        pnlModifiablePositions.BorderStyle = BorderStyle.FixedSingle;
        pnlModifiablePositions.Controls.Add(btnModifyPosition);
        pnlModifiablePositions.Controls.Add(sep119);
        pnlModifiablePositions.Controls.Add(gridModifiablePositions);
        pnlModifiablePositions.Controls.Add(sep118);
        pnlModifiablePositions.Controls.Add(btnGetModifiablePositions);
        pnlModifiablePositions.Controls.Add(sep117);
        pnlModifiablePositions.Controls.Add(numModifiablePositionsEndRow);
        pnlModifiablePositions.Controls.Add(sep116);
        pnlModifiablePositions.Controls.Add(numModifiablePositionsStartRow);
        pnlModifiablePositions.Controls.Add(sep115);
        pnlModifiablePositions.Controls.Add(lblModifiablePositions);
        pnlModifiablePositions.Location = new Point(2563, 3);
        pnlModifiablePositions.Name = "pnlModifiablePositions";
        pnlModifiablePositions.Padding = new Padding(5);
        pnlModifiablePositions.Size = new Size(250, 253);
        pnlModifiablePositions.TabIndex = 14;
        // 
        // btnModifyPosition
        // 
        btnModifyPosition.Dock = DockStyle.Top;
        btnModifyPosition.Location = new Point(5, 223);
        btnModifyPosition.Name = "btnModifyPosition";
        btnModifyPosition.Size = new Size(238, 23);
        btnModifyPosition.TabIndex = 10;
        btnModifyPosition.Text = "Modify Position";
        btnModifyPosition.UseVisualStyleBackColor = true;
        btnModifyPosition.Click += btnModifyPosition_Click;
        // 
        // sep119
        // 
        sep119.Dock = DockStyle.Top;
        sep119.Location = new Point(5, 218);
        sep119.Name = "sep119";
        sep119.Size = new Size(238, 5);
        sep119.TabIndex = 9;
        // 
        // gridModifiablePositions
        // 
        gridModifiablePositions.Dock = DockStyle.Top;
        gridModifiablePositions.HelpVisible = false;
        gridModifiablePositions.Location = new Point(5, 117);
        gridModifiablePositions.Name = "gridModifiablePositions";
        gridModifiablePositions.PropertySort = PropertySort.NoSort;
        gridModifiablePositions.Size = new Size(238, 101);
        gridModifiablePositions.TabIndex = 8;
        gridModifiablePositions.ToolbarVisible = false;
        // 
        // sep118
        // 
        sep118.Dock = DockStyle.Top;
        sep118.Location = new Point(5, 112);
        sep118.Name = "sep118";
        sep118.Size = new Size(238, 5);
        sep118.TabIndex = 7;
        // 
        // btnGetModifiablePositions
        // 
        btnGetModifiablePositions.Dock = DockStyle.Top;
        btnGetModifiablePositions.Location = new Point(5, 89);
        btnGetModifiablePositions.Name = "btnGetModifiablePositions";
        btnGetModifiablePositions.Size = new Size(238, 23);
        btnGetModifiablePositions.TabIndex = 6;
        btnGetModifiablePositions.Text = "Get Modifiable positions";
        btnGetModifiablePositions.UseVisualStyleBackColor = true;
        btnGetModifiablePositions.Click += btnGetModifiablePositions_Click;
        // 
        // sep117
        // 
        sep117.Dock = DockStyle.Top;
        sep117.Location = new Point(5, 84);
        sep117.Name = "sep117";
        sep117.Size = new Size(238, 5);
        sep117.TabIndex = 5;
        // 
        // numModifiablePositionsEndRow
        // 
        numModifiablePositionsEndRow.Dock = DockStyle.Top;
        numModifiablePositionsEndRow.Location = new Point(5, 61);
        numModifiablePositionsEndRow.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numModifiablePositionsEndRow.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numModifiablePositionsEndRow.Name = "numModifiablePositionsEndRow";
        numModifiablePositionsEndRow.Size = new Size(238, 23);
        numModifiablePositionsEndRow.TabIndex = 4;
        numModifiablePositionsEndRow.Value = new decimal(new int[] { 100, 0, 0, 0 });
        // 
        // sep116
        // 
        sep116.Dock = DockStyle.Top;
        sep116.Location = new Point(5, 56);
        sep116.Name = "sep116";
        sep116.Size = new Size(238, 5);
        sep116.TabIndex = 3;
        // 
        // numModifiablePositionsStartRow
        // 
        numModifiablePositionsStartRow.Dock = DockStyle.Top;
        numModifiablePositionsStartRow.Location = new Point(5, 33);
        numModifiablePositionsStartRow.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
        numModifiablePositionsStartRow.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numModifiablePositionsStartRow.Name = "numModifiablePositionsStartRow";
        numModifiablePositionsStartRow.Size = new Size(238, 23);
        numModifiablePositionsStartRow.TabIndex = 2;
        numModifiablePositionsStartRow.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // sep115
        // 
        sep115.Dock = DockStyle.Top;
        sep115.Location = new Point(5, 28);
        sep115.Name = "sep115";
        sep115.Size = new Size(238, 5);
        sep115.TabIndex = 1;
        // 
        // lblModifiablePositions
        // 
        lblModifiablePositions.Dock = DockStyle.Top;
        lblModifiablePositions.Location = new Point(5, 5);
        lblModifiablePositions.Name = "lblModifiablePositions";
        lblModifiablePositions.Size = new Size(238, 23);
        lblModifiablePositions.TabIndex = 0;
        lblModifiablePositions.Text = "Modifiable positions";
        lblModifiablePositions.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlAllModifiablePositions
        // 
        pnlAllModifiablePositions.BorderStyle = BorderStyle.FixedSingle;
        pnlAllModifiablePositions.Controls.Add(btnModifyAllPositions);
        pnlAllModifiablePositions.Controls.Add(sep121);
        pnlAllModifiablePositions.Controls.Add(gridAllModifiablePositions);
        pnlAllModifiablePositions.Controls.Add(sep120);
        pnlAllModifiablePositions.Controls.Add(btnGetAllModifiablePositions);
        pnlAllModifiablePositions.Location = new Point(2819, 3);
        pnlAllModifiablePositions.Name = "pnlAllModifiablePositions";
        pnlAllModifiablePositions.Padding = new Padding(5);
        pnlAllModifiablePositions.Size = new Size(250, 226);
        pnlAllModifiablePositions.TabIndex = 15;
        // 
        // btnModifyAllPositions
        // 
        btnModifyAllPositions.Dock = DockStyle.Top;
        btnModifyAllPositions.Location = new Point(5, 196);
        btnModifyAllPositions.Name = "btnModifyAllPositions";
        btnModifyAllPositions.Size = new Size(238, 23);
        btnModifyAllPositions.TabIndex = 4;
        btnModifyAllPositions.Text = "Modify All positions";
        btnModifyAllPositions.UseVisualStyleBackColor = true;
        btnModifyAllPositions.Click += btnModifyAllPositions_Click;
        // 
        // sep121
        // 
        sep121.Dock = DockStyle.Top;
        sep121.Location = new Point(5, 191);
        sep121.Name = "sep121";
        sep121.Size = new Size(238, 5);
        sep121.TabIndex = 3;
        // 
        // gridAllModifiablePositions
        // 
        gridAllModifiablePositions.Dock = DockStyle.Top;
        gridAllModifiablePositions.HelpVisible = false;
        gridAllModifiablePositions.Location = new Point(5, 33);
        gridAllModifiablePositions.Name = "gridAllModifiablePositions";
        gridAllModifiablePositions.PropertySort = PropertySort.NoSort;
        gridAllModifiablePositions.Size = new Size(238, 158);
        gridAllModifiablePositions.TabIndex = 2;
        gridAllModifiablePositions.ToolbarVisible = false;
        // 
        // sep120
        // 
        sep120.Dock = DockStyle.Top;
        sep120.Location = new Point(5, 28);
        sep120.Name = "sep120";
        sep120.Size = new Size(238, 5);
        sep120.TabIndex = 1;
        // 
        // btnGetAllModifiablePositions
        // 
        btnGetAllModifiablePositions.Dock = DockStyle.Top;
        btnGetAllModifiablePositions.Location = new Point(5, 5);
        btnGetAllModifiablePositions.Name = "btnGetAllModifiablePositions";
        btnGetAllModifiablePositions.Size = new Size(238, 23);
        btnGetAllModifiablePositions.TabIndex = 0;
        btnGetAllModifiablePositions.Text = "Get All modifiable positions";
        btnGetAllModifiablePositions.UseVisualStyleBackColor = true;
        btnGetAllModifiablePositions.Click += btnGetAllModifiablePositions_Click;
        // 
        // tabSymbols
        // 
        tabSymbols.Controls.Add(flowSymbols);
        tabSymbols.Location = new Point(4, 24);
        tabSymbols.Name = "tabSymbols";
        tabSymbols.Padding = new Padding(3);
        tabSymbols.Size = new Size(882, 421);
        tabSymbols.TabIndex = 4;
        tabSymbols.Text = "Symbols";
        tabSymbols.UseVisualStyleBackColor = true;
        // 
        // flowSymbols
        // 
        flowSymbols.AutoScroll = true;
        flowSymbols.Controls.Add(pnlSymbolProperties);
        flowSymbols.Controls.Add(pnlSymbolValue);
        flowSymbols.Controls.Add(pnlSearchSymbols);
        flowSymbols.Controls.Add(pnlValidate);
        flowSymbols.Controls.Add(pnlObjectListExtension);
        flowSymbols.Dock = DockStyle.Fill;
        flowSymbols.FlowDirection = FlowDirection.TopDown;
        flowSymbols.Location = new Point(3, 3);
        flowSymbols.Name = "flowSymbols";
        flowSymbols.Size = new Size(876, 415);
        flowSymbols.TabIndex = 0;
        // 
        // pnlSymbolProperties
        // 
        pnlSymbolProperties.BorderStyle = BorderStyle.FixedSingle;
        pnlSymbolProperties.Controls.Add(gridSymbolProperties);
        pnlSymbolProperties.Controls.Add(sep123);
        pnlSymbolProperties.Controls.Add(btnGetSymbolProperties);
        pnlSymbolProperties.Controls.Add(sep122);
        pnlSymbolProperties.Controls.Add(txtSymbolUrl);
        pnlSymbolProperties.Location = new Point(3, 3);
        pnlSymbolProperties.Name = "pnlSymbolProperties";
        pnlSymbolProperties.Padding = new Padding(5);
        pnlSymbolProperties.Size = new Size(250, 340);
        pnlSymbolProperties.TabIndex = 0;
        // 
        // gridSymbolProperties
        // 
        gridSymbolProperties.Dock = DockStyle.Top;
        gridSymbolProperties.HelpVisible = false;
        gridSymbolProperties.Location = new Point(5, 61);
        gridSymbolProperties.Name = "gridSymbolProperties";
        gridSymbolProperties.PropertySort = PropertySort.NoSort;
        gridSymbolProperties.Size = new Size(238, 272);
        gridSymbolProperties.TabIndex = 4;
        gridSymbolProperties.ToolbarVisible = false;
        // 
        // sep123
        // 
        sep123.Dock = DockStyle.Top;
        sep123.Location = new Point(5, 56);
        sep123.Name = "sep123";
        sep123.Size = new Size(238, 5);
        sep123.TabIndex = 3;
        // 
        // btnGetSymbolProperties
        // 
        btnGetSymbolProperties.Dock = DockStyle.Top;
        btnGetSymbolProperties.Location = new Point(5, 33);
        btnGetSymbolProperties.Name = "btnGetSymbolProperties";
        btnGetSymbolProperties.Size = new Size(238, 23);
        btnGetSymbolProperties.TabIndex = 2;
        btnGetSymbolProperties.Text = "Get Symbol properties";
        btnGetSymbolProperties.UseVisualStyleBackColor = true;
        btnGetSymbolProperties.Click += btnGetSymbolProperties_Click;
        // 
        // sep122
        // 
        sep122.Dock = DockStyle.Top;
        sep122.Location = new Point(5, 28);
        sep122.Name = "sep122";
        sep122.Size = new Size(238, 5);
        sep122.TabIndex = 1;
        // 
        // txtSymbolUrl
        // 
        txtSymbolUrl.Dock = DockStyle.Top;
        txtSymbolUrl.Location = new Point(5, 5);
        txtSymbolUrl.Name = "txtSymbolUrl";
        txtSymbolUrl.PlaceholderText = "symbolUrl";
        txtSymbolUrl.Size = new Size(238, 23);
        txtSymbolUrl.TabIndex = 0;
        txtSymbolUrl.Text = "RAPID/T_ROB1/user/reg1";
        // 
        // pnlSymbolValue
        // 
        pnlSymbolValue.BorderStyle = BorderStyle.FixedSingle;
        pnlSymbolValue.Controls.Add(btnSetSymbolInitialValue);
        pnlSymbolValue.Controls.Add(sep127);
        pnlSymbolValue.Controls.Add(btnSetSymbolValue);
        pnlSymbolValue.Controls.Add(sep126);
        pnlSymbolValue.Controls.Add(txtSetSymbolValueValue);
        pnlSymbolValue.Controls.Add(sep125);
        pnlSymbolValue.Controls.Add(gridSymbolValue);
        pnlSymbolValue.Controls.Add(sep124);
        pnlSymbolValue.Controls.Add(btnGetSymbolValue);
        pnlSymbolValue.Location = new Point(259, 3);
        pnlSymbolValue.Name = "pnlSymbolValue";
        pnlSymbolValue.Padding = new Padding(5);
        pnlSymbolValue.Size = new Size(250, 339);
        pnlSymbolValue.TabIndex = 1;
        // 
        // btnSetSymbolInitialValue
        // 
        btnSetSymbolInitialValue.Dock = DockStyle.Top;
        btnSetSymbolInitialValue.Location = new Point(5, 309);
        btnSetSymbolInitialValue.Name = "btnSetSymbolInitialValue";
        btnSetSymbolInitialValue.Size = new Size(238, 23);
        btnSetSymbolInitialValue.TabIndex = 8;
        btnSetSymbolInitialValue.Text = "Set Symbol initial value";
        btnSetSymbolInitialValue.UseVisualStyleBackColor = true;
        btnSetSymbolInitialValue.Click += btnSetSymbolInitialValue_Click;
        // 
        // sep127
        // 
        sep127.Dock = DockStyle.Top;
        sep127.Location = new Point(5, 304);
        sep127.Name = "sep127";
        sep127.Size = new Size(238, 5);
        sep127.TabIndex = 7;
        // 
        // btnSetSymbolValue
        // 
        btnSetSymbolValue.Dock = DockStyle.Top;
        btnSetSymbolValue.Location = new Point(5, 281);
        btnSetSymbolValue.Name = "btnSetSymbolValue";
        btnSetSymbolValue.Size = new Size(238, 23);
        btnSetSymbolValue.TabIndex = 6;
        btnSetSymbolValue.Text = "Set Symbol value";
        btnSetSymbolValue.UseVisualStyleBackColor = true;
        btnSetSymbolValue.Click += btnSetSymbolValue_Click;
        // 
        // sep126
        // 
        sep126.Dock = DockStyle.Top;
        sep126.Location = new Point(5, 276);
        sep126.Name = "sep126";
        sep126.Size = new Size(238, 5);
        sep126.TabIndex = 5;
        // 
        // txtSetSymbolValueValue
        // 
        txtSetSymbolValueValue.Dock = DockStyle.Top;
        txtSetSymbolValueValue.Location = new Point(5, 253);
        txtSetSymbolValueValue.Name = "txtSetSymbolValueValue";
        txtSetSymbolValueValue.PlaceholderText = "value";
        txtSetSymbolValueValue.Size = new Size(238, 23);
        txtSetSymbolValueValue.TabIndex = 4;
        txtSetSymbolValueValue.Text = "0";
        // 
        // sep125
        // 
        sep125.Dock = DockStyle.Top;
        sep125.Location = new Point(5, 248);
        sep125.Name = "sep125";
        sep125.Size = new Size(238, 5);
        sep125.TabIndex = 3;
        // 
        // gridSymbolValue
        // 
        gridSymbolValue.Dock = DockStyle.Top;
        gridSymbolValue.HelpVisible = false;
        gridSymbolValue.Location = new Point(5, 33);
        gridSymbolValue.Name = "gridSymbolValue";
        gridSymbolValue.PropertySort = PropertySort.NoSort;
        gridSymbolValue.Size = new Size(238, 215);
        gridSymbolValue.TabIndex = 2;
        gridSymbolValue.ToolbarVisible = false;
        // 
        // sep124
        // 
        sep124.Dock = DockStyle.Top;
        sep124.Location = new Point(5, 28);
        sep124.Name = "sep124";
        sep124.Size = new Size(238, 5);
        sep124.TabIndex = 1;
        // 
        // btnGetSymbolValue
        // 
        btnGetSymbolValue.Dock = DockStyle.Top;
        btnGetSymbolValue.Location = new Point(5, 5);
        btnGetSymbolValue.Name = "btnGetSymbolValue";
        btnGetSymbolValue.Size = new Size(238, 23);
        btnGetSymbolValue.TabIndex = 0;
        btnGetSymbolValue.Text = "Get Symbol value";
        btnGetSymbolValue.UseVisualStyleBackColor = true;
        btnGetSymbolValue.Click += btnGetSymbolValue_Click;
        // 
        // pnlSearchSymbols
        // 
        pnlSearchSymbols.BorderStyle = BorderStyle.FixedSingle;
        pnlSearchSymbols.Controls.Add(gridSearchSymbols);
        pnlSearchSymbols.Controls.Add(sep135);
        pnlSearchSymbols.Controls.Add(btnSearchSymbols);
        pnlSearchSymbols.Controls.Add(sep134);
        pnlSearchSymbols.Controls.Add(chkSearchSymbolsRecursive);
        pnlSearchSymbols.Controls.Add(sep133);
        pnlSearchSymbols.Controls.Add(txtSearchSymbolsDataType);
        pnlSearchSymbols.Controls.Add(sep132);
        pnlSearchSymbols.Controls.Add(txtSearchSymbolsNamePattern);
        pnlSearchSymbols.Controls.Add(sep131);
        pnlSearchSymbols.Controls.Add(cboSearchSymbolsSymbolType);
        pnlSearchSymbols.Controls.Add(sep130);
        pnlSearchSymbols.Controls.Add(cboSearchSymbolsView);
        pnlSearchSymbols.Controls.Add(sep129);
        pnlSearchSymbols.Controls.Add(txtSearchSymbolsBlockUrl);
        pnlSearchSymbols.Controls.Add(sep128);
        pnlSearchSymbols.Controls.Add(lblSearchSymbols);
        pnlSearchSymbols.Location = new Point(515, 3);
        pnlSearchSymbols.Name = "pnlSearchSymbols";
        pnlSearchSymbols.Padding = new Padding(5);
        pnlSearchSymbols.Size = new Size(250, 413);
        pnlSearchSymbols.TabIndex = 2;
        // 
        // gridSearchSymbols
        // 
        gridSearchSymbols.Dock = DockStyle.Top;
        gridSearchSymbols.HelpVisible = false;
        gridSearchSymbols.Location = new Point(5, 229);
        gridSearchSymbols.Name = "gridSearchSymbols";
        gridSearchSymbols.PropertySort = PropertySort.NoSort;
        gridSearchSymbols.Size = new Size(238, 177);
        gridSearchSymbols.TabIndex = 16;
        gridSearchSymbols.ToolbarVisible = false;
        // 
        // sep135
        // 
        sep135.Dock = DockStyle.Top;
        sep135.Location = new Point(5, 224);
        sep135.Name = "sep135";
        sep135.Size = new Size(238, 5);
        sep135.TabIndex = 15;
        // 
        // btnSearchSymbols
        // 
        btnSearchSymbols.Dock = DockStyle.Top;
        btnSearchSymbols.Location = new Point(5, 201);
        btnSearchSymbols.Name = "btnSearchSymbols";
        btnSearchSymbols.Size = new Size(238, 23);
        btnSearchSymbols.TabIndex = 14;
        btnSearchSymbols.Text = "Search Symbols";
        btnSearchSymbols.UseVisualStyleBackColor = true;
        btnSearchSymbols.Click += btnSearchSymbols_Click;
        // 
        // sep134
        // 
        sep134.Dock = DockStyle.Top;
        sep134.Location = new Point(5, 196);
        sep134.Name = "sep134";
        sep134.Size = new Size(238, 5);
        sep134.TabIndex = 13;
        // 
        // chkSearchSymbolsRecursive
        // 
        chkSearchSymbolsRecursive.Checked = true;
        chkSearchSymbolsRecursive.CheckState = CheckState.Checked;
        chkSearchSymbolsRecursive.Dock = DockStyle.Top;
        chkSearchSymbolsRecursive.Location = new Point(5, 173);
        chkSearchSymbolsRecursive.Name = "chkSearchSymbolsRecursive";
        chkSearchSymbolsRecursive.Size = new Size(238, 23);
        chkSearchSymbolsRecursive.TabIndex = 12;
        chkSearchSymbolsRecursive.Text = "Recursive";
        chkSearchSymbolsRecursive.UseVisualStyleBackColor = true;
        // 
        // sep133
        // 
        sep133.Dock = DockStyle.Top;
        sep133.Location = new Point(5, 168);
        sep133.Name = "sep133";
        sep133.Size = new Size(238, 5);
        sep133.TabIndex = 11;
        // 
        // txtSearchSymbolsDataType
        // 
        txtSearchSymbolsDataType.Dock = DockStyle.Top;
        txtSearchSymbolsDataType.Location = new Point(5, 145);
        txtSearchSymbolsDataType.Name = "txtSearchSymbolsDataType";
        txtSearchSymbolsDataType.PlaceholderText = "data type (optional)";
        txtSearchSymbolsDataType.Size = new Size(238, 23);
        txtSearchSymbolsDataType.TabIndex = 10;
        // 
        // sep132
        // 
        sep132.Dock = DockStyle.Top;
        sep132.Location = new Point(5, 140);
        sep132.Name = "sep132";
        sep132.Size = new Size(238, 5);
        sep132.TabIndex = 9;
        // 
        // txtSearchSymbolsNamePattern
        // 
        txtSearchSymbolsNamePattern.Dock = DockStyle.Top;
        txtSearchSymbolsNamePattern.Location = new Point(5, 117);
        txtSearchSymbolsNamePattern.Name = "txtSearchSymbolsNamePattern";
        txtSearchSymbolsNamePattern.PlaceholderText = "name pattern (optional)";
        txtSearchSymbolsNamePattern.Size = new Size(238, 23);
        txtSearchSymbolsNamePattern.TabIndex = 8;
        // 
        // sep131
        // 
        sep131.Dock = DockStyle.Top;
        sep131.Location = new Point(5, 112);
        sep131.Name = "sep131";
        sep131.Size = new Size(238, 5);
        sep131.TabIndex = 7;
        // 
        // cboSearchSymbolsSymbolType
        // 
        cboSearchSymbolsSymbolType.Dock = DockStyle.Top;
        cboSearchSymbolsSymbolType.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSearchSymbolsSymbolType.FormattingEnabled = true;
        cboSearchSymbolsSymbolType.Location = new Point(5, 89);
        cboSearchSymbolsSymbolType.Name = "cboSearchSymbolsSymbolType";
        cboSearchSymbolsSymbolType.Size = new Size(238, 23);
        cboSearchSymbolsSymbolType.TabIndex = 6;
        // 
        // sep130
        // 
        sep130.Dock = DockStyle.Top;
        sep130.Location = new Point(5, 84);
        sep130.Name = "sep130";
        sep130.Size = new Size(238, 5);
        sep130.TabIndex = 5;
        // 
        // cboSearchSymbolsView
        // 
        cboSearchSymbolsView.Dock = DockStyle.Top;
        cboSearchSymbolsView.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSearchSymbolsView.FormattingEnabled = true;
        cboSearchSymbolsView.Location = new Point(5, 61);
        cboSearchSymbolsView.Name = "cboSearchSymbolsView";
        cboSearchSymbolsView.Size = new Size(238, 23);
        cboSearchSymbolsView.TabIndex = 4;
        // 
        // sep129
        // 
        sep129.Dock = DockStyle.Top;
        sep129.Location = new Point(5, 56);
        sep129.Name = "sep129";
        sep129.Size = new Size(238, 5);
        sep129.TabIndex = 3;
        // 
        // txtSearchSymbolsBlockUrl
        // 
        txtSearchSymbolsBlockUrl.Dock = DockStyle.Top;
        txtSearchSymbolsBlockUrl.Location = new Point(5, 33);
        txtSearchSymbolsBlockUrl.Name = "txtSearchSymbolsBlockUrl";
        txtSearchSymbolsBlockUrl.PlaceholderText = "blockUrl";
        txtSearchSymbolsBlockUrl.Size = new Size(238, 23);
        txtSearchSymbolsBlockUrl.TabIndex = 2;
        txtSearchSymbolsBlockUrl.Text = "RAPID/T_ROB1";
        // 
        // sep128
        // 
        sep128.Dock = DockStyle.Top;
        sep128.Location = new Point(5, 28);
        sep128.Name = "sep128";
        sep128.Size = new Size(238, 5);
        sep128.TabIndex = 1;
        // 
        // lblSearchSymbols
        // 
        lblSearchSymbols.Dock = DockStyle.Top;
        lblSearchSymbols.Location = new Point(5, 5);
        lblSearchSymbols.Name = "lblSearchSymbols";
        lblSearchSymbols.Size = new Size(238, 23);
        lblSearchSymbols.TabIndex = 0;
        lblSearchSymbols.Text = "Search symbols";
        lblSearchSymbols.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlValidate
        // 
        pnlValidate.BorderStyle = BorderStyle.FixedSingle;
        pnlValidate.Controls.Add(chkValidateResult);
        pnlValidate.Controls.Add(sep138);
        pnlValidate.Controls.Add(btnValidateSymbolValue);
        pnlValidate.Controls.Add(sep137);
        pnlValidate.Controls.Add(txtValidateValue);
        pnlValidate.Controls.Add(sep136);
        pnlValidate.Controls.Add(txtValidateDataType);
        pnlValidate.Location = new Point(771, 3);
        pnlValidate.Name = "pnlValidate";
        pnlValidate.Padding = new Padding(5);
        pnlValidate.Size = new Size(250, 119);
        pnlValidate.TabIndex = 3;
        // 
        // chkValidateResult
        // 
        chkValidateResult.AutoCheck = false;
        chkValidateResult.Dock = DockStyle.Top;
        chkValidateResult.Location = new Point(5, 89);
        chkValidateResult.Name = "chkValidateResult";
        chkValidateResult.Size = new Size(238, 23);
        chkValidateResult.TabIndex = 6;
        chkValidateResult.Text = "Value accepted";
        chkValidateResult.UseVisualStyleBackColor = true;
        // 
        // sep138
        // 
        sep138.Dock = DockStyle.Top;
        sep138.Location = new Point(5, 84);
        sep138.Name = "sep138";
        sep138.Size = new Size(238, 5);
        sep138.TabIndex = 5;
        // 
        // btnValidateSymbolValue
        // 
        btnValidateSymbolValue.Dock = DockStyle.Top;
        btnValidateSymbolValue.Location = new Point(5, 61);
        btnValidateSymbolValue.Name = "btnValidateSymbolValue";
        btnValidateSymbolValue.Size = new Size(238, 23);
        btnValidateSymbolValue.TabIndex = 4;
        btnValidateSymbolValue.Text = "Validate Symbol value";
        btnValidateSymbolValue.UseVisualStyleBackColor = true;
        btnValidateSymbolValue.Click += btnValidateSymbolValue_Click;
        // 
        // sep137
        // 
        sep137.Dock = DockStyle.Top;
        sep137.Location = new Point(5, 56);
        sep137.Name = "sep137";
        sep137.Size = new Size(238, 5);
        sep137.TabIndex = 3;
        // 
        // txtValidateValue
        // 
        txtValidateValue.Dock = DockStyle.Top;
        txtValidateValue.Location = new Point(5, 33);
        txtValidateValue.Name = "txtValidateValue";
        txtValidateValue.PlaceholderText = "value";
        txtValidateValue.Size = new Size(238, 23);
        txtValidateValue.TabIndex = 2;
        txtValidateValue.Text = "42";
        // 
        // sep136
        // 
        sep136.Dock = DockStyle.Top;
        sep136.Location = new Point(5, 28);
        sep136.Name = "sep136";
        sep136.Size = new Size(238, 5);
        sep136.TabIndex = 1;
        // 
        // txtValidateDataType
        // 
        txtValidateDataType.Dock = DockStyle.Top;
        txtValidateDataType.Location = new Point(5, 5);
        txtValidateDataType.Name = "txtValidateDataType";
        txtValidateDataType.PlaceholderText = "dataType";
        txtValidateDataType.Size = new Size(238, 23);
        txtValidateDataType.TabIndex = 0;
        txtValidateDataType.Text = "num";
        // 
        // pnlObjectListExtension
        // 
        pnlObjectListExtension.BorderStyle = BorderStyle.FixedSingle;
        pnlObjectListExtension.Controls.Add(gridObjectListExtension);
        pnlObjectListExtension.Controls.Add(sep141);
        pnlObjectListExtension.Controls.Add(btnGetObjectListExtension);
        pnlObjectListExtension.Controls.Add(sep140);
        pnlObjectListExtension.Controls.Add(cboObjectListExtensionType);
        pnlObjectListExtension.Controls.Add(sep139);
        pnlObjectListExtension.Controls.Add(txtObjectListExtensionSymbolUrl);
        pnlObjectListExtension.Location = new Point(1027, 3);
        pnlObjectListExtension.Name = "pnlObjectListExtension";
        pnlObjectListExtension.Padding = new Padding(5);
        pnlObjectListExtension.Size = new Size(250, 406);
        pnlObjectListExtension.TabIndex = 4;
        // 
        // gridObjectListExtension
        // 
        gridObjectListExtension.Dock = DockStyle.Top;
        gridObjectListExtension.HelpVisible = false;
        gridObjectListExtension.Location = new Point(5, 89);
        gridObjectListExtension.Name = "gridObjectListExtension";
        gridObjectListExtension.PropertySort = PropertySort.NoSort;
        gridObjectListExtension.Size = new Size(238, 310);
        gridObjectListExtension.TabIndex = 6;
        gridObjectListExtension.ToolbarVisible = false;
        // 
        // sep141
        // 
        sep141.Dock = DockStyle.Top;
        sep141.Location = new Point(5, 84);
        sep141.Name = "sep141";
        sep141.Size = new Size(238, 5);
        sep141.TabIndex = 5;
        // 
        // btnGetObjectListExtension
        // 
        btnGetObjectListExtension.Dock = DockStyle.Top;
        btnGetObjectListExtension.Location = new Point(5, 61);
        btnGetObjectListExtension.Name = "btnGetObjectListExtension";
        btnGetObjectListExtension.Size = new Size(238, 23);
        btnGetObjectListExtension.TabIndex = 4;
        btnGetObjectListExtension.Text = "Get Object list extension";
        btnGetObjectListExtension.UseVisualStyleBackColor = true;
        btnGetObjectListExtension.Click += btnGetObjectListExtension_Click;
        // 
        // sep140
        // 
        sep140.Dock = DockStyle.Top;
        sep140.Location = new Point(5, 56);
        sep140.Name = "sep140";
        sep140.Size = new Size(238, 5);
        sep140.TabIndex = 3;
        // 
        // cboObjectListExtensionType
        // 
        cboObjectListExtensionType.Dock = DockStyle.Top;
        cboObjectListExtensionType.DropDownStyle = ComboBoxStyle.DropDownList;
        cboObjectListExtensionType.FormattingEnabled = true;
        cboObjectListExtensionType.Location = new Point(5, 33);
        cboObjectListExtensionType.Name = "cboObjectListExtensionType";
        cboObjectListExtensionType.Size = new Size(238, 23);
        cboObjectListExtensionType.TabIndex = 2;
        // 
        // sep139
        // 
        sep139.Dock = DockStyle.Top;
        sep139.Location = new Point(5, 28);
        sep139.Name = "sep139";
        sep139.Size = new Size(238, 5);
        sep139.TabIndex = 1;
        // 
        // txtObjectListExtensionSymbolUrl
        // 
        txtObjectListExtensionSymbolUrl.Dock = DockStyle.Top;
        txtObjectListExtensionSymbolUrl.Location = new Point(5, 5);
        txtObjectListExtensionSymbolUrl.Name = "txtObjectListExtensionSymbolUrl";
        txtObjectListExtensionSymbolUrl.PlaceholderText = "symbolUrl";
        txtObjectListExtensionSymbolUrl.Size = new Size(238, 23);
        txtObjectListExtensionSymbolUrl.TabIndex = 0;
        txtObjectListExtensionSymbolUrl.Text = "RAPID/T_ROB1/MainModule";
        // 
        // tabMotion
        // 
        tabMotion.Controls.Add(flowMotion);
        tabMotion.Location = new Point(4, 24);
        tabMotion.Name = "tabMotion";
        tabMotion.Padding = new Padding(3);
        tabMotion.Size = new Size(882, 421);
        tabMotion.TabIndex = 5;
        tabMotion.Text = "Motion";
        tabMotion.UseVisualStyleBackColor = true;
        // 
        // flowMotion
        // 
        flowMotion.AutoScroll = true;
        flowMotion.Controls.Add(pnlRobTarget);
        flowMotion.Controls.Add(pnlJointTarget);
        flowMotion.Controls.Add(pnlExternalJointStates);
        flowMotion.Controls.Add(pnlRapidMechanicalUnits);
        flowMotion.Dock = DockStyle.Fill;
        flowMotion.FlowDirection = FlowDirection.TopDown;
        flowMotion.Location = new Point(3, 3);
        flowMotion.Name = "flowMotion";
        flowMotion.Size = new Size(876, 415);
        flowMotion.TabIndex = 0;
        // 
        // pnlRobTarget
        // 
        pnlRobTarget.BorderStyle = BorderStyle.FixedSingle;
        pnlRobTarget.Controls.Add(gridRobTarget);
        pnlRobTarget.Controls.Add(sep144);
        pnlRobTarget.Controls.Add(btnGetRobTarget);
        pnlRobTarget.Controls.Add(sep143);
        pnlRobTarget.Controls.Add(txtGetRobTargetWorkObject);
        pnlRobTarget.Controls.Add(sep142);
        pnlRobTarget.Controls.Add(txtGetRobTargetTool);
        pnlRobTarget.Location = new Point(3, 3);
        pnlRobTarget.Name = "pnlRobTarget";
        pnlRobTarget.Padding = new Padding(5);
        pnlRobTarget.Size = new Size(250, 368);
        pnlRobTarget.TabIndex = 0;
        // 
        // gridRobTarget
        // 
        gridRobTarget.Dock = DockStyle.Top;
        gridRobTarget.HelpVisible = false;
        gridRobTarget.Location = new Point(5, 89);
        gridRobTarget.Name = "gridRobTarget";
        gridRobTarget.PropertySort = PropertySort.NoSort;
        gridRobTarget.Size = new Size(238, 272);
        gridRobTarget.TabIndex = 6;
        gridRobTarget.ToolbarVisible = false;
        // 
        // sep144
        // 
        sep144.Dock = DockStyle.Top;
        sep144.Location = new Point(5, 84);
        sep144.Name = "sep144";
        sep144.Size = new Size(238, 5);
        sep144.TabIndex = 5;
        // 
        // btnGetRobTarget
        // 
        btnGetRobTarget.Dock = DockStyle.Top;
        btnGetRobTarget.Location = new Point(5, 61);
        btnGetRobTarget.Name = "btnGetRobTarget";
        btnGetRobTarget.Size = new Size(238, 23);
        btnGetRobTarget.TabIndex = 4;
        btnGetRobTarget.Text = "Get RobTarget";
        btnGetRobTarget.UseVisualStyleBackColor = true;
        btnGetRobTarget.Click += btnGetRobTarget_Click;
        // 
        // sep143
        // 
        sep143.Dock = DockStyle.Top;
        sep143.Location = new Point(5, 56);
        sep143.Name = "sep143";
        sep143.Size = new Size(238, 5);
        sep143.TabIndex = 3;
        // 
        // txtGetRobTargetWorkObject
        // 
        txtGetRobTargetWorkObject.Dock = DockStyle.Top;
        txtGetRobTargetWorkObject.Location = new Point(5, 33);
        txtGetRobTargetWorkObject.Name = "txtGetRobTargetWorkObject";
        txtGetRobTargetWorkObject.PlaceholderText = "wobj (optional)";
        txtGetRobTargetWorkObject.Size = new Size(238, 23);
        txtGetRobTargetWorkObject.TabIndex = 2;
        // 
        // sep142
        // 
        sep142.Dock = DockStyle.Top;
        sep142.Location = new Point(5, 28);
        sep142.Name = "sep142";
        sep142.Size = new Size(238, 5);
        sep142.TabIndex = 1;
        // 
        // txtGetRobTargetTool
        // 
        txtGetRobTargetTool.Dock = DockStyle.Top;
        txtGetRobTargetTool.Location = new Point(5, 5);
        txtGetRobTargetTool.Name = "txtGetRobTargetTool";
        txtGetRobTargetTool.PlaceholderText = "tool (optional)";
        txtGetRobTargetTool.Size = new Size(238, 23);
        txtGetRobTargetTool.TabIndex = 0;
        // 
        // pnlJointTarget
        // 
        pnlJointTarget.BorderStyle = BorderStyle.FixedSingle;
        pnlJointTarget.Controls.Add(gridJointTarget);
        pnlJointTarget.Controls.Add(sep145);
        pnlJointTarget.Controls.Add(btnGetJointTarget);
        pnlJointTarget.Location = new Point(259, 3);
        pnlJointTarget.Name = "pnlJointTarget";
        pnlJointTarget.Padding = new Padding(5);
        pnlJointTarget.Size = new Size(250, 350);
        pnlJointTarget.TabIndex = 1;
        // 
        // gridJointTarget
        // 
        gridJointTarget.Dock = DockStyle.Top;
        gridJointTarget.HelpVisible = false;
        gridJointTarget.Location = new Point(5, 33);
        gridJointTarget.Name = "gridJointTarget";
        gridJointTarget.PropertySort = PropertySort.NoSort;
        gridJointTarget.Size = new Size(238, 310);
        gridJointTarget.TabIndex = 2;
        gridJointTarget.ToolbarVisible = false;
        // 
        // sep145
        // 
        sep145.Dock = DockStyle.Top;
        sep145.Location = new Point(5, 28);
        sep145.Name = "sep145";
        sep145.Size = new Size(238, 5);
        sep145.TabIndex = 1;
        // 
        // btnGetJointTarget
        // 
        btnGetJointTarget.Dock = DockStyle.Top;
        btnGetJointTarget.Location = new Point(5, 5);
        btnGetJointTarget.Name = "btnGetJointTarget";
        btnGetJointTarget.Size = new Size(238, 23);
        btnGetJointTarget.TabIndex = 0;
        btnGetJointTarget.Text = "Get JointTarget";
        btnGetJointTarget.UseVisualStyleBackColor = true;
        btnGetJointTarget.Click += btnGetJointTarget_Click;
        // 
        // pnlExternalJointStates
        // 
        pnlExternalJointStates.BorderStyle = BorderStyle.FixedSingle;
        pnlExternalJointStates.Controls.Add(gridExternalJointStates);
        pnlExternalJointStates.Controls.Add(sep146);
        pnlExternalJointStates.Controls.Add(btnGetExternalJointStates);
        pnlExternalJointStates.Location = new Point(515, 3);
        pnlExternalJointStates.Name = "pnlExternalJointStates";
        pnlExternalJointStates.Padding = new Padding(5);
        pnlExternalJointStates.Size = new Size(250, 160);
        pnlExternalJointStates.TabIndex = 2;
        // 
        // gridExternalJointStates
        // 
        gridExternalJointStates.Dock = DockStyle.Top;
        gridExternalJointStates.HelpVisible = false;
        gridExternalJointStates.Location = new Point(5, 33);
        gridExternalJointStates.Name = "gridExternalJointStates";
        gridExternalJointStates.PropertySort = PropertySort.NoSort;
        gridExternalJointStates.Size = new Size(238, 120);
        gridExternalJointStates.TabIndex = 2;
        gridExternalJointStates.ToolbarVisible = false;
        // 
        // sep146
        // 
        sep146.Dock = DockStyle.Top;
        sep146.Location = new Point(5, 28);
        sep146.Name = "sep146";
        sep146.Size = new Size(238, 5);
        sep146.TabIndex = 1;
        // 
        // btnGetExternalJointStates
        // 
        btnGetExternalJointStates.Dock = DockStyle.Top;
        btnGetExternalJointStates.Location = new Point(5, 5);
        btnGetExternalJointStates.Name = "btnGetExternalJointStates";
        btnGetExternalJointStates.Size = new Size(238, 23);
        btnGetExternalJointStates.TabIndex = 0;
        btnGetExternalJointStates.Text = "Get External joint states";
        btnGetExternalJointStates.UseVisualStyleBackColor = true;
        btnGetExternalJointStates.Click += btnGetExternalJointStates_Click;
        // 
        // pnlRapidMechanicalUnits
        // 
        pnlRapidMechanicalUnits.BorderStyle = BorderStyle.FixedSingle;
        pnlRapidMechanicalUnits.Controls.Add(gridRapidMechanicalUnits);
        pnlRapidMechanicalUnits.Controls.Add(sep147);
        pnlRapidMechanicalUnits.Controls.Add(btnGetRapidMechanicalUnits);
        pnlRapidMechanicalUnits.Location = new Point(515, 169);
        pnlRapidMechanicalUnits.Name = "pnlRapidMechanicalUnits";
        pnlRapidMechanicalUnits.Padding = new Padding(5);
        pnlRapidMechanicalUnits.Size = new Size(250, 160);
        pnlRapidMechanicalUnits.TabIndex = 3;
        // 
        // gridRapidMechanicalUnits
        // 
        gridRapidMechanicalUnits.Dock = DockStyle.Top;
        gridRapidMechanicalUnits.HelpVisible = false;
        gridRapidMechanicalUnits.Location = new Point(5, 33);
        gridRapidMechanicalUnits.Name = "gridRapidMechanicalUnits";
        gridRapidMechanicalUnits.PropertySort = PropertySort.NoSort;
        gridRapidMechanicalUnits.Size = new Size(238, 120);
        gridRapidMechanicalUnits.TabIndex = 2;
        gridRapidMechanicalUnits.ToolbarVisible = false;
        // 
        // sep147
        // 
        sep147.Dock = DockStyle.Top;
        sep147.Location = new Point(5, 28);
        sep147.Name = "sep147";
        sep147.Size = new Size(238, 5);
        sep147.TabIndex = 1;
        // 
        // btnGetRapidMechanicalUnits
        // 
        btnGetRapidMechanicalUnits.Dock = DockStyle.Top;
        btnGetRapidMechanicalUnits.Location = new Point(5, 5);
        btnGetRapidMechanicalUnits.Name = "btnGetRapidMechanicalUnits";
        btnGetRapidMechanicalUnits.Size = new Size(238, 23);
        btnGetRapidMechanicalUnits.TabIndex = 0;
        btnGetRapidMechanicalUnits.Text = "Get Mechanical units";
        btnGetRapidMechanicalUnits.UseVisualStyleBackColor = true;
        btnGetRapidMechanicalUnits.Click += btnGetRapidMechanicalUnits_Click;
        // 
        // tabUiInstructions
        // 
        tabUiInstructions.Controls.Add(flowUiInstructions);
        tabUiInstructions.Location = new Point(4, 24);
        tabUiInstructions.Name = "tabUiInstructions";
        tabUiInstructions.Padding = new Padding(3);
        tabUiInstructions.Size = new Size(882, 421);
        tabUiInstructions.TabIndex = 6;
        tabUiInstructions.Text = "UI instructions";
        tabUiInstructions.UseVisualStyleBackColor = true;
        // 
        // flowUiInstructions
        // 
        flowUiInstructions.AutoScroll = true;
        flowUiInstructions.Controls.Add(pnlActiveUiInstruction);
        flowUiInstructions.Controls.Add(pnlUiParameters);
        flowUiInstructions.Controls.Add(pnlUiParameter);
        flowUiInstructions.Dock = DockStyle.Fill;
        flowUiInstructions.FlowDirection = FlowDirection.TopDown;
        flowUiInstructions.Location = new Point(3, 3);
        flowUiInstructions.Name = "flowUiInstructions";
        flowUiInstructions.Size = new Size(876, 415);
        flowUiInstructions.TabIndex = 0;
        // 
        // pnlActiveUiInstruction
        // 
        pnlActiveUiInstruction.BorderStyle = BorderStyle.FixedSingle;
        pnlActiveUiInstruction.Controls.Add(gridActiveUiInstruction);
        pnlActiveUiInstruction.Controls.Add(sep148);
        pnlActiveUiInstruction.Controls.Add(btnGetActiveUiInstruction);
        pnlActiveUiInstruction.Location = new Point(3, 3);
        pnlActiveUiInstruction.Name = "pnlActiveUiInstruction";
        pnlActiveUiInstruction.Padding = new Padding(5);
        pnlActiveUiInstruction.Size = new Size(250, 141);
        pnlActiveUiInstruction.TabIndex = 0;
        // 
        // gridActiveUiInstruction
        // 
        gridActiveUiInstruction.Dock = DockStyle.Top;
        gridActiveUiInstruction.HelpVisible = false;
        gridActiveUiInstruction.Location = new Point(5, 33);
        gridActiveUiInstruction.Name = "gridActiveUiInstruction";
        gridActiveUiInstruction.PropertySort = PropertySort.NoSort;
        gridActiveUiInstruction.Size = new Size(238, 101);
        gridActiveUiInstruction.TabIndex = 2;
        gridActiveUiInstruction.ToolbarVisible = false;
        // 
        // sep148
        // 
        sep148.Dock = DockStyle.Top;
        sep148.Location = new Point(5, 28);
        sep148.Name = "sep148";
        sep148.Size = new Size(238, 5);
        sep148.TabIndex = 1;
        // 
        // btnGetActiveUiInstruction
        // 
        btnGetActiveUiInstruction.Dock = DockStyle.Top;
        btnGetActiveUiInstruction.Location = new Point(5, 5);
        btnGetActiveUiInstruction.Name = "btnGetActiveUiInstruction";
        btnGetActiveUiInstruction.Size = new Size(238, 23);
        btnGetActiveUiInstruction.TabIndex = 0;
        btnGetActiveUiInstruction.Text = "Get Active UI instruction";
        btnGetActiveUiInstruction.UseVisualStyleBackColor = true;
        btnGetActiveUiInstruction.Click += btnGetActiveUiInstruction_Click;
        // 
        // pnlUiParameters
        // 
        pnlUiParameters.BorderStyle = BorderStyle.FixedSingle;
        pnlUiParameters.Controls.Add(gridUiInstructionParameters);
        pnlUiParameters.Controls.Add(sep150);
        pnlUiParameters.Controls.Add(btnGetUiInstructionParameters);
        pnlUiParameters.Controls.Add(sep149);
        pnlUiParameters.Controls.Add(txtUiStackUrl);
        pnlUiParameters.Location = new Point(259, 3);
        pnlUiParameters.Name = "pnlUiParameters";
        pnlUiParameters.Padding = new Padding(5);
        pnlUiParameters.Size = new Size(250, 302);
        pnlUiParameters.TabIndex = 1;
        // 
        // gridUiInstructionParameters
        // 
        gridUiInstructionParameters.Dock = DockStyle.Top;
        gridUiInstructionParameters.HelpVisible = false;
        gridUiInstructionParameters.Location = new Point(5, 61);
        gridUiInstructionParameters.Name = "gridUiInstructionParameters";
        gridUiInstructionParameters.PropertySort = PropertySort.NoSort;
        gridUiInstructionParameters.Size = new Size(238, 234);
        gridUiInstructionParameters.TabIndex = 4;
        gridUiInstructionParameters.ToolbarVisible = false;
        // 
        // sep150
        // 
        sep150.Dock = DockStyle.Top;
        sep150.Location = new Point(5, 56);
        sep150.Name = "sep150";
        sep150.Size = new Size(238, 5);
        sep150.TabIndex = 3;
        // 
        // btnGetUiInstructionParameters
        // 
        btnGetUiInstructionParameters.Dock = DockStyle.Top;
        btnGetUiInstructionParameters.Location = new Point(5, 33);
        btnGetUiInstructionParameters.Name = "btnGetUiInstructionParameters";
        btnGetUiInstructionParameters.Size = new Size(238, 23);
        btnGetUiInstructionParameters.TabIndex = 2;
        btnGetUiInstructionParameters.Text = "Get UI instruction parameters";
        btnGetUiInstructionParameters.UseVisualStyleBackColor = true;
        btnGetUiInstructionParameters.Click += btnGetUiInstructionParameters_Click;
        // 
        // sep149
        // 
        sep149.Dock = DockStyle.Top;
        sep149.Location = new Point(5, 28);
        sep149.Name = "sep149";
        sep149.Size = new Size(238, 5);
        sep149.TabIndex = 1;
        // 
        // txtUiStackUrl
        // 
        txtUiStackUrl.Dock = DockStyle.Top;
        txtUiStackUrl.Location = new Point(5, 5);
        txtUiStackUrl.Name = "txtUiStackUrl";
        txtUiStackUrl.PlaceholderText = "stackUrl";
        txtUiStackUrl.Size = new Size(238, 23);
        txtUiStackUrl.TabIndex = 0;
        // 
        // pnlUiParameter
        // 
        pnlUiParameter.BorderStyle = BorderStyle.FixedSingle;
        pnlUiParameter.Controls.Add(btnSetUiInstructionParameter);
        pnlUiParameter.Controls.Add(sep154);
        pnlUiParameter.Controls.Add(txtSetUiInstructionParameterValue);
        pnlUiParameter.Controls.Add(sep153);
        pnlUiParameter.Controls.Add(txtUiParameterValue);
        pnlUiParameter.Controls.Add(sep152);
        pnlUiParameter.Controls.Add(btnGetUiInstructionParameter);
        pnlUiParameter.Controls.Add(sep151);
        pnlUiParameter.Controls.Add(txtUiParameterName);
        pnlUiParameter.Location = new Point(515, 3);
        pnlUiParameter.Name = "pnlUiParameter";
        pnlUiParameter.Padding = new Padding(5);
        pnlUiParameter.Size = new Size(250, 147);
        pnlUiParameter.TabIndex = 2;
        // 
        // btnSetUiInstructionParameter
        // 
        btnSetUiInstructionParameter.Dock = DockStyle.Top;
        btnSetUiInstructionParameter.Location = new Point(5, 117);
        btnSetUiInstructionParameter.Name = "btnSetUiInstructionParameter";
        btnSetUiInstructionParameter.Size = new Size(238, 23);
        btnSetUiInstructionParameter.TabIndex = 8;
        btnSetUiInstructionParameter.Text = "Set UI instruction parameter";
        btnSetUiInstructionParameter.UseVisualStyleBackColor = true;
        btnSetUiInstructionParameter.Click += btnSetUiInstructionParameter_Click;
        // 
        // sep154
        // 
        sep154.Dock = DockStyle.Top;
        sep154.Location = new Point(5, 112);
        sep154.Name = "sep154";
        sep154.Size = new Size(238, 5);
        sep154.TabIndex = 7;
        // 
        // txtSetUiInstructionParameterValue
        // 
        txtSetUiInstructionParameterValue.Dock = DockStyle.Top;
        txtSetUiInstructionParameterValue.Location = new Point(5, 89);
        txtSetUiInstructionParameterValue.Name = "txtSetUiInstructionParameterValue";
        txtSetUiInstructionParameterValue.PlaceholderText = "value to write";
        txtSetUiInstructionParameterValue.Size = new Size(238, 23);
        txtSetUiInstructionParameterValue.TabIndex = 6;
        txtSetUiInstructionParameterValue.Text = "TRUE";
        // 
        // sep153
        // 
        sep153.Dock = DockStyle.Top;
        sep153.Location = new Point(5, 84);
        sep153.Name = "sep153";
        sep153.Size = new Size(238, 5);
        sep153.TabIndex = 5;
        // 
        // txtUiParameterValue
        // 
        txtUiParameterValue.Dock = DockStyle.Top;
        txtUiParameterValue.Location = new Point(5, 61);
        txtUiParameterValue.Name = "txtUiParameterValue";
        txtUiParameterValue.PlaceholderText = "value";
        txtUiParameterValue.ReadOnly = true;
        txtUiParameterValue.Size = new Size(238, 23);
        txtUiParameterValue.TabIndex = 4;
        // 
        // sep152
        // 
        sep152.Dock = DockStyle.Top;
        sep152.Location = new Point(5, 56);
        sep152.Name = "sep152";
        sep152.Size = new Size(238, 5);
        sep152.TabIndex = 3;
        // 
        // btnGetUiInstructionParameter
        // 
        btnGetUiInstructionParameter.Dock = DockStyle.Top;
        btnGetUiInstructionParameter.Location = new Point(5, 33);
        btnGetUiInstructionParameter.Name = "btnGetUiInstructionParameter";
        btnGetUiInstructionParameter.Size = new Size(238, 23);
        btnGetUiInstructionParameter.TabIndex = 2;
        btnGetUiInstructionParameter.Text = "Get UI instruction parameter";
        btnGetUiInstructionParameter.UseVisualStyleBackColor = true;
        btnGetUiInstructionParameter.Click += btnGetUiInstructionParameter_Click;
        // 
        // sep151
        // 
        sep151.Dock = DockStyle.Top;
        sep151.Location = new Point(5, 28);
        sep151.Name = "sep151";
        sep151.Size = new Size(238, 5);
        sep151.TabIndex = 1;
        // 
        // txtUiParameterName
        // 
        txtUiParameterName.Dock = DockStyle.Top;
        txtUiParameterName.Location = new Point(5, 5);
        txtUiParameterName.Name = "txtUiParameterName";
        txtUiParameterName.PlaceholderText = "parameter";
        txtUiParameterName.Size = new Size(238, 23);
        txtUiParameterName.TabIndex = 0;
        txtUiParameterName.Text = "TPCompleted";
        // 
        // RwsRapidControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tabControl);
        Controls.Add(pnlHeader);
        Margin = new Padding(4, 3, 4, 3);
        Name = "RwsRapidControl";
        Size = new Size(890, 491);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        tabControl.ResumeLayout(false);
        tabExecution.ResumeLayout(false);
        flowExecution.ResumeLayout(false);
        pnlExecutionState.ResumeLayout(false);
        pnlStart.ResumeLayout(false);
        pnlStop.ResumeLayout(false);
        pnlProductionEntry.ResumeLayout(false);
        pnlExecutionCycle.ResumeLayout(false);
        pnlHoldToRun.ResumeLayout(false);
        pnlTaskSelection.ResumeLayout(false);
        pnlAliasIo.ResumeLayout(false);
        tabTasks.ResumeLayout(false);
        flowTasks.ResumeLayout(false);
        pnlTasks.ResumeLayout(false);
        pnlTask.ResumeLayout(false);
        pnlTaskActivation.ResumeLayout(false);
        pnlBuildTask.ResumeLayout(false);
        pnlLoadModule.ResumeLayout(false);
        pnlLoadModule.PerformLayout();
        pnlSpy.ResumeLayout(false);
        pnlSpy.PerformLayout();
        pnlSyncState.ResumeLayout(false);
        pnlSyncState.PerformLayout();
        pnlStructuralChangeCount.ResumeLayout(false);
        pnlActivationRecord.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numGetActivationRecordStackFrame).EndInit();
        pnlServiceRoutines.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numGetServiceRoutinesLimit).EndInit();
        pnlPreferredDataTypes.ResumeLayout(false);
        pnlPreferredDataTypes.PerformLayout();
        pnlPalletHeads.ResumeLayout(false);
        pnlPallet.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numGetPalletNumber).EndInit();
        tabProgram.ResumeLayout(false);
        flowProgram.ResumeLayout(false);
        pnlProgram.ResumeLayout(false);
        pnlLoadProgram.ResumeLayout(false);
        pnlLoadProgram.PerformLayout();
        pnlSaveProgram.ResumeLayout(false);
        pnlSaveProgram.PerformLayout();
        pnlProgramName.ResumeLayout(false);
        pnlProgramName.PerformLayout();
        pnlBreakpoints.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numSetBreakpointColumn).EndInit();
        ((System.ComponentModel.ISupportInitialize)numSetBreakpointRow).EndInit();
        pnlBuildErrors.ResumeLayout(false);
        pnlPointers.ResumeLayout(false);
        pnlProgramCounterPosition.ResumeLayout(false);
        pnlProgramPointerMoves.ResumeLayout(false);
        pnlProgramPointerMoves.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numSetProgramPointerColumn).EndInit();
        ((System.ComponentModel.ISupportInitialize)numSetProgramPointerRow).EndInit();
        pnlProgramPointerUrl.ResumeLayout(false);
        pnlProgramPointerUrl.PerformLayout();
        tabModules.ResumeLayout(false);
        flowModules.ResumeLayout(false);
        pnlModules.ResumeLayout(false);
        pnlModule.ResumeLayout(false);
        pnlModuleCounters.ResumeLayout(false);
        pnlModuleCounters.PerformLayout();
        pnlModuleText.ResumeLayout(false);
        pnlModuleText.PerformLayout();
        pnlModuleTextRange.ResumeLayout(false);
        pnlModuleTextRange.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numModuleTextRangeEndColumn).EndInit();
        ((System.ComponentModel.ISupportInitialize)numModuleTextRangeEndRow).EndInit();
        ((System.ComponentModel.ISupportInitialize)numModuleTextRangeStartColumn).EndInit();
        ((System.ComponentModel.ISupportInitialize)numModuleTextRangeStartRow).EndInit();
        pnlSearchModuleText.ResumeLayout(false);
        pnlSearchModuleText.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numSearchModuleTextStartColumn).EndInit();
        ((System.ComponentModel.ISupportInitialize)numSearchModuleTextStartRow).EndInit();
        pnlSyncPers.ResumeLayout(false);
        pnlModuleAttributes.ResumeLayout(false);
        pnlSaveModule.ResumeLayout(false);
        pnlSaveModule.PerformLayout();
        pnlModuleSymbol.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numGetModuleSymbolColumn).EndInit();
        ((System.ComponentModel.ISupportInitialize)numGetModuleSymbolRow).EndInit();
        pnlRoutine.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numGetRoutineColumn).EndInit();
        ((System.ComponentModel.ISupportInitialize)numGetRoutineRow).EndInit();
        pnlRoutineArguments.ResumeLayout(false);
        pnlInstructionTemplate.ResumeLayout(false);
        pnlInstructionTemplate.PerformLayout();
        pnlObjectChildren.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numObjectChildEndColumn).EndInit();
        ((System.ComponentModel.ISupportInitialize)numObjectChildEndLine).EndInit();
        ((System.ComponentModel.ISupportInitialize)numObjectChildStartColumn).EndInit();
        ((System.ComponentModel.ISupportInitialize)numObjectChildStartLine).EndInit();
        pnlModifiablePositions.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numModifiablePositionsEndRow).EndInit();
        ((System.ComponentModel.ISupportInitialize)numModifiablePositionsStartRow).EndInit();
        pnlAllModifiablePositions.ResumeLayout(false);
        tabSymbols.ResumeLayout(false);
        flowSymbols.ResumeLayout(false);
        pnlSymbolProperties.ResumeLayout(false);
        pnlSymbolProperties.PerformLayout();
        pnlSymbolValue.ResumeLayout(false);
        pnlSymbolValue.PerformLayout();
        pnlSearchSymbols.ResumeLayout(false);
        pnlSearchSymbols.PerformLayout();
        pnlValidate.ResumeLayout(false);
        pnlValidate.PerformLayout();
        pnlObjectListExtension.ResumeLayout(false);
        pnlObjectListExtension.PerformLayout();
        tabMotion.ResumeLayout(false);
        flowMotion.ResumeLayout(false);
        pnlRobTarget.ResumeLayout(false);
        pnlRobTarget.PerformLayout();
        pnlJointTarget.ResumeLayout(false);
        pnlExternalJointStates.ResumeLayout(false);
        pnlRapidMechanicalUnits.ResumeLayout(false);
        tabUiInstructions.ResumeLayout(false);
        flowUiInstructions.ResumeLayout(false);
        pnlActiveUiInstruction.ResumeLayout(false);
        pnlUiParameters.ResumeLayout(false);
        pnlUiParameters.PerformLayout();
        pnlUiParameter.ResumeLayout(false);
        pnlUiParameter.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel pnlHeader;
    private Label lblTask;
    private TextBox txtTask;
    private Label lblModule;
    private TextBox txtModule;
    private Button btnTakeMastership;
    private Button btnReleaseMastership;
    private Label lblMastershipStatus;
    private TabControl tabControl;

    private TabPage tabExecution;
    private FlowLayoutPanel flowExecution;

    private Panel pnlExecutionState;
    private Button btnGetExecutionState;
    private Panel sep1;
    private PropertyGrid gridExecutionState;

    private Panel pnlStart;
    private Label lblStart;
    private Panel sep2;
    private ComboBox cboStartRegain;
    private Panel sep3;
    private ComboBox cboStartExecutionMode;
    private Panel sep4;
    private ComboBox cboStartCycle;
    private Panel sep5;
    private ComboBox cboStartCondition;
    private Panel sep6;
    private CheckBox chkStartStopAtBreakpoint;
    private Panel sep7;
    private CheckBox chkStartAllTasksBySelection;
    private Panel sep8;
    private Button btnStart;

    private Panel pnlStop;
    private Label lblStop;
    private Panel sep9;
    private ComboBox cboStopStopMode;
    private Panel sep10;
    private ComboBox cboStopScope;
    private Panel sep11;
    private Button btnStop;

    private Panel pnlProductionEntry;
    private Button btnStartFromProductionEntry;
    private Panel sep12;
    private Button btnResetProgramPointer;

    private Panel pnlExecutionCycle;
    private ComboBox cboSetExecutionCycleCycle;
    private Panel sep13;
    private Button btnSetExecutionCycle;

    private Panel pnlHoldToRun;
    private ComboBox cboSetHoldToRunState;
    private Panel sep14;
    private Button btnSetHoldToRun;

    private Panel pnlTaskSelection;
    private Button btnGetTaskSelection;
    private Panel sep15;
    private PropertyGrid gridTaskSelection;

    private Panel pnlAliasIo;
    private Button btnGetAliasIo;
    private Panel sep16;
    private PropertyGrid gridAliasIo;

    private TabPage tabTasks;
    private FlowLayoutPanel flowTasks;

    private Panel pnlTasks;
    private Button btnGetTasks;
    private Panel sep17;
    private PropertyGrid gridTasks;

    private Panel pnlTask;
    private Button btnGetTask;
    private Panel sep18;
    private PropertyGrid gridTask;

    private Panel pnlTaskActivation;
    private Button btnActivateTask;
    private Panel sep19;
    private Button btnDeactivateTask;
    private Panel sep20;
    private Button btnActivateTasks;
    private Panel sep21;
    private Button btnDeactivateTasks;

    private Panel pnlBuildTask;
    private Button btnBuildTask;
    private Panel sep22;
    private Button btnAbortExecutionLevel;

    private Panel pnlLoadModule;
    private TextBox txtLoadModulePath;
    private Panel sep23;
    private CheckBox chkLoadModuleReplace;
    private Panel sep24;
    private Button btnLoadModule;
    private Panel sep25;
    private TextBox txtLoadModuleResult;
    private Panel sep26;
    private Button btnUnloadModule;

    private Panel pnlSpy;
    private Button btnGetSpyStatus;
    private Panel sep27;
    private TextBox txtSpyStatus;
    private Panel sep28;
    private TextBox txtStartSpyLogFile;
    private Panel sep29;
    private Button btnStartSpy;
    private Panel sep30;
    private Button btnStopSpy;

    private Panel pnlSyncState;
    private Button btnGetProgramPointerSyncState;
    private Panel sep31;
    private TextBox txtProgramPointerSyncState;
    private Panel sep32;
    private Button btnGetMotionPointerSyncState;
    private Panel sep33;
    private TextBox txtMotionPointerSyncState;
    private Panel sep34;
    private Button btnGetTaskProgramPointerSyncState;
    private Panel sep35;
    private TextBox txtTaskProgramPointerSyncState;
    private Panel sep36;
    private Button btnGetTaskMotionPointerSyncState;
    private Panel sep37;
    private TextBox txtTaskMotionPointerSyncState;

    private Panel pnlStructuralChangeCount;
    private Button btnGetStructuralChangeCount;
    private Panel sep38;
    private PropertyGrid gridStructuralChangeCount;

    private Panel pnlActivationRecord;
    private NumericUpDown numGetActivationRecordStackFrame;
    private Panel sep39;
    private Button btnGetActivationRecord;
    private Panel sep40;
    private PropertyGrid gridActivationRecord;

    private Panel pnlServiceRoutines;
    private NumericUpDown numGetServiceRoutinesLimit;
    private Panel sep41;
    private Button btnGetServiceRoutines;
    private Panel sep42;
    private PropertyGrid gridServiceRoutines;

    private Panel pnlPreferredDataTypes;
    private TextBox txtGetPreferredDataTypesInstruction;
    private Panel sep43;
    private TextBox txtGetPreferredDataTypesParameter;
    private Panel sep44;
    private Button btnGetPreferredDataTypes;
    private Panel sep45;
    private PropertyGrid gridPreferredDataTypes;

    private Panel pnlPalletHeads;
    private Button btnGetPalletHeads;
    private Panel sep46;
    private PropertyGrid gridPalletHeads;

    private Panel pnlPallet;
    private NumericUpDown numGetPalletNumber;
    private Panel sep47;
    private Button btnGetPallet;
    private Panel sep48;
    private PropertyGrid gridPallet;

    private TabPage tabProgram;
    private FlowLayoutPanel flowProgram;

    private Panel pnlProgram;
    private Button btnGetProgram;
    private Panel sep49;
    private PropertyGrid gridProgram;

    private Panel pnlLoadProgram;
    private TextBox txtLoadProgramPath;
    private Panel sep50;
    private ComboBox cboLoadProgramLoadMode;
    private Panel sep51;
    private Button btnLoadProgram;
    private Panel sep52;
    private Button btnUnloadProgram;

    private Panel pnlSaveProgram;
    private TextBox txtSaveProgramPath;
    private Panel sep53;
    private Button btnSaveProgram;

    private Panel pnlProgramName;
    private TextBox txtSetProgramNameName;
    private Panel sep54;
    private Button btnSetProgramName;
    private Panel sep55;
    private TextBox txtSetEntryPointRoutine;
    private Panel sep56;
    private Button btnSetEntryPoint;

    private Panel pnlBreakpoints;
    private Button btnGetBreakpoints;
    private Panel sep57;
    private PropertyGrid gridBreakpoints;
    private Panel sep58;
    private NumericUpDown numSetBreakpointRow;
    private Panel sep59;
    private NumericUpDown numSetBreakpointColumn;
    private Panel sep60;
    private Button btnSetBreakpoint;

    private Panel pnlBuildErrors;
    private Button btnGetBuildErrors;
    private Panel sep61;
    private PropertyGrid gridBuildErrors;

    private Panel pnlPointers;
    private Button btnGetPointers;
    private Panel sep62;
    private PropertyGrid gridPointers;

    private Panel pnlProgramCounterPosition;
    private Button btnGetProgramCounterPosition;
    private Panel sep63;
    private PropertyGrid gridProgramCounterPosition;

    private Panel pnlProgramPointerMoves;
    private Label lblProgramPointer;
    private Panel sep64;
    private TextBox txtSetProgramPointerRoutine;
    private Panel sep65;
    private NumericUpDown numSetProgramPointerRow;
    private Panel sep66;
    private NumericUpDown numSetProgramPointerColumn;
    private Panel sep67;
    private CheckBox chkSetProgramPointerUserLevel;
    private Panel sep68;
    private Button btnSetProgramPointerToCursor;
    private Panel sep69;
    private Button btnSetProgramPointerToRoutine;
    private Panel sep70;
    private Button btnSetProgramPointerToNextInstruction;
    private Panel sep71;
    private Button btnSetProgramPointerToPreviousInstruction;

    private Panel pnlProgramPointerUrl;
    private TextBox txtSetProgramPointerToRoutineUrlRoutineUrl;
    private Panel sep72;
    private Button btnSetProgramPointerToRoutineUrl;

    private TabPage tabModules;
    private FlowLayoutPanel flowModules;

    private Panel pnlModules;
    private Button btnGetModules;
    private Panel sep73;
    private PropertyGrid gridModules;

    private Panel pnlModule;
    private Button btnGetModule;
    private Panel sep74;
    private PropertyGrid gridModule;

    private Panel pnlModuleCounters;
    private Button btnGetModuleChangeCount;
    private Panel sep75;
    private TextBox txtModuleChangeCount;
    private Panel sep76;
    private Button btnGetModuleExtension;
    private Panel sep77;
    private PropertyGrid gridModuleExtension;

    private Panel pnlModuleText;
    private Button btnGetModuleText;
    private Panel sep78;
    private TextBox memoModuleText;
    private Panel sep79;
    private Button btnSetModuleText;

    private Panel pnlModuleTextRange;
    private Label lblModuleTextRange;
    private Panel sep80;
    private NumericUpDown numModuleTextRangeStartRow;
    private Panel sep81;
    private NumericUpDown numModuleTextRangeStartColumn;
    private Panel sep82;
    private NumericUpDown numModuleTextRangeEndRow;
    private Panel sep83;
    private NumericUpDown numModuleTextRangeEndColumn;
    private Panel sep84;
    private Button btnGetModuleTextRange;
    private Panel sep85;
    private TextBox memoModuleTextRange;
    private Panel sep86;
    private ComboBox cboSetModuleTextRangeReplaceMode;
    private Panel sep87;
    private ComboBox cboSetModuleTextRangeQueryMode;
    private Panel sep88;
    private Button btnSetModuleTextRange;
    private Panel sep89;
    private PropertyGrid gridSetModuleTextRangeResult;

    private Panel pnlSearchModuleText;
    private TextBox txtSearchModuleTextText;
    private Panel sep90;
    private NumericUpDown numSearchModuleTextStartRow;
    private Panel sep91;
    private NumericUpDown numSearchModuleTextStartColumn;
    private Panel sep92;
    private Button btnSearchModuleText;
    private Panel sep93;
    private PropertyGrid gridSearchModuleText;

    private Panel pnlSyncPers;
    private Button btnGetSyncPersStatus;
    private Panel sep94;
    private CheckBox chkSyncPersStatus;
    private Panel sep95;
    private Button btnSyncPersistentVariables;

    private Panel pnlModuleAttributes;
    private Button btnGetPossibleModuleAttributes;
    private Panel sep96;
    private PropertyGrid gridPossibleModuleAttributes;

    private Panel pnlSaveModule;
    private TextBox txtSaveModuleName;
    private Panel sep97;
    private TextBox txtSaveModulePath;
    private Panel sep98;
    private Button btnSaveModule;

    private Panel pnlModuleSymbol;
    private NumericUpDown numGetModuleSymbolRow;
    private Panel sep99;
    private NumericUpDown numGetModuleSymbolColumn;
    private Panel sep100;
    private Button btnGetModuleSymbol;
    private Panel sep101;
    private PropertyGrid gridModuleSymbol;

    private Panel pnlRoutine;
    private NumericUpDown numGetRoutineRow;
    private Panel sep102;
    private NumericUpDown numGetRoutineColumn;
    private Panel sep103;
    private Button btnGetRoutine;
    private Panel sep104;
    private PropertyGrid gridRoutine;

    private Panel pnlRoutineArguments;
    private Button btnGetRoutineArguments;
    private Panel sep105;
    private PropertyGrid gridRoutineArguments;

    private Panel pnlInstructionTemplate;
    private TextBox txtGetInstructionTemplateName;
    private Panel sep106;
    private CheckBox chkGetInstructionTemplateIsDataType;
    private Panel sep107;
    private Button btnGetInstructionTemplate;
    private Panel sep108;
    private PropertyGrid gridInstructionTemplate;

    private Panel pnlObjectChildren;
    private Label lblObjectChildren;
    private Panel sep109;
    private NumericUpDown numObjectChildStartLine;
    private Panel sep110;
    private NumericUpDown numObjectChildStartColumn;
    private Panel sep111;
    private NumericUpDown numObjectChildEndLine;
    private Panel sep112;
    private NumericUpDown numObjectChildEndColumn;
    private Panel sep113;
    private Button btnGetObjectChildren;
    private Panel sep114;
    private PropertyGrid gridObjectChildren;

    private Panel pnlModifiablePositions;
    private Label lblModifiablePositions;
    private Panel sep115;
    private NumericUpDown numModifiablePositionsStartRow;
    private Panel sep116;
    private NumericUpDown numModifiablePositionsEndRow;
    private Panel sep117;
    private Button btnGetModifiablePositions;
    private Panel sep118;
    private PropertyGrid gridModifiablePositions;
    private Panel sep119;
    private Button btnModifyPosition;

    private Panel pnlAllModifiablePositions;
    private Button btnGetAllModifiablePositions;
    private Panel sep120;
    private PropertyGrid gridAllModifiablePositions;
    private Panel sep121;
    private Button btnModifyAllPositions;

    private TabPage tabSymbols;
    private FlowLayoutPanel flowSymbols;

    private Panel pnlSymbolProperties;
    private TextBox txtSymbolUrl;
    private Panel sep122;
    private Button btnGetSymbolProperties;
    private Panel sep123;
    private PropertyGrid gridSymbolProperties;

    private Panel pnlSymbolValue;
    private Button btnGetSymbolValue;
    private Panel sep124;
    private PropertyGrid gridSymbolValue;
    private Panel sep125;
    private TextBox txtSetSymbolValueValue;
    private Panel sep126;
    private Button btnSetSymbolValue;
    private Panel sep127;
    private Button btnSetSymbolInitialValue;

    private Panel pnlSearchSymbols;
    private Label lblSearchSymbols;
    private Panel sep128;
    private TextBox txtSearchSymbolsBlockUrl;
    private Panel sep129;
    private ComboBox cboSearchSymbolsView;
    private Panel sep130;
    private ComboBox cboSearchSymbolsSymbolType;
    private Panel sep131;
    private TextBox txtSearchSymbolsNamePattern;
    private Panel sep132;
    private TextBox txtSearchSymbolsDataType;
    private Panel sep133;
    private CheckBox chkSearchSymbolsRecursive;
    private Panel sep134;
    private Button btnSearchSymbols;
    private Panel sep135;
    private PropertyGrid gridSearchSymbols;

    private Panel pnlValidate;
    private TextBox txtValidateDataType;
    private Panel sep136;
    private TextBox txtValidateValue;
    private Panel sep137;
    private Button btnValidateSymbolValue;
    private Panel sep138;
    private CheckBox chkValidateResult;

    private Panel pnlObjectListExtension;
    private TextBox txtObjectListExtensionSymbolUrl;
    private Panel sep139;
    private ComboBox cboObjectListExtensionType;
    private Panel sep140;
    private Button btnGetObjectListExtension;
    private Panel sep141;
    private PropertyGrid gridObjectListExtension;

    private TabPage tabMotion;
    private FlowLayoutPanel flowMotion;

    private Panel pnlRobTarget;
    private TextBox txtGetRobTargetTool;
    private Panel sep142;
    private TextBox txtGetRobTargetWorkObject;
    private Panel sep143;
    private Button btnGetRobTarget;
    private Panel sep144;
    private PropertyGrid gridRobTarget;

    private Panel pnlJointTarget;
    private Button btnGetJointTarget;
    private Panel sep145;
    private PropertyGrid gridJointTarget;

    private Panel pnlExternalJointStates;
    private Button btnGetExternalJointStates;
    private Panel sep146;
    private PropertyGrid gridExternalJointStates;

    private Panel pnlRapidMechanicalUnits;
    private Button btnGetRapidMechanicalUnits;
    private Panel sep147;
    private PropertyGrid gridRapidMechanicalUnits;

    private TabPage tabUiInstructions;
    private FlowLayoutPanel flowUiInstructions;

    private Panel pnlActiveUiInstruction;
    private Button btnGetActiveUiInstruction;
    private Panel sep148;
    private PropertyGrid gridActiveUiInstruction;

    private Panel pnlUiParameters;
    private TextBox txtUiStackUrl;
    private Panel sep149;
    private Button btnGetUiInstructionParameters;
    private Panel sep150;
    private PropertyGrid gridUiInstructionParameters;

    private Panel pnlUiParameter;
    private TextBox txtUiParameterName;
    private Panel sep151;
    private Button btnGetUiInstructionParameter;
    private Panel sep152;
    private TextBox txtUiParameterValue;
    private Panel sep153;
    private TextBox txtSetUiInstructionParameterValue;
    private Panel sep154;
    private Button btnSetUiInstructionParameter;
}
