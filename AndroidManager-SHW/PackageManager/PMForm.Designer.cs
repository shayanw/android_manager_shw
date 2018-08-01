namespace AndroidManager_SHW.PackageManager
{
    partial class PMForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PMForm));
            this.panel_details = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_statePackage = new System.Windows.Forms.Label();
            this.label_namePackage = new System.Windows.Forms.Label();
            this.label_addressPackage = new System.Windows.Forms.Label();
            this.progressBar_statePackage = new System.Windows.Forms.ProgressBar();
            this.label_titleTempPackages = new System.Windows.Forms.Label();
            this.label_titleDevicePackages = new System.Windows.Forms.Label();
            this.panel_rightSide = new System.Windows.Forms.Panel();
            this.listBox_tempPackages = new System.Windows.Forms.ListBox();
            this.panel_rightTools = new System.Windows.Forms.Panel();
            this.button_addTempPackages = new System.Windows.Forms.Button();
            this.button_removeTempPackages = new System.Windows.Forms.Button();
            this.panel_rightFooter = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_installTempPackages = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_externalMemory = new System.Windows.Forms.RadioButton();
            this.radioButton_internalMemory = new System.Windows.Forms.RadioButton();
            this.panel_rightHeader = new System.Windows.Forms.Panel();
            this.panel_leftSide = new System.Windows.Forms.Panel();
            this.dataGridView_devicePackages = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_dataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unistallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_leftSearch = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox_searchIcon = new System.Windows.Forms.PictureBox();
            this.panel_leftFooter = new System.Windows.Forms.Panel();
            this.panel_leftButton = new System.Windows.Forms.Panel();
            this.button_unistallDevicePackages = new System.Windows.Forms.Button();
            this.panel_righteButton = new System.Windows.Forms.Panel();
            this.button_backupDevicePackages = new System.Windows.Forms.Button();
            this.panel_leftHeader = new System.Windows.Forms.Panel();
            this.backgroundWorker_setDataGridView = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog_apk = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker_unistallPackages = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_installPackages = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_backupPackages = new System.ComponentModel.BackgroundWorker();
            this.panel_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_rightSide.SuspendLayout();
            this.panel_rightTools.SuspendLayout();
            this.panel_rightFooter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_rightHeader.SuspendLayout();
            this.panel_leftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_devicePackages)).BeginInit();
            this.contextMenuStrip_dataGridView.SuspendLayout();
            this.panel_leftSearch.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_searchIcon)).BeginInit();
            this.panel_leftFooter.SuspendLayout();
            this.panel_leftButton.SuspendLayout();
            this.panel_righteButton.SuspendLayout();
            this.panel_leftHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_details
            // 
            this.panel_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.panel_details.Controls.Add(this.pictureBox2);
            this.panel_details.Controls.Add(this.label_statePackage);
            this.panel_details.Controls.Add(this.label_namePackage);
            this.panel_details.Controls.Add(this.label_addressPackage);
            this.panel_details.Controls.Add(this.progressBar_statePackage);
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_details.Location = new System.Drawing.Point(0, 660);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(710, 71);
            this.panel_details.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(660, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label_statePackage
            // 
            this.label_statePackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_statePackage.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_statePackage.Location = new System.Drawing.Point(368, 13);
            this.label_statePackage.Name = "label_statePackage";
            this.label_statePackage.Size = new System.Drawing.Size(288, 20);
            this.label_statePackage.TabIndex = 2;
            this.label_statePackage.Text = "State";
            this.label_statePackage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_namePackage
            // 
            this.label_namePackage.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_namePackage.Location = new System.Drawing.Point(3, 15);
            this.label_namePackage.Name = "label_namePackage";
            this.label_namePackage.Size = new System.Drawing.Size(355, 23);
            this.label_namePackage.TabIndex = 3;
            this.label_namePackage.Text = "Name:";
            // 
            // label_addressPackage
            // 
            this.label_addressPackage.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addressPackage.Location = new System.Drawing.Point(3, 38);
            this.label_addressPackage.Name = "label_addressPackage";
            this.label_addressPackage.Size = new System.Drawing.Size(647, 23);
            this.label_addressPackage.TabIndex = 3;
            this.label_addressPackage.Text = "Address:";
            // 
            // progressBar_statePackage
            // 
            this.progressBar_statePackage.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar_statePackage.Location = new System.Drawing.Point(0, 0);
            this.progressBar_statePackage.Name = "progressBar_statePackage";
            this.progressBar_statePackage.Size = new System.Drawing.Size(710, 13);
            this.progressBar_statePackage.TabIndex = 0;
            this.progressBar_statePackage.Visible = false;
            // 
            // label_titleTempPackages
            // 
            this.label_titleTempPackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(220)))), ((int)(((byte)(203)))));
            this.label_titleTempPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_titleTempPackages.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titleTempPackages.ForeColor = System.Drawing.Color.Black;
            this.label_titleTempPackages.Location = new System.Drawing.Point(0, 0);
            this.label_titleTempPackages.Name = "label_titleTempPackages";
            this.label_titleTempPackages.Size = new System.Drawing.Size(292, 40);
            this.label_titleTempPackages.TabIndex = 0;
            this.label_titleTempPackages.Text = "Temp Packages";
            this.label_titleTempPackages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_titleDevicePackages
            // 
            this.label_titleDevicePackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(220)))), ((int)(((byte)(203)))));
            this.label_titleDevicePackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_titleDevicePackages.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titleDevicePackages.ForeColor = System.Drawing.Color.Black;
            this.label_titleDevicePackages.Location = new System.Drawing.Point(0, 0);
            this.label_titleDevicePackages.Name = "label_titleDevicePackages";
            this.label_titleDevicePackages.Size = new System.Drawing.Size(418, 40);
            this.label_titleDevicePackages.TabIndex = 1;
            this.label_titleDevicePackages.Text = "Device Packages";
            this.label_titleDevicePackages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_rightSide
            // 
            this.panel_rightSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.panel_rightSide.Controls.Add(this.listBox_tempPackages);
            this.panel_rightSide.Controls.Add(this.panel_rightTools);
            this.panel_rightSide.Controls.Add(this.panel_rightFooter);
            this.panel_rightSide.Controls.Add(this.panel_rightHeader);
            this.panel_rightSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_rightSide.Location = new System.Drawing.Point(418, 0);
            this.panel_rightSide.Name = "panel_rightSide";
            this.panel_rightSide.Size = new System.Drawing.Size(292, 660);
            this.panel_rightSide.TabIndex = 1;
            // 
            // listBox_tempPackages
            // 
            this.listBox_tempPackages.AllowDrop = true;
            this.listBox_tempPackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.listBox_tempPackages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_tempPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_tempPackages.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_tempPackages.FormattingEnabled = true;
            this.listBox_tempPackages.ItemHeight = 20;
            this.listBox_tempPackages.Location = new System.Drawing.Point(0, 68);
            this.listBox_tempPackages.Name = "listBox_tempPackages";
            this.listBox_tempPackages.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_tempPackages.Size = new System.Drawing.Size(292, 533);
            this.listBox_tempPackages.TabIndex = 7;
            this.listBox_tempPackages.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_tempPackages_DragDrop);
            this.listBox_tempPackages.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_tempPackages_DragEnter);
            // 
            // panel_rightTools
            // 
            this.panel_rightTools.Controls.Add(this.button_addTempPackages);
            this.panel_rightTools.Controls.Add(this.button_removeTempPackages);
            this.panel_rightTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_rightTools.Location = new System.Drawing.Point(0, 40);
            this.panel_rightTools.Name = "panel_rightTools";
            this.panel_rightTools.Size = new System.Drawing.Size(292, 28);
            this.panel_rightTools.TabIndex = 6;
            // 
            // button_addTempPackages
            // 
            this.button_addTempPackages.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_addTempPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_addTempPackages.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_addTempPackages.FlatAppearance.BorderSize = 0;
            this.button_addTempPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addTempPackages.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addTempPackages.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_addTempPackages.Location = new System.Drawing.Point(0, 0);
            this.button_addTempPackages.Name = "button_addTempPackages";
            this.button_addTempPackages.Size = new System.Drawing.Size(232, 28);
            this.button_addTempPackages.TabIndex = 5;
            this.button_addTempPackages.Text = "Add Packages";
            this.button_addTempPackages.UseVisualStyleBackColor = false;
            this.button_addTempPackages.Click += new System.EventHandler(this.button_addTempPackages_Click);
            // 
            // button_removeTempPackages
            // 
            this.button_removeTempPackages.BackColor = System.Drawing.Color.LightPink;
            this.button_removeTempPackages.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_removeTempPackages.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_removeTempPackages.FlatAppearance.BorderSize = 0;
            this.button_removeTempPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_removeTempPackages.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_removeTempPackages.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_removeTempPackages.Location = new System.Drawing.Point(232, 0);
            this.button_removeTempPackages.Name = "button_removeTempPackages";
            this.button_removeTempPackages.Size = new System.Drawing.Size(60, 28);
            this.button_removeTempPackages.TabIndex = 4;
            this.button_removeTempPackages.Text = "Clear";
            this.button_removeTempPackages.UseVisualStyleBackColor = false;
            this.button_removeTempPackages.Click += new System.EventHandler(this.button_removeTempPackages_Click);
            // 
            // panel_rightFooter
            // 
            this.panel_rightFooter.BackColor = System.Drawing.Color.PaleGreen;
            this.panel_rightFooter.Controls.Add(this.panel2);
            this.panel_rightFooter.Controls.Add(this.panel1);
            this.panel_rightFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_rightFooter.Location = new System.Drawing.Point(0, 601);
            this.panel_rightFooter.Name = "panel_rightFooter";
            this.panel_rightFooter.Size = new System.Drawing.Size(292, 59);
            this.panel_rightFooter.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.panel2.Controls.Add(this.button_installTempPackages);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 59);
            this.panel2.TabIndex = 10;
            // 
            // button_installTempPackages
            // 
            this.button_installTempPackages.BackColor = System.Drawing.Color.PaleGreen;
            this.button_installTempPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_installTempPackages.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_installTempPackages.FlatAppearance.BorderSize = 0;
            this.button_installTempPackages.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_installTempPackages.Image = global::AndroidManager_SHW.Properties.Resources.pm_install;
            this.button_installTempPackages.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_installTempPackages.Location = new System.Drawing.Point(0, 0);
            this.button_installTempPackages.Name = "button_installTempPackages";
            this.button_installTempPackages.Size = new System.Drawing.Size(173, 59);
            this.button_installTempPackages.TabIndex = 8;
            this.button_installTempPackages.Text = "Install";
            this.button_installTempPackages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_installTempPackages.UseVisualStyleBackColor = false;
            this.button_installTempPackages.Click += new System.EventHandler(this.button_installTempPackages_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.radioButton_externalMemory);
            this.panel1.Controls.Add(this.radioButton_internalMemory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(173, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 59);
            this.panel1.TabIndex = 9;
            // 
            // radioButton_externalMemory
            // 
            this.radioButton_externalMemory.AutoSize = true;
            this.radioButton_externalMemory.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_externalMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_externalMemory.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_externalMemory.Location = new System.Drawing.Point(11, 30);
            this.radioButton_externalMemory.Name = "radioButton_externalMemory";
            this.radioButton_externalMemory.Size = new System.Drawing.Size(94, 23);
            this.radioButton_externalMemory.TabIndex = 7;
            this.radioButton_externalMemory.Text = "External M";
            this.radioButton_externalMemory.UseVisualStyleBackColor = false;
            // 
            // radioButton_internalMemory
            // 
            this.radioButton_internalMemory.AutoSize = true;
            this.radioButton_internalMemory.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_internalMemory.Checked = true;
            this.radioButton_internalMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_internalMemory.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_internalMemory.Location = new System.Drawing.Point(11, 6);
            this.radioButton_internalMemory.Name = "radioButton_internalMemory";
            this.radioButton_internalMemory.Size = new System.Drawing.Size(93, 23);
            this.radioButton_internalMemory.TabIndex = 6;
            this.radioButton_internalMemory.TabStop = true;
            this.radioButton_internalMemory.Text = "Internal M";
            this.radioButton_internalMemory.UseVisualStyleBackColor = false;
            // 
            // panel_rightHeader
            // 
            this.panel_rightHeader.Controls.Add(this.label_titleTempPackages);
            this.panel_rightHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_rightHeader.Location = new System.Drawing.Point(0, 0);
            this.panel_rightHeader.Name = "panel_rightHeader";
            this.panel_rightHeader.Size = new System.Drawing.Size(292, 40);
            this.panel_rightHeader.TabIndex = 1;
            // 
            // panel_leftSide
            // 
            this.panel_leftSide.BackColor = System.Drawing.Color.White;
            this.panel_leftSide.Controls.Add(this.dataGridView_devicePackages);
            this.panel_leftSide.Controls.Add(this.panel_leftSearch);
            this.panel_leftSide.Controls.Add(this.panel_leftFooter);
            this.panel_leftSide.Controls.Add(this.panel_leftHeader);
            this.panel_leftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_leftSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_leftSide.Location = new System.Drawing.Point(0, 0);
            this.panel_leftSide.Name = "panel_leftSide";
            this.panel_leftSide.Size = new System.Drawing.Size(418, 660);
            this.panel_leftSide.TabIndex = 2;
            // 
            // dataGridView_devicePackages
            // 
            this.dataGridView_devicePackages.AllowUserToAddRows = false;
            this.dataGridView_devicePackages.AllowUserToDeleteRows = false;
            this.dataGridView_devicePackages.AllowUserToOrderColumns = true;
            this.dataGridView_devicePackages.AllowUserToResizeColumns = false;
            this.dataGridView_devicePackages.AllowUserToResizeRows = false;
            this.dataGridView_devicePackages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.dataGridView_devicePackages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_devicePackages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView_devicePackages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_devicePackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_devicePackages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Version});
            this.dataGridView_devicePackages.ContextMenuStrip = this.contextMenuStrip_dataGridView;
            this.dataGridView_devicePackages.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView_devicePackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_devicePackages.Location = new System.Drawing.Point(0, 68);
            this.dataGridView_devicePackages.Name = "dataGridView_devicePackages";
            this.dataGridView_devicePackages.RowHeadersVisible = false;
            this.dataGridView_devicePackages.RowTemplate.Height = 24;
            this.dataGridView_devicePackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_devicePackages.Size = new System.Drawing.Size(418, 533);
            this.dataGridView_devicePackages.TabIndex = 1;
            this.dataGridView_devicePackages.SelectionChanged += new System.EventHandler(this.dataGridView_devicePackages_SelectionChanged);
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.FillWeight = 60F;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Version
            // 
            this.Version.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Version.FillWeight = 40F;
            this.Version.HeaderText = "Version";
            this.Version.Name = "Version";
            // 
            // contextMenuStrip_dataGridView
            // 
            this.contextMenuStrip_dataGridView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_dataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.unistallToolStripMenuItem});
            this.contextMenuStrip_dataGridView.Name = "contextMenuStrip_dataGridView";
            this.contextMenuStrip_dataGridView.Size = new System.Drawing.Size(132, 56);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Image = global::AndroidManager_SHW.Properties.Resources.pm_backup;
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // unistallToolStripMenuItem
            // 
            this.unistallToolStripMenuItem.Image = global::AndroidManager_SHW.Properties.Resources.pm_unistall;
            this.unistallToolStripMenuItem.Name = "unistallToolStripMenuItem";
            this.unistallToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.unistallToolStripMenuItem.Text = "Unistall";
            this.unistallToolStripMenuItem.Click += new System.EventHandler(this.button_unistallDevicePackages_Click);
            // 
            // panel_leftSearch
            // 
            this.panel_leftSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.panel_leftSearch.Controls.Add(this.panel4);
            this.panel_leftSearch.Controls.Add(this.panel3);
            this.panel_leftSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_leftSearch.Location = new System.Drawing.Point(0, 40);
            this.panel_leftSearch.Name = "panel_leftSearch";
            this.panel_leftSearch.Size = new System.Drawing.Size(418, 28);
            this.panel_leftSearch.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.textBox_search);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(370, 28);
            this.panel4.TabIndex = 9;
            // 
            // textBox_search
            // 
            this.textBox_search.BackColor = System.Drawing.Color.White;
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.ForeColor = System.Drawing.Color.Black;
            this.textBox_search.Location = new System.Drawing.Point(0, 0);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(370, 20);
            this.textBox_search.TabIndex = 3;
            this.textBox_search.Text = "Search Now •••";
            this.textBox_search.Enter += new System.EventHandler(this.textBox_search_Enter);
            this.textBox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_search_KeyDown);
            this.textBox_search.Leave += new System.EventHandler(this.textBox_search_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox_searchIcon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(370, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(48, 28);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox_searchIcon
            // 
            this.pictureBox_searchIcon.BackColor = System.Drawing.Color.White;
            this.pictureBox_searchIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_searchIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_searchIcon.Image")));
            this.pictureBox_searchIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_searchIcon.Name = "pictureBox_searchIcon";
            this.pictureBox_searchIcon.Size = new System.Drawing.Size(48, 28);
            this.pictureBox_searchIcon.TabIndex = 7;
            this.pictureBox_searchIcon.TabStop = false;
            this.pictureBox_searchIcon.Click += new System.EventHandler(this.pictureBox_searchIcon_Click);
            // 
            // panel_leftFooter
            // 
            this.panel_leftFooter.BackColor = System.Drawing.Color.Transparent;
            this.panel_leftFooter.Controls.Add(this.panel_leftButton);
            this.panel_leftFooter.Controls.Add(this.panel_righteButton);
            this.panel_leftFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_leftFooter.Location = new System.Drawing.Point(0, 601);
            this.panel_leftFooter.Name = "panel_leftFooter";
            this.panel_leftFooter.Size = new System.Drawing.Size(418, 59);
            this.panel_leftFooter.TabIndex = 2;
            // 
            // panel_leftButton
            // 
            this.panel_leftButton.Controls.Add(this.button_unistallDevicePackages);
            this.panel_leftButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_leftButton.Location = new System.Drawing.Point(0, 0);
            this.panel_leftButton.Name = "panel_leftButton";
            this.panel_leftButton.Size = new System.Drawing.Size(245, 59);
            this.panel_leftButton.TabIndex = 4;
            // 
            // button_unistallDevicePackages
            // 
            this.button_unistallDevicePackages.BackColor = System.Drawing.Color.LightPink;
            this.button_unistallDevicePackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_unistallDevicePackages.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_unistallDevicePackages.FlatAppearance.BorderSize = 0;
            this.button_unistallDevicePackages.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_unistallDevicePackages.Image = global::AndroidManager_SHW.Properties.Resources.pm_unistall;
            this.button_unistallDevicePackages.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_unistallDevicePackages.Location = new System.Drawing.Point(0, 0);
            this.button_unistallDevicePackages.Name = "button_unistallDevicePackages";
            this.button_unistallDevicePackages.Size = new System.Drawing.Size(245, 59);
            this.button_unistallDevicePackages.TabIndex = 2;
            this.button_unistallDevicePackages.Text = "Unistall";
            this.button_unistallDevicePackages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_unistallDevicePackages.UseVisualStyleBackColor = false;
            this.button_unistallDevicePackages.Click += new System.EventHandler(this.button_unistallDevicePackages_Click);
            // 
            // panel_righteButton
            // 
            this.panel_righteButton.Controls.Add(this.button_backupDevicePackages);
            this.panel_righteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_righteButton.Location = new System.Drawing.Point(245, 0);
            this.panel_righteButton.Name = "panel_righteButton";
            this.panel_righteButton.Size = new System.Drawing.Size(173, 59);
            this.panel_righteButton.TabIndex = 3;
            // 
            // button_backupDevicePackages
            // 
            this.button_backupDevicePackages.BackColor = System.Drawing.Color.Aquamarine;
            this.button_backupDevicePackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_backupDevicePackages.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_backupDevicePackages.FlatAppearance.BorderSize = 0;
            this.button_backupDevicePackages.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_backupDevicePackages.Image = global::AndroidManager_SHW.Properties.Resources.pm_backup;
            this.button_backupDevicePackages.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_backupDevicePackages.Location = new System.Drawing.Point(0, 0);
            this.button_backupDevicePackages.Name = "button_backupDevicePackages";
            this.button_backupDevicePackages.Size = new System.Drawing.Size(173, 59);
            this.button_backupDevicePackages.TabIndex = 2;
            this.button_backupDevicePackages.Text = "Backup";
            this.button_backupDevicePackages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_backupDevicePackages.UseVisualStyleBackColor = false;
            this.button_backupDevicePackages.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // panel_leftHeader
            // 
            this.panel_leftHeader.Controls.Add(this.label_titleDevicePackages);
            this.panel_leftHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_leftHeader.Location = new System.Drawing.Point(0, 0);
            this.panel_leftHeader.Name = "panel_leftHeader";
            this.panel_leftHeader.Size = new System.Drawing.Size(418, 40);
            this.panel_leftHeader.TabIndex = 1;
            // 
            // backgroundWorker_setDataGridView
            // 
            this.backgroundWorker_setDataGridView.WorkerReportsProgress = true;
            this.backgroundWorker_setDataGridView.WorkerSupportsCancellation = true;
            this.backgroundWorker_setDataGridView.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_setDataGridView_DoWork);
            this.backgroundWorker_setDataGridView.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_setDataGridView_ProgressChanged);
            this.backgroundWorker_setDataGridView.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_setDataGridView_RunWorkerCompleted);
            // 
            // openFileDialog_apk
            // 
            this.openFileDialog_apk.Filter = "Android Package|*.apk";
            this.openFileDialog_apk.Multiselect = true;
            // 
            // backgroundWorker_unistallPackages
            // 
            this.backgroundWorker_unistallPackages.WorkerReportsProgress = true;
            this.backgroundWorker_unistallPackages.WorkerSupportsCancellation = true;
            this.backgroundWorker_unistallPackages.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_unistallPackages_DoWork);
            this.backgroundWorker_unistallPackages.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_unistallPackages_ProgressChanged);
            this.backgroundWorker_unistallPackages.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_unistallPackages_RunWorkerCompleted);
            // 
            // backgroundWorker_installPackages
            // 
            this.backgroundWorker_installPackages.WorkerReportsProgress = true;
            this.backgroundWorker_installPackages.WorkerSupportsCancellation = true;
            this.backgroundWorker_installPackages.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_installPackages_DoWork);
            this.backgroundWorker_installPackages.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_installPackages_ProgressChanged);
            this.backgroundWorker_installPackages.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_installPackages_RunWorkerCompleted);
            // 
            // backgroundWorker_backupPackages
            // 
            this.backgroundWorker_backupPackages.WorkerReportsProgress = true;
            this.backgroundWorker_backupPackages.WorkerSupportsCancellation = true;
            this.backgroundWorker_backupPackages.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_backupPackages_DoWork);
            this.backgroundWorker_backupPackages.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_backupPackages_ProgressChanged);
            this.backgroundWorker_backupPackages.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_backupPackages_RunWorkerCompleted);
            // 
            // PMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 731);
            this.Controls.Add(this.panel_leftSide);
            this.Controls.Add(this.panel_rightSide);
            this.Controls.Add(this.panel_details);
            this.MinimumSize = new System.Drawing.Size(728, 500);
            //this.Name = "PMForm";
            this.ShowIcon = false;
            this.Text = "Package Manager";
            this.Load += new System.EventHandler(this.PMForm_Load);
            this.panel_details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_rightSide.ResumeLayout(false);
            this.panel_rightTools.ResumeLayout(false);
            this.panel_rightFooter.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_rightHeader.ResumeLayout(false);
            this.panel_leftSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_devicePackages)).EndInit();
            this.contextMenuStrip_dataGridView.ResumeLayout(false);
            this.panel_leftSearch.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_searchIcon)).EndInit();
            this.panel_leftFooter.ResumeLayout(false);
            this.panel_leftButton.ResumeLayout(false);
            this.panel_righteButton.ResumeLayout(false);
            this.panel_leftHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_details;
        private System.Windows.Forms.Label label_titleTempPackages;
        private System.Windows.Forms.Label label_titleDevicePackages;
        private System.Windows.Forms.Panel panel_rightSide;
        private System.Windows.Forms.Panel panel_rightHeader;
        private System.Windows.Forms.Panel panel_leftSide;
        private System.Windows.Forms.Panel panel_leftHeader;
        private System.Windows.Forms.Panel panel_rightFooter;
        private System.Windows.Forms.Panel panel_leftFooter;
        private System.Windows.Forms.Panel panel_leftSearch;
        private System.Windows.Forms.Panel panel_rightTools;
        private System.Windows.Forms.Button button_addTempPackages;
        private System.Windows.Forms.Button button_removeTempPackages;
        private System.Windows.Forms.RadioButton radioButton_externalMemory;
        private System.Windows.Forms.RadioButton radioButton_internalMemory;
        private System.Windows.Forms.ProgressBar progressBar_statePackage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_statePackage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_installTempPackages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_unistallDevicePackages;
        private System.Windows.Forms.Label label_namePackage;
        private System.Windows.Forms.Label label_addressPackage;
        private System.Windows.Forms.ListBox listBox_tempPackages;
        private System.Windows.Forms.DataGridView dataGridView_devicePackages;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox_searchIcon;
        private System.ComponentModel.BackgroundWorker backgroundWorker_setDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.OpenFileDialog openFileDialog_apk;
        private System.ComponentModel.BackgroundWorker backgroundWorker_unistallPackages;
        private System.ComponentModel.BackgroundWorker backgroundWorker_installPackages;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_dataGridView;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unistallToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker_backupPackages;
        private System.Windows.Forms.Button button_backupDevicePackages;
        private System.Windows.Forms.Panel panel_leftButton;
        private System.Windows.Forms.Panel panel_righteButton;
    }
}