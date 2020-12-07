﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SegurosVehiculos.Dal;

namespace SegurosVehiculos.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SegurosVehiculos.Entidades.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cedula")
                        .HasColumnType("TEXT");

                    b.Property<double>("Celular")
                        .HasColumnType("REAL");

                    b.Property<string>("CorreoElectronico")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<double>("Telefono")
                        .HasColumnType("REAL");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SegurosVehiculos.Entidades.Colores", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .HasColumnType("TEXT");

                    b.HasKey("ColorId");

                    b.ToTable("Colores");

                    b.HasData(
                        new
                        {
                            ColorId = 1,
                            Color = "Verde"
                        },
                        new
                        {
                            ColorId = 2,
                            Color = "Rojo"
                        },
                        new
                        {
                            ColorId = 3,
                            Color = "Azul"
                        },
                        new
                        {
                            ColorId = 4,
                            Color = "Blanco"
                        },
                        new
                        {
                            ColorId = 5,
                            Color = "Negro"
                        });
                });

            modelBuilder.Entity("SegurosVehiculos.Entidades.Cotizaciones", b =>
                {
                    b.Property<int>("CotizacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadCuotas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.Property<string>("Observaciones")
                        .HasColumnType("TEXT");

                    b.Property<int>("TipoSeguroId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CotizacionId");

                    b.ToTable("Cotizaciones");
                });

            modelBuilder.Entity("SegurosVehiculos.Entidades.CotizacionesDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadCuotas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CotizacionId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.Property<int>("NumeroCuota")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoSeguroId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CotizacionId");

                    b.ToTable("CotizacionesDetalle");
                });

            modelBuilder.Entity("SegurosVehiculos.Entidades.MarcaVehiculos", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Marca")
                        .HasColumnType("TEXT");

                    b.HasKey("MarcaId");

                    b.ToTable("MarcaVehiculos");

                    b.HasData(
                        new
                        {
                            MarcaId = 1,
                            Marca = "Tauro Turbo"
                        },
                        new
                        {
                            MarcaId = 2,
                            Marca = "Toyota"
                        },
                        new
                        {
                            MarcaId = 3,
                            Marca = "Mercedes Benz"
                        },
                        new
                        {
                            MarcaId = 4,
                            Marca = "Lamborghini"
                        },
                        new
                        {
                            MarcaId = 5,
                            Marca = "BMW"
                        });
                });

            modelBuilder.Entity("SegurosVehiculos.Entidades.Modelos", b =>
                {
                    b.Property<int>("ModeloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ModeloVehiculo")
                        .HasColumnType("TEXT");

                    b.HasKey("ModeloId");

                    b.ToTable("Modelos");

                    b.HasData(
                        new
                        {
                            ModeloId = 1,
                            ModeloVehiculo = "Camry"
                        },
                        new
                        {
                            ModeloId = 2,
                            ModeloVehiculo = "Urus"
                        },
                        new
                        {
                            ModeloId = 3,
                            ModeloVehiculo = "I8"
                        },
                        new
                        {
                            ModeloId = 4,
                            ModeloVehiculo = "R5"
                        },
                        new
                        {
                            ModeloId = 5,
                            ModeloVehiculo = "GLE 63"
                        });
                });

            modelBuilder.Entity("SegurosVehiculos.Entidades.Pagos", b =>
                {
                    b.Property<int>("PagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroCuotaId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Total")
                        .HasColumnType("REAL");

                    b.Property<int>("VentaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PagoId");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("SegurosVehiculos.Entidades.StatusVehiculo", b =>
                {
                    b.Property<int>("StatusVehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.HasKey("StatusVehiculoId");

                    b.ToTable("StatusVehiculo");

                    b.HasData(
                        new
                        {
                            StatusVehiculoId = 1,
                            Status = "Vehiculo Tiene Opsicion"
                        },
                        new
                        {
                            StatusVehiculoId = 2,
                            Status = "No tiene oposicon"
                        });
                });

            modelBuilder.Entity("SegurosVehiculos.Entidades.TipoEmision", b =>
                {
                    b.Property<int>("TipoEmisionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Emision")
                        .HasColumnType("TEXT");

                    b.HasKey("TipoEmisionId");

                    b.ToTable("TipoEmision");

                    b.HasData(
                        new
                        {
                            TipoEmisionId = 1,
                            Emision = "Exoneracion Ley 168"
                        },
                        new
                        {
                            TipoEmisionId = 2,
                            Emision = "No es Exonerado"
                        });
                });

            modelBuilder.Entity("SegurosVehiculos.Entidades.TipoSeguros", b =>
                {
                    b.Property<int>("TipoSeguroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Seguros")
                        .HasColumnType("TEXT");

                    b.HasKey("TipoSeguroId");

                    b.ToTable("TipoSeguros");

                    b.HasData(
                        new
                        {
                            TipoSeguroId = 1,
                            Seguros = "FULL"
                        },
                        new
                        {
                            TipoSeguroId = 2,
                            Seguros = "De Ley"
                        });
                });

            modelBuilder.Entity("SegurosVehiculos.Entidades.TipoVehiculo", b =>
                {
                    b.Property<int>("TipoVehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tipo")
                        .HasColumnType("TEXT");

                    b.HasKey("TipoVehiculoId");

                    b.ToTable("TipoVehiculo");

                    b.HasData(
                        new
                        {
                            TipoVehiculoId = 1,
                            Tipo = "Privado"
                        },
                        new
                        {
                            TipoVehiculoId = 2,
                            Tipo = "Publico"
                        });
                });

            modelBuilder.Entity("SegurosVehiculos.Entidades.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .HasColumnType("TEXT");

                    b.Property<string>("Clave")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            Apellido = "Lopez",
                            Clave = "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5",
                            Fecha = new DateTime(2020, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Raldy",
                            NombreUsuario = "Admin"
                        });
                });

            modelBuilder.Entity("SegurosVehiculos.Entidades.Vehiculos", b =>
                {
                    b.Property<int>("VehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AñoFabricacion")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadPasajeros")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CapacidadCarga")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Chasis")
                        .HasColumnType("TEXT");

                    b.Property<int>("Cilindros")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ColorId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaExpedicionMatricula")
                        .HasColumnType("TEXT");

                    b.Property<double>("FuerzaMotriz")
                        .HasColumnType("REAL");

                    b.Property<int>("MarcaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Matricula")
                        .HasColumnType("TEXT");

                    b.Property<int>("ModeloId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Motor")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusVehiculoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoEmisionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoVehiculoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TotalPuertas")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Uso")
                        .HasColumnType("TEXT");

                    b.Property<double>("ValorVehiculo")
                        .HasColumnType("REAL");

                    b.HasKey("VehiculoId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("SegurosVehiculos.Entidades.Ventas", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadCuotas")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.Property<int>("NumeroCuotaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Observacion")
                        .HasColumnType("TEXT");

                    b.Property<int>("TipoSeguroId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Vence")
                        .HasColumnType("TEXT");

                    b.HasKey("VentaId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("SegurosVehiculos.Entidades.VentasDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Balance")
                        .HasColumnType("REAL");

                    b.Property<int>("CantidadCuotas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.Property<int>("TipoSeguroId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VentaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("VentaId");

                    b.ToTable("VentasDetalle");
                });

            modelBuilder.Entity("SegurosVehiculos.Entidades.CotizacionesDetalle", b =>
                {
                    b.HasOne("SegurosVehiculos.Entidades.Cotizaciones", null)
                        .WithMany("Detalle")
                        .HasForeignKey("CotizacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SegurosVehiculos.Entidades.VentasDetalle", b =>
                {
                    b.HasOne("SegurosVehiculos.Entidades.Ventas", null)
                        .WithMany("Detalle")
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SegurosVehiculos.Entidades.Cotizaciones", b =>
                {
                    b.Navigation("Detalle");
                });

            modelBuilder.Entity("SegurosVehiculos.Entidades.Ventas", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
