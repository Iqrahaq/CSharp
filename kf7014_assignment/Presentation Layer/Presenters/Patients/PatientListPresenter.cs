// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Data_Access_Layer;
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

namespace Presentation_Layer.Presenters
{
    public class PatientListPresenter
    {
        private IPatientList view;
        SqlConnection connection;
        SqlDataAdapter allPatients;
        DataSet patients;
        DataSet joinDS;

        public PatientListPresenter(IPatientList view)
        {
            this.view = view;
            view.register(this);
            initialiseForm();
        }

        private void initialiseForm()
        {
            connection = new SqlConnection(Properties.Settings.Default.connString);

            string allPatientsSQL = "Select * from People WHERE Type = 'Patient'; Select * from PersonAddresses";
            allPatients = new SqlDataAdapter(allPatientsSQL, connection);
            patients = new DataSet("Patients");
            allPatients.Fill(patients);

            string joinTable = "SELECT People.PersonId, People.FirstName, People.MiddleName, People.LastName from People LEFT JOIN PersonAddresses ON People.Address_PersonAddressId = PersonAddresses.PersonAddressId GROUP BY People.PersonId, People.FirstName, People.MiddleName, People.LastName;";
            SqlDataAdapter join = new SqlDataAdapter(joinTable, connection);
            joinDS = new DataSet("Join");
            join.Fill(joinDS);

            view.setPatients(patients);

        }
        public void btn_home_Clicked()
        {
            HomeForm hForm = new HomeForm();
            HomePresenter hp = new HomePresenter(hForm);
            hForm.Show();
        }

        public void rowSelected(int index)
        {
            DataRow dr = joinDS.Tables[0].Rows[index];
            int patientID = dr.Field<int>(0);
            PatientInformationForm piForm = new PatientInformationForm();
            PatientInformationPresenter patientInformationPresenter = new PatientInformationPresenter(piForm, patients, patientID);
            piForm.Show();
        }
    }
}
