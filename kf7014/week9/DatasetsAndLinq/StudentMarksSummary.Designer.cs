
namespace DatasetsAndLinq
{
    partial class StudentMarksSummary
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
            this.dgv_marks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_marks
            // 
            this.dgv_marks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_marks.Location = new System.Drawing.Point(73, 47);
            this.dgv_marks.Name = "dgv_marks";
            this.dgv_marks.Size = new System.Drawing.Size(672, 365);
            this.dgv_marks.TabIndex = 0;
            this.dgv_marks.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_marks_CellContentDoubleClick);
            this.dgv_marks.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_marks_RowHeaderMouseDoubleClick);
            // 
            // StudentMarksSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_marks);
            this.Name = "StudentMarksSummary";
            this.Text = "StudentMarksSummary";
            this.Load += new System.EventHandler(this.StudentMarksSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_marks;
    }
}