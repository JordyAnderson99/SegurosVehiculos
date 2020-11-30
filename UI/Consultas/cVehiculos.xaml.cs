using System;
using System.Collections.Generic;
using System.Windows;
using SegurosVehiculos.BLL;
using SegurosVehiculos.Entidades;


namespace SegurosVehiculos.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cVehiculos.xaml
    /// </summary>
    public partial class cVehiculos : Window
    {
        public cVehiculos()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Vehiculos>();
             var lista = new List<TipoVehiculo>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        try
                        {
                            listado = VehiculosBLL.GetList(u => u.VehiculoId == Utilidades.ToInt(CriterioTextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido para aplicar este filtro.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;





                    case 1:
                        try
                        {
                            listado = VehiculosBLL.GetList(u => u.Matricula.Contains(CriterioTextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido para aplicar este filtro.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;



                   case 2:
                        try
                        {
                            lista = TipoVehiculoBLL.GetList(u => u.TipoVehiculoId == Utilidades.ToInt(CriterioTextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido para aplicar este filtro.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;


                   case 3:
                        try
                        {
                            listado = VehiculosBLL.GetList(u => u.AñoFabricacion == Utilidades.ToInt(CriterioTextBox.Text));
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
               
                listado = VehiculosBLL.GetList(c => true);
            }

            if (DesdeDatePicker.SelectedDate != null)
                listado = VehiculosBLL.GetList(c => c.Fecha.Date >= DesdeDatePicker.SelectedDate);

            if (HastaDatePicker.SelectedDate != null)
                listado = VehiculosBLL.GetList(c => c.Fecha.Date <= HastaDatePicker.SelectedDate);

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }


    }
}