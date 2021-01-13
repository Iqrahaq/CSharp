// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Presentation_Layer.Presenters;
using Assignment.Presentation_Layer.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Presentation_Layer.Forms
{
    public partial class PatientInformationForm : Form, IPatientInformation
    {
        private PatientInformationPresenter patientInformationPresenter;

        public PatientInformationForm()
        {
            InitializeComponent();
        }

        private void PatientInformationForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            patientInformationPresenter.btn_home_Clicked();
        }

        public void setPatientID(int id)
        {
            txt_no.Text = id.ToString();
        }

        public void setPatientName(string name)
        {
            rtb_name.Text = name;
        }
        public void setPatientGender(string gender)
        {
            cmb_gender.Text = gender;
        }

        public void setPatientDOB(string dob)
        {
            dte_dob.Text = dob;
        }

        public void setPatientPrimary(string phone)
        {
            txt_phone.Text = phone;
        }

        public void setPatientSecondary(string phone)
        {
            txt_emer.Text = phone;
        }

        public void setPatientAddress(string address)
        {
            rtb_address.Text = address;
        }

        private void btn_app_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            patientInformationPresenter.btn_app_Clicked();
        }

        public void register(PatientInformationPresenter PIP)
        {
            patientInformationPresenter = PIP;
        }

    }
}
