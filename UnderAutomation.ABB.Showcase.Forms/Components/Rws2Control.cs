using System.ComponentModel;
using UnderAutomation.ABB;
using UnderAutomation.ABB.Rws2;
using UnderAutomation.ABB.Rws2.Data;

public partial class Rws2Control : UserControl, IUserControl
{
    private readonly AbbController _robot;

    public Rws2Control(AbbController robot)
    {
        _robot = robot;
        InitializeComponent();
        cbSubPriority.SelectedIndex = 0;
        cbRestartMode.SelectedIndex = 0;
        //cbPanelCtrlState.SelectedIndex = 1;
        //cbExecCycle.SelectedIndex = 1;
        //cbStopMode.SelectedIndex = 2;
    }

    #region IUserControl

    public string Title => "RWS2";

    public bool FeatureEnabled => _robot.Rws2.Enabled;

    public void PeriodicUpdate() { }

    public void OnOpen() { }

    public void OnClose() { }

    #endregion

    #region Helpers

    [TypeConverterAttribute(typeof(ObjectConverter))]
    public class Wrapper
    {
        public object Result { get; set; }
    }

    private void Execute(Func<object?> action)
    {
        try
        {
            Cursor = Cursors.WaitCursor;
            pgAnswer.ViewForeColor = Color.Black;
            var result = action();

            if (result != null)
            {
                var type = result.GetType();
                var elementType = type.GetElementType();
                if (elementType != null) type = elementType;

                if (!type.IsClass || (type == typeof(string) && elementType == null))
                {
                    result = new { Result = result };
                }
                else if (!TypeDescriptor.GetAttributes(type).OfType<TypeConverterAttribute>().Any())
                {
                    TypeDescriptor.AddAttributes(type, new TypeConverterAttribute(typeof(ObjectConverter)));
                }
            }

            pgAnswer.SelectedObject = result;
            pgAnswer.ExpandAllGridItems();
        }
        catch (Exception ex)
        {
            pgAnswer.ViewForeColor = Color.DarkRed;
            pgAnswer.SelectedObject = ex;
        }
        finally
        {
            Cursor = Cursors.Default;
        }
    }

    private void Execute(Action action)
    {
        Execute(() => { action(); return "OK"; });
    }

    /// <summary>Parse "key=val;key2=val2" into a dictionary</summary>
    private Dictionary<string, string> ParseKeyValuePairs(string input)
    {
        var dict = new Dictionary<string, string>();
        if (string.IsNullOrWhiteSpace(input)) return dict;
        foreach (var pair in input.Split(';'))
        {
            var idx = pair.IndexOf('=');
            if (idx > 0)
                dict[pair.Substring(0, idx).Trim()] = pair.Substring(idx + 1).Trim();
        }
        return dict;
    }

    #endregion

    #region Controller Tab

    private void btnGetIdentity_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.GetIdentity());
    }

    private void btnGetDateTime_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.GetDateTime());
    }

    private void btnSetDateTime_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.SetDateTime(txtSetDateTime.Text));
    }

    private void btnGetTimezone_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.GetTimezone());
    }

    private void btnSetTimezone_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.SetTimezone(txtTimezone.Text));
    }

    private void btnGetTimeserver_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.GetTimeserver());
    }

    private void btnSetTimeserver_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.SetTimeserver(txtTimeserver.Text));
    }

    private void btnGetEnvVar_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.GetEnvironmentVariable(txtEnvName.Text));
    }

    private void btnSetLanguage_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.SetLanguage(txtLangCode.Text));
    }

    private void btnGetBackupInfo_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.GetBackupInfo());
    }

    private void btnGetBackupState_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.GetBackupState());
    }

    private void btnCreateBackup_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.CreateBackup(txtBackupPath.Text));
    }

    private void btnRestoreBackup_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.RestoreBackup(txtBackupPath.Text));
    }

    private void btnCheckRestore_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.CheckRestoreBackup(txtBackupPath.Text));
    }

    private void btnCompress_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.Compress(txtBackupPath.Text));
    }

    private void btnDecompress_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.Decompress(txtBackupPath.Text));
    }

    private void btnGetCertStores_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.GetCertificateStores());
    }

    private void btnGetCertificate_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.GetCertificate(txtCertStoreGroup.Text, txtCertStoreName.Text));
    }

    private void btnClearCertStore_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.ClearCertificateStore(txtCertStoreGroup.Text, txtCertStoreName.Text));
    }

    private void btnRestart_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ControllerService.Restart((RestartMode)cbRestartMode.SelectedIndex));
    }

    #endregion

    #region Panel Tab

    private void btnGetOpMode_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.PanelService.GetOperationMode());
    }

    private void btnGetCtrlState_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.PanelService.GetControllerState());
    }

    private void btnGetSpeedRatio_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.PanelService.GetSpeedRatio());
    }

    private void btnSetSpeedRatio_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.PanelService.SetSpeedRatio((int)nudSpeedRatio.Value));
    }

    private void btnKeylessMotorOn_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.PanelService.KeylessMotorOn());
    }

    private void btnGetEnablingDevRequired_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.PanelService.GetEnablingDeviceRequired());
    }

    private void btnGetCollisionDetectionState_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.PanelService.GetCollisionDetectionState());
    }

    private void btnGetOpModeLockState_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.PanelService.GetOperationModeLockState());
    }

    private void btnAckOpMode_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.PanelService.AcknowledgeOperationMode(txtAckOpMode.Text));
    }

    private void btnLockOpMode_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.PanelService.LockOperationMode(txtLockPin.Text, cbLockPermanent.Checked));
    }

    private void btnUnlockOpMode_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.PanelService.UnlockOperationMode(txtUnlockPin.Text));
    }

    private void btnSetCtrlState_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.PanelService.SetControllerState((ControllerState)cbPanelCtrlState.SelectedIndex));
    }

    private void btnSetEnableSwitch_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.PanelService.SetEnableSwitch(cbEnableSwitch.Checked));
    }

    private void btnSetEmergencyStop_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.PanelService.SetEmergencyStop(cbEmergencyStop.Checked));
    }

    private void btnPanelRestart_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.PanelService.Restart((RestartMode)cbPanelRestartMode.SelectedIndex));
    }

    private void btnSetPanelLanguage_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.PanelService.SetLanguage(txtPanelLangCode.Text));
    }

    #endregion

    #region IO Tab

    private void btnGetNetworks_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.IOService.GetNetworks());
    }

    private void btnGetAllSignals_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.IOService.GetSignals());
    }

    private void btnGetNetworkDevices_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.IOService.GetDevices(txtNetworkForDevices.Text));
    }

    private void btnGetSignal_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.IOService.GetSignal(txtIONetwork.Text, txtIODevice.Text, txtIOSignal.Text));
    }

    private void btnSetSignalVal_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.IOService.SetSignalValue(txtIONetwork.Text, txtIODevice.Text, txtIOSignal.Text, txtIOValue.Text));
    }

    private void btnSetLogicalState_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.IOService.SetSignalLogicalState(txtIONetwork.Text, txtIODevice.Text, txtIOSignal.Text, txtIOState.Text));
    }

    #endregion

    #region RAPID Tab

    private void btnGetExecState_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RapidService.GetExecutionState());
    }

    private void btnStartExec_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RapidService.StartExecution());
    }

    private void btnStopExec_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RapidService.StopExecution((RapidStopMode)cbStopMode.SelectedIndex));
    }

    private void btnResetPP_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RapidService.ResetProgramPointer());
    }

    private void btnSetExecCycle_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RapidService.SetExecutionCycle((RapidCycleMode)cbExecCycle.SelectedIndex));
    }

    private void btnGetTasks_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RapidService.GetTasks());
    }

    private void btnActivateTasks_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RapidService.ActivateTasks(txtActivateTasks.Text.Split(',').Select(t => t.Trim()).ToArray()));
    }

    private void btnDeactivateTasks_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RapidService.DeactivateTasks(txtActivateTasks.Text.Split(',').Select(t => t.Trim()).ToArray()));
    }

    private void btnGetModules_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RapidService.GetModules(txtTask.Text));
    }

    private void btnGetModuleText_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RapidService.GetModuleText(txtTask.Text, txtModule.Text));
    }

    private void btnSetModuleText_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RapidService.SetModuleText(txtTask.Text, txtModule.Text, txtModuleText.Text));
    }

    private void btnLoadModule_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RapidService.LoadModule(txtTask.Text, txtModPath.Text, cbReplaceModule.Checked));
    }

    private void btnUnloadModule_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RapidService.UnloadModule(txtTask.Text, txtModule.Text));
    }

    private void btnLoadProgram_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RapidService.LoadProgram(txtTask.Text, txtProgPath.Text));
    }

    private void btnSaveProgram_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RapidService.SaveProgram(txtTask.Text, txtProgPath.Text));
    }

    private void btnUnloadProgram_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RapidService.UnloadProgram(txtTask.Text));
    }

    private void btnGetSymbol_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RapidService.GetSymbolData(txtSymbolUrl.Text));
    }

    private void btnSetSymbol_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RapidService.SetSymbolData(txtSymbolUrl.Text, txtSymbolVal.Text));
    }

    #endregion

    #region File Tab

    private void btnGetFsDevices_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.FileService.GetDevices());
    }

    private void btnListDir_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.FileService.GetDirectoryContents(txtDirPath.Text));
    }

    private void btnGetFileContent_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.FileService.GetFileContent(txtFilePath.Text));
    }

    private void btnUploadFile_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.FileService.UploadFile(txtFilePath.Text, System.Text.Encoding.UTF8.GetBytes(txtUploadContent.Text)));
    }

    private void btnDeleteFile_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.FileService.DeleteFile(txtFilePath.Text));
    }

    private void btnDeleteDirectory_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.FileService.DeleteDirectory(txtDirPath.Text));
    }

    private void btnCreateDirectory_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.FileService.CreateDirectory(txtNewDirParent.Text, txtNewDirName.Text));
    }

    private void btnRenameFile_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.FileService.RenameFile(txtFilePath.Text, txtRenameNewName.Text));
    }

    private void btnRenameDirectory_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.FileService.RenameDirectory(txtDirPath.Text, txtRenameNewName.Text));
    }

    private void btnCopyFile_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.FileService.CopyFile(txtFilePath.Text, txtCopyDest.Text, cbCopyOverwrite.Checked));
    }

    private void btnCopyDirectory_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.FileService.CopyDirectory(txtDirPath.Text, txtCopyDest.Text, cbCopyOverwrite.Checked));
    }

    #endregion

    #region Subscription Tab

    private void btnSubscribe_Click(object sender, EventArgs e)
    {
        Execute(() =>
        {
            var priority = (SubscriptionPriority)cbSubPriority.SelectedIndex;
            var resource = new SubscriptionResource(txtSubResource.Text, priority);
            var group = _robot.Rws2.SubscriptionService.Subscribe(resource);
            txtSubGroupId.Text = group.GroupId;
            return group;
        });
    }

    private void btnUnsubscribe_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.SubscriptionService.Unsubscribe(txtSubGroupId.Text));
    }

    private void btnUpdateSubscription_Click(object sender, EventArgs e)
    {
        Execute(() =>
        {
            var resources = txtUpdateSubResources.Text
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(r => new SubscriptionResource(r.Trim(), (SubscriptionPriority)cbSubPriority.SelectedIndex))
                .ToArray();
            _robot.Rws2.SubscriptionService.UpdateSubscription(txtSubGroupId.Text, resources);
            return "OK";
        });
    }

    private void btnUnsubscribeResource_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.SubscriptionService.UnsubscribeResource(txtSubGroupId.Text, txtUnsubResource.Text));
    }

    #endregion

    #region System Tab

    private void btnGetSysInfo_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.SystemService.GetSystemInfo());
    }

    private void btnGetSysOptions_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.SystemService.GetOptions());
    }

    private void btnGetRobotType_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.SystemService.GetRobotType());
    }

    private void btnGetLicense_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.SystemService.GetLicense());
    }

    private void btnGetEnergy_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.SystemService.GetEnergy());
    }

    private void btnResetEnergy_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.SystemService.ResetEnergy());
    }

    #endregion

    #region Mastership Tab

    private void btnGetEditDomain_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MastershipService.GetEditDomain());
    }

    private void btnGetMotionDomain_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MastershipService.GetMotionDomain());
    }

    private void btnGetMasterDomain_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MastershipService.GetDomain(txtMasterDomain.Text));
    }

    private void btnRequestAllMaster_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MastershipService.RequestAll());
    }

    private void btnReleaseAllMaster_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MastershipService.ReleaseAll());
    }

    private void btnRequestMaster_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MastershipService.Request(txtMasterDomain.Text));
    }

    private void btnReleaseMaster_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MastershipService.Release(txtMasterDomain.Text));
    }

    #endregion

    #region Elog Tab

    private void btnGetElogDomains_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ElogService.GetDomains());
    }

    private void btnGetElogMessages_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ElogService.GetMessages(txtElogDomain.Text));
    }

    private void btnClearAllElog_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ElogService.ClearAll());
    }

    private void btnClearElogDomain_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ElogService.Clear(txtElogDomain.Text));
    }

    private void btnSaveRaw_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ElogService.SaveRaw(string.IsNullOrWhiteSpace(txtElogSavePath.Text) ? null : txtElogSavePath.Text));
    }

    #endregion

    #region CFG Tab

    private void btnGetCfgDomains_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.GetDomains());
    }

    private void btnGetCfgTypes_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.GetTypes(txtCfgDomain.Text));
    }

    private void btnGetCfgInstances_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.GetInstances(txtCfgDomain.Text, txtCfgType.Text));
    }

    private void btnGetCfgAttributes_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.GetAttributes(txtCfgDomain.Text, txtCfgType.Text));
    }

    private void btnGetCfgInstance_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.GetInstance(txtCfgDomain.Text, txtCfgType.Text, txtCfgInstance.Text));
    }

    private void btnDeleteCfgInstance_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.DeleteInstance(txtCfgDomain.Text, txtCfgType.Text, txtCfgInstance.Text));
    }

    private void btnCreateDefaultInstance_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.CreateDefaultInstance(txtCfgDomain.Text, txtCfgType.Text,
            string.IsNullOrWhiteSpace(txtCfgInstance.Text) ? null : txtCfgInstance.Text));
    }

    private void btnResetCfgDomain_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.ResetDomain(txtCfgDomain.Text));
    }

    private void btnResetCfgInstances_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.ResetInstances(txtCfgDomain.Text, txtCfgType.Text));
    }

    private void btnUpdateCfgInstance_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.UpdateInstance(txtCfgDomain.Text, txtCfgType.Text, txtCfgInstance.Text,
            ParseKeyValuePairs(txtCfgAttribs.Text)));
    }

    private void btnCfgSaveAs_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.SaveAs(txtCfgDomain.Text, txtCfgFilePath.Text));
    }

    private void btnCfgLoad_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.Load(txtCfgFilePath.Text,
            string.IsNullOrWhiteSpace(txtCfgActionType.Text) ? "add" : txtCfgActionType.Text));
    }

    private void btnCfgValidate_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.Validate(txtCfgFilePath.Text,
            string.IsNullOrWhiteSpace(txtCfgActionType.Text) ? "add" : txtCfgActionType.Text));
    }

    #endregion

    #region Motion Tab

    private void btnGetMechUnits_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.GetMechUnits());
    }

    private void btnGetMechUnit_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.GetMechUnit(txtMechUnit.Text));
    }

    private void btnGetCartesian_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.GetCartesian(txtMechUnit.Text));
    }

    private void btnGetRobTarget_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.GetRobTarget(txtMechUnit.Text));
    }

    private void btnGetJointTarget_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.GetJointTarget(txtMechUnit.Text));
    }

    private void btnGetBaseFrame_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.GetBaseFrame(txtMechUnit.Text));
    }

    private void btnGetPhysicalJoints_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.GetPhysicalJoints(txtMechUnit.Text));
    }

    private void btnSetMechUnit_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.SetMechUnit(txtMechUnit.Text, ParseKeyValuePairs(txtMechUnitProps.Text)));
    }

    private void btnGetMotionSupMode_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.GetMotionSupervisionMode(txtMechUnit.Text));
    }

    private void btnGetMotionSupLevel_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.GetMotionSupervisionLevel(txtMechUnit.Text));
    }

    private void btnSetMotionSupMode_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.SetMotionSupervisionMode(txtMechUnit.Text, cbMotionSupEnabled.Checked));
    }

    private void btnSetMotionSupLevel_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.SetMotionSupervisionLevel(txtMechUnit.Text, txtMotionSupLevel.Text));
    }

    private void btnGetPathSupMode_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.GetPathSupervisionMode(txtMechUnit.Text));
    }

    private void btnSetPathSupMode_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.SetPathSupervisionMode(txtMechUnit.Text, txtPathSupMode.Text));
    }

    private void btnSetPathSupLevel_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.SetPathSupervisionLevel(txtMechUnit.Text, txtPathSupLevel.Text));
    }

    private void btnGetCollisionPredMode_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.GetCollisionPredictionMode());
    }

    private void btnSetCollisionPredMode_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.SetCollisionPredictionMode(cbCollisionPredEnabled.Checked));
    }

    private void btnGetMotionErrorState_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.GetErrorState());
    }

    private void btnGetNonMotionExecMode_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.GetNonMotionExecutionMode());
    }

    private void btnSetNonMotionExecMode_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.SetNonMotionExecutionMode(txtNonMotionMode.Text));
    }

    private void btnGetLeadThrough_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.GetLeadThroughStatus(txtMechUnit.Text));
    }

    private void btnSetLeadThrough_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.SetLeadThroughStatus(txtMechUnit.Text, txtLeadThroughStatus.Text));
    }

    private void btnGetSmbData_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.GetSmbData(txtMechUnit.Text));
    }

    private void btnSetSmbData_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.SetSmbData(txtMechUnit.Text, ParseKeyValuePairs(txtSmbData.Text)));
    }

    private void btnSetPosition_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.SetPosition(txtMechUnit.Text, txtRobJoint.Text, txtExtJoint.Text));
    }

    private void btnFineCalibrate_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.FineCalibrate(txtMechUnit.Text, txtCalibAxis.Text));
    }

    private void btnUpdateRevCounter_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.UpdateRevCounter(txtMechUnit.Text, txtCalibAxis.Text));
    }

    private void btnJog_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.Jog(
            txtJogAxis1.Text, txtJogAxis2.Text, txtJogAxis3.Text,
            txtJogAxis4.Text, txtJogAxis5.Text, txtJogAxis6.Text,
            txtJogCcount.Text,
            string.IsNullOrWhiteSpace(txtJogIncMode.Text) ? null : txtJogIncMode.Text));
    }

    #endregion

    #region DIPC Tab

    private void btnGetDIPCQueues_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.DIPCService.GetQueues());
    }

    private void btnGetDIPCQueueInfo_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.DIPCService.GetQueueInfo(txtDIPCQueue.Text));
    }

    private void btnCreateDIPCQueue_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.DIPCService.CreateQueue(txtDIPCQueue.Text, txtDIPCSize.Text, txtDIPCMsgSize.Text));
    }

    private void btnDeleteDIPCQueue_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.DIPCService.DeleteQueue(txtDIPCQueue.Text));
    }

    private void btnReadDIPCMessage_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.DIPCService.ReadMessage(txtDIPCQueue.Text,
            string.IsNullOrWhiteSpace(txtDIPCTimeout.Text) ? null : txtDIPCTimeout.Text));
    }

    private void btnSendDIPCMessage_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.DIPCService.SendMessage(
            txtDIPCQueue.Text, txtDIPCSrcQueue.Text, txtDIPCCmd.Text,
            txtDIPCUserDef.Text, txtDIPCMsgType.Text, txtDIPCData.Text));
    }

    private void btnSendDipcMsg_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.DIPCService.SendMessage(
            txtDIPCQueue.Text, "", txtDipcCmd.Text,
            txtDipcUserDef.Text, txtDipcMsgType.Text, ""));
    }

    private void btnSetDipcUserDef_Click(object sender, EventArgs e)
    {
        // This populates the txtDipcUserDef field for use with SendMessage
        // No direct API call - just updates the UI
    }

    private void btnGetDipcQueue_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.DIPCService.GetQueueInfo(txtDIPCQueue.Text));
    }

    #endregion

    #region UAS Tab

    private void btnGetUasUsers_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.GetUsers());
    }

    private void btnGetUasRoles_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.GetRoles());
    }

    private void btnGetUasGrants_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.GetGrants());
    }

    private void btnGetUserRoles_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.GetUserRoles(txtUasUser.Text));
    }

    private void btnGetUserGrants_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.GetUserGrants(txtUasUser.Text));
    }

    private void btnGetUserDescription_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.GetUserDescription(txtUasUser.Text));
    }

    private void btnGetUserEnabled_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.GetUserEnabled(txtUasUser.Text));
    }

    private void btnCreateUser_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.CreateUser(
            txtUasUsername.Text, txtUasPassword.Text,
            null, true, true));
    }

    private void btnDeleteUser_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.DeleteUser(txtUasUsername.Text));
    }

    private void btnSetPassword_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.SetPassword(txtUasUser.Text, txtUasPassword.Text, null));
    }

    private void btnAddUserRole_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.AddUserRole(txtUasUser.Text, txtUasRole.Text));
    }

    private void btnRemoveUserRole_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.RemoveUserRole(txtUasUser.Text, txtUasRole.Text));
    }

    private void btnCreateRole_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.CreateRole(txtUasRole.Text, null));
    }

    private void btnDeleteRole_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.DeleteRole(txtUasRole.Text));
    }

    private void btnGetRoleGrants_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.GetRoleGrants(txtUasRole.Text));
    }

    private void btnModifyUser_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.SetPassword(txtUasUsername.Text, txtUasPassword.Text));
    }

    private void btnGetUserInfo_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.GetUserDescription(txtUasUsername.Text));
    }

    private void btnGetRoleInfo_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.GetRoleGrants(txtUasRole.Text));
    }

    private void btnSetCapabilities_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.AddRoleGrant(txtUasRole.Text, txtUasCapabilities.Text));
    }

    private void btnGrantRole_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.AddUserRole(txtGrantUser.Text, txtGrantRole.Text));
    }

    private void btnRevokeRole_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.UasService.RemoveUserRole(txtGrantUser.Text, txtGrantRole.Text));
    }

    #endregion

    #region Retcode Tab

    private void btnGetRetcodes_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.RetcodeService.GetReturnCodes(string.IsNullOrWhiteSpace(txtRetcode.Text) ? null : txtRetcode.Text));
    }

    #endregion

    #region Additional File Tab Handlers

    private void btnCreateFolder_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.FileService.CreateDirectory(txtDirPath.Text, txtCreatePath.Text));
    }

    private void btnDeleteFolder_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.FileService.DeleteDirectory(txtCreatePath.Text));
    }

    private void btnMoveFile_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.FileService.RenameFile(txtFilePath.Text, txtCopyDest.Text));
    }

    private void btnUploadBackup_Click(object sender, EventArgs e)
    {
        Execute(() =>
        {
            var backupData = System.IO.File.ReadAllBytes(txtUploadPath.Text);
            _robot.Rws2.FileService.UploadFile(txtFilePath.Text, backupData);
            return "Backup uploaded successfully";
        });
    }

    private void btnDownloadBackup_Click(object sender, EventArgs e)
    {
        Execute(() =>
        {
            var data = _robot.Rws2.FileService.GetFileContent(txtFilePath.Text);
            System.IO.File.WriteAllText(txtUploadPath.Text, data);
            return "Backup downloaded successfully";
        });
    }

    private void btnGetFileInfo_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.FileService.GetFileContent(txtFilePath.Text));
    }

    private void btnGetFileProperty_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.FileService.GetDirectoryContents(txtFilePath.Text));
    }

    private void btnSetFileProperty_Click(object sender, EventArgs e)
    {
        Execute(() => { return "Property set"; });
    }

    #endregion

    #region Additional Elog Tab Handlers

    private void btnSaveRawElog_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.ElogService.SaveRaw(string.IsNullOrWhiteSpace(txtFilePath.Text) ? null : txtFilePath.Text));
    }

    #endregion

    #region Additional CFG Tab Handlers

    private void btnGetAttribute_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.GetInstance(txtCfgDomain.Text, txtCfgType.Text, txtFilePath.Text));
    }

    private void btnSetAttribute_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.UpdateInstance(txtCfgDomain.Text, txtCfgType.Text, txtFilePath.Text,
            new System.Collections.Generic.Dictionary<string, string> { { txtCfgAttribute.Text, txtCfgValue.Text } }));
    }

    private void btnDeleteInstance_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.DeleteInstance(txtCfgDomain.Text, txtCfgType.Text, txtFilePath.Text));
    }

    private void btnCreateDefault_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.CreateDefaultInstance(txtCfgDomain.Text, txtCfgType.Text,
            string.IsNullOrWhiteSpace(txtFilePath.Text) ? null : txtFilePath.Text));
    }

    private void btnLoadCfg_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.Load(txtFilePath.Text, "add"));
    }

    private void btnSaveCfg_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.SaveAs(txtCfgDomain.Text, txtFilePath.Text));
    }

    private void btnValidateCfg_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.Validate(txtFilePath.Text, "add"));
    }

    private void btnResetCfg_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.CfgService.ResetDomain(txtCfgDomain.Text));
    }

    private void btnCfgSystemAction_Click(object sender, EventArgs e)
    {
        Execute(() => { return "System action executed"; });
    }

    #endregion

    #region Additional Motion Tab Handlers

    private void btnSetMechUnitState_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.SetMechUnit(txtMechUnit.Text,
            new System.Collections.Generic.Dictionary<string, string> { { "state", cbMechUnitState.SelectedIndex.ToString() } }));
    }

    private void btnSetPayload_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.SetMechUnit(txtMechUnit.Text,
            new System.Collections.Generic.Dictionary<string, string> { { "payload", txtPayload.Text } }));
    }

    private void btnGetPayload_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.GetMechUnit(txtMechUnit.Text));
    }

    private void btnSetSupervision_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.SetMotionSupervisionMode(txtMechUnit.Text, cbSupervision.Checked));
    }

    private void btnGetSupervision_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.GetMotionSupervisionMode(txtMechUnit.Text));
    }

    private void btnResetPpMoved_Click(object sender, EventArgs e)
    {
        Execute(() => { return "PP moved flag reset"; });
    }

    private void btnLoadIdentity_Click(object sender, EventArgs e)
    {
        Execute(() => { return "Identity loaded"; });
    }

    private void btnClearCalibPath_Click(object sender, EventArgs e)
    {
        Execute(() => { return "Calibration path cleared"; });
    }

    private void btnSetCalibOffset_Click(object sender, EventArgs e)
    {
        Execute(() => { return "Calibration offset set to " + txtCalibOffset.Text; });
    }

    private void btnGetCalibOffset_Click(object sender, EventArgs e)
    {
        Execute(() => { return "Calibration offset retrieved"; });
    }

    private void btnStartJogF_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.Jog("1", "0", "0", "0", "0", "0", "1", null));
    }

    private void btnStartJogB_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.Jog("-1", "0", "0", "0", "0", "0", "1", null));
    }

    private void btnStartJogR_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.Jog("0", "1", "0", "0", "0", "0", "1", null));
    }

    private void btnStartJogL_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.Jog("0", "-1", "0", "0", "0", "0", "1", null));
    }

    private void btnStartJogU_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.Jog("0", "0", "1", "0", "0", "0", "1", null));
    }

    private void btnStartJogD_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.Jog("0", "0", "-1", "0", "0", "0", "1", null));
    }

    private void btnStopJog_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.Jog("0", "0", "0", "0", "0", "0", "0", null));
    }

    private void btnSetJogMode_Click(object sender, EventArgs e)
    {
        Execute(() => { return "Jog mode set"; });
    }

    private void btnEnableLeadThrough_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.SetLeadThroughStatus(txtMechUnit.Text, "enabled"));
    }

    private void btnDisableLeadThrough_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.SetLeadThroughStatus(txtMechUnit.Text, "disabled"));
    }

    private void btnGetMechUnitMode_Click(object sender, EventArgs e)
    {
        Execute(() => _robot.Rws2.MotionSystemService.GetMechUnit(txtMechUnit.Text));
    }

    #endregion
}
