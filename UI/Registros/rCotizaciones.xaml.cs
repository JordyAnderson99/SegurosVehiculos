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
            var cotizaciones = CotizacionesBLL.Buscar(Utilidades.ToInt(CotizacionIdTextBox.Text));
            if (cotizaciones != null)
                this.cotizaciones = cotizaciones;
            else
                this.cotizaciones = new Cotizaciones();

            this.DataContext = this.cotizaciones;
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

                //———————————————————————————————————[ VALIDAR TEXTBOX ]———————————————————————————————————————————————————————
               
               
               
                //—————————————————————————————————[ Cotizacion Id ]—————————————————————————————————
                if (CotizacionIdTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (Cotizacion Id) está vacío.\n\nAsigne un Id al Usuario.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    CotizacionIdTextBox.Text = "0";
                    CotizacionIdTextBox.Focus();
                    CotizacionIdTextBox.SelectAll();
                    return;
                }
                //—————————————————————————————————[ Fecha ]—————————————————————————————————
                if (FechaDatePicker.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (Fecha) está vacío.\n\nEscriba sus Nombres.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                  //  FechaDatePicker.Clear();
                    FechaDatePicker.Focus();
                    return;
                }
                //—————————————————————————————————[ Cliente Id ]—————————————————————————————————
               /*if (ClienteIdComboBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (ClienteId) está vacío.\n\nEscriba sus Apellidos.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ClienteIdComboBox.Clear();
                    ClienteIdComboBox.Focus();
                    return;
                }
               

                //—————————————————————————————————[ Vehiculo Id ]—————————————————————————————————
                if (VehiculoIdComboBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (VehiculoId) está vacío.\n\nAsigne un Nombre al Usuario.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    VehiculoIdComboBox.Focus();
                    VehiculoIdComboBox.SelectAll();
                    return;
                }
                //—————————————————————————————————[ Tipo Seguro Id ]—————————————————————————————————
                if (TipoSeguroIdComboBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (TipoSeguroId) está vacío.\n\nAsigne un Nombre al Usuario.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    TipoSeguroIdComboBox.Focus();
                    TipoSeguroIdComboBox.SelectAll();
                    return;
                }

                */

                
                //—————————————————————————————————[ Monto ]—————————————————————————————————
                if (MontoTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (Monto) está vacío.\n\nAsigne una Contraseña al Usuario.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    MontoTextBox.Focus();
                    MontoTextBox.SelectAll();
                    return;
                }
                //—————————————————————————————————[ Observaciones ]—————————————————————————————————
                if (ObservacionesTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (Observaciones) está vacío.\n\nConfirme la Contraseña del Usuario.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ObservacionesTextBox.Focus();
                    ObservacionesTextBox.SelectAll();
                    return;
                }
                //—————————————————————————————————[CantidadCuotas ]—————————————————————————————————
                if (CantidadCuotasTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (CantidadCuotas) está vacío.\n\nConfirme la Contraseña del Usuario.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    CantidadCuotasTextBox.Focus();
                    CantidadCuotasTextBox.SelectAll();
                    return;
                }

                
                var paso = CotizacionesBLL.Guardar(cotizaciones);
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
                    MessageBox.Show("No fue posible eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        
        //Boton de Agregar Fila
        private void AgregarFilaButton_Click(object sender, RoutedEventArgs e)
        {
            Clientes clientes = (Clientes)ClienteIdComboBox.SelectedItem;
            var filaDetalle = new CotizacionesDetalle
            {
                CotizacionId = this.cotizaciones.CotizacionId,
                ClienteId = Convert.ToInt32(ClienteIdComboBox.SelectedValue.ToString()),
                clientes = (Clientes)ClienteIdComboBox.SelectedItem,
                NumeroCuota = Convert.ToInt32(NumeroCuotaTextBox.Text)
            };

           /* ordenes.Monto += producto.Costo * int.Parse(CantidadTextBox.Text);
            this.ordenes.Detalle.Add(filaDetalle);*/


            Cargar();

            TipoSeguroIdComboBox.SelectedIndex = -1;
            NumeroCuotaTextBox.Clear();
            NumeroCuotaTextBox.Focus();
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