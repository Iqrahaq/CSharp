using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Converter
{
    public partial class Form1 : Form
    {
        Centigrade c;
        Fahrenheit f;


        public Form1()
        {
            c = new Centigrade();
            f = new Fahrenheit();
            f.setTemperature(c.convertToFahrenheit());

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_cent.Text = c.getTemperature().ToString();
            txt_fahr.Text = f.getTemperature().ToString();
        }

        private void txt_cent_Leave(object sender, EventArgs e)
        {
            ProcessCent();
        }

        private void txt_cent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                ProcessCent();
            }
        }

        private void ProcessCent()
        {
            double value;
            if (Double.TryParse(txt_cent.Text.Trim(), out value))
            {
                c.setTemperature(value);
                f.setTemperature(c.convertToFahrenheit());
                txt_fahr.Text = f.getTemperature().ToString();
            }
            else
            {
                txt_cent.Text = c.getTemperature().ToString();
                MessageBox.Show("Only Numbers!");
            }
        }

        public void ProcessFahr()
        {
            double value;
            if(Double.TryParse(txt_fahr.Text.Trim(), out value))
            {
                f.setTemperature(value);
                c.setTemperature(f.convertToCentigrade());
                txt_cent.Text = c.getTemperature().ToString();
            }
            else
            {
                txt_fahr.Text = f.getTemperature().ToString();
                MessageBox.Show("Only Numbers!");
            }
        }

        private void txt_fahr_Leave(object sender, EventArgs e)
        {
            ProcessFahr();
        }

        private void txt_fahr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)(Keys.Enter))
            {
                ProcessFahr();
            }
        }
    }
}
