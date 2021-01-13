// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment;
using Assignment.Domain_Layer;
using Domain_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment.Domain_Layer.Person;

namespace Assignment.Data_Access_Layer
{
    public class AppointmentDB
    {
        public static void InsertAppointment(Appointment appointment)
        {
            using (var context = new MyDBEntities())
            {
                context.Appointments.Add(appointment);
                context.SaveChanges();
            }
        }
    }
}
