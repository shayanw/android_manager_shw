using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpAdbClient;
namespace ADBProccessDLL
{
    public class Option
    {
        DeviceData currentDevice;
        public Option(DeviceData CurrentDevice)
        {
            currentDevice = CurrentDevice;
        }

        static public string MainPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        static public string MainLabelDirectoryName = "Android Manager SHW";
        static public string DirNameBackupApk = "ApkBackups_" + "SHW";
        static public string FullAddressBackupApk = "";
        static public string DeviceDirectoryName;
        static public string PlatformToolsPath = @".\platform-tools\adb.exe";
        static private string IconPath = MainPath + "\\" + MainLabelDirectoryName + "\\Icons";
        public static string IconPathProp
        {
            get
            {
                if (!Directory.Exists(IconPath))
                {
                    Directory.CreateDirectory(IconPath);
                }
                return IconPath;
            }
        }
        static public bool IsShowSizeFM = true;
        static public bool IsShowHiddenFile = false;
        static public bool IsKeepLatestApk = false;
        static public bool IsPMTheme1 = false;
        static public DeviceData currentDeviceStatic=null;


        /// <summary>
        /// make and return main path for backup
        /// </summary>
        public string MainPathBackupProp
        {
            get
            {
                //Set Directory Name
                string name;
                if (string.IsNullOrEmpty(DeviceDirectoryName) || !DeviceDirectoryName.Contains(currentDevice.Serial))
                {
                    if (!currentDevice.Serial.Contains(":"))
                    {
                        name = currentDevice.Model + "_" + currentDevice.Name + "[" + currentDevice.Serial + "]";
                    }
                    else
                    {
                        name = currentDevice.Model + "_" + currentDevice.Name + "[" + currentDevice.Serial.Replace(":", "_") + "]";
                    }
                    DeviceDirectoryName = name;
                }
                else
                {
                    name = DeviceDirectoryName;
                }

                //if (!Directory.Exists(MainPath + "\\" + MainLabelDirectoryName))
                //{
                //    Directory.CreateDirectory(MainPath + "\\" + MainLabelDirectoryName);
                //}
                //if (!Directory.Exists(MainPath + "\\" + MainLabelDirectoryName + "\\" + name))
                //{
                //    Directory.CreateDirectory(MainPath + "\\" + MainLabelDirectoryName + "\\" + name);
                //}
                string mainPathBackupFullName = MainPath + "\\" + MainLabelDirectoryName + "\\" + name;
                if (!Directory.Exists(mainPathBackupFullName))
                {
                    Directory.CreateDirectory(mainPathBackupFullName);
                }
                return mainPathBackupFullName;
            }
            set
            {
                if (Directory.Exists(value))
                {
                    MainPath = value;
                }
            }
        }
        public string IntoApkBackupDirectory()
        {
            //Set Directory Name
            string name;
            if (string.IsNullOrEmpty(DeviceDirectoryName) || !DeviceDirectoryName.Contains(currentDevice.Serial))
            {
                name = currentDevice.Model + "_" + currentDevice.Name + "[" + currentDevice.Serial.Replace(":", "_") + "]";
                DeviceDirectoryName = name;
            }
            else
            {
                name = DeviceDirectoryName;
            }


            //if (!Directory.Exists(MainPath + "\\" + MainLabelDirectoryName))
            //{
            //    Directory.CreateDirectory(MainPath + "\\" + MainLabelDirectoryName);
            //}
            //if (!Directory.Exists(MainPath + "\\" + MainLabelDirectoryName + "\\" + name))
            //{
            //    Directory.CreateDirectory(MainPath + "\\" + MainLabelDirectoryName + "\\" + name);
            //}
            //if (!Directory.Exists(MainPath + "\\" + MainLabelDirectoryName + "\\" + name + "\\" + DirNameBackupApk))
            //{
            //    Directory.CreateDirectory(MainPath + "\\" + MainLabelDirectoryName + "\\" + name + "\\" + DirNameBackupApk);
            //}
            FullAddressBackupApk = MainPath + "\\" + MainLabelDirectoryName + "\\" + name + "\\" + DirNameBackupApk;
            if (!Directory.Exists(FullAddressBackupApk))
            {
                Directory.CreateDirectory(FullAddressBackupApk);
            }
            return FullAddressBackupApk;
        }

    }
}
