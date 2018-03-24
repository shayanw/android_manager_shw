using ADBFileProccessDLL;
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
        int CountFilesForTransfer=0;
        double TotalLengthFiles=0;
        DeviceData Device;

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
            if (tt==TransferType.BackingUp)
            {
                DirectoryInfo di = new DirectoryInfo(path);
                label_transferTo.Text = di.Name;
            }
            else
            {
                label_transferTo.Text = path;
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

                default:
                    break;
            }
        }

        private void backgroundWorker_transfer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer_5s.Stop();
            progressBar_transfer.Value = progressBar_transfer.Maximum;
            label_Status.Text = "Transfer " + progressBar_transfer.Value + " Files";
            MessageBox.Show(TransferTp.ToString()+" Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (TransferType.BackingUp==TransferTp)
            {
                System.Diagnostics.Process.Start(Path);
            }
            if (TransferTp==TransferType.Cutting)
            {
                foreach (ADBFile item in MyFiles)
                {
                    FM.DeleteDirectoryAndFiles(item.FullName);
                }
            }
            
        }

        private int GetCountFiles()
        {
            if (TransferTp==TransferType.BackingUp)
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
            label_transferBase.Text = MyFiles[0].Name;
            if (ExternalMethod.counterEx < progressBar_transfer.Maximum)
            {
                progressBar_transfer.Value = ExternalMethod.counterEx;
                //progressBar_transfer.Value = FM.FileAndDirectoryCounter;
            }
            if (!backgroundWorker_SetProgress.IsBusy)
            {
                backgroundWorker_SetProgress.RunWorkerAsync();
                // progressBar_transfer.Value = CountFilesNow - CountFilesPath;
            }
            label_Status.Text = "Transfer " + progressBar_transfer.Value + " Files";
        }


        private void backgroundWorker_SetLabels_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (var Filetmp in MyFiles)
            {
                CountFilesForTransfer += FM.CountFileAndDirectory(Filetmp);
                TotalLengthFiles=Filetmp.GetLengthDouble();
            }
            
        }

        private void backgroundWorker_SetLabels_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label_totalFiles.Text ="Total Files: "+CountFilesForTransfer.ToString();
            progressBar_transfer.Maximum = CountFilesForTransfer;
            label_totalSize.Text = "Total Size: " + TotalLengthFiles.humanReadable();
            backgroundWorker_transfer.RunWorkerAsync();
        }
    }
}
