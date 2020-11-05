using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelViewPresenter
{
    public partial class Form1 : Form, IView
    {
        private Presenter presenter = null;
        private readonly Model m_Model;

        public Form1(Model model)
        {
            m_Model = model;
            InitializeComponent();
            presenter = new Presenter(this, m_Model);
            SubscribeToModelEvents();
        }

        public string TextValue
        {
            get
            {
                return txt_main.Text;
            }
            set
            {
                txt_main.Text = value;
            }
        }

        private void SetClick(object sender, EventArgs e)
        {
            presenter.SetTextValue();
        }

        private void ReverseClick(object sender, EventArgs e)
        {
            presenter.ReverseTextValue();
        }

        private void SubscribeToModelEvents()
        {
            m_Model.TextSet += m_ModelTextSet;
        }

        void m_ModelTextSet(object sender, CustomArgs e)
        {
            this.txt_main.Text = e.m_after;
            this.lbl_main.Text = "Text changed from " + e.m_before + " to " + e.m_after;
        }
    }
}
