   M S B A M L   `   `   `  ����?  ;Task, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Task.View	Task.View  5   	       Task.View.ShowTask   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Task.View     5   	     � Title$  ShowTask��5   	   $	��450��6   $	��800��6'   .��5	      �� $��Disabled=�6   $
��Auto=�6<   .��5
   
   �� .+�5      �� ���#AAA$��0 0 0 1q�6(   ._�5      ��  � DataContext 6   �� *TaskViewModel.Task+.+�5      �� -   5        $��Title��5      $��10,10,10,10q�6+   $��48��6@   $	��Top=�6L    �� TextAlignment$ Center=�6d   $��20(�6{   $��Center=�6�   ��6�   ��  �� Path$ title��� 5      -   5        $��Description��5      $��
10,10,10,0q�61   $	��200��6E    �� TextWrapping$
 Wrap=�6R    �� AcceptsReturn$
 True��6f   " �� VerticalScrollBarVisibility$ Visible=�6{   ��6�   �� $ description�]� 5      $��
10,10,10,0q�6    .+�5      �� 2  ,System.Windows.Markup.XmlAttributeProperties  XmlSpace preserve69   $��Right=�	Status : 6`   �� 5      $��Right=�6$   ��6@   �� $ status��� 5      -   5        $��Status��5   K   $��Right=�6#   $	��100��6?   .@�5      �� .��6+   	Pending64   �� 5      .��6+   In Progress68   �� 5      .��6+   
Finished65   5      5      ]� 5      $��	0,10,0,10q�6    .+�5      �� -   5        ���#fa1e22$��0q�5   6   $��32��6J   $��70��6V   $��10,0,0,0q�6a   $
��Left=�6s    � Cursor$
 Hand��6�   .��6�   	Supprimer6�   �� 5      -   5        ���#2e82db$��0q�5   6   $��32��6J   $��70��6V   $��0,0,10,0q�6a   $��Right=�6s   $
 Hand��6�   .��6�   Enregistrer6�   5      5      5      �� 5      .+�5      �� $��20(�6   $��Center=�6&   .��6C   Commentaires6Q   �� 5       $��0,10,0,0q�6h    6   �� *CommentListViewModel+��6G   �� *
Comments+��5!      �� 5"      .R�5#      �� 5$      ��5&      �� 5'      	 �� 
TargetType"	 ��6    .�5(      �� 
 �� Property
 � �� �� Value$ Stretch=�6K   �� 5)      
 �@�FocusVisualStyle 6A   Z� �� 5*      
 � |�$ False��6:   5+      ��5-      �� 5.      .R�5/      �� ���#AAA$��0 0 0 1q�68   ._�50   "   � $��5q�6'    � ColumnDefinitions 51   &   �� 52   *   $��* �6;   �� 53   *   $
��auto �6;    � RowDefinitions 56   &   �� 57   *   $
��auto �68   .+�5:   &   �� $��0��61   $��0��6>   -  'System.Windows.Input.KeyboardNavigation   TabNavigation$
 None=�6N   .+�5;   *   �� $
��Wrap=�64   ��6H   �� $
 text�]� 5<   *   .+�5=   .   ��  �� Orientation$ 
Horizontal=�69   $��Bottom=�6R   $
��Left=�6m   $��0,10,0,0q�6�   .+�5>   2   �� $��10(�6<   $��
Created : ��6J   �� 5?   2   $��10(�6<   ��6J   �� $ created�5@   /   �� 5A   .   -   5        $��0q�5A   5   $
 Hand��6I   $��Right=�6W   
������ $��32��6�   $��32��6�   .��5B   2   �� $��/src/img/trash.png��68   $��Stretch=�6T   $��Stretch=�6r   5C   /   5D   +   5E   '   5F   #   5G      5H      5J      �� 5K      -   5        $��
NewComment��5K      $��30��6,   $	��200��6;   $��
10,10,10,0q�6K   $
 Wrap=�6_   $
 True��6s   $ Visible=�6�   �� 5L      -   5        ���#2e82db$��0q�5L   .   $��32��6B   $��60��6N   $��
0,10,10,10q�6Y   $��Right=�6m   $
 Hand��6�   .��6�   	Ajouter6�   5M      5N      5O      5P      