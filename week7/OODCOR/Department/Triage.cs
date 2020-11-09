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

        public Triage()
        {
            
        }

        public override void HandlePatient(Patient patient)
        {
            if (Enum.IsDefined(typeof (Severity.severity), number))
            {

            }
        }
    }
}
