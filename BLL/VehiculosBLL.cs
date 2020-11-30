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
    public class VehiculosBLL
    {
        //Funcion Guardar
        public static bool Guardar(Vehiculos vehiculos)
        {
            if (!Existe(vehiculos.VehiculoId))
                return Insertar(vehiculos);
            else
                return Modificar(vehiculos);
        }

        //Funcion Existe 
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Vehiculos.Any(e => e.VehiculoId == id);
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
        private static bool Insertar(Vehiculos vehiculos)
        {
            Contexto contexto = new Contexto();
            bool guardado = false;

            try
            {
                contexto.Vehiculos.Add(vehiculos);
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
        private static bool Modificar(Vehiculos vehiculos)
        {
            Contexto contexto = new Contexto();
            bool modificado = false;
          

            try
            {
                contexto.Entry(vehiculos).State = EntityState.Modified;
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
                var vehiculo = contexto.Vehiculos.Find(id);

                if (vehiculo != null)
                {
                    contexto.Vehiculos.Remove(vehiculo);
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
        public static Vehiculos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Vehiculos vehiculos = new Vehiculos();

            try
            {
                vehiculos = contexto.Vehiculos.Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return vehiculos;
        }

        //Funcion List
        public static List<Vehiculos> GetList(Expression<Func<Vehiculos, bool>> vehiculo)
        {
            Contexto contexto = new Contexto();
            List<Vehiculos> Lista = new List<Vehiculos>();

            try
            {
                Lista = contexto.Vehiculos.Where(vehiculo).ToList();

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