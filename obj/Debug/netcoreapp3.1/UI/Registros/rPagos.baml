   M S B A M L   `   `   `  ����K  GSegurosVehiculos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SegurosVehiculos.UI.RegistrosSegurosVehiculos.UI.Registros  5   	   *    $SegurosVehiculos.UI.Registros.rPagos   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SegurosVehiculos.UI.Registros     5   	     � Title$  Registro de Pagos��5   	   $	��380��6#   $	��410��60    � WindowStartupLocation$ CenterScreen=�6=    � 
ResizeMode$ CanMinimize=�6b    � Icon$ /Imagenes/Agendar.png��6{   .��5
      �  J� OpacityMask 5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ White��6    � Offset$ 1Q�6-   5      ��5   
   �� 5      $ 0.5,1&�6"   $ 0.5,0&�63   .��5      � $ 	#FF0AA0AE��6   � 5      $ 	#FF0091FF��6   $ 1Q�61   5      .+�5   
   �� $��-23,-110,0,0q�6   $	��Top=�6-   $
��Left=�6E   $	��450��6a   $	��600��6m   .+�5      �� $��PagoId��6   $
��15px(�6'   $��-300,150,0,50q�67   $��SimSun-ExtB)�6N   $��Normal$�6g   $��80��6z   $��33��6�   $
��Bold"�6�   �� 5      -   5        	 ��Name$	 PagoIdTextBox��5      $��50��6H   $��25��6S   $��10,-150,0,0q�6_   ��6/   �� *PagoId+6_   �� 5"      $��Fecha��6   $��13.5px(�6&   $��-295,-80,1,1q�68   $��SimSun-ExtB)�6N   $��Normal$�6g   $��82��6z   $��25��6�   $
��Bold"�6�   (  "System.Windows.Controls.DatePicker  5#      -   5        
  Name$
 FechaDatePicker��5#      $	��190��6T   $��30��6`   $��150,-80,0,0q�6l      SelectedDate 64   �� *Fecha+6l   �� 5&      $��	ClienteId��6   $
��15px(�6*   $��-290,-15,1,1q�6:   $��SimSun-ExtB)�6P   $��Normal$�6i   $��85��6|   $
��Bold"�6�   �� 5'      -   5         ��Name$ ClienteIdComboBox��5'      $	��190��6Y   $��25��6e   $��150,-30,0,0q�6q    �� SelectedValue 64   �� *	ClienteId+6q   �� 5*      $��VentaId��6   $
��15px(�6(   $��-295,10,1,1q�68   $��SimSun-ExtB)�6M   $��Normal$�6f   $��83��6y   $
��Bold"�6�   �� 5+      -   5        $ VentaIdComboBox��5+      $	��190��6U   $��25��6a   $��150,-30,0,0q�6m    62   �� *	VentaId+6�   �� 5.      $��Numero Cuota��6   $
��15px(�6-   $��-245,10,1,1q�6=   $��SimSun-ExtB)�6R   $��Normal$�6k   $	��130��6~   $
��Bold"�6�   �� 5/      -   5        $ NumeroCuotaIdComboBox��5/      $	��190��6a   $��25��6m   $��150,-30,0,0q�6y    68   �� *NumeroCuotaId+6�   �� 52      $��Total��6   $
��15px(�6&   $��-295,10,1,1q�66   $��SimSun-ExtB)�6K   $��Normal$�6d   $��83��6w   $
��Bold"�6�   �� 53      -   5        $	 TotalTextBox��53       �� 
IsReadOnly$
 True��6F   $	��190��6X   $��25��6d   $��150,-30,0,0q�6p   ��6.   �� *Total+6p   �� 57      -   5         ��Name$ BuscarButton��57      $��240,-400,0,0q�6,   $	��100��6B   $��40��6P   $��     Buscar��6^   $
��Bold"�6�   �� 58      $��/Imagenes/Buscar.png��6   $��30��63   $��30��6>   $��180,-400,0,0q�6K   �� 5;      -   5        $ NuevoButton��5;      $��-270,20,0,0q�6+   $	��100��6@   $��40��6N   $��        Nuevo��6\   $
��Bold"�6�   $��Stretch=�6�   $��Stretch=�6�   �� 5<      $��/Imagenes/Nuevo.png��6   $��40��62   $��40��6=   $��-330,-40,0,0q�6J   �� 5?      -	   5        $ GuardarButton��5?      $��-20,-40,0,0q�6-   $	��100��6B   $��40��6P   $��        Guardar��6^   $
��Bold"�6�   �� 5@      $��/Imagenes/Guardar.jpg��6   $��35��64   $��35��6?   $��-80,-40,0,0q�6L   �� 5C      -
   5        $ EliminarButton��5C      $��240,-40,0,0q�6.   $	��100��6C   $��40��6Q   $��          Eliminar��6_   $
��Bold"�6�   �� 5D      $��/Imagenes/Eliminar.png��6   $��40��65   $��40��6@   $��180,-40,0,0q�6M   5F      5G      5H      