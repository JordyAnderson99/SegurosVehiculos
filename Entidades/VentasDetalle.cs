using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SegurosVehiculos.Entidades
{
    public class VentasDetalle
    {
        [Key]
        public int Id { get; set; }
        public int VentaId { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;        
        public double Monto { get; set; }
        public double Balance { get; set; }

        [ForeignKey("ClienteId")]

        public Clientes clientes { get; set; } = new Clientes();

    }
}
