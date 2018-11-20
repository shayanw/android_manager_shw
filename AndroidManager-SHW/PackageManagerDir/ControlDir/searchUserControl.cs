using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidManager_SHW.PackageManagerDir.ControlDir
{
    public partial class searchUserControl : UserControl
    {
        public event EventHandler TextChangedEvent;

        string DefaultText="Search Package...";
        bool isDefault;
        public string DefaultTextProp { get { return DefaultText; } set { DefaultText = value; } }
        public string SearchTextProp { get; set; }

        

        public searchUserControl()
        {
            InitializeComponent();
            EnterDefaultState();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            if (!isDefault)
            {
                TextChangedEvent(this, e);
            }
        }

        private void TextBox_search_Enter(object sender, EventArgs e)
        {
            if (isDefault)
            {
                LeaveDefaultState();
            }
        }
        private void TextBox_search_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_search.Text))
            {
                EnterDefaultState();
            }
        }

        private void EnterDefaultState()
        {
            isDefault = true;
            textBox_search.Text = DefaultTextProp;
            textBox_search.ForeColor = Color.Gray;
        }
        private void LeaveDefaultState()
        {
            isDefault = false;
            textBox_search.Text = "";
            textBox_search.ForeColor = Color.Black;
        }
    }
}
