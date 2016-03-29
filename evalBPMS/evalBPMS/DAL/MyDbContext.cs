using evalBPMS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evalBPMS.DAL
{
   
        public class MyDbContext : DbContext
        {

            public MyDbContext() : base("MyDbContextConnectionString")
            {
                Database.SetInitializer<MyDbContext>(new MyDbInitializer());
            }
        
            public DbSet<User> User { get; set; }
            public DbSet<Rol> Rol { get; set; }
            public DbSet<Tool> Tool { get; set; }
            public DbSet<Threshold> Threshold { get; set; }
            public DbSet<Characteristic> Characteristic { get; set; }
            public DbSet<Category> Category { get; set; }
            public DbSet<Evaluation> Evaluation { get; set; }
            public DbSet<Importance> Importance { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }
    
}
