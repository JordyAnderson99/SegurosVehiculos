using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SegurosVehiculos.Entidades
{
    public class Pagos
    {
        [Key]
        public int PagoId { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public int VentaId { get; set; }
        public int MyProperty { get; set; }
        public int NumeroCuotaId { get; set; }
        public double Total { get; set; }

    }
}
