
namespace Week8StudentDBForm
{
    partial class Form1
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
            this.lbl_course = new System.Windows.Forms.Label();
            this.lbl_student = new System.Windows.Forms.Label();
            this.cbx_course = new System.Windows.Forms.ComboBox();
            this.lbx_student = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.Location = new System.Drawing.Point(33, 27);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(67, 13);
            this.lbl_course.TabIndex = 0;
            this.lbl_course.Text = "Course Type";
            // 
            // lbl_student
            // 
            this.lbl_student.AutoSize = true;
            this.lbl_student.Location = new System.Drawing.Point(37, 79);
            this.lbl_student.Name = "lbl_student";
            this.lbl_student.Size = new System.Drawing.Size(63, 13);
            this.lbl_student.TabIndex = 1;
            this.lbl_student.Text = "Student List";
            // 
            // cbx_course
            // 
            this.cbx_course.FormattingEnabled = true;
            this.cbx_course.Location = new System.Drawing.Point(179, 27);
            this.cbx_course.Name = "cbx_course";
            this.cbx_course.Size = new System.Drawing.Size(261, 21);
            this.cbx_course.TabIndex = 2;
            this.cbx_course.SelectedIndexChanged += new System.EventHandler(this.cbx_course_SelectedIndexChanged);
            // 
            // lbx_student
            // 
            this.lbx_student.FormattingEnabled = true;
            this.lbx_student.Location = new System.Drawing.Point(179, 79);
            this.lbx_student.Name = "lbx_student";
            this.lbx_student.Size = new System.Drawing.Size(261, 290);
            this.lbx_student.TabIndex = 4;
            this.lbx_student.SelectedIndexChanged += new System.EventHandler(this.lbx_student_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbx_student);
            this.Controls.Add(this.cbx_course);
            this.Controls.Add(this.lbl_student);
            this.Controls.Add(this.lbl_course);
            this.Name = "Form1";
            this.Text = "Students By Course";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.Label lbl_student;
        private System.Windows.Forms.ComboBox cbx_course;
        private System.Windows.Forms.ListBox lbx_student;
    }
}

