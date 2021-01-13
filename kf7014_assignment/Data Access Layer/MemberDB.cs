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
    public class MemberDB
    {
        public static void InsertMember(Person person)
        {
            using (var context = new MyDBEntities())
            {
                context.People.Add(person);
                context.SaveChanges();
            }
        }

        public static void InsertGP(Person gp)
        {
            using (var context = new MyDBEntities())
            {
                gp.PersonMember = Member.GP;
                gp.PersonDOB = new DateTime(2021, 01, 01);
                context.People.Add(gp);
                context.SaveChanges();
            }
        }
    }
}
