// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Presenters;

namespace Assignment.Views
{
    public interface INewMember
    {
        String getMember();
        String getTitle();
        void setFirstName(string first);
        String getFirstName();
        String getMiddleName();
        String getLastName();
        String getGender();
        DateTime getDOB();
        String getPhone();
        String getEmergency();
        String getFirstLine();
        String getSecondLine();
        String getThirdLine();
        String getCity();
        String getCounty();
        String getPostcode();
        void register(NewMemberPresenter NMP);
    }
}
