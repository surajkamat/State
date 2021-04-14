using System;
using System.Collections.Generic;
using System.Data.Entity; //DbContext
using System.Linq;
using System.Web;

namespace StateScholarship.Models
{
    public class DBHandler:DbContext
    {
        public DBHandler()
        {
                
        }

        public virtual DbSet <UserRegistration> UserRegistrations { get; set; }
        public virtual DbSet<LoginView> Login { get; set; }
    }
}