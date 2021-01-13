// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Presentation_Layer.Presenters.New_Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Presentation_Layer.Views.New_Members
{
    public interface IGPInformation
    {
        String getTitle();
        String getPracticeName();
        String getFirstName();
        String getMiddleName();
        String getLastName();
        String getPhone();
        String getEmergency();
        String getFirstLine();
        String getSecondLine();
        String getThirdLine();
        String getCity();
        String getCounty();
        String getPostcode();
        void register(GPInformationPresenter GIP);
    }
}
