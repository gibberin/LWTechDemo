using Loaner.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loaner.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<Item>().HasData(
                                new Item() { Id = 1, Name = "Test Item", Size = 11, Value = 101 }
                            ) ;
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<LoanEvent> LoanEvents { get; set; }
    }
}
