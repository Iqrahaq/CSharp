// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment;
using Assignment.Data_Access_Layer;
using Assignment.Presentation_Layer.Forms;
using Assignment.Presentation_Layer.Presenters;
using Assignment.Presentation_Layer.Views;
using Assignment.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment.Appointment;

namespace Presentation_Layer.Presenters
{
    public class NewAppointmentPresenter
    {
        private INewAppointment view;
        private Appointment appointment;
        SqlConnection connection;
        SqlDataAdapter allDentists;
        DataSet dentists;
        DataSet patients;
        private int patientID;

        public NewAppointmentPresenter(INewAppointment view, DataSet patients, int patientID)
        {
            this.view = view;
            this.patients = patients;
            this.patientID = patientID;
            appointment = new Appointment();
            view.register(this);
            initialiseForm();
        }

        private void initialiseForm()
        {
            //Set Appointment Dentists.
            connection = new SqlConnection(Properties.Settings.Default.connString);

            string allDentistsSQL = "Select * from People WHERE Type = 'Dentist'";
            allDentists = new SqlDataAdapter(allDentistsSQL, connection);
            dentists = new DataSet("Dentists");
            allDentists.Fill(dentists);
            
            List<string> list = dentists.Tables[0].AsEnumerable().Select(r => 
                                                    (r.Field<string>("Title")) + " " +
                                                    (r.Field<string>("FirstName")) + " " +
                                                    (r.Field<string>("MiddleName")) + " " +
                                                    (r.Field<string>("LastName"))).ToList();

            view.setAppointmentDentists(list);

            var patientsquery = from patient in patients.Tables[0].AsEnumerable()
                                join address in patients.Tables[1].AsEnumerable()
                                on patient.Field<int>(10) equals
                                    address.Field<int>(0)
                                where patient.Field<int>(0) == patientID
                                select new
                                {
                                    FirstName = patient.Field<string>(3),
                                    MiddleName = patient.Field<string>(4),
                                    LastName = patient.Field<string>(5),
                                    Gender = patient.Field<string>(6),
                                    DOB = patient.Field<DateTime>(7),
                                    PrimaryPhone = patient.Field<string>(8),
                                    SecondaryPhone = patient.Field<string>(9),
                                    FirstLine = address.Field<string>("FirstLine"),
                                    SecondLine = address.Field<string>("SecondLine"),
                                    ThirdLine = address.Field<string>("ThirdLine"),
                                    City = address.Field<string>("City"),
                                    County = address.Field<string>("County"),
                                    Postcode = address.Field<string>("Postcode"),
                                };
            var patientList = patientsquery.ToList();
            view.setPatientName(patientList[0].FirstName + " " + patientList[0].MiddleName + " " + patientList[0].LastName);
            view.setPatientNumber(patientID.ToString());
            view.setPatientDOB(patientList[0].DOB.ToString());
            view.setPatientAddress(patientList[0].FirstLine + "\n" +
                                   patientList[0].SecondLine + "\n" +
                                   patientList[0].ThirdLine + "\n" +
                                   patientList[0].City + "\n" +
                                   patientList[0].County + "\n" +
                                   patientList[0].Postcode + "\n");
        }

        public void btn_home_Clicked()
        {
            HomeForm hForm = new HomeForm();
            hForm.Show();
        }

        public void btn_submit_Clicked()
        {
            appointment.AppointmentType = (Consult)Enum.Parse(typeof(Consult), view.getAppointmentType());
            appointment.AppointmentDate = view.getAppointmentDate();
            appointment.AppointmentTime = view.getAppointmentTime();
            appointment.AppointmentDentist = view.getAppointmentDentist();
            appointment.AppointmentNotes = view.getAppointmentNotes();

            AppointmentDB.InsertAppointment(appointment);
            ConfirmationForm cForm = new ConfirmationForm();
            ConfirmationPresenter cPresenter = new ConfirmationPresenter(cForm);
            cForm.Show();
        }

    }
}
