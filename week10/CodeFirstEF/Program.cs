using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDBEntities())
            {
                var studentList = context.Students.ToList<Student>();
                Address a = new Address();
                a.AddressId = 1;
                a.NumberorName = "20";
                a.PostCode = "LL00 GP4";
                a.Street = "BackOfBehold";
                a.Town = "Trumpton";

                context.Addresses.Add(a);
                context.SaveChanges();
            }
        }
    }
}
