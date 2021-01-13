// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Presentation_Layer.Forms;
using Assignment.Presentation_Layer.Presenters;
using Assignment.Presentation_Layer.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Layer.Presenters.Appointments
{
    public class AppointmentListPresenter
    {
        private IAppointmentList view;
        SqlConnection connection;
        SqlDataAdapter allAppointments;
        DataSet appointments;

        public AppointmentListPresenter(IAppointmentList view)
        {
            this.view = view;
            view.register(this);
            initialiseForm();
        }

        private void initialiseForm()
        {
            connection = new SqlConnection(Properties.Settings.Default.connString);

            string allAppointmentsSQL = "Select People.FirstName, People.MiddleName, People.LastName, Appointments.* from Appointments LEFT JOIN People ON Appointments.People_PersonId = People.PersonId";
            allAppointments = new SqlDataAdapter(allAppointmentsSQL, connection);
            appointments = new DataSet("Appointments");
            allAppointments.Fill(appointments);
            view.setAppointments(appointments);
        }

        public void btn_home_Clicked()
        {
            HomeForm hForm = new HomeForm();
            HomePresenter hp = new HomePresenter(hForm);
            hForm.Show();
        }
    }
}
