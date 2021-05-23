using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Registro1_Ap2.Models;


namespace Registro1_Ap2.DAL
{

    public class Contexto : DbContext{
        
     public DbSet<Personas> Personas { get; set; }
     public DbSet<Prestamos> Prestamos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
        optionsBuilder.UseSqlite(@"Data Source= Data/Registro.db");
      }   
    }
}