   M S B A M L   `   `   `  ����H  DRoutingAndBom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:RoutingAndBomRoutingAndBom  5   	   T PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	       RoutingAndBom.RoutingInfo   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:RoutingAndBom     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  RoutingInfo��5	   	   $	��500��6   $	��700��6*    � WindowStartupLocation$ CenterScreen=�5
   	   $��0q�5   	   (  "MahApps.Metro.Controls.MetroWindow   	GlowBrush
 �   � � 
ResizeMode$ CanResizeWithGrip=�5   	      WindowTransitionsEnabled .  .��5      � -   5        $��Routing_Info_Grid��5       � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��7* �6   6*   �� 5      $��* �6   6)   .+�5   
   �� -   5        $��Routing_Info_Title��5   A   $��0 0 0 1q�6   ���#32a2da._�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   63   �� 5      $��* �6'   63   �� 5      $��* �6'   63   .+�5       ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   $��Center=�6S   .+�5!      �� .��6   指导书编号6#   �� 5"      -   5        $��routing_info_nr��5"   -   $	��150��6   6F   5#      �� 5%      $��1��6   $ 
Horizontal=�6-   $��Center=�6F   $��Center=�6c   .+�5&      �� .��6   	零件号6!   �� 5'      $	��150��6   6/   5(      �� 5*      $��2��6   $ 
Horizontal=�6-   $��Center=�6F   $��Center=�6c   .+�5+      �� .��6   	工作台6!   �� 5,      -   5        $��WorkStationCB��5,      $	��150��64   6B   5-      5.      5/      � 51   
   $��1��6    52      �� 53      $��* �6#   6/   �� 54      $��* �6#   6/   �� 55      $��2* �6#   60   .+�57      �� $��Center=�6   $��20(�6/   $��10 0 0 0q�6=   .��6O   RoutingList6\   �� 58      $��1��6   $	��200��6&   $	��150��65   $��Center=�6D   6a   � 59      $��2��6    5:      �� 5;      $��* �6'   63   �� 5<      $��2* �6'   64   .+�5?      �� -   5        $��
NewRouting��5?   0   $��80��6   $��30��6$   $��Center=�6B   $��Center=�6]   .��5@      �� $��15��6    $��15��6+   
��� � � J� OpacityMask 5A      !� 5B      	 j� Stretch$
	 Fill=�6*      
appbar_add
 !� Visual#
 �   69   6a   5D      5E      � 5G      $��1��6   .+�5H      (  "MahApps.Metro.Controls.SplitButton  -   5        $��TemplateSplit��5H   +   $��30��5I   +   $	��200��5J   +   $��Center=�5K   +   $
��Left=�5L   +    �� DisplayMemberPath$ content��5M   +      SelectedIndex$ 0��5N   +   5O      5P      5Q      5R      � 5T   
   $��2��6   .+�5U      �� $��2q�6   
�����F� �� CornerRadius$ 5��6A   $��
10 0 10 10q�6R   ._�5V      &   System.Windows.Controls.DataGrid  -   5        $��routing_list_data_grid��5V         HeadersVisibility$ Column=�69      AutoGenerateColumns .     CanUserAddRows .     CanUserResizeColumns .     
IsReadOnly .    Columns 5W      0  *System.Windows.Controls.DataGridTextColumn  5X      ,  &System.Windows.Controls.DataGridColumn   Header$ 序号��6.      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6:   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *Nr+6]     5Y      $ 制造程序说明��6-   $ 6* 6=    6H   �� *ProductName+6j   4  .System.Windows.Controls.DataGridTemplateColumn  5[      $ 操作��62   $ 3* 6>      HeaderStyle 5\      �� 5]   "    �� 
TargetType=	  7System.Windows.Controls.Primitives.DataGridColumnHeader" 	 6(   .�5^   &   ��  �� Property � �� �� Value$ Center=�6S   6d   5_   #      CellTemplate 5a      �� 5b   "   .R�5c   &   �  5d   *   �� 5e   .   $��* �6?   6K   �� 5f   .   $��* �6?   6K   �� 5g   .   $��* �6?   6K   .+�5j   *   �� $��ShowRouting��6H   $��40��61   $��30��6<   $��Center=�6[   $��Center=�6v   
 � Tag 6�   �� *Nr+.��5k   .   �� $��15��68   $��15��6C   
��� � � 5l   2   !� 5m   6   $
	 Fill=�6B     
appbar_eye#
 �  6Q   6y   5o   /   5p   +   �� 5r   *   $��EditRouting��6X   $��1��61   $��40��6A   $��30��6L   $��Center=�6k   $��Center=�6�   $��10 0 0 0q�6�    6�   �� *Nr+.��5s   .   �� $��15��68   $��15��6C   
���� �� 5t   2   !� 5u   6   $
	 Fill=�6B     appbar_edit_box#
 �  6Q   6~   5w   /   5x   +   �� 5z   *   $��DeleteRouting��6X   $��2��61   $��40��6A   $��30��6L   $��Center=�6m   $��Center=�6�   $��10 0 0 0q�6�    6�   �� *Nr+.��5{   .   �� $��15��68   $��15��6C   
���  �� 5|   2   !� 5}   6   $
	 Fill=�6B     appbar_axis_x_letter#
 �  6Q   6�   5   /   5�   +   5�   '   5�   #   5�      5�      5�      5�      � 5�   
   $��3��6    5�      �� 5�      $��* �6#   6/   �� 5�      $��* �6#   6/   �� 5�      $��* �6#   6/   .+�5�      �� $��1��6   $	��200��6%   $��60��64   $��5q�6C   .��6N   Create6V   5�      5�      5�      