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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button_fileManager = new System.Windows.Forms.Button();
            this.label_model = new System.Windows.Forms.Label();
            this.label_devices = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_state = new System.Windows.Forms.Label();
            this.label_serial = new System.Windows.Forms.Label();
            this.label_usb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_devices = new System.Windows.Forms.ComboBox();
            this.button_check = new System.Windows.Forms.Button();
            this.button_select = new System.Windows.Forms.Button();
            this.panel_leftSide = new System.Windows.Forms.Panel();
            this.panel_upLeftSide = new System.Windows.Forms.Panel();
            this.panel_downLeftSide = new System.Windows.Forms.Panel();
            this.panel_rightSide = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_leftSide.SuspendLayout();
            this.panel_upLeftSide.SuspendLayout();
            this.panel_downLeftSide.SuspendLayout();
            this.panel_rightSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Package Manager";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 60);
            this.button3.TabIndex = 0;
            this.button3.Text = "Advanced Code";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 336);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 60);
            this.button4.TabIndex = 0;
            this.button4.Text = "Back Up";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button_fileManager
            // 
            this.button_fileManager.Location = new System.Drawing.Point(25, 72);
            this.button_fileManager.Name = "button_fileManager";
            this.button_fileManager.Size = new System.Drawing.Size(135, 60);
            this.button_fileManager.TabIndex = 0;
            this.button_fileManager.Text = "File Manager";
            this.button_fileManager.UseVisualStyleBackColor = true;
            this.button_fileManager.Click += new System.EventHandler(this.button_fileManager_Click);
            // 
            // label_model
            // 
            this.label_model.Location = new System.Drawing.Point(12, 126);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(145, 20);
            this.label_model.TabIndex = 0;
            this.label_model.Text = "Model";
            // 
            // label_devices
            // 
            this.label_devices.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_devices.Location = new System.Drawing.Point(96, 9);
            this.label_devices.Name = "label_devices";
            this.label_devices.Size = new System.Drawing.Size(101, 30);
            this.label_devices.TabIndex = 0;
            this.label_devices.Text = "Devices";
            this.label_devices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_name
            // 
            this.label_name.Location = new System.Drawing.Point(12, 160);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(145, 20);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // label_state
            // 
            this.label_state.Location = new System.Drawing.Point(3, 9);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(266, 17);
            this.label_state.TabIndex = 0;
            this.label_state.Text = "State";
            // 
            // label_serial
            // 
            this.label_serial.Location = new System.Drawing.Point(12, 194);
            this.label_serial.Name = "label_serial";
            this.label_serial.Size = new System.Drawing.Size(145, 20);
            this.label_serial.TabIndex = 0;
            this.label_serial.Text = "Serial";
            // 
            // label_usb
            // 
            this.label_usb.Location = new System.Drawing.Point(12, 228);
            this.label_usb.Name = "label_usb";
            this.label_usb.Size = new System.Drawing.Size(145, 20);
            this.label_usb.TabIndex = 0;
            this.label_usb.Text = "USB";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_devices
            // 
            this.comboBox_devices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_devices.Location = new System.Drawing.Point(12, 42);
            this.comboBox_devices.Name = "comboBox_devices";
            this.comboBox_devices.Size = new System.Drawing.Size(175, 24);
            this.comboBox_devices.TabIndex = 2;
            // 
            // button_check
            // 
            this.button_check.Location = new System.Drawing.Point(192, 42);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(106, 28);
            this.button_check.TabIndex = 3;
            this.button_check.Text = "Check";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(95, 72);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(92, 32);
            this.button_select.TabIndex = 3;
            this.button_select.Text = "Select";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
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
            this.panel_upLeftSide.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel_upLeftSide.Controls.Add(this.label_devices);
            this.panel_upLeftSide.Controls.Add(this.comboBox_devices);
            this.panel_upLeftSide.Controls.Add(this.pictureBox1);
            this.panel_upLeftSide.Controls.Add(this.label_model);
            this.panel_upLeftSide.Controls.Add(this.label_name);
            this.panel_upLeftSide.Controls.Add(this.label_usb);
            this.panel_upLeftSide.Controls.Add(this.label_serial);
            this.panel_upLeftSide.Controls.Add(this.button_select);
            this.panel_upLeftSide.Controls.Add(this.button_check);
            this.panel_upLeftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_upLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panel_upLeftSide.Name = "panel_upLeftSide";
            this.panel_upLeftSide.Size = new System.Drawing.Size(301, 568);
            this.panel_upLeftSide.TabIndex = 5;
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
            // panel_rightSide
            // 
            this.panel_rightSide.Controls.Add(this.button_fileManager);
            this.panel_rightSide.Controls.Add(this.button1);
            this.panel_rightSide.Controls.Add(this.button2);
            this.panel_rightSide.Controls.Add(this.button4);
            this.panel_rightSide.Controls.Add(this.button3);
            this.panel_rightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_rightSide.Location = new System.Drawing.Point(301, 0);
            this.panel_rightSide.Name = "panel_rightSide";
            this.panel_rightSide.Size = new System.Drawing.Size(181, 603);
            this.panel_rightSide.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 60);
            this.button2.TabIndex = 0;
            this.button2.Text = "Setting";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 603);
            this.Controls.Add(this.panel_rightSide);
            this.Controls.Add(this.panel_leftSide);
            this.MaximumSize = new System.Drawing.Size(500, 650);
            this.MinimumSize = new System.Drawing.Size(500, 650);
            this.Name = "HomeForm";
            this.Text = "Home Form";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_leftSide.ResumeLayout(false);
            this.panel_upLeftSide.ResumeLayout(false);
            this.panel_downLeftSide.ResumeLayout(false);
            this.panel_rightSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_fileManager;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Label label_devices;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Label label_serial;
        private System.Windows.Forms.Label label_usb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_devices;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Panel panel_leftSide;
        private System.Windows.Forms.Panel panel_upLeftSide;
        private System.Windows.Forms.Panel panel_downLeftSide;
        private System.Windows.Forms.Panel panel_rightSide;
        private System.Windows.Forms.Button button2;
    }
}

