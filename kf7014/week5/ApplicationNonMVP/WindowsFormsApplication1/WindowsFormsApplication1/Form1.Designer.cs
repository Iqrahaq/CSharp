namespace WindowsFormsApplication1
{
    partial class KeyGenerator
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
            this.chk_LowerCase = new System.Windows.Forms.CheckBox();
            this.chk_number = new System.Windows.Forms.CheckBox();
            this.chk_uppercase = new System.Windows.Forms.CheckBox();
            this.chk_otherchars = new System.Windows.Forms.CheckBox();
            this.txt_keyLength = new System.Windows.Forms.TextBox();
            this.txt_generatedKey = new System.Windows.Forms.TextBox();
            this.grb_keySet = new System.Windows.Forms.GroupBox();
            this.chk_hex = new System.Windows.Forms.CheckBox();
            this.lbl_keyLength = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn_generateKey = new System.Windows.Forms.Button();
            this.grb_keyStrength = new System.Windows.Forms.GroupBox();
            this.lbl_keysPerSecond = new System.Windows.Forms.Label();
            this.txt_keysPerSecond = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_minutes = new System.Windows.Forms.TextBox();
            this.txt_hours = new System.Windows.Forms.TextBox();
            this.txt_days = new System.Windows.Forms.TextBox();
            this.txt_years = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_seconds = new System.Windows.Forms.TextBox();
            this.grb_keySet.SuspendLayout();
            this.grb_keyStrength.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_LowerCase
            // 
            this.chk_LowerCase.AutoSize = true;
            this.chk_LowerCase.Location = new System.Drawing.Point(6, 19);
            this.chk_LowerCase.Name = "chk_LowerCase";
            this.chk_LowerCase.Size = new System.Drawing.Size(111, 17);
            this.chk_LowerCase.TabIndex = 0;
            this.chk_LowerCase.Text = "LoweCase Letters";
            this.chk_LowerCase.UseVisualStyleBackColor = true;
            this.chk_LowerCase.CheckedChanged += new System.EventHandler(this.chk_LowerCase_CheckedChanged);
            // 
            // chk_number
            // 
            this.chk_number.AutoSize = true;
            this.chk_number.Location = new System.Drawing.Point(6, 48);
            this.chk_number.Name = "chk_number";
            this.chk_number.Size = new System.Drawing.Size(68, 17);
            this.chk_number.TabIndex = 1;
            this.chk_number.Text = "Numbers";
            this.chk_number.UseVisualStyleBackColor = true;
            this.chk_number.CheckedChanged += new System.EventHandler(this.chk_number_CheckedChanged);
            // 
            // chk_uppercase
            // 
            this.chk_uppercase.AutoSize = true;
            this.chk_uppercase.Location = new System.Drawing.Point(119, 19);
            this.chk_uppercase.Name = "chk_uppercase";
            this.chk_uppercase.Size = new System.Drawing.Size(114, 17);
            this.chk_uppercase.TabIndex = 2;
            this.chk_uppercase.Text = "UpperCase Letters";
            this.chk_uppercase.UseVisualStyleBackColor = true;
            this.chk_uppercase.CheckedChanged += new System.EventHandler(this.chk_uppercase_CheckedChanged);
            // 
            // chk_otherchars
            // 
            this.chk_otherchars.AutoSize = true;
            this.chk_otherchars.Location = new System.Drawing.Point(119, 48);
            this.chk_otherchars.Name = "chk_otherchars";
            this.chk_otherchars.Size = new System.Drawing.Size(106, 17);
            this.chk_otherchars.TabIndex = 3;
            this.chk_otherchars.Text = "Other Characters";
            this.chk_otherchars.UseVisualStyleBackColor = true;
            this.chk_otherchars.CheckedChanged += new System.EventHandler(this.chk_otherchars_CheckedChanged);
            // 
            // txt_keyLength
            // 
            this.txt_keyLength.Location = new System.Drawing.Point(364, 257);
            this.txt_keyLength.Name = "txt_keyLength";
            this.txt_keyLength.Size = new System.Drawing.Size(90, 20);
            this.txt_keyLength.TabIndex = 4;
            this.txt_keyLength.Leave += new System.EventHandler(this.txt_keyLength_Leave);
            // 
            // txt_generatedKey
            // 
            this.txt_generatedKey.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_generatedKey.Location = new System.Drawing.Point(63, 38);
            this.txt_generatedKey.Name = "txt_generatedKey";
            this.txt_generatedKey.ReadOnly = true;
            this.txt_generatedKey.Size = new System.Drawing.Size(389, 31);
            this.txt_generatedKey.TabIndex = 5;
            // 
            // grb_keySet
            // 
            this.grb_keySet.Controls.Add(this.chk_hex);
            this.grb_keySet.Controls.Add(this.chk_otherchars);
            this.grb_keySet.Controls.Add(this.chk_uppercase);
            this.grb_keySet.Controls.Add(this.chk_number);
            this.grb_keySet.Controls.Add(this.chk_LowerCase);
            this.grb_keySet.Location = new System.Drawing.Point(16, 246);
            this.grb_keySet.Name = "grb_keySet";
            this.grb_keySet.Size = new System.Drawing.Size(238, 101);
            this.grb_keySet.TabIndex = 6;
            this.grb_keySet.TabStop = false;
            this.grb_keySet.Text = "KeySet";
            // 
            // chk_hex
            // 
            this.chk_hex.AutoSize = true;
            this.chk_hex.Location = new System.Drawing.Point(6, 78);
            this.chk_hex.Name = "chk_hex";
            this.chk_hex.Size = new System.Drawing.Size(66, 17);
            this.chk_hex.TabIndex = 4;
            this.chk_hex.Text = "HexOnly";
            this.chk_hex.UseVisualStyleBackColor = true;
            this.chk_hex.CheckedChanged += new System.EventHandler(this.chk_hex_CheckedChanged);
            // 
            // lbl_keyLength
            // 
            this.lbl_keyLength.AutoSize = true;
            this.lbl_keyLength.Location = new System.Drawing.Point(297, 257);
            this.lbl_keyLength.Name = "lbl_keyLength";
            this.lbl_keyLength.Size = new System.Drawing.Size(61, 13);
            this.lbl_keyLength.TabIndex = 7;
            this.lbl_keyLength.Text = "Key Length";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(7, 38);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(50, 13);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "New Key";
            // 
            // btn_generateKey
            // 
            this.btn_generateKey.Location = new System.Drawing.Point(293, 287);
            this.btn_generateKey.Name = "btn_generateKey";
            this.btn_generateKey.Size = new System.Drawing.Size(160, 31);
            this.btn_generateKey.TabIndex = 9;
            this.btn_generateKey.Text = "Create Key";
            this.btn_generateKey.UseVisualStyleBackColor = true;
            this.btn_generateKey.Click += new System.EventHandler(this.btn_generateKey_Click);
            // 
            // grb_keyStrength
            // 
            this.grb_keyStrength.Controls.Add(this.label5);
            this.grb_keyStrength.Controls.Add(this.txt_seconds);
            this.grb_keyStrength.Controls.Add(this.lbl_keysPerSecond);
            this.grb_keyStrength.Controls.Add(this.txt_keysPerSecond);
            this.grb_keyStrength.Controls.Add(this.label4);
            this.grb_keyStrength.Controls.Add(this.label3);
            this.grb_keyStrength.Controls.Add(this.label2);
            this.grb_keyStrength.Controls.Add(this.label1);
            this.grb_keyStrength.Controls.Add(this.txt_minutes);
            this.grb_keyStrength.Controls.Add(this.txt_hours);
            this.grb_keyStrength.Controls.Add(this.txt_days);
            this.grb_keyStrength.Controls.Add(this.txt_years);
            this.grb_keyStrength.Location = new System.Drawing.Point(16, 77);
            this.grb_keyStrength.Name = "grb_keyStrength";
            this.grb_keyStrength.Size = new System.Drawing.Size(427, 163);
            this.grb_keyStrength.TabIndex = 10;
            this.grb_keyStrength.TabStop = false;
            this.grb_keyStrength.Text = "KeyStrength - Average time to Crack Key";
            // 
            // lbl_keysPerSecond
            // 
            this.lbl_keysPerSecond.AutoSize = true;
            this.lbl_keysPerSecond.Location = new System.Drawing.Point(141, 126);
            this.lbl_keysPerSecond.Name = "lbl_keysPerSecond";
            this.lbl_keysPerSecond.Size = new System.Drawing.Size(116, 13);
            this.lbl_keysPerSecond.TabIndex = 16;
            this.lbl_keysPerSecond.Text = "Keys Tried Per Second";
            // 
            // txt_keysPerSecond
            // 
            this.txt_keysPerSecond.Location = new System.Drawing.Point(263, 123);
            this.txt_keysPerSecond.Name = "txt_keysPerSecond";
            this.txt_keysPerSecond.Size = new System.Drawing.Size(155, 20);
            this.txt_keysPerSecond.TabIndex = 15;
            this.txt_keysPerSecond.Leave += new System.EventHandler(this.txt_keysPerSecond_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Years";
            // 
            // txt_minutes
            // 
            this.txt_minutes.Location = new System.Drawing.Point(64, 100);
            this.txt_minutes.Name = "txt_minutes";
            this.txt_minutes.ReadOnly = true;
            this.txt_minutes.Size = new System.Drawing.Size(47, 20);
            this.txt_minutes.TabIndex = 3;
            // 
            // txt_hours
            // 
            this.txt_hours.Location = new System.Drawing.Point(64, 74);
            this.txt_hours.Name = "txt_hours";
            this.txt_hours.ReadOnly = true;
            this.txt_hours.Size = new System.Drawing.Size(47, 20);
            this.txt_hours.TabIndex = 2;
            // 
            // txt_days
            // 
            this.txt_days.Location = new System.Drawing.Point(64, 48);
            this.txt_days.Name = "txt_days";
            this.txt_days.ReadOnly = true;
            this.txt_days.Size = new System.Drawing.Size(47, 20);
            this.txt_days.TabIndex = 1;
            // 
            // txt_years
            // 
            this.txt_years.Location = new System.Drawing.Point(64, 19);
            this.txt_years.Name = "txt_years";
            this.txt_years.ReadOnly = true;
            this.txt_years.Size = new System.Drawing.Size(354, 20);
            this.txt_years.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Seconds";
            // 
            // txt_seconds
            // 
            this.txt_seconds.Location = new System.Drawing.Point(64, 126);
            this.txt_seconds.Name = "txt_seconds";
            this.txt_seconds.ReadOnly = true;
            this.txt_seconds.Size = new System.Drawing.Size(47, 20);
            this.txt_seconds.TabIndex = 17;
            // 
            // KeyGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 356);
            this.Controls.Add(this.grb_keyStrength);
            this.Controls.Add(this.btn_generateKey);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl_keyLength);
            this.Controls.Add(this.grb_keySet);
            this.Controls.Add(this.txt_generatedKey);
            this.Controls.Add(this.txt_keyLength);
            this.Name = "KeyGenerator";
            this.Text = "Key Gen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grb_keySet.ResumeLayout(false);
            this.grb_keySet.PerformLayout();
            this.grb_keyStrength.ResumeLayout(false);
            this.grb_keyStrength.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_LowerCase;
        private System.Windows.Forms.CheckBox chk_number;
        private System.Windows.Forms.CheckBox chk_uppercase;
        private System.Windows.Forms.CheckBox chk_otherchars;
        private System.Windows.Forms.TextBox txt_keyLength;
        private System.Windows.Forms.TextBox txt_generatedKey;
        private System.Windows.Forms.GroupBox grb_keySet;
        private System.Windows.Forms.Label lbl_keyLength;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn_generateKey;
        private System.Windows.Forms.GroupBox grb_keyStrength;
        private System.Windows.Forms.TextBox txt_minutes;
        private System.Windows.Forms.TextBox txt_hours;
        private System.Windows.Forms.TextBox txt_days;
        private System.Windows.Forms.TextBox txt_years;
        private System.Windows.Forms.Label lbl_keysPerSecond;
        private System.Windows.Forms.TextBox txt_keysPerSecond;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_hex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_seconds;
    }
}

