   M S B A M L   `   `   `  ����I  EFileManagerTwo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FileManagerTwoFileManagerTwo  5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType   DrivesListboxStyle �� Property �� Value �� Orientation  DrivesItemStyle �� Triggers ]� 
Conditions �� Property �� Value ��Name	 �� Padding%    FileManagerTwo.DriveItemControl
 �� Triggers :� RoutedEvent �� 
TargetName �� TargetProperty	 �� To g� Duration   DirectoryDisplayListboxStyle  BackgroundMainBrush  FileItemStyle  ForegroundTestBrush �� Binding �� Value  ForegroundDarkBrush$   FileManagerTwo.FileItemControl�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      &localclr-namespace:FileManagerTwo  5      %�  &	        &	 P    &	     7  &	 
    7  7  �� 5      "  ��6   .�5   
   ��  � ��
 ���� 6'   �� 5   
    � ��$ 0q�6,   �� 5	   
    � ��
 �  ��6(   �� 5
   
    � ��$ Visible=�6G   �� 5   
    � ��$ Disabled=�6E   �� 5   
    � �� 5      �� 5      .R�5      �� $ 
Horizontal=�6!   5      5      5      �� 5      "  ��6    5   
   ]� 5       5      �� 5       �@��
IsSelected$
 True��66   ./�5      ��  � ��
 �� ��60   5       ]� 5"       5#      �� 5$       �@��
IsSelected$ False��66   ./�5&      ��  � ��
 ���� 60   5'      .�5,   
   ��  � �� 5-      �� 5.      .R�5/      �� $ border��6   #��z��50      #��z��51      $��1q�52      $��0q�53      $	 3q�54      ._�56         58      
 5;      :� 5=      $ 
MouseEnter��6'   .[�5>      �� .��5?   "   �� .��5@   &   �� $ border��65   $ Background.Color�5A   5    	LightPink5B   5   $ 	0:0:0:0.2D�5C   5   5E   #   5F      5G      :� 5I      $ 
MouseLeave��6'   .[�5J      �� .��5K   "   �� .��5L   &   �� $ border��65   $ Background.Color�5M   5    Transparent5N   5   $ 	0:0:0:0.2D�5O   5   5Q   #   5R      5S      5V      5X      5Z      �� 5]      "  ��6   .�5^   
   ��  � ��8   6'   �� 5_   
    � ��$ 0q�6,   �� 5`   
    � ��$ 0q�6#   �� 5a   
    � ��$	 Top=�6.   �� 5b   
    � ��$ Disabled=�6G   �� 5c   
    � ��$ Visible=�6E   5d      �� 5g      "  ��6    5j   
   ]� 5k       5l      �� 5m       �@��
IsSelected$
 True��66   ./�5p      ��  � ��
 ��ح�6/   �� 5q       � ��
 �  ��6/   5r      ]� 5t       5u      �� 5v       �@��
IsSelected$ False��66   ./�5y      ��  � ��8   6/   5z      �� 5}       6   �� *
IsHidden+ true67   .a�5~      ��  � ��8  6/   5      .�5�   
   ��  � �� 5�      �� 5�      .R�5�      �� $ border��6   #��z��5�      $��0q�5�      #��z��5�      ._�5�        5�      5�      5�      5�      5�      