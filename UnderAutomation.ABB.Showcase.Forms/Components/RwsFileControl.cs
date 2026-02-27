using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using UnderAutomation.ABB;
using UnderAutomation.ABB.Rws.Data;

public partial class RwsFileControl : UserControl, IUserControl
{
    private AbbController _robot;
    private FileSystemItem _copiedItem;
    private string _copiedItemSourcePath;

    public RwsFileControl(AbbController robot)
    {
        TypeDescriptor.AddAttributes(typeof(FileSystemItem), new ReadOnlyAttribute(true));
        _robot = robot;
        InitializeComponent();
    }

    #region IUserControl
    public string Title => "File handling (RWS)";

    public bool FeatureEnabled => _robot?.Rws != null && _robot.Rws.Enabled;

    public void PeriodicUpdate()
    {
        this.Enabled = FeatureEnabled;
    }


    public void OnClose()
    {
        Config.Current.FilePath = txtPath.Text;
        Config.Save();

        lstFolder.Items.Clear();
        gridFile.SelectedObject = null;
    }

    public void OnOpen()
    {
        try
        {
            InitializeFtp();
        }
        catch (Exception)
        {
            Config.Current.FilePath = "/";
            InitializeFtp();
        }
    }
    #endregion

    public void InitializeFtp()
    {
        FillList(Config.Current.FilePath ?? "/");
    }

    // Display directory content in the list view
    private void FillList(string path)
    {
        gridFile.SelectedObject = null;
        lstFolder.Items.Clear();

        if (!FeatureEnabled) return;

        path = path.Replace(@"\", "/");
        if (!path.EndsWith("/"))
            path = path + "/";


        var listing = _robot.Rws.File.ListDirectory(path);

        txtPath.Text = listing.Path;

        // Show devices first (only present at root)
        foreach (var device in listing.Devices)
        {
            if (device == null || string.IsNullOrEmpty(device.Name)) continue;
            var itm = lstFolder.Items.Add(device.Name);
            itm.Tag = device;
            itm.ImageKey = "folder";
        }

        // Then directories
        foreach (var dir in listing.Directories)
        {
            if (dir == null || string.IsNullOrEmpty(dir.Name)) continue;
            var itm = lstFolder.Items.Add(dir.Name);
            itm.Tag = dir;
            itm.ImageKey = "folder";
        }

        // Then files
        foreach (var file in listing.Files)
        {
            if (file == null || string.IsNullOrEmpty(file.Name)) continue;
            var itm = lstFolder.Items.Add(file.Name);
            itm.Tag = file;
            itm.ImageKey = "file";
        }

        if (new[] { "", "/", "\\" }.Contains(path))
        {
            foreach (var envVar in new[] { "$home", "$temp" })
            {
                var itm = lstFolder.Items.Add(envVar);
                itm.Tag = new DirectoryItem() { Name = envVar, IsReadOnly = true };
                itm.ImageKey = "folder";
            }
        }

        UpdateCopyPasteButtons();
    }

    // Open directory after double click
    private void lstFolder_ItemActivate(object sender, EventArgs e)
    {
        var entry = lstFolder.SelectedItems?.OfType<ListViewItem>()?.FirstOrDefault()?.Tag as FileSystemItem;

        if (entry == null) return;

        if (entry is DirectoryItem || entry is DeviceItem)
        {
            FillList(CombinePath(GetPath(), entry.Name));
        }
        else
        {
            dlgSave.FileName = entry.Name;
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                var remotePath = CombinePath(GetPath(), entry.Name);
                _robot.Rws.File.GetFileToDestination(remotePath, dlgSave.FileName);
            }
        }
    }

    // Show select item data inside right grid
    private void lstFolder_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
        gridFile.SelectedObject = e.Item?.Tag;
    }
    private void lstFolder_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstFolder.SelectedItems.Count == 0) gridFile.SelectedObject = null;
    }

    // Navigate to parent directory
    private void btnPrevious_Click(object sender, EventArgs e)
    {
        var p = GetPath().TrimEnd('/');
        if (p == "") return;
        FillList(Path.GetDirectoryName(p));
    }

    // Refresh current directory
    private void btnOpenPath_Click(object sender, EventArgs e)
    {
        if (e is KeyEventArgs && ((KeyEventArgs)e).KeyCode != Keys.Enter) return;
        ReloadList();
    }
    private void ReloadList()
    {
        FillList(GetPath());
        gridFile.SelectedObject = null;
    }

    // Delete an element
    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Do you really want to delete selected item ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

        if (!FeatureEnabled) return;

        foreach (var itm in lstFolder.SelectedItems.OfType<ListViewItem>())
        {
            var entry = itm.Tag as FileSystemItem;

            if (entry == null) return;

            if (entry is DirectoryItem || entry is DeviceItem)
            {
                _robot.Rws.File.DeleteDirectory(CombinePath(GetPath(), entry.Name));
            }
            else
            {
                _robot.Rws.File.DeleteFile(CombinePath(GetPath(), entry.Name));
            }
            Thread.Sleep(500);
            ReloadList();
        }
    }

    // Edit item to rename element
    private void btnRename_Click(object sender, EventArgs e)
    {
        lstFolder.SelectedItems?.OfType<ListViewItem>()?.FirstOrDefault()?.BeginEdit();
    }

    // Send file to the robot and refresh list
    private void btnUpload_Click(object sender, EventArgs e)
    {
        if (!FeatureEnabled) return;

        if (dlgOpen.ShowDialog() != DialogResult.OK) return;

        var localPath = dlgOpen.FileName;
        var remotePath = CombinePath(GetPath(), Path.GetFileName(localPath));
        _robot.Rws.File.UploadFileFromPath(remotePath, localPath);

        Thread.Sleep(500);
        ReloadList();
        SelectFile(Path.GetFileName(localPath));
    }

    // Get current directory path
    private string GetPath()
    {
        if (!txtPath.Text.EndsWith("/")) return txtPath.Text + "/";
        return txtPath.Text;
    }

    // Select a file in list view by its name
    private void SelectFile(string name)
    {
        var itm = lstFolder.Items.OfType<ListViewItem>().FirstOrDefault(x => string.Equals(x.Text, name, StringComparison.InvariantCultureIgnoreCase));
        if (itm != null) itm.Selected = true;
    }

    // Save remote file to local computer
    private void btnDownload_Click(object sender, EventArgs e)
    {
        if (!FeatureEnabled) return;

        var entry = lstFolder.SelectedItems?.OfType<ListViewItem>()?.FirstOrDefault()?.Tag as FileSystemItem;
        if (entry == null || !(entry is FileItem)) return;

        dlgSave.FileName = entry.Name;
        if (dlgSave.ShowDialog() != DialogResult.OK) return;

        var remotePath = CombinePath(GetPath(), entry.Name);
        _robot.Rws.File.GetFileToDestination(remotePath, dlgSave.FileName);
    }

    // Perform renaming or directory creation
    private void lstFolder_AfterLabelEdit(object sender, LabelEditEventArgs e)
    {
        if (!FeatureEnabled) return;

        try
        {
            if (e.Label == null)
                return;

            var entry = lstFolder.Items[e.Item].Tag as FileSystemItem;
            if (entry == null)
            {
                // if it is a directory creation
                _robot.Rws.File.CreateDirectory(GetPath(), e.Label);
            }
            else if (entry is DirectoryItem || entry is DeviceItem)
            {
                _robot.Rws.File.RenameDirectory(CombinePath(GetPath(), entry.Name), e.Label);
            }
            else
            {
                _robot.Rws.File.RenameFile(CombinePath(GetPath(), entry.Name), e.Label);
            }
        }
        finally
        {
            e.CancelEdit = true;
            Thread.Sleep(500);
            ReloadList();
            SelectFile(e.Label);
        }
    }


    private void btnNewFolder_Click(object sender, EventArgs e)
    {
        if (!FeatureEnabled) return;
        lstFolder.Items.Add("new directory", "folder").BeginEdit();
    }

    private void gridFile_SelectedObjectsChanged(object sender, EventArgs e)
    {
        var selected = gridFile.SelectedObject as FileSystemItem;

        btnDownload.Enabled = selected is FileItem;
        btnRename.Enabled = selected != null;
        btnDelete.Enabled = selected != null;

        // Copy: enabled only for files/directories whose name doesn't start with $
        bool canCopy = (selected is FileItem || selected is DirectoryItem)
            && selected.Name != null
            && !selected.Name.StartsWith("$");
        btnCopy.Enabled = canCopy;

        UpdateCopyPasteButtons();
    }

    private bool IsRootPath(string path)
    {
        return string.IsNullOrEmpty(path)
            || path == "/"
            || path == "\\"
            || path == ".";
    }

    private void UpdateCopyPasteButtons()
    {
        // Paste: enabled only if an item has been copied, we're not at root, and we're not in the same folder as the source
        var currentPath = GetPath().TrimEnd('/');
        bool hasCopiedItem = _copiedItem != null;
        bool isRoot = IsRootPath(currentPath);
        bool isSameFolder = false;

        if (hasCopiedItem && !string.IsNullOrEmpty(_copiedItemSourcePath))
        {
            // Extract source folder from copied item full path
            var sourceFolder = _copiedItemSourcePath.TrimEnd('/');
            int lastSlash = sourceFolder.LastIndexOf('/');
            if (lastSlash >= 0)
                sourceFolder = sourceFolder.Substring(0, lastSlash);

            isSameFolder = string.Equals(currentPath, sourceFolder, StringComparison.OrdinalIgnoreCase);
        }

        btnPaste.Enabled = hasCopiedItem && !isRoot && !isSameFolder;
    }

    private static string CombinePath(string basePath, string relativePath)
    {
        if (string.IsNullOrEmpty(basePath)) return relativePath ?? string.Empty;
        if (string.IsNullOrEmpty(relativePath)) return basePath;

        basePath = basePath.Replace(@"\", "/").TrimEnd('/');
        relativePath = relativePath.Replace(@"\", "/").TrimStart('/');

        return basePath + "/" + relativePath;
    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
        var entry = lstFolder.SelectedItems?.OfType<ListViewItem>()?.FirstOrDefault()?.Tag as FileSystemItem;
        if (entry == null) return;

        _copiedItem = entry;
        _copiedItemSourcePath = CombinePath(GetPath(), entry.Name);
        UpdateCopyPasteButtons();
    }

    private void btnPaste_Click(object sender, EventArgs e)
    {
        if (!FeatureEnabled || _copiedItem == null) return;

        var destinationPath = CombinePath(GetPath(), _copiedItem.Name);

        if (_copiedItem is DirectoryItem)
        {
            _robot.Rws.File.CopyDirectory(_copiedItemSourcePath, destinationPath, true);
        }
        else if (_copiedItem is FileItem)
        {
            _robot.Rws.File.CopyFile(_copiedItemSourcePath, destinationPath, true);
        }

        ReloadList();
        SelectFile(_copiedItem.Name);
    }
}
