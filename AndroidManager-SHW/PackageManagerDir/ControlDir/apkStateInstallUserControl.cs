using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AndroidManager_SHW.PackageManagerDir.ControlDir
{
    public partial class apkStateInstallUserControl : UserControl
    {
        int stateInstall;
        bool IsInstallOnPhone;
        public FileInfo fi;
        public int stateInstallProp
        {
            get { return stateInstall; }
            set
            {
                if (value==2)
                {
                    pictureBox_stateInstall.BackgroundImage = AndroidManager_SHW.Properties.Resources.stateWait_mini;
                    stateInstall = 2;
                }
                else if (value == 1)
                {
                    pictureBox_stateInstall.BackgroundImage = AndroidManager_SHW.Properties.Resources.stateSuccess_mini;
                    stateInstall = 1;
                }
                else
                {
                    pictureBox_stateInstall.BackgroundImage = AndroidManager_SHW.Properties.Resources.stateFail_mini;
                    stateInstall = 0;
                }
            }
        }
        public bool IsInstallOnPhoneProp
        {
            get { return IsInstallOnPhone; }
            set
            {
                if (value)
                {
                    pictureBox_memory.BackgroundImage = AndroidManager_SHW.Properties.Resources.memoryPhone_mini;
                    IsInstallOnPhone = value;
                }
                else
                {
                    pictureBox_memory.BackgroundImage = AndroidManager_SHW.Properties.Resources.memorySD_mini;
                    IsInstallOnPhone = value;
                }
            }
        }
        public string nameApkProp { get { return label_nameApk.Text; } set { label_nameApk.Text = value; } }

        public apkStateInstallUserControl()
        {
            InitializeComponent();
        }

        public apkStateInstallUserControl(string fullnameApkString,bool isInstallOnMemoryPhone)
        {
            InitializeComponent();
            fi = new FileInfo(fullnameApkString);
            nameApkProp = fi.Name;
            IsInstallOnPhoneProp = isInstallOnMemoryPhone;
            
        }

        private void pictureBox_memory_Click(object sender, EventArgs e)
        {
            return;
            IsInstallOnPhoneProp = !IsInstallOnPhone;
        }
    }
}
