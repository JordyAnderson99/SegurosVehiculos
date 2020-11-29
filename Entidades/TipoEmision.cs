using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SegurosVehiculos.Entidades{

    public class TipoEmision{
        [Key]
        public int TipoEmisionId { get; set; }
        public string Emision { get; set; }
    }
}
