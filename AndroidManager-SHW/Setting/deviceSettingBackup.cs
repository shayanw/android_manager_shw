using ADBProccessDLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidManager_SHW.Setting
{
    class deviceSettingBackup
    {
        string model, name, serial, pathBackup;
        double sizePath=0;
        int countFiles;
        DirectoryInfo infoDir;
        public deviceSettingBackup(DirectoryInfo directoryName)
        {
            infoDir = directoryName;
            string DirectoryName=directoryName.Name;
            pathBackup = directoryName.FullName;

            //--mode | name | serial
            int tmpLastUnderLine = DirectoryName.Split('[')[0].LastIndexOf('_');
            for (int i = 0; i < tmpLastUnderLine; i++)
            {
                model += DirectoryName[i];
            }
            DirectoryName=DirectoryName.Replace(model, "");
            name = DirectoryName.Split('[')[0].Replace("_","");
            serial = DirectoryName.Replace(name,"").Replace("_", "").Replace("[", "").Replace("]", "");


            //---Size
            getSizeDir();

            //---count
            getCountFiles();
        }
        
        public string Model { get { return model; } }

        //public string Name { get { return name; } }
        //public string Serial { get { return serial; } }
        public string SizePath { get { return (sizePath/1024).humanReadable(); } }
        public int CountFiles { get { return countFiles; } }
        
        public string PathBackup { get { return pathBackup; } }

        private void getSizeDir()
        {
            foreach (FileInfo f in infoDir.GetFiles("*", SearchOption.AllDirectories))
            {
                sizePath += f.Length;
            }
        }

        private void getCountFiles()
        {
            countFiles=infoDir.GetFiles("*",SearchOption.AllDirectories).Count();
        }


    }
}
