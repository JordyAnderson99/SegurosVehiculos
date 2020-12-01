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

namespace SegurosVehiculos.BLL
{
    public class CotizacionesBLL
    {
         //Funcion Existe 
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Cotizaciones.Any(e => e.CotizacionId == id);
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
        private static bool Insertar(Cotizaciones cotizaciones)
        {
            Contexto contexto = new Contexto();
            bool guardado = false;

            try
            {
                    contexto.Cotizaciones.Add(cotizaciones);   
                    guardado = (contexto.SaveChanges() > 0);
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
        private static bool Modificar(Cotizaciones cotizaciones)
        {
            Contexto contexto = new Contexto();
            bool modificado = false;
            

            try
            {
                contexto.Entry(cotizaciones).State = EntityState.Modified;
                modificado = (contexto.SaveChanges() > 0);
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
        
        //Funcion Guardar
        public static bool Guardar(Cotizaciones cotizaciones)
        {
            if (!Existe(cotizaciones.ClienteId))
                return Insertar(cotizaciones);
            else
                return Modificar(cotizaciones);
        }
        
        
        //Funcion Eliminar
        public static bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool eliminado = false;

            try
            {
                var cotizaciones = contexto.Cotizaciones.Find(id);

                if (cotizaciones != null)
                {
                    contexto.Cotizaciones.Remove(cotizaciones);
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
        public static Cotizaciones Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Cotizaciones cotizaciones = new Cotizaciones();

            try
            {
                cotizaciones = contexto.Cotizaciones.Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return cotizaciones;
        }

               //Funcion List
        public static List<Cotizaciones> GetList(Expression<Func<Cotizaciones, bool>> cotizaciones)
        {
            Contexto contexto = new Contexto();
            List<Cotizaciones> Lista = new List<Cotizaciones>();

            try
            {
                Lista = contexto.Cotizaciones.Where(cotizaciones).ToList();

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
       


        //GET
        public static List<Cotizaciones> GetUsuarios()
        {
            List<Cotizaciones> lista = new List<Cotizaciones>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Cotizaciones.ToList();
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