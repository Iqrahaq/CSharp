namespace SoftwareBlogsMVP
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
            this.btn_name = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_name
            // 
            this.btn_name.Location = new System.Drawing.Point(49, 44);
            this.btn_name.Name = "btn_name";
            this.btn_name.Size = new System.Drawing.Size(262, 77);
            this.btn_name.TabIndex = 0;
            this.btn_name.Text = "Click for Name";
            this.btn_name.UseVisualStyleBackColor = true;
            this.btn_name.Click += new System.EventHandler(this.btn_name_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(161, 162);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 229);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_name;
        private System.Windows.Forms.Label lbl_name;
    }
}

