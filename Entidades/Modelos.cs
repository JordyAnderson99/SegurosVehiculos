using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SegurosVehiculos.Entidades{

    public class Modelos{
        [Key]
        public int ModeloId { get; set; }
        public string ModeloVehiculo { get; set; }
    }
}

