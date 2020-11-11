using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODCOR
{
    public enum Condition
    {
        ChestPain,
        Injury,
        Infection,
        HeadTrauma,
        GeneralPain,
        Other
    }

    public enum Severity
    {
        VeryLow,
        Low,
        Medium,
        High,
        Critical
    }

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

        public static void Information(Patient patient)
        {
            Console.WriteLine("Patient's Name: " + patient.name);
            Console.WriteLine("Patient's Health Severity: " + patient.severity.ToString());
            Console.WriteLine("Patient's Current Condition: " + patient.condition.ToString());
        }
    }
}