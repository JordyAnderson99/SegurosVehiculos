   M S B A M L   `   `   `  ����K  GSegurosVehiculos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SegurosVehiculos.UI.RegistrosSegurosVehiculos.UI.Registros  5   	   1    +SegurosVehiculos.UI.Registros.rCotizaciones   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SegurosVehiculos.UI.Registros     5   	     � Title$  Registro de Cotizaciones��5   	   $	��580��6*   $	��810��67    � WindowStartupLocation$ CenterScreen=�6D    � 
ResizeMode$ CanMinimize=�6i    � Icon$ /Imagenes/Agendar.png��6�   .��5
      �  J� OpacityMask 5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ White��6    � Offset$ 1Q�6-   5      ��5   
   �� 5      $ 0.5,1&�6"   $ 0.5,0&�63   .��5      � $ 	#FF0AA0AE��6   � 5      $ 	#FF0091FF��6   $ 1Q�61   5      .+�5   
   �� $��	0,-21,0,0q�6   $	��Top=�6*   $
��Left=�6B   $	��790��6^   $	��758��6j   .+�5      �� $��CotizacionId��6   $
��15px(�6-   $��-660,40,1,1q�6=   $��SimSun-ExtB)�6R   $��Normal$�6k   $	��107��6~   $
��Bold"�6�   �� 5      -   5        	 ��Name$	 CotizacionIdTextBox��5      $��60��6T   $��25��6_   $��-440,-25,0,0q�6k   ��65   �� *CotizacionId+6k   �� 5      -   5        
 ��Name$
 BuscarButton��5      $��240,-40,0,0q�6,   $	��100��6A   $��40��6O   $��     Buscar��6]   $
��Bold"�6s   $��14(�6�   �� 5      $��/Imagenes/Buscar.png��6   $��30��63   $��30��6>   $��170,-40,0,0q�6K   �� 5"      $��Fecha��6   $��13.5px(�6&   $��-715,10,0,0q�68   $��SimSun-ExtB)�6M   $��Normal$�6f   $��52��6y   $��24��6�   $
��Bold"�6�   (  "System.Windows.Controls.DatePicker  5#      -   5          Name$ FechaDatePicker��5#      $	��160��6T   $��25��6`   $��-340,-20,0,0q�6l      SelectedDate 64   �� *Fecha+6l   �� 5&      $��Observaciones��6   $
��15px(�6.   $��-650,10,1,1q�6>   $��SimSun-ExtB)�6S   $	��120��6l   $��25��6x   $��Normal$�6�   $
��Bold"�6�   �� 5'      -   5        $	 ObservacionesTextBox��5'      $	��160��6V   $��50��6b   $��-340,-25,0,0q�6n   ��66   �� *Observaciones+6n   �� 5*      $��	ClienteId��6   $
��15px(�6*   $��40,-150,1,1q�6:   $��SimSun-ExtB)�6O   $��Normal$�6h   $��90��6{   $��25��6�   $
��Bold"�6�   �� 5+      -   5         ��Name$ ClienteIdComboBox��5+      $	��120��6Y   $��25��6e   $��260,-150,0,0q�6q    �� SelectedValue 64   �� *	ClienteId+6q   �� 5/      $��
VehiculoId��6   $
��15px(�6,   $��
50,-70,1,1q�6<   $��96��6P   $��25��6[   $��SimSun-ExtB)�6g   $��Normal$�6�   $
��Bold"�6�   �� 50      -   5        $ VehiculoIdComboBox��50      $	��120��6[   $��26��6g   $��260,-70,0,0q�6s    65   �� *
VehiculoId+6s   �� 53       �� Orientation$ Vertical=�6   .+�54      �� $��Detalle de Cotizaciones��6   $��0,5,0,0q�6=   $	��774��6N   $
��Bold"�6Z   .��55      �� $	��246��6!   .+�59      �� $��SeguroId��6    $
��15px(�65   $��-655,26,1,-35q�6E   $��SimSun-ExtB)�6\   $��Normal$�6u   $��85��6�   $
��Bold"�6�   �� 5:      -   5        $ TipoSeguroIdComboBox��5:   #   $	��100��6k   $��26��6w   $��-470,-30,0,-75q�6�    6C   �� *TipoSeguroId+6�   �� 5>      $��Cantidad de Cuotas��6    $
��15px(�6?   $��-130,10,1,1q�6O   $��SimSun-ExtB)�6d   $	��150��6}   $��25��6�   $��Normal$�6�   $
��Bold"�6�   �� 5?      -   5        $	 CantidadCuotasTextBox��5?   "   $	��120��6d   $��30��6p   $��180,-30,0,0q�6|   ��6C   �� *CantidadCuotas+6|   �� 5D      $��Monto��6    $
��15px(�62   $��420,-27,1,1q�6B   $��SimSun-ExtB)�6W   $��50��6p   $��25��6{   $��Normal$�6�   $
��Bold"�6�   �� 5E      -	   5        $	 MontoTextBox��5E   "   $	��100��6R   $��30��6^   $��640,-30,0,0q�6j   ��6:   �� *Monto+6j   �� 5H      -
   5        $��ModificarMontoCheckBox��5H   #   $��Modificar Monto��6A   $��-610,10,0,0q�6[   $	��126��6p   �� 5K      -   5        $
 CalcularCuotaButton��5K   !   $��35��6>   $	��200��6J   $��-550,10,0,0q�6V   .��5L      �� $ 
Horizontal=�6)   .+�5M   "   �� $��/Imagenes/Calculadora.png��6(   $��25��6K   �� 5N   "   $��Calcular Cuota��6(   $
��Bold"�6A   5O      5P      &   System.Windows.Controls.DataGrid  5V      -   5          Name$ DetalleDataGrid��5V   #      
IsReadOnly$
 true��6=   $	��110��6O   $	��750��6\      AutoGenerateColumns$ False��6h   $��0,10,0,0q�6�   ��6�   �� *	Detalle+   Columns 5W      0  *System.Windows.Controls.DataGridTextColumn  5Y   "   ,  &System.Windows.Controls.DataGridColumn   Header$        SeguroId       ��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6U   �� *TipoSeguroId+  5Z   "   $, &             Numero de cuota          ��65    6e   �� *NumeroCuota+  5[   "   $. (           Cantidad de cuotas           ��65    6g   �� *CantidadCuotas+  5\   "   $* $               Monto                ��65    6c   �� *Monto+5`      5b      5c      5f      �� 5l      -   5        $
 NuevoButton��5l      $��-430,20,0,0q�6+   $	��120��6@   $��45��6N   $��        Nuevo��6\   $
��Bold"�6�   $��14(�6�   �� 5m      $��/Imagenes/Nuevo.png��6   $��40��62   $��45��6=   $��-490,-45,0,0q�6J   �� 5p      -   5        $
 GuardarButton��5p      $��
75,-48,0,0q�6-   $	��120��6A   $��45��6O   $��        Guardar��6]   $
��Bold"�6�   $��14(�6�   �� 5q      $��/Imagenes/Guardar.jpg��6   $��35��64   $��35��6?   $��
10,-45,0,0q�6L   �� 5t      -   5        $
 EliminarButton��5t      $��580,-48,0,0q�6.   $	��120��6C   $��45��6Q   $��          Eliminar��6_   $
��Bold"�6�   $��14(�6�   �� 5u      $��/Imagenes/Eliminar.png��6   $��45��65   $��45��6@   $��500,-45,0,0q�6M   5v      5w      5x      