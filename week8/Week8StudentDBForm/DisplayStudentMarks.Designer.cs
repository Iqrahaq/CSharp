
namespace Week8StudentDBForm
{
    partial class DisplayStudentMarks
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_stuid = new System.Windows.Forms.TextBox();
            this.txt_stuname = new System.Windows.Forms.TextBox();
            this.lbx_info = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txt_stuid
            // 
            this.txt_stuid.Enabled = false;
            this.txt_stuid.Location = new System.Drawing.Point(130, 28);
            this.txt_stuid.Name = "txt_stuid";
            this.txt_stuid.Size = new System.Drawing.Size(100, 20);
            this.txt_stuid.TabIndex = 2;
            // 
            // txt_stuname
            // 
            this.txt_stuname.Enabled = false;
            this.txt_stuname.Location = new System.Drawing.Point(130, 85);
            this.txt_stuname.Name = "txt_stuname";
            this.txt_stuname.Size = new System.Drawing.Size(100, 20);
            this.txt_stuname.TabIndex = 3;
            // 
            // lbx_info
            // 
            this.lbx_info.FormattingEnabled = true;
            this.lbx_info.Location = new System.Drawing.Point(130, 142);
            this.lbx_info.Name = "lbx_info";
            this.lbx_info.Size = new System.Drawing.Size(515, 251);
            this.lbx_info.TabIndex = 4;
            // 
            // DisplayStudentMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbx_info);
            this.Controls.Add(this.txt_stuname);
            this.Controls.Add(this.txt_stuid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DisplayStudentMarks";
            this.Text = "DisplayStudentMarks";
            this.Load += new System.EventHandler(this.DisplayStudentMarks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_stuid;
        private System.Windows.Forms.TextBox txt_stuname;
        private System.Windows.Forms.ListBox lbx_info;
    }
}