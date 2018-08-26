namespace AndroidManager_SHW.Setting
{
    partial class SettingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_setting = new System.Windows.Forms.Panel();
            this.panel_filemanagerSett = new System.Windows.Forms.Panel();
            this.button_showHiddenFile = new System.Windows.Forms.Button();
            this.button_showFileSize = new System.Windows.Forms.Button();
            this.label_fm_showHiddenFile = new System.Windows.Forms.Label();
            this.label_fm_showFileSize = new System.Windows.Forms.Label();
            this.panel_titleFilemanager = new System.Windows.Forms.Panel();
            this.label_titleFilemanager = new System.Windows.Forms.Label();
            this.panelPath = new System.Windows.Forms.Panel();
            this.textBox_backupPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_updatePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_backupPath = new System.Windows.Forms.Button();
            this.button_updatePath = new System.Windows.Forms.Button();
            this.panel_saveResetSetting = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.panel_titlePath = new System.Windows.Forms.Panel();
            this.label_titlePath = new System.Windows.Forms.Label();
            this.panel_titleDGV = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_showDevices = new System.Windows.Forms.Panel();
            this.panel_DGV = new System.Windows.Forms.Panel();
            this.dataGridView_Device = new System.Windows.Forms.DataGridView();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PathBackup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_buttonDGV = new System.Windows.Forms.Panel();
            this.button_openFolderBackup = new System.Windows.Forms.Button();
            this.button_deleteDeviceBackup = new System.Windows.Forms.Button();
            this.saveFileDialog_path = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog_path = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker_refreshDGV = new System.ComponentModel.BackgroundWorker();
            this.panel_setting.SuspendLayout();
            this.panel_filemanagerSett.SuspendLayout();
            this.panel_titleFilemanager.SuspendLayout();
            this.panelPath.SuspendLayout();
            this.panel_saveResetSetting.SuspendLayout();
            this.panel_titlePath.SuspendLayout();
            this.panel_titleDGV.SuspendLayout();
            this.panel_showDevices.SuspendLayout();
            this.panel_DGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Device)).BeginInit();
            this.panel_buttonDGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_setting
            // 
            this.panel_setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.panel_setting.Controls.Add(this.panel_filemanagerSett);
            this.panel_setting.Controls.Add(this.panel_titleFilemanager);
            this.panel_setting.Controls.Add(this.panelPath);
            this.panel_setting.Controls.Add(this.panel_saveResetSetting);
            this.panel_setting.Controls.Add(this.panel_titlePath);
            this.panel_setting.Controls.Add(this.panel_titleDGV);
            this.panel_setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_setting.Location = new System.Drawing.Point(0, 0);
            this.panel_setting.Name = "panel_setting";
            this.panel_setting.Size = new System.Drawing.Size(482, 367);
            this.panel_setting.TabIndex = 0;
            // 
            // panel_filemanagerSett
            // 
            this.panel_filemanagerSett.Controls.Add(this.button_showHiddenFile);
            this.panel_filemanagerSett.Controls.Add(this.button_showFileSize);
            this.panel_filemanagerSett.Controls.Add(this.label_fm_showHiddenFile);
            this.panel_filemanagerSett.Controls.Add(this.label_fm_showFileSize);
            this.panel_filemanagerSett.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_filemanagerSett.Location = new System.Drawing.Point(0, 176);
            this.panel_filemanagerSett.Name = "panel_filemanagerSett";
            this.panel_filemanagerSett.Size = new System.Drawing.Size(482, 116);
            this.panel_filemanagerSett.TabIndex = 11;
            // 
            // button_showHiddenFile
            // 
            this.button_showHiddenFile.BackColor = System.Drawing.Color.Transparent;
            this.button_showHiddenFile.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.toggleOff;
            this.button_showHiddenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_showHiddenFile.FlatAppearance.BorderSize = 0;
            this.button_showHiddenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showHiddenFile.Location = new System.Drawing.Point(163, 44);
            this.button_showHiddenFile.Name = "button_showHiddenFile";
            this.button_showHiddenFile.Size = new System.Drawing.Size(48, 48);
            this.button_showHiddenFile.TabIndex = 10;
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
            this.button_showFileSize.Location = new System.Drawing.Point(240, 6);
            this.button_showFileSize.Name = "button_showFileSize";
            this.button_showFileSize.Size = new System.Drawing.Size(48, 48);
            this.button_showFileSize.TabIndex = 11;
            this.button_showFileSize.UseVisualStyleBackColor = false;
            this.button_showFileSize.Click += new System.EventHandler(this.button_showFileSize_Click);
            // 
            // label_fm_showHiddenFile
            // 
            this.label_fm_showHiddenFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fm_showHiddenFile.Location = new System.Drawing.Point(15, 57);
            this.label_fm_showHiddenFile.Name = "label_fm_showHiddenFile";
            this.label_fm_showHiddenFile.Size = new System.Drawing.Size(142, 23);
            this.label_fm_showHiddenFile.TabIndex = 8;
            this.label_fm_showHiddenFile.Text = "show Hidden files: \r\n";
            this.label_fm_showHiddenFile.Click += new System.EventHandler(this.button_showHiddenFile_Click);
            // 
            // label_fm_showFileSize
            // 
            this.label_fm_showFileSize.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fm_showFileSize.Location = new System.Drawing.Point(15, 19);
            this.label_fm_showFileSize.Name = "label_fm_showFileSize";
            this.label_fm_showFileSize.Size = new System.Drawing.Size(227, 23);
            this.label_fm_showFileSize.TabIndex = 9;
            this.label_fm_showFileSize.Text = "show file size in Filemanager: \r\n";
            this.label_fm_showFileSize.Click += new System.EventHandler(this.button_showFileSize_Click);
            // 
            // panel_titleFilemanager
            // 
            this.panel_titleFilemanager.Controls.Add(this.label_titleFilemanager);
            this.panel_titleFilemanager.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titleFilemanager.Location = new System.Drawing.Point(0, 149);
            this.panel_titleFilemanager.Name = "panel_titleFilemanager";
            this.panel_titleFilemanager.Size = new System.Drawing.Size(482, 27);
            this.panel_titleFilemanager.TabIndex = 10;
            // 
            // label_titleFilemanager
            // 
            this.label_titleFilemanager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label_titleFilemanager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_titleFilemanager.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titleFilemanager.Location = new System.Drawing.Point(0, 0);
            this.label_titleFilemanager.Name = "label_titleFilemanager";
            this.label_titleFilemanager.Size = new System.Drawing.Size(482, 27);
            this.label_titleFilemanager.TabIndex = 1;
            this.label_titleFilemanager.Text = "filemanager Options";
            this.label_titleFilemanager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPath
            // 
            this.panelPath.Controls.Add(this.textBox_backupPath);
            this.panelPath.Controls.Add(this.label1);
            this.panelPath.Controls.Add(this.textBox_updatePath);
            this.panelPath.Controls.Add(this.label2);
            this.panelPath.Controls.Add(this.button_backupPath);
            this.panelPath.Controls.Add(this.button_updatePath);
            this.panelPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPath.Location = new System.Drawing.Point(0, 27);
            this.panelPath.Name = "panelPath";
            this.panelPath.Size = new System.Drawing.Size(482, 122);
            this.panelPath.TabIndex = 9;
            // 
            // textBox_backupPath
            // 
            this.textBox_backupPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_backupPath.Location = new System.Drawing.Point(121, 20);
            this.textBox_backupPath.Name = "textBox_backupPath";
            this.textBox_backupPath.Size = new System.Drawing.Size(300, 27);
            this.textBox_backupPath.TabIndex = 1;
            this.textBox_backupPath.TextChanged += new System.EventHandler(this.textBox_backupPath_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Backup Path";
            // 
            // textBox_updatePath
            // 
            this.textBox_updatePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_updatePath.Enabled = false;
            this.textBox_updatePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_updatePath.Location = new System.Drawing.Point(121, 60);
            this.textBox_updatePath.Name = "textBox_updatePath";
            this.textBox_updatePath.Size = new System.Drawing.Size(300, 27);
            this.textBox_updatePath.TabIndex = 1;
            this.textBox_updatePath.Text = "Coming soon ...";
            // 
            // label2
            // 
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Update Path";
            // 
            // button_backupPath
            // 
            this.button_backupPath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_backupPath.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_backupPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_backupPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_backupPath.Location = new System.Drawing.Point(427, 21);
            this.button_backupPath.Name = "button_backupPath";
            this.button_backupPath.Size = new System.Drawing.Size(44, 27);
            this.button_backupPath.TabIndex = 3;
            this.button_backupPath.Text = "...";
            this.button_backupPath.UseVisualStyleBackColor = false;
            this.button_backupPath.Click += new System.EventHandler(this.button_backupPath_Click);
            // 
            // button_updatePath
            // 
            this.button_updatePath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_updatePath.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_updatePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_updatePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updatePath.Location = new System.Drawing.Point(427, 61);
            this.button_updatePath.Name = "button_updatePath";
            this.button_updatePath.Size = new System.Drawing.Size(44, 27);
            this.button_updatePath.TabIndex = 3;
            this.button_updatePath.Text = "...";
            this.button_updatePath.UseVisualStyleBackColor = false;
            this.button_updatePath.Click += new System.EventHandler(this.button_updatePath_Click_1);
            // 
            // panel_saveResetSetting
            // 
            this.panel_saveResetSetting.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_saveResetSetting.Controls.Add(this.button_save);
            this.panel_saveResetSetting.Controls.Add(this.button_reset);
            this.panel_saveResetSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_saveResetSetting.Location = new System.Drawing.Point(0, 292);
            this.panel_saveResetSetting.Name = "panel_saveResetSetting";
            this.panel_saveResetSetting.Size = new System.Drawing.Size(482, 45);
            this.panel_saveResetSetting.TabIndex = 8;
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
            // panel_titlePath
            // 
            this.panel_titlePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.panel_titlePath.Controls.Add(this.label_titlePath);
            this.panel_titlePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titlePath.Location = new System.Drawing.Point(0, 0);
            this.panel_titlePath.Name = "panel_titlePath";
            this.panel_titlePath.Size = new System.Drawing.Size(482, 27);
            this.panel_titlePath.TabIndex = 6;
            // 
            // label_titlePath
            // 
            this.label_titlePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label_titlePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_titlePath.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titlePath.Location = new System.Drawing.Point(0, 0);
            this.label_titlePath.Name = "label_titlePath";
            this.label_titlePath.Size = new System.Drawing.Size(482, 27);
            this.label_titlePath.TabIndex = 0;
            this.label_titlePath.Text = "backup\'s path";
            this.label_titlePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_titleDGV
            // 
            this.panel_titleDGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.panel_titleDGV.Controls.Add(this.label3);
            this.panel_titleDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_titleDGV.Location = new System.Drawing.Point(0, 337);
            this.panel_titleDGV.Name = "panel_titleDGV";
            this.panel_titleDGV.Size = new System.Drawing.Size(482, 30);
            this.panel_titleDGV.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(482, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Device\'s backup";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_showDevices
            // 
            this.panel_showDevices.Controls.Add(this.panel_DGV);
            this.panel_showDevices.Controls.Add(this.panel_buttonDGV);
            this.panel_showDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_showDevices.Location = new System.Drawing.Point(0, 367);
            this.panel_showDevices.Name = "panel_showDevices";
            this.panel_showDevices.Size = new System.Drawing.Size(482, 286);
            this.panel_showDevices.TabIndex = 1;
            // 
            // panel_DGV
            // 
            this.panel_DGV.Controls.Add(this.dataGridView_Device);
            this.panel_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_DGV.Location = new System.Drawing.Point(0, 0);
            this.panel_DGV.Name = "panel_DGV";
            this.panel_DGV.Size = new System.Drawing.Size(482, 241);
            this.panel_DGV.TabIndex = 2;
            // 
            // dataGridView_Device
            // 
            this.dataGridView_Device.AllowUserToAddRows = false;
            this.dataGridView_Device.AllowUserToDeleteRows = false;
            this.dataGridView_Device.AllowUserToResizeColumns = false;
            this.dataGridView_Device.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dataGridView_Device.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Device.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Device.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Device.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataGridView_Device.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Device.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Device.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Device.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Device.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Model,
            this.SizePath,
            this.CountFiles,
            this.PathBackup});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Device.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Device.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Device.EnableHeadersVisualStyles = false;
            this.dataGridView_Device.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Device.MultiSelect = false;
            this.dataGridView_Device.Name = "dataGridView_Device";
            this.dataGridView_Device.ReadOnly = true;
            this.dataGridView_Device.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Device.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Device.RowHeadersVisible = false;
            this.dataGridView_Device.RowTemplate.Height = 24;
            this.dataGridView_Device.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Device.Size = new System.Drawing.Size(482, 241);
            this.dataGridView_Device.TabIndex = 0;
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
            this.panel_buttonDGV.Location = new System.Drawing.Point(0, 241);
            this.panel_buttonDGV.Name = "panel_buttonDGV";
            this.panel_buttonDGV.Size = new System.Drawing.Size(482, 45);
            this.panel_buttonDGV.TabIndex = 1;
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
            // folderBrowserDialog_path
            // 
            this.folderBrowserDialog_path.Description = "Select a Directory for Main work [ Your_path\\AndroidManagerSHW\\  ]";
            // 
            // backgroundWorker_refreshDGV
            // 
            this.backgroundWorker_refreshDGV.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_refreshDGV_DoWork);
            this.backgroundWorker_refreshDGV.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_refreshDGV_RunWorkerCompleted);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.panel_showDevices);
            this.Controls.Add(this.panel_setting);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 950);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 550);
            this.Name = "SettingForm";
            this.ShowIcon = false;
            this.Text = "Setting";
            this.panel_setting.ResumeLayout(false);
            this.panel_filemanagerSett.ResumeLayout(false);
            this.panel_titleFilemanager.ResumeLayout(false);
            this.panelPath.ResumeLayout(false);
            this.panelPath.PerformLayout();
            this.panel_saveResetSetting.ResumeLayout(false);
            this.panel_titlePath.ResumeLayout(false);
            this.panel_titleDGV.ResumeLayout(false);
            this.panel_showDevices.ResumeLayout(false);
            this.panel_DGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Device)).EndInit();
            this.panel_buttonDGV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_setting;
        private System.Windows.Forms.Button button_updatePath;
        private System.Windows.Forms.Button button_backupPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_updatePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_backupPath;
        private System.Windows.Forms.Panel panel_showDevices;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.DataGridView dataGridView_Device;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_path;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_path;
        private System.Windows.Forms.Panel panel_DGV;
        private System.Windows.Forms.Panel panel_buttonDGV;
        private System.Windows.Forms.Button button_openFolderBackup;
        private System.Windows.Forms.Button button_deleteDeviceBackup;
        private System.Windows.Forms.Panel panel_titleDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_titlePath;
        private System.Windows.Forms.Label label_titlePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathBackup;
        private System.ComponentModel.BackgroundWorker backgroundWorker_refreshDGV;
        private System.Windows.Forms.Panel panel_saveResetSetting;
        private System.Windows.Forms.Panel panelPath;
        private System.Windows.Forms.Panel panel_filemanagerSett;
        private System.Windows.Forms.Button button_showHiddenFile;
        private System.Windows.Forms.Button button_showFileSize;
        private System.Windows.Forms.Label label_fm_showHiddenFile;
        private System.Windows.Forms.Label label_fm_showFileSize;
        private System.Windows.Forms.Panel panel_titleFilemanager;
        private System.Windows.Forms.Label label_titleFilemanager;
    }
}