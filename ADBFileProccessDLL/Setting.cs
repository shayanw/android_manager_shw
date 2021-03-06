﻿using System;
using System.IO;

namespace ADBProccessDLL
{
    [Serializable]
    public class Setting
    {
        public string backupPath;
        public string updatePackagePath;
        public bool isKeepLatestApk;
        public bool isShowSizeFM;
        public bool isShowHiddenFile;
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

                }
                sr.Close();
            }
            catch
            {
                backupPath = Option.MainPath;
                isShowSizeFM = Option.IsShowSizeFM;
                isShowHiddenFile = Option.IsShowHiddenFile;
                isKeepLatestApk = Option.IsKeepLatestApk;
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


            sw.WriteLine("updatePackagePath:" + updatePackagePath);

            Option.IsShowSizeFM = isShowSizeFM;
            sw.WriteLine("isShowSizeFM:" + isShowSizeFM);

            Option.IsShowHiddenFile = isShowHiddenFile;
            sw.WriteLine("isShowHiddenFile:" + isShowHiddenFile);

            Option.IsKeepLatestApk = isKeepLatestApk;
            sw.WriteLine("isKeepLatestApk:" + isKeepLatestApk);

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
