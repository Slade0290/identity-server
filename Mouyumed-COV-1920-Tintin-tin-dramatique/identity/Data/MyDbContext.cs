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
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=EFGetStarted.ConsoleApp.NewDb;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer(@"Server=localhost:3306;Database=test;User Id=;Password=;");//, x => x.MigrationsAssembly("Mouyumed_COV_1920_Tintin_tin_dramatique.Migrations"));
        }

        public DbSet<Client> Clients { get; set; }
    }
}
