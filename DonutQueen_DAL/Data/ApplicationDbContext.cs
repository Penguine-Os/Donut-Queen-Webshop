﻿using DonutQueen_Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonutQueen_DAL.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Winkel> Winkels{ get; set; }
        public DbSet<Donut> Donuts{ get; set; } 
        public DbSet<Leverancier> Leveranciers{ get; set; } 
        public DbSet<LeverancierDonut> LeverancierDonut { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Donut>().
                ToTable("Donuts")
                .Property(p => p.Prijs).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Winkel>().ToTable("Winkels");

            modelBuilder.Entity<LeverancierDonut>()
                .HasOne(x => x.Leverancier)
                .WithMany(y => y.LeverancierDonuts)
                .HasForeignKey(z => z.LeverancierId)
                .IsRequired();

            modelBuilder.Entity<LeverancierDonut>()
                .HasOne(x => x.Donut)
                .WithMany(y => y.LeverancierDonuts)
                .HasForeignKey(z => z.DonutId)
                .IsRequired();
        }

     
    }
}
