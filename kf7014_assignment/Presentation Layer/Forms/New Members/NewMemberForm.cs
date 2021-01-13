// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment.Presenters;
using Assignment.Views;

namespace Assignment.Forms.Patients
{
    public partial class NewMemberForm : Form, INewMember
    {
        private NewMemberPresenter newMemberPresenter;

        public NewMemberForm()
        {
            InitializeComponent();
        }

        private void MemberInformationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            newMemberPresenter.btn_home_Clicked();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            newMemberPresenter.btn_submit_Clicked();
        }

        public String getMember()
        {
            return cmb_type.SelectedItem.ToString();
        }

        public String getTitle()
        {
            return cmb_title.Text;
        }

        public String getFirstName()
        {
            return txt_first.Text;
        }

        public void setFirstName(string first)
        {
            txt_first.Text = first;
        }

        public String getMiddleName()
        {
            return txt_middle.Text;
        }

        public String getLastName()
        {
            return txt_last.Text;
        }

        public String getGender()
        {
            return cmb_gender.SelectedItem.ToString();
        }

        public DateTime getDOB()
        {
            return dte_dob.Value.Date;
        }

        public String getPhone()
        {
            return txt_phone.Text;
        }

        public String getEmergency()
        {
            return txt_emer.Text;
        }

        public String getFirstLine()
        {
            return txt_fline.Text;
        }

        public String getSecondLine()
        {
            return txt_sline.Text;
        }

        public String getThirdLine()
        {
            return txt_tline.Text;
        }

        public String getCity()
        {
            return txt_city.Text;
        }

        public String getCounty()
        {
            return txt_county.Text;
        }

        public String getPostcode()
        {
            return txt_postcode.Text;
        }

        public void register(NewMemberPresenter NMP)
        {
            newMemberPresenter = NMP;
        }
    }
}