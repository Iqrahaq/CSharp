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
    public partial class StudentsByCourseForm : Form
    {
        private SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.connection);
        public StudentsByCourseForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select distinct major from student", sqlConn);
            sqlConn.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cmb_type.Items.Add(reader.GetString(0));
                }
            }
            command.Dispose();
            reader.Close();
            sqlConn.Close();
        }

        private void cmb_type_SelectedValueChanged(object sender, EventArgs e)
        {
            lbx_students.Items.Clear();
            string majorString = cmb_type.Text.Trim();
            string sql = "Select studentid, stuname from student where major = '" + majorString + "'";
            SqlCommand command = new SqlCommand(sql, sqlConn);
            sqlConn.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lbx_students.Items.Add(reader.GetInt32(0) + " - " + reader.GetString(1));
                }
            }
            command.Dispose();
            reader.Close();
            sqlConn.Close();
        }

        private void lbx_students_SelectedValueChanged(object sender, EventArgs e)
        {
            string[] values = lbx_students.SelectedItem.ToString().Split(new[] { " - " }, StringSplitOptions.None);
            DisplayStudentMarksForm studentMarksForm = new DisplayStudentMarksForm(Convert.ToInt32(values[0]), values[1]);
            this.Hide();
            studentMarksForm.ShowDialog();
            this.Show();
        }
    }
}
