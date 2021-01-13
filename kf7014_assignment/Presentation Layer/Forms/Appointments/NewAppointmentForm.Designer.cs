
namespace Assignment.Forms.Appointments
{
    partial class NewAppointmentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbx_app = new System.Windows.Forms.GroupBox();
            this.dte_time = new System.Windows.Forms.DateTimePicker();
            this.txt_notes = new System.Windows.Forms.RichTextBox();
            this.lbl_notes = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.cmb_dentist = new System.Windows.Forms.ComboBox();
            this.lbl_dentist = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.dte_when = new System.Windows.Forms.DateTimePicker();
            this.gbx_patient = new System.Windows.Forms.GroupBox();
            this.txt_address = new System.Windows.Forms.RichTextBox();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.dte_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_full = new System.Windows.Forms.TextBox();
            this.lbl_ptno = new System.Windows.Forms.Label();
            this.lbl_full = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.gbx_app.SuspendLayout();
            this.gbx_patient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW APPOINTMENT FORM";
            // 
            // gbx_app
            // 
            this.gbx_app.Controls.Add(this.dte_time);
            this.gbx_app.Controls.Add(this.txt_notes);
            this.gbx_app.Controls.Add(this.lbl_notes);
            this.gbx_app.Controls.Add(this.lbl_time);
            this.gbx_app.Controls.Add(this.cmb_dentist);
            this.gbx_app.Controls.Add(this.lbl_dentist);
            this.gbx_app.Controls.Add(this.cmb_type);
            this.gbx_app.Controls.Add(this.lbl_type);
            this.gbx_app.Controls.Add(this.lbl_date);
            this.gbx_app.Controls.Add(this.dte_when);
            this.gbx_app.Location = new System.Drawing.Point(38, 317);
            this.gbx_app.Name = "gbx_app";
            this.gbx_app.Size = new System.Drawing.Size(443, 429);
            this.gbx_app.TabIndex = 2;
            this.gbx_app.TabStop = false;
            this.gbx_app.Text = "Appointment Details";
            // 
            // dte_time
            // 
            this.dte_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dte_time.Location = new System.Drawing.Point(136, 144);
            this.dte_time.Name = "dte_time";
            this.dte_time.Size = new System.Drawing.Size(200, 20);
            this.dte_time.TabIndex = 15;
            this.dte_time.TabStop = false;
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(136, 247);
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(200, 96);
            this.txt_notes.TabIndex = 14;
            this.txt_notes.Text = "";
            // 
            // lbl_notes
            // 
            this.lbl_notes.AutoSize = true;
            this.lbl_notes.Location = new System.Drawing.Point(74, 250);
            this.lbl_notes.Name = "lbl_notes";
            this.lbl_notes.Size = new System.Drawing.Size(35, 13);
            this.lbl_notes.TabIndex = 13;
            this.lbl_notes.Text = "Notes";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(80, 147);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(30, 13);
            this.lbl_time.TabIndex = 8;
            this.lbl_time.Text = "Time";
            // 
            // cmb_dentist
            // 
            this.cmb_dentist.FormattingEnabled = true;
            this.cmb_dentist.Items.AddRange(new object[] {
            "Dr. Who",
            "Dr. Dentist",
            "Dr. Watson"});
            this.cmb_dentist.Location = new System.Drawing.Point(136, 188);
            this.cmb_dentist.Name = "cmb_dentist";
            this.cmb_dentist.Size = new System.Drawing.Size(200, 21);
            this.cmb_dentist.TabIndex = 7;
            // 
            // lbl_dentist
            // 
            this.lbl_dentist.AutoSize = true;
            this.lbl_dentist.Location = new System.Drawing.Point(70, 191);
            this.lbl_dentist.Name = "lbl_dentist";
            this.lbl_dentist.Size = new System.Drawing.Size(40, 13);
            this.lbl_dentist.TabIndex = 6;
            this.lbl_dentist.Text = "Dentist";
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "Checkups",
            "Other"});
            this.cmb_type.Location = new System.Drawing.Point(136, 44);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(200, 21);
            this.cmb_type.TabIndex = 3;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(79, 47);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(31, 13);
            this.lbl_type.TabIndex = 2;
            this.lbl_type.Text = "Type";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(79, 97);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(30, 13);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date";
            // 
            // dte_when
            // 
            this.dte_when.Location = new System.Drawing.Point(136, 91);
            this.dte_when.Name = "dte_when";
            this.dte_when.Size = new System.Drawing.Size(200, 20);
            this.dte_when.TabIndex = 0;
            this.dte_when.TabStop = false;
            // 
            // gbx_patient
            // 
            this.gbx_patient.Controls.Add(this.txt_address);
            this.gbx_patient.Controls.Add(this.lbl_dob);
            this.gbx_patient.Controls.Add(this.dte_date);
            this.gbx_patient.Controls.Add(this.lbl_address);
            this.gbx_patient.Controls.Add(this.txt_num);
            this.gbx_patient.Controls.Add(this.txt_full);
            this.gbx_patient.Controls.Add(this.lbl_ptno);
            this.gbx_patient.Controls.Add(this.lbl_full);
            this.gbx_patient.Location = new System.Drawing.Point(558, 317);
            this.gbx_patient.Name = "gbx_patient";
            this.gbx_patient.Size = new System.Drawing.Size(393, 324);
            this.gbx_patient.TabIndex = 3;
            this.gbx_patient.TabStop = false;
            this.gbx_patient.Text = "Patient Details";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(152, 188);
            this.txt_address.Name = "txt_address";
            this.txt_address.ReadOnly = true;
            this.txt_address.Size = new System.Drawing.Size(200, 96);
            this.txt_address.TabIndex = 12;
            this.txt_address.Text = "";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Location = new System.Drawing.Point(34, 143);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(66, 13);
            this.lbl_dob.TabIndex = 9;
            this.lbl_dob.Text = "Date of Birth";
            // 
            // dte_date
            // 
            this.dte_date.Enabled = false;
            this.dte_date.Location = new System.Drawing.Point(152, 137);
            this.dte_date.Name = "dte_date";
            this.dte_date.Size = new System.Drawing.Size(200, 20);
            this.dte_date.TabIndex = 8;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(37, 188);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(64, 13);
            this.lbl_address.TabIndex = 11;
            this.lbl_address.Text = "Full Address";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(152, 89);
            this.txt_num.Name = "txt_num";
            this.txt_num.ReadOnly = true;
            this.txt_num.Size = new System.Drawing.Size(200, 20);
            this.txt_num.TabIndex = 10;
            // 
            // txt_full
            // 
            this.txt_full.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_full.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_full.Location = new System.Drawing.Point(152, 43);
            this.txt_full.Name = "txt_full";
            this.txt_full.ReadOnly = true;
            this.txt_full.Size = new System.Drawing.Size(200, 20);
            this.txt_full.TabIndex = 8;
            // 
            // lbl_ptno
            // 
            this.lbl_ptno.AutoSize = true;
            this.lbl_ptno.Location = new System.Drawing.Point(41, 92);
            this.lbl_ptno.Name = "lbl_ptno";
            this.lbl_ptno.Size = new System.Drawing.Size(60, 13);
            this.lbl_ptno.TabIndex = 9;
            this.lbl_ptno.Text = "Patient No.";
            // 
            // lbl_full
            // 
            this.lbl_full.AutoSize = true;
            this.lbl_full.Location = new System.Drawing.Point(44, 46);
            this.lbl_full.Name = "lbl_full";
            this.lbl_full.Size = new System.Drawing.Size(54, 13);
            this.lbl_full.TabIndex = 8;
            this.lbl_full.Text = "Full Name";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(807, 693);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(144, 53);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation_Layer.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(420, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 151);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_home
            // 
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(489, 190);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(54, 42);
            this.btn_home.TabIndex = 11;
            this.btn_home.Text = "🏠";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // NewAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 776);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.gbx_patient);
            this.Controls.Add(this.gbx_app);
            this.Controls.Add(this.label1);
            this.Name = "NewAppointmentForm";
            this.Text = "New Appointment";
            this.Load += new System.EventHandler(this.NewAppointmentForm_Load);
            this.gbx_app.ResumeLayout(false);
            this.gbx_app.PerformLayout();
            this.gbx_patient.ResumeLayout(false);
            this.gbx_patient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbx_app;
        private System.Windows.Forms.ComboBox cmb_dentist;
        private System.Windows.Forms.Label lbl_dentist;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DateTimePicker dte_when;
        private System.Windows.Forms.GroupBox gbx_patient;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_full;
        private System.Windows.Forms.Label lbl_ptno;
        private System.Windows.Forms.Label lbl_full;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.DateTimePicker dte_date;
        private System.Windows.Forms.RichTextBox txt_address;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.RichTextBox txt_notes;
        private System.Windows.Forms.Label lbl_notes;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.DateTimePicker dte_time;
    }
}