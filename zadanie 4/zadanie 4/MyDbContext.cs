using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie_4;

namespace lab5
{
    internal class MyDbContext : DbContext
    {
        public DbSet<Autor> Autor { set; get; }
        public DbSet<Ksiazka> Ksiazka { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Zadanie;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {




            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<Autor>().Property("Nazwisko");

            //modelbuilder.Entity<Ksiazka>;
        }

    }
}