   M S B A M L   `   `   `  ����K  GSegurosVehiculos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SegurosVehiculos.UI.ConsultasSegurosVehiculos.UI.Consultas  5   	   c6clr-namespace:SegurosVehiculos.Imagenes.PasswordHelper(SegurosVehiculos.Imagenes.PasswordHelper  5   	   -    'SegurosVehiculos.UI.Consultas.cClientes   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SegurosVehiculos.UI.Consultas     5   	   QPasswordHelper6clr-namespace:SegurosVehiculos.Imagenes.PasswordHelper     5   	     � Title$  Consultas de Clientes��5	   	   $	��450��6'   $	��800��64    � WindowStartupLocation$ CenterScreen=�6A    � 
ResizeMode$ CanMinimize =�6f    � Icon$ /Imagenes/Lista.png��6�   .��5
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
Cliente Id��6'   �� 50      $��Nombres��6'   �� 51      $��	Apellidos��6'   �� 52      $��	Direccion��6'   �� 53      $��Telefono��6'   �� 54      $��Celular��6'   �� 55      $��Cedula��6'   �� 56      $��CorreoElectronico��6'   �� 57      $��Fecha��6'   59      5:      �� 5?      $	��5,0q�6   .+�5@      �� $��Critero:��6   $
��Bold"�6/   �� 5A      -   5         ��Name$ CriterioTextBox��5A      $��95��67   $��24��6B   $��0,0,10,0q�6N   $��Center=�6`   5B      �� 5G      -   5         ��Name$ ConsultarButton��5G      $��35��62   $��90��6>   .��5H      �� $	 
Horizontal=�6!   .+�5I      �� $��/Imagenes/Buscar.png��6    �� 5J      $��	Consultar��6    $��-7,0,0,0q�64   $
��Bold"�6F   5K      5L      5Q      �� 5R      $
��Left=�6   $	��635��64   .+�5S      &   System.Windows.Controls.DataGrid  -   5          Name$ DatosDataGrid��5S      $	��330��62      
IsReadOnly$
 True��6?      AutoGenerateColumns$ False��6Q      AlternatingRowBackground
 ����� �� TextAlignment$ Center=�6�   ��5U      �� 5V      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5W      � $ 	#FFBCC8C9��6+   $ 0.544Q�6=   � 5X      $ 	#FFB2C2C5��6+   $ 0.946Q�6=   5Y         Columns 5\      0  *System.Windows.Controls.DataGridTextColumn  5]      ,  &System.Windows.Controls.DataGridColumn   Header$    Cliente Id   ��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� *	ClienteId+  5^      $    Nombres   ��6-    6D   �� *Nombre+  5_      $   Apellidos  ��6-    6D   �� *
Apellido+  5`      $ 	  Fecha  ��6-    6@   �� *Fecha+ �� StringFormat$ 
dd/MM/yyyy��  5a      $ 	Direccion��6-    6@   �� *	Direccion+  5b      $ Telefono��6-    6?   �� *
Telefono+  5c      $ Celular��6-    6>   �� *	Celular+  5d      $ 
  Cedula  ��6-    6A   �� *Cedula+  5e      $   CorreoElectronico��6-    6J   �� *CorreoElectronico+5g      5h      5j      5k      5l      