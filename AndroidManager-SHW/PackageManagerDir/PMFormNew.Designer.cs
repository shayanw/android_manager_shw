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
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel_sdcardInstall = new System.Windows.Forms.Panel();
            this.panel_phoneInstall = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel_packages = new System.Windows.Forms.FlowLayoutPanel();
            this.progressBar_Load = new System.Windows.Forms.ProgressBar();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_bottomProgress = new System.Windows.Forms.Panel();
            this.label_status = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel_fill = new System.Windows.Forms.Panel();
            this.backgroundWorker_flowLayoutPanel = new System.ComponentModel.BackgroundWorker();
            this.panel_bottomStatus = new System.Windows.Forms.Panel();
            this.backgroundWorker_addControlFLP = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_setIcon = new System.ComponentModel.BackgroundWorker();
            this.panel_sdcardInstall.SuspendLayout();
            this.panel_phoneInstall.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            this.panel_bottomProgress.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.panel_fill.SuspendLayout();
            this.panel_bottomStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.BackColor = System.Drawing.Color.White;
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_search.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.ForeColor = System.Drawing.Color.Black;
            this.textBox_search.Location = new System.Drawing.Point(570, 12);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(222, 23);
            this.textBox_search.TabIndex = 4;
            this.textBox_search.Text = "  Search Now •••";
            // 
            // panel_sdcardInstall
            // 
            this.panel_sdcardInstall.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel_sdcardInstall.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_sdcardInstall.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.exteralMemory;
            this.panel_sdcardInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_sdcardInstall.Controls.Add(this.label1);
            this.panel_sdcardInstall.Location = new System.Drawing.Point(405, 9);
            this.panel_sdcardInstall.Name = "panel_sdcardInstall";
            this.panel_sdcardInstall.Size = new System.Drawing.Size(387, 132);
            this.panel_sdcardInstall.TabIndex = 0;
            // 
            // panel_phoneInstall
            // 
            this.panel_phoneInstall.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel_phoneInstall.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_phoneInstall.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.internalMemory;
            this.panel_phoneInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_phoneInstall.Controls.Add(this.label2);
            this.panel_phoneInstall.Location = new System.Drawing.Point(12, 9);
            this.panel_phoneInstall.Name = "panel_phoneInstall";
            this.panel_phoneInstall.Size = new System.Drawing.Size(387, 132);
            this.panel_phoneInstall.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drag to install on SD Card";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Drag to install on Phone";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(50, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::AndroidManager_SHW.Properties.Resources.fm_con_delete;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(97, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Unistall";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::AndroidManager_SHW.Properties.Resources.fm_con_details;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(237, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "Backup";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel_packages
            // 
            this.flowLayoutPanel_packages.AutoScroll = true;
            this.flowLayoutPanel_packages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel_packages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_packages.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_packages.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel_packages.Name = "flowLayoutPanel_packages";
            this.flowLayoutPanel_packages.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanel_packages.Size = new System.Drawing.Size(803, 335);
            this.flowLayoutPanel_packages.TabIndex = 6;
            // 
            // progressBar_Load
            // 
            this.progressBar_Load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar_Load.Location = new System.Drawing.Point(0, 0);
            this.progressBar_Load.Margin = new System.Windows.Forms.Padding(15);
            this.progressBar_Load.Name = "progressBar_Load";
            this.progressBar_Load.Size = new System.Drawing.Size(803, 18);
            this.progressBar_Load.TabIndex = 7;
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_bottom.Controls.Add(this.panel_phoneInstall);
            this.panel_bottom.Controls.Add(this.panel_sdcardInstall);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 432);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Padding = new System.Windows.Forms.Padding(10);
            this.panel_bottom.Size = new System.Drawing.Size(803, 151);
            this.panel_bottom.TabIndex = 8;
            // 
            // panel_bottomProgress
            // 
            this.panel_bottomProgress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_bottomProgress.Controls.Add(this.progressBar_Load);
            this.panel_bottomProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottomProgress.Location = new System.Drawing.Point(0, 414);
            this.panel_bottomProgress.Margin = new System.Windows.Forms.Padding(10);
            this.panel_bottomProgress.Name = "panel_bottomProgress";
            this.panel_bottomProgress.Size = new System.Drawing.Size(803, 18);
            this.panel_bottomProgress.TabIndex = 9;
            // 
            // label_status
            // 
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(0, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(803, 30);
            this.label_status.TabIndex = 8;
            this.label_status.Text = "Say Status...     |     Progress 58%     |     Package Name: sd\\dfd\\dfdsf\\dfsf\\aa" +
    "p.apk";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_top.Controls.Add(this.button4);
            this.panel_top.Controls.Add(this.button3);
            this.panel_top.Controls.Add(this.textBox_search);
            this.panel_top.Controls.Add(this.button1);
            this.panel_top.Controls.Add(this.button2);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(803, 49);
            this.panel_top.TabIndex = 10;
            // 
            // panel_fill
            // 
            this.panel_fill.Controls.Add(this.flowLayoutPanel_packages);
            this.panel_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fill.Location = new System.Drawing.Point(0, 49);
            this.panel_fill.Name = "panel_fill";
            this.panel_fill.Size = new System.Drawing.Size(803, 335);
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
            this.panel_bottomStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_bottomStatus.Controls.Add(this.label_status);
            this.panel_bottomStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottomStatus.Location = new System.Drawing.Point(0, 384);
            this.panel_bottomStatus.Name = "panel_bottomStatus";
            this.panel_bottomStatus.Size = new System.Drawing.Size(803, 30);
            this.panel_bottomStatus.TabIndex = 9;
            // 
            // backgroundWorker_addControlFLP
            // 
            this.backgroundWorker_addControlFLP.WorkerReportsProgress = true;
            this.backgroundWorker_addControlFLP.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_addControlFLP_DoWork);
            this.backgroundWorker_addControlFLP.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_addControlFLP_ProgressChanged);
            this.backgroundWorker_addControlFLP.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_addControlFLP_RunWorkerCompleted);
            // 
            // backgroundWorker_setIcon
            // 
            this.backgroundWorker_setIcon.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_setIcon_DoWork);
            // 
            // PMFormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 583);
            this.Controls.Add(this.panel_fill);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_bottomStatus);
            this.Controls.Add(this.panel_bottomProgress);
            this.Controls.Add(this.panel_bottom);
            this.Name = "PMFormNew";
            this.Text = "PMFormNew";
            this.Load += new System.EventHandler(this.PMFormNew_Load);
            this.panel_sdcardInstall.ResumeLayout(false);
            this.panel_phoneInstall.ResumeLayout(false);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottomProgress.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_fill.ResumeLayout(false);
            this.panel_bottomStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_phoneInstall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_sdcardInstall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker_setIcon;
    }
}