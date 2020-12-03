using System;
using System.Linq;
using System.Linq.Expressions;
using SegurosVehiculos.Dal;
using SegurosVehiculos.Entidades;
using System.Collections.Generic;

namespace SegurosVehiculos.BLL
{
    public class TipoSegurosBLL
    {
        public static List<TipoSeguros> GetList(Expression<Func<TipoSeguros, bool>> criterio)
        {

            List<TipoSeguros> lista = new List<TipoSeguros>();
            Contexto contexto = new Contexto();

            try
            {
                //obtener la lista y filtrarla segun el criterio recibido por parametro
                lista = contexto.TipoSeguros.Where(criterio).ToList();

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