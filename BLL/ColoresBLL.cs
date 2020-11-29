using System;
using System.Linq;
using System.Linq.Expressions;
using SegurosVehiculos.Dal;
using SegurosVehiculos.Entidades;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SegurosVehiculos.BLL
{
    public class ColoresBLL
    {
        public static List<Colores> GetList(Expression<Func<Colores, bool>> criterio)
        {

            List<Colores> lista = new List<Colores>();
            Contexto contexto = new Contexto();

            try
            {
                //obtener la lista y filtrarla segun el criterio recibido por parametro
                lista = contexto.Colores.Where(criterio).ToList();

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