using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SegurosVehiculos.Entidades{

    public class Colores{
        [Key]
        public int ColorId { get; set; }
        public string Color { get; set; }
        
    }
}