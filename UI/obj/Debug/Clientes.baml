   M S B A M L   `   `   `  ����  UI    UI.Clientes   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  Clientes��5      .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��69* �6   �� 5      $	��69* �6   �� 5      $	��69* �6   �� 5      $	��69* �6    � RowDefinitions 5   
   �� 5      $	��20* �6   �� 5      $	��20* �6   �� 5      $	��20* �6   �� 5      $	��20* �6   �� 5      $
��149* �6   .+�5   
   �� $��0��6   $��1��6    $��Nombre:��6-   $��Right=�6?   $��Center=�6[   6x   �� 5   
   $��2��6   $��1��6    $��	Apellido:��6-   $��Right=�6A   $��Center=�6]   6z   �� 5   
   $��0��6   $��2��6    $��Fecha de nacimiento:��6-   $��Right=�6L   $��Center=�6h   6�   �� 5   
   -   5         ��Name$ 	txtNombre��5      $��1��6%   $��1��65   $��7q�6B   6O   �� 5   
   -   5        $ txtApellido��5      $��3��6'   $��1��67   $��7q�6D   6Q   (  "System.Windows.Controls.DatePicker  5    
   -   5          Name$ dtpFecha��5       $��1��6'   $��2��67   $��Center=�6D   6a   �� 5"   
   -   5         ��Name$ 
btnAgregar��5"      $��3��6%   $��3��65   $��8q�6B   $��Agregar��6M   6z   �� 5#   
   -   5        $ btnModificar��5#      $��2��6'   $��3��67   $��8q�6D   $��	Modificar��6O   6�   �� 5$   
   -   5        $ btnEliminar��5$      $��1��6&   $��3��66   $��8q�6C   $��Eliminar��6N   6}   &   System.Windows.Controls.DataGrid  5%   
   -   5          Name$ 	dtg_Datos��5%      $��0��6&   $��5��66   $��4��6C   $��10q�6W   6f   5&      5'      