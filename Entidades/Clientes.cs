using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SegurosVehiculos.Entidades
{
    public class Clientes
    {
        [Key]

        public int ClienteId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public int Telefono { get; set; }

        public int Celular { get; set; }

        public string Cedula { get; set; }

        public string CorreoElectronico { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;


    }

}