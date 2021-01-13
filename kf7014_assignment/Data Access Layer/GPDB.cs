// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Domain_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data_Access_Layer
{
    public class GPDB
    {
        public static void InsertGP(GP gp)
        {
            using (var context = new MyDBEntities())
            {
                context.GPs.Add(gp);
                context.SaveChanges();
            }
        }
    }
}
