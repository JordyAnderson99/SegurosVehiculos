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
using SegurosVehiculos.Entidades;
using SegurosVehiculos.BLL;

namespace SegurosVehiculos.UI.Registros 
{
    /// <summary>
    /// Interaction logic for rMoras.xaml
    /// </summary>
    public partial class rVehiculos : Window
    {
        private Vehiculos vehiculos = new Vehiculos(); 
        
        public rVehiculos()
        {
            InitializeComponent();
            //--------------------ColorId ComboBox--------------------------
            ColorIdComboBox.ItemsSource= ColoresBLL.GetList(p =>true);
            ColorIdComboBox.SelectedValuePath= "ColorId";
            ColorIdComboBox.DisplayMemberPath="Color";

            //--------------------MarcaId ComboBox--------------------------
            MarcaIdComboBox.ItemsSource = MarcaVehiculosBLL.GetList(p => true);
            MarcaIdComboBox.SelectedValuePath = "MarcaId";
            MarcaIdComboBox.DisplayMemberPath = "Marca";

            //--------------------ModeloId ComboBox--------------------------
            ModeloIdComboBox.ItemsSource = ModelosBLL.GetList(p => true);
            ModeloIdComboBox.SelectedValuePath = "ModeloId";
            ModeloIdComboBox.DisplayMemberPath = "ModeloVehiculo";

            //--------------------StatusVehiculoId ComboBox--------------------------
            StatusVehiculoIdComboBox.ItemsSource = StatusVehiculoBLL.GetList(p => true);
            StatusVehiculoIdComboBox.SelectedValuePath = "StatusVehiculoId";
            StatusVehiculoIdComboBox.DisplayMemberPath = "Status";

            //--------------------TipoEmisionId ComboBox--------------------------
            TipoEmisionIdComboBox.ItemsSource = TipoEmisionBLL.GetList(p => true);
            TipoEmisionIdComboBox.SelectedValuePath = "TipoEmisionId";
            TipoEmisionIdComboBox.DisplayMemberPath = "Emision";

            //--------------------TipoVehiculoId ComboBox--------------------------
            TipoVehiculoIdComboBox.ItemsSource = TipoVehiculoBLL.GetList(p => true);
            TipoVehiculoIdComboBox.SelectedValuePath = "TipoVehiculoId";
            TipoVehiculoIdComboBox.DisplayMemberPath = "Tipo";
            this.DataContext= vehiculos;
        }

        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = vehiculos;
        }

        private void Limpiar(){
            this.vehiculos = new Vehiculos();
            this.DataContext= vehiculos;
        }

        private bool Validar(){
            bool esValido = true;

            if(MatriculaTextBox.Text.Length ==0){
                esValido = false;
                MessageBox.Show("Transaccion Fallida" , "Fallo", 
                MessageBoxButton.OK, MessageBoxImage.Warning);
                                
            }            
            


            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e){
              var vehiculo = VehiculosBLL.Buscar(this.vehiculos.VehiculoId);

            if(vehiculo!= null){
                    this.vehiculos = vehiculo;
                Cargar();
            }
            else{
                    this.vehiculos = new Vehiculos();
            }
            this.DataContext = this.vehiculos;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e){

            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e){
            
            if(!Validar()){
                return;
            }
            
                var paso = VehiculosBLL.Guardar(vehiculos);
                if(paso){
                Limpiar();
                MessageBox.Show("Transaccion exitosa!" , "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else{
                MessageBox.Show("Transaccion Fallida", "Fallo",  MessageBoxButton.OK, MessageBoxImage.Error);
                }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e){
            if(VehiculosBLL.Eliminar(Utilidades.ToInt(VehiculoIdTextBox.Text))){

                Limpiar();
                MessageBox.Show("Registro eliminado!" , "Exito" , MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else{
                MessageBox.Show("No fue posible eliminar", "Fallo",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}