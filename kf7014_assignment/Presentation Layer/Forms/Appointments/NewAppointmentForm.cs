// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment.Views;
using Assignment.Presenters;
using Presentation_Layer.Presenters;

namespace Assignment.Forms.Appointments
{
    public partial class NewAppointmentForm : Form, INewAppointment
    {
        private NewAppointmentPresenter appointmentPresenter;

        public NewAppointmentForm()
        {
            InitializeComponent();
        }

        private void NewAppointmentForm_Load(object sender, EventArgs e)
        {
 
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            appointmentPresenter.btn_home_Clicked();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            appointmentPresenter.btn_submit_Clicked();
        }

        public String getAppointmentType()
        {
            return cmb_type.SelectedItem.ToString();
        }

        public void setAppointmentTypes(List<String> types)
        {
            cmb_type.DataSource = types;
        }

        public DateTime getAppointmentDate()
        {
            return dte_date.Value.Date;
        }

        public String getAppointmentTime()
        {
            return dte_time.Text;
        }

        public String getAppointmentDentist()
        {
            if (cmb_dentist.SelectedItem != null)
            {
                return cmb_dentist.SelectedItem.ToString();
            }
            else
            {
                return "Dr. Default";
            }
        }

        public void setAppointmentDentists(List<string> dentists)
        {
            cmb_dentist.DataSource = dentists;
        }

        public String getAppointmentNotes()
        {
            return txt_notes.Text;
        }

        public void setPatientName(String name)
        {
            txt_full.Text = name;
        }

        public void setPatientNumber(String number)
        {
            txt_num.Text = number;
        }

        public void setPatientDOB(String dob)
        {
            dte_date.Text = dob;
        }

        public void setPatientAddress(String address)
        {
            txt_address.Text = address;
        }

        public void register(NewAppointmentPresenter NAP)
        {
            appointmentPresenter = NAP;
        }
    }
}
