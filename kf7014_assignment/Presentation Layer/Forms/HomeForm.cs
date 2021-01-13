// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Presentation_Layer.Presenters;
using Assignment.Presentation_Layer.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Presentation_Layer.Forms
{
    public partial class HomeForm : Form, IHome
    {
        private HomePresenter homePresenter;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_patlist_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            homePresenter.btn_patlist_Clicked();
        }

        private void btn_applist_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            homePresenter.btn_applist_Clicked();
        }

        private void btn_newmem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            homePresenter.btn_newmem_Clicked();
        }

        public void register(HomePresenter HP)
        {
            homePresenter = HP;
        }
    }
}
