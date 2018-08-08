using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpAdbClient;
using ADBProccessDLL;
using System.Net;
using System.Threading;

namespace AndroidManager_SHW
{
    public partial class FileManagerForm : Form
    {
        //Local DataType
        DeviceData device;
        FileManager fm;
        
        //String
        string currentPath = "storage";
        string backupPath = "";

        //Form DataType
            //Selected Item ListView...
        ListViewItem ListViewSI = new ListViewItem();

        //List
        List<ListViewItem> lastSelectedItem = new List<ListViewItem>();
        List<string> fileOrDirectoryForCopyCut = new List<string>();

    
       
        //Stack
        Stack<string> BackwardPath = new Stack<string>();
        Stack<string> ForwardPath = new Stack<string>();

        //Bool
        bool IsTransfer = false;
        bool IsPasteForCopy = true;
        bool IsShowSize = false;
        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="currentDevice"></param>
        public FileManagerForm(DeviceData currentDevice)
        {
            InitializeComponent();
            patchFixImage();

            IsShowSize = Option.IsShowSizeFM;
            if (IsShowSize)
            {
                button_showSize.BackgroundImage = AndroidManager_SHW.Properties.Resources.toggleOn;
                IsShowSize = true;

            }
            else
            {
                button_showSize.BackgroundImage = AndroidManager_SHW.Properties.Resources.toggleOff;
                label_size.Text = "";
                IsShowSize = false;
            }





            device = currentDevice;
            fm = new FileManager(device);
            backupPath = fm.option.MainPathBackupProp;
        }

        private void FileManagerForm_Load(object sender, EventArgs e)
        {
            refreshListView();
            SetTree();
        }

        /// <summary>
        /// az [currentPath] list file & directory migire va vase har no icon migire o tu listView_files add mishe
        /// </summary>
        void refreshListView()
        {
            //az item haye listView_files backup migirim
            ListView.ListViewItemCollection last = listView_files.Items;
            try
            {
                //item haye listView_files pak mikonim
                listView_files.Items.Clear();

                //be ezaye har file ye icon dar item listView_files dar nazar migirim...
                foreach (ADBFile item in fm.getDirectoryAndFiles(currentPath))
                {


                    ListViewItem lvi = new ListViewItem();
                    lvi.Name = item.FullName;
                    lvi.Text = item.Name.nickName().DecodingText();

                    if (item.Tag == "d" || item.Tag == "l")
                    {
                        lvi.ImageIndex = 1;
                        lvi.Tag = item.Tag;
                    }
                    else
                    {
                        switch (item.Extension.ToLower())
                        {
                            case ".aac":
                            case ".flac":
                            case ".mp3":
                            case ".MP3":
                            case ".ogg":
                                lvi.ImageIndex = 3;
                                break;
                            case ".exe":
                            case ".msi":
                                lvi.ImageIndex = 4;
                                break;
                            case ".apk":
                                lvi.ImageIndex = 5;
                                break;
                            case ".zip":
                            case ".rar":
                                lvi.ImageIndex = 6;
                                break;
                            case ".3gp":
                            case ".mkv":
                            case ".mp4":
                                lvi.ImageIndex = 7;
                                break;
                            case ".pdf":
                                lvi.ImageIndex = 8;
                                break;
                            case ".txt":
                            case ".text":
                                lvi.ImageIndex = 9;
                                break;
                            case ".jpg":
                            case ".JPG":
                            case ".png":
                            case ".img":
                            case ".dng":
                                lvi.ImageIndex = 10;
                                break;
                            case ".vcf":
                                lvi.ImageIndex = 12;
                                break;
                            case ".doc":
                            case ".docx":
                            case ".docm":
                            case ".dotx":
                            case ".dotm":
                            case ".docb":
                                lvi.ImageIndex = 13;
                                break;
                            case ".xls":
                            case ".xlt":
                            case ".xlm":
                            case ".xlsx":
                            case ".xlsm":
                                lvi.ImageIndex = 14;
                                break;
                            case ".ppt":
                            case ".pot":
                            case ".pps":
                            case ".pptx":
                            case ".ppsx":
                                lvi.ImageIndex = 15;
                                break;
                            case ".accdb":
                            case ".accde":
                            case ".accdt":
                            case ".accdr":
                                lvi.ImageIndex = 16;
                                break;
                            default:
                                lvi.ImageIndex = 2;
                                break;
                        }
                        lvi.Tag = 'F';

                    }

                    //har item dorost shode dar listView_files add mishe
                    listView_files.Items.Add(lvi);


                }

                //masire directory fileha ro dar toolStripTextBox_path neshun mide
                toolStripTextBox_path.Text = currentPath.Replace(@"\", string.Empty).DecodingText();

                if (backgroundWorker_ProccessSize.IsBusy)
                {
                    backgroundWorker_ProccessSize.CancelAsync();
                }
                if (!backgroundWorker_ProccessSize.IsBusy)
                {
                    backgroundWorker_ProccessSize.RunWorkerAsync();
                }
            }
            catch (Exception)
            {
                try
                {
                    listView_files.Items.AddRange(last);
                }
                catch
                {

                }
            }
        }

        private void listView_files_DoubleClick(object sender, EventArgs e)
        {
            if (listView_files.SelectedItems.Count > 0)
            {
                if (listView_files.SelectedItems[0].Tag.ToString() == "d" || listView_files.SelectedItems[0].Tag.ToString() == "l")
                {
                    BackwardPath.Push(currentPath);
                    currentPath = listView_files.SelectedItems[0].Name;
                    refreshListView();
                }
                else
                {
                    //try
                    //{
               
                    //}
                    //catch (Exception)
                    //{


                    //}
                }

            }
        }




        private void SetTree()
        {
            TreeNode Home = new TreeNode();
            Home.Name = "Root";
            Home.Text = "Root";
            Home.ImageIndex = 0;
            treeView_dir.Nodes.Add(Home);

            foreach (ADBFile dr in fm.getDirectoryAndFiles(""))
            {
                if (dr.Tag == "d" || dr.Tag == "l")
                {
                    TreeNode root = new TreeNode();
                    root.Name = dr.Name.nickName();
                    root.Text = dr.FullName;
                    root.ImageIndex = 1;
                    treeView_dir.Nodes[0].Nodes.Add(root);
                }
            }

        }




        #region Backward_Forward

        /// <summary>
        /// forward
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_forwardDirectory_Click(object sender, EventArgs e)
        {
            if (ForwardPath.Count > 0)
            {
                BackwardPath.Push(currentPath);
                currentPath = ForwardPath.Pop();
                refreshListView();
            }
        }
        /// <summary>
        /// backward
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_ParentDirectory_Click(object sender, EventArgs e)
        {
            if (BackwardPath.Count > 0)
            {
                ForwardPath.Push(currentPath);
                currentPath = BackwardPath.Pop();
                refreshListView();
            }

        }

        #endregion
        
        /// <summary>
        /// double click ruye treeView=>esm node dar currentPath mire va listView Refresh mishe...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_dir_DoubleClick(object sender, EventArgs e)
        {
            if (treeView_dir.SelectedNode.Name == "Root")
            {
                currentPath = "";
                refreshListView();
            }
            else
            {
                currentPath = treeView_dir.SelectedNode.Name;
                refreshListView();
            }
        }

        /// <summary>
        /// badaz kilik ruye node treeview=>list zir directoria sabt she...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_dir_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //age ghablan node baz shode bud ke hichi...
            if (treeView_dir.SelectedNode.Tag == "true")
            {
                return;
            }
            try
            {
                string ParentDr = treeView_dir.SelectedNode.Name;
                foreach (ADBFile Dr in fm.getDirectoryAndFiles(ParentDr))
                {
                    if (Dr.Tag == "d" || Dr.Tag == "l")
                    {
                        TreeNode directory = new TreeNode();
                        directory.Text = Dr.Name.nickName();
                        directory.Name = Dr.FullName;
                        directory.ImageIndex = 2;
                        treeView_dir.SelectedNode.Nodes.Add(directory);
                        treeView_dir.SelectedNode.Tag = "true";
                    }
                }
            }
            catch (Exception)
            {
            }
        }


        private void toolStripButton_collapseExpand_Click(object sender, EventArgs e)
        {

            if (panel_TreeSideBar.Visible)
            {
                panel_TreeSideBar.Visible = !panel_TreeSideBar.Visible;
                toolStripButton_collapseExpand.Image = AndroidManager_SHW.Properties.Resources.expand;
            }
            else
            {
                panel_TreeSideBar.Visible = !panel_TreeSideBar.Visible;
                toolStripButton_collapseExpand.Image = AndroidManager_SHW.Properties.Resources.collapse;
            }
        }


        /// <summary>
        /// age axa tu mohite visual dorost kar nakard...
        /// </summary>
        private void patchFixImage()
        {
            toolStripButton_collapseExpand.Image = AndroidManager_SHW.Properties.Resources.collapse;
            toolStripButton_forwardDirectory.Image = AndroidManager_SHW.Properties.Resources.Next;
            toolStripButton_ParentDirectory.Image = AndroidManager_SHW.Properties.Resources.Back;
            toolStripButton_goPath.Image = AndroidManager_SHW.Properties.Resources.Go;
        }

        /// <summary>
        /// address neveshte shode be onvane currentpath sabt shode va listView refresh mishe...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_goPath_Click(object sender, EventArgs e)
        {
            currentPath = toolStripTextBox_path.Text.fixBracketInTerminal().EncodingText();
            refreshListView();
        }


        private void listView_files_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_files.SelectedItems.Count == 0)
            {
                label_name.Text = "None";
                label_type.Text = "None";
            }
            if (listView_files.SelectedItems.Count == 1)
            {
                ListViewSI = listView_files.SelectedItems[0];
                setLabelFile();
            }
            if (listView_files.SelectedItems.Count > 1)
            {
                label_name.Text= "Selected Items: " + listView_files.SelectedItems.Count + " Files";
                label_type.Text = "Type: Files...";

                if (IsShowSize)
                {
                    label_size.Text = "_";
                }
                
            }
       
            if (listView_files.SelectedItems.Count > 0)
            {
                backupToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
                propertiesToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
            }
        }

        private void setLabelFile()
        {
            ADBFile f1 = ReturnAdbFileFromLVSelectItem(ListViewSI);

            label_name.Text = "Name: " + f1.Name.nickName().DecodingText();


            if (IsShowSize)
            {
                label_size.Text = "Size: " + f1.GetLengthDouble().humanReadable();
            }


            if (ListViewSI.Tag.ToString() == "d" || ListViewSI.Tag.ToString() == "l")
            {
                label_type.Text = "Type: Directory";

            }
            else
            {
                ADBFile oneFile = ListViewSI.Name.returnFile(device);
                label_type.Text = "Type: " + oneFile.Extension.DecodingText();
            }
        }

        private ADBFile ReturnAdbFileFromLVSelectItem(ListViewItem onelistViewItem)
        {
            ADBFile f1;

            if (fm.ListAdbFiles.Exists(a => a.FullName == onelistViewItem.Name))
            {
                f1 = fm.ListAdbFiles.Find(a => a.FullName == onelistViewItem.Name);
            }
            else
            {
                f1 = ListViewSI.Name.returnFile(device);
            }

            return f1;
        }

        /// <summary>
        /// delete selected items...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView_files.SelectedItems.Count > 0)
            {
                if (DialogResult.Yes == MessageBox.Show( messageForDelete(), "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int errorCounter = 0;
                    foreach (ListViewItem item in listView_files.SelectedItems)
                    {
                        if (!fm.DeleteDirectoryAndFiles(item.Name))
                        {
                            errorCounter++;
                        }
                    }
                    if (errorCounter>0)
                    {
                        MessageBox.Show("you have " + errorCounter + " Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Delete Files Completely", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    refreshListView();
                }

            }

        }

        private string messageForDelete()
        {
            if (listView_files.SelectedItems.Count==1)
            {
                return "are you sure Delete" +" \""+ listView_files.SelectedItems[0].Text+" \"  ?";
            }
            else
            {
                return "are you sure Delete  \" " + listView_files.SelectedItems.Count.ToString() + " \"  File & Directory ?";
            }
        }


        /// <summary>
        /// list copyCut clear => list jadid entesab && isIsPasteForCopy = true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copycutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView_files.SelectedItems.Count > 0)
            {
                string CurrentSenderText = ((ToolStripMenuItem)sender).Text;
                fileOrDirectoryForCopyCut.Clear();

                if (CurrentSenderText == "Copy")
                {
                    IsPasteForCopy = true;
                }
                else if (CurrentSenderText == "Cut")
                {
                    IsPasteForCopy = false;
                }
                foreach (ListViewItem item in listView_files.SelectedItems)
                {
                    fileOrDirectoryForCopyCut.Add(item.Name);
                }
                pasteToolStripMenuItem.Enabled = true;
            }
        }

        /// <summary>
        /// file hayi ke select shode backup gerefte mishavad...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listView_files.SelectedItems.Count > 0)
            {
                if (IsTransfer)
                {
                    MessageBox.Show("Please Wait For Last Proccess And Then Try Agin...","Notice",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                List<ADBFile> listFilesTmp = new List<ADBFile>();
                foreach (ListViewItem item in listView_files.SelectedItems)
                {
                    listFilesTmp.Add(new ADBFile(device, item.Name.fixBracketInTerminal()));
                }
                TransferForm transferform = new TransferForm(TransferType.BackingUp, listFilesTmp, backupPath, device);
                IsTransfer = true;
                transferform.Show();

                transferform.FormClosed += Transferform_FormClosed;
                fileOrDirectoryForCopyCut.Clear();
            }

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileOrDirectoryForCopyCut.Count != 0)
            {
                TransferForm transferform;
                List<ADBFile> listFilesTmp = new List<ADBFile>();

                if (IsTransfer)
                {
                    MessageBox.Show("Please Wait For Last Proccess And Then Try Agin...", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                
                foreach (string item in fileOrDirectoryForCopyCut)
                {
                    listFilesTmp.Add(new ADBFile(device, item.fixBracketInTerminal()));
                }

                
                if (IsPasteForCopy)
                {
                     transferform = new TransferForm(TransferType.Copying, listFilesTmp, currentPath, device);
                }
                else
                {
                     transferform = new TransferForm(TransferType.Cutting, listFilesTmp, currentPath, device);
                }
                
                IsTransfer = true;
                transferform.Show();
                transferform.FormClosed += Transferform_FormClosed;
                fileOrDirectoryForCopyCut.Clear();
            }


        }

        /// <summary>
        /// [Transferform] baste shod => [IsTransfer] false mishe va ListView Refresh mishe...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Transferform_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsTransfer = false;
            refreshListView();
        }

        /// <summary>
        /// baraye sakhte directory jadid => form [FileManager_CreateNewDir] baz she...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManager_CreateNewDir CND = new FileManager_CreateNewDir(device, currentPath); 
            CND.FormClosed += CND_FormClosed;
            CND.ShowDialog();

        }

        /// <summary>
        /// list view ro refresh kon...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CND_FormClosed(object sender, FormClosedEventArgs e)
        {
            refreshListView();
        }

        /// <summary>
        /// baraye enteghale file ha az pc va upliad ruye device
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Clipboard.GetFileDropList().Count!=0)
            {
                if (IsTransfer)
                {
                    MessageBox.Show("Please Wait For Last Proccess And Then Try Agin...", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                List<string> fdList = new List<string>();
                foreach (string item in Clipboard.GetFileDropList())
                {
                    fdList.Add(item);
                }
                TransferForm transferform = new TransferForm(TransferType.Uploading,fdList,currentPath,device);
                IsTransfer = true;
                transferform.Show();

                transferform.FormClosed += Transferform_FormClosed;
            }
        }

        /// <summary>
        /// [ADBFile] migire & Image => [PropertiesForm] ro ejra mikone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView_files.SelectedItems.Count==0)
            {
                return;
            }
            else if (listView_files.SelectedItems.Count==1)
            {
                Image thisImg = imageList_iconFile.Images[listView_files.SelectedItems[0].ImageIndex];
                PropertiesForm pf = new PropertiesForm(ReturnAdbFileFromLVSelectItem(listView_files.SelectedItems[0]),thisImg);
                pf.FormClosed += Pf_FormClosed;
                pf.ShowDialog();
            }
            else if (listView_files.SelectedItems.Count>1)
            {
                Image thisImg = imageList_iconFile.Images[11];
                List<ADBFile> liFiles = new List<ADBFile>();
                for (int i = 0; i < listView_files.SelectedItems.Count; i++)
                {
                    liFiles.Add(ReturnAdbFileFromLVSelectItem(listView_files.SelectedItems[i]));
                }
                PropertiesForm pf = new PropertiesForm(liFiles, thisImg);
                pf.FormClosed += Pf_FormClosed;
                pf.ShowDialog();
            }
        }

        private void Pf_FormClosed(object sender, FormClosedEventArgs e)
        {
            refreshListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            propertiesToolStripMenuItem_Click(sender,e);
        }

        private void listView_files_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listView_files_DoubleClick(sender, e);
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.KeyCode:
                        break;
                    case Keys.Modifiers:
                        break;
                    case Keys.None:
                        break;
                    case Keys.LButton:
                        break;
                    case Keys.RButton:
                        break;
                    case Keys.Cancel:
                        break;
                    case Keys.MButton:
                        break;
                    case Keys.XButton1:
                        break;
                    case Keys.XButton2:
                        break;
                    case Keys.Back:
                        toolStripButton_ParentDirectory_Click(sender, e);
                        break;
                    case Keys.Tab:
                        break;
                    case Keys.LineFeed:
                        break;
                    case Keys.Clear:
                        break;
                    case Keys.Return:
                        break;
                    case Keys.ShiftKey:
                        break;
                    case Keys.ControlKey:
                        break;
                    case Keys.Menu:
                        break;
                    case Keys.Pause:
                        break;
                    case Keys.Capital:
                        break;
                    case Keys.JunjaMode:
                        break;
                    case Keys.FinalMode:
                        break;
                    case Keys.HanjaMode:
                        break;
                    case Keys.Escape:
                        break;
                    case Keys.IMEConvert:
                        break;
                    case Keys.IMENonconvert:
                        break;
                    case Keys.IMEAccept:
                        break;
                    case Keys.IMEModeChange:
                        break;
                    case Keys.Space:
                        break;
                    case Keys.Prior:
                        break;
                    case Keys.Next:
                        break;
                    case Keys.End:
                        break;
                    case Keys.Home:
                        break;
                    case Keys.Left:
                        break;
                    case Keys.Up:
                        break;
                    case Keys.Right:
                        break;
                    case Keys.Down:
                        break;
                    case Keys.Select:
                        break;
                    case Keys.Print:
                        break;
                    case Keys.Execute:
                        break;
                    case Keys.Snapshot:
                        break;
                    case Keys.Insert:
                        break;
                    case Keys.Delete:
                        break;
                    case Keys.Help:
                        break;
                    case Keys.D0:
                        break;
                    case Keys.D1:
                        break;
                    case Keys.D2:
                        break;
                    case Keys.D3:
                        break;
                    case Keys.D4:
                        break;
                    case Keys.D5:
                        break;
                    case Keys.D6:
                        break;
                    case Keys.D7:
                        break;
                    case Keys.D8:
                        break;
                    case Keys.D9:
                        break;
                    case Keys.A:
                        break;
                    case Keys.B:
                        break;
                    case Keys.C:
                        break;
                    case Keys.D:
                        break;
                    case Keys.E:
                        break;
                    case Keys.F:
                        break;
                    case Keys.G:
                        break;
                    case Keys.H:
                        break;
                    case Keys.I:
                        break;
                    case Keys.J:
                        break;
                    case Keys.K:
                        break;
                    case Keys.L:
                        break;
                    case Keys.M:
                        break;
                    case Keys.N:
                        break;
                    case Keys.O:
                        break;
                    case Keys.P:
                        break;
                    case Keys.Q:
                        break;
                    case Keys.R:
                        break;
                    case Keys.S:
                        break;
                    case Keys.T:
                        break;
                    case Keys.U:
                        break;
                    case Keys.V:
                        break;
                    case Keys.W:
                        break;
                    case Keys.X:
                        break;
                    case Keys.Y:
                        break;
                    case Keys.Z:
                        break;
                    case Keys.LWin:
                        break;
                    case Keys.RWin:
                        break;
                    case Keys.Apps:
                        break;
                    case Keys.Sleep:
                        break;
                    case Keys.NumPad0:
                        break;
                    case Keys.NumPad1:
                        break;
                    case Keys.NumPad2:
                        break;
                    case Keys.NumPad3:
                        break;
                    case Keys.NumPad4:
                        break;
                    case Keys.NumPad5:
                        break;
                    case Keys.NumPad6:
                        break;
                    case Keys.NumPad7:
                        break;
                    case Keys.NumPad8:
                        break;
                    case Keys.NumPad9:
                        break;
                    case Keys.Multiply:
                        break;
                    case Keys.Add:
                        break;
                    case Keys.Separator:
                        break;
                    case Keys.Subtract:
                        break;
                    case Keys.Decimal:
                        break;
                    case Keys.Divide:
                        break;
                    case Keys.F1:
                        break;
                    case Keys.F2:
                        break;
                    case Keys.F3:
                        break;
                    case Keys.F4:
                        break;
                    case Keys.F5:
                        break;
                    case Keys.F6:
                        break;
                    case Keys.F7:
                        break;
                    case Keys.F8:
                        break;
                    case Keys.F9:
                        break;
                    case Keys.F10:
                        break;
                    case Keys.F11:
                        break;
                    case Keys.F12:
                        break;
                    case Keys.F13:
                        break;
                    case Keys.F14:
                        break;
                    case Keys.F15:
                        break;
                    case Keys.F16:
                        break;
                    case Keys.F17:
                        break;
                    case Keys.F18:
                        break;
                    case Keys.F19:
                        break;
                    case Keys.F20:
                        break;
                    case Keys.F21:
                        break;
                    case Keys.F22:
                        break;
                    case Keys.F23:
                        break;
                    case Keys.F24:
                        break;
                    case Keys.NumLock:
                        break;
                    case Keys.Scroll:
                        break;
                    case Keys.LShiftKey:
                        break;
                    case Keys.RShiftKey:
                        break;
                    case Keys.LControlKey:
                        break;
                    case Keys.RControlKey:
                        break;
                    case Keys.LMenu:
                        break;
                    case Keys.RMenu:
                        break;
                    case Keys.BrowserBack:
                        break;
                    case Keys.BrowserForward:
                        break;
                    case Keys.BrowserRefresh:
                        break;
                    case Keys.BrowserStop:
                        break;
                    case Keys.BrowserSearch:
                        break;
                    case Keys.BrowserFavorites:
                        break;
                    case Keys.BrowserHome:
                        break;
                    case Keys.VolumeMute:
                        break;
                    case Keys.VolumeDown:
                        break;
                    case Keys.VolumeUp:
                        break;
                    case Keys.MediaNextTrack:
                        break;
                    case Keys.MediaPreviousTrack:
                        break;
                    case Keys.MediaStop:
                        break;
                    case Keys.MediaPlayPause:
                        break;
                    case Keys.LaunchMail:
                        break;
                    case Keys.SelectMedia:
                        break;
                    case Keys.LaunchApplication1:
                        break;
                    case Keys.LaunchApplication2:
                        break;
                    case Keys.OemSemicolon:
                        break;
                    case Keys.ProcessKey:
                        break;
                    case Keys.Packet:
                        break;
                    case Keys.Attn:
                        break;
                    case Keys.Crsel:
                        break;
                    case Keys.Exsel:
                        break;
                    case Keys.EraseEof:
                        break;
                    case Keys.Play:
                        break;
                    case Keys.Zoom:
                        break;
                    case Keys.NoName:
                        break;
                    case Keys.Pa1:
                        break;
                    case Keys.OemClear:
                        break;
                    case Keys.Shift:
                        break;
                    case Keys.Control:
                        break;
                    case Keys.Alt:
                        break;
                    default:
                        break;
                }
            }


        }

        private void refreshToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            refreshListView();
        }

        private void toolStripTextBox_path_Click(object sender, EventArgs e)
        {

        }

        private void listView_files_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listView_files_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (files.Length != 0)
            {
                if (IsTransfer)
                {
                    MessageBox.Show("Please Wait For Last Proccess And Then Try Agin...", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                List<string> fdList = new List<string>();
                foreach (string item in files)
                {
                    fdList.Add(item);
                }
                TransferForm transferform = new TransferForm(TransferType.Uploading, fdList, currentPath, device);
                IsTransfer = true;
                transferform.Show();

                transferform.FormClosed += Transferform_FormClosed;
            }
        }

        private void contextMenuStrip_ListView_Opened(object sender, EventArgs e)
        {
            if (fileOrDirectoryForCopyCut.Count==0)
            {
                pasteToolStripMenuItem.Enabled = false;
            }

            if (listView_files.SelectedItems.Count==0)
            {
                backupToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                propertiesToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
            }
        }

        private void backgroundWorker_ProccessSize_DoWork(object sender, DoWorkEventArgs e)
        {
            if (fm.ListAdbFiles.Count>50 || !IsShowSize)
            {
                return;
            }
            foreach (ADBFile tmpfile in fm.ListAdbFiles)
            {
                tmpfile.GetLengthDouble();
            }
        }

        private void button_showSize_Click(object sender, EventArgs e)
        {
            if (IsShowSize)
            {
                button_showSize.BackgroundImage = AndroidManager_SHW.Properties.Resources.toggleOff;
                IsShowSize = false;
                label_size.Text = "";
            }
            else
            {
                button_showSize.BackgroundImage = AndroidManager_SHW.Properties.Resources.toggleOn;
                IsShowSize = true;
            }
        }
    }
}
