   M S B A M L   `   `   `  ����F  BBurgerJoint, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BurgerJoint.UIBurgerJoint.UI  5   	       BurgerJoint.UI.Dashboard   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:BurgerJoint.UI     5   	     � Title$  	Dashboard��5   	   $	��800��6   $
��1400��6(    � WindowStartupLocation$ CenterScreen=�65    � 
ResizeMode$ CanResizeWithGrip=�6Z   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��100 �6   �� 5      $��1300* �6   .+�5   
   �� 
�������$��0��6(   .+�5      A� $��90��6   $��0,40,0,0q�6"   $��90��64   ��5      �� 5       �� ImageSource$ /Image/logo.png��6!   5      �� 5      -   5         ��Name$	 add��5      $��50��6"   $��10,130,10,30q�6-   $��50��6C   
������ ��5      �� 5      $ /Image/add.png��6!   5      �� 5      -   5        $
 updt��5      $��10,30,10,30q�6#   $��50��68   $��50��6C   
������ ��5      �� 5      $ /Image/menu.png��6!   5      �� 5      -   5        $	 rpt��5      $��10,30,10,30q�6"   $��50��67   $��50��6B   
������ ��5      �� 5       $ /Image/report.png��6!   5"      �� 5#      -   5        $
 home��5#      $��10,120,10,30q�6#   $��50��69   $��50��6D   
������ ��5$      �� 5%      $ /Image/backtohome.png��6!   5'      5(       � 5)   
   -   5        $��
adminFrame��5)      $��1��6"     � Source$ Updatemenu.xaml?�62     � NavigationUIVisibility$ Hidden=�6K   6m   5*      5+      