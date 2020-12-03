using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SegurosVehiculos.Entidades
{
    public class TipoSeguros
    {
        [Key]
        public int TipoSeguroId { get; set; }
        public String Seguros { get; set; }
    }
}
