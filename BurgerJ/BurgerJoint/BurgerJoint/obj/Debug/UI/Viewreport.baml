   M S B A M L   `   `   `  ����F  BBurgerJoint, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BurgerJoint.UIBurgerJoint.UI  5          BurgerJoint.UI.Viewreport   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:BurgerJoint.UI     5      $	��800��5      $
��1300��6     N� 
Background  �#303841 N� Title$ 
Viewreport��5	       � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /Styles/Admin.xaml?�6%   %    5      .��5      � .+�5   
   9� $��Search by item��6   $��25(�6+   
�������$��24,70,1028,584q�6L   .��5      � $	��118��6   .+�5      �� $��20(�6      
AdminLabel#��[  6'   $��Enter the menu item��6L   $��24,10,21,70q�6j    J� RenderTransformOrigin$ 0.5,0.5&�6   $
��Auto��6�   $
��Auto��6�   6�   �� 5      -   5         ��Name$ txtName��5      
������� �� TextWrapping$
 Wrap=�6>   $��
24,53,21,0q�6t   $ 
0.5,-0.283&�6�   $��30��6�   $	��Top=�6�   .��6�   5      5      5      9� 5   
   $��Search by category��6   $��25(�6/   
�������$��24,239,1028,348q�6P   .��5      � .+�5      �� -   5         ��Name$ selectCatgry��5      $��Right=�6b   $	��216��6~   $��0,25,10,104q�6�   .@�5      �� .��6#   Burger6+   �� 5      .��6$   
Beverage6.   �� 5       .��6#   Sides6*   5!      �� 5"      -   5        	 ��Name$	 	searchBtn��5"      $��25(�6,     AdminBtn#��[ 6:   $��Search��6\   $
��Auto��6m   $
��Auto��6�   $��74,98,66,27q�6�   5#      5$      9� 5&   
   $��Search by date��6   $��25(�6+   
�������$��24,486,1028,69q�6L   $ 
0.498,1.17&�6d   .��5'      � .+�5(      (  "System.Windows.Controls.DatePicker  -   5        
  Name$
 
selectDate��5(      $��20(�61      DisplayDate$ 
12/02/2021��5)         DisplayDateStart$ 8/1/2021X�6%      DisplayDateEnd$ 8/1/2022X�5*       �� Left$
 1067��6%   
 �� Top$ 10��5+      $��24,23,10,154q�6S   5,      5-      �� 5/   
   $��-10,14,10,-14q�6   .+�50      ��  �� CornerRadius$ 40��6   ���#3A4750$��Bottom=�51      $��Center=�6,   $	��978��52      $	��679��6   $ 33��6*   $	 292��6:   ._�53      � $��10,10,10,10q�6   .+�54      &   System.Windows.Controls.DataGrid  -   5          Name$ 
reportGrid��54      $��0��63   
������ $��15(�6\      AutoGenerateColumns .     AlternatingRowBackground �#393E46 �� AlternationCount$ 2��55   <   $��10q�6Q      
IsReadOnly .  57      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value)  #System.Windows.Controls.DataGridRow��%�  '        '  �     '�� 0    �� 58      "  6$   .�59   "   ��  � ��
 �   �6?   �� 5:   "    � �� �#D65A316?   �� 5;   "    � ��$ 50��6;   �� 5<   "    � ��$ 25(�6=   5=      �� 5>      "  6$   .�5?   "   ��  � �� �#3A47506?   �� 5@   "    � ��
 �����6?   5A      �� 5B      " ��6$   .�5C   "   ��  � ��
 �����6?   �� 5D   "    �@�ForceCursor . 6@   �� 5E   "    � ��
 �����6?   5F      5G         Columns 5I      4  .System.Windows.Controls.DataGridTemplateColumn  5J      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 65      CellTemplate 5K   "   �� 5L   &   .R�5M   *   �� ��60   �� *	ItemPhoto+5N   '   5P      0  *System.Windows.Controls.DataGridTextColumn  5Q         Header$ 	     Date��6O   $	 150 6b   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 61   �� *	orderDate+ 	  ElementStyle 5R   "   �� 5S   &   .�5T   *   ��  � ��$
 Wrap=�6S   �� 5U   *    �@��TextAlignment$ Center=�6T   �� 5V   *    � ��$ Center=�6X   5W   '   5Y        5Z      $   Name��6N   $	 200 6^    61   �� *
ItemName+ 5[   "   �� 5\   &   .�5]   *   ��  � ��$
 Wrap=�6S   �� 5^   *    �@��TextAlignment$ Center=�6T   �� 5_   *    � ��$ Center=�6X   5`   '   5b        5c      $    Category��6N   $	 133 6c    61   �� *
Category+ 5d   "   �� 5e   &   .�5f   *   ��  � ��$
 Wrap=�6S   �� 5g   *    �@��TextAlignment$ Center=�6T   �� 5h   *    � ��$ Center=�6X   5i   '   5k        5l      $ 	 Quantity��6N   $	 121 6a    61   �� *
Quantity+ 5m   "   �� 5n   &   .�5o   *   ��  � ��$
 Wrap=�6S   �� 5p   *    �@��TextAlignment$ Center=�6T   �� 5q   *    � ��$ Center=�6X   5r   '   5t        5u      $  Unit Price��6O   $	 130 6d    61   �� *	UnitPrice+ 5v   "   �� 5w   &   .�5x   *   ��  � ��$
 Wrap=�6S   �� 5y   *    �@��TextAlignment$ Center=�6T   �� 5z   *    � ��$ Center=�6X   5{   '   5}        5~      $   Sub total��61   $	 125 6c    6F   �� *
SubTotal+ 5   "   �� 5�   &   .�5�   *   ��  � ��$
 Wrap=�6S   �� 5�   *    �@��TextAlignment$ Center=�6T   �� 5�   *    � ��$ Center=�6X   5�   '   5�      5�      5�      5�      �� 5�      -   5        $	 	refrshBtn��5�      $��36��6(   
���   �$��36��6G   $	 327��6S   $ 64��6e   $ 	0.28,-0.2&�6�   ��5�      �� 5�       �� ImageSource$ /Image/refsh.png��6!   5�      5�      5�      5�      