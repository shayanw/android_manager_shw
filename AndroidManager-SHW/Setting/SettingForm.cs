using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADBProccessDLL;

namespace AndroidManager_SHW.Setting
{
    public partial class SettingForm : Form
    {
        ADBProccessDLL.Setting st;
        List<deviceSettingBackup> dsbl;
        public SettingForm()
        {
            InitializeComponent();
            st = new ADBProccessDLL.Setting();

            textBox_backupPath.Text = st.backupPath;

            if (textBox_backupPath.Text != System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
            {
                button_reset.BackColor = Color.LightPink;
            }

            try
            {
                RefreshDataGridView();


                if (st.isShowSizeFM)
                {
                    button_showFileSize.BackgroundImage = AndroidManager_SHW.Properties.Resources.toggleOn;
                    st.isShowSizeFM = true;
                }
                else
                {
                    button_showFileSize.BackgroundImage = AndroidManager_SHW.Properties.Resources.toggleOff;
                    st.isShowSizeFM = false;
                }

                if (st.isShowHiddenFile)
                {
                    button_showHiddenFile.BackgroundImage = AndroidManager_SHW.Properties.Resources.toggleOn;
                    st.isShowHiddenFile = true;
                }
                else
                {
                    button_showHiddenFile.BackgroundImage = AndroidManager_SHW.Properties.Resources.toggleOff;
                    st.isShowHiddenFile = false;
                }

            }
            catch
            {
                reset();
                RefreshDataGridView();
                MessageBox.Show("there is some Problem,Reset Setting...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (st.changeBackupPath(textBox_backupPath.Text))
                {
                    if (textBox_backupPath.Text == Option.MainPath && st.isShowSizeFM == Option.IsShowSizeFM && st.isShowHiddenFile==Option.IsShowHiddenFile)
                    {
                        return;
                    }
                    st.saveChanged();
                    RefreshDataGridView();
                    button_save.BackColor = Color.WhiteSmoke;
                    button_reset.BackColor = Color.LightPink;
                    MessageBox.Show("Save Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("this address is Not Valid !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Something is Wrong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button_backupPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_path.ShowDialog() == DialogResult.OK)
            {
                textBox_backupPath.Text = folderBrowserDialog_path.SelectedPath;
            }
        }
        private void button_updatePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_path.ShowDialog() == DialogResult.OK)
            {
                textBox_updatePath.Text = folderBrowserDialog_path.SelectedPath;
            }
        }
        private void button_reset_Click(object sender, EventArgs e)
        {
            try
            {
                reset();
                MessageBox.Show("Reset !", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGridView();
                button_reset.BackColor = Color.WhiteSmoke;
            }
            catch
            {
                MessageBox.Show("Something is Wrong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void reset()
        {
            textBox_backupPath.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            st.changeBackupPath(textBox_backupPath.Text);

            st.isShowSizeFM = Option.IsShowSizeFM = true;
            st.isShowHiddenFile = Option.IsShowHiddenFile = false;
            button_showFileSize.BackgroundImage = AndroidManager_SHW.Properties.Resources.toggleOn;
            button_showHiddenFile.BackgroundImage = AndroidManager_SHW.Properties.Resources.toggleOff;

            st.saveChanged();
        }


        private void RefreshDataGridView()
        {
            //List<deviceSettingBackup> dsbl = new List<deviceSettingBackup>();
            //string path = Option.MainPath + "\\" + Option.MainLabelDirectoryName;
            //DirectoryInfo di = new DirectoryInfo(path);
            //Regex rgx = new Regex(@"^.*_.*\[.*\]$");

            //foreach (DirectoryInfo tmpdi in di.GetDirectories())
            //{
            //    if (rgx.IsMatch(tmpdi.Name))
            //    {
            //        dsbl.Add(new deviceSettingBackup(tmpdi));
            //    }
            //}

            //dataGridView_Device.DataSource = dsbl;
            backgroundWorker_refreshDGV.RunWorkerAsync();
        }

        private void textBox_backupPath_TextChanged(object sender, EventArgs e)
        {
            if (textBox_backupPath.Text == Option.MainPath || textBox_backupPath.Text == System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
            {
                button_save.BackColor = Color.WhiteSmoke;
            }
            else
            {
                button_save.BackColor = Color.LightGreen;
            }

        }

        private void button_deleteDeviceBackup_Click(object sender, EventArgs e)
        {
            if (dataGridView_Device.SelectedRows.Count > 0)
            {
                try
                {
                    string tmpAddress = dataGridView_Device.SelectedRows[0].Cells["PathBackup"].Value.ToString();
                    string ModelDevice = dataGridView_Device.SelectedRows[0].Cells["Model"].Value.ToString();
                    if (MessageBox.Show("Are you sure to Delete " + ModelDevice + "'s Backups ? ", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Directory.Delete(tmpAddress, true);
                        MessageBox.Show("Delete " + ModelDevice + "'s Backups Successfully ", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataGridView();
                    }
                }
                catch
                {
                    MessageBox.Show("Somethings is Wrong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_openFolderBackup_Click(object sender, EventArgs e)
        {
            if (dataGridView_Device.SelectedRows.Count > 0)
            {
                string tmpAddress = dataGridView_Device.SelectedRows[0].Cells["PathBackup"].Value.ToString();
                System.Diagnostics.Process.Start(tmpAddress);
            }

        }

        private void dataGridView_Device_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                button_deleteDeviceBackup_Click(sender, e);
            }
        }

        private void button_showFileSize_Click(object sender, EventArgs e)
        {
            if (st.isShowSizeFM)
            {
                button_showFileSize.BackgroundImage = AndroidManager_SHW.Properties.Resources.toggleOff;
                st.isShowSizeFM = false;
            }
            else
            {
                button_showFileSize.BackgroundImage = AndroidManager_SHW.Properties.Resources.toggleOn;
                st.isShowSizeFM = true;
            }
        }

        private void backgroundWorker_refreshDGV_DoWork(object sender, DoWorkEventArgs e)
        {
            dsbl = new List<deviceSettingBackup>();
            string path = Option.MainPath + "\\" + Option.MainLabelDirectoryName;
            DirectoryInfo di = new DirectoryInfo(path);
            Regex rgx = new Regex(@"^.*_.*\[.*\]$");

            foreach (DirectoryInfo tmpdi in di.GetDirectories())
            {
                if (rgx.IsMatch(tmpdi.Name))
                {
                    dsbl.Add(new deviceSettingBackup(tmpdi));
                }
            }
            
        }

        private void backgroundWorker_refreshDGV_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridView_Device.DataSource = dsbl;
        }

        private void button_showHiddenFile_Click(object sender, EventArgs e)
        {
            if (st.isShowHiddenFile)
            {
                button_showHiddenFile.BackgroundImage = AndroidManager_SHW.Properties.Resources.toggleOff;
                st.isShowHiddenFile = false;
            }
            else
            {
                button_showHiddenFile.BackgroundImage = AndroidManager_SHW.Properties.Resources.toggleOn;
                st.isShowHiddenFile = true;
            }
        }
    }
}
