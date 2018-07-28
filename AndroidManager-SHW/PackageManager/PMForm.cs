using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpAdbClient;
using System.IO;
using ADBProccessDLL;
namespace AndroidManager_SHW.PackageManager
{
    public partial class PMForm : Form
    {
        DeviceData Device;
        SharpAdbClient.DeviceCommands.PackageManager PM;
        Stack<string> packageKeys;
        List<KeyValuePair<string, string>> MyPackages;
        int TotalPackage, c;
        List<string> oneRow = new List<string>();
        DataGridViewRow[] BackupDGV;
        List<FileInfo> PackagesTempFiles;
        ApkManager am;
        List<string> SelectedItemsForUnistall = new List<string>();
        List<string> SelectedItemsForInstall = new List<string>();
        List<DataGridViewRow> SelectedItemsForBackup = new List<DataGridViewRow>();
        public PMForm()
        {
            InitializeComponent();
        }
        public PMForm(DeviceData device)
        {
            InitializeComponent();
            TotalPackage = c = 0;
            MyPackages = new List<KeyValuePair<string, string>>();
            PackagesTempFiles = new List<FileInfo>();
            Device = device;
            am = new ApkManager(Device);
            packageKeys = new Stack<string>();
            RefreshDataGridView();
        }


        private void RefreshDataGridView()
        {
            dataGridView_devicePackages.Rows.Clear();
            MyPackages.Clear();
            progressBar_statePackage.Visible = true;
            if (backgroundWorker_setDataGridView.IsBusy)
            {
                backgroundWorker_setDataGridView.CancelAsync();
            }
            if (!backgroundWorker_setDataGridView.IsBusy)
            {
                backgroundWorker_setDataGridView.RunWorkerAsync();
            }

        }
        private void backgroundWorker_setDataGridView_DoWork(object sender, DoWorkEventArgs e)
        {
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
                oneRow.Clear();
                oneRow.Add(item.Key);
                oneRow.Add(PM.GetVersionInfo(item.Key).VersionName);
                c++;
                backgroundWorker_setDataGridView.ReportProgress(c, oneRow.ToArray());
            }
        }
        private void backgroundWorker_setDataGridView_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar_statePackage.Maximum = TotalPackage;
            progressBar_statePackage.Value = e.ProgressPercentage;
            label_statePackage.Text = "Proccess " + e.ProgressPercentage + "/" + TotalPackage + " Packages";
            string[] tmpList = (string[])e.UserState;

            int indexRow= dataGridView_devicePackages.Rows.Add(tmpList[0], tmpList[1]);
            int stateExistBackup = am.ExistBackup(tmpList[1], tmpList[0]);
            if (stateExistBackup == 0)
            {
                foreach (DataGridViewCell cell in dataGridView_devicePackages.Rows[indexRow].Cells)
                {
                    cell.Style.BackColor = Color.GreenYellow;
                }
            }
            else if (stateExistBackup == 1)
            {
                foreach (DataGridViewCell cell in dataGridView_devicePackages.Rows[indexRow].Cells)
                {
                    cell.Style.BackColor = Color.LightSkyBlue;
                }
            }
            else
            {

            }

            

        }
        private void backgroundWorker_setDataGridView_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar_statePackage.Visible = false;
            List<DataGridViewRow> LDGVTemp = new List<DataGridViewRow>();
            foreach (DataGridViewRow item in dataGridView_devicePackages.Rows)
            {
                LDGVTemp.Add(item);

            }
            BackupDGV = LDGVTemp.ToArray();
        }



        private void button_unistallDevicePackages_Click(object sender, EventArgs e)
        {
            int countrows = dataGridView_devicePackages.SelectedRows.Count;
            if (countrows == 0)
            {
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Are You Sure Delete " + countrows + " Packages?", "Unistall...", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                SelectedItemsForUnistall.Clear();
                foreach (DataGridViewRow oneRow in dataGridView_devicePackages.SelectedRows)
                {
                    SelectedItemsForUnistall.Add(oneRow.Cells["Name"].Value.ToString());
                }
                label_statePackage.Text = "Unistalling ";
                progressBar_statePackage.Value = 0;
                progressBar_statePackage.Maximum = countrows;
                progressBar_statePackage.Visible = true;
                backgroundWorker_unistallPackages.RunWorkerAsync();
                //RefreshDataGridView();
            }
        }

        private void backgroundWorker_unistallPackages_DoWork(object sender, DoWorkEventArgs e)
        {
            int success, fail;
            success = fail = 0;

            foreach (string onePackage in SelectedItemsForUnistall)
            {
                if (am.UnistallApk(onePackage))
                {
                    success++;
                }
                else
                {
                    fail++;
                }
                backgroundWorker_unistallPackages.ReportProgress(success + fail, new int[] { success, fail });
            }
        }

        private void backgroundWorker_unistallPackages_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label_statePackage.Text = "Unistalling " + ((int[])e.UserState)[0] + "/" + progressBar_statePackage.Maximum + " Packages...";
            progressBar_statePackage.Value = e.ProgressPercentage;
        }
        private void backgroundWorker_unistallPackages_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar_statePackage.Visible = false;
            RefreshDataGridView();
        }

        private void dataGridView_devicePackages_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_devicePackages.SelectedRows.Count == 1)
            {
                try
                {
                    string k = dataGridView_devicePackages.SelectedRows[0].Cells["Name"].Value.ToString();

                    label_addressPackage.Text = "Address: " + MyPackages.Where(a => a.Key == k).FirstOrDefault().Value;
                    label_namePackage.Text = "Name: " + MyPackages.Where(a => a.Key == k).FirstOrDefault().Key;
                }
                catch
                {
                    return;
                }
            }
        }


        private void button_addTempPackages_Click(object sender, EventArgs e)
        {

            if (openFileDialog_apk.ShowDialog() == DialogResult.OK)
            {
                foreach (string oneFile in openFileDialog_apk.FileNames)
                {
                    FileInfo fi = new FileInfo(oneFile);
                    PackagesTempFiles.Add(fi);
                    listBox_tempPackages.Items.Add(fi.Name);
                }
            }
        }

        private void button_removeTempPackages_Click(object sender, EventArgs e)
        {

            listBox_tempPackages.Items.Clear();
        }

        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                pictureBox_searchIcon_Click(sender, e);
            }
        }

        private void PMForm_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker_installPackages_DoWork(object sender, DoWorkEventArgs e)
        {

            int success, fail;
            success = fail = 0;
            bool isInternal, isReinstall;
            isReinstall = true;
            isInternal = true;
            if (radioButton_externalMemory.Checked)
            {
                isInternal = false;
            }
            foreach (string onePackage in SelectedItemsForInstall)
            {
                if (am.InstallApk(onePackage, isInternal, isReinstall))
                {
                    success++;
                    fail = 0;
                }
                else
                {
                    fail++;
                }
                backgroundWorker_installPackages.ReportProgress(success + fail, new int[] { success, fail });
            }

        }

        private void backgroundWorker_installPackages_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label_statePackage.Text = "Installing " + ((int[])e.UserState)[0] + "/" + progressBar_statePackage.Maximum + " Packages...";
            if (((int[])e.UserState)[1] == 0)
            {
                progressBar_statePackage.Value = e.ProgressPercentage;
            }
        }

        private void backgroundWorker_installPackages_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (progressBar_statePackage.Value == progressBar_statePackage.Maximum)
            {
                label_statePackage.Text = "Install is Successed";
            }
            else
            {
                label_statePackage.Text = "Install is Failed";
            }
            progressBar_statePackage.Visible = false;
            RefreshDataGridView();
        }

        private void pictureBox_searchIcon_Click(object sender, EventArgs e)
        {
            try
            {
                if (BackupDGV.Count() == 0)
                {
                    return;
                }
            }
            catch
            {
                return;
            }

            if (string.IsNullOrEmpty(textBox_search.Text) || textBox_search.Text == "Search Now •••")
            {
                dataGridView_devicePackages.Rows.Clear();
                dataGridView_devicePackages.Rows.AddRange(BackupDGV);
            }
            else
            {
                dataGridView_devicePackages.Rows.Clear();
                foreach (DataGridViewRow item in BackupDGV)
                {
                    try
                    {
                        if (item.Cells[0].Value.ToString().ToLower().Contains(textBox_search.Text.ToLower()))
                        {
                            dataGridView_devicePackages.Rows.Add(item);
                        }
                    }
                    catch (Exception)
                    {
                        return;
                    }

                }
            }
        }

        private void textBox_search_Enter(object sender, EventArgs e)
        {
            textBox_search.Text = "";
        }

        private void textBox_search_Leave(object sender, EventArgs e)
        {
            textBox_search.Text = "Search Now •••";
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int countrows = dataGridView_devicePackages.SelectedRows.Count;
            if (countrows == 0)
            {
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Are You Sure Backup " + countrows + " Packages?", "Backing Up...", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                SelectedItemsForBackup.Clear();
                foreach (DataGridViewRow oneRow in dataGridView_devicePackages.SelectedRows)
                {
                    SelectedItemsForBackup.Add(oneRow);
                }
                progressBar_statePackage.Visible = true;
                label_statePackage.Text = "Backing Up";
                progressBar_statePackage.Value = 0;
                progressBar_statePackage.Maximum = countrows;
                progressBar_statePackage.Visible = true;
                backgroundWorker_backupPackages.RunWorkerAsync();
            }

        }

        private void backgroundWorker_backupPackages_DoWork(object sender, DoWorkEventArgs e)
        {
            int success, fail;
            success = fail = 0;

            foreach (DataGridViewRow oneRow in dataGridView_devicePackages.SelectedRows)
            {
                string versionPackage = oneRow.Cells["Version"].Value.ToString();
                string k = oneRow.Cells["Name"].Value.ToString();
                string addressPackage = MyPackages.Where(a => a.Key == k).FirstOrDefault().Value;
                string namePackage = MyPackages.Where(a => a.Key == k).FirstOrDefault().Key;
      
                if (am.BackupApk(addressPackage, versionPackage, namePackage))
                {
                    success++;
                    fail = 0;
                    foreach (DataGridViewCell cell in oneRow.Cells)
                    {
                        cell.Style.BackColor = Color.GreenYellow;
                    }
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
            label_statePackage.Text = "Backing Up " + ((int[])e.UserState)[0] + "/" + progressBar_statePackage.Maximum + " Packages...";
            if (((int[])e.UserState)[1] == 0)
            {
                progressBar_statePackage.Value = e.ProgressPercentage;
            }
        }
        private void backgroundWorker_backupPackages_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (progressBar_statePackage.Value == progressBar_statePackage.Maximum)
            {
                label_statePackage.Text = "Backup is Successed";
            }
            else
            {
                label_statePackage.Text = "Backup is Failed";
            }
            progressBar_statePackage.Visible = false;
            System.Diagnostics.Process.Start(Option.FullAddressBackupApk);
        }

        private void listBox_tempPackages_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox_tempPackages_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string itemFile in files)
            { 
                if (File.Exists(itemFile))
                {
                    addToListBox_TempPackages(itemFile);
                }
            }
        }
        private void addToListBox_TempPackages(string addressFile)
        {
            if ((new FileInfo(addressFile).Extension.ToLower() == ".apk"))
            {
                FileInfo fi = new FileInfo(addressFile);
                PackagesTempFiles.Add(fi);
                listBox_tempPackages.Items.Add(fi.Name);
            }
        }
        private List<string> returnAddressFilesInDirectory(string addressDirectory)
        {
            List<string> listFiles = new List<string>();
            DirectoryInfo dr = new DirectoryInfo(addressDirectory);
            foreach (var item in dr.GetFiles())
            {
                listFiles.Add(item.FullName);
            }
            return listFiles;
        }
    


        private void button_installTempPackages_Click(object sender, EventArgs e)
        {
            int countpackageinstall = listBox_tempPackages.Items.Count;
            if (countpackageinstall == 0)
            {
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("Are You Sure Install " + countpackageinstall + " Packages?", "Install...", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                SelectedItemsForInstall.Clear();
                foreach (string s in listBox_tempPackages.Items)
                {
                    SelectedItemsForInstall.Add(PackagesTempFiles.Where(a => a.Name == s).FirstOrDefault().FullName);
                }
                label_statePackage.Text = "Installing... ";
                progressBar_statePackage.Value = 0;
                progressBar_statePackage.Maximum = countpackageinstall;
                progressBar_statePackage.Visible = true;
                backgroundWorker_installPackages.RunWorkerAsync();

            }
        }


    }
}
