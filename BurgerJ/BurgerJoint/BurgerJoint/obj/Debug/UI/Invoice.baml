   M S B A M L   `   `   `  ����F  BBurgerJoint, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BurgerJoint.UIBurgerJoint.UI  5   	       BurgerJoint.UI.Invoice   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:BurgerJoint.UI     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	        � WindowStartupLocation$  CenterScreen=�5       � Title$ Invoice��5   	   $	��800��6   $	��550��6&   
�������.��5
      �� .��5   
   � $	��800��6   $	��500��6   .+�5      �� $��Right=�6   $��10q�61   $	��Top=�6>   .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=null]]   Kind$ Printer=�6*   $��27��69   $��27��6E   5      � 5      -   5         �Name$ print��5       � RowDefinitions 5      �� 5      $
��58.4 �6$   �� 5      $��525.6 �6$   �� 5      $	��200 �6$   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   $��10,25,10,4.2q�6Q   $��0��6g   $��48��6t   .+�5      �� $��80q�6    67   �� 5      $��INVOICE��6    $��Center=�6/   ���	#FFFF9559$��Hobo Std)�6a   ���	#FF510101$��35(�6�   $
��Bold"�6�   5      �� 5      $��1��6   $��Stretch=�6*   $��20,19.8,20,172.6q�6H   .+�5      � $��Stretch=�6    � ColumnDefinitions 5      �� 5      $	��31* �6/   �� 5      $	��15* �6/   .+�5       �� -   5         ��Name$ Payment��5    %   $��0��66   $��10,10,0,9.8q�6F   $
��Left=�6[   $	��299��6v   .+�5!      �� $��Order��6(   $��20(�65   $��5q�6C   $
��Bold"�6N   �� 5"      $ 
Horizontal=�6)   .+�5#   "   �� $��Date Issued:��6,   $��20(�6@   $��5q�6N   �� 5$   "   -   5         ��Name$ displayDate��5$   ,   $�� ��6A   $��20(�6I   $��5q�6W   $��DemiBold"�6b   5%      5'      5)      � 5+      $��0,0,0,5q�6    5,      �� 5-      $��3* �6/   �� 5.      $��1* �6/   �� 5/      $��1* �6/   �� 50      $��1* �6/    54      �� 55      $��1* �6,   �� 56      $	��10* �6,   .+�58      �� $
��Bold"�6    .��62   ITEMS69   �� 59      $��2��6    $
��Bold"�60   .��6C   
QUANTITY6M   �� 5:      $��1��6    $
��Bold"�60   .��6C   
ITEM PRICE6O   �� 5;      $��3��6    $
��Bold"�60   .��6C   	SUB TOTAL6N   �� 5<      -   5        $��displayItemName��5<   X   
������ $��1��6>   $��10q�6L   6q   �� 5=      -   5        $��displayUnitPrice��5=   f   
������ $��1��6=   $��1��6M   $��10q�6Z   6�   �� 5>      -   5        $��displayQuntity��5>   g   
������ $��2��6=   $��1��6M   $��10q�6[   6   �� 5?      -   5        $��displaySubTotal��5?   f   
������ $��3��6=   $��1��6M   $��10q�6Z   6   5@      5B      �� 5D      $��1��6   $��20,404.8,20,92.4q�6*   $��2��6D   .+�5E      � $��
10 20 10 0q�6    5F      �� 5G      $��1* �6/   �� 5H      $��1* �6/   �� 5I      $��1* �6/   .+�5M      �� $��	TOTAL DUE��6$   $��3��65   $��20(�6E   $��
ExtraLight"�6S   $��Right=�6k   5N      �� 5O      
���   �$��1��6-   $��5q�68   	 J� Opacity$		 0.5Q�6C   � 5P      $��10q�6    5Q      �� 5R      $��1* �6/   �� 5S      $��1* �6/   �� 5T      $��1* �6/   .+�5W      �� $��1��6%   5Y      �� 5Z      $��2��6%   .+�5[      �� -   5        $��displayTotal��5[   (   $��00.00��6=   $��25(�6J   $��5q�6X   $��Right=�6c   ���	#FF62013C$
��Bold"�6�   5\      5]      �� 5^      
���   �$��1��6-   $��5q�68   $		 0.5Q�6C   � 5`      $
��0 20q�6   $��Stretch=�6)   .+�5a      �� $ 
Horizontal=�6%   .+�5b        $ Heart=�66   ���	#FF62013C$��20��6Z   $��20��6e   $��5q�6q   $��Center=�6|   �� 5c      $��
Thank you!��6(   $��Center=�6:   $��20(�6U   $��5q�6c   $��Light"�6n   5d      �� 5e      $ 
Horizontal=�6%   $��Right=�6>   $��Bottom=�6Z   .+�5f      �� $��Sourcode@email.com��6(   $��Center=�6B   $��10(�6]   $��5q�6k   $��Light"�6v   �� 5g      $��
0323229535��6(   $��Center=�6:   $��10(�6U   $��5q�6c   $��Light"�6n   �� 5h      $��Sourcode.com��6(   $��Center=�6<   $��10(�6W   $��5q�6e   $��Light"�6p   5i      5j      5k      5l      5m      5n      5o      