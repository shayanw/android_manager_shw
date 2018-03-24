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
            this.label_CopyCutBackup = new System.Windows.Forms.Label();
            this.progressBar_transfer = new System.Windows.Forms.ProgressBar();
            this.label_totalSize = new System.Windows.Forms.Label();
            this.label_totalFiles = new System.Windows.Forms.Label();
            this.label_to = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_transferBase = new System.Windows.Forms.Label();
            this.label_transferTo = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.backgroundWorker_transfer = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_SetProgress = new System.ComponentModel.BackgroundWorker();
            this.timer_5s = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker_SetLabels = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label_CopyCutBackup
            // 
            this.label_CopyCutBackup.Location = new System.Drawing.Point(12, 9);
            this.label_CopyCutBackup.Name = "label_CopyCutBackup";
            this.label_CopyCutBackup.Size = new System.Drawing.Size(75, 34);
            this.label_CopyCutBackup.TabIndex = 0;
            this.label_CopyCutBackup.Text = "Copying";
            this.label_CopyCutBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar_transfer
            // 
            this.progressBar_transfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_transfer.Location = new System.Drawing.Point(12, 84);
            this.progressBar_transfer.Name = "progressBar_transfer";
            this.progressBar_transfer.Size = new System.Drawing.Size(538, 20);
            this.progressBar_transfer.TabIndex = 1;
            this.progressBar_transfer.Value = 50;
            // 
            // label_totalSize
            // 
            this.label_totalSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_totalSize.Location = new System.Drawing.Point(363, 9);
            this.label_totalSize.Name = "label_totalSize";
            this.label_totalSize.Size = new System.Drawing.Size(187, 34);
            this.label_totalSize.TabIndex = 0;
            this.label_totalSize.Text = "Total Size: 43Gb";
            this.label_totalSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_totalFiles
            // 
            this.label_totalFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_totalFiles.Location = new System.Drawing.Point(363, 47);
            this.label_totalFiles.Name = "label_totalFiles";
            this.label_totalFiles.Size = new System.Drawing.Size(187, 34);
            this.label_totalFiles.TabIndex = 0;
            this.label_totalFiles.Text = "Total Files: 1024";
            this.label_totalFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_to
            // 
            this.label_to.Location = new System.Drawing.Point(12, 43);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(75, 34);
            this.label_to.TabIndex = 0;
            this.label_to.Text = "to   ";
            this.label_to.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.Location = new System.Drawing.Point(433, 108);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(117, 33);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label_transferBase
            // 
            this.label_transferBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_transferBase.Location = new System.Drawing.Point(93, 9);
            this.label_transferBase.Name = "label_transferBase";
            this.label_transferBase.Size = new System.Drawing.Size(334, 34);
            this.label_transferBase.TabIndex = 0;
            this.label_transferBase.Text = "Mobile: /root";
            this.label_transferBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_transferTo
            // 
            this.label_transferTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_transferTo.Location = new System.Drawing.Point(93, 43);
            this.label_transferTo.Name = "label_transferTo";
            this.label_transferTo.Size = new System.Drawing.Size(334, 34);
            this.label_transferTo.TabIndex = 0;
            this.label_transferTo.Text = "MyPC:Dr";
            this.label_transferTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Status
            // 
            this.label_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Status.Location = new System.Drawing.Point(12, 107);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(415, 34);
            this.label_Status.TabIndex = 0;
            this.label_Status.Text = "Status: Waiting •••";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backgroundWorker_transfer
            // 
            this.backgroundWorker_transfer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_transfer_DoWork);
            this.backgroundWorker_transfer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_transfer_RunWorkerCompleted);
            // 
            // backgroundWorker_SetProgress
            // 
            this.backgroundWorker_SetProgress.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_SetProgress_DoWork);
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
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 153);
            this.ControlBox = false;
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.progressBar_transfer);
            this.Controls.Add(this.label_totalFiles);
            this.Controls.Add(this.label_totalSize);
            this.Controls.Add(this.label_transferTo);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label_transferBase);
            this.Controls.Add(this.label_to);
            this.Controls.Add(this.label_CopyCutBackup);
            this.MaximumSize = new System.Drawing.Size(580, 200);
            this.MinimumSize = new System.Drawing.Size(580, 200);
            this.Name = "TransferForm";
            this.Text = "Copying";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_CopyCutBackup;
        private System.Windows.Forms.ProgressBar progressBar_transfer;
        private System.Windows.Forms.Label label_totalSize;
        private System.Windows.Forms.Label label_totalFiles;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_transferBase;
        private System.Windows.Forms.Label label_transferTo;
        private System.Windows.Forms.Label label_Status;
        private System.ComponentModel.BackgroundWorker backgroundWorker_transfer;
        private System.ComponentModel.BackgroundWorker backgroundWorker_SetProgress;
        private System.Windows.Forms.Timer timer_5s;
        private System.ComponentModel.BackgroundWorker backgroundWorker_SetLabels;
    }
}