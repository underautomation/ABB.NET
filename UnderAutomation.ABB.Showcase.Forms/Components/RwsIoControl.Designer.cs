
    partial class RwsIoControl
{
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RwsControllerControl));
        lstFolderImageList = new ImageList(components);
        dlgOpen = new OpenFileDialog();
        dlgSave = new SaveFileDialog();
        SuspendLayout();
        // 
        // lstFolderImageList
        // 
        lstFolderImageList.ColorDepth = ColorDepth.Depth8Bit;
        lstFolderImageList.ImageStream = (ImageListStreamer)resources.GetObject("lstFolderImageList.ImageStream");
        lstFolderImageList.TransparentColor = Color.Transparent;
        lstFolderImageList.Images.SetKeyName(0, "folder");
        lstFolderImageList.Images.SetKeyName(1, "file");
        lstFolderImageList.Images.SetKeyName(2, "symbolicLink");
        // 
        // dlgOpen
        // 
        dlgOpen.Filter = "All files|*.*";
        dlgOpen.Title = "Select file to upload";
        // 
        // dlgSave
        // 
        dlgSave.Filter = "All files|*.*";
        dlgSave.RestoreDirectory = true;
        dlgSave.Title = "Download file";
        // 
        // RwsControllerControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Margin = new Padding(4, 3, 4, 3);
        Name = "RwsControllerControl";
        Size = new Size(818, 764);
        ResumeLayout(false);
    }

    #endregion
    internal System.Windows.Forms.OpenFileDialog dlgOpen;
    internal System.Windows.Forms.SaveFileDialog dlgSave;
    internal System.Windows.Forms.ImageList lstFolderImageList;
}
