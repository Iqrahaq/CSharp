using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OODCOR
{
    public class Triage : MedicalHandler
    {
        Random random = new Random();
        public override void HandlePatient(Patient patient)
        {
            int number = random.Next(0, 5);
            patient.severity.Equals(number);

            Patient.Information(patient);
            switch (number) {
                case 0:
                    patient.severity = Severity.VeryLow;
                    break;
                case 1:
                    patient.severity = Severity.Low;
                    break;
                case 2:
                    patient.severity = Severity.Medium;
                    break;
                case 3:
                    patient.severity = Severity.High;
                    break;
                case 4:
                    patient.severity = Severity.Critical;
                    break;
            }

            if (patient.severity == Severity.VeryLow)
            {
                Console.WriteLine("Discharged and referred to GP.");
            }
            else if ((patient.severity == Severity.Low || patient.severity == Severity.Medium) && (patient.condition == Condition.Injury || patient.condition == Condition.Infection))
            {
                Console.WriteLine("Treated by Triage Nurse and then discharged.");
            }
            else
            {
                Console.WriteLine("Referred to Doctor.");
            }
        }
    }
}
