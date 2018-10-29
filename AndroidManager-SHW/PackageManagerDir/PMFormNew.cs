using ADBProccessDLL;
using AndroidManager_SHW.FileManager.Control;
using SharpAdbClient;
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

namespace AndroidManager_SHW.PackageManagerDir
{
    public partial class PMFormNew : Form
    {
        DeviceData Device;
        SharpAdbClient.DeviceCommands.PackageManager PM;
        ApkManager am;
        List<KeyValuePair<string, string>> MyPackages;
        int TotalPackage, c;
        List<Control> listControl = new List<Control>();
        Queue<string[]> qArrayControlString = new Queue<string[]>();
        public PMFormNew(DeviceData device)
        {
            InitializeComponent();
            Device = device;
            am = new ApkManager(Device);
            MyPackages = new List<KeyValuePair<string, string>>();

            if (backgroundWorker_flowLayoutPanel.IsBusy)
            {
                backgroundWorker_flowLayoutPanel.CancelAsync();
            }
            if (!backgroundWorker_flowLayoutPanel.IsBusy)
            {
                backgroundWorker_flowLayoutPanel.RunWorkerAsync();
            }
        }

        private void PMFormNew_Load(object sender, EventArgs e)
        {

        }



        private void backgroundWorker_flowLayoutPanel_DoWork(object sender, DoWorkEventArgs e)
        {
            //apkPackageUserControl apuc;
            string[] NameVersion;
            PM = new SharpAdbClient.DeviceCommands.PackageManager(Device);

            foreach (var item in PM.Packages)
            {
                if (!item.Value.Contains("/system/"))
                {
                    MyPackages.Add(item);
                }
            }

            TotalPackage = MyPackages.Count;
            c = 0;

            foreach (var item in MyPackages)
            {
                c++;
                NameVersion=new string[]{ item.Key, PM.GetVersionInfo(item.Key).VersionName};
                backgroundWorker_flowLayoutPanel.ReportProgress(c, NameVersion);
            }

        }



        private void backgroundWorker_flowLayoutPanel_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar_Load.Maximum = TotalPackage;
            progressBar_Load.Value = e.ProgressPercentage;
            label_status.Text = "Proccess " + e.ProgressPercentage + "/" + TotalPackage + " Packages";

            qArrayControlString.Enqueue((string[])e.UserState);

            if (!backgroundWorker_addControlFLP.IsBusy)
            {
                backgroundWorker_addControlFLP.RunWorkerAsync();
            }
        }

        private void backgroundWorker_addControlFLP_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] str;
            while (qArrayControlString.Count>0)
            {

                str = qArrayControlString.Dequeue();
                string backcolor = "default";
                //int stateExistBackup = am.ExistBackup(tmpApuc.ProductVersion, tmpApuc.ProductName);
                int stateExistBackup = am.ExistBackup(str[0], str[1]);
                if (stateExistBackup == 0)
                {
                    //tmpApuc.BackColorProp = Color.GreenYellow;
                    backcolor = Color.GreenYellow.Name;
                }
                else/* if (stateExistBackup == 1)*/
                {
                    //tmpApuc.BackColorProp = Color.LightSkyBlue;
                    backcolor = Color.LightSkyBlue.Name;
                }

                backgroundWorker_addControlFLP.ReportProgress(1, new apkPackageUserControl(str[0], str[1], backcolor));
            }
        }

        private void backgroundWorker_addControlFLP_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            flowLayoutPanel_packages.Controls.Add((apkPackageUserControl)e.UserState);
        }

        private void backgroundWorker_setIcon_DoWork(object sender, DoWorkEventArgs e)
        {
            string pathIcon = @"C:\Users\shayan\Documents\Android Manager SHW\Icons", pathpng;
            List<string> lsIcon = new List<string>(Directory.GetFiles(pathIcon));

            foreach (apkPackageUserControl tmpPackage in flowLayoutPanel_packages.Controls)
            {
                pathpng = lsIcon.Where(a => a.Contains(tmpPackage.PackageNameProp)).FirstOrDefault();
                if (!string.IsNullOrEmpty(pathpng))
                {
                    tmpPackage.IconPackagePathProp = pathpng;
                }
            }
        }

        private void backgroundWorker_addControlFLP_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!backgroundWorker_setIcon.IsBusy)
            {
                backgroundWorker_setIcon.RunWorkerAsync();
            }
           
        }

        private void backgroundWorker_flowLayoutPanel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //panel_bottomProgress.Visible = false;
            //flowLayoutPanel_packages.Controls.AddRange(listControl.ToArray());
        }
    }
}
