using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatasetsAndLinq
{
    public partial class StudentMarksViewForm : Form
    {
  
        DataSet students;
        int id;
        public StudentMarksViewForm(DataSet students, int id)
        {
            this.students = students;
            this.id = id;
            InitializeComponent();
        }

        private void StudentMarksViewForm_Load(object sender, EventArgs e)
        {
            DataTable allStudents = students.Tables[0];
            DataTable allMarks = students.Tables[1];
            DataTable allSubjecs = students.Tables[2];
            var query = from student in allStudents.AsEnumerable()
                        where student.Field<int>("studentId") == id
                        select student.Field<string>("stuName");

            var nameList = query.ToList();
            txt_name.Text = nameList[0];
            txt_id.Text = id.ToString();

            DataTable dt = new DataTable();
            dt.Columns.Add("Subject ID", typeof(string));
            dt.Columns.Add("Subject", typeof(string));
            dt.Columns.Add("Period", typeof(string));
            dt.Columns.Add("Mark", typeof(int));

            var marksQuery = from mark in allMarks.AsEnumerable()
                             join subject in allSubjecs.AsEnumerable()
                             on mark.Field<string>("subjectId")
                             equals subject.Field<string>("subjectId")
                             where mark.Field<int>("studentId") == id
                             select dt.LoadDataRow(new object[]
                             {
                                    mark.Field<string>("SubjectId"),
                                    subject.Field<string>("sname"),
                                    mark.Field<string>("period"),
                                    mark.Field<int>("mark")
                             }, false);
            marksQuery.CopyToDataTable();
            dgv_info.DataSource = dt;

            dgv_info.AllowUserToDeleteRows = false;
            dgv_info.AllowUserToAddRows = false;
            for (int x = 0; x < dgv_info.ColumnCount; x++)
                dgv_info.Columns[x].ReadOnly = true;
        }
    }
}
