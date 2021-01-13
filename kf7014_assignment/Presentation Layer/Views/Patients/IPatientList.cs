// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Presentation_Layer.Presenters;
using Presentation_Layer.Presenters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Presentation_Layer.Views
{
    public interface IPatientList
    {
        void setPatients(DataSet source);
        void register(PatientListPresenter PLP);
    }
}
