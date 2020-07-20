using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AspNet.Models;

namespace AspNet.Data
{
    public class StudentContext:DbContext
    {
        public StudentContext():base("Server=DESKTOP-5SNTQAJ;Database=School;Trusted_connection=true;")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}