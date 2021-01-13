
namespace Assignment.Presentation_Layer.Forms
{
    partial class PatientInformationForm
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
            this.gbx_patient = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtb_history = new System.Windows.Forms.RichTextBox();
            this.rtb_name = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbx_address = new System.Windows.Forms.GroupBox();
            this.rtb_address = new System.Windows.Forms.RichTextBox();
            this.txt_emer = new System.Windows.Forms.TextBox();
            this.lbl_emer = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.dte_dob = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_app = new System.Windows.Forms.Button();
            this.gbx_patient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbx_address.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(420, 192);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(54, 42);
            this.btn_home.TabIndex = 14;
            this.btn_home.Text = "🏠";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // gbx_patient
            // 
            this.gbx_patient.Controls.Add(this.groupBox1);
            this.gbx_patient.Controls.Add(this.rtb_name);
            this.gbx_patient.Controls.Add(this.label9);
            this.gbx_patient.Controls.Add(this.gbx_address);
            this.gbx_patient.Controls.Add(this.txt_emer);
            this.gbx_patient.Controls.Add(this.lbl_emer);
            this.gbx_patient.Controls.Add(this.txt_phone);
            this.gbx_patient.Controls.Add(this.lbl_phone);
            this.gbx_patient.Controls.Add(this.cmb_gender);
            this.gbx_patient.Controls.Add(this.lbl_gender);
            this.gbx_patient.Controls.Add(this.txt_no);
            this.gbx_patient.Controls.Add(this.label2);
            this.gbx_patient.Controls.Add(this.lbl_dob);
            this.gbx_patient.Controls.Add(this.dte_dob);
            this.gbx_patient.Location = new System.Drawing.Point(41, 295);
            this.gbx_patient.Name = "gbx_patient";
            this.gbx_patient.Size = new System.Drawing.Size(835, 419);
            this.gbx_patient.TabIndex = 13;
            this.gbx_patient.TabStop = false;
            this.gbx_patient.Text = "Patient Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtb_history);
            this.groupBox1.Location = new System.Drawing.Point(436, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 152);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medical History";
            // 
            // rtb_history
            // 
            this.rtb_history.Location = new System.Drawing.Point(18, 35);
            this.rtb_history.Name = "rtb_history";
            this.rtb_history.Size = new System.Drawing.Size(311, 75);
            this.rtb_history.TabIndex = 0;
            this.rtb_history.Text = "";
            // 
            // rtb_name
            // 
            this.rtb_name.Location = new System.Drawing.Point(163, 126);
            this.rtb_name.Name = "rtb_name";
            this.rtb_name.Size = new System.Drawing.Size(200, 34);
            this.rtb_name.TabIndex = 1;
            this.rtb_name.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Full Name";
            // 
            // gbx_address
            // 
            this.gbx_address.Controls.Add(this.rtb_address);
            this.gbx_address.Location = new System.Drawing.Point(436, 44);
            this.gbx_address.Name = "gbx_address";
            this.gbx_address.Size = new System.Drawing.Size(348, 152);
            this.gbx_address.TabIndex = 28;
            this.gbx_address.TabStop = false;
            this.gbx_address.Text = "Full Address";
            // 
            // rtb_address
            // 
            this.rtb_address.Location = new System.Drawing.Point(18, 35);
            this.rtb_address.Name = "rtb_address";
            this.rtb_address.Size = new System.Drawing.Size(311, 75);
            this.rtb_address.TabIndex = 0;
            this.rtb_address.Text = "";
            // 
            // txt_emer
            // 
            this.txt_emer.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_emer.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_emer.Location = new System.Drawing.Point(164, 310);
            this.txt_emer.Name = "txt_emer";
            this.txt_emer.Size = new System.Drawing.Size(200, 20);
            this.txt_emer.TabIndex = 26;
            // 
            // lbl_emer
            // 
            this.lbl_emer.AutoSize = true;
            this.lbl_emer.Location = new System.Drawing.Point(13, 313);
            this.lbl_emer.Name = "lbl_emer";
            this.lbl_emer.Size = new System.Drawing.Size(100, 13);
            this.lbl_emer.TabIndex = 27;
            this.lbl_emer.Text = "Emergency Number";
            // 
            // txt_phone
            // 
            this.txt_phone.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_phone.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_phone.Location = new System.Drawing.Point(164, 267);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(200, 20);
            this.txt_phone.TabIndex = 24;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(35, 270);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(78, 13);
            this.lbl_phone.TabIndex = 25;
            this.lbl_phone.Text = "Phone Number";
            // 
            // cmb_gender
            // 
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_gender.Location = new System.Drawing.Point(164, 179);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(200, 21);
            this.cmb_gender.TabIndex = 23;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(70, 182);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(42, 13);
            this.lbl_gender.TabIndex = 22;
            this.lbl_gender.Text = "Gender";
            // 
            // txt_no
            // 
            this.txt_no.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_no.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_no.Location = new System.Drawing.Point(164, 90);
            this.txt_no.Name = "txt_no";
            this.txt_no.ReadOnly = true;
            this.txt_no.Size = new System.Drawing.Size(200, 20);
            this.txt_no.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Patient ID.";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Location = new System.Drawing.Point(46, 229);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(66, 13);
            this.lbl_dob.TabIndex = 9;
            this.lbl_dob.Text = "Date of Birth";
            // 
            // dte_dob
            // 
            this.dte_dob.Location = new System.Drawing.Point(164, 223);
            this.dte_dob.Name = "dte_dob";
            this.dte_dob.Size = new System.Drawing.Size(200, 20);
            this.dte_dob.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "PATIENT INFORMATION FORM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation_Layer.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(353, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 151);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_app
            // 
            this.btn_app.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_app.Location = new System.Drawing.Point(334, 735);
            this.btn_app.Name = "btn_app";
            this.btn_app.Size = new System.Drawing.Size(242, 90);
            this.btn_app.TabIndex = 30;
            this.btn_app.Text = "New Appointment";
            this.btn_app.UseVisualStyleBackColor = true;
            this.btn_app.Click += new System.EventHandler(this.btn_app_Click);
            // 
            // PatientInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 867);
            this.Controls.Add(this.btn_app);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.gbx_patient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PatientInformationForm";
            this.Text = "Patient Information Form";
            this.Load += new System.EventHandler(this.PatientInformationForm_Load);
            this.gbx_patient.ResumeLayout(false);
            this.gbx_patient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbx_address.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.GroupBox gbx_patient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbx_address;
        private System.Windows.Forms.TextBox txt_emer;
        private System.Windows.Forms.Label lbl_emer;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.DateTimePicker dte_dob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtb_name;
        private System.Windows.Forms.RichTextBox rtb_address;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtb_history;
        private System.Windows.Forms.Button btn_app;
    }
}