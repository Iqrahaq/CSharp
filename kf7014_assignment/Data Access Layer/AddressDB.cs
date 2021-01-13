// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment;
using Assignment.Domain_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data_Access_Layer
{
    public class AddressDB
    {
        public static void InsertAddress(PersonAddress address)
        {
            using (var context = new MyDBEntities())
            {
                context.PersonAddresses.Add(address);
                context.SaveChanges();
            }
        }
    }
}
