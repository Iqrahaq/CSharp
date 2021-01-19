using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DatasetsAndLinq
{
    public partial class StudentMarksSummary : Form
    {
        private SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.connection);

        DataSet ds = new DataSet("StudentsMarksSubjects");
        public StudentMarksSummary()
        {
            InitializeComponent();
        }

        private void StudentMarksSummary_Load(object sender, EventArgs e)
        {
            sqlConn.Open();
            String command = "SELECT Student.studentId, Student.stuName, Count(mark) AS MarksAvailable, Avg(mark) AS AvrageMark FROM Student LEFT JOIN marks ON Student.StudentID = marks.studentID GROUP BY Student.studentId, Student.stuName";
            SqlDataAdapter adapter = new SqlDataAdapter(command, sqlConn);
            adapter.Fill(ds, "Students");

            dgv_marks.DataSource = ds.Tables[0];

            command = "SELECT * from MARKS";
            adapter = new SqlDataAdapter(command, sqlConn);
            adapter.Fill(ds, "Marks");

            command = "SELECT * from SUBJECT";
            adapter = new SqlDataAdapter(command, sqlConn);
            adapter.Fill(ds, "Subjects");
            sqlConn.Close();

            dgv_marks.AllowUserToAddRows = false;
            dgv_marks.AllowUserToDeleteRows = false;
            int cols = dgv_marks.Columns.Count;
            for(int x=0; x<cols; x++)
            {
                dgv_marks.Columns[x].ReadOnly = true;
            }
            
        }

        private void dgv_marks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgv_marks.Rows[e.RowIndex].Cells[0].Value;
            StudentMarksViewForm studentMarksForm = new StudentMarksViewForm(ds, id);
            this.Hide();
            studentMarksForm.ShowDialog();
            this.Show();
        }

        private void dgv_marks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgv_marks.Rows[e.RowIndex].Cells[0].Value;
            StudentMarksViewForm studentMarksForm = new StudentMarksViewForm(ds, id);
            this.Hide();
            studentMarksForm.ShowDialog();
            this.Show();
        }
    }
}
