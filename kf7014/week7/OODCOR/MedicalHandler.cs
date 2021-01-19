using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODCOR
{
    public abstract class MedicalHandler
    {
        protected MedicalHandler successor;

        public virtual void SetSuccessor(MedicalHandler successor)
        {
            this.successor = successor;
        }

        public abstract void HandlePatient(Patient patient);
    }
}
