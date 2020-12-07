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
            //—————————————————————————————————[ Observaciones ]—————————————————————————————————
            if (ObservacionesTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (Observaciones) está vacío.\n\nAsegurese de que este lleno", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                ObservacionesTextBox.Focus();
                ObservacionesTextBox.SelectAll();
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
            VehiculoId = Convert.ToInt32(VehiculoIdComboBox.SelectedValue.ToString()),
            TipoSeguroId = Convert.ToInt32(TipoSeguroIdComboBox.SelectedValue.ToString()),                
            NumeroCuota = Convert.ToInt32(NumeroCuotaTextBox.Text),
            CantidadCuotas = Convert.ToInt32(CantidadCuotasTextBox.Text),
            Monto = Convert.ToInt32(MontoTextBox.Text)

        };

        /* ordenes.Monto += producto.Costo * int.Parse(CantidadTextBox.Text);*/
            this.cotizaciones.Detalle.Add(filaDetalle);


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


    }
}