using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ApkReaderShwDll
{
    public static class ApkProccess
    {
        public static ApkReader.ApkInfo ViewApkInfo(string addressApk)
        {
            var reader = new ApkReader.ApkReader();
            var info = reader.Read(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, addressApk));
            return info;
        }

        public static bool ExtractIcon(string pathIcon, string addressApk)
        {
            string addressPathIcon = pathIcon;
            string item = addressApk;

            ApkReader.ApkInfo apkinfo = ViewApkInfo(addressApk);
            string tmpIcon = "";

            //List Icon For One apk
            List<string> lsicon = new List<string>(apkinfo.Icons.Values);
            //get Last Icon
            tmpIcon = lsicon[lsicon.Count - 1];

            //Extract Icon
            using (ZipFile zip = ZipFile.Read(item))
            {
                ZipEntry e = zip[tmpIcon];
                e.Extract(addressPathIcon);
                File.Move(addressPathIcon + @"\" + tmpIcon, addressPathIcon + @"\" + apkinfo.PackageName + ".png");
            }
            return true;
        }

        public static void ExtractIconProccess(string pathIcon, string addressApk)
        {

            List<string> SavedIconsList = new List<string>(Directory.GetFiles(pathIcon));
            List<string> ApkList = new List<string>(Directory.GetFiles(addressApk));

            Regex apkFileRGX = new Regex(@".*apk", RegexOptions.IgnoreCase);

            foreach (string fileApkTmp in ApkList)
            {
                if (!apkFileRGX.IsMatch(fileApkTmp))
                {
                    continue;
                }

                if (!SavedIconsList.Any(a=>a.Contains(fileApkTmp.getName())))
                {
                    try
                    {
                        ExtractIcon(pathIcon, fileApkTmp);
                    }
                    catch
                    {}
                }
            }

            foreach (string tmpDir in Directory.GetDirectories(pathIcon))
            {
                try
                {
                    Directory.Delete(tmpDir, true);
                }
                catch
                {}
            }
        }



        static string getName(this string fullPath)
        {
            return fullPath.Replace(fullPath.Remove(fullPath.LastIndexOf(@"\") + 1), "").removeVersion(); ; 
        }

        static string removeVersion(this string nameApk)
        {
           return nameApk.Remove(nameApk.LastIndexOf(@"_")+1).Replace(@"_","");
        }
    }
}
