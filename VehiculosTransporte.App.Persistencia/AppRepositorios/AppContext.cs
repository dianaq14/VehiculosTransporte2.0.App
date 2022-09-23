using Microsoft.EntityFrameworkCore;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Duenio> Duenios {get; set;}
        public DbSet<Conductor> Conductores {get; set;}
        public DbSet<Mecanico> Mecanicos {get; set;}
        public DbSet<Vehiculo> Vehiculos  {get; set;}
        public DbSet<JefeOperaciones> JefesOperaciones {get; set;}
        public DbSet<Revision> Revisiones {get; set;}
        public DbSet<ServicioTransporte> ServiciosTransporte {get; set;}
         
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog = EmpresaTransporteData");
            }
        }
}
}