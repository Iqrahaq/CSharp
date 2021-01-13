// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Presentation_Layer.Forms;
using Assignment.Presentation_Layer.Views;
using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Presentation_Layer.Presenters
{
    public class ConfirmationPresenter
    {
        private IConfirmation view;

        public ConfirmationPresenter(IConfirmation view)
        {
            this.view = view;
            view.register(this);
        }

        public void btn_home_Clicked()
        {
            HomeForm hForm = new HomeForm();
            HomePresenter hp = new HomePresenter(hForm);
            hForm.Show();
        }
    }
}
