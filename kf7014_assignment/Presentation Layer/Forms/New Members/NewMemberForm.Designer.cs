
namespace Assignment.Forms.Patients
{
    partial class NewMemberForm
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
            this.gbx_member = new System.Windows.Forms.GroupBox();
            this.cmb_title = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.txt_emer = new System.Windows.Forms.TextBox();
            this.lbl_emer = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.txt_last = new System.Windows.Forms.TextBox();
            this.lbl_last = new System.Windows.Forms.Label();
            this.txt_middle = new System.Windows.Forms.TextBox();
            this.lbl_middle = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.dte_dob = new System.Windows.Forms.DateTimePicker();
            this.txt_first = new System.Windows.Forms.TextBox();
            this.lbl_full = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbx_member.SuspendLayout();
            this.gbx_address.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation_Layer.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(562, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 232);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "NEW MEMBER REGISTRATION FORM";
            // 
            // gbx_member
            // 
            this.gbx_member.Controls.Add(this.cmb_title);
            this.gbx_member.Controls.Add(this.label9);
            this.gbx_member.Controls.Add(this.gbx_address);
            this.gbx_member.Controls.Add(this.txt_emer);
            this.gbx_member.Controls.Add(this.lbl_emer);
            this.gbx_member.Controls.Add(this.txt_phone);
            this.gbx_member.Controls.Add(this.lbl_phone);
            this.gbx_member.Controls.Add(this.cmb_gender);
            this.gbx_member.Controls.Add(this.lbl_gender);
            this.gbx_member.Controls.Add(this.txt_last);
            this.gbx_member.Controls.Add(this.lbl_last);
            this.gbx_member.Controls.Add(this.txt_middle);
            this.gbx_member.Controls.Add(this.lbl_middle);
            this.gbx_member.Controls.Add(this.cmb_type);
            this.gbx_member.Controls.Add(this.lbl_type);
            this.gbx_member.Controls.Add(this.lbl_dob);
            this.gbx_member.Controls.Add(this.dte_dob);
            this.gbx_member.Controls.Add(this.txt_first);
            this.gbx_member.Controls.Add(this.lbl_full);
            this.gbx_member.Location = new System.Drawing.Point(94, 429);
            this.gbx_member.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbx_member.Name = "gbx_member";
            this.gbx_member.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbx_member.Size = new System.Drawing.Size(1252, 641);
            this.gbx_member.TabIndex = 8;
            this.gbx_member.TabStop = false;
            this.gbx_member.Text = "Member Details";
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
            this.cmb_title.Location = new System.Drawing.Point(261, 102);
            this.cmb_title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_title.Name = "cmb_title";
            this.cmb_title.Size = new System.Drawing.Size(298, 28);
            this.cmb_title.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 106);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Title *";
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
            this.gbx_address.Location = new System.Drawing.Point(672, 29);
            this.gbx_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbx_address.Name = "gbx_address";
            this.gbx_address.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbx_address.Size = new System.Drawing.Size(522, 522);
            this.gbx_address.TabIndex = 28;
            this.gbx_address.TabStop = false;
            this.gbx_address.Text = "Full Address";
            // 
            // txt_postcode
            // 
            this.txt_postcode.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_postcode.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_postcode.Location = new System.Drawing.Point(196, 445);
            this.txt_postcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_postcode.Name = "txt_postcode";
            this.txt_postcode.Size = new System.Drawing.Size(298, 26);
            this.txt_postcode.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 449);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Postcode *";
            // 
            // txt_county
            // 
            this.txt_county.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_county.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_county.Location = new System.Drawing.Point(196, 365);
            this.txt_county.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_county.Name = "txt_county";
            this.txt_county.Size = new System.Drawing.Size(298, 26);
            this.txt_county.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 369);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "County *";
            // 
            // txt_city
            // 
            this.txt_city.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_city.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_city.Location = new System.Drawing.Point(196, 285);
            this.txt_city.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(298, 26);
            this.txt_city.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 289);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "City *";
            // 
            // txt_tline
            // 
            this.txt_tline.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_tline.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_tline.Location = new System.Drawing.Point(196, 206);
            this.txt_tline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_tline.Name = "txt_tline";
            this.txt_tline.Size = new System.Drawing.Size(298, 26);
            this.txt_tline.TabIndex = 33;
            // 
            // txt_sline
            // 
            this.txt_sline.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_sline.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_sline.Location = new System.Drawing.Point(196, 128);
            this.txt_sline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sline.Name = "txt_sline";
            this.txt_sline.Size = new System.Drawing.Size(298, 26);
            this.txt_sline.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Third Line";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "First Line *";
            // 
            // txt_fline
            // 
            this.txt_fline.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_fline.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_fline.Location = new System.Drawing.Point(196, 58);
            this.txt_fline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_fline.Name = "txt_fline";
            this.txt_fline.Size = new System.Drawing.Size(298, 26);
            this.txt_fline.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Second Line";
            // 
            // txt_emer
            // 
            this.txt_emer.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_emer.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_emer.Location = new System.Drawing.Point(261, 553);
            this.txt_emer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_emer.Name = "txt_emer";
            this.txt_emer.Size = new System.Drawing.Size(298, 26);
            this.txt_emer.TabIndex = 26;
            // 
            // lbl_emer
            // 
            this.lbl_emer.AutoSize = true;
            this.lbl_emer.Location = new System.Drawing.Point(34, 558);
            this.lbl_emer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_emer.Name = "lbl_emer";
            this.lbl_emer.Size = new System.Drawing.Size(149, 20);
            this.lbl_emer.TabIndex = 27;
            this.lbl_emer.Text = "Emergency Number";
            // 
            // txt_phone
            // 
            this.txt_phone.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_phone.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_phone.Location = new System.Drawing.Point(261, 486);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(298, 26);
            this.txt_phone.TabIndex = 24;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(67, 491);
            this.lbl_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(125, 20);
            this.lbl_phone.TabIndex = 25;
            this.lbl_phone.Text = "Phone Number *";
            // 
            // cmb_gender
            // 
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_gender.Location = new System.Drawing.Point(260, 356);
            this.cmb_gender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(298, 28);
            this.cmb_gender.TabIndex = 23;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(118, 360);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(73, 20);
            this.lbl_gender.TabIndex = 22;
            this.lbl_gender.Text = "Gender *";
            // 
            // txt_last
            // 
            this.txt_last.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_last.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_last.Location = new System.Drawing.Point(261, 287);
            this.txt_last.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_last.Name = "txt_last";
            this.txt_last.Size = new System.Drawing.Size(298, 26);
            this.txt_last.TabIndex = 20;
            // 
            // lbl_last
            // 
            this.lbl_last.AutoSize = true;
            this.lbl_last.Location = new System.Drawing.Point(96, 291);
            this.lbl_last.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_last.Name = "lbl_last";
            this.lbl_last.Size = new System.Drawing.Size(96, 20);
            this.lbl_last.TabIndex = 21;
            this.lbl_last.Text = "Last Name *";
            // 
            // txt_middle
            // 
            this.txt_middle.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_middle.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_middle.Location = new System.Drawing.Point(260, 219);
            this.txt_middle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_middle.Name = "txt_middle";
            this.txt_middle.Size = new System.Drawing.Size(298, 26);
            this.txt_middle.TabIndex = 18;
            // 
            // lbl_middle
            // 
            this.lbl_middle.AutoSize = true;
            this.lbl_middle.Location = new System.Drawing.Point(78, 223);
            this.lbl_middle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_middle.Name = "lbl_middle";
            this.lbl_middle.Size = new System.Drawing.Size(101, 20);
            this.lbl_middle.TabIndex = 19;
            this.lbl_middle.Text = "Middle Name";
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "Patient",
            "Dentist",
            "Receptionist"});
            this.cmb_type.Location = new System.Drawing.Point(261, 52);
            this.cmb_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(298, 28);
            this.cmb_type.TabIndex = 15;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(136, 52);
            this.lbl_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(53, 20);
            this.lbl_type.TabIndex = 14;
            this.lbl_type.Text = "Type *";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Location = new System.Drawing.Point(83, 428);
            this.lbl_dob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(109, 20);
            this.lbl_dob.TabIndex = 9;
            this.lbl_dob.Text = "Date of Birth *";
            // 
            // dte_dob
            // 
            this.dte_dob.Location = new System.Drawing.Point(261, 418);
            this.dte_dob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dte_dob.Name = "dte_dob";
            this.dte_dob.Size = new System.Drawing.Size(298, 26);
            this.dte_dob.TabIndex = 8;
            // 
            // txt_first
            // 
            this.txt_first.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_first.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_first.Location = new System.Drawing.Point(260, 159);
            this.txt_first.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_first.Name = "txt_first";
            this.txt_first.Size = new System.Drawing.Size(298, 26);
            this.txt_first.TabIndex = 8;
            // 
            // lbl_full
            // 
            this.lbl_full.AutoSize = true;
            this.lbl_full.Location = new System.Drawing.Point(98, 163);
            this.lbl_full.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_full.Name = "lbl_full";
            this.lbl_full.Size = new System.Drawing.Size(96, 20);
            this.lbl_full.TabIndex = 8;
            this.lbl_full.Text = "First Name *";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(611, 1107);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(216, 82);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_home
            // 
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(663, 271);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(81, 65);
            this.btn_home.TabIndex = 10;
            this.btn_home.Text = "🏠";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // NewMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1437, 961);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.gbx_member);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewMemberForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "New Member";
            this.Load += new System.EventHandler(this.MemberInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbx_member.ResumeLayout(false);
            this.gbx_member.PerformLayout();
            this.gbx_address.ResumeLayout(false);
            this.gbx_address.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbx_member;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.DateTimePicker dte_dob;
        private System.Windows.Forms.TextBox txt_first;
        private System.Windows.Forms.Label lbl_full;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.TextBox txt_middle;
        private System.Windows.Forms.Label lbl_middle;
        private System.Windows.Forms.TextBox txt_last;
        private System.Windows.Forms.Label lbl_last;
        private System.Windows.Forms.TextBox txt_emer;
        private System.Windows.Forms.Label lbl_emer;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.Label lbl_gender;
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
        private System.Windows.Forms.ComboBox cmb_title;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_home;
    }
}