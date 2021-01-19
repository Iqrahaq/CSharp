using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareBlogsMVP.Presenter;
using SoftwareBlogsMVP.Models;

namespace SoftwareBlogsMVP
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string NameTextBox
        {
            get
            {
                return lbl_name.Text;
            }
            set
            {
                lbl_name.Text = value;
            }
        }

        protected void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_name_Click(object sender, EventArgs e)
        {
            PresenterCls presenter = new PresenterCls(this, new Model());
            presenter.BindNameTextBox();
        }
    }
}
