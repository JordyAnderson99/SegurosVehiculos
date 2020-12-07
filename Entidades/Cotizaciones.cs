using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SegurosVehiculos.Entidades{

    public class Cotizaciones{
        [Key]
        

        public int CotizacionId { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public int ClienteId { get; set; }

        public int VehiculoId { get; set; }

        public int TipoSeguroId { get; set; }

        public double Monto { get; set; }

        public string Observaciones { get; set; }

        public int CantidadCuotas { get; set; }

         [ForeignKey("CotizacionId")]
        public virtual List<CotizacionesDetalle> Detalle { get; set; } = new List<CotizacionesDetalle>();

        
    }
}