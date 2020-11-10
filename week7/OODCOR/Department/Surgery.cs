using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODCOR
{
    public class Surgery : MedicalHandler
    {
        public Surgery(Patient patient)
        {
            HandlePatient(patient);
        }
        public override void HandlePatient(Patient patient)
        {
            Patient.Information(patient);
            Console.WriteLine("Patient is currently in surgery.");
        }
    }
}
