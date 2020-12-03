using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using SegurosVehiculos.Entidades;
using SegurosVehiculos.Dal;

namespace SegurosVehiculos.BLL
{
    public class PagosBLL
    {
        //Funcion Guardar
        public static bool Guardar(Pagos pagos)
        {
            if (!Existe(pagos.PagoId))
                return Insertar(pagos);
            else
                return Modificar(pagos);
        }

        //Funcion Existe 
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Pagos.Any(e => e.PagoId == id);
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

        //Funcion Insertar
        private static bool Insertar(Pagos pagos)
        {
            Contexto contexto = new Contexto();
            bool guardado = false;

            try
            {
                contexto.Pagos.Add(pagos);
                guardado = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return guardado;
        }

        //Funcion Modificar
        private static bool Modificar(Pagos pagos)
        {
            Contexto contexto = new Contexto();
            bool modificado = false;


            try
            {
                contexto.Entry(pagos).State = EntityState.Modified;
                modificado = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return modificado;
        }


        //Funcion Eliminar
        public static bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool eliminado = false;

            try
            {
                var pago = contexto.Pagos.Find(id);

                if (pago != null)
                {
                    contexto.Pagos.Remove(pago);
                    eliminado = (contexto.SaveChanges() > 0);
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

            return eliminado;
        }
        //Funcion Buscar
        public static Pagos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Pagos pagos = new Pagos();

            try
            {
                pagos = contexto.Pagos.Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return pagos;
        }

        //Funcion List
        public static List<Pagos> GetList(Expression<Func<Pagos, bool>> vehiculo)
        {
            Contexto contexto = new Contexto();
            List<Pagos> Lista = new List<Pagos>();

            try
            {
                Lista = contexto.Pagos.Where(vehiculo).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return Lista;
        }

    }
}