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
    public partial class DisplayStudentMarksForm : Form
    { 

        private SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.connection);

        public int id;
        public string name;
        public DisplayStudentMarksForm(int id, string name)
        {
            this.id = id;
            this.name = name;
            InitializeComponent();
        }

        private void DisplayStudentMarks_Load(object sender, EventArgs e)
        {
            txt_id.Text = id.ToString();
            txt_name.Text = name;

            string sql = "Select sname, period, mark from marks join subject on marks.subjectid = subject.subjectid where studentid =" + id;
            SqlCommand command = new SqlCommand(sql, sqlConn);
            sqlConn.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txt_info.AppendText(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetInt32(2) + "\n");
                }
            }
            command.Dispose();
            reader.Close();
            sqlConn.Close(); 
        }
    }
}
