using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SegurosVehiculos.Entidades
{
    public class Ventas
    {
        [Key]
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public DateTime Vence { get; set; } = DateTime.Now;
        public int VehiculoId { get; set; }
        public int TipoSeguroId { get; set; }
        public Double Monto { get; set; }
        public String Observacion { get; set; }
        public int CantidadCuotas { get; set; }

        [ForeignKey("VentaId")]

        public virtual List<VentasDetalle> Detalle { get; set; } = new List<VentasDetalle>();
    }
}
