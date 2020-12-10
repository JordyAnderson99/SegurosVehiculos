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
    public partial class rPagos : Window
    {
        private Pagos pagos = new Pagos();
        public rPagos()
        {
            InitializeComponent();
            this.DataContext = pagos;

            //ComboBox del ClienteId
            ClienteIdComboBox.ItemsSource = ClientesBLL.GetList(s => true);
            ClienteIdComboBox.SelectedValuePath = "ClienteId";
            ClienteIdComboBox.DisplayMemberPath = "Nombre";

            // ComboBox del VehiculoId
            VentaIdComboBox.ItemsSource = VentasBLL.GetList(p => true);
            VentaIdComboBox.SelectedValuePath = "VentaId";
            VentaIdComboBox.DisplayMemberPath = "VentaId";
        
            //// ComboBox del NumeroCuotaId
            //NumeroCuotaIdComboBox.ItemsSource = TipoSegurosBLL.GetList(p => true);
            //NumeroCuotaIdComboBox.SelectedValuePath = "NumeroCuotaId";
            //NumeroCuotaIdComboBox.DisplayMemberPath = "NumeroCuota";
        }
        //LIMPIAR
        private void Limpiar()
        {
            this.pagos = new Pagos();
            this.DataContext = pagos;
        }
        //VALIDAR
        private bool Validar()
        {
            bool esValido = true;
            if (PagoIdTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Transaccion Fallida", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (!int.TryParse(PagoIdTextBox.Text, out int PagoId))
            {
                esValido = false;
                MessageBox.Show("Este Id no es valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (!Double.TryParse(TotalTextBox.Text, out Double Total))
            {
                esValido = false;
                MessageBox.Show("Este Total no es valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            //—————————————————————————————————[ Pago Id ]—————————————————————————————————
            if (PagoIdTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (Pago Id) está vacío.\n\nAsigne un Pago al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                PagoIdTextBox.Text = "0";
                PagoIdTextBox.Focus();
                PagoIdTextBox.SelectAll();
                esValido = false;
            }


           

            //—————————————————————————————————[ ClienteId ]—————————————————————————————————
            if (ClienteIdComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (ClienteId) está vacío.\n\nAsigne un Cliente al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                ClienteIdComboBox.Focus();
                ClienteIdComboBox.IsDropDownOpen = true;
                esValido = false;
            }


            //—————————————————————————————————[ VentaId ]—————————————————————————————————
            if (VentaIdComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (VentaId) está vacío.\n\nAsigne una Venta al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);

                VentaIdComboBox.Focus();
                VentaIdComboBox.IsDropDownOpen = true;
                esValido = false;
            }



            /*//—————————————————————————————————[ NumeroCuotaIdComboBox ]—————————————————————————————————
            if (NumeroCuotaIdComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (NumeroCuota) está vacío.\n\nAsigne un NumeroCuota al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                NumeroCuotaIdComboBox.Text = "0";
                NumeroCuotaIdComboBox.Focus();
                NumeroCuotaIdComboBox.IsDropDownOpen = true;
                esValido = false;
            }
            */



            //—————————————————————————————————[ TotalTextBox ]—————————————————————————————————
            if (TotalTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Campo (Total) está vacío.\n\nAsigne un Total al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                TotalTextBox.Text = "0";
                TotalTextBox.Focus();
                TotalTextBox.SelectAll();
                esValido = false;
            }


            return esValido;
        }
        //BOTON BUSCAR---------------------------------------------------------------- 
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var pago= PagosBLL.Buscar(Utilidades.ToInt(PagoIdTextBox.Text));
            if (pago != null)
                this.pagos = pago;
            else
                this.pagos = new Pagos();

            this.DataContext = this.pagos;
        }
        //BOTON NUEVO --------------------------------------------------------------------
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }
        //BOTO GUARDAR -------------------------------------------------------------------
        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (!Validar())
                    return;

                var paso = PagosBLL.Guardar(pagos);
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Transaccion Exitosa!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Transaccion Fallida", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }



        }
        //BOTON ELIMINAR ----------------------------------------------------------
        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (PagosBLL.Eliminar(Utilidades.ToInt(PagoIdTextBox.Text)))
                {
                    Limpiar();
                    MessageBox.Show("Registro Eliminado!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("No fue posible eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void VentaIdComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(VentaIdComboBox.SelectedIndex == -1) { return; }
            var ventas = (Ventas)VentaIdComboBox.SelectedItem;
            NumeroCuotaIdComboBox.ItemsSource = PagosBLL.GetCuotas(ventas.VentaId);
        }

        private void NumeroCuotaIdComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NumeroCuotaIdComboBox.SelectedIndex == -1) { return; }
            var ventas = VentasBLL.Buscar(int.Parse(VentaIdComboBox.SelectedValue.ToString()));
           
           TotalTextBox.Text = ventas.Detalle[1].Monto.ToString();
           pagos.Total = ventas.Detalle[1].Monto;

        }


   

    }
}