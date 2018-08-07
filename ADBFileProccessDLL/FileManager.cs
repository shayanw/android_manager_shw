using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpAdbClient;
using System.IO;
using System.Threading;
using System.Net;
using System.Drawing;

namespace ADBProccessDLL
{
    public class FileManager
    {
        DeviceData dv;
        public int FileAndDirectoryCounter = 0;
        public List<ADBFile> ListAdbFiles;

        //address directory backup tush hast
        public ADBProccessDLL.Option option;
        public FileManager(DeviceData currentDevice)
        {
            dv = currentDevice;
            option = new Option(currentDevice);
        }

        //zire file and directory ro dar ghalebe [List<ADBFile>] bar migardune
        public List<ADBFile> getDirectoryAndFiles(string CurrentPath)
        {
            //if (backgroundWorker_ProccessSize.IsBusy)
            //{
            //    backgroundWorker_ProccessSize.CancelAsync();
            //}
            //if (!backgroundWorker_ProccessSize.IsBusy)
            //{
            //    backgroundWorker_ProccessSize.RunWorkerAsync();


            //List<ADBFile> DirectoryAndFiles = new List<ADBFile>();

            //ADBFile myfile = new ADBFile(dv);
            //myfile.FullName = CurrentPath;
            //myfile.Tag = "d";

            //foreach (var item in myfile.GetChildFiles())
            //{
            //    DirectoryAndFiles.Add(item);
            //}
            //return DirectoryAndFiles;
            ListAdbFiles = new ADBFile(dv) { FullName = CurrentPath }.SubFiles();
            return ListAdbFiles ;
        }

        public bool DeleteDirectoryAndFiles(string FileFullName)
        {
            if (resultCommand("rm -r " + FileFullName.fixBracketInTerminal()).Count() == 0)
            {
                return true;
            }
            return false;

        }



        public bool PasteCopy(ADBFile myfile, string path)
        {
            ExternalMethod.counterEx++;
            bool rslt = false;
            if (myfile.isDirectory())
            {
                CreateDirectory(path, myfile.Name.fixBracketInTerminal());
                foreach (ADBFile onefile in myfile.GetChildFiles())
                {
                    PasteCopy(onefile, path + "/" + myfile.Name.fixBracketInTerminal());

                }
                rslt = true;
            }
            else
            {
                if (resultCommand(string.Format(@"cp {0} {1}", myfile.FullName.fixBracketInTerminal(), path)).Count() == 0)
                {
                    rslt = true;
                }
                rslt = false;
            }
            return rslt;

        }
        public bool PasteCut(ADBFile myfile, string path)
        {
            //FileAndDirectoryCounter++;
            ExternalMethod.counterEx++;
            bool rslt = false;
            if (myfile.isDirectory())
            {
                CreateDirectory(path, myfile.Name.fixBracketInTerminal());
                foreach (ADBFile onefile in myfile.GetChildFiles())
                {
                    PasteCut(onefile, path + "/" + myfile.Name.fixBracketInTerminal());

                }
                rslt = true;
            }
            else
            {
                if (resultCommand(string.Format(@"mv {0} {1}", myfile.FullName.fixBracketInTerminal(), path)).Count() == 0)
                {
                    rslt = true;
                }
                rslt = false;
            }
            return rslt;
        }

        public bool BackupToSystem(ADBFile myfile, string BackupPath)
        {
            ExternalMethod.counterEx++;
            //FileAndDirectoryCounter++;
            if (myfile.isDirectory())
            {
                Directory.CreateDirectory(/*option.MainPathBackupProp*/BackupPath + @"\" + myfile.Name.nickName().DecodingText());
                foreach (ADBFile onefile in myfile.GetChildFiles())
                {
                    BackupToSystem(onefile, /*option.MainPathBackupProp */BackupPath + @"\" + myfile.Name.nickName().DecodingText());
                }
                return true;
            }
            else
            {
                string fullnamebackup = /*option.MainPathBackupProp*/BackupPath + @"\" + myfile.FullName.returnFile(dv).Name.Replace(@"\", string.Empty).DecodingText();
                if (File.Exists(fullnamebackup))
                {
                    return true;
                }
                using (SyncService service = new SyncService(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)), dv))
                using (Stream stream = System.IO.File.OpenWrite(fullnamebackup))
                {
                    try
                    {
                        service.Pull(myfile.FullName.Replace(@"\", string.Empty), stream, null, CancellationToken.None);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }


        }
        public bool UploadToAndroid(FileInfo FileForUpload, string AndroidPath)
        {
            using (SyncService service = new SyncService(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)), dv))
            using (Stream stream = File.OpenRead(FileForUpload.FullName))
            {
                service.Push(stream, AndroidPath + "/" + FileForUpload.Name, 444, DateTime.Now, null, CancellationToken.None);
            }
            return true;
        }


        //Upload file And Directory (Support Unicode Character)
        public bool UploadToAndroid(List<string> FilesAndDirectory, string AndroidPath)
        {
            string tmp = AndroidPath.DecodingText();
            if (!tmp.Contains("?"))
            {
                AndroidPath = tmp;
            }
            foreach (string AddressFileOrDir in FilesAndDirectory)
            {
                ExternalMethod.counterEx++;
                //age [AddressFileOrDir] Directory bud yedune besaz
                if (Directory.Exists(AddressFileOrDir))
                {
                    List<string> tmpLiFD = new List<string>();
                    DirectoryInfo di = new DirectoryInfo(AddressFileOrDir);
                    //be hamun esm ye directory besaz

                    CreateDirectory(AndroidPath.fixBracketInTerminal().EncodingText(), di.Name.fixBracketInTerminal().EncodingText());

                    //list directory ha va file haro be [tmpLifD] ezaf kon
                    tmpLiFD.AddRange(di.GetDirectories().Select(a => a.FullName));
                    tmpLiFD.AddRange(di.GetFiles().Select(a => a.FullName));

                    UploadToAndroid(tmpLiFD, (AndroidPath+ "/" + di.Name));
                }
            
                //age [AddressFileOrDir] File bud => file ro push kon
                else
                {
                    FileInfo fi = new FileInfo(AddressFileOrDir);
                    using (SyncService service = new SyncService(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)), dv))
                    using (Stream stream = File.OpenRead(fi.FullName))
                    {
                        try
                        {
                            service.Push(stream, AndroidPath.EncodingText().Replace("\\", "") + "/" + fi.Name.EncodingText(), 444, DateTime.Now, null, CancellationToken.None);
                        }
                        catch
                        {
                            service.Push(stream, AndroidPath.Replace("\\", "").EncodingText() + "/" + fi.Name.EncodingText(), 444, DateTime.Now, null, CancellationToken.None);
                        }

                    }
                }

            }
            return true;
        }
        public bool UploadToAndroid(string FileOrDirectory, string AndroidPath)
        {
            ExternalMethod.counterEx++;
            if (Directory.Exists(FileOrDirectory))
            {
                //CreateDirectory(path, myfile.Name.fixBracketInTerminal());
                DirectoryInfo di = new DirectoryInfo(FileOrDirectory);
                CreateDirectory(AndroidPath.fixBracketInTerminal().EncodingText(), di.Name.fixBracketInTerminal());

                foreach (FileInfo item in di.GetFiles())
                {
                    UploadToAndroid(item.FullName, AndroidPath + "/" + di.Name);
                }
                foreach (DirectoryInfo item in di.GetDirectories())
                {
                    UploadToAndroid(item.FullName, AndroidPath + "/" + di.Name);
                }
            }

            else
            {
                FileInfo fi = new FileInfo(FileOrDirectory);
                using (SyncService service = new SyncService(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)), dv))
                using (Stream stream = File.OpenRead(fi.FullName))
                {
                    service.Push(stream, AndroidPath.Replace("\\", "").EncodingText() + "/" + fi.Name, 444, DateTime.Now, null, CancellationToken.None);
                }
            }
            return true;
        }

        public bool CreateDirectory(string BaseDirectory, string NameNewDir)
        {
            if (resultCommand("mkdir " + BaseDirectory + "/" + NameNewDir).Count() == 0)
            {
                return true;
            }
            return false;
        }
        private string resultCommand(string Command)
        {
            var receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand(Command, dv, receiver);
            return receiver.ToString();
        }

        //public string MainPathSystem(string address)
        //{
        //    string name=dv.Model+"_"+dv.Name + "_AndroidManagerSHW";
        //    //try
        //    //{
        //        if (!Directory.Exists(address + "\\" + "AndroidManagerSHW"))
        //        {
        //            Directory.CreateDirectory(address + "\\" + "AndroidManagerSHW");
        //        }
        //        if (!Directory.Exists(address + "\\" + "AndroidManagerSHW"+"\\" + name))
        //        {
        //            Directory.CreateDirectory(address + "\\" + "AndroidManagerSHW" + "\\" + name);
        //        }
        //        return address + "\\" + "AndroidManagerSHW" + "\\" + name;
        //    //}
        //    //catch (Exception)
        //    //{

        //    //    return false;
        //    //}

        //}

        public int CountFileAndDirectory(ADBFile myFile)
        {
            int countFiles = 1;
            countFiles += myFile.GetChildFiles().Count();
            foreach (ADBFile onefileordir in myFile.GetChildFiles())
            {
                if (onefileordir.Tag == "d")
                {
                    countFiles += CountFileAndDirectory(onefileordir);
                }
            }
            return countFiles;
        }


    }
    public enum TransferType
    {
        Copying, Cutting, BackingUp, Uploading
    }
}
