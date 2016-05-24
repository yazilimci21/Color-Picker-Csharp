using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ColorPicked
{
    public partial class Picked : Form
    {
        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        [DllImport("user32.dll")]
        static extern IntPtr LoadCursorFromFile(string lpFileName);
        [DllImport("user32.dll")]
        static extern bool SetSystemCursor(IntPtr hcur, uint id);
        private const uint OCR_NORMAL = 32512;
        static Cursor ColoredCursor;

        [DllImport("user32.dll")]
        static extern bool SetCursor(IntPtr hcur);
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        Lister MyColorList = new Lister();
        
        public bool IsChanged = false;

        public static Picked picker;

        public Picked()
        {
            InitializeComponent();
            picker = this;
        }

        bool bul = false;
        IntPtr defhdc;
        private int nowx, nowy;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = MousePosition.X, y = MousePosition.Y;
            int cx = label1.Location.X, cy = label1.Location.Y;
            int cw = label1.Size.Width, ch = label1.Size.Height;
            int tx = this.Location.X, ty=this.Location.Y+30;
            if ((x - tx) >= cx & (x - tx) <= (cx + cw) & (y - ty) >= cy & (y - ty) <= (cy + ch) & MouseButtons == MouseButtons.Left)
            {
                bul = true;
                Cursor cursor = Cursor;
                SetCursor(LoadCursorFromFile("Cursor.cur"));
                if(comboBox1.SelectedIndex == 0) label1.Image = Panes.nullpen;
            }
            if (MouseButtons == MouseButtons.Left)
            {
                if (bul)
                {
                    IntPtr hdc = GetDC(defhdc);
                    uint pixel = uint.MinValue;
                    if (defhdc == label1.Handle)
                    {
                        int curx = (MousePosition.X - this.Location.X) - label1.Location.X - 4;
                        int cury = (MousePosition.Y - this.Location.Y) - (label1.Location.Y + 23);
                        pixel = GetPixel(hdc, curx, cury);
                    }
                    else
                    {
                        pixel = GetPixel(hdc, MousePosition.X, MousePosition.Y);
                    }
                    nowx = MousePosition.X;
                    nowy = MousePosition.Y;
                    ReleaseDC(IntPtr.Zero, hdc);
                    Color color = ColorTranslator.FromOle((int)pixel);
                    ColorView.BackColor = color;
                    TxtRgb.Text = color.R + "," + color.G + "," + color.B;
                    TxtHtml.Text = ColorTranslator.ToHtml(color);
                    if (comboBox1.SelectedIndex == 0) label1.Image = Panes.nullpen;
                }
            }
            else
            {
                bul = false;
                SetCursor(System.Windows.Forms.Cursors.Default.Handle);
                if (comboBox1.SelectedIndex == 0) label1.Image = Panes.pen;
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkında hakkinda = new Hakkında();
            hakkinda.ShowDialog();
        }

        private void Picked_Load(object sender, EventArgs e)
        {
            defhdc = label1.Handle;
            label1.Image = Panes.pane1;
            label1.Size = new Size(Panes.pane1.Size.Width, Panes.pane1.Size.Height);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    defhdc = IntPtr.Zero;
                    label1.Image = null;
                    label1.Size = new Size(56, 39);
                    this.Size = new Size(283, 159);
                    this.Location = new Point((System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - 283), (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - 160));
                    break;
                case 1:
                    defhdc = label1.Handle;
                    label1.Text = "";
                    label1.Image = Panes.pane1;
                    label1.Size = new Size(Panes.pane1.Size.Width, Panes.pane1.Size.Height);
                    this.Location = new Point(((System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width / 2) - 142), ((System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height / 2) - 156));
                    this.Size = new Size(283, 313);
                    break;
                case 2:
                    defhdc = label1.Handle;
                    label1.Text = "";
                    label1.Image = Panes.pane2;
                    label1.Size = new Size(Panes.pane2.Size.Width, Panes.pane2.Size.Height);
                    this.Location = new Point(((System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width / 2)-250), ((System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height / 2)-200));
                    this.Size = new Size(550, 400);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.ShowImageMargin = false;
            for (int i = 0; i < Lister.MyList.getGroupCount(); i++)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = Lister.MyList.getGroupName(i);
                item.Click += new EventHandler(menuClick);
                menu.Items.Add(item);
            }
            menu.Show(button1, new Point(button1.Size.Width, 0));
        }

        private void menuClick(object sender, EventArgs e)
        {
            if(TxtHtml.Text.Length > 0 & TxtRgb.Text.Length >0)
            {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            AddColorForm colorForm = new AddColorForm();
            if (colorForm.ShowDialog() == DialogResult.OK)
            {
                if (Lister.MyList.AddColor(item.Text, colorForm.getColorName, TxtHtml.Text, TxtRgb.Text) > 0)
                {
                    IsChanged = true;
                    MessageBox.Show("Color was Added", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorList colorList = new ColorList();
            colorList.Show();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Picked_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsChanged)
            {
                DialogResult = MessageBox.Show("Do You Want to Save?", "Color Settings is Changed!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.OK)
                {
                    Lister.MyList.SaveAll();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Desktop")
            {
                getImage img = new getImage(Lister.MyList.getWindowImageFromPoint(nowx, nowy));
                img.ShowDialog();
            }
            else
            {
                MessageBox.Show("Desktop pane only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}