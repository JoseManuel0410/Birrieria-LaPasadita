   M S B A M L   `   `   `  ����O  KBirrieria-LaPasadita, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Birrieria_LaPasadita.PagesBirrieria_LaPasadita.Pages  5      7    1Birrieria_LaPasadita.Pages.pgnModificar_Empleados   5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5	      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5
      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Birrieria_LaPasadita.Pages     5      
���   �$��Regular"�5      $��16(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5         MaterialDesignFont N� 
FontFamily# �   5       N� Title$ pgnModificar_Empleados��5       N� 
Background �	#FFE6E6E6.��5      � .+�5   
    � -   5          �Name$ Maint��5        � NavigationUIVisibility$ Hidden=�5      � 5   
   -   5         �Name$ grid2��5      .+�5      �� .+�5      �� $��Modificar empleado��6   $	��Top=�5      $��Center=�5      $��25(�5      $
��Bold"�5       $��0,30,0,0q�5!      � 5#      $��Center=�6   $��0,70,0,0q�5$       � ColumnDefinitions 5&      �� 5'      $��* �6'   �� 5(      $��* �6'   .+�5+      �� $��0��6   .+�5-      � .+�5/      �� $��ID��6$   $	��160��50   $   $
��Bold"�51   $   $��Center=�52   $   $��0,0,20,0q�53   $   �� 55      -   5        	 ��Name$	 txtID��55   "   $	��Top=�56   "   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Ingresa el ID��57   "   $	��210��58   "   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton .   MaterialDesignFilledTextBox#��[ 5:   "   5<      � 5>      $��0,40,0,0q�6    .+�5@      �� $��NOMBRE��6$   $	��160��5A   $   $
��Bold"�5B   $   $��Center=�5C   $   $��0,0,20,0q�5D   $   �� 5F      -   5        $	 	txtNombre��5F   "   $	��Top=�5G   "   $
 Ingresa el nombre��5H   "   $	��210��5I   "    . #��[ 5K   "   5M      � 5O      $��0,40,0,0q�6    .+�5Q      �� $��	TELÉFONO��6$   $	��160��5R   $   $
��Bold"�5S   $   $��Center=�5T   $   $��0,0,20,0q�5U   $   �� 5W      -   5        $	 txtTelefono��5W   "   $	��Top=�5X   "   $
 Ingresa el teléfono��5Y   "   $	��210��5Z   "    . #��[ 5\   "   5^      � 5`      $��0,40,0,0q�6    .+�5b      �� $��SUELDO MENSUAL��6$   $	��160��5c   $   $
��Bold"�5d   $   $��Center=�5e   $   $��0,0,20,0q�5f   $   �� 5h      -   5        $	 	txtSueldo��5h   "   $	��Top=�5i   "   $
 Ingresa el sueldo��5j   "   $	��210��5k   "    . #��[ 5m   "   5o      5s      �� 5u      $��1��6   $��50,0,0,0q�5v      .+�5x      � .+�5z      �� $��APELLIDO PATERNO��6$   $	��160��5{   $   $
��Bold"�5|   $   $��Center=�5}   $   $��0,0,20,0q�5~   $   �� 5�      -   5        $	 txtApellidoPat��5�   "   $	��Top=�5�   "   $
 Ingresa el apellido��5�   "   $	��210��5�   "    . #��[ 5�   "   5�      � 5�      $��0,40,0,0q�6    .+�5�      �� $��APELLIDO MATERNO��6$   $	��160��5�   $   $
��Bold"�5�   $   $��Center=�5�   $   $��0,0,20,0q�5�   $   �� 5�      -   5        $	 txtApellidoMat��5�   "   $	��Top=�5�   "   $
 Ingresa el apellido��5�   "   $	��210��5�   "    . #��[ 5�   "   5�      � 5�      $��0,40,0,0q�6    .+�5�      �� $��CARGO��6$   $	��160��5�   $   $
��Bold"�5�   $   $��Center=�5�   $   $��0,0,20,0q�5�   $   �� 5�      -	   5         ��Name$ cbxCargo��5�   '   $
 Ordenar por:��5�   #   $	��210��5�   #    .    MaterialDesignFilledComboBox#��[ 5�   #   5�      5�      � 5�      $��0,40,0,0q�6    .+�5�      �� $��
DIRECCIÓN��6$   $	��160��5�   $   $
��Bold"�5�   $   $��Center=�5�   $   $��0,0,20,0q�5�   $   �� 5�      -
   5        $	 txtDireccion��5�   "   $	��Top=�5�   "   $
 Ingresa el direccion��5�   "   $	��210��5�   "    . #��[ 5�   "   5�      5�      5�      � 5�      $��Center=�6   $��0,80,0,0q�5�      .+�5�      �� -   5         ��Name$ 	btnBuscar��5�      $��0,0,50,0q�5�      $��Buscar empleado��5�       " MaterialDesignRaisedDarkButton#��[ 5�      6Q   �� 5�      -   5        $ btnModEmpleados��5�      $��Modificar empleado��5�      #��[ 5�      5�      �� 5�      -   5        $ btnCancelar��5�      $��Cancelar��6.   $��50,0,0,0q�5�      #��[ 5�      6Q   5�      5�      5�      5�      5�      