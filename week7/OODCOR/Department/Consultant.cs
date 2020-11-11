using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODCOR
{
    class Consultant : MedicalHandler
    {
        protected List<MedicalHandler> successor;

        public Consultant()
        {
            successor = new List<MedicalHandler>();
        }

        public override void SetSuccessor(MedicalHandler successor)
        {
            this.successor.Add(successor);
        }

        public override void HandlePatient(Patient patient)
        {
            Patient.Information(patient);
            if (patient.condition == Condition.ChestPain)
            {
                Console.WriteLine("Sent to Ward.");
                successor[0].HandlePatient(patient);
            }
            else if (patient.condition == Condition.HeadTrauma)
            {
                Console.WriteLine("Sent to Surgery.");
                successor[1].HandlePatient(patient);
            }
            else
            {
                Console.WriteLine("Treated by Consultant and discharged.");
            }
        }
    }
}
