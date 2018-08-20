namespace AndroidManager_SHW
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.label_state = new System.Windows.Forms.Label();
            this.panel_leftSide = new System.Windows.Forms.Panel();
            this.panel_upLeftSide = new System.Windows.Forms.Panel();
            this.panel_errorDeviceTest = new System.Windows.Forms.Panel();
            this.pictureBox_onMobileState = new System.Windows.Forms.PictureBox();
            this.button_mobileState = new System.Windows.Forms.Button();
            this.label_devices = new System.Windows.Forms.Label();
            this.comboBox_devices = new System.Windows.Forms.ComboBox();
            this.label_serial = new System.Windows.Forms.Label();
            this.label_model = new System.Windows.Forms.Label();
            this.label_vAndroid = new System.Windows.Forms.Label();
            this.label_battery = new System.Windows.Forms.Label();
            this.button_network = new System.Windows.Forms.Button();
            this.button_reconnect = new System.Windows.Forms.Button();
            this.button_check = new System.Windows.Forms.Button();
            this.panel_downLeftSide = new System.Windows.Forms.Panel();
            this.panel_dslL = new System.Windows.Forms.Panel();
            this.panel_dlsR = new System.Windows.Forms.Panel();
            this.button_state = new System.Windows.Forms.Button();
            this.toolTip_fileManager = new System.Windows.Forms.ToolTip(this.components);
            this.button_backupDirectory = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.button_setting = new System.Windows.Forms.Button();
            this.button_shutdown = new System.Windows.Forms.Button();
            this.button_software = new System.Windows.Forms.Button();
            this.button_fileManager = new System.Windows.Forms.Button();
            this.panel_rightSide = new System.Windows.Forms.Panel();
            this.backgroundWorker_refreshCombo = new System.ComponentModel.BackgroundWorker();
            this.timer_event = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip_reboot = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rebootToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recoveryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bootloaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker_installApk = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_reconnectDevice = new System.ComponentModel.BackgroundWorker();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel_leftSide.SuspendLayout();
            this.panel_upLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_onMobileState)).BeginInit();
            this.panel_downLeftSide.SuspendLayout();
            this.panel_dslL.SuspendLayout();
            this.panel_dlsR.SuspendLayout();
            this.panel_rightSide.SuspendLayout();
            this.contextMenuStrip_reboot.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_state
            // 
            this.label_state.BackColor = System.Drawing.Color.Transparent;
            this.label_state.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_state.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_state.ForeColor = System.Drawing.Color.Black;
            this.label_state.Location = new System.Drawing.Point(0, 0);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(266, 35);
            this.label_state.TabIndex = 0;
            this.label_state.Text = "State";
            this.label_state.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_leftSide
            // 
            this.panel_leftSide.Controls.Add(this.panel_upLeftSide);
            this.panel_leftSide.Controls.Add(this.panel_downLeftSide);
            this.panel_leftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_leftSide.Location = new System.Drawing.Point(0, 0);
            this.panel_leftSide.Name = "panel_leftSide";
            this.panel_leftSide.Size = new System.Drawing.Size(301, 603);
            this.panel_leftSide.TabIndex = 4;
            // 
            // panel_upLeftSide
            // 
            this.panel_upLeftSide.BackColor = System.Drawing.Color.Ivory;
            this.panel_upLeftSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_upLeftSide.Controls.Add(this.panel_errorDeviceTest);
            this.panel_upLeftSide.Controls.Add(this.pictureBox_onMobileState);
            this.panel_upLeftSide.Controls.Add(this.button_mobileState);
            this.panel_upLeftSide.Controls.Add(this.label_devices);
            this.panel_upLeftSide.Controls.Add(this.comboBox_devices);
            this.panel_upLeftSide.Controls.Add(this.label_serial);
            this.panel_upLeftSide.Controls.Add(this.label_model);
            this.panel_upLeftSide.Controls.Add(this.label_vAndroid);
            this.panel_upLeftSide.Controls.Add(this.label_battery);
            this.panel_upLeftSide.Controls.Add(this.button_network);
            this.panel_upLeftSide.Controls.Add(this.button_reconnect);
            this.panel_upLeftSide.Controls.Add(this.button_check);
            this.panel_upLeftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_upLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panel_upLeftSide.Name = "panel_upLeftSide";
            this.panel_upLeftSide.Size = new System.Drawing.Size(301, 568);
            this.panel_upLeftSide.TabIndex = 5;
            this.panel_upLeftSide.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_upLeftSide_DragDrop);
            this.panel_upLeftSide.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_upLeftSide_DragEnter);
            this.panel_upLeftSide.DragLeave += new System.EventHandler(this.panel_upLeftSide_DragLeave);
            this.panel_upLeftSide.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_upLeftSide_Paint);
            // 
            // panel_errorDeviceTest
            // 
            this.panel_errorDeviceTest.BackColor = System.Drawing.Color.Crimson;
            this.panel_errorDeviceTest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_errorDeviceTest.Enabled = false;
            this.panel_errorDeviceTest.Location = new System.Drawing.Point(0, 565);
            this.panel_errorDeviceTest.Name = "panel_errorDeviceTest";
            this.panel_errorDeviceTest.Size = new System.Drawing.Size(301, 3);
            this.panel_errorDeviceTest.TabIndex = 5;
            this.panel_errorDeviceTest.Visible = false;
            // 
            // pictureBox_onMobileState
            // 
            this.pictureBox_onMobileState.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_onMobileState.Image = global::AndroidManager_SHW.Properties.Resources.network;
            this.pictureBox_onMobileState.Location = new System.Drawing.Point(90, 321);
            this.pictureBox_onMobileState.Name = "pictureBox_onMobileState";
            this.pictureBox_onMobileState.Size = new System.Drawing.Size(126, 190);
            this.pictureBox_onMobileState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_onMobileState.TabIndex = 4;
            this.pictureBox_onMobileState.TabStop = false;
            this.pictureBox_onMobileState.Visible = false;
            // 
            // button_mobileState
            // 
            this.button_mobileState.BackColor = System.Drawing.Color.Transparent;
            this.button_mobileState.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.mobileNewOnline;
            this.button_mobileState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_mobileState.Enabled = false;
            this.button_mobileState.FlatAppearance.BorderSize = 0;
            this.button_mobileState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mobileState.Location = new System.Drawing.Point(25, 288);
            this.button_mobileState.Name = "button_mobileState";
            this.button_mobileState.Size = new System.Drawing.Size(256, 256);
            this.button_mobileState.TabIndex = 3;
            this.button_mobileState.UseVisualStyleBackColor = false;
            // 
            // label_devices
            // 
            this.label_devices.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_devices.BackColor = System.Drawing.Color.Transparent;
            this.label_devices.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_devices.Location = new System.Drawing.Point(9, 36);
            this.label_devices.Name = "label_devices";
            this.label_devices.Size = new System.Drawing.Size(60, 30);
            this.label_devices.TabIndex = 0;
            this.label_devices.Text = "Device: ";
            this.label_devices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_devices
            // 
            this.comboBox_devices.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_devices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_devices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_devices.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_devices.Location = new System.Drawing.Point(75, 38);
            this.comboBox_devices.Name = "comboBox_devices";
            this.comboBox_devices.Size = new System.Drawing.Size(183, 28);
            this.comboBox_devices.TabIndex = 2;
            this.comboBox_devices.SelectedIndexChanged += new System.EventHandler(this.comboBox_devices_SelectedIndexChanged);
            // 
            // label_serial
            // 
            this.label_serial.BackColor = System.Drawing.Color.Transparent;
            this.label_serial.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_serial.Location = new System.Drawing.Point(34, 170);
            this.label_serial.Name = "label_serial";
            this.label_serial.Size = new System.Drawing.Size(238, 26);
            this.label_serial.TabIndex = 0;
            this.label_serial.Text = "Serial";
            this.label_serial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_model
            // 
            this.label_model.BackColor = System.Drawing.Color.Transparent;
            this.label_model.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_model.Location = new System.Drawing.Point(34, 132);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(238, 26);
            this.label_model.TabIndex = 0;
            this.label_model.Text = "Model";
            this.label_model.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_vAndroid
            // 
            this.label_vAndroid.BackColor = System.Drawing.Color.Transparent;
            this.label_vAndroid.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vAndroid.Location = new System.Drawing.Point(34, 246);
            this.label_vAndroid.Name = "label_vAndroid";
            this.label_vAndroid.Size = new System.Drawing.Size(238, 26);
            this.label_vAndroid.TabIndex = 0;
            this.label_vAndroid.Text = "Version";
            this.label_vAndroid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_battery
            // 
            this.label_battery.BackColor = System.Drawing.Color.Transparent;
            this.label_battery.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_battery.Location = new System.Drawing.Point(34, 208);
            this.label_battery.Name = "label_battery";
            this.label_battery.Size = new System.Drawing.Size(238, 26);
            this.label_battery.TabIndex = 0;
            this.label_battery.Text = "Battery";
            this.label_battery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_network
            // 
            this.button_network.BackColor = System.Drawing.Color.LightCyan;
            this.button_network.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_network.FlatAppearance.BorderSize = 0;
            this.button_network.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_network.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_network.Location = new System.Drawing.Point(204, 72);
            this.button_network.Name = "button_network";
            this.button_network.Size = new System.Drawing.Size(88, 28);
            this.button_network.TabIndex = 1;
            this.button_network.Text = "Network";
            this.toolTip_fileManager.SetToolTip(this.button_network, "just if you have adb over the network on developer options");
            this.button_network.UseVisualStyleBackColor = false;
            this.button_network.Click += new System.EventHandler(this.button_network_Click);
            // 
            // button_reconnect
            // 
            this.button_reconnect.BackColor = System.Drawing.SystemColors.Control;
            this.button_reconnect.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_reconnect.FlatAppearance.BorderSize = 0;
            this.button_reconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reconnect.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reconnect.Location = new System.Drawing.Point(75, 72);
            this.button_reconnect.Name = "button_reconnect";
            this.button_reconnect.Size = new System.Drawing.Size(123, 28);
            this.button_reconnect.TabIndex = 1;
            this.button_reconnect.Text = "Reconnect";
            this.button_reconnect.UseVisualStyleBackColor = false;
            this.button_reconnect.Click += new System.EventHandler(this.button_reconnect_Click);
            // 
            // button_check
            // 
            this.button_check.BackColor = System.Drawing.Color.Transparent;
            this.button_check.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.refresh_shield8;
            this.button_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_check.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_check.FlatAppearance.BorderSize = 0;
            this.button_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_check.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_check.Location = new System.Drawing.Point(264, 38);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(28, 28);
            this.button_check.TabIndex = 1;
            this.toolTip_fileManager.SetToolTip(this.button_check, "Refresh Device List");
            this.button_check.UseVisualStyleBackColor = false;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            this.button_check.MouseLeave += new System.EventHandler(this.button_check_MouseLeave);
            this.button_check.MouseHover += new System.EventHandler(this.button_check_MouseHover);
            // 
            // panel_downLeftSide
            // 
            this.panel_downLeftSide.BackColor = System.Drawing.Color.Silver;
            this.panel_downLeftSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_downLeftSide.Controls.Add(this.panel_dslL);
            this.panel_downLeftSide.Controls.Add(this.panel_dlsR);
            this.panel_downLeftSide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_downLeftSide.Location = new System.Drawing.Point(0, 568);
            this.panel_downLeftSide.Name = "panel_downLeftSide";
            this.panel_downLeftSide.Size = new System.Drawing.Size(301, 35);
            this.panel_downLeftSide.TabIndex = 5;
            // 
            // panel_dslL
            // 
            this.panel_dslL.BackColor = System.Drawing.Color.Transparent;
            this.panel_dslL.Controls.Add(this.label_state);
            this.panel_dslL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dslL.Location = new System.Drawing.Point(0, 0);
            this.panel_dslL.Name = "panel_dslL";
            this.panel_dslL.Size = new System.Drawing.Size(266, 35);
            this.panel_dslL.TabIndex = 1;
            // 
            // panel_dlsR
            // 
            this.panel_dlsR.BackColor = System.Drawing.Color.Transparent;
            this.panel_dlsR.Controls.Add(this.button_state);
            this.panel_dlsR.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_dlsR.Location = new System.Drawing.Point(266, 0);
            this.panel_dlsR.Name = "panel_dlsR";
            this.panel_dlsR.Size = new System.Drawing.Size(35, 35);
            this.panel_dlsR.TabIndex = 0;
            // 
            // button_state
            // 
            this.button_state.BackColor = System.Drawing.Color.Transparent;
            this.button_state.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.info;
            this.button_state.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_state.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_state.FlatAppearance.BorderSize = 0;
            this.button_state.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_state.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_state.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_state.Location = new System.Drawing.Point(0, 0);
            this.button_state.Name = "button_state";
            this.button_state.Size = new System.Drawing.Size(35, 35);
            this.button_state.TabIndex = 8;
            this.toolTip_fileManager.SetToolTip(this.button_state, "informations about instaltions state");
            this.button_state.UseVisualStyleBackColor = false;
            this.button_state.Visible = false;
            this.button_state.Click += new System.EventHandler(this.button_state_Click);
            this.button_state.MouseLeave += new System.EventHandler(this.button_state_MouseLeave);
            this.button_state.MouseHover += new System.EventHandler(this.button_state_MouseHover);
            // 
            // toolTip_fileManager
            // 
            this.toolTip_fileManager.BackColor = System.Drawing.Color.MediumAquamarine;
            this.toolTip_fileManager.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolTip_fileManager.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_fileManager.ToolTipTitle = "details";
            // 
            // button_backupDirectory
            // 
            this.button_backupDirectory.BackColor = System.Drawing.Color.Transparent;
            this.button_backupDirectory.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.backup8Orange;
            this.button_backupDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_backupDirectory.FlatAppearance.BorderSize = 0;
            this.button_backupDirectory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_backupDirectory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_backupDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_backupDirectory.Location = new System.Drawing.Point(15, 456);
            this.button_backupDirectory.Name = "button_backupDirectory";
            this.button_backupDirectory.Size = new System.Drawing.Size(55, 55);
            this.button_backupDirectory.TabIndex = 8;
            this.toolTip_fileManager.SetToolTip(this.button_backupDirectory, "Backup Path | you can go to Backup path rapidly");
            this.button_backupDirectory.UseVisualStyleBackColor = false;
            this.button_backupDirectory.Click += new System.EventHandler(this.button_backupDirectory_Click);
            this.button_backupDirectory.MouseLeave += new System.EventHandler(this.button_backupDirectory_MouseLeave);
            this.button_backupDirectory.MouseHover += new System.EventHandler(this.button_backupDirectory_MouseHover);
            // 
            // button_about
            // 
            this.button_about.BackColor = System.Drawing.Color.Transparent;
            this.button_about.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.about8;
            this.button_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_about.FlatAppearance.BorderSize = 0;
            this.button_about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Location = new System.Drawing.Point(15, 536);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(55, 55);
            this.button_about.TabIndex = 8;
            this.toolTip_fileManager.SetToolTip(this.button_about, "About | Version and Programmer");
            this.button_about.UseVisualStyleBackColor = false;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            this.button_about.MouseLeave += new System.EventHandler(this.button_about_MouseLeave);
            this.button_about.MouseHover += new System.EventHandler(this.button_about_MouseHover);
            // 
            // button_setting
            // 
            this.button_setting.BackColor = System.Drawing.Color.Transparent;
            this.button_setting.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.sett8h;
            this.button_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_setting.FlatAppearance.BorderSize = 0;
            this.button_setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_setting.Location = new System.Drawing.Point(15, 200);
            this.button_setting.Name = "button_setting";
            this.button_setting.Size = new System.Drawing.Size(55, 55);
            this.button_setting.TabIndex = 8;
            this.toolTip_fileManager.SetToolTip(this.button_setting, "Setting | you can change default options and view all backup paths");
            this.button_setting.UseVisualStyleBackColor = false;
            this.button_setting.Click += new System.EventHandler(this.button_setting_Click);
            this.button_setting.MouseLeave += new System.EventHandler(this.button_setting_MouseLeave);
            this.button_setting.MouseHover += new System.EventHandler(this.button_setting_MouseHover);
            // 
            // button_shutdown
            // 
            this.button_shutdown.BackColor = System.Drawing.Color.Transparent;
            this.button_shutdown.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.power8;
            this.button_shutdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_shutdown.FlatAppearance.BorderSize = 0;
            this.button_shutdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_shutdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_shutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_shutdown.Location = new System.Drawing.Point(15, 287);
            this.button_shutdown.Name = "button_shutdown";
            this.button_shutdown.Size = new System.Drawing.Size(55, 55);
            this.button_shutdown.TabIndex = 6;
            this.toolTip_fileManager.SetToolTip(this.button_shutdown, "Power | you can restart & shutdown & go to recovery mod & go to bootloader mod");
            this.button_shutdown.UseVisualStyleBackColor = false;
            this.button_shutdown.Click += new System.EventHandler(this.button_shutdown_Click);
            this.button_shutdown.MouseLeave += new System.EventHandler(this.pictureBox_code_MouseLeave);
            this.button_shutdown.MouseHover += new System.EventHandler(this.pictureBox_code_MouseHover);
            // 
            // button_software
            // 
            this.button_software.BackColor = System.Drawing.Color.Transparent;
            this.button_software.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.soft8h;
            this.button_software.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_software.FlatAppearance.BorderSize = 0;
            this.button_software.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_software.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_software.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_software.Location = new System.Drawing.Point(15, 113);
            this.button_software.Name = "button_software";
            this.button_software.Size = new System.Drawing.Size(55, 55);
            this.button_software.TabIndex = 5;
            this.toolTip_fileManager.SetToolTip(this.button_software, "Package manager | you can install and unistall,backup apps...");
            this.button_software.UseVisualStyleBackColor = false;
            this.button_software.Click += new System.EventHandler(this.button_software_Click);
            this.button_software.MouseLeave += new System.EventHandler(this.pictureBox_software_MouseLeave);
            this.button_software.MouseHover += new System.EventHandler(this.pictureBox_software_MouseHover);
            // 
            // button_fileManager
            // 
            this.button_fileManager.BackColor = System.Drawing.Color.Transparent;
            this.button_fileManager.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.file8h;
            this.button_fileManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_fileManager.FlatAppearance.BorderSize = 0;
            this.button_fileManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_fileManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_fileManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fileManager.Location = new System.Drawing.Point(15, 26);
            this.button_fileManager.Name = "button_fileManager";
            this.button_fileManager.Size = new System.Drawing.Size(55, 55);
            this.button_fileManager.TabIndex = 4;
            this.toolTip_fileManager.SetToolTip(this.button_fileManager, "File manager | you can copy,cut,delete,upload,backup ...");
            this.button_fileManager.UseVisualStyleBackColor = false;
            this.button_fileManager.Click += new System.EventHandler(this.button_fileManager_Click);
            this.button_fileManager.MouseLeave += new System.EventHandler(this.pictureBox_fileManager_MouseLeave);
            this.button_fileManager.MouseHover += new System.EventHandler(this.pictureBox_fileManager_MouseHover);
            // 
            // panel_rightSide
            // 
            this.panel_rightSide.BackColor = System.Drawing.Color.White;
            this.panel_rightSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_rightSide.Controls.Add(this.button_backupDirectory);
            this.panel_rightSide.Controls.Add(this.button_about);
            this.panel_rightSide.Controls.Add(this.button_setting);
            this.panel_rightSide.Controls.Add(this.button_shutdown);
            this.panel_rightSide.Controls.Add(this.button_software);
            this.panel_rightSide.Controls.Add(this.button_fileManager);
            this.panel_rightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_rightSide.Location = new System.Drawing.Point(301, 0);
            this.panel_rightSide.Name = "panel_rightSide";
            this.panel_rightSide.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel_rightSide.Size = new System.Drawing.Size(81, 603);
            this.panel_rightSide.TabIndex = 5;
            // 
            // backgroundWorker_refreshCombo
            // 
            this.backgroundWorker_refreshCombo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_refreshCombo_DoWork);
            this.backgroundWorker_refreshCombo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_refreshCombo_RunWorkerCompleted);
            // 
            // timer_event
            // 
            this.timer_event.Enabled = true;
            this.timer_event.Interval = 1000;
            this.timer_event.Tick += new System.EventHandler(this.timer_event_Tick);
            // 
            // contextMenuStrip_reboot
            // 
            this.contextMenuStrip_reboot.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip_reboot.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_reboot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rebootToolStripMenuItem1,
            this.shutdownToolStripMenuItem1,
            this.toolStripSeparator1,
            this.recoveryToolStripMenuItem1,
            this.bootloaderToolStripMenuItem});
            this.contextMenuStrip_reboot.Name = "contextMenuStrip_reboot";
            this.contextMenuStrip_reboot.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip_reboot.Size = new System.Drawing.Size(215, 142);
            // 
            // rebootToolStripMenuItem1
            // 
            this.rebootToolStripMenuItem1.Image = global::AndroidManager_SHW.Properties.Resources.con_reboot;
            this.rebootToolStripMenuItem1.Name = "rebootToolStripMenuItem1";
            this.rebootToolStripMenuItem1.Size = new System.Drawing.Size(214, 26);
            this.rebootToolStripMenuItem1.Text = "Reboot";
            this.rebootToolStripMenuItem1.Click += new System.EventHandler(this.rebootToolStripMenuItem_Click);
            // 
            // recoveryToolStripMenuItem1
            // 
            this.recoveryToolStripMenuItem1.Image = global::AndroidManager_SHW.Properties.Resources.con_recovery;
            this.recoveryToolStripMenuItem1.Name = "recoveryToolStripMenuItem1";
            this.recoveryToolStripMenuItem1.Size = new System.Drawing.Size(214, 26);
            this.recoveryToolStripMenuItem1.Text = "Recovery";
            this.recoveryToolStripMenuItem1.Click += new System.EventHandler(this.recoveryToolStripMenuItem_Click);
            // 
            // bootloaderToolStripMenuItem
            // 
            this.bootloaderToolStripMenuItem.Image = global::AndroidManager_SHW.Properties.Resources.con_bootloader;
            this.bootloaderToolStripMenuItem.Name = "bootloaderToolStripMenuItem";
            this.bootloaderToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.bootloaderToolStripMenuItem.Text = "Bootloader";
            this.bootloaderToolStripMenuItem.Click += new System.EventHandler(this.bootloaderToolStripMenuItem_Click);
            // 
            // shutdownToolStripMenuItem1
            // 
            this.shutdownToolStripMenuItem1.Image = global::AndroidManager_SHW.Properties.Resources.con_shutdown;
            this.shutdownToolStripMenuItem1.Name = "shutdownToolStripMenuItem1";
            this.shutdownToolStripMenuItem1.Size = new System.Drawing.Size(214, 26);
            this.shutdownToolStripMenuItem1.Text = "Shutdown";
            this.shutdownToolStripMenuItem1.Click += new System.EventHandler(this.shutdownToolStripMenuItem_Click);
            // 
            // backgroundWorker_installApk
            // 
            this.backgroundWorker_installApk.WorkerReportsProgress = true;
            this.backgroundWorker_installApk.WorkerSupportsCancellation = true;
            this.backgroundWorker_installApk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_installApk_DoWork);
            this.backgroundWorker_installApk.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_installApk_ProgressChanged);
            this.backgroundWorker_installApk.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_installApk_RunWorkerCompleted);
            // 
            // backgroundWorker_reconnectDevice
            // 
            this.backgroundWorker_reconnectDevice.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_reconnectDevice_DoWork);
            this.backgroundWorker_reconnectDevice.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_reconnectDevice_RunWorkerCompleted);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 603);
            this.Controls.Add(this.panel_rightSide);
            this.Controls.Add(this.panel_leftSide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 650);
            this.MinimumSize = new System.Drawing.Size(400, 650);
            this.Name = "HomeForm";
            this.Text = "ADB Manager SHW";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel_leftSide.ResumeLayout(false);
            this.panel_upLeftSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_onMobileState)).EndInit();
            this.panel_downLeftSide.ResumeLayout(false);
            this.panel_dslL.ResumeLayout(false);
            this.panel_dlsR.ResumeLayout(false);
            this.panel_rightSide.ResumeLayout(false);
            this.contextMenuStrip_reboot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Label label_devices;
        private System.Windows.Forms.Label label_vAndroid;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Label label_battery;
        private System.Windows.Forms.ComboBox comboBox_devices;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Panel panel_leftSide;
        private System.Windows.Forms.Panel panel_upLeftSide;
        private System.Windows.Forms.Panel panel_downLeftSide;
        private System.Windows.Forms.Panel panel_rightSide;
        private System.Windows.Forms.ToolTip toolTip_fileManager;
        private System.ComponentModel.BackgroundWorker backgroundWorker_refreshCombo;
        private System.Windows.Forms.Timer timer_event;
        private System.Windows.Forms.Button button_fileManager;
        private System.Windows.Forms.Button button_software;
        private System.Windows.Forms.Button button_shutdown;
        private System.Windows.Forms.Button button_setting;
        private System.Windows.Forms.Label label_serial;
        private System.Windows.Forms.Button button_network;
        private System.Windows.Forms.Button button_mobileState;
        private System.Windows.Forms.Button button_backupDirectory;
        private System.Windows.Forms.Button button_reconnect;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_reboot;
        private System.Windows.Forms.ToolStripMenuItem rebootToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recoveryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bootloaderToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker_installApk;
        private System.Windows.Forms.PictureBox pictureBox_onMobileState;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Button button_state;
        private System.Windows.Forms.Panel panel_dslL;
        private System.Windows.Forms.Panel panel_dlsR;
        private System.ComponentModel.BackgroundWorker backgroundWorker_reconnectDevice;
        private System.Windows.Forms.Panel panel_errorDeviceTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

