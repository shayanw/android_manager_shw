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
using ADBFileProccessDLL;


namespace AndroidManager_SHW
{
    public partial class HomeForm : Form
    {
        AdbServer server;
        List<DeviceData> devices;
        DeviceData currentDevice;
        public HomeForm()
        {
            InitializeComponent();
            server = new AdbServer();
            //var resultStartServer = server.StartServer(@".\platform-tools\adb.exe", false);
            var resultStartServer = server.StartServer(@"C:\Program Files (x86)\platform-tools\adb.exe", false);
            
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            RefreshDevices();
        }

        void RefreshDevices()
        {
            devices = AdbClient.Instance.GetDevices();
            comboBox_devices.Items.Clear();
            comboBox_devices.Items.AddRange(devices.ToArray());
            comboBox_devices.ValueMember = "Model";
            comboBox_devices.DisplayMember = "Model";

            if (devices.Count!=0)
            {
                currentDevice = devices[0];
                selectDevice();
                comboBox_devices.SelectedIndex = 0;
            }
        }

        private void selectDevice()
        {
            label_model.Text = "Model: "+currentDevice.Model;
            label_name.Text = "Name: "+currentDevice.Name;
            label_serial.Text = "Serial: "+currentDevice.Serial;
            label_state.Text ="State: "+currentDevice.State.ToString();
            label_usb.Text = "USB: "+currentDevice.Usb;
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            RefreshDevices();
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            currentDevice = devices[comboBox_devices.SelectedIndex];
            selectDevice();
        }

        private void button_fileManager_Click(object sender, EventArgs e)
        {
            FileManagerForm fmf = new FileManagerForm(currentDevice);
            fmf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransferForm tf = new TransferForm();
            tf.Show();
        }
        //void CheckConnectDisconnect()
        //{
        //    var monitor = new DeviceMonitor(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)));
        //    monitor.DeviceConnected += this.OnDeviceConnected;
        //    monitor.DeviceDisconnected += Monitor_DeviceDisconnected;
        //    monitor.Start();
        //}

        //private void Monitor_DeviceDisconnected(object sender, DeviceDataEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //void OnDeviceConnected(object sender, DeviceDataEventArgs e)
        //{
        //    Console.WriteLine($"The device {e.Device.Name} has connected to this PC");
        //}
    }
}
