namespace AndroidManager_SHW
{
    partial class TransferForm
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
            this.progressBar_transfer = new System.Windows.Forms.ProgressBar();
            this.label_totalSize = new System.Windows.Forms.Label();
            this.label_totalFiles = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_transferBase = new System.Windows.Forms.Label();
            this.label_transferTo = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.backgroundWorker_transfer = new System.ComponentModel.BackgroundWorker();
            this.timer_5s = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker_SetLabels = new System.ComponentModel.BackgroundWorker();
            this.label_percent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar_transfer
            // 
            this.progressBar_transfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_transfer.Location = new System.Drawing.Point(12, 77);
            this.progressBar_transfer.Name = "progressBar_transfer";
            this.progressBar_transfer.Size = new System.Drawing.Size(578, 20);
            this.progressBar_transfer.TabIndex = 1;
            this.progressBar_transfer.Value = 50;
            // 
            // label_totalSize
            // 
            this.label_totalSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_totalSize.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalSize.Location = new System.Drawing.Point(403, -1);
            this.label_totalSize.Name = "label_totalSize";
            this.label_totalSize.Size = new System.Drawing.Size(187, 34);
            this.label_totalSize.TabIndex = 0;
            this.label_totalSize.Text = "Total Size: 43Gb";
            this.label_totalSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_totalFiles
            // 
            this.label_totalFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_totalFiles.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalFiles.Location = new System.Drawing.Point(403, 37);
            this.label_totalFiles.Name = "label_totalFiles";
            this.label_totalFiles.Size = new System.Drawing.Size(187, 34);
            this.label_totalFiles.TabIndex = 0;
            this.label_totalFiles.Text = "Total Files: 1024";
            this.label_totalFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_cancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.Black;
            this.button_cancel.Location = new System.Drawing.Point(473, 116);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(117, 33);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label_transferBase
            // 
            this.label_transferBase.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_transferBase.ForeColor = System.Drawing.Color.Black;
            this.label_transferBase.Location = new System.Drawing.Point(16, -1);
            this.label_transferBase.Name = "label_transferBase";
            this.label_transferBase.Size = new System.Drawing.Size(462, 34);
            this.label_transferBase.TabIndex = 0;
            this.label_transferBase.Text = "[ Finding Address... ]";
            this.label_transferBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_transferBase.Click += new System.EventHandler(this.label_transferBase_Click);
            // 
            // label_transferTo
            // 
            this.label_transferTo.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_transferTo.Location = new System.Drawing.Point(20, 33);
            this.label_transferTo.Name = "label_transferTo";
            this.label_transferTo.Size = new System.Drawing.Size(458, 34);
            this.label_transferTo.TabIndex = 0;
            this.label_transferTo.Text = "MyPC:Dr";
            this.label_transferTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Status
            // 
            this.label_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Status.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.Location = new System.Drawing.Point(8, 115);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(459, 34);
            this.label_Status.TabIndex = 0;
            this.label_Status.Text = "Status: Waiting •••";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backgroundWorker_transfer
            // 
            this.backgroundWorker_transfer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_transfer_DoWork);
            this.backgroundWorker_transfer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_transfer_RunWorkerCompleted);
            // 
            // timer_5s
            // 
            this.timer_5s.Enabled = true;
            this.timer_5s.Interval = 200;
            this.timer_5s.Tick += new System.EventHandler(this.timer_5s_Tick);
            // 
            // backgroundWorker_SetLabels
            // 
            this.backgroundWorker_SetLabels.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_SetLabels_DoWork);
            this.backgroundWorker_SetLabels.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_SetLabels_RunWorkerCompleted);
            // 
            // label_percent
            // 
            this.label_percent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_percent.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_percent.Location = new System.Drawing.Point(239, 103);
            this.label_percent.Name = "label_percent";
            this.label_percent.Size = new System.Drawing.Size(125, 20);
            this.label_percent.TabIndex = 0;
            this.label_percent.Text = "%";
            this.label_percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 158);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.progressBar_transfer);
            this.Controls.Add(this.label_totalFiles);
            this.Controls.Add(this.label_totalSize);
            this.Controls.Add(this.label_transferTo);
            this.Controls.Add(this.label_percent);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label_transferBase);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 205);
            this.MinimumSize = new System.Drawing.Size(620, 200);
            this.Name = "TransferForm";
            this.ShowIcon = false;
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar_transfer;
        private System.Windows.Forms.Label label_totalSize;
        private System.Windows.Forms.Label label_totalFiles;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_transferBase;
        private System.Windows.Forms.Label label_transferTo;
        private System.Windows.Forms.Label label_Status;
        private System.ComponentModel.BackgroundWorker backgroundWorker_transfer;
        private System.Windows.Forms.Timer timer_5s;
        private System.ComponentModel.BackgroundWorker backgroundWorker_SetLabels;
        private System.Windows.Forms.Label label_percent;
    }
}