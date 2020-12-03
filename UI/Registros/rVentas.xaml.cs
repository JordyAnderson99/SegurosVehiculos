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
using SegurosVehiculos.Entidades;
using SegurosVehiculos.BLL;

namespace SegurosVehiculos.UI.Registros
{
    /// <summary>
    /// Interaction logic for rVentas.xaml
    /// </summary>
    public partial class rVentas : Window
    {
        private Ventas ventas = new Ventas();
        public rVentas()
        {
            InitializeComponent();
            this.DataContext = ventas;

            //ComboBox del ClienteId
            ClienteIdComboBox.ItemsSource = ClientesBLL.GetList(s => true);
            ClienteIdComboBox.SelectedValuePath = "SuplidorId";
            ClienteIdComboBox.DisplayMemberPath = "Nombres";

            // ComboBox del VehiculoId
            VehiculoIdComboBox.ItemsSource = VehiculosBLL.GetList(p => true);
            VehiculoIdComboBox.SelectedValuePath = "ProductoId";
            VehiculoIdComboBox.DisplayMemberPath = "Descripcion";

            // ComboBox del SeguroId
            TipoSeguroIdComboBox.ItemsSource = TipoSegurosBLL.GetList(p => true);
            TipoSeguroIdComboBox.SelectedValuePath = "ProductoId";
            TipoSeguroIdComboBox.DisplayMemberPath = "Descripcion";
        }
        // Funcion Cagar
        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = ventas;
        }
        //Funcion Limpiar
        private void Limpiar()
        {
            this.ventas = new Ventas();
            this.DataContext = ventas;
        }
        //Funcion Validar
        private bool Validar()
        {
            bool esValidado = true;
            if (VentaIdTextBox.Text.Length == 0)
            {
                esValidado = false;
                MessageBox.Show("Transaccion Fallida", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return esValidado;
        }
        //Boton Buscar
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Ventas encontrado = VentasBLL.Buscar(ventas.VentaId);

            if (encontrado != null)
            {
                ventas = encontrado;
                Cargar();
            }
            else
            {
                MessageBox.Show($"Esta venat no fue encontrada.\n\nAsegurese que exista o cree uno nuevo.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                Limpiar();
                VentaIdTextBox.Clear();
                VentaIdTextBox.Focus();
            }
        }

        //Boton Nuevo
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }
        //Boton Guardar
        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (!Validar())
                    return;

                var paso = VentasBLL.Guardar(this.ventas);
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Transaccion Exitosa", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Transaccion Errada", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        //Boton Eliminar
        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (VentasBLL.Eliminar(Utilidades.ToInt(VentaIdTextBox.Text)))
                {
                    Limpiar();
                    MessageBox.Show("Registro Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("No se pudo eliminar", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        //Boton de Agregar Fila
        private void AgregarFilaButton_Click(object sender, RoutedEventArgs e)
        {
            Clientes clientes = (Clientes)ClienteIdComboBox.SelectedItem;
            var filaDetalle = new VentasDetalle
            {
                VentaId = this.ventas.VentaId,
                ClienteId = Convert.ToInt32(ClienteIdComboBox.SelectedValue.ToString()),
                clientes = (Clientes)ClienteIdComboBox.SelectedItem,
                Monto = Convert.ToInt32(MontoTextBox.Text)
            };

           /* ordenes.Monto += producto.Costo * int.Parse(CantidadTextBox.Text);
            this.ordenes.Detalle.Add(filaDetalle);*/
            Cargar();

            TipoSeguroIdComboBox.SelectedIndex = -1;
            MontoTextBox.Clear();
            MontoTextBox.Focus();
        }
        //Boton de Eliminar Fila
        private void EliminarFilaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DetalleDataGrid.Items.Count >= 1 && DetalleDataGrid.SelectedIndex <= DetalleDataGrid.Items.Count - 1)
            {
                var detalle = (VentasDetalle)DetalleDataGrid.SelectedItem;

                /*ordenes.Monto = ordenes.Monto - (detalle.productos.Costo * (decimal)detalle.Cantidad);
                ordenes.Detalle.RemoveAt(DetalleDataGrid.SelectedIndex);*/
                Cargar();
            }
        }
    }
}
