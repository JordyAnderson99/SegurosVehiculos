using System;
using System.Linq;
using System.Linq.Expressions;
using SegurosVehiculos.Dal;
using SegurosVehiculos.Entidades;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SegurosVehiculos.BLL
{
    public class StatusVehiculoBLL
    {
        public static List<StatusVehiculo> GetList(Expression<Func<StatusVehiculo, bool>> criterio)
        {

            List<StatusVehiculo> lista = new List<StatusVehiculo>();
            Contexto contexto = new Contexto();

            try
            {
                //obtener la lista y filtrarla segun el criterio recibido por parametro
                lista = contexto.StatusVehiculo.Where(criterio).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}