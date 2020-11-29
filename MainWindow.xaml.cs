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

        private void rVehiculosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rVehiculos vehiculos = new rVehiculos();
            vehiculos.Show();
        }

    }
}
