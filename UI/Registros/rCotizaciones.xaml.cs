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
    public partial class rCotizaciones : Window
    {
        private Cotizaciones cotizaciones = new Cotizaciones();

        public rCotizaciones()
        {
            InitializeComponent();
            this.DataContext = cotizaciones;



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
            this.cotizaciones = new Cotizaciones();
            this.DataContext = cotizaciones;
        }


        //VALIDAR *************************************************************************
        private bool Validar()
        {
            bool esValido = true;
            if (CotizacionIdTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Transaccion Fallida", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (!int.TryParse(CotizacionIdTextBox.Text, out int CotizacionId))
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



            //—————————————————————————————————[ Cotizacion Id ]—————————————————————————————————
            if (CotizacionIdTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (Cotizacion Id) está vacío.\n\nAsegurese de que este lleno.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                CotizacionIdTextBox.Text = "0";
                CotizacionIdTextBox.Focus();
                CotizacionIdTextBox.SelectAll();
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
            this.DataContext = cotizaciones;
        }



        //BOTON BUSCAR *************************************************************************
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Cotizaciones encontrado = CotizacionesBLL.Buscar(cotizaciones.CotizacionId);

            if (encontrado != null)
            {
                cotizaciones = encontrado;
                Cargar();
            }
            else
            {
                MessageBox.Show($"Esta Cotizacion no fue encontrada.\n\nAsegurese que exista o cree uno nuevo.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                Limpiar();
                CotizacionIdTextBox.Clear();
                CotizacionIdTextBox.Focus();
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





                var paso = CotizacionesBLL.Guardar(this.cotizaciones);
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
                if (CotizacionesBLL.Eliminar(Utilidades.ToInt(CotizacionIdTextBox.Text)))
                {
                    Limpiar();
                    MessageBox.Show("Registro Eliminado!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("No fue posible Eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }




        //Boton de Agregar Fila
        private void AgregarFilaButton_Click(object sender, RoutedEventArgs e)
        {
            Clientes clientes = (Clientes)ClienteIdComboBox.SelectedItem;
            cotizaciones.Detalle = new List<CotizacionesDetalle>();
            double cuota = Calcular(Monto());
            CotizacionesDetalle aux;

            var filaDetalle = new CotizacionesDetalle
            {

                VehiculoId = Convert.ToInt32(VehiculoIdComboBox.SelectedValue.ToString()),
                TipoSeguroId = Convert.ToInt32(TipoSeguroIdComboBox.SelectedValue.ToString()),
                CantidadCuotas = Convert.ToInt32(CantidadCuotasTextBox.Text),
                Monto = cuota

            };

            for (int i = 1; i <= int.Parse(CantidadCuotasTextBox.Text); i++)
            {
                filaDetalle.NumeroCuota = i;
                cotizaciones.Detalle.Add(filaDetalle);
                aux = filaDetalle;
                filaDetalle = new CotizacionesDetalle();
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
                var detalle = (CotizacionesDetalle)DetalleDataGrid.SelectedItem;

                /*ordenes.Monto = ordenes.Monto - (detalle.productos.Costo * (decimal)detalle.Cantidad);*/
                cotizaciones.Detalle.RemoveAt(DetalleDataGrid.SelectedIndex);
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
                return cotizaciones.Monto;
            }
            else
            {
                if (vehiculo.AñoFabricacion >= 2008)
                {
                    monto = vehiculo.ValorVehiculo + 100000;
                    cotizaciones.Monto = monto;
                    return monto;
                }
                else
                {
                    seguro = (TipoSeguros)TipoSeguroIdComboBox.SelectedItem;
                    vehiculo = (Vehiculos)VehiculoIdComboBox.SelectedItem;
                    monto = seguro.ValorSeguro + vehiculo.ValorVehiculo;

                    cotizaciones.Monto = monto;
                    return monto;
                }
            }
        }

    }
}