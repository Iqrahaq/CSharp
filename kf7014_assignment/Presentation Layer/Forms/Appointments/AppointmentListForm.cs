// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Presentation_Layer.Views;
using Presentation_Layer.Presenters.Appointments;
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
    public partial class AppointmentListForm : Form, IAppointmentList
    {
        private AppointmentListPresenter appointmentListPresenter;

        public AppointmentListForm()
        {
            InitializeComponent();
        }

        private void AppointmentListForm_Load(object sender, EventArgs e)
        {

        }

        public void setAppointments(DataSet source)
        {
            dgv_appointments.DataSource = source.Tables[0];
            if (dgv_appointments != null)
            {
                this.dgv_appointments.Columns["People_PersonId"].Visible = false;
                this.dgv_appointments.Columns["AppointmentId"].Visible = false;
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            appointmentListPresenter.btn_home_Clicked();
        }

        public void register(AppointmentListPresenter ALP)
        {
            appointmentListPresenter = ALP;
        }

    }
}
