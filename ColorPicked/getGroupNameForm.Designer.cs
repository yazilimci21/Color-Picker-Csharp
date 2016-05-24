namespace ColorPicked
{
    partial class getGroupNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(getGroupNameForm));
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.GroupNameTxt = new System.Windows.Forms.Label();
            this.GroupName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(139, 51);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(58, 51);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 15;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // GroupNameTxt
            // 
            this.GroupNameTxt.AutoSize = true;
            this.GroupNameTxt.Location = new System.Drawing.Point(12, 9);
            this.GroupNameTxt.Name = "GroupNameTxt";
            this.GroupNameTxt.Size = new System.Drawing.Size(67, 13);
            this.GroupNameTxt.TabIndex = 1;
            this.GroupNameTxt.Text = "Group Name";
            // 
            // GroupName
            // 
            this.GroupName.Location = new System.Drawing.Point(12, 25);
            this.GroupName.Name = "GroupName";
            this.GroupName.Size = new System.Drawing.Size(200, 20);
            this.GroupName.TabIndex = 0;
            this.GroupName.TextChanged += new System.EventHandler(this.GroupNamea_TextChanged);
            // 
            // getGroupNameForm
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(222, 81);
            this.Controls.Add(this.GroupNameTxt);
            this.Controls.Add(this.GroupName);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "getGroupNameForm";
            this.Text = "GroupName Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label GroupNameTxt;
        private System.Windows.Forms.TextBox GroupName;
    }
}