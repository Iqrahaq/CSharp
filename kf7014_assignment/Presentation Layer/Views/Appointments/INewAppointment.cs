// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Presenters;
using Presentation_Layer.Presenters;

namespace Assignment.Views
{
    public interface INewAppointment
    {
        String getAppointmentType();
        void setAppointmentTypes(List<String> types);
        DateTime getAppointmentDate();
        String getAppointmentTime();
        String getAppointmentDentist();
        void setAppointmentDentists(List<string> dentists);
        String getAppointmentNotes();
        void setPatientName(String name);
        void setPatientNumber(String number);
        void setPatientDOB(String dob);
        void setPatientAddress(String address);
        void register(NewAppointmentPresenter NAP);
    }
}
