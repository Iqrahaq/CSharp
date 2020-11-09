using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODCOR
{
    class Consultant : MedicalHandler
    {
        public Consultant(Patient patient)
        {
            HandlePatient(patient);
        }

        public override void HandlePatient(Patient patient)
        {
            
        }
    }
}
