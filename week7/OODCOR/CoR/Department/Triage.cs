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
        public override void HandlePatient(Patient patient)
        {
            Random random = new Random();
            int number = random.Next(0, 5);
            patient.severity.Equals(number);


            Patient.Information(patient);
            if (number == 0)
                patient.severity = Severity.VeryLow;
            if (number == 1)
                patient.severity = Severity.Low;
            if (number == 2)
                patient.severity = Severity.Medium;
            if (number == 3)
                patient.severity = Severity.High;
            if (number == 4)
                patient.severity = Severity.Critical;



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
