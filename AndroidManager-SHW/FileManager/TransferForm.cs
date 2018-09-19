using ADBProccessDLL;
using SharpAdbClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
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
        List<string> FilesAndDirecoriesForUpload;
        String PreLine_CopyCutBackup;
        public bool IsChangeValue;


        public TransferForm(TransferType tt, List<ADBFile> myfiles, string path, FileManager fm)
        {

            InitializeComponent();
            IsChangeValue = false;
            ExternalMethod.CounterEx = 0;
            progressBar_transfer.Value = 0;
            Path = path;
            MyFiles = myfiles;
            FM = fm;
            TransferTp = tt;
            progressBar_transfer.Maximum = 10000;
            timer_5s.Start();
            label_totalFiles.Text = label_totalSize.Text = "•••";
            if (tt == TransferType.BackingUp)
            {
                DirectoryInfo di = new DirectoryInfo(path);
                label_transferTo.Text = "from => " + di.Name.DecodingText().Replace(@"\", "");
            }
            else
            {
                label_transferTo.Text = "to => " + path.DecodingText().Replace(@"\", "");
            }
            this.Text = tt.ToString();
            backgroundWorker_SetLabels.RunWorkerAsync();
        }

        public TransferForm(TransferType transfer_type, List<string> FilesForUpload, string path, DeviceData device)
        {
            InitializeComponent();
            ExternalMethod.CounterEx = 0;
            progressBar_transfer.Value = 0;
            Path = path;
            FilesAndDirecoriesForUpload = FilesForUpload;
            FM = new FileManager(device);
            TransferTp = transfer_type;
            progressBar_transfer.Maximum = 10000;
            timer_5s.Interval = 500;
            timer_5s.Start();
            label_totalFiles.Text = label_totalSize.Text = "•••";
            if (transfer_type == TransferType.BackingUp)
            {
                DirectoryInfo di = new DirectoryInfo(path);
                label_transferTo.Text ="From => "+di.Name.DecodingText().Replace(@"\", "");
            }
            else
            {
                label_transferTo.Text = "to => " + path.DecodingText().Replace(@"\", "");
            }
            this.Text = transfer_type.ToString();
            backgroundWorker_SetLabels.RunWorkerAsync();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {

            PreLine_CopyCutBackup = TransferTp.ToString().DecodingText()+":: ";

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
            label_Status.Text = "Transfer " + ExternalMethod.CounterEx + " Files In " + (MyTime * timer_5s.Interval / 1000).getStringTime();
            label_percent.Text ="100 %";
            MessageBox.Show(TransferTp.ToString() + " Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IsChangeValue = true;
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
                return FM.CountFileAndDirectory(Path.returnFile(FM.CurrentDevice));
            }
        }


        private void timer_5s_Tick(object sender, EventArgs e)
        {
            MyTime++;
            if (TransferTp == TransferType.Uploading)
            {
                label_transferBase.Text = PreLine_CopyCutBackup+" "+GetParentDirectory(FilesAndDirecoriesForUpload[0]).Replace(@"\","");
            }
            else
            {
                label_transferBase.Text = PreLine_CopyCutBackup + " " + MyFiles[0].Name.DecodingText().Replace(@"\", "");
            }
            //------------------------------------------------------------------------------
            if ((ExternalMethod.CounterEx-1)*100 < progressBar_transfer.Maximum)
            {
                if ((ExternalMethod.CounterEx - 1) * 100 == progressBar_transfer.Value- progressBar_transfer.Value%100)
                {
                    int tmpProgressInt = progressBar_transfer.Value % 100;
                    if (tmpProgressInt < 99 && MyTime%2==0)
                    {
                        if (progressBar_transfer.Value!=progressBar_transfer.Maximum)
                        {
                            if (tmpProgressInt<15)
                            {
                                progressBar_transfer.Value += 3;
                            }
                            else if (tmpProgressInt < 50)
                            {
                                progressBar_transfer.Value += 1;
                            }
                            else if (tmpProgressInt < 60)
                            {
                                progressBar_transfer.Value += 3;
                            }
                            else if (tmpProgressInt < 75)
                            {
                                progressBar_transfer.Value += 1;
                            }
                            else if (tmpProgressInt < 90)
                            {
                                progressBar_transfer.Value += 2;
                            }
                            else if (tmpProgressInt < 99)
                            {
                                progressBar_transfer.Value += 1;
                            }

                        }
                    }
                }
                else
                {
                    progressBar_transfer.Value = ExternalMethod.CounterEx * 100;
                }
                
            }
            label_Status.Text = "Transfer " + ExternalMethod.CounterEx + " Files";
            float pr = float.Parse(progressBar_transfer.Value.ToString())/ float.Parse(progressBar_transfer.Maximum.ToString());
            label_percent.Text = (pr*100).ToString("0")+ " %";
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
            progressBar_transfer.Maximum = CountFilesForTransfer*100+1;
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
