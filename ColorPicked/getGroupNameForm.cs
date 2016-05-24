using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ColorPicked
{
    public partial class getGroupNameForm : Form
    {
        public getGroupNameForm()
        {
            InitializeComponent();
        }

        private string _GroupName;

        public string getGroupName
        {
            get
            {
                return _GroupName;
            }
        }

        private void GroupNamea_TextChanged(object sender, EventArgs e)
        {
            _GroupName = GroupName.Text;
        }
    }
}