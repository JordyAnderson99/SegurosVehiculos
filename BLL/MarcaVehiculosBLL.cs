using System;
using System.Linq;
using System.Linq.Expressions;
using SegurosVehiculos.Dal;
using SegurosVehiculos.Entidades;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SegurosVehiculos.BLL
{
    public class MarcaVehiculosBLL
    {
        public static List<MarcaVehiculos> GetList(Expression<Func<MarcaVehiculos, bool>> criterio)
        {

            List<MarcaVehiculos> lista = new List<MarcaVehiculos>();
            Contexto contexto = new Contexto();

            try
            {

                lista = contexto.MarcaVehiculos.Where(criterio).ToList();

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