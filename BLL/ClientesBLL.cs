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
    public class ClientesBLL
    {
         //Funcion Existe 
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Clientes.Any(e => e.ClienteId == id);
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
        private static bool Insertar(Clientes clientes)
        {
            Contexto contexto = new Contexto();
            bool guardado = false;

            try
            {
                    contexto.Clientes.Add(clientes);   
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
        private static bool Modificar(Clientes clientes)
        {
            Contexto contexto = new Contexto();
            bool modificado = false;
            

            try
            {
                contexto.Entry(clientes).State = EntityState.Modified;
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
        public static bool Guardar(Clientes clientes)
        {
            if (!Existe(clientes.ClienteId))
                return Insertar(clientes);
            else
                return Modificar(clientes);
        }
        
        
        //Funcion Eliminar
        public static bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool eliminado = false;

            try
            {
                var clientes = contexto.Clientes.Find(id);

                if (clientes != null)
                {
                    contexto.Clientes.Remove(clientes);
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
        public static Clientes Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Clientes clientes = new Clientes();

            try
            {
                clientes = contexto.Clientes.Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return clientes;
        }

               //Funcion List
        public static List<Clientes> GetList(Expression<Func<Clientes, bool>> clientes)
        {
            Contexto contexto = new Contexto();
            List<Clientes> Lista = new List<Clientes>();

            try
            {
                Lista = contexto.Clientes.Where(clientes).ToList();

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
        public static List<Clientes> GetUsuarios()
        {
            List<Clientes> lista = new List<Clientes>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Clientes.ToList();
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