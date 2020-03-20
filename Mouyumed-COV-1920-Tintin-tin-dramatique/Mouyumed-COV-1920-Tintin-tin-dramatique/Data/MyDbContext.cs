using Microsoft.EntityFrameworkCore;
using Mouyumed_COV_1920_Tintin_tin_dramatique.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mouyumed_COV_1920_Tintin_tin_dramatique.Data
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
