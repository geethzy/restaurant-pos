   M S B A M L   `   `   `  ����F  BBurgerJoint, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BurgerJoint.UIBurgerJoint.UI  5          BurgerJoint.UI.Report   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:BurgerJoint.UI     5      $
��1000��5      $
��1600��6     N� 
Background  �#303841 N� Title$ Report��5	       � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /Styles/Admin.xaml?�6%   %    5      .��5      � .+�5   
   �� -   5        $��Tabs1��5       �� TabStripPlacement$	 Top=�6"   ���#303841���#D65A31$��232,46,264,516q�6e   .@�5      �� $��Category��6    �� 
IsSelected . $	��250��6:   ���#FFD369���#D65A31$
��Left=�6q   $��0,-2,0,0q�6�   .��5      � .+�5      �� -   5         ��Name$ selectCatgry��5       �� Left$	 351��65   
	 �� Top$		 113��6G   $	��250��6X   $��50��6d   $��94,10,754,326q�6�   .@�5      �� .��6'   Burger6/   �� 5      .��6'   
Beverage61   �� 5      .��6'   Sides6.   5      �� 5      -   5        
 ��Name$
 	searchBtn��5         AdminBtn#��[  60   $��Search��6R   $
 1164��6c   $		 146��6v   $��694,10,254,326q�6�   6�   �� 5      -   5        $
 clrBtn��5      #��[  6-   $��Clear��6O   $
 1398��6_   $		 146��6r   $��903,10,45,326q�6�   5      5       �� 5*      $
��item��6   ���#FFD369���#D65A31$	��100q�6O   .��5+      �� -   5         ��Name$ txtName��5+      $	��250��6+   $	 741��67    �� TextWrapping$
 Wrap=�6I   $		 113��6]   $��508,36,340,321q�6�   5,      5-      �� 5/   
   .+�50      ��  �� CornerRadius$ 40��6   ���#3A4750$��Bottom=�51      $��Center=�6,   $
��1600��52      $	��812��6   $		 188��6+   ._�53      � $��10,10,10,10q�6   .+�54      &   System.Windows.Controls.DataGrid  -   5          Name$ 
reportGrid��54      $��0��63   $��15(�6C      AutoGenerateColumns .     AlternatingRowBackground �#393E46 �� AlternationCount$ 2��55   <   $��35,37,40,43q�6Q      
IsReadOnly .  57      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value)  #System.Windows.Controls.DataGridRow��%�  '        '  �     '�� 0    �� 58      "  6$   .�59   "   ��  � ��
 �   �6?   �� 5:   "    � �� �#D65A316?   �� 5;   "    � ��$ 50��6;   �� 5<   "    � ��$ 25(�6=   5=      �� 5>      "  6$   .�5?   "   ��  � �� �#3A47506?   �� 5@   "    � ��
 �����6?   5A      �� 5B      " ��6$   .�5C   "   ��  � ��
 �  ��6?   5D      5E         Columns 5G      4  .System.Windows.Controls.DataGridTemplateColumn  5H      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 65      CellTemplate 5I   "   �� 5J   &   .R�5K   *   �� ��60   �� *	ItemPhoto+5L   '   5N      0  *System.Windows.Controls.DataGridTextColumn  5O         Header$
 Name��6N   $	 200 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
ItemName+   ElementStyle 5P   "   �� 5Q   &   .�5R   *   ��  � ��$
 Wrap=�6S   �� 5S   *    �@��TextAlignment$ Center=�6T   �� 5T   *    � ��$ Center=�6X   5U   '   5W        5X      $ Category��6N   $	 130 6`    61   �� *
Category+ 5Y   "   �� 5Z   &   .�5[   *   ��  � ��$
 Wrap=�6S   �� 5\   *    �@��TextAlignment$ Center=�6T   �� 5]   *    � ��$ Center=�6X   5^   '   5`        5a      $ Quantity��6N   $	 100 6`    61   �� *
Quantity+ 5b   "   �� 5c   &   .�5d   *   ��  � ��$
 Wrap=�6S   �� 5e   *    �@��TextAlignment$ Center=�6T   �� 5f   *    � ��$ Center=�6X   5g   '   5i      5k      5l      5m      �� 5n      -   5        $
 	refrshBtn��5n      #��[  6(   $��Refresh��6J   $ 40��6\   $	 61��6m   6}   5o      5p      5q      