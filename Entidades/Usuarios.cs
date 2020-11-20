using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace SegurosVehiculos.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
    }
}
