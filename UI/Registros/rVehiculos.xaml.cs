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

            if(VehiculoIdTextBox.Text.Length ==0){
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
                this.DataContext = this.vehiculos;
                MessageBox.Show($"Este Vehiculo no fue encontrado.\n\nAsegúrese que existe o cree uno nuevo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                Limpiar();
                VehiculoIdTextBox.SelectAll();
                VehiculoIdTextBox.Focus();
            }
            this.DataContext = this.vehiculos;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e){

            Limpiar();
        }








        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (!Validar())
                    return;

                //—————————————————————————————[ VALIDAR TEXTBOX ]———————————————————————————————————————————————————————
               
               
               
                //—————————————————————————————————[ VehiculoId  ]—————————————————————————————————
                if (VehiculoIdTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (VehiculoId) está vacío.\n\nAsigne un VehiculoId al Usuario.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    VehiculoIdTextBox.Text = "0";
                    VehiculoIdTextBox.Focus();
                    VehiculoIdTextBox.SelectAll();
                    return;
                }
                //—————————————————————————————————[ CantidadPasajeros ]—————————————————————————————————
                if (CantidadPasajerosTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (CantidadPasajeros) está vacío.\n\nEscriba la Cantidad de Pasajeros en el campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    CantidadPasajerosTextBox.Clear();
                    CantidadPasajerosTextBox.Focus();
                    return;
                }
                //—————————————————————————————————[ Cilindros ]—————————————————————————————————
                if (CilindrosTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (Cilindros) está vacío.\n\nEscriba los Cilindros en el campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    CilindrosTextBox.Clear();
                    CilindrosTextBox.Focus();
                    return;
                }
               

                //—————————————————————————————————[ Uso ]—————————————————————————————————
                if (UsoTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (Uso) está vacío.\n\nAsigne un Uso al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    UsoTextBox.Focus();
                    UsoTextBox.SelectAll();
                    return;
                }
               



               //—————————————————————————————————[ Chasis ]—————————————————————————————————
                if (ChasisTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (Chasis) está vacío.\n\nAsigne un Chasis al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ChasisTextBox.Focus();
                    ChasisTextBox.SelectAll();
                    return;
                }


               //—————————————————————————————————[ Matricula ]—————————————————————————————————
                if (MatriculaTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (Matricula) está vacío.\n\nAsigne una Matricula al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    MatriculaTextBox.Focus();
                    MatriculaTextBox.SelectAll();
                    return;
                }


               //—————————————————————————————————[ ValorVehiculo ]—————————————————————————————————
                if (ValorVehiculoTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (ValorVehiculo) está vacío.\n\nAsigne un Valor al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ValorVehiculoTextBox.Focus();
                    ValorVehiculoTextBox.SelectAll();
                    return;
                }



               


                //—————————————————————————————————[ AñoFabricacion ]—————————————————————————————————
                if (AñoFabricacionTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (AñoFabricacion) está vacío.\n\nAsigne un Año al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    AñoFabricacionTextBox.Focus();
                    AñoFabricacionTextBox.SelectAll();
                    return;
                }


                //—————————————————————————————————[ Motor ]—————————————————————————————————
                if (MotorTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (Motor) está vacío.\n\nAsigne un Motor al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    MotorTextBox.Focus();
                    MotorTextBox.SelectAll();
                    return;
                }


                //—————————————————————————————————[ FuerzaMotriz ]—————————————————————————————————
                if (FuerzaMotrizTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (FuerzaMotriz) está vacío.\n\nAsigne una FuerzaMotriz al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    FuerzaMotrizTextBox.Focus();
                    FuerzaMotrizTextBox.SelectAll();
                    return;
                }


                //—————————————————————————————————[ CapacidadCarga ]—————————————————————————————————
                if (CapacidadCargaTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (CapacidadCarga) está vacío.\n\nAsigne una Capacidad al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    CapacidadCargaTextBox.Focus();
                    CapacidadCargaTextBox.SelectAll();
                    return;
                }


                //—————————————————————————————————[ TotalPuertas ]—————————————————————————————————
                if (TotalPuertasTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (TotalPuertas) está vacío.\n\nAsigne un Total al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    TotalPuertasTextBox.Focus();
                    TotalPuertasTextBox.SelectAll();
                    return;
                }


                //—————————————————————————————————[ ColorId ]—————————————————————————————————
                if (ColorIdComboBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (ColorId) está vacío.\n\nAsigne un Color al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ColorIdComboBox.Focus();
                    ColorIdComboBox.IsDropDownOpen = true;
                    return;
                }



                //—————————————————————————————————[ MarcaId ]—————————————————————————————————
                if (MarcaIdComboBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (MarcaId) está vacío.\n\nAsigne una Marca al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    MarcaIdComboBox.Focus();
                    MarcaIdComboBox.IsDropDownOpen = true;
                    return;
                }




                //—————————————————————————————————[ ModeloId ]—————————————————————————————————
                if (ModeloIdComboBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (ModeloId) está vacío.\n\nAsigne un Modelo al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ModeloIdComboBox.Focus();
                    ModeloIdComboBox.IsDropDownOpen = true;
                    return;
                }



                //—————————————————————————————————[ StatusVehiculoId ]—————————————————————————————————
                if (StatusVehiculoIdComboBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (StatusVehiculoId) está vacío.\n\nAsigne un Status al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    StatusVehiculoIdComboBox.Focus();
                    StatusVehiculoIdComboBox.IsDropDownOpen = true;
                    return;
                }


                //—————————————————————————————————[ TipoEmisionId ]—————————————————————————————————
                if (TipoEmisionIdComboBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (TipoEmisionId) está vacío.\n\nAsigne un Tipo de Emision al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    TipoEmisionIdComboBox.Focus();
                    TipoEmisionIdComboBox.IsDropDownOpen = true;
                    return;
                }


                //—————————————————————————————————[ TipoVehiculoId ]—————————————————————————————————
                if (TipoVehiculoIdComboBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El Campo (TipoVehiculoId) está vacío.\n\nAsigne un Tipo de Vehiculo al campo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    TipoVehiculoIdComboBox.Focus();
                    TipoVehiculoIdComboBox.IsDropDownOpen = true;
                    return;
                }
                
                var paso = VehiculosBLL.Guardar(vehiculos);
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Transacción Exitosa", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Transacción Fallida", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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

        private void ColorIdComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var color = ((ComboBox)sender).Items.CurrentItem as Colores;
            if (color != null)
            {
                vehiculos.ColorId = color.ColorId;
            }

        }

        private void MarcaIdComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Marca = ((ComboBox)sender).Items.CurrentItem as MarcaVehiculos;
            if (Marca != null)
            {

                vehiculos.MarcaId = Marca.MarcaId;

            }

        }

        private void ModeloIdComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Modelo = ((ComboBox)sender).Items.CurrentItem as Modelos;
            if (Modelo != null)
            {

                vehiculos.ModeloId = Modelo.ModeloId;

            }

        }

        private void StatusVehiculoIdComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var StatusVehiculo = ((ComboBox)sender).Items.CurrentItem as StatusVehiculo;
            if (StatusVehiculo != null)
            {

                vehiculos.StatusVehiculoId = StatusVehiculo.StatusVehiculoId;

            }

        }

        private void TipoEmisionIdComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var TipoEmision = ((ComboBox)sender).Items.CurrentItem as TipoEmision;
            if (TipoEmision != null)
            {

                vehiculos.TipoEmisionId = TipoEmision.TipoEmisionId;

            }

        }

        private void TipoVehiculoIdComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var TipoVehiculo = ((ComboBox)sender).Items.CurrentItem as TipoVehiculo;
            if (TipoVehiculo != null)
            {

                vehiculos.TipoVehiculoId = TipoVehiculo.TipoVehiculoId;

            }

        }
    }
}