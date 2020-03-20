using Microsoft.EntityFrameworkCore;
using identity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace identity.Data
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"connectionstring");
        }

        public DbSet<Client> Clients { get; set; }
    }
}
