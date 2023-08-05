using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using New_OnlineTaxibooking.DAL;

namespace New_OnlineTaxibooking
{
    public class DB_MyonlinetaxinewoneEntities : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public  DbSet<Category> Categories { get; set; }    
        public DbSet<Product> Products { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<contact> contacts { get; set; }
    }
}