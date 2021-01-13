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
    public partial class ConfirmationForm : Form, IConfirmation
    {
        private ConfirmationPresenter confirmationPresenter;
        public ConfirmationForm()
        {
            InitializeComponent();
        }

        private void ConfirmationForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            confirmationPresenter.btn_home_Clicked();
        }

        public void register(ConfirmationPresenter CP)
        {
            confirmationPresenter = CP;
        }
    }
}
