   M S B A M L   `   `   `  ����O  KBirrieria-LaPasadita, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Birrieria_LaPasadita.Formularios Birrieria_LaPasadita.Formularios  5   	   0    *Birrieria_LaPasadita.Formularios.frmventas   5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:Birrieria_LaPasadita.Formularios     5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5	   	    � Title$ 	frmventas��5   	   $	��720��5   	   $
��1280��6    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ CanMinimize=�5   	   .��5      � ���	#FF1F1F1F � ColumnDefinitions 5   
   �� 5      $	��222 �6   �� 5      $��* �6   .+�5   
   ]� $
��Left=�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   ���	#FF323232$
��auto��5!      $	��Top=�5"      .+�5#      �� $��\Imagenes/Usuario.png��6   $��32��5$      $��32��5%      $��10,20,10,20q�5&      �� 5'      -   5         ��Name$ 
txtusuario��5(      $��Center=�5'      $��	5,20,0,20q�5)      $��18(�5*      
��������� 5,       �� BaselineAlignment$ Center=�6   .�60   	Alberto69   6?   5-      �� 50      ���	#FF323232.+�51      �� -   5        	 ��Name$	 
btnordenes��51      $��50��52      $��10,100,10,50q�53      $��16(�54      $	��200��55      ���	#FF1F1F1F
�������+  %MaterialDesignThemes.Wpf.ButtonAssist
   CornerRadius$
 25��58       " MaterialDesignRaisedDarkButton#��[ 5:       � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners��5;      {�59      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�.��5<      �� $ 
Horizontal=�6!   .+�5=      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ FileSign=�62   $��25��6B   $��25��6M   �� 5>      $��Center=�6$   $��10,0,0,0q�6?   	ORDENES6Z   5?      5@      �� 5A      -   5        $	 btnempleados��5A      $��50��5B      $	��200��5C      $��16(�5D      $��5,0,5,50q�5E      ���	#FF1F1F1F
�������$
 25��5H      #��[ 5J      $7 1MaterialDesignRaisedDarkButton with Round Corners��5K      {�5I      �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�.��5L      �� $ 
Horizontal=�6!   .+�5M        $ AccountGroup=�62   $��25��6F   $��25��6Q   �� 5N      $��Center=�6$   $��10,0,0,0q�6?   	EMPLEADOS6\   5O      5P      �� 5Q      -   5        $	 	btnventas��5Q      $��50��5R      $	��200��5S      $��16(�5T      $��5,0,5,50q�5U      ���	#FF1F1F1F
�������$
 25��5X      {�.  #��[ 5Z      $7 1MaterialDesignRaisedDarkButton with Round Corners��5[      .��5\      �� $ 
Horizontal=�6!   .+�5]        $
 Bank=�62   $��25��6>   $��25��6I   �� 5^      $��Center=�6$   $��10,0,0,0q�6?   VENTAS6Y   5_      5`      �� 5a      -   5        $	 btnclientes��5a      $��50��5b      $	��200��5c      $��16(�5d      $��5,0,5,0q�5e      ���	#FF1F1F1F
�������$
 25��5h      #��[ 5j      $7 1MaterialDesignRaisedDarkButton with Round Corners��5k      {�5i      �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�.��5l      �� $ 
Horizontal=�6!   .+�5m      �� $��\Imagenes/cliente.png��6    $��25��6?   $��25��6J   �� 5n      $��Center=�6$   $��10,0,0,0q�6?   
CLIENTES6[   5o      5p      5q      5r      �� 5u   
   $��1��6   $��0,10,0,0q�6%   .+�5v      �� $��Reporte de ventas��6   
�������$��25(�5x      $��DemiBold"�5y      $��Center=�5z      � 5{      $��Center=�6   $��0,30,0,0q�65   .+�5|      �� $��Fecha de Inicio:��6   
�������$��16(�5~      $��Center=�5      (  "System.Windows.Controls.DatePicker  5�      $	��160��6   $��14(�5�      $��10,0,0,0q�5�      
�������)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Igrese la fecha��5�       " MaterialDesignFilledDatePicker#��[ 5�      �� 5�      $��Fecha de Fin:��6   $��80,0,0,0q�5�      
�������$��16(�5�      $��Center=�5�        5�      $	��160��6   $��14(�5�      $��10,0,0,0q�5�      
�������$ Igrese la fecha��5�      #��[ 5�      �� 5�      $��Center=�6   ���	#FF1F1F1F$��45��5�      $	��160��5�      $��20,0,0,0q�5�      #��[ 5�      $
 10��5�      .��5�      � .+�5�      �� 
�������$��20(�6<   Buscar6R   �� 5�      $��5,0,5,0q�6$     5�      $ Magnify=�62   
�������$��25��5�   2   $��25��5�   2   5�      5�      5�      � 5�      $��Center=�6   $��0,30,0,0q�65   .+�5�      �� $��Center=�6   ���	#FF1F1F1F$��45��5�      $	��220��5�      #��[ 5�      $
 10��5�      .��5�      � .+�5�        $ FileExcelOutline=�62   
�������$��25��5�   2   $��25��5�   2   �� 5�      $��5,0,5,0q�6$   �� 5�      
�������$��20(�6<   Descargar Excel6[   5�      5�      �� 5�      $��Buscar por:��6   
�������$��18(�5�      $��50,0,0,0q�5�      $��Center=�5�      �� 5�      $	��250��6   $��10,0,0,0q�5�      
�������$��14(�5�       �� 
IsEditable . $ Tipo de busqueda��5�         MaterialDesignFilledComboBox#��[ 5�      .@�5�      �� $��Item 1��6#   �� 5�      $��Item 2��6#   �� 5�      $��Item 3��6#   5�      �� 5�      $	��190��6   $��70,0,0,0q�5�      $	��Top=�5�      $
��Left=�5�      $	��190��5�      
�������$��14(�5�      $ Busqueda especifica��5�        MaterialDesignFilledTextBox#��[ 5�      �� 5�      $��Center=�6   $��10,0,0,0q�5�      ���	#FF1F1F1F$��45��5�      $��90��5�      #��[ 5�      $
 10��5�      .��5�      � .+�5�        $ Magnify=�62   
�������$��25��5�   2   $��25��5�   2   5�      5�      5�      &   System.Windows.Controls.DataGrid  5�      -   5          Name$ 
dtgdVentas��5�         AutoGenerateColumns .     CanUserAddRows .  $��Center=�5�      $��0,50,0,0q�5�      $��15(�5�      $	��980��5�      $
��1000��5�      $	��400��5�      "   VerticalScrollBarVisibility$
 Auto=�5�      $   HorizontalScrollBarVisibility$ Visible=�5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Fecha Registro��6)   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6A   �� *FechaRegistro+  5�      $ Número Documento��6)    6C   �� *NumeroDocumento+  5�      $ Monto Total��6)    6>   �� *
MontoTotal+  5�      $ Usuario Registro��6)    6C   �� *UsuarioRegistro+  5�      $ Nombre Cliente��6)    6A   �� *NombreCliente+  5�      $ Código Producto��6)    6B   �� *CodigoProducto+  5�      $ Nombre Producto��6)    6B   �� *NombreProducto+  5�      $ Precio Unitario��6)    6B   �� *PrecioUnitario+  5�      $ Cantidad��6)    6;   �� *
Cantidad+  5�      $ Subtotal��6)    6;   �� *
Subtotal+5�      5�      5�      5�      