
namespace DatasetsAndLinq
{
    partial class StudentsByCourseForm
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
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.lbx_students = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student List";
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(179, 45);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(194, 21);
            this.cmb_type.TabIndex = 2;
            this.cmb_type.SelectedValueChanged += new System.EventHandler(this.cmb_type_SelectedValueChanged);
            // 
            // lbx_students
            // 
            this.lbx_students.FormattingEnabled = true;
            this.lbx_students.Location = new System.Drawing.Point(179, 120);
            this.lbx_students.Name = "lbx_students";
            this.lbx_students.Size = new System.Drawing.Size(194, 173);
            this.lbx_students.TabIndex = 3;
            this.lbx_students.SelectedValueChanged += new System.EventHandler(this.lbx_students_SelectedValueChanged);
            // 
            // StudentsByCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 328);
            this.Controls.Add(this.lbx_students);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentsByCourse";
            this.Text = "Students By Course";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.ListBox lbx_students;
    }
}

