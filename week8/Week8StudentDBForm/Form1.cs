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

namespace Week8StudentDBForm
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        public Form1()
        {
            connection = new SqlConnection(Properties.Settings.Default.connection);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            String listSQL = "Select distinct major from student;";
            SqlCommand command = new SqlCommand(listSQL, connection);
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                String row = reader.GetString(0);
                cbx_course.Items.Add(row);
            }
            command.Dispose();
            reader.Close();
        }

        private void cbx_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbx_student.Items.Clear();
            String selectedIndex = (string)cbx_course.SelectedItem;

            String studentsSQL = "select studentid, stuname from student where major = '" + selectedIndex.Trim() + "'";
            SqlCommand command = new SqlCommand(studentsSQL, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int row1 = reader.GetInt32(0);
                String row2 = reader.GetString(1);

                lbx_student.Items.Add(row1 + " - " + row2);
            }
            command.Dispose();
            reader.Close();
        }

        private void lbx_student_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (string)lbx_student.SelectedItem;
            string[] values = selected.Split();
            DisplayStudentMarks studentMarksForm = new DisplayStudentMarks(values[0], values[1]);
            this.Hide();
            studentMarksForm.ShowDialog();
            this.Show();

        }
    }
}
