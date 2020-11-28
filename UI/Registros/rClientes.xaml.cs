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
            if (NombreTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Transaccion Fallida", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            

            if(clientes.Nombre == null)
            {
                MessageBox.Show("\nNo puede Guardar con el campo nombre vacio", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
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
                    MessageBox.Show("Transaccion Exitosa!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Transaccion Fallida", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
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