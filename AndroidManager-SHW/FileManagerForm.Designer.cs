namespace AndroidManager_SHW
{
    partial class FileManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManagerForm));
            this.panel_TreeSideBar = new System.Windows.Forms.Panel();
            this.treeView_dir = new System.Windows.Forms.TreeView();
            this.imageList_tools = new System.Windows.Forms.ImageList(this.components);
            this.panel_leftSideBar = new System.Windows.Forms.Panel();
            this.panel_fillRightSideBar = new System.Windows.Forms.Panel();
            this.listView_files = new System.Windows.Forms.ListView();
            this.contextMenuStrip_ListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList_iconFile = new System.Windows.Forms.ImageList(this.components);
            this.panel_rightSideBarProgress = new System.Windows.Forms.Panel();
            this.progressBar_transfer = new System.Windows.Forms.ProgressBar();
            this.panel_rightSideBarDown = new System.Windows.Forms.Panel();
            this.label_type = new System.Windows.Forms.Label();
            this.label_size = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.panel_rightSideBarUp = new System.Windows.Forms.Panel();
            this.toolStrip_upMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_collapseExpand = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_ParentDirectory = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_forwardDirectory = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox_path = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton_goPath = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker_getSize = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_backup = new System.ComponentModel.BackgroundWorker();
            this.label_countFiles = new System.Windows.Forms.Label();
            this.backgroundWorker_getCountFiles = new System.ComponentModel.BackgroundWorker();
            this.panel_TreeSideBar.SuspendLayout();
            this.panel_leftSideBar.SuspendLayout();
            this.panel_fillRightSideBar.SuspendLayout();
            this.contextMenuStrip_ListView.SuspendLayout();
            this.panel_rightSideBarProgress.SuspendLayout();
            this.panel_rightSideBarDown.SuspendLayout();
            this.panel_rightSideBarUp.SuspendLayout();
            this.toolStrip_upMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_TreeSideBar
            // 
            this.panel_TreeSideBar.Controls.Add(this.treeView_dir);
            this.panel_TreeSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_TreeSideBar.Location = new System.Drawing.Point(0, 0);
            this.panel_TreeSideBar.Name = "panel_TreeSideBar";
            this.panel_TreeSideBar.Size = new System.Drawing.Size(247, 653);
            this.panel_TreeSideBar.TabIndex = 0;
            // 
            // treeView_dir
            // 
            this.treeView_dir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.treeView_dir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_dir.ImageIndex = 0;
            this.treeView_dir.ImageList = this.imageList_tools;
            this.treeView_dir.Location = new System.Drawing.Point(0, 0);
            this.treeView_dir.Name = "treeView_dir";
            this.treeView_dir.SelectedImageIndex = 0;
            this.treeView_dir.Size = new System.Drawing.Size(247, 653);
            this.treeView_dir.TabIndex = 0;
            this.treeView_dir.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_dir_AfterSelect);
            this.treeView_dir.DoubleClick += new System.EventHandler(this.treeView_dir_DoubleClick);
            // 
            // imageList_tools
            // 
            this.imageList_tools.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_tools.ImageStream")));
            this.imageList_tools.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_tools.Images.SetKeyName(0, "Home.png");
            this.imageList_tools.Images.SetKeyName(1, "drive.png");
            this.imageList_tools.Images.SetKeyName(2, "folder.png");
            this.imageList_tools.Images.SetKeyName(3, "desktop.png");
            this.imageList_tools.Images.SetKeyName(4, "Flag.png");
            // 
            // panel_leftSideBar
            // 
            this.panel_leftSideBar.Controls.Add(this.panel_fillRightSideBar);
            this.panel_leftSideBar.Controls.Add(this.panel_rightSideBarProgress);
            this.panel_leftSideBar.Controls.Add(this.panel_rightSideBarDown);
            this.panel_leftSideBar.Controls.Add(this.panel_rightSideBarUp);
            this.panel_leftSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_leftSideBar.Location = new System.Drawing.Point(247, 0);
            this.panel_leftSideBar.Name = "panel_leftSideBar";
            this.panel_leftSideBar.Size = new System.Drawing.Size(635, 653);
            this.panel_leftSideBar.TabIndex = 1;
            // 
            // panel_fillRightSideBar
            // 
            this.panel_fillRightSideBar.Controls.Add(this.listView_files);
            this.panel_fillRightSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fillRightSideBar.Location = new System.Drawing.Point(0, 57);
            this.panel_fillRightSideBar.Name = "panel_fillRightSideBar";
            this.panel_fillRightSideBar.Size = new System.Drawing.Size(635, 465);
            this.panel_fillRightSideBar.TabIndex = 3;
            // 
            // listView_files
            // 
            this.listView_files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.listView_files.ContextMenuStrip = this.contextMenuStrip_ListView;
            this.listView_files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_files.LargeImageList = this.imageList_iconFile;
            this.listView_files.Location = new System.Drawing.Point(0, 0);
            this.listView_files.Name = "listView_files";
            this.listView_files.Size = new System.Drawing.Size(635, 465);
            this.listView_files.SmallImageList = this.imageList_iconFile;
            this.listView_files.TabIndex = 0;
            this.listView_files.UseCompatibleStateImageBehavior = false;
            this.listView_files.SelectedIndexChanged += new System.EventHandler(this.listView_files_SelectedIndexChanged);
            this.listView_files.DoubleClick += new System.EventHandler(this.listView_files_DoubleClick);
            // 
            // contextMenuStrip_ListView
            // 
            this.contextMenuStrip_ListView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_ListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.newFolderToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip_ListView.Name = "contextMenuStrip_ListView";
            this.contextMenuStrip_ListView.Size = new System.Drawing.Size(157, 148);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Enabled = false;
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.openFolderToolStripMenuItem.Text = "OpenFolder";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.copyToolStripMenuItem.Text = "Copy|Cut";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forCopyToolStripMenuItem,
            this.forCutToolStripMenuItem});
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // forCopyToolStripMenuItem
            // 
            this.forCopyToolStripMenuItem.Name = "forCopyToolStripMenuItem";
            this.forCopyToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.forCopyToolStripMenuItem.Text = "CopyPaste";
            this.forCopyToolStripMenuItem.Click += new System.EventHandler(this.forCopyToolStripMenuItem_Click);
            // 
            // forCutToolStripMenuItem
            // 
            this.forCutToolStripMenuItem.Name = "forCutToolStripMenuItem";
            this.forCutToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.forCutToolStripMenuItem.Text = "CutPaste";
            this.forCutToolStripMenuItem.Click += new System.EventHandler(this.forCutToolStripMenuItem_Click);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.newFolderToolStripMenuItem.Text = "NewFolder";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // imageList_iconFile
            // 
            this.imageList_iconFile.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_iconFile.ImageStream")));
            this.imageList_iconFile.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_iconFile.Images.SetKeyName(0, "drive.png");
            this.imageList_iconFile.Images.SetKeyName(1, "folder.png");
            this.imageList_iconFile.Images.SetKeyName(2, "file.png");
            this.imageList_iconFile.Images.SetKeyName(3, "Music.png");
            this.imageList_iconFile.Images.SetKeyName(4, "exe.png");
            this.imageList_iconFile.Images.SetKeyName(5, "apk.png");
            this.imageList_iconFile.Images.SetKeyName(6, "zip.png");
            this.imageList_iconFile.Images.SetKeyName(7, "Movie.png");
            this.imageList_iconFile.Images.SetKeyName(8, "pdf.png");
            this.imageList_iconFile.Images.SetKeyName(9, "text.png");
            this.imageList_iconFile.Images.SetKeyName(10, "img.png");
            // 
            // panel_rightSideBarProgress
            // 
            this.panel_rightSideBarProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.panel_rightSideBarProgress.Controls.Add(this.progressBar_transfer);
            this.panel_rightSideBarProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_rightSideBarProgress.Location = new System.Drawing.Point(0, 43);
            this.panel_rightSideBarProgress.Name = "panel_rightSideBarProgress";
            this.panel_rightSideBarProgress.Size = new System.Drawing.Size(635, 14);
            this.panel_rightSideBarProgress.TabIndex = 2;
            this.panel_rightSideBarProgress.Visible = false;
            // 
            // progressBar_transfer
            // 
            this.progressBar_transfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar_transfer.Location = new System.Drawing.Point(0, 0);
            this.progressBar_transfer.Name = "progressBar_transfer";
            this.progressBar_transfer.Size = new System.Drawing.Size(635, 14);
            this.progressBar_transfer.TabIndex = 0;
            // 
            // panel_rightSideBarDown
            // 
            this.panel_rightSideBarDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.panel_rightSideBarDown.Controls.Add(this.label_countFiles);
            this.panel_rightSideBarDown.Controls.Add(this.label_type);
            this.panel_rightSideBarDown.Controls.Add(this.label_size);
            this.panel_rightSideBarDown.Controls.Add(this.label_name);
            this.panel_rightSideBarDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_rightSideBarDown.Location = new System.Drawing.Point(0, 522);
            this.panel_rightSideBarDown.Name = "panel_rightSideBarDown";
            this.panel_rightSideBarDown.Size = new System.Drawing.Size(635, 131);
            this.panel_rightSideBarDown.TabIndex = 1;
            // 
            // label_type
            // 
            this.label_type.Location = new System.Drawing.Point(19, 86);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(173, 23);
            this.label_type.TabIndex = 0;
            this.label_type.Text = "Type: ";
            // 
            // label_size
            // 
            this.label_size.Location = new System.Drawing.Point(19, 51);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(564, 23);
            this.label_size.TabIndex = 0;
            this.label_size.Text = "Size: ";
            // 
            // label_name
            // 
            this.label_name.Location = new System.Drawing.Point(19, 16);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(604, 23);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name:";
            // 
            // panel_rightSideBarUp
            // 
            this.panel_rightSideBarUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel_rightSideBarUp.Controls.Add(this.toolStrip_upMain);
            this.panel_rightSideBarUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_rightSideBarUp.Location = new System.Drawing.Point(0, 0);
            this.panel_rightSideBarUp.Name = "panel_rightSideBarUp";
            this.panel_rightSideBarUp.Size = new System.Drawing.Size(635, 43);
            this.panel_rightSideBarUp.TabIndex = 0;
            // 
            // toolStrip_upMain
            // 
            this.toolStrip_upMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.toolStrip_upMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip_upMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_upMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_collapseExpand,
            this.toolStripSeparator3,
            this.toolStripButton_ParentDirectory,
            this.toolStripButton_forwardDirectory,
            this.toolStripSeparator1,
            this.toolStripTextBox_path,
            this.toolStripButton_goPath});
            this.toolStrip_upMain.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_upMain.Name = "toolStrip_upMain";
            this.toolStrip_upMain.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStrip_upMain.Size = new System.Drawing.Size(635, 43);
            this.toolStrip_upMain.TabIndex = 2;
            this.toolStrip_upMain.Text = "Go";
            // 
            // toolStripButton_collapseExpand
            // 
            this.toolStripButton_collapseExpand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_collapseExpand.Image = global::AndroidManager_SHW.Properties.Resources.collapse;
            this.toolStripButton_collapseExpand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_collapseExpand.Name = "toolStripButton_collapseExpand";
            this.toolStripButton_collapseExpand.Size = new System.Drawing.Size(24, 40);
            this.toolStripButton_collapseExpand.Text = "Expand/Collapse";
            this.toolStripButton_collapseExpand.Click += new System.EventHandler(this.toolStripButton_collapseExpand_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripButton_ParentDirectory
            // 
            this.toolStripButton_ParentDirectory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ParentDirectory.Image = global::AndroidManager_SHW.Properties.Resources.Back;
            this.toolStripButton_ParentDirectory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ParentDirectory.Name = "toolStripButton_ParentDirectory";
            this.toolStripButton_ParentDirectory.Size = new System.Drawing.Size(24, 40);
            this.toolStripButton_ParentDirectory.Text = "Go Parent Path";
            this.toolStripButton_ParentDirectory.Click += new System.EventHandler(this.toolStripButton_ParentDirectory_Click);
            // 
            // toolStripButton_forwardDirectory
            // 
            this.toolStripButton_forwardDirectory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_forwardDirectory.Image = global::AndroidManager_SHW.Properties.Resources.Next;
            this.toolStripButton_forwardDirectory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_forwardDirectory.Name = "toolStripButton_forwardDirectory";
            this.toolStripButton_forwardDirectory.Size = new System.Drawing.Size(24, 40);
            this.toolStripButton_forwardDirectory.Text = "Go Last Path";
            this.toolStripButton_forwardDirectory.Click += new System.EventHandler(this.toolStripButton_forwardDirectory_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripTextBox_path
            // 
            this.toolStripTextBox_path.Name = "toolStripTextBox_path";
            this.toolStripTextBox_path.Size = new System.Drawing.Size(300, 43);
            // 
            // toolStripButton_goPath
            // 
            this.toolStripButton_goPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_goPath.Image = global::AndroidManager_SHW.Properties.Resources.Go;
            this.toolStripButton_goPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_goPath.Name = "toolStripButton_goPath";
            this.toolStripButton_goPath.Size = new System.Drawing.Size(24, 40);
            this.toolStripButton_goPath.Text = "Go/Refresh";
            this.toolStripButton_goPath.Click += new System.EventHandler(this.toolStripButton_goPath_Click);
            // 
            // backgroundWorker_getSize
            // 
            this.backgroundWorker_getSize.WorkerSupportsCancellation = true;
            this.backgroundWorker_getSize.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_getSize_DoWork);
            this.backgroundWorker_getSize.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_getSize_RunWorkerCompleted);
            // 
            // backgroundWorker_backup
            // 
            this.backgroundWorker_backup.WorkerReportsProgress = true;
            this.backgroundWorker_backup.WorkerSupportsCancellation = true;
            this.backgroundWorker_backup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_backup_DoWork);
            this.backgroundWorker_backup.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_backup_ProgressChanged);
            this.backgroundWorker_backup.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_backup_RunWorkerCompleted);
            // 
            // label_countFiles
            // 
            this.label_countFiles.Location = new System.Drawing.Point(198, 86);
            this.label_countFiles.Name = "label_countFiles";
            this.label_countFiles.Size = new System.Drawing.Size(167, 23);
            this.label_countFiles.TabIndex = 0;
            this.label_countFiles.Text = "Count: ";
            this.label_countFiles.Visible = false;
            // 
            // backgroundWorker_getCountFiles
            // 
            this.backgroundWorker_getCountFiles.WorkerSupportsCancellation = true;
            this.backgroundWorker_getCountFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_getCountFiles_DoWork);
            this.backgroundWorker_getCountFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_getCountFiles_RunWorkerCompleted);
            // 
            // FileManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.panel_leftSideBar);
            this.Controls.Add(this.panel_TreeSideBar);
            this.MinimumSize = new System.Drawing.Size(870, 400);
            this.Name = "FileManagerForm";
            this.Text = "FileManagerForm";
            this.Load += new System.EventHandler(this.FileManagerForm_Load);
            this.panel_TreeSideBar.ResumeLayout(false);
            this.panel_leftSideBar.ResumeLayout(false);
            this.panel_fillRightSideBar.ResumeLayout(false);
            this.contextMenuStrip_ListView.ResumeLayout(false);
            this.panel_rightSideBarProgress.ResumeLayout(false);
            this.panel_rightSideBarDown.ResumeLayout(false);
            this.panel_rightSideBarUp.ResumeLayout(false);
            this.panel_rightSideBarUp.PerformLayout();
            this.toolStrip_upMain.ResumeLayout(false);
            this.toolStrip_upMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_TreeSideBar;
        private System.Windows.Forms.Panel panel_leftSideBar;
        private System.Windows.Forms.Panel panel_rightSideBarDown;
        private System.Windows.Forms.Panel panel_rightSideBarUp;
        private System.Windows.Forms.Panel panel_fillRightSideBar;
        private System.Windows.Forms.Panel panel_rightSideBarProgress;
        private System.Windows.Forms.ListView listView_files;
        private System.Windows.Forms.TreeView treeView_dir;
        private System.Windows.Forms.ToolStrip toolStrip_upMain;
        private System.Windows.Forms.ToolStripButton toolStripButton_collapseExpand;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton_ParentDirectory;
        private System.Windows.Forms.ToolStripButton toolStripButton_forwardDirectory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_path;
        private System.Windows.Forms.ToolStripButton toolStripButton_goPath;
        private System.Windows.Forms.ImageList imageList_iconFile;
        private System.Windows.Forms.ImageList imageList_tools;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.Label label_name;
        private System.ComponentModel.BackgroundWorker backgroundWorker_getSize;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_ListView;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar_transfer;
        private System.ComponentModel.BackgroundWorker backgroundWorker_backup;
        private System.Windows.Forms.Label label_countFiles;
        private System.ComponentModel.BackgroundWorker backgroundWorker_getCountFiles;
    }
}