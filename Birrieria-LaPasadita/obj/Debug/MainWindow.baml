   M S B A M L   `   `   `  ����O  KBirrieria-LaPasadita, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Birrieria_LaPasaditaBirrieria_LaPasadita  5   	   %    Birrieria_LaPasadita.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Birrieria_LaPasadita     5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   ���	#FF303030  MaterialDesignFont#���  5	   	    � Title$ LOGIN��5   	   $	��720��5   	   $
��1280��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$ \Imagenes/Logo.png��5   	    � 
ResizeMode$ CanMinimize=�5   	   .��5      � ���	#FFE6E6E6.+�5   
   � $��180,50,180,50q�6   $	��604��5      $	��920��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6#      
BlurRadius$ 50Q�5    #   	   ShadowDepth$	 0Q�5!   #   
   Opacity$	
 0.7Q�5"   #    � ColumnDefinitions 5$      �� 5%      $��* �6#   �� 5&      $��* �6#   .+�5*      �� $��0��6   ���	#FF455A64.+�5,      �� $��Center=�6   $��50,50,50,60q�5-      $��\Imagenes/Logo.png��5.      $	��256��5/      $	��256��50       J� Opacity$	 0.9Q�51       52        53      $ 50Q�6+   $	 1Q�54   +   $	
 0.5Q�55   +   57      �� 58      $��	50,0,50,0q�6   $��45(�59      $��DemiBold"�5:       �� TextAlignment$ Center=�5;      ���	#FFEAEAEA	BIRRIERIA�� 5<   =   "LA PASADITA"6X   5=      �� 5@      $��1��6   
�������.+�5B      �� $��Right=�6   $	��Top=�5C      $��
0,50,125,0q�5D      
���   �$��Roboto)�5F      $��40(�5G      $
��Bold"�5H      
Bienvenido6:   �� 5J      -   5         ��Name$ 
txtusuario��5J      $	��250��5K      $��	0,50,0,50q�5L      $��18(�5M       �� 	MaxLength$ 20��5N      $��Center=�5O      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ USUARIO��5P         
Foreground
 �   �.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 �   �!   CharacterCounterVisibility$ Hidden=�5S       % !MaterialDesignFloatingHintTextBox#��[ 5T       � Cursor$  ��5U       �� 
CaretBrush
 �   ����	#890000005W      �� 5Y      -   5        $ txtcontraseña��5Y      $	��250��5Z      $��	0,50,0,50q�5[      $��18(�5\      $ 20��5]      $��Center=�5^      $ CONTRASEÑA��5_      
 �   �
 �   �$ Hidden=�5b      #��[ 5c      $  ��5d      
 �   ����	#890000005f      �� 5h      -   5         ��Name$ btnRegEmpleados��5h      $	��250��5i      $��Iniciar Sesión��5j       " MaterialDesignRaisedDarkButton#��[ 5k      5l      5n      5o      5p      5q      