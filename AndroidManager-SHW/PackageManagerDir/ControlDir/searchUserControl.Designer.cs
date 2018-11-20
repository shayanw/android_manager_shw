namespace AndroidManager_SHW.PackageManagerDir.ControlDir
{
    partial class searchUserControl
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
            this.panel_all = new System.Windows.Forms.Panel();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel_textBox = new System.Windows.Forms.Panel();
            this.panel_searchButton = new System.Windows.Forms.Panel();
            this.button_search = new System.Windows.Forms.Button();
            this.panel_all.SuspendLayout();
            this.panel_searchButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_all
            // 
            this.panel_all.BackColor = System.Drawing.Color.Transparent;
            this.panel_all.Controls.Add(this.textBox_search);
            this.panel_all.Controls.Add(this.panel_textBox);
            this.panel_all.Controls.Add(this.panel_searchButton);
            this.panel_all.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_all.Location = new System.Drawing.Point(0, 0);
            this.panel_all.Name = "panel_all";
            this.panel_all.Size = new System.Drawing.Size(250, 27);
            this.panel_all.TabIndex = 0;
            // 
            // textBox_search
            // 
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_search.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.Location = new System.Drawing.Point(0, 0);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(224, 24);
            this.textBox_search.TabIndex = 1;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            this.textBox_search.Enter += new System.EventHandler(this.TextBox_search_Enter);
            this.textBox_search.Leave += new System.EventHandler(this.TextBox_search_Leave);
            // 
            // panel_textBox
            // 
            this.panel_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_textBox.Location = new System.Drawing.Point(0, 0);
            this.panel_textBox.Name = "panel_textBox";
            this.panel_textBox.Size = new System.Drawing.Size(224, 27);
            this.panel_textBox.TabIndex = 2;
            // 
            // panel_searchButton
            // 
            this.panel_searchButton.Controls.Add(this.button_search);
            this.panel_searchButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_searchButton.Location = new System.Drawing.Point(224, 0);
            this.panel_searchButton.Name = "panel_searchButton";
            this.panel_searchButton.Size = new System.Drawing.Size(26, 27);
            this.panel_searchButton.TabIndex = 0;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.Transparent;
            this.button_search.BackgroundImage = global::AndroidManager_SHW.Properties.Resources.search;
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Location = new System.Drawing.Point(0, 0);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(26, 27);
            this.button_search.TabIndex = 0;
            this.button_search.UseVisualStyleBackColor = false;
            // 
            // searchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panel_all);
            this.Name = "searchUserControl";
            this.Size = new System.Drawing.Size(250, 27);
            this.panel_all.ResumeLayout(false);
            this.panel_all.PerformLayout();
            this.panel_searchButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_all;
        private System.Windows.Forms.Panel panel_searchButton;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Panel panel_textBox;
        private System.Windows.Forms.Button button_search;
    }
}
