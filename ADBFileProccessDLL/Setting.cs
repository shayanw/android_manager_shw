using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ADBProccessDLL;

namespace ADBProccessDLL
{
    [Serializable]
    public class Setting
    {
        public string backupPath;
        public string updatePackagePath;
        public Setting()
        {
            string tmp;
            try
            {
                StreamReader sr = new StreamReader(returnPathSetting() + @"\sett.shw");
                while (sr.Peek()>0)
                {
                    tmp=sr.ReadLine();
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
                }
                sr.Close();
            }
            catch
            {
                backupPath = updatePackagePath = "";
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
            sw.WriteLine("backupPath:" + backupPath);
            sw.WriteLine("updatePackagePath:" + updatePackagePath);
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
