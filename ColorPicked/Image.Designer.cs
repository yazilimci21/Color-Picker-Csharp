namespace ColorPicked
{
    partial class getImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(getImage));
            this.Resim = new System.Windows.Forms.PictureBox();
            this.SaveMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Saver = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).BeginInit();
            this.SaveMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Resim
            // 
            this.Resim.ContextMenuStrip = this.SaveMenu;
            this.Resim.Location = new System.Drawing.Point(-1, 0);
            this.Resim.Name = "Resim";
            this.Resim.Size = new System.Drawing.Size(446, 372);
            this.Resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Resim.TabIndex = 0;
            this.Resim.TabStop = false;
            // 
            // SaveMenu
            // 
            this.SaveMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.SaveMenu.Name = "SaveMenu";
            this.SaveMenu.Size = new System.Drawing.Size(110, 26);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Saver
            // 
            this.Saver.DefaultExt = "Img";
            this.Saver.FileName = "Img";
            this.Saver.Filter = "Jpg File|*.jpg|Png File|*.png|Bmp File|*.bmp";
            this.Saver.Title = "Color Picker Window Image";
            // 
            // getImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 372);
            this.Controls.Add(this.Resim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "getImage";
            this.Text = "Color Picker Image Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).EndInit();
            this.SaveMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Resim;
        private System.Windows.Forms.ContextMenuStrip SaveMenu;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog Saver;
    }
}