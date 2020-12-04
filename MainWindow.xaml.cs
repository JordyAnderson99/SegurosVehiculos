using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SegurosVehiculos.UI.Registros;
using SegurosVehiculos.UI.Consultas;

namespace SegurosVehiculos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        //Registro de Usuarios y su consulta
       private void rUsuariosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rUsuarios rUsuarios = new rUsuarios();
            rUsuarios.Show();
        }

        private void cUsuariosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cUsuarios cUsuarios = new cUsuarios();
            cUsuarios.Show();
        }

        //Registro de Clientes y su consulta
        private void rClientesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rClientes rClientes = new rClientes();
            rClientes.Show();
        }

        private void cClientesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cClientes cClientes = new cClientes();
            cClientes.Show();
        }

        //Registro de Vehiculos y su consulta
        private void rVehiculosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rVehiculos vehiculos = new rVehiculos();
            vehiculos.Show();
        }


        private void cVehiculosMenuItem_Click(object sender, RoutedEventArgs e)
        { 
            cVehiculos vehiculos = new cVehiculos();
            vehiculos.Show();
        }

        //Registro de Cotizaciones y su consulta*******************************************************

        private void rCotizacionesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rCotizaciones rCotizaciones = new rCotizaciones();
            rCotizaciones.Show();
        }

        private void cCotizacionesMenuItem_Click(object sender, RoutedEventArgs e)
        {            
            cCotizaciones cCotizaciones = new cCotizaciones();
            cCotizaciones.Show();
        }

        //Registro de Ventas y su consulta*******************************************************
        private void rVentasMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rVentas ventas = new rVentas();
            ventas.Show();
        }

        private void cVentasMenuItem_Click(object sender, RoutedEventArgs e)
        {
            
            cVentas cVentas = new cVentas();
            cVentas.Show();

        }

        //Registro de Pagos y su consulta*******************************************************
        private void rPagosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rPagos pagos = new rPagos();
            pagos.Show();
        }

        private void cPagosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cPagos cpagos = new cPagos();
            cpagos.Show();
        }
    }
}
