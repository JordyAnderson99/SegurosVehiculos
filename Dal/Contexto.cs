using Microsoft.EntityFrameworkCore;
using SegurosVehiculos.Entidades;
using System;

namespace SegurosVehiculos.Dal
{

    public class Contexto : DbContext
    {

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Vehiculos> Vehiculos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Colores> Colores { get; set; }
        public DbSet<MarcaVehiculos> MarcaVehiculos { get; set; }
        public DbSet<Modelos> Modelos { get; set; }
        public DbSet<StatusVehiculo> StatusVehiculo { get; set; }
        public DbSet<TipoEmision> TipoEmision { get; set; }
        public DbSet<TipoVehiculo> TipoVehiculo { get; set; }
        public DbSet<Cotizaciones> Cotizaciones { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<TipoSeguros> TipoSeguros { get; set; }
        public DbSet<Pagos> Pagos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite(@"Data Source = Data/Seguros.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                UsuarioId = 1,
                Nombre = "Raldy",
                Apellido = "Lopez",
                Fecha = new DateTime(2020, 11, 22),
                NombreUsuario = "Admin",
                Clave = "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5",
            }); // Calve 12345


            //------------------Colores--------------------
            modelBuilder.Entity<Colores>().HasData(new Colores { ColorId = 1, Color = "Verde" });
            modelBuilder.Entity<Colores>().HasData(new Colores { ColorId = 2, Color = "Rojo" });
            modelBuilder.Entity<Colores>().HasData(new Colores { ColorId = 3, Color = "Azul" });
            modelBuilder.Entity<Colores>().HasData(new Colores { ColorId = 4, Color = "Blanco" });
            modelBuilder.Entity<Colores>().HasData(new Colores { ColorId = 5, Color = "Negro" });

            //------------------Marca de los Vehiculos--------------------
            modelBuilder.Entity<MarcaVehiculos>().HasData(new MarcaVehiculos { MarcaId = 1, Marca = "Tauro Turbo" });
            modelBuilder.Entity<MarcaVehiculos>().HasData(new MarcaVehiculos { MarcaId = 2, Marca = "Toyota" });
            modelBuilder.Entity<MarcaVehiculos>().HasData(new MarcaVehiculos { MarcaId = 3, Marca = "Mercedes Benz" });
            modelBuilder.Entity<MarcaVehiculos>().HasData(new MarcaVehiculos { MarcaId = 4, Marca = "Lamborghini" });
            modelBuilder.Entity<MarcaVehiculos>().HasData(new MarcaVehiculos { MarcaId = 5, Marca = "BMW" });

            //------------------Modelo de los Vehiculos--------------------
            modelBuilder.Entity<Modelos>().HasData(new Modelos { ModeloId = 1, ModeloVehiculo = "Camry" });
            modelBuilder.Entity<Modelos>().HasData(new Modelos { ModeloId = 2, ModeloVehiculo = "Urus" });
            modelBuilder.Entity<Modelos>().HasData(new Modelos { ModeloId = 3, ModeloVehiculo = "I8" });
            modelBuilder.Entity<Modelos>().HasData(new Modelos { ModeloId = 4, ModeloVehiculo = "R5" });
            modelBuilder.Entity<Modelos>().HasData(new Modelos { ModeloId = 5, ModeloVehiculo = "GLE 63" });


            //------------------Status de los Vehiculos--------------------
            modelBuilder.Entity<StatusVehiculo>().HasData(new StatusVehiculo { StatusVehiculoId = 1, Status = "Vehiculo Tiene Opsicion" });
            modelBuilder.Entity<StatusVehiculo>().HasData(new StatusVehiculo { StatusVehiculoId = 2, Status = "No tiene oposicon" });
       

            //------------------Status de los Vehiculos--------------------
            modelBuilder.Entity<TipoEmision>().HasData(new TipoEmision { TipoEmisionId = 1, Emision = "Exoneracion Ley 168" });
            modelBuilder.Entity<TipoEmision>().HasData(new TipoEmision { TipoEmisionId = 2, Emision = "No es Exonerado" });

            //------------------Tipo de Vehiculos--------------------
            modelBuilder.Entity<TipoVehiculo>().HasData(new TipoVehiculo { TipoVehiculoId = 1, Tipo = "Motocicleta" });
            modelBuilder.Entity<TipoVehiculo>().HasData(new TipoVehiculo { TipoVehiculoId = 2, Tipo = "Carro"});
            modelBuilder.Entity<TipoVehiculo>().HasData(new TipoVehiculo { TipoVehiculoId = 3, Tipo = "Jeepeta" });
            modelBuilder.Entity<TipoVehiculo>().HasData(new TipoVehiculo { TipoVehiculoId = 4, Tipo = "Camioneta"});
            modelBuilder.Entity<TipoVehiculo>().HasData(new TipoVehiculo { TipoVehiculoId = 5, Tipo = "Camión"});
            
            
            //------------------Tipo de Seguros--------------------
            modelBuilder.Entity<TipoSeguros>().HasData(new TipoSeguros { TipoSeguroId = 1, Seguros = "FULL"  });
            modelBuilder.Entity<TipoSeguros>().HasData(new TipoSeguros { TipoSeguroId = 2, Seguros = "De Ley", ValorSeguro = 20000 });

        }
    }
}