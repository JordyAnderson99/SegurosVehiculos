   M S B A M L   `   `   `  ����K  GSegurosVehiculos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SegurosVehiculos.UI.RegistrosSegurosVehiculos.UI.Registros  5   	   -    'SegurosVehiculos.UI.Registros.rClientes   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SegurosVehiculos.UI.Registros     5   	     � Title$  Registro de Clientes��5   	   $	��470��6&   $	��410��63    � WindowStartupLocation$ CenterScreen=�6@    � 
ResizeMode$ CanMinimize=�6e    � Icon$ /Imagenes/Agendar.png��6~   .��5	      �  J� OpacityMask 5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ White��6    � Offset$ 1Q�6-   5      ��5   
   �� 5      $ 0.5,1&�6"   $ 0.5,0&�63   .��5      � $ 	#FF0AA0AE��6   � 5      $ 	#FF0091FF��6   $ 1Q�61   5      .+�5   
   �� $��-23,-110,0,0q�6   $	��Top=�6-   $
��Left=�6E   $	��450��6a   $	��600��6m   .+�5      �� $��	ClienteId��6   $
��15px(�6*   $��-300,150,0,50q�6:   $��SimSun-ExtB)�6Q   $��Normal$�6j   $��80��6}   $��33��6�   $
��Bold"�6�   �� 5      -   5        	 ��Name$	 ClienteIdTextBox��5      $��50��6N   $��25��6Y   $��10,-150,0,0q�6e   ��62   �� *	ClienteId+6e   �� 5"      $��Fecha��6   $��13.5px(�6&   $��-295,-80,1,1q�68   $��SimSun-ExtB)�6N   $��Normal$�6g   $��82��6z   $��25��6�   $
��Bold"�6�   (  "System.Windows.Controls.DatePicker  5#      -   5        
  Name$
 FechaDatePicker��5#      $	��190��6T   $��30��6`   $��150,-80,0,0q�6l      SelectedDate 64   �� *Fecha+6l   �� 5*      $��Nombre��6   $
��15px(�6'   $��-310,-15,1,1q�67   $��SimSun-ExtB)�6M   $��Normal$�6f   $��68��6y   $
��Bold"�6�   �� 5+      -   5        $	 NombreTextBox��5+      $	��190��6H   $��25��6T   $��150,-30,0,0q�6`   ��6/   �� *Nombre+6`   �� 52      $��Apellido��6   $
��15px(�6)   $��-295,10,1,1q�69   $��SimSun-ExtB)�6N   $��Normal$�6g   $��83��6z   $
��Bold"�6�   �� 53      -   5        $	 ApellidoTextBox��53      $	��190��6L   $��25��6X   $��150,-30,0,0q�6d   ��61   �� *
Apellido+6d   �� 58      $��	Direccion��6   $
��15px(�6*   $��-295,10,1,1q�6:   $��SimSun-ExtB)�6O   $��Normal$�6h   $��83��6{   $
��Bold"�6�   �� 59      -   5        $	 DireccionTextBox��59      $	��190��6N   $��25��6Z   $��150,-30,0,0q�6f   ��62   �� *	Direccion+6f   �� 5>      $��Telefono��6   $
��15px(�6)   $��-295,10,1,1q�69   $��SimSun-ExtB)�6N   $��Normal$�6g   $��83��6z   $
��Bold"�6�   �� 5?      -   5        $	 TelefonoTextBox��5?      $	��190��6L   $��25��6X   $��150,-30,0,0q�6d   ��61   �� *
Telefono+6d   �� 5E      $��Celular��6   $
��15px(�6(   $��-295,10,1,1q�68   $��SimSun-ExtB)�6M   $��Normal$�6f   $��83��6y   $
��Bold"�6�   �� 5F      -   5        $	 CelularTextBox��5F      $	��190��6J   $��25��6V   $��150,-30,0,0q�6b   ��60   �� *	Celular+6b   �� 5L      $��Cedula��6   $
��15px(�6'   $��-295,10,1,1q�67   $��SimSun-ExtB)�6L   $��Normal$�6e   $��83��6x   $
��Bold"�6�   �� 5M      -   5        $	 CedulaTextBox��5M      $	��190��6H   $��25��6T   $��150,-30,0,0q�6`   ��6/   �� *Cedula+6`   �� 5S      $��Correo Electronico��6   $
��15px(�63   $��-225,10,1,1q�6C   $��SimSun-ExtB)�6X   $��Normal$�6q   $	��155��6�   $
��Bold"�6�   �� 5T      -	   5        $	 CorreoElectronicoTextBox��5T      $	��190��6^   $��25��6j   $��150,-30,0,0q�6v   ��6:   �� *CorreoElectronico+6v   �� 5[      -
   5         ��Name$ BuscarButton��5[      $��240,-620,0,0q�6,   $	��100��6B   $��40��6P   $��     Buscar��6^   $
��Bold"�6�   �� 5\      $��/Imagenes/Buscar.png��6   $��30��63   $��30��6>   $��180,-620,0,0q�6K   �� 5b      -   5        $ NuevoButton��5b      $��-270,20,0,0q�6+   $	��100��6@   $��40��6N   $��        Nuevo��6\   $
��Bold"�6�   $��Stretch=�6�   $��Stretch=�6�   �� 5c      $��/Imagenes/Nuevo.png��6   $��40��62   $��40��6=   $��-330,-40,0,0q�6J   �� 5i      -   5        $ GuardarButton��5i      $��-20,-40,0,0q�6-   $	��100��6B   $��40��6P   $��        Guardar��6^   $
��Bold"�6�   �� 5j      $��/Imagenes/Guardar.jpg��6   $��35��64   $��35��6?   $��-80,-40,0,0q�6L   �� 5p      -   5        $ EliminarButton��5p      $��240,-40,0,0q�6.   $	��100��6C   $��40��6Q   $��          Eliminar��6_   $
��Bold"�6�   �� 5q      $��/Imagenes/Eliminar.png��6   $��40��65   $��40��6@   $��180,-40,0,0q�6M   5u      5v      5w      