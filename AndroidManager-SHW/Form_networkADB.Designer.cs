namespace AndroidManager_SHW
{
    partial class Form_networkADB
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_upStatus = new System.Windows.Forms.Panel();
            this.panel_downConnect = new System.Windows.Forms.Panel();
            this.label_ip = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.panel_upStatus.SuspendLayout();
            this.panel_downConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_downConnect);
            this.panel_main.Controls.Add(this.panel_upStatus);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(411, 97);
            this.panel_main.TabIndex = 0;
            // 
            // panel_upStatus
            // 
            this.panel_upStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(220)))), ((int)(((byte)(203)))));
            this.panel_upStatus.Controls.Add(this.label_title);
            this.panel_upStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_upStatus.Location = new System.Drawing.Point(0, 0);
            this.panel_upStatus.Name = "panel_upStatus";
            this.panel_upStatus.Size = new System.Drawing.Size(411, 40);
            this.panel_upStatus.TabIndex = 0;
            // 
            // panel_downConnect
            // 
            this.panel_downConnect.BackColor = System.Drawing.Color.White;
            this.panel_downConnect.Controls.Add(this.button_connect);
            this.panel_downConnect.Controls.Add(this.textBox_port);
            this.panel_downConnect.Controls.Add(this.label1);
            this.panel_downConnect.Controls.Add(this.textBox_ip);
            this.panel_downConnect.Controls.Add(this.label_ip);
            this.panel_downConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_downConnect.Location = new System.Drawing.Point(0, 40);
            this.panel_downConnect.Name = "panel_downConnect";
            this.panel_downConnect.Size = new System.Drawing.Size(411, 57);
            this.panel_downConnect.TabIndex = 1;
            // 
            // label_ip
            // 
            this.label_ip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ip.Location = new System.Drawing.Point(7, 18);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(36, 23);
            this.label_ip.TabIndex = 0;
            this.label_ip.Text = "IP:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ip.Location = new System.Drawing.Point(38, 16);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(143, 27);
            this.textBox_ip.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // textBox_port
            // 
            this.textBox_port.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_port.Location = new System.Drawing.Point(236, 16);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(52, 27);
            this.textBox_port.TabIndex = 2;
            // 
            // button_connect
            // 
            this.button_connect.BackColor = System.Drawing.Color.LightCyan;
            this.button_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_connect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_connect.Location = new System.Drawing.Point(302, 14);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(97, 31);
            this.button_connect.TabIndex = 3;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = false;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // label_title
            // 
            this.label_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(411, 40);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Connect State";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_networkADB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 97);
            this.Controls.Add(this.panel_main);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(429, 144);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(429, 144);
            this.Name = "Form_networkADB";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Network Connection";
            this.panel_main.ResumeLayout(false);
            this.panel_upStatus.ResumeLayout(false);
            this.panel_downConnect.ResumeLayout(false);
            this.panel_downConnect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_downConnect;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Panel panel_upStatus;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label_title;
    }
}