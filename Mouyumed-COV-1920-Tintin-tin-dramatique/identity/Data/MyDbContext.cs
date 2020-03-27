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
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lydav\Desktop\git-repo\identity-server\Mouyumed-COV-1920-Tintin-tin-dramatique\identity\Data\Database1.mdf;Integrated Security=True");
            
            //optionsBuilder.UseSqlServer(@"Server=localhost:3306;Database=test;User Id=test;Password=;");//, x => x.MigrationsAssembly("Mouyumed_COV_1920_Tintin_tin_dramatique.Migrations"));
        }

        public DbSet<Client> Clients { get; set; }
    }
}
