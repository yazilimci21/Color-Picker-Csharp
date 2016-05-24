using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ColorPicked
{
    public partial class ColorList : Form
    {
        public ColorList()
        {
            InitializeComponent();
        }

        string oldgroupName = "";
        string oldcolorName = "";

        ArrayList Colors = new ArrayList();
        string SelectedGroupName;
        bool IsChanged = false;

        private void ColorList_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Lister.MyList.getGroupCount(); i++)
            {
                GroupListView.Items.Add(Lister.MyList.getGroupName(i));
            }
            if (Lister.MyList.getGroupCount() > 0)
            {
                SelectedGroupName = Lister.MyList.getGroupName(0);
                getColors(SelectedGroupName);
                this.Text = "ColorList - " + SelectedGroupName;
            }
        }
        ImageList imglist;

        private int getColors(string GroupName)
        {
            //try
            //{
                Colors = Lister.MyList.getGroup(GroupName);
                imglist = new ImageList();
                imglist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
                imglist.ImageSize = new System.Drawing.Size(24, 20);
                imglist.TransparentColor = System.Drawing.Color.Transparent;

                Bitmap bmp;
                ColorListView.SmallImageList = imglist;

                for (int i = 0; i < Colors.Count; i++)
                {
                    ListEra color = (ListEra)Colors[i];

                    bmp = new Bitmap(32, 32);
                    try
                    {
                        string[] rgb = color.Rgb.Split(',');
                        int r = Convert.ToInt32(rgb[0]), g = Convert.ToInt32(rgb[1]), b = Convert.ToInt32(rgb[2]);
                        Graphics grp = Graphics.FromImage(bmp);
                        grp.Clear(Color.FromArgb(r, g, b));
                    }
                    catch { }
                    imglist.Images.Add(bmp);
                    ColorListView.Items.Add(color.ColorName);
                    ColorListView.Items[i].ImageIndex = i;
                    ColorListView.Items[i].SubItems.Add(color.Html);
                    ColorListView.Items[i].SubItems.Add(color.Rgb);
                }
                return 1;
            //}
            //catch { }
            //return 0;
        }

        private void GroupListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GroupListView.SelectedItems.Count > 0)
            {
                ColorListView.Items.Clear();
                SelectedGroupName = Lister.MyList.getGroupName(Lister.MyList.getGroupInt(GroupListView.SelectedItems[0].Text));
                getColors(SelectedGroupName);
                this.Text = "ColorList - " + SelectedGroupName;
            }
        }

        private void deleteGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GroupListView.SelectedItems.Count > 0)
            {
                DialogResult = MessageBox.Show("Group Name:"+SelectedGroupName, "Do You Want to Delete The Group?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.OK)
                {
                    if (Lister.MyList.DelGroup(Lister.MyList.getGroupInt(GroupListView.SelectedItems[0].Text)) > 0)
                    {
                        IsChanged = true;
                        MessageBox.Show("Group was Deleted", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GroupListView.Items.Clear();
                        ColorListView.Items.Clear();
                        for (int i = 0; i < Lister.MyList.getGroupCount(); i++)
                        {
                            GroupListView.Items.Add(Lister.MyList.getGroupName(i));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Group was Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        this.Text = "ColorList";
                    }
                }
            }
        }

        private void deleteColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ColorListView.SelectedItems.Count > 0)
            {
                DialogResult = MessageBox.Show("Color Name:" + ColorListView.SelectedItems[0].Text, "Do You Want to Delete Color?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.OK)
                {
                    if (Lister.MyList.DelColor(SelectedGroupName, ColorListView.SelectedItems[0].Text) > 0)
                    {
                        MessageBox.Show("Color was Deleted", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ColorListView.Items.Clear();
                        getColors(SelectedGroupName);
                        IsChanged = true;
                    }
                    else
                    {
                        MessageBox.Show("Color was Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddButton.Text == "Replace Color")
            {
                if (ColorName.Text.Length > 0 & Html.Text.Length > 0 & Rgb.Text.Length > 0)
                {
                    if (Lister.MyList.ReplaceColorName(SelectedGroupName, "", oldcolorName, ColorName.Text, Html.Text, Rgb.Text) > 0)
                    {
                        MessageBox.Show("Color was Replace", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ColorListView.Items.Clear();
                        getColors(SelectedGroupName);
                        IsChanged = true;
                        AddButton.Text = "Add Color";
                        ColorName.Text = "";
                        Html.Text = "";
                        Rgb.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Color was Not Replace\nThis colour name is present in your list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            else
            {
                if (ColorName.Text.Length > 0 & Html.Text.Length > 0 & Rgb.Text.Length > 0)
                {
                    if (Lister.MyList.AddColor(SelectedGroupName, ColorName.Text, Html.Text, Rgb.Text) > 0)
                    {
                        MessageBox.Show("Color was Added", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ColorListView.Items.Clear();
                        getColors(SelectedGroupName);
                        IsChanged = true;
                        ColorName.Text = "";
                        Html.Text = "";
                        Rgb.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Color was Not Added\nThis colour name is present in your list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        private void ColorList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsChanged)
            {
                DialogResult = MessageBox.Show("Do You Want to Save?", "Color Settings is Changed!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.OK)
                {
                    Picked.picker.IsChanged = true;
                }
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (IsChanged)
            {
                Picked.picker.IsChanged = true;
                IsChanged = false;
            }
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getGroupNameForm group = new getGroupNameForm();
            if (group.ShowDialog() == DialogResult.OK)
            {
                if (Lister.MyList.AddGroup(group.getGroupName) > 0)
                {
                    IsChanged = true;
                    GroupListView.Items.Clear();
                    for (int i = 0; i < Lister.MyList.getGroupCount(); i++)
                    {
                        GroupListView.Items.Add(Lister.MyList.getGroupName(i));
                    }
                }
                else
                {
                    MessageBox.Show("Group was Not Added\nThis group name is present in your list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void GroupAddButton_Click(object sender, EventArgs e)
        {
            if (GroupAddButton.Text == "Replace Group")
            {
                if (Lister.MyList.ReplaceGroupName(Lister.MyList.getGroupInt(oldgroupName), AddGroupStr.Text) > 0)
                {
                    MessageBox.Show("Group was Replace", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IsChanged = true;
                    GroupListView.Items.Clear();
                    for (int i = 0; i < Lister.MyList.getGroupCount(); i++)
                    {
                        GroupListView.Items.Add(Lister.MyList.getGroupName(i));
                    }
                    GroupAddButton.Text = "Add Group";
                }
                else
                {
                    MessageBox.Show("Group was Not Replace\nThis group name is present in your list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                if (Lister.MyList.AddGroup(AddGroupStr.Text) > 0)
                {
                    IsChanged = true;
                    MessageBox.Show("Group was Added", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GroupListView.Items.Clear();
                    for (int i = 0; i < Lister.MyList.getGroupCount(); i++)
                    {
                        GroupListView.Items.Add(Lister.MyList.getGroupName(i));
                    }
                }
                else
                {
                    MessageBox.Show("Group was Not Added\nThis group name is present in your list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            AddGroupStr.Text = "";
        }

        private void editColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ColorListView.SelectedItems.Count > 0)
            {
                oldcolorName = ColorListView.SelectedItems[0].Text;
                ColorName.Text = oldcolorName;
                Html.Text = ColorListView.SelectedItems[0].SubItems[1].Text;
                Rgb.Text = ColorListView.SelectedItems[0].SubItems[2].Text;
                AddButton.Text = "Replace Color";
            }
        }

        private void editGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GroupListView.SelectedItems.Count > 0)
            {
                oldgroupName = GroupListView.SelectedItems[0].Text;
                AddGroupStr.Text = oldgroupName;
                GroupAddButton.Text = "Replace Group";
            }
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ColorListView.SelectedItems.Count > 0)
            {
                Clipboard.SetText(ColorListView.SelectedItems[0].SubItems[0].Text);
                MessageBox.Show(Clipboard.GetText(), "Your Clipboard");
            }
        }

        private void htmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ColorListView.SelectedItems.Count > 0)
            {
                Clipboard.SetText(ColorListView.SelectedItems[0].SubItems[1].Text);
                MessageBox.Show(Clipboard.GetText(), "Your Clipboard");
            }
        }

        private void rGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ColorListView.SelectedItems.Count > 0)
            {
                Clipboard.SetText(ColorListView.SelectedItems[0].SubItems[2].Text);
                MessageBox.Show(Clipboard.GetText(), "Your Clipboard");
            }
        }

        private void ColorListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control & e.KeyCode == Keys.N)
            {
                if (ColorListView.SelectedItems.Count > 0)
                {
                    Clipboard.SetText(ColorListView.SelectedItems[0].SubItems[0].Text);
                }
            }
            if (e.Control & e.KeyCode == Keys.H)
            {
                if (ColorListView.SelectedItems.Count > 0)
                {
                    Clipboard.SetText(ColorListView.SelectedItems[0].SubItems[1].Text);
                }
            }
            if (e.Control & e.KeyCode == Keys.R)
            {
                if (ColorListView.SelectedItems.Count > 0)
                {
                    Clipboard.SetText(ColorListView.SelectedItems[0].SubItems[2].Text);
                }
            }
            if (e.Control & (e.KeyCode == Keys.R | e.KeyCode == Keys.N |e.KeyCode == Keys.H))
            {
                MessageBox.Show(Clipboard.GetText(), "Your Clipboard");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do You Want to Reset The Colors?", "Heyy!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.OK)
            {
                GroupListView.Items.Clear();
                ColorListView.Items.Clear();
                Lister.MyList.getDefaultSettings();
                IsChanged = true;
                SelectedGroupName = "DefaultColors";
                for (int i = 0; i < Lister.MyList.getGroupCount(); i++)
                {
                    GroupListView.Items.Add(Lister.MyList.getGroupName(i));
                }
                this.Text = "ColorList - " + SelectedGroupName;
            }
        }

        private void Rgb_TextChanged(object sender, EventArgs e)
        {
            string[] color = Rgb.Text.Split(',');
            try
            {
                ColorViewTable1.BackColor = Color.FromArgb(Convert.ToInt32(color[0]), Convert.ToInt32(color[1]), Convert.ToInt32(color[2]));
                if(Html.Text.Length == 0) Html.Text = ColorTranslator.ToHtml(ColorViewTable1.BackColor);
                if (ColorName.Text.Length == 0) ColorName.Text = ColorViewTable1.BackColor.Name;
            }
            catch
            {
 
            }
        }

        private void Html_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ColorViewTable1.BackColor = ColorTranslator.FromHtml(Html.Text);
                if (Rgb.Text.Length == 0) Rgb.Text = ColorViewTable1.BackColor.R + "," + ColorViewTable1.BackColor.G + "," + ColorViewTable1.BackColor.B;
                if (ColorName.Text.Length == 0) ColorName.Text = ColorViewTable1.BackColor.Name;
            }
            catch
            {

            }
        }

        private void ColorName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ColorViewTable1.BackColor = Color.FromName(ColorName.Text);
                if (Rgb.Text.Length == 0) Rgb.Text = ColorViewTable1.BackColor.R + "," + ColorViewTable1.BackColor.G + "," + ColorViewTable1.BackColor.B;
                if (Html.Text.Length == 0) Html.Text = ColorTranslator.ToHtml(ColorViewTable1.BackColor);
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=UF8V46TH73MJW");
        }
    }
}
