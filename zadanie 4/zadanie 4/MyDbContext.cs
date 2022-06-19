﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class MyDbContext : DbContext
    {
        public DbSet<Client> Clients { set; get; }
        public DbSet<Order> Orders { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\DESKTOP-OSC0UN5;Initial Catalog=PIV2-Relations;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        ////protected override void OnModelCreating(ModelBuilder modelbuilder)
        ////{
        ////    base.OnModelCreating(modelbuilder);
        ////    modelbuilder.Entity<Client>().Property("Id")
        ////    .IsRequired()
        ////    .HasMaxLength(50);
        ////    modelbuilder.Entity<Order>
        ////}

    }
}
