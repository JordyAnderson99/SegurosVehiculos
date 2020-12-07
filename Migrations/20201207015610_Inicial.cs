using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SegurosVehiculos.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Apellido = table.Column<string>(type: "TEXT", nullable: true),
                    Direccion = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<double>(type: "REAL", nullable: false),
                    Celular = table.Column<double>(type: "REAL", nullable: false),
                    Cedula = table.Column<string>(type: "TEXT", nullable: true),
                    CorreoElectronico = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Colores",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Color = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colores", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "Cotizaciones",
                columns: table => new
                {
                    CotizacionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoSeguroId = table.Column<int>(type: "INTEGER", nullable: false),
                    Monto = table.Column<double>(type: "REAL", nullable: false),
                    Observaciones = table.Column<string>(type: "TEXT", nullable: true),
                    CantidadCuotas = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotizaciones", x => x.CotizacionId);
                });

            migrationBuilder.CreateTable(
                name: "MarcaVehiculos",
                columns: table => new
                {
                    MarcaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Marca = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcaVehiculos", x => x.MarcaId);
                });

            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    ModeloId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ModeloVehiculo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.ModeloId);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    PagoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    VentaId = table.Column<int>(type: "INTEGER", nullable: false),
                    NumeroCuotaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Total = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.PagoId);
                });

            migrationBuilder.CreateTable(
                name: "StatusVehiculo",
                columns: table => new
                {
                    StatusVehiculoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Status = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusVehiculo", x => x.StatusVehiculoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoEmision",
                columns: table => new
                {
                    TipoEmisionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Emision = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEmision", x => x.TipoEmisionId);
                });

            migrationBuilder.CreateTable(
                name: "TipoSeguros",
                columns: table => new
                {
                    TipoSeguroId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Seguros = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoSeguros", x => x.TipoSeguroId);
                });

            migrationBuilder.CreateTable(
                name: "TipoVehiculo",
                columns: table => new
                {
                    TipoVehiculoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tipo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVehiculo", x => x.TipoVehiculoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Apellido = table.Column<string>(type: "TEXT", nullable: true),
                    NombreUsuario = table.Column<string>(type: "TEXT", nullable: true),
                    Clave = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CantidadPasajeros = table.Column<int>(type: "INTEGER", nullable: false),
                    Cilindros = table.Column<int>(type: "INTEGER", nullable: false),
                    Uso = table.Column<string>(type: "TEXT", nullable: true),
                    Chasis = table.Column<string>(type: "TEXT", nullable: true),
                    Matricula = table.Column<string>(type: "TEXT", nullable: true),
                    ValorVehiculo = table.Column<double>(type: "REAL", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaExpedicionMatricula = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AñoFabricacion = table.Column<int>(type: "INTEGER", nullable: false),
                    Motor = table.Column<string>(type: "TEXT", nullable: true),
                    FuerzaMotriz = table.Column<double>(type: "REAL", nullable: false),
                    CapacidadCarga = table.Column<double>(type: "REAL", nullable: false),
                    TotalPuertas = table.Column<int>(type: "INTEGER", nullable: false),
                    ColorId = table.Column<int>(type: "INTEGER", nullable: false),
                    MarcaId = table.Column<int>(type: "INTEGER", nullable: false),
                    ModeloId = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusVehiculoId = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoEmisionId = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoVehiculoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.VehiculoId);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    VentaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Vence = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoSeguroId = table.Column<int>(type: "INTEGER", nullable: false),
                    NumeroCuotaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Monto = table.Column<double>(type: "REAL", nullable: false),
                    Observacion = table.Column<string>(type: "TEXT", nullable: true),
                    CantidadCuotas = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.VentaId);
                });

            migrationBuilder.CreateTable(
                name: "CotizacionesDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CotizacionId = table.Column<int>(type: "INTEGER", nullable: false),
                    NumeroCuota = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadCuotas = table.Column<int>(type: "INTEGER", nullable: false),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoSeguroId = table.Column<int>(type: "INTEGER", nullable: false),
                    Monto = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CotizacionesDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CotizacionesDetalle_Cotizaciones_CotizacionId",
                        column: x => x.CotizacionId,
                        principalTable: "Cotizaciones",
                        principalColumn: "CotizacionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VentasDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VentaId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Monto = table.Column<double>(type: "REAL", nullable: false),
                    Balance = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentasDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VentasDetalle_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VentasDetalle_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "VentaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Colores",
                columns: new[] { "ColorId", "Color" },
                values: new object[] { 1, "Verde" });

            migrationBuilder.InsertData(
                table: "Colores",
                columns: new[] { "ColorId", "Color" },
                values: new object[] { 2, "Rojo" });

            migrationBuilder.InsertData(
                table: "Colores",
                columns: new[] { "ColorId", "Color" },
                values: new object[] { 3, "Azul" });

            migrationBuilder.InsertData(
                table: "Colores",
                columns: new[] { "ColorId", "Color" },
                values: new object[] { 4, "Blanco" });

            migrationBuilder.InsertData(
                table: "Colores",
                columns: new[] { "ColorId", "Color" },
                values: new object[] { 5, "Negro" });

            migrationBuilder.InsertData(
                table: "MarcaVehiculos",
                columns: new[] { "MarcaId", "Marca" },
                values: new object[] { 1, "Tauro Turbo" });

            migrationBuilder.InsertData(
                table: "MarcaVehiculos",
                columns: new[] { "MarcaId", "Marca" },
                values: new object[] { 2, "Toyota" });

            migrationBuilder.InsertData(
                table: "MarcaVehiculos",
                columns: new[] { "MarcaId", "Marca" },
                values: new object[] { 3, "Mercedes Benz" });

            migrationBuilder.InsertData(
                table: "MarcaVehiculos",
                columns: new[] { "MarcaId", "Marca" },
                values: new object[] { 4, "Lamborghini" });

            migrationBuilder.InsertData(
                table: "MarcaVehiculos",
                columns: new[] { "MarcaId", "Marca" },
                values: new object[] { 5, "BMW" });

            migrationBuilder.InsertData(
                table: "Modelos",
                columns: new[] { "ModeloId", "ModeloVehiculo" },
                values: new object[] { 5, "GLE 63" });

            migrationBuilder.InsertData(
                table: "Modelos",
                columns: new[] { "ModeloId", "ModeloVehiculo" },
                values: new object[] { 3, "I8" });

            migrationBuilder.InsertData(
                table: "Modelos",
                columns: new[] { "ModeloId", "ModeloVehiculo" },
                values: new object[] { 4, "R5" });

            migrationBuilder.InsertData(
                table: "Modelos",
                columns: new[] { "ModeloId", "ModeloVehiculo" },
                values: new object[] { 1, "Camry" });

            migrationBuilder.InsertData(
                table: "Modelos",
                columns: new[] { "ModeloId", "ModeloVehiculo" },
                values: new object[] { 2, "Urus" });

            migrationBuilder.InsertData(
                table: "StatusVehiculo",
                columns: new[] { "StatusVehiculoId", "Status" },
                values: new object[] { 1, "Vehiculo Tiene Opsicion" });

            migrationBuilder.InsertData(
                table: "StatusVehiculo",
                columns: new[] { "StatusVehiculoId", "Status" },
                values: new object[] { 2, "?" });

            migrationBuilder.InsertData(
                table: "StatusVehiculo",
                columns: new[] { "StatusVehiculoId", "Status" },
                values: new object[] { 3, "?" });

            migrationBuilder.InsertData(
                table: "StatusVehiculo",
                columns: new[] { "StatusVehiculoId", "Status" },
                values: new object[] { 4, "?" });

            migrationBuilder.InsertData(
                table: "StatusVehiculo",
                columns: new[] { "StatusVehiculoId", "Status" },
                values: new object[] { 5, "?" });

            migrationBuilder.InsertData(
                table: "TipoEmision",
                columns: new[] { "TipoEmisionId", "Emision" },
                values: new object[] { 1, "Exoneracion Ley 168" });

            migrationBuilder.InsertData(
                table: "TipoEmision",
                columns: new[] { "TipoEmisionId", "Emision" },
                values: new object[] { 2, "?" });

            migrationBuilder.InsertData(
                table: "TipoSeguros",
                columns: new[] { "TipoSeguroId", "Seguros" },
                values: new object[] { 1, "FULL" });

            migrationBuilder.InsertData(
                table: "TipoSeguros",
                columns: new[] { "TipoSeguroId", "Seguros" },
                values: new object[] { 2, "De Ley" });

            migrationBuilder.InsertData(
                table: "TipoVehiculo",
                columns: new[] { "TipoVehiculoId", "Tipo" },
                values: new object[] { 2, "Publico" });

            migrationBuilder.InsertData(
                table: "TipoVehiculo",
                columns: new[] { "TipoVehiculoId", "Tipo" },
                values: new object[] { 1, "Privado" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Apellido", "Clave", "Fecha", "Nombre", "NombreUsuario" },
                values: new object[] { 1, "Lopez", "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5", new DateTime(2020, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Raldy", "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_CotizacionesDetalle_CotizacionId",
                table: "CotizacionesDetalle",
                column: "CotizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_VentasDetalle_ClienteId",
                table: "VentasDetalle",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_VentasDetalle_VentaId",
                table: "VentasDetalle",
                column: "VentaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colores");

            migrationBuilder.DropTable(
                name: "CotizacionesDetalle");

            migrationBuilder.DropTable(
                name: "MarcaVehiculos");

            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "StatusVehiculo");

            migrationBuilder.DropTable(
                name: "TipoEmision");

            migrationBuilder.DropTable(
                name: "TipoSeguros");

            migrationBuilder.DropTable(
                name: "TipoVehiculo");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "VentasDetalle");

            migrationBuilder.DropTable(
                name: "Cotizaciones");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
