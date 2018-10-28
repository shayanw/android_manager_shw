using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidManager_SHW.FileManager.Control
{
    public partial class apkPackageUserControl : UserControl
    {
        string version, packageName, iconPackagePath;
        bool isPanelButtonVisible = false;
        bool isSelected = false;



        public event EventHandler removePackageClick;
        public event EventHandler backupPackageClick;
        public event EventHandler packageSelected;

        public string VersionProp { get { return version; } set { version = value; } }
        public string PackageNameProp { get { return packageName; } set { packageName = value; } }
        public string IconPackagePathProp { get { return iconPackagePath; } set { iconPackagePath = value; } }
        public bool isPanelButtonVisibleProp { get { return isPanelButtonVisible; }
            set {
                isPanelButtonVisible = button_removePackage.Visible=button_backupPackage.Visible = value;
            } }

        public bool isSelectedProp { get { label_package_Click(new object(), new EventArgs()); return isSelected; } set { isSelected = value; } }


        #region animation icon
        private void button_removePackage_MouseHover(object sender, EventArgs e)
        {
            button_removePackage.BackgroundImage = AndroidManager_SHW.Properties.Resources.unistallLight_UC;
        }

        private void button_removePackage_MouseLeave(object sender, EventArgs e)
        {
            button_removePackage.BackgroundImage = AndroidManager_SHW.Properties.Resources.unistall_UC;
        }
        private void button_backupPackage_MouseHover(object sender, EventArgs e)
        {
            button_backupPackage.BackgroundImage = AndroidManager_SHW.Properties.Resources.backupLight_UC;
        }

        private void button_backupPackage_MouseLeave(object sender, EventArgs e)
        {
            button_backupPackage.BackgroundImage = AndroidManager_SHW.Properties.Resources.backup_UC;
        }
        #endregion

        public apkPackageUserControl()
        {
            InitializeComponent();
        }

        private void apkPackageUserControl_Load(object sender, EventArgs e)
        {
            label_package.Text = packageName;
            label_version.Text = version;
            string pathImage = iconPackagePath;
            try
            {
                pictureBox_iconPackage.BackgroundImage = Image.FromFile(pathImage);
            }
            catch
            {
                pictureBox_iconPackage.BackgroundImage = AndroidManager_SHW.Properties.Resources.default_UC;
            }
        }





        private void button_removePackage_Click(object sender, EventArgs e)
        {
            removePackageClick(sender, e);
        }

        private void button_backupPackage_Click(object sender, EventArgs e)
        {
            backupPackageClick(sender, e);
        }

        private void label_package_Click(object sender, EventArgs e)
        {
            if (isSelected)
            {
                this.BackColor = Color.Transparent;
                button_selectedPackage.Visible = false;
                isSelected = false;
                
            }
            else
            {
                this.BackColor = Color.Gainsboro;
                button_selectedPackage.Visible = true;
                isSelected = true;
            }
            packageSelected(sender, e);
        }





  
    }
}
