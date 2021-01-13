// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment;
using Assignment.Domain_Layer;
using Domain_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data_Access_Layer
{
    class MyDBEntities : DbContext
    {
        public MyDBEntities() 
            : base("name=connString")
        {
            
        }

        public DbSet<Person> People { get; set; }
        public DbSet<PersonAddress> PersonAddresses { get; set; }
        public DbSet<GP> GPs { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer<MyDBEntities>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
