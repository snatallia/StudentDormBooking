using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;



namespace StudentDorm.Models
{
    public class StudentDormContext:DbContext
    {
        public DbSet<Room> Room { get; set; }
        public DbSet<Booking> Booking { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//migration error
        }
    }
}