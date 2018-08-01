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
using ADBProccessDLL;
using SharpAdbClient.DeviceCommands;
using System.Net;

namespace AndroidManager_SHW
{
    public partial class HomeForm : Form
    {
        int counterTimer = 0;
        AdbServer server;
        List<DeviceData> devices;
        public static DeviceData currentDevice;
        List<Form> childForms = new List<Form>();
        bool IsDisconnect, IsConnect, IsDebuging;


        public HomeForm()
        {

            InitializeComponent();
            server = new AdbServer();
            StartServerResult resultStartServer = server.StartServer(@".\platform-tools\adb.exe", false);
            currentDevice = null;
            IsDisconnect = IsConnect = IsDebuging = false;
            TestDeviceConnect();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            RefreshDevices();
        }

        void RefreshDevices()
        {
            //hame icon ha black and white she
            currentDeviceIsNullIcon();

            //liste device haye motasel dar devices entesab mishe
            devices = AdbClient.Instance.GetDevices();

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
            panel_downLeftSide.BackColor = Color.Gray;
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
                }

            }
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

        /// <summary>
        /// ye form az FileManagerForm besaz bad ShowDialog konesh...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_fileManager_Click(object sender, EventArgs e)
        {
            if (currentDevice == null)
            {
                return;
            }
            FileManagerForm fmf = new FileManagerForm(currentDevice);
            fmf.ShowDialog();

            //----- ezafi -----
            childForms.Add(fmf);
        }

        /// <summary>
        /// ye form az PMForm besaz bad ShowDialog konesh...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_software_Click(object sender, EventArgs e)
        {

            //PackageManager.PackageManagerForm pmf = new PackageManager.PackageManagerForm(currentDevice);
            //pmf.Show();
            if (currentDevice == null)
            {
                return;
            }
            PackageManager.PMForm pmrf = new PackageManager.PMForm(currentDevice);
            pmrf.ShowDialog();

            //----- ezafi -----
            childForms.Add(pmrf);

        }

        private void rebootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExternalMethod.resultCommand("reboot sideload-auto-reboot", currentDevice);
            RefreshDevices();
        }
        private void recoveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExternalMethod.resultCommand("reboot recovery", currentDevice);
            RefreshDevices();
        }
        private void bootloaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExternalMethod.resultCommand("reboot bootloader", currentDevice);
            RefreshDevices();
        }
        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExternalMethod.resultCommand("reboot -p", currentDevice);
            //ExternalMethod.AdbCommand(string.Format("adb -s {0} shell reboot -p",currentDevice.Serial));
            RefreshDevices();
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


        #region Animation_Icons

        /// <summary>
        /// hameye icon ha black And white mishe
        /// </summary>
        private void currentDeviceIsNullIcon()
        {
            button_fileManager.Enabled = button_software.Enabled = button_shutdown.Enabled = button_setting.Enabled = false;
            button_fileManager.BackgroundImage= AndroidManager_SHW.Properties.Resources.file8bw;
            button_software.BackgroundImage = AndroidManager_SHW.Properties.Resources.soft8bw;
            button_shutdown.BackgroundImage= AndroidManager_SHW.Properties.Resources.power8bw;
            button_setting.BackgroundImage = AndroidManager_SHW.Properties.Resources.sett8bw;

            //pictureBox1.Image= AndroidManager_SHW.Properties.Resources.mobilebw;
            button_mobileState.BackgroundImage = AndroidManager_SHW.Properties.Resources.mobileOffline;
            button_backupDirectory.BackgroundImage = AndroidManager_SHW.Properties.Resources.backup8Orange;
            panel_upLeftSide.BackColor = Color.LightGray;
        }

        /// <summary>
        /// icon haye karbordi,rangi va ghabele estefade beshe
        /// </summary>
        /// 
        private void currentDeviceIsOn()
        {
            button_fileManager.Enabled = button_software.Enabled = button_shutdown.Enabled = /*button_setting.Enabled=*/ true;
            button_fileManager.BackgroundImage = AndroidManager_SHW.Properties.Resources.file8;
            button_software.BackgroundImage = AndroidManager_SHW.Properties.Resources.soft8;
            button_shutdown.BackgroundImage = AndroidManager_SHW.Properties.Resources.power8;
            //button_setting.BackgroundImage = AndroidManager_SHW.Properties.Resources.sett8h;
            //pictureBox1.Image = AndroidManager_SHW.Properties.Resources.mobile;
            button_mobileState.BackgroundImage = AndroidManager_SHW.Properties.Resources.mobileOnline;
            button_backupDirectory.BackgroundImage = AndroidManager_SHW.Properties.Resources.backup8;
            panel_upLeftSide.BackColor = Color.FromArgb(178, 230, 213/*168, 220, 203*/);
        }

        private void pictureBox_fileManager_MouseHover(object sender, EventArgs e)
        {
            button_fileManager.BackgroundImage = AndroidManager_SHW.Properties.Resources.file8h;
            //  pictureBox_fileManager.Size = new Size(60, 60);
        }

        private void pictureBox_fileManager_MouseLeave(object sender, EventArgs e)
        {
            if (currentDevice==null)
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

        private void pictureBox_setting_MouseHover(object sender, EventArgs e)
        {
            button_setting.BackgroundImage = AndroidManager_SHW.Properties.Resources.sett8h;
            // pictureBox_setting.Size = new Size(60, 60);
        }

        private void pictureBox_setting_MouseLeave(object sender, EventArgs e)
        {
            if (currentDevice == null)
            {
                return;
            }
            button_setting.BackgroundImage = AndroidManager_SHW.Properties.Resources.sett8;
            // pictureBox_setting.Size = new Size(55, 55);
        }


        private void button_backupDirectory_MouseHover(object sender, EventArgs e)
        {
            if (currentDevice!=null)
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

        private void pictureBox_about_MouseHover(object sender, EventArgs e)
        {
            pictureBox_about.Image = AndroidManager_SHW.Properties.Resources.about8h;
        }

        private void pictureBox_about_MouseLeave(object sender, EventArgs e)
        {
            if (currentDevice == null)
            {
                return;
            }
            pictureBox_about.Image = AndroidManager_SHW.Properties.Resources.about8;
        }


        #endregion

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

        /// <summary>
        /// dar surate taghir vaziat => RefreshDevice ejra mishe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void pictureBox_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create By ShayanW" + "\n\n" + "shayan.worthy@msn.com" + "\n\n" + "CopyRight 2018-2019" + "\n\n" + "Version: 0.79 Beta", "About Me", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        /// <summary>
        /// az Form_networkADB nemune sakhte mishe va ShowDialog mishe 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_network_Click(object sender, EventArgs e)
        {
            Form_networkADB fnadb = new Form_networkADB();
            fnadb.ShowDialog();
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

        private void button_code_Click(object sender, EventArgs e)
        {
            if (currentDevice == null)
            {
                return;
            }
            contextMenuStrip_reboot.Show(button_shutdown,new Point(0,0));

            //AdbCommand.CommandForm cmdf = new AdbCommand.CommandForm(currentDevice);
            //cmdf.ShowDialog();

            ////----- ezafi -----
            //childForms.Add(cmdf);
        }

        private void button_reconnect_Click(object sender, EventArgs e)
        {
            string cmdadb = "";

            if (currentDevice==null)
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

        private void comboBox_devices_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_select_Click(sender, e);
        }


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
