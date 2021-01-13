// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Presentation_Layer.Views;
using Presentation_Layer.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment.Domain_Layer.Person;

namespace Assignment.Presentation_Layer.Forms
{
    public partial class PatientListForm : Form, IPatientList
    {
        private PatientListPresenter patientListPresenter;

        public PatientListForm()
        {
            InitializeComponent();
        }

        private void PatientListForm_Load(object sender, EventArgs e)
        {
            dgv_patients.AllowUserToAddRows = false;
            dgv_patients.AllowUserToDeleteRows = false;
            for (int x = 0; x < dgv_patients.ColumnCount; x++)
            {
                dgv_patients.Columns[x].ReadOnly = true;
            }
        }

        public void setPatients(DataSet source)
        {
            dgv_patients.DataSource = source.Tables[0];
            if(dgv_patients != null)
            {
                this.dgv_patients.Columns["PersonId"].Visible = false;
                this.dgv_patients.Columns["Type"].Visible = false;
                this.dgv_patients.Columns["Address_PersonAddressId"].Visible = false;
                this.dgv_patients.Columns["GP_GPId"].Visible = false;
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            patientListPresenter.btn_home_Clicked();
        }


        private void dgv_patients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Visible = false;
            patientListPresenter.rowSelected(dgv_patients.CurrentCell.RowIndex);
        }

        private void dgv_patients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Visible = false;
            patientListPresenter.rowSelected(dgv_patients.CurrentCell.RowIndex);
        }

        public void register(PatientListPresenter PLP)
        {
            patientListPresenter = PLP;
        }
    }
}
