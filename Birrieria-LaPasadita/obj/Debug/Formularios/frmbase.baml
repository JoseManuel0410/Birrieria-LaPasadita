   M S B A M L   `   `   `  ����O  KBirrieria-LaPasadita, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Birrieria_LaPasadita.Formularios Birrieria_LaPasadita.Formularios  5   	   .    (Birrieria_LaPasadita.Formularios.frmbase   5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5	   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5
   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:Birrieria_LaPasadita.Formularios     5   	   
���   �$��Regular"�5   	   $��17(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignFont#���   5   	    � Title$ LA PASADITA��5   	   $	��720��5   	   $
��1280��5   	    � WindowStartupLocation$ CenterScreen=�5   	   ���	#FFE6E6E6 � Icon$ \Imagenes/Logo.png��5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $
��4.6* �6   .+�5   
   � ���	#FFBEBEBE � RowDefinitions 5      �� 5       $��1* �6    �� 5!      $
��4.5* �6    .+�5#      � $��Center=�6   $��Center=�5$      .+�5%      �� $��\Imagenes/Usuario.png��6   $��48��5&      $��48��5'      $��0q�5(      �� 5)      -   5         ��Name$ 
txtusuario��5*      $��Center=�5)      $��	5,20,0,20q�5+      $��19(�5,      $��SemiBold"�5-      $��Alberto��5.      5/      �� 50      $��1��6   .+�51      �� -   5         ��Name$ 
btnordenes��51       " MaterialDesignRaisedDarkButton#��[ 52      $��17(�53      $��45��54      $��
25,60,25,0q�55      .��57      � .+�58      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 FileSign=�62   $��25��59   2   $��25��5:   2   �� 5;      $��ORDENES��6$   $��Center=�5<   $   $��10,0,0,0q�5=   $   5>      5?      �� 5@      $
��0,20q�6   ��5A      Z� �� 5B      -   5        $ btnempleados��5B      #��[ 5C      $��17(�5D      $��45��5E      $
��25,0q�5F      .��5H      � .+�5I        $	 AccountGroup=�62   $��25��5J   2   $��25��5K   2   �� 5L      $��	EMPLEADOS��6$   $��Center=�5M   $   $��10,0,0,0q�5N   $   5O      5P      �� 5Q      $
��0,20q�6   ��5R      Z� �� 5S      -   5        $ 	btnventas��5S      #��[ 5T      $��17(�5U      $��45��5V      $
��25,0q�5W      .��5Y      � .+�5Z        $
	 Bank=�62   $��25��5[   2   $��25��5\   2   �� 5]      $��VENTAS��6$   $��Center=�5^   $   $��10,0,0,0q�5_   $   5`      5a      �� 5b      $
��0,20q�6   ��5c      Z� �� 5d      -   5        $ btnclientes��5d      #��[ 5e      $��17(�5f      $��45��5g      $
��25,0q�5h      .��5j      � .+�5k      �� $��\Imagenes/cliente.png��6    $��25��5l       $��25��5m       �� 5n      $��CLIENTES��6$   $��Center=�5o   $   $��10,0,0,0q�5p   $   5q      5r      5s      5t       � 5x   
   -   5        
  �Name$

 Main��5x      $��1��5y        � NavigationUIVisibility$ Hidden=�5z      5|      5}      