using System;
using System.Linq;
using System.Linq.Expressions;
using SegurosVehiculos.Dal;
using SegurosVehiculos.Entidades;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SegurosVehiculos.BLL
{
    public class ModelosBLL
    {
        public static List<Modelos> GetList(Expression<Func<Modelos, bool>> criterio)
        {

            List<Modelos> lista = new List<Modelos>();
            Contexto contexto = new Contexto();

            try
            {
                //obtener la lista y filtrarla segun el criterio recibido por parametro
                lista = contexto.Modelos.Where(criterio).ToList();

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