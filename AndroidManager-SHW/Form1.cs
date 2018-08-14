using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SharpAdbClient;
using ADBProccessDLL;
using System.Net;
using System.IO;

namespace AndroidManager_SHW
{
    public partial class HomeForm : Form
    {
        #region Filed And Prop
        int counterTimer = 0;
        AdbServer server;
        List<DeviceData> devices;
        public static DeviceData currentDevice;
        List<Form> childForms = new List<Form>();
        bool IsDisconnect, IsConnect, IsDebuging;
        ADBProccessDLL.Setting st;

        List<FileInfo> listTmpApks;
        List<string[]> ListStateInstalledApk;
        ApkManager AM;
        string lastLableState;
        string stateMessage;
        #endregion

        #region Constructor
        public HomeForm()
        {

            InitializeComponent();
            server = new AdbServer();
            currentDevice = null;
            IsDisconnect = IsConnect = IsDebuging = false;
            TestDeviceConnect();
            st = new ADBProccessDLL.Setting();
            stateMessage="";

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            RefreshDevices();
        }
        #endregion

        #region Refresh Device
        void RefreshDevices()
        {
            //hame icon ha black and white she
            currentDeviceIsNullIcon();
            panel_upLeftSide.AllowDrop = false;
            //liste device haye motasel dar devices entesab mishe
            try
            {
                devices = AdbClient.Instance.GetDevices();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            //age currentDevice vujud dasht...
            if (currentDevice!=null)
            {
                //age serial curentDevice tuye serialaye list devices vojud nadasht=>yani currentDevice alan dige nist pas (currentDevice = null) va icon ha black and white she...
                if (devices.Where(a => a.Serial == currentDevice.Serial).Count() == 0)
                {
                    currentDevice = null;
                    currentDeviceIsNullIcon();
                }
            }
            
            //item haye combobox pak she
            comboBox_devices.Items.Clear();

            //tamame item haye devices tuye item haye comboBox entesab she
            comboBox_devices.Items.AddRange(devices.ToArray());

            //arzeshe item ha va namayeshe una bar asase Model Device bashe...
            comboBox_devices.ValueMember = "Model";
            comboBox_devices.DisplayMember = "Model";

            //tamame label ha vaziat nabud dastgah ro neshun midan
            label_model.Text = "[ No Device ! ]";
            label_vAndroid.Text = label_battery.Text =label_serial.Text = " ";
            panel_downLeftSide.BackColor = Color.Silver;
            label_state.Text = "State: Offline";

            //age dastgahi vojud dasht va currentDevice null bud=> avalin dastgah ro currentDevice entesab kon
            if (devices.Count > 0 && currentDevice == null)
            {
                currentDevice = devices[0];
            }

            selectDevice();

        }

        /// <summary>
        /// moshakhasate currentDevice ro ruye label ha namayesh bede
        /// currentdevice ro dar comboBox namayesh bede
        /// </summary>
        private void selectDevice()
        {
            if (devices.Count != 0)
            { 
                //age currentDevice vojud dasht ama Model ro natunest neshun bede=>debuging active nist & timer_event start she
                if (string.IsNullOrEmpty(currentDevice.Model))
                {
                    label_model.Text = "Please Allow USB Debuging";
                    label_serial.Text= "Serial:  " + currentDevice.Serial;
                    label_state.Text = "State: Away";
                    button_mobileState.BackgroundImage = AndroidManager_SHW.Properties.Resources.mobileDebugging;
                    panel_downLeftSide.BackColor = Color.Yellow;
                    panel_upLeftSide.BackColor = Color.Ivory;
                    IsDebuging = true;
                    currentDevice = null;
                    timer_event.Start();
                }
                else
                {
                    currentDeviceIsOn();
                    panel_downLeftSide.BackColor =Color.GreenYellow;
                    label_model.Text = "Model:  " + currentDevice.Model;
                    label_serial.Text = "Serial:  " + currentDevice.Serial;
                    label_vAndroid.Text = "Android:  " + currentDevice.AndroidVersion();
                    label_battery.Text = "Battery:  " + currentDevice.BatteryPercentage() + "%";
                    label_state.Text = "State: " + currentDevice.State.ToString();
                    comboBox_devices.SelectedIndex = devices.IndexOf(currentDevice);
                    panel_upLeftSide.AllowDrop = true;
                }

            }
        }

        void TestDeviceConnect()
        {
            var monitor = new DeviceMonitor(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)));
            monitor.DeviceConnected += Monitor_DeviceConnected;
            monitor.DeviceDisconnected += Monitor_DeviceDisconnected;
            monitor.Start();
        }

        /// <summary>
        /// age device disconnect shod => IsDisconnect True mishe & timer_event Start mishe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Monitor_DeviceDisconnected(object sender, DeviceDataEventArgs e)
        {
            DisposeAllChildForm();
            IsDisconnect = true;
            timer_event.Start();
        }

        /// <summary>
        /// age device connect shod => IsConnect True mishe & timer_event Start mishe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Monitor_DeviceConnected(object sender, DeviceDataEventArgs e)
        {
            IsConnect = true;
            timer_event.Start();
        }

        private void timer_event_Tick(object sender, EventArgs e)
        {
            //age device(connect,disconnect,debuging)~taghir vaziat nadad... => kari nakon
            if (!IsConnect && !IsDisconnect && !IsDebuging)
            {
                return;
            }
            //age taghir vaziat dad...=>hame vaziat haro false mikonim
            counterTimer++;
            IsConnect = IsDisconnect = IsDebuging = false;
            RefreshDevices();
        }
        #endregion

        #region buttons Right Panel
        private void button_fileManager_Click(object sender, EventArgs e)
        {
            if (currentDevice == null)
            {
                return;
            }
            FileManagerForm fmf = new FileManagerForm(currentDevice);
            pictureBox_onMobileState_enable(sender);
            fmf.FormClosed += allFormClosed;
            fmf.ShowDialog();

            //----- ezafi -----
            childForms.Add(fmf);
        }
        private void button_software_Click(object sender, EventArgs e)
        {
            if (currentDevice == null)
            {
                return;
            }
            PackageManager.PMForm pmrf = new PackageManager.PMForm(currentDevice);
            pictureBox_onMobileState_enable(sender);
            pmrf.FormClosed += allFormClosed;
            pmrf.ShowDialog();

            //----- ezafi -----
            childForms.Add(pmrf);

        }
        private void button_setting_Click(object sender, EventArgs e)
        {
            Setting.SettingForm stf = new Setting.SettingForm();
            pictureBox_onMobileState_enable(sender);
            stf.FormClosed += allFormClosed;
            stf.ShowDialog();
        }
        private void button_shutdown_Click(object sender, EventArgs e)
        {
            if (currentDevice == null)
            {
                return;
            }
            contextMenuStrip_reboot.Show(button_shutdown, new Point(0, 0));
            pictureBox_onMobileState.Image = AndroidManager_SHW.Properties.Resources.toggleOn;
            pictureBox_onMobileState.Visible = true;
            contextMenuStrip_reboot.Closed += ContextMenuStrip_reboot_Closed;
        }
        private void button_backupDirectory_Click(object sender, EventArgs e)
        {
            if (currentDevice == null)
            {
                try
                {
                    System.Diagnostics.Process.Start(Option.MainPath + "\\" + Option.MainLabelDirectoryName);
                }
                catch
                {

                }
            }
            else
            {
                Option opt = new Option(currentDevice);
                try
                {
                    System.Diagnostics.Process.Start(opt.MainPathBackupProp);
                }
                catch
                {

                }
            }
        }
        private void button_about_Click(object sender, EventArgs e)
        {
            pictureBox_onMobileState_enable(sender);
            if (MessageBox.Show("Create By ShayanW" + "\n\n" + "shayan.worthy@msn.com" + "\n\n" + "CopyRight 2018-2019" + "\n\n" + "Version: 0.95.7 Beta", "About Me", MessageBoxButtons.OK, MessageBoxIcon.Information)==DialogResult.OK)
            {
                pictureBox_onMobileState.Visible = false;
            }
        }

        private void pictureBox_onMobileState_enable(object sender)
        {
            pictureBox_onMobileState.Image = ((Button)sender).BackgroundImage;
            pictureBox_onMobileState.Visible = true;
        }
        private void ContextMenuStrip_reboot_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            pictureBox_onMobileState.Visible = false;
        }
        private void allFormClosed(object sender, FormClosedEventArgs e)
        {
            pictureBox_onMobileState.Visible = false;
        }
        #endregion

        #region buttons ContextMenu Reboot 
        private void rebootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentDevice.Reboot();
            RefreshDevices();
        }
        private void recoveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentDevice.Recovery();
            RefreshDevices();
        }
        private void bootloaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentDevice.Bootloader();
            RefreshDevices();
        }
        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentDevice.Shutdown();
            RefreshDevices();
        }
        #endregion

        #region buttons other and all about these

        private void button_state_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(stateMessage, "install status", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                stateMessage = "";
                button_state.Visible = false;
            }
        }

        /// <summary>
        /// az Form_networkADB nemune sakhte mishe va ShowDialog mishe 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_network_Click(object sender, EventArgs e)
        {
            Form_networkADB fnadb = new Form_networkADB();
            fnadb.FormClosed += Fnadb_FormClosed;
            pictureBox_onMobileState.Image = AndroidManager_SHW.Properties.Resources.network;
            pictureBox_onMobileState.Visible = true;
            fnadb.ShowDialog();

        }
        private void Fnadb_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (((Form_networkADB)sender).isChanged)
            {
                RefreshDevices();
            }
            pictureBox_onMobileState.Visible = false;
        }

        private void button_reconnect_Click(object sender, EventArgs e)
        {
            string cmdadb = "";

            if (currentDevice == null)
            {
                cmdadb = "reconnect";
            }
            else
            {
                cmdadb = string.Format("-s {0} reconnect", currentDevice.Serial);
            }

            ExternalMethod.AdbCommand(cmdadb);
            RefreshDevices();
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            RefreshDevices();
        }

        /// <summary>
        /// device entekhabi dar comboBox,be onvan currentDevice dar nazar gerefte she
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_select_Click(object sender, EventArgs e)
        {
            if (comboBox_devices.Items.Count == 0)
            {
                return;
            }

            try
            {
                currentDevice = devices[comboBox_devices.SelectedIndex];
                selectDevice();
            }
            catch (Exception)
            {

            }
        }

        private void comboBox_devices_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_select_Click(sender, e);
        }
        private void backgroundWorker_refreshCombo_DoWork(object sender, DoWorkEventArgs e)
        {
            devices = AdbClient.Instance.GetDevices();
            while (!comboBox_devices.IsDisposed)
            {

            }
        }
        private void backgroundWorker_refreshCombo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            comboBox_devices.Items.Clear();
            comboBox_devices.Items.AddRange(devices.ToArray());
            comboBox_devices.ValueMember = "Model";
            comboBox_devices.DisplayMember = "Model";

            if (devices.Count != 0)
            {
                currentDevice = devices[0];
                selectDevice();
                comboBox_devices.SelectedIndex = 0;
            }
        }
        #endregion

        #region Install Apk Drag&Drop
        private void panel_upLeftSide_DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
                panel_upLeftSide.BackgroundImage = null;
                panel_upLeftSide.BackColor = Color.PaleTurquoise;
            }
            else
                e.Effect = DragDropEffects.None;
        }
        private void panel_upLeftSide_DragLeave(object sender, EventArgs e)
        {

            if (backgroundWorker_installApk.IsBusy)
            {
                panel_upLeftSide.BackColor = Color.LightSteelBlue;
            }
            else
            {
                panel_upLeftSide.BackgroundImage = AndroidManager_SHW.Properties.Resources.walpapernew6;
            }
        }
        private void panel_upLeftSide_DragDrop(object sender, DragEventArgs e)
        {
            if (backgroundWorker_installApk.IsBusy)
            {
                panel_upLeftSide.BackColor = Color.LightSteelBlue;
                MessageBox.Show("Please Wait,Another Packages are installing...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                panel_upLeftSide.BackgroundImage = AndroidManager_SHW.Properties.Resources.walpapernew6;
            }

            if (currentDevice==null)
            { 
                return;
            }

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            listTmpApks = new List<FileInfo>();
            AM = new ApkManager(currentDevice);
            foreach (string itemFile in files)
            {
                if ((new FileInfo(itemFile).Extension.ToLower() == ".apk"))
                {
                    FileInfo fi = new FileInfo(itemFile);
                    listTmpApks.Add(fi);
                }
            }

            if (listTmpApks.Count==0)
            {
                return;
            }
            lastLableState = label_state.Text;
            panel_downLeftSide.BackColor = Color.SkyBlue;
            panel_upLeftSide.BackgroundImage = null;
            panel_upLeftSide.BackColor = Color.LightSteelBlue;
            pictureBox_onMobileState.Image = AndroidManager_SHW.Properties.Resources.installing;
            pictureBox_onMobileState.Visible = true;
            label_state.Text = "installing Package...";
            backgroundWorker_installApk.RunWorkerAsync();
        }

        private void backgroundWorker_installApk_DoWork(object sender, DoWorkEventArgs e)
        {

            ListStateInstalledApk = new List<string[]>();
            int count = 0;
            foreach (FileInfo apkFile in listTmpApks)
            {
                if (currentDevice == null)
                {
                    backgroundWorker_installApk.CancelAsync();
                }
                backgroundWorker_installApk.ReportProgress(count, apkFile.Name);
                count++;

                if (AM.InstallApk(apkFile.FullName))
                {
                    ListStateInstalledApk.Add(new string[] { apkFile.Name, "Successfull" });
                }
                else
                {
                    ListStateInstalledApk.Add(new string[] { apkFile.Name, "Failed" });
                }

            }
        }

        private void backgroundWorker_installApk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

         label_state.Text = "installing "+(string)e.UserState;

        }

        private void backgroundWorker_installApk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label_state.Text = "Finished...";
            string tmpMessage = "";
            foreach (string[] item2 in ListStateInstalledApk)
            {
                tmpMessage += string.Format("{0}     > {1} \n",item2[0],item2[1]);
            }
            stateMessage += tmpMessage;
            button_state.Visible = true;

            label_state.Text = lastLableState;
            panel_downLeftSide.BackColor = Color.GreenYellow;
            panel_upLeftSide.BackgroundImage = AndroidManager_SHW.Properties.Resources.walpapernew6;
            pictureBox_onMobileState.Visible = false;
        }
        #endregion

        #region Animation_Icons
        private void button_check_MouseHover(object sender, EventArgs e)
        {
            button_check.BackgroundImage = AndroidManager_SHW.Properties.Resources.refresh_shield8h;
        }

        private void button_check_MouseLeave(object sender, EventArgs e)
        {
            button_check.BackgroundImage = AndroidManager_SHW.Properties.Resources.refresh_shield8;
        }
        /// <summary>
        /// hameye icon ha black And white mishe
        /// </summary>
        private void currentDeviceIsNullIcon()
        {
            button_fileManager.Enabled = button_software.Enabled = button_shutdown.Enabled = false;
            button_fileManager.BackgroundImage = AndroidManager_SHW.Properties.Resources.file8bw;
            button_software.BackgroundImage = AndroidManager_SHW.Properties.Resources.soft8bw;
            button_shutdown.BackgroundImage = AndroidManager_SHW.Properties.Resources.power8bw;
            button_mobileState.BackgroundImage = AndroidManager_SHW.Properties.Resources.mobileOffline;
            button_backupDirectory.BackgroundImage = AndroidManager_SHW.Properties.Resources.backup8Orange;
            panel_upLeftSide.BackgroundImage = null;
            panel_upLeftSide.BackColor = Color.Gainsboro;
        }

        /// <summary>
        /// icon haye karbordi,rangi va ghabele estefade beshe
        /// </summary>
        /// 
        private void currentDeviceIsOn()
        {
            button_fileManager.Enabled = button_software.Enabled = button_shutdown.Enabled = button_setting.Enabled = true;
            button_fileManager.BackgroundImage = AndroidManager_SHW.Properties.Resources.file8;
            button_software.BackgroundImage = AndroidManager_SHW.Properties.Resources.soft8;
            button_shutdown.BackgroundImage = AndroidManager_SHW.Properties.Resources.power8;
            button_setting.BackgroundImage = AndroidManager_SHW.Properties.Resources.sett8h;
            //pictureBox1.Image = AndroidManager_SHW.Properties.Resources.mobile;
            button_mobileState.BackgroundImage = AndroidManager_SHW.Properties.Resources.mobileOnline;
            button_backupDirectory.BackgroundImage = AndroidManager_SHW.Properties.Resources.backup8;
            //panel_upLeftSide.BackColor = Color.FromArgb(178, 230, 213/*168, 220, 203*/);
            panel_upLeftSide.BackgroundImage = AndroidManager_SHW.Properties.Resources.walpapernew6;
        }

        private void pictureBox_fileManager_MouseHover(object sender, EventArgs e)
        {
            button_fileManager.BackgroundImage = AndroidManager_SHW.Properties.Resources.file8h;
            //  pictureBox_fileManager.Size = new Size(60, 60);
        }

        private void pictureBox_fileManager_MouseLeave(object sender, EventArgs e)
        {
            if (currentDevice == null)
            {
                return;
            }
            button_fileManager.BackgroundImage = AndroidManager_SHW.Properties.Resources.file8;
            // pictureBox_fileManager.Size = new Size(55, 55);
        }

        private void pictureBox_software_MouseHover(object sender, EventArgs e)
        {
            button_software.BackgroundImage = AndroidManager_SHW.Properties.Resources.soft8h;
            // pictureBox_software.Size = new Size(60, 60);
        }

        private void pictureBox_software_MouseLeave(object sender, EventArgs e)
        {
            if (currentDevice == null)
            {
                return;
            }
            button_software.BackgroundImage = AndroidManager_SHW.Properties.Resources.soft8;
            //pictureBox_software.Size = new Size(55, 55);
        }

        private void pictureBox_code_MouseHover(object sender, EventArgs e)
        {
            button_shutdown.BackgroundImage = AndroidManager_SHW.Properties.Resources.power8h;
            //pictureBox_code.Size = new Size(60, 60);
        }

        private void pictureBox_code_MouseLeave(object sender, EventArgs e)
        {
            if (currentDevice == null)
            {
                return;
            }
            button_shutdown.BackgroundImage = AndroidManager_SHW.Properties.Resources.power8;
            //  pictureBox_code.Size = new Size(55, 55);
        }

        private void button_setting_MouseHover(object sender, EventArgs e)
        {
            button_setting.BackgroundImage = AndroidManager_SHW.Properties.Resources.sett8h;
        }

        private void button_setting_MouseLeave(object sender, EventArgs e)
        {
            button_setting.BackgroundImage = AndroidManager_SHW.Properties.Resources.sett8;
        }


        private void button_backupDirectory_MouseHover(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                button_backupDirectory.BackgroundImage = AndroidManager_SHW.Properties.Resources.backup8h;
            }
            else
            {
                button_backupDirectory.BackgroundImage = AndroidManager_SHW.Properties.Resources.backup8Orangeh;
            }
        }

        private void button_backupDirectory_MouseLeave(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                button_backupDirectory.BackgroundImage = AndroidManager_SHW.Properties.Resources.backup8;
            }
            else
            {
                button_backupDirectory.BackgroundImage = AndroidManager_SHW.Properties.Resources.backup8Orange;
            }
        }

        private void button_about_MouseHover(object sender, EventArgs e)
        {
            button_about.BackgroundImage = AndroidManager_SHW.Properties.Resources.about8h;
        }
        private void button_about_MouseLeave(object sender, EventArgs e)
        {
            button_about.BackgroundImage = AndroidManager_SHW.Properties.Resources.about8;
        }

        private void button_state_MouseHover(object sender, EventArgs e)
        {
            button_state.BackgroundImage = AndroidManager_SHW.Properties.Resources.infoh;
        }

        private void button_state_MouseLeave(object sender, EventArgs e)
        {
            button_state.BackgroundImage = AndroidManager_SHW.Properties.Resources.info;
        }


        #endregion


        /// <summary>
        /// bayad tamame zir form haro bebande ->kar nemikone !
        /// </summary>
        public void DisposeAllChildForm()
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }
    }
}
