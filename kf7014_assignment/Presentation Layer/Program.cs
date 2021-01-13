// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment.Forms.Appointments;
using Assignment.Forms.Patients;
using Assignment.Forms;
using Assignment.Presenters;
using Assignment.Presentation_Layer.Forms;
using Assignment.Presentation_Layer.Presenters;
using Assignment.Domain_Layer;
using System.Data.Entity;
using Data_Access_Layer;

namespace Assignment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            

            HomeForm hf = new HomeForm();
            HomePresenter hp = new HomePresenter(hf);
            Application.Run(hf);
        }
    }
}
