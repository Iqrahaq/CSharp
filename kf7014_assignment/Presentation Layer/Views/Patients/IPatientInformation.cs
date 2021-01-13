// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Presentation_Layer.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Presentation_Layer.Views
{
    public interface IPatientInformation
    {
        void setPatientID(int id);
        void setPatientName(string name);
        void setPatientGender(string gender);
        void setPatientDOB(string dob);
        void setPatientPrimary(string phone);
        void setPatientSecondary(string phone);
        void setPatientAddress(string address);
        void register(PatientInformationPresenter PIP);
    }
}
