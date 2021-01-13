
namespace Presentation_Layer.Forms.New_Members
{
    partial class GPInformationForm
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
            this.btn_home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbx_patient = new System.Windows.Forms.GroupBox();
            this.txt_practice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_emer = new System.Windows.Forms.TextBox();
            this.lbl_emer = new System.Windows.Forms.Label();
            this.txt_last = new System.Windows.Forms.TextBox();
            this.lbl_last = new System.Windows.Forms.Label();
            this.txt_middle = new System.Windows.Forms.TextBox();
            this.lbl_middle = new System.Windows.Forms.Label();
            this.txt_first = new System.Windows.Forms.TextBox();
            this.lbl_full = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.cmb_title = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbx_address = new System.Windows.Forms.GroupBox();
            this.txt_postcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_county = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tline = new System.Windows.Forms.TextBox();
            this.txt_sline = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fline = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbx_patient.SuspendLayout();
            this.gbx_address.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(435, 186);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(54, 42);
            this.btn_home.TabIndex = 13;
            this.btn_home.Text = "🏠";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "GP INFORMATION FORM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation_Layer.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(367, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 151);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // gbx_patient
            // 
            this.gbx_patient.Controls.Add(this.txt_practice);
            this.gbx_patient.Controls.Add(this.label9);
            this.gbx_patient.Controls.Add(this.txt_emer);
            this.gbx_patient.Controls.Add(this.lbl_emer);
            this.gbx_patient.Controls.Add(this.txt_last);
            this.gbx_patient.Controls.Add(this.lbl_last);
            this.gbx_patient.Controls.Add(this.txt_middle);
            this.gbx_patient.Controls.Add(this.lbl_middle);
            this.gbx_patient.Controls.Add(this.txt_first);
            this.gbx_patient.Controls.Add(this.lbl_full);
            this.gbx_patient.Controls.Add(this.txt_phone);
            this.gbx_patient.Controls.Add(this.lbl_phone);
            this.gbx_patient.Controls.Add(this.cmb_title);
            this.gbx_patient.Controls.Add(this.label2);
            this.gbx_patient.Location = new System.Drawing.Point(31, 288);
            this.gbx_patient.Name = "gbx_patient";
            this.gbx_patient.Size = new System.Drawing.Size(411, 265);
            this.gbx_patient.TabIndex = 14;
            this.gbx_patient.TabStop = false;
            this.gbx_patient.Text = "GP Details";
            // 
            // txt_practice
            // 
            this.txt_practice.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_practice.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_practice.Location = new System.Drawing.Point(171, 26);
            this.txt_practice.Name = "txt_practice";
            this.txt_practice.Size = new System.Drawing.Size(200, 20);
            this.txt_practice.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Practice Name *";
            // 
            // txt_emer
            // 
            this.txt_emer.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_emer.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_emer.Location = new System.Drawing.Point(171, 226);
            this.txt_emer.Name = "txt_emer";
            this.txt_emer.Size = new System.Drawing.Size(200, 20);
            this.txt_emer.TabIndex = 39;
            // 
            // lbl_emer
            // 
            this.lbl_emer.AutoSize = true;
            this.lbl_emer.Location = new System.Drawing.Point(19, 229);
            this.lbl_emer.Name = "lbl_emer";
            this.lbl_emer.Size = new System.Drawing.Size(100, 13);
            this.lbl_emer.TabIndex = 40;
            this.lbl_emer.Text = "Emergency Number";
            // 
            // txt_last
            // 
            this.txt_last.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_last.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_last.Location = new System.Drawing.Point(171, 156);
            this.txt_last.Name = "txt_last";
            this.txt_last.Size = new System.Drawing.Size(200, 20);
            this.txt_last.TabIndex = 37;
            // 
            // lbl_last
            // 
            this.lbl_last.AutoSize = true;
            this.lbl_last.Location = new System.Drawing.Point(61, 159);
            this.lbl_last.Name = "lbl_last";
            this.lbl_last.Size = new System.Drawing.Size(65, 13);
            this.lbl_last.TabIndex = 38;
            this.lbl_last.Text = "Last Name *";
            // 
            // txt_middle
            // 
            this.txt_middle.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_middle.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_middle.Location = new System.Drawing.Point(171, 124);
            this.txt_middle.Name = "txt_middle";
            this.txt_middle.Size = new System.Drawing.Size(200, 20);
            this.txt_middle.TabIndex = 35;
            // 
            // lbl_middle
            // 
            this.lbl_middle.AutoSize = true;
            this.lbl_middle.Location = new System.Drawing.Point(49, 127);
            this.lbl_middle.Name = "lbl_middle";
            this.lbl_middle.Size = new System.Drawing.Size(69, 13);
            this.lbl_middle.TabIndex = 36;
            this.lbl_middle.Text = "Middle Name";
            // 
            // txt_first
            // 
            this.txt_first.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_first.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_first.Location = new System.Drawing.Point(171, 93);
            this.txt_first.Name = "txt_first";
            this.txt_first.Size = new System.Drawing.Size(200, 20);
            this.txt_first.TabIndex = 33;
            // 
            // lbl_full
            // 
            this.lbl_full.AutoSize = true;
            this.lbl_full.Location = new System.Drawing.Point(63, 96);
            this.lbl_full.Name = "lbl_full";
            this.lbl_full.Size = new System.Drawing.Size(64, 13);
            this.lbl_full.TabIndex = 34;
            this.lbl_full.Text = "First Name *";
            // 
            // txt_phone
            // 
            this.txt_phone.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_phone.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_phone.Location = new System.Drawing.Point(171, 194);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(200, 20);
            this.txt_phone.TabIndex = 24;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(41, 196);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(85, 13);
            this.lbl_phone.TabIndex = 25;
            this.lbl_phone.Text = "Phone Number *";
            // 
            // cmb_title
            // 
            this.cmb_title.FormattingEnabled = true;
            this.cmb_title.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Miss",
            "Ms",
            "Dr"});
            this.cmb_title.Location = new System.Drawing.Point(171, 62);
            this.cmb_title.Name = "cmb_title";
            this.cmb_title.Size = new System.Drawing.Size(200, 21);
            this.cmb_title.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Title *";
            // 
            // gbx_address
            // 
            this.gbx_address.Controls.Add(this.txt_postcode);
            this.gbx_address.Controls.Add(this.label8);
            this.gbx_address.Controls.Add(this.txt_county);
            this.gbx_address.Controls.Add(this.label7);
            this.gbx_address.Controls.Add(this.txt_city);
            this.gbx_address.Controls.Add(this.label6);
            this.gbx_address.Controls.Add(this.txt_tline);
            this.gbx_address.Controls.Add(this.txt_sline);
            this.gbx_address.Controls.Add(this.label3);
            this.gbx_address.Controls.Add(this.label5);
            this.gbx_address.Controls.Add(this.txt_fline);
            this.gbx_address.Controls.Add(this.label4);
            this.gbx_address.Location = new System.Drawing.Point(490, 288);
            this.gbx_address.Name = "gbx_address";
            this.gbx_address.Size = new System.Drawing.Size(348, 339);
            this.gbx_address.TabIndex = 29;
            this.gbx_address.TabStop = false;
            this.gbx_address.Text = "Full Address";
            // 
            // txt_postcode
            // 
            this.txt_postcode.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_postcode.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_postcode.Location = new System.Drawing.Point(131, 289);
            this.txt_postcode.Name = "txt_postcode";
            this.txt_postcode.Size = new System.Drawing.Size(200, 20);
            this.txt_postcode.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Postcode *";
            // 
            // txt_county
            // 
            this.txt_county.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_county.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_county.Location = new System.Drawing.Point(131, 237);
            this.txt_county.Name = "txt_county";
            this.txt_county.Size = new System.Drawing.Size(200, 20);
            this.txt_county.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "County *";
            // 
            // txt_city
            // 
            this.txt_city.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_city.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_city.Location = new System.Drawing.Point(131, 185);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(200, 20);
            this.txt_city.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "City *";
            // 
            // txt_tline
            // 
            this.txt_tline.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_tline.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_tline.Location = new System.Drawing.Point(131, 134);
            this.txt_tline.Name = "txt_tline";
            this.txt_tline.Size = new System.Drawing.Size(200, 20);
            this.txt_tline.TabIndex = 33;
            // 
            // txt_sline
            // 
            this.txt_sline.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_sline.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_sline.Location = new System.Drawing.Point(131, 83);
            this.txt_sline.Name = "txt_sline";
            this.txt_sline.Size = new System.Drawing.Size(200, 20);
            this.txt_sline.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Third Line";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "First Line *";
            // 
            // txt_fline
            // 
            this.txt_fline.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_fline.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_fline.Location = new System.Drawing.Point(131, 38);
            this.txt_fline.Name = "txt_fline";
            this.txt_fline.Size = new System.Drawing.Size(200, 20);
            this.txt_fline.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Second Line";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(156, 574);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(144, 53);
            this.btn_submit.TabIndex = 30;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // GPInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(898, 663);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.gbx_address);
            this.Controls.Add(this.gbx_patient);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GPInformationForm";
            this.Text = "GP Information";
            this.Load += new System.EventHandler(this.GPInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbx_patient.ResumeLayout(false);
            this.gbx_patient.PerformLayout();
            this.gbx_address.ResumeLayout(false);
            this.gbx_address.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbx_patient;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.ComboBox cmb_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbx_address;
        private System.Windows.Forms.TextBox txt_postcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_county;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tline;
        private System.Windows.Forms.TextBox txt_sline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_last;
        private System.Windows.Forms.Label lbl_last;
        private System.Windows.Forms.TextBox txt_middle;
        private System.Windows.Forms.Label lbl_middle;
        private System.Windows.Forms.TextBox txt_first;
        private System.Windows.Forms.Label lbl_full;
        private System.Windows.Forms.TextBox txt_emer;
        private System.Windows.Forms.Label lbl_emer;
        private System.Windows.Forms.TextBox txt_practice;
        private System.Windows.Forms.Label label9;
    }
}