﻿using System;
using System.Windows.Forms;
using ADBProccessDLL;

namespace AndroidManager_SHW
{
    public partial class Form_networkADB : Form
    {
        public bool isChanged;
        public Form_networkADB()
        {
            InitializeComponent();
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            string result = ExternalMethod.AdbCommand("connect " + textBox_ip.Text + ":" + textBox_port.Text);
            if (result.Contains("connected"))
            {
                label_title.Text = textBox_ip.Text + " Connected Successfully";
            }
            else
            {
                label_title.Text ="Something is Wrong!";
            }
            isChanged = true;
        }
    }
}
