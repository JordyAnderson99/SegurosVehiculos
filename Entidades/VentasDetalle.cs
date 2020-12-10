using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SegurosVehiculos.Entidades
{
    public class VentasDetalle
    {
        [Key]
        public int Id { get; set; }
        public int VentaId { get; set; }
        
        public DateTime Fecha { get; set; } = DateTime.Now;        
        public double Monto { get; set; }
        public int NumeroCuotaId { get; set; }
        public int VehiculoId { get; set; }
        public int TipoSeguroId { get; set; }
        public int CantidadCuotas { get; set; }

    }
}
