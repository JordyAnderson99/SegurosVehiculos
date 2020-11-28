using Microsoft.EntityFrameworkCore;
using SegurosVehiculos.Entidades;
using System;



namespace SegurosVehiculos.Dal{

    public class Contexto: DbContext{

        public DbSet<Usuarios> Usuarios {get; set;}
        public DbSet<Clientes> Clientes {get; set;}
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            optionsBuilder.UseSqlite(@"Data Source = Data/Seguros.db");
        }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.Entity<Usuarios>().HasData(new Usuarios
             {UsuarioId = 1,
              Nombre = "Raldy",
               Apellido = "Lopez",
               Fecha = new DateTime(2020,11,22),
               NombreUsuario = "Admin",
               Clave = "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5",
                 }); // Calve 12345
         }        
    }
}        