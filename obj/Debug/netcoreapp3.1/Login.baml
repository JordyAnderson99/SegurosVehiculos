   M S B A M L   `   `   `  ����K  GSegurosVehiculos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:SegurosVehiculos.UI.LoginSegurosVehiculos.UI.Login  5   	   c6clr-namespace:SegurosVehiculos.Imagenes.PasswordHelper(SegurosVehiculos.Imagenes.PasswordHelper  5   	   %    SegurosVehiculos.UI.Login.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:SegurosVehiculos.UI.Login     5   	   QPasswordHelper6clr-namespace:SegurosVehiculos.Imagenes.PasswordHelper     5   	     � Title$  Login��5	   	   $	��550��6   $	��400��6$    � Icon$ /Imagenes/login.png��60   .��5      �  J� OpacityMask 5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ White��6    � Offset$ 1Q�6-   5      ��5   
   �� 5      $ 0.5,1&�6"   $ 0.5,0&�63   .��5      � $ 	#FF0AA0AE��6   � 5      $ 	#FF0091FF��6   $ 1Q�61   5      .+�5   
   ��  �� Orientation$ Vertical=�6   $��10q�6,   $	��300��68   $��Center=�6F   .+�5      �� $��LogIn��6   $��Center=�6$   $
��Bold"�6A   $��18(�6S   �� 5       $��Nombre Usuario��6   $��0,5,0,0q�6-   $
��Bold"�6>   �� 5!      $ 
Horizontal=�6   .+�5"      �� $��/Imagenes/Usuario.png��6   $	��40 ��67   $��30��6D   �� 5#      -   5         ��Name$ NombreUsuarioTextBox��5#      $	��240��6W   $��Center=�6c   $��30��6�   ��68   �� *NombreUsuario+6�   5$      �� 5*      $��Contraseña��6   $��0,10,0,0q�6)   $
��Bold"�6;   �� 5+      $ 
Horizontal=�6   .+�5,      �� $��/Imagenes/Llave.png��6   $��30��65   G� 5-      -   5        	 G�Name$	 ClavePasswordBox��5-      =   7SegurosVehiculos.Imagenes.PasswordHelper.PasswordHelper
   Attach$

 True��68   $	��240��6�   $��Center=�6�      Password 6d   �� *Clave+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   5.      �� 5/      $ 
Horizontal=�6   $��0,25,0,0q�62   $��Center=�6D   .+�57      �� -   5         ��Name$ CancelarButton��57      $	��100��6N   ���	#FFBEBEBE$��0,0,35,0q�6r   .��58      �� $ 
Horizontal=�6!   .+�5:      �� $��Cancelar��6    $
��Bold"�63   $��14(�6E   5;      5<      �� 5B      -   5        $ IngresarButton��5B      $	��100��6N   ���	#FFBEBEBE.��5C      �� $ 
Horizontal=�6!   .+�5E      �� $��Ingresar��6    $
��Bold"�63   $��14(�6E   5F      5G      5H      5I      5P      5Q      