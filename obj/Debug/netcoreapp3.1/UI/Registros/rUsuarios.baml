   M S B A M L   `   `   `  ����K  GSegurosVehiculos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SegurosVehiculos.UI.RegistrosSegurosVehiculos.UI.Registros  5   	   c6clr-namespace:SegurosVehiculos.Imagenes.PasswordHelper(SegurosVehiculos.Imagenes.PasswordHelper  5   	   -    'SegurosVehiculos.UI.Registros.rUsuarios   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SegurosVehiculos.UI.Registros     5   	   QPasswordHelper6clr-namespace:SegurosVehiculos.Imagenes.PasswordHelper     5   	     � Title$  Registro de Usuarios��5	   	   $	��400��6&   $	��410��63    � WindowStartupLocation$ CenterScreen=�6@    � 
ResizeMode$ CanMinimize=�6e    � Icon$ /Imagenes/Agendar.png��6~   .��5
      �  J� OpacityMask 5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ White��6    � Offset$ 1Q�6-   5      ��5   
   �� 5      $ 0.5,1&�6"   $ 0.5,0&�63   .��5      � $ 	#FF0AA0AE��6   � 5      $ 	#FF0091FF��6   $ 1Q�61   5      .+�5   
   �� $��-23,-110,0,0q�6   $	��Top=�6-   $
��Left=�6E   $	��450��6a   $	��600��6m   .+�5      �� $��	UsuarioId��6   $
��15px(�6*   $��-300,150,0,50q�6:   $��SimSun-ExtB)�6Q   $��Normal$�6j   $��80��6}   $��33��6�   $
��Bold"�6�   �� 5      -   5        	 ��Name$	 UsuarioIdTextBox��5      $��50��6N   $��25��6Y   $��10,-150,0,0q�6e   ��62   �� *	UsuarioId+6e   �� 5#      $��Fecha��6   $��13.5px(�6&   $��-295,-80,1,1q�68   $��SimSun-ExtB)�6N   $��Normal$�6g   $��82��6z   $��25��6�   $
��Bold"�6�   (  "System.Windows.Controls.DatePicker  5$      -   5        
  Name$
 FechaDatePicker��5$      $	��190��6T   $��30��6`   $��150,-80,0,0q�6l      SelectedDate 64   �� *Fecha+6l   �� 5*      $��Nombre��6   $
��15px(�6'   $��-310,-15,1,1q�67   $��SimSun-ExtB)�6M   $��Normal$�6f   $��68��6y   $
��Bold"�6�   �� 5+      -   5        $	 NombreTextBox��5+      $	��190��6H   $��25��6T   $��150,-30,0,0q�6`   ��6/   �� *Nombre+6`   �� 52      $��Apellido��6   $
��15px(�6)   $��-295,10,1,1q�69   $��SimSun-ExtB)�6N   $��Normal$�6g   $��83��6z   $
��Bold"�6�   �� 53      -   5        $	 ApellidoTextBox��53      $	��190��6L   $��25��6X   $��150,-30,0,0q�6d   ��61   �� *
Apellido+6d   �� 59      $��Nombre Usuario��6   $
��15px(�6/   $��-225,10,1,1q�6?   $��SimSun-ExtB)�6T   $��Normal$�6m   $	��155��6�   $
��Bold"�6�   �� 5:      -   5        $	 NombreUsuarioTextBox��5:      $	��190��6V   $��27��6b   $��150,-30,0,0q�6n   ��66   �� *NombreUsuario+6n   �� 5?      $��
Contrasena��6   $
��15px(�6+   $��-280,10,1,1q�6;   $��SimSun-ExtB)�6P   $��Normal$�6i   $	��100��6|   $
��Bold"�6�   G� 5@      -   5         G�Name$ ClavePasswordBox��5@      =   7SegurosVehiculos.Imagenes.PasswordHelper.PasswordHelper   Attach$
 True��64   $��30��6�   $	��190��6�   $��150,-30,1,1q�6�      Password 6`   �� *Clave+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5E      $��Confirmar Contrasena��6   $
��15px(�65   $��	35,10,1,1q�6E   $��SimSun-ExtB)�6X   $��Normal$�6q   $
��Bold"�6�   G� 5F      -   5        $ ConfirmarClavePasswordBox��5F      $
 True��6=   $��30��6i   $	��190��6u   $��150,-30,1,1q�6�   �� 5K      -   5         ��Name$ BuscarButton��5K      $��240,-480,0,0q�6,   $	��100��6B   $��40��6P   $��     Buscar��6^   $
��Bold"�6�   �� 5L      $��/Imagenes/Buscar.png��6   $��30��63   $��30��6>   $��180,-480,0,0q�6K   �� 5R      -	   5        $ NuevoButton��5R      $��-270,20,0,0q�6+   $	��100��6@   $��40��6N   $��        Nuevo��6\   $
��Bold"�6�   $��Stretch=�6�   $��Stretch=�6�   �� 5S      $��/Imagenes/Nuevo.png��6   $��40��62   $��40��6=   $��-330,-40,0,0q�6J   �� 5Y      -
   5        $ GuardarButton��5Y      $��-20,-40,0,0q�6-   $	��100��6B   $��40��6P   $��        Guardar��6^   $
��Bold"�6�   �� 5Z      $��/Imagenes/Guardar.jpg��6   $��35��64   $��35��6?   $��-80,-40,0,0q�6L   �� 5`      -   5        $ EliminarButton��5`      $��240,-40,0,0q�6.   $	��100��6C   $��40��6Q   $��          Eliminar��6_   $
��Bold"�6�   �� 5a      $��/Imagenes/Eliminar.png��6   $��40��65   $��40��6@   $��180,-40,0,0q�6M   5e      5f      5g      