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
            this.label_model = new System.Windows.Forms.Label();
            this.label_devices = new System.Windows.Forms.Label();
            this.label_vAndroid = new System.Windows.Forms.Label();
            this.label_state = new System.Windows.Forms.Label();
            this.label_battery = new System.Windows.Forms.Label();
            this.comboBox_devices = new System.Windows.Forms.ComboBox();
            this.button_check = new System.Windows.Forms.Button();
            this.panel_leftSide = new System.Windows.Forms.Panel();
            this.panel_upLeftSide = new System.Windows.Forms.Panel();
            this.label_serial = new System.Windows.Forms.Label();
            this.button_network = new System.Windows.Forms.Button();
            this.panel_downLeftSide = new System.Windows.Forms.Panel();
            this.toolTip_fileManager = new System.Windows.Forms.ToolTip(this.components);
            this.button_software = new System.Windows.Forms.Button();
            this.button_fileManager = new System.Windows.Forms.Button();
            this.pictureBox_about = new System.Windows.Forms.PictureBox();
            this.panel_rightSide = new System.Windows.Forms.Panel();
            this.button_setting = new System.Windows.Forms.Button();
            this.button_code = new System.Windows.Forms.Button();
            this.backgroundWorker_refreshCombo = new System.ComponentModel.BackgroundWorker();
            this.timer_event = new System.Windows.Forms.Timer(this.components);
            this.panel_leftSide.SuspendLayout();
            this.panel_upLeftSide.SuspendLayout();
            this.panel_downLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_about)).BeginInit();
            this.panel_rightSide.SuspendLayout();
            this.SuspendLayout();
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
            // label_devices
            // 
            this.label_devices.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_devices.BackColor = System.Drawing.Color.Transparent;
            this.label_devices.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_devices.Location = new System.Drawing.Point(34, 36);
            this.label_devices.Name = "label_devices";
            this.label_devices.Size = new System.Drawing.Size(60, 30);
            this.label_devices.TabIndex = 0;
            this.label_devices.Text = "Device: ";
            this.label_devices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // label_state
            // 
            this.label_state.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_state.ForeColor = System.Drawing.Color.Black;
            this.label_state.Location = new System.Drawing.Point(3, 9);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(266, 17);
            this.label_state.TabIndex = 0;
            this.label_state.Text = "State";
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
            // comboBox_devices
            // 
            this.comboBox_devices.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_devices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_devices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_devices.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_devices.Location = new System.Drawing.Point(100, 38);
            this.comboBox_devices.Name = "comboBox_devices";
            this.comboBox_devices.Size = new System.Drawing.Size(174, 28);
            this.comboBox_devices.TabIndex = 2;
            this.comboBox_devices.SelectedIndexChanged += new System.EventHandler(this.comboBox_devices_SelectedIndexChanged);
            // 
            // button_check
            // 
            this.button_check.BackColor = System.Drawing.SystemColors.Control;
            this.button_check.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_check.FlatAppearance.BorderSize = 0;
            this.button_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_check.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_check.Location = new System.Drawing.Point(100, 72);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(79, 28);
            this.button_check.TabIndex = 1;
            this.button_check.Text = "Refresh";
            this.button_check.UseVisualStyleBackColor = false;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
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
            this.panel_upLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(213)))));
            this.panel_upLeftSide.Controls.Add(this.label_devices);
            this.panel_upLeftSide.Controls.Add(this.comboBox_devices);
            this.panel_upLeftSide.Controls.Add(this.label_serial);
            this.panel_upLeftSide.Controls.Add(this.label_model);
            this.panel_upLeftSide.Controls.Add(this.label_vAndroid);
            this.panel_upLeftSide.Controls.Add(this.label_battery);
            this.panel_upLeftSide.Controls.Add(this.button_network);
            this.panel_upLeftSide.Controls.Add(this.button_check);
            this.panel_upLeftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_upLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panel_upLeftSide.Name = "panel_upLeftSide";
            this.panel_upLeftSide.Size = new System.Drawing.Size(301, 568);
            this.panel_upLeftSide.TabIndex = 5;
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
            // button_network
            // 
            this.button_network.BackColor = System.Drawing.Color.LightCyan;
            this.button_network.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_network.FlatAppearance.BorderSize = 0;
            this.button_network.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_network.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_network.Location = new System.Drawing.Point(186, 72);
            this.button_network.Name = "button_network";
            this.button_network.Size = new System.Drawing.Size(88, 28);
            this.button_network.TabIndex = 1;
            this.button_network.Text = "Network";
            this.button_network.UseVisualStyleBackColor = false;
            this.button_network.Click += new System.EventHandler(this.button_network_Click);
            // 
            // panel_downLeftSide
            // 
            this.panel_downLeftSide.BackColor = System.Drawing.Color.LightGreen;
            this.panel_downLeftSide.Controls.Add(this.label_state);
            this.panel_downLeftSide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_downLeftSide.Location = new System.Drawing.Point(0, 568);
            this.panel_downLeftSide.Name = "panel_downLeftSide";
            this.panel_downLeftSide.Size = new System.Drawing.Size(301, 35);
            this.panel_downLeftSide.TabIndex = 5;
            // 
            // toolTip_fileManager
            // 
            this.toolTip_fileManager.BackColor = System.Drawing.Color.MediumAquamarine;
            this.toolTip_fileManager.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolTip_fileManager.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_fileManager.ToolTipTitle = "details";
            // 
            // button_software
            // 
            this.button_software.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.soft8h;
            this.button_software.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_software.FlatAppearance.BorderSize = 0;
            this.button_software.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_software.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_software.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_software.Location = new System.Drawing.Point(15, 106);
            this.button_software.Name = "button_software";
            this.button_software.Size = new System.Drawing.Size(55, 55);
            this.button_software.TabIndex = 5;
            this.toolTip_fileManager.SetToolTip(this.button_software, "Package manager | you can install and unistall,backup apps...");
            this.button_software.UseVisualStyleBackColor = true;
            this.button_software.Click += new System.EventHandler(this.pictureBox_software_Click);
            this.button_software.MouseLeave += new System.EventHandler(this.pictureBox_software_MouseLeave);
            this.button_software.MouseHover += new System.EventHandler(this.pictureBox_software_MouseHover);
            // 
            // button_fileManager
            // 
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
            this.button_fileManager.UseVisualStyleBackColor = true;
            this.button_fileManager.Click += new System.EventHandler(this.button_fileManager_Click);
            this.button_fileManager.MouseLeave += new System.EventHandler(this.pictureBox_fileManager_MouseLeave);
            this.button_fileManager.MouseHover += new System.EventHandler(this.pictureBox_fileManager_MouseHover);
            // 
            // pictureBox_about
            // 
            this.pictureBox_about.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_about.Image = global::AndroidManager_SHW.Properties.Resources.about8;
            this.pictureBox_about.Location = new System.Drawing.Point(15, 536);
            this.pictureBox_about.Name = "pictureBox_about";
            this.pictureBox_about.Size = new System.Drawing.Size(55, 55);
            this.pictureBox_about.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_about.TabIndex = 1;
            this.pictureBox_about.TabStop = false;
            this.toolTip_fileManager.SetToolTip(this.pictureBox_about, "About | you can know more about developer and program");
            this.pictureBox_about.Click += new System.EventHandler(this.pictureBox_about_Click);
            this.pictureBox_about.MouseLeave += new System.EventHandler(this.pictureBox_about_MouseLeave);
            this.pictureBox_about.MouseHover += new System.EventHandler(this.pictureBox_about_MouseHover);
            // 
            // panel_rightSide
            // 
            this.panel_rightSide.BackColor = System.Drawing.Color.White;
            this.panel_rightSide.Controls.Add(this.button_setting);
            this.panel_rightSide.Controls.Add(this.button_code);
            this.panel_rightSide.Controls.Add(this.button_software);
            this.panel_rightSide.Controls.Add(this.button_fileManager);
            this.panel_rightSide.Controls.Add(this.pictureBox_about);
            this.panel_rightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_rightSide.Location = new System.Drawing.Point(301, 0);
            this.panel_rightSide.Name = "panel_rightSide";
            this.panel_rightSide.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel_rightSide.Size = new System.Drawing.Size(81, 603);
            this.panel_rightSide.TabIndex = 5;
            // 
            // button_setting
            // 
            this.button_setting.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.sett8h;
            this.button_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_setting.FlatAppearance.BorderSize = 0;
            this.button_setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_setting.Location = new System.Drawing.Point(15, 266);
            this.button_setting.Name = "button_setting";
            this.button_setting.Size = new System.Drawing.Size(55, 55);
            this.button_setting.TabIndex = 8;
            this.button_setting.UseVisualStyleBackColor = true;
            this.button_setting.Click += new System.EventHandler(this.pictureBox_software_Click);
            this.button_setting.MouseLeave += new System.EventHandler(this.pictureBox_setting_MouseLeave);
            this.button_setting.MouseHover += new System.EventHandler(this.pictureBox_setting_MouseHover);
            // 
            // button_code
            // 
            this.button_code.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.code8h;
            this.button_code.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_code.FlatAppearance.BorderSize = 0;
            this.button_code.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_code.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_code.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_code.Location = new System.Drawing.Point(15, 186);
            this.button_code.Name = "button_code";
            this.button_code.Size = new System.Drawing.Size(55, 55);
            this.button_code.TabIndex = 6;
            this.button_code.UseVisualStyleBackColor = true;
            this.button_code.Click += new System.EventHandler(this.pictureBox_software_Click);
            this.button_code.MouseLeave += new System.EventHandler(this.pictureBox_code_MouseLeave);
            this.button_code.MouseHover += new System.EventHandler(this.pictureBox_code_MouseHover);
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
            this.panel_downLeftSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_about)).EndInit();
            this.panel_rightSide.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox_about;
        private System.Windows.Forms.ToolTip toolTip_fileManager;
        private System.ComponentModel.BackgroundWorker backgroundWorker_refreshCombo;
        private System.Windows.Forms.Timer timer_event;
        private System.Windows.Forms.Button button_fileManager;
        private System.Windows.Forms.Button button_software;
        private System.Windows.Forms.Button button_code;
        private System.Windows.Forms.Button button_setting;
        private System.Windows.Forms.Label label_serial;
        private System.Windows.Forms.Button button_network;
    }
}

