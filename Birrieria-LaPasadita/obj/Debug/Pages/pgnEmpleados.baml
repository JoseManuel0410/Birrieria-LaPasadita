   M S B A M L   `   `   `  ����O  KBirrieria-LaPasadita, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Birrieria_LaPasadita.PagesBirrieria_LaPasadita.Pages  5      -    'Birrieria_LaPasadita.Pages.pgnEmpleados   5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5	      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5
      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Birrieria_LaPasadita.Pages     5      
���   �$��Regular"�5      $��16(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5         MaterialDesignFont N� 
FontFamily# �   5       N� Title$ pgnEmpleados��5       N� 
Background �	#FFE6E6E6.��5      � .+�5   
    � -   5          �Name$
 Main��5        � NavigationUIVisibility$ Hidden=�5      � 5   
   -   5         �Name$ grid_1��5      .+�5      �� .+�5      � $��0,50,0,0q�6   $��Center=�5      $	��Top=�5      .+�5!      �� -   5         ��Name$ txtCodEmpleado��5!      $��0,0,50,0q�5"      $	��Top=�5#      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Codigo del empleado��5$      $	��210��5%      .  (MaterialDesignThemes.Wpf.TextFieldAssist
   HasClearButton
 .   MaterialDesignFilledTextBox#��[ 5'      �� 5)      -   5        $ txtNomEmpleado��5)      $	��Top=�5*      $	 Nombre del empleado��5+      $	��210��5,      
 . #��[ 5.      �� 50      $	 Ordenar por:��6   $��50,0,0,0q�51      $	��210��52      
 .    MaterialDesignFilledComboBox#��[ 54      .@�55      �� $��Alfabéticamente��6'   �� 56      $��Cargo��6'   �� 57      $��Sueldo��6'   �� 58      $
��Lada��6'   59      �� 5;      $	 Estado��6   $��50,0,0,0q�5<      $	��210��5=      
 . #��[ 5?      .@�5@      �� $��Activo��6'   �� 5A      $��Inactivo��6'   5B      5D      �� 5F      
�������$
��0,60q�5G      $	��300��5H      $	��300��5I      $	��600��5J      $	��600��5K      $��2q�5L      $��Center=�5M      ._�5O      �� $
��Auto=�6#   $
��Auto=�5P   #   $��Center=�5Q   #   ��. ���	#FFD6D6D6.��5U      &   System.Windows.Controls.DataGrid  -   5          Name$ 
dtgValores��5U   #      AutoGenerateColumns . $��Center=�5W   #   5X   #   5Z      5\      � 5^      $��Center=�6   $	��Top=�5_      .+�5a      �� -   5         ��Name$ btnRegEmpleados��5a      $��Registrar empleados��5b       " MaterialDesignRaisedDarkButton#��[ 5c      5d      �� 5f      -   5        $ btnEliminarEmpleado��5f      $��Eliminar empleado��5g      $��30,0,0,0q�5h      #��[ 5i      5j      �� 5l      -   5        $ btnModificarEmpleado��5l      $��Modificar empleados��5m      $��30,0,0,0q�5n      #��[ 5o      6U   5q      5s      5u      5w      5y      