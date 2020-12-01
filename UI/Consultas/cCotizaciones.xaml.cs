using System;
using System.Collections.Generic;
using System.Windows;
using SegurosVehiculos.BLL;
using SegurosVehiculos.Entidades;

namespace SegurosVehiculos.UI.Consultas
{
    public partial class cCotizaciones : Window
    {
        public cCotizaciones()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Cotizaciones>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    
                    case 1:
                        try
                        {
                            listado = CotizacionesBLL.GetList(u => u.CotizacionId == Utilidades.ToInt(CriterioTextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido para aplicar este filtro.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;


                


                         case 2:
                        try
                        {
                            listado = CotizacionesBLL.GetList(u => u.ClienteId == Utilidades.ToInt(CriterioTextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido para aplicar este filtro.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;

                   

                    case 3:
                        try
                        {
                            listado = CotizacionesBLL.GetList(u => u.VehiculoId == Utilidades.ToInt(CriterioTextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido para aplicar este filtro.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;

                        
                     case 4:
                        try
                        {
                            listado = CotizacionesBLL.GetList(u => u.TipoSeguroId == Utilidades.ToInt(CriterioTextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido para aplicar este filtro.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;


                               
                }
            }
            else
            {
               
                listado = CotizacionesBLL.GetList(c => true);
            }

            if (DesdeDatePicker.SelectedDate != null)
                listado = CotizacionesBLL.GetList(c => c.Fecha.Date >= DesdeDatePicker.SelectedDate);

            if (HastaDatePicker.SelectedDate != null)
                listado = CotizacionesBLL.GetList(c => c.Fecha.Date <= HastaDatePicker.SelectedDate);

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }

        private void DatosDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}