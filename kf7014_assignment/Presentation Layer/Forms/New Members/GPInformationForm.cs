// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Presentation_Layer.Presenters.New_Members;
using Assignment.Presentation_Layer.Views.New_Members;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.Forms.New_Members
{
    public partial class GPInformationForm : Form, IGPInformation
    {
        private GPInformationPresenter gpInformationPresenter;

        public GPInformationForm()
        {
            InitializeComponent();
        }

        private void GPInformationForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            gpInformationPresenter.btn_home_Clicked();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            gpInformationPresenter.btn_submit_Clicked();
        }

        public String getPracticeName()
        {
            return txt_practice.Text;
        }

        public String getTitle()
        {
            return cmb_title.Text;
        }

        public String getFirstName()
        {
            return txt_first.Text;
        }

        public String getMiddleName()
        {
            return txt_middle.Text;
        }

        public String getLastName()
        {
            return txt_last.Text;
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

        public void register(GPInformationPresenter GIP)
        {
            gpInformationPresenter = GIP;
        }
    }
}
