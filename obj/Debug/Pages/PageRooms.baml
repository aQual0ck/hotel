   M S B A M L   `   `   `  ����@  <hotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:hotel.Pageshotel.Pages  5          hotel.Pages.PageRooms   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:hotel.Pages     5        N� Title$  	PageRooms��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��40 �6   �� 5      .+�5   
   o� .@�5      m� -   5        $��menuAdd��5      $��Добавить��6&   68   m� 5      -   5        $��
menuUpdate��5      $��Обновить��6)   6;   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5      �� -   5        $��cmbCategory��5      $	��200��6*   $��25��66   $
��5, 0q�6B   5      �� 5      -   5        $��	cmbStatus��5      $	��200��6(   $��25��64   $
��5, 0q�6@   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgrRooms��5         AutoGenerateColumns .     
IsReadOnly . $��2��5       � 	Resources 5      )  #System.Windows.Controls.DataGridRow �� 
TargetType��%E   '        �� 5      "  6   .�5      -   5        5!      5"         Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер комнаты��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6<   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5%   %   �� *
RoomNumber+  5&      $ Этаж��6%   $	 * 63   
 6=   �� *Floor+4  .System.Windows.Controls.DataGridTemplateColumn  5'      $ Категория��6)   $	 * 6<      CellTemplate 5(      �� 5)      .R�5*      ��  � DataContext 6(   ��  �� Path$ 
Categories���5+   "   �� 5,   &   $ CategoryName�6.   5.      5/      51        52      $ Статус��6)   $	 * 69    53      �� 54      .R�55      ��  6(   �� $ Statuses���56   "   �� 57   &   $ 
StatusName�6.   59      5:      5<      5>      5?      5@      