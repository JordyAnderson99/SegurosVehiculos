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
using System.Threading.Tasks;

namespace SegurosVehiculos.UI.Registros
{
    public partial class rVentas : Window
    {
        private Ventas ventas = new Ventas();

        public rVentas()
        {
            InitializeComponent();
            this.DataContext = ventas;



            //--------------------ClienteId ComboBox--------------------------
            ClienteIdComboBox.ItemsSource = ClientesBLL.GetList(p => true);
            ClienteIdComboBox.SelectedValuePath = "ClienteId";
            ClienteIdComboBox.DisplayMemberPath = "Nombre";

            //--------------------VehiculoId ComboBox--------------------------
            VehiculoIdComboBox.ItemsSource = VehiculosBLL.GetList(p => true);
            VehiculoIdComboBox.SelectedValuePath = "VehiculoId";
            VehiculoIdComboBox.DisplayMemberPath = "VehiculoId";

            //--------------------TipoSeguroId ComboBox--------------------------
            TipoSeguroIdComboBox.ItemsSource = TipoSegurosBLL.GetList(p => true);
            TipoSeguroIdComboBox.SelectedValuePath = "TipoSeguroId";
            TipoSeguroIdComboBox.DisplayMemberPath = "Seguros";

        }


        //LIMPIAR *************************************************************************
        private void Limpiar()
        {
            this.ventas = new Ventas();
            this.DataContext = ventas;
        }


        //VALIDAR *************************************************************************
        private bool Validar()
        {
            bool esValido = true;
            if (VentaIdTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Transaccion Fallida", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (!int.TryParse(VentaIdTextBox.Text, out int CotizacionId))
            {
                esValido = false;
                MessageBox.Show("Este Id no es valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (!int.TryParse(CantidadCuotasTextBox.Text, out int CantidadCuotas))
            {
                esValido = false;
                MessageBox.Show("Esta Cantidad Cuota no es valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (!int.TryParse(MontoTextBox.Text, out int Monto))
            {
                esValido = false;
                MessageBox.Show("Este Monto no es valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            //———————————————————————————————————[ VALIDAR TEXTBOX ]———————————————————————————————————————————————————————



            //—————————————————————————————————[ Venta Id ]—————————————————————————————————
            if (VentaIdTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (Venta Id) está vacío.\n\nAsegurese de que este lleno.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                VentaIdTextBox.Text = "0";
                VentaIdTextBox.Focus();
                VentaIdTextBox.SelectAll();
                esValido = false;
            }

            //—————————————————————————————————[ Cliente Id ]—————————————————————————————————
            if (ClienteIdComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (ClienteId) está vacío.\n\nAsegurese de que este lleno.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                ClienteIdComboBox.Focus();
                ClienteIdComboBox.IsDropDownOpen = true;
                esValido = false;
            }


            //—————————————————————————————————[ Vehiculo Id ]—————————————————————————————————
            if (VehiculoIdComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (VehiculoId) está vacío.\n\nAsegurese de que este lleno.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                VehiculoIdComboBox.Focus();
                VehiculoIdComboBox.IsDropDownOpen = true;
                esValido = false;
            }
            //—————————————————————————————————[ Tipo Seguro Id ]—————————————————————————————————
            if (TipoSeguroIdComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (TipoSeguroId) está vacío.\n\nAsegurese de que este lleno.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                TipoSeguroIdComboBox.Focus();
                TipoSeguroIdComboBox.IsDropDownOpen = true;
                esValido = false;
            }


            //—————————————————————————————————[ Monto ]—————————————————————————————————
            if (MontoTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (Monto) está vacío.\n\nAsegurese de que este lleno.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                MontoTextBox.Focus();
                MontoTextBox.SelectAll();
                esValido = false;
            }

            //—————————————————————————————————[CantidadCuotas ]—————————————————————————————————
            if (CantidadCuotasTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (CantidadCuotas) está vacío.\n\nAsegurese de que este lleno.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                CantidadCuotasTextBox.Focus();
                CantidadCuotasTextBox.SelectAll();
                esValido = false;
            }

            return esValido;


        }


        // Funcion Cagar
        private void Cargar()
        {

            this.DataContext = null;
            this.DataContext = ventas;
        }



        //BOTON BUSCAR *************************************************************************
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
                MessageBox.Show($"Esta Venta no fue encontrada.\n\nAsegurese que exista o cree uno nuevo.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                Limpiar();
                VentaIdTextBox.Clear();
                VentaIdTextBox.Focus();
            }
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





                var paso = VentasBLL.Guardar(this.ventas);
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
                if (VentasBLL.Eliminar(Utilidades.ToInt(VentaIdTextBox.Text)))
                {
                    Limpiar();
                    MessageBox.Show("Registro Eliminado!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("No fue posible Eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }




        //Boton de Calcular Cuota
        private void CalcularCuotaButton_Click(object sender, RoutedEventArgs e)
        {
            Clientes clientes = (Clientes)ClienteIdComboBox.SelectedItem;
            ventas.Detalle = new List<VentasDetalle>();
            double cuota = Calcular(Monto());
            ventas.Balance = Monto();
            VentasDetalle aux;

            var filaDetalle = new VentasDetalle
            {

                VehiculoId = Convert.ToInt32(VehiculoIdComboBox.SelectedValue.ToString()),
                TipoSeguroId = Convert.ToInt32(TipoSeguroIdComboBox.SelectedValue.ToString()),
                CantidadCuotas = Convert.ToInt32(CantidadCuotasTextBox.Text),
                Monto = cuota

            };

            for (int i = 1; i <= int.Parse(CantidadCuotasTextBox.Text); i++)
            {
                filaDetalle.NumeroCuotaId = i;
                ventas.Detalle.Add(filaDetalle);
                aux = filaDetalle;
                filaDetalle = new VentasDetalle();
                filaDetalle.VehiculoId = aux.VehiculoId;
                filaDetalle.TipoSeguroId = aux.TipoSeguroId;
                filaDetalle.CantidadCuotas = aux.CantidadCuotas;
                filaDetalle.Monto = aux.Monto;

            }

            Cargar();


        }


        //Boton de Eliminar Fila
        private void EliminarFilaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DetalleDataGrid.Items.Count >= 1 && DetalleDataGrid.SelectedIndex <= DetalleDataGrid.Items.Count - 1)
            {
                var detalle = (VentasDetalle)DetalleDataGrid.SelectedItem;

                /*ordenes.Monto = ordenes.Monto - (detalle.productos.Costo * (decimal)detalle.Cantidad);*/
                ventas.Detalle.RemoveAt(DetalleDataGrid.SelectedIndex);
                Cargar();
            }
        }

        private double Calcular(double monto)
        {
            double cuota = 0;

            cuota = monto / int.Parse(CantidadCuotasTextBox.Text);


            return Math.Round(cuota, 2);
        }

        public double Monto()
        {
            var seguro = (TipoSeguros)TipoSeguroIdComboBox.SelectedItem;
            var vehiculo = (Vehiculos)VehiculoIdComboBox.SelectedItem;
            double monto = seguro.ValorSeguro + vehiculo.ValorVehiculo;

            if (ModificarMontoCheckBox.IsChecked == true)
            {
                return ventas.Monto;
            }
            else
            {
                if (vehiculo.AñoFabricacion >= 2008)
                {
                    monto = vehiculo.ValorVehiculo + 100000;
                    ventas.Monto = monto;
                    return monto;
                }
                else
                {
                    seguro = (TipoSeguros)TipoSeguroIdComboBox.SelectedItem;
                    vehiculo = (Vehiculos)VehiculoIdComboBox.SelectedItem;
                    monto = seguro.ValorSeguro + vehiculo.ValorVehiculo;

                    ventas.Monto = monto;
                    return monto;
                }
            }
        }

    }
}