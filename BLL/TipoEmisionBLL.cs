using System;
using System.Linq;
using System.Linq.Expressions;
using SegurosVehiculos.Dal;
using SegurosVehiculos.Entidades;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SegurosVehiculos.BLL
{
    public class TipoEmisionBLL
    {
        public static List<TipoEmision> GetList(Expression<Func<TipoEmision, bool>> criterio)
        {

            List<TipoEmision> lista = new List<TipoEmision>();
            Contexto contexto = new Contexto();

            try
            {
                //obtener la lista y filtrarla segun el criterio recibido por parametro
                lista = contexto.TipoEmision.Where(criterio).ToList();

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