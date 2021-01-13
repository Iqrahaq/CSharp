// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Forms.Patients;
using Assignment.Presentation_Layer.Forms;
using Assignment.Presentation_Layer.Views;
using Assignment.Presenters;
using Presentation_Layer.Presenters;
using Presentation_Layer.Presenters.Appointments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Presentation_Layer.Presenters
{
    public class HomePresenter
    {
        private IHome view;

        public HomePresenter(IHome view)
        {
            this.view = view;
            view.register(this);
            initialiseForm();
        }

        private void initialiseForm()
        {
            
        }

        public void btn_patlist_Clicked()
        {
            PatientListForm plForm = new PatientListForm();
            PatientListPresenter plPresenter = new PatientListPresenter(plForm);
            plForm.Show();
        }

        public void btn_applist_Clicked()
        {
            AppointmentListForm aplForm = new AppointmentListForm();
            AppointmentListPresenter aplPresenter = new AppointmentListPresenter(aplForm);
            aplForm.Show();
        }

        public void btn_newmem_Clicked()
        {
            NewMemberForm nmForm = new NewMemberForm();
            NewMemberPresenter nmPresenter = new NewMemberPresenter(nmForm);
            nmForm.Show();
        }
    }
}
