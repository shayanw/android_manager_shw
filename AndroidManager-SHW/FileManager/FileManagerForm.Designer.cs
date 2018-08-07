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
            this.refreshToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList_iconFile = new System.Windows.Forms.ImageList(this.components);
            this.panel_rightSideBarProgress = new System.Windows.Forms.Panel();
            this.panel_rightSideBarDown = new System.Windows.Forms.Panel();
            this.label_type = new System.Windows.Forms.Label();
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
            this.label_size = new System.Windows.Forms.Label();
            this.panel_TreeSideBar.SuspendLayout();
            this.panel_leftSideBar.SuspendLayout();
            this.panel_fillRightSideBar.SuspendLayout();
            this.contextMenuStrip_ListView.SuspendLayout();
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
            this.panel_TreeSideBar.Size = new System.Drawing.Size(172, 453);
            this.panel_TreeSideBar.TabIndex = 0;
            // 
            // treeView_dir
            // 
            this.treeView_dir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(220)))), ((int)(((byte)(203)))));
            this.treeView_dir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView_dir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_dir.ImageIndex = 0;
            this.treeView_dir.ImageList = this.imageList_tools;
            this.treeView_dir.Location = new System.Drawing.Point(0, 0);
            this.treeView_dir.Name = "treeView_dir";
            this.treeView_dir.SelectedImageIndex = 0;
            this.treeView_dir.Size = new System.Drawing.Size(172, 453);
            this.treeView_dir.TabIndex = 20;
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
            this.panel_leftSideBar.Location = new System.Drawing.Point(172, 0);
            this.panel_leftSideBar.Name = "panel_leftSideBar";
            this.panel_leftSideBar.Size = new System.Drawing.Size(510, 453);
            this.panel_leftSideBar.TabIndex = 1;
            // 
            // panel_fillRightSideBar
            // 
            this.panel_fillRightSideBar.Controls.Add(this.listView_files);
            this.panel_fillRightSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fillRightSideBar.Location = new System.Drawing.Point(0, 70);
            this.panel_fillRightSideBar.Name = "panel_fillRightSideBar";
            this.panel_fillRightSideBar.Size = new System.Drawing.Size(510, 304);
            this.panel_fillRightSideBar.TabIndex = 3;
            // 
            // listView_files
            // 
            this.listView_files.AllowDrop = true;
            this.listView_files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.listView_files.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_files.ContextMenuStrip = this.contextMenuStrip_ListView;
            this.listView_files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_files.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_files.LargeImageList = this.imageList_iconFile;
            this.listView_files.Location = new System.Drawing.Point(0, 0);
            this.listView_files.Name = "listView_files";
            this.listView_files.Size = new System.Drawing.Size(510, 304);
            this.listView_files.SmallImageList = this.imageList_iconFile;
            this.listView_files.TabIndex = 1;
            this.listView_files.UseCompatibleStateImageBehavior = false;
            this.listView_files.SelectedIndexChanged += new System.EventHandler(this.listView_files_SelectedIndexChanged);
            this.listView_files.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_files_DragDrop);
            this.listView_files.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView_files_DragEnter);
            this.listView_files.DoubleClick += new System.EventHandler(this.listView_files_DoubleClick);
            this.listView_files.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_files_KeyDown);
            // 
            // contextMenuStrip_ListView
            // 
            this.contextMenuStrip_ListView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_ListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem2,
            this.backupToolStripMenuItem,
            this.uploadToolStripMenuItem,
            this.toolStripSeparator2,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.newFolderToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator5,
            this.propertiesToolStripMenuItem});
            this.contextMenuStrip_ListView.Name = "contextMenuStrip_ListView";
            this.contextMenuStrip_ListView.Size = new System.Drawing.Size(203, 256);
            this.contextMenuStrip_ListView.Opened += new System.EventHandler(this.contextMenuStrip_ListView_Opened);
            // 
            // refreshToolStripMenuItem2
            // 
            this.refreshToolStripMenuItem2.Image = global::AndroidManager_SHW.Properties.Resources.fm_con_refresh;
            this.refreshToolStripMenuItem2.Name = "refreshToolStripMenuItem2";
            this.refreshToolStripMenuItem2.Size = new System.Drawing.Size(202, 26);
            this.refreshToolStripMenuItem2.Text = "Refresh";
            this.refreshToolStripMenuItem2.Click += new System.EventHandler(this.refreshToolStripMenuItem2_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Image = global::AndroidManager_SHW.Properties.Resources.fm_con_backup;
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Image = global::AndroidManager_SHW.Properties.Resources.fm_con_upload;
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::AndroidManager_SHW.Properties.Resources.fm_con_copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copycutToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::AndroidManager_SHW.Properties.Resources.fm_con_cut;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.copycutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::AndroidManager_SHW.Properties.Resources.fm_con_paste;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(199, 6);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Image = global::AndroidManager_SHW.Properties.Resources.fm_con_newdr;
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.newFolderToolStripMenuItem.Text = "NewFolder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::AndroidManager_SHW.Properties.Resources.fm_con_delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(199, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Image = global::AndroidManager_SHW.Properties.Resources.fm_con_details;
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
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
            this.imageList_iconFile.Images.SetKeyName(10, "picture.png");
            this.imageList_iconFile.Images.SetKeyName(11, "files.png");
            this.imageList_iconFile.Images.SetKeyName(12, "contact.png");
            this.imageList_iconFile.Images.SetKeyName(13, "office_Word.png");
            this.imageList_iconFile.Images.SetKeyName(14, "office_Excel.png");
            this.imageList_iconFile.Images.SetKeyName(15, "office_Powerpoint.png");
            this.imageList_iconFile.Images.SetKeyName(16, "office_Access.png");
            // 
            // panel_rightSideBarProgress
            // 
            this.panel_rightSideBarProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.panel_rightSideBarProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_rightSideBarProgress.Location = new System.Drawing.Point(0, 40);
            this.panel_rightSideBarProgress.Name = "panel_rightSideBarProgress";
            this.panel_rightSideBarProgress.Size = new System.Drawing.Size(510, 30);
            this.panel_rightSideBarProgress.TabIndex = 2;
            this.panel_rightSideBarProgress.Visible = false;
            // 
            // panel_rightSideBarDown
            // 
            this.panel_rightSideBarDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.panel_rightSideBarDown.Controls.Add(this.label_size);
            this.panel_rightSideBarDown.Controls.Add(this.label_type);
            this.panel_rightSideBarDown.Controls.Add(this.label_name);
            this.panel_rightSideBarDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_rightSideBarDown.Location = new System.Drawing.Point(0, 374);
            this.panel_rightSideBarDown.Name = "panel_rightSideBarDown";
            this.panel_rightSideBarDown.Size = new System.Drawing.Size(510, 79);
            this.panel_rightSideBarDown.TabIndex = 1;
            // 
            // label_type
            // 
            this.label_type.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_type.Location = new System.Drawing.Point(17, 46);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(151, 24);
            this.label_type.TabIndex = 0;
            this.label_type.Text = "Type: ";
            // 
            // label_name
            // 
            this.label_name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(17, 17);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(481, 24);
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
            this.panel_rightSideBarUp.Size = new System.Drawing.Size(510, 40);
            this.panel_rightSideBarUp.TabIndex = 0;
            // 
            // toolStrip_upMain
            // 
            this.toolStrip_upMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.toolStrip_upMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip_upMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
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
            this.toolStrip_upMain.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip_upMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip_upMain.Size = new System.Drawing.Size(510, 40);
            this.toolStrip_upMain.TabIndex = 2;
            this.toolStrip_upMain.Text = "Go";
            // 
            // toolStripButton_collapseExpand
            // 
            this.toolStripButton_collapseExpand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_collapseExpand.Image = global::AndroidManager_SHW.Properties.Resources.collapse;
            this.toolStripButton_collapseExpand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_collapseExpand.Name = "toolStripButton_collapseExpand";
            this.toolStripButton_collapseExpand.Size = new System.Drawing.Size(24, 37);
            this.toolStripButton_collapseExpand.Text = "Expand/Collapse";
            this.toolStripButton_collapseExpand.Click += new System.EventHandler(this.toolStripButton_collapseExpand_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripButton_ParentDirectory
            // 
            this.toolStripButton_ParentDirectory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ParentDirectory.Image = global::AndroidManager_SHW.Properties.Resources.Back;
            this.toolStripButton_ParentDirectory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ParentDirectory.Name = "toolStripButton_ParentDirectory";
            this.toolStripButton_ParentDirectory.Size = new System.Drawing.Size(24, 37);
            this.toolStripButton_ParentDirectory.Text = "Go Parent Path";
            this.toolStripButton_ParentDirectory.Click += new System.EventHandler(this.toolStripButton_ParentDirectory_Click);
            // 
            // toolStripButton_forwardDirectory
            // 
            this.toolStripButton_forwardDirectory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_forwardDirectory.Image = global::AndroidManager_SHW.Properties.Resources.Next;
            this.toolStripButton_forwardDirectory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_forwardDirectory.Name = "toolStripButton_forwardDirectory";
            this.toolStripButton_forwardDirectory.Size = new System.Drawing.Size(24, 37);
            this.toolStripButton_forwardDirectory.Text = "Go Last Path";
            this.toolStripButton_forwardDirectory.Click += new System.EventHandler(this.toolStripButton_forwardDirectory_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripTextBox_path
            // 
            this.toolStripTextBox_path.Name = "toolStripTextBox_path";
            this.toolStripTextBox_path.Size = new System.Drawing.Size(315, 40);
            this.toolStripTextBox_path.Click += new System.EventHandler(this.toolStripTextBox_path_Click);
            // 
            // toolStripButton_goPath
            // 
            this.toolStripButton_goPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_goPath.Image = global::AndroidManager_SHW.Properties.Resources.Go;
            this.toolStripButton_goPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_goPath.Name = "toolStripButton_goPath";
            this.toolStripButton_goPath.Size = new System.Drawing.Size(24, 37);
            this.toolStripButton_goPath.Text = "Go/Refresh";
            this.toolStripButton_goPath.Click += new System.EventHandler(this.toolStripButton_goPath_Click);
            // 
            // label_size
            // 
            this.label_size.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_size.Location = new System.Drawing.Point(347, 46);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(151, 24);
            this.label_size.TabIndex = 0;
            this.label_size.Text = "Size: ";
            // 
            // FileManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.panel_leftSideBar);
            this.Controls.Add(this.panel_TreeSideBar);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "FileManagerForm";
            this.ShowIcon = false;
            this.Text = "File Manager";
            this.Load += new System.EventHandler(this.FileManagerForm_Load);
            this.panel_TreeSideBar.ResumeLayout(false);
            this.panel_leftSideBar.ResumeLayout(false);
            this.panel_fillRightSideBar.ResumeLayout(false);
            this.contextMenuStrip_ListView.ResumeLayout(false);
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
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_ListView;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.Label label_size;
    }
}