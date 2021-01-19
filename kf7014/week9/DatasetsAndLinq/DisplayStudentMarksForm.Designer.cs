
namespace DatasetsAndLinq
{
    partial class DisplayStudentMarksForm
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_info = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(168, 53);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(169, 20);
            this.txt_id.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(168, 123);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(169, 20);
            this.txt_name.TabIndex = 3;
            // 
            // txt_info
            // 
            this.txt_info.Location = new System.Drawing.Point(53, 203);
            this.txt_info.Name = "txt_info";
            this.txt_info.Size = new System.Drawing.Size(466, 194);
            this.txt_info.TabIndex = 4;
            this.txt_info.Text = "";
            // 
            // DisplayStudentMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.txt_info);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
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
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.RichTextBox txt_info;
    }
}