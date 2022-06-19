using Microsoft.EntityFrameworkCore;
using projekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab5
{
    internal class MyDbContext : DbContext
    {
        public DbSet<wlasciciel> wlasciciel { set; get; }
        public DbSet<samochod> samochod { set; get; }
        public DbSet<dokumenty> dokumenty { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projekt;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {







        }

    }
}
