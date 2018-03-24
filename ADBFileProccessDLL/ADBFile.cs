using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpAdbClient;
using System.IO;
using System.Text.RegularExpressions;

namespace ADBFileProccessDLL
{
    public class ADBFile
    {
        public DeviceData device;
        public ADBFile(DeviceData currentDevice)
        {
            device = currentDevice;
        }

        public ADBFile(DeviceData currentDevice, string name, string directoryname, string tag)
        {
            device = currentDevice;
            Name = name;
            DirectoryName = directoryname;
            FullName = directoryname + "/" + name;
            Extension = GetExtension(Name);
            Tag = tag;
        }

        public ADBFile(DeviceData currentDevice, string fullname)
        {
            device = currentDevice;
            FullName = fullname;
            Name = fullname.Remove(0, fullname.LastIndexOf(@"/")).Remove(0, 1);
            DirectoryName = fullname.Remove(fullname.LastIndexOf(@"/"), fullname.Length - fullname.LastIndexOf(@"/"));
            try
            {
                ParentDirectory = DirectoryName.Remove(DirectoryName.LastIndexOf(@"/"), DirectoryName.Length - DirectoryName.LastIndexOf(@"/"));
            }
            catch (Exception)
            {
                ParentDirectory = "/";
            }
            Extension = GetExtension(Name);
        }

        /// <summary>
        /// just name of file or directory
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// full path + name of file or directory
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// full path of parent Directory
        /// </summary>
        public string ParentDirectory { get; set; }

        /// <summary>
        /// Fullname - Name => DirectoryName
        /// </summary>
        public string DirectoryName { get; set; }
        public string Extension { get; set; }

        public string Tag { get; set; }
        public bool Exist { get; set; }

        public List<ADBFile> GetChildFiles()
        {
            List<ADBFile> lf = new List<ADBFile>();
            string cmd = resultCommand("ls -l " + FullName + "/");
            if (FullName == "/sdcard")
            {
                Exist = true;
            }
            foreach (string[] fileOrDirName in resultNameLs(cmd))
            {
                lf.Add(new ADBFile(device, fileOrDirName[1], FullName, fileOrDirName[0]));
            }
            return lf;
        }
        public string GetLength()
        {
            string fixName = Name.fixBracketInTerminal();
            string cmd = resultCommand(string.Format("ls -l {0}|grep {1} ", DirectoryName, fixName));
            string[] rslt = resultOneLineLs(cmd);
            string result = "";

            if (!"ld".Contains(rslt[0]))
            {
                //in kb
                result = (Convert.ToDouble(rslt[1]) / 1024).ToString();
            }
            else if (rslt[0] == "l")
            {
                result = "0";
            }
            else
            {
                //in byte
                cmd = resultCommand(@"du -s " + FullName);
                result = resultDu(cmd);
            }

            return Convert.ToDouble(result).humanReadable();

        }
        public double GetLengthDouble()
        {
            string fixName = Name.fixBracketInTerminal();
            string cmd = resultCommand(string.Format("ls -l {0}|grep {1} ", DirectoryName, fixName));
            string[] rslt = resultOneLineLs(cmd);
            Double result;

            if (!"ld".Contains(rslt[0]))
            {
                //in kb
                result = (Convert.ToDouble(rslt[1]) / 1024);
            }
            else if (rslt[0] == "l")
            {
                result = 0;
            }
            else
            {
                //in byte
                cmd = resultCommand(@"du -s " + FullName);
                result = Convert.ToDouble(resultDu(cmd));

            }

            return Convert.ToDouble(result);
        } 
        private string resultCommand(string Command)
        {

                var receiver = new ConsoleOutputReceiver();
                AdbClient.Instance.ExecuteRemoteCommand(Command, device, receiver);
                return receiver.ToString();

        }


        private string GetExtension(string nameFile)
        {
            return "." + nameFile.Split('.').LastOrDefault();
        }



        /// <summary>
        /// method return list of tag and name
        /// </summary>
        /// <param name="result">result Command In Shell</param>
        /// <returns>Tag & Name File or Directory</returns>
        private List<string[]> resultNameLs(string result)
        {
            List<string> resultList_ls = new List<string>();
            List<string> resultWords = new List<string>();
            List<string[]> resultEnd = new List<string[]>();
            string temp;
            bool firstTime = true;


            Regex rgx = new Regex(@"\d\d:\d\d");

            // remove Error
            StringReader sr = new StringReader(result);
            while (sr.Peek() >= 0)
            {
                temp = sr.ReadLine();
                if (temp.Contains("Permission denied") || temp.Contains("total"))
                {
                    continue;
                }
                resultList_ls.Add(temp);
            }

            //Each Line Ls -l
            foreach (string oneline in resultList_ls)
            {
                resultWords = oneline.Split(' ').ToList();

                for (int i = 0; i < resultWords.Count; i++)
                {
                    if (rgx.IsMatch(resultWords[i]))
                    {
                        temp = "";
                        firstTime = true;
                        for (int j = i + 1; j < resultWords.Count; j++)
                        {
                            if (resultWords[j] == "->" && j < resultWords.Count)
                            {
                                break;
                            }
                            if (firstTime)
                            {
                                temp += resultWords[j];
                                firstTime = false;
                            }
                            else
                            {
                                temp += @"\ " + resultWords[j];
                            }
                        }
                        resultEnd.Add(new string[] { oneline[0].ToString(), temp });
                        break;
                    }
                }
            }

            return resultEnd;
        }
        private string resultDu(string result)
        {
            Regex rgx = new Regex(@"\d{1,10}");
            List<string> tmp = new List<string>();
            string temp;
            StringReader sr = new StringReader(result);
            while (sr.Peek() >= 0)
            {
                temp = sr.ReadLine();
                if (temp.Contains("Permission denied") || temp.Contains("error"))
                {
                    continue;
                }
                tmp.Add(temp);
            }
            if (tmp.Count == 0)
            {
                return "0";
            }
            return tmp.LastOrDefault().Split('\t')[0];
        }
        private string[] resultOneLineLs(string result)
        {
            List<string> tmp = new List<string>();
            string temp;
            string size = "0";
            StringReader sr = new StringReader(result);
            //Regex rgx = new Regex(@"[1-9]{1,12}");

            while (sr.Peek() >= 0)
            {
                temp = sr.ReadLine();
                if (temp.Contains("Permission denied") || temp.Contains("error"))
                {
                    continue;
                }
                tmp.Add(temp);
            }

            ///
            if (tmp.Count == 0)
            {
                return new string[] { "d", "0" };
            }
            if (tmp.LastOrDefault()[0].ToString() == "d")
            {
                return new string[] { "d", "0" };
            }
            ///

            foreach (string word in tmp.LastOrDefault().Split(' '))
            {
                if (word.isDigits())
                {
                    size = word;
                }
            }

            return new string[] { tmp.LastOrDefault()[0].ToString(), size };
        }

        //private string fixSpaceName(string mytext)
        //{
        //    string temp = string.Empty;
        //    if (mytext.Contains(' '))
        //    {
        //        foreach (var item in mytext.ToList())
        //        {
        //            if (item == ' ')
        //            {
        //                temp = temp + @"\ ";
        //            }
        //            else
        //            {
        //                temp = temp + item;
        //            }
        //        }
        //        return temp;
        //    }
        //    else
        //    {
        //        return mytext;
        //    }
        //}

        //public bool isDirectory()
        //{
        //    char tempchar=resultCommand(string.Format("ls -l {0}|grep {1}", this.DirectoryName, this.Name)).FirstOrDefault();
        //    if (tempchar=='d')
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}
