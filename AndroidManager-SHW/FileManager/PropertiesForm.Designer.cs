namespace AndroidManager_SHW
{
    partial class PropertiesForm
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_type = new System.Windows.Forms.Label();
            this.label_location = new System.Windows.Forms.Label();
            this.label_size = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.label_typeValue = new System.Windows.Forms.Label();
            this.label_locationValue = new System.Windows.Forms.Label();
            this.label_sizeValue = new System.Windows.Forms.Label();
            this.label_countValue = new System.Windows.Forms.Label();
            this.pictureBox_iconFile = new System.Windows.Forms.PictureBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.backgroundWorker_getSizeFile = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_getCountFile = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iconFile)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_name.Location = new System.Drawing.Point(79, 23);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(156, 25);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(12, 63);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(41, 19);
            this.label_type.TabIndex = 3;
            this.label_type.Text = "Type:";
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Location = new System.Drawing.Point(12, 99);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(66, 19);
            this.label_location.TabIndex = 3;
            this.label_location.Text = "Location:";
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(12, 135);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(38, 19);
            this.label_size.TabIndex = 3;
            this.label_size.Text = "Size:";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(12, 171);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(82, 19);
            this.label_count.TabIndex = 3;
            this.label_count.Text = "Count Files:";
            // 
            // label_typeValue
            // 
            this.label_typeValue.AutoSize = true;
            this.label_typeValue.Location = new System.Drawing.Point(106, 63);
            this.label_typeValue.Name = "label_typeValue";
            this.label_typeValue.Size = new System.Drawing.Size(41, 19);
            this.label_typeValue.TabIndex = 3;
            this.label_typeValue.Text = "Type:";
            // 
            // label_locationValue
            // 
            this.label_locationValue.AutoSize = true;
            this.label_locationValue.Location = new System.Drawing.Point(106, 99);
            this.label_locationValue.Name = "label_locationValue";
            this.label_locationValue.Size = new System.Drawing.Size(66, 19);
            this.label_locationValue.TabIndex = 3;
            this.label_locationValue.Text = "Location:";
            // 
            // label_sizeValue
            // 
            this.label_sizeValue.AutoSize = true;
            this.label_sizeValue.Location = new System.Drawing.Point(106, 135);
            this.label_sizeValue.Name = "label_sizeValue";
            this.label_sizeValue.Size = new System.Drawing.Size(38, 19);
            this.label_sizeValue.TabIndex = 3;
            this.label_sizeValue.Text = "Size:";
            // 
            // label_countValue
            // 
            this.label_countValue.AutoSize = true;
            this.label_countValue.Location = new System.Drawing.Point(106, 171);
            this.label_countValue.Name = "label_countValue";
            this.label_countValue.Size = new System.Drawing.Size(82, 19);
            this.label_countValue.TabIndex = 3;
            this.label_countValue.Text = "Count Files:";
            // 
            // pictureBox_iconFile
            // 
            this.pictureBox_iconFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_iconFile.Location = new System.Drawing.Point(16, 13);
            this.pictureBox_iconFile.Name = "pictureBox_iconFile";
            this.pictureBox_iconFile.Size = new System.Drawing.Size(37, 35);
            this.pictureBox_iconFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_iconFile.TabIndex = 0;
            this.pictureBox_iconFile.TabStop = false;
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Location = new System.Drawing.Point(169, 208);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(66, 24);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ok.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Location = new System.Drawing.Point(97, 208);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(66, 24);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // backgroundWorker_getSizeFile
            // 
            this.backgroundWorker_getSizeFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_getSizeFile_DoWork);
            this.backgroundWorker_getSizeFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_getSizeFile_RunWorkerCompleted);
            // 
            // backgroundWorker_getCountFile
            // 
            this.backgroundWorker_getCountFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_getCountFile_DoWork);
            this.backgroundWorker_getCountFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_getCountFile_RunWorkerCompleted);
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(251, 244);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_countValue);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label_sizeValue);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.label_locationValue);
            this.Controls.Add(this.label_location);
            this.Controls.Add(this.label_typeValue);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.pictureBox_iconFile);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(269, 291);
            this.MinimumSize = new System.Drawing.Size(269, 291);
            this.Name = "PropertiesForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.PropertiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iconFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_iconFile;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label_typeValue;
        private System.Windows.Forms.Label label_locationValue;
        private System.Windows.Forms.Label label_sizeValue;
        private System.Windows.Forms.Label label_countValue;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.ComponentModel.BackgroundWorker backgroundWorker_getSizeFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker_getCountFile;
    }
}