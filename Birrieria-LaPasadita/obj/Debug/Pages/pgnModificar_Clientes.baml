   M S B A M L   `   `   `  ����O  KBirrieria-LaPasadita, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Birrieria_LaPasadita.PagesBirrieria_LaPasadita.Pages  5      6    0Birrieria_LaPasadita.Pages.pgnModificar_Clientes   5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5	      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5
      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Birrieria_LaPasadita.Pages     5      
���   �$��Regular"�5      $��16(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5         MaterialDesignFont N� 
FontFamily# �   5       N� 
Background �	#FFE6E6E6.��5      � .+�5   
    � -   5          �Name$ Maint��5        � NavigationUIVisibility$ Hidden=�5      � 5   
   -   5         �Name$ grid2��5      .+�5      �� .+�5      �� $��Modificar Cliente��6   $	��Top=�5      $��Center=�5      $��25(�5      $
��Bold"�5      $��0,30,0,0q�5      � 5!      $��Center=�6   $��0,70,0,0q�5"       � ColumnDefinitions 5$      �� 5%      $��* �6'   �� 5&      $��* �6'   .+�5)      �� $��0��6   .+�5+      � .+�5-      �� $��ID��6$   $	��160��5.   $   $
��Bold"�5/   $   $��Center=�50   $   $��0,0,20,0q�51   $   �� 53      -   5         ��Name$ txtID��53   "   $	��Top=�54   "   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Ingresa el ID��55   "   $	��210��56   "   .  (MaterialDesignThemes.Wpf.TextFieldAssist
   HasClearButton
 .   MaterialDesignFilledTextBox#��[ 58   "   5:      � 5<      $��0,40,0,0q�6    .+�5>      �� $��NOMBRE��6$   $	��160��5?   $   $
��Bold"�5@   $   $��Center=�5A   $   $��0,0,20,0q�5B   $   �� 5D      -   5        $ 	txtNombre��5D   "   $	��Top=�5E   "   $	 Ingresa el nombre��5F   "   $	��210��5G   "   
 . #��[ 5I   "   5K      � 5M      $��0,40,0,0q�6    .+�5O      �� $��	TELÉFONO��6$   $	��160��5P   $   $
��Bold"�5Q   $   $��Center=�5R   $   $��0,0,20,0q�5S   $   �� 5U      -   5        $ txtTelefono��5U   "   $	��Top=�5V   "   $	 Ingresa el teléfono��5W   "   $	��210��5X   "   
 . #��[ 5Z   "   5\      5^      �� 5`      $��1��6   $��50,0,0,0q�5a      .+�5c      � .+�5e      �� $��APELLIDO PATERNO��6$   $	��160��5f   $   $
��Bold"�5g   $   $��Center=�5h   $   $��0,0,20,0q�5i   $   �� 5k      -   5        $ txtApellidoPat��5k   "   $	��Top=�5l   "   $	 Ingresa el apellido��5m   "   $	��210��5n   "   
 . #��[ 5p   "   5r      � 5t      $��0,40,0,0q�6    .+�5v      �� $��APELLIDO MATERNO��6$   $	��160��5w   $   $
��Bold"�5x   $   $��Center=�5y   $   $��0,0,20,0q�5z   $   �� 5|      -   5        $ txtApellidoMat��5|   "   $	��Top=�5}   "   $	 Ingresa el apellido��5~   "   $	��210��5   "   
 . #��[ 5�   "   5�      � 5�      $��0,40,0,0q�6    .+�5�      �� $��
DIRECCIÓN��6$   $	��160��5�   $   $
��Bold"�5�   $   $��Center=�5�   $   $��0,0,20,0q�5�   $   �� 5�      -   5        $ txtDireccion��5�   "   $	��Top=�5�   "   $	 Ingresa el direccion��5�   "   $	��210��5�   "   
 . #��[ 5�   "   5�      5�      5�      � 5�      $��Center=�6   $��0,80,0,0q�5�      .+�5�      �� -	   5         ��Name$ 	btnBuscar��5�      $��0,0,50,0q�5�      $��Buscar cliente��5�       " MaterialDesignRaisedDarkButton#��[ 5�      6Q   �� 5�      -
   5        $ btnModClientes��5�      $��Modificar cliente��5�      #��[ 5�      5�      �� 5�      -   5        $ btnCancelar��5�      $��Cancelar��6.   $��50,0,0,0q�5�      #��[ 5�      6Q   5�      5�      5�      5�      5�      