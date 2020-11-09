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

        public static void Information(Patient patient)
        {
            Console.WriteLine("Patient's Health Severity: " + patient.severity.ToString());
            Console.WriteLine("Patient's Current Condition: " + patient.condition.ToString());
        }

        public override void HandlePatient(Patient patient)
        {
            patient.severity.Equals(number);
            Information(patient);
            if (patient.severity.ToString() == "VeryLow")
            {
                // Discharge and GP referral.
                Console.WriteLine("Discharged and referred to GP.");

            }
            else if ((patient.severity.ToString() == "Low" || patient.severity.ToString() == "Medium") && (patient.condition.ToString() == "Injury" || patient.condition.ToString() == "Infection"))
            {
                // Traige nurse can treat patient and then discharge them.
                Console.WriteLine("Treated by Triage Nurse and then discharged.");
            }
            else
            {
                // Refer to Doctor.
                Console.WriteLine("Referred to Doctor.");
                Doctor doctor = new Doctor(patient);
            }
        }
    }
}
