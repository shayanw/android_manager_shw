using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADBProccessDLL;
namespace AndroidManager_SHW
{
    public partial class PropertiesForm : Form
    {
        string TypeFile, Location, Size, CountFiles;
        int CountFilesInt;
        double SizeDouble;
        bool isFile;
        ADBFile oneFile;
        FileManager FM;

        string tmpName;

        List<ADBFile> multiFiles;

        public PropertiesForm()
        {
            InitializeComponent();
        }

        public PropertiesForm(ADBFile myFile,Image img)
        {
            InitializeComponent();
            
            isFile = true;
            oneFile = myFile;
            FM = new FileManager(myFile.device);
            TypeFile = getTypeFile(myFile);
            Location = myFile.DirectoryName;
            pictureBox_iconFile.Image = img;
            label_locationValue.Text = Location.DecodingText();

            label_sizeValue.Text = label_countValue.Text = "•••";

            backgroundWorker_getSizeFile.RunWorkerAsync();

            textBox_name.Text = myFile.Name.Replace(@"\",string.Empty).DecodingText();
            tmpName = textBox_name.Text;
            label_typeValue.Text = TypeFile.DecodingText();
        }

        public PropertiesForm(List<ADBFile> myFiles, Image img)
        {
            InitializeComponent();
            textBox_name.Enabled = false;
            isFile = false;
            CountFilesInt = 0;
            SizeDouble = 0;
            multiFiles = myFiles;
            FM = new FileManager(myFiles[0].device);
            pictureBox_iconFile.Image = img;
            label_locationValue.Text = myFiles[0].DirectoryName.DecodingText();
            label_sizeValue.Text = label_countValue.Text = "•••";
            textBox_name.Text = myFiles .Count+ " Selected Files...";
            tmpName = textBox_name.Text;
            label_typeValue.Text = "Multi Files";
            backgroundWorker_getSizeFile.RunWorkerAsync();
        }
        private void backgroundWorker_getSizeFile_DoWork(object sender, DoWorkEventArgs e)
        {
            if (isFile)
            {
                Size = oneFile.GetLengthDouble().humanReadable();
            }
            else
            {
                foreach (ADBFile onefile in multiFiles)
                {
                    SizeDouble += onefile.GetLengthDouble();
                }
                Size = SizeDouble.humanReadable();
            }
        }
        private void backgroundWorker_getSizeFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label_sizeValue.Text = Size;
            backgroundWorker_getCountFile.RunWorkerAsync();
        }


        private void backgroundWorker_getCountFile_DoWork(object sender, DoWorkEventArgs e)
        {
            if (isFile)
            {
                CountFiles = FM.CountFileAndDirectory(oneFile).ToString();
            }
            else
            {

            }
            
        }
        private void backgroundWorker_getCountFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (isFile)
            {
                if (TypeFile != "Directory")
                {
                    label_countValue.Visible = label_count.Visible = false;
                    return;
                }
                label_countValue.Text = CountFiles;
            }
            else
            {
                label_countValue.Text = "-";
            }
            
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            if (tmpName==textBox_name.Text || string.IsNullOrEmpty(textBox_name.Text)|| string.IsNullOrEmpty(tmpName))
            {
                button_ok.Text = "ok";
            }
            else
            {
                button_ok.Text = "Rename";
            }
            
        }

        private void PropertiesForm_Load(object sender, EventArgs e)
        {

        }



        private void button_ok_Click(object sender, EventArgs e)
        {
            if (isFile)
            {
                if (!string.IsNullOrEmpty(textBox_name.Text) && isFile)
                {
                    oneFile.Rename(textBox_name.Text.fixBracketInTerminal().EncodingText());
                }
            }
            this.Close();
        }

        private string getTypeFile(ADBFile onefile)
        {
            if (onefile.isDirectory())
            {
                return "Directory";
            }
            else
            {
                if (string.IsNullOrEmpty(onefile.Extension))
                {
                    return "unknownFile";
                }
                return onefile.Extension;
            }
        }
    }
}
