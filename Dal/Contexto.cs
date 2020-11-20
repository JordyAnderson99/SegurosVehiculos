using Microsoft.EntityFrameworkCore;
using SegurosVehiculos.Entidades;

namespace SegurosVehiculos.Dal{

    public class Contexto: DbContext{

        public DbSet<Usuarios> Usuarios {get; set;}
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            optionsBuilder.UseSqlite(@"Data Source = Data/Seguros.db");
        }
    }
}        