using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio.Entidades;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public class AppContext: DbContext
    {
        public DbSet<Paciente> Pacientes {get; set;}
        public DbSet<Enfermera> Enfermeras {get; set;}
        public DbSet<Medico> Medicos {get; set;}
        public DbSet<FamiliarDesignado> FamiliaresDesignados {get; set;}
        public DbSet<SignoVital> SignosVitales {get; set;}
        public DbSet<Historia> Historias {get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HospiEnCasaData");
            }
        }



        
    }
}