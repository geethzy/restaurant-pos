   M S B A M L   `   `   `  ����F  BBurgerJoint, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BurgerJoint.UIBurgerJoint.UI  5          BurgerJoint.UI.Welcome   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:BurgerJoint.UI     5      $	��640��5      $
��1400��6     N� 
Background
  ����� N� Title$ Welcome��5	       � 	Resources 5       �� 
TargetType   lab �� Property �� Value  
roundlabel �� 
TargetType��%  &	        &	     �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$ 50��6'   �� 5       � ��
 �����6,   �� 5       � ��$ 5q�60   �� 5       � ��$ 20(�6)   �� 5       � ��$ Ink Free)�6+   5      �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      
roundlabel��" ��6:   .R�5      � .+�5      A� #��z��6&   #��z��6J   �� 5      $��Center=�6/   $��Center=�6L   5      5      5      5       5!      .��5$   
   � $��3��6    � RowDefinitions 5%      �� 5&      $��	 0.00001* �6    �� 5'      $�� 0.4* �6    �� 5(      $�� 0.5* �6     � ColumnDefinitions 5*      �� 5+      $�� 0.3* �6#   �� 5,      $�� 0.3* �6#   �� 5-      $�� 0.4* �6#   .+�5/      �� $��1��6   $��3��6"   ��50      �� 51      	 �� ImageSource$	 /Image/homebg.jpg��6!   
 �� Opacity$	
 0.2Q�6A   6Q   .+�53      �� $��1��6   $��2��6%   $$��Char-grilled and flavor-filled��69   $��Light"�6b   $��15(�6u    �� Left$	 359��6�   
 �� Top$	 115��6�   $��28��6�   $	��238��6�    J� RenderTransformOrigin$ 0.909,2.406&�6�   $��Italic$�6�   $��MingLiU-ExtB)�6�   z�54      V� 55      .~�56      �� �� 57      �� 58       �� Angle$ -0.043Q�6.   T� 59       T� X$ 3.106Q�61    T� Y$ -4.169Q�6;   5:      5<      �� 5=      $��1��6   $��2��6%   
�������
���**��$��5q�6d   $��WELCOME TO BURGER JOINT��6y   
���   �$��	ExtraBold"�6�   $��35(�6�   $ 27��6�   $ 33��6�   $	��572��6�   $��75��6   $��Segoe Print)�6  6(  �� 5>      $��1��6   $��2��6*   $	 440��6>   $	 170��6P   $	��562��6a   $��92��6m   $��28(�6y   $��DemiBold"�6�   �� 6�   $R�L                                            it's burger o'clock             ��6�   �� 6�   �� 6  $>�8to help you fuel up whatever your day holds             ��6	  �� 6K  6X  �� 5?      $��/Image/home1.png��6   $	 879��62   $
 -114��6D   $	��463��6V   $	��694��6c   $ 0.5,0.5&�6o   z�5@      V� 5A      .~�5B      �� �� 5C      �� 5D      $ -11.892Q�6.   T� 5E      5F      5H      5I      �� 5J      $��0��6   $��2��6$   $��/Image/fallenburg.png��62   $��218,92,37,33q�6Q   �� 5K      -   5        $��special��5K   �   #��[ 6   
���   �$��3q�6L   $��0��6`   $��19(�6p   $��2��6~   
���`���$��Burger Joint SPECIAL��6�   $��6,32,164,248q�6�   
���   �$��SemiBold"�6�   $��Comic Sans MS)�6  $ 0.239,1&�6,  z�5M      V� 5N      .~�5O      �� �� 5P      �� 5Q      $ -9.339Q�6*   T� 5R      5S       � Triggers 5U      :� 5V       :� RoutedEvent$ Label.Loaded��6#   .[�5W      �� .��5X      �� .��5Y   "   W�  �� 
TargetName$ special��62    �� TargetProperty$ Opacity�6R    W� From$	 0.0X�6v   	 W� To$	 1.0X�6�    g� AutoReverse .  g� RepeatBehavior$ Forever��6�   5Z      5[      5\      5^      �� 5`       �� Padding$ 8,10,8,8q�6   
���   �$
��Left=�6>   $��
10,103,0,0q�6Y   $��2��6m   $��0��6z   $
��Wrap=�6�   $	��Top=�6�   $	��204��6�   $��14(�6�   $	��203��6�   $ -0.18,1.422&�6�   ��5a      �� 5b       �� 
StartPoint$	 0,0&�6*    �� EndPoint$	 1,1&�6;   .��5c      �  � Color$ Beige��6'    � Offset$
 0.05Q�65   � 5d      $ 
WhiteSmoke��6'   $
 0.10Q�6:   � 5e      $ Beige��6'   $
 0.15Q�65   � 5f      $ 
WhiteSmoke��6'   $
 0.20Q�6:   � 5g      $ Beige��6'   $
 0.25Q�65   � 5h      $ 
WhiteSmoke��6'   $
 0.30Q�6:   � 5i      $ Beige��6'   $
 0.35Q�66   � 5j      $ 
WhiteSmoke��6'   $
 0.40Q�6:   � 5k      $ Beige��6'   $
 0.45Q�65   � 5l      $ 
WhiteSmoke��6'   $
 0.50Q�6:   � 5m      $ Beige��6'   $
 0.55Q�66   � 5n      $ 
WhiteSmoke��6'   $
 0.60Q�6:   � 5o      $ Beige��6'   $
 0.65Q�65   � 5p      $ 
WhiteSmoke��6'   $
 0.70Q�6:   � 5q      $ Beige��6'   $
 0.75Q�65   � 5r      $ 
WhiteSmoke��6'   $
 0.80Q�6:   � 5s      $ Beige��6'   $
 0.85Q�66   � 5t      $ 
WhiteSmoke��6'   $
 0.90Q�6:   � 5u      $ Beige��6'   $
 0.95Q�65   � 5v      $ 
WhiteSmoke��6'   $
 1.00Q�6:   5x      �� 5y   )   $��
ExtraBlack"�6-   $��15(�6E   $��Ink Free)�6S   $�FALLEN BURGER TOWER��6i   �� 6�   �� 6�   �� 6�   �� 6�   $5�/A tower of burger made with grilled beef patty,��6�   �� 6�   �� 6�   $�tomatoes and cheese has ��6�   �� 6  �� 6  $7�1fallen to a pit of crisp golden fries and blended��6#  �� 6^  �� 6j  $�with our very own ��6n  �� 6�  �� 6�  $�magical sauce...��6�  6�  �� 5z      $��2��6   $��2��6!   #��[  61   $��Stop, eat and go��6N   $��127,75,262,229q�6i   $
��Auto��6�   $
��Auto��6�   �� 5{      $��2��6   $��2��6!   #��[  61   $(��"Your place or our place? We cater!��6N   $��127,158,113,144q�6{   $
��Auto��6�   $ 0.5,0.8&�6�   �� 5|      $��2��6   $��2��6!   #��[  61   $��We deliver for FREE!!!��6N   $��127,234,220,69q�6o   $
��Auto��6�   $ 
0.496,1.66&�6�   $
��Auto��6�   �� 5}      $ 8,8,8,8q�6   $��2��6*   $��10,35,480,31q�67   $��20(�6M   $��1��6[   $��Segoe Script)�6k   $ 
0.517,0.71&�6�   $��2��6�   �� 6�   $��29(�6�   $%�a little bit about our burgers,��6�   �� 6�   �� 6  $-�'       every grilled burger that leaves��6  �� 69  �� 6E  $-�'     our kitchen is made from a unique ��6I  �� 6z  �� 6�  $-�'      blend of juicy meat patty freshly��6�  �� 6�  �� 6�  $0�*  baked breads and organic ingredients... ��6�  �� 6�  �� 6  $1�+ variety of  flavours loaded fresh burgers ��6  �� 6D  �� 6P  $'�!            will make your day...��6T  �� 6  6�  5~      5      