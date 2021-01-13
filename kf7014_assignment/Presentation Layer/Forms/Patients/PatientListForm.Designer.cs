
namespace Assignment.Presentation_Layer.Forms
{
    partial class PatientListForm
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
            this.dgv_patients = new System.Windows.Forms.DataGridView();
            this.btn_home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_patients
            // 
            this.dgv_patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patients.Location = new System.Drawing.Point(54, 306);
            this.dgv_patients.Name = "dgv_patients";
            this.dgv_patients.Size = new System.Drawing.Size(692, 150);
            this.dgv_patients.TabIndex = 0;
            this.dgv_patients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_patients_CellContentClick);
            this.dgv_patients.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_patients_CellContentDoubleClick);
            // 
            // btn_home
            // 
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(377, 186);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(54, 42);
            this.btn_home.TabIndex = 17;
            this.btn_home.Text = "🏠";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "LIST OF PATIENTS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation_Layer.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(310, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 151);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // PatientListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_patients);
            this.Name = "PatientListForm";
            this.Text = "Patient List";
            this.Load += new System.EventHandler(this.PatientListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_patients;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}