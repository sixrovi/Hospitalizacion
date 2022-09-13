using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class AppContext : DbContext
    {
        //public DbSet<Persona> Personas {get; set;}
        
        public DbSet<Enfermera> Enfermera {get; set; }
        public DbSet<FamiliarDesignado> Familiares {get; set; }
        public DbSet<Historia> HistoriasClinicas {get; set; }
        public DbSet<Medico> Medicos {get; set; }
        public DbSet<Paciente> Pacientes {get; set; }
        public DbSet<SignoVital> SignosVitales {get; set; }
        public DbSet<SugerenciaCuidado> SugerenciasCuidados {get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if( !optionsBuilder.IsConfigured )
        {
            optionsBuilder.UseSqlServer("Data Source = (Localdb)\\MSSQLLocalDB; Initial Catalog  = HospiEnCasaData");
        }
    }

    }
}