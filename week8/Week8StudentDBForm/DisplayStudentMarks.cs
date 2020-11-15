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
    public partial class DisplayStudentMarks : Form
    {
        public readonly String studentID;
        public readonly String studentName;

        SqlConnection connection;

        public DisplayStudentMarks(String studentID, String studentName)
        {
            this.studentID = studentID;
            this.studentName = studentName;
            connection = new SqlConnection(Properties.Settings.Default.connection);
            InitializeComponent();
        }

        private void DisplayStudentMarks_Load(object sender, EventArgs e)
        {
            txt_stuid.Text = studentID;
            txt_stuname.Text = studentName;

            connection.Open();
            String listSQL = "select sname, period, mark from marks join subject using (subjectId) where studentid = '" + studentID +"'";
            SqlCommand command = new SqlCommand(listSQL, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                String row1 = reader.GetString(0);
                String row2 = reader.GetString(1);
                String row3 = reader.GetString(2);
                lbx_info.Items.Add(row1 + ", " + row2 + ", " + row3);
            }
            command.Dispose();
            reader.Close();
        }
    }
}
