using System;
using System.Collections.Generic;
using System.Data.Entity;
using tk848615_MIS4200.Models;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace tk848615_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, tk848615_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
        }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }

        //public System.Data.Entity.DbSet<tk848615_MIS4200.Models.Product> Products { get; set; }


    }
}