using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODCOR
{
    public class Patient
    {
        private String name;
        public Condition condition { get; set; }
        public Severity severity { get; set; }

        public Patient(String name, Condition condition)
        {
            this.name = name;
            this.condition = condition;
        }

        public override string ToString()
        {
            return name + " " + condition.ToString() + " " + severity.ToString();
        }
    }
}
