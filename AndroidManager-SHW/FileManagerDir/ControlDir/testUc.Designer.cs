namespace AndroidManager_SHW.FileManagerDir.ControlDir
{
    partial class testUc
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker_flow = new System.ComponentModel.BackgroundWorker();
            this.timer_addicon = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // backgroundWorker_flow
            // 
            this.backgroundWorker_flow.WorkerReportsProgress = true;
            this.backgroundWorker_flow.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_flow_DoWork);
            this.backgroundWorker_flow.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_flow_ProgressChanged);
            this.backgroundWorker_flow.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_flow_RunWorkerCompleted_1);
            // 
            // timer_addicon
            // 
            this.timer_addicon.Enabled = true;
            this.timer_addicon.Interval = 1;
            this.timer_addicon.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // testUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "testUc";
            this.Text = "testUc";
            this.Load += new System.EventHandler(this.testUc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker_flow;
        private System.Windows.Forms.Timer timer_addicon;
    }
}