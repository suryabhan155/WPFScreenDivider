   M S B A M L   `   `   `  ����H  DScreenDivider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowState$ 	Maximized=�6L   .��5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $��30 �6    .+�5   
   �� -   5        $��
DataBorder��5      $��0��6#   $��1��60   
����  �$��1,2,2,2q�5       �� Padding$ 2q�5   	   ._�5      �� -   5        $��RVideoListView��5      $��0��6-   $��Stretch=�6`   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�   $��Disabled=�6�    �� SelectionMode$ Single=�6�   $��Disabled=�5   (   $��1q�6^   $��18(�6r   ��5   :   �� *RemoteVideoes+��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 �����67   �� 5       � �� 5      �� 5   "   	 �� 
TargetType"	 ��62   .R�5   &   �� $��RVideoBr��6-   -   5        
���   �$��2q�5!   =   ��5   =   �� *width+
 �� UpdateSourceTrigger$
 PropertyChanged=� �� Mode$ TwoWay=���5   =   �� *height+$
 PropertyChanged=�$ TwoWay=�y�5   =   �� *
Visibility+$
 PropertyChanged=�$ TwoWay=�
 � Tag 5    <   �� *RemoteVideoId+._�5"   *   �� 5#   '    �� Triggers 5$   &   ]� 5%   *    ]� 
Conditions 5&   .   �� 5'   2    �� Property �@J�IsMouseOver �� Value . 6S   ./�5)   .   ��  �� 
TargetName$ RVideoBr��6L    � ��
 �����6b   �� 5*   .    � ��
 �����6K   �� 5+   .    �@�Cursor$
 Hand��6G   5,   +   5.   #   50      51      ��54      �� 55      .R�56      �  � Orientation$ 
Horizontal=�6$   ��6=   ��  �� ElementName$ 
DataBorder�� �� Path$ ActualWidth�6z   57      ��5:      �� 5;      .R�5<      � .+�5=      �� $
��Fill=�5>   4   $��Center=�6C   $��Center=�6`   ��5=   $   �� *Image+$
 PropertyChanged=�$ TwoWay=� 5?   5   �� *RemoteVideoId+�� 5@      
������� �� Padding$ 1q�6Z   
���   �$��Center=�5A   K   $��Bottom=�6h   ��5@   (   �� *RemoteVideoId+5A   h   5B      5C      5F      5G      �� 5I   
   $��1��6   .+�5J      �  � ColumnDefinitions 5K      �� 5L      $��1* �6'   �� 5M      $��1* �6'   .+�5P      �� -   5         ��Name$	 xyz��5P      $��0��6"   
��� ���$	��Add��6X   $��30��6f   $��Stretch=�5Q      $��Bottom=�6/   $��20(�6J   �� 5R      -   5        $ delete��5R      $��1��6%   
���  ��$��Delete��6\   $��30��6m   $��Stretch=�5S      $��Bottom=�6/   $��20(�6J   5T      5U      5W      5Y      