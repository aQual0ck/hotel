   M S B A M L   `   `   `  ����@  <hotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:hotel.Pageshotel.Pages  5      3clr-namespace:hotel.AuxClasseshotel.AuxClasses  5          hotel.Pages.PageUsers   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:hotel.Pages     5      2classesclr-namespace:hotel.AuxClasses     5        N� Title$  	PageUsers��5
       � 	Resources 5      $  hotel.AuxClasses.BoolConverter   BoolConverter��%   &	          5   
   6    5      .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��40 �6   �� 5      .+�5   
   o� $��0��6   .@�5      m� -   5        $��menuAdd��5      $��Добавить��6&   68   m� 5      -   5        $��
menuUpdate��5      $��Обновить��6)   6;   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5      �� -   5        $��	txbSearch��5      $	��200��6'   $��25��63   $
��5, 0q�6?   5      �� 5      -   5        $��cmbRole��5      $	��200��6&   $��25��62   $
��5, 0q�6>   5      �� 5      $ Vertical=�6   $
��0, 5q�60   .+�5      �� $ 
Horizontal=�6   .+�5       	� -   5        $��rbAllRegistered��5    9    	� 	GroupName$ 
Registered��6"    d� 	IsChecked$
 TrueY�5!   D   $��Все��5"   "   	� 5#      -   5        $��rbOnlyRegistered��5#   9   $ 
Registered��6"   $7��1Только зарегистрированные��5%   "   	� 5&      -   5        $��rbOnlyNotRegistered��5&   9   $ 
Registered��6"   $<��6Только не зарегистрированные��5(   "   5)      �� 5*      $ 
Horizontal=�6   .+�5+      	� -   5        $��rbAllBlocked��5+   6   $ Blocked��6"   $
 TrueY�5,   A   $��Все��5-   "   	� 5.      -	   5        $��rbOnlyBlocked��5.   6   $ Blocked��6"   $1��+Только заблокированные��50   "   $	��177��51   "   	� 52      -
   5        $��rbOnlyNotBlocked��52   6   $ Blocked��6"   $6��0Только не заблокированные��54   "   55      56      57      &   System.Windows.Controls.DataGrid  58   
   -   5        $��dgrUsers��58         AutoGenerateColumns .     
IsReadOnly . $��2��59       5:      )  #System.Windows.Controls.DataGridRow �� 
TargetType��%E   '        �� 5;      "  6   .�5<      -   5        5>      5?      	   Columns	 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
Логин��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5B   %   �� *
Username+  5C      $
 Пароль��6%   $ * 65    5D   %   �� *
Password+  5E      $
 Имя��6%   $ * 62    5F   %   �� *
FullName+4  .System.Windows.Controls.DataGridTemplateColumn  5G      $
 Роль��6)   $ * 67      CellTemplate 5H      �� 5I      .R�5J      ��  � DataContext 6(   ��  �� Path$ Roles���5K   "   �� 5L   &   $ RoleName�6.   5N      5O      5Q        5R      $
 Зарег.��6%    5S   %   �� *IsRegistered+ �� 	Converter# [    5T      $
 Заблок.��6%    5U   %   �� *	IsBlocked+# [    5V      $.
 (Дата последнего входа��6%   $ * 6D    5W   %   �� *LastLoginDate+ �� StringFormat$ d��5Y      5Z      5[      