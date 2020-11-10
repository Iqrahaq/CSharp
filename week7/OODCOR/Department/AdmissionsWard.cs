using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODCOR
{
    class AdmissionsWard : MedicalHandler
    {
        public AdmissionsWard(Patient patient)
        {
            HandlePatient(patient);
        }
        public override void HandlePatient(Patient patient)
        {
            Patient.Information(patient);
            Console.WriteLine("Patient is currently in the ward.");
        }
    }
}
