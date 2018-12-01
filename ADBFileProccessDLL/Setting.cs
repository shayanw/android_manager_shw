using System;
using System.IO;

namespace ADBProccessDLL
{
    [Serializable]
    public class Setting
    {
        public string backupPath;
        public string updatePackagePath;
        public string platformToolsPath;
        public bool isKeepLatestApk;
        public bool isShowSizeFM;
        public bool isShowHiddenFile;
        public bool isPMTheme1;
        public Setting()
        {
            try
            {
                string tmp;
                StreamReader sr = new StreamReader(returnPathSetting() + @"\sett.shw");
                while (sr.Peek() > 0)
                {
                    tmp = sr.ReadLine();

                    if (tmp.Contains("backupPath:"))
                    {
                        backupPath = tmp.Replace("backupPath:", "");

                        if (string.IsNullOrEmpty(backupPath))
                        {
                            backupPath = Option.MainPath;
                        }
                        else
                        {
                            Option.MainPath = backupPath;
                        }
                    }
                    else if (tmp.Contains("platformToolsPath:"))
                    {
                        platformToolsPath = tmp.Replace("platformToolsPath:", "");

                        if (string.IsNullOrEmpty(platformToolsPath))
                        {
                            platformToolsPath = Option.PlatformToolsPath;
                        }
                        else
                        {
                            Option.PlatformToolsPath = platformToolsPath;
                        }
                    }
                    else if (tmp.Contains("updatePackagePath:"))
                    {
                        updatePackagePath = tmp.Replace("updatePackagePath:", "");
                    }
                    else if (tmp.Contains("isShowSizeFM:"))
                    {
                        isShowSizeFM = Convert.ToBoolean(tmp.Replace("isShowSizeFM:", ""));

                        if (string.IsNullOrEmpty(isShowSizeFM.ToString()))
                        {
                            isShowSizeFM = Option.IsShowSizeFM;
                        }
                        else
                        {
                            Option.IsShowSizeFM = isShowSizeFM;
                        }
                    }
                    else if (tmp.Contains("isShowHiddenFile:"))
                    {
                        isShowHiddenFile = Convert.ToBoolean(tmp.Replace("isShowHiddenFile:", ""));

                        if (string.IsNullOrEmpty(isShowHiddenFile.ToString()))
                        {
                            isShowHiddenFile = Option.IsShowHiddenFile;
                        }
                        else
                        {
                            Option.IsShowHiddenFile = isShowHiddenFile;
                        }
                    }
                    else if (tmp.Contains("isKeepLatestApk:"))
                    {
                        isKeepLatestApk = Convert.ToBoolean(tmp.Replace("isKeepLatestApk:", ""));

                        if (string.IsNullOrEmpty(isKeepLatestApk.ToString()))
                        {
                            isKeepLatestApk = Option.IsKeepLatestApk;
                        }
                        else
                        {
                            Option.IsKeepLatestApk = isKeepLatestApk;
                        }
                    }
                    else if (tmp.Contains("isPMTheme1:"))
                    {
                        isPMTheme1 = Convert.ToBoolean(tmp.Replace("isPMTheme1:", ""));

                        if (string.IsNullOrEmpty(isPMTheme1.ToString()))
                        {
                            isPMTheme1 = Option.IsPMTheme1;
                        }
                        else
                        {
                            Option.IsPMTheme1 = isPMTheme1;
                        }
                    }

                }
                sr.Close();
            }
            catch
            {
                backupPath = Option.MainPath;
                platformToolsPath = Option.PlatformToolsPath;
                isShowSizeFM = Option.IsShowSizeFM;
                isShowHiddenFile = Option.IsShowHiddenFile;
                isKeepLatestApk = Option.IsKeepLatestApk;
                isPMTheme1 = Option.IsPMTheme1;
            }
        }



        public bool changeBackupPath(string DirectoryAddress)
        {
            if (Directory.Exists(DirectoryAddress))
            {
                try
                {
                    Directory.CreateDirectory(DirectoryAddress + "\\test");
                    Directory.Delete(DirectoryAddress + "\\test");

                    backupPath = DirectoryAddress;
                    return true;
                }
                catch
                { }
            }
            return false;
        }

        public bool changePlatformToolsPath(string DirectoryAddress)
        {
            if (Directory.Exists(DirectoryAddress))
            {
                try
                {
                    Directory.CreateDirectory(DirectoryAddress + "\\test");
                    Directory.Delete(DirectoryAddress + "\\test");

                    
                    if (File.Exists(DirectoryAddress + "\\adb.exe"))
                    {
                        platformToolsPath = DirectoryAddress;
                        return true;
                    }
                    
                }
                catch
                { }
            }
            return false;
        }

        public bool changeUpdatePackagePath(string DirectoryAddress)
        {
            if (Directory.Exists(DirectoryAddress))
            {
                try
                {
                    Directory.CreateDirectory(DirectoryAddress + "\\test");
                    Directory.Delete(DirectoryAddress + "\\test");

                    updatePackagePath = DirectoryAddress;
                    return true;
                }
                catch
                { }
            }
            return false;
        }


        public void saveChanged()
        {
            Option.MainPath = backupPath;

            StreamWriter sw = new StreamWriter(returnPathSetting() + @"\sett.shw");

            Option.MainPath = backupPath;
            sw.WriteLine("backupPath:" + backupPath);

            Option.PlatformToolsPath = platformToolsPath;
            sw.WriteLine("platformToolsPath:" + platformToolsPath);

            sw.WriteLine("updatePackagePath:" + updatePackagePath);

            Option.IsShowSizeFM = isShowSizeFM;
            sw.WriteLine("isShowSizeFM:" + isShowSizeFM);

            Option.IsShowHiddenFile = isShowHiddenFile;
            sw.WriteLine("isShowHiddenFile:" + isShowHiddenFile);

            Option.IsKeepLatestApk = isKeepLatestApk;
            sw.WriteLine("isKeepLatestApk:" + isKeepLatestApk);

            Option.IsPMTheme1 = isPMTheme1;
            sw.WriteLine("isPMTheme1:" + isPMTheme1);

            sw.Close();
        }

        public string returnPathSetting()
        {
            string main = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (!Directory.Exists(main + "\\" + Option.MainLabelDirectoryName))
            {
                Directory.CreateDirectory(main + "\\" + Option.MainLabelDirectoryName);
            }
            return main + "\\" + Option.MainLabelDirectoryName;
        }
    }
}
