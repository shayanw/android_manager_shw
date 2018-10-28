namespace AndroidManager_SHW
{
    partial class FileManager_CreateNewDir
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nameDir = new System.Windows.Forms.TextBox();
            this.button_CreateDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_nameDir
            // 
            this.textBox_nameDir.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_nameDir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nameDir.Location = new System.Drawing.Point(71, 6);
            this.textBox_nameDir.Name = "textBox_nameDir";
            this.textBox_nameDir.Size = new System.Drawing.Size(161, 30);
            this.textBox_nameDir.TabIndex = 1;
            this.textBox_nameDir.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_nameDir_KeyUp);
            // 
            // button_CreateDir
            // 
            this.button_CreateDir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_CreateDir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_CreateDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CreateDir.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CreateDir.Location = new System.Drawing.Point(238, 6);
            this.button_CreateDir.Name = "button_CreateDir";
            this.button_CreateDir.Size = new System.Drawing.Size(84, 30);
            this.button_CreateDir.TabIndex = 2;
            this.button_CreateDir.Text = "Create";
            this.button_CreateDir.UseVisualStyleBackColor = true;
            this.button_CreateDir.Click += new System.EventHandler(this.button_CreateDir_Click);
            // 
            // FileManager_CreateNewDir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(329, 43);
            this.Controls.Add(this.button_CreateDir);
            this.Controls.Add(this.textBox_nameDir);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(347, 90);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(347, 90);
            this.Name = "FileManager_CreateNewDir";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nameDir;
        private System.Windows.Forms.Button button_CreateDir;
    }
}