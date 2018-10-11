using System;
using System.Linq;
using SharpAdbClient;
using System.IO;
using System.Net;
using System.Threading;
using System.Collections.Generic;

namespace ADBProccessDLL
{
    public class ApkManager
    {
        #region Filed and Prop
        DeviceData Device;
        Option option;
        #endregion

        #region Constructor
        public ApkManager(DeviceData device)
        {
            Device = device;
            option = new Option(device);
        }
        #endregion

        #region Proccess on Package Apk
        public bool InstallApk(string AddressApk, bool IsOnInternalMemory = true, bool IsReInstall = true)
        {

            System.Diagnostics.Process process = new System.Diagnostics.Process();

            string preCode = @"-s " + Device.Serial + " ";
            process.StartInfo.FileName = Option.PlatformToolsPath;
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
        #endregion

        #region extra method
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


        #endregion
    }
}
