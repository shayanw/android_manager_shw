using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpAdbClient;
using System.IO;
using System.Net;
using System.Threading;

namespace ADBProccessDLL
{
    public class ApkManager
    {
        DeviceData Device;
        Option option;
        public ApkManager(DeviceData device)
        {
            Device = device;
            option = new Option(device);
        }

        public bool InstallApk(string AddressApk, bool IsOnInternalMemory = true, bool IsReInstall = true)
        {

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = @"adb install " + AddressApk;
            //System.Environment.SpecialFolder.CommonProgramFilesX86
            string preCode = @"-s " + Device.Serial + " ";
            process.StartInfo.FileName = @".\platform-tools\adb.exe";
            if (IsOnInternalMemory && IsReInstall)
            {
                process.StartInfo.Arguments = @"install -r "+"\""+ AddressApk + "\"";
            }
            else if (!IsOnInternalMemory && IsReInstall)
            {
                process.StartInfo.Arguments = @"install -sr " + "\"" + AddressApk + "\"";
            }
            else if (IsOnInternalMemory && !IsReInstall)
            {
                process.StartInfo.Arguments = @"install  " + "\"" + AddressApk + "\"";
            }
            else
            {
                process.StartInfo.Arguments = @"install -s " + "\"" + AddressApk + "\"";
            }
            process.StartInfo.Arguments = preCode+process.StartInfo.Arguments ;

            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            //process.StartInfo.WorkingDirectory = @"C:\Windows\System32";
            process.Start();
            string outputcmd = process.StandardOutput.ReadToEnd();
            if (outputcmd.Contains("Success"))
            {
                return true;
            }
            else
            {
                return false;
            }
            
            ////return true;
            //try
            //{
            //    FileManager fm = new FileManager(Device);
            //    fm.UploadToAndroid(new FileInfo(AddressApk), "/data/local/tmp");
            //    //SharpAdbClient.DeviceCommands.PackageManager pm = new SharpAdbClient.DeviceCommands.PackageManager(Device);
            //    //pm.InstallPackage(AddressApk,reinstall:true);

            //    //Stream sr = new FileStream(AddressApk, FileMode.Open);
            //    //AdbClient.Instance.Install(Device, sr);
            //    return true;
            //}
            //catch (Exception)
            //{

            //    return false;
            //}
            //return true;
        }
        
        public bool UnistallApk(string PackageName)
        {
            try
            {
                SharpAdbClient.DeviceCommands.PackageManager pm = new SharpAdbClient.DeviceCommands.PackageManager(Device);
                pm.UninstallPackage(PackageName);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool BackupApk(string PackageFullName,string version="0V",string packageName="oneApp.apk")
        {
            string fullnamebackup = option.intoApkBackupDirectory() + @"\" + apkVersion(packageName, version);
            if (File.Exists(fullnamebackup))
            {
                return true;
            }
            using (SyncService service = new SyncService(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)), Device))
            using (Stream stream = System.IO.File.OpenWrite(fullnamebackup))
            {
                try
                {
                    service.Pull(PackageFullName, stream, null, CancellationToken.None);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public int ExistBackup(string version = "0V", string packageName = "oneApp.apk")
        {
            string fullnamebackup = option.intoApkBackupDirectory() + @"\" + apkVersion(packageName, version);
            packageName = packageName.Replace(".apk", string.Empty);
            if (File.Exists(fullnamebackup))
            {
                return 0;
            }
            else if (Directory.GetFiles(option.intoApkBackupDirectory(), "*"+packageName+"*").Count()>0)
            {
                return 1; 
            }
            else
            {
                return 2;
            }

            


        }


        private string apkVersion(string apk,string version)
        {
            apk=apk.ToLower();
            return apk.Replace(".apk",string.Empty)+"_"+version+".apk";
        }
    }
}
