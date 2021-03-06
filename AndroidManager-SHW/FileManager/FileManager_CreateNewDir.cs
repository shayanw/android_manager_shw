﻿using System;
using System.Windows.Forms;
using ADBProccessDLL;
namespace AndroidManager_SHW
{
    public partial class FileManager_CreateNewDir : Form
    {
        FileManager FM;
        string Path;
        public bool IsChangeValue;
        public FileManager_CreateNewDir(FileManager fm, string path)
        {
            InitializeComponent();
            FM = fm;
            Path = path;
            IsChangeValue = false;
        }

        private void button_CreateDir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_nameDir.Text))
            {
                FM.CreateDirectory(Path, textBox_nameDir.Text.FixForbidCharInTerminal().EncodingText());
                IsChangeValue = true;
            }
            this.Close();
        }

        private void textBox_nameDir_KeyUp(object sender, KeyEventArgs e)
        {
            if (Keys.Enter==e.KeyData)
            {
                button_CreateDir_Click(sender,e);
            }
        }
    }
}
