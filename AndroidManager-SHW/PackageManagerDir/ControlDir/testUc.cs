using AndroidManager_SHW.FileManager.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidManager_SHW.FileManagerDir.ControlDir
{
    public partial class testUc : Form
    {

        string pathApks = @"C:\Users\shayan\Documents\Android Manager SHW\ALP_L29_HWALP[QMU7N18424000111]\ApkBackups_SHW";
        string pathIcons = @"C:\Users\shayan\Documents\Android Manager SHW\Icons";
        bool flagFinish = false;
        Queue<apkPackageUserControl> apucList = new Queue<apkPackageUserControl>();
        public testUc()
        {
            InitializeComponent();
        }

        private void testUc_Load(object sender, EventArgs e)
        {

            backgroundWorker_flow.RunWorkerAsync();
          
        }

        private void backgroundWorker_flow_DoWork(object sender, DoWorkEventArgs e)
        {
            timer_addicon.Start();
            apkPackageUserControl apuc;
            List<string> listIcons = new List<string>(Directory.GetFiles(pathIcons));
            List<string> listPngs = new List<string>();

            foreach (string png in listIcons)
            {
                listPngs.Add(png.Replace(".png", "").Replace(pathIcons + @"\", ""));
            }

            foreach (string apk in Directory.GetFiles(pathApks))
            {
                apuc = new apkPackageUserControl();
                apuc.PackageNameProp = new FileInfo(apk).Name;
                apuc.VersionProp = "Version Beta";

                foreach (string png in listPngs)
                {
                    if (apuc.PackageNameProp.Contains(png))
                    {
                        apuc.IconPackagePathProp = pathIcons + @"\" + png + ".png";
                        break;
                    }
                    else
                    {
                        apuc.IconPackagePathProp = png + ".png";
                    }
                }
                backgroundWorker_flow.ReportProgress(1, apuc);
                
            }
        }

        private void backgroundWorker_flow_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            apkPackageUserControl apuc = (apkPackageUserControl)e.UserState;
            apuc.packageSelected += Apuc_packageSelected;
            apucList.Enqueue(apuc);
        }

        private void Apuc_packageSelected(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (apucList.Count>0)
            {
                flowLayoutPanel1.Controls.Add(apucList.Dequeue());
            }
            else
            {
                if (flagFinish)
                {
                    timer_addicon.Stop();
                }
            }
            
        }

        private void backgroundWorker_flow_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            flagFinish = true;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
