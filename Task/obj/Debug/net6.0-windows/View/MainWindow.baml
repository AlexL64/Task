   M S B A M L   `   `   `  ����?  ;Task, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TaskTask  5   	       Task.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Task     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   � $��64��6   $��Stretch=�6   $	��Top=�69   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      �  � Color$ #8BC6EC��6#    � Offset$	 0.0Q�63   � 5      $ #9599E2��6#   $	 1.0Q�63   5      .+�5      �� -   5        
������ $��0q�5   .   $��32��6B   $��32��6N   $��Center=�6Y   $
��Left=�6t   $��16q�6�    � Cursor$
 Hand��6�   .��5      �� $��/src/img/add.png��6   $��Stretch=�62   $��Stretch=�6P   5      5      �� 5   
   $��1��6Z   $��0,64,0,0q�6g    � DataContext 6   �� *TaskListViewModel+��6<   �� *Tasks+��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � ��	 �� Value$	 Stretch=�6C   �� 5       �@�FocusVisualStyle	 69   Z� �� 5       � |�$	 False��62   5      ��5      �� 5      .R�5      �� ���#AAA$��0 0 0 1q�60   ._�5       � -   5        $��5q�5       $
 Hand��6P   
 � ColumnDefinitions
 5!      �� 5"   "   $��* �63   �� 5#   "   $
��auto �63    � RowDefinitions 5&      �� 5'   "   $
��auto �60   .+�5*      �� $��0��6)   $��0��66   -  'System.Windows.Input.KeyboardNavigation   TabNavigation$
 None=�6F   .+�5+   "   �� $��18(�6,   ��6:   ��  �� Path$ title��� 5,   "   ��6,   �� $ description�]� 5-   "   $��0,10,0,0q�6,   .+�5.   &   ��  �� Orientation$ 
Horizontal=�61   $��Bottom=�6J   $
��Left=�6e   .+�5/   *   �� $��
Created : ��64   �� 50   *   ��64   �� $ created�51   '   �� 52   &   $ 
Horizontal=�61   $��Bottom=�6J   $��Right=�6e   .+�53   *   �� $��	Status : ��64   �� 54   *   ��64   �� $ status�55   '   56   #   57      58      59      5:      5<      5=      5>      