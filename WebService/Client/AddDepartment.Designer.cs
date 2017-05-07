namespace Client
{
    partial class AddDepartment
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
            this.newdepname = new System.Windows.Forms.TextBox();
            this.addnewdep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newdepname
            // 
            this.newdepname.Location = new System.Drawing.Point(118, 62);
            this.newdepname.Name = "newdepname";
            this.newdepname.Size = new System.Drawing.Size(100, 20);
            this.newdepname.TabIndex = 0;
            // 
            // addnewdep
            // 
            this.addnewdep.Location = new System.Drawing.Point(127, 88);
            this.addnewdep.Name = "addnewdep";
            this.addnewdep.Size = new System.Drawing.Size(75, 23);
            this.addnewdep.TabIndex = 1;
            this.addnewdep.Text = "Add";
            this.addnewdep.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department name";
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 169);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addnewdep);
            this.Controls.Add(this.newdepname);
            this.Name = "AddDepartment";
            this.Text = "AddDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newdepname;
        private System.Windows.Forms.Button addnewdep;
        private System.Windows.Forms.Label label1;
    }
}