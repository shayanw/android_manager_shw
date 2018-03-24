using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpAdbClient;
using System.IO;

namespace ADBFileProccessDLL
{
    public static class ExternalMethod
    {
        public static int counterEx;
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
        public static ADBFile returnFile(this string fullname,DeviceData device)
        {
            return new ADBFile(device, fullname);
        }
        public static string returnSizeFile(this string fullname, DeviceData device)
        {
            ADBFile f = new ADBFile(device, fullname);
            return f.GetLength();
        }

        public static string humanReadable(this double byteSize)
        {
            string result = "";
            double kb1 = 1;
            double mb1 = kb1 * 1024;
            double gb1 = mb1 * 1024;
            if (byteSize>gb1)
            {
                result = (byteSize / gb1).ToString("0.0") +" Gb";
            }
            else if (byteSize > mb1)
            {
                result = (byteSize / mb1).ToString("0.0") +" Mb";
            }
            else
            {
                result = (byteSize / mb1).ToString("0.0") + " kb";
            }
            return result;
        }

        public static string fixBracketInTerminal(this string txt)
        {
            string result = "";
            foreach (char oneChar in txt.ToList())
            {
                if (oneChar == '\\')
                {
                    continue;
                }
                if (oneChar=='('|| oneChar == ')'|| oneChar == ' ' || oneChar == '\'' || oneChar == '&')
                {
                    result+=@"\";
                }
                result += oneChar;
            }
            return result;
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

        public static bool isDirectory(this ADBFile oneFile)
        {
            string cmd = resultCommand(string.Format("ls -l {0}|grep {1} ", oneFile.DirectoryName+"/", oneFile.Name.fixBracketInTerminal()),oneFile.device);
            List<string> tmp = new List<string>();
            string temp;
            StringReader sr = new StringReader(cmd);

            while (sr.Peek() >= 0)
            {
                temp = sr.ReadLine();
                if (temp.Contains("Permission denied") || temp.Contains("error"))
                {
                    continue;
                }
                tmp.Add(temp);
            }

            if (tmp.Count>0 && tmp.LastOrDefault()[0].ToString() == "d")
            {
                return true;
            }
            return false;
        }

        private static string resultCommand(string Command,DeviceData device)
        {
            var receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand(Command, device, receiver);
            return receiver.ToString();
        }
        public static void test() { }
        
    }
}
