using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ColorPicked
{
    public partial class getImage : Form
    {
        public getImage(Bitmap bmp)
        {
            InitializeComponent();
            this.Resim.Image = bmp;
            this.Size = new Size(bmp.Width+7, bmp.Height+35);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Saver.ShowDialog() == DialogResult.OK)
            {
                Resim.Image.Save(Saver.FileName);
            }
        }
    }
}