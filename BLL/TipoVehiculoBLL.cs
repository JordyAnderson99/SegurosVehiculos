using System;
using System.Linq;
using System.Linq.Expressions;
using SegurosVehiculos.Dal;
using SegurosVehiculos.Entidades;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SegurosVehiculos.BLL
{
    public class TipoVehiculoBLL
    {
        public static List<TipoVehiculo> GetList(Expression<Func<TipoVehiculo, bool>> criterio)
        {

            List<TipoVehiculo> lista = new List<TipoVehiculo>();
            Contexto contexto = new Contexto();

            try
            {
                //obtener la lista y filtrarla segun el criterio recibido por parametro
                lista = contexto.TipoVehiculo.Where(criterio).ToList();

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