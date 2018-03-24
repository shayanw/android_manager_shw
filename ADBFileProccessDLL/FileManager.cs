using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpAdbClient;
using System.IO;
using System.Threading;
using System.Net;


namespace ADBFileProccessDLL
{
    public class FileManager
    {
        DeviceData dv;
        public int FileAndDirectoryCounter = 0;
        public FileManager(DeviceData currentDevice)
        {
            dv = currentDevice;
        }
        public List<ADBFile> getDirectoryAndFiles(string CurrentPath)
        {
            List<ADBFile> DirectoryAndFiles = new List<ADBFile>();
            ADBFile myfile = new ADBFile(dv);
            myfile.FullName = CurrentPath;
            myfile.Tag = "d";
            foreach (var item in myfile.GetChildFiles())
            {
                DirectoryAndFiles.Add(item);
            }
            return DirectoryAndFiles;
        }

        public List<ADBFile> getDirectoryAndFiles(ADBFile currentFile)
        {
            List<ADBFile> DirectoryAndFiles = new List<ADBFile>();
            foreach (var item in currentFile.GetChildFiles())
            {
                DirectoryAndFiles.Add(item);
            }
            return DirectoryAndFiles;
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
            //ExternalMethod.counterEx++;
            //if (myfile.isDirectory())
            //{
            //    if (resultCommand(string.Format(@"cp -r {0} {1}", myfile.FullName, path)).Count() == 0)
            //    {
            //        return true;
            //    }
            //    return false;
            //}
            //else
            //{
            //    if (resultCommand(string.Format(@"cp {0} {1}", myfile.FullName, path)).Count() == 0)
            //    {
            //        return true;
            //    }
            //    return false;
            //}
            //FileAndDirectoryCounter++;
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
                rslt= true;
            }
            else
            {
                if (resultCommand(string.Format(@"mv {0} {1}", myfile.FullName.fixBracketInTerminal(), path)).Count() == 0)
                {
                    rslt= true;
                }
                rslt= false;
            }
            return rslt;
        }
        public bool BackupToSystem(ADBFile myfile, string BackupPath)
        {
            ExternalMethod.counterEx++;
            //FileAndDirectoryCounter++;
            if (myfile.isDirectory())
            {
                Directory.CreateDirectory(BackupPath+@"\"+ myfile.Name.nickName());
                foreach (ADBFile onefile in myfile.GetChildFiles())
                {
                    BackupToSystem(onefile, BackupPath + @"\" + myfile.Name.nickName());
                }
                return true;
            }
            else
            {
                using (SyncService service = new SyncService(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)), dv))
                using (Stream stream = System.IO.File.OpenWrite(BackupPath + @"\" + myfile.FullName.returnFile(dv).Name.Replace(@"\", string.Empty)))
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



        public bool CreateDirectory(string BaseDirectory,string NameNewDir)
        {
            if (resultCommand("mkdir "+BaseDirectory+"/"+NameNewDir).Count()==0)
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

        public string MainPathSystem(string address)
        {
            string name=dv.Model+"_"+dv.Name + "_AndroidManagerSHW";
            //try
            //{
                if (!Directory.Exists(address + "\\" + "AndroidManagerSHW"))
                {
                    Directory.CreateDirectory(address + "\\" + "AndroidManagerSHW");
                }
                if (!Directory.Exists(address + "\\" + "AndroidManagerSHW"+"\\" + name))
                {
                    Directory.CreateDirectory(address + "\\" + "AndroidManagerSHW" + "\\" + name);
                }
                return address + "\\" + "AndroidManagerSHW" + "\\" + name;
            //}
            //catch (Exception)
            //{

            //    return false;
            //}
            
        }

        public int CountFileAndDirectory(ADBFile myFile)
        {
            int countFiles = 0;
            countFiles += myFile.GetChildFiles().Count();
            foreach (ADBFile onefileordir in myFile.GetChildFiles())
            {
                if (onefileordir.Tag=="d")
                {
                    countFiles += CountFileAndDirectory(onefileordir);
                }
            }
            return countFiles;
        }

    
    }
    public enum TransferType
    {
           Copying,Cutting,BackingUp
    }
}
