using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SegurosVehiculos.Entidades{

    public class TipoVehiculo{
        [Key]
        public int TipoVehiculoId { get; set; }
        public string Tipo { get; set; }
    }
}
