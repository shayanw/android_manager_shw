using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADBProccessDLL;
using SharpAdbClient;
namespace AndroidManager_SHW
{
    public partial class FileManager_CreateNewDir : Form
    {
        FileManager FM;
        string Path;
        public bool IsChangeValue;
        public FileManager_CreateNewDir(DeviceData device,string path)
        {
            InitializeComponent();
            FM = new FileManager(device);
            Path = path;
            IsChangeValue = false;
        }

        private void button_CreateDir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_nameDir.Text))
            {
                FM.CreateDirectory(Path, textBox_nameDir.Text.fixBracketInTerminal().EncodingText());
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
