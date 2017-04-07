using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrainingApp.Entities;

namespace TrainingApp.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
            public DbSet<Entry> Entries { get; set; }
            public DbSet<Person> People { get; set; }
            public DbSet<Stack> Stacks { get; set; }
            public DbSet<Supplement> Supplements { get; set; }

            public ApplicationDbContext()
                : base("DefaultConnection", throwIfV1Schema: false)
            {
            }

            public static ApplicationDbContext Create()
            {
                return new ApplicationDbContext();
            }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
            }
    }

}