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
using System.Linq;
using System.Threading.Tasks;

namespace SegurosVehiculos.UI.Registros
{
    public partial class rClientes : Window
    {
        private Clientes clientes = new Clientes();
        public rClientes()
        {
            InitializeComponent();
            this.DataContext = clientes;
        }
        //LIMPIAR
        private void Limpiar()
        {
            this.clientes = new Clientes();
            this.DataContext = clientes;
        }
        //VALIDAR
        private bool Validar()
        {
            bool esValido = true;
            

            if (ClienteIdTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Transacción Fallida", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (!int.TryParse(ClienteIdTextBox.Text, out int ClieneteId))
            {
                esValido = false;
                MessageBox.Show("Este Id no es valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (!double.TryParse(TelefonoTextBox.Text,out double Telefono))
            {
                esValido = false;
                MessageBox.Show("Este Telefono no es valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (!double.TryParse(CelularTextBox.Text, out double Celular))
            {
                esValido = false;
                MessageBox.Show("Este Celular no es valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            //———————————————————————————————————[ VALIDAR TEXTBOX ]———————————————————————————————————————————————————————



            //—————————————————————————————————[ Cliente Id ]—————————————————————————————————
            if (ClienteIdTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (Cliente Id) está vacío.\n\nAsigne un Cliente al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                ClienteIdTextBox.Text = "0";
                ClienteIdTextBox.Focus();
                ClienteIdTextBox.SelectAll();
                esValido = false;
            }
            //—————————————————————————————————[ Nombre ]—————————————————————————————————
            if (NombreTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (Nombre) está vacío.\n\nAsigne un Nombre al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                NombreTextBox.Focus();
                NombreTextBox.SelectAll();
                esValido = false;
            }

            //—————————————————————————————————[ Apellido ]—————————————————————————————————
            if (ApellidoTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (Apellido) está vacío.\n\nAsigne un Apellido al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                ApellidoTextBox.Focus();
                ApellidoTextBox.SelectAll();
                esValido = false;
            }


            //—————————————————————————————————[ Direccion ]—————————————————————————————————
            if (DireccionTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (Direccion) está vacío.\n\nAsigne una Dirrecion al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);

                DireccionTextBox.Focus();
                DireccionTextBox.SelectAll();
                esValido = false;
            }



            //—————————————————————————————————[ Telefono ]—————————————————————————————————
            if (TelefonoTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (Telefono) está vacío.\n\nAsigne un Telefono al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                TelefonoTextBox.Text = "0";
                TelefonoTextBox.Focus();
                TelefonoTextBox.SelectAll();
                esValido = false;
            }




            //—————————————————————————————————[ Celular ]—————————————————————————————————
            if (CelularTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (Celular) está vacío.\n\nAsigne un Celular al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                CelularTextBox.Text = "0";
                CelularTextBox.Focus();
                CelularTextBox.SelectAll();
                esValido = false;
            }



            //—————————————————————————————————[ Cedula ]—————————————————————————————————
            if (CedulaTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (Cedula) está vacío.\n\nAsigne una Cedula al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                CedulaTextBox.Text = "0";
                CedulaTextBox.Focus();
                CedulaTextBox.SelectAll();
                esValido = false;
            }
                                             
            
            return esValido;
        }
        //BOTON BUSCAR *************************************************************************
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var clientes = ClientesBLL.Buscar(Utilidades.ToInt(ClienteIdTextBox.Text));
            if (clientes != null)
                this.clientes = clientes;
            else
                this.clientes = new Clientes();

            this.DataContext = this.clientes;
        }
        //BOTON NUEVO *************************************************************************
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }
        //BOTO GUARDAR **************************************************************************
        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {

            {
                if (!Validar())
                    return;

               

                
                var paso = ClientesBLL.Guardar(clientes);
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Transacción Exitosa", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Transacción Fallida", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
        //BOTON ELIMINAR *************************************************************************
        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (ClientesBLL.Eliminar(Utilidades.ToInt(ClienteIdTextBox.Text)))
                {
                    Limpiar();
                    MessageBox.Show("Registro Eliminado!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("No fue posible eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}