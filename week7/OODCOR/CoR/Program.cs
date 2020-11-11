using OODCOR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    class Program
    {
        static void Main(string[] args)
        {
            // Triage > Doctor > Consultant.
            Triage triage = new Triage();
            Doctor doctor = new Doctor();
            Consultant consultant = new Consultant();
            AdmissionsWard ward = new AdmissionsWard();
            Surgery surgery = new Surgery();

            triage.SetSuccessor(doctor);
            doctor.SetSuccessor(consultant);
            consultant.SetSuccessor(ward);
            consultant.SetSuccessor(surgery);

            Patient p1 = new Patient("Alison", Condition.HeadTrauma);
            Patient p2 = new Patient("Brian", Condition.Infection);
            Patient p3 = new Patient("Charlie", Condition.GeneralPain);
            Patient p4 = new Patient("Diana", Condition.Other);
            Patient p5 = new Patient("Edward", Condition.ChestPain);
            Patient p6 = new Patient("Frankie", Condition.Injury);

            triage.HandlePatient(p1);
            Console.WriteLine();
            triage.HandlePatient(p2);
            Console.WriteLine();
            triage.HandlePatient(p3);
            Console.WriteLine();
            triage.HandlePatient(p4);
            Console.WriteLine();
            triage.HandlePatient(p5);
            Console.WriteLine();
            triage.HandlePatient(p6);
            Console.ReadKey();
        }
    }
}
