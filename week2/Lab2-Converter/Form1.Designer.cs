namespace Lab2_Converter
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cent = new System.Windows.Forms.TextBox();
            this.txt_fahr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Centigrade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fahrenheit";
            // 
            // txt_cent
            // 
            this.txt_cent.Location = new System.Drawing.Point(136, 32);
            this.txt_cent.Name = "txt_cent";
            this.txt_cent.Size = new System.Drawing.Size(100, 20);
            this.txt_cent.TabIndex = 2;
            this.txt_cent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cent_KeyPress);
            this.txt_cent.Leave += new System.EventHandler(this.txt_cent_Leave);
            // 
            // txt_fahr
            // 
            this.txt_fahr.Location = new System.Drawing.Point(136, 107);
            this.txt_fahr.Name = "txt_fahr";
            this.txt_fahr.Size = new System.Drawing.Size(100, 20);
            this.txt_fahr.TabIndex = 3;
            this.txt_fahr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fahr_KeyPress);
            this.txt_fahr.Leave += new System.EventHandler(this.txt_fahr_Leave);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(255, 146);
            this.Controls.Add(this.txt_fahr);
            this.Controls.Add(this.txt_cent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Temp Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cent;
        private System.Windows.Forms.TextBox txt_fahr;
    }
}

