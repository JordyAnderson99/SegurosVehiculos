   M S B A M L   `   `   `  ����K  GSegurosVehiculos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SegurosVehiculos.UI.ConsultasSegurosVehiculos.UI.Consultas  5   	   1    +SegurosVehiculos.UI.Consultas.cCotizaciones   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SegurosVehiculos.UI.Consultas     5   	     � Title$  Consultas de Cotizaciones��5   	   $	��450��6+   $	��800��68    � WindowStartupLocation$ CenterScreen=�6E    � 
ResizeMode$ CanMinimize =�6j    � Icon$ /Imagenes/Lista.png��6�   .��5	      �  J� OpacityMask 5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ White��6    � Offset$ 1Q�6-   5      ��5   
   �� 5      $ 0.5,1&�6"   $ 0.5,0&�63   .��5      � $ 	#FF0AA0AE��6   � 5      $ 	#FF0091FF��6   $ 1Q�61   5      .+�5   
   �� 	 �� Orientation$	 Vertical=�6   $��0,5,0,0q�6,   $��Center=�6=   .+�5      �� $	 
Horizontal=�6   $��60��62   .+�5      �� .+�5      �� $��Desde:��6   $
��Bold"�6-   (  "System.Windows.Controls.DatePicker  5      -   5        
  Name$
 DesdeDatePicker��5   !   $��0,0,15,0q�6:   5      �� 5"      $	 Vertical=�6   $��0,0,20,0q�64   .+�5#      �� $��Hasta:��6   $
��Bold"�6-     5$      -   5        $
 HastaDatePicker��5$   !   5%      �� 5*      $��0,0,10,0q�6   .+�5+      �� $��Filtro:��6   $
��Bold"�6.   �� 5,      -   5         ��Name$ FiltroComboBox��5,      $��95��67   $��24��6B   .@�5-      �� $��CotizacionId��6'   �� 5.      $��	ClienteId��6'   �� 5/      $��
VehiculoId��6'   �� 50      $��TipoSeguroId��6'   54      55      �� 5:      $	��5,0q�6   .+�5;      �� $��Critero:��6   $
��Bold"�6/   �� 5<      -   5         ��Name$ CriterioTextBox��5<      $��95��67   $��24��6B   $��0,0,10,0q�6N   $��Center=�6`   5=      �� 5B      -   5         ��Name$ ConsultarButton��5B      $��35��62   $��95��6>   $��-5,0,0,0q�6g   .��5C      �� $	 
Horizontal=�6!   .+�5D      �� $��/Imagenes/Buscar.png��6    �� 5E      $��	Consultar��6    $
��Bold"�64   $��-5,0,0,0q�6F   5F      5G      5L      �� 5M      $
��Left=�6   $	��635��64   .+�5N      &   System.Windows.Controls.DataGrid  -   5          Name$ DatosDataGrid��5N      $	��330��62      
IsReadOnly$
 True��6?      AutoGenerateColumns$ False��6Q      AlternatingRowBackground
 ����� �� TextAlignment$ Center=�6�   ��5P      �� 5Q      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5R      � $ 	#FFBCC8C9��6+   $ 0.544Q�6=   � 5S      $ 	#FFB2C2C5��6+   $ 0.946Q�6=   5T         Columns 5W      0  *System.Windows.Controls.DataGridTextColumn  5X      ,  &System.Windows.Controls.DataGridColumn   Header$    CotizacionId   ��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *CotizacionId+  5Y      $    Fecha   ��6-    6B   �� *Fecha+ �� StringFormat$ 
dd/MM/yyyy��  5Z      $   ClienteId  ��6-    6D   �� *	ClienteId+  5[      $ 
VehiculoId��6-    6A   �� *
VehiculoId+  5\      $ TipoSeguroId��6-    6C   �� *TipoSeguroId+  5]      $ 	  Monto  ��6-    6@   �� *Monto+  5^      $   Observaciones  ��6-    6H   �� *Observacione+  5_      $   CantidadCuotas ��6-    6H   �� *CantidadCuotas+5a      5b      5d      5e      5f      