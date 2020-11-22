using System;
using System.Collections.Generic;
using System.Windows;
using SegurosVehiculos.BLL;
using SegurosVehiculos.Entidades;

namespace SegurosVehiculos.UI.Consultas
{
    public partial class cUsuarios : Window
    {
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Usuarios>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        try
                        {
                            listado = UsuariosBLL.GetList(u => u.UsuarioId == Utilidades.ToInt(CriterioTextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido para aplicar este filtro.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;

                    case 1:
                        try
                        {
                            listado = UsuariosBLL.GetList(u => u.Nombre.Contains(CriterioTextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido para aplicar este filtro.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;
                    case 2:
                        try
                        {
                            listado = UsuariosBLL.GetList(u => u.Apellido.Contains(CriterioTextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido para aplicar este filtro.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;
                    case 3:
                        try
                        {
                            listado = UsuariosBLL.GetList(u => u.NombreUsuario.Contains(CriterioTextBox.Text));
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
               
                listado = UsuariosBLL.GetList(c => true);
            }

            if (DesdeDatePicker.SelectedDate != null)
                listado = UsuariosBLL.GetList(c => c.Fecha.Date >= DesdeDatePicker.SelectedDate);

            if (HastaDatePicker.SelectedDate != null)
                listado = UsuariosBLL.GetList(c => c.Fecha.Date <= HastaDatePicker.SelectedDate);

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }


    }
}