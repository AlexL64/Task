   M S B A M L   `   `   `  ���� ?  ;Task, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TaskTask      Task.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $localclr-namespace:Task       � Title$  
MainWindow��$	��450��$	��800��.��� .+�� $��64��$��Stretch=�$	��Top=�.+��� -   $��AddTaskButton�����#FFF$��0q�$��32��$��32��$��Center=�$
��Left=�$��16q� � Cursor$
 Hand��.���� $��/src/img/add.png��$��Stretch=�$��Stretch=��� $ �� IsSynchronizedWithCurrentItem$
 TrueY�-  'System.Windows.Input.KeyboardNavigation   TabNavigation$ Continue=�$��1�� � DataContext �� *TaskListViewModel+���� *Tasks+����  �� 
TargetType" ��.���  �� Property � �� �� Value$ Stretch=���  �@�FocusVisualStyle Z� ��  � |�$ False������ .R�� $��5q� � ColumnDefinitions �� $��* ��� $
��auto �	 � RowDefinitions	 �� $
��auto �.+��� $��0��$��0��$
 None=�.+��� $��18(����� 
 �� Path$
 Title��� ���� $
 Description���  �� Orientation$ 
Horizontal=�$��Bottom=�.+��� $��Price : ���� ���� $
 Created��� $	��€��