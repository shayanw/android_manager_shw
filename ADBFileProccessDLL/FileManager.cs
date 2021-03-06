﻿using System;
using System.Collections.Generic;
using System.Linq;
using SharpAdbClient;
using System.IO;
using System.Threading;
using System.Net;


namespace ADBProccessDLL
{
    public class FileManager
    {
        #region filed and prop
        public DeviceData CurrentDevice;
        public int FileAndDirectoryCounter = 0;
        public List<ADBFile> ListAdbFiles;
        //address directory backup tush hast
        public ADBProccessDLL.Option option;
        #endregion

        #region Constructor
        public FileManager(DeviceData currentDevice)
        {
            CurrentDevice = currentDevice;
            option = new Option(currentDevice);
            ListAdbFiles = new List<ADBFile>();
        }
        #endregion

        #region proccess on File

        public bool DeleteDirectoryAndFiles(string FileFullName)
        {
            if (resultCommand("rm -r " + FileFullName.FixForbidCharInTerminal()).Count() == 0)
            {
                return true;
            }
            return false;
        }

        public bool PasteCopy(ADBFile myfile, string path)
        {
            ExternalMethod.CounterEx++;
            bool rslt = false;
            if (myfile.GetTag()=='d')
            {
                CreateDirectory(path, myfile.Name.FixForbidCharInTerminal());
                foreach (ADBFile onefile in myfile.GetSubFiles())
                {
                    if (PasteCopy(onefile, path + "/" + myfile.Name.FixForbidCharInTerminal()))
                    {
                        rslt = true;
                    }
                    else
                    {
                        rslt = false;
                    }
                }
                
            }
            else
            {
                if (resultCommand(string.Format(@"cp {0} {1}", myfile.FullName.FixForbidCharInTerminal(), path)).Count() == 0)
                {
                    rslt = true;
                }
                else
                {
                    rslt = false;
                }
            }
            return rslt;

        }
        public bool PasteCut(ADBFile myfile, string path)
        {
            //FileAndDirectoryCounter++;
            ExternalMethod.CounterEx++;
            bool rslt = false;
            if (myfile.GetTag()=='d')
            {
                CreateDirectory(path, myfile.Name.FixForbidCharInTerminal());
                foreach (ADBFile onefile in myfile.GetSubFiles())
                {
                    PasteCut(onefile, path + "/" + myfile.Name.FixForbidCharInTerminal());

                }
                rslt = true;
            }
            else
            {
                if (resultCommand(string.Format(@"mv {0} {1}", myfile.FullName.FixForbidCharInTerminal(), path)).Count() == 0)
                {
                    rslt = true;
                }
                rslt = false;
            }
            return rslt;
        }

        public bool BackupToSystem(ADBFile myfile, string BackupPath)
        {
            ExternalMethod.CounterEx++;
            if (myfile.GetTag()=='d')
            {
                Directory.CreateDirectory(BackupPath + @"\" + myfile.Name.nickName().DecodingText());
                foreach (ADBFile onefile in myfile.GetSubFiles())
                {
                    BackupToSystem(onefile,BackupPath + @"\" + myfile.Name.nickName().DecodingText());
                }
                return true;
            }
            else
            {
                string fullnamebackup =BackupPath + @"\" + myfile.FullName.returnFile(CurrentDevice).Name.Replace(@"\", string.Empty).DecodingText();
                if (File.Exists(fullnamebackup))
                {
                    return true;
                }
                using (SyncService service = new SyncService(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)), CurrentDevice))
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
                ExternalMethod.CounterEx++;
                //age [AddressFileOrDir] Directory bud yedune besaz
                if (Directory.Exists(AddressFileOrDir))
                {
                    List<string> tmpLiFD = new List<string>();
                    DirectoryInfo di = new DirectoryInfo(AddressFileOrDir);
                    //be hamun esm ye directory besaz

                    CreateDirectory(AndroidPath.FixForbidCharInTerminal().EncodingText(), di.Name.FixForbidCharInTerminal().EncodingText());

                    //list directory ha va file haro be [tmpLifD] ezaf kon
                    tmpLiFD.AddRange(di.GetDirectories().Select(a => a.FullName));
                    tmpLiFD.AddRange(di.GetFiles().Select(a => a.FullName));

                    UploadToAndroid(tmpLiFD, (AndroidPath+ "/" + di.Name));
                }
            
                //age [AddressFileOrDir] File bud => file ro push kon
                else
                {
                    FileInfo fi = new FileInfo(AddressFileOrDir);
                    if (!ListAdbFiles.Any(a=>a.Name==fi.Name))
                    {
                        using (SyncService service = new SyncService(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)), CurrentDevice))
                        using (Stream stream = File.OpenRead(fi.FullName))
                        {
                            try
                            {
                                service.Push(stream, AndroidPath.EncodingText().Replace("\\", "") + "/" + fi.Name.EncodingText(), 444, DateTime.Now, null, CancellationToken.None);
                            }
                            catch
                            {
                                //service.Push(stream, AndroidPath.Replace("\\", "").EncodingText() + "/" + fi.Name.EncodingText(), 444, DateTime.Now, null, CancellationToken.None);
                                return false;
                            }

                        }
                    }

                }

            }
            return true;
        }

        public bool CreateDirectory(string BaseDirectory, string NameNewDir)
        {
            if (ListAdbFiles.Any(a=>a.Name==NameNewDir))
            {
                return true;
            }
            else if (resultCommand("mkdir " + BaseDirectory + "/" + NameNewDir).Count() == 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Get More Details File
        public int CountFileAndDirectory(ADBFile myFile)
        {
            myFile.GetCountSubFiles();
            return myFile.SubFilesNumber;
        }
        public List<ADBFile> getDirectoryAndFiles(string CurrentPath)
        {
            ListAdbFiles = new ADBFile(CurrentDevice) { FullName = CurrentPath }.GetSubFiles();
            return ListAdbFiles;
        }
        #endregion

        #region base method
        private string resultCommand(string Command)
        {
            var receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand(Command, CurrentDevice, receiver);
            return receiver.ToString();
        }
        #endregion
    }
    public enum TransferType
    {
        Copying, Cutting, BackingUp, Uploading
    }
}
