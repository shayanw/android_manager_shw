namespace AndroidManager_SHW.PackageManagerDir.ControlDir
{
    partial class apkStateInstallUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(apkStateInstallUserControl));
            this.label_nameApk = new System.Windows.Forms.Label();
            this.label_line = new System.Windows.Forms.Label();
            this.pictureBox_stateInstall = new System.Windows.Forms.PictureBox();
            this.pictureBox_memory = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_stateInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_memory)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nameApk
            // 
            this.label_nameApk.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nameApk.Location = new System.Drawing.Point(39, 0);
            this.label_nameApk.Name = "label_nameApk";
            this.label_nameApk.Size = new System.Drawing.Size(232, 38);
            this.label_nameApk.TabIndex = 2;
            this.label_nameApk.Text = "co.pxhouse.done_1.6.3.apk";
            this.label_nameApk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_line
            // 
            this.label_line.BackColor = System.Drawing.Color.Silver;
            this.label_line.Location = new System.Drawing.Point(43, 37);
            this.label_line.Name = "label_line";
            this.label_line.Size = new System.Drawing.Size(225, 1);
            this.label_line.TabIndex = 3;
            // 
            // pictureBox_stateInstall
            // 
            this.pictureBox_stateInstall.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_stateInstall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_stateInstall.BackgroundImage")));
            this.pictureBox_stateInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_stateInstall.Location = new System.Drawing.Point(272, 5);
            this.pictureBox_stateInstall.Name = "pictureBox_stateInstall";
            this.pictureBox_stateInstall.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_stateInstall.TabIndex = 1;
            this.pictureBox_stateInstall.TabStop = false;
            // 
            // pictureBox_memory
            // 
            this.pictureBox_memory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_memory.BackgroundImage")));
            this.pictureBox_memory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_memory.Location = new System.Drawing.Point(8, 5);
            this.pictureBox_memory.Name = "pictureBox_memory";
            this.pictureBox_memory.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_memory.TabIndex = 0;
            this.pictureBox_memory.TabStop = false;
            this.pictureBox_memory.Click += new System.EventHandler(this.pictureBox_memory_Click);
            // 
            // apkStateInstallUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox_stateInstall);
            this.Controls.Add(this.pictureBox_memory);
            this.Controls.Add(this.label_line);
            this.Controls.Add(this.label_nameApk);
            this.Name = "apkStateInstallUserControl";
            this.Size = new System.Drawing.Size(310, 38);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_stateInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_memory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_memory;
        private System.Windows.Forms.PictureBox pictureBox_stateInstall;
        private System.Windows.Forms.Label label_nameApk;
        private System.Windows.Forms.Label label_line;
    }
}
