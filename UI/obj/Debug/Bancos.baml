   M S B A M L   `   `   `  ����  UI    	UI.Bancos   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  Bancos��5      .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��69* �6   �� 5      $	��69* �6   �� 5      $	��69* �6   �� 5      $	��69* �6    � RowDefinitions 5   
   �� 5      $	��20* �6   �� 5      $	��20* �6   �� 5      $	��20* �6   �� 5      $	��20* �6   �� 5      $
��149* �6   .+�5   
   �� $��0��6   $��1��6    $��Nombre:��6-   $��Right=�6?   $��Center=�6[   6x   �� 5   
   $��2��6   $��1��6    $��Swift:��6-   $��Right=�6>   $��Center=�6Z   6w   �� 5   
   -   5         ��Name$ 	txtNombre��5      $��1��6%   $��1��65   $��7q�6B   6O   �� 5   
   -   5        $ txtSwift��5      $��3��6$   $��1��64   $��7q�6A   6N   �� 5    
   -   5         ��Name$ 
btnAgregar��5       $��3��6%   $��3��65   $��8q�6B   $��Agregar��6M   6z   �� 5!   
   -   5        $ btnModificar��5!      $��2��6'   $��3��67   $��8q�6D   $��	Modificar��6O   6�   �� 5"   
   -   5        $ btnEliminar��5"      $��1��6&   $��3��66   $��8q�6C   $��Eliminar��6N   6}   &   System.Windows.Controls.DataGrid  5#   
   -   5          Name$ 	dtg_Datos��5#      $��0��6&   $��5��66   $��4��6C   $��10q�6W   6f   5$      5%      