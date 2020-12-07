using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SegurosVehiculos.BLL;
using SegurosVehiculos.Entidades;

namespace SegurosVehiculos.UI.Registros
{
    public partial class rUsuarios : Window
    {
        private Usuarios usuarios = new Usuarios();
        public rUsuarios()
        {
            InitializeComponent();
            this.DataContext = usuarios;
        }
        //Funcion Cargar 
        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = usuarios;
            ClavePasswordBox.Password = string.Empty;
            ConfirmarClavePasswordBox.Password = string.Empty;
        }
        //Funcion Limpiar
        private void Limpiar()
        {
            this.usuarios = new Usuarios();
            this.DataContext = usuarios;
            ClavePasswordBox.Password = string.Empty;
            ConfirmarClavePasswordBox.Password = string.Empty;
        }
        //Funcion Validar
        private bool Validar()
        {
            bool Validado = true;
            if (UsuarioIdTextBox.Text.Length == 0)
            {
                Validado = false;
                MessageBox.Show("Transacción Fallida", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (!int.TryParse(UsuarioIdTextBox.Text, out int UsuarioId))
            {
                Validado = false;
                MessageBox.Show("Este Id no es valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            /*if (UsuarioIdTextBox.Text.Length <= 0)
            {
                GuardarButton.IsEnabled = false;
                Validado = false;
                MessageBox.Show("Solamente pueden ser numeros positivos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                GuardarButton.IsEnabled = true;
            }
            */
            //—————————————————————————————[ VALIDAR TEXTBOX ]———————————————————————————————————————————————————————



            //—————————————————————————————————[ Usuario Id ]—————————————————————————————————
            if (UsuarioIdTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (Usuario Id) está vacío.\n\nAsigne un Usuario al Usuario.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                UsuarioIdTextBox.Text = "0";
                UsuarioIdTextBox.Focus();
                UsuarioIdTextBox.SelectAll();
                Validado = false;
            }
            //—————————————————————————————————[ Nombres ]—————————————————————————————————
            if (NombreTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (Nombre) está vacío.\n\nEscriba sus Nombres.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                NombreTextBox.Clear();
                NombreTextBox.Focus();
                Validado = false;
            }
            //—————————————————————————————————[ Apellidos ]—————————————————————————————————
            if (ApellidoTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (Apellido) está vacío.\n\nEscriba sus Apellidos.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                ApellidoTextBox.Clear();
                ApellidoTextBox.Focus();
                Validado = false;
            }


            //—————————————————————————————————[ Nombre Usuario ]—————————————————————————————————
            if (NombreUsuarioTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (Nombre Usuario) está vacío.\n\nAsigne un Nombre al Usuario.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                NombreUsuarioTextBox.Focus();
                NombreUsuarioTextBox.SelectAll();
                Validado = false;
            }




            //—————————————————————————————————[ Contraseña ]—————————————————————————————————
            if (ClavePasswordBox.Password == string.Empty)
            {
                MessageBox.Show("El Campo (Contraseña) está vacío.\n\nAsigne una Contraseña al Usuario.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                ClavePasswordBox.Focus();
                ClavePasswordBox.SelectAll();
                Validado = false;
            }
            //—————————————————————————————————[ Confirmar Contraseña ]—————————————————————————————————
            if (ConfirmarClavePasswordBox.Password == string.Empty)
            {
                MessageBox.Show("El Campo (Confirmar Contraseña) está vacío.\n\nConfirme la Contraseña del Usuario.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                ConfirmarClavePasswordBox.Focus();
                ConfirmarClavePasswordBox.SelectAll();
                Validado = false;
            }
            //—————————————————————————————————[ Validar Contraseñas ]—————————————————————————————————
            if (ConfirmarClavePasswordBox.Password != ClavePasswordBox.Password)
            {
                MessageBox.Show("Las Contraseñas escritas no coinciden", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                ClavePasswordBox.Clear();
                ConfirmarClavePasswordBox.Clear();
                ClavePasswordBox.Focus();
                Validado = false;
            }

            return Validado;
        }
        //Boton Buscar
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Usuarios encontrado = UsuariosBLL.Buscar(Utilidades.ToInt(UsuarioIdTextBox.Text));

            if (encontrado != null)
            {
                this.usuarios = encontrado;
                Cargar();
            }
            else
            {
                this.usuarios = new Usuarios();
                this.DataContext = this.usuarios;
                MessageBox.Show($"Este Usuario no fue encontrado.\n\nAsegúrese que existe o cree uno nuevo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                Limpiar();
                UsuarioIdTextBox.SelectAll();
                UsuarioIdTextBox.Focus();
            }
            if (UsuarioIdTextBox.Text == "1")
            {
                EliminarButton.IsEnabled = false;
                GuardarButton.IsEnabled = false;
            }
            else
            {
                EliminarButton.IsEnabled = true;
                GuardarButton.IsEnabled = true;
            }
        }
        //Boton Nuevo
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
            EliminarButton.IsEnabled = true;
            GuardarButton.IsEnabled = true;
        }
        //Boton Guardar
        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (!Validar())
                    return;

                               
                var paso = UsuariosBLL.Guardar(usuarios);
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Transacción Exitosa", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Transacción Fallida", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
        }
        //Boton Eliminar 
        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            //—————————————————————————————————[ Evitar que se borre el Usuario Admin Id #1 ]—————————————————————————————————
            if (UsuarioIdTextBox.Text == "1")
            {
                MessageBox.Show("No se pudo eliminar este Usuario.\n\nNo puede eliminar este Usuario.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                Limpiar();
                UsuarioIdTextBox.Focus();
                UsuarioIdTextBox.SelectAll();
                return;
            }

            if (UsuariosBLL.Eliminar(Utilidades.ToInt(UsuarioIdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro Eliminado", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No se pudo eliminar el registro", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}