namespace ColorPicked
{
    partial class AddColorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddColorForm));
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.AddColorGroupBox = new System.Windows.Forms.GroupBox();
            this.ColorNameTxt = new System.Windows.Forms.Label();
            this.ColorName = new System.Windows.Forms.TextBox();
            this.AddColorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(136, 79);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(55, 79);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 9;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // AddColorGroupBox
            // 
            this.AddColorGroupBox.Controls.Add(this.ColorNameTxt);
            this.AddColorGroupBox.Controls.Add(this.ColorName);
            this.AddColorGroupBox.Location = new System.Drawing.Point(2, 2);
            this.AddColorGroupBox.Name = "AddColorGroupBox";
            this.AddColorGroupBox.Size = new System.Drawing.Size(365, 79);
            this.AddColorGroupBox.TabIndex = 8;
            this.AddColorGroupBox.TabStop = false;
            this.AddColorGroupBox.Text = "Add Color";
            // 
            // ColorNameTxt
            // 
            this.ColorNameTxt.AutoSize = true;
            this.ColorNameTxt.Location = new System.Drawing.Point(9, 28);
            this.ColorNameTxt.Name = "ColorNameTxt";
            this.ColorNameTxt.Size = new System.Drawing.Size(62, 13);
            this.ColorNameTxt.TabIndex = 1;
            this.ColorNameTxt.Text = "Color Name";
            // 
            // ColorName
            // 
            this.ColorName.Location = new System.Drawing.Point(9, 44);
            this.ColorName.Name = "ColorName";
            this.ColorName.Size = new System.Drawing.Size(200, 20);
            this.ColorName.TabIndex = 0;
            this.ColorName.TextChanged += new System.EventHandler(this.ColorName_TextChanged);
            // 
            // AddColorForm
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(219, 108);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.AddColorGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddColorForm";
            this.Text = "Add Color";
            this.AddColorGroupBox.ResumeLayout(false);
            this.AddColorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.GroupBox AddColorGroupBox;
        private System.Windows.Forms.Label ColorNameTxt;
        private System.Windows.Forms.TextBox ColorName;
    }
}