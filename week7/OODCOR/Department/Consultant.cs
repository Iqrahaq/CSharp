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
            Patient.Information(patient);
            if (patient.condition.ToString() == "ChestPain")
            {
                Console.WriteLine("Sent to Ward.");
                AdmissionsWard ward = new AdmissionsWard(patient);
            }
            else if (patient.condition.ToString() == "HeadTrauma")
            {
                Console.WriteLine("Sent to Surgery.");
                Surgery surgery = new Surgery(patient);
            }
            else
            {
                Console.WriteLine("Treated by Consultant and discharged.");
            }
        }
    }
}
