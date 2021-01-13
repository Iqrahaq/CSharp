// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Presentation_Layer.Presenters.Appointments;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Presentation_Layer.Views
{
    public interface IAppointmentList
    {
        void setAppointments(DataSet source);
        void register(AppointmentListPresenter ALP);
    }
}
