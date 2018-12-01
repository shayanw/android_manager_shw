namespace AndroidManager_SHW.PackageManagerDir
{
    partial class PMFormNew
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
            this.button_selectNone = new System.Windows.Forms.Button();
            this.button_selectAll = new System.Windows.Forms.Button();
            this.flowLayoutPanel_packages = new System.Windows.Forms.FlowLayoutPanel();
            this.progressBar_Load = new System.Windows.Forms.ProgressBar();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_phoneInstall = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_sdcardInstall = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_bottomProgress = new System.Windows.Forms.Panel();
            this.label_status = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.searchUserControl = new AndroidManager_SHW.PackageManagerDir.ControlDir.searchUserControl();
            this.button_backup = new System.Windows.Forms.Button();
            this.button_unistall = new System.Windows.Forms.Button();
            this.panel_fill = new System.Windows.Forms.Panel();
            this.backgroundWorker_flowLayoutPanel = new System.ComponentModel.BackgroundWorker();
            this.panel_bottomStatus = new System.Windows.Forms.Panel();
            this.backgroundWorker_addControlFLP = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_unistallPackages = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_backupPackages = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_KeepLatestApkBackup = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_installApk = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_setIcon = new System.ComponentModel.BackgroundWorker();
            this.panel_bottom.SuspendLayout();
            this.panel_phoneInstall.SuspendLayout();
            this.panel_sdcardInstall.SuspendLayout();
            this.panel_bottomProgress.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.panel_fill.SuspendLayout();
            this.panel_bottomStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_selectNone
            // 
            this.button_selectNone.BackColor = System.Drawing.Color.Transparent;
            this.button_selectNone.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.checkNone;
            this.button_selectNone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_selectNone.FlatAppearance.BorderSize = 0;
            this.button_selectNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selectNone.Location = new System.Drawing.Point(12, 7);
            this.button_selectNone.Name = "button_selectNone";
            this.button_selectNone.Size = new System.Drawing.Size(32, 32);
            this.button_selectNone.TabIndex = 5;
            this.button_selectNone.UseVisualStyleBackColor = false;
            this.button_selectNone.Click += new System.EventHandler(this.button_selectNone_Click);
            // 
            // button_selectAll
            // 
            this.button_selectAll.BackColor = System.Drawing.Color.Transparent;
            this.button_selectAll.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.checkAll;
            this.button_selectAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_selectAll.FlatAppearance.BorderSize = 0;
            this.button_selectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selectAll.Location = new System.Drawing.Point(50, 7);
            this.button_selectAll.Name = "button_selectAll";
            this.button_selectAll.Size = new System.Drawing.Size(32, 32);
            this.button_selectAll.TabIndex = 5;
            this.button_selectAll.UseVisualStyleBackColor = false;
            this.button_selectAll.Click += new System.EventHandler(this.button_selectAll_Click);
            // 
            // flowLayoutPanel_packages
            // 
            this.flowLayoutPanel_packages.AutoScroll = true;
            this.flowLayoutPanel_packages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.flowLayoutPanel_packages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_packages.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_packages.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel_packages.Name = "flowLayoutPanel_packages";
            this.flowLayoutPanel_packages.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanel_packages.Size = new System.Drawing.Size(792, 335);
            this.flowLayoutPanel_packages.TabIndex = 6;
            // 
            // progressBar_Load
            // 
            this.progressBar_Load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar_Load.Location = new System.Drawing.Point(0, 0);
            this.progressBar_Load.Margin = new System.Windows.Forms.Padding(15);
            this.progressBar_Load.Name = "progressBar_Load";
            this.progressBar_Load.Size = new System.Drawing.Size(792, 18);
            this.progressBar_Load.TabIndex = 7;
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.Transparent;
            this.panel_bottom.Controls.Add(this.panel_phoneInstall);
            this.panel_bottom.Controls.Add(this.panel_sdcardInstall);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 432);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Padding = new System.Windows.Forms.Padding(10);
            this.panel_bottom.Size = new System.Drawing.Size(792, 151);
            this.panel_bottom.TabIndex = 8;
            // 
            // panel_phoneInstall
            // 
            this.panel_phoneInstall.AllowDrop = true;
            this.panel_phoneInstall.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel_phoneInstall.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_phoneInstall.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.internalMemory;
            this.panel_phoneInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_phoneInstall.Controls.Add(this.label2);
            this.panel_phoneInstall.Location = new System.Drawing.Point(16, 7);
            this.panel_phoneInstall.Name = "panel_phoneInstall";
            this.panel_phoneInstall.Size = new System.Drawing.Size(371, 131);
            this.panel_phoneInstall.TabIndex = 0;
            this.panel_phoneInstall.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_phoneInstall_DragDrop);
            this.panel_phoneInstall.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_phoneInstall_DragEnter);
            this.panel_phoneInstall.DragLeave += new System.EventHandler(this.panel_phoneInstall_DragLeave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-5, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Drag to install on Phone";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_sdcardInstall
            // 
            this.panel_sdcardInstall.AllowDrop = true;
            this.panel_sdcardInstall.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel_sdcardInstall.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_sdcardInstall.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.exteralMemory;
            this.panel_sdcardInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_sdcardInstall.Controls.Add(this.label1);
            this.panel_sdcardInstall.Location = new System.Drawing.Point(404, 7);
            this.panel_sdcardInstall.Name = "panel_sdcardInstall";
            this.panel_sdcardInstall.Size = new System.Drawing.Size(371, 131);
            this.panel_sdcardInstall.TabIndex = 0;
            this.panel_sdcardInstall.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_phoneInstall_DragDrop);
            this.panel_sdcardInstall.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_phoneInstall_DragEnter);
            this.panel_sdcardInstall.DragLeave += new System.EventHandler(this.panel_phoneInstall_DragLeave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-8, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drag to install on SD Card";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_bottomProgress
            // 
            this.panel_bottomProgress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_bottomProgress.Controls.Add(this.progressBar_Load);
            this.panel_bottomProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottomProgress.Location = new System.Drawing.Point(0, 414);
            this.panel_bottomProgress.Margin = new System.Windows.Forms.Padding(10);
            this.panel_bottomProgress.Name = "panel_bottomProgress";
            this.panel_bottomProgress.Size = new System.Drawing.Size(792, 18);
            this.panel_bottomProgress.TabIndex = 9;
            // 
            // label_status
            // 
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(0, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(792, 30);
            this.label_status.TabIndex = 8;
            this.label_status.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Transparent;
            this.panel_top.Controls.Add(this.searchUserControl);
            this.panel_top.Controls.Add(this.button_backup);
            this.panel_top.Controls.Add(this.button_unistall);
            this.panel_top.Controls.Add(this.button_selectNone);
            this.panel_top.Controls.Add(this.button_selectAll);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(792, 49);
            this.panel_top.TabIndex = 10;
            // 
            // searchUserControl
            // 
            this.searchUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchUserControl.BackColor = System.Drawing.SystemColors.Window;
            this.searchUserControl.DefaultTextProp = "Search Package...";
            this.searchUserControl.Location = new System.Drawing.Point(528, 12);
            this.searchUserControl.Name = "searchUserControl";
            this.searchUserControl.Size = new System.Drawing.Size(250, 27);
            this.searchUserControl.TabIndex = 6;
            this.searchUserControl.TextChangedEvent += new System.EventHandler(this.searchUserControl_TextChangedEvent);
            this.searchUserControl.ClickSearchButtonEvent += new System.EventHandler(this.searchUserControl_ClickSearchButtonEvent);
            // 
            // button_backup
            // 
            this.button_backup.BackColor = System.Drawing.Color.LightCyan;
            this.button_backup.FlatAppearance.BorderSize = 0;
            this.button_backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_backup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_backup.Image = global::AndroidManager_SHW.Properties.Resources.backup20_UC;
            this.button_backup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_backup.Location = new System.Drawing.Point(221, 7);
            this.button_backup.Name = "button_backup";
            this.button_backup.Size = new System.Drawing.Size(122, 36);
            this.button_backup.TabIndex = 5;
            this.button_backup.Text = "Backup";
            this.button_backup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_backup.UseVisualStyleBackColor = false;
            this.button_backup.Click += new System.EventHandler(this.button_backup_Click);
            // 
            // button_unistall
            // 
            this.button_unistall.BackColor = System.Drawing.Color.Bisque;
            this.button_unistall.FlatAppearance.BorderSize = 0;
            this.button_unistall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_unistall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_unistall.Image = global::AndroidManager_SHW.Properties.Resources.unistall24_UC;
            this.button_unistall.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_unistall.Location = new System.Drawing.Point(93, 7);
            this.button_unistall.Name = "button_unistall";
            this.button_unistall.Size = new System.Drawing.Size(122, 36);
            this.button_unistall.TabIndex = 5;
            this.button_unistall.Text = "Unistall";
            this.button_unistall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_unistall.UseVisualStyleBackColor = false;
            this.button_unistall.Click += new System.EventHandler(this.button_unistall_Click);
            // 
            // panel_fill
            // 
            this.panel_fill.Controls.Add(this.flowLayoutPanel_packages);
            this.panel_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fill.Location = new System.Drawing.Point(0, 49);
            this.panel_fill.Name = "panel_fill";
            this.panel_fill.Size = new System.Drawing.Size(792, 335);
            this.panel_fill.TabIndex = 11;
            // 
            // backgroundWorker_flowLayoutPanel
            // 
            this.backgroundWorker_flowLayoutPanel.WorkerReportsProgress = true;
            this.backgroundWorker_flowLayoutPanel.WorkerSupportsCancellation = true;
            this.backgroundWorker_flowLayoutPanel.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_flowLayoutPanel_DoWork);
            this.backgroundWorker_flowLayoutPanel.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_flowLayoutPanel_ProgressChanged);
            this.backgroundWorker_flowLayoutPanel.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_flowLayoutPanel_RunWorkerCompleted);
            // 
            // panel_bottomStatus
            // 
            this.panel_bottomStatus.BackColor = System.Drawing.Color.Transparent;
            this.panel_bottomStatus.Controls.Add(this.label_status);
            this.panel_bottomStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottomStatus.Location = new System.Drawing.Point(0, 384);
            this.panel_bottomStatus.Name = "panel_bottomStatus";
            this.panel_bottomStatus.Size = new System.Drawing.Size(792, 30);
            this.panel_bottomStatus.TabIndex = 9;
            // 
            // backgroundWorker_addControlFLP
            // 
            this.backgroundWorker_addControlFLP.WorkerReportsProgress = true;
            this.backgroundWorker_addControlFLP.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_addControlFLP_DoWork);
            this.backgroundWorker_addControlFLP.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_addControlFLP_ProgressChanged);
            this.backgroundWorker_addControlFLP.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_addControlFLP_RunWorkerCompleted);
            // 
            // backgroundWorker_unistallPackages
            // 
            this.backgroundWorker_unistallPackages.WorkerReportsProgress = true;
            this.backgroundWorker_unistallPackages.WorkerSupportsCancellation = true;
            this.backgroundWorker_unistallPackages.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_unistallPackages_DoWork);
            this.backgroundWorker_unistallPackages.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_unistallPackages_ProgressChanged);
            this.backgroundWorker_unistallPackages.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_unistallPackages_RunWorkerCompleted);
            // 
            // backgroundWorker_backupPackages
            // 
            this.backgroundWorker_backupPackages.WorkerReportsProgress = true;
            this.backgroundWorker_backupPackages.WorkerSupportsCancellation = true;
            this.backgroundWorker_backupPackages.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_backupPackages_DoWork);
            this.backgroundWorker_backupPackages.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_backupPackages_ProgressChanged);
            this.backgroundWorker_backupPackages.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_backupPackages_RunWorkerCompleted);
            // 
            // backgroundWorker_KeepLatestApkBackup
            // 
            this.backgroundWorker_KeepLatestApkBackup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_KeepLatestApkBackup_DoWork);
            // 
            // backgroundWorker_installApk
            // 
            this.backgroundWorker_installApk.WorkerReportsProgress = true;
            this.backgroundWorker_installApk.WorkerSupportsCancellation = true;
            this.backgroundWorker_installApk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_installApk_DoWork);
            this.backgroundWorker_installApk.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_installApk_ProgressChanged);
            this.backgroundWorker_installApk.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_installApk_RunWorkerCompleted);
            // 
            // backgroundWorker_setIcon
            // 
            this.backgroundWorker_setIcon.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_setIcon_DoWork);
            // 
            // PMFormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(792, 583);
            this.Controls.Add(this.panel_fill);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_bottomStatus);
            this.Controls.Add(this.panel_bottomProgress);
            this.Controls.Add(this.panel_bottom);
            this.MinimumSize = new System.Drawing.Size(810, 630);
            this.Name = "PMFormNew";
            this.ShowIcon = false;
            this.Text = "Package Manager";
            this.panel_bottom.ResumeLayout(false);
            this.panel_phoneInstall.ResumeLayout(false);
            this.panel_sdcardInstall.ResumeLayout(false);
            this.panel_bottomProgress.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_fill.ResumeLayout(false);
            this.panel_bottomStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_phoneInstall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_sdcardInstall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_selectNone;
        private System.Windows.Forms.Button button_selectAll;
        private System.Windows.Forms.Button button_unistall;
        private System.Windows.Forms.Button button_backup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_packages;
        private System.Windows.Forms.ProgressBar progressBar_Load;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Panel panel_bottomProgress;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_fill;
        private System.ComponentModel.BackgroundWorker backgroundWorker_flowLayoutPanel;
        private System.Windows.Forms.Panel panel_bottomStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker_addControlFLP;
        private ControlDir.searchUserControl searchUserControl;
        private System.ComponentModel.BackgroundWorker backgroundWorker_unistallPackages;
        private System.ComponentModel.BackgroundWorker backgroundWorker_backupPackages;
        private System.ComponentModel.BackgroundWorker backgroundWorker_KeepLatestApkBackup;
        private System.ComponentModel.BackgroundWorker backgroundWorker_installApk;
        private System.ComponentModel.BackgroundWorker backgroundWorker_setIcon;
    }
}