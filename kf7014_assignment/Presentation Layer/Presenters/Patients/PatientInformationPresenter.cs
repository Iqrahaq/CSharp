// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Forms.Appointments;
using Assignment.Presentation_Layer.Forms;
using Assignment.Presentation_Layer.Views;
using Assignment.Presenters;
using Presentation_Layer.Presenters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Presentation_Layer.Presenters
{
    public class PatientInformationPresenter
    {
        private IPatientInformation view;
        DataSet patients;
        private int patientID;

        public PatientInformationPresenter(IPatientInformation view, DataSet patients, int patientID)
        {
            this.view = view;
            this.patientID = patientID;
            this.patients = patients;
            view.register(this);
            initialiseForm();
        }

        private void initialiseForm()
        {
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
            view.setPatientID(patientID);
            view.setPatientGender(patientList[0].Gender);
            view.setPatientDOB(patientList[0].DOB.ToString());
            view.setPatientPrimary(patientList[0].PrimaryPhone);
            view.setPatientSecondary(patientList[0].SecondaryPhone);
            view.setPatientAddress(patientList[0].FirstLine + "\n" +
                                   patientList[0].SecondLine + "\n" +
                                   patientList[0].ThirdLine + "\n" +
                                   patientList[0].City + "\n" +
                                   patientList[0].County + "\n" +
                                   patientList[0].Postcode + "\n");
        }

        public void btn_app_Clicked()
        {
            NewAppointmentForm apForm = new NewAppointmentForm();
            NewAppointmentPresenter apPresenter = new NewAppointmentPresenter(apForm, patients, patientID);
            apForm.Show();
        }

        public void btn_home_Clicked()
        {
            HomeForm hForm = new HomeForm();
            HomePresenter hp = new HomePresenter(hForm);
            hForm.Show();
        }
    }
}
