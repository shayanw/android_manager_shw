namespace AndroidManager_SHW.FileManager.Control
{
    partial class apkPackageUserControl
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
            this.label_package = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.pictureBox_iconPackage = new System.Windows.Forms.PictureBox();
            this.button_selectedPackage = new System.Windows.Forms.Button();
            this.button_removePackage = new System.Windows.Forms.Button();
            this.button_backupPackage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iconPackage)).BeginInit();
            this.SuspendLayout();
            // 
            // label_package
            // 
            this.label_package.BackColor = System.Drawing.Color.Transparent;
            this.label_package.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_package.Location = new System.Drawing.Point(13, 99);
            this.label_package.Name = "label_package";
            this.label_package.Size = new System.Drawing.Size(144, 39);
            this.label_package.TabIndex = 0;
            this.label_package.Text = "com.google.android.googlequicksearchbox";
            this.label_package.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_package.Click += new System.EventHandler(this.label_package_Click);
            // 
            // label_version
            // 
            this.label_version.BackColor = System.Drawing.Color.Transparent;
            this.label_version.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_version.ForeColor = System.Drawing.Color.Gray;
            this.label_version.Location = new System.Drawing.Point(13, 78);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(144, 21);
            this.label_version.TabIndex = 0;
            this.label_version.Text = "Version 8.20.13.21";
            this.label_version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_version.Click += new System.EventHandler(this.label_package_Click);
            // 
            // pictureBox_iconPackage
            // 
            this.pictureBox_iconPackage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_iconPackage.Location = new System.Drawing.Point(56, 11);
            this.pictureBox_iconPackage.Name = "pictureBox_iconPackage";
            this.pictureBox_iconPackage.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_iconPackage.TabIndex = 0;
            this.pictureBox_iconPackage.TabStop = false;
            this.pictureBox_iconPackage.Click += new System.EventHandler(this.label_package_Click);
            // 
            // button_selectedPackage
            // 
            this.button_selectedPackage.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.selected_UC;
            this.button_selectedPackage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_selectedPackage.FlatAppearance.BorderSize = 0;
            this.button_selectedPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selectedPackage.Location = new System.Drawing.Point(17, 10);
            this.button_selectedPackage.Name = "button_selectedPackage";
            this.button_selectedPackage.Size = new System.Drawing.Size(24, 24);
            this.button_selectedPackage.TabIndex = 4;
            this.button_selectedPackage.UseVisualStyleBackColor = false;
            this.button_selectedPackage.Visible = false;
            this.button_selectedPackage.MouseLeave += new System.EventHandler(this.button_removePackage_MouseLeave);
            this.button_selectedPackage.MouseHover += new System.EventHandler(this.button_removePackage_MouseHover);
            // 
            // button_removePackage
            // 
            this.button_removePackage.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.unistall_UC;
            this.button_removePackage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_removePackage.FlatAppearance.BorderSize = 0;
            this.button_removePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_removePackage.Location = new System.Drawing.Point(133, 10);
            this.button_removePackage.Name = "button_removePackage";
            this.button_removePackage.Size = new System.Drawing.Size(24, 24);
            this.button_removePackage.TabIndex = 4;
            this.button_removePackage.UseVisualStyleBackColor = false;
            this.button_removePackage.Click += new System.EventHandler(this.button_removePackage_Click);
            this.button_removePackage.MouseLeave += new System.EventHandler(this.button_removePackage_MouseLeave);
            this.button_removePackage.MouseHover += new System.EventHandler(this.button_removePackage_MouseHover);
            // 
            // button_backupPackage
            // 
            this.button_backupPackage.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.backup_UC;
            this.button_backupPackage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_backupPackage.FlatAppearance.BorderSize = 0;
            this.button_backupPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_backupPackage.Location = new System.Drawing.Point(133, 40);
            this.button_backupPackage.Name = "button_backupPackage";
            this.button_backupPackage.Size = new System.Drawing.Size(24, 24);
            this.button_backupPackage.TabIndex = 5;
            this.button_backupPackage.UseVisualStyleBackColor = true;
            this.button_backupPackage.Click += new System.EventHandler(this.button_backupPackage_Click);
            this.button_backupPackage.MouseLeave += new System.EventHandler(this.button_backupPackage_MouseLeave);
            this.button_backupPackage.MouseHover += new System.EventHandler(this.button_backupPackage_MouseHover);
            // 
            // apkPackageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox_iconPackage);
            this.Controls.Add(this.button_selectedPackage);
            this.Controls.Add(this.button_removePackage);
            this.Controls.Add(this.button_backupPackage);
            this.Controls.Add(this.label_package);
            this.Controls.Add(this.label_version);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "apkPackageUserControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(170, 150);
            this.Load += new System.EventHandler(this.apkPackageUserControl_Load);
            this.Click += new System.EventHandler(this.label_package_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iconPackage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_package;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Button button_removePackage;
        private System.Windows.Forms.Button button_backupPackage;
        private System.Windows.Forms.PictureBox pictureBox_iconPackage;
        private System.Windows.Forms.Button button_selectedPackage;
    }
}
