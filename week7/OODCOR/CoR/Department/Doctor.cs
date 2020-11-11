using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODCOR
{
    class Doctor : MedicalHandler
    {
        public override void HandlePatient(Patient patient)
        {
            Patient.Information(patient);
            if (patient.severity == Severity.Critical|| patient.severity == Severity.High && ((patient.condition == Condition.HeadTrauma || patient.condition == Condition.ChestPain)))
            {
                // Refer to Consultant.
                Console.WriteLine("Referred to Consultant.");
            }
            else
            {
                // Treat and Discharge.
                Console.WriteLine("Treated by Doctor and discharged.");
            }
        }
    }
}
