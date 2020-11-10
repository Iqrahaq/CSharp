using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODCOR
{
    public abstract class MedicalHandler
    {
        protected List<MedicalHandler> successor = new List<MedicalHandler>();

        public virtual void SetSuccessor(List<MedicalHandler> successor)
        {
            this.successor = successor;
            successor.Add(this);
        }

        public abstract void HandlePatient(Patient patient);
    }
}
