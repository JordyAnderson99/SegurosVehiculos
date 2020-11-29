using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SegurosVehiculos.Entidades{

    public class StatusVehiculo{
        [Key]
        public int StatusVehiculoId { get; set; }
        public string Status { get; set; }
    }
}

