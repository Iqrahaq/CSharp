using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Schema;

namespace OODCOR
{
    public class Triage : MedicalHandler
    {
        private readonly Random random = new Random();

        private int number 
        {
            get 
            {
                return number;
            }
            set
            {
                number = random.Next(0,5);
            }
        }

        public Triage(Patient patient)
        {
            HandlePatient(patient);
        }

        public override void HandlePatient(Patient patient)
        {
            patient.severity.Equals(number);
            Patient.Information(patient);
            if (patient.severity.ToString() == "VeryLow")
            {
                Console.WriteLine("Discharged and referred to GP.");

            }
            else if ((patient.severity.ToString() == "Low" || patient.severity.ToString() == "Medium") && (patient.condition.ToString() == "Injury" || patient.condition.ToString() == "Infection"))
            {
                Console.WriteLine("Treated by Triage Nurse and then discharged.");
            }
            else
            {
                Console.WriteLine("Referred to Doctor.");
                Doctor doctor = new Doctor(patient);
            }
        }
    }
}
