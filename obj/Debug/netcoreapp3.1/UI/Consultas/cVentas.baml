   M S B A M L   `   `   `  ����K  GSegurosVehiculos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SegurosVehiculos.UI.ConsultasSegurosVehiculos.UI.Consultas  5   	   +    %SegurosVehiculos.UI.Consultas.cVentas   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SegurosVehiculos.UI.Consultas     5   	     � Title$  Consultas de Ventas��5   	   $	��450��6%   $	��800��62    � WindowStartupLocation$ CenterScreen=�6?    � 
ResizeMode$ CanMinimize=�6d    � Icon$ /Imagenes/Lista.png��6}   .��5	      �  J� OpacityMask 5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ White��6    � Offset$ 1Q�6-   5      ��5   
   �� 5      $ 0.5,1&�6"   $ 0.5,0&�63   .��5      � $ 	#FF0AA0AE��6   � 5      $ 	#FF0091FF��6   $ 1Q�61   5      .+�5   
   �� 	 �� Orientation$	 Vertical=�6   $��0,5,0,0q�6,   $��Center=�6=   .+�5      �� $	 
Horizontal=�6   $��60��62   .+�5      �� .+�5      �� $��Desde:��6   $
��Bold"�6-   (  "System.Windows.Controls.DatePicker  5      -   5        
  Name$
 DesdeDatePicker��5   !   $��0,0,15,0q�6:   5      �� 5#      $	 Vertical=�6   $��0,0,20,0q�64   .+�5$      �� $��Hasta:��6   $
��Bold"�6-     5%      -   5        $
 HastaDatePicker��5%   !   5&      �� 5+      $��0,0,10,0q�6   .+�5,      �� $��Filtro:��6   $
��Bold"�6.   �� 5-      -   5         ��Name$ FiltroComboBox��5-      $��95��67   $��24��6B   .@�5/      �� $��VentaId ��6'   �� 50      $��
VehiculoId��6'   �� 51      $��TipoSeguroId��6'   �� 52      $��NumeroCuotaId��6'   55      56      �� 5;      $	��5,0q�6   .+�5<      �� $��Critero:��6   $
��Bold"�6/   �� 5=      -   5         ��Name$ CriterioTextBox��5=      $��95��67   $��24��6B   $��0,0,10,0q�6N   $��Center=�6`   5>      �� 5C      -   5         ��Name$ ConsultarButton��5C      $��35��62   $��90��6>   $
��Bold"�6g   .��5D      �� $	 
Horizontal=�6!   .+�5E      �� $��/Imagenes/Buscar.png��6    �� 5F      $��	Consultar��6    $��-5,0,0,0q�64   5G      5H      5M      �� 5N      $
��Left=�6   $	��635��64   .+�5O      &   System.Windows.Controls.DataGrid  -   5          Name$ DatosDataGrid��5O      $	��330��62      
IsReadOnly$
 True��6?      AutoGenerateColumns$ False��6Q      AlternatingRowBackground
 ����� �� TextAlignment$ Center=�6�   ��5Q      �� 5R      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5S      � $ 	#FFBCC8C9��6+   $ 0.544Q�6=   � 5T      $ 	#FFB2C2C5��6+   $ 0.946Q�6=   5U         Columns 5X      0  *System.Windows.Controls.DataGridTextColumn  5Y      ,  &System.Windows.Controls.DataGridColumn   Header$    VentaId   ��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *	ClienteId+  5Z      $ 	  Fecha  ��6-    6@   �� *Fecha+ �� StringFormat$ 
dd/MM/yyyy��  5[      $ 	  Vence  ��6-    6@   �� *Vence+$ 
dd/MM/yyyy��  5\      $   VehiculoId  ��6-    6E   �� *
VehiculoId+  5]      $ TipoSeguroId��6-    6C   �� *TipoSeguroId+  5^      $ Numero de Cuota��6-    6F   �� *NumeroCuotaId+  5_      $ Monto��6-    6<   �� *Monto+  5`      $   Observaciones  ��6-    6H   �� *Observaciones+  5a      $   CantidadCuotas��6-    6G   �� *CantidadCuotas+5c      5d      5f      5g      5h      