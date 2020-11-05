namespace ModelViewPresenter
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
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_rev = new System.Windows.Forms.Button();
            this.txt_main = new System.Windows.Forms.TextBox();
            this.lbl_main = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(42, 32);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(169, 60);
            this.btn_set.TabIndex = 0;
            this.btn_set.Text = "Set";
            this.btn_set.UseVisualStyleBackColor = true;
            // 
            // btn_rev
            // 
            this.btn_rev.Location = new System.Drawing.Point(42, 126);
            this.btn_rev.Name = "btn_rev";
            this.btn_rev.Size = new System.Drawing.Size(169, 60);
            this.btn_rev.TabIndex = 0;
            this.btn_rev.Text = "Reverse";
            this.btn_rev.UseVisualStyleBackColor = true;
            // 
            // txt_main
            // 
            this.txt_main.Location = new System.Drawing.Point(42, 228);
            this.txt_main.Name = "txt_main";
            this.txt_main.Size = new System.Drawing.Size(174, 20);
            this.txt_main.TabIndex = 1;
            // 
            // lbl_main
            // 
            this.lbl_main.AutoSize = true;
            this.lbl_main.Location = new System.Drawing.Point(113, 267);
            this.lbl_main.Name = "lbl_main";
            this.lbl_main.Size = new System.Drawing.Size(33, 13);
            this.lbl_main.TabIndex = 2;
            this.lbl_main.Text = "Label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 319);
            this.Controls.Add(this.lbl_main);
            this.Controls.Add(this.txt_main);
            this.Controls.Add(this.btn_rev);
            this.Controls.Add(this.btn_set);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_rev;
        private System.Windows.Forms.TextBox txt_main;
        private System.Windows.Forms.Label lbl_main;
    }
}

