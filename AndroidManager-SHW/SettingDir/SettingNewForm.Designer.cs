namespace AndroidManager_SHW.Setting
{
    partial class SettingNewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_deviceBackupContent = new System.Windows.Forms.Panel();
            this.dataGridView_Device = new System.Windows.Forms.DataGridView();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PathBackup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_buttonDGV = new System.Windows.Forms.Panel();
            this.button_openFolderBackup = new System.Windows.Forms.Button();
            this.button_deleteDeviceBackup = new System.Windows.Forms.Button();
            this.panel_deviceBackupTitle = new System.Windows.Forms.Panel();
            this.label_deviceBackup = new System.Windows.Forms.Label();
            this.panel_saveResetSetting = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.panel_filemanagerContent = new System.Windows.Forms.Panel();
            this.button_showHiddenFile = new System.Windows.Forms.Button();
            this.button_showFileSize = new System.Windows.Forms.Button();
            this.label_fm_showHiddenFile = new System.Windows.Forms.Label();
            this.label_fm_showFileSize = new System.Windows.Forms.Label();
            this.panel_filemanagerTitle = new System.Windows.Forms.Panel();
            this.label_filemanager = new System.Windows.Forms.Label();
            this.panel_packageManagerContent = new System.Windows.Forms.Panel();
            this.textBox_platformToolsPath = new System.Windows.Forms.TextBox();
            this.label_platformToolsPath = new System.Windows.Forms.Label();
            this.button_platformToolsPath = new System.Windows.Forms.Button();
            this.panel_packageManagerTitle = new System.Windows.Forms.Panel();
            this.label_platformTools = new System.Windows.Forms.Label();
            this.panel_pathsContent = new System.Windows.Forms.Panel();
            this.textBox_backupPath = new System.Windows.Forms.TextBox();
            this.button_PMTheme12 = new System.Windows.Forms.Button();
            this.button_keepLatestApk = new System.Windows.Forms.Button();
            this.label_backupPath = new System.Windows.Forms.Label();
            this.button_backupPath = new System.Windows.Forms.Button();
            this.label_PMTheme = new System.Windows.Forms.Label();
            this.label_pm_keepLatestApk = new System.Windows.Forms.Label();
            this.panel_pathsTitle = new System.Windows.Forms.Panel();
            this.label_backup = new System.Windows.Forms.Label();
            this.saveFileDialog_path = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog_path = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker_refreshDGV = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_KeepLatestApkBackup = new System.ComponentModel.BackgroundWorker();
            this.panel_main.SuspendLayout();
            this.panel_deviceBackupContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Device)).BeginInit();
            this.panel_buttonDGV.SuspendLayout();
            this.panel_deviceBackupTitle.SuspendLayout();
            this.panel_saveResetSetting.SuspendLayout();
            this.panel_filemanagerContent.SuspendLayout();
            this.panel_filemanagerTitle.SuspendLayout();
            this.panel_packageManagerContent.SuspendLayout();
            this.panel_packageManagerTitle.SuspendLayout();
            this.panel_pathsContent.SuspendLayout();
            this.panel_pathsTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_deviceBackupContent);
            this.panel_main.Controls.Add(this.panel_deviceBackupTitle);
            this.panel_main.Controls.Add(this.panel_saveResetSetting);
            this.panel_main.Controls.Add(this.panel_packageManagerContent);
            this.panel_main.Controls.Add(this.panel_packageManagerTitle);
            this.panel_main.Controls.Add(this.panel_filemanagerContent);
            this.panel_main.Controls.Add(this.panel_filemanagerTitle);
            this.panel_main.Controls.Add(this.panel_pathsContent);
            this.panel_main.Controls.Add(this.panel_pathsTitle);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(482, 753);
            this.panel_main.TabIndex = 0;
            // 
            // panel_deviceBackupContent
            // 
            this.panel_deviceBackupContent.Controls.Add(this.dataGridView_Device);
            this.panel_deviceBackupContent.Controls.Add(this.panel_buttonDGV);
            this.panel_deviceBackupContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_deviceBackupContent.Location = new System.Drawing.Point(0, 486);
            this.panel_deviceBackupContent.Name = "panel_deviceBackupContent";
            this.panel_deviceBackupContent.Size = new System.Drawing.Size(482, 267);
            this.panel_deviceBackupContent.TabIndex = 11;
            // 
            // dataGridView_Device
            // 
            this.dataGridView_Device.AllowUserToAddRows = false;
            this.dataGridView_Device.AllowUserToDeleteRows = false;
            this.dataGridView_Device.AllowUserToResizeColumns = false;
            this.dataGridView_Device.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dataGridView_Device.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_Device.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Device.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Device.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataGridView_Device.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Device.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Device.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_Device.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Device.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Model,
            this.SizePath,
            this.CountFiles,
            this.PathBackup});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Device.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView_Device.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Device.EnableHeadersVisualStyles = false;
            this.dataGridView_Device.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Device.MultiSelect = false;
            this.dataGridView_Device.Name = "dataGridView_Device";
            this.dataGridView_Device.ReadOnly = true;
            this.dataGridView_Device.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Device.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView_Device.RowHeadersVisible = false;
            this.dataGridView_Device.RowTemplate.Height = 24;
            this.dataGridView_Device.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Device.Size = new System.Drawing.Size(482, 222);
            this.dataGridView_Device.TabIndex = 3;
            this.dataGridView_Device.DoubleClick += new System.EventHandler(this.button_openFolderBackup_Click);
            this.dataGridView_Device.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView_Device_KeyUp);
            // 
            // Model
            // 
            this.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Model.DataPropertyName = "Model";
            this.Model.FillWeight = 55F;
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // SizePath
            // 
            this.SizePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SizePath.DataPropertyName = "SizePath";
            this.SizePath.FillWeight = 45F;
            this.SizePath.HeaderText = "Size";
            this.SizePath.Name = "SizePath";
            this.SizePath.ReadOnly = true;
            // 
            // CountFiles
            // 
            this.CountFiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CountFiles.DataPropertyName = "CountFiles";
            this.CountFiles.FillWeight = 50F;
            this.CountFiles.HeaderText = "Files Number";
            this.CountFiles.Name = "CountFiles";
            this.CountFiles.ReadOnly = true;
            // 
            // PathBackup
            // 
            this.PathBackup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PathBackup.DataPropertyName = "PathBackup";
            this.PathBackup.FillWeight = 200F;
            this.PathBackup.HeaderText = "Path";
            this.PathBackup.Name = "PathBackup";
            this.PathBackup.ReadOnly = true;
            this.PathBackup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PathBackup.Visible = false;
            // 
            // panel_buttonDGV
            // 
            this.panel_buttonDGV.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_buttonDGV.Controls.Add(this.button_openFolderBackup);
            this.panel_buttonDGV.Controls.Add(this.button_deleteDeviceBackup);
            this.panel_buttonDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_buttonDGV.Location = new System.Drawing.Point(0, 222);
            this.panel_buttonDGV.Name = "panel_buttonDGV";
            this.panel_buttonDGV.Size = new System.Drawing.Size(482, 45);
            this.panel_buttonDGV.TabIndex = 2;
            // 
            // button_openFolderBackup
            // 
            this.button_openFolderBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_openFolderBackup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_openFolderBackup.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_openFolderBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_openFolderBackup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openFolderBackup.Location = new System.Drawing.Point(244, 7);
            this.button_openFolderBackup.Name = "button_openFolderBackup";
            this.button_openFolderBackup.Size = new System.Drawing.Size(145, 32);
            this.button_openFolderBackup.TabIndex = 4;
            this.button_openFolderBackup.Text = "Open Backups";
            this.button_openFolderBackup.UseVisualStyleBackColor = false;
            this.button_openFolderBackup.Click += new System.EventHandler(this.button_openFolderBackup_Click);
            // 
            // button_deleteDeviceBackup
            // 
            this.button_deleteDeviceBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_deleteDeviceBackup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_deleteDeviceBackup.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_deleteDeviceBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteDeviceBackup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteDeviceBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_deleteDeviceBackup.Location = new System.Drawing.Point(395, 7);
            this.button_deleteDeviceBackup.Name = "button_deleteDeviceBackup";
            this.button_deleteDeviceBackup.Size = new System.Drawing.Size(82, 32);
            this.button_deleteDeviceBackup.TabIndex = 4;
            this.button_deleteDeviceBackup.Text = "Delete";
            this.button_deleteDeviceBackup.UseVisualStyleBackColor = false;
            this.button_deleteDeviceBackup.Click += new System.EventHandler(this.button_deleteDeviceBackup_Click);
            // 
            // panel_deviceBackupTitle
            // 
            this.panel_deviceBackupTitle.Controls.Add(this.label_deviceBackup);
            this.panel_deviceBackupTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_deviceBackupTitle.Location = new System.Drawing.Point(0, 456);
            this.panel_deviceBackupTitle.Name = "panel_deviceBackupTitle";
            this.panel_deviceBackupTitle.Size = new System.Drawing.Size(482, 30);
            this.panel_deviceBackupTitle.TabIndex = 10;
            // 
            // label_deviceBackup
            // 
            this.label_deviceBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label_deviceBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_deviceBackup.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deviceBackup.Location = new System.Drawing.Point(0, 0);
            this.label_deviceBackup.Name = "label_deviceBackup";
            this.label_deviceBackup.Size = new System.Drawing.Size(482, 30);
            this.label_deviceBackup.TabIndex = 1;
            this.label_deviceBackup.Text = "Device\'s backup";
            this.label_deviceBackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_saveResetSetting
            // 
            this.panel_saveResetSetting.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_saveResetSetting.Controls.Add(this.button_save);
            this.panel_saveResetSetting.Controls.Add(this.button_reset);
            this.panel_saveResetSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_saveResetSetting.Location = new System.Drawing.Point(0, 411);
            this.panel_saveResetSetting.Name = "panel_saveResetSetting";
            this.panel_saveResetSetting.Size = new System.Drawing.Size(482, 45);
            this.panel_saveResetSetting.TabIndex = 9;
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_save.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(395, 7);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(82, 32);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_reset
            // 
            this.button_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_reset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_reset.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.Location = new System.Drawing.Point(307, 7);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(82, 32);
            this.button_reset.TabIndex = 4;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // panel_filemanagerContent
            // 
            this.panel_filemanagerContent.Controls.Add(this.button_showHiddenFile);
            this.panel_filemanagerContent.Controls.Add(this.button_showFileSize);
            this.panel_filemanagerContent.Controls.Add(this.label_fm_showHiddenFile);
            this.panel_filemanagerContent.Controls.Add(this.label_fm_showFileSize);
            this.panel_filemanagerContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_filemanagerContent.Location = new System.Drawing.Point(0, 171);
            this.panel_filemanagerContent.Margin = new System.Windows.Forms.Padding(40, 20, 20, 40);
            this.panel_filemanagerContent.Name = "panel_filemanagerContent";
            this.panel_filemanagerContent.Size = new System.Drawing.Size(482, 102);
            this.panel_filemanagerContent.TabIndex = 5;
            // 
            // button_showHiddenFile
            // 
            this.button_showHiddenFile.BackColor = System.Drawing.Color.Transparent;
            this.button_showHiddenFile.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.toggleOff;
            this.button_showHiddenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_showHiddenFile.FlatAppearance.BorderSize = 0;
            this.button_showHiddenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showHiddenFile.Location = new System.Drawing.Point(160, 43);
            this.button_showHiddenFile.Name = "button_showHiddenFile";
            this.button_showHiddenFile.Size = new System.Drawing.Size(48, 48);
            this.button_showHiddenFile.TabIndex = 14;
            this.button_showHiddenFile.UseVisualStyleBackColor = false;
            this.button_showHiddenFile.Click += new System.EventHandler(this.button_showHiddenFile_Click);
            // 
            // button_showFileSize
            // 
            this.button_showFileSize.BackColor = System.Drawing.Color.Transparent;
            this.button_showFileSize.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.toggleOff;
            this.button_showFileSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_showFileSize.FlatAppearance.BorderSize = 0;
            this.button_showFileSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showFileSize.Location = new System.Drawing.Point(237, 5);
            this.button_showFileSize.Name = "button_showFileSize";
            this.button_showFileSize.Size = new System.Drawing.Size(48, 48);
            this.button_showFileSize.TabIndex = 15;
            this.button_showFileSize.UseVisualStyleBackColor = false;
            this.button_showFileSize.Click += new System.EventHandler(this.button_showFileSize_Click);
            // 
            // label_fm_showHiddenFile
            // 
            this.label_fm_showHiddenFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fm_showHiddenFile.Location = new System.Drawing.Point(13, 56);
            this.label_fm_showHiddenFile.Name = "label_fm_showHiddenFile";
            this.label_fm_showHiddenFile.Size = new System.Drawing.Size(142, 23);
            this.label_fm_showHiddenFile.TabIndex = 12;
            this.label_fm_showHiddenFile.Text = "show Hidden files: \r\n";
            // 
            // label_fm_showFileSize
            // 
            this.label_fm_showFileSize.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fm_showFileSize.Location = new System.Drawing.Point(13, 18);
            this.label_fm_showFileSize.Name = "label_fm_showFileSize";
            this.label_fm_showFileSize.Size = new System.Drawing.Size(227, 23);
            this.label_fm_showFileSize.TabIndex = 13;
            this.label_fm_showFileSize.Text = "show file size in Filemanager: \r\n";
            // 
            // panel_filemanagerTitle
            // 
            this.panel_filemanagerTitle.Controls.Add(this.label_filemanager);
            this.panel_filemanagerTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_filemanagerTitle.Location = new System.Drawing.Point(0, 141);
            this.panel_filemanagerTitle.Name = "panel_filemanagerTitle";
            this.panel_filemanagerTitle.Size = new System.Drawing.Size(482, 30);
            this.panel_filemanagerTitle.TabIndex = 4;
            // 
            // label_filemanager
            // 
            this.label_filemanager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label_filemanager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_filemanager.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_filemanager.Location = new System.Drawing.Point(0, 0);
            this.label_filemanager.Name = "label_filemanager";
            this.label_filemanager.Size = new System.Drawing.Size(482, 30);
            this.label_filemanager.TabIndex = 1;
            this.label_filemanager.Text = "File manager";
            this.label_filemanager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_packageManagerContent
            // 
            this.panel_packageManagerContent.Controls.Add(this.label_pm_keepLatestApk);
            this.panel_packageManagerContent.Controls.Add(this.label_PMTheme);
            this.panel_packageManagerContent.Controls.Add(this.button_keepLatestApk);
            this.panel_packageManagerContent.Controls.Add(this.button_PMTheme12);
            this.panel_packageManagerContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_packageManagerContent.Location = new System.Drawing.Point(0, 303);
            this.panel_packageManagerContent.Name = "panel_packageManagerContent";
            this.panel_packageManagerContent.Size = new System.Drawing.Size(482, 108);
            this.panel_packageManagerContent.TabIndex = 3;
            // 
            // textBox_platformToolsPath
            // 
            this.textBox_platformToolsPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_platformToolsPath.Location = new System.Drawing.Point(170, 64);
            this.textBox_platformToolsPath.Name = "textBox_platformToolsPath";
            this.textBox_platformToolsPath.Size = new System.Drawing.Size(249, 27);
            this.textBox_platformToolsPath.TabIndex = 12;
            // 
            // label_platformToolsPath
            // 
            this.label_platformToolsPath.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_platformToolsPath.Location = new System.Drawing.Point(13, 68);
            this.label_platformToolsPath.Name = "label_platformToolsPath";
            this.label_platformToolsPath.Size = new System.Drawing.Size(151, 23);
            this.label_platformToolsPath.TabIndex = 13;
            this.label_platformToolsPath.Text = "platform-tools Path";
            // 
            // button_platformToolsPath
            // 
            this.button_platformToolsPath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_platformToolsPath.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_platformToolsPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_platformToolsPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_platformToolsPath.Location = new System.Drawing.Point(425, 65);
            this.button_platformToolsPath.Name = "button_platformToolsPath";
            this.button_platformToolsPath.Size = new System.Drawing.Size(44, 27);
            this.button_platformToolsPath.TabIndex = 14;
            this.button_platformToolsPath.Text = "...";
            this.button_platformToolsPath.UseVisualStyleBackColor = false;
            this.button_platformToolsPath.Click += new System.EventHandler(this.button_platformToolsPath_Click);
            // 
            // panel_packageManagerTitle
            // 
            this.panel_packageManagerTitle.Controls.Add(this.label_platformTools);
            this.panel_packageManagerTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_packageManagerTitle.Location = new System.Drawing.Point(0, 273);
            this.panel_packageManagerTitle.Name = "panel_packageManagerTitle";
            this.panel_packageManagerTitle.Size = new System.Drawing.Size(482, 30);
            this.panel_packageManagerTitle.TabIndex = 2;
            // 
            // label_platformTools
            // 
            this.label_platformTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label_platformTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_platformTools.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_platformTools.Location = new System.Drawing.Point(0, 0);
            this.label_platformTools.Name = "label_platformTools";
            this.label_platformTools.Size = new System.Drawing.Size(482, 30);
            this.label_platformTools.TabIndex = 1;
            this.label_platformTools.Text = "Package manager";
            this.label_platformTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_pathsContent
            // 
            this.panel_pathsContent.Controls.Add(this.textBox_platformToolsPath);
            this.panel_pathsContent.Controls.Add(this.label_platformToolsPath);
            this.panel_pathsContent.Controls.Add(this.textBox_backupPath);
            this.panel_pathsContent.Controls.Add(this.button_platformToolsPath);
            this.panel_pathsContent.Controls.Add(this.label_backupPath);
            this.panel_pathsContent.Controls.Add(this.button_backupPath);
            this.panel_pathsContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_pathsContent.Location = new System.Drawing.Point(0, 30);
            this.panel_pathsContent.Name = "panel_pathsContent";
            this.panel_pathsContent.Size = new System.Drawing.Size(482, 111);
            this.panel_pathsContent.TabIndex = 1;
            // 
            // textBox_backupPath
            // 
            this.textBox_backupPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_backupPath.Location = new System.Drawing.Point(119, 17);
            this.textBox_backupPath.Name = "textBox_backupPath";
            this.textBox_backupPath.Size = new System.Drawing.Size(300, 27);
            this.textBox_backupPath.TabIndex = 12;
            // 
            // button_PMTheme12
            // 
            this.button_PMTheme12.BackColor = System.Drawing.Color.Transparent;
            this.button_PMTheme12.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.toggleOff;
            this.button_PMTheme12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_PMTheme12.FlatAppearance.BorderSize = 0;
            this.button_PMTheme12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PMTheme12.Location = new System.Drawing.Point(307, 53);
            this.button_PMTheme12.Name = "button_PMTheme12";
            this.button_PMTheme12.Size = new System.Drawing.Size(48, 48);
            this.button_PMTheme12.TabIndex = 16;
            this.button_PMTheme12.UseVisualStyleBackColor = false;
            this.button_PMTheme12.Click += new System.EventHandler(this.button_PMTheme12_Click);
            // 
            // button_keepLatestApk
            // 
            this.button_keepLatestApk.BackColor = System.Drawing.Color.Transparent;
            this.button_keepLatestApk.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.toggleOff;
            this.button_keepLatestApk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_keepLatestApk.FlatAppearance.BorderSize = 0;
            this.button_keepLatestApk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_keepLatestApk.Location = new System.Drawing.Point(307, 10);
            this.button_keepLatestApk.Name = "button_keepLatestApk";
            this.button_keepLatestApk.Size = new System.Drawing.Size(48, 48);
            this.button_keepLatestApk.TabIndex = 16;
            this.button_keepLatestApk.UseVisualStyleBackColor = false;
            this.button_keepLatestApk.Click += new System.EventHandler(this.button_keepLatestApk_Click);
            // 
            // label_backupPath
            // 
            this.label_backupPath.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_backupPath.Location = new System.Drawing.Point(13, 21);
            this.label_backupPath.Name = "label_backupPath";
            this.label_backupPath.Size = new System.Drawing.Size(100, 23);
            this.label_backupPath.TabIndex = 13;
            this.label_backupPath.Text = "Backup Path";
            // 
            // button_backupPath
            // 
            this.button_backupPath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_backupPath.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_backupPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_backupPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_backupPath.Location = new System.Drawing.Point(425, 18);
            this.button_backupPath.Name = "button_backupPath";
            this.button_backupPath.Size = new System.Drawing.Size(44, 27);
            this.button_backupPath.TabIndex = 14;
            this.button_backupPath.Text = "...";
            this.button_backupPath.UseVisualStyleBackColor = false;
            this.button_backupPath.Click += new System.EventHandler(this.button_backupPath_Click);
            // 
            // label_PMTheme
            // 
            this.label_PMTheme.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PMTheme.Location = new System.Drawing.Point(13, 66);
            this.label_PMTheme.Name = "label_PMTheme";
            this.label_PMTheme.Size = new System.Drawing.Size(288, 23);
            this.label_PMTheme.TabIndex = 15;
            this.label_PMTheme.Text = "Packagemanager(Theme 1 / Theme 2):\r\n\r\n:\r\n";
            // 
            // label_pm_keepLatestApk
            // 
            this.label_pm_keepLatestApk.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pm_keepLatestApk.Location = new System.Drawing.Point(13, 23);
            this.label_pm_keepLatestApk.Name = "label_pm_keepLatestApk";
            this.label_pm_keepLatestApk.Size = new System.Drawing.Size(288, 23);
            this.label_pm_keepLatestApk.TabIndex = 15;
            this.label_pm_keepLatestApk.Text = "just Keep Latest Version apk\'s Backup:";
            // 
            // panel_pathsTitle
            // 
            this.panel_pathsTitle.Controls.Add(this.label_backup);
            this.panel_pathsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_pathsTitle.Location = new System.Drawing.Point(0, 0);
            this.panel_pathsTitle.Name = "panel_pathsTitle";
            this.panel_pathsTitle.Size = new System.Drawing.Size(482, 30);
            this.panel_pathsTitle.TabIndex = 0;
            // 
            // label_backup
            // 
            this.label_backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label_backup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_backup.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_backup.Location = new System.Drawing.Point(0, 0);
            this.label_backup.Name = "label_backup";
            this.label_backup.Size = new System.Drawing.Size(482, 30);
            this.label_backup.TabIndex = 1;
            this.label_backup.Text = "Paths";
            this.label_backup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // folderBrowserDialog_path
            // 
            this.folderBrowserDialog_path.Description = "Select a Directory ";
            // 
            // backgroundWorker_refreshDGV
            // 
            this.backgroundWorker_refreshDGV.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_refreshDGV_DoWork);
            this.backgroundWorker_refreshDGV.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_refreshDGV_RunWorkerCompleted);
            // 
            // backgroundWorker_KeepLatestApkBackup
            // 
            this.backgroundWorker_KeepLatestApkBackup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_KeepLatestApkBackup_DoWork);
            this.backgroundWorker_KeepLatestApkBackup.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_KeepLatestApkBackup_RunWorkerCompleted);
            // 
            // SettingNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 753);
            this.Controls.Add(this.panel_main);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 650);
            this.Name = "SettingNewForm";
            this.ShowIcon = false;
            this.Text = "Setting";
            this.panel_main.ResumeLayout(false);
            this.panel_deviceBackupContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Device)).EndInit();
            this.panel_buttonDGV.ResumeLayout(false);
            this.panel_deviceBackupTitle.ResumeLayout(false);
            this.panel_saveResetSetting.ResumeLayout(false);
            this.panel_filemanagerContent.ResumeLayout(false);
            this.panel_filemanagerTitle.ResumeLayout(false);
            this.panel_packageManagerContent.ResumeLayout(false);
            this.panel_packageManagerTitle.ResumeLayout(false);
            this.panel_pathsContent.ResumeLayout(false);
            this.panel_pathsContent.PerformLayout();
            this.panel_pathsTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_pathsTitle;
        private System.Windows.Forms.Label label_backup;
        private System.Windows.Forms.Panel panel_pathsContent;
        private System.Windows.Forms.TextBox textBox_backupPath;
        private System.Windows.Forms.Button button_keepLatestApk;
        private System.Windows.Forms.Label label_backupPath;
        private System.Windows.Forms.Button button_backupPath;
        private System.Windows.Forms.Label label_pm_keepLatestApk;
        private System.Windows.Forms.Panel panel_packageManagerContent;
        private System.Windows.Forms.TextBox textBox_platformToolsPath;
        private System.Windows.Forms.Label label_platformToolsPath;
        private System.Windows.Forms.Button button_platformToolsPath;
        private System.Windows.Forms.Panel panel_packageManagerTitle;
        private System.Windows.Forms.Label label_platformTools;
        private System.Windows.Forms.Panel panel_filemanagerTitle;
        private System.Windows.Forms.Label label_filemanager;
        private System.Windows.Forms.Panel panel_filemanagerContent;
        private System.Windows.Forms.Button button_showHiddenFile;
        private System.Windows.Forms.Button button_showFileSize;
        private System.Windows.Forms.Label label_fm_showHiddenFile;
        private System.Windows.Forms.Label label_fm_showFileSize;
        private System.Windows.Forms.Panel panel_saveResetSetting;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Panel panel_deviceBackupTitle;
        private System.Windows.Forms.Label label_deviceBackup;
        private System.Windows.Forms.Panel panel_deviceBackupContent;
        private System.Windows.Forms.Panel panel_buttonDGV;
        private System.Windows.Forms.Button button_openFolderBackup;
        private System.Windows.Forms.Button button_deleteDeviceBackup;
        private System.Windows.Forms.DataGridView dataGridView_Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathBackup;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_path;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_path;
        private System.ComponentModel.BackgroundWorker backgroundWorker_refreshDGV;
        private System.ComponentModel.BackgroundWorker backgroundWorker_KeepLatestApkBackup;
        private System.Windows.Forms.Button button_PMTheme12;
        private System.Windows.Forms.Label label_PMTheme;
    }
}