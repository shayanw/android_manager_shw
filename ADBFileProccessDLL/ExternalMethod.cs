﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpAdbClient;
using System.IO;

namespace ADBProccessDLL
{
    public static class ExternalMethod
    {
        private static int counterEx;
        public static int CounterEx { get => counterEx; set => counterEx = value; }

        #region More Method About AdbFile and convert...
        public static string humanReadable(this double byteSize)
        {
            string result = "";
            double kb1 = 1;
            double mb1 = kb1 * 1024;
            double gb1 = mb1 * 1024;
            if (byteSize >= gb1)
            {
                result = (byteSize / gb1).ToString("0.0") +" GB";
            }
            else if (byteSize >= mb1)
            {
                result = (byteSize / mb1).ToString("0.0") +" MB";
            }
            else if(byteSize >= kb1)
            {
                result = (byteSize / kb1).ToString("0.0") + " KB";
            }
            else
            {
                result = byteSize.ToString("0.0") + " B";
            }
            return result;
        }

        public static string getStringTime(this int time_seconds)
        {
            int sec = 1;
            int min = 60 * sec;
            int hou = min * 60;
            int day = hou * 24;

            if (time_seconds> day)
            {
                return string.Format("{0} Days And {1} Hours",time_seconds/day,time_seconds%day);
            }
            else if (time_seconds > hou)
            {
                return string.Format("{0} Hours And {1} Minutes", time_seconds / hou, time_seconds % hou);
            }
            else if (time_seconds > min)
            {
                return string.Format("{0} Minutes And {1} Seconds", time_seconds / min, time_seconds % min);
            }
            else
            {
                return string.Format("{0} Seconds", time_seconds);
            }

        }

        public static bool isDigits(this string txt)
        {
            try
            {
                Convert.ToDecimal(txt);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static string nickName(this string txt)
        {
            string tmp = "";
            List<int> listIndex = new List<int>();
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i].ToString() == @"\" && i + 1 < txt.Length)
                {
                    if (txt[i + 1] == ' ')
                    {
                        listIndex.Add(i);
                        tmp += " ";
                        continue;
                    }
                }
                tmp += txt[i];
            }
            return tmp;
        }

        public static ADBFile returnFile(this string fullname, DeviceData device)
        {
            return new ADBFile(device, fullname);
        }
        #endregion

        #region DeviceData Extension Method
        public static string AndroidVersion(this DeviceData myDevice)
        {
            return resultCommand(@"getprop ro.build.version.release",myDevice);
        }
        public static int AndroidSDK(this DeviceData myDevice)
        {
            return Convert.ToInt32(resultCommand(@"getprop ro.build.version.sdk", myDevice));
        }
        public static string BatteryPercentage(this DeviceData myDevice)
        {
            StringReader sr = new StringReader(resultCommand(@"dumpsys battery", myDevice));
            string tmp;
            while (sr.Peek() >= 0)
            {
                tmp = sr.ReadLine();
                if (tmp.Contains("level"))
                {
                    return tmp.Remove(0, tmp.IndexOf(':')+1);
                }
            }
            return " - ";

        }


        public static bool Shutdown(this DeviceData myDevice)
        {
            if (string.IsNullOrEmpty(resultCommand("reboot -p", myDevice)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Bootloader(this DeviceData myDevice)
        {
            if (string.IsNullOrEmpty(resultCommand("reboot bootloader", myDevice)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Recovery(this DeviceData myDevice)
        {
            if (string.IsNullOrEmpty(resultCommand("reboot recovery", myDevice)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Reboot(this DeviceData myDevice)
        {
            if (string.IsNullOrEmpty(resultCommand("reboot sideload-auto-reboot", myDevice)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region work on File System
        public static int GetCountOfFilesAndDirectoriesInSystem(this string FileOrDirectory)
        {
            int counter = 0;
            if (Directory.Exists(FileOrDirectory))
            {
                counter++;
                DirectoryInfo di = new DirectoryInfo(FileOrDirectory);
                counter += di.GetFiles().Count();
                counter += di.GetDirectories().Count();
                foreach (DirectoryInfo item in di.GetDirectories())
                {
                    counter+= GetCountOfFilesAndDirectoriesInSystem(item.FullName);
                }
            }
            else
            {
                counter += 1;
            }
            return counter;
        }
        public static double GetSizeOfFilesAndDirectoriesInSystem(this string FileOrDirectory)
        {
            double sizeCount = 0;
            if (Directory.Exists(FileOrDirectory))
            {
                List<string> fileAndDirS = new List<string>();
                DirectoryInfo di = new DirectoryInfo(FileOrDirectory);

                foreach (DirectoryInfo item in di.GetDirectories())
                {
                    fileAndDirS.Add(item.FullName);
                }
                foreach (FileInfo item in di.GetFiles())
                {
                    fileAndDirS.Add(item.FullName);
                }
                foreach (string item in fileAndDirS)
                {
                    sizeCount += GetSizeOfFilesAndDirectoriesInSystem(item);
                }
            }
            else
            {
                FileInfo fi = new FileInfo(FileOrDirectory);
                sizeCount += fi.Length;
            }
            return sizeCount;
        }
        #endregion

        #region Fix Code in Adb
        public static string FixForbidCharInTerminal(this string txt)
        {
            string result = "";
            if (string.IsNullOrEmpty(txt))
            {
                return "";
            }
            foreach (char oneChar in txt.ToList())
            {
                if (oneChar == '\\')
                {
                    continue;
                }
                if (oneChar == '(' || oneChar == ')' || oneChar == ' ' || oneChar == '\'' || oneChar == '&')
                {
                    result += @"\";
                }
                result += oneChar;
            }
            return result;
        }
        public static string EncodingText(this string forEncodText)
        {
            return Encoding.GetEncoding("iso-8859-1").GetString(Encoding.UTF8.GetBytes(forEncodText));
        }
        public static string DecodingText(this string forDecodeText)
        {
            string tmp = forDecodeText.textDicoder();
            if (tmp.Contains("?"))
            {
                return forDecodeText;
            }
            return tmp;
        }
        private static string textDicoder(this string forDecodText)
        {
            if (string.IsNullOrEmpty(forDecodText))
            {
                return "";
            }
            return Encoding.UTF8.GetString(Encoding.GetEncoding("iso-8859-1").GetBytes(forDecodText));
        }
        #endregion

        #region Base Method
        public static string resultCommand(string Command, DeviceData device)
        {
            try
            {
                var receiver = new ConsoleOutputReceiver();
                AdbClient.Instance.ExecuteRemoteCommand(Command, device, receiver);
                return receiver.ToString();
            }
            catch (Exception)
            {
                return "•••";
            }
        }
        public static string AdbCommand(string command)
        {

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = @".\platform-tools\adb.exe";
            process.StartInfo.Arguments = command;

            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            return process.StandardOutput.ReadToEnd();
        }
        #endregion
    }
}
