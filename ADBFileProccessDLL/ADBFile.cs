using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpAdbClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace ADBProccessDLL
{
    public class ADBFile
    {
        #region Filed and Prop

        public DeviceData device;

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

        public double Size = -1;
        public int SubFilesNumber;
        public string LineLsForFile;

        #endregion

        #region Constructor
        public ADBFile(DeviceData currentDevice, string name, string directoryname, string tag, string lineLs = "")
        {
            device = currentDevice;
            Name = name;
            DirectoryName = directoryname;
            FullName = directoryname + "/" + name;
            Extension = GetExtension(Name);
            Tag = tag;
            LineLsForFile = lineLs;
            SubFilesNumber = 0;
        }

        public ADBFile(DeviceData currentDevice, string fullname)
        {
            device = currentDevice;
            FullName = fullname;

            try
            {
                Name = fullname.Remove(0, fullname.LastIndexOf(@"/")).Remove(0, 1);
                SubFilesNumber = 0;
                DirectoryName = fullname.Remove(fullname.LastIndexOf(@"/"), fullname.Length - fullname.LastIndexOf(@"/"));
                ParentDirectory = DirectoryName.Remove(DirectoryName.LastIndexOf(@"/"), DirectoryName.Length - DirectoryName.LastIndexOf(@"/"));
                Extension = GetExtension(Name);
            }
            catch (Exception)
            {
                ParentDirectory = "/";
                Extension = "-";
            }
            
        }

        public ADBFile(DeviceData currentDevice)
        {
            device = currentDevice;
            SubFilesNumber = 0;
        }
        #endregion

        #region Get More Details File
        public List<ADBFile> GetSubFiles()
        {
            List<ADBFile> ListAdbFiles = new List<ADBFile>();
            string cmd = "";

            if (Option.IsShowHiddenFile)
            {
                cmd = ReturnResultCommand("ls -la " + FullName + "/");
            }
            else
            {
                cmd = ReturnResultCommand("ls -l " + FullName + "/");
            }

            return ReturnListAdbFile_LinesLs(cmd, FullName);
        }

        public double GetLengthDouble()
        {
            if (Size > -1)
            {
                return Size;
            }
            string fixName = Name.FixForbidCharInTerminal();
            string cmd = "";
            if (!string.IsNullOrEmpty(LineLsForFile))
            {
                cmd = LineLsForFile;
            }
            else
            {
                cmd = ReturnResultCommand(string.Format("ls -l {0}|grep {1} ", DirectoryName, fixName));
            }
            string[] rslt = ReturnTagSize_OneLineLs(cmd);
            Double result;
            if (!"ld".Contains(rslt[0]))
            {
                //in kb
                result = (Convert.ToDouble(rslt[1]) / 1024);
            }
            else
            {
                //in byte
                cmd = ReturnResultCommand(@"du -s " + FullName.FixForbidCharInTerminal()/*.EncodingText()*/);
                try
                {
                    result = Convert.ToDouble(ReturnResultDu(cmd));
                }
                catch
                {
                    result = 000;
                }

            }
            Size = Convert.ToDouble(result);
            return Size;
        }
        public int GetCountSubFiles()
        {
            int ctmp = 0;

            if ("ld".Contains(GetTag()))
            {
                foreach (ADBFile oneFileTmp in GetSubFiles())
                {
                    ctmp += oneFileTmp.GetCountSubFiles();
                }
            }
            else
            {
                ctmp++;
            }

            SubFilesNumber = ctmp;
            return ctmp;
        }
        private string GetExtension(string nameFile)
        {
            return "." + nameFile.Split('.').LastOrDefault();
        }

        public char GetTag()
        {
            string cmd = "";

            if (!string.IsNullOrEmpty(this.Tag))
            {
                cmd = this.Tag;
            }

            else if (!string.IsNullOrEmpty(LineLsForFile))
            {
                cmd = LineLsForFile;
            }
            else
            {
                cmd = ReturnResultCommand(string.Format("ls -l {0}|grep {1} ", DirectoryName, Name.FixForbidCharInTerminal()));
            }

            try
            {
                return cmd[0];
            }
            catch
            {

                return 'n';
            }

        }
        #endregion
         
        #region Base Method
        private string ReturnResultCommand(string Command)
        {

            var receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand(Command, device, receiver);
            return receiver.ToString();

        }
        private List<ADBFile> ReturnListAdbFile_LinesLs(string result_LinesLs, string tmpDirectoryName)
        {
            //Should Return ADB File...
            //Fiels-------------------------------------------------------------
            List<string> ValidLsLines = new List<string>();
            List<string> resultWords = new List<string>();
            List<string[]> ListTagName = new List<string[]>();
            StringReader StreamReader_ResultCode = new StringReader(result_LinesLs);
            string tempCheckLine;
            bool firstTime = true;
            Regex rgx = new Regex(@"\d\d:\d\d");

            List<ADBFile> ListAdbFile = new List<ADBFile>();
            ADBFile tmpAdbFile;
            string tmpName, tmpTag;

            //Add Valid Code in ValidLsLines------------------------------------
            while (StreamReader_ResultCode.Peek() >= 0)
            {
                tempCheckLine = StreamReader_ResultCode.ReadLine();
                if (tempCheckLine.Contains("Permission denied") || tempCheckLine.Contains("total"))
                {
                    continue;
                }
                ValidLsLines.Add(tempCheckLine);
            }



            //Each Line Ls -l Get Tag & Name-------------------------------------
            foreach (string oneline in ValidLsLines)
            {
                resultWords = oneline.Split(' ').ToList();

                for (int i = 0; i < resultWords.Count; i++)
                {
                    if (rgx.IsMatch(resultWords[i]))
                    {
                        tempCheckLine = "";
                        firstTime = true;
                        for (int j = i + 1; j < resultWords.Count; j++)
                        {
                            if (resultWords[j] == "->" && j < resultWords.Count)
                            {
                                break;
                            }
                            if (firstTime)
                            {
                                tempCheckLine += resultWords[j];
                                firstTime = false;
                            }
                            else
                            {
                                tempCheckLine += @"\ " + resultWords[j];
                            }
                        }
                        tmpName = tempCheckLine;
                        tmpTag = oneline[0].ToString();
                        tmpAdbFile = new ADBFile(device, tmpName, tmpDirectoryName, tmpTag, oneline);
                        ListAdbFile.Add(tmpAdbFile);
                        break;
                    }
                }
            }

            return ListAdbFile;
        }
        private string[] ReturnTagSize_OneLineLs(string result_Ls_Code)
        {
            //Fiels-------------------------------------------------------------
            List<string> ValidLsLines = new List<string>();
            string tempCheckLine;
            string SizeString = "0";
            StringReader StreamReader_ResultCode = new StringReader(result_Ls_Code);



            //Add Valid Code in ValidLsLines------------------------------------
            while (StreamReader_ResultCode.Peek() >= 0)
            {
                tempCheckLine = StreamReader_ResultCode.ReadLine();
                if (tempCheckLine.Contains("Permission denied") || tempCheckLine.Contains("error"))
                {
                    continue;
                }
                ValidLsLines.Add(tempCheckLine);
            }



            //Seprate null and Directory from File------------------------------
            //Default null and Directory => Tag="d" & Size="0"------------------
            if (ValidLsLines.Count == 0)
            {
                return new string[] { "d", "0" };
            }
            else if (ValidLsLines.LastOrDefault()[0].ToString() == "d")
            {
                return new string[] { "d", "0" };
            }

            string tmpvalidlsline=ValidLsLines.LastOrDefault().Replace(this.Name.Replace("\\",""), "");
            //Seprate null and Directory from File------------------------------
            foreach (string word in tmpvalidlsline.Split(' '))
            {
                if (word.isDigits())
                {
                    SizeString = word;
                }
            }


            //Return Tag & Size-------------------------------------------------
            return new string[] { ValidLsLines.LastOrDefault()[0].ToString(), SizeString };
        }
        private string ReturnResultDu(string result_Du_Code)
        {
            //Fiels-------------------------------------------------------------
            Regex rgx = new Regex(@"\d{1,10}");
            List<string> ValidLsLines = new List<string>();
            string tempCheckLine;
            StringReader StreamReader_ResultCode = new StringReader(result_Du_Code);



            //Add Valid Code in ValidLsLines------------------------------------
            while (StreamReader_ResultCode.Peek() >= 0)
            {
                tempCheckLine = StreamReader_ResultCode.ReadLine();
                if (tempCheckLine.Contains("Permission denied") || tempCheckLine.Contains("error"))
                {
                    continue;
                }
                ValidLsLines.Add(tempCheckLine);
            }



            //if ValidLsLines is Empty Return Size=0----------------------------
            if (ValidLsLines.Count == 0)
            {
                return "0";
            }



            //return Size Of Directory------------------------------------------
            return ValidLsLines.LastOrDefault().Split('\t')[0];
        }
        public bool Rename(string NewName)
        {
            if (string.IsNullOrEmpty(ReturnResultCommand(string.Format(@"mv {0} {1}", FullName.FixForbidCharInTerminal(), (this.DirectoryName + "/" + NewName).FixForbidCharInTerminal()))))
            {
                this.FullName = this.ParentDirectory + "/" + NewName;
                this.Name = NewName;
                return true;
            }
            return false;
        }
        #endregion

    }
}