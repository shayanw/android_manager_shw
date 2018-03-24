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
using ADBFileProccessDLL;
using System.Net;
using System.Threading;

namespace AndroidManager_SHW
{
    public partial class FileManagerForm : Form
    {
        Thread MyThread = new Thread(new ThreadStart(ExternalMethod.test));
        DeviceData device;
        FileManager fm;
        string currentPath = "storage";
        ListViewItem ListViewSI = new ListViewItem();
        string tmpSizeFile = "";
        int tmpCountFile = 0;
        List<string> fileOrDirectoryForCopyCut = new List<string>();
        //string backupPath = @"C:\Users\shayan\Desktop\backup";
        string backupPath = "";
        List<ListViewItem> lastSelectedItem = new List<ListViewItem>();

        Stack<string> BackwardPath = new Stack<string>();
        Stack<string> ForwardPath = new Stack<string>();
        bool IsTransfer = false;
        public FileManagerForm(DeviceData currentDevice)
        {
            InitializeComponent();
            patchFixImage();
            device = currentDevice;
            fm = new FileManager(device);
            backupPath = fm.MainPathSystem(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }

        private void FileManagerForm_Load(object sender, EventArgs e)
        {
            refreshListView();
            SetTree();
        }

        void refreshListView()
        {
            ListView.ListViewItemCollection last = listView_files.Items;
            try
            {
                listView_files.Items.Clear();
                foreach (ADBFile item in fm.getDirectoryAndFiles(currentPath))
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Name = item.FullName;
                    lvi.Text = item.Name.nickName();

                    if (item.Tag == "d" || item.Tag == "l")
                    {
                        lvi.ImageIndex = 1;
                        lvi.Tag = item.Tag;
                    }
                    else
                    {
                        switch (item.Extension)
                        {
                            case ".aac":
                            case ".flac":
                            case ".mp3":
                            case ".MP3":
                            case ".ogg":
                                lvi.ImageIndex = 3;
                                break;
                            case ".exe":
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
                            case ".MKV":
                            case ".MP4":
                                lvi.ImageIndex = 7;
                                break;
                            case ".pdf":
                                lvi.ImageIndex = 8;
                                break;
                            case ".txt":
                                lvi.ImageIndex = 9;
                                break;
                            case ".jpg":
                            case ".JPG":
                            case ".PNG":
                            case ".png":
                            case ".img":
                                lvi.ImageIndex = 10;
                                break;
                            default:
                                lvi.ImageIndex = 2;
                                break;
                        }
                        lvi.Tag = 'F';

                    }
                    listView_files.Items.Add(lvi);


                }
                toolStripTextBox_path.Text = currentPath;
            }
            catch (Exception)
            {
                listView_files.Items.AddRange(last);
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
                    try
                    {
                        //System.Diagnostics.Process.Start(listView_files.SelectedItems[0].Name);
                    }
                    catch (Exception)
                    {


                    }
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




        #region CompeleteMethod

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

        private void treeView_dir_AfterSelect(object sender, TreeViewEventArgs e)
        {
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

        private void patchFixImage()
        {
            toolStripButton_collapseExpand.Image = AndroidManager_SHW.Properties.Resources.collapse;
            toolStripButton_forwardDirectory.Image = AndroidManager_SHW.Properties.Resources.Next;
            toolStripButton_ParentDirectory.Image = AndroidManager_SHW.Properties.Resources.Back;
            toolStripButton_goPath.Image = AndroidManager_SHW.Properties.Resources.Go;
        }

        private void toolStripButton_goPath_Click(object sender, EventArgs e)
        {
            currentPath = toolStripTextBox_path.Text;
            refreshListView();
        }

        private void listView_files_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_files.SelectedItems.Count > 0)
            {
                ListViewSI = listView_files.SelectedItems[0];
                setLabelFile();
                //label_size.Text = "Size: •••";
                //label_name.Text = "Name: " + ListViewSI.Name.returnFile(device).Name.nickName();
                //label_countFiles.Text = "Count: " + "";
                //if (listView_files.SelectedItems[0].Tag.ToString() == "d" || listView_files.SelectedItems[0].Tag.ToString() == "l")
                //{
                //    label_type.Text = "Type: Directory";
                //}
                //else
                //{
                //    label_type.Text = "Type: " + listView_files.SelectedItems[0].Name.returnFile(device).Extension;
                //}

                //if (backgroundWorker_getSize.IsBusy)
                //{
                //    backgroundWorker_getSize.CancelAsync();
                //}
                //if (!backgroundWorker_getSize.IsBusy)
                //{
                //    backgroundWorker_getSize.RunWorkerAsync();
                //}



            }
        }

        private void setLabelFile()
        {
            ADBFile f1 = ListViewSI.Name.returnFile(device);

            label_size.Text = "Size: •••";
            label_countFiles.Text = "Count: •••";
            label_name.Text = "Name: " + f1.Name.nickName();
            label_countFiles.Visible = false;

            if (backgroundWorker_getCountFiles.IsBusy)
            {
                backgroundWorker_getCountFiles.CancelAsync();
            }
            if (backgroundWorker_getSize.IsBusy)
            {
                backgroundWorker_getSize.CancelAsync();
            }


            if (ListViewSI.Tag.ToString() == "d" || ListViewSI.Tag.ToString() == "l")
            {
                label_type.Text = "Type: Directory";

                label_countFiles.Visible = true;

                if (!backgroundWorker_getCountFiles.IsBusy)
                {
                    backgroundWorker_getCountFiles.RunWorkerAsync();
                }
            }
            else
            {
                label_type.Text = "Type: " + ListViewSI.Name.returnFile(device).Extension;
            }

            if (!backgroundWorker_getSize.IsBusy)
            {
                backgroundWorker_getSize.RunWorkerAsync();
            }
        }

        private void backgroundWorker_getSize_DoWork(object sender, DoWorkEventArgs e)
        {
            tmpSizeFile = "Size: " + ListViewSI.Name.returnSizeFile(device);
        }

        private void backgroundWorker_getSize_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label_size.Text = tmpSizeFile;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView_files.SelectedItems.Count > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("are you sure Delete " + listView_files.SelectedItems.Count + " File & Directory ?", "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int errorCounter = 0;
                    foreach (ListViewItem item in listView_files.SelectedItems)
                    {
                        if (!fm.DeleteDirectoryAndFiles(item.Name))
                        {
                            errorCounter++;
                        }
                    }
                    MessageBox.Show("you have " + errorCounter + " Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshListView();
                }

            }

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView_files.SelectedItems.Count > 0)
            {
                fileOrDirectoryForCopyCut.Clear();
                foreach (ListViewItem item in listView_files.SelectedItems)
                {
                    fileOrDirectoryForCopyCut.Add(item.Name);
                }
            }
        }



        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //if (listView_files.SelectedItems.Count > 0)
            //{
            //    if (backgroundWorker_backup.IsBusy)
            //    {
            //        if (DialogResult.No == MessageBox.Show("Do You Want To Cancel Last Backup Proccess?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            //        {
            //            return;
            //        }
            //        backgroundWorker_backup.CancelAsync();

            //    }
            //    progressBar_transfer.Maximum = listView_files.SelectedItems.Count;
            //    panel_rightSideBarProgress.Visible = true;
            //    lastSelectedItem.Clear();
            //    foreach (ListViewItem item in listView_files.SelectedItems)
            //    {
            //        lastSelectedItem.Add(item);
            //    }
            //    backgroundWorker_backup.RunWorkerAsync();
            //}

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

        private void forCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (fileOrDirectoryForCopyCut.Count != 0)
            //{
            //    int errorCounter = 0;
            //    foreach (string item in fileOrDirectoryForCopyCut)
            //    {
            //        if (fm.PasteCopy(new ADBFile(device, item.fixBracketInTerminal()), currentPath))
            //        {
            //            errorCounter++;
            //        }
            //    }
            //    MessageBox.Show("you have " + errorCounter + " Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    refreshListView();
            //    fileOrDirectoryForCopyCut.Clear();
            //}

            if (fileOrDirectoryForCopyCut.Count != 0)
            {
                if (IsTransfer)
                {
                    MessageBox.Show("Please Wait For Last Proccess And Then Try Agin...", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                List<ADBFile> listFilesTmp = new List<ADBFile>();
                foreach (string item in fileOrDirectoryForCopyCut)
                {
                    listFilesTmp.Add(new ADBFile(device, item.fixBracketInTerminal()));
                }
                TransferForm transferform = new TransferForm(TransferType.Copying, listFilesTmp, currentPath, device);
                IsTransfer = true;
                transferform.Show();

                transferform.FormClosed += Transferform_FormClosed;
                fileOrDirectoryForCopyCut.Clear();
            }
        }

        private void forCutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (fileOrDirectoryForCopyCut.Count != 0)
            //{
            //    int errorCounter = 0;
            //    foreach (string item in fileOrDirectoryForCopyCut)
            //    {
            //        if (fm.PasteCut(new ADBFile(device, item.fixBracketInTerminal()), currentPath))
            //        {
            //            fm.DeleteDirectoryAndFiles(item.fixBracketInTerminal());
            //            errorCounter++;
            //        }
            //    }

            //    MessageBox.Show("you have " + errorCounter + " Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    refreshListView();
            //    fileOrDirectoryForCopyCut.Clear();
            //}
            if (fileOrDirectoryForCopyCut.Count != 0)
            {
                if (IsTransfer)
                {
                    MessageBox.Show("Please Wait For Last Proccess And Then Try Agin...", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                List<ADBFile> listFilesTmp = new List<ADBFile>();
                foreach (string item in fileOrDirectoryForCopyCut)
                {
                    listFilesTmp.Add(new ADBFile(device, item.fixBracketInTerminal()));
                }
                TransferForm transferform = new TransferForm(TransferType.Cutting, listFilesTmp, currentPath, device);
                IsTransfer = true;
                transferform.Show();
                transferform.FormClosed += Transferform_FormClosed;
                fileOrDirectoryForCopyCut.Clear();
            }
        }

        private void Transferform_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsTransfer = false;
            refreshListView();
        }



        private void backgroundWorker_backup_DoWork(object sender, DoWorkEventArgs e)
        {

            int[] reportObj;
            int errorCounter = 0;
            int itemChecked = 0;
            foreach (ListViewItem item in lastSelectedItem)
            {
                if (!fm.BackupToSystem(new ADBFile(device, item.Name.fixBracketInTerminal()), backupPath))
                {
                    errorCounter++;
                }
                itemChecked++;
                reportObj = new int[] { errorCounter, itemChecked };
                backgroundWorker_backup.ReportProgress(0, reportObj);
            }

        }

        private void backgroundWorker_backup_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            panel_rightSideBarProgress.Visible = false;
            progressBar_transfer.Value = 0;
            int errorCounter = 0;
            MessageBox.Show("you have " + errorCounter + " Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start(backupPath);
        }

        private void backgroundWorker_backup_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar_transfer.Value = ((int[])e.UserState)[1];
        }

        private void backgroundWorker_getCountFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            tmpCountFile = fm.CountFileAndDirectory(ListViewSI.Name.returnFile(device));
        }

        private void backgroundWorker_getCountFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label_countFiles.Text = "Count: " + tmpCountFile;
        }
    }
}
