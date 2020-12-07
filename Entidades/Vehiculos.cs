using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SegurosVehiculos.Entidades
{
    public class Vehiculos
    {
        [Key]
        public int VehiculoId { get; set; }
        public int CantidadPasajeros { get; set; }
        public int Cilindros { get; set; }
        public string Uso { get; set; }
        public string Chasis { get; set; }
        public string Matricula { get; set; }
        public double ValorVehiculo { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public DateTime FechaExpedicionMatricula { get; set; } = DateTime.Now;
        public int AñoFabricacion { get; set; }
        public string Motor { get; set; }
        public double FuerzaMotriz { get; set; }
        public double CapacidadCarga { get; set; }
        public int TotalPuertas { get; set; }
        public int ColorId { get; set; }
        public int MarcaId { get; set; }
        public int ModeloId { get; set; }
        public int StatusVehiculoId { get; set; }
        public int TipoEmisionId { get; set; }
        public int TipoVehiculoId { get; set; }

    }
}