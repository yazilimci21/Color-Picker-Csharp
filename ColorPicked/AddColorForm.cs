using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ColorPicked
{
    public partial class AddColorForm : Form
    {
        public AddColorForm()
        {
            InitializeComponent();
        }
        private string _ColorName;

        public string getColorName
        {
            get
            {
                return _ColorName;
            }
        }

        private void ColorName_TextChanged(object sender, EventArgs e)
        {
            _ColorName = ColorName.Text;
        }
    }
}