   M S B A M L   `   `   `  ����@  <hotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:hotel.Pageshotel.Pages  5      "    hotel.Pages.PageRoomsClients   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:hotel.Pages     5        N� Title$  PageRoomsClients��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      .+�5   
   o� $��0��6   .@�5      m� -   5        $��menuAdd��5      $��Добавить��6&   68   m� 5      -   5        $��
menuUpdate��5      $��Обновить��6)   6;   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgrRoomsClients��5         AutoGenerateColumns .     
IsReadOnly . $��1��5         Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Комната��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6:      CellTemplate 5      �� 5      .R�5      ��  � DataContext 6(   �� 	 �� Path$	 Rooms���5   "   �� 5   &   $	 
RoomNumber�6.   5      5      5!        5"      $ Клиент��6)   $ * 69    5#      �� 5$      .R�5%      ��  6(   �� $	 Clients���5&   "   �� 5'   &   $	 
ClientName�6.   5)      5*      5,      0  *System.Windows.Controls.DataGridTextColumn  5-      $ 
Въезд��6%   $ * 64   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5.   %   �� *
MoveInDate+ �� StringFormat$ d��  5/      $ 
Выезд��6%   $ * 64   
 50   %   �� *MoveOutDate+$ d��52      53      54      