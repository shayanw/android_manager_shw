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
        #region FIELD
        DeviceData Device;
        SharpAdbClient.DeviceCommands.PackageManager PM;
        ApkManager am;
        List<KeyValuePair<string, string>> MyPackages;
        int TotalPackage, PackageProccessCounter;
        List<Control> ListControl, ListSelectedControl;

        Queue<string[]> QueueControlNameVersionString;
        Queue<string> QueueApksFullNameForInstall;
        #endregion

        public PMFormNew(DeviceData device)
        {
            InitializeComponent();
            Device = device;
            am = new ApkManager(Device);
            QueueControlNameVersionString = new Queue<string[]>();
            QueueApksFullNameForInstall = new Queue<string>();
            ListControl = ListSelectedControl = new List<Control>();
            MyPackages = new List<KeyValuePair<string, string>>();
            RefreshFlowLayoutPanel();
        }
        private void RefreshFlowLayoutPanel()
        {
            flowLayoutPanel_packages.Controls.Clear();
            MyPackages.Clear();
            panel_bottomProgress.Visible = true;
            if (backgroundWorker_flowLayoutPanel.IsBusy)
            {
                backgroundWorker_flowLayoutPanel.CancelAsync();
            }
            if (!backgroundWorker_flowLayoutPanel.IsBusy)
            {
                backgroundWorker_flowLayoutPanel.RunWorkerAsync();
            }
        }


        #region backgroundWorker_flowLayoutPanel
        private void backgroundWorker_flowLayoutPanel_DoWork(object sender, DoWorkEventArgs e)
        {
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
            PackageProccessCounter = 0;

            foreach (var tmpPackage in MyPackages)
            {
                PackageProccessCounter++;
                NameVersion=new string[]{ tmpPackage.Key, PM.GetVersionInfo(tmpPackage.Key).VersionName};
                backgroundWorker_flowLayoutPanel.ReportProgress(PackageProccessCounter, NameVersion);
            }

        }
        private void backgroundWorker_flowLayoutPanel_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar_Load.Maximum = TotalPackage;
            progressBar_Load.Value = e.ProgressPercentage;
            string[] stringArryNameVersion = (string[])e.UserState;

            label_status.Text = string.Format("Proccess {0}/{1} Packages     |     {2} package added", e.ProgressPercentage, TotalPackage, stringArryNameVersion[0]);

            QueueControlNameVersionString.Enqueue(stringArryNameVersion);

            if (!backgroundWorker_addControlFLP.IsBusy)
            {
                backgroundWorker_addControlFLP.RunWorkerAsync();
            }
        }
        private void backgroundWorker_flowLayoutPanel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label_status.Text = string.Format("{0} Package",TotalPackage);
            panel_bottomProgress.Visible = false;
        }
        #endregion

        #region backgroundWorker_addControlFLP
        private void backgroundWorker_addControlFLP_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] str;
            apkPackageUserControl tmpApuc;
            while (QueueControlNameVersionString.Count>0)
            {
                str = QueueControlNameVersionString.Dequeue();
                string backcolor = "default";
                int stateExistBackup = am.ExistBackup(str[1], str[0]);
                if (stateExistBackup == 0)
                {
                    backcolor = Color.PowderBlue.Name;
                }
                else if (stateExistBackup == 1)
                {
                    backcolor = Color.Lavender.Name;
                }
                else
                {
                    backcolor = Color.Transparent.Name;
                }
                tmpApuc= new apkPackageUserControl(str[0], str[1], backcolor);
                tmpApuc.removePackageClick += TmpApuc_removePackageClick;
                tmpApuc.backupPackageClick += TmpApuc_backupPackageClick;
                backgroundWorker_addControlFLP.ReportProgress(1, tmpApuc);
            }
        }
        private void backgroundWorker_addControlFLP_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            flowLayoutPanel_packages.Controls.Add((apkPackageUserControl)e.UserState);
        }
        private void backgroundWorker_addControlFLP_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!backgroundWorker_setIcon.IsBusy)
            {
                backgroundWorker_setIcon.RunWorkerAsync();
            }

        }
        #endregion

        #region backgroundWorker_setIcon
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
        #endregion



        #region apkPackageUC_Event
        private void TmpApuc_backupPackageClick(object sender, EventArgs e)
        {
            apkPackageUserControl tmpApuc = (apkPackageUserControl)sender;
            string tmpMessage = "Are You Sure Backup " + tmpApuc.PackageNameProp + " Application?";
            ListSelectedControl = new List<Control>() { tmpApuc };
            excecuteBackup(tmpMessage, 1);
        }
        private void TmpApuc_removePackageClick(object sender, EventArgs e)
        {
            apkPackageUserControl tmpApuc = (apkPackageUserControl)sender;
            string tmpMessage = "Are You Sure Delete " + tmpApuc.PackageNameProp + " Application?";
            ListSelectedControl = new List<Control>(){tmpApuc};
            excecuteUnistall(tmpMessage, 1);
        }
        #endregion

        #region searchUC
        private void searchUserControl_TextChangedEvent(object sender, EventArgs e)
        {
            return;
        }
        #endregion



        private void button_selectAll_Click(object sender, EventArgs e)
        {
            foreach (apkPackageUserControl tmpAPUC in flowLayoutPanel_packages.Controls)
            {
                tmpAPUC.isSelectedProp = true;
            }
        }

        private void button_selectNone_Click(object sender, EventArgs e)
        {
            foreach (apkPackageUserControl tmpAPUC in flowLayoutPanel_packages.Controls)
            {
                tmpAPUC.isSelectedProp = false;
            }
        }

        private void button_unistall_Click(object sender, EventArgs e)
        {
            int countSelect = getSelectedControls().Count;
            string tmpMessage = "";
            if (countSelect == 0)
            {
                return;
            }
            if (countSelect == 1)
            {
                tmpMessage = "Are You Sure Delete " + ((apkPackageUserControl)ListSelectedControl[0]).PackageNameProp + " ?";
            }
            else
            {
                tmpMessage = "Are You Sure Delete " + countSelect + " Application?";
            }

            excecuteUnistall(tmpMessage,countSelect);
        }

        private void excecuteUnistall(string message,int countPackage)
        {
            if (DialogResult.Yes == MessageBox.Show(message, "Unistall...", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                panel_bottomProgress.Visible = true;
                label_status.Text = "Unistalling ";

                progressBar_Load.Value = 0;
                progressBar_Load.Maximum = countPackage;
                progressBar_Load.Visible = true;

                backgroundWorker_unistallPackages.RunWorkerAsync();
            }
        }

        private void button_backup_Click(object sender, EventArgs e)
        {
            int countrows = getSelectedControls().Count;
            string tmpMessage = "";
            if (countrows == 0)
            {
                return;
            }
            if (countrows == 1)
            {
                tmpMessage = "Are You Sure Backup " + ((apkPackageUserControl)ListSelectedControl[0]).ProductName + " ?";
            }
            else
            {
                tmpMessage = "Are You Sure Backup " + countrows + " Application?";
            }

            excecuteBackup(tmpMessage, countrows);
        }
        private void excecuteBackup(string message, int countPackage)
        {
            if (DialogResult.Yes == MessageBox.Show(message, "Backing Up...", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                panel_bottomProgress.Visible = true;
                label_status.Text = "Backing Up";
                progressBar_Load.Value = 0;
                progressBar_Load.Maximum = countPackage;
                progressBar_Load.Visible = true;
                if (!backgroundWorker_backupPackages.IsBusy)
                {
                    backgroundWorker_backupPackages.RunWorkerAsync();
                }
            }
        }

        private List<Control> getSelectedControls()
        {
            ListSelectedControl = new List<Control>();
            foreach (apkPackageUserControl tmpAPUC in flowLayoutPanel_packages.Controls)
            {
                if (tmpAPUC.isSelectedProp)
                {
                    ListSelectedControl.Add(tmpAPUC);
                }
            }
            return ListSelectedControl;
        }

        #region backgroundWorker_unistallPackages
        private void backgroundWorker_unistallPackages_DoWork(object sender, DoWorkEventArgs e)
        {
            int success, fail;
            success = fail = 0;

            foreach (apkPackageUserControl onePackage in ListSelectedControl)
            {
                if (am.UnistallApk(onePackage.PackageNameProp))
                {
                    success++;
                    backgroundWorker_unistallPackages.ReportProgress(success, onePackage);
                }
                else
                {
                    fail++;
                }
               
            }
        }

        private void backgroundWorker_unistallPackages_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            flowLayoutPanel_packages.Controls.Remove((apkPackageUserControl)e.UserState);
            label_status.Text = "Unistalling " + e.ProgressPercentage + "/" + progressBar_Load.Maximum + " Packages...";
            progressBar_Load.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_unistallPackages_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            panel_bottomProgress.Visible = false;
            //RefreshDataGridView();
        }
        #endregion

        #region backgroundWorker_backupPackages
        private void backgroundWorker_backupPackages_DoWork(object sender, DoWorkEventArgs e)
        {
            int success, fail;
            success = fail = 0;

            foreach (apkPackageUserControl onePackage in ListSelectedControl)
            {
                string addressPackage = MyPackages.Where(a => a.Key == onePackage.PackageNameProp).FirstOrDefault().Value;

                if (am.BackupApk(addressPackage, onePackage.VersionProp, onePackage.PackageNameProp))
                {
                    success++;
                    fail = 0;

                    onePackage.BackColorProp = Color.PowderBlue;
                }
                else
                {
                    fail++;
                }
                backgroundWorker_backupPackages.ReportProgress(success + fail, new int[] { success, fail });
            }
        }

        private void backgroundWorker_backupPackages_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label_status.Text = "Backing Up " + ((int[])e.UserState)[0] + "/" + progressBar_Load.Maximum + " Packages...";
            if (((int[])e.UserState)[1] == 0)
            {
                progressBar_Load.Value = e.ProgressPercentage;
            }
        }

        private void backgroundWorker_backupPackages_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Diagnostics.Process.Start(Option.FullAddressBackupApk);
            if (progressBar_Load.Value == progressBar_Load.Maximum)
            {
                label_status.Text = "Backup is Successed";
            }
            else
            {
                label_status.Text = "Backup is Failed";
            }
            panel_bottomProgress.Visible = false;
            if (!backgroundWorker_KeepLatestApkBackup.IsBusy)
            {
                backgroundWorker_KeepLatestApkBackup.RunWorkerAsync();
            }
        }

        #endregion

        #region backgroundWorker_KeepLatestApkBackup
        private void backgroundWorker_KeepLatestApkBackup_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!Option.IsKeepLatestApk)
            {
                return;
            }
            Option opt = new Option(Device);
            string path = opt.intoApkBackupDirectory();
            if (!Directory.Exists(path))
            {
                return;
            }
            ExternalMethod.KeepLatestVersionApkBackup(path);
        }
        #endregion

        #region backgroundWorker_installApk
        private void backgroundWorker_installApk_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = 0;
            string fileFullName = "";
            while (QueueApksFullNameForInstall.Count > 0)
            {
                fileFullName = QueueApksFullNameForInstall.Dequeue();
                count++;

                if (am.InstallApk(fileFullName))
                {
                    backgroundWorker_installApk.ReportProgress(count, new string[] { fileFullName, "Successfull" });

                }
                else
                {
                    backgroundWorker_installApk.ReportProgress(count, new string[] { fileFullName, "fail" });
                }

            }
        }

        private void backgroundWorker_installApk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string[] tmpstrarry = (string[])e.UserState;
            label_status.Text = "installing " + tmpstrarry[0] + " " + tmpstrarry[1];
        }

        private void backgroundWorker_installApk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label_status.Text = "Finished...";
            panel_phoneInstall.BackgroundImage = AndroidManager_SHW.Properties.Resources.internalMemory;
        }
        #endregion


        #region phoneInstall_Drag&Drop
        private void panel_phoneInstall_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
                panel_phoneInstall.BackColor = Color.FromKnownColor(KnownColor.GradientActiveCaption);
                panel_phoneInstall.BackgroundImage = AndroidManager_SHW.Properties.Resources.dropDown_PM;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void panel_phoneInstall_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            panel_phoneInstall.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            
            foreach (string tmpFile in files)
            {
                if (tmpFile.ToLower().Contains(".apk"))
                {
                    QueueApksFullNameForInstall.Enqueue(tmpFile);
                }
            }
            if (backgroundWorker_installApk.IsBusy)
            {
                return;
            }
            else
            {
                if (QueueApksFullNameForInstall.Count == 0)
                {
                    return;
                }
                label_status.Text = "installing Package...";
                backgroundWorker_installApk.RunWorkerAsync();
                panel_phoneInstall.BackgroundImage = AndroidManager_SHW.Properties.Resources.install_PM;
            }
           
        }

 
        private void panel_phoneInstall_DragLeave(object sender, EventArgs e)
        {
            if (!backgroundWorker_installApk.IsBusy)
            {
                panel_phoneInstall.BackgroundImage = AndroidManager_SHW.Properties.Resources.internalMemory;
                panel_phoneInstall.BackColor= Color.FromKnownColor(KnownColor.ActiveCaption);
            }
        }
        #endregion

    }
}
