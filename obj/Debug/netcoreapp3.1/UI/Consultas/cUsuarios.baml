   M S B A M L   `   `   `  ����K  GSegurosVehiculos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SegurosVehiculos.UI.ConsultasSegurosVehiculos.UI.Consultas  5   	   c6clr-namespace:SegurosVehiculos.Imagenes.PasswordHelper(SegurosVehiculos.Imagenes.PasswordHelper  5   	   -    'SegurosVehiculos.UI.Consultas.cUsuarios   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SegurosVehiculos.UI.Consultas     5   	   QPasswordHelper6clr-namespace:SegurosVehiculos.Imagenes.PasswordHelper     5   	     � Title$  Consultas de Usuarios��5	   	   $	��450��6'   $	��800��64    � WindowStartupLocation$ CenterScreen=�6A    � 
ResizeMode$ CanMinimize=�6f    � Icon$ /Imagenes/Lista.png��6   .��5
      �  J� OpacityMask 5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ White��6    � Offset$ 1Q�6-   5      ��5   
   �� 5      $ 0.5,1&�6"   $ 0.5,0&�63   .��5      � $ 	#FF0AA0AE��6   � 5      $ 	#FF0091FF��6   $ 1Q�61   5      .+�5   
   �� 	 �� Orientation$	 Vertical=�6   $��0,5,0,0q�6,   $��Center=�6=   .+�5      �� $	 
Horizontal=�6   $��60��62   .+�5      �� .+�5      �� $��Desde:��6   $
��Bold"�6-   (  "System.Windows.Controls.DatePicker  5      -   5        
  Name$
 DesdeDatePicker��5   !   $��0,0,15,0q�6:   5      �� 5$      $	 Vertical=�6   $��0,0,20,0q�64   .+�5%      �� $��Hasta:��6   $
��Bold"�6-     5&      -   5        $
 HastaDatePicker��5&   !   5'      �� 5,      $��0,0,10,0q�6   .+�5-      �� $��Filtro:��6   $
��Bold"�6.   �� 5.      -   5         ��Name$ FiltroComboBox��5.      $��95��67   $��24��6B   .@�5/      �� $��
Usuario Id��6'   �� 50      $��Nombres��6'   �� 51      $��	Apellidos��6'   �� 52      $��Nombre Usuario��6'   53      54      �� 59      $	��5,0q�6   .+�5:      �� $��Critero:��6   $
��Bold"�6/   �� 5;      -   5         ��Name$ CriterioTextBox��5;      $��95��67   $��24��6B   $��0,0,10,0q�6N   $��Center=�6`   5<      �� 5A      -   5         ��Name$ ConsultarButton��5A      $��35��62   $��90��6>   $
��Bold"�6g   .��5B      �� $	 
Horizontal=�6!   .+�5C      �� $��/Imagenes/Buscar.png��6    �� 5D      $��	Consultar��6    $��-7,0,0,0q�64   5E      5F      5K      �� 5L      $
��Left=�6   $	��635��64   .+�5M      &   System.Windows.Controls.DataGrid  -   5          Name$ DatosDataGrid��5M      $	��330��62      
IsReadOnly$
 True��6?      AutoGenerateColumns$ False��6Q      AlternatingRowBackground
 ����� �� TextAlignment$ Center=�6�   ��5O      �� 5P      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5Q      � $ 	#FFBCC8C9��6+   $ 0.544Q�6=   � 5R      $ 	#FFB2C2C5��6+   $ 0.946Q�6=   5S         Columns 5V      0  *System.Windows.Controls.DataGridTextColumn  5W      ,  &System.Windows.Controls.DataGridColumn   Header$       UsuarioId    ��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   �� *	UsuarioId+  5X      $           Nombre        ��6-    6O   �� *Nombre+  5Y      $       Apellido       ��6-    6L   �� *
Apellido+  5Z      $%          Fecha Creacion        ��6-    6V   �� *Fecha+ �� StringFormat$ 
dd/MM/yyyy��  5[      $' !          Nombre Usuario         ��6-    6X   �� *NombreUsuario+5]      5^      5`      5a      5b      