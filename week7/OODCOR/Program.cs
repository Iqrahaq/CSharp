using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OODCOR
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
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

            triage.HandlePatient(p2);
            //triage.HandlePatient(p2);
            //triage.HandlePatient(p3);
            //triage.HandlePatient(p4);
            //triage.HandlePatient(p5);
            //triage.HandlePatient(p6);
            Console.ReadKey();
        }
    }
}
