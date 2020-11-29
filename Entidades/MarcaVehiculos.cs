using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SegurosVehiculos.Entidades{

    public class MarcaVehiculos{
        [Key]
        public int MarcaId { get; set; }
        public string Marca { get; set; }
    }
}