namespace ColorPicked
{
    partial class ColorList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorList));
            this.ColorListView = new System.Windows.Forms.ListView();
            this._ColorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._Html = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._RGB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColorListViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupListView = new System.Windows.Forms.ListView();
            this.GroupName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupListViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorName = new System.Windows.Forms.TextBox();
            this.ColorNameTxt = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.HtmlTxt = new System.Windows.Forms.Label();
            this.Html = new System.Windows.Forms.TextBox();
            this.RgbTxt = new System.Windows.Forms.Label();
            this.Rgb = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddGroupStr = new System.Windows.Forms.TextBox();
            this.GroupAddButton = new System.Windows.Forms.Button();
            this.GroupNameTxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ColorViewTable1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ColorListViewMenu.SuspendLayout();
            this.GroupListViewMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorViewTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorListView
            // 
            this.ColorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._ColorName,
            this._Html,
            this._RGB});
            this.ColorListView.ContextMenuStrip = this.ColorListViewMenu;
            this.ColorListView.FullRowSelect = true;
            this.ColorListView.Location = new System.Drawing.Point(208, 47);
            this.ColorListView.MultiSelect = false;
            this.ColorListView.Name = "ColorListView";
            this.ColorListView.Size = new System.Drawing.Size(338, 271);
            this.ColorListView.TabIndex = 1;
            this.ColorListView.UseCompatibleStateImageBehavior = false;
            this.ColorListView.View = System.Windows.Forms.View.Details;
            this.ColorListView.DoubleClick += new System.EventHandler(this.editColorToolStripMenuItem_Click);
            this.ColorListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColorListView_KeyDown);
            // 
            // _ColorName
            // 
            this._ColorName.Text = "Color Name";
            this._ColorName.Width = 119;
            // 
            // _Html
            // 
            this._Html.Text = "Html";
            this._Html.Width = 97;
            // 
            // _RGB
            // 
            this._RGB.Text = "RGB";
            this._RGB.Width = 111;
            // 
            // ColorListViewMenu
            // 
            this.ColorListViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editColorToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.deleteColorToolStripMenuItem});
            this.ColorListViewMenu.Name = "GroupListViewMenu";
            this.ColorListViewMenu.ShowImageMargin = false;
            this.ColorListViewMenu.Size = new System.Drawing.Size(115, 70);
            // 
            // editColorToolStripMenuItem
            // 
            this.editColorToolStripMenuItem.Name = "editColorToolStripMenuItem";
            this.editColorToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.editColorToolStripMenuItem.Text = "Edit Color";
            this.editColorToolStripMenuItem.Click += new System.EventHandler(this.editColorToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.htmlToolStripMenuItem,
            this.rGBToolStripMenuItem});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nameToolStripMenuItem.Text = "Name(Ctrl+N)";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // htmlToolStripMenuItem
            // 
            this.htmlToolStripMenuItem.Name = "htmlToolStripMenuItem";
            this.htmlToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.htmlToolStripMenuItem.Text = "Html(Ctrl+H)";
            this.htmlToolStripMenuItem.Click += new System.EventHandler(this.htmlToolStripMenuItem_Click);
            // 
            // rGBToolStripMenuItem
            // 
            this.rGBToolStripMenuItem.Name = "rGBToolStripMenuItem";
            this.rGBToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.rGBToolStripMenuItem.Text = "RGB(Ctrl+R)";
            this.rGBToolStripMenuItem.Click += new System.EventHandler(this.rGBToolStripMenuItem_Click);
            // 
            // deleteColorToolStripMenuItem
            // 
            this.deleteColorToolStripMenuItem.Name = "deleteColorToolStripMenuItem";
            this.deleteColorToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.deleteColorToolStripMenuItem.Text = "Delete Color";
            this.deleteColorToolStripMenuItem.Click += new System.EventHandler(this.deleteColorToolStripMenuItem_Click);
            // 
            // GroupListView
            // 
            this.GroupListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GroupName});
            this.GroupListView.ContextMenuStrip = this.GroupListViewMenu;
            this.GroupListView.FullRowSelect = true;
            this.GroupListView.Location = new System.Drawing.Point(-2, 47);
            this.GroupListView.MultiSelect = false;
            this.GroupListView.Name = "GroupListView";
            this.GroupListView.Size = new System.Drawing.Size(209, 271);
            this.GroupListView.TabIndex = 2;
            this.GroupListView.UseCompatibleStateImageBehavior = false;
            this.GroupListView.View = System.Windows.Forms.View.Details;
            this.GroupListView.SelectedIndexChanged += new System.EventHandler(this.GroupListView_SelectedIndexChanged);
            this.GroupListView.DoubleClick += new System.EventHandler(this.editGroupToolStripMenuItem_Click);
            // 
            // GroupName
            // 
            this.GroupName.Text = "Group Name";
            this.GroupName.Width = 196;
            // 
            // GroupListViewMenu
            // 
            this.GroupListViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editGroupToolStripMenuItem,
            this.addGroupToolStripMenuItem,
            this.deleteGroupToolStripMenuItem});
            this.GroupListViewMenu.Name = "GroupListViewMenu";
            this.GroupListViewMenu.ShowImageMargin = false;
            this.GroupListViewMenu.Size = new System.Drawing.Size(119, 70);
            // 
            // editGroupToolStripMenuItem
            // 
            this.editGroupToolStripMenuItem.Name = "editGroupToolStripMenuItem";
            this.editGroupToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.editGroupToolStripMenuItem.Text = "Edit Group";
            this.editGroupToolStripMenuItem.Click += new System.EventHandler(this.editGroupToolStripMenuItem_Click);
            // 
            // addGroupToolStripMenuItem
            // 
            this.addGroupToolStripMenuItem.Name = "addGroupToolStripMenuItem";
            this.addGroupToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.addGroupToolStripMenuItem.Text = "Add Group";
            this.addGroupToolStripMenuItem.Click += new System.EventHandler(this.addGroupToolStripMenuItem_Click);
            // 
            // deleteGroupToolStripMenuItem
            // 
            this.deleteGroupToolStripMenuItem.Name = "deleteGroupToolStripMenuItem";
            this.deleteGroupToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.deleteGroupToolStripMenuItem.Text = "Delete Group";
            this.deleteGroupToolStripMenuItem.Click += new System.EventHandler(this.deleteGroupToolStripMenuItem_Click);
            // 
            // ColorName
            // 
            this.ColorName.Location = new System.Drawing.Point(7, 337);
            this.ColorName.Name = "ColorName";
            this.ColorName.Size = new System.Drawing.Size(100, 20);
            this.ColorName.TabIndex = 0;
            this.ColorName.TextChanged += new System.EventHandler(this.ColorName_TextChanged);
            // 
            // ColorNameTxt
            // 
            this.ColorNameTxt.AutoSize = true;
            this.ColorNameTxt.Location = new System.Drawing.Point(7, 321);
            this.ColorNameTxt.Name = "ColorNameTxt";
            this.ColorNameTxt.Size = new System.Drawing.Size(62, 13);
            this.ColorNameTxt.TabIndex = 1;
            this.ColorNameTxt.Text = "Color Name";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(369, 335);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add Color";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // HtmlTxt
            // 
            this.HtmlTxt.AutoSize = true;
            this.HtmlTxt.Location = new System.Drawing.Point(112, 321);
            this.HtmlTxt.Name = "HtmlTxt";
            this.HtmlTxt.Size = new System.Drawing.Size(28, 13);
            this.HtmlTxt.TabIndex = 4;
            this.HtmlTxt.Text = "Html";
            // 
            // Html
            // 
            this.Html.Location = new System.Drawing.Point(112, 337);
            this.Html.Name = "Html";
            this.Html.Size = new System.Drawing.Size(100, 20);
            this.Html.TabIndex = 3;
            this.Html.TextChanged += new System.EventHandler(this.Html_TextChanged);
            // 
            // RgbTxt
            // 
            this.RgbTxt.AutoSize = true;
            this.RgbTxt.Location = new System.Drawing.Point(218, 321);
            this.RgbTxt.Name = "RgbTxt";
            this.RgbTxt.Size = new System.Drawing.Size(30, 13);
            this.RgbTxt.TabIndex = 6;
            this.RgbTxt.Text = "RGB";
            // 
            // Rgb
            // 
            this.Rgb.Location = new System.Drawing.Point(218, 337);
            this.Rgb.Name = "Rgb";
            this.Rgb.Size = new System.Drawing.Size(100, 20);
            this.Rgb.TabIndex = 5;
            this.Rgb.TextChanged += new System.EventHandler(this.Rgb_TextChanged);
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(311, 375);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 6;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(392, 375);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.AddGroupStr);
            this.groupBox1.Controls.Add(this.GroupAddButton);
            this.groupBox1.Controls.Add(this.GroupNameTxt);
            this.groupBox1.Location = new System.Drawing.Point(1, -16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 62);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Color";
            // 
            // AddGroupStr
            // 
            this.AddGroupStr.Location = new System.Drawing.Point(6, 32);
            this.AddGroupStr.Name = "AddGroupStr";
            this.AddGroupStr.Size = new System.Drawing.Size(129, 20);
            this.AddGroupStr.TabIndex = 0;
            // 
            // GroupAddButton
            // 
            this.GroupAddButton.Location = new System.Drawing.Point(138, 30);
            this.GroupAddButton.Name = "GroupAddButton";
            this.GroupAddButton.Size = new System.Drawing.Size(143, 23);
            this.GroupAddButton.TabIndex = 2;
            this.GroupAddButton.Text = "Add Group";
            this.GroupAddButton.UseVisualStyleBackColor = true;
            this.GroupAddButton.Click += new System.EventHandler(this.GroupAddButton_Click);
            // 
            // GroupNameTxt
            // 
            this.GroupNameTxt.AutoSize = true;
            this.GroupNameTxt.Location = new System.Drawing.Point(6, 16);
            this.GroupNameTxt.Name = "GroupNameTxt";
            this.GroupNameTxt.Size = new System.Drawing.Size(67, 13);
            this.GroupNameTxt.TabIndex = 1;
            this.GroupNameTxt.Text = "Group Name";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(473, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColorViewTable1
            // 
            this.ColorViewTable1.Location = new System.Drawing.Point(324, 324);
            this.ColorViewTable1.Name = "ColorViewTable1";
            this.ColorViewTable1.Size = new System.Drawing.Size(39, 33);
            this.ColorViewTable1.TabIndex = 10;
            this.ColorViewTable1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Bağış yap";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ColorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 398);
            this.Controls.Add(this.ColorName);
            this.Controls.Add(this.Html);
            this.Controls.Add(this.Rgb);
            this.Controls.Add(this.GroupListView);
            this.Controls.Add(this.ColorListView);
            this.Controls.Add(this.ColorViewTable1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RgbTxt);
            this.Controls.Add(this.ColorNameTxt);
            this.Controls.Add(this.HtmlTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(557, 436);
            this.MinimumSize = new System.Drawing.Size(557, 436);
            this.Name = "ColorList";
            this.Text = "ColorList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColorList_FormClosing);
            this.Load += new System.EventHandler(this.ColorList_Load);
            this.ColorListViewMenu.ResumeLayout(false);
            this.GroupListViewMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorViewTable1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ColorListView;
        private System.Windows.Forms.ColumnHeader _ColorName;
        private System.Windows.Forms.ColumnHeader _Html;
        private System.Windows.Forms.ColumnHeader _RGB;
        private System.Windows.Forms.ListView GroupListView;
        private System.Windows.Forms.ContextMenuStrip GroupListViewMenu;
        private System.Windows.Forms.ContextMenuStrip ColorListViewMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteColorToolStripMenuItem;
        private System.Windows.Forms.Label RgbTxt;
        private System.Windows.Forms.TextBox Rgb;
        private System.Windows.Forms.Label HtmlTxt;
        private System.Windows.Forms.TextBox Html;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label ColorNameTxt;
        private System.Windows.Forms.TextBox ColorName;
        private System.Windows.Forms.ColumnHeader GroupName;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ToolStripMenuItem addGroupToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GroupAddButton;
        private System.Windows.Forms.Label GroupNameTxt;
        private System.Windows.Forms.TextBox AddGroupStr;
        private System.Windows.Forms.ToolStripMenuItem editColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ColorViewTable1;
        private System.Windows.Forms.Button button2;
    }
}