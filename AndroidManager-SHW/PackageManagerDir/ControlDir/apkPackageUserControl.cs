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
        string Version, PackageName, IconPackagePath;
        bool isPanelButtonVisible = false;
        bool isSelected = false;



        public event EventHandler removePackageClick;
        public event EventHandler backupPackageClick;
        public event EventHandler packageSelected;

        public string VersionProp { get { return Version; } set { Version = value; } }
        public string PackageNameProp { get { return PackageName; } set { PackageName = value; } }
        public string IconPackagePathProp { get { return IconPackagePath; } set
            {
                try
                {
                    pictureBox_iconPackage.BackgroundImage = Image.FromFile(value);
                    IconPackagePath = value;
                }
                catch
                {
                    pictureBox_iconPackage.BackgroundImage = AndroidManager_SHW.Properties.Resources.default_UC;
                }
            } }
        public bool isPanelButtonVisibleProp { get { return isPanelButtonVisible; }
            set {
                isPanelButtonVisible = button_removePackage.Visible=button_backupPackage.Visible = value;
            } }

        public bool isSelectedProp { get {return isSelected; } set
            {
                isSelected = value;
                if (isSelected)
                {
                    this.BackColor = Color.Gainsboro;
                    button_selectedPackage.Visible = true;
                }
                else
                {
                    this.BackColor = lastColor;
                    button_selectedPackage.Visible = false;
                }
            } }
        Color lastColor;
        public Color BackColorProp { get { return this.BackColor; } set { this.BackColor =lastColor= value; } }
        

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
            pictureBox_iconPackage.BackgroundImage = AndroidManager_SHW.Properties.Resources.default_UC;

        }
        public apkPackageUserControl(string packagename,string version,string backcolor="default", string iconPath = "default")
        {
            InitializeComponent();

            PackageName = packagename;
            Version = version;
            if (backcolor == "default")
            {
                this.BackColorProp = Color.Transparent;
            }
            else
            {
                this.BackColorProp = Color.FromName(backcolor);
            }
            if (iconPath == "default")
            {
                pictureBox_iconPackage.BackgroundImage = AndroidManager_SHW.Properties.Resources.default_UC;
            }
            else
            {
                pictureBox_iconPackage.BackgroundImage = Image.FromFile(iconPath);
            }
        }
        private void apkPackageUserControl_Load(object sender, EventArgs e)
        {
            label_package.Text = PackageName;
            label_version.Text = Version; 
        }





        private void button_removePackage_Click(object sender, EventArgs e)
        {
            removePackageClick(this, e);
        }

        private void button_backupPackage_Click(object sender, EventArgs e)
        {
            backupPackageClick(this, e);
        }

        private void package_Click(object sender, EventArgs e)
        {
            isSelectedProp = !isSelected;

            return;
            packageSelected(sender, e);
        }





  
    }
}
