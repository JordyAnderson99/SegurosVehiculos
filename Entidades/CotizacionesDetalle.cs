using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SegurosVehiculos.Entidades{

    public class CotizacionesDetalle{
        [Key]
        

        public int Id { get; set; }

        public int CotizacionId { get; set; }

        public int NumeroCuota { get; set; }

        public double Money { get; set; }

        
    }
}