using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODCOR
{
    class Doctor : MedicalHandler
    {
        public Doctor(Patient patient)
        {
            HandlePatient(patient);
        }

        public override void HandlePatient(Patient patient)
        {
            Patient.Information(patient);
            if (patient.severity.ToString() == "Critical" || patient.severity.ToString() == "High" && ((patient.condition.ToString() == "HeadTrauma" || patient.condition.ToString() == "ChestPain")))
            {
                // Refer to Consultant.
                Console.WriteLine("Referred to Consultant.");
                Consultant consultant = new Consultant(patient);
            }
            else
            {
                // Treat and Discharge.
                Console.WriteLine("Treated by Doctor and discharged.");
            }
        }
    }
}
