using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestHospital.Data;

namespace TestHospital.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("con")
        {

        }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Hospital> Hospital { get; set; }
    }
}