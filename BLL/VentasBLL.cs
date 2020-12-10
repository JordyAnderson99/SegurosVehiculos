using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Security.RightsManagement;
using System.Linq.Expressions;
using System.Security.Cryptography;
using SegurosVehiculos.Entidades;
using SegurosVehiculos.Dal;
using System.Collections;

namespace SegurosVehiculos.BLL
{
    public class VentasBLL
    {

        public static bool Guardar(Ventas ventas)
        {
            if (!Existe(ventas.VentaId))
                return Insertar(ventas);
            else
                return Modificar(ventas);
        }

        private static bool Insertar(Ventas ventas)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                //Agregar a la entidad que se desea ingresar al contexto
                
                contexto.Ventas.Add(ventas);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;

        }

        private static bool Modificar(Ventas ventas)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete From VentasDetalle Where VentaId={ventas.VentaId}");

                foreach (var item in ventas.Detalle)
                {
                    contexto.Entry(item).State = EntityState.Added;
                }

                contexto.Entry(ventas).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                //Buscar La entidad que se desea eliminar
                var venta = contexto.Ventas.Find(id);

                if (venta != null)
                {
                    contexto.Ventas.Remove(venta);//Removemos la entidad
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Ventas Buscar(int id)
        {

            Contexto contexto = new Contexto();
            Ventas ventas = new Ventas();

            try
            {
                ventas = contexto.Ventas
                  .Where(d => d.VentaId == id)
                  .Include(d => d.Detalle)                  
                  .SingleOrDefault();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return ventas;

        }

        public static bool Existe(int id)
        {

            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Ventas.Any(e => e.VentaId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static List<Ventas> GetList(Expression<Func<Ventas, bool>> criterio)
        {

            List<Ventas> lista = new List<Ventas>();
            Contexto contexto = new Contexto();

            try
            {
                //obtener la lista y filtrarla segun el criterio recibido por parametro
                lista = contexto.Ventas.Where(criterio).ToList();

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
