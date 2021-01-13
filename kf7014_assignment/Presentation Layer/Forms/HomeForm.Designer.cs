
namespace Assignment.Presentation_Layer.Forms
{
    partial class HomeForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_patlist = new System.Windows.Forms.Button();
            this.btn_applist = new System.Windows.Forms.Button();
            this.btn_newmem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation_Layer.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(296, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 151);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "HOME FORM";
            // 
            // btn_patlist
            // 
            this.btn_patlist.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patlist.Location = new System.Drawing.Point(44, 311);
            this.btn_patlist.Name = "btn_patlist";
            this.btn_patlist.Size = new System.Drawing.Size(281, 64);
            this.btn_patlist.TabIndex = 9;
            this.btn_patlist.Text = "Patient List";
            this.btn_patlist.UseVisualStyleBackColor = true;
            this.btn_patlist.Click += new System.EventHandler(this.btn_patlist_Click);
            // 
            // btn_applist
            // 
            this.btn_applist.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_applist.Location = new System.Drawing.Point(457, 311);
            this.btn_applist.Name = "btn_applist";
            this.btn_applist.Size = new System.Drawing.Size(281, 64);
            this.btn_applist.TabIndex = 10;
            this.btn_applist.Text = "Appointment List";
            this.btn_applist.UseVisualStyleBackColor = true;
            this.btn_applist.Click += new System.EventHandler(this.btn_applist_Click);
            // 
            // btn_newmem
            // 
            this.btn_newmem.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newmem.Location = new System.Drawing.Point(257, 431);
            this.btn_newmem.Name = "btn_newmem";
            this.btn_newmem.Size = new System.Drawing.Size(281, 64);
            this.btn_newmem.TabIndex = 11;
            this.btn_newmem.Text = "New Member";
            this.btn_newmem.UseVisualStyleBackColor = true;
            this.btn_newmem.Click += new System.EventHandler(this.btn_newmem_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.btn_newmem);
            this.Controls.Add(this.btn_applist);
            this.Controls.Add(this.btn_patlist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HomeForm";
            this.Text = "Home Form";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_patlist;
        private System.Windows.Forms.Button btn_applist;
        private System.Windows.Forms.Button btn_newmem;
    }
}