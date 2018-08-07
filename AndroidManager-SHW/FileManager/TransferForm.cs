using ADBProccessDLL;
using SharpAdbClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AndroidManager_SHW
{
    public partial class TransferForm : Form
    {
        string Path;
        List<ADBFile> MyFiles;
        FileManager FM;
        TransferType TransferTp;
        int CountFilesForTransfer = 0;
        double TotalLengthFiles = 0;
        int MyTime = 0;
        DeviceData Device;
        List<string> FilesAndDirecoriesForUpload;
        String PreLine_CopyCutBackup;

        public TransferForm()
        {
            InitializeComponent();
        }

        public TransferForm(TransferType tt, List<ADBFile> myfiles, string path, DeviceData device)
        {

            InitializeComponent();
            ExternalMethod.counterEx = 0;
            progressBar_transfer.Value = 0;
            Path = path;
            MyFiles = myfiles;
            FM = new FileManager(device);
            TransferTp = tt;
            progressBar_transfer.Maximum = 100;
            timer_5s.Start();
            label_totalFiles.Text = label_totalSize.Text = "•••";
            if (tt == TransferType.BackingUp)
            {
                DirectoryInfo di = new DirectoryInfo(path);
                label_transferTo.Text = "to => " + di.Name.fixDecodePatch();
            }
            else
            {
                label_transferTo.Text = "to => " + path.fixDecodePatch();
            }
            this.Text = tt.ToString();
            backgroundWorker_SetLabels.RunWorkerAsync();
        }

        public TransferForm(TransferType tt, List<string> FilesForUpload, string path, DeviceData device)
        {
            InitializeComponent();
            ExternalMethod.counterEx = 0;
            progressBar_transfer.Value = 0;
            Path = path;
            FilesAndDirecoriesForUpload = FilesForUpload;
            FM = new FileManager(device);
            TransferTp = tt;
            progressBar_transfer.Maximum = 100;
            timer_5s.Interval = 500;
            timer_5s.Start();
            label_totalFiles.Text = label_totalSize.Text = "•••";
            if (tt == TransferType.BackingUp)
            {
                DirectoryInfo di = new DirectoryInfo(path);
                label_transferTo.Text ="to => "+di.Name.DecodingText();
            }
            else
            {
                label_transferTo.Text = "to => " + path.DecodingText();
            }
            this.Text = tt.ToString();
            backgroundWorker_SetLabels.RunWorkerAsync();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {


            PreLine_CopyCutBackup = TransferTp.ToString().fixDecodePatch()+":: ";


        }

        private void backgroundWorker_transfer_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (TransferTp)
            {
                //Copy---
                case TransferType.Copying:
                    foreach (var MyFile in MyFiles)
                    {
                        FM.PasteCopy(MyFile, Path);
                    }
                    break;

                //Cut---
                case TransferType.Cutting:
                    foreach (var MyFile in MyFiles)
                    {
                        FM.PasteCut(MyFile, Path);
                    }
                    break;

                //Backup---
                case TransferType.BackingUp:
                    foreach (var MyFile in MyFiles)
                    {
                        FM.BackupToSystem(MyFile, Path);
                    }
                    break;

                //Upload---
                case TransferType.Uploading:
                    FM.UploadToAndroid(FilesAndDirecoriesForUpload, Path);
                    label_transferBase.ForeColor = Color.Blue;
                    break;

                default:
                    break;
            }
        }

        private void backgroundWorker_transfer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer_5s.Stop();
            progressBar_transfer.Value = progressBar_transfer.Maximum;


            button_cancel.Text = "OK";
            label_Status.Text = "Transfer " + progressBar_transfer.Value + " Files In " + (MyTime * timer_5s.Interval / 1000).getStringTime();

            MessageBox.Show(TransferTp.ToString() + " Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (TransferType.BackingUp == TransferTp)
            {
                System.Diagnostics.Process.Start(Path);
            }
            if (TransferTp == TransferType.Cutting)
            {
                foreach (ADBFile item in MyFiles)
                {
                    FM.DeleteDirectoryAndFiles(item.FullName);
                }
            }
        }

        private int GetCountFiles()
        {
            if (TransferTp == TransferType.BackingUp)
            {
                return Directory.GetFiles(Path).Count();
            }
            else
            {
                return FM.CountFileAndDirectory(Path.returnFile(Device));
            }
        }

        private void backgroundWorker_SetProgress_DoWork(object sender, DoWorkEventArgs e)
        {
            // CountFilesNow = GetCountFiles();
        }

        private void timer_5s_Tick(object sender, EventArgs e)
        {
            //FileTransferExternalProp = FM.FileTransfer_FileManager;
            //FileTransferExternalProp = ExternalMethod.counterEx;
            MyTime++;
            if (TransferTp == TransferType.Uploading)
            {
                label_transferBase.Text = PreLine_CopyCutBackup+" "+GetParentDirectory(FilesAndDirecoriesForUpload[0]).Replace(@"\","");
            }
            else
            {
                label_transferBase.Text = PreLine_CopyCutBackup + " " + MyFiles[0].Name.fixDecodePatch().Replace(@"\", "");
            }
            //------------------------------------------------------------------------------
            if (ExternalMethod.counterEx < progressBar_transfer.Maximum)
            {
                progressBar_transfer.Value = ExternalMethod.counterEx;
                //progressBar_transfer.Value = FM.FileAndDirectoryCounter;
            }
            label_Status.Text = "Transfer " + progressBar_transfer.Value + " Files";
        }


        private void backgroundWorker_SetLabels_DoWork(object sender, DoWorkEventArgs e)
        {
            if (TransferTp == TransferType.Uploading)
            {
                foreach (string Filetmp in FilesAndDirecoriesForUpload)
                {
                    CountFilesForTransfer += Filetmp.GetCountOfFilesAndDirectoriesInSystem();
                    TotalLengthFiles += (Filetmp.GetSizeOfFilesAndDirectoriesInSystem() / 1024);
                }
            }
            else
            {
                foreach (var Filetmp in MyFiles)
                {
                    CountFilesForTransfer += FM.CountFileAndDirectory(Filetmp);
                    TotalLengthFiles += Filetmp.GetLengthDouble();
                }
            }

        }

        private void backgroundWorker_SetLabels_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (TransferTp==TransferType.Uploading)
            {
                label_transferBase.Text = PreLine_CopyCutBackup + " " + GetParentDirectory(FilesAndDirecoriesForUpload[0]);
            }
            label_totalFiles.Text = "Total Files: " + CountFilesForTransfer.ToString();
            progressBar_transfer.Maximum = CountFilesForTransfer;
            label_totalSize.Text = "Total Size: " + TotalLengthFiles.humanReadable();
            backgroundWorker_transfer.RunWorkerAsync();
        }

        private void label_transferBase_Click(object sender, EventArgs e)
        {
            if (label_transferBase.ForeColor==Color.Blue)
            {
                System.Diagnostics.Process.Start(GetParentDirectory(FilesAndDirecoriesForUpload[0]));
            }
        }

        private string GetParentDirectory(string Address)
        {
            if (Directory.Exists(Address))
            {
                return (new DirectoryInfo(Address)).Parent.FullName;
            }
            else
            {
                return (new FileInfo(Address)).DirectoryName;
            }
        }
    }
}
