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
    public class UsuariosBLL
    {
         //Funcion Existe 
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Usuarios.Any(e => e.UsuarioId == id);
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
        private static bool Insertar(Usuarios usuario)
        {
            Contexto contexto = new Contexto();
            bool guardado = false;

            try
            {
                usuario.Clave = GetSHA256(usuario.Clave);
                if (contexto.Usuarios.Add(usuario) != null)
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
        private static bool Modificar(Usuarios usuario)
        {
            Contexto contexto = new Contexto();
            bool modificado = false;
            usuario.Clave = GetSHA256(usuario.Clave);

            try
            {
                contexto.Entry(usuario).State = EntityState.Modified;
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
        public static bool Guardar(Usuarios usuario)
        {
            if (!Existe(usuario.UsuarioId))
                return Insertar(usuario);
            else
                return Modificar(usuario);
        }
        
        
        //Funcion Eliminar
        public static bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool eliminado = false;

            try
            {
                var usuario = contexto.Usuarios.Find(id);

                if (usuario != null)
                {
                    contexto.Usuarios.Remove(usuario);
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
        public static Usuarios Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Usuarios usuario = new Usuarios();

            try
            {
                usuario = contexto.Usuarios.Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return usuario;
        }

               //Funcion List
        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> usuario)
        {
            Contexto contexto = new Contexto();
            List<Usuarios> Lista = new List<Usuarios>();

            try
            {
                Lista = contexto.Usuarios.Where(usuario).ToList();

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
        //Funcion Autenticar
        public static bool Autenticar(string nombreusuario, string clave)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                paso = contexto.Usuarios.Any(u => u.NombreUsuario.Equals(nombreusuario) && u.Clave.Equals(GetSHA256(clave)));
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
        //Encriptar Clave
        private static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);

            return sb.ToString();
        }
        //GET
        public static List<Usuarios> GetUsuarios()
        {
            List<Usuarios> lista = new List<Usuarios>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Usuarios.ToList();
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